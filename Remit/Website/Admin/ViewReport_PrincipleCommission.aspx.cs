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
using System.Data.SqlClient;
using Evernet.Shared;
using Evernet.MoneyExchange.BusinessLogic;

namespace Evernet.MoneyExchange.Admin {

	public class ViewReport_PrincipleCommission : System.Web.UI.Page {
		protected System.Web.UI.WebControls.DropDownList ddlAgentAccountList;
		protected System.Web.UI.WebControls.TextBox txtStartDate;
		protected System.Web.UI.WebControls.TextBox txtEndDate;
		protected System.Web.UI.WebControls.Button butDisplay;
		protected System.Web.UI.WebControls.DataGrid dgrdAccountReport;
		protected System.Web.UI.WebControls.DropDownList ddlReportType;
		protected System.Web.UI.WebControls.Label lblBalanceUSD;
		protected System.Web.UI.WebControls.Label lblBalanceType;
		protected System.Web.UI.WebControls.Label lblBalance;
		protected System.Web.UI.WebControls.Label lblTotalUSDDebit;
		protected System.Web.UI.WebControls.Label lblTotalDebit;
		protected System.Web.UI.WebControls.Label lblTotalUSDCredit;
		protected System.Web.UI.WebControls.Label lblTotalCredit;
		protected System.Web.UI.WebControls.Label lblOpeningUSDBalance;
		protected System.Web.UI.WebControls.Label lblOpeningBalanceType;
		protected System.Web.UI.WebControls.Label lblOpeningBalance;
		protected System.Web.UI.WebControls.Label lblUSD1;
		protected System.Web.UI.WebControls.Label lblUSD2;
		protected System.Web.UI.WebControls.Label lblFC1;
		protected System.Web.UI.WebControls.Label lblFC2;
		protected System.Web.UI.WebControls.HyperLink hlnkPrintView;
		protected System.Web.UI.WebControls.Label lblMessage;
	
