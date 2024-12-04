/*
	This C# source code was automatically generated using:

		SQL Server Centric .NET Code Generator
			v 1.0.1697.21165

			Generation Date: 11/30/2004 11:54:03 PM
			Generator name: EVERNET\kvsg
			Template last update: 10/13/2003 4:51:40 AM
			Template revision: 56177501

			SQL Server version: 08.00.0859
			Server: localhost
			Database: [mexchange]

	WARNING: This source is provided "AS IS" without warranty of any kind.
	The author disclaims all warranties, either express or implied, including
	the warranties of merchantability and fitness for a particular purpose.
	In no event shall the author or its suppliers be liable for any damages
	whatsoever including direct, indirect, incidental, consequential, loss of
	business profits or special damages, even if the author or its suppliers
	have been advised of the possibility of such damages.

	    More information: http://www.microsoft.com/france/msdn/olymars
	Latest interim build: http://www.olymars.net/latest.zip
	       Author's blog: http://blogs.msdn.com/olymars
*/

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
using System.Configuration;

namespace Evernet.MoneyExchange.Web.Forms
{
	/// <summary>
	/// Summary description for AdminTop.
	/// </summary>
	public class WebFormInternal_AdminTop : System.Web.UI.Page {

		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labTables;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.DropDownList comDatabaseTablesList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labRecords;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgencyCommissionIncomeAccountDetails com_AgencyCommissionIncomeAccountDetails;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgencyDifferenceIncomeAccountDetails com_AgencyDifferenceIncomeAccountDetails;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgencyExchangeRateList com_AgencyExchangeRateList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentAccountDetails com_AgentAccountDetails;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentAccountType com_AgentAccountType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentAvailablePaymentModeList com_AgentAvailablePaymentModeList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentCommissionIncomeAccount com_AgentCommissionIncomeAccount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentCommissionSplitList com_AgentCommissionSplitList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentExchangeRateList com_AgentExchangeRateList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentGroupList com_AgentGroupList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentLocationList com_AgentLocationList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentMaster com_AgentMaster;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_BankExchangeRateList com_BankExchangeRateList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_BankList com_BankList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_BeneficeryBankList com_BeneficeryBankList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CommissionCurrencyType com_CommissionCurrencyType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CommissionSlabMaster com_CommissionSlabMaster;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CommissionSplitTypeList com_CommissionSplitTypeList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CountryAllowedOutboundCurrencyList com_CountryAllowedOutboundCurrencyList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CountryAvailablePaymentModeList com_CountryAvailablePaymentModeList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CountryList com_CountryList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CountryTransactionPermissionList com_CountryTransactionPermissionList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CountryTransactionPermissionTypeList com_CountryTransactionPermissionTypeList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CurrencyExchangeType com_CurrencyExchangeType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CurrencyList com_CurrencyList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CustomerCardList com_CustomerCardList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CustomerCardStatusList com_CustomerCardStatusList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CustomerList com_CustomerList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CustomerLoyaltyPointsAccumulationHistory com_CustomerLoyaltyPointsAccumulationHistory;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CustomerLoyaltyPointsRedeemHistory com_CustomerLoyaltyPointsRedeemHistory;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_EntityList com_EntityList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_GlobalSettings com_GlobalSettings;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_LocationList com_LocationList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_LocationTree com_LocationTree;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_MasterCountryList com_MasterCountryList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_MasterModuleList com_MasterModuleList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_OFACBannedNameList com_OFACBannedNameList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_PayInAgentDifferenceIncomeAccount com_PayInAgentDifferenceIncomeAccount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_PaymentHistory com_PaymentHistory;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_PaymentModeBaseTypeList com_PaymentModeBaseTypeList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_PaymentModeList com_PaymentModeList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_PaymentType com_PaymentType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_ProductsList com_ProductsList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_PurposeOfTransferList com_PurposeOfTransferList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionDetails com_TransactionDetails;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionDraftList com_TransactionDraftList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionModificationMessageList com_TransactionModificationMessageList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionSettlementHistory com_TransactionSettlementHistory;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionSettlementStatusList com_TransactionSettlementStatusList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionStatusList com_TransactionStatusList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionTypeList com_TransactionTypeList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransitionAccountDetails com_TransitionAccountDetails;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_UserAuditList com_UserAuditList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_UserList com_UserList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_UserRoleAssignmentList com_UserRoleAssignmentList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_UserRoleList com_UserRoleList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_UserRoleTypeList com_UserRoleTypeList;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Button cmdAddNewRecord;
	
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormInternal_AdminTop() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString;
		private System.Globalization.CultureInfo CurrentUserCulture;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public string FrameEditURL;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public string FrameAddURL;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public string ComboBoxName;

		private void Page_Load(object sender, System.EventArgs e) {

			string Language = "en-US";
			if (Request.UserLanguages.Length != 0) {

				Language = Request.UserLanguages[0];
			}

			CurrentUserCulture = System.Globalization.CultureInfo.CreateSpecificCulture(Language);
			System.Threading.Thread.CurrentThread.CurrentUICulture = CurrentUserCulture;
			System.Threading.Thread.CurrentThread.CurrentCulture = CurrentUserCulture;

			/*
				Add the following in your web.config file
				<appSettings>
					<add key="mexchange ConnectionString" value="Data Source=localhost; Initial Catalog=mexchange; Integrated Security=SSPI" />
				</appSettings>
			*/
			if (ConfigurationSettings.AppSettings["mexchange ConnectionString"] != null) {

				ConnectionString = ConfigurationSettings.AppSettings["mexchange ConnectionString"];
			}
			else if (Application["ConnectionString"] != null) {

				ConnectionString = Application["ConnectionString"].ToString().Trim();
			}
			else {

				ConnectionString = String.Empty;
			}

			if (!Page.IsPostBack) {

				UpdateRecords();
				com_AgencyCommissionIncomeAccountDetails_SelectedIndexChanged(null, null);
			}
		}

