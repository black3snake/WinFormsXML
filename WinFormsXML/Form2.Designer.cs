namespace WinFormsXML
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			btnXLST = new Button();
			btnCloseF2 = new Button();
			webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
			((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.BorderStyle = BorderStyle.FixedSingle;
			textBox1.Location = new Point(12, 12);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.ReadOnly = true;
			textBox1.ScrollBars = ScrollBars.Vertical;
			textBox1.Size = new Size(707, 554);
			textBox1.TabIndex = 0;
			textBox1.TabStop = false;
			// 
			// btnXLST
			// 
			btnXLST.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnXLST.Location = new Point(12, 593);
			btnXLST.Name = "btnXLST";
			btnXLST.Size = new Size(154, 38);
			btnXLST.TabIndex = 1;
			btnXLST.Text = "XLST преобр.";
			btnXLST.UseVisualStyleBackColor = true;
			btnXLST.Click += btnXLST_Click;
			// 
			// btnCloseF2
			// 
			btnCloseF2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnCloseF2.Location = new Point(551, 593);
			btnCloseF2.Name = "btnCloseF2";
			btnCloseF2.Size = new Size(154, 38);
			btnCloseF2.TabIndex = 2;
			btnCloseF2.Text = "Close";
			btnCloseF2.UseVisualStyleBackColor = true;
			btnCloseF2.Click += btnCloseF2_Click;
			// 
			// webView21
			// 
			webView21.AllowExternalDrop = true;
			webView21.CreationProperties = null;
			webView21.DefaultBackgroundColor = Color.White;
			webView21.Location = new Point(12, 13);
			webView21.Name = "webView21";
			webView21.Size = new Size(693, 554);
			webView21.TabIndex = 3;
			webView21.Visible = false;
			webView21.ZoomFactor = 1D;
			webView21.CoreWebView2InitializationCompleted += webView21_CoreWebView2InitializationCompleted;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(731, 643);
			Controls.Add(btnCloseF2);
			Controls.Add(btnXLST);
			Controls.Add(textBox1);
			Controls.Add(webView21);
			Name = "Form2";
			Text = "Данные XML файла";
			((System.ComponentModel.ISupportInitialize)webView21).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		public TextBox textBox1;
		private Button btnXLST;
		private Button btnCloseF2;
		public Microsoft.Web.WebView2.WinForms.WebView2 webView21;
	}
}