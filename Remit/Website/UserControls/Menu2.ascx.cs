namespace Evernet.MoneyExchange.UserControls {
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using Evernet.MoneyExchange.BusinessLogic;

	public class Menu2 : System.Web.UI.UserControl {
		protected System.Web.UI.WebControls.HyperLink hlnkCountryManager;
		protected System.Web.UI.WebControls.HyperLink hlnkCurrencyManager;
		protected System.Web.UI.WebControls.HyperLink hlnkCommissionSlabManager;
		protected System.Web.UI.WebControls.HyperLink hlnkLocationManager;
		protected System.Web.UI.WebControls.HyperLink hlnkAgentManager;
		protected System.Web.UI.WebControls.HyperLink hlnkBankManager;
		protected System.Web.UI.WebControls.HyperLink hlnkTransactionManager;
		protected System.Web.UI.WebControls.HyperLink hlnkUserManager;
		protected System.Web.UI.WebControls.HyperLink hlnkCustomerManager;
		protected System.Web.UI.WebControls.HyperLink hlnkViewExchangeRate;
		protected System.Web.UI.WebControls.HyperLink hlnkChangePassword;
		protected System.Web.UI.WebControls.HyperLink hlnkAgentAccountManagement;
		protected System.Web.UI.WebControls.HyperLink hlnkCountryMOP;
		protected System.Web.UI.WebControls.HyperLink hlnkUserRoleManagement;
		protected System.Web.UI.WebControls.HyperLink hlnkCustomerCardManagement;
		protected System.Web.UI.WebControls.HyperLink hlnkInitiateTransaction;
		protected System.Web.UI.WebControls.HyperLink hlnkIncomingTransaction;
		protected System.Web.UI.WebControls.HyperLink hlnkPendingTransaction;
		protected System.Web.UI.WebControls.HyperLink hlnkOpenTransaction;
		protected System.Web.UI.WebControls.HyperLink hlnkSentTransactions;
		protected System.Web.UI.WebControls.HyperLink hlnkBulkCardAssignment;
		protected System.Web.UI.WebControls.HyperLink hlnkBankExchangeRate;
		protected System.Web.UI.WebControls.HyperLink hlnkAgencyExchangeMargin;
		protected System.Web.UI.WebControls.HyperLink hlnkAgentExchangeMargin;
		protected System.Web.UI.WebControls.HyperLink hlnkSRUserManagement;
		protected System.Web.UI.WebControls.HyperLink hlnkSRUserRole;
		protected System.Web.UI.WebControls.HyperLink hlnkCountryPermissionList;
		protected System.Web.UI.WebControls.HyperLink hlnkAgentMOP;
		protected System.Web.UI.WebControls.HyperLink hlnkAgentGroupList;
		protected System.Web.UI.WebControls.HyperLink hlnkPurposeOfTransfer;
		protected System.Web.UI.WebControls.HyperLink hlnkViewTransactionStatus;
		protected System.Web.UI.WebControls.HyperLink hlnkViewDrafts;
		protected System.Web.UI.WebControls.HyperLink hlnkBankMOP;
		protected System.Web.UI.WebControls.HyperLink hlnkDailyRates;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_CountryManager;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_CurrencyManager;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_CountryMOP;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SPurposeOfTransfer;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SCountryMOP;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_CountryPermissionList;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SCountryPermissionList;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_AgencyExchangeMargin;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SAgencyExchangeMargin;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_AgentExchangeMargin;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SAgentExchangeMargin;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_CommissionSlabManager;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SCommissionSlabManager;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_LocationManager;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_BankExchangeRate;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SBankExchangeRate;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SChangePassword;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SLocationManager;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_AgentAccountManagement;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SAgentAccountManagement;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_AgentGroupList;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SAgentGroupList;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_AgentManager;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SAgentManager;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_AgentMOP;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SAgentMOP;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_BankMOP;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SBankMOP;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_BankManager;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SBankManager;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_TransactionManager;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_STransactionManager;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_InitiateTransaction;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SInitiateTransaction;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_IncomingTransaction;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SIncomingTransaction;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_PendingTransaction;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SPendingTransaction;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_OpenTransaction;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SOpenTransaction;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_ViewDrafts;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SViewDrafts;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_ViewTransactionStatus;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SViewTransactionStatus;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SentTransactions;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SSentTransactions;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SRUserManagement;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SSRUserManagement;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SRUserRole;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SSRUserRole;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_UserManager;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SUserManager;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_UserRoleManagement;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SUserRoleManagement;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_CustomerManager;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SCustomerManager;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_CustomerCardManagement;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SCustomerCardManagement;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_BulkCardAssignment;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SBulkCardAssignment;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_ViewExchangeRate;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SViewExchangeRate;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SCountryManager;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_PurposeOfTransfer;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_SCurrencyManager;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_DailyRates;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SCountryManager;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SCurrencyManager;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SPurposeOfTransfer;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SCountryMOP;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SCountryPermissionList;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SBankExchangeRate;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SAgencyExchangeMargin;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SAgentExchangeMargin;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SCommissionSlabManager;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SLocationManager;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SAgentAccountManagement;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SAgentGroupList;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SAgentManager;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SAgentMOP;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SBankMOP;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SBankManager;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_STransactionManager;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SInitiateTransaction;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SIncomingTransaction;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SPendingTransaction;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SOpenTransaction;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SViewDrafts;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SViewTransactionStatus;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SSentTransactions;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SSRUserManagement;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SSRUserRole;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SUserManager;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SUserRoleManagement;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SCustomerManager;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SCustomerCardManagement;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SBulkCardAssignment;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SViewExchangeRate;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_SChangePassword;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_DailyRates;
		protected System.Web.UI.HtmlControls.HtmlTable Table1;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_Spacer;
		protected System.Web.UI.HtmlControls.HtmlTableCell td_Spacer;
		protected System.Web.UI.WebControls.Image img_Spacer;
		protected System.Web.UI.HtmlControls.HtmlTableRow Tr_SDailyRates;
		protected System.Web.UI.HtmlControls.HtmlTableCell Td_SDailyRates;
		protected System.Web.UI.HtmlControls.HtmlTableRow Tr_SInitiateTransfer;
		protected System.Web.UI.HtmlControls.HtmlTableCell Td_SInitiateTransfer;
		protected System.Web.UI.HtmlControls.HtmlTableRow tr_ChangePassword;

		private void Page_Load(object sender, System.EventArgs e) {
			// Put user code to initialize the page here
			if(!IsPostBack) {
				ManageControlVisibility();
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
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private void ManageControlVisibility() {
			if(Context.User.Identity.IsAuthenticated) {
				if(!Context.User.IsInRole(UserRoles.Administrator.ToString())) {
					if(Context.User.IsInRole(UserRoles.CurrencyManagerViewer.ToString())) {
						tr_CurrencyManager.Visible=true;
						tr_SCurrencyManager.Visible=true;
						td_SCurrencyManager.Visible=true;
						hlnkCurrencyManager.Visible=true;
					}
					if(Context.User.IsInRole(UserRoles.CountryManagerViewer.ToString())
						||
						Context.User.IsInRole(UserRoles.CountryManagerCreator.ToString())
						||
						Context.User.IsInRole(UserRoles.CountryManagerEditor.ToString()) ){
						tr_CountryManager.Visible=true;
						tr_SCountryManager.Visible=true;
						td_SCountryManager.Visible=true;
						hlnkCountryManager.Visible=true;
					}

					if(Context.User.IsInRole(UserRoles.AgentAccountManagerViewer.ToString())) {
						tr_AgentAccountManagement.Visible=true;
						tr_SAgentAccountManagement.Visible=true;
						td_SAgentAccountManagement.Visible=true;
						hlnkAgentAccountManagement.Visible=true;
					}

					if(Context.User.IsInRole(UserRoles.CountryManagerModeOfPaymentEditor.ToString())) {
						tr_CountryMOP.Visible=true;
						tr_SCountryMOP.Visible=true;
						td_SCountryMOP.Visible=true;
						hlnkCountryMOP.Visible=true;
					}
					if(Context.User.IsInRole(UserRoles.UserManagerRoleEditor.ToString())) {
						tr_UserRoleManagement.Visible=true;
						tr_SUserRoleManagement.Visible=true;
						td_SUserRoleManagement.Visible=true;
						hlnkUserRoleManagement.Visible=true;
					}
					if(Context.User.IsInRole(UserRoles.CommissionSlabManagerViewer.ToString())) {
						tr_CommissionSlabManager.Visible=true;
						tr_SCommissionSlabManager.Visible=true;
						td_SCommissionSlabManager.Visible=true;
						hlnkCommissionSlabManager.Visible=true;
					}
					if(Context.User.IsInRole(UserRoles.LocationManagerViewer.ToString())) {
						tr_LocationManager.Visible=true;
						tr_SLocationManager.Visible=true;
						td_SLocationManager.Visible=true;
						hlnkLocationManager.Visible=true;
					}
					if(Context.User.IsInRole(UserRoles.AgentManagerViewer.ToString())) {
						tr_AgentManager.Visible=true;
						tr_SAgentManager.Visible=true;
						td_SAgentManager.Visible=true;
						hlnkAgentManager.Visible=true;
					}
					if(Context.User.IsInRole(UserRoles.BankManagerViewer.ToString())) {
						tr_BankManager.Visible=true;
						tr_SBankManager.Visible=true;
						td_SBankManager.Visible=true;
						hlnkBankManager.Visible=true;
					}

					if(Context.User.IsInRole(UserRoles.UserManagerViewer.ToString())
						||
						Context.User.IsInRole(UserRoles.UserManagerCreator.ToString())
						||
						Context.User.IsInRole(UserRoles.UserManagerEditor.ToString())) {
						tr_UserManager.Visible=true;
						tr_SUserManager.Visible=true;
						td_SUserManager.Visible=true;
						hlnkUserManager.Visible=true;
					}
					if(Context.User.IsInRole(UserRoles.CustomerCardCreator.ToString())) {
						tr_CustomerCardManagement.Visible=true;
						tr_BulkCardAssignment.Visible=true;

						tr_SCustomerCardManagement.Visible=true;
						td_SCustomerCardManagement.Visible=true;
						tr_SBulkCardAssignment.Visible=true;
						td_SBulkCardAssignment.Visible=true;

						hlnkCustomerCardManagement.Visible=true;
						hlnkBulkCardAssignment.Visible=true;
					}
					////////////////////////
					if(Context.User.IsInRole(UserRoles.CustomerManagerCreator.ToString())
						||
						Context.User.IsInRole(UserRoles.CustomerManagerEditor.ToString())
						||
						Context.User.IsInRole(UserRoles.CustomerManagerViewer.ToString())) 
					{
						tr_CustomerManager.Visible=true;
						tr_SCustomerManager.Visible=true;
						td_SCustomerManager.Visible=true;
						hlnkCustomerManager.Visible=true;
					}
					////////////////////////
					if(Context.User.IsInRole(UserRoles.AgentLocationPayOutTransactionAcceptor.ToString())) {
						tr_IncomingTransaction.Visible=true;
						tr_OpenTransaction.Visible=true;

						tr_SIncomingTransaction.Visible=true;
						td_SIncomingTransaction.Visible=true;
						tr_SOpenTransaction.Visible=true;
						td_SOpenTransaction.Visible=true;
						hlnkIncomingTransaction.Visible=true;
						hlnkOpenTransaction.Visible=true;

					}

					if(Context.User.IsInRole(UserRoles.AgentLocationPayInTransactionInitiator.ToString())) {

						tr_InitiateTransaction.Visible=true;
						tr_SentTransactions.Visible=true;

						tr_SInitiateTransaction.Visible=true;
						td_SInitiateTransaction.Visible=true;
						tr_SSentTransactions.Visible=true;
						td_SSentTransactions.Visible=true;
						
						tr_DailyRates.Visible=true;
						td_DailyRates.Visible=true;
						Tr_SDailyRates.Visible=true;
						Td_SDailyRates.Visible=true;
						
						hlnkDailyRates.Visible=true;
						hlnkInitiateTransaction.Visible=true;
						hlnkSentTransactions.Visible=true;
					}

					if(Context.User.IsInRole(UserRoles.AgentLocationPayInTransactonApprover.ToString())
						||
						Context.User.IsInRole(UserRoles.AgentLocationPayOutTransactionApprover.ToString())) {
						tr_PendingTransaction.Visible=true;
						tr_SPendingTransaction.Visible=true;
						td_SPendingTransaction.Visible=true;
						hlnkPendingTransaction.Visible=true;
					}

					if(Context.User.IsInRole(UserRoles.BulkCardAssigner.ToString())) {
						tr_BulkCardAssignment.Visible=true;
						tr_SBulkCardAssignment.Visible=true;
						td_SBulkCardAssignment.Visible=true;
						hlnkBulkCardAssignment.Visible=true;
					}

					if(Context.User.IsInRole(UserRoles.BankExchangeRateEditor.ToString())) {
						tr_BankExchangeRate.Visible=true;
						tr_SBankExchangeRate.Visible=true;
						td_SBankExchangeRate.Visible=true;
						hlnkBankExchangeRate.Visible=true;
					}

					if(Context.User.IsInRole(UserRoles.AgencyExchangeRateManagerEditor.ToString())
						||
						Context.User.IsInRole(UserRoles.AgencyExchangeRateManagerCreator.ToString())
						||
						Context.User.IsInRole(UserRoles.AgencyExchangeRateManagerViewer.ToString())) {
						tr_AgencyExchangeMargin.Visible=true;
						tr_SAgencyExchangeMargin.Visible=true;
						td_SAgencyExchangeMargin.Visible=true;
						hlnkAgencyExchangeMargin.Visible=true;
					}

					if(Context.User.IsInRole(UserRoles.AgentExchangeRateManagerEditor.ToString())
						||
						Context.User.IsInRole(UserRoles.AgentExchangeRateManagerCreator.ToString())
						||
						Context.User.IsInRole(UserRoles.AgentExchangeRateManagerViewer.ToString())) 
					{
						tr_AgentExchangeMargin.Visible=true;
						tr_SAgentExchangeMargin.Visible=true;
						td_SAgentExchangeMargin.Visible=true;
						hlnkAgentExchangeMargin.Visible=true;
					}

					if(Context.User.IsInRole(UserRoles.AgencyUserRoleEditor.ToString())) {
						tr_SRUserRole.Visible=true;
						tr_SSRUserRole.Visible=true;
						td_SSRUserRole.Visible=true;
						hlnkSRUserRole.Visible=true;
					}

					if(Context.User.IsInRole(UserRoles.CountryManagerPermissionViewer.ToString())) {
						tr_CountryPermissionList.Visible=true;
						tr_SCountryPermissionList.Visible=true;
						td_SCountryPermissionList.Visible=true;
						hlnkCountryPermissionList.Visible=true;
					}

					if(Context.User.IsInRole(UserRoles.BankExchangeRateViewer.ToString())) {
						tr_BankExchangeRate.Visible=true;
						tr_SBankExchangeRate.Visible=true;
						td_SBankExchangeRate.Visible=true;
						hlnkBankExchangeRate.Visible=true;
					}

					if(Context.User.IsInRole(UserRoles.PurposeOfTransferViewer.ToString())) {
						tr_PurposeOfTransfer.Visible = true;
						tr_SPurposeOfTransfer.Visible = true;
						td_SPurposeOfTransfer.Visible = true;
						hlnkPurposeOfTransfer.Visible = true;
					}

					if(Context.User.IsInRole(UserRoles.AgentGroupViewer.ToString())) {
						tr_AgentGroupList.Visible = true;
						tr_SAgentGroupList.Visible = true;
						td_SAgentGroupList.Visible = true;
						hlnkAgentGroupList.Visible = true;
					}

					if(Context.User.IsInRole(UserRoles.AgentModeOfPaymentViewer.ToString())) {
						tr_AgentMOP.Visible = true;
						tr_SAgentMOP.Visible = true;
						td_SAgentMOP.Visible = true;
						hlnkAgentMOP.Visible = true;
					}

					if(Context.User.IsInRole(UserRoles.TransactionStatusViewer.ToString())) {
						tr_ViewTransactionStatus.Visible = true;
						tr_SViewTransactionStatus.Visible = true;
						td_SViewTransactionStatus.Visible = true;
						hlnkViewTransactionStatus.Visible = true;
						
						tr_DailyRates.Visible = true;
						td_DailyRates.Visible = true;
						hlnkDailyRates.Visible = true;
					}
					
					if(Context.User.IsInRole(UserRoles.DraftTransactionViewer.ToString())) {
						tr_ViewDrafts.Visible = true;
						tr_SViewDrafts.Visible = true;
						td_SViewDrafts.Visible = true;
						hlnkViewDrafts.Visible = true;
					}

				} else {
					//tr_ViewDrafts.Visible = true;
					//tr_SViewDrafts.Visible = true;
					//td_SViewDrafts.Visible = true;
					//hlnkViewDrafts.Visible = true;
					tr_ViewTransactionStatus.Visible = true;
					tr_SViewTransactionStatus.Visible = true;
					td_SViewTransactionStatus.Visible = true;
					hlnkViewTransactionStatus.Visible = true;
					tr_AgentMOP.Visible = true;
					tr_SAgentMOP.Visible = true;
					td_SAgentMOP.Visible = true;
					hlnkAgentMOP.Visible = true;
					tr_AgentGroupList.Visible = true;
					tr_SAgentGroupList.Visible = true;
					td_SAgentGroupList.Visible = true;
					hlnkAgentGroupList.Visible = true;
					tr_PurposeOfTransfer.Visible = true;
					tr_SPurposeOfTransfer.Visible = true;
					td_SPurposeOfTransfer.Visible = true;
					hlnkPurposeOfTransfer.Visible = true;
//					hlnkOpenTransaction.Visible=true;
//					hlnkInitiateTransaction.Visible=true;
					tr_CurrencyManager.Visible=true;
					tr_SCurrencyManager.Visible=true;
					td_SCurrencyManager.Visible=true;
					hlnkCurrencyManager.Visible=true;
					tr_CountryManager.Visible=true;
					tr_SCountryManager.Visible=true;
					td_SCountryManager.Visible=true;
					hlnkCountryManager.Visible=true;
//					hlnkAgencyExchangeRateManager.Visible=true;
					tr_CommissionSlabManager.Visible=true;
					tr_SCommissionSlabManager.Visible=true;
					td_SCommissionSlabManager.Visible=true;
					hlnkCommissionSlabManager.Visible=true;
					tr_LocationManager.Visible=true;
					tr_SLocationManager.Visible=true;
					td_SLocationManager.Visible=true;
					hlnkLocationManager.Visible=true;
					tr_AgentManager.Visible=true;
					tr_SAgentManager.Visible=true;
					td_SAgentManager.Visible=true;
					hlnkAgentManager.Visible=true;
					tr_BankManager.Visible=true;
					tr_SBankManager.Visible=true;
					td_SBankManager.Visible=true;
					hlnkBankManager.Visible=true;
					tr_BankExchangeRate.Visible=true;
					tr_SBankExchangeRate.Visible=true;
					td_SBankExchangeRate.Visible=true;
					hlnkBankExchangeRate.Visible=true;
					tr_UserManager.Visible=true;
					tr_SUserManager.Visible=true;
					td_SUserManager.Visible=true;
					hlnkUserManager.Visible=true;
					tr_CustomerManager.Visible=true;
					tr_SCustomerManager.Visible=true;
					td_SCustomerManager.Visible=true;
					hlnkCustomerManager.Visible=true;
//					hlnkTransactionManager.Visible=true;
					tr_AgentAccountManagement.Visible=true;
					tr_SAgentAccountManagement.Visible=true;
					td_SAgentAccountManagement.Visible=true;
					hlnkAgentAccountManagement.Visible=true;
					tr_CountryMOP.Visible=true;
					tr_SCountryMOP.Visible=true;
					td_SCountryMOP.Visible=true;
					hlnkCountryMOP.Visible=true;
					tr_UserRoleManagement.Visible=true;
					tr_SUserRoleManagement.Visible=true;
					td_SUserRoleManagement.Visible=true;
					hlnkUserRoleManagement.Visible=true;
					tr_CustomerCardManagement.Visible=true;
					tr_SCustomerCardManagement.Visible=true;
					td_SCustomerCardManagement.Visible=true;
					hlnkCustomerCardManagement.Visible=true;
					tr_BulkCardAssignment.Visible=true;
					tr_SBulkCardAssignment.Visible=true;
					td_SBulkCardAssignment.Visible=true;
					hlnkBulkCardAssignment.Visible=true;
					tr_BankExchangeRate.Visible=true;
					tr_SBankExchangeRate.Visible=true;
					td_SBankExchangeRate.Visible=true;
					hlnkBankExchangeRate.Visible=true;
					tr_AgencyExchangeMargin.Visible=true;
					tr_SAgencyExchangeMargin.Visible=true;
					td_SAgencyExchangeMargin.Visible=true;
					hlnkAgencyExchangeMargin.Visible=true;
					tr_AgentExchangeMargin.Visible=true;
					tr_SAgentExchangeMargin.Visible=true;
					td_SAgentExchangeMargin.Visible=true;
					hlnkAgentExchangeMargin.Visible=true;
					tr_SRUserManagement.Visible=true;
					tr_SSRUserManagement.Visible=true;
					td_SSRUserManagement.Visible=true;
					hlnkSRUserManagement.Visible=true;
					tr_SRUserRole.Visible=true;
					tr_SSRUserRole.Visible=true;
					td_SSRUserRole.Visible=true;
					hlnkSRUserRole.Visible=true;
					tr_CountryPermissionList.Visible=true;
					tr_SCountryPermissionList.Visible=true;
					td_SCountryPermissionList.Visible=true;
					hlnkCountryPermissionList.Visible=true;
				}
			}
		}
	}
}
