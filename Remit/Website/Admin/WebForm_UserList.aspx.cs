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
	/// Summary description for WebForm_UserList.
	/// </summary>
	public class WebForm_UserList : System.Web.UI.Page {

		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_LoginName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_LoginName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_LoginName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_LoginPassword;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_LoginPassword;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_LoginPassword;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_TransactionPassword;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_TransactionPassword;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_TransactionPassword;
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
		protected System.Web.UI.WebControls.Label lab_AgentId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentLocationList com_AgentId;
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
		protected System.Web.UI.WebControls.CheckBox chk_IsAgencyEmployee;
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
		public WebForm_UserList() {

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

					if(!User.IsInRole(Evernet.MoneyExchange.BusinessLogic.UserRoles.UserManagerCreator.ToString())
						&&
						!User.IsInRole(Evernet.MoneyExchange.BusinessLogic.UserRoles.Administrator.ToString())
						) {
						if(Action == ActionEnum.Add) {
							cmdUpdate.Enabled=false;
						}
					}

					if(!User.IsInRole(Evernet.MoneyExchange.BusinessLogic.UserRoles.UserManagerEditor.ToString())
						&&
						!User.IsInRole(Evernet.MoneyExchange.BusinessLogic.UserRoles.Administrator.ToString())
						) {
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
			com_AgentAccountId.Items.Insert(0, "[No value set]");

			com_AgentId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlGuid.Null);
			try {

				com_AgentId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
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
			com_AgentId.Items.Insert(0, "[No value set]");

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

			Evernet.MoneyExchange.AbstractClasses.Abstract_UserList oAbstract_UserList = new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(ConnectionString);

			if (!oAbstract_UserList.Refresh(CurrentID)) {

				MainDisplay.Visible = false;
				ErrorDisplay.Visible = true;
				lab_Error.Text = String.Format("No record with ID: {0}", CurrentID.ToString());
				return;
			}

			if (!oAbstract_UserList.Col_LoginName.IsNull) {

				txt_LoginName.Text = oAbstract_UserList.Col_LoginName.Value.ToString();
			}
			else {

				txt_LoginName.Text = String.Empty;
			}

			if (!oAbstract_UserList.Col_LoginPassword.IsNull) {

				txt_LoginPassword.Text = oAbstract_UserList.Col_LoginPassword.Value.ToString();
			}
			else {

				txt_LoginPassword.Text = String.Empty;
			}

			if (!oAbstract_UserList.Col_TransactionPassword.IsNull) {

				txt_TransactionPassword.Text = oAbstract_UserList.Col_TransactionPassword.Value.ToString();
			}
			else {

				txt_TransactionPassword.Text = String.Empty;
			}

			if (!oAbstract_UserList.Col_AgentAccountId.IsNull) {

				com_AgentAccountId.Items.FindByValue(Convert.ToString(oAbstract_UserList.Col_AgentAccountId)).Selected = true;
			}
			else {

				com_AgentAccountId.SelectedIndex = 0;
			}

			if (!oAbstract_UserList.Col_AgentId.IsNull) {

				com_AgentId.Items.FindByValue(Convert.ToString(oAbstract_UserList.Col_AgentId)).Selected = true;
			}
			else {

				com_AgentId.SelectedIndex = 0;
			}

			if (!oAbstract_UserList.Col_Email.IsNull) {

				txt_Email.Text = oAbstract_UserList.Col_Email.Value.ToString();
			}
			else {

				txt_Email.Text = String.Empty;
			}

			if (!oAbstract_UserList.Col_IsAgencyEmployee.IsNull) {

				chk_IsAgencyEmployee.Checked = oAbstract_UserList.Col_IsAgencyEmployee.Value;
			}
			else {

				chk_IsAgencyEmployee.Checked = false;
			}

			if (!oAbstract_UserList.Col_Active.IsNull) {

				chk_Active.Checked = oAbstract_UserList.Col_Active.Value;
			}
			else {

				chk_Active.Checked = false;
			}

		}

		private void EmptyControls() {

			txt_LoginName.Text = String.Empty;
			txt_LoginPassword.Text = String.Empty;
			txt_TransactionPassword.Text = String.Empty;
			com_AgentAccountId.SelectedIndex = 0;
			com_AgentId.SelectedIndex = 0;
			txt_Email.Text = String.Empty;
			chk_IsAgencyEmployee.Checked = false;
			chk_Active.Checked = false;
		}

		private void cmdAdd_Click(object sender, System.EventArgs e) {

			if (ReturnURL.Visible) {

				Response.Redirect(String.Format("WebForm_UserList.aspx?Action=Add&ReturnToUrl={0}&ReturnToDisplay={1}", ReturnURL.NavigateUrl, ReturnURL.Text));
			}
			else {

				Response.Redirect("WebForm_UserList.aspx?Action=Add");
			}
		}

		private void cmdUpdate_Click(object sender, System.EventArgs e) {

			if (!CheckValues()) {
			
				return;
			}

			if (Action == ActionEnum.Edit) {

				Params.spU_UserList Param = null;
				SPs.spU_UserList SP = null;

				Param = new Params.spU_UserList(false);

				Param.SetUpConnection(ConnectionString);

				Param.Param_Id = CurrentID;

				if (txt_LoginName.Text.Trim() != String.Empty) {

					Param.Param_LoginName = new System.Data.SqlTypes.SqlString(txt_LoginName.Text);
				}

				if (txt_LoginPassword.Text.Trim() != String.Empty) {

					Param.Param_LoginPassword = new System.Data.SqlTypes.SqlString(txt_LoginPassword.Text);
				}

				if (txt_TransactionPassword.Text.Trim() != String.Empty) {

					Param.Param_TransactionPassword = new System.Data.SqlTypes.SqlString(txt_TransactionPassword.Text);
				}

				if (com_AgentAccountId.SelectedIndex != 0) {

					Param.Param_AgentAccountId = new Guid(com_AgentAccountId.SelectedItem.Value);
				} else {
					Param.Param_AgentAccountId = System.Data.SqlTypes.SqlGuid.Null;
				}

				if (com_AgentId.SelectedIndex != 0) {

					Param.Param_AgentId = new Guid(com_AgentId.SelectedItem.Value);
				} else {
					Param.Param_AgentId = System.Data.SqlTypes.SqlGuid.Null;
				}

				if (txt_Email.Text.Trim() != String.Empty) {

					Param.Param_Email = new System.Data.SqlTypes.SqlString(txt_Email.Text);
				}

				Param.Param_IsAgencyEmployee = new System.Data.SqlTypes.SqlBoolean(chk_IsAgencyEmployee.Checked);
				Param.Param_Active = new System.Data.SqlTypes.SqlBoolean(chk_Active.Checked);
				SP = new SPs.spU_UserList();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_UserList.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", CurrentID.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_UserList.aspx?Action=Edit&ID={0}", CurrentID.ToString()));
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

				Params.spI_UserList Param = null;
				SPs.spI_UserList SP = null;

				Param = new Params.spI_UserList();

				Param.SetUpConnection(ConnectionString);

				if (txt_LoginName.Text.Trim() != String.Empty) {

					Param.Param_LoginName = new System.Data.SqlTypes.SqlString(txt_LoginName.Text);
				}

				if (txt_LoginPassword.Text.Trim() != String.Empty) {

					Param.Param_LoginPassword = new System.Data.SqlTypes.SqlString(txt_LoginPassword.Text);
				}

				if (txt_TransactionPassword.Text.Trim() != String.Empty) {

					Param.Param_TransactionPassword = new System.Data.SqlTypes.SqlString(txt_TransactionPassword.Text);
				}

				if (com_AgentAccountId.SelectedIndex != 0) {

					Param.Param_AgentAccountId = new Guid(com_AgentAccountId.SelectedItem.Value);
				}

				if (com_AgentId.SelectedIndex != 0) {

					Param.Param_AgentId = new Guid(com_AgentId.SelectedItem.Value);
				}

				if (txt_Email.Text.Trim() != String.Empty) {

					Param.Param_Email = new System.Data.SqlTypes.SqlString(txt_Email.Text);
				}

				Param.Param_IsAgencyEmployee = new System.Data.SqlTypes.SqlBoolean(chk_IsAgencyEmployee.Checked);
				Param.Param_Active = new System.Data.SqlTypes.SqlBoolean(chk_Active.Checked);
				SP = new SPs.spI_UserList();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_UserList.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", Param.Param_Id.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_UserList.aspx?Action=Edit&ID={0}", Param.Param_Id.ToString()));
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

			Params.spD_UserList Param = null;
			SPs.spD_UserList SP = null;

			Param = new Params.spD_UserList();

			Param.SetUpConnection(ConnectionString);

			Param.Param_Id = CurrentID;

			SP = new SPs.spD_UserList();

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
			return(status);
		}
	}
}
