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
	/// Summary description for WebForm_AgentMaster.
	/// </summary>
	public class WebForm_AgentMaster : System.Web.UI.Page {

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
		protected System.Web.UI.WebControls.Label lab_Number;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Number;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Number;
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
		protected System.Web.UI.WebControls.Label lab_PayInThreshold;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_PayInThreshold;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_PayInThreshold;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_BankSwiftCode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_BankSwiftCode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_BankSwiftCode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_DraftStatusUrl;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_DraftStatusUrl;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_DraftStatusUrl;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_DraftStatusVariable;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_DraftStatusVariable;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_DraftStatusVariable;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_CountryId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CountryList com_CountryId;
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
		public WebForm_AgentMaster() {

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
			labError_PayInThreshold.Visible = false;

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

					if(!User.IsInRole(UserRoles.AgentAccountManagerCreator.ToString())
						&&
						!User.IsInRole(UserRoles.Administrator.ToString())) {
						if(Action==ActionEnum.Add) {
							cmdUpdate.Enabled=false;
						}
					}

					if(!User.IsInRole(UserRoles.AgentAccountManagerEditor.ToString())
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

			com_CountryId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
			try {

				com_CountryId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
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
			com_CountryId.Items.Insert(0, "[No value set]");

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

			Evernet.MoneyExchange.AbstractClasses.Abstract_AgentMaster oAbstract_AgentMaster = new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentMaster(ConnectionString);

			if (!oAbstract_AgentMaster.Refresh(CurrentID)) {

				MainDisplay.Visible = false;
				ErrorDisplay.Visible = true;
				lab_Error.Text = String.Format("No record with ID: {0}", CurrentID.ToString());
				return;
			}

			if (!oAbstract_AgentMaster.Col_Name.IsNull) {

				txt_Name.Text = oAbstract_AgentMaster.Col_Name.Value.ToString();
			}
			else {

				txt_Name.Text = String.Empty;
			}

			if (!oAbstract_AgentMaster.Col_Number.IsNull) {

				txt_Number.Text = oAbstract_AgentMaster.Col_Number.Value.ToString();
			}
			else {

				txt_Number.Text = String.Empty;
			}

			if (!oAbstract_AgentMaster.Col_CreditLimitInUSD.IsNull) {

				txt_CreditLimitInUSD.Text = oAbstract_AgentMaster.Col_CreditLimitInUSD.Value.ToString();
			}
			else {

				txt_CreditLimitInUSD.Text = String.Empty;
			}

			if (!oAbstract_AgentMaster.Col_PayInThreshold.IsNull) {

				txt_PayInThreshold.Text = oAbstract_AgentMaster.Col_PayInThreshold.Value.ToString();
			}
			else {

				txt_PayInThreshold.Text = String.Empty;
			}

			if (!oAbstract_AgentMaster.Col_BankSwiftCode.IsNull) {

				txt_BankSwiftCode.Text = oAbstract_AgentMaster.Col_BankSwiftCode.Value.ToString();
			}
			else {

				txt_BankSwiftCode.Text = String.Empty;
			}

			if (!oAbstract_AgentMaster.Col_DraftStatusUrl.IsNull) {

				txt_DraftStatusUrl.Text = oAbstract_AgentMaster.Col_DraftStatusUrl.Value.ToString();
			}
			else {

				txt_DraftStatusUrl.Text = String.Empty;
			}

			if (!oAbstract_AgentMaster.Col_DraftStatusVariable.IsNull) {

				txt_DraftStatusVariable.Text = oAbstract_AgentMaster.Col_DraftStatusVariable.Value.ToString();
			}
			else {

				txt_DraftStatusVariable.Text = String.Empty;
			}

			if (!oAbstract_AgentMaster.Col_CountryId.IsNull) {

				com_CountryId.Items.FindByValue(Convert.ToString(oAbstract_AgentMaster.Col_CountryId)).Selected = true;
			}
			else {

				com_CountryId.SelectedIndex = 0;
			}

			if (!oAbstract_AgentMaster.Col_Active.IsNull) {

				chk_Active.Checked = oAbstract_AgentMaster.Col_Active.Value;
			}
			else {

				chk_Active.Checked = false;
			}

		}

		private void EmptyControls() {

			txt_Name.Text = String.Empty;
			txt_Number.Text = String.Empty;
			txt_CreditLimitInUSD.Text = String.Empty;
			txt_PayInThreshold.Text = String.Empty;
			txt_BankSwiftCode.Text = String.Empty;
			txt_DraftStatusUrl.Text = String.Empty;
			txt_DraftStatusVariable.Text = String.Empty;
			com_CountryId.SelectedIndex = 0;
			chk_Active.Checked = false;
		}

		private void cmdAdd_Click(object sender, System.EventArgs e) {

			if (ReturnURL.Visible) {

				Response.Redirect(String.Format("WebForm_AgentMaster.aspx?Action=Add&ReturnToUrl={0}&ReturnToDisplay={1}", ReturnURL.NavigateUrl, ReturnURL.Text));
			}
			else {

				Response.Redirect("WebForm_AgentMaster.aspx?Action=Add");
			}
		}

		private void cmdUpdate_Click(object sender, System.EventArgs e) {

			if (!CheckValues()) {
			
				return;
			}

			if (Action == ActionEnum.Edit) {

				Params.spU_AgentMaster Param = null;
				SPs.spU_AgentMaster SP = null;

				Param = new Params.spU_AgentMaster();

				Param.SetUpConnection(ConnectionString);

				Param.Param_Id = CurrentID;

				if (txt_Name.Text.Trim() != String.Empty) {

					Param.Param_Name = new System.Data.SqlTypes.SqlString(txt_Name.Text);
				}

				if (txt_Number.Text.Trim() != String.Empty) {

					Param.Param_Number = new System.Data.SqlTypes.SqlString(txt_Number.Text);
				}

				if (txt_CreditLimitInUSD.Text.Trim() != String.Empty) {

					Param.Param_CreditLimitInUSD = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CreditLimitInUSD.Text));
				}

				if (txt_PayInThreshold.Text.Trim() != String.Empty) {

					Param.Param_PayInThreshold = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_PayInThreshold.Text));
				}

				if (txt_BankSwiftCode.Text.Trim() != String.Empty) {

					Param.Param_BankSwiftCode = new System.Data.SqlTypes.SqlString(txt_BankSwiftCode.Text);
				}

				if (txt_DraftStatusUrl.Text.Trim() != String.Empty) {

					Param.Param_DraftStatusUrl = new System.Data.SqlTypes.SqlString(txt_DraftStatusUrl.Text);
				}

				if (txt_DraftStatusVariable.Text.Trim() != String.Empty) {

					Param.Param_DraftStatusVariable = new System.Data.SqlTypes.SqlString(txt_DraftStatusVariable.Text);
				}

				if (com_CountryId.SelectedIndex != 0) {

					Param.Param_CountryId = new Guid(com_CountryId.SelectedItem.Value);
				}

				Param.Param_Active = new System.Data.SqlTypes.SqlBoolean(chk_Active.Checked);
				SP = new SPs.spU_AgentMaster();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_AgentMaster.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", CurrentID.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_AgentMaster.aspx?Action=Edit&ID={0}", CurrentID.ToString()));
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

				Params.spI_AgentMaster Param = null;
				SPs.spI_AgentMaster SP = null;

				Param = new Params.spI_AgentMaster();

				Param.SetUpConnection(ConnectionString);

				if (txt_Name.Text.Trim() != String.Empty) {

					Param.Param_Name = new System.Data.SqlTypes.SqlString(txt_Name.Text);
				}

				if (txt_Number.Text.Trim() != String.Empty) {

					Param.Param_Number = new System.Data.SqlTypes.SqlString(txt_Number.Text);
				}

				if (txt_CreditLimitInUSD.Text.Trim() != String.Empty) {

					Param.Param_CreditLimitInUSD = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CreditLimitInUSD.Text));
				}

				if (txt_PayInThreshold.Text.Trim() != String.Empty) {

					Param.Param_PayInThreshold = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_PayInThreshold.Text));
				}

				if (txt_BankSwiftCode.Text.Trim() != String.Empty) {

					Param.Param_BankSwiftCode = new System.Data.SqlTypes.SqlString(txt_BankSwiftCode.Text);
				}

				if (txt_DraftStatusUrl.Text.Trim() != String.Empty) {

					Param.Param_DraftStatusUrl = new System.Data.SqlTypes.SqlString(txt_DraftStatusUrl.Text);
				}

				if (txt_DraftStatusVariable.Text.Trim() != String.Empty) {

					Param.Param_DraftStatusVariable = new System.Data.SqlTypes.SqlString(txt_DraftStatusVariable.Text);
				}

				if (com_CountryId.SelectedIndex != 0) {

					Param.Param_CountryId = new Guid(com_CountryId.SelectedItem.Value);
				}

				Param.Param_Active = new System.Data.SqlTypes.SqlBoolean(chk_Active.Checked);
				SP = new SPs.spI_AgentMaster();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_AgentMaster.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", Param.Param_Id.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_AgentMaster.aspx?Action=Edit&ID={0}", Param.Param_Id.ToString()));
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

			Params.spD_AgentMaster Param = null;
			SPs.spD_AgentMaster SP = null;

			Param = new Params.spD_AgentMaster();

			Param.SetUpConnection(ConnectionString);

			Param.Param_Id = CurrentID;

			SP = new SPs.spD_AgentMaster();

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

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CreditLimitInUSD.Text));
			}

			catch {

				labError_CreditLimitInUSD.Text = "INVALID";
				labError_CreditLimitInUSD.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_PayInThreshold.Text));
			}

			catch {

				labError_PayInThreshold.Text = "INVALID";
				labError_PayInThreshold.Visible = true;
				status = false;
			}

			return(status);
		}
	}
}
