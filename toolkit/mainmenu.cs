/*
 * Created by SharpDevelop.
 * User: Oscar
 * Date: 15/11/2020
 * Time: 21:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace toolkit
{
	/// <summary>
	/// Description of mainmenu.
	/// </summary>
	public partial class mainmenu : Form
	{
		public mainmenu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainmenuFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
		void MainmenuDeactivate(object sender, EventArgs e)
		{
			this.Close();
		}
		void ListView1MouseUp(object sender, MouseEventArgs e)
		{
			/*if (listView1.FocusedItem.Checked) listView1.FocusedItem.Checked = false;
			else listView1.FocusedItem.Checked = true;
			tabControl1.Focus();*/
		}
		void MainmenuMouseDown(object sender, MouseEventArgs e)
		{
			Console.WriteLine(this.Focused);
		}
		void MainmenuLoad(object sender, EventArgs e)
		{
			/*var icon = Icon.ExtractAssociatedIcon(@"E:\data\portable\dev\SharpDevelop\bin\SharpDevelop.exe");
			pItems.Images.Add("abc" ,icon);
			listView1.Items.Add("lol", "abc");
			*/
			string drive = Application.StartupPath.Split('\\')[0]+"\\";
			Application.StartupPath+"\\config.csv"
		}
		
	}
}
