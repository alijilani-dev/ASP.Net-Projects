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
using Evernet.MoneyExchange.BusinessLogic;

namespace Evernet.MoneyExchange.Web.Forms {

	/// <summary>
	/// Summary description for WebForm_CountryList.
	/// </summary>
	public class WebForm_CountryList : System.Web.UI.Page {

		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Name;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Name;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Name;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Code;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Code;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Code;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_BaseCurrency;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CurrencyList com_BaseCurrency;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_AllowedInternationalTransactionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionTypeList com_AllowedInternationalTransactionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_AllowedDomesticTransactionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionTypeList com_AllowedDomesticTransactionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_TotalInboundThresholdPerYearPerPerson;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_TotalInboundThresholdPerYearPerPerson;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_TotalInboundThresholdPerYearPerPerson;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_MaximumTransactionsPerYearPerPersonToOneBeneficery;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_MaximumTransactionsPerYearPerPersonToOneBeneficery;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_MaximumTransactionsPerYearPerPersonToOneBeneficery;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_TransactionYearStartDate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_TransactionYearStartDate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_TransactionYearStartDate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_TransactionYearEndDate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_TransactionYearEndDate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_TransactionYearEndDate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_OutboundIDRequirementThreshold;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_OutboundIDRequirementThreshold;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_OutboundIDRequirementThreshold;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_OutboundThresholdPerTransaction;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_OutboundThresholdPerTransaction;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_OutboundThresholdPerTransaction;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.CheckBox chk_CanPayOutUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.CheckBox chk_Active;
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
		public WebForm_CountryList() {

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

			labError_TotalInboundThresholdPerYearPerPerson.Visible = false;
			labError_MaximumTransactionsPerYearPerPersonToOneBeneficery.Visible = false;
			labError_TransactionYearStartDate.Visible = false;
			labError_TransactionYearEndDate.Visible = false;
			labError_OutboundIDRequirementThreshold.Visible = false;
			labError_OutboundThresholdPerTransaction.Visible = false;

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

					if(!User.IsInRole(UserRoles.CountryManagerCreator.ToString())
						&&
						!User.IsInRole(UserRoles.Administrator.ToString())
						) {
						if(Action==ActionEnum.Add) {
							cmdUpdate.Enabled=false;
						}
					}


					if(!User.IsInRole(UserRoles.CountryManagerEditor.ToString())
						&&
						!User.IsInRole(UserRoles.Administrator.ToString())) {
						if(Action==ActionEnum.Edit) {
							cmdUpdate.Enabled=false;
							cmdDelete.Enabled=false;
						}
					}
					
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

			com_BaseCurrency.Initialize(ConnectionString);
			try {

				com_BaseCurrency.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
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

			com_AllowedInternationalTransactionType.Initialize(ConnectionString);
			try {

				com_AllowedInternationalTransactionType.RefreshData(System.Data.SqlTypes.SqlString.Null);
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_TransactionTypeList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_TransactionTypeList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}

			com_AllowedDomesticTransactionType.Initialize(ConnectionString);
			try {

				com_AllowedDomesticTransactionType.RefreshData(System.Data.SqlTypes.SqlString.Null);
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_TransactionTypeList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_TransactionTypeList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
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

			Evernet.MoneyExchange.AbstractClasses.Abstract_CountryList oAbstract_CountryList = new Evernet.MoneyExchange.AbstractClasses.Abstract_CountryList(ConnectionString);

			if (!oAbstract_CountryList.Refresh(CurrentID)) {

				MainDisplay.Visible = false;
				ErrorDisplay.Visible = true;
				lab_Error.Text = String.Format("No record with ID: {0}", CurrentID.ToString());
				return;
			}

			if (!oAbstract_CountryList.Col_Name.IsNull) {

				txt_Name.Text = oAbstract_CountryList.Col_Name.Value.ToString();
			}
			else {

				txt_Name.Text = String.Empty;
			}

			if (!oAbstract_CountryList.Col_Code.IsNull) {

				txt_Code.Text = oAbstract_CountryList.Col_Code.Value.ToString();
			}
			else {

				txt_Code.Text = String.Empty;
			}

			com_BaseCurrency.Items.FindByValue(Convert.ToString(oAbstract_CountryList.Col_BaseCurrency)).Selected = true;

			com_AllowedInternationalTransactionType.Items.FindByValue(Convert.ToString(oAbstract_CountryList.Col_AllowedInternationalTransactionType)).Selected = true;

			com_AllowedDomesticTransactionType.Items.FindByValue(Convert.ToString(oAbstract_CountryList.Col_AllowedDomesticTransactionType)).Selected = true;

			if (!oAbstract_CountryList.Col_TotalInboundThresholdPerYearPerPerson.IsNull) {

				txt_TotalInboundThresholdPerYearPerPerson.Text = oAbstract_CountryList.Col_TotalInboundThresholdPerYearPerPerson.Value.ToString();
			}
			else {

				txt_TotalInboundThresholdPerYearPerPerson.Text = String.Empty;
			}

			if (!oAbstract_CountryList.Col_MaximumTransactionsPerYearPerPersonToOneBeneficery.IsNull) {

				txt_MaximumTransactionsPerYearPerPersonToOneBeneficery.Text = oAbstract_CountryList.Col_MaximumTransactionsPerYearPerPersonToOneBeneficery.Value.ToString();
			}
			else {

				txt_MaximumTransactionsPerYearPerPersonToOneBeneficery.Text = String.Empty;
			}

			if (!oAbstract_CountryList.Col_TransactionYearStartDate.IsNull) {

				txt_TransactionYearStartDate.Text = oAbstract_CountryList.Col_TransactionYearStartDate.Value.ToString();
			}
			else {

				txt_TransactionYearStartDate.Text = String.Empty;
			}

			if (!oAbstract_CountryList.Col_TransactionYearEndDate.IsNull) {

				txt_TransactionYearEndDate.Text = oAbstract_CountryList.Col_TransactionYearEndDate.Value.ToString();
			}
			else {

				txt_TransactionYearEndDate.Text = String.Empty;
			}

			if (!oAbstract_CountryList.Col_OutboundIDRequirementThreshold.IsNull) {

				txt_OutboundIDRequirementThreshold.Text = oAbstract_CountryList.Col_OutboundIDRequirementThreshold.Value.ToString();
			}
			else {

				txt_OutboundIDRequirementThreshold.Text = String.Empty;
			}

			if (!oAbstract_CountryList.Col_OutboundThresholdPerTransaction.IsNull) {

				txt_OutboundThresholdPerTransaction.Text = oAbstract_CountryList.Col_OutboundThresholdPerTransaction.Value.ToString();
			}
			else {

				txt_OutboundThresholdPerTransaction.Text = String.Empty;
			}

			if (!oAbstract_CountryList.Col_CanPayOutUSD.IsNull) {

				chk_CanPayOutUSD.Checked = oAbstract_CountryList.Col_CanPayOutUSD.Value;
			}
			else {

				chk_CanPayOutUSD.Checked = false;
			}

			if (!oAbstract_CountryList.Col_Active.IsNull) {

				chk_Active.Checked = oAbstract_CountryList.Col_Active.Value;
			}
			else {

				chk_Active.Checked = false;
			}

		}

		private void EmptyControls() {

			txt_Name.Text = String.Empty;
			txt_Code.Text = String.Empty;
			com_BaseCurrency.SelectedIndex = 0;
			com_AllowedInternationalTransactionType.SelectedIndex = 0;
			com_AllowedDomesticTransactionType.SelectedIndex = 0;
			txt_TotalInboundThresholdPerYearPerPerson.Text = String.Empty;
			txt_MaximumTransactionsPerYearPerPersonToOneBeneficery.Text = String.Empty;
			txt_TransactionYearStartDate.Text = String.Empty;
			txt_TransactionYearEndDate.Text = String.Empty;
			txt_OutboundIDRequirementThreshold.Text = String.Empty;
			txt_OutboundThresholdPerTransaction.Text = String.Empty;
			chk_CanPayOutUSD.Checked = false;
			chk_Active.Checked = false;
		}

		private void cmdAdd_Click(object sender, System.EventArgs e) {

			if (ReturnURL.Visible) {

				Response.Redirect(String.Format("WebForm_CountryList.aspx?Action=Add&ReturnToUrl={0}&ReturnToDisplay={1}", ReturnURL.NavigateUrl, ReturnURL.Text));
			}
			else {

				Response.Redirect("WebForm_CountryList.aspx?Action=Add");
			}
		}

		private void cmdUpdate_Click(object sender, System.EventArgs e) {

			if (!CheckValues()) {
			
				return;
			}

			if (Action == ActionEnum.Edit) {

				Params.spU_CountryList Param = null;
				SPs.spU_CountryList SP = null;

				Param = new Params.spU_CountryList();

				Param.SetUpConnection(ConnectionString);

				Param.Param_Id = CurrentID;

				if (txt_Name.Text.Trim() != String.Empty) {

					Param.Param_Name = new System.Data.SqlTypes.SqlString(txt_Name.Text);
				}

				if (txt_Code.Text.Trim() != String.Empty) {

					Param.Param_Code = new System.Data.SqlTypes.SqlString(txt_Code.Text);
				}

				Param.Param_BaseCurrency = new Guid(com_BaseCurrency.SelectedItem.Value);

				Param.Param_AllowedInternationalTransactionType = Convert.ToString(com_AllowedInternationalTransactionType.SelectedItem.Value);

				Param.Param_AllowedDomesticTransactionType = Convert.ToString(com_AllowedDomesticTransactionType.SelectedItem.Value);

				if (txt_TotalInboundThresholdPerYearPerPerson.Text.Trim() != String.Empty) {

					Param.Param_TotalInboundThresholdPerYearPerPerson = new System.Data.SqlTypes.SqlMoney(System.Convert.ToDecimal(txt_TotalInboundThresholdPerYearPerPerson.Text));
				}

				if (txt_MaximumTransactionsPerYearPerPersonToOneBeneficery.Text.Trim() != String.Empty) {

					Param.Param_MaximumTransactionsPerYearPerPersonToOneBeneficery = new System.Data.SqlTypes.SqlInt32(System.Convert.ToInt32(txt_MaximumTransactionsPerYearPerPersonToOneBeneficery.Text));
				}

				if (txt_TransactionYearStartDate.Text.Trim() != String.Empty) {

					Param.Param_TransactionYearStartDate = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_TransactionYearStartDate.Text));
				}

				if (txt_TransactionYearEndDate.Text.Trim() != String.Empty) {

					Param.Param_TransactionYearEndDate = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_TransactionYearEndDate.Text));
				}

