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
			//Console.WriteLine(this.Focused);
		}
		
		Array lines;
		string drive;
		
		void MainmenuLoad(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.None;
			
			string sp = Application.StartupPath+"\\config.csv";
			drive = sp.Split('\\')[0]+"\\";
			
			StreamReader sr = new StreamReader(sp);
			lines = sr.ReadToEnd().Split('\n');
			
			foreach (string v in lines) {
				var spl = v.Split(',');
				
				var icon = Icon.ExtractAssociatedIcon(drive + spl[1]);
				pItems.Images.Add(spl[0] ,icon);
				
				ListViewItem i = new ListViewItem();
				i.Text = i.ImageKey = spl[0];
				i.ToolTipText = drive + spl[1];
				i.Tag = spl[2];
				
				
				listView1.Items.Add(i);
				
			}
			//listView1.Items.AddRange(portableItems);
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
		void TextBox1MouseDown(object sender, MouseEventArgs e)
		{
			
		}
		void TextBox1Enter(object sender, EventArgs e)
		{
			if (textBox1.Text=="Search...") textBox1.Text = "";
		}
		void TextBox1Leave(object sender, EventArgs e)
		{
			if (textBox1.Text=="") textBox1.Text = "Search...";
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			tableLayoutPanel1.Enabled = textBox1.Text.Length==0;
			foreach (string v in lines) {
				var spl = v.Split(',');
				
				if (spl[0].ToLower().Contains(textBox1.Text.ToLower()))
				{
					ListViewItem i = new ListViewItem();
					i.Text = i.ImageKey = spl[0];
					i.ToolTipText = drive + spl[1];
					i.Tag = spl[2];
					
					listView1.Items.Add(i);
				}
			}
		}
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			
			string tags = "";
			
			foreach (Control c in tableLayoutPanel1.Controls)
			{
				CheckBox ch = (CheckBox)c;
				if (ch.Checked) tags += ch.Text + ",";
			}
					
			foreach (string v in lines) {
				var spl = v.Split(',');
				
				if (tags.Contains(spl[2].Trim())){
					ListViewItem i = new ListViewItem();
					i.Text = i.ImageKey = spl[0];
					i.ToolTipText = drive + spl[1];
					i.Tag = spl[2];
					
					listView1.Items.Add(i);
				}
			}
		}
		void AllToolStripMenuItemClick(object sender, EventArgs e)
		{
			ToolStripItem t = (ToolStripItem)sender;
			
			foreach (Control c in tableLayoutPanel1.Controls)
			{
				CheckBox ch = (CheckBox)c;
				ch.Checked=t.Text=="All";
			}
			
		}
		
	}
}
