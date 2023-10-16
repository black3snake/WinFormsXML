namespace WinFormsXML
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			txtBox_Log = new TextBox();
			label1 = new Label();
			panel1 = new Panel();
			label2 = new Label();
			textBox1 = new TextBox();
			labelName = new Label();
			labelDol = new Label();
			labelDateR = new Label();
			labelTheme = new Label();
			labelVid = new Label();
			labelSilkaNaCard = new Label();
			labelId = new Label();
			label_Name_Result = new Label();
			labelDol_Result = new Label();
			labelDate_Result = new Label();
			labelTheme_Result = new Label();
			labelVid_Result = new Label();
			labelSilkaNaCard_Result = new Label();
			labelId_Result = new Label();
			checkBox1 = new CheckBox();
			btnClear = new Button();
			btnReadFormDB = new Button();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// txtBox_Log
			// 
			txtBox_Log.BorderStyle = BorderStyle.FixedSingle;
			txtBox_Log.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			txtBox_Log.Location = new Point(315, 367);
			txtBox_Log.Margin = new Padding(4, 3, 4, 3);
			txtBox_Log.Multiline = true;
			txtBox_Log.Name = "txtBox_Log";
			txtBox_Log.Size = new Size(608, 138);
			txtBox_Log.TabIndex = 18;
			// 
			// label1
			// 
			label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(337, 14);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(583, 24);
			label1.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.AllowDrop = true;
			panel1.BackgroundImageLayout = ImageLayout.None;
			panel1.Controls.Add(label2);
			panel1.Location = new Point(14, 105);
			panel1.Margin = new Padding(4, 3, 4, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(302, 242);
			panel1.TabIndex = 1;
			panel1.DragDrop += panel1_DragDrop;
			panel1.DragEnter += panel1_DragEnter;
			panel1.DragLeave += panel1_DragLeave;
			panel1.Paint += panel1_Paint;
			panel1.MouseClick += panel1_Click;
			// 
			// label2
			// 
			label2.Location = new Point(4, 107);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(295, 27);
			label2.TabIndex = 0;
			label2.Text = "Перетащите файл сюда";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			textBox1.BorderStyle = BorderStyle.None;
			textBox1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.Location = new Point(14, 14);
			textBox1.Margin = new Padding(4, 3, 4, 3);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.ReadOnly = true;
			textBox1.Size = new Size(302, 89);
			textBox1.TabIndex = 2;
			textBox1.TabStop = false;
			textBox1.Text = "Загрузить XML файл: бросить его на панель или ClickMouse";
			// 
			// labelName
			// 
			labelName.AutoSize = true;
			labelName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelName.Location = new Point(337, 105);
			labelName.Margin = new Padding(4, 0, 4, 0);
			labelName.Name = "labelName";
			labelName.Size = new Size(116, 16);
			labelName.TabIndex = 3;
			labelName.Text = "Имя сотрудника:";
			// 
			// labelDol
			// 
			labelDol.AutoSize = true;
			labelDol.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelDol.Location = new Point(337, 137);
			labelDol.Margin = new Padding(4, 0, 4, 0);
			labelDol.Name = "labelDol";
			labelDol.Size = new Size(81, 16);
			labelDol.TabIndex = 4;
			labelDol.Text = "Должность:";
			// 
			// labelDateR
			// 
			labelDateR.AutoSize = true;
			labelDateR.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelDateR.Location = new Point(337, 170);
			labelDateR.Margin = new Padding(4, 0, 4, 0);
			labelDateR.Name = "labelDateR";
			labelDateR.Size = new Size(129, 16);
			labelDateR.TabIndex = 5;
			labelDateR.Text = "Дата регистрации:";
			// 
			// labelTheme
			// 
			labelTheme.AutoSize = true;
			labelTheme.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelTheme.Location = new Point(337, 198);
			labelTheme.Margin = new Padding(4, 0, 4, 0);
			labelTheme.Name = "labelTheme";
			labelTheme.Size = new Size(44, 16);
			labelTheme.TabIndex = 6;
			labelTheme.Text = "Тема:";
			// 
			// labelVid
			// 
			labelVid.AutoSize = true;
			labelVid.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelVid.Location = new Point(337, 232);
			labelVid.Margin = new Padding(4, 0, 4, 0);
			labelVid.Name = "labelVid";
			labelVid.Size = new Size(35, 16);
			labelVid.TabIndex = 7;
			labelVid.Text = "Вид:";
			// 
			// labelSilkaNaCard
			// 
			labelSilkaNaCard.AutoSize = true;
			labelSilkaNaCard.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelSilkaNaCard.Location = new Point(337, 268);
			labelSilkaNaCard.Margin = new Padding(4, 0, 4, 0);
			labelSilkaNaCard.Name = "labelSilkaNaCard";
			labelSilkaNaCard.Size = new Size(141, 16);
			labelSilkaNaCard.TabIndex = 8;
			labelSilkaNaCard.Text = "Ссылка на карточку:";
			// 
			// labelId
			// 
			labelId.AutoSize = true;
			labelId.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelId.Location = new Point(337, 305);
			labelId.Margin = new Padding(4, 0, 4, 0);
			labelId.Name = "labelId";
			labelId.Size = new Size(79, 16);
			labelId.TabIndex = 9;
			labelId.Text = "ИД автора:";
			// 
			// label_Name_Result
			// 
			label_Name_Result.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label_Name_Result.Location = new Point(495, 105);
			label_Name_Result.Margin = new Padding(4, 0, 4, 0);
			label_Name_Result.Name = "label_Name_Result";
			label_Name_Result.Size = new Size(428, 18);
			label_Name_Result.TabIndex = 10;
			label_Name_Result.Text = "empty";
			// 
			// labelDol_Result
			// 
			labelDol_Result.AutoSize = true;
			labelDol_Result.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelDol_Result.Location = new Point(496, 137);
			labelDol_Result.Margin = new Padding(4, 0, 4, 0);
			labelDol_Result.Name = "labelDol_Result";
			labelDol_Result.Size = new Size(44, 16);
			labelDol_Result.TabIndex = 11;
			labelDol_Result.Text = "empty";
			// 
			// labelDate_Result
			// 
			labelDate_Result.AutoSize = true;
			labelDate_Result.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelDate_Result.Location = new Point(495, 170);
			labelDate_Result.Margin = new Padding(4, 0, 4, 0);
			labelDate_Result.Name = "labelDate_Result";
			labelDate_Result.Size = new Size(44, 16);
			labelDate_Result.TabIndex = 12;
			labelDate_Result.Text = "empty";
			// 
			// labelTheme_Result
			// 
			labelTheme_Result.AutoSize = true;
			labelTheme_Result.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelTheme_Result.Location = new Point(495, 198);
			labelTheme_Result.Margin = new Padding(4, 0, 4, 0);
			labelTheme_Result.Name = "labelTheme_Result";
			labelTheme_Result.Size = new Size(44, 16);
			labelTheme_Result.TabIndex = 13;
			labelTheme_Result.Text = "empty";
			// 
			// labelVid_Result
			// 
			labelVid_Result.AutoSize = true;
			labelVid_Result.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelVid_Result.Location = new Point(495, 232);
			labelVid_Result.Margin = new Padding(4, 0, 4, 0);
			labelVid_Result.Name = "labelVid_Result";
			labelVid_Result.Size = new Size(44, 16);
			labelVid_Result.TabIndex = 14;
			labelVid_Result.Text = "empty";
			// 
			// labelSilkaNaCard_Result
			// 
			labelSilkaNaCard_Result.AutoSize = true;
			labelSilkaNaCard_Result.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelSilkaNaCard_Result.Location = new Point(496, 268);
			labelSilkaNaCard_Result.Margin = new Padding(4, 0, 4, 0);
			labelSilkaNaCard_Result.Name = "labelSilkaNaCard_Result";
			labelSilkaNaCard_Result.Size = new Size(44, 16);
			labelSilkaNaCard_Result.TabIndex = 15;
			labelSilkaNaCard_Result.Text = "empty";
			// 
			// labelId_Result
			// 
			labelId_Result.AutoSize = true;
			labelId_Result.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelId_Result.Location = new Point(496, 305);
			labelId_Result.Margin = new Padding(4, 0, 4, 0);
			labelId_Result.Name = "labelId_Result";
			labelId_Result.Size = new Size(44, 16);
			labelId_Result.TabIndex = 16;
			labelId_Result.Text = "empty";
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			checkBox1.Location = new Point(14, 367);
			checkBox1.Margin = new Padding(4, 3, 4, 3);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(182, 20);
			checkBox1.TabIndex = 17;
			checkBox1.Text = "Save XML file to db sqlite?";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// btnClear
			// 
			btnClear.FlatStyle = FlatStyle.System;
			btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			btnClear.Location = new Point(821, 341);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(100, 23);
			btnClear.TabIndex = 19;
			btnClear.Text = "Clear_Log";
			btnClear.UseMnemonic = false;
			btnClear.UseVisualStyleBackColor = true;
			// 
			// btnReadFormDB
			// 
			btnReadFormDB.Location = new Point(14, 465);
			btnReadFormDB.Name = "btnReadFormDB";
			btnReadFormDB.Size = new Size(164, 40);
			btnReadFormDB.TabIndex = 20;
			btnReadFormDB.Text = "Прочитать последний XML из базы(XSLT)";
			btnReadFormDB.UseVisualStyleBackColor = true;
			btnReadFormDB.Click += btnReadFormDB_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(933, 519);
			Controls.Add(btnReadFormDB);
			Controls.Add(btnClear);
			Controls.Add(checkBox1);
			Controls.Add(labelId_Result);
			Controls.Add(labelSilkaNaCard_Result);
			Controls.Add(labelVid_Result);
			Controls.Add(labelTheme_Result);
			Controls.Add(labelDate_Result);
			Controls.Add(labelDol_Result);
			Controls.Add(label_Name_Result);
			Controls.Add(labelId);
			Controls.Add(labelSilkaNaCard);
			Controls.Add(labelVid);
			Controls.Add(labelTheme);
			Controls.Add(labelDateR);
			Controls.Add(labelDol);
			Controls.Add(labelName);
			Controls.Add(textBox1);
			Controls.Add(txtBox_Log);
			Controls.Add(panel1);
			Controls.Add(label1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			Name = "Form1";
			Text = "WinFormXML";
			panel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelDol;
		private System.Windows.Forms.Label labelDateR;
		private System.Windows.Forms.Label labelTheme;
		private System.Windows.Forms.Label labelVid;
		private System.Windows.Forms.Label labelSilkaNaCard;
		private System.Windows.Forms.Label labelId;
		private System.Windows.Forms.Label label_Name_Result;
		private System.Windows.Forms.Label labelDol_Result;
		private System.Windows.Forms.Label labelDate_Result;
		private System.Windows.Forms.Label labelTheme_Result;
		private System.Windows.Forms.Label labelVid_Result;
		private System.Windows.Forms.Label labelSilkaNaCard_Result;
		private System.Windows.Forms.Label labelId_Result;
		private System.Windows.Forms.CheckBox checkBox1;
		//private Button button1;
		private TextBox txtBox_Log;
		private Button btnClear;
		private Button btnReadFormDB;
	}
}