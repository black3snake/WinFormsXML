using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using WinFormsXML.DataModel;

namespace WinFormsXML
{
	public partial class Form1 : Form
	{
		internal static XmlDocument xDoc = new XmlDocument();
		public Form1()
		{
			InitializeComponent();

			btnClear.MouseClick += (s, a) => { txtBox_Log.Clear(); };
			txtBox_Log.MouseClick += (s, a) => { txtBox_Log.ScrollBars = ScrollBars.Vertical; };
		}

		#region Загрузка XML файла (получения его расположения)

		private void panel1_Click(object sender, MouseEventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.Title = "Вебери файл в форметe XML";
			fileDialog.Filter = "XML-файлы (*.xml)|*.xml";
			fileDialog.InitialDirectory = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Desktop\";

			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				if (!Path.GetExtension(fileDialog.FileName).Equals(".xml"))
				{
					label2.Text = "Данный файл не XML";
					txtBox_Log.AppendText($"Данный файл {fileDialog.FileName} не XML, Проверте!" + Environment.NewLine);
					return;
				}

				txtBox_Log.AppendText($"Данные из XML файла: {fileDialog.FileName} получены." + Environment.NewLine);
				ReadXML(fileDialog.FileName);

				if (checkBox1.Checked)
					SaveXML_Sqlite(fileDialog.FileName);
			}
		}

