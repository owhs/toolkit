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
        	Instance = this;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.None;
			
			//this.Location
			//Screen.PrimaryScreen.WorkingArea.Width
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public static mainmenu Instance {get; private set;}
		
		void MainmenuFormClosing(object sender, FormClosingEventArgs e)
		{
			//Application.Exit();
			e.Cancel=true;
			this.Hide();
		}
		void MainmenuDeactivate(object sender, EventArgs e)
		{
			if (!dialog) this.Close();
			else this.Opacity = 0.98;
		}
		
		void MainmenuMouseDown(object sender, MouseEventArgs e)
		{
			MessageBox.Show("mmmain");
		}
		
		Array lines;
		string drive;
		
		public void loadItems(){
						
			listView1.Items.Clear();
			
			string sp = Application.StartupPath+"\\config.csv";
			drive = sp.Split('\\')[0]+"\\";
			
			StreamReader sr = new StreamReader(sp);
			lines = sr.ReadToEnd().Split('\n');
			sr.Close();
			
			foreach (string v in lines) {
				var spl = v.Split(',');
				
				try{
					var icon = Icon.ExtractAssociatedIcon(drive + spl[1]);
					pItems.Images.Add(spl[0] ,icon);
				}catch{}
				
				
				ListViewItem i = new ListViewItem();
				i.Text = i.ImageKey = spl[0];
				i.ToolTipText = drive + spl[1];
				if(spl.Length==4) i.Tag = spl[3];
				
				listView1.Items.Add(i);
				
			}
		}
				
		void MainmenuLoad(object sender, EventArgs e)
		{
			//this.Location = new Point(
	         //       (Screen.PrimaryScreen.WorkingArea.Width - this.Width) - 200, (Screen.PrimaryScreen.WorkingArea.Height - this.Height));
						
			footer.Text = "";
			
			loadItems();
			//listView1.Items.AddRange(portableItems);
		}
		void ListView1DoubleClick(object sender, EventArgs e)
		{
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
			if (textBox1.Text=="  Search...") textBox1.Text = "";
		}
		void TextBox1Leave(object sender, EventArgs e)
		{
			if (textBox1.Text=="") textBox1.Text = "  Search...";
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			if (textBox1.Text=="  Search...") return;
			listView1.Items.Clear();
			tableLayoutPanel1.Enabled = textBox1.Text.Length==0;
			foreach (string v in lines) {
				var spl = v.Split(',');
				
				string[] sc = textBox1.Text.ToLower().Split(';');
				
				string[] se = sc[0].Split(',');
				
				foreach (string t in se) {
					if (spl[0].ToLower().Contains(t) ||
					    	(spl.Length==4 && spl[3].ToLower().Contains(t)) ||
					    	(spl[2].ToLower().Contains(t))){
						
						ListViewItem i = new ListViewItem();
						i.Text = i.ImageKey = spl[0];
						i.ToolTipText = drive + spl[1];
						if(spl.Length==4) i.Tag = spl[3];
						
						listView1.Items.Add(i);
					}
				}
				
				if (sc.Length==2){
					foreach (ListViewItem i in listView1.Items) {
						if (!(i.Text.ToLower().Contains(sc[1]) ||
								(i.Tag!=null && i.Tag.ToString().ToLower().Contains(sc[1])))){
							i.Remove();
						}
					}
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
					if(spl.Length==4) i.Tag = spl[3];
					
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
		void AddToolStripMenuItemClick(object sender, EventArgs e)
		{
			//dialog = true;
			Form f = new sourcesPortable();
			f.ShowDialog();
			//dialog = false;
		}
		void ListView1Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count>0 && listView1.SelectedItems[0].Tag!=null){
				footer.Text=listView1.SelectedItems[0].Tag.ToString();
			} else footer.Text="";
		}
		
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
		bool dialog = false;
		void Button2Click(object sender, EventArgs e)
		{
			//dialog = true;
			Form f = new sourcesPortable();
			f.ShowDialog();
			//dialog = false;
		}
		void MainmenuActivated(object sender, EventArgs e)
		{
			this.Opacity=1;
		}
		void MainmenuVisibleChanged(object sender, EventArgs e)
		{
			this.Location = new Point(
	                (Screen.PrimaryScreen.WorkingArea.Width - this.Width - 1), (Screen.PrimaryScreen.WorkingArea.Height - this.Height));
		}
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Environment.Exit(1);
		}
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			//MessageBox.Show(e.KeyChar.);
			if (e.KeyChar.ToString() == "") {
				textBox1.Text="";
				e.Handled = true;
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			Form f = new browser();
			f.ShowDialog();
		}
		
	}
}
