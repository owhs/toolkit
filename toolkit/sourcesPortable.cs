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
		
		void SourcesPortableLoad(object sender, EventArgs e)
		{
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void Button2Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Maximized){
				this.WindowState = FormWindowState.Normal;
			}
			else this.WindowState = FormWindowState.Maximized;
		}
		
	}
}
