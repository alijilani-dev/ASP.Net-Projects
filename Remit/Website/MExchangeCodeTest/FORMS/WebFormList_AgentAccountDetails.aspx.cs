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
	/// Summary description for WebFormList_AgentAccountDetails.
	/// </summary>
	public class WebFormList_AgentAccountDetails: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_AgentAccountDetails() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_AgentAccountDetails_SelectDisplay repeater_AgentAccountDetails_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentMaster com_AgentAccountId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionDetails com_TransactionId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Id;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_CreditDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_DebitDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AgentAccountId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_TransactionId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_CreditLC;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_CreditUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_DebitLC;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_DebitUSD;
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

				// com_TransactionId
				System.Data.SqlTypes.SqlGuid colTransactionId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["TransactionId"] != String.Empty) {
				
					try {
					
						colTransactionId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["TransactionId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_TransactionId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
				try {

					com_TransactionId.RefreshData(colTransactionId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_TransactionDetails' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_TransactionDetails' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_TransactionId.Items.Insert(0, "Show all");

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

				if (ViewState["WebFormList_AgentAccountDetails_CurrentSort"] == null) {

					ViewState.Add("WebFormList_AgentAccountDetails_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_AgentAccountDetails_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_AgentAccountDetails_SelectDisplay.EnableViewState = true;

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
			this.com_TransactionId.SelectedIndexChanged += new System.EventHandler(this.com_TransactionId_SelectedIndexChanged);
			this.Label_Id.Click += new System.EventHandler(this.Label_Id_Click);
			this.Label_CreditDateTime.Click += new System.EventHandler(this.Label_CreditDateTime_Click);
			this.Label_DebitDateTime.Click += new System.EventHandler(this.Label_DebitDateTime_Click);
			this.Label_AgentAccountId.Click += new System.EventHandler(this.Label_AgentAccountId_Click);
			this.Label_TransactionId.Click += new System.EventHandler(this.Label_TransactionId_Click);
			this.Label_CreditLC.Click += new System.EventHandler(this.Label_CreditLC_Click);
			this.Label_CreditUSD.Click += new System.EventHandler(this.Label_CreditUSD_Click);
			this.Label_DebitLC.Click += new System.EventHandler(this.Label_DebitLC_Click);
			this.Label_DebitUSD.Click += new System.EventHandler(this.Label_DebitUSD_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_Id
			, SortBy_CreditDateTime
			, SortBy_DebitDateTime
			, SortBy_AgentAccountId
			, SortBy_TransactionId
			, SortBy_CreditLC
			, SortBy_CreditUSD
			, SortBy_DebitLC
			, SortBy_DebitUSD
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_AgentAccountId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_TransactionId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid AgentAccountId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_AgentAccountId.SelectedIndex != 0) {

				AgentAccountId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_AgentAccountId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlGuid TransactionId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_TransactionId.SelectedIndex != 0) {

				TransactionId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_TransactionId.SelectedItem.Value));
			}

			repeater_AgentAccountDetails_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, AgentAccountId, TransactionId);
			try {

				repeater_AgentAccountDetails_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_AgentAccountDetails' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_AgentAccountDetails' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_AgentAccountDetails_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_AgentAccountDetails_CurrentSort"]) {

				case CurrentSortEnum.SortBy_Id:
					SortDirective = spS_AgentAccountDetails.Resultset1.Fields.Column_Id.ColumnName;
					break;

				case CurrentSortEnum.SortBy_CreditDateTime:
					SortDirective = spS_AgentAccountDetails.Resultset1.Fields.Column_CreditDateTime.ColumnName;
					break;

				case CurrentSortEnum.SortBy_DebitDateTime:
					SortDirective = spS_AgentAccountDetails.Resultset1.Fields.Column_DebitDateTime.ColumnName;
					break;

				case CurrentSortEnum.SortBy_AgentAccountId:
					SortDirective = spS_AgentAccountDetails_SelectDisplay.Resultset1.Fields.Column_AgentAccountId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_TransactionId:
					SortDirective = spS_AgentAccountDetails_SelectDisplay.Resultset1.Fields.Column_TransactionId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_CreditLC:
					SortDirective = spS_AgentAccountDetails.Resultset1.Fields.Column_CreditLC.ColumnName;
					break;

				case CurrentSortEnum.SortBy_CreditUSD:
					SortDirective = spS_AgentAccountDetails.Resultset1.Fields.Column_CreditUSD.ColumnName;
					break;

				case CurrentSortEnum.SortBy_DebitLC:
					SortDirective = spS_AgentAccountDetails.Resultset1.Fields.Column_DebitLC.ColumnName;
					break;

				case CurrentSortEnum.SortBy_DebitUSD:
					SortDirective = spS_AgentAccountDetails.Resultset1.Fields.Column_DebitUSD.ColumnName;
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
			repeater_AgentAccountDetails_SelectDisplay.DataBind();
		}

		private void Label_Id_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentAccountDetails_CurrentSort"] == CurrentSortEnum.SortBy_Id) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentAccountDetails_CurrentSort"] = CurrentSortEnum.SortBy_Id;
			}

			RefreshList();
		}

		private void Label_CreditDateTime_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentAccountDetails_CurrentSort"] == CurrentSortEnum.SortBy_CreditDateTime) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentAccountDetails_CurrentSort"] = CurrentSortEnum.SortBy_CreditDateTime;
			}

			RefreshList();
		}

		private void Label_DebitDateTime_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentAccountDetails_CurrentSort"] == CurrentSortEnum.SortBy_DebitDateTime) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentAccountDetails_CurrentSort"] = CurrentSortEnum.SortBy_DebitDateTime;
			}

			RefreshList();
		}

		private void Label_AgentAccountId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentAccountDetails_CurrentSort"] == CurrentSortEnum.SortBy_AgentAccountId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentAccountDetails_CurrentSort"] = CurrentSortEnum.SortBy_AgentAccountId;
			}

			RefreshList();
		}

		private void Label_TransactionId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentAccountDetails_CurrentSort"] == CurrentSortEnum.SortBy_TransactionId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentAccountDetails_CurrentSort"] = CurrentSortEnum.SortBy_TransactionId;
			}

			RefreshList();
		}

		private void Label_CreditLC_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentAccountDetails_CurrentSort"] == CurrentSortEnum.SortBy_CreditLC) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentAccountDetails_CurrentSort"] = CurrentSortEnum.SortBy_CreditLC;
			}

			RefreshList();
		}

		private void Label_CreditUSD_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentAccountDetails_CurrentSort"] == CurrentSortEnum.SortBy_CreditUSD) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentAccountDetails_CurrentSort"] = CurrentSortEnum.SortBy_CreditUSD;
			}

			RefreshList();
		}

		private void Label_DebitLC_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentAccountDetails_CurrentSort"] == CurrentSortEnum.SortBy_DebitLC) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentAccountDetails_CurrentSort"] = CurrentSortEnum.SortBy_DebitLC;
			}

			RefreshList();
		}

		private void Label_DebitUSD_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentAccountDetails_CurrentSort"] == CurrentSortEnum.SortBy_DebitUSD) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentAccountDetails_CurrentSort"] = CurrentSortEnum.SortBy_DebitUSD;
			}

			RefreshList();
		}

	}
}