				if (txt_OutboundIDRequirementThreshold.Text.Trim() != String.Empty) {

					Param.Param_OutboundIDRequirementThreshold = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_OutboundIDRequirementThreshold.Text));
				}

				if (txt_OutboundThresholdPerTransaction.Text.Trim() != String.Empty) {

					Param.Param_OutboundThresholdPerTransaction = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_OutboundThresholdPerTransaction.Text));
				}

				Param.Param_CanPayOutUSD = new System.Data.SqlTypes.SqlBoolean(chk_CanPayOutUSD.Checked);
				Param.Param_Active = new System.Data.SqlTypes.SqlBoolean(chk_Active.Checked);
				SP = new SPs.spU_CountryList();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_CountryList.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", CurrentID.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_CountryList.aspx?Action=Edit&ID={0}", CurrentID.ToString()));
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

				Params.spI_CountryList Param = null;
				SPs.spI_CountryList SP = null;

				Param = new Params.spI_CountryList();

				Param.SetUpConnection(ConnectionString);

				if (txt_Name.Text.Trim() != String.Empty) {

					Param.Param_Name = new System.Data.SqlTypes.SqlString(txt_Name.Text);
				}

				if (txt_Code.Text.Trim() != String.Empty) {

					Param.Param_Code = new System.Data.SqlTypes.SqlString(txt_Code.Text);
				}

				Param.Param_BaseCurrency = new Guid(com_BaseCurrency.SelectedItem.Value);

				Param.Param_AllowedInternationalTransactionType = Convert.ToString(com_AllowedInternationalTransactionType.SelectedItem.Value);

				Param.Param_AllowedDomesticTransactionType = Convert.ToString(com_AllowedDomesticTransactionType.SelectedItem.Value);

				if (txt_TotalInboundThresholdPerYearPerPerson.Text.Trim() != String.Empty) {

					Param.Param_TotalInboundThresholdPerYearPerPerson = new System.Data.SqlTypes.SqlMoney(System.Convert.ToDecimal(txt_TotalInboundThresholdPerYearPerPerson.Text));
				}

				if (txt_MaximumTransactionsPerYearPerPersonToOneBeneficery.Text.Trim() != String.Empty) {

					Param.Param_MaximumTransactionsPerYearPerPersonToOneBeneficery = new System.Data.SqlTypes.SqlInt32(System.Convert.ToInt32(txt_MaximumTransactionsPerYearPerPersonToOneBeneficery.Text));
				}

				if (txt_TransactionYearStartDate.Text.Trim() != String.Empty) {

					Param.Param_TransactionYearStartDate = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_TransactionYearStartDate.Text));
				}

				if (txt_TransactionYearEndDate.Text.Trim() != String.Empty) {

					Param.Param_TransactionYearEndDate = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_TransactionYearEndDate.Text));
				}

				if (txt_OutboundIDRequirementThreshold.Text.Trim() != String.Empty) {

					Param.Param_OutboundIDRequirementThreshold = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_OutboundIDRequirementThreshold.Text));
				}

				if (txt_OutboundThresholdPerTransaction.Text.Trim() != String.Empty) {

					Param.Param_OutboundThresholdPerTransaction = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_OutboundThresholdPerTransaction.Text));
				}

				Param.Param_CanPayOutUSD = new System.Data.SqlTypes.SqlBoolean(chk_CanPayOutUSD.Checked);
				Param.Param_Active = new System.Data.SqlTypes.SqlBoolean(chk_Active.Checked);
				SP = new SPs.spI_CountryList();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_CountryList.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", Param.Param_Id.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_CountryList.aspx?Action=Edit&ID={0}", Param.Param_Id.ToString()));
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

			Params.spD_CountryList Param = null;
			SPs.spD_CountryList SP = null;

			Param = new Params.spD_CountryList();

			Param.SetUpConnection(ConnectionString);

			Param.Param_Id = CurrentID;

			SP = new SPs.spD_CountryList();

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

				System.Data.SqlTypes.SqlMoney value = new System.Data.SqlTypes.SqlMoney(System.Convert.ToDecimal(txt_TotalInboundThresholdPerYearPerPerson.Text));
			}

			catch {

				labError_TotalInboundThresholdPerYearPerPerson.Text = "INVALID";
				labError_TotalInboundThresholdPerYearPerPerson.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlInt32 value = new System.Data.SqlTypes.SqlInt32(System.Convert.ToInt32(txt_MaximumTransactionsPerYearPerPersonToOneBeneficery.Text));
			}

			catch {

				labError_MaximumTransactionsPerYearPerPersonToOneBeneficery.Text = "INVALID";
				labError_MaximumTransactionsPerYearPerPersonToOneBeneficery.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDateTime value = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_TransactionYearStartDate.Text));
			}

			catch {

				labError_TransactionYearStartDate.Text = "INVALID";
				labError_TransactionYearStartDate.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDateTime value = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_TransactionYearEndDate.Text));
			}

			catch {

				labError_TransactionYearEndDate.Text = "INVALID";
				labError_TransactionYearEndDate.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_OutboundIDRequirementThreshold.Text));
			}

			catch {

				labError_OutboundIDRequirementThreshold.Text = "INVALID";
				labError_OutboundIDRequirementThreshold.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_OutboundThresholdPerTransaction.Text));
			}

			catch {

				labError_OutboundThresholdPerTransaction.Text = "INVALID";
				labError_OutboundThresholdPerTransaction.Visible = true;
				status = false;
			}

			return(status);
		}
	}
}