		private void panel1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data == null) { return; }
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				label2.Text = "Отпустите левую кнопку мыши";
				e.Effect = DragDropEffects.Copy;
			}
		}

		private void panel1_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data == null) { return; }
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
				if (!Path.GetExtension(files[0]).Equals(".xml"))
				{
					label2.Text = "Данный файл не XML";
					txtBox_Log.AppendText($"Данный файл {files[0]} не XML, Проверте!" + Environment.NewLine);
					return;
				}
				label2.Text = "Данные обработаны";
				txtBox_Log.AppendText($"Данные из XML файла: {files[0]} получены." + Environment.NewLine);
				ReadXML(files[0]);

				if (checkBox1.Checked)
					SaveXML_Sqlite(files[0]);
			}
		}

		private void panel1_DragLeave(object sender, EventArgs e)
		{
			label2.Text = "Перетащите файл сюда";
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			Pen pen = new Pen(Color.Black);
			pen.DashPattern = new float[] { 4, 4 };
			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			e.Graphics.DrawRectangle(pen, 0, 0, panel1.Width - 2, panel1.Height - 2);
		}
		#endregion Загрузка XML файла (получения его расположения)

		private void ReadXML(string path)
		{
			string? Performer = string.Empty;
			try
			{
				XmlDocument? xDoc = new XmlDocument();
				xDoc.Load(path);

				XmlNodeList? nodesMain = xDoc.SelectNodes("/Data/CardDocument/*");
				if (nodesMain?.Count > 0)
				{
					foreach (XmlNode node in nodesMain)
					{
						if (node.Name == "MainInfo")
						{
							label_Name_Result.Text = node.Attributes?.GetNamedItem("FirstName")?.Value;
							labelDate_Result.Text = node.Attributes?.GetNamedItem("RegDate")?.Value;
							labelTheme_Result.Text = node.Attributes?.GetNamedItem("Content")?.Value;
							labelSilkaNaCard_Result.Text = node.Attributes?.GetNamedItem("ReferenceList")?.Value;
							labelId_Result.Text = node.Attributes?.GetNamedItem("Author")?.Value;
						}
						else if (node.Name == "System")
						{
							labelVid_Result.Text = node.Attributes?.GetNamedItem("Kind_Name")?.Value;
						}
					}
				}
				XmlNodeList? nodesPerf = xDoc.SelectNodes("/Data/CardDocument/Performers/*");

				if (nodesPerf?.Count > 0)
				{
					foreach (XmlNode node in nodesPerf)
					{
						if (node.Name == "PerformersRow")
						{
							Performer = node.Attributes?.GetNamedItem("Performer")?.Value;
							txtBox_Log.AppendText($"/Data/CardDocument/Performers/Performer: {Performer}" + Environment.NewLine);
						}
					}
				}
				// Обратимся к человеческим данным :-)
				XmlNodeList? nodesEmRow = xDoc.SelectNodes("/Data/RefStaff/Units/UnitsRow/UnitsRow/UnitsRow/Employees/*");
				if (nodesEmRow?.Count > 0)
				{
					foreach (XmlNode node in nodesEmRow)
					{
						if (node.Name == "EmployeesRow" & Performer.Equals(node.Attributes?.GetNamedItem("ActiveEmployee")?.Value))
						{
							string? PosName = node.Attributes?.GetNamedItem("PositionName")?.Value;
							labelDol_Result.Text = PosName;
							txtBox_Log.AppendText($"Найдено соответвие номера Performer в Employees, возьмем там поле PositionName: {PosName}" + Environment.NewLine);

						}
					}
				}
			}
			catch (Exception ex)
			{
				label1.Text = "Ошибка доступа к файлу";
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void SaveXML_Sqlite(string path)
		{
			//XmlDocument xDoc = new XmlDocument();
			xDoc.Load(path);
			var ms = new MemoryStream();
			xDoc.Save(ms);
			byte[] bytes = ms.ToArray();

			DateTime dt = DateTime.Parse(labelDate_Result.Text);

			//byte[] bytes = System.Text.Encoding.UTF8.GetBytes(s);
			//string s = System.Text.Encoding.UTF8.GetString(bytes);
			Filexml fx = new Filexml { DateReg = dt, PathFileName = path, Data = bytes };

			using (DataModelContext context = new DataModelContext())
			{
				var uniq = context.Filexmls.FirstOrDefault(c => c.PathFileName == path);
				if (uniq == null)
				{
					context.Filexmls.Add(fx);
					context.SaveChanges();
					txtBox_Log.AppendText($"XML файл {path.Substring(path.LastIndexOf("\\") + 1)} сохранен в BD" + Environment.NewLine);

				}
				else
				{
					txtBox_Log.AppendText($"XML файл {path} c таким путем уже есть в базе! ( Не будем дублировать данные)" + Environment.NewLine);
				}

			}

			long countDB = 0;
			using (DataModelContext context = new DataModelContext())
			{
				var listC = context.Filexmls.ToList();
				countDB = listC.Count;
				txtBox_Log.AppendText($"Количество сохраненных XML файлов в БД: {countDB}" + Environment.NewLine);

				foreach (var item in listC)
				{
					txtBox_Log.AppendText($"id:{item.Id},  Path:{item.PathFileName},  Дата рег:{item.DateReg}" + Environment.NewLine);
				}

			}

		}

		private void btnReadFormDB_Click(object sender, EventArgs e)
		{
			//XmlDocument xDoc = new XmlDocument();
			Form2 form2 = new Form2();

			using (DataModelContext context = new DataModelContext())
			{
				try
				{
					var Idobj = context.Filexmls.Max(x => x.Id);
					var obj = context.Filexmls.Where(x => x.Id == Idobj).Select(x => x.Data).ToArray();

					byte[]? b = Array.Empty<byte>();
					foreach (byte[]? item in obj)
						b = item;

					if (b.Length > 0)
					{
						MemoryStream ms = new MemoryStream(b);
						xDoc.Load(ms);
					}
					else
					{
						form2.textBox1.AppendText("Данных для загрузки нет ..:(" + Environment.NewLine);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("В Базе данных нет записей. Загрузите XML с поставленным чекБоксом..", "Ошибка, отсутвие данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtBox_Log.AppendText($"{ex.Message}. В Базе данных нет записей. Загрузите XML с поставленным чекБоксом.." + Environment.NewLine);

					return;

				}

			}
			form2.textBox1.Text = xDoc.InnerXml.ToString();

			DialogResult result = form2.ShowDialog(this);
			if (result == DialogResult.Cancel)
				return;

		}
	}
}