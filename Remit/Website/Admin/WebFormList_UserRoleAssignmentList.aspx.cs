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
	/// Summary description for WebFormList_UserRoleAssignmentList.
	/// </summary>
	public class WebFormList_UserRoleAssignmentList: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_UserRoleAssignmentList() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_UserRoleAssignmentList_SelectDisplay repeater_UserRoleAssignmentList_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_UserList com_UserId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_UserRoleList com_Role;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_UserId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Role;
		protected System.Web.UI.WebControls.HyperLink Add;
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

				// com_UserId
				System.Data.SqlTypes.SqlGuid colUserId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["UserId"] != String.Empty) {
				
					try {
					
						colUserId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["UserId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_UserId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
				try {

					com_UserId.RefreshData(colUserId);
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
				com_UserId.Items.Insert(0, "Show all");

				// com_Role
				System.Data.SqlTypes.SqlString colRole = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["Role"] != String.Empty) {
				
					try {
					
						colRole = Request.Params["Role"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_Role.Initialize(ConnectionString, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
				try {

					com_Role.RefreshData(colRole);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_UserRoleList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_UserRoleList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_Role.Items.Insert(0, "Show all");

				// Any sort preferences?
				CurrentSortEnum sortColumn = CurrentSortEnum.SortBy_UserId;
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

				if (ViewState["WebFormList_UserRoleAssignmentList_CurrentSort"] == null) {

					ViewState.Add("WebFormList_UserRoleAssignmentList_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_UserRoleAssignmentList_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_UserRoleAssignmentList_SelectDisplay.EnableViewState = true;

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
			this.com_UserId.SelectedIndexChanged += new System.EventHandler(this.com_UserId_SelectedIndexChanged);
			this.com_Role.SelectedIndexChanged += new System.EventHandler(this.com_Role_SelectedIndexChanged);
			this.Label_UserId.Click += new System.EventHandler(this.Label_UserId_Click);
			this.Label_Role.Click += new System.EventHandler(this.Label_Role_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_UserId
			, SortBy_Role
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_UserId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_Role_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid UserId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_UserId.SelectedIndex != 0) {

				UserId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_UserId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlString Role = System.Data.SqlTypes.SqlString.Null;
			if (com_Role.SelectedIndex != 0) {
				Role = new System.Data.SqlTypes.SqlString(com_Role.SelectedItem.Value);
			}

			repeater_UserRoleAssignmentList_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, UserId, Role);
			try {

				repeater_UserRoleAssignmentList_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_UserRoleAssignmentList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_UserRoleAssignmentList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_UserRoleAssignmentList_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_UserRoleAssignmentList_CurrentSort"]) {

				case CurrentSortEnum.SortBy_UserId:
					SortDirective = spS_UserRoleAssignmentList_SelectDisplay.Resultset1.Fields.Column_UserId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Role:
					SortDirective = spS_UserRoleAssignmentList_SelectDisplay.Resultset1.Fields.Column_Role_Display.ColumnName;
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
			repeater_UserRoleAssignmentList_SelectDisplay.DataBind();
		}

		private void Label_UserId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_UserRoleAssignmentList_CurrentSort"] == CurrentSortEnum.SortBy_UserId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_UserRoleAssignmentList_CurrentSort"] = CurrentSortEnum.SortBy_UserId;
			}

			RefreshList();
		}

		private void Label_Role_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_UserRoleAssignmentList_CurrentSort"] == CurrentSortEnum.SortBy_Role) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_UserRoleAssignmentList_CurrentSort"] = CurrentSortEnum.SortBy_Role;
			}

			RefreshList();
		}

	}
}
