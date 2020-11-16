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
using System.IO;

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
			//this.Close();
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
			string sp = Application.StartupPath+"\\config.csv";
			string drive = sp.Split('\\')[0]+"\\";
			//sp;
			StreamReader sr = new StreamReader(sp);
			Array lines = sr.ReadToEnd().Split('\n');
			foreach (string v in lines) {
				var spl = v.Split(',');
				//richTextBox1.Text += drive + spl[1] + "\n";
				var icon = Icon.ExtractAssociatedIcon(drive + spl[1]);
				pItems.Images.Add(spl[0] ,icon);
				
				ListViewItem i = new ListViewItem();
				i.Text = spl[0];
				i.ImageKey = spl[0];
				i.Tag = spl[2];
				i.ToolTipText = drive + spl[1];
				
				listView1.Items.Add(i);
			}
		}
		void ListView1DoubleClick(object sender, EventArgs e)
		{
			//MessageBox.Show(listView1.SelectedItems[0].ToolTipText);
			//MessageBox.Show(listView1.SelectedItems[0].Tag.ToString());
			//MessageBox.Show(listView1.SelectedItems.Count.ToString());
			Process p = new Process();
			p.StartInfo.FileName = listView1.SelectedItems[0].ToolTipText;
			try{
			p.Start();
			} catch{
			
			}
		}
		void PortableCTXOpening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (listView1.SelectedItems.Count>0){
				runAsAdministratorToolStripMenuItem.Visible = true;
			} else {
				runAsAdministratorToolStripMenuItem.Visible = false;
			}
		}
		void FavouriteToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
		
	}
}
