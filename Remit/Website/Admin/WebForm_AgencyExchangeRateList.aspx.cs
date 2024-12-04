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
	/// Summary description for WebForm_AgencyExchangeRateList.
	/// </summary>
	public class WebForm_AgencyExchangeRateList : System.Web.UI.Page {

		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_ExchangeSetName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_ExchangeSetName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_ExchangeSetName;
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
		protected System.Web.UI.WebControls.Label lab_PayOutCurrencyId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CurrencyList com_PayOutCurrencyId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_MarginPercent;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_MarginPercent;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_MarginPercent;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_MaximumAgentMargin;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_MaximumAgentMargin;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_MaximumAgentMargin;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_MinimumAgentMargin;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_MinimumAgentMargin;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_MinimumAgentMargin;
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
		public WebForm_AgencyExchangeRateList() {

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

			labError_MarginPercent.Visible = false;
			labError_MaximumAgentMargin.Visible = false;
			labError_MinimumAgentMargin.Visible = false;

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

					if(!User.IsInRole(UserRoles.AgencyExchangeRateManagerCreator.ToString())
						&&
						!User.IsInRole(UserRoles.Administrator.ToString())) {

						if(Action==ActionEnum.Add) {
							cmdUpdate.Enabled=false;
						}
					}


					if(!User.IsInRole(UserRoles.AgencyExchangeRateManagerEditor.ToString())
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

			Evernet.MoneyExchange.AbstractClasses.Abstract_AgencyExchangeRateList oAbstract_AgencyExchangeRateList = new Evernet.MoneyExchange.AbstractClasses.Abstract_AgencyExchangeRateList(ConnectionString);

			if (!oAbstract_AgencyExchangeRateList.Refresh(CurrentID)) {

				MainDisplay.Visible = false;
				ErrorDisplay.Visible = true;
				lab_Error.Text = String.Format("No record with ID: {0}", CurrentID.ToString());
				return;
			}

			if (!oAbstract_AgencyExchangeRateList.Col_ExchangeSetName.IsNull) {

				txt_ExchangeSetName.Text = oAbstract_AgencyExchangeRateList.Col_ExchangeSetName.Value.ToString();
			}
			else {

				txt_ExchangeSetName.Text = String.Empty;
			}

			com_PayInCountryId.Items.FindByValue(Convert.ToString(oAbstract_AgencyExchangeRateList.Col_PayInCountryId)).Selected = true;

			com_PayOutCountryId.Items.FindByValue(Convert.ToString(oAbstract_AgencyExchangeRateList.Col_PayOutCountryId)).Selected = true;

			com_PayOutCurrencyId.Items.FindByValue(Convert.ToString(oAbstract_AgencyExchangeRateList.Col_PayOutCurrencyId)).Selected = true;

			if (!oAbstract_AgencyExchangeRateList.Col_MarginPercent.IsNull) {

				txt_MarginPercent.Text = oAbstract_AgencyExchangeRateList.Col_MarginPercent.Value.ToString();
			}
			else {

				txt_MarginPercent.Text = String.Empty;
			}

			if (!oAbstract_AgencyExchangeRateList.Col_MaximumAgentMargin.IsNull) {

				txt_MaximumAgentMargin.Text = oAbstract_AgencyExchangeRateList.Col_MaximumAgentMargin.Value.ToString();
			}
			else {

				txt_MaximumAgentMargin.Text = String.Empty;
			}

			if (!oAbstract_AgencyExchangeRateList.Col_MinimumAgentMargin.IsNull) {

				txt_MinimumAgentMargin.Text = oAbstract_AgencyExchangeRateList.Col_MinimumAgentMargin.Value.ToString();
			}
			else {

				txt_MinimumAgentMargin.Text = String.Empty;
			}

		}

		private void EmptyControls() {

			txt_ExchangeSetName.Text = String.Empty;
			com_PayInCountryId.SelectedIndex = 0;
			com_PayOutCountryId.SelectedIndex = 0;
			com_PayOutCurrencyId.SelectedIndex = 0;
			txt_MarginPercent.Text = String.Empty;
			txt_MaximumAgentMargin.Text = String.Empty;
			txt_MinimumAgentMargin.Text = String.Empty;
		}

		private void cmdAdd_Click(object sender, System.EventArgs e) {

			if (ReturnURL.Visible) {

				Response.Redirect(String.Format("WebForm_AgencyExchangeRateList.aspx?Action=Add&ReturnToUrl={0}&ReturnToDisplay={1}", ReturnURL.NavigateUrl, ReturnURL.Text));
			}
			else {

				Response.Redirect("WebForm_AgencyExchangeRateList.aspx?Action=Add");
			}
		}

		private void cmdUpdate_Click(object sender, System.EventArgs e) {

			if (!CheckValues()) {
			
				return;
			}

			if (Action == ActionEnum.Edit) {

				Params.spU_AgencyExchangeRateList Param = null;
				SPs.spU_AgencyExchangeRateList SP = null;

				Param = new Params.spU_AgencyExchangeRateList();

				Param.SetUpConnection(ConnectionString);

				Param.Param_Id = CurrentID;

				if (txt_ExchangeSetName.Text.Trim() != String.Empty) {

					Param.Param_ExchangeSetName = new System.Data.SqlTypes.SqlString(txt_ExchangeSetName.Text);
				}

				Param.Param_PayInCountryId = new Guid(com_PayInCountryId.SelectedItem.Value);

				Param.Param_PayOutCountryId = new Guid(com_PayOutCountryId.SelectedItem.Value);

				Param.Param_PayOutCurrencyId = new Guid(com_PayOutCurrencyId.SelectedItem.Value);

				if (txt_MarginPercent.Text.Trim() != String.Empty) {

					Param.Param_MarginPercent = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_MarginPercent.Text));
				}

				if (txt_MaximumAgentMargin.Text.Trim() != String.Empty) {

					Param.Param_MaximumAgentMargin = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_MaximumAgentMargin.Text));
				}

				if (txt_MinimumAgentMargin.Text.Trim() != String.Empty) {

					Param.Param_MinimumAgentMargin = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_MinimumAgentMargin.Text));
				}

				SP = new SPs.spU_AgencyExchangeRateList();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_AgencyExchangeRateList.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", CurrentID.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_AgencyExchangeRateList.aspx?Action=Edit&ID={0}", CurrentID.ToString()));
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

				Params.spI_AgencyExchangeRateList Param = null;
				SPs.spI_AgencyExchangeRateList SP = null;

				Param = new Params.spI_AgencyExchangeRateList();

				Param.SetUpConnection(ConnectionString);

				if (txt_ExchangeSetName.Text.Trim() != String.Empty) {

					Param.Param_ExchangeSetName = new System.Data.SqlTypes.SqlString(txt_ExchangeSetName.Text);
				}

				Param.Param_PayInCountryId = new Guid(com_PayInCountryId.SelectedItem.Value);

				Param.Param_PayOutCountryId = new Guid(com_PayOutCountryId.SelectedItem.Value);

				Param.Param_PayOutCurrencyId = new Guid(com_PayOutCurrencyId.SelectedItem.Value);

				if (txt_MarginPercent.Text.Trim() != String.Empty) {

					Param.Param_MarginPercent = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_MarginPercent.Text));
				}

				if (txt_MaximumAgentMargin.Text.Trim() != String.Empty) {

					Param.Param_MaximumAgentMargin = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_MaximumAgentMargin.Text));
				}

				if (txt_MinimumAgentMargin.Text.Trim() != String.Empty) {

					Param.Param_MinimumAgentMargin = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_MinimumAgentMargin.Text));
				}

				SP = new SPs.spI_AgencyExchangeRateList();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_AgencyExchangeRateList.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", Param.Param_Id.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_AgencyExchangeRateList.aspx?Action=Edit&ID={0}", Param.Param_Id.ToString()));
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

			Params.spD_AgencyExchangeRateList Param = null;
			SPs.spD_AgencyExchangeRateList SP = null;

			Param = new Params.spD_AgencyExchangeRateList();

			Param.SetUpConnection(ConnectionString);

			Param.Param_Id = CurrentID;

			SP = new SPs.spD_AgencyExchangeRateList();

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

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_MarginPercent.Text));
			}

			catch {

				labError_MarginPercent.Text = "INVALID";
				labError_MarginPercent.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_MaximumAgentMargin.Text));
			}

			catch {

				labError_MaximumAgentMargin.Text = "INVALID";
				labError_MaximumAgentMargin.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_MinimumAgentMargin.Text));
			}

			catch {

				labError_MinimumAgentMargin.Text = "INVALID";
				labError_MinimumAgentMargin.Visible = true;
				status = false;
			}

			return(status);
		}
	}
}
