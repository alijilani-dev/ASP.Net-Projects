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
using Evernet.Shared;
using Microsoft.ApplicationBlocks.Data;

namespace Evernet.MoneyExchange.Admin {
	/// <summary>
	/// Summary description for PrintView_ExchangeEarnings.
	/// </summary>
	public class PrintView_ExchangeEarnings : System.Web.UI.Page {
		protected System.Web.UI.WebControls.Label lblTitle;
		protected System.Web.UI.WebControls.Label lblAgentAccount;
		protected System.Web.UI.WebControls.Label lblAccountCurrency;
		protected System.Web.UI.WebControls.Label lblFromDate;
		protected System.Web.UI.WebControls.Label lblToDate;
		protected System.Web.UI.WebControls.DataGrid dgrdExchangeEarning;

		protected decimal totalEarning=0;
		protected decimal totalAgencyEarning = 0;
		protected decimal totalPayInAmount = 0;
	
		private void Page_Load(object sender, System.EventArgs e) {
			// Put user code to initialize the page here

			/*
			 * Expected Variables
			 * 
			 * AgentAccountId
			 * StartDate
			 * EndDate
			 * 
			 * */

			if(Request["AgentAccountId"]==null
				||
				Request["StartDate"]==null
				||
				Request["EndDate"]==null){
				Response.Redirect("ViewReport_ExchangeEarnings.aspx");
				return;
			}

			BindEarningGrid();
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

		private void BindEarningGrid() {
			// ListItem li = ddlAgentAccount.SelectedItem;

			if(true) {
				DateTime startDate = DateTime.Today;
				DateTime endDate = DateTime.Today;

				try {
					startDate = DateTime.Parse(Request["StartDate"]);
				}catch{
					// lblMessage.Text = "Invalid start date";
					return;
				}

				try {
					endDate = DateTime.Parse(Request["EndDate"]);
				}catch{
					// lblMessage.Text = "Invalid end date";
					return;
				}

				Evernet.MoneyExchange.AbstractClasses.Abstract_AgentMaster aoAgentMaster					
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentMaster(ConfigHelper.ConStr);
				
				aoAgentMaster.Refresh(new Guid(Request["AgentAccountId"]));

				Evernet.MoneyExchange.AbstractClasses.Abstract_CountryList aoCountry
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_CountryList(ConfigHelper.ConStr);

				aoCountry.Refresh(aoAgentMaster.Col_CountryId);

				Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList aoCurrency
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList(ConfigHelper.ConStr);

				aoCurrency.Refresh(aoCountry.Col_BaseCurrency);

				lblAgentAccount.Text = aoAgentMaster.Col_Name.Value + " [" + aoAgentMaster.Col_Number.Value+"]";
				lblAccountCurrency.Text = aoCurrency.Col_Code.Value;
				lblFromDate.Text = Request["StartDate"];
				lblToDate.Text = Request["EndDate"];

				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					@"Select 	PayInDateTime, aad.VoucherNumber, TransactionNumber, PayInAmount, 
					PayInAmount - (PayInAmount * (AgentMarginPercent/100)) as AgencyAmount,
					PayInAmount - (PayInAmount - (PayInAmount * (AgentMarginPercent/100))) as Earnings
					From TransactionDetails td
					Join AgentLocationList al
					On td.PayInAgentLocationId = al.Id
					Join AgentMaster am
					On al.AgentAccountId = am.Id
					Join AgentAccountDetails aad
					On aad.TransactionId = td.Id
					And aad.CreditDateTime Is Null
					Where PayInDateTime Between '"+ startDate.ToString() +@"' And '"+ endDate.AddDays(1).ToString() +@"'
					And am.Id='"+ Request["AgentAccountId"] +@"'
					And td.Status <> 'CancelledWithoutRefund' " + @"
					Order by PayInDateTime");

				foreach(DataRow dr in ds.Tables[0].Rows) {
					totalEarning += decimal.Round(decimal.Parse(dr["Earnings"].ToString()),3);
					totalAgencyEarning += decimal.Round(decimal.Parse(dr["AgencyAmount"].ToString()),3);
					totalPayInAmount += decimal.Round(decimal.Parse(dr["PayInAmount"].ToString()),3);
				}

				dgrdExchangeEarning.DataSource = ds;
				dgrdExchangeEarning.DataBind();
			}
		}
	}
}
