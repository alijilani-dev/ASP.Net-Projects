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
	/// Summary description for WebFormList_BankList.
	/// </summary>
	public class WebFormList_BankList: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_BankList() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_BankList_SelectDisplay repeater_BankList_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentMaster com_AccountId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_LocationList com_LocationId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Name;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_BranchName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_InternalCode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_ExternalCode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Address;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_ZipCode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AccountId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_LocationId;
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

				// com_AccountId
				System.Data.SqlTypes.SqlGuid colAccountId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["AccountId"] != String.Empty) {
				
					try {
					
						colAccountId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["AccountId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_AccountId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
				try {

					com_AccountId.RefreshData(colAccountId);
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
				com_AccountId.Items.Insert(0, "Show all");

				// com_LocationId
				System.Data.SqlTypes.SqlGuid colLocationId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["LocationId"] != String.Empty) {
				
					try {
					
						colLocationId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["LocationId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_LocationId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
				try {

					com_LocationId.RefreshData(colLocationId);
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
				com_LocationId.Items.Insert(0, "Show all");

				// Any sort preferences?
				CurrentSortEnum sortColumn = CurrentSortEnum.SortBy_Name;
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

				if (ViewState["WebFormList_BankList_CurrentSort"] == null) {

					ViewState.Add("WebFormList_BankList_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_BankList_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_BankList_SelectDisplay.EnableViewState = true;

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
			this.com_AccountId.SelectedIndexChanged += new System.EventHandler(this.com_AccountId_SelectedIndexChanged);
			this.com_LocationId.SelectedIndexChanged += new System.EventHandler(this.com_LocationId_SelectedIndexChanged);
			this.Label_Name.Click += new System.EventHandler(this.Label_Name_Click);
			this.Label_BranchName.Click += new System.EventHandler(this.Label_BranchName_Click);
			this.Label_InternalCode.Click += new System.EventHandler(this.Label_InternalCode_Click);
			this.Label_ExternalCode.Click += new System.EventHandler(this.Label_ExternalCode_Click);
			this.Label_Address.Click += new System.EventHandler(this.Label_Address_Click);
			this.Label_ZipCode.Click += new System.EventHandler(this.Label_ZipCode_Click);
			this.Label_AccountId.Click += new System.EventHandler(this.Label_AccountId_Click);
			this.Label_LocationId.Click += new System.EventHandler(this.Label_LocationId_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_Name
			, SortBy_BranchName
			, SortBy_InternalCode
			, SortBy_ExternalCode
			, SortBy_Address
			, SortBy_ZipCode
			, SortBy_AccountId
			, SortBy_LocationId
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_AccountId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_LocationId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid AccountId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_AccountId.SelectedIndex != 0) {

				AccountId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_AccountId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlGuid LocationId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_LocationId.SelectedIndex != 0) {

				LocationId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_LocationId.SelectedItem.Value));
			}

			repeater_BankList_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, AccountId, LocationId);
			try {

				repeater_BankList_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_BankList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_BankList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_BankList_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_BankList_CurrentSort"]) {

				case CurrentSortEnum.SortBy_Name:
					SortDirective = spS_BankList.Resultset1.Fields.Column_Name.ColumnName;
					break;

				case CurrentSortEnum.SortBy_BranchName:
					SortDirective = spS_BankList.Resultset1.Fields.Column_BranchName.ColumnName;
					break;

				case CurrentSortEnum.SortBy_InternalCode:
					SortDirective = spS_BankList.Resultset1.Fields.Column_InternalCode.ColumnName;
					break;

				case CurrentSortEnum.SortBy_ExternalCode:
					SortDirective = spS_BankList.Resultset1.Fields.Column_ExternalCode.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Address:
					SortDirective = spS_BankList.Resultset1.Fields.Column_Address.ColumnName;
					break;

				case CurrentSortEnum.SortBy_ZipCode:
					SortDirective = spS_BankList.Resultset1.Fields.Column_ZipCode.ColumnName;
					break;

				case CurrentSortEnum.SortBy_AccountId:
					SortDirective = spS_BankList_SelectDisplay.Resultset1.Fields.Column_AccountId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_LocationId:
					SortDirective = spS_BankList_SelectDisplay.Resultset1.Fields.Column_LocationId_Display.ColumnName;
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
			repeater_BankList_SelectDisplay.DataBind();
		}

		private void Label_Name_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_BankList_CurrentSort"] == CurrentSortEnum.SortBy_Name) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_BankList_CurrentSort"] = CurrentSortEnum.SortBy_Name;
			}

			RefreshList();
		}

		private void Label_BranchName_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_BankList_CurrentSort"] == CurrentSortEnum.SortBy_BranchName) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_BankList_CurrentSort"] = CurrentSortEnum.SortBy_BranchName;
			}

			RefreshList();
		}

		private void Label_InternalCode_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_BankList_CurrentSort"] == CurrentSortEnum.SortBy_InternalCode) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_BankList_CurrentSort"] = CurrentSortEnum.SortBy_InternalCode;
			}

			RefreshList();
		}

		private void Label_ExternalCode_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_BankList_CurrentSort"] == CurrentSortEnum.SortBy_ExternalCode) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_BankList_CurrentSort"] = CurrentSortEnum.SortBy_ExternalCode;
			}

			RefreshList();
		}

		private void Label_Address_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_BankList_CurrentSort"] == CurrentSortEnum.SortBy_Address) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_BankList_CurrentSort"] = CurrentSortEnum.SortBy_Address;
			}

			RefreshList();
		}

		private void Label_ZipCode_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_BankList_CurrentSort"] == CurrentSortEnum.SortBy_ZipCode) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_BankList_CurrentSort"] = CurrentSortEnum.SortBy_ZipCode;
			}

			RefreshList();
		}

		private void Label_AccountId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_BankList_CurrentSort"] == CurrentSortEnum.SortBy_AccountId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_BankList_CurrentSort"] = CurrentSortEnum.SortBy_AccountId;
			}

			RefreshList();
		}

		private void Label_LocationId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_BankList_CurrentSort"] == CurrentSortEnum.SortBy_LocationId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_BankList_CurrentSort"] = CurrentSortEnum.SortBy_LocationId;
			}

			RefreshList();
		}

	}
}
