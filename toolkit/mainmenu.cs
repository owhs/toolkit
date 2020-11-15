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
	}
}
