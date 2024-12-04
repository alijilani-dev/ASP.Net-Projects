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

namespace Evernet.MoneyExchange.Admin
{
	/// <summary>
	/// Summary description for PrintView_PrincipleCommissionUnPaid.
	/// </summary>
	public class PrintView_PrincipleCommissionUnPaid : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblTitle;
		protected System.Web.UI.WebControls.Label lblAgentAccount;
		protected System.Web.UI.WebControls.Label lblAccountCurrency;
		protected System.Web.UI.WebControls.Label lblFromDate;
		protected System.Web.UI.WebControls.Label lblOpeningUSDBalance;
		protected System.Web.UI.WebControls.Label lblOpeningBalanceType;
		protected System.Web.UI.WebControls.Label lblOpeningBalance;
		protected System.Web.UI.WebControls.Label lblOpeningUSDDebit;
		protected System.Web.UI.WebControls.Label lblOpeningDebit;
		protected System.Web.UI.WebControls.Label lblOpeningUSDCredit;
		protected System.Web.UI.WebControls.Label lblOpeningCredit;
		protected System.Web.UI.WebControls.DataGrid dgrdAccounts;
		protected System.Web.UI.WebControls.Label lblBalanceUSD;
		protected System.Web.UI.WebControls.Label lblBalanceType;
		protected System.Web.UI.WebControls.Label lblBalance;
		protected System.Web.UI.WebControls.Label lblTotalUSDDebit;
		protected System.Web.UI.WebControls.Label lblTotalDebit;
		protected System.Web.UI.WebControls.Label lblTotalUSDCredit;
		protected System.Web.UI.WebControls.Label lblTotalCredit;
		protected System.Web.UI.WebControls.Label lblToDate;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here

			/*
			 * Expected Variables
			 * 
			 * CurrencyId
			 * StartDate
			 * EndDate
			 * */

			if(Request["CurrencyId"]==null
				||
				Request["StartDate"]==null
				||
				Request["EndDate"]==null){
				Response.Redirect("ViewReport_PrincipleCommissionUnPaid.aspx");
				return;
			}
			BindAccountDetails();
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
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
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void BindAccountDetails() {
			// ListItem li = ddlCurrencyList.SelectedItem;

			if(true) {

				DateTime startDate = DateTime.Today;
				DateTime endDate = DateTime.Today;

				try {
					startDate = DateTime.Parse(Request["StartDate"]);
				}catch{}

				try {
					endDate = DateTime.Parse(Request["EndDate"]);
					//endDate = endDate.AddDays(1);
				}catch{}

				lblFromDate.Text = Request["StartDate"];
				lblToDate.Text = Request["EndDate"];

				string query ="";

				// Calculate opening balance

				decimal totalOpeningCredit=0;
				decimal totalOpeningDebit=0;
				decimal totalOpeningBalance=0;
				decimal totalOpeningUSDCredit=0;
				decimal totalOpeningUSDDebit=0;
				decimal totalOpeningUSDBalance=0;

				query = "Select * From fn_getUnPaidPrincipleAccountDetailsForCurrency('"+ Request["CurrencyId"] +"') Where FinalDate < '"+ startDate.ToString() +"'";

				DataSet ds =SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					query);

				if(ds.Tables[0].Rows.Count>0) {
					foreach(DataRow dr in ds.Tables[0].Rows) {
						totalOpeningDebit += decimal.Parse(dr["DebitLC2"].ToString());
						totalOpeningCredit += decimal.Parse(dr["CreditLC2"].ToString());
						totalOpeningUSDDebit += decimal.Parse(dr["DebitUSD2"].ToString());
						totalOpeningUSDCredit += decimal.Parse(dr["CreditUSD2"].ToString());
					}
				}

				totalOpeningBalance = totalOpeningCredit - totalOpeningDebit;
				totalOpeningUSDBalance = totalOpeningUSDCredit - totalOpeningUSDDebit;

				Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList aoCurrency
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList(ConfigHelper.ConStr);

				aoCurrency.Refresh(new Guid(Request["CurrencyId"]));

				query = "Select * From fn_getUnPaidPrincipleAccountDetailsForCurrency('"+ Request["CurrencyId"] +"') Where FinalDate Between '"+ startDate.ToString() +"' And '"+ endDate.ToString() +"'";

				ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					query);