		private void Page_Load(object sender, System.EventArgs e) {
			// Put user code to initialize the page here
			if(!IsPostBack) {
				BindAll();
				ManageUSDRatesVisibility();
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
			this.ddlReportType.SelectedIndexChanged += new System.EventHandler(this.ddlReportType_SelectedIndexChanged);
			this.butDisplay.Click += new System.EventHandler(this.butDisplay_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void BindAll() {
			BindAgentAccount();
			BindDates();
		}

		private void BindDates() {
			txtStartDate.Text = "19 Dec 2004";
			txtEndDate.Text = DateTime.Today.ToString("dd MMM yyyy");
		}

		private void ManageUSDRatesVisibility() {
			if(User.IsInRole(UserRoles.Administrator.ToString())
				||
				User.IsInRole(UserRoles.ReportsManagerAgencyReportsViewer.ToString())
				) {
				dgrdAccountReport.Columns[4].Visible=true;
				dgrdAccountReport.Columns[6].Visible=true;

				SetUSDLabelsVisibility(true);
			} else {
				// 4 and 6 for FC
				// 3 and 5 for USD

				ListItem liAgentAccount = ddlAgentAccountList.SelectedItem;
				ListItem liReportType = ddlReportType.SelectedItem;

				if(liAgentAccount != null
					&&
					liReportType != null) {

					// If its Principal and comm report
					if(liReportType.Value=="PC") {
						// Hide USD rate columns
						dgrdAccountReport.Columns[3].Visible=true;
						dgrdAccountReport.Columns[5].Visible=true;
						dgrdAccountReport.Columns[4].Visible=false;
						dgrdAccountReport.Columns[6].Visible=false;

						SetUSDLabelsVisibility(false);
						SetFCLablesVisibility(true);

						// Else if its comm report
					} else {
						string query = @"Select PayOutCurrencyType From CommissionSlabMaster csm
											Where csm.PayOutCountryId = '"+ Evernet.MoneyExchange.BusinessLogic.UserManager.GetCountryForUser(new Guid(User.Identity.Name)).ToString() +"'";

						DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
							CommandType.Text,
							query);

						if(ds.Tables[0].Rows.Count>0) {
							DataRow dr = ds.Tables[0].Rows[0];

							if(dr["PayOutCurrencyType"].ToString().ToUpper()=="USD") {
								dgrdAccountReport.Columns[3].Visible=false;
								dgrdAccountReport.Columns[5].Visible=false;
								dgrdAccountReport.Columns[4].Visible=true;
								dgrdAccountReport.Columns[6].Visible=true;

								SetUSDLabelsVisibility(true);
								SetFCLablesVisibility(false);

							} else {
								dgrdAccountReport.Columns[3].Visible=true;
								dgrdAccountReport.Columns[5].Visible=true;
								dgrdAccountReport.Columns[4].Visible=false;
								dgrdAccountReport.Columns[6].Visible=false;

								SetUSDLabelsVisibility(false);
								SetFCLablesVisibility(true);
								
							}
						}
					}
				}
			}
			if(IsPostBack) {
				BindAccountDetails();
			}
		}
		private void SetFCLablesVisibility(bool visibility) {
			lblBalance.Visible = visibility;
			lblOpeningBalance.Visible = visibility;
			lblTotalCredit.Visible = visibility;
			lblTotalDebit.Visible = visibility;
			lblFC1.Visible = visibility;
			lblFC2.Visible = visibility;
		}
		private void SetUSDLabelsVisibility(bool visibility) {
			lblBalanceUSD.Visible = visibility;
			lblOpeningUSDBalance.Visible = visibility;
			lblTotalUSDCredit.Visible = visibility;
			lblTotalUSDDebit.Visible = visibility;
			lblUSD1.Visible = visibility;
			lblUSD2.Visible = visibility;
		}

		private void BindAgentAccount() {
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select Id ID1, Name Display From AgentMaster Order By Name");

			ddlAgentAccountList.DataSource = ds;
			ddlAgentAccountList.DataBind();

			Evernet.MoneyExchange.AbstractClasses.Abstract_UserList aoUser
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(ConfigHelper.ConStr);

			aoUser.Refresh(new Guid(User.Identity.Name));


			if(!User.IsInRole(UserRoles.Administrator.ToString())
				&&
				!aoUser.Col_IsAgencyEmployee.Value) {

				ListItem li = ddlAgentAccountList.Items.FindByValue(UserManager.GetAgentAccountForUser(new Guid(User.Identity.Name)).ToString());

				if(li!=null) {
					ddlAgentAccountList.SelectedIndex=-1;
					li.Selected=true;
				}
				ddlAgentAccountList.Enabled=false;
			}
		}

		private void BindAccountDetails() {
			lblMessage.Text=String.Empty;
			DateTime startDate = DateTime.Today;
			DateTime endDate = DateTime.Today;//.AddDays(1);
			ListItem liAgentAccount = ddlAgentAccountList.SelectedItem;

			decimal totalCreditLC = 0;
			decimal totalDebitLC = 0;
			decimal totalCreditUSD = 0;
			decimal totalDebitUSD = 0;
			decimal totalBalanceLC =0;
			decimal totalBalanceUSD =0;
			decimal totalOpeningCreditLC = 0;
			decimal totalOpeningCreditUSD = 0;
			decimal totalOpeningDebitLC = 0;
			decimal totalOpeningDebitUSD = 0;
			decimal totalOpeningBalanceLC = 0;
			decimal totalOpeningBalanceUSD = 0;

			try {
				startDate = DateTime.Parse(txtStartDate.Text);
			}catch{
				lblMessage.Text = "The start date was not recoganised !";
				return;
			}

			try {
				endDate = DateTime.Parse(txtEndDate.Text);
				//endDate = endDate.AddDays(1);
			}catch{
				lblMessage.Text = "The end date was not recoganised !";
				return;
			}

			if(liAgentAccount!=null) {
				Evernet.MoneyExchange.AbstractClasses.Abstract_AgentMaster aoAgentMaster					
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentMaster(ConfigHelper.ConStr);
				
				aoAgentMaster.Refresh(new Guid(liAgentAccount.Value));

				Evernet.MoneyExchange.AbstractClasses.Abstract_CountryList aoCountry
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_CountryList(ConfigHelper.ConStr);

				aoCountry.Refresh(aoAgentMaster.Col_CountryId);

				Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList aoCurrency
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList(ConfigHelper.ConStr);

				aoCurrency.Refresh(aoCountry.Col_BaseCurrency);

				dgrdAccountReport.Columns[3].HeaderText = "Debit ("+aoCurrency.Col_Code.Value+")";
				dgrdAccountReport.Columns[5].HeaderText = "Credit ("+aoCurrency.Col_Code.Value+")";

				lblFC1.Text = aoCurrency.Col_Code.Value;
				lblFC2.Text = aoCurrency.Col_Code.Value;

				string query ="";

				if(ddlReportType.SelectedValue=="PC") {
					query = "Select * From fn_getAccountDetailsForAgentAccount('"+ liAgentAccount.Value +"') Where FinalDate < '"+ startDate.ToString() +"'    Order by VoucherNumber";
				} else {
					query = "Select * From fn_getCommissionIncomeDetailsForAgentAccount('"+ liAgentAccount.Value +"') Where FinalDate < '"+ startDate.ToString() +"'  Order by VoucherNumber";
				}
				
				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					query);

				foreach(DataRow dr in ds.Tables[0].Rows) {
					totalOpeningDebitLC += decimal.Parse(dr["DebitLC"].ToString());
					totalOpeningCreditLC += decimal.Parse(dr["CreditLC"].ToString());
					totalOpeningDebitUSD += decimal.Parse(dr["DebitUSD"].ToString());
					totalOpeningCreditUSD += decimal.Parse(dr["CreditUSD"].ToString());
				}

//				lblOpeningCredit.Text = decimal.Round(totalOpeningCreditLC,2).ToString();
//				lblOpeningDebit.Text = decimal.Round(totalOpeningDebitLC,2).ToString();
				totalOpeningBalanceLC = totalOpeningCreditLC - totalOpeningDebitLC;
				lblOpeningBalance.Text = decimal.Round(Math.Abs(totalOpeningBalanceLC),2).ToString();

//				lblOpeningUSDCredit.Text = decimal.Round(totalOpeningCreditUSD,2).ToString();
//				lblOpeningUSDDebit.Text = decimal.Round(totalOpeningDebitUSD,2).ToString();
				totalOpeningBalanceUSD = totalOpeningCreditUSD - totalOpeningDebitUSD;
				lblOpeningUSDBalance.Text = decimal.Round(Math.Abs(totalOpeningBalanceUSD),2).ToString();

				if(totalOpeningBalanceLC>0) {
					lblOpeningBalanceType.Text = "Cr";
					lblOpeningBalance.ForeColor = Color.Green;
					lblOpeningUSDBalance.ForeColor = Color.Green;
				} else if(totalOpeningBalanceLC<0) {
					lblOpeningBalanceType.Text = "Dr";
					lblOpeningBalance.ForeColor = Color.Red;
					lblOpeningUSDBalance.ForeColor = Color.Red;
				} else if(totalOpeningBalanceLC==0) {
					lblOpeningBalanceType.Text = "Cr";
					lblOpeningBalance.ForeColor = Color.Black;
					lblOpeningUSDBalance.ForeColor = Color.Black;
				}

				if(ddlReportType.SelectedValue=="PC") {
					query = "Select * From fn_getAccountDetailsForAgentAccount('"+ liAgentAccount.Value +"') Where FinalDate Between '"+ startDate.ToString() +"' And '"+ endDate.ToString() +"' Order by VoucherNumber";
				} else {
					query = "Select * From fn_getCommissionIncomeDetailsForAgentAccount('"+ liAgentAccount.Value +"') Where FinalDate Between '"+ startDate.ToString() +"' And '"+ endDate.ToString() +"' Order by VoucherNumber";
				}

				ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					query);

				foreach(DataRow dr in ds.Tables[0].Rows) {
					totalDebitLC += decimal.Parse(dr["DebitLC"].ToString());
					totalCreditLC += decimal.Parse(dr["CreditLC"].ToString());
					totalDebitUSD += decimal.Parse(dr["DebitUSD"].ToString());
					totalCreditUSD += decimal.Parse(dr["CreditUSD"].ToString());
				}

				lblTotalCredit.Text = decimal.Round(totalCreditLC,2).ToString();
				lblTotalDebit.Text = decimal.Round(totalDebitLC,2).ToString();
				totalBalanceLC = totalCreditLC - totalDebitLC;
				totalBalanceLC += totalOpeningBalanceLC;
				lblBalance.Text =  decimal.Round(Math.Abs(totalBalanceLC),2).ToString();

				lblTotalUSDCredit.Text = decimal.Round(totalCreditUSD,2).ToString();
				lblTotalUSDDebit.Text = decimal.Round(totalDebitUSD,2).ToString();
				totalBalanceUSD = totalCreditUSD - totalDebitUSD;
				totalBalanceUSD += totalOpeningBalanceUSD;
				lblBalanceUSD.Text = decimal.Round(Math.Abs(totalBalanceUSD),2).ToString();		

				if(totalBalanceLC>0) {
					lblBalanceType.Text = "Cr";
					lblBalance.ForeColor = Color.Green;
					lblBalanceUSD.ForeColor = Color.Green;
				} else if(totalBalanceLC<0) {
					lblBalanceType.Text = "Dr";
					lblBalance.ForeColor = Color.Red;
					lblBalanceUSD.ForeColor = Color.Red;
				} else if(totalBalanceLC==0) {
					lblBalanceType.Text = "Cr";
					lblBalance.ForeColor = Color.Black;
					lblBalanceUSD.ForeColor = Color.Black;
				}

				dgrdAccountReport.DataSource = ds;
				dgrdAccountReport.DataBind();

				string printReportUrl = "PrintView_PrincipleCommission.aspx?AgentAccountId="+ liAgentAccount.Value +"&StartDate="+ txtStartDate.Text +"&EndDate="+ txtEndDate.Text +"&ReportType="+ddlReportType.SelectedValue;

				hlnkPrintView.NavigateUrl = printReportUrl;
				hlnkPrintView.Visible = true;
			}
		}

		private void butDisplay_Click(object sender, System.EventArgs e) {
			BindAccountDetails();
		}

		private void ddlReportType_SelectedIndexChanged(object sender, System.EventArgs e) {
			ManageUSDRatesVisibility();
		}
	}
}
