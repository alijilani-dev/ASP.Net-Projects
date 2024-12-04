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
	/// Summary description for WebFormList_AgentCommissionSplitList.
	/// </summary>
	public class WebFormList_AgentCommissionSplitList: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_AgentCommissionSplitList() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_AgentCommissionSplitList_SelectDisplay repeater_AgentCommissionSplitList_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentMaster com_CurrentAccountId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentMaster com_EndNodeAccountId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Id;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_CurrentAccountId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_EndNodeAccountId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayInCommission;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayOutCommission;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Level;
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

				// com_CurrentAccountId
				System.Data.SqlTypes.SqlGuid colCurrentAccountId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["CurrentAccountId"] != String.Empty) {
				
					try {
					
						colCurrentAccountId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["CurrentAccountId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_CurrentAccountId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
				try {

					com_CurrentAccountId.RefreshData(colCurrentAccountId);
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
				com_CurrentAccountId.Items.Insert(0, "Show all");

				// com_EndNodeAccountId
				System.Data.SqlTypes.SqlGuid colEndNodeAccountId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["EndNodeAccountId"] != String.Empty) {
				
					try {
					
						colEndNodeAccountId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["EndNodeAccountId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_EndNodeAccountId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
				try {

					com_EndNodeAccountId.RefreshData(colEndNodeAccountId);
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
				com_EndNodeAccountId.Items.Insert(0, "Show all");

				// Any sort preferences?
				CurrentSortEnum sortColumn = CurrentSortEnum.SortBy_Id;
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

				if (ViewState["WebFormList_AgentCommissionSplitList_CurrentSort"] == null) {

					ViewState.Add("WebFormList_AgentCommissionSplitList_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_AgentCommissionSplitList_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_AgentCommissionSplitList_SelectDisplay.EnableViewState = true;

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

			this.com_CurrentAccountId.SelectedIndexChanged += new System.EventHandler(this.com_CurrentAccountId_SelectedIndexChanged);
			this.com_EndNodeAccountId.SelectedIndexChanged += new System.EventHandler(this.com_EndNodeAccountId_SelectedIndexChanged);
			this.Label_Id.Click += new System.EventHandler(this.Label_Id_Click);
			this.Label_CurrentAccountId.Click += new System.EventHandler(this.Label_CurrentAccountId_Click);
			this.Label_EndNodeAccountId.Click += new System.EventHandler(this.Label_EndNodeAccountId_Click);
			this.Label_PayInCommission.Click += new System.EventHandler(this.Label_PayInCommission_Click);
			this.Label_PayOutCommission.Click += new System.EventHandler(this.Label_PayOutCommission_Click);
			this.Label_Level.Click += new System.EventHandler(this.Label_Level_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_Id
			, SortBy_CurrentAccountId
			, SortBy_EndNodeAccountId
			, SortBy_PayInCommission
			, SortBy_PayOutCommission
			, SortBy_Level
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_CurrentAccountId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_EndNodeAccountId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid CurrentAccountId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_CurrentAccountId.SelectedIndex != 0) {

				CurrentAccountId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_CurrentAccountId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlGuid EndNodeAccountId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_EndNodeAccountId.SelectedIndex != 0) {

				EndNodeAccountId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_EndNodeAccountId.SelectedItem.Value));
			}

			repeater_AgentCommissionSplitList_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, CurrentAccountId, EndNodeAccountId);
			try {

				repeater_AgentCommissionSplitList_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_AgentCommissionSplitList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_AgentCommissionSplitList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_AgentCommissionSplitList_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_AgentCommissionSplitList_CurrentSort"]) {

				case CurrentSortEnum.SortBy_Id:
					SortDirective = spS_AgentCommissionSplitList.Resultset1.Fields.Column_Id.ColumnName;
					break;

				case CurrentSortEnum.SortBy_CurrentAccountId:
					SortDirective = spS_AgentCommissionSplitList_SelectDisplay.Resultset1.Fields.Column_CurrentAccountId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_EndNodeAccountId:
					SortDirective = spS_AgentCommissionSplitList_SelectDisplay.Resultset1.Fields.Column_EndNodeAccountId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayInCommission:
					SortDirective = spS_AgentCommissionSplitList.Resultset1.Fields.Column_PayInCommission.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayOutCommission:
					SortDirective = spS_AgentCommissionSplitList.Resultset1.Fields.Column_PayOutCommission.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Level:
					SortDirective = spS_AgentCommissionSplitList.Resultset1.Fields.Column_Level.ColumnName;
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
			repeater_AgentCommissionSplitList_SelectDisplay.DataBind();
		}

		private void Label_Id_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentCommissionSplitList_CurrentSort"] == CurrentSortEnum.SortBy_Id) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentCommissionSplitList_CurrentSort"] = CurrentSortEnum.SortBy_Id;
			}

			RefreshList();
		}

		private void Label_CurrentAccountId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentCommissionSplitList_CurrentSort"] == CurrentSortEnum.SortBy_CurrentAccountId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentCommissionSplitList_CurrentSort"] = CurrentSortEnum.SortBy_CurrentAccountId;
			}

			RefreshList();
		}

		private void Label_EndNodeAccountId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentCommissionSplitList_CurrentSort"] == CurrentSortEnum.SortBy_EndNodeAccountId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentCommissionSplitList_CurrentSort"] = CurrentSortEnum.SortBy_EndNodeAccountId;
			}

			RefreshList();
		}

		private void Label_PayInCommission_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentCommissionSplitList_CurrentSort"] == CurrentSortEnum.SortBy_PayInCommission) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentCommissionSplitList_CurrentSort"] = CurrentSortEnum.SortBy_PayInCommission;
			}

			RefreshList();
		}

		private void Label_PayOutCommission_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentCommissionSplitList_CurrentSort"] == CurrentSortEnum.SortBy_PayOutCommission) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentCommissionSplitList_CurrentSort"] = CurrentSortEnum.SortBy_PayOutCommission;
			}

			RefreshList();
		}

		private void Label_Level_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentCommissionSplitList_CurrentSort"] == CurrentSortEnum.SortBy_Level) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentCommissionSplitList_CurrentSort"] = CurrentSortEnum.SortBy_Level;
			}

			RefreshList();
		}

	}
}