				if(ds.Tables[0].Rows.Count>0) {
					decimal totalCredit=0;
					decimal totalDebit=0;
					decimal balance=0;
					decimal totalUSDCredit=0;
					decimal totalUSDDebit=0;
					decimal totalUSDBalance=0;				

					foreach(DataRow dr in ds.Tables[0].Rows) {
						totalDebit += decimal.Parse(dr["DebitLC2"].ToString());
						totalCredit += decimal.Parse(dr["CreditLC2"].ToString());
						totalUSDDebit += decimal.Parse(dr["DebitUSD2"].ToString());
						totalUSDCredit += decimal.Parse(dr["CreditUSD2"].ToString());
					}

					balance = totalCredit - totalDebit;
					totalUSDBalance = totalUSDCredit - totalUSDDebit;

					balance += totalOpeningBalance;
					totalUSDBalance += totalOpeningUSDBalance;

					lblTotalCredit.Text = decimal.Round(totalCredit,aoCurrency.Col_Scale.Value).ToString();
					lblTotalDebit.Text = decimal.Round(totalDebit,aoCurrency.Col_Scale.Value).ToString();
					lblBalance.Text =  decimal.Round(Math.Abs(balance),aoCurrency.Col_Scale.Value).ToString();

					lblTotalUSDCredit.Text = decimal.Round(totalUSDCredit,2).ToString();
					lblTotalUSDDebit.Text = decimal.Round(totalUSDDebit,2).ToString();
					lblBalanceUSD.Text = decimal.Round(Math.Abs(totalUSDBalance),2).ToString();

					lblOpeningCredit.Text = decimal.Round(totalOpeningCredit,aoCurrency.Col_Scale.Value).ToString();
					lblOpeningDebit.Text = decimal.Round(totalOpeningDebit,aoCurrency.Col_Scale.Value).ToString();
					lblOpeningBalance.Text = decimal.Round(totalOpeningBalance,aoCurrency.Col_Scale.Value).ToString();


					lblOpeningUSDCredit.Text = decimal.Round(totalOpeningUSDCredit,2).ToString();
					lblOpeningUSDDebit.Text = decimal.Round(totalOpeningUSDDebit,2).ToString();
					lblOpeningUSDBalance.Text = decimal.Round(totalOpeningUSDBalance,2).ToString();

					if(balance>0) {
						lblBalanceType.Text = "Cr";
						lblBalance.ForeColor = Color.Green;
						lblBalanceUSD.ForeColor = Color.Green;
					} else if(balance<0){
						lblBalanceType.Text = "Dr";
						lblBalance.ForeColor = Color.Red;
						lblBalanceUSD.ForeColor = Color.Red;
					} else if(balance==0) {
						lblBalanceType.Text = "Cr";
						lblBalance.ForeColor = Color.Black;
						lblBalanceUSD.ForeColor = Color.Black;
					}


					if(totalOpeningBalance>0) {
						lblOpeningBalanceType.Text = "Cr";
						lblOpeningBalance.ForeColor = Color.Green;
						lblOpeningUSDBalance.ForeColor = Color.Green;
					} else if(totalOpeningBalance<0){
						lblOpeningBalanceType.Text = "Dr";
						lblOpeningBalance.ForeColor = Color.Red;
						lblOpeningUSDBalance.ForeColor = Color.Red;
					} else if(totalOpeningBalance==0) {
						lblOpeningBalanceType.Text = "Cr";
						lblOpeningBalance.ForeColor = Color.Black;
						lblOpeningUSDBalance.ForeColor = Color.Black;
					}
					
				} else {
					lblTotalCredit.Text = "0";
					lblTotalDebit.Text = "0";
					lblBalance.Text = "0";
				}

				dgrdAccounts.DataSource = ds;
				dgrdAccounts.DataBind();
			}
		}
	}
}
