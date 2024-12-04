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
	/// Summary description for WebForm_AgentLocationList.
	/// </summary>
	public class WebForm_AgentLocationList : System.Web.UI.Page {

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
		protected System.Web.UI.WebControls.Label lab_AgentAccountId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentMaster com_AgentAccountId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_AgentGroupId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentGroupList com_AgentGroupId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_CreditLimitInUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_CreditLimitInUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_CreditLimitInUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_IndividualTransactionLimit;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_IndividualTransactionLimit;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_IndividualTransactionLimit;
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
		protected System.Web.UI.WebControls.Label lab_AllowedInternationalTransactionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionTypeList com_AllowedInternationalTransactionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_ListOnWebFor;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionTypeList com_ListOnWebFor;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Address;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Address;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Address;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Telephone;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Telephone;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Telephone;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Fax;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Fax;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Fax;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Email;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Email;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Email;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_LocationId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_LocationList com_LocationId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_ContactPerson;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_ContactPerson;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_ContactPerson;
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
		public WebForm_AgentLocationList() {

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

			labError_CreditLimitInUSD.Visible = false;
			labError_IndividualTransactionLimit.Visible = false;

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
					
					if(!User.IsInRole(UserRoles.AgentManagerCreator.ToString())
						&&
						!User.IsInRole(UserRoles.Administrator.ToString())) {
						if(Action==ActionEnum.Add) {
							cmdUpdate.Enabled=false;
						}
					}


					if(!User.IsInRole(UserRoles.AgentManagerEditor.ToString())
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

			com_AgentAccountId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
			try {

				com_AgentAccountId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_AgentMaster' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_AgentMaster' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}

			com_AgentGroupId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null);
			try {

				com_AgentGroupId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_AgentGroupList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_AgentGroupList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			com_AgentGroupId.Items.Insert(0, "[No value set]");

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

			com_ListOnWebFor.Initialize(ConnectionString);
			try {

				com_ListOnWebFor.RefreshData(System.Data.SqlTypes.SqlString.Null);
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

			com_LocationId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
			try {

				com_LocationId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_LocationList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_LocationList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			com_LocationId.Items.Insert(0, "[No value set]");

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

			Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList oAbstract_AgentLocationList = new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList(ConnectionString);

			if (!oAbstract_AgentLocationList.Refresh(CurrentID)) {

				MainDisplay.Visible = false;
				ErrorDisplay.Visible = true;
				lab_Error.Text = String.Format("No record with ID: {0}", CurrentID.ToString());
				return;
			}

			if (!oAbstract_AgentLocationList.Col_Name.IsNull) {

				txt_Name.Text = oAbstract_AgentLocationList.Col_Name.Value.ToString();
			}
			else {

				txt_Name.Text = String.Empty;
			}

			if (!oAbstract_AgentLocationList.Col_Code.IsNull) {

				txt_Code.Text = oAbstract_AgentLocationList.Col_Code.Value.ToString();
			}
			else {

				txt_Code.Text = String.Empty;
			}

			com_AgentAccountId.Items.FindByValue(Convert.ToString(oAbstract_AgentLocationList.Col_AgentAccountId)).Selected = true;

			if (!oAbstract_AgentLocationList.Col_AgentGroupId.IsNull) {

				com_AgentGroupId.Items.FindByValue(Convert.ToString(oAbstract_AgentLocationList.Col_AgentGroupId)).Selected = true;
			}
			else {

				com_AgentGroupId.SelectedIndex = 0;
			}

			if (!oAbstract_AgentLocationList.Col_CreditLimitInUSD.IsNull) {

				txt_CreditLimitInUSD.Text = oAbstract_AgentLocationList.Col_CreditLimitInUSD.Value.ToString();
			}
			else {

				txt_CreditLimitInUSD.Text = String.Empty;
			}

			if (!oAbstract_AgentLocationList.Col_IndividualTransactionLimit.IsNull) {

				txt_IndividualTransactionLimit.Text = oAbstract_AgentLocationList.Col_IndividualTransactionLimit.Value.ToString();
			}
			else {

				txt_IndividualTransactionLimit.Text = String.Empty;
			}

			// if(com_AllowedDomesticTransactionType.Items.FindByValue(Convert.ToString(oAbstract_AgentLocationList.Col_AllowedDomesticTransactionType))!=null)
			com_AllowedDomesticTransactionType.Items.FindByValue(Convert.ToString(oAbstract_AgentLocationList.Col_AllowedDomesticTransactionType)).Selected = true;

			com_AllowedInternationalTransactionType.Items.FindByValue(Convert.ToString(oAbstract_AgentLocationList.Col_AllowedInternationalTransactionType)).Selected = true;

			com_ListOnWebFor.Items.FindByValue(Convert.ToString(oAbstract_AgentLocationList.Col_ListOnWebFor)).Selected = true;

			if (!oAbstract_AgentLocationList.Col_Address.IsNull) {

				txt_Address.Text = oAbstract_AgentLocationList.Col_Address.Value.ToString();
			}
			else {

				txt_Address.Text = String.Empty;
			}

			if (!oAbstract_AgentLocationList.Col_Telephone.IsNull) {

				txt_Telephone.Text = oAbstract_AgentLocationList.Col_Telephone.Value.ToString();
			}
			else {

				txt_Telephone.Text = String.Empty;
			}

			if (!oAbstract_AgentLocationList.Col_Fax.IsNull) {

				txt_Fax.Text = oAbstract_AgentLocationList.Col_Fax.Value.ToString();
			}
			else {

				txt_Fax.Text = String.Empty;
			}

			if (!oAbstract_AgentLocationList.Col_Email.IsNull) {

				txt_Email.Text = oAbstract_AgentLocationList.Col_Email.Value.ToString();
			}
			else {

				txt_Email.Text = String.Empty;
			}

			if (!oAbstract_AgentLocationList.Col_LocationId.IsNull) {

				com_LocationId.Items.FindByValue(Convert.ToString(oAbstract_AgentLocationList.Col_LocationId)).Selected = true;
			}
			else {

				com_LocationId.SelectedIndex = 0;
			}

			if (!oAbstract_AgentLocationList.Col_ContactPerson.IsNull) {

				txt_ContactPerson.Text = oAbstract_AgentLocationList.Col_ContactPerson.Value.ToString();
			}
			else {

				txt_ContactPerson.Text = String.Empty;
			}

			if (!oAbstract_AgentLocationList.Col_Active.IsNull) {

				chk_Active.Checked = oAbstract_AgentLocationList.Col_Active.Value;
			}
			else {

				chk_Active.Checked = false;
			}

		}

		private void EmptyControls() {

			txt_Name.Text = String.Empty;
			txt_Code.Text = String.Empty;
			com_AgentAccountId.SelectedIndex = 0;
			com_AgentGroupId.SelectedIndex = 0;
			txt_CreditLimitInUSD.Text = String.Empty;
			txt_IndividualTransactionLimit.Text = String.Empty;
			com_AllowedDomesticTransactionType.SelectedIndex = 0;
			com_AllowedInternationalTransactionType.SelectedIndex = 0;
			com_ListOnWebFor.SelectedIndex = 0;
			txt_Address.Text = String.Empty;
			txt_Telephone.Text = String.Empty;
			txt_Fax.Text = String.Empty;
			txt_Email.Text = String.Empty;
			com_LocationId.SelectedIndex = 0;
			txt_ContactPerson.Text = String.Empty;
			chk_Active.Checked = false;
		}

		private void cmdAdd_Click(object sender, System.EventArgs e) {

			if (ReturnURL.Visible) {

				Response.Redirect(String.Format("WebForm_AgentLocationList.aspx?Action=Add&ReturnToUrl={0}&ReturnToDisplay={1}", ReturnURL.NavigateUrl, ReturnURL.Text));
			}
			else {

				Response.Redirect("WebForm_AgentLocationList.aspx?Action=Add");
			}
		}

		private void cmdUpdate_Click(object sender, System.EventArgs e) {

			if (!CheckValues()) {
			
				return;
			}

			if (Action == ActionEnum.Edit) {

				Params.spU_AgentLocationList Param = null;
				SPs.spU_AgentLocationList SP = null;

				Param = new Params.spU_AgentLocationList();

				Param.SetUpConnection(ConnectionString);

				Param.Param_Id = CurrentID;

				if (txt_Name.Text.Trim() != String.Empty) {

					Param.Param_Name = new System.Data.SqlTypes.SqlString(txt_Name.Text);
				}

				if (txt_Code.Text.Trim() != String.Empty) {

					Param.Param_Code = new System.Data.SqlTypes.SqlString(txt_Code.Text);
				}

				Param.Param_AgentAccountId = new Guid(com_AgentAccountId.SelectedItem.Value);

				if (com_AgentGroupId.SelectedIndex != 0) {

					Param.Param_AgentGroupId = new Guid(com_AgentGroupId.SelectedItem.Value);
				}

//				if (txt_CreditLimitInUSD.Text.Trim() != String.Empty) {
//
//					Param.Param_CreditLimitInUSD = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CreditLimitInUSD.Text));
//				}
//
//				if (txt_IndividualTransactionLimit.Text.Trim() != String.Empty) {
//
//					Param.Param_IndividualTransactionLimit = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_IndividualTransactionLimit.Text));
//				}

				Param.Param_CreditLimitInUSD = System.Data.SqlTypes.SqlDecimal.Null;
				Param.Param_IndividualTransactionLimit = System.Data.SqlTypes.SqlDecimal.Null;

				Param.Param_AllowedDomesticTransactionType = Convert.ToString(com_AllowedDomesticTransactionType.SelectedItem.Value);

				Param.Param_AllowedInternationalTransactionType = Convert.ToString(com_AllowedInternationalTransactionType.SelectedItem.Value);

				Param.Param_ListOnWebFor = Convert.ToString(com_ListOnWebFor.SelectedItem.Value);

				if (txt_Address.Text.Trim() != String.Empty) {

					Param.Param_Address = new System.Data.SqlTypes.SqlString(txt_Address.Text);
				}

				if (txt_Telephone.Text.Trim() != String.Empty) {

					Param.Param_Telephone = new System.Data.SqlTypes.SqlString(txt_Telephone.Text);
				}

				if (txt_Fax.Text.Trim() != String.Empty) {

					Param.Param_Fax = new System.Data.SqlTypes.SqlString(txt_Fax.Text);
				}

				if (txt_Email.Text.Trim() != String.Empty) {

					Param.Param_Email = new System.Data.SqlTypes.SqlString(txt_Email.Text);
				}

				if (com_LocationId.SelectedIndex != 0) {

					Param.Param_LocationId = new Guid(com_LocationId.SelectedItem.Value);
				}

				if (txt_ContactPerson.Text.Trim() != String.Empty) {

					Param.Param_ContactPerson = new System.Data.SqlTypes.SqlString(txt_ContactPerson.Text);
				}

				Param.Param_Active = new System.Data.SqlTypes.SqlBoolean(chk_Active.Checked);
				SP = new SPs.spU_AgentLocationList();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_AgentLocationList.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", CurrentID.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_AgentLocationList.aspx?Action=Edit&ID={0}", CurrentID.ToString()));
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

				Params.spI_AgentLocationList Param = null;
				SPs.spI_AgentLocationList SP = null;

				Param = new Params.spI_AgentLocationList();

				Param.SetUpConnection(ConnectionString);

				if (txt_Name.Text.Trim() != String.Empty) {

					Param.Param_Name = new System.Data.SqlTypes.SqlString(txt_Name.Text);
				}

				if (txt_Code.Text.Trim() != String.Empty) {

					Param.Param_Code = new System.Data.SqlTypes.SqlString(txt_Code.Text);
				}

				Param.Param_AgentAccountId = new Guid(com_AgentAccountId.SelectedItem.Value);

				if (com_AgentGroupId.SelectedIndex != 0) {

					Param.Param_AgentGroupId = new Guid(com_AgentGroupId.SelectedItem.Value);
				}

				if (txt_CreditLimitInUSD.Text.Trim() != String.Empty) {

					Param.Param_CreditLimitInUSD = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CreditLimitInUSD.Text));
				}

				if (txt_IndividualTransactionLimit.Text.Trim() != String.Empty) {

					Param.Param_IndividualTransactionLimit = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_IndividualTransactionLimit.Text));
				}

				Param.Param_AllowedDomesticTransactionType = Convert.ToString(com_AllowedDomesticTransactionType.SelectedItem.Value);

				Param.Param_AllowedInternationalTransactionType = Convert.ToString(com_AllowedInternationalTransactionType.SelectedItem.Value);

				Param.Param_ListOnWebFor = Convert.ToString(com_ListOnWebFor.SelectedItem.Value);

				if (txt_Address.Text.Trim() != String.Empty) {

					Param.Param_Address = new System.Data.SqlTypes.SqlString(txt_Address.Text);
				}

				if (txt_Telephone.Text.Trim() != String.Empty) {

					Param.Param_Telephone = new System.Data.SqlTypes.SqlString(txt_Telephone.Text);
				}

				if (txt_Fax.Text.Trim() != String.Empty) {

					Param.Param_Fax = new System.Data.SqlTypes.SqlString(txt_Fax.Text);
				}

				if (txt_Email.Text.Trim() != String.Empty) {

					Param.Param_Email = new System.Data.SqlTypes.SqlString(txt_Email.Text);
				}

				if (com_LocationId.SelectedIndex != 0) {

					Param.Param_LocationId = new Guid(com_LocationId.SelectedItem.Value);
				}

				if (txt_ContactPerson.Text.Trim() != String.Empty) {

					Param.Param_ContactPerson = new System.Data.SqlTypes.SqlString(txt_ContactPerson.Text);
				}

				Param.Param_Active = new System.Data.SqlTypes.SqlBoolean(chk_Active.Checked);
				SP = new SPs.spI_AgentLocationList();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_AgentLocationList.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", Param.Param_Id.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_AgentLocationList.aspx?Action=Edit&ID={0}", Param.Param_Id.ToString()));
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

			Params.spD_AgentLocationList Param = null;
			SPs.spD_AgentLocationList SP = null;

			Param = new Params.spD_AgentLocationList();

			Param.SetUpConnection(ConnectionString);

			Param.Param_Id = CurrentID;

			SP = new SPs.spD_AgentLocationList();

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
//			try {
//
//				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CreditLimitInUSD.Text));
//			}
//
//			catch {
//
//				labError_CreditLimitInUSD.Text = "INVALID";
//				labError_CreditLimitInUSD.Visible = true;
//				status = false;
//			}
//
//			try {
//
//				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_IndividualTransactionLimit.Text));
//			}
//
//			catch {
//
//				labError_IndividualTransactionLimit.Text = "INVALID";
//				labError_IndividualTransactionLimit.Visible = true;
//				status = false;
//			}

			return(status);
		}
	}
}
