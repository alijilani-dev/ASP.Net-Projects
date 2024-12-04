using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Microsoft.ApplicationBlocks.Data;
using Evernet.Shared;

namespace Evernet.MoneyExchange.Admin {
	/// <summary>
	/// Summary description for PrintView_CurrencyExposure.
	/// </summary>
	public class PrintView_CurrencyExposure : System.Web.UI.Page {
		protected System.Web.UI.WebControls.Label lblBalance;
		protected System.Web.UI.WebControls.DataGrid dgrdAgencyCommissionIncomeAccounts;
		protected System.Web.UI.WebControls.DataGrid dgrdUnpaidAccounts;
		protected System.Web.UI.WebControls.DataGrid dgrdAgentsReport;
		protected System.Web.UI.WebControls.Label lblDateTime;
		protected DateTime reportDate = DateTime.Today;
		protected decimal agentReportsTotal = 0;
		protected decimal unpaidAccountReportsTotal = 0;
		protected decimal srCommissionIncomeAccountsTotal = 0;
	
		private void Page_Load(object sender, System.EventArgs e) {
			// Put user code to initialize the page here
			if(Request["ReportDate"]==null) {
				Response.Redirect("Home.aspx");
				return;
			}
			try {
				reportDate = DateTime.Parse(Request["ReportDate"]);
				
			}catch{}
			reportDate = reportDate.AddDays(1);
			BindAll();
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e) {
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {    
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private void BindAll() {
			BindAgentReports();
			BindUnPaidAccountReports();
			BindIncomeAccountReports();
			BindTotals();
			BindReportDate();
		}

		private void BindReportDate() {
			lblDateTime.Text = DateTime.Parse(Request["ReportDate"]).ToString("dd MMM yyyy");
		}

		private void BindAgentReports() {
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				@"Select * From dbo.fn_getExposurePrincipalAccount('"+ reportDate.ToString() +@"')
					Union
				Select * From dbo.fn_getExposureCommissionAccount('"+ reportDate.ToString() +@"')");

			foreach(DataRow dr in ds.Tables[0].Rows) {
				agentReportsTotal += decimal.Parse(dr["USDAmount"].ToString());
			}

			agentReportsTotal = decimal.Round(agentReportsTotal,2);

			dgrdAgentsReport.DataSource=ds;
			dgrdAgentsReport.DataBind();
		}

		private void BindUnPaidAccountReports() {
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				@"Select * From dbo.fn_getExposurePrincipalUnpaidAccount('"+ reportDate.ToString() +@"')
Union
Select * From dbo.fn_getExposureCommissionUnpaidAccount('"+ reportDate.ToString() +@"')");

			foreach(DataRow dr in ds.Tables[0].Rows) {
				unpaidAccountReportsTotal += decimal.Parse(dr["USDAmount"].ToString());
			}

			unpaidAccountReportsTotal = decimal.Round(unpaidAccountReportsTotal,2);

			dgrdUnpaidAccounts.DataSource=ds;
			dgrdUnpaidAccounts.DataBind();
		}

		private void BindIncomeAccountReports() {
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				@"Select * From dbo.fn_getExposureAgencyCommissionAccount('"+ reportDate.ToString() +@"')");

			foreach(DataRow dr in ds.Tables[0].Rows) {
				srCommissionIncomeAccountsTotal += decimal.Parse(dr["USDAmount"].ToString());
			}

			srCommissionIncomeAccountsTotal = decimal.Round(srCommissionIncomeAccountsTotal,2);

			dgrdAgencyCommissionIncomeAccounts.DataSource=ds;
			dgrdAgencyCommissionIncomeAccounts.DataBind();
		}

		private void BindTotals() {
			//			lblAgentReportsTotal.Text = agentReportsTotal.ToString();
			//			lblUnpaidAccountTotal.Text = unpaidAccountReportsTotal.ToString();
			//			lblAgencyCommissionIncomeTotal.Text = srCommissionIncomeAccountsTotal.ToString();
			lblBalance.Text = (decimal.Round(agentReportsTotal,2) + decimal.Round(srCommissionIncomeAccountsTotal,2) + decimal.Round(unpaidAccountReportsTotal,2)).ToString();
		}
	}
}
