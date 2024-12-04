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
	public class CreditToAccount : System.Web.UI.Page {
		protected System.Web.UI.WebControls.DropDownList ddlAgentAccountList;
		protected System.Web.UI.WebControls.TextBox txtAmountUSD;
		protected System.Web.UI.WebControls.TextBox txtAmountExchange;
		protected System.Web.UI.WebControls.Button butCalculate;
		protected System.Web.UI.WebControls.ListBox lbxAllUnPaidTransactions;
		protected System.Web.UI.WebControls.ListBox lbxSelectedTransactions;
		protected System.Web.UI.WebControls.Button butSelect;
		protected System.Web.UI.WebControls.Button butRemove;
		protected System.Web.UI.WebControls.DropDownList ddlBankList ;
		protected System.Web.UI.WebControls.Button butCreditToAccount;
		protected System.Web.UI.WebControls.DropDownList ddlPaymentType;
		protected System.Web.UI.WebControls.Label lblFC1;
		protected System.Web.UI.WebControls.Label lblFC2;
		protected System.Web.UI.WebControls.Label lblCurrentOnAccount;
		protected System.Web.UI.WebControls.ListBox lbxOnAccountAvailable;
		protected System.Web.UI.WebControls.Button butSelectOnAccount;
		protected System.Web.UI.WebControls.Button butRemoveOnAccount;
		protected System.Web.UI.WebControls.ListBox lbxOnAccountSelected;
		protected System.Web.UI.WebControls.Label lblTotalAmount;
		protected System.Web.UI.WebControls.RadioButton rbutUseCurrentOnAccount;
		protected System.Web.UI.WebControls.RadioButton rbutSaveCurrentOnAccount;
		protected System.Web.UI.WebControls.ListBox lbxAvailableCancellingTrans;
		protected System.Web.UI.WebControls.ListBox lbxSelectedCancellingTrans;
		protected System.Web.UI.WebControls.Button butSelectCancellingTrans;
		protected System.Web.UI.WebControls.Button butRemoveCancellingTrans;
		protected System.Web.UI.WebControls.TextBox txtTotalPaying;
		protected System.Web.UI.WebControls.Label lblTotalTrans;
		protected System.Web.UI.WebControls.Label lblTotalOnAccount;
		protected System.Web.UI.WebControls.TextBox txtFCAmount;
		protected System.Web.UI.WebControls.TextBox txtExchangeRate;
		protected System.Web.UI.WebControls.TextBox txtUSDAmount;
		protected System.Web.UI.WebControls.Button butCalculate2;
		protected System.Web.UI.WebControls.Button butFinalCalculate;
		protected System.Web.UI.WebControls.Label lblTransactionAmount;
		protected System.Web.UI.WebControls.Label lblPayingAmount;
		protected System.Web.UI.WebControls.Label lblCancellingTransactionAmount;
		protected System.Web.UI.WebControls.Label lblOnAccountBalanceAmount;
		protected System.Web.UI.WebControls.Label lblTotalCreditAmount;
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.Label lblTotalCancellingAmount;
	
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
			this.ddlPaymentType.SelectedIndexChanged += new System.EventHandler(this.ddlPaymentType_SelectedIndexChanged);
			this.ddlAgentAccountList.SelectedIndexChanged += new System.EventHandler(this.ddlAgentAccountList_SelectedIndexChanged);
			this.butCalculate.Click += new System.EventHandler(this.butCalculate_Click);
			this.butSelect.Click += new System.EventHandler(this.butSelect_Click);
			this.butRemove.Click += new System.EventHandler(this.butRemove_Click);
			this.rbutUseCurrentOnAccount.CheckedChanged += new System.EventHandler(this.rbutUseCurrentOnAccount_CheckedChanged);
			this.butSelectOnAccount.Click += new System.EventHandler(this.butSelectOnAccount_Click);
			this.butRemoveOnAccount.Click += new System.EventHandler(this.butRemoveOnAccount_Click);
			this.butCalculate2.Click += new System.EventHandler(this.butCalculate2_Click);
			this.butFinalCalculate.Click += new System.EventHandler(this.butFinalCalculate_Click);
			this.butCreditToAccount.Click += new System.EventHandler(this.butCreditToAccount_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void BindAll() {
			BindAgentAccountList();
			BindBankAccountList();
			BindTransactions();
			BindCancellingTransactions();
		}

		private void BindAgentAccountList() {
			string query = "Select * From AgentMaster Order by Name";
            
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			ddlAgentAccountList.DataSource = ds;
			ddlAgentAccountList.DataBind();
		}

		private void BindBankAccountList() {
			string query = "Select * From BankAccountMaster Order by Name";
            
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			ddlBankList.DataSource = ds;
			ddlBankList.DataBind();
		}
		
		private void BindTransactions() {
			lbxAllUnPaidTransactions.Items.Clear();
			lbxSelectedTransactions.Items.Clear();

			string qCurrency = "Select curl.Code From CurrencyList curl Join CountryList conl On curl.Id = conl.BaseCurrency Join AgentMaster am On conl.Id = am.CountryId Where am.Id = '"+ ddlAgentAccountList.SelectedValue +"'";

			DataSet dsCurrency = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				qCurrency);

			lblFC1.Text = lblFC2.Text = dsCurrency.Tables[0].Rows[0]["Code"].ToString();

			//			string columnToSelect = "PayInAgentLocationId";
			//
			//			if(ddlPaymentType.SelectedValue == "Debit") {
			//				columnToSelect = "ActualPayOutAgentId";
			//			}
			//
			//			string query = "Select TransactionNumber, Id, TransactionNumber + '      ['+cast(PayInAmount as nvarchar(50))+']' as Display From TransactionDetails Where "+ columnToSelect +" In (Select Id From AgentLocationList Where AgentAccountId = '"+ ddlAgentAccountList.SelectedValue +"') And SettlementStatus = 'UnPaid'";

			string query = "Select TransactionNumber, Id, TransactionNumber +'      ['+cast(Amount as nvarchar(50))+']' as Display From vwAccountTransactionView Where AgentAccountId = '"+ ddlAgentAccountList.SelectedValue +"' And PaymentType = 'PayIn'";

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			lbxAllUnPaidTransactions.DataSource = ds;
			lbxAllUnPaidTransactions.DataBind();
			
			CalculateTransactionTotal();
		}

		private void BindCancellingTransactions() {
			string query = "Select TransactionNumber, Id, TransactionNumber +'      ['+cast(Amount as nvarchar(50))+']' as Display From vwAccountTransactionView Where AgentAccountId = '"+ ddlAgentAccountList.SelectedValue +"' And PaymentType = 'PayOut'";

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			lbxAvailableCancellingTrans.DataSource = ds;
			lbxAvailableCancellingTrans.DataBind();


		}

		private void CalculateTransactionTotal() {
			if(lbxSelectedTransactions.Items.Count>0) {
				string columnToSum = "PayInAmount";

				if(ddlPaymentType.SelectedValue == "Debit") {
					columnToSum = "PayOutAmount";
				}

				string query = "Select Sum("+columnToSum+") From TransactionDetails Where Id In (";

				for(int i=0;i<lbxSelectedTransactions.Items.Count;i++) {
					query += "'"+ lbxSelectedTransactions.Items[i].Value +"'";

					if(i!= lbxSelectedTransactions.Items.Count-1) {
						query += ",";
					}
				}

				query += ")";

				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					query);

				if(ds.Tables[0].Rows.Count>0) {
					lblTotalTrans.Text = ds.Tables[0].Rows[0][0].ToString();
				}

			} else {
				lblTotalTrans.Text = "0";
			}

			CalculateCurrentOnAccount();
		}

		private void CalculateCurrentOnAccount() {
			if(txtTotalPaying.Text!=String.Empty && lblTotalTrans.Text!=String.Empty) {
				decimal payin = decimal.Parse(txtTotalPaying.Text);
				decimal transTotal = decimal.Parse(lblTotalTrans.Text);

				decimal onAccount = payin - transTotal;

				lblCurrentOnAccount.Text = decimal.Round(onAccount,3).ToString();
			}
		}

		private void butCalculate_Click(object sender, System.EventArgs e) {
			decimal amountUSD = decimal.Parse(txtAmountUSD.Text);
			decimal exchangeRate = decimal.Parse(txtAmountExchange.Text);

			txtTotalPaying.Text =  decimal.Round(amountUSD * exchangeRate,3).ToString();
		}

		private void CalculatePreviousOnAccountTotal() {
			if(lbxOnAccountSelected.Items.Count>0) {
				string query = "Select Sum(Credit) From OnAccountHistory Where Id In (";

				for(int i=0;i<lbxOnAccountSelected.Items.Count;i++) {
					query += "'"+lbxOnAccountSelected.Items[i].Value+"'";

					if(i != lbxOnAccountSelected.Items.Count-1) {
						query += ",";
					}
				}

				query +=")";

				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					query);

				decimal total = decimal.Parse(ds.Tables[0].Rows[0][0].ToString());
				lblTotalOnAccount.Text = total.ToString();
			} else {
				lblTotalOnAccount.Text = "0";
			}
		}

		private void CalculateOnAccountTotal() {
			decimal onAccountTotal = 0;

			onAccountTotal = decimal.Parse(lblTotalOnAccount.Text);

			if(rbutUseCurrentOnAccount.Checked) {
				onAccountTotal += decimal.Parse(lblCurrentOnAccount.Text);
			}

			lblTotalAmount.Text = onAccountTotal.ToString();
		}

		private void CalculateTotal() {
			CalculateTransactionTotal();
			CalculatePreviousOnAccountTotal();
			CalculateOnAccountTotal();

			decimal payin = decimal.Parse(txtTotalPaying.Text);
			// decimal transAmount = decimal.Parse(lblTotalTrans.Text);
			decimal onAccTotal = decimal.Parse(lblTotalOnAccount.Text);

			lblTotalAmount.Text = decimal.Round(payin+onAccTotal,3).ToString();
		}

		private void ddlAgentAccountList_SelectedIndexChanged(object sender, System.EventArgs e) {
			BindTransactions();
		}

		private void butSelect_Click(object sender, System.EventArgs e) {
			ListItem li = lbxAllUnPaidTransactions.SelectedItem;

			if(li!=null) {
				li.Selected=false;
				lbxAllUnPaidTransactions.Items.Remove(li);
				lbxSelectedTransactions.Items.Add(li);
				CalculateTotal();
			}
		}

		private void butRemove_Click(object sender, System.EventArgs e) {
			ListItem li = lbxSelectedTransactions.SelectedItem;

			if(li!=null) {
				li.Selected=false;
				lbxSelectedTransactions.Items.Remove(li);
				lbxAllUnPaidTransactions.Items.Add(li);
				CalculateTotal();
			}
		}

		private void ddlPaymentType_SelectedIndexChanged(object sender, System.EventArgs e) {
			BindTransactions();
		}

		private void rbutUseCurrentOnAccount_CheckedChanged(object sender, System.EventArgs e) {
		
		}

		private void butSelectOnAccount_Click(object sender, System.EventArgs e) {
			ListItem li = lbxOnAccountAvailable.SelectedItem;

			if(li!=null) {
				li.Selected = false;
				lbxOnAccountAvailable.Items.Remove(li);
				lbxOnAccountSelected.Items.Add(li);

				CalculateTotal();
			}
		}

		private void butRemoveOnAccount_Click(object sender, System.EventArgs e) {
			ListItem li = lbxOnAccountSelected.SelectedItem;

			if(li!=null) {
				li.Selected = false;

				lbxOnAccountSelected.Items.Remove(li);
				lbxOnAccountAvailable.Items.Add(li);

				CalculateTotal();
			}
		}

		private void butCalculate2_Click(object sender, System.EventArgs e) {
			decimal fc = decimal.Parse(txtFCAmount.Text);
			decimal exchangeRate = decimal.Parse(txtExchangeRate.Text);

			txtUSDAmount.Text = decimal.Round(fc / exchangeRate,3).ToString();
		}

		private void butFinalCalculate_Click(object sender, System.EventArgs e) {
			lblTransactionAmount.Text = lblTotalTrans.Text;
			lblPayingAmount.Text = txtTotalPaying.Text;
			lblCancellingTransactionAmount.Text = lblTotalCancellingAmount.Text;
			lblOnAccountBalanceAmount.Text = lblTotalOnAccount.Text;

			decimal transAmount = decimal.Parse(lblTotalTrans.Text);

			decimal payinAmount = decimal.Parse(lblPayingAmount.Text);
			decimal cancellingAmount = decimal.Parse(lblCancellingTransactionAmount.Text);
			decimal onAccountAmount = decimal.Parse(lblOnAccountBalanceAmount.Text);
			decimal currentOnAccount = decimal.Parse(lblCurrentOnAccount.Text);

			decimal totalCredit = payinAmount + cancellingAmount + onAccountAmount;

			lblTotalCreditAmount.Text = totalCredit.ToString();
		}

		private void butCreditToAccount_Click(object sender, System.EventArgs e) {
			lblTransactionAmount.Text = lblTotalTrans.Text;
			lblPayingAmount.Text = txtTotalPaying.Text;
			lblCancellingTransactionAmount.Text = lblTotalCancellingAmount.Text;
			lblOnAccountBalanceAmount.Text = lblTotalOnAccount.Text;

			decimal transAmount = decimal.Parse(lblTotalTrans.Text);

			decimal payinAmount = decimal.Parse(lblPayingAmount.Text);
			decimal cancellingAmount = decimal.Parse(lblCancellingTransactionAmount.Text);
			decimal onAccountAmount = decimal.Parse(lblOnAccountBalanceAmount.Text);
			decimal currentOnAccount = decimal.Parse(lblCurrentOnAccount.Text);

			decimal totalCredit = payinAmount + cancellingAmount + onAccountAmount;

			Guid paymentId = Guid.NewGuid();

			string query1 = "Insert Into PaymentHistory Values('"+ paymentId.ToString() +"', getdate(), getdate(), NULL, 0, "+ totalCredit.ToString() +", 'Settlement', NULL)";
			string query2 = "";

			for(int i=0;i<lbxSelectedTransactions.Items.Count;i++) {
				query2 += "Insert Into TransactionSettlementHistory Values (newid(),'"+ paymentId.ToString() +"','"+ lbxSelectedTransactions.Items[i].Value +"',NULL);";
				query2 += "Update TransactionDetails Set SettlementStatus='Paid' Where Id = '"+ lbxSelectedTransactions.Items[i].Value +"';";
			}

			string query3 = "";

			if(currentOnAccount>0) {
				query3 = "Insert Into OnAccountHistory Values (newid(), '"+ ddlAgentAccountList.SelectedValue +"', '"+ paymentId.ToString() +"', NULL, getdate(), NULL, "+ currentOnAccount.ToString() +" ,NULL)";
			}

			string query4 = "";
		
			for(int i=0;i<lbxSelectedCancellingTrans.Items.Count;i++) {
				query4 += "Insert Into CancellingTransactionList Values (newid(), '"+ lbxSelectedCancellingTrans.Items[i].Value +"', '"+ paymentId.ToString() +"')";
			}
			string query5 = "Insert Into BankAccountPaymentHistory Values (newid(), '"+ ddlBankList.SelectedValue +"', '"+ paymentId.ToString() +"', "+ totalCredit.ToString() +" , NULL)";

			string query6 = "Insert Into AgentAccountDetails (Id,CreditDateTime, AgentAccountId, CreditLC, CreditUSD) ";
			query6 += " Values(newid(), getdate(), '"+ ddlAgentAccountList.SelectedValue +"',"+ txtFCAmount.Text +","+ txtUSDAmount.Text +")";

			System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigHelper.ConStr);
			con.Open();
			System.Data.SqlClient.SqlTransaction trans = con.BeginTransaction();

			try {

				if(query1!=string.Empty)
				SqlHelper.ExecuteNonQuery(trans,
					CommandType.Text,
					query1);

				if(query2!=string.Empty)
				SqlHelper.ExecuteNonQuery(trans,
					CommandType.Text,
					query2);

				if(query3!=string.Empty)
				SqlHelper.ExecuteNonQuery(trans,
					CommandType.Text,
					query3);

				if(query4!=string.Empty)
				SqlHelper.ExecuteNonQuery(trans,
					CommandType.Text,
					query4);

				if(query5!=string.Empty)
				SqlHelper.ExecuteNonQuery(trans,
					CommandType.Text,
					query5);

				if(query6!=string.Empty)
				SqlHelper.ExecuteNonQuery(trans,
					CommandType.Text,
					query6);

				trans.Commit();
			}catch(Exception ex) {
				trans.Rollback();
				lblMessage.Text = "Error occurred !";
				Trace.Warn("Exception","Exception Occured", ex);
				return;
			}

			con.Close();

			lblMessage.Text = "Agent account has been credit successfully!";
		}
	}
}
