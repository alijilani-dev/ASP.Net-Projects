using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.Data;
using ARYETP;

namespace ZOHAET
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmZohaET : System.Windows.Forms.Form
	{
		private System.IO.FileSystemWatcher fswZohaET;
		private System.Timers.Timer tmrZohaET;
		private System.Windows.Forms.Button btnGenerateIndia;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.ComponentModel.Container components = null;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		public frmZohaET()
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
				if (components != null) 
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
			System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmZohaET));
			this.btnGenerateIndia = new System.Windows.Forms.Button();
			this.fswZohaET = new System.IO.FileSystemWatcher();
			this.tmrZohaET = new System.Timers.Timer();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.fswZohaET)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tmrZohaET)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGenerateIndia
			// 
			this.btnGenerateIndia.BackColor = System.Drawing.SystemColors.Control;
			this.btnGenerateIndia.Location = new System.Drawing.Point(16, 224);
			this.btnGenerateIndia.Name = "btnGenerateIndia";
			this.btnGenerateIndia.Size = new System.Drawing.Size(304, 23);
			this.btnGenerateIndia.TabIndex = 0;
			this.btnGenerateIndia.Text = "&Generate India Cash";
			this.btnGenerateIndia.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// fswZohaET
			// 
			this.fswZohaET.EnableRaisingEvents = true;
			this.fswZohaET.Filter = "*.txt";
			this.fswZohaET.IncludeSubdirectories = ((bool)(configurationAppSettings.GetValue("fswZohaET.IncludeSubdirectories", typeof(bool))));
			this.fswZohaET.Path = ((string)(configurationAppSettings.GetValue("fswZohaET.Path", typeof(string))));
			this.fswZohaET.SynchronizingObject = this;
			this.fswZohaET.Created += new System.IO.FileSystemEventHandler(this.fswZohaET_Created);
			// 
			// tmrZohaET
			// 
			this.tmrZohaET.Enabled = ((bool)(configurationAppSettings.GetValue("tmrZohaET.Enabled", typeof(bool))));
			this.tmrZohaET.Interval = ((System.Double)(configurationAppSettings.GetValue("tmrZohaET.Interval", typeof(System.Double))));
			this.tmrZohaET.SynchronizingObject = this;
			this.tmrZohaET.Elapsed += new System.Timers.ElapsedEventHandler(this.tmrZohaET_Elapsed);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(40, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(248, 64);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(72, 160);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(192, 56);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// frmZohaET
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(336, 266);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnGenerateIndia);
			this.Name = "frmZohaET";
			this.Text = "ARY Speed Remit Electronic Transfer";
			this.Load += new System.EventHandler(this.frmZohaET_Load);
			((System.ComponentModel.ISupportInitialize)(this.fswZohaET)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tmrZohaET)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmZohaET());
		}

		private void btnGenerate_Click(object sender, System.EventArgs e)
		{
			DatUtil datNew = new DatUtil();
		}

		private void fswZohaET_Created(object sender, System.IO.FileSystemEventArgs e)
		{
			StringBuilder sr_Dat = new StringBuilder();
			String strPathBase = (String) System.Configuration.ConfigurationSettings.AppSettings.GetValues("fswZohaET.Path").GetValue(0);
			Thread.Sleep(15000);
			//if(MessageBox.Show( "File Created: " + e.FullPath.ToString() + " do you want to upload it?","ZohaET Upload Module.",MessageBoxButtons.YesNo )==DialogResult.Yes)
			{
				FTPManager fm = new FTPManager();
				if(fm.OnClickServerConnect())
				{
					fm.OnClickOptionsUploadFile(e.FullPath.ToUpper());
					DataTable dt_Files = fm.OnClickOptionsRefresh();
					if (dt_Files.Rows.Count!=0)
					{
						foreach (DataRow dr_file in dt_Files.Rows)
						{
							fm.OnClickOptionsDownloadFile(dr_file[1].ToString());
						}
					}
					else{MessageBox.Show("No files in current directory.");}
				}
				else
				{MessageBox.Show("Connection Failed..");}
			}
		}

		private void tmrZohaET_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			DatUtil datNew = new DatUtil();
		}

		private void frmZohaET_Load(object sender, System.EventArgs e)
		{
			DatUtil datNew = new DatUtil();
		}
	}
}