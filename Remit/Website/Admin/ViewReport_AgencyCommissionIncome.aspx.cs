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
using Evernet.MoneyExchange.BusinessLogic;

namespace Evernet.MoneyExchange.Admin {
	/// <summary>
	/// Summary description for ViewReport_AgencyCommissionIncome.
	/// </summary>
	public class ViewReport_AgencyCommissionIncome : System.Web.UI.Page {
		protected System.Web.UI.WebControls.Label lblBalanceUSD;
		protected System.Web.UI.WebControls.Label lblBalanceType;
		protected System.Web.UI.WebControls.Label lblBalance;
		protected System.Web.UI.WebControls.Label lblTotalUSDDebit;
		protected System.Web.UI.WebControls.Label lblTotalDebit;
		protected System.Web.UI.WebControls.Label lblTotalUSDCredit;
		protected System.Web.UI.WebControls.Label lblTotalCredit;
		protected System.Web.UI.WebControls.DataGrid dgrdAccounts;
		protected System.Web.UI.WebControls.Button butDisplay;
		protected System.Web.UI.WebControls.TextBox txtEndDate;
		protected System.Web.UI.WebControls.TextBox txtStartDate;
		protected System.Web.UI.WebControls.DropDownList ddlCurrencyList;
		protected System.Web.UI.WebControls.Label lblOpeningUSDBalance;
		protected System.Web.UI.WebControls.Label lblOpeningBalanceType;
		protected System.Web.UI.WebControls.Label lblOpeningBalance;
		protected System.Web.UI.WebControls.Label lblFC1;
		protected System.Web.UI.WebControls.Label lblFC2;
		protected System.Web.UI.WebControls.Label lblUSD1;
		protected System.Web.UI.WebControls.Label lblUSD2;
		protected System.Web.UI.WebControls.HyperLink hlnkPrintView;
		protected System.Web.UI.WebControls.Label lblMessage;
	
		private void Page_Load(object sender, System.EventArgs e) {
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

			ListItem li = new ListItem("[All Currencies]",Guid.Empty.ToString());
			ddlCurrencyList.Items.Insert(0,li);
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

				if(ddlCurrencyList.SelectedIndex!=0) {
					query = "Select * From fn_getAgencyCommissionIncomeForCurrency('"+ li.Value +"') Where Date < '"+ startDate.AddDays(1).ToString() +"' Order by CurrencyCode, VoucherNumber";
				} else {
					query = "Select * From fn_getAgencyCommissionIncome() Where Date < '"+ startDate.AddDays(1).ToString() +"' Order by CurrencyCode, VoucherNumber";
				}

				DataSet ds =SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					query);

				if(ds.Tables[0].Rows.Count>0) {
					foreach(DataRow dr in ds.Tables[0].Rows) {
						totalOpeningDebit += decimal.Parse(dr["DebitLC"].ToString());
						totalOpeningCredit += decimal.Parse(dr["CreditLC"].ToString());
						totalOpeningUSDDebit += decimal.Parse(dr["DebitUSD"].ToString());
						totalOpeningUSDCredit += decimal.Parse(dr["CreditUSD"].ToString());
					}
				}

				totalOpeningBalance = totalOpeningCredit - totalOpeningDebit;

				Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList aoCurrency
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList(ConfigHelper.ConStr);

				aoCurrency.Refresh(new Guid(li.Value));

				if(ddlCurrencyList.SelectedIndex!=0) {
					query = "Select * From fn_getAgencyCommissionIncomeForCurrency('"+ li.Value +"') Where Date Between '"+ startDate.ToString() +"' And '"+ endDate.ToString() +"' Order by CurrencyCode, VoucherNumber";
				} else {
					query = "Select * From fn_getAgencyCommissionIncome() Where Date Between '"+ startDate.ToString() +"' And '"+ endDate.ToString() +"' Order by CurrencyCode, VoucherNumber";
				}

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
						totalDebit += decimal.Parse(dr["DebitLC"].ToString());
						totalCredit += decimal.Parse(dr["CreditLC"].ToString());
						totalUSDDebit += decimal.Parse(dr["DebitUSD"].ToString());
						totalUSDCredit += decimal.Parse(dr["CreditUSD"].ToString());
					}

					balance = totalCredit - totalDebit;
					totalUSDBalance = totalUSDCredit - totalUSDDebit;

