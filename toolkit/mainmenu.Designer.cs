/*
 * Created by SharpDevelop.
 * User: Oscar
 * Date: 15/11/2020
 * Time: 21:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace toolkit
{
	partial class mainmenu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private toolkit.CustomTabControl tabs;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox11;
		private System.Windows.Forms.CheckBox checkBox10;
		private System.Windows.Forms.CheckBox checkBox9;
		private System.Windows.Forms.CheckBox checkBox8;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ImageList pItems;
		private System.Windows.Forms.ContextMenuStrip portableCTX;
		private System.Windows.Forms.ToolStripMenuItem runAsAdministratorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem favouriteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog fileOpen;
		private System.Windows.Forms.CheckBox checkBox12;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.Label footer;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Button button1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainmenu));
			this.tabs = new toolkit.CustomTabControl();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.listView1 = new System.Windows.Forms.ListView();
			this.portableCTX = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.runAsAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.favouriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pItems = new System.Windows.Forms.ImageList(this.components);
			this.footer = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.checkBox12 = new System.Windows.Forms.CheckBox();
			this.checkBox11 = new System.Windows.Forms.CheckBox();
			this.checkBox10 = new System.Windows.Forms.CheckBox();
			this.checkBox9 = new System.Windows.Forms.CheckBox();
			this.checkBox8 = new System.Windows.Forms.CheckBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.fileOpen = new System.Windows.Forms.OpenFileDialog();
			this.tabs.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.portableCTX.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabs
			// 
			this.tabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tabs.ContextMenuStrip = this.contextMenuStrip1;
			this.tabs.Controls.Add(this.tabPage1);
			this.tabs.Controls.Add(this.tabPage2);
			this.tabs.Controls.Add(this.tabPage3);
			this.tabs.Controls.Add(this.tabPage4);
			this.tabs.Controls.Add(this.tabPage5);
			this.tabs.Cursor = System.Windows.Forms.Cursors.Default;
			this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.tabs.Location = new System.Drawing.Point(0, 0);
			this.tabs.Multiline = true;
			this.tabs.Name = "tabs";
			this.tabs.Padding = new System.Drawing.Point(6, 10);
			this.tabs.SelectedIndex = 0;
			this.tabs.SelectTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
			this.tabs.SelectTabLineColor = System.Drawing.Color.Empty;
			this.tabs.Size = new System.Drawing.Size(556, 723);
			this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabs.TabColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(100)))), ((int)(((byte)(55)))));
			this.tabs.TabIndex = 1;
			this.tabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TabsMouseDown);
			this.tabs.MouseLeave += new System.EventHandler(this.TabsMouseLeave);
			this.tabs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TabsMouseMove);
			this.tabs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TabsMouseUp);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.exitToolStripMenuItem});
			this.contextMenuStrip1.Name = "portableCTX";
			this.contextMenuStrip1.Size = new System.Drawing.Size(103, 28);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
			this.tabPage1.Controls.Add(this.listView1);
			this.tabPage1.Controls.Add(this.footer);
			this.tabPage1.Controls.Add(this.tableLayoutPanel1);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 95);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(548, 624);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Portable";
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView1.ContextMenuStrip = this.portableCTX;
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.listView1.LargeImageList = this.pItems;
			this.listView1.Location = new System.Drawing.Point(3, 103);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(542, 495);
			this.listView1.TabIndex = 4;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.Click += new System.EventHandler(this.ListView1Click);
			this.listView1.DoubleClick += new System.EventHandler(this.ListView1DoubleClick);
			// 
			// portableCTX
			// 
			this.portableCTX.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.portableCTX.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.runAsAdministratorToolStripMenuItem,
									this.favouriteToolStripMenuItem,
									this.addToolStripMenuItem});
			this.portableCTX.Name = "portableCTX";
			this.portableCTX.Size = new System.Drawing.Size(217, 76);
			this.portableCTX.Opening += new System.ComponentModel.CancelEventHandler(this.PortableCTXOpening);
			// 
			// runAsAdministratorToolStripMenuItem
			// 
			this.runAsAdministratorToolStripMenuItem.Name = "runAsAdministratorToolStripMenuItem";
			this.runAsAdministratorToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
			this.runAsAdministratorToolStripMenuItem.Text = "Run as Administrator";
			// 
			// favouriteToolStripMenuItem
			// 
			this.favouriteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.allToolStripMenuItem,
									this.noneToolStripMenuItem});
			this.favouriteToolStripMenuItem.Name = "favouriteToolStripMenuItem";
			this.favouriteToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
			this.favouriteToolStripMenuItem.Text = "Filter";
			this.favouriteToolStripMenuItem.Click += new System.EventHandler(this.FavouriteToolStripMenuItemClick);
			// 
			// allToolStripMenuItem
			// 
			this.allToolStripMenuItem.Name = "allToolStripMenuItem";
			this.allToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
			this.allToolStripMenuItem.Text = "All";
			this.allToolStripMenuItem.Click += new System.EventHandler(this.AllToolStripMenuItemClick);
			// 
			// noneToolStripMenuItem
			// 
			this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
			this.noneToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
			this.noneToolStripMenuItem.Text = "None";
			this.noneToolStripMenuItem.Click += new System.EventHandler(this.AllToolStripMenuItemClick);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
			this.addToolStripMenuItem.Text = "Edit Sources";
			this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItemClick);
			// 
			// pItems
			// 
			this.pItems.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.pItems.ImageSize = new System.Drawing.Size(32, 32);
			this.pItems.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// footer
			// 
			this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.footer.Location = new System.Drawing.Point(3, 598);
			this.footer.Name = "footer";
			this.footer.Size = new System.Drawing.Size(542, 23);
			this.footer.TabIndex = 3;
			this.footer.Text = "footer text";
			this.footer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ContextMenuStrip = this.portableCTX;
			this.tableLayoutPanel1.Controls.Add(this.checkBox12, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.checkBox11, 4, 2);
			this.tableLayoutPanel1.Controls.Add(this.checkBox10, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.checkBox9, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.checkBox8, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.checkBox7, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.checkBox6, 5, 1);
			this.tableLayoutPanel1.Controls.Add(this.checkBox5, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this.checkBox4, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.checkBox3, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.checkBox2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 31);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(542, 72);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// checkBox12
			// 
			this.checkBox12.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox12.Checked = true;
			this.checkBox12.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBox12.FlatAppearance.BorderSize = 0;
			this.checkBox12.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
			this.checkBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox12.Location = new System.Drawing.Point(3, 41);
			this.checkBox12.Name = "checkBox12";
			this.checkBox12.Size = new System.Drawing.Size(84, 28);
			this.checkBox12.TabIndex = 14;
			this.checkBox12.Text = "hdd";
			this.checkBox12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox12.UseVisualStyleBackColor = true;
			this.checkBox12.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// checkBox11
			// 
			this.checkBox11.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox11.Checked = true;
			this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBox11.FlatAppearance.BorderSize = 0;
			this.checkBox11.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
			this.checkBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox11.Location = new System.Drawing.Point(453, 41);
			this.checkBox11.Name = "checkBox11";
			this.checkBox11.Size = new System.Drawing.Size(86, 28);
			this.checkBox11.TabIndex = 13;
			this.checkBox11.Text = "setup";
			this.checkBox11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox11.UseVisualStyleBackColor = true;
			this.checkBox11.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// checkBox10
			// 
			this.checkBox10.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox10.Checked = true;
			this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBox10.FlatAppearance.BorderSize = 0;
			this.checkBox10.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
			this.checkBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox10.Location = new System.Drawing.Point(363, 41);
			this.checkBox10.Name = "checkBox10";
			this.checkBox10.Size = new System.Drawing.Size(84, 28);
			this.checkBox10.TabIndex = 12;
			this.checkBox10.Text = "analysis";
			this.checkBox10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox10.UseVisualStyleBackColor = true;
			this.checkBox10.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// checkBox9
			// 
			this.checkBox9.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox9.Checked = true;
			this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBox9.FlatAppearance.BorderSize = 0;
			this.checkBox9.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
			this.checkBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox9.Location = new System.Drawing.Point(273, 41);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(84, 28);
			this.checkBox9.TabIndex = 11;
			this.checkBox9.Text = "graphics";
			this.checkBox9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox9.UseVisualStyleBackColor = true;
			this.checkBox9.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// checkBox8
			// 
			this.checkBox8.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox8.Checked = true;
			this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBox8.FlatAppearance.BorderSize = 0;
			this.checkBox8.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
			this.checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox8.Location = new System.Drawing.Point(183, 41);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(84, 28);
			this.checkBox8.TabIndex = 10;
			this.checkBox8.Text = "network";
			this.checkBox8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox8.UseVisualStyleBackColor = true;
			this.checkBox8.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// checkBox7
			// 
			this.checkBox7.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox7.Checked = true;
			this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBox7.FlatAppearance.BorderSize = 0;
			this.checkBox7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
			this.checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox7.Location = new System.Drawing.Point(93, 41);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(84, 28);
			this.checkBox7.TabIndex = 9;
			this.checkBox7.Text = "pe tools";
			this.checkBox7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox7.UseVisualStyleBackColor = true;
			this.checkBox7.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// checkBox6
			// 
			this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox6.Checked = true;
			this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBox6.FlatAppearance.BorderSize = 0;
			this.checkBox6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
			this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox6.Location = new System.Drawing.Point(453, 8);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(86, 27);
			this.checkBox6.TabIndex = 8;
			this.checkBox6.Text = "security";
			this.checkBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox6.UseVisualStyleBackColor = true;
			this.checkBox6.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// checkBox5
			// 
			this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox5.Checked = true;
			this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBox5.FlatAppearance.BorderSize = 0;
			this.checkBox5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
			this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox5.Location = new System.Drawing.Point(363, 8);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(84, 27);
			this.checkBox5.TabIndex = 7;
			this.checkBox5.Text = "dev";
			this.checkBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox5.UseVisualStyleBackColor = true;
			this.checkBox5.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// checkBox4
			// 
			this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox4.Checked = true;
			this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBox4.FlatAppearance.BorderSize = 0;
			this.checkBox4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
			this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox4.Location = new System.Drawing.Point(273, 8);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(84, 27);
			this.checkBox4.TabIndex = 6;
			this.checkBox4.Text = "suite";
			this.checkBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBox3.FlatAppearance.BorderSize = 0;
			this.checkBox3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox3.Location = new System.Drawing.Point(183, 8);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(84, 27);
			this.checkBox3.TabIndex = 5;
			this.checkBox3.Text = "misc";
			this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBox2.FlatAppearance.BorderSize = 0;
			this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(93, 8);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(84, 27);
			this.checkBox2.TabIndex = 4;
			this.checkBox2.Text = "useful";
			this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBox1.FlatAppearance.BorderSize = 0;
			this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(3, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(84, 27);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "common";
			this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox1.ForeColor = System.Drawing.Color.LightGray;
			this.textBox1.Location = new System.Drawing.Point(3, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(542, 28);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "  Search...";
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			this.textBox1.Enter += new System.EventHandler(this.TextBox1Enter);
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1KeyPress);
			this.textBox1.Leave += new System.EventHandler(this.TextBox1Leave);
			this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox1MouseDown);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
			this.tabPage2.Location = new System.Drawing.Point(4, 95);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(548, 624);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Installers";
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
			this.tabPage3.Location = new System.Drawing.Point(4, 95);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(548, 624);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Scripts";
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
			this.tabPage4.Location = new System.Drawing.Point(4, 95);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(548, 624);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "BootCD";
			// 
			// tabPage5
			// 
			this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
			this.tabPage5.Controls.Add(this.button1);
			this.tabPage5.Controls.Add(this.button2);
			this.tabPage5.Location = new System.Drawing.Point(4, 95);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(548, 624);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Options";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.button1.Dock = System.Windows.Forms.DockStyle.Top;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.button1.Location = new System.Drawing.Point(3, 61);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(542, 58);
			this.button1.TabIndex = 5;
			this.button1.Text = "Browser";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.button2.Dock = System.Windows.Forms.DockStyle.Top;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.button2.Location = new System.Drawing.Point(3, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(542, 58);
			this.button2.TabIndex = 4;
			this.button2.Text = "Portable Source";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// fileOpen
			// 
			this.fileOpen.Filter = "Executables|*.exe";
			// 
			// mainmenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(556, 723);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.tabs);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "mainmenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Oscar\'s Toolkit";
			this.TopMost = true;
			this.Activated += new System.EventHandler(this.MainmenuActivated);
			this.Deactivate += new System.EventHandler(this.MainmenuDeactivate);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainmenuFormClosing);
			this.Load += new System.EventHandler(this.MainmenuLoad);
			this.VisibleChanged += new System.EventHandler(this.MainmenuVisibleChanged);
			this.Enter += new System.EventHandler(this.MainmenuActivated);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TabsMouseDown);
			this.MouseLeave += new System.EventHandler(this.TabsMouseLeave);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TabsMouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TabsMouseUp);
			this.tabs.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.portableCTX.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.ResumeLayout(false);
		}
	}
}
