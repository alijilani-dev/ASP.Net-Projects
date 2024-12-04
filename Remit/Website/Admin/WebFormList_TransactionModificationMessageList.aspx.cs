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
	/// Summary description for WebFormList_TransactionModificationMessageList.
	/// </summary>
	public class WebFormList_TransactionModificationMessageList: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_TransactionModificationMessageList() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_TransactionModificationMessageList_SelectDisplay repeater_TransactionModificationMessageList_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_UserList com_UserId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Id;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_TransactionId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Date;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_UserId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Message;
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

				if (ViewState["WebFormList_TransactionModificationMessageList_CurrentSort"] == null) {

					ViewState.Add("WebFormList_TransactionModificationMessageList_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_TransactionModificationMessageList_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_TransactionModificationMessageList_SelectDisplay.EnableViewState = true;

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
			this.Label_Id.Click += new System.EventHandler(this.Label_Id_Click);
			this.Label_TransactionId.Click += new System.EventHandler(this.Label_TransactionId_Click);
			this.Label_Date.Click += new System.EventHandler(this.Label_Date_Click);
			this.Label_UserId.Click += new System.EventHandler(this.Label_UserId_Click);
			this.Label_Message.Click += new System.EventHandler(this.Label_Message_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_Id
			, SortBy_TransactionId
			, SortBy_Date
			, SortBy_UserId
			, SortBy_Message
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_UserId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid UserId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_UserId.SelectedIndex != 0) {

				UserId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_UserId.SelectedItem.Value));
			}

			repeater_TransactionModificationMessageList_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, UserId);
			try {

				repeater_TransactionModificationMessageList_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_TransactionModificationMessageList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_TransactionModificationMessageList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_TransactionModificationMessageList_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_TransactionModificationMessageList_CurrentSort"]) {

				case CurrentSortEnum.SortBy_Id:
					SortDirective = spS_TransactionModificationMessageList.Resultset1.Fields.Column_Id.ColumnName;
					break;

				case CurrentSortEnum.SortBy_TransactionId:
					SortDirective = spS_TransactionModificationMessageList.Resultset1.Fields.Column_TransactionId.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Date:
					SortDirective = spS_TransactionModificationMessageList.Resultset1.Fields.Column_Date.ColumnName;
					break;

				case CurrentSortEnum.SortBy_UserId:
					SortDirective = spS_TransactionModificationMessageList_SelectDisplay.Resultset1.Fields.Column_UserId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Message:
					SortDirective = spS_TransactionModificationMessageList.Resultset1.Fields.Column_Message.ColumnName;
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
			repeater_TransactionModificationMessageList_SelectDisplay.DataBind();
		}

		private void Label_Id_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionModificationMessageList_CurrentSort"] == CurrentSortEnum.SortBy_Id) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionModificationMessageList_CurrentSort"] = CurrentSortEnum.SortBy_Id;
			}

			RefreshList();
		}

		private void Label_TransactionId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionModificationMessageList_CurrentSort"] == CurrentSortEnum.SortBy_TransactionId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionModificationMessageList_CurrentSort"] = CurrentSortEnum.SortBy_TransactionId;
			}

			RefreshList();
		}

		private void Label_Date_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionModificationMessageList_CurrentSort"] == CurrentSortEnum.SortBy_Date) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionModificationMessageList_CurrentSort"] = CurrentSortEnum.SortBy_Date;
			}

			RefreshList();
		}

		private void Label_UserId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionModificationMessageList_CurrentSort"] == CurrentSortEnum.SortBy_UserId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionModificationMessageList_CurrentSort"] = CurrentSortEnum.SortBy_UserId;
			}

			RefreshList();
		}

		private void Label_Message_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionModificationMessageList_CurrentSort"] == CurrentSortEnum.SortBy_Message) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionModificationMessageList_CurrentSort"] = CurrentSortEnum.SortBy_Message;
			}

			RefreshList();
		}

	}
}