					lblTotalCredit.Text = decimal.Round(totalCredit,2).ToString();
					lblTotalDebit.Text = decimal.Round(totalDebit,2).ToString();
					balance += totalOpeningBalance;
					lblBalance.Text =  decimal.Round(Math.Abs(balance),2).ToString();

					lblTotalUSDCredit.Text = decimal.Round(totalUSDCredit,2).ToString();
					lblTotalUSDDebit.Text = decimal.Round(totalUSDDebit,2).ToString();
					lblBalanceUSD.Text = decimal.Round(Math.Abs(totalUSDBalance),2).ToString();

//					lblOpeningCredit.Text = decimal.Round(totalOpeningCredit,2).ToString();
//					lblOpeningDebit.Text = decimal.Round(totalOpeningDebit,2).ToString();
					lblOpeningBalance.Text = decimal.Round(totalOpeningBalance,2).ToString();


//					lblOpeningUSDCredit.Text = decimal.Round(totalOpeningUSDCredit,2).ToString();
//					lblOpeningUSDDebit.Text = decimal.Round(totalOpeningUSDDebit,2).ToString();
					totalOpeningUSDBalance = (totalOpeningUSDCredit - totalOpeningUSDDebit);
					lblOpeningUSDBalance.Text = decimal.Round(totalOpeningUSDBalance,2).ToString();

					if(totalOpeningBalance>0) {
						lblOpeningBalanceType.Text = "Cr";
						lblOpeningBalance.ForeColor = Color.Green;
						lblOpeningUSDBalance.ForeColor = Color.Green;
					} else if(totalOpeningBalance<0) {
						lblOpeningBalanceType.Text = "Dr";
						lblOpeningBalance.ForeColor = Color.Red;
						lblOpeningUSDBalance.ForeColor = Color.Red;
					} else if(totalOpeningBalance==0) {
						lblOpeningBalanceType.Text = "Cr";
						lblOpeningBalance.ForeColor = Color.Black;
						lblOpeningUSDBalance.ForeColor = Color.Black;
					}


					if(balance>0) {
						lblBalanceType.Text = "Cr";
						lblBalance.ForeColor = Color.Green;
						lblBalanceUSD.ForeColor = Color.Green;
					} else if(balance<0) {
						lblBalanceType.Text = "Dr";
						lblBalance.ForeColor = Color.Red;
						lblBalanceUSD.ForeColor = Color.Red;
					} else if(balance==0) {
						lblBalanceType.Text = "Cr";
						lblBalance.ForeColor = Color.Black;
						lblBalanceUSD.ForeColor = Color.Black;
					}

					if(ddlCurrencyList.SelectedIndex==0) {
						SetFCLablesVisibility(false);
					} else {
						SetFCLablesVisibility(true);
					}
					
				} else {
					lblTotalCredit.Text = "0";
					lblTotalDebit.Text = "0";
					lblBalance.Text = "0";
				}

				string currency = "All";

				if(ddlCurrencyList.SelectedIndex!=0) {
					currency = li.Value;
				}

				string url = "PrintView_AgencyCommissionIncome.aspx?StartDate="+ startDate.ToString() +"&EndDate="+ endDate.ToString() +"&Currency="+currency;

				hlnkPrintView.NavigateUrl = url;
				hlnkPrintView.Visible=true;

				dgrdAccounts.DataSource = ds;
				dgrdAccounts.DataBind();
			}
		}
		private void SetFCLablesVisibility(bool visibility) {
			lblBalance.Visible = visibility;
			lblOpeningBalance.Visible = visibility;
			//			lblOpeningCredit.Visible = visibility;
			//			lblOpeningDebit.Visible = visibility;
			lblTotalCredit.Visible = visibility;
			lblTotalDebit.Visible = visibility;
			lblFC1.Visible = visibility;
			lblFC2.Visible = visibility;
		}
		private void SetUSDLabelsVisibility(bool visibility) {
			lblBalanceUSD.Visible = visibility;
			lblOpeningUSDBalance.Visible = visibility;
			//			lblOpeningUSDCredit.Visible = visibility;
			//			lblOpeningUSDDebit.Visible = visibility;
			lblTotalUSDCredit.Visible = visibility;
			lblTotalUSDDebit.Visible = visibility;
			lblUSD1.Visible = visibility;
			lblUSD2.Visible = visibility;
		}

		private void butDisplay_Click(object sender, System.EventArgs e) {
			BindAccountDetails();
		}
	}
}