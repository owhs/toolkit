/*
 * Created by SharpDevelop.
 * User: Oscar
 * Date: 22/11/2020
 * Time: 21:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace toolkit
{
	
	/// <summary>
	/// Description of sourcesPortable.
	/// </summary>
	public partial class browser : Form
	{
		public browser()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.FormBorderStyle = FormBorderStyle.None;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainmenu));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
		}
		
		
		/*
		 * 
			if (fileOpen.ShowDialog() == DialogResult.OK){
				string path = fileOpen.FileName;
				
			}
		 * 
		 */
		
		private bool mouseDown;
		private Point lastLocation;
		
		void TabsMouseDown(object sender, MouseEventArgs e)
		{
	        mouseDown = true;
	        lastLocation = e.Location;
		}
		void TabsMouseMove(object sender, MouseEventArgs e)
		{
	        if(mouseDown)
	        {
	            this.Location = new Point(
	                (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
	
	            this.Update();
	        }
		}
		void TabsMouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}
		void TabsMouseLeave(object sender, EventArgs e)
		{
			mouseDown = false;
		}
		
		string drive = "";
		
		void SourcesPortableLoad(object sender, EventArgs e)
		{
			string sp = Application.StartupPath+"\\config.csv";
			drive = sp.Split('\\')[0]+"\\";			
		}
		void Button1Click(object sender, EventArgs e)
		{
			mainmenu.Instance.Show();
			this.Close();
		}
				
		void Button2Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Maximized){
				this.WindowState = FormWindowState.Normal;
				panel1.Padding = new Padding(3);
			} else {
				this.WindowState = FormWindowState.Maximized;
				panel1.Padding = new Padding(0);
			}
		}
		void Label1DoubleClick(object sender, EventArgs e)
		{
			button2.PerformClick();
		}
		void WebBrowser1DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			textBox1.Text = webBrowser1.Url.AbsoluteUri;
		}
		
	}
}
