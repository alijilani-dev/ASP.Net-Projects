using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FTPExplorer
{
	/// <summary>
	/// Summary description for FTPLocalFolderDlg.
	/// </summary>
	public class FTPLocalFolderDlg : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox m_tbLocalFolder;
		private System.Windows.Forms.Button m_bnBrowse;
		private System.Windows.Forms.Button m_bnOK;
		private System.Windows.Forms.Button m_bnCancel;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.ComponentModel.IContainer components;

		public FTPLocalFolderDlg(string l_strLocalFolder)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			m_tbLocalFolder.Text = l_strLocalFolder;
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
			this.components = new System.ComponentModel.Container();
			this.m_bnOK = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.m_tbLocalFolder = new System.Windows.Forms.TextBox();
			this.m_bnBrowse = new System.Windows.Forms.Button();
			this.m_bnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// m_bnOK
			// 
			this.m_bnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_bnOK.Location = new System.Drawing.Point(250, 68);
			this.m_bnOK.Name = "m_bnOK";
			this.m_bnOK.TabIndex = 3;
			this.m_bnOK.Text = "&OK";
			this.toolTip1.SetToolTip(this.m_bnOK, "Closes this dialog and saves the changes that you have made");
			this.m_bnOK.Click += new System.EventHandler(this.OnClickOK);
			// 
			// m_tbLocalFolder
			// 
			this.m_tbLocalFolder.Location = new System.Drawing.Point(86, 35);
			this.m_tbLocalFolder.Name = "m_tbLocalFolder";
			this.m_tbLocalFolder.Size = new System.Drawing.Size(239, 20);
			this.m_tbLocalFolder.TabIndex = 1;
			this.m_tbLocalFolder.Text = "";
			this.toolTip1.SetToolTip(this.m_tbLocalFolder, "Displays your current local folder");
			// 
			// m_bnBrowse
			// 
			this.m_bnBrowse.Location = new System.Drawing.Point(298, 33);
			this.m_bnBrowse.Name = "m_bnBrowse";
			this.m_bnBrowse.Size = new System.Drawing.Size(27, 23);
			this.m_bnBrowse.TabIndex = 2;
			this.m_bnBrowse.Text = "...";
			this.toolTip1.SetToolTip(this.m_bnBrowse, "Click here to browse for folder");
			this.m_bnBrowse.Visible = false;
			this.m_bnBrowse.Click += new System.EventHandler(this.OnClickBrowse);
			// 
			// m_bnCancel
			// 
			this.m_bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_bnCancel.Location = new System.Drawing.Point(170, 68);
			this.m_bnCancel.Name = "m_bnCancel";
			this.m_bnCancel.TabIndex = 4;
			this.m_bnCancel.Text = "&Cancel";
			this.toolTip1.SetToolTip(this.m_bnCancel, "Closes this dialog and discards the changes that you have made");
			this.m_bnCancel.Click += new System.EventHandler(this.OnClickCancel);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Local Folder : ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FTPLocalFolderDlg
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(340, 104);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.m_bnCancel,
																		  this.m_bnOK,
																		  this.m_tbLocalFolder,
																		  this.label1,
																		  this.m_bnBrowse});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FTPLocalFolderDlg";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FTP Explorer - Set Local Folder";
			this.ResumeLayout(false);

		}
		#endregion

		public string LocalFolder {
			get { return m_tbLocalFolder.Text;}
		}

		private void OnClickBrowse(object sender, System.EventArgs e) {

		}

		private void OnClickOK(object sender, System.EventArgs e) {
			this.Close();
		}

		private void OnClickCancel(object sender, System.EventArgs e) {
			this.Close();
		}
	}
}
