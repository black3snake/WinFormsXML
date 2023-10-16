using Microsoft.Web.WebView2.Core;
using System.IO;
using System.Xml;
using System.Xml.Xsl;

namespace WinFormsXML
{
	public partial class Form2 : Form
	{
		internal static XmlDocument xDocF2 = new XmlDocument();
		static string pathXSL = @"Style.xsl";
		//static string pathHTML = @"Out.html";
		//static string pathXML = @"File.xml";
		//public string LocalPath { get; set; }
		public string pathHTML { get; set; }
		public string pathXML { get; set; }

		public Form2()
		{
			InitializeComponent();
			webView21.EnsureCoreWebView2Async();

			pathHTML = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Out.html");
			pathXML = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"File.xml");
			
		}

		private void btnCloseF2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnXLST_Click(object sender, EventArgs e)
		{
			// Преобразование
			xDocF2 = Form1.xDoc;
			if (ensure)
			{
				textBox1.Visible = false;
				webView21.Visible = true;


				#region OLd code
				//string h2 = File.ReadAllText(@"D:\REPOS2\WinFormsXML\help.html");
				//webView21.CoreWebView2.Navigate(h2);
				//webView21.CoreWebView2.Navigate("file:///D:/REPOS2/WinFormsXML/help.html");
				//webView21.CoreWebView2.Navigate("file:///D:/REPOS2/WinFormsXML/file.xml");
				//webView21.CoreWebView2.NavigateToString(h2);
				//webView21.CoreWebView2.Navigate("https://ifrgufk.ru");
				//webView21.CoreWebView2.SetVirtualHostNameToFolderMapping("demo", @"D:\REPOS2\WinFormsXML\help.html", CoreWebView2HostResourceAccessKind.DenyCors);
				//webView21.CoreWebView2.Navigate("https://demo/index.html");
				//webView21.CoreWebView2.Reload();
				#endregion

				if (!File.Exists(pathHTML))
					using (File.Create(pathHTML)) { };

				XslCompiledTransform xslt = new XslCompiledTransform();
				xslt.Load(pathXSL);

				xDocF2.Save(pathXML);
				xslt.Transform(pathXML, pathHTML);

				StreamReader sr = new StreamReader(pathHTML);
				webView21.CoreWebView2.NavigateToString(sr.ReadToEnd());
				sr.Close();

			}
		}


		bool ensure = false;
		private void webView21_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
		{
			ensure = true;
		}
	}
}
