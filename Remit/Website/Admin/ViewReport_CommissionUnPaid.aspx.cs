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
using Evernet.MoneyExchange.BusinessLogic;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using Evernet.Shared;

namespace Evernet.MoneyExchange.Admin {

	public class ViewReport_CommissionUnPaid : System.Web.UI.Page {
		protected System.Web.UI.WebControls.DropDownList ddlCurrencyList;
		protected System.Web.UI.WebControls.TextBox txtStartDate;
		protected System.Web.UI.WebControls.TextBox txtEndDate;
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.DataGrid dgrdAccounts;
		protected System.Web.UI.WebControls.Label lblTotalCredit;
		protected System.Web.UI.WebControls.Label lblTotalUSDCredit;
		protected System.Web.UI.WebControls.Label lblTotalDebit;
		protected System.Web.UI.WebControls.Label lblTotalUSDDebit;
		protected System.Web.UI.WebControls.Label lblBalance;
		protected System.Web.UI.WebControls.Label lblBalanceType;
		protected System.Web.UI.WebControls.Label lblBalanceUSD;
		protected System.Web.UI.WebControls.Label lblOpeningUSDBalance;
		protected System.Web.UI.WebControls.Label lblOpeningBalanceType;
		protected System.Web.UI.WebControls.Label lblOpeningBalance;
		protected System.Web.UI.WebControls.Label lblUSD1;
		protected System.Web.UI.WebControls.Label lblFC1;
		protected System.Web.UI.WebControls.HyperLink hlnkPrintView;
		protected System.Web.UI.WebControls.Button butDisplay;
	
		private void Page_Load(object sender, System.EventArgs e) {
			if(!User.IsInRole(UserRoles.Administrator.ToString()) &&
				!User.IsInRole(UserRoles.ReportsManagerAgencyReportsViewer.ToString())){
				Response.Redirect("Home.aspx");
			}

			if(!IsPostBack) {
				BindAll();
			}
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
			this.butDisplay.Click += new System.EventHandler(this.butDisplay_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void BindAll(){
			BindCurrencyList();
			BindDates();
		}

		private void BindDates() {
			txtStartDate.Text = "19 Dec 2004";
			txtEndDate.Text = DateTime.Today.ToString("dd MMM yyyy");
		}

		private void BindCurrencyList() {
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select Id [ID1],Name [Display] From CurrencyList Order by Name");

			ddlCurrencyList.DataSource = ds;
			ddlCurrencyList.DataBind();
		}

		private void BindAccountDetails() {
			ListItem li = ddlCurrencyList.SelectedItem;

			if(li!=null) {

				DateTime startDate = DateTime.Today;
				DateTime endDate = DateTime.Today;

				try {
					startDate = DateTime.Parse(txtStartDate.Text);
				}catch{}

				try {
					endDate = DateTime.Parse(txtEndDate.Text);
					endDate = endDate.AddDays(1);
				}catch{}

				string query ="";

				// Calculate opening balance

				decimal totalOpeningCredit=0;
				decimal totalOpeningDebit=0;
				decimal totalOpeningBalance=0;
				decimal totalOpeningUSDCredit=0;
				decimal totalOpeningUSDDebit=0;
				decimal totalOpeningUSDBalance=0;

				query = "Select * From fn_getUnPaidCommissionAccountDetailsForCurrency('"+ li.Value +"') Where FinalDate < '"+ startDate.AddDays(1).ToString() +"'";

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

				aoCurrency.Refresh(new Guid(li.Value));

				query = "Select * From fn_getUnPaidCommissionAccountDetailsForCurrency('"+ li.Value +"') Where FinalDate Between '"+ startDate.ToString() +"' And '"+ endDate.ToString() +"'";

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

//					lblOpeningCredit.Text = decimal.Round(totalOpeningCredit,3).ToString();
//					lblOpeningDebit.Text = decimal.Round(totalOpeningDebit,3).ToString();
					lblOpeningBalance.Text = decimal.Round(Math.Abs(totalOpeningBalance),3).ToString();

//					lblOpeningUSDCredit.Text = decimal.Round(totalOpeningUSDCredit,2).ToString();
//					lblOpeningUSDDebit.Text = decimal.Round(totalOpeningUSDDebit,2).ToString();
					lblOpeningUSDBalance.Text = decimal.Round(Math.Abs(totalOpeningUSDBalance),2).ToString();

					lblTotalCredit.Text = decimal.Round(totalCredit,aoCurrency.Col_Scale.Value).ToString();
					lblTotalDebit.Text = decimal.Round(totalDebit,aoCurrency.Col_Scale.Value).ToString();
					lblBalance.Text =  decimal.Round(Math.Abs(balance),aoCurrency.Col_Scale.Value).ToString();

					lblTotalUSDCredit.Text = decimal.Round(totalUSDCredit,2).ToString();
					lblTotalUSDDebit.Text = decimal.Round(totalUSDDebit,2).ToString();
					lblBalanceUSD.Text = decimal.Round(Math.Abs(totalUSDBalance),2).ToString();

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

					if(totalOpeningUSDBalance>0) {
						lblOpeningBalanceType.Text = "Cr";
						lblOpeningBalance.ForeColor = Color.Green;
						lblOpeningUSDBalance.ForeColor = Color.Green;
					} else if(totalOpeningUSDBalance<0){
						lblOpeningBalanceType.Text = "Dr";
						lblOpeningBalance.ForeColor = Color.Red;
						lblOpeningUSDBalance.ForeColor = Color.Red;
					} else if(totalOpeningUSDBalance==0) {
						lblOpeningBalanceType.Text = "Cr";
						lblOpeningBalance.ForeColor = Color.Black;
						lblOpeningUSDBalance.ForeColor = Color.Black;
					}
					
				} else {
					lblTotalCredit.Text = "0";
					lblTotalDebit.Text = "0";
					lblBalance.Text = "0";
				}

				string url = "PrintView_CommissionUnPaid.aspx?CurrencyId="+ li.Value +"&StartDate="+ txtStartDate.Text +"&EndDate="+ txtEndDate.Text;

				hlnkPrintView.NavigateUrl=url;
				hlnkPrintView.Visible = true;

				dgrdAccounts.DataSource = ds;
				dgrdAccounts.DataBind();
			}
		}

		private void ClearLabels() {
			lblOpeningBalance.Text = "0";
//			lblOpeningCredit.Text = "0";
//			lblOpeningDebit.Text = "0";
//			lblOpeningUSDBalance.Text = "0";
//			lblOpeningUSDCredit.Text = "0";
//			lblOpeningUSDDebit.Text = "0";

			lblBalance.Text = "0";
			lblTotalCredit.Text = "0";
			lblTotalDebit.Text = "0";
			lblBalanceUSD.Text = "0";
			lblTotalUSDCredit.Text = "0";
			lblTotalUSDDebit.Text = "0";
		}

		private void butDisplay_Click(object sender, System.EventArgs e) {
			ClearLabels();
			BindAccountDetails();
		}
	}
}
