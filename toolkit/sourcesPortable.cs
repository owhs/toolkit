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
	public partial class sourcesPortable : Form
	{
		public sourcesPortable()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.FormBorderStyle = FormBorderStyle.None;
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
		string sp = "";
		
		void SourcesPortableLoad(object sender, EventArgs e)
		{
			sp = Application.StartupPath+"\\config.csv";
			drive = sp.Split('\\')[0]+"\\";
			
			fileOpen.InitialDirectory = drive + "data\\portable";
			
			//MessageBox.Show(drive + "data\\portable");
			
			StreamReader sr = new StreamReader(sp);
			textBox1.Text = sr.ReadToEnd();
			sr.Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
			//this.Close();
			button4.PerformClick();
		}
		void Button2Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Maximized){
				this.WindowState = FormWindowState.Normal;
			}
			else this.WindowState = FormWindowState.Maximized;
		}
		void Label1DoubleClick(object sender, EventArgs e)
		{
			button2.PerformClick();
		}
		void Button3Click(object sender, EventArgs e)
		{
			if (fileOpen.ShowDialog() == DialogResult.OK){
				string path = fileOpen.FileName.Replace(drive,"");
				string[] spl = path.Split('\\');
				
				textBox1.Text += "\r\n" + spl[spl.Length-1].Split('.')[0] + "," + path + "," + spl[2] + ",";
			}
		}
		
		
		void Button4Click(object sender, EventArgs e)
		{
			StreamWriter sw = new StreamWriter(sp);
			sw.Flush();
			sw.Write(textBox1.Text);
			sw.Close();
			
			mainmenu.Instance.loadItems();
			this.Close();
			mainmenu.Instance.Show();
		}
	}
}