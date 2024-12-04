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
	/// Summary description for WebForm_CommissionSlabMaster.
	/// </summary>
	public class WebForm_CommissionSlabMaster : System.Web.UI.Page {

		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PayInCountryId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CountryList com_PayInCountryId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PayOutCountryId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CountryList com_PayOutCountryId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_ModeOfPayment;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_PaymentModeList com_ModeOfPayment;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_StartRange;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_StartRange;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_StartRange;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_EndRange;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_EndRange;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_EndRange;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_BaseToBaseCommissionAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_BaseToBaseCommissionAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_BaseToBaseCommissionAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_BaseToUSDCommissionAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_BaseToUSDCommissionAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_BaseToUSDCommissionAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PayInCommissionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CommissionSplitTypeList com_PayInCommissionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PayInCommissionAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_PayInCommissionAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_PayInCommissionAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PayOutCommissionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CommissionSplitTypeList com_PayOutCommissionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PayOutCurrencyType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CommissionCurrencyType com_PayOutCurrencyType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PayOutCommissionAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_PayOutCommissionAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_PayOutCommissionAmount;
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
		public WebForm_CommissionSlabMaster() {

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

			labError_StartRange.Visible = false;
			labError_EndRange.Visible = false;
			labError_BaseToBaseCommissionAmount.Visible = false;
			labError_BaseToUSDCommissionAmount.Visible = false;
			labError_PayInCommissionAmount.Visible = false;
			labError_PayOutCommissionAmount.Visible = false;

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

					if(!User.IsInRole(UserRoles.CommissionSlabManagerCreator.ToString())
						&&
						!User.IsInRole(UserRoles.Administrator.ToString())){
						if(Action==ActionEnum.Add) {
							cmdUpdate.Enabled=false;
						}
					}

					if(!User.IsInRole(UserRoles.CommissionSlabManagerEditor.ToString())
						&&
						!User.IsInRole(UserRoles.Administrator.ToString())){
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

			com_PayInCountryId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
			try {

				com_PayInCountryId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CountryList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CountryList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}

			com_PayOutCountryId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
			try {

				com_PayOutCountryId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CountryList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CountryList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}

			com_ModeOfPayment.Initialize(ConnectionString, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
			try {

				com_ModeOfPayment.RefreshData(System.Data.SqlTypes.SqlString.Null);
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

			com_PayInCommissionType.Initialize(ConnectionString);
			try {

				com_PayInCommissionType.RefreshData(System.Data.SqlTypes.SqlString.Null);
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CommissionSplitTypeList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CommissionSplitTypeList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}

			com_PayOutCommissionType.Initialize(ConnectionString);
			try {

				com_PayOutCommissionType.RefreshData(System.Data.SqlTypes.SqlString.Null);
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CommissionSplitTypeList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CommissionSplitTypeList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}

			com_PayOutCurrencyType.Initialize(ConnectionString);
			try {

				com_PayOutCurrencyType.RefreshData(System.Data.SqlTypes.SqlString.Null);
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CommissionCurrencyType' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CommissionCurrencyType' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
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

			Evernet.MoneyExchange.AbstractClasses.Abstract_CommissionSlabMaster oAbstract_CommissionSlabMaster = new Evernet.MoneyExchange.AbstractClasses.Abstract_CommissionSlabMaster(ConnectionString);

			if (!oAbstract_CommissionSlabMaster.Refresh(CurrentID)) {

				MainDisplay.Visible = false;
				ErrorDisplay.Visible = true;
				lab_Error.Text = String.Format("No record with ID: {0}", CurrentID.ToString());
				return;
			}

			com_PayInCountryId.Items.FindByValue(Convert.ToString(oAbstract_CommissionSlabMaster.Col_PayInCountryId)).Selected = true;

			com_PayOutCountryId.Items.FindByValue(Convert.ToString(oAbstract_CommissionSlabMaster.Col_PayOutCountryId)).Selected = true;

			com_ModeOfPayment.Items.FindByValue(Convert.ToString(oAbstract_CommissionSlabMaster.Col_ModeOfPayment)).Selected = true;

			if (!oAbstract_CommissionSlabMaster.Col_StartRange.IsNull) {

				txt_StartRange.Text = oAbstract_CommissionSlabMaster.Col_StartRange.Value.ToString();
			}
			else {

				txt_StartRange.Text = String.Empty;
			}

			if (!oAbstract_CommissionSlabMaster.Col_EndRange.IsNull) {

				txt_EndRange.Text = oAbstract_CommissionSlabMaster.Col_EndRange.Value.ToString();
			}
			else {

				txt_EndRange.Text = String.Empty;
			}

			if (!oAbstract_CommissionSlabMaster.Col_BaseToBaseCommissionAmount.IsNull) {

				txt_BaseToBaseCommissionAmount.Text = oAbstract_CommissionSlabMaster.Col_BaseToBaseCommissionAmount.Value.ToString();
			}
			else {

				txt_BaseToBaseCommissionAmount.Text = String.Empty;
			}

			if (!oAbstract_CommissionSlabMaster.Col_BaseToUSDCommissionAmount.IsNull) {

				txt_BaseToUSDCommissionAmount.Text = oAbstract_CommissionSlabMaster.Col_BaseToUSDCommissionAmount.Value.ToString();
			}
			else {

				txt_BaseToUSDCommissionAmount.Text = String.Empty;
			}

			com_PayInCommissionType.Items.FindByValue(Convert.ToString(oAbstract_CommissionSlabMaster.Col_PayInCommissionType)).Selected = true;

			if (!oAbstract_CommissionSlabMaster.Col_PayInCommissionAmount.IsNull) {

				txt_PayInCommissionAmount.Text = oAbstract_CommissionSlabMaster.Col_PayInCommissionAmount.Value.ToString();
			}
			else {

				txt_PayInCommissionAmount.Text = String.Empty;
			}

			com_PayOutCommissionType.Items.FindByValue(Convert.ToString(oAbstract_CommissionSlabMaster.Col_PayOutCommissionType)).Selected = true;

			com_PayOutCurrencyType.Items.FindByValue(Convert.ToString(oAbstract_CommissionSlabMaster.Col_PayOutCurrencyType)).Selected = true;

			if (!oAbstract_CommissionSlabMaster.Col_PayOutCommissionAmount.IsNull) {

				txt_PayOutCommissionAmount.Text = oAbstract_CommissionSlabMaster.Col_PayOutCommissionAmount.Value.ToString();
			}
			else {

				txt_PayOutCommissionAmount.Text = String.Empty;
			}

		}

		private void EmptyControls() {

			com_PayInCountryId.SelectedIndex = 0;
			com_PayOutCountryId.SelectedIndex = 0;
			com_ModeOfPayment.SelectedIndex = 0;
			txt_StartRange.Text = String.Empty;
			txt_EndRange.Text = String.Empty;
			txt_BaseToBaseCommissionAmount.Text = String.Empty;
			txt_BaseToUSDCommissionAmount.Text = String.Empty;
			com_PayInCommissionType.SelectedIndex = 0;
			txt_PayInCommissionAmount.Text = String.Empty;
			com_PayOutCommissionType.SelectedIndex = 0;
			com_PayOutCurrencyType.SelectedIndex = 0;
			txt_PayOutCommissionAmount.Text = String.Empty;
		}

		private void cmdAdd_Click(object sender, System.EventArgs e) {

			if (ReturnURL.Visible) {

				Response.Redirect(String.Format("WebForm_CommissionSlabMaster.aspx?Action=Add&ReturnToUrl={0}&ReturnToDisplay={1}", ReturnURL.NavigateUrl, ReturnURL.Text));
			}
			else {

				Response.Redirect("WebForm_CommissionSlabMaster.aspx?Action=Add");
			}
		}

		private void cmdUpdate_Click(object sender, System.EventArgs e) {

			if (!CheckValues()) {
			
				return;
			}

			if (Action == ActionEnum.Edit) {

				Params.spU_CommissionSlabMaster Param = null;
				SPs.spU_CommissionSlabMaster SP = null;

				Param = new Params.spU_CommissionSlabMaster();

				Param.SetUpConnection(ConnectionString);

				Param.Param_Id = CurrentID;

				Param.Param_PayInCountryId = new Guid(com_PayInCountryId.SelectedItem.Value);

				Param.Param_PayOutCountryId = new Guid(com_PayOutCountryId.SelectedItem.Value);

				Param.Param_ModeOfPayment = Convert.ToString(com_ModeOfPayment.SelectedItem.Value);

				if (txt_StartRange.Text.Trim() != String.Empty) {

					Param.Param_StartRange = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_StartRange.Text));
				}

				if (txt_EndRange.Text.Trim() != String.Empty) {

					Param.Param_EndRange = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_EndRange.Text));
				}

				if (txt_BaseToBaseCommissionAmount.Text.Trim() != String.Empty) {

					Param.Param_BaseToBaseCommissionAmount = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_BaseToBaseCommissionAmount.Text));
				}

				if (txt_BaseToUSDCommissionAmount.Text.Trim() != String.Empty) {

					Param.Param_BaseToUSDCommissionAmount = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_BaseToUSDCommissionAmount.Text));
				}

				Param.Param_PayInCommissionType = Convert.ToString(com_PayInCommissionType.SelectedItem.Value);

				if (txt_PayInCommissionAmount.Text.Trim() != String.Empty) {

					Param.Param_PayInCommissionAmount = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_PayInCommissionAmount.Text));
				}

				Param.Param_PayOutCommissionType = Convert.ToString(com_PayOutCommissionType.SelectedItem.Value);

				Param.Param_PayOutCurrencyType = Convert.ToString(com_PayOutCurrencyType.SelectedItem.Value);

				if (txt_PayOutCommissionAmount.Text.Trim() != String.Empty) {

					Param.Param_PayOutCommissionAmount = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_PayOutCommissionAmount.Text));
				}

				SP = new SPs.spU_CommissionSlabMaster();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_CommissionSlabMaster.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", CurrentID.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_CommissionSlabMaster.aspx?Action=Edit&ID={0}", CurrentID.ToString()));
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

				Params.spI_CommissionSlabMaster Param = null;
				SPs.spI_CommissionSlabMaster SP = null;

				Param = new Params.spI_CommissionSlabMaster();

				Param.SetUpConnection(ConnectionString);

				Param.Param_PayInCountryId = new Guid(com_PayInCountryId.SelectedItem.Value);

				Param.Param_PayOutCountryId = new Guid(com_PayOutCountryId.SelectedItem.Value);

				Param.Param_ModeOfPayment = Convert.ToString(com_ModeOfPayment.SelectedItem.Value);

				if (txt_StartRange.Text.Trim() != String.Empty) {

					Param.Param_StartRange = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_StartRange.Text));
				}

				if (txt_EndRange.Text.Trim() != String.Empty) {

					Param.Param_EndRange = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_EndRange.Text));
				}

				if (txt_BaseToBaseCommissionAmount.Text.Trim() != String.Empty) {

					Param.Param_BaseToBaseCommissionAmount = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_BaseToBaseCommissionAmount.Text));
				}

				if (txt_BaseToUSDCommissionAmount.Text.Trim() != String.Empty) {

					Param.Param_BaseToUSDCommissionAmount = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_BaseToUSDCommissionAmount.Text));
				}

				Param.Param_PayInCommissionType = Convert.ToString(com_PayInCommissionType.SelectedItem.Value);

				if (txt_PayInCommissionAmount.Text.Trim() != String.Empty) {

					Param.Param_PayInCommissionAmount = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_PayInCommissionAmount.Text));
				}

				Param.Param_PayOutCommissionType = Convert.ToString(com_PayOutCommissionType.SelectedItem.Value);

				Param.Param_PayOutCurrencyType = Convert.ToString(com_PayOutCurrencyType.SelectedItem.Value);

				if (txt_PayOutCommissionAmount.Text.Trim() != String.Empty) {

					Param.Param_PayOutCommissionAmount = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_PayOutCommissionAmount.Text));
				}

				SP = new SPs.spI_CommissionSlabMaster();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_CommissionSlabMaster.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", Param.Param_Id.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_CommissionSlabMaster.aspx?Action=Edit&ID={0}", Param.Param_Id.ToString()));
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

			Params.spD_CommissionSlabMaster Param = null;
			SPs.spD_CommissionSlabMaster SP = null;

			Param = new Params.spD_CommissionSlabMaster();

			Param.SetUpConnection(ConnectionString);

			Param.Param_Id = CurrentID;

			SP = new SPs.spD_CommissionSlabMaster();

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

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_StartRange.Text));
			}

			catch {

				labError_StartRange.Text = "INVALID";
				labError_StartRange.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_EndRange.Text));
			}

			catch {

				labError_EndRange.Text = "INVALID";
				labError_EndRange.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_BaseToBaseCommissionAmount.Text));
			}

			catch {

				labError_BaseToBaseCommissionAmount.Text = "INVALID";
				labError_BaseToBaseCommissionAmount.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_BaseToUSDCommissionAmount.Text));
			}

			catch {

				labError_BaseToUSDCommissionAmount.Text = "INVALID";
				labError_BaseToUSDCommissionAmount.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_PayInCommissionAmount.Text));
			}

			catch {

				labError_PayInCommissionAmount.Text = "INVALID";
				labError_PayInCommissionAmount.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_PayOutCommissionAmount.Text));
			}

			catch {

				labError_PayOutCommissionAmount.Text = "INVALID";
				labError_PayOutCommissionAmount.Visible = true;
				status = false;
			}

			return(status);
		}
	}
}