		private void UpdateRecords() {

			com_AgencyCommissionIncomeAccountDetails.EnableViewState = false;
			com_AgencyCommissionIncomeAccountDetails.Visible = false;
			com_AgencyDifferenceIncomeAccountDetails.EnableViewState = false;
			com_AgencyDifferenceIncomeAccountDetails.Visible = false;
			com_AgencyExchangeRateList.EnableViewState = false;
			com_AgencyExchangeRateList.Visible = false;
			com_AgentAccountDetails.EnableViewState = false;
			com_AgentAccountDetails.Visible = false;
			com_AgentAccountType.EnableViewState = false;
			com_AgentAccountType.Visible = false;
			com_AgentAvailablePaymentModeList.EnableViewState = false;
			com_AgentAvailablePaymentModeList.Visible = false;
			com_AgentCommissionIncomeAccount.EnableViewState = false;
			com_AgentCommissionIncomeAccount.Visible = false;
			com_AgentCommissionSplitList.EnableViewState = false;
			com_AgentCommissionSplitList.Visible = false;
			com_AgentExchangeRateList.EnableViewState = false;
			com_AgentExchangeRateList.Visible = false;
			com_AgentGroupList.EnableViewState = false;
			com_AgentGroupList.Visible = false;
			com_AgentLocationList.EnableViewState = false;
			com_AgentLocationList.Visible = false;
			com_AgentMaster.EnableViewState = false;
			com_AgentMaster.Visible = false;
			com_BankExchangeRateList.EnableViewState = false;
			com_BankExchangeRateList.Visible = false;
			com_BankList.EnableViewState = false;
			com_BankList.Visible = false;
			com_BeneficeryBankList.EnableViewState = false;
			com_BeneficeryBankList.Visible = false;
			com_CommissionCurrencyType.EnableViewState = false;
			com_CommissionCurrencyType.Visible = false;
			com_CommissionSlabMaster.EnableViewState = false;
			com_CommissionSlabMaster.Visible = false;
			com_CommissionSplitTypeList.EnableViewState = false;
			com_CommissionSplitTypeList.Visible = false;
			com_CountryAllowedOutboundCurrencyList.EnableViewState = false;
			com_CountryAllowedOutboundCurrencyList.Visible = false;
			com_CountryAvailablePaymentModeList.EnableViewState = false;
			com_CountryAvailablePaymentModeList.Visible = false;
			com_CountryList.EnableViewState = false;
			com_CountryList.Visible = false;
			com_CountryTransactionPermissionList.EnableViewState = false;
			com_CountryTransactionPermissionList.Visible = false;
			com_CountryTransactionPermissionTypeList.EnableViewState = false;
			com_CountryTransactionPermissionTypeList.Visible = false;
			com_CurrencyExchangeType.EnableViewState = false;
			com_CurrencyExchangeType.Visible = false;
			com_CurrencyList.EnableViewState = false;
			com_CurrencyList.Visible = false;
			com_CustomerCardList.EnableViewState = false;
			com_CustomerCardList.Visible = false;
			com_CustomerCardStatusList.EnableViewState = false;
			com_CustomerCardStatusList.Visible = false;
			com_CustomerList.EnableViewState = false;
			com_CustomerList.Visible = false;
			com_CustomerLoyaltyPointsAccumulationHistory.EnableViewState = false;
			com_CustomerLoyaltyPointsAccumulationHistory.Visible = false;
			com_CustomerLoyaltyPointsRedeemHistory.EnableViewState = false;
			com_CustomerLoyaltyPointsRedeemHistory.Visible = false;
			com_EntityList.EnableViewState = false;
			com_EntityList.Visible = false;
			com_GlobalSettings.EnableViewState = false;
			com_GlobalSettings.Visible = false;
			com_LocationList.EnableViewState = false;
			com_LocationList.Visible = false;
			com_LocationTree.EnableViewState = false;
			com_LocationTree.Visible = false;
			com_MasterCountryList.EnableViewState = false;
			com_MasterCountryList.Visible = false;
			com_MasterModuleList.EnableViewState = false;
			com_MasterModuleList.Visible = false;
			com_OFACBannedNameList.EnableViewState = false;
			com_OFACBannedNameList.Visible = false;
			com_PayInAgentDifferenceIncomeAccount.EnableViewState = false;
			com_PayInAgentDifferenceIncomeAccount.Visible = false;
			com_PaymentHistory.EnableViewState = false;
			com_PaymentHistory.Visible = false;
			com_PaymentModeBaseTypeList.EnableViewState = false;
			com_PaymentModeBaseTypeList.Visible = false;
			com_PaymentModeList.EnableViewState = false;
			com_PaymentModeList.Visible = false;
			com_PaymentType.EnableViewState = false;
			com_PaymentType.Visible = false;
			com_ProductsList.EnableViewState = false;
			com_ProductsList.Visible = false;
			com_PurposeOfTransferList.EnableViewState = false;
			com_PurposeOfTransferList.Visible = false;
			com_TransactionDetails.EnableViewState = false;
			com_TransactionDetails.Visible = false;
			com_TransactionDraftList.EnableViewState = false;
			com_TransactionDraftList.Visible = false;
			com_TransactionModificationMessageList.EnableViewState = false;
			com_TransactionModificationMessageList.Visible = false;
			com_TransactionSettlementHistory.EnableViewState = false;
			com_TransactionSettlementHistory.Visible = false;
			com_TransactionSettlementStatusList.EnableViewState = false;
			com_TransactionSettlementStatusList.Visible = false;
			com_TransactionStatusList.EnableViewState = false;
			com_TransactionStatusList.Visible = false;
			com_TransactionTypeList.EnableViewState = false;
			com_TransactionTypeList.Visible = false;
			com_TransitionAccountDetails.EnableViewState = false;
			com_TransitionAccountDetails.Visible = false;
			com_UserAuditList.EnableViewState = false;
			com_UserAuditList.Visible = false;
			com_UserList.EnableViewState = false;
			com_UserList.Visible = false;
			com_UserRoleAssignmentList.EnableViewState = false;
			com_UserRoleAssignmentList.Visible = false;
			com_UserRoleList.EnableViewState = false;
			com_UserRoleList.Visible = false;
			com_UserRoleTypeList.EnableViewState = false;
			com_UserRoleTypeList.Visible = false;

			switch (comDatabaseTablesList.SelectedItem.Value) {

				case "AgencyCommissionIncomeAccountDetails":
					com_AgencyCommissionIncomeAccountDetails.EnableViewState = true;
					com_AgencyCommissionIncomeAccountDetails.Visible = true;
					com_AgencyCommissionIncomeAccountDetails.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null);
					com_AgencyCommissionIncomeAccountDetails.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_AgencyCommissionIncomeAccountDetails.Items.Insert(0, "");
					if (com_AgencyCommissionIncomeAccountDetails.Items.Count > 1) {

						com_AgencyCommissionIncomeAccountDetails.SelectedIndex = 1;
					}
					com_AgencyCommissionIncomeAccountDetails_SelectedIndexChanged(null, null);
					break;

				case "AgencyDifferenceIncomeAccountDetails":
					com_AgencyDifferenceIncomeAccountDetails.EnableViewState = true;
					com_AgencyDifferenceIncomeAccountDetails.Visible = true;
					com_AgencyDifferenceIncomeAccountDetails.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null);
					com_AgencyDifferenceIncomeAccountDetails.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_AgencyDifferenceIncomeAccountDetails.Items.Insert(0, "");
					if (com_AgencyDifferenceIncomeAccountDetails.Items.Count > 1) {

						com_AgencyDifferenceIncomeAccountDetails.SelectedIndex = 1;
					}
					com_AgencyDifferenceIncomeAccountDetails_SelectedIndexChanged(null, null);
					break;

				case "AgencyExchangeRateList":
					com_AgencyExchangeRateList.EnableViewState = true;
					com_AgencyExchangeRateList.Visible = true;
					com_AgencyExchangeRateList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
					com_AgencyExchangeRateList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_AgencyExchangeRateList.Items.Insert(0, "");
					if (com_AgencyExchangeRateList.Items.Count > 1) {

						com_AgencyExchangeRateList.SelectedIndex = 1;
					}
					com_AgencyExchangeRateList_SelectedIndexChanged(null, null);
					break;

				case "AgentAccountDetails":
					com_AgentAccountDetails.EnableViewState = true;
					com_AgentAccountDetails.Visible = true;
					com_AgentAccountDetails.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
					com_AgentAccountDetails.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_AgentAccountDetails.Items.Insert(0, "");
					if (com_AgentAccountDetails.Items.Count > 1) {

						com_AgentAccountDetails.SelectedIndex = 1;
					}
					com_AgentAccountDetails_SelectedIndexChanged(null, null);
					break;

				case "AgentAccountType":
					com_AgentAccountType.EnableViewState = true;
					com_AgentAccountType.Visible = true;
					com_AgentAccountType.Initialize(ConnectionString);
					com_AgentAccountType.RefreshData(System.Data.SqlTypes.SqlString.Null);
					com_AgentAccountType.Items.Insert(0, "");
					if (com_AgentAccountType.Items.Count > 1) {

						com_AgentAccountType.SelectedIndex = 1;
					}
					com_AgentAccountType_SelectedIndexChanged(null, null);
					break;

				case "AgentAvailablePaymentModeList":
					com_AgentAvailablePaymentModeList.EnableViewState = true;
					com_AgentAvailablePaymentModeList.Visible = true;
					com_AgentAvailablePaymentModeList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null);
					com_AgentAvailablePaymentModeList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_AgentAvailablePaymentModeList.Items.Insert(0, "");
					if (com_AgentAvailablePaymentModeList.Items.Count > 1) {

						com_AgentAvailablePaymentModeList.SelectedIndex = 1;
					}
					com_AgentAvailablePaymentModeList_SelectedIndexChanged(null, null);
					break;

				case "AgentCommissionIncomeAccount":
					com_AgentCommissionIncomeAccount.EnableViewState = true;
					com_AgentCommissionIncomeAccount.Visible = true;
					com_AgentCommissionIncomeAccount.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
					com_AgentCommissionIncomeAccount.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_AgentCommissionIncomeAccount.Items.Insert(0, "");
					if (com_AgentCommissionIncomeAccount.Items.Count > 1) {

						com_AgentCommissionIncomeAccount.SelectedIndex = 1;
					}
					com_AgentCommissionIncomeAccount_SelectedIndexChanged(null, null);
					break;

				case "AgentCommissionSplitList":
					com_AgentCommissionSplitList.EnableViewState = true;
					com_AgentCommissionSplitList.Visible = true;
					com_AgentCommissionSplitList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
					com_AgentCommissionSplitList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_AgentCommissionSplitList.Items.Insert(0, "");
					if (com_AgentCommissionSplitList.Items.Count > 1) {

						com_AgentCommissionSplitList.SelectedIndex = 1;
					}
					com_AgentCommissionSplitList_SelectedIndexChanged(null, null);
					break;

				case "AgentExchangeRateList":
					com_AgentExchangeRateList.EnableViewState = true;
					com_AgentExchangeRateList.Visible = true;
					com_AgentExchangeRateList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
					com_AgentExchangeRateList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_AgentExchangeRateList.Items.Insert(0, "");
					if (com_AgentExchangeRateList.Items.Count > 1) {

						com_AgentExchangeRateList.SelectedIndex = 1;
					}
					com_AgentExchangeRateList_SelectedIndexChanged(null, null);
					break;

				case "AgentGroupList":
					com_AgentGroupList.EnableViewState = true;
					com_AgentGroupList.Visible = true;
					com_AgentGroupList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null);
					com_AgentGroupList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_AgentGroupList.Items.Insert(0, "");
					if (com_AgentGroupList.Items.Count > 1) {

						com_AgentGroupList.SelectedIndex = 1;
					}
					com_AgentGroupList_SelectedIndexChanged(null, null);
					break;

				case "AgentLocationList":
					com_AgentLocationList.EnableViewState = true;
					com_AgentLocationList.Visible = true;
					com_AgentLocationList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlGuid.Null);
					com_AgentLocationList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_AgentLocationList.Items.Insert(0, "");
					if (com_AgentLocationList.Items.Count > 1) {

						com_AgentLocationList.SelectedIndex = 1;
					}
					com_AgentLocationList_SelectedIndexChanged(null, null);
					break;

				case "AgentMaster":
					com_AgentMaster.EnableViewState = true;
					com_AgentMaster.Visible = true;
					com_AgentMaster.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
					com_AgentMaster.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_AgentMaster.Items.Insert(0, "");
					if (com_AgentMaster.Items.Count > 1) {

						com_AgentMaster.SelectedIndex = 1;
					}
					com_AgentMaster_SelectedIndexChanged(null, null);
					break;

				case "BankExchangeRateList":
					com_BankExchangeRateList.EnableViewState = true;
					com_BankExchangeRateList.Visible = true;
					com_BankExchangeRateList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null);
					com_BankExchangeRateList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_BankExchangeRateList.Items.Insert(0, "");
					if (com_BankExchangeRateList.Items.Count > 1) {

						com_BankExchangeRateList.SelectedIndex = 1;
					}
					com_BankExchangeRateList_SelectedIndexChanged(null, null);
					break;

				case "BankList":
					com_BankList.EnableViewState = true;
					com_BankList.Visible = true;
					com_BankList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
					com_BankList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_BankList.Items.Insert(0, "");
					if (com_BankList.Items.Count > 1) {

						com_BankList.SelectedIndex = 1;
					}
					com_BankList_SelectedIndexChanged(null, null);
					break;

				case "BeneficeryBankList":
					com_BeneficeryBankList.EnableViewState = true;
					com_BeneficeryBankList.Visible = true;
					com_BeneficeryBankList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
					com_BeneficeryBankList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_BeneficeryBankList.Items.Insert(0, "");
					if (com_BeneficeryBankList.Items.Count > 1) {

						com_BeneficeryBankList.SelectedIndex = 1;
					}
					com_BeneficeryBankList_SelectedIndexChanged(null, null);
					break;

				case "CommissionCurrencyType":
					com_CommissionCurrencyType.EnableViewState = true;
					com_CommissionCurrencyType.Visible = true;
					com_CommissionCurrencyType.Initialize(ConnectionString);
					com_CommissionCurrencyType.RefreshData(System.Data.SqlTypes.SqlString.Null);
					com_CommissionCurrencyType.Items.Insert(0, "");
					if (com_CommissionCurrencyType.Items.Count > 1) {

						com_CommissionCurrencyType.SelectedIndex = 1;
					}
					com_CommissionCurrencyType_SelectedIndexChanged(null, null);
					break;

				case "CommissionSlabMaster":
					com_CommissionSlabMaster.EnableViewState = true;
					com_CommissionSlabMaster.Visible = true;
					com_CommissionSlabMaster.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
					com_CommissionSlabMaster.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_CommissionSlabMaster.Items.Insert(0, "");
					if (com_CommissionSlabMaster.Items.Count > 1) {

						com_CommissionSlabMaster.SelectedIndex = 1;
					}
					com_CommissionSlabMaster_SelectedIndexChanged(null, null);
					break;

				case "CommissionSplitTypeList":
					com_CommissionSplitTypeList.EnableViewState = true;
					com_CommissionSplitTypeList.Visible = true;
					com_CommissionSplitTypeList.Initialize(ConnectionString);
					com_CommissionSplitTypeList.RefreshData(System.Data.SqlTypes.SqlString.Null);
					com_CommissionSplitTypeList.Items.Insert(0, "");
					if (com_CommissionSplitTypeList.Items.Count > 1) {

						com_CommissionSplitTypeList.SelectedIndex = 1;
					}
					com_CommissionSplitTypeList_SelectedIndexChanged(null, null);
					break;

				case "CountryAllowedOutboundCurrencyList":
					com_CountryAllowedOutboundCurrencyList.EnableViewState = true;
					com_CountryAllowedOutboundCurrencyList.Visible = true;
					com_CountryAllowedOutboundCurrencyList.Initialize(ConnectionString);
					com_CountryAllowedOutboundCurrencyList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_CountryAllowedOutboundCurrencyList.Items.Insert(0, "");
					if (com_CountryAllowedOutboundCurrencyList.Items.Count > 1) {

						com_CountryAllowedOutboundCurrencyList.SelectedIndex = 1;
					}
					com_CountryAllowedOutboundCurrencyList_SelectedIndexChanged(null, null);
					break;

				case "CountryAvailablePaymentModeList":
					com_CountryAvailablePaymentModeList.EnableViewState = true;
					com_CountryAvailablePaymentModeList.Visible = true;
					com_CountryAvailablePaymentModeList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null);
					com_CountryAvailablePaymentModeList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_CountryAvailablePaymentModeList.Items.Insert(0, "");
					if (com_CountryAvailablePaymentModeList.Items.Count > 1) {

						com_CountryAvailablePaymentModeList.SelectedIndex = 1;
					}
					com_CountryAvailablePaymentModeList_SelectedIndexChanged(null, null);
					break;

				case "CountryList":
					com_CountryList.EnableViewState = true;
					com_CountryList.Visible = true;
					com_CountryList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
					com_CountryList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_CountryList.Items.Insert(0, "");
					if (com_CountryList.Items.Count > 1) {

						com_CountryList.SelectedIndex = 1;
					}
					com_CountryList_SelectedIndexChanged(null, null);
					break;

				case "CountryTransactionPermissionList":
					com_CountryTransactionPermissionList.EnableViewState = true;
					com_CountryTransactionPermissionList.Visible = true;
					com_CountryTransactionPermissionList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null);
					com_CountryTransactionPermissionList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_CountryTransactionPermissionList.Items.Insert(0, "");
					if (com_CountryTransactionPermissionList.Items.Count > 1) {

						com_CountryTransactionPermissionList.SelectedIndex = 1;
					}
					com_CountryTransactionPermissionList_SelectedIndexChanged(null, null);
					break;

				case "CountryTransactionPermissionTypeList":
					com_CountryTransactionPermissionTypeList.EnableViewState = true;
					com_CountryTransactionPermissionTypeList.Visible = true;
					com_CountryTransactionPermissionTypeList.Initialize(ConnectionString);
					com_CountryTransactionPermissionTypeList.RefreshData(System.Data.SqlTypes.SqlString.Null);
					com_CountryTransactionPermissionTypeList.Items.Insert(0, "");
					if (com_CountryTransactionPermissionTypeList.Items.Count > 1) {

						com_CountryTransactionPermissionTypeList.SelectedIndex = 1;
					}
					com_CountryTransactionPermissionTypeList_SelectedIndexChanged(null, null);
					break;

				case "CurrencyExchangeType":
					com_CurrencyExchangeType.EnableViewState = true;
					com_CurrencyExchangeType.Visible = true;
					com_CurrencyExchangeType.Initialize(ConnectionString);
					com_CurrencyExchangeType.RefreshData(System.Data.SqlTypes.SqlString.Null);
					com_CurrencyExchangeType.Items.Insert(0, "");
					if (com_CurrencyExchangeType.Items.Count > 1) {

						com_CurrencyExchangeType.SelectedIndex = 1;
					}
					com_CurrencyExchangeType_SelectedIndexChanged(null, null);
					break;

				case "CurrencyList":
					com_CurrencyList.EnableViewState = true;
					com_CurrencyList.Visible = true;
					com_CurrencyList.Initialize(ConnectionString);
					com_CurrencyList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_CurrencyList.Items.Insert(0, "");
					if (com_CurrencyList.Items.Count > 1) {

						com_CurrencyList.SelectedIndex = 1;
					}
					com_CurrencyList_SelectedIndexChanged(null, null);
					break;

				case "CustomerCardList":
					com_CustomerCardList.EnableViewState = true;
					com_CustomerCardList.Visible = true;
					com_CustomerCardList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null);
					com_CustomerCardList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_CustomerCardList.Items.Insert(0, "");
					if (com_CustomerCardList.Items.Count > 1) {

						com_CustomerCardList.SelectedIndex = 1;
					}
					com_CustomerCardList_SelectedIndexChanged(null, null);
					break;

				case "CustomerCardStatusList":
					com_CustomerCardStatusList.EnableViewState = true;
					com_CustomerCardStatusList.Visible = true;
					com_CustomerCardStatusList.Initialize(ConnectionString);
					com_CustomerCardStatusList.RefreshData(System.Data.SqlTypes.SqlString.Null);
					com_CustomerCardStatusList.Items.Insert(0, "");
					if (com_CustomerCardStatusList.Items.Count > 1) {

						com_CustomerCardStatusList.SelectedIndex = 1;
					}
					com_CustomerCardStatusList_SelectedIndexChanged(null, null);
					break;

				case "CustomerList":
					com_CustomerList.EnableViewState = true;
					com_CustomerList.Visible = true;
					com_CustomerList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null);
					com_CustomerList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_CustomerList.Items.Insert(0, "");
					if (com_CustomerList.Items.Count > 1) {

						com_CustomerList.SelectedIndex = 1;
					}
					com_CustomerList_SelectedIndexChanged(null, null);
					break;

				case "CustomerLoyaltyPointsAccumulationHistory":
					com_CustomerLoyaltyPointsAccumulationHistory.EnableViewState = true;
					com_CustomerLoyaltyPointsAccumulationHistory.Visible = true;
					com_CustomerLoyaltyPointsAccumulationHistory.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
					com_CustomerLoyaltyPointsAccumulationHistory.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_CustomerLoyaltyPointsAccumulationHistory.Items.Insert(0, "");
					if (com_CustomerLoyaltyPointsAccumulationHistory.Items.Count > 1) {

						com_CustomerLoyaltyPointsAccumulationHistory.SelectedIndex = 1;
					}
					com_CustomerLoyaltyPointsAccumulationHistory_SelectedIndexChanged(null, null);
					break;

				case "CustomerLoyaltyPointsRedeemHistory":
					com_CustomerLoyaltyPointsRedeemHistory.EnableViewState = true;
					com_CustomerLoyaltyPointsRedeemHistory.Visible = true;
					com_CustomerLoyaltyPointsRedeemHistory.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
					com_CustomerLoyaltyPointsRedeemHistory.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_CustomerLoyaltyPointsRedeemHistory.Items.Insert(0, "");
					if (com_CustomerLoyaltyPointsRedeemHistory.Items.Count > 1) {

						com_CustomerLoyaltyPointsRedeemHistory.SelectedIndex = 1;
					}
					com_CustomerLoyaltyPointsRedeemHistory_SelectedIndexChanged(null, null);
					break;

				case "EntityList":
					com_EntityList.EnableViewState = true;
					com_EntityList.Visible = true;
					com_EntityList.Initialize(ConnectionString);
					com_EntityList.RefreshData(System.Data.SqlTypes.SqlString.Null);
					com_EntityList.Items.Insert(0, "");
					if (com_EntityList.Items.Count > 1) {

						com_EntityList.SelectedIndex = 1;
					}
					com_EntityList_SelectedIndexChanged(null, null);
					break;

				case "GlobalSettings":
					com_GlobalSettings.EnableViewState = true;
					com_GlobalSettings.Visible = true;
					com_GlobalSettings.Initialize(ConnectionString);
					com_GlobalSettings.RefreshData(System.Data.SqlTypes.SqlByte.Null);
					com_GlobalSettings.Items.Insert(0, "");
					if (com_GlobalSettings.Items.Count > 1) {

						com_GlobalSettings.SelectedIndex = 1;
					}
					com_GlobalSettings_SelectedIndexChanged(null, null);
					break;

				case "LocationList":
					com_LocationList.EnableViewState = true;
					com_LocationList.Visible = true;
					com_LocationList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
					com_LocationList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_LocationList.Items.Insert(0, "");
					if (com_LocationList.Items.Count > 1) {

						com_LocationList.SelectedIndex = 1;
					}
					com_LocationList_SelectedIndexChanged(null, null);
					break;

				case "LocationTree":
					com_LocationTree.EnableViewState = true;
					com_LocationTree.Visible = true;
					com_LocationTree.Initialize(ConnectionString);
					com_LocationTree.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_LocationTree.Items.Insert(0, "");
					if (com_LocationTree.Items.Count > 1) {

						com_LocationTree.SelectedIndex = 1;
					}
					com_LocationTree_SelectedIndexChanged(null, null);
					break;

				case "MasterCountryList":
					com_MasterCountryList.EnableViewState = true;
					com_MasterCountryList.Visible = true;
					com_MasterCountryList.Initialize(ConnectionString);
					com_MasterCountryList.RefreshData(System.Data.SqlTypes.SqlString.Null);
					com_MasterCountryList.Items.Insert(0, "");
					if (com_MasterCountryList.Items.Count > 1) {

						com_MasterCountryList.SelectedIndex = 1;
					}
					com_MasterCountryList_SelectedIndexChanged(null, null);
					break;

				case "MasterModuleList":
					com_MasterModuleList.EnableViewState = true;
					com_MasterModuleList.Visible = true;
					com_MasterModuleList.Initialize(ConnectionString);
					com_MasterModuleList.RefreshData(System.Data.SqlTypes.SqlString.Null);
					com_MasterModuleList.Items.Insert(0, "");
					if (com_MasterModuleList.Items.Count > 1) {

						com_MasterModuleList.SelectedIndex = 1;
					}
					com_MasterModuleList_SelectedIndexChanged(null, null);
					break;

				case "OFACBannedNameList":
					com_OFACBannedNameList.EnableViewState = true;
					com_OFACBannedNameList.Visible = true;
					com_OFACBannedNameList.Initialize(ConnectionString);
					com_OFACBannedNameList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_OFACBannedNameList.Items.Insert(0, "");
					if (com_OFACBannedNameList.Items.Count > 1) {

						com_OFACBannedNameList.SelectedIndex = 1;
					}
					com_OFACBannedNameList_SelectedIndexChanged(null, null);
					break;

				case "PayInAgentDifferenceIncomeAccount":
					com_PayInAgentDifferenceIncomeAccount.EnableViewState = true;
					com_PayInAgentDifferenceIncomeAccount.Visible = true;
					com_PayInAgentDifferenceIncomeAccount.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
					com_PayInAgentDifferenceIncomeAccount.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_PayInAgentDifferenceIncomeAccount.Items.Insert(0, "");
					if (com_PayInAgentDifferenceIncomeAccount.Items.Count > 1) {

						com_PayInAgentDifferenceIncomeAccount.SelectedIndex = 1;
					}
					com_PayInAgentDifferenceIncomeAccount_SelectedIndexChanged(null, null);
					break;

				case "PaymentHistory":
					com_PaymentHistory.EnableViewState = true;
					com_PaymentHistory.Visible = true;
					com_PaymentHistory.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null);
					com_PaymentHistory.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_PaymentHistory.Items.Insert(0, "");
					if (com_PaymentHistory.Items.Count > 1) {

						com_PaymentHistory.SelectedIndex = 1;
					}
					com_PaymentHistory_SelectedIndexChanged(null, null);
					break;

				case "PaymentModeBaseTypeList":
					com_PaymentModeBaseTypeList.EnableViewState = true;
					com_PaymentModeBaseTypeList.Visible = true;
					com_PaymentModeBaseTypeList.Initialize(ConnectionString);
					com_PaymentModeBaseTypeList.RefreshData(System.Data.SqlTypes.SqlString.Null);
					com_PaymentModeBaseTypeList.Items.Insert(0, "");
					if (com_PaymentModeBaseTypeList.Items.Count > 1) {

						com_PaymentModeBaseTypeList.SelectedIndex = 1;
					}
					com_PaymentModeBaseTypeList_SelectedIndexChanged(null, null);
					break;

				case "PaymentModeList":
					com_PaymentModeList.EnableViewState = true;
					com_PaymentModeList.Visible = true;
					com_PaymentModeList.Initialize(ConnectionString, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
					com_PaymentModeList.RefreshData(System.Data.SqlTypes.SqlString.Null);
					com_PaymentModeList.Items.Insert(0, "");
					if (com_PaymentModeList.Items.Count > 1) {

						com_PaymentModeList.SelectedIndex = 1;
					}
					com_PaymentModeList_SelectedIndexChanged(null, null);
					break;

				case "PaymentType":
					com_PaymentType.EnableViewState = true;
					com_PaymentType.Visible = true;
					com_PaymentType.Initialize(ConnectionString);
					com_PaymentType.RefreshData(System.Data.SqlTypes.SqlString.Null);
					com_PaymentType.Items.Insert(0, "");
					if (com_PaymentType.Items.Count > 1) {

						com_PaymentType.SelectedIndex = 1;
					}
					com_PaymentType_SelectedIndexChanged(null, null);
					break;

				case "ProductsList":
					com_ProductsList.EnableViewState = true;
					com_ProductsList.Visible = true;
					com_ProductsList.Initialize(ConnectionString);
					com_ProductsList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_ProductsList.Items.Insert(0, "");
					if (com_ProductsList.Items.Count > 1) {

						com_ProductsList.SelectedIndex = 1;
					}
					com_ProductsList_SelectedIndexChanged(null, null);
					break;

				case "PurposeOfTransferList":
					com_PurposeOfTransferList.EnableViewState = true;
					com_PurposeOfTransferList.Visible = true;
					com_PurposeOfTransferList.Initialize(ConnectionString, System.Data.SqlTypes.SqlString.Null);
					com_PurposeOfTransferList.RefreshData(System.Data.SqlTypes.SqlString.Null);
					com_PurposeOfTransferList.Items.Insert(0, "");
					if (com_PurposeOfTransferList.Items.Count > 1) {

						com_PurposeOfTransferList.SelectedIndex = 1;
					}
					com_PurposeOfTransferList_SelectedIndexChanged(null, null);
					break;

				case "TransactionDetails":
					com_TransactionDetails.EnableViewState = true;
					com_TransactionDetails.Visible = true;
					com_TransactionDetails.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
					com_TransactionDetails.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_TransactionDetails.Items.Insert(0, "");
					if (com_TransactionDetails.Items.Count > 1) {

						com_TransactionDetails.SelectedIndex = 1;
					}
					com_TransactionDetails_SelectedIndexChanged(null, null);
					break;

				case "TransactionDraftList":
					com_TransactionDraftList.EnableViewState = true;
					com_TransactionDraftList.Visible = true;
					com_TransactionDraftList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null);
					com_TransactionDraftList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_TransactionDraftList.Items.Insert(0, "");
					if (com_TransactionDraftList.Items.Count > 1) {

						com_TransactionDraftList.SelectedIndex = 1;
					}
					com_TransactionDraftList_SelectedIndexChanged(null, null);
					break;

				case "TransactionModificationMessageList":
					com_TransactionModificationMessageList.EnableViewState = true;
					com_TransactionModificationMessageList.Visible = true;
					com_TransactionModificationMessageList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null);
					com_TransactionModificationMessageList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_TransactionModificationMessageList.Items.Insert(0, "");
					if (com_TransactionModificationMessageList.Items.Count > 1) {

						com_TransactionModificationMessageList.SelectedIndex = 1;
					}
					com_TransactionModificationMessageList_SelectedIndexChanged(null, null);
					break;

				case "TransactionSettlementHistory":
					com_TransactionSettlementHistory.EnableViewState = true;
					com_TransactionSettlementHistory.Visible = true;
					com_TransactionSettlementHistory.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
					com_TransactionSettlementHistory.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_TransactionSettlementHistory.Items.Insert(0, "");
					if (com_TransactionSettlementHistory.Items.Count > 1) {

						com_TransactionSettlementHistory.SelectedIndex = 1;
					}
					com_TransactionSettlementHistory_SelectedIndexChanged(null, null);
					break;

				case "TransactionSettlementStatusList":
					com_TransactionSettlementStatusList.EnableViewState = true;
					com_TransactionSettlementStatusList.Visible = true;
					com_TransactionSettlementStatusList.Initialize(ConnectionString);
					com_TransactionSettlementStatusList.RefreshData(System.Data.SqlTypes.SqlString.Null);
					com_TransactionSettlementStatusList.Items.Insert(0, "");
					if (com_TransactionSettlementStatusList.Items.Count > 1) {

						com_TransactionSettlementStatusList.SelectedIndex = 1;
					}
					com_TransactionSettlementStatusList_SelectedIndexChanged(null, null);
					break;

				case "TransactionStatusList":
					com_TransactionStatusList.EnableViewState = true;
					com_TransactionStatusList.Visible = true;
					com_TransactionStatusList.Initialize(ConnectionString);
					com_TransactionStatusList.RefreshData(System.Data.SqlTypes.SqlString.Null);
					com_TransactionStatusList.Items.Insert(0, "");
					if (com_TransactionStatusList.Items.Count > 1) {

						com_TransactionStatusList.SelectedIndex = 1;
					}
					com_TransactionStatusList_SelectedIndexChanged(null, null);
					break;

				case "TransactionTypeList":
					com_TransactionTypeList.EnableViewState = true;
					com_TransactionTypeList.Visible = true;
					com_TransactionTypeList.Initialize(ConnectionString);
					com_TransactionTypeList.RefreshData(System.Data.SqlTypes.SqlString.Null);
					com_TransactionTypeList.Items.Insert(0, "");
					if (com_TransactionTypeList.Items.Count > 1) {

						com_TransactionTypeList.SelectedIndex = 1;
					}
					com_TransactionTypeList_SelectedIndexChanged(null, null);
					break;

				case "TransitionAccountDetails":
					com_TransitionAccountDetails.EnableViewState = true;
					com_TransitionAccountDetails.Visible = true;
					com_TransitionAccountDetails.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null);
					com_TransitionAccountDetails.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_TransitionAccountDetails.Items.Insert(0, "");
					if (com_TransitionAccountDetails.Items.Count > 1) {

						com_TransitionAccountDetails.SelectedIndex = 1;
					}
					com_TransitionAccountDetails_SelectedIndexChanged(null, null);
					break;

				case "UserAuditList":
					com_UserAuditList.EnableViewState = true;
					com_UserAuditList.Visible = true;
					com_UserAuditList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null);
					com_UserAuditList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_UserAuditList.Items.Insert(0, "");
					if (com_UserAuditList.Items.Count > 1) {

						com_UserAuditList.SelectedIndex = 1;
					}
					com_UserAuditList_SelectedIndexChanged(null, null);
					break;

				case "UserList":
					com_UserList.EnableViewState = true;
					com_UserList.Visible = true;
					com_UserList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
					com_UserList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_UserList.Items.Insert(0, "");
					if (com_UserList.Items.Count > 1) {

						com_UserList.SelectedIndex = 1;
					}
					com_UserList_SelectedIndexChanged(null, null);
					break;

				case "UserRoleAssignmentList":
					com_UserRoleAssignmentList.EnableViewState = true;
					com_UserRoleAssignmentList.Visible = true;
					com_UserRoleAssignmentList.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null);
					com_UserRoleAssignmentList.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
					com_UserRoleAssignmentList.Items.Insert(0, "");
					if (com_UserRoleAssignmentList.Items.Count > 1) {

						com_UserRoleAssignmentList.SelectedIndex = 1;
					}
					com_UserRoleAssignmentList_SelectedIndexChanged(null, null);
					break;

				case "UserRoleList":
					com_UserRoleList.EnableViewState = true;
					com_UserRoleList.Visible = true;
					com_UserRoleList.Initialize(ConnectionString, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
					com_UserRoleList.RefreshData(System.Data.SqlTypes.SqlString.Null);
					com_UserRoleList.Items.Insert(0, "");
					if (com_UserRoleList.Items.Count > 1) {

						com_UserRoleList.SelectedIndex = 1;
					}
					com_UserRoleList_SelectedIndexChanged(null, null);
					break;

				case "UserRoleTypeList":
					com_UserRoleTypeList.EnableViewState = true;
					com_UserRoleTypeList.Visible = true;
					com_UserRoleTypeList.Initialize(ConnectionString);
					com_UserRoleTypeList.RefreshData(System.Data.SqlTypes.SqlString.Null);
					com_UserRoleTypeList.Items.Insert(0, "");
					if (com_UserRoleTypeList.Items.Count > 1) {

						com_UserRoleTypeList.SelectedIndex = 1;
					}
					com_UserRoleTypeList_SelectedIndexChanged(null, null);
					break;

				default:
					break;
			}
		}

		private void Page_Init(object sender, EventArgs e) {

			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
		}

		private void comDatabaseTablesList_SelectedIndexChanged(object sender, System.EventArgs e) {

			UpdateRecords();
		}

		private void com_AgencyCommissionIncomeAccountDetails_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_AgencyCommissionIncomeAccountDetails.SelectedIndex == -1 || com_AgencyCommissionIncomeAccountDetails.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_AgencyCommissionIncomeAccountDetails.aspx?Action=Edit&ID=" + com_AgencyCommissionIncomeAccountDetails.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_AgencyCommissionIncomeAccountDetails.aspx?Action=Add";
			ComboBoxName = "com_AgencyCommissionIncomeAccountDetails";
		}
		private void com_AgencyDifferenceIncomeAccountDetails_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_AgencyDifferenceIncomeAccountDetails.SelectedIndex == -1 || com_AgencyDifferenceIncomeAccountDetails.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_AgencyDifferenceIncomeAccountDetails.aspx?Action=Edit&ID=" + com_AgencyDifferenceIncomeAccountDetails.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_AgencyDifferenceIncomeAccountDetails.aspx?Action=Add";
			ComboBoxName = "com_AgencyDifferenceIncomeAccountDetails";
		}
		private void com_AgencyExchangeRateList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_AgencyExchangeRateList.SelectedIndex == -1 || com_AgencyExchangeRateList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_AgencyExchangeRateList.aspx?Action=Edit&ID=" + com_AgencyExchangeRateList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_AgencyExchangeRateList.aspx?Action=Add";
			ComboBoxName = "com_AgencyExchangeRateList";
		}
		private void com_AgentAccountDetails_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_AgentAccountDetails.SelectedIndex == -1 || com_AgentAccountDetails.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_AgentAccountDetails.aspx?Action=Edit&ID=" + com_AgentAccountDetails.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_AgentAccountDetails.aspx?Action=Add";
			ComboBoxName = "com_AgentAccountDetails";
		}
		private void com_AgentAccountType_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_AgentAccountType.SelectedIndex == -1 || com_AgentAccountType.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_AgentAccountType.aspx?Action=Edit&ID=" + com_AgentAccountType.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_AgentAccountType.aspx?Action=Add";
			ComboBoxName = "com_AgentAccountType";
		}
		private void com_AgentAvailablePaymentModeList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_AgentAvailablePaymentModeList.SelectedIndex == -1 || com_AgentAvailablePaymentModeList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_AgentAvailablePaymentModeList.aspx?Action=Edit&ID=" + com_AgentAvailablePaymentModeList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_AgentAvailablePaymentModeList.aspx?Action=Add";
			ComboBoxName = "com_AgentAvailablePaymentModeList";
		}
		private void com_AgentCommissionIncomeAccount_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_AgentCommissionIncomeAccount.SelectedIndex == -1 || com_AgentCommissionIncomeAccount.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_AgentCommissionIncomeAccount.aspx?Action=Edit&ID=" + com_AgentCommissionIncomeAccount.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_AgentCommissionIncomeAccount.aspx?Action=Add";
			ComboBoxName = "com_AgentCommissionIncomeAccount";
		}
		private void com_AgentCommissionSplitList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_AgentCommissionSplitList.SelectedIndex == -1 || com_AgentCommissionSplitList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_AgentCommissionSplitList.aspx?Action=Edit&ID=" + com_AgentCommissionSplitList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_AgentCommissionSplitList.aspx?Action=Add";
			ComboBoxName = "com_AgentCommissionSplitList";
		}
		private void com_AgentExchangeRateList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_AgentExchangeRateList.SelectedIndex == -1 || com_AgentExchangeRateList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_AgentExchangeRateList.aspx?Action=Edit&ID=" + com_AgentExchangeRateList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_AgentExchangeRateList.aspx?Action=Add";
			ComboBoxName = "com_AgentExchangeRateList";
		}
		private void com_AgentGroupList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_AgentGroupList.SelectedIndex == -1 || com_AgentGroupList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_AgentGroupList.aspx?Action=Edit&ID=" + com_AgentGroupList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_AgentGroupList.aspx?Action=Add";
			ComboBoxName = "com_AgentGroupList";
		}
		private void com_AgentLocationList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_AgentLocationList.SelectedIndex == -1 || com_AgentLocationList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_AgentLocationList.aspx?Action=Edit&ID=" + com_AgentLocationList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_AgentLocationList.aspx?Action=Add";
			ComboBoxName = "com_AgentLocationList";
		}
		private void com_AgentMaster_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_AgentMaster.SelectedIndex == -1 || com_AgentMaster.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_AgentMaster.aspx?Action=Edit&ID=" + com_AgentMaster.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_AgentMaster.aspx?Action=Add";
			ComboBoxName = "com_AgentMaster";
		}
		private void com_BankExchangeRateList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_BankExchangeRateList.SelectedIndex == -1 || com_BankExchangeRateList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_BankExchangeRateList.aspx?Action=Edit&ID=" + com_BankExchangeRateList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_BankExchangeRateList.aspx?Action=Add";
			ComboBoxName = "com_BankExchangeRateList";
		}
		private void com_BankList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_BankList.SelectedIndex == -1 || com_BankList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_BankList.aspx?Action=Edit&ID=" + com_BankList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_BankList.aspx?Action=Add";
			ComboBoxName = "com_BankList";
		}
		private void com_BeneficeryBankList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_BeneficeryBankList.SelectedIndex == -1 || com_BeneficeryBankList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_BeneficeryBankList.aspx?Action=Edit&ID=" + com_BeneficeryBankList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_BeneficeryBankList.aspx?Action=Add";
			ComboBoxName = "com_BeneficeryBankList";
		}
		private void com_CommissionCurrencyType_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_CommissionCurrencyType.SelectedIndex == -1 || com_CommissionCurrencyType.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_CommissionCurrencyType.aspx?Action=Edit&ID=" + com_CommissionCurrencyType.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_CommissionCurrencyType.aspx?Action=Add";
			ComboBoxName = "com_CommissionCurrencyType";
		}
		private void com_CommissionSlabMaster_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_CommissionSlabMaster.SelectedIndex == -1 || com_CommissionSlabMaster.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_CommissionSlabMaster.aspx?Action=Edit&ID=" + com_CommissionSlabMaster.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_CommissionSlabMaster.aspx?Action=Add";
			ComboBoxName = "com_CommissionSlabMaster";
		}
		private void com_CommissionSplitTypeList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_CommissionSplitTypeList.SelectedIndex == -1 || com_CommissionSplitTypeList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_CommissionSplitTypeList.aspx?Action=Edit&ID=" + com_CommissionSplitTypeList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_CommissionSplitTypeList.aspx?Action=Add";
			ComboBoxName = "com_CommissionSplitTypeList";
		}
		private void com_CountryAllowedOutboundCurrencyList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_CountryAllowedOutboundCurrencyList.SelectedIndex == -1 || com_CountryAllowedOutboundCurrencyList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_CountryAllowedOutboundCurrencyList.aspx?Action=Edit&ID=" + com_CountryAllowedOutboundCurrencyList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_CountryAllowedOutboundCurrencyList.aspx?Action=Add";
			ComboBoxName = "com_CountryAllowedOutboundCurrencyList";
		}
		private void com_CountryAvailablePaymentModeList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_CountryAvailablePaymentModeList.SelectedIndex == -1 || com_CountryAvailablePaymentModeList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_CountryAvailablePaymentModeList.aspx?Action=Edit&ID=" + com_CountryAvailablePaymentModeList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_CountryAvailablePaymentModeList.aspx?Action=Add";
			ComboBoxName = "com_CountryAvailablePaymentModeList";
		}
		private void com_CountryList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_CountryList.SelectedIndex == -1 || com_CountryList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_CountryList.aspx?Action=Edit&ID=" + com_CountryList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_CountryList.aspx?Action=Add";
			ComboBoxName = "com_CountryList";
		}
		private void com_CountryTransactionPermissionList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_CountryTransactionPermissionList.SelectedIndex == -1 || com_CountryTransactionPermissionList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_CountryTransactionPermissionList.aspx?Action=Edit&ID=" + com_CountryTransactionPermissionList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_CountryTransactionPermissionList.aspx?Action=Add";
			ComboBoxName = "com_CountryTransactionPermissionList";
		}
		private void com_CountryTransactionPermissionTypeList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_CountryTransactionPermissionTypeList.SelectedIndex == -1 || com_CountryTransactionPermissionTypeList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_CountryTransactionPermissionTypeList.aspx?Action=Edit&ID=" + com_CountryTransactionPermissionTypeList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_CountryTransactionPermissionTypeList.aspx?Action=Add";
			ComboBoxName = "com_CountryTransactionPermissionTypeList";
		}
		private void com_CurrencyExchangeType_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_CurrencyExchangeType.SelectedIndex == -1 || com_CurrencyExchangeType.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_CurrencyExchangeType.aspx?Action=Edit&ID=" + com_CurrencyExchangeType.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_CurrencyExchangeType.aspx?Action=Add";
			ComboBoxName = "com_CurrencyExchangeType";
		}
		private void com_CurrencyList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_CurrencyList.SelectedIndex == -1 || com_CurrencyList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_CurrencyList.aspx?Action=Edit&ID=" + com_CurrencyList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_CurrencyList.aspx?Action=Add";
			ComboBoxName = "com_CurrencyList";
		}
		private void com_CustomerCardList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_CustomerCardList.SelectedIndex == -1 || com_CustomerCardList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_CustomerCardList.aspx?Action=Edit&ID=" + com_CustomerCardList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_CustomerCardList.aspx?Action=Add";
			ComboBoxName = "com_CustomerCardList";
		}
		private void com_CustomerCardStatusList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_CustomerCardStatusList.SelectedIndex == -1 || com_CustomerCardStatusList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_CustomerCardStatusList.aspx?Action=Edit&ID=" + com_CustomerCardStatusList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_CustomerCardStatusList.aspx?Action=Add";
			ComboBoxName = "com_CustomerCardStatusList";
		}
		private void com_CustomerList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_CustomerList.SelectedIndex == -1 || com_CustomerList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_CustomerList.aspx?Action=Edit&ID=" + com_CustomerList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_CustomerList.aspx?Action=Add";
			ComboBoxName = "com_CustomerList";
		}
		private void com_CustomerLoyaltyPointsAccumulationHistory_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_CustomerLoyaltyPointsAccumulationHistory.SelectedIndex == -1 || com_CustomerLoyaltyPointsAccumulationHistory.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_CustomerLoyaltyPointsAccumulationHistory.aspx?Action=Edit&ID=" + com_CustomerLoyaltyPointsAccumulationHistory.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_CustomerLoyaltyPointsAccumulationHistory.aspx?Action=Add";
			ComboBoxName = "com_CustomerLoyaltyPointsAccumulationHistory";
		}
		private void com_CustomerLoyaltyPointsRedeemHistory_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_CustomerLoyaltyPointsRedeemHistory.SelectedIndex == -1 || com_CustomerLoyaltyPointsRedeemHistory.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_CustomerLoyaltyPointsRedeemHistory.aspx?Action=Edit&ID=" + com_CustomerLoyaltyPointsRedeemHistory.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_CustomerLoyaltyPointsRedeemHistory.aspx?Action=Add";
			ComboBoxName = "com_CustomerLoyaltyPointsRedeemHistory";
		}
		private void com_EntityList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_EntityList.SelectedIndex == -1 || com_EntityList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_EntityList.aspx?Action=Edit&ID=" + com_EntityList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_EntityList.aspx?Action=Add";
			ComboBoxName = "com_EntityList";
		}
		private void com_GlobalSettings_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_GlobalSettings.SelectedIndex == -1 || com_GlobalSettings.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_GlobalSettings.aspx?Action=Edit&ID=" + com_GlobalSettings.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_GlobalSettings.aspx?Action=Add";
			ComboBoxName = "com_GlobalSettings";
		}
		private void com_LocationList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_LocationList.SelectedIndex == -1 || com_LocationList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_LocationList.aspx?Action=Edit&ID=" + com_LocationList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_LocationList.aspx?Action=Add";
			ComboBoxName = "com_LocationList";
		}
		private void com_LocationTree_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_LocationTree.SelectedIndex == -1 || com_LocationTree.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_LocationTree.aspx?Action=Edit&ID=" + com_LocationTree.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_LocationTree.aspx?Action=Add";
			ComboBoxName = "com_LocationTree";
		}
		private void com_MasterCountryList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_MasterCountryList.SelectedIndex == -1 || com_MasterCountryList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_MasterCountryList.aspx?Action=Edit&ID=" + com_MasterCountryList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_MasterCountryList.aspx?Action=Add";
			ComboBoxName = "com_MasterCountryList";
		}
		private void com_MasterModuleList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_MasterModuleList.SelectedIndex == -1 || com_MasterModuleList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_MasterModuleList.aspx?Action=Edit&ID=" + com_MasterModuleList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_MasterModuleList.aspx?Action=Add";
			ComboBoxName = "com_MasterModuleList";
		}
		private void com_OFACBannedNameList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_OFACBannedNameList.SelectedIndex == -1 || com_OFACBannedNameList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_OFACBannedNameList.aspx?Action=Edit&ID=" + com_OFACBannedNameList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_OFACBannedNameList.aspx?Action=Add";
			ComboBoxName = "com_OFACBannedNameList";
		}
		private void com_PayInAgentDifferenceIncomeAccount_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_PayInAgentDifferenceIncomeAccount.SelectedIndex == -1 || com_PayInAgentDifferenceIncomeAccount.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_PayInAgentDifferenceIncomeAccount.aspx?Action=Edit&ID=" + com_PayInAgentDifferenceIncomeAccount.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_PayInAgentDifferenceIncomeAccount.aspx?Action=Add";
			ComboBoxName = "com_PayInAgentDifferenceIncomeAccount";
		}
		private void com_PaymentHistory_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_PaymentHistory.SelectedIndex == -1 || com_PaymentHistory.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_PaymentHistory.aspx?Action=Edit&ID=" + com_PaymentHistory.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_PaymentHistory.aspx?Action=Add";
			ComboBoxName = "com_PaymentHistory";
		}
		private void com_PaymentModeBaseTypeList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_PaymentModeBaseTypeList.SelectedIndex == -1 || com_PaymentModeBaseTypeList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_PaymentModeBaseTypeList.aspx?Action=Edit&ID=" + com_PaymentModeBaseTypeList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_PaymentModeBaseTypeList.aspx?Action=Add";
			ComboBoxName = "com_PaymentModeBaseTypeList";
		}
		private void com_PaymentModeList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_PaymentModeList.SelectedIndex == -1 || com_PaymentModeList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_PaymentModeList.aspx?Action=Edit&ID=" + com_PaymentModeList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_PaymentModeList.aspx?Action=Add";
			ComboBoxName = "com_PaymentModeList";
		}
		private void com_PaymentType_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_PaymentType.SelectedIndex == -1 || com_PaymentType.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_PaymentType.aspx?Action=Edit&ID=" + com_PaymentType.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_PaymentType.aspx?Action=Add";
			ComboBoxName = "com_PaymentType";
		}
		private void com_ProductsList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_ProductsList.SelectedIndex == -1 || com_ProductsList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_ProductsList.aspx?Action=Edit&ID=" + com_ProductsList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_ProductsList.aspx?Action=Add";
			ComboBoxName = "com_ProductsList";
		}
		private void com_PurposeOfTransferList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_PurposeOfTransferList.SelectedIndex == -1 || com_PurposeOfTransferList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_PurposeOfTransferList.aspx?Action=Edit&ID=" + com_PurposeOfTransferList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_PurposeOfTransferList.aspx?Action=Add";
			ComboBoxName = "com_PurposeOfTransferList";
		}
		private void com_TransactionDetails_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_TransactionDetails.SelectedIndex == -1 || com_TransactionDetails.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_TransactionDetails.aspx?Action=Edit&ID=" + com_TransactionDetails.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_TransactionDetails.aspx?Action=Add";
			ComboBoxName = "com_TransactionDetails";
		}
		private void com_TransactionDraftList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_TransactionDraftList.SelectedIndex == -1 || com_TransactionDraftList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_TransactionDraftList.aspx?Action=Edit&ID=" + com_TransactionDraftList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_TransactionDraftList.aspx?Action=Add";
			ComboBoxName = "com_TransactionDraftList";
		}
		private void com_TransactionModificationMessageList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_TransactionModificationMessageList.SelectedIndex == -1 || com_TransactionModificationMessageList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_TransactionModificationMessageList.aspx?Action=Edit&ID=" + com_TransactionModificationMessageList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_TransactionModificationMessageList.aspx?Action=Add";
			ComboBoxName = "com_TransactionModificationMessageList";
		}
		private void com_TransactionSettlementHistory_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_TransactionSettlementHistory.SelectedIndex == -1 || com_TransactionSettlementHistory.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_TransactionSettlementHistory.aspx?Action=Edit&ID=" + com_TransactionSettlementHistory.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_TransactionSettlementHistory.aspx?Action=Add";
			ComboBoxName = "com_TransactionSettlementHistory";
		}
		private void com_TransactionSettlementStatusList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_TransactionSettlementStatusList.SelectedIndex == -1 || com_TransactionSettlementStatusList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_TransactionSettlementStatusList.aspx?Action=Edit&ID=" + com_TransactionSettlementStatusList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_TransactionSettlementStatusList.aspx?Action=Add";
			ComboBoxName = "com_TransactionSettlementStatusList";
		}
		private void com_TransactionStatusList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_TransactionStatusList.SelectedIndex == -1 || com_TransactionStatusList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_TransactionStatusList.aspx?Action=Edit&ID=" + com_TransactionStatusList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_TransactionStatusList.aspx?Action=Add";
			ComboBoxName = "com_TransactionStatusList";
		}
		private void com_TransactionTypeList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_TransactionTypeList.SelectedIndex == -1 || com_TransactionTypeList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_TransactionTypeList.aspx?Action=Edit&ID=" + com_TransactionTypeList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_TransactionTypeList.aspx?Action=Add";
			ComboBoxName = "com_TransactionTypeList";
		}
		private void com_TransitionAccountDetails_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_TransitionAccountDetails.SelectedIndex == -1 || com_TransitionAccountDetails.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_TransitionAccountDetails.aspx?Action=Edit&ID=" + com_TransitionAccountDetails.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_TransitionAccountDetails.aspx?Action=Add";
			ComboBoxName = "com_TransitionAccountDetails";
		}
		private void com_UserAuditList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_UserAuditList.SelectedIndex == -1 || com_UserAuditList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_UserAuditList.aspx?Action=Edit&ID=" + com_UserAuditList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_UserAuditList.aspx?Action=Add";
			ComboBoxName = "com_UserAuditList";
		}
		private void com_UserList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_UserList.SelectedIndex == -1 || com_UserList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_UserList.aspx?Action=Edit&ID=" + com_UserList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_UserList.aspx?Action=Add";
			ComboBoxName = "com_UserList";
		}
		private void com_UserRoleAssignmentList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_UserRoleAssignmentList.SelectedIndex == -1 || com_UserRoleAssignmentList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_UserRoleAssignmentList.aspx?Action=Edit&ID=" + com_UserRoleAssignmentList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_UserRoleAssignmentList.aspx?Action=Add";
			ComboBoxName = "com_UserRoleAssignmentList";
		}
		private void com_UserRoleList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_UserRoleList.SelectedIndex == -1 || com_UserRoleList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_UserRoleList.aspx?Action=Edit&ID=" + com_UserRoleList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_UserRoleList.aspx?Action=Add";
			ComboBoxName = "com_UserRoleList";
		}
		private void com_UserRoleTypeList_SelectedIndexChanged(object sender, System.EventArgs e) {

			if (com_UserRoleTypeList.SelectedIndex == -1 || com_UserRoleTypeList.SelectedIndex == 0) {

				FrameEditURL = "about:blank";
			}
			else {

				FrameEditURL = "WebForm_UserRoleTypeList.aspx?Action=Edit&ID=" + com_UserRoleTypeList.SelectedItem.Value;
			}
			FrameAddURL = "WebForm_UserRoleTypeList.aspx?Action=Add";
			ComboBoxName = "com_UserRoleTypeList";
		}

		#region Web Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {

			this.comDatabaseTablesList.SelectedIndexChanged += new System.EventHandler(this.comDatabaseTablesList_SelectedIndexChanged);
			this.com_AgencyCommissionIncomeAccountDetails.SelectedIndexChanged += new System.EventHandler(this.com_AgencyCommissionIncomeAccountDetails_SelectedIndexChanged);
			this.com_AgencyDifferenceIncomeAccountDetails.SelectedIndexChanged += new System.EventHandler(this.com_AgencyDifferenceIncomeAccountDetails_SelectedIndexChanged);
			this.com_AgencyExchangeRateList.SelectedIndexChanged += new System.EventHandler(this.com_AgencyExchangeRateList_SelectedIndexChanged);
			this.com_AgentAccountDetails.SelectedIndexChanged += new System.EventHandler(this.com_AgentAccountDetails_SelectedIndexChanged);
			this.com_AgentAccountType.SelectedIndexChanged += new System.EventHandler(this.com_AgentAccountType_SelectedIndexChanged);
			this.com_AgentAvailablePaymentModeList.SelectedIndexChanged += new System.EventHandler(this.com_AgentAvailablePaymentModeList_SelectedIndexChanged);
			this.com_AgentCommissionIncomeAccount.SelectedIndexChanged += new System.EventHandler(this.com_AgentCommissionIncomeAccount_SelectedIndexChanged);
			this.com_AgentCommissionSplitList.SelectedIndexChanged += new System.EventHandler(this.com_AgentCommissionSplitList_SelectedIndexChanged);
			this.com_AgentExchangeRateList.SelectedIndexChanged += new System.EventHandler(this.com_AgentExchangeRateList_SelectedIndexChanged);
			this.com_AgentGroupList.SelectedIndexChanged += new System.EventHandler(this.com_AgentGroupList_SelectedIndexChanged);
			this.com_AgentLocationList.SelectedIndexChanged += new System.EventHandler(this.com_AgentLocationList_SelectedIndexChanged);
			this.com_AgentMaster.SelectedIndexChanged += new System.EventHandler(this.com_AgentMaster_SelectedIndexChanged);
			this.com_BankExchangeRateList.SelectedIndexChanged += new System.EventHandler(this.com_BankExchangeRateList_SelectedIndexChanged);
			this.com_BankList.SelectedIndexChanged += new System.EventHandler(this.com_BankList_SelectedIndexChanged);
			this.com_BeneficeryBankList.SelectedIndexChanged += new System.EventHandler(this.com_BeneficeryBankList_SelectedIndexChanged);
			this.com_CommissionCurrencyType.SelectedIndexChanged += new System.EventHandler(this.com_CommissionCurrencyType_SelectedIndexChanged);
			this.com_CommissionSlabMaster.SelectedIndexChanged += new System.EventHandler(this.com_CommissionSlabMaster_SelectedIndexChanged);
			this.com_CommissionSplitTypeList.SelectedIndexChanged += new System.EventHandler(this.com_CommissionSplitTypeList_SelectedIndexChanged);
			this.com_CountryAllowedOutboundCurrencyList.SelectedIndexChanged += new System.EventHandler(this.com_CountryAllowedOutboundCurrencyList_SelectedIndexChanged);
			this.com_CountryAvailablePaymentModeList.SelectedIndexChanged += new System.EventHandler(this.com_CountryAvailablePaymentModeList_SelectedIndexChanged);
			this.com_CountryList.SelectedIndexChanged += new System.EventHandler(this.com_CountryList_SelectedIndexChanged);
			this.com_CountryTransactionPermissionList.SelectedIndexChanged += new System.EventHandler(this.com_CountryTransactionPermissionList_SelectedIndexChanged);
			this.com_CountryTransactionPermissionTypeList.SelectedIndexChanged += new System.EventHandler(this.com_CountryTransactionPermissionTypeList_SelectedIndexChanged);
			this.com_CurrencyExchangeType.SelectedIndexChanged += new System.EventHandler(this.com_CurrencyExchangeType_SelectedIndexChanged);
			this.com_CurrencyList.SelectedIndexChanged += new System.EventHandler(this.com_CurrencyList_SelectedIndexChanged);
			this.com_CustomerCardList.SelectedIndexChanged += new System.EventHandler(this.com_CustomerCardList_SelectedIndexChanged);
			this.com_CustomerCardStatusList.SelectedIndexChanged += new System.EventHandler(this.com_CustomerCardStatusList_SelectedIndexChanged);
			this.com_CustomerList.SelectedIndexChanged += new System.EventHandler(this.com_CustomerList_SelectedIndexChanged);
			this.com_CustomerLoyaltyPointsAccumulationHistory.SelectedIndexChanged += new System.EventHandler(this.com_CustomerLoyaltyPointsAccumulationHistory_SelectedIndexChanged);
			this.com_CustomerLoyaltyPointsRedeemHistory.SelectedIndexChanged += new System.EventHandler(this.com_CustomerLoyaltyPointsRedeemHistory_SelectedIndexChanged);
			this.com_EntityList.SelectedIndexChanged += new System.EventHandler(this.com_EntityList_SelectedIndexChanged);
			this.com_GlobalSettings.SelectedIndexChanged += new System.EventHandler(this.com_GlobalSettings_SelectedIndexChanged);
			this.com_LocationList.SelectedIndexChanged += new System.EventHandler(this.com_LocationList_SelectedIndexChanged);
			this.com_LocationTree.SelectedIndexChanged += new System.EventHandler(this.com_LocationTree_SelectedIndexChanged);
			this.com_MasterCountryList.SelectedIndexChanged += new System.EventHandler(this.com_MasterCountryList_SelectedIndexChanged);
			this.com_MasterModuleList.SelectedIndexChanged += new System.EventHandler(this.com_MasterModuleList_SelectedIndexChanged);
			this.com_OFACBannedNameList.SelectedIndexChanged += new System.EventHandler(this.com_OFACBannedNameList_SelectedIndexChanged);
			this.com_PayInAgentDifferenceIncomeAccount.SelectedIndexChanged += new System.EventHandler(this.com_PayInAgentDifferenceIncomeAccount_SelectedIndexChanged);
			this.com_PaymentHistory.SelectedIndexChanged += new System.EventHandler(this.com_PaymentHistory_SelectedIndexChanged);
			this.com_PaymentModeBaseTypeList.SelectedIndexChanged += new System.EventHandler(this.com_PaymentModeBaseTypeList_SelectedIndexChanged);
			this.com_PaymentModeList.SelectedIndexChanged += new System.EventHandler(this.com_PaymentModeList_SelectedIndexChanged);
			this.com_PaymentType.SelectedIndexChanged += new System.EventHandler(this.com_PaymentType_SelectedIndexChanged);
			this.com_ProductsList.SelectedIndexChanged += new System.EventHandler(this.com_ProductsList_SelectedIndexChanged);
			this.com_PurposeOfTransferList.SelectedIndexChanged += new System.EventHandler(this.com_PurposeOfTransferList_SelectedIndexChanged);
			this.com_TransactionDetails.SelectedIndexChanged += new System.EventHandler(this.com_TransactionDetails_SelectedIndexChanged);
			this.com_TransactionDraftList.SelectedIndexChanged += new System.EventHandler(this.com_TransactionDraftList_SelectedIndexChanged);
			this.com_TransactionModificationMessageList.SelectedIndexChanged += new System.EventHandler(this.com_TransactionModificationMessageList_SelectedIndexChanged);
			this.com_TransactionSettlementHistory.SelectedIndexChanged += new System.EventHandler(this.com_TransactionSettlementHistory_SelectedIndexChanged);
			this.com_TransactionSettlementStatusList.SelectedIndexChanged += new System.EventHandler(this.com_TransactionSettlementStatusList_SelectedIndexChanged);
			this.com_TransactionStatusList.SelectedIndexChanged += new System.EventHandler(this.com_TransactionStatusList_SelectedIndexChanged);
			this.com_TransactionTypeList.SelectedIndexChanged += new System.EventHandler(this.com_TransactionTypeList_SelectedIndexChanged);
			this.com_TransitionAccountDetails.SelectedIndexChanged += new System.EventHandler(this.com_TransitionAccountDetails_SelectedIndexChanged);
			this.com_UserAuditList.SelectedIndexChanged += new System.EventHandler(this.com_UserAuditList_SelectedIndexChanged);
			this.com_UserList.SelectedIndexChanged += new System.EventHandler(this.com_UserList_SelectedIndexChanged);
			this.com_UserRoleAssignmentList.SelectedIndexChanged += new System.EventHandler(this.com_UserRoleAssignmentList_SelectedIndexChanged);
			this.com_UserRoleList.SelectedIndexChanged += new System.EventHandler(this.com_UserRoleList_SelectedIndexChanged);
			this.com_UserRoleTypeList.SelectedIndexChanged += new System.EventHandler(this.com_UserRoleTypeList_SelectedIndexChanged);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion
	}
}
