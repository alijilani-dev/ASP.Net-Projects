using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;
using System.Windows.Forms;

namespace ARYETSniffer
{
	public class ARYETSniffer : System.ServiceProcess.ServiceBase
	{
		public System.IO.FileSystemWatcher fswTxtFiles;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ARYETSniffer()
		{
			// This call is required by the Windows.Forms Component Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitComponent call
		}

		// The main entry point for the process
		static void Main()
		{
			System.ServiceProcess.ServiceBase[] ServicesToRun;
	
			// More than one user Service may run within the same process. To add
			// another service to this process, change the following line to
			// create a second service object. For example,
			//
			//   ServicesToRun = new System.ServiceProcess.ServiceBase[] {new Service1(), new MySecondUserService()};
			//
			ServicesToRun = new System.ServiceProcess.ServiceBase[] { new ARYETSniffer() };

			System.ServiceProcess.ServiceBase.Run(ServicesToRun);
		}

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
			this.fswTxtFiles = new System.IO.FileSystemWatcher();
			((System.ComponentModel.ISupportInitialize)(this.fswTxtFiles)).BeginInit();
			// 
			// fswTxtFiles
			// 
			this.fswTxtFiles.EnableRaisingEvents = ((bool)(configurationAppSettings.GetValue("fswTxtFiles.EnableRaisingEvents", typeof(bool))));
			this.fswTxtFiles.Filter = ((string)(configurationAppSettings.GetValue("fswTxtFiles.Filter", typeof(string))));
			this.fswTxtFiles.IncludeSubdirectories = ((bool)(configurationAppSettings.GetValue("fswTxtFiles.IncludeSubdirectories", typeof(bool))));
			this.fswTxtFiles.Path = ((string)(configurationAppSettings.GetValue("fswTxtFiles.Path", typeof(string))));
			this.fswTxtFiles.Created += new System.IO.FileSystemEventHandler(this.fswTxtFiles_Created);
			// 
			// ARYETSniffer
			// 
			this.CanPauseAndContinue = true;
			this.ServiceName = "ARYETSniffer";
			((System.ComponentModel.ISupportInitialize)(this.fswTxtFiles)).EndInit();

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

		/// <summary>
		/// Set things in motion so your service can do its work.
		/// </summary>
		protected override void OnStart(string[] args)
		{
			fswTxtFiles.EnableRaisingEvents = true;
		}
 
		/// <summary>
		/// Stop this service.
		/// </summary>
		protected override void OnStop()
		{
			fswTxtFiles.EnableRaisingEvents = false;
		}

		protected override void OnPause()
		{
			fswTxtFiles.EnableRaisingEvents = false;
		}
		protected override void OnContinue()
		{
			fswTxtFiles.EnableRaisingEvents = true;
		}
		private void fswTxtFiles_Created(object sender, System.IO.FileSystemEventArgs e)
		{
			FileInfo fi = new FileInfo(e.FullPath);
			fi.Directory.CreateSubdirectory("Updated");
			File.Copy(e.FullPath,fi.DirectoryName + @"\Updated\" + fi.Name, true);
			fi.Delete();
			MessageBox.Show("found the file.." + e.FullPath);
		}
	}
}