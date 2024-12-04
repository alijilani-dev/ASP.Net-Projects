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
	/// Summary description for WebFormList_CustomerCardList.
	/// </summary>
	public class WebFormList_CustomerCardList: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_CustomerCardList() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_CustomerCardList_SelectDisplay repeater_CustomerCardList_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentLocationList com_AgentId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CustomerCardStatusList com_Status;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Code;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AgentId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Status;
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

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CustomerCardStatusList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CustomerCardStatusList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_Status.Items.Insert(0, "Show all");

				// Any sort preferences?
				CurrentSortEnum sortColumn = CurrentSortEnum.SortBy_Code;
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

				if (ViewState["WebFormList_CustomerCardList_CurrentSort"] == null) {

					ViewState.Add("WebFormList_CustomerCardList_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_CustomerCardList_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_CustomerCardList_SelectDisplay.EnableViewState = true;

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

			this.com_AgentId.SelectedIndexChanged += new System.EventHandler(this.com_AgentId_SelectedIndexChanged);
			this.com_Status.SelectedIndexChanged += new System.EventHandler(this.com_Status_SelectedIndexChanged);
			this.Label_Code.Click += new System.EventHandler(this.Label_Code_Click);
			this.Label_AgentId.Click += new System.EventHandler(this.Label_AgentId_Click);
			this.Label_Status.Click += new System.EventHandler(this.Label_Status_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_Code
			, SortBy_AgentId
			, SortBy_Status
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_AgentId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_Status_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid AgentId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_AgentId.SelectedIndex != 0) {

				AgentId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_AgentId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlString Status = System.Data.SqlTypes.SqlString.Null;
			if (com_Status.SelectedIndex != 0) {

				Status = new System.Data.SqlTypes.SqlString(com_Status.SelectedItem.Value);
			}

			repeater_CustomerCardList_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, AgentId, Status);
			try {

				repeater_CustomerCardList_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_CustomerCardList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_CustomerCardList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_CustomerCardList_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_CustomerCardList_CurrentSort"]) {

				case CurrentSortEnum.SortBy_Code:
					SortDirective = spS_CustomerCardList.Resultset1.Fields.Column_Code.ColumnName;
					break;

				case CurrentSortEnum.SortBy_AgentId:
					SortDirective = spS_CustomerCardList_SelectDisplay.Resultset1.Fields.Column_AgentId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Status:
					SortDirective = spS_CustomerCardList_SelectDisplay.Resultset1.Fields.Column_Status_Display.ColumnName;
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
			repeater_CustomerCardList_SelectDisplay.DataBind();
		}

		private void Label_Code_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerCardList_CurrentSort"] == CurrentSortEnum.SortBy_Code) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerCardList_CurrentSort"] = CurrentSortEnum.SortBy_Code;
			}

			RefreshList();
		}

		private void Label_AgentId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerCardList_CurrentSort"] == CurrentSortEnum.SortBy_AgentId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerCardList_CurrentSort"] = CurrentSortEnum.SortBy_AgentId;
			}

			RefreshList();
		}

		private void Label_Status_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerCardList_CurrentSort"] == CurrentSortEnum.SortBy_Status) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerCardList_CurrentSort"] = CurrentSortEnum.SortBy_Status;
			}

			RefreshList();
		}

	}
}
