/*
	This C# source code was automatically generated using:

		SQL Server Centric .NET Code Generator
			v 1.0.1697.21165

			Generation Date: 11/30/2004 11:54:02 PM
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
using Params = Evernet.MoneyExchange.DataClasses.Parameters;
using SPs = Evernet.MoneyExchange.DataClasses.StoredProcedures;

namespace Evernet.MoneyExchange.Web.Forms {

	/// <summary>
	/// Summary description for WebForm_TransactionDetails.
	/// </summary>
	public class WebForm_TransactionDetails : System.Web.UI.Page {

		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Id;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Id;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Id;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_VoucherNumber;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_VoucherNumber;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_VoucherNumber;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_TransactionNumber;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_TransactionNumber;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_TransactionNumber;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_CustomerId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CustomerList com_CustomerId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_BeneficeryId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CustomerList com_BeneficeryId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_BeneficeryBankId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_BeneficeryBankList com_BeneficeryBankId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PaymentMode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_PaymentModeList com_PaymentMode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PurposeOfTransfer;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_PurposeOfTransferList com_PurposeOfTransfer;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PayInCurrencyId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CurrencyList com_PayInCurrencyId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PayInAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_PayInAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_PayInAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PayOutCurrencyId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CurrencyList com_PayOutCurrencyId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PayOutAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_PayOutAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_PayOutAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Commission;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Commission;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Commission;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Question;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Question;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Question;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Answer;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Answer;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Answer;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_MessageToBeneficery;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_MessageToBeneficery;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_MessageToBeneficery;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_MessageToPayOutAgent;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_MessageToPayOutAgent;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_MessageToPayOutAgent;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_BankExchangeRateForPayInCurrency;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_BankExchangeRateForPayInCurrency;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_BankExchangeRateForPayInCurrency;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_BankExchangeRateForPayOutCurrency;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_BankExchangeRateForPayOutCurrency;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_BankExchangeRateForPayOutCurrency;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PayInCurrencyGroup;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_PayInCurrencyGroup;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_PayInCurrencyGroup;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PayOutCurrencyGroup;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_PayOutCurrencyGroup;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_PayOutCurrencyGroup;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_FinalBankExchangeRate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_FinalBankExchangeRate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_FinalBankExchangeRate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_AgencyMarginPercent;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_AgencyMarginPercent;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_AgencyMarginPercent;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_AgencyExchangeRate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_AgencyExchangeRate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_AgencyExchangeRate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_AgentMarginPercent;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_AgentMarginPercent;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_AgentMarginPercent;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_AgentExchangeRate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_AgentExchangeRate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_AgentExchangeRate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_AssociatedBankId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_BankList com_AssociatedBankId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PayOutLocationId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_PayOutLocationId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_PayOutLocationId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PayInAgentUserId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_UserList com_PayInAgentUserId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PayInAgentLocationId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentLocationList com_PayInAgentLocationId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PayInDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_PayInDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_PayInDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_RecommendedPayOutAgentId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_RecommendedPayOutAgentId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_RecommendedPayOutAgentId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_ActualPayOutAgentId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_ActualPayOutAgentId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_ActualPayOutAgentId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PayOutAgentUserId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_UserList com_PayOutAgentUserId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PayOutDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_PayOutDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_PayOutDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_CollectedBeneficeryIdDetails;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_CollectedBeneficeryIdDetails;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_CollectedBeneficeryIdDetails;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.CheckBox chk_IsOpenTransaction;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Status;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionStatusList com_Status;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_SettlementStatus;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionSettlementStatusList com_SettlementStatus;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Button cmdRefresh;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Button cmdDelete;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Panel MainDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Error;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Panel ErrorDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Button cmdUpdate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.HyperLink ReturnURL;
	
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebForm_TransactionDetails() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString;
		private ActionEnum Action = ActionEnum.None;
		private System.Data.SqlTypes.SqlGuid CurrentID = System.Data.SqlTypes.SqlGuid.Null;

		private enum ActionEnum {

			None, Add, Edit, Delete
		}

		private System.Globalization.CultureInfo CurrentUserCulture;
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

				if (Request.Params["ReturnToUrl"] != null) {

					ReturnURL.NavigateUrl = Request.Params["ReturnToUrl"].ToString();
					if (Request.Params["ReturnToDisplay"] != null) {

						ReturnURL.Text = Request.Params["ReturnToDisplay"].ToString();
					}
					ReturnURL.Visible = true;
				}
			}

			labError_Id.Visible = false;
			labError_VoucherNumber.Visible = false;
			labError_PayInAmount.Visible = false;
			labError_PayOutAmount.Visible = false;
			labError_Commission.Visible = false;
			labError_BankExchangeRateForPayInCurrency.Visible = false;
			labError_BankExchangeRateForPayOutCurrency.Visible = false;
			labError_FinalBankExchangeRate.Visible = false;
			labError_AgencyMarginPercent.Visible = false;
			labError_AgencyExchangeRate.Visible = false;
			labError_AgentMarginPercent.Visible = false;
			labError_AgentExchangeRate.Visible = false;
			labError_PayOutLocationId.Visible = false;
			labError_PayInDateTime.Visible = false;
			labError_RecommendedPayOutAgentId.Visible = false;
			labError_ActualPayOutAgentId.Visible = false;
			labError_PayOutDateTime.Visible = false;

			if (Request.Params["Action"] != null) {

				switch(Request.Params["Action"].ToString()) {

					case "Add":
						Action = ActionEnum.Add;
						CurrentID = System.Data.SqlTypes.SqlGuid.Null;
						break;

					case "Edit":
						Action = ActionEnum.Edit;
						object ID = Request.Params["ID"];

						if (ID != null) {

							try {

								CurrentID = new Guid(Request.Params["ID"].ToString());
							}
							catch {

								MainDisplay.Visible = false;
								ErrorDisplay.Visible = true;
								lab_Error.Text = "ERROR: Action=Edit-> ID supplied is not a valid Guid";
								return;
							}
						}
						else {

							MainDisplay.Visible = false;
							ErrorDisplay.Visible = true;
							lab_Error.Text = "ERROR: Action=Edit-> No ID was supplied";
							return;
						}
						break;

					case "Delete":
						Action = ActionEnum.Delete;
						if (Request.Params["ID"] != null) {

							try {

								CurrentID = new Guid(Request.Params["ID"].ToString());
							}
							catch {

								MainDisplay.Visible = false;
								ErrorDisplay.Visible = true;
								lab_Error.Text = "ERROR: Action=Edit-> ID supplied is not a valid Int32";
								return;
							}
							cmdDelete_Click(null, null);
							return;
						}
						else {

							MainDisplay.Visible = false;
							ErrorDisplay.Visible = true;
							lab_Error.Text = "ERROR: Action=Delete-> No ID was supplied";
							return;
						}

					default:
						Action = ActionEnum.None;
						CurrentID = System.Data.SqlTypes.SqlGuid.Null;
						MainDisplay.Visible = false;
						ErrorDisplay.Visible = true;
						lab_Error.Text = "ERROR: Action must be Add, Edit Or Delete";
						return;
				}

				if (!Page.IsPostBack) {

					RefreshAll();
				}
			}

			else {

				MainDisplay.Visible = false;
				ErrorDisplay.Visible = true;
				lab_Error.Text = "ERROR: No Action was supplied";
			}
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

			this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
			this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
			this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void RefreshForeignTables() {

			com_CustomerId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null);
			try {

				com_CustomerId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
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

			com_BeneficeryId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null);
			try {

				com_BeneficeryId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
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

			com_BeneficeryBankId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
			try {

				com_BeneficeryBankId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
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
			com_BeneficeryBankId.Items.Insert(0, "[No value set]");

			com_PaymentMode.Initialize(ConnectionString, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
			try {

				com_PaymentMode.RefreshData(System.Data.SqlTypes.SqlString.Null);
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

			com_PurposeOfTransfer.Initialize(ConnectionString, System.Data.SqlTypes.SqlString.Null);
			try {

				com_PurposeOfTransfer.RefreshData(System.Data.SqlTypes.SqlString.Null);
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

			com_PayInCurrencyId.Initialize(ConnectionString);
			try {

				com_PayInCurrencyId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
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

			com_PayOutCurrencyId.Initialize(ConnectionString);
			try {

				com_PayOutCurrencyId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
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

			com_AssociatedBankId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
			try {

				com_AssociatedBankId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
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
			com_AssociatedBankId.Items.Insert(0, "[No value set]");

			com_PayInAgentUserId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
			try {

				com_PayInAgentUserId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
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

			com_PayInAgentLocationId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlGuid.Null);
			try {

				com_PayInAgentLocationId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
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

			com_PayOutAgentUserId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
			try {

				com_PayOutAgentUserId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
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
			com_PayOutAgentUserId.Items.Insert(0, "[No value set]");

			com_Status.Initialize(ConnectionString);
			try {

				com_Status.RefreshData(System.Data.SqlTypes.SqlString.Null);
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

			com_SettlementStatus.Initialize(ConnectionString);
			try {

				com_SettlementStatus.RefreshData(System.Data.SqlTypes.SqlString.Null);
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

		}

		private void UpdateForm() {

			if (Action == ActionEnum.Edit || Action == ActionEnum.None) {

				cmdRefresh.Visible = true;
				cmdDelete.Visible = true;
				cmdUpdate.Visible = true;
				cmdUpdate.Text = "Update";
				RefreshRecord();
			}
			else {

				cmdRefresh.Visible = false;
				cmdDelete.Visible = false;
				cmdUpdate.Visible = true;
				cmdUpdate.Text = "OK";
				EmptyControls();
			}
		}

		private void RefreshAll() {

			RefreshForeignTables();
			UpdateForm();
		}

		private void cmdRefresh_Click(object sender, System.EventArgs e) {

			RefreshAll();
		}

		private void RefreshRecord() {

			Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails oAbstract_TransactionDetails = new Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails(ConnectionString);

			if (!oAbstract_TransactionDetails.Refresh(CurrentID)) {

				MainDisplay.Visible = false;
				ErrorDisplay.Visible = true;
				lab_Error.Text = String.Format("No record with ID: {0}", CurrentID.ToString());
				return;
			}

			if (!oAbstract_TransactionDetails.Col_Id.IsNull) {

				txt_Id.Text = oAbstract_TransactionDetails.Col_Id.Value.ToString();
			}
			else {

				txt_Id.Text = String.Empty;
			}
				txt_Id.ReadOnly = true;

			if (!oAbstract_TransactionDetails.Col_VoucherNumber.IsNull) {

				txt_VoucherNumber.Text = oAbstract_TransactionDetails.Col_VoucherNumber.Value.ToString();
			}
			else {

				txt_VoucherNumber.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_TransactionNumber.IsNull) {

				txt_TransactionNumber.Text = oAbstract_TransactionDetails.Col_TransactionNumber.Value.ToString();
			}
			else {

				txt_TransactionNumber.Text = String.Empty;
			}

			com_CustomerId.Items.FindByValue(Convert.ToString(oAbstract_TransactionDetails.Col_CustomerId)).Selected = true;

			com_BeneficeryId.Items.FindByValue(Convert.ToString(oAbstract_TransactionDetails.Col_BeneficeryId)).Selected = true;

			if (!oAbstract_TransactionDetails.Col_BeneficeryBankId.IsNull) {

				com_BeneficeryBankId.Items.FindByValue(Convert.ToString(oAbstract_TransactionDetails.Col_BeneficeryBankId)).Selected = true;
			}
			else {

				com_BeneficeryBankId.SelectedIndex = 0;
			}

			com_PaymentMode.Items.FindByValue(Convert.ToString(oAbstract_TransactionDetails.Col_PaymentMode)).Selected = true;

			com_PurposeOfTransfer.Items.FindByValue(Convert.ToString(oAbstract_TransactionDetails.Col_PurposeOfTransfer)).Selected = true;

			com_PayInCurrencyId.Items.FindByValue(Convert.ToString(oAbstract_TransactionDetails.Col_PayInCurrencyId)).Selected = true;

			if (!oAbstract_TransactionDetails.Col_PayInAmount.IsNull) {

				txt_PayInAmount.Text = oAbstract_TransactionDetails.Col_PayInAmount.Value.ToString();
			}
			else {

				txt_PayInAmount.Text = String.Empty;
			}

			com_PayOutCurrencyId.Items.FindByValue(Convert.ToString(oAbstract_TransactionDetails.Col_PayOutCurrencyId)).Selected = true;

			if (!oAbstract_TransactionDetails.Col_PayOutAmount.IsNull) {

				txt_PayOutAmount.Text = oAbstract_TransactionDetails.Col_PayOutAmount.Value.ToString();
			}
			else {

				txt_PayOutAmount.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_Commission.IsNull) {

				txt_Commission.Text = oAbstract_TransactionDetails.Col_Commission.Value.ToString();
			}
			else {

				txt_Commission.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_Question.IsNull) {

				txt_Question.Text = oAbstract_TransactionDetails.Col_Question.Value.ToString();
			}
			else {

				txt_Question.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_Answer.IsNull) {

				txt_Answer.Text = oAbstract_TransactionDetails.Col_Answer.Value.ToString();
			}
			else {

				txt_Answer.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_MessageToBeneficery.IsNull) {

				txt_MessageToBeneficery.Text = oAbstract_TransactionDetails.Col_MessageToBeneficery.Value.ToString();
			}
			else {

				txt_MessageToBeneficery.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_MessageToPayOutAgent.IsNull) {

				txt_MessageToPayOutAgent.Text = oAbstract_TransactionDetails.Col_MessageToPayOutAgent.Value.ToString();
			}
			else {

				txt_MessageToPayOutAgent.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_BankExchangeRateForPayInCurrency.IsNull) {

				txt_BankExchangeRateForPayInCurrency.Text = oAbstract_TransactionDetails.Col_BankExchangeRateForPayInCurrency.Value.ToString();
			}
			else {

				txt_BankExchangeRateForPayInCurrency.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_BankExchangeRateForPayOutCurrency.IsNull) {

				txt_BankExchangeRateForPayOutCurrency.Text = oAbstract_TransactionDetails.Col_BankExchangeRateForPayOutCurrency.Value.ToString();
			}
			else {

				txt_BankExchangeRateForPayOutCurrency.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_PayInCurrencyGroup.IsNull) {

				txt_PayInCurrencyGroup.Text = oAbstract_TransactionDetails.Col_PayInCurrencyGroup.Value.ToString();
			}
			else {

				txt_PayInCurrencyGroup.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_PayOutCurrencyGroup.IsNull) {

				txt_PayOutCurrencyGroup.Text = oAbstract_TransactionDetails.Col_PayOutCurrencyGroup.Value.ToString();
			}
			else {

				txt_PayOutCurrencyGroup.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_FinalBankExchangeRate.IsNull) {

				txt_FinalBankExchangeRate.Text = oAbstract_TransactionDetails.Col_FinalBankExchangeRate.Value.ToString();
			}
			else {

				txt_FinalBankExchangeRate.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_AgencyMarginPercent.IsNull) {

				txt_AgencyMarginPercent.Text = oAbstract_TransactionDetails.Col_AgencyMarginPercent.Value.ToString();
			}
			else {

				txt_AgencyMarginPercent.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_AgencyExchangeRate.IsNull) {

				txt_AgencyExchangeRate.Text = oAbstract_TransactionDetails.Col_AgencyExchangeRate.Value.ToString();
			}
			else {

				txt_AgencyExchangeRate.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_AgentMarginPercent.IsNull) {

				txt_AgentMarginPercent.Text = oAbstract_TransactionDetails.Col_AgentMarginPercent.Value.ToString();
			}
			else {

				txt_AgentMarginPercent.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_AgentExchangeRate.IsNull) {

				txt_AgentExchangeRate.Text = oAbstract_TransactionDetails.Col_AgentExchangeRate.Value.ToString();
			}
			else {

				txt_AgentExchangeRate.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_AssociatedBankId.IsNull) {

				com_AssociatedBankId.Items.FindByValue(Convert.ToString(oAbstract_TransactionDetails.Col_AssociatedBankId)).Selected = true;
			}
			else {

				com_AssociatedBankId.SelectedIndex = 0;
			}

			if (!oAbstract_TransactionDetails.Col_PayOutLocationId.IsNull) {

				txt_PayOutLocationId.Text = oAbstract_TransactionDetails.Col_PayOutLocationId.Value.ToString();
			}
			else {

				txt_PayOutLocationId.Text = String.Empty;
			}

			com_PayInAgentUserId.Items.FindByValue(Convert.ToString(oAbstract_TransactionDetails.Col_PayInAgentUserId)).Selected = true;

			com_PayInAgentLocationId.Items.FindByValue(Convert.ToString(oAbstract_TransactionDetails.Col_PayInAgentLocationId)).Selected = true;

			if (!oAbstract_TransactionDetails.Col_PayInDateTime.IsNull) {

				txt_PayInDateTime.Text = oAbstract_TransactionDetails.Col_PayInDateTime.Value.ToString();
			}
			else {

				txt_PayInDateTime.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_RecommendedPayOutAgentId.IsNull) {

				txt_RecommendedPayOutAgentId.Text = oAbstract_TransactionDetails.Col_RecommendedPayOutAgentId.Value.ToString();
			}
			else {

				txt_RecommendedPayOutAgentId.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_ActualPayOutAgentId.IsNull) {

				txt_ActualPayOutAgentId.Text = oAbstract_TransactionDetails.Col_ActualPayOutAgentId.Value.ToString();
			}
			else {

				txt_ActualPayOutAgentId.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_PayOutAgentUserId.IsNull) {

				com_PayOutAgentUserId.Items.FindByValue(Convert.ToString(oAbstract_TransactionDetails.Col_PayOutAgentUserId)).Selected = true;
			}
			else {

				com_PayOutAgentUserId.SelectedIndex = 0;
			}

			if (!oAbstract_TransactionDetails.Col_PayOutDateTime.IsNull) {

				txt_PayOutDateTime.Text = oAbstract_TransactionDetails.Col_PayOutDateTime.Value.ToString();
			}
			else {

				txt_PayOutDateTime.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_CollectedBeneficeryIdDetails.IsNull) {

				txt_CollectedBeneficeryIdDetails.Text = oAbstract_TransactionDetails.Col_CollectedBeneficeryIdDetails.Value.ToString();
			}
			else {

				txt_CollectedBeneficeryIdDetails.Text = String.Empty;
			}

			if (!oAbstract_TransactionDetails.Col_IsOpenTransaction.IsNull) {

				chk_IsOpenTransaction.Checked = oAbstract_TransactionDetails.Col_IsOpenTransaction.Value;
			}
			else {

				chk_IsOpenTransaction.Checked = false;
			}

			com_Status.Items.FindByValue(Convert.ToString(oAbstract_TransactionDetails.Col_Status)).Selected = true;

			com_SettlementStatus.Items.FindByValue(Convert.ToString(oAbstract_TransactionDetails.Col_SettlementStatus)).Selected = true;

		}

		private void EmptyControls() {

			txt_Id.Text = String.Empty;
			txt_VoucherNumber.Text = String.Empty;
			txt_TransactionNumber.Text = String.Empty;
			com_CustomerId.SelectedIndex = 0;
			com_BeneficeryId.SelectedIndex = 0;
			com_BeneficeryBankId.SelectedIndex = 0;
			com_PaymentMode.SelectedIndex = 0;
			com_PurposeOfTransfer.SelectedIndex = 0;
			com_PayInCurrencyId.SelectedIndex = 0;
			txt_PayInAmount.Text = String.Empty;
			com_PayOutCurrencyId.SelectedIndex = 0;
			txt_PayOutAmount.Text = String.Empty;
			txt_Commission.Text = String.Empty;
			txt_Question.Text = String.Empty;
			txt_Answer.Text = String.Empty;
			txt_MessageToBeneficery.Text = String.Empty;
			txt_MessageToPayOutAgent.Text = String.Empty;
			txt_BankExchangeRateForPayInCurrency.Text = String.Empty;
			txt_BankExchangeRateForPayOutCurrency.Text = String.Empty;
			txt_PayInCurrencyGroup.Text = String.Empty;
			txt_PayOutCurrencyGroup.Text = String.Empty;
			txt_FinalBankExchangeRate.Text = String.Empty;
			txt_AgencyMarginPercent.Text = String.Empty;
			txt_AgencyExchangeRate.Text = String.Empty;
			txt_AgentMarginPercent.Text = String.Empty;
			txt_AgentExchangeRate.Text = String.Empty;
			com_AssociatedBankId.SelectedIndex = 0;
			txt_PayOutLocationId.Text = String.Empty;
			com_PayInAgentUserId.SelectedIndex = 0;
			com_PayInAgentLocationId.SelectedIndex = 0;
			txt_PayInDateTime.Text = String.Empty;
			txt_RecommendedPayOutAgentId.Text = String.Empty;
			txt_ActualPayOutAgentId.Text = String.Empty;
			com_PayOutAgentUserId.SelectedIndex = 0;
			txt_PayOutDateTime.Text = String.Empty;
			txt_CollectedBeneficeryIdDetails.Text = String.Empty;
			chk_IsOpenTransaction.Checked = false;
			com_Status.SelectedIndex = 0;
			com_SettlementStatus.SelectedIndex = 0;
		}

		private void cmdAdd_Click(object sender, System.EventArgs e) {

			if (ReturnURL.Visible) {

				Response.Redirect(String.Format("WebForm_TransactionDetails.aspx?Action=Add&ReturnToUrl={0}&ReturnToDisplay={1}", ReturnURL.NavigateUrl, ReturnURL.Text));
			}
			else {

				Response.Redirect("WebForm_TransactionDetails.aspx?Action=Add");
			}
		}

		private void cmdUpdate_Click(object sender, System.EventArgs e) {

			if (!CheckValues()) {
			
				return;
			}

			if (Action == ActionEnum.Edit) {

				Params.spU_TransactionDetails Param = null;
				SPs.spU_TransactionDetails SP = null;

				Param = new Params.spU_TransactionDetails();

				Param.SetUpConnection(ConnectionString);

				Param.Param_Id = CurrentID;

				if (txt_Id.Text.Trim() != String.Empty) {

					Param.Param_Id = new System.Data.SqlTypes.SqlGuid(new System.Guid(txt_Id.Text));
				}

				if (txt_VoucherNumber.Text.Trim() != String.Empty) {

					Param.Param_VoucherNumber = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_VoucherNumber.Text));
				}

				if (txt_TransactionNumber.Text.Trim() != String.Empty) {

					Param.Param_TransactionNumber = new System.Data.SqlTypes.SqlString(txt_TransactionNumber.Text);
				}

				Param.Param_CustomerId = new Guid(com_CustomerId.SelectedItem.Value);

				Param.Param_BeneficeryId = new Guid(com_BeneficeryId.SelectedItem.Value);

				if (com_BeneficeryBankId.SelectedIndex != 0) {

					Param.Param_BeneficeryBankId = new Guid(com_BeneficeryBankId.SelectedItem.Value);
				}

				Param.Param_PaymentMode = Convert.ToString(com_PaymentMode.SelectedItem.Value);

				Param.Param_PurposeOfTransfer = Convert.ToString(com_PurposeOfTransfer.SelectedItem.Value);

				Param.Param_PayInCurrencyId = new Guid(com_PayInCurrencyId.SelectedItem.Value);

				if (txt_PayInAmount.Text.Trim() != String.Empty) {

					Param.Param_PayInAmount = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_PayInAmount.Text));
				}

				Param.Param_PayOutCurrencyId = new Guid(com_PayOutCurrencyId.SelectedItem.Value);

				if (txt_PayOutAmount.Text.Trim() != String.Empty) {

					Param.Param_PayOutAmount = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_PayOutAmount.Text));
				}

				if (txt_Commission.Text.Trim() != String.Empty) {

					Param.Param_Commission = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_Commission.Text));
				}

				if (txt_Question.Text.Trim() != String.Empty) {

					Param.Param_Question = new System.Data.SqlTypes.SqlString(txt_Question.Text);
				}

				if (txt_Answer.Text.Trim() != String.Empty) {

					Param.Param_Answer = new System.Data.SqlTypes.SqlString(txt_Answer.Text);
				}

				if (txt_MessageToBeneficery.Text.Trim() != String.Empty) {

					Param.Param_MessageToBeneficery = new System.Data.SqlTypes.SqlString(txt_MessageToBeneficery.Text);
				}

				if (txt_MessageToPayOutAgent.Text.Trim() != String.Empty) {

					Param.Param_MessageToPayOutAgent = new System.Data.SqlTypes.SqlString(txt_MessageToPayOutAgent.Text);
				}

				if (txt_BankExchangeRateForPayInCurrency.Text.Trim() != String.Empty) {

					Param.Param_BankExchangeRateForPayInCurrency = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_BankExchangeRateForPayInCurrency.Text));
				}

				if (txt_BankExchangeRateForPayOutCurrency.Text.Trim() != String.Empty) {

					Param.Param_BankExchangeRateForPayOutCurrency = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_BankExchangeRateForPayOutCurrency.Text));
				}

				if (txt_PayInCurrencyGroup.Text.Trim() != String.Empty) {

					Param.Param_PayInCurrencyGroup = new System.Data.SqlTypes.SqlString(txt_PayInCurrencyGroup.Text);
				}

				if (txt_PayOutCurrencyGroup.Text.Trim() != String.Empty) {

					Param.Param_PayOutCurrencyGroup = new System.Data.SqlTypes.SqlString(txt_PayOutCurrencyGroup.Text);
				}

				if (txt_FinalBankExchangeRate.Text.Trim() != String.Empty) {

					Param.Param_FinalBankExchangeRate = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_FinalBankExchangeRate.Text));
				}

				if (txt_AgencyMarginPercent.Text.Trim() != String.Empty) {

					Param.Param_AgencyMarginPercent = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_AgencyMarginPercent.Text));
				}

				if (txt_AgencyExchangeRate.Text.Trim() != String.Empty) {

					Param.Param_AgencyExchangeRate = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_AgencyExchangeRate.Text));
				}

				if (txt_AgentMarginPercent.Text.Trim() != String.Empty) {

					Param.Param_AgentMarginPercent = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_AgentMarginPercent.Text));
				}

				if (txt_AgentExchangeRate.Text.Trim() != String.Empty) {

					Param.Param_AgentExchangeRate = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_AgentExchangeRate.Text));
				}

				if (com_AssociatedBankId.SelectedIndex != 0) {

					Param.Param_AssociatedBankId = new Guid(com_AssociatedBankId.SelectedItem.Value);
				}

				if (txt_PayOutLocationId.Text.Trim() != String.Empty) {

					Param.Param_PayOutLocationId = new System.Data.SqlTypes.SqlGuid(new System.Guid(txt_PayOutLocationId.Text));
				}

				Param.Param_PayInAgentUserId = new Guid(com_PayInAgentUserId.SelectedItem.Value);

				Param.Param_PayInAgentLocationId = new Guid(com_PayInAgentLocationId.SelectedItem.Value);

				if (txt_PayInDateTime.Text.Trim() != String.Empty) {

					Param.Param_PayInDateTime = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_PayInDateTime.Text));
				}

				if (txt_RecommendedPayOutAgentId.Text.Trim() != String.Empty) {

					Param.Param_RecommendedPayOutAgentId = new System.Data.SqlTypes.SqlGuid(new System.Guid(txt_RecommendedPayOutAgentId.Text));
				}

				if (txt_ActualPayOutAgentId.Text.Trim() != String.Empty) {

					Param.Param_ActualPayOutAgentId = new System.Data.SqlTypes.SqlGuid(new System.Guid(txt_ActualPayOutAgentId.Text));
				}

				if (com_PayOutAgentUserId.SelectedIndex != 0) {

					Param.Param_PayOutAgentUserId = new Guid(com_PayOutAgentUserId.SelectedItem.Value);
				}

				if (txt_PayOutDateTime.Text.Trim() != String.Empty) {

					Param.Param_PayOutDateTime = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_PayOutDateTime.Text));
				}

				if (txt_CollectedBeneficeryIdDetails.Text.Trim() != String.Empty) {

					Param.Param_CollectedBeneficeryIdDetails = new System.Data.SqlTypes.SqlString(txt_CollectedBeneficeryIdDetails.Text);
				}

				Param.Param_IsOpenTransaction = new System.Data.SqlTypes.SqlBoolean(chk_IsOpenTransaction.Checked);
				Param.Param_Status = Convert.ToString(com_Status.SelectedItem.Value);

				Param.Param_SettlementStatus = Convert.ToString(com_SettlementStatus.SelectedItem.Value);

				SP = new SPs.spU_TransactionDetails();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_TransactionDetails.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", CurrentID.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_TransactionDetails.aspx?Action=Edit&ID={0}", CurrentID.ToString()));
					}
					return;
				}
				else {

					if (Param.SqlException != null) {

						throw Param.SqlException;
					}

					if (Param.OtherException != null) {

						throw Param.OtherException;
					}
				}
			}

			else {

				Params.spI_TransactionDetails Param = null;
				SPs.spI_TransactionDetails SP = null;

				Param = new Params.spI_TransactionDetails();

				Param.SetUpConnection(ConnectionString);

				if (txt_Id.Text.Trim() != String.Empty) {

					Param.Param_Id = new System.Data.SqlTypes.SqlGuid(new System.Guid(txt_Id.Text));
				}

				if (txt_VoucherNumber.Text.Trim() != String.Empty) {

					Param.Param_VoucherNumber = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_VoucherNumber.Text));
				}

				if (txt_TransactionNumber.Text.Trim() != String.Empty) {

					Param.Param_TransactionNumber = new System.Data.SqlTypes.SqlString(txt_TransactionNumber.Text);
				}

				Param.Param_CustomerId = new Guid(com_CustomerId.SelectedItem.Value);

				Param.Param_BeneficeryId = new Guid(com_BeneficeryId.SelectedItem.Value);

				if (com_BeneficeryBankId.SelectedIndex != 0) {

					Param.Param_BeneficeryBankId = new Guid(com_BeneficeryBankId.SelectedItem.Value);
				}

				Param.Param_PaymentMode = Convert.ToString(com_PaymentMode.SelectedItem.Value);

				Param.Param_PurposeOfTransfer = Convert.ToString(com_PurposeOfTransfer.SelectedItem.Value);

				Param.Param_PayInCurrencyId = new Guid(com_PayInCurrencyId.SelectedItem.Value);

				if (txt_PayInAmount.Text.Trim() != String.Empty) {

					Param.Param_PayInAmount = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_PayInAmount.Text));
				}

				Param.Param_PayOutCurrencyId = new Guid(com_PayOutCurrencyId.SelectedItem.Value);

				if (txt_PayOutAmount.Text.Trim() != String.Empty) {

					Param.Param_PayOutAmount = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_PayOutAmount.Text));
				}

				if (txt_Commission.Text.Trim() != String.Empty) {

					Param.Param_Commission = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_Commission.Text));
				}

				if (txt_Question.Text.Trim() != String.Empty) {

					Param.Param_Question = new System.Data.SqlTypes.SqlString(txt_Question.Text);
				}

				if (txt_Answer.Text.Trim() != String.Empty) {

					Param.Param_Answer = new System.Data.SqlTypes.SqlString(txt_Answer.Text);
				}

				if (txt_MessageToBeneficery.Text.Trim() != String.Empty) {

					Param.Param_MessageToBeneficery = new System.Data.SqlTypes.SqlString(txt_MessageToBeneficery.Text);
				}

				if (txt_MessageToPayOutAgent.Text.Trim() != String.Empty) {

					Param.Param_MessageToPayOutAgent = new System.Data.SqlTypes.SqlString(txt_MessageToPayOutAgent.Text);
				}

				if (txt_BankExchangeRateForPayInCurrency.Text.Trim() != String.Empty) {

					Param.Param_BankExchangeRateForPayInCurrency = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_BankExchangeRateForPayInCurrency.Text));
				}

				if (txt_BankExchangeRateForPayOutCurrency.Text.Trim() != String.Empty) {

					Param.Param_BankExchangeRateForPayOutCurrency = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_BankExchangeRateForPayOutCurrency.Text));
				}

				if (txt_PayInCurrencyGroup.Text.Trim() != String.Empty) {

					Param.Param_PayInCurrencyGroup = new System.Data.SqlTypes.SqlString(txt_PayInCurrencyGroup.Text);
				}

				if (txt_PayOutCurrencyGroup.Text.Trim() != String.Empty) {

					Param.Param_PayOutCurrencyGroup = new System.Data.SqlTypes.SqlString(txt_PayOutCurrencyGroup.Text);
				}

				if (txt_FinalBankExchangeRate.Text.Trim() != String.Empty) {

					Param.Param_FinalBankExchangeRate = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_FinalBankExchangeRate.Text));
				}

				if (txt_AgencyMarginPercent.Text.Trim() != String.Empty) {

					Param.Param_AgencyMarginPercent = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_AgencyMarginPercent.Text));
				}

				if (txt_AgencyExchangeRate.Text.Trim() != String.Empty) {

					Param.Param_AgencyExchangeRate = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_AgencyExchangeRate.Text));
				}

				if (txt_AgentMarginPercent.Text.Trim() != String.Empty) {

					Param.Param_AgentMarginPercent = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_AgentMarginPercent.Text));
				}

				if (txt_AgentExchangeRate.Text.Trim() != String.Empty) {

					Param.Param_AgentExchangeRate = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_AgentExchangeRate.Text));
				}

				if (com_AssociatedBankId.SelectedIndex != 0) {

					Param.Param_AssociatedBankId = new Guid(com_AssociatedBankId.SelectedItem.Value);
				}

				if (txt_PayOutLocationId.Text.Trim() != String.Empty) {

					Param.Param_PayOutLocationId = new System.Data.SqlTypes.SqlGuid(new System.Guid(txt_PayOutLocationId.Text));
				}

				Param.Param_PayInAgentUserId = new Guid(com_PayInAgentUserId.SelectedItem.Value);

				Param.Param_PayInAgentLocationId = new Guid(com_PayInAgentLocationId.SelectedItem.Value);

				if (txt_PayInDateTime.Text.Trim() != String.Empty) {

					Param.Param_PayInDateTime = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_PayInDateTime.Text));
				}

				if (txt_RecommendedPayOutAgentId.Text.Trim() != String.Empty) {

					Param.Param_RecommendedPayOutAgentId = new System.Data.SqlTypes.SqlGuid(new System.Guid(txt_RecommendedPayOutAgentId.Text));
				}

				if (txt_ActualPayOutAgentId.Text.Trim() != String.Empty) {

					Param.Param_ActualPayOutAgentId = new System.Data.SqlTypes.SqlGuid(new System.Guid(txt_ActualPayOutAgentId.Text));
				}

				if (com_PayOutAgentUserId.SelectedIndex != 0) {

					Param.Param_PayOutAgentUserId = new Guid(com_PayOutAgentUserId.SelectedItem.Value);
				}

				if (txt_PayOutDateTime.Text.Trim() != String.Empty) {

					Param.Param_PayOutDateTime = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_PayOutDateTime.Text));
				}

				if (txt_CollectedBeneficeryIdDetails.Text.Trim() != String.Empty) {

					Param.Param_CollectedBeneficeryIdDetails = new System.Data.SqlTypes.SqlString(txt_CollectedBeneficeryIdDetails.Text);
				}

				Param.Param_IsOpenTransaction = new System.Data.SqlTypes.SqlBoolean(chk_IsOpenTransaction.Checked);
				Param.Param_Status = Convert.ToString(com_Status.SelectedItem.Value);

				Param.Param_SettlementStatus = Convert.ToString(com_SettlementStatus.SelectedItem.Value);

				SP = new SPs.spI_TransactionDetails();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_TransactionDetails.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", Param.Param_Id.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_TransactionDetails.aspx?Action=Edit&ID={0}", Param.Param_Id.ToString()));
					}
					return;
				}
				else {

					if (Param.SqlException != null) {

						throw Param.SqlException;
					}

					if (Param.OtherException != null) {

						throw Param.OtherException;
					}
				}
			}
		}

		private void cmdDelete_Click(object sender, System.EventArgs e) {

			Params.spD_TransactionDetails Param = null;
			SPs.spD_TransactionDetails SP = null;

			Param = new Params.spD_TransactionDetails();

			Param.SetUpConnection(ConnectionString);

			Param.Param_Id = CurrentID;

			SP = new SPs.spD_TransactionDetails();

			if (SP.Execute(ref Param)) {

				Param.Dispose();
				SP.Dispose();

				MainDisplay.Visible = false;
				ErrorDisplay.Visible = true;
				lab_Error.Text = String.Format("Record with ID: {0} was successfully deleted!", CurrentID.ToString());

				return;
			}
			else {

				if (Param.SqlException != null) {

					throw Param.SqlException;
				}

				if (Param.OtherException != null) {

					throw Param.OtherException;
				}
			}
		}

		private bool CheckValues() {

			bool status = true;
			try {

				System.Data.SqlTypes.SqlGuid value = new System.Data.SqlTypes.SqlGuid(new System.Guid(txt_Id.Text));
			}

			catch {

				labError_Id.Text = "INVALID";
				labError_Id.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_VoucherNumber.Text));
			}

			catch {

				labError_VoucherNumber.Text = "INVALID";
				labError_VoucherNumber.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_PayInAmount.Text));
			}

			catch {

				labError_PayInAmount.Text = "INVALID";
				labError_PayInAmount.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_PayOutAmount.Text));
			}

			catch {

				labError_PayOutAmount.Text = "INVALID";
				labError_PayOutAmount.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_Commission.Text));
			}

			catch {

				labError_Commission.Text = "INVALID";
				labError_Commission.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_BankExchangeRateForPayInCurrency.Text));
			}

			catch {

				labError_BankExchangeRateForPayInCurrency.Text = "INVALID";
				labError_BankExchangeRateForPayInCurrency.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_BankExchangeRateForPayOutCurrency.Text));
			}

			catch {

				labError_BankExchangeRateForPayOutCurrency.Text = "INVALID";
				labError_BankExchangeRateForPayOutCurrency.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_FinalBankExchangeRate.Text));
			}

			catch {

				labError_FinalBankExchangeRate.Text = "INVALID";
				labError_FinalBankExchangeRate.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_AgencyMarginPercent.Text));
			}

			catch {

				labError_AgencyMarginPercent.Text = "INVALID";
				labError_AgencyMarginPercent.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_AgencyExchangeRate.Text));
			}

			catch {

				labError_AgencyExchangeRate.Text = "INVALID";
				labError_AgencyExchangeRate.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_AgentMarginPercent.Text));
			}

			catch {

				labError_AgentMarginPercent.Text = "INVALID";
				labError_AgentMarginPercent.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_AgentExchangeRate.Text));
			}

			catch {

				labError_AgentExchangeRate.Text = "INVALID";
				labError_AgentExchangeRate.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlGuid value = new System.Data.SqlTypes.SqlGuid(new System.Guid(txt_PayOutLocationId.Text));
			}

			catch {

				labError_PayOutLocationId.Text = "INVALID";
				labError_PayOutLocationId.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDateTime value = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_PayInDateTime.Text));
			}

			catch {

				labError_PayInDateTime.Text = "INVALID";
				labError_PayInDateTime.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlGuid value = new System.Data.SqlTypes.SqlGuid(new System.Guid(txt_RecommendedPayOutAgentId.Text));
			}

			catch {

				labError_RecommendedPayOutAgentId.Text = "INVALID";
				labError_RecommendedPayOutAgentId.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlGuid value = new System.Data.SqlTypes.SqlGuid(new System.Guid(txt_ActualPayOutAgentId.Text));
			}

			catch {

				labError_ActualPayOutAgentId.Text = "INVALID";
				labError_ActualPayOutAgentId.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDateTime value = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_PayOutDateTime.Text));
			}

			catch {

				labError_PayOutDateTime.Text = "INVALID";
				labError_PayOutDateTime.Visible = true;
				status = false;
			}

			return(status);
		}
	}
}
