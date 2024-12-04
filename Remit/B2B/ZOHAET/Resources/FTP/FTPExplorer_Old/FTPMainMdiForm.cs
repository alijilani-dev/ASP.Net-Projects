using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace FTPExplorer
{
	/// <summary>
	/// Summary description for FTPMainMdiForm.
	/// </summary>
	public class FTPMainMdiForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu m_menuMDI;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MdiClient mdiClient1;
		private System.Windows.Forms.MenuItem menuItem10;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FTPMainMdiForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.m_menuMDI = new System.Windows.Forms.MainMenu();
			this.mdiClient1 = new System.Windows.Forms.MdiClient();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 1;
			this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem10,
																					  this.menuItem7,
																					  this.menuItem8,
																					  this.menuItem9});
			this.menuItem6.Text = "&Window";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 1;
			this.menuItem7.Text = "&Cascade";
			this.menuItem7.Click += new System.EventHandler(this.OnClickWindowCascade);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 2;
			this.menuItem8.Text = "Tile &Horizontal";
			this.menuItem8.Click += new System.EventHandler(this.OnClickWindowHorizontal);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 3;
			this.menuItem9.Text = "Tile &Vertical";
			this.menuItem9.Click += new System.EventHandler(this.OnClickWindowVertical);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3});
			this.menuItem1.Text = "&File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "&New Connection";
			this.menuItem2.Click += new System.EventHandler(this.OnClickFileNewConnection);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "&Exit";
			this.menuItem3.Click += new System.EventHandler(this.OnClickFileExit);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem5});
			this.menuItem4.Text = "&Help";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 0;
			this.menuItem5.Text = "&About";
			this.menuItem5.Click += new System.EventHandler(this.OnClickHelpAbout);
			// 
			// m_menuMDI
			// 
			this.m_menuMDI.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem6,
																					  this.menuItem4});
			// 
			// mdiClient1
			// 
			this.mdiClient1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mdiClient1.Name = "mdiClient1";
			this.mdiClient1.TabIndex = 0;
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 0;
			this.menuItem10.Text = "&Arrange Icons";
			this.menuItem10.Click += new System.EventHandler(this.OnClickWindowArrange);
			// 
			// FTPMainMdiForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(288, 269);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.mdiClient1});
			this.IsMdiContainer = true;
			this.Menu = this.m_menuMDI;
			this.Name = "FTPMainMdiForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FTP Explorer - Version 1.0";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.Run(new FTPMainMdiForm());
		}

		private void OnClickFileNewConnection(object sender, System.EventArgs e) {
			FTPExplorerDlg newFTPConnection = new FTPExplorerDlg(this);
			newFTPConnection.Show();
		}

		private void OnClickFileExit(object sender, System.EventArgs e) {
			Close();
		}

		private void OnClickWindowCascade(object sender, System.EventArgs e) {
			LayoutMdi(MdiLayout.Cascade);
		}

		private void OnClickWindowHorizontal(object sender, System.EventArgs e) {
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void OnClickWindowVertical(object sender, System.EventArgs e) {
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void OnClickHelpAbout(object sender, System.EventArgs e) {
			AboutDlg aboutDlg = new AboutDlg();
			aboutDlg.ShowDialog();
		}

		private void OnClickWindowArrange(object sender, System.EventArgs e) {
			LayoutMdi(MdiLayout.ArrangeIcons);
		}
	
	}
}
