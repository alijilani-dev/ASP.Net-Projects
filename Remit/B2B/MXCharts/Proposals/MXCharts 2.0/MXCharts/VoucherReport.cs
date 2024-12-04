using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Windows.Forms;

namespace MXCharts
{
	/// <summary>
	/// Summary description for VoucherReport.
	/// </summary>
	public class VoucherReport : System.Windows.Forms.Form
	{
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		private VouchersReport Report;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public VoucherReport()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public VoucherReport(int n_MasterID)
		{
			InitializeComponent();
			Report = new VouchersReport();
			Report.SetParameterValue("MasterID",n_MasterID);
			ConfigureCrystalReports();
			this.crystalReportViewer1.ReportSource = Report;
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
			this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.SuspendLayout();
			// 
			// crystalReportViewer1
			// 
			this.crystalReportViewer1.ActiveViewIndex = -1;
			this.crystalReportViewer1.DisplayGroupTree = false;
			this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.ReportSource = null;
			this.crystalReportViewer1.Size = new System.Drawing.Size(292, 266);
			this.crystalReportViewer1.TabIndex = 0;
			// 
			// VoucherReport
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.crystalReportViewer1);
			this.Name = "VoucherReport";
			this.Text = "MXCharts Voucher Report";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);

		}
		#endregion
		private void SetDBLogonForReport(ConnectionInfo connectionInfo)
		{
			Tables tables = Report.Database.Tables;
			TableLogOnInfo tableLogonInfo = new TableLogOnInfo();
			foreach(CrystalDecisions.CrystalReports.Engine.Table table in tables)
			{
				tableLogonInfo = table.LogOnInfo;
				tableLogonInfo.ConnectionInfo = connectionInfo;
				table.ApplyLogOnInfo(tableLogonInfo);
			}
		}
		private void ConfigureCrystalReports()
		{
			ConnectionInfo connectionInfo = new ConnectionInfo();
			connectionInfo.ServerName	= ((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("Reports.ServerName").GetValue(0));
			connectionInfo.DatabaseName = ((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("Reports.DatabaseName").GetValue(0));
			connectionInfo.UserID		= ((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("Reports.UserID").GetValue(0));
			connectionInfo.Password		= ((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("Reports.Password").GetValue(0));
			SetDBLogonForReport(connectionInfo);
		}
	}
}