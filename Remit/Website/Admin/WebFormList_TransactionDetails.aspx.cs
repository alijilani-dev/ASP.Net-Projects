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
using Evernet.MoneyExchange.DataClasses.StoredProcedures;

namespace Evernet.MoneyExchange.Web.Forms
{
	/// <summary>
	/// Summary description for WebFormList_TransactionDetails.
	/// </summary>
	public class WebFormList_TransactionDetails: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_TransactionDetails() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_TransactionDetails_SelectDisplay repeater_TransactionDetails_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CustomerList com_CustomerId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CustomerList com_BeneficeryId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_BeneficeryBankList com_BeneficeryBankId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_PaymentModeList com_PaymentMode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_PurposeOfTransferList com_PurposeOfTransfer;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CurrencyList com_PayInCurrencyId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CurrencyList com_PayOutCurrencyId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_BankList com_AssociatedBankId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_UserList com_PayInAgentUserId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentLocationList com_PayInAgentLocationId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_UserList com_PayOutAgentUserId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionStatusList com_Status;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionSettlementStatusList com_SettlementStatus;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Id;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_VoucherNumber;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_TransactionNumber;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_CustomerId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_BeneficeryId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_BeneficeryBankId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PaymentMode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PurposeOfTransfer;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayInCurrencyId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayInAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayOutCurrencyId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayOutAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Commission;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Question;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Answer;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_MessageToBeneficery;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_MessageToPayOutAgent;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_BankExchangeRateForPayInCurrency;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_BankExchangeRateForPayOutCurrency;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayInCurrencyGroup;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayOutCurrencyGroup;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_FinalBankExchangeRate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AgencyMarginPercent;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AgencyExchangeRate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AgentMarginPercent;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AgentExchangeRate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AssociatedBankId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayOutLocationId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayInAgentUserId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayInAgentLocationId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayInDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_RecommendedPayOutAgentId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_ActualPayOutAgentId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayOutAgentUserId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayOutDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_CollectedBeneficeryIdDetails;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_IsOpenTransaction;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Status;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_SettlementStatus;
		private System.Globalization.CultureInfo CurrentUserCulture;
		private void Page_Load(object sender, System.EventArgs e) {

			string Language = "en-US";
			if (Request.UserLanguages.Length != 0) {

				Language = Request.UserLanguages[0];
			}

			CurrentUserCulture = System.Globalization.CultureInfo.CreateSpecificCulture(Language);

			if (ConfigurationSettings.AppSettings["mexchange ConnectionString"] != null) {

				ConnectionString = ConfigurationSettings.AppSettings["mexchange ConnectionString"];
			}
			else if (Application["ConnectionString"] != null) {

				ConnectionString = Application["ConnectionString"].ToString().Trim();
			}

			if (!Page.IsPostBack) {

				// com_CustomerId
				System.Data.SqlTypes.SqlGuid colCustomerId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["CustomerId"] != String.Empty) {
				
					try {
					
						colCustomerId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["CustomerId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_CustomerId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null);
				try {

					com_CustomerId.RefreshData(colCustomerId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CustomerList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CustomerList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_CustomerId.Items.Insert(0, "Show all");

				// com_BeneficeryId
				System.Data.SqlTypes.SqlGuid colBeneficeryId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["BeneficeryId"] != String.Empty) {
				
					try {
					
						colBeneficeryId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["BeneficeryId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_BeneficeryId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null);
				try {

					com_BeneficeryId.RefreshData(colBeneficeryId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CustomerList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CustomerList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_BeneficeryId.Items.Insert(0, "Show all");

				// com_BeneficeryBankId
				System.Data.SqlTypes.SqlGuid colBeneficeryBankId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["BeneficeryBankId"] != String.Empty) {
				
					try {
					
						colBeneficeryBankId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["BeneficeryBankId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_BeneficeryBankId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
				try {

					com_BeneficeryBankId.RefreshData(colBeneficeryBankId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_BeneficeryBankList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_BeneficeryBankList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_BeneficeryBankId.Items.Insert(0, "Show all");

				// com_PaymentMode
				System.Data.SqlTypes.SqlString colPaymentMode = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["PaymentMode"] != String.Empty) {
				
					try {
					
						colPaymentMode = Request.Params["PaymentMode"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_PaymentMode.Initialize(ConnectionString, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
				try {

					com_PaymentMode.RefreshData(colPaymentMode);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_PaymentModeList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_PaymentModeList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_PaymentMode.Items.Insert(0, "Show all");

				// com_PurposeOfTransfer
				System.Data.SqlTypes.SqlString colPurposeOfTransfer = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["PurposeOfTransfer"] != String.Empty) {
				
					try {
					
						colPurposeOfTransfer = Request.Params["PurposeOfTransfer"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_PurposeOfTransfer.Initialize(ConnectionString, System.Data.SqlTypes.SqlString.Null);
				try {

					com_PurposeOfTransfer.RefreshData(colPurposeOfTransfer);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_PurposeOfTransferList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_PurposeOfTransferList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_PurposeOfTransfer.Items.Insert(0, "Show all");

				// com_PayInCurrencyId
				System.Data.SqlTypes.SqlGuid colPayInCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["PayInCurrencyId"] != String.Empty) {
				
					try {
					
						colPayInCurrencyId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["PayInCurrencyId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_PayInCurrencyId.Initialize(ConnectionString);
				try {

					com_PayInCurrencyId.RefreshData(colPayInCurrencyId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CurrencyList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CurrencyList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_PayInCurrencyId.Items.Insert(0, "Show all");

				// com_PayOutCurrencyId
				System.Data.SqlTypes.SqlGuid colPayOutCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["PayOutCurrencyId"] != String.Empty) {
				
					try {
					
						colPayOutCurrencyId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["PayOutCurrencyId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_PayOutCurrencyId.Initialize(ConnectionString);
				try {

					com_PayOutCurrencyId.RefreshData(colPayOutCurrencyId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CurrencyList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CurrencyList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_PayOutCurrencyId.Items.Insert(0, "Show all");

				// com_AssociatedBankId
				System.Data.SqlTypes.SqlGuid colAssociatedBankId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["AssociatedBankId"] != String.Empty) {
				
					try {
					
						colAssociatedBankId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["AssociatedBankId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_AssociatedBankId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
				try {

					com_AssociatedBankId.RefreshData(colAssociatedBankId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_BankList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_BankList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_AssociatedBankId.Items.Insert(0, "Show all");

				// com_PayInAgentUserId
				System.Data.SqlTypes.SqlGuid colPayInAgentUserId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["PayInAgentUserId"] != String.Empty) {
				
					try {
					
						colPayInAgentUserId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["PayInAgentUserId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_PayInAgentUserId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
				try {

					com_PayInAgentUserId.RefreshData(colPayInAgentUserId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_UserList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_UserList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_PayInAgentUserId.Items.Insert(0, "Show all");

				// com_PayInAgentLocationId
				System.Data.SqlTypes.SqlGuid colPayInAgentLocationId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["PayInAgentLocationId"] != String.Empty) {
				
					try {
					
						colPayInAgentLocationId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["PayInAgentLocationId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_PayInAgentLocationId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlGuid.Null);
				try {

					com_PayInAgentLocationId.RefreshData(colPayInAgentLocationId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_AgentLocationList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_AgentLocationList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_PayInAgentLocationId.Items.Insert(0, "Show all");

				// com_PayOutAgentUserId
				System.Data.SqlTypes.SqlGuid colPayOutAgentUserId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["PayOutAgentUserId"] != String.Empty) {
				
					try {
					
						colPayOutAgentUserId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["PayOutAgentUserId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_PayOutAgentUserId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
				try {

					com_PayOutAgentUserId.RefreshData(colPayOutAgentUserId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_UserList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_UserList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_PayOutAgentUserId.Items.Insert(0, "Show all");

				// com_Status
				System.Data.SqlTypes.SqlString colStatus = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["Status"] != String.Empty) {
				
					try {
					
						colStatus = Request.Params["Status"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_Status.Initialize(ConnectionString);
				try {

					com_Status.RefreshData(colStatus);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_TransactionStatusList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_TransactionStatusList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_Status.Items.Insert(0, "Show all");

				// com_SettlementStatus
				System.Data.SqlTypes.SqlString colSettlementStatus = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["SettlementStatus"] != String.Empty) {
				
					try {
					
						colSettlementStatus = Request.Params["SettlementStatus"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_SettlementStatus.Initialize(ConnectionString);
				try {

					com_SettlementStatus.RefreshData(colSettlementStatus);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_TransactionSettlementStatusList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_TransactionSettlementStatusList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_SettlementStatus.Items.Insert(0, "Show all");

				// Any sort preferences?
				CurrentSortEnum sortColumn = CurrentSortEnum.SortBy_Id;
				if (Request.Params["SortBy"] != String.Empty) {
				
					try {
					
						sortColumn = (CurrentSortEnum)Enum.Parse(typeof(CurrentSortEnum), "SortBy_" + Request.Params["SortBy"]);
					}
					
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}

				SortOrderEnum sortOrder = SortOrderEnum.Ascending;
				if (Request.Params["SortOrder"] != String.Empty) {
				
					try {
					
						sortOrder = (SortOrderEnum)Enum.Parse(typeof(SortOrderEnum), Request.Params["SortOrder"]);
					}
					
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}

				if (ViewState["WebFormList_TransactionDetails_CurrentSort"] == null) {

					ViewState.Add("WebFormList_TransactionDetails_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_TransactionDetails_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_TransactionDetails_SelectDisplay.EnableViewState = true;

			RefreshList();
		}

		private void Page_Init(object sender, EventArgs e) {

			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
		}

		#region Web Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {

			this.com_CustomerId.SelectedIndexChanged += new System.EventHandler(this.com_CustomerId_SelectedIndexChanged);
			this.com_BeneficeryId.SelectedIndexChanged += new System.EventHandler(this.com_BeneficeryId_SelectedIndexChanged);
			this.com_BeneficeryBankId.SelectedIndexChanged += new System.EventHandler(this.com_BeneficeryBankId_SelectedIndexChanged);
			this.com_PaymentMode.SelectedIndexChanged += new System.EventHandler(this.com_PaymentMode_SelectedIndexChanged);
			this.com_PurposeOfTransfer.SelectedIndexChanged += new System.EventHandler(this.com_PurposeOfTransfer_SelectedIndexChanged);
			this.com_PayInCurrencyId.SelectedIndexChanged += new System.EventHandler(this.com_PayInCurrencyId_SelectedIndexChanged);
			this.com_PayOutCurrencyId.SelectedIndexChanged += new System.EventHandler(this.com_PayOutCurrencyId_SelectedIndexChanged);
			this.com_AssociatedBankId.SelectedIndexChanged += new System.EventHandler(this.com_AssociatedBankId_SelectedIndexChanged);
			this.com_PayInAgentUserId.SelectedIndexChanged += new System.EventHandler(this.com_PayInAgentUserId_SelectedIndexChanged);
			this.com_PayInAgentLocationId.SelectedIndexChanged += new System.EventHandler(this.com_PayInAgentLocationId_SelectedIndexChanged);
			this.com_PayOutAgentUserId.SelectedIndexChanged += new System.EventHandler(this.com_PayOutAgentUserId_SelectedIndexChanged);
			this.com_Status.SelectedIndexChanged += new System.EventHandler(this.com_Status_SelectedIndexChanged);
			this.com_SettlementStatus.SelectedIndexChanged += new System.EventHandler(this.com_SettlementStatus_SelectedIndexChanged);
			this.Label_Id.Click += new System.EventHandler(this.Label_Id_Click);
			this.Label_VoucherNumber.Click += new System.EventHandler(this.Label_VoucherNumber_Click);
			this.Label_TransactionNumber.Click += new System.EventHandler(this.Label_TransactionNumber_Click);
			this.Label_CustomerId.Click += new System.EventHandler(this.Label_CustomerId_Click);
			this.Label_BeneficeryId.Click += new System.EventHandler(this.Label_BeneficeryId_Click);
			this.Label_BeneficeryBankId.Click += new System.EventHandler(this.Label_BeneficeryBankId_Click);
			this.Label_PaymentMode.Click += new System.EventHandler(this.Label_PaymentMode_Click);
			this.Label_PurposeOfTransfer.Click += new System.EventHandler(this.Label_PurposeOfTransfer_Click);
			this.Label_PayInCurrencyId.Click += new System.EventHandler(this.Label_PayInCurrencyId_Click);
			this.Label_PayInAmount.Click += new System.EventHandler(this.Label_PayInAmount_Click);
			this.Label_PayOutCurrencyId.Click += new System.EventHandler(this.Label_PayOutCurrencyId_Click);
			this.Label_PayOutAmount.Click += new System.EventHandler(this.Label_PayOutAmount_Click);
			this.Label_Commission.Click += new System.EventHandler(this.Label_Commission_Click);
			this.Label_Question.Click += new System.EventHandler(this.Label_Question_Click);
			this.Label_Answer.Click += new System.EventHandler(this.Label_Answer_Click);
			this.Label_MessageToBeneficery.Click += new System.EventHandler(this.Label_MessageToBeneficery_Click);
			this.Label_MessageToPayOutAgent.Click += new System.EventHandler(this.Label_MessageToPayOutAgent_Click);
			this.Label_BankExchangeRateForPayInCurrency.Click += new System.EventHandler(this.Label_BankExchangeRateForPayInCurrency_Click);
			this.Label_BankExchangeRateForPayOutCurrency.Click += new System.EventHandler(this.Label_BankExchangeRateForPayOutCurrency_Click);
			this.Label_PayInCurrencyGroup.Click += new System.EventHandler(this.Label_PayInCurrencyGroup_Click);
			this.Label_PayOutCurrencyGroup.Click += new System.EventHandler(this.Label_PayOutCurrencyGroup_Click);
			this.Label_FinalBankExchangeRate.Click += new System.EventHandler(this.Label_FinalBankExchangeRate_Click);
			this.Label_AgencyMarginPercent.Click += new System.EventHandler(this.Label_AgencyMarginPercent_Click);
			this.Label_AgencyExchangeRate.Click += new System.EventHandler(this.Label_AgencyExchangeRate_Click);
			this.Label_AgentMarginPercent.Click += new System.EventHandler(this.Label_AgentMarginPercent_Click);
			this.Label_AgentExchangeRate.Click += new System.EventHandler(this.Label_AgentExchangeRate_Click);
			this.Label_AssociatedBankId.Click += new System.EventHandler(this.Label_AssociatedBankId_Click);
			this.Label_PayOutLocationId.Click += new System.EventHandler(this.Label_PayOutLocationId_Click);
			this.Label_PayInAgentUserId.Click += new System.EventHandler(this.Label_PayInAgentUserId_Click);
			this.Label_PayInAgentLocationId.Click += new System.EventHandler(this.Label_PayInAgentLocationId_Click);
			this.Label_PayInDateTime.Click += new System.EventHandler(this.Label_PayInDateTime_Click);
			this.Label_RecommendedPayOutAgentId.Click += new System.EventHandler(this.Label_RecommendedPayOutAgentId_Click);
			this.Label_ActualPayOutAgentId.Click += new System.EventHandler(this.Label_ActualPayOutAgentId_Click);
			this.Label_PayOutAgentUserId.Click += new System.EventHandler(this.Label_PayOutAgentUserId_Click);
			this.Label_PayOutDateTime.Click += new System.EventHandler(this.Label_PayOutDateTime_Click);
			this.Label_CollectedBeneficeryIdDetails.Click += new System.EventHandler(this.Label_CollectedBeneficeryIdDetails_Click);
			this.Label_IsOpenTransaction.Click += new System.EventHandler(this.Label_IsOpenTransaction_Click);
			this.Label_Status.Click += new System.EventHandler(this.Label_Status_Click);
			this.Label_SettlementStatus.Click += new System.EventHandler(this.Label_SettlementStatus_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_Id
			, SortBy_VoucherNumber
			, SortBy_TransactionNumber
			, SortBy_CustomerId
			, SortBy_BeneficeryId
			, SortBy_BeneficeryBankId
			, SortBy_PaymentMode
			, SortBy_PurposeOfTransfer
			, SortBy_PayInCurrencyId
			, SortBy_PayInAmount
			, SortBy_PayOutCurrencyId
			, SortBy_PayOutAmount
			, SortBy_Commission
			, SortBy_Question
			, SortBy_Answer
			, SortBy_MessageToBeneficery
			, SortBy_MessageToPayOutAgent
			, SortBy_BankExchangeRateForPayInCurrency
			, SortBy_BankExchangeRateForPayOutCurrency
			, SortBy_PayInCurrencyGroup
			, SortBy_PayOutCurrencyGroup
			, SortBy_FinalBankExchangeRate
			, SortBy_AgencyMarginPercent
			, SortBy_AgencyExchangeRate
			, SortBy_AgentMarginPercent
			, SortBy_AgentExchangeRate
			, SortBy_AssociatedBankId
			, SortBy_PayOutLocationId
			, SortBy_PayInAgentUserId
			, SortBy_PayInAgentLocationId
			, SortBy_PayInDateTime
			, SortBy_RecommendedPayOutAgentId
			, SortBy_ActualPayOutAgentId
			, SortBy_PayOutAgentUserId
			, SortBy_PayOutDateTime
			, SortBy_CollectedBeneficeryIdDetails
			, SortBy_IsOpenTransaction
			, SortBy_Status
			, SortBy_SettlementStatus
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_CustomerId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_BeneficeryId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_BeneficeryBankId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_PaymentMode_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_PurposeOfTransfer_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_PayInCurrencyId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_PayOutCurrencyId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_AssociatedBankId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_PayInAgentUserId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_PayInAgentLocationId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_PayOutAgentUserId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_Status_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_SettlementStatus_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid CustomerId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_CustomerId.SelectedIndex != 0) {

				CustomerId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_CustomerId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlGuid BeneficeryId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_BeneficeryId.SelectedIndex != 0) {

				BeneficeryId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_BeneficeryId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlGuid BeneficeryBankId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_BeneficeryBankId.SelectedIndex != 0) {

				BeneficeryBankId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_BeneficeryBankId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlString PaymentMode = System.Data.SqlTypes.SqlString.Null;
			if (com_PaymentMode.SelectedIndex != 0) {

				PaymentMode = new System.Data.SqlTypes.SqlString(com_PaymentMode.SelectedItem.Value);
			}

			System.Data.SqlTypes.SqlString PurposeOfTransfer = System.Data.SqlTypes.SqlString.Null;
			if (com_PurposeOfTransfer.SelectedIndex != 0) {

				PurposeOfTransfer = new System.Data.SqlTypes.SqlString(com_PurposeOfTransfer.SelectedItem.Value);
			}

			System.Data.SqlTypes.SqlGuid PayInCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_PayInCurrencyId.SelectedIndex != 0) {

				PayInCurrencyId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_PayInCurrencyId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlGuid PayOutCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_PayOutCurrencyId.SelectedIndex != 0) {

				PayOutCurrencyId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_PayOutCurrencyId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlGuid AssociatedBankId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_AssociatedBankId.SelectedIndex != 0) {

				AssociatedBankId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_AssociatedBankId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlGuid PayInAgentUserId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_PayInAgentUserId.SelectedIndex != 0) {

				PayInAgentUserId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_PayInAgentUserId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlGuid PayInAgentLocationId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_PayInAgentLocationId.SelectedIndex != 0) {

				PayInAgentLocationId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_PayInAgentLocationId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlGuid PayOutAgentUserId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_PayOutAgentUserId.SelectedIndex != 0) {

				PayOutAgentUserId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_PayOutAgentUserId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlString Status = System.Data.SqlTypes.SqlString.Null;
			if (com_Status.SelectedIndex != 0) {

				Status = new System.Data.SqlTypes.SqlString(com_Status.SelectedItem.Value);
			}

			System.Data.SqlTypes.SqlString SettlementStatus = System.Data.SqlTypes.SqlString.Null;
			if (com_SettlementStatus.SelectedIndex != 0) {

				SettlementStatus = new System.Data.SqlTypes.SqlString(com_SettlementStatus.SelectedItem.Value);
			}

			repeater_TransactionDetails_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, CustomerId, BeneficeryId, BeneficeryBankId, PaymentMode, PurposeOfTransfer, PayInCurrencyId, PayOutCurrencyId, AssociatedBankId, PayInAgentUserId, PayInAgentLocationId, PayOutAgentUserId, Status, SettlementStatus);
			try {

				repeater_TransactionDetails_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_TransactionDetails' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_TransactionDetails' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_TransactionDetails_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"]) {

				case CurrentSortEnum.SortBy_Id:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_Id.ColumnName;
					break;

				case CurrentSortEnum.SortBy_VoucherNumber:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_VoucherNumber.ColumnName;
					break;

				case CurrentSortEnum.SortBy_TransactionNumber:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_TransactionNumber.ColumnName;
					break;

				case CurrentSortEnum.SortBy_CustomerId:
					SortDirective = spS_TransactionDetails_SelectDisplay.Resultset1.Fields.Column_CustomerId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_BeneficeryId:
					SortDirective = spS_TransactionDetails_SelectDisplay.Resultset1.Fields.Column_BeneficeryId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_BeneficeryBankId:
					SortDirective = spS_TransactionDetails_SelectDisplay.Resultset1.Fields.Column_BeneficeryBankId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PaymentMode:
					SortDirective = spS_TransactionDetails_SelectDisplay.Resultset1.Fields.Column_PaymentMode_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PurposeOfTransfer:
					SortDirective = spS_TransactionDetails_SelectDisplay.Resultset1.Fields.Column_PurposeOfTransfer_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayInCurrencyId:
					SortDirective = spS_TransactionDetails_SelectDisplay.Resultset1.Fields.Column_PayInCurrencyId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayInAmount:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_PayInAmount.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayOutCurrencyId:
					SortDirective = spS_TransactionDetails_SelectDisplay.Resultset1.Fields.Column_PayOutCurrencyId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayOutAmount:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_PayOutAmount.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Commission:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_Commission.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Question:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_Question.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Answer:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_Answer.ColumnName;
					break;

				case CurrentSortEnum.SortBy_MessageToBeneficery:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_MessageToBeneficery.ColumnName;
					break;

				case CurrentSortEnum.SortBy_MessageToPayOutAgent:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_MessageToPayOutAgent.ColumnName;
					break;

				case CurrentSortEnum.SortBy_BankExchangeRateForPayInCurrency:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_BankExchangeRateForPayInCurrency.ColumnName;
					break;

				case CurrentSortEnum.SortBy_BankExchangeRateForPayOutCurrency:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_BankExchangeRateForPayOutCurrency.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayInCurrencyGroup:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_PayInCurrencyGroup.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayOutCurrencyGroup:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_PayOutCurrencyGroup.ColumnName;
					break;

				case CurrentSortEnum.SortBy_FinalBankExchangeRate:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_FinalBankExchangeRate.ColumnName;
					break;

				case CurrentSortEnum.SortBy_AgencyMarginPercent:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_AgencyMarginPercent.ColumnName;
					break;

				case CurrentSortEnum.SortBy_AgencyExchangeRate:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_AgencyExchangeRate.ColumnName;
					break;

				case CurrentSortEnum.SortBy_AgentMarginPercent:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_AgentMarginPercent.ColumnName;
					break;

				case CurrentSortEnum.SortBy_AgentExchangeRate:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_AgentExchangeRate.ColumnName;
					break;

				case CurrentSortEnum.SortBy_AssociatedBankId:
					SortDirective = spS_TransactionDetails_SelectDisplay.Resultset1.Fields.Column_AssociatedBankId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayOutLocationId:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_PayOutLocationId.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayInAgentUserId:
					SortDirective = spS_TransactionDetails_SelectDisplay.Resultset1.Fields.Column_PayInAgentUserId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayInAgentLocationId:
					SortDirective = spS_TransactionDetails_SelectDisplay.Resultset1.Fields.Column_PayInAgentLocationId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayInDateTime:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_PayInDateTime.ColumnName;
					break;

				case CurrentSortEnum.SortBy_RecommendedPayOutAgentId:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_RecommendedPayOutAgentId.ColumnName;
					break;

				case CurrentSortEnum.SortBy_ActualPayOutAgentId:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_ActualPayOutAgentId.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayOutAgentUserId:
					SortDirective = spS_TransactionDetails_SelectDisplay.Resultset1.Fields.Column_PayOutAgentUserId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayOutDateTime:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_PayOutDateTime.ColumnName;
					break;

				case CurrentSortEnum.SortBy_CollectedBeneficeryIdDetails:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_CollectedBeneficeryIdDetails.ColumnName;
					break;

				case CurrentSortEnum.SortBy_IsOpenTransaction:
					SortDirective = spS_TransactionDetails.Resultset1.Fields.Column_IsOpenTransaction.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Status:
					SortDirective = spS_TransactionDetails_SelectDisplay.Resultset1.Fields.Column_Status_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_SettlementStatus:
					SortDirective = spS_TransactionDetails_SelectDisplay.Resultset1.Fields.Column_SettlementStatus_Display.ColumnName;
					break;

			}

			switch ((SortOrderEnum)ViewState["sortOrder"]) {

				case SortOrderEnum.Ascending:
					SortDirective += " ASC";
					break;

				case SortOrderEnum.Descending:
					SortDirective += " DESC";
					break;
			}

			dataView.Sort = SortDirective;
			repeater_TransactionDetails_SelectDisplay.DataBind();
		}

		private void Label_Id_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_Id) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_Id;
			}

			RefreshList();
		}

		private void Label_VoucherNumber_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_VoucherNumber) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_VoucherNumber;
			}

			RefreshList();
		}

		private void Label_TransactionNumber_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_TransactionNumber) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_TransactionNumber;
			}

			RefreshList();
		}

		private void Label_CustomerId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_CustomerId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_CustomerId;
			}

			RefreshList();
		}

		private void Label_BeneficeryId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_BeneficeryId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_BeneficeryId;
			}

			RefreshList();
		}

		private void Label_BeneficeryBankId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_BeneficeryBankId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_BeneficeryBankId;
			}

			RefreshList();
		}

		private void Label_PaymentMode_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_PaymentMode) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_PaymentMode;
			}

			RefreshList();
		}

		private void Label_PurposeOfTransfer_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_PurposeOfTransfer) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_PurposeOfTransfer;
			}

			RefreshList();
		}

		private void Label_PayInCurrencyId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_PayInCurrencyId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_PayInCurrencyId;
			}

			RefreshList();
		}

		private void Label_PayInAmount_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_PayInAmount) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_PayInAmount;
			}

			RefreshList();
		}

		private void Label_PayOutCurrencyId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_PayOutCurrencyId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_PayOutCurrencyId;
			}

			RefreshList();
		}

		private void Label_PayOutAmount_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_PayOutAmount) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_PayOutAmount;
			}

			RefreshList();
		}

		private void Label_Commission_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_Commission) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_Commission;
			}

			RefreshList();
		}

		private void Label_Question_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_Question) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_Question;
			}

			RefreshList();
		}

		private void Label_Answer_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_Answer) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_Answer;
			}

			RefreshList();
		}

		private void Label_MessageToBeneficery_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_MessageToBeneficery) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_MessageToBeneficery;
			}

			RefreshList();
		}

		private void Label_MessageToPayOutAgent_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_MessageToPayOutAgent) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_MessageToPayOutAgent;
			}

			RefreshList();
		}

		private void Label_BankExchangeRateForPayInCurrency_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_BankExchangeRateForPayInCurrency) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_BankExchangeRateForPayInCurrency;
			}

			RefreshList();
		}

		private void Label_BankExchangeRateForPayOutCurrency_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_BankExchangeRateForPayOutCurrency) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_BankExchangeRateForPayOutCurrency;
			}

			RefreshList();
		}

		private void Label_PayInCurrencyGroup_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_PayInCurrencyGroup) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_PayInCurrencyGroup;
			}

			RefreshList();
		}

		private void Label_PayOutCurrencyGroup_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_PayOutCurrencyGroup) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_PayOutCurrencyGroup;
			}

			RefreshList();
		}

		private void Label_FinalBankExchangeRate_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_FinalBankExchangeRate) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_FinalBankExchangeRate;
			}

			RefreshList();
		}

		private void Label_AgencyMarginPercent_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_AgencyMarginPercent) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_AgencyMarginPercent;
			}

			RefreshList();
		}

		private void Label_AgencyExchangeRate_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_AgencyExchangeRate) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_AgencyExchangeRate;
			}

			RefreshList();
		}

		private void Label_AgentMarginPercent_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_AgentMarginPercent) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_AgentMarginPercent;
			}

			RefreshList();
		}

		private void Label_AgentExchangeRate_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_AgentExchangeRate) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_AgentExchangeRate;
			}

			RefreshList();
		}

		private void Label_AssociatedBankId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_AssociatedBankId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_AssociatedBankId;
			}

			RefreshList();
		}

		private void Label_PayOutLocationId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_PayOutLocationId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_PayOutLocationId;
			}

			RefreshList();
		}

		private void Label_PayInAgentUserId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_PayInAgentUserId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_PayInAgentUserId;
			}

			RefreshList();
		}

		private void Label_PayInAgentLocationId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_PayInAgentLocationId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_PayInAgentLocationId;
			}

			RefreshList();
		}

		private void Label_PayInDateTime_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_PayInDateTime) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_PayInDateTime;
			}

			RefreshList();
		}

		private void Label_RecommendedPayOutAgentId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_RecommendedPayOutAgentId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_RecommendedPayOutAgentId;
			}

			RefreshList();
		}

		private void Label_ActualPayOutAgentId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_ActualPayOutAgentId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_ActualPayOutAgentId;
			}

			RefreshList();
		}

		private void Label_PayOutAgentUserId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_PayOutAgentUserId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_PayOutAgentUserId;
			}

			RefreshList();
		}

		private void Label_PayOutDateTime_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_PayOutDateTime) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_PayOutDateTime;
			}

			RefreshList();
		}

		private void Label_CollectedBeneficeryIdDetails_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_CollectedBeneficeryIdDetails) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_CollectedBeneficeryIdDetails;
			}

			RefreshList();
		}

		private void Label_IsOpenTransaction_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_IsOpenTransaction) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_IsOpenTransaction;
			}

			RefreshList();
		}

		private void Label_Status_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_Status) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_Status;
			}

			RefreshList();
		}

		private void Label_SettlementStatus_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionDetails_CurrentSort"] == CurrentSortEnum.SortBy_SettlementStatus) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionDetails_CurrentSort"] = CurrentSortEnum.SortBy_SettlementStatus;
			}

			RefreshList();
		}

	}
}
