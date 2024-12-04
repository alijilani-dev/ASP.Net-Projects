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
	/// Summary description for WebFormList_UserList.
	/// </summary>
	public class WebFormList_UserList: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_UserList() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_UserList_SelectDisplay repeater_UserList_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentMaster com_AgentAccountId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentLocationList com_AgentId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_LoginName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_LoginPassword;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_TransactionPassword;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AgentAccountId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AgentId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Email;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_IsAgencyEmployee;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Active;
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

				// com_AgentAccountId
				System.Data.SqlTypes.SqlGuid colAgentAccountId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["AgentAccountId"] != String.Empty) {
				
					try {
					
						colAgentAccountId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["AgentAccountId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_AgentAccountId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
				try {

					com_AgentAccountId.RefreshData(colAgentAccountId);
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
				com_AgentAccountId.Items.Insert(0, "Show all");

				// com_AgentId
				System.Data.SqlTypes.SqlGuid colAgentId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["AgentId"] != String.Empty) {
				
					try {
					
						colAgentId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["AgentId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_AgentId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlGuid.Null);
				try {

					com_AgentId.RefreshData(colAgentId);
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
				com_AgentId.Items.Insert(0, "Show all");

				// Any sort preferences?
				CurrentSortEnum sortColumn = CurrentSortEnum.SortBy_LoginName;
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

				if (ViewState["WebFormList_UserList_CurrentSort"] == null) {

					ViewState.Add("WebFormList_UserList_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_UserList_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_UserList_SelectDisplay.EnableViewState = true;

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

			this.com_AgentAccountId.SelectedIndexChanged += new System.EventHandler(this.com_AgentAccountId_SelectedIndexChanged);
			this.com_AgentId.SelectedIndexChanged += new System.EventHandler(this.com_AgentId_SelectedIndexChanged);
			this.Label_LoginName.Click += new System.EventHandler(this.Label_LoginName_Click);
			this.Label_LoginPassword.Click += new System.EventHandler(this.Label_LoginPassword_Click);
			this.Label_TransactionPassword.Click += new System.EventHandler(this.Label_TransactionPassword_Click);
			this.Label_AgentAccountId.Click += new System.EventHandler(this.Label_AgentAccountId_Click);
			this.Label_AgentId.Click += new System.EventHandler(this.Label_AgentId_Click);
			this.Label_Email.Click += new System.EventHandler(this.Label_Email_Click);
			this.Label_IsAgencyEmployee.Click += new System.EventHandler(this.Label_IsAgencyEmployee_Click);
			this.Label_Active.Click += new System.EventHandler(this.Label_Active_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_LoginName
			, SortBy_LoginPassword
			, SortBy_TransactionPassword
			, SortBy_AgentAccountId
			, SortBy_AgentId
			, SortBy_Email
			, SortBy_IsAgencyEmployee
			, SortBy_Active
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_AgentAccountId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_AgentId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid AgentAccountId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_AgentAccountId.SelectedIndex != 0) {

				AgentAccountId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_AgentAccountId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlGuid AgentId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_AgentId.SelectedIndex != 0) {

				AgentId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_AgentId.SelectedItem.Value));
			}

			repeater_UserList_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, AgentAccountId, AgentId);
			try {

				repeater_UserList_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_UserList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_UserList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_UserList_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_UserList_CurrentSort"]) {

				case CurrentSortEnum.SortBy_LoginName:
					SortDirective = spS_UserList.Resultset1.Fields.Column_LoginName.ColumnName;
					break;

				case CurrentSortEnum.SortBy_LoginPassword:
					SortDirective = spS_UserList.Resultset1.Fields.Column_LoginPassword.ColumnName;
					break;

				case CurrentSortEnum.SortBy_TransactionPassword:
					SortDirective = spS_UserList.Resultset1.Fields.Column_TransactionPassword.ColumnName;
					break;

				case CurrentSortEnum.SortBy_AgentAccountId:
					SortDirective = spS_UserList_SelectDisplay.Resultset1.Fields.Column_AgentAccountId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_AgentId:
					SortDirective = spS_UserList_SelectDisplay.Resultset1.Fields.Column_AgentId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Email:
					SortDirective = spS_UserList.Resultset1.Fields.Column_Email.ColumnName;
					break;

				case CurrentSortEnum.SortBy_IsAgencyEmployee:
					SortDirective = spS_UserList.Resultset1.Fields.Column_IsAgencyEmployee.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Active:
					SortDirective = spS_UserList.Resultset1.Fields.Column_Active.ColumnName;
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
			repeater_UserList_SelectDisplay.DataBind();
		}

		private void Label_LoginName_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_UserList_CurrentSort"] == CurrentSortEnum.SortBy_LoginName) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_UserList_CurrentSort"] = CurrentSortEnum.SortBy_LoginName;
			}

			RefreshList();
		}

		private void Label_LoginPassword_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_UserList_CurrentSort"] == CurrentSortEnum.SortBy_LoginPassword) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_UserList_CurrentSort"] = CurrentSortEnum.SortBy_LoginPassword;
			}

			RefreshList();
		}

		private void Label_TransactionPassword_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_UserList_CurrentSort"] == CurrentSortEnum.SortBy_TransactionPassword) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_UserList_CurrentSort"] = CurrentSortEnum.SortBy_TransactionPassword;
			}

			RefreshList();
		}

		private void Label_AgentAccountId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_UserList_CurrentSort"] == CurrentSortEnum.SortBy_AgentAccountId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_UserList_CurrentSort"] = CurrentSortEnum.SortBy_AgentAccountId;
			}

			RefreshList();
		}

		private void Label_AgentId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_UserList_CurrentSort"] == CurrentSortEnum.SortBy_AgentId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_UserList_CurrentSort"] = CurrentSortEnum.SortBy_AgentId;
			}

			RefreshList();
		}

		private void Label_Email_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_UserList_CurrentSort"] == CurrentSortEnum.SortBy_Email) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_UserList_CurrentSort"] = CurrentSortEnum.SortBy_Email;
			}

			RefreshList();
		}

		private void Label_IsAgencyEmployee_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_UserList_CurrentSort"] == CurrentSortEnum.SortBy_IsAgencyEmployee) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_UserList_CurrentSort"] = CurrentSortEnum.SortBy_IsAgencyEmployee;
			}

			RefreshList();
		}

		private void Label_Active_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_UserList_CurrentSort"] == CurrentSortEnum.SortBy_Active) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_UserList_CurrentSort"] = CurrentSortEnum.SortBy_Active;
			}

			RefreshList();
		}

	}
}
