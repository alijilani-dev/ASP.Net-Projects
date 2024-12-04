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
	/// Summary description for WebFormList_AgencyCommissionIncomeAccountDetails.
	/// </summary>
	public class WebFormList_AgencyCommissionIncomeAccountDetails: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_AgencyCommissionIncomeAccountDetails() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_AgencyCommissionIncomeAccountDetails_SelectDisplay repeater_AgencyCommissionIncomeAccountDetails_SelectDisplay;
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
		protected System.Web.UI.WebControls.LinkButton Label_Date;
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

				if (ViewState["WebFormList_AgencyCommissionIncomeAccountDetails_CurrentSort"] == null) {

					ViewState.Add("WebFormList_AgencyCommissionIncomeAccountDetails_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_AgencyCommissionIncomeAccountDetails_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_AgencyCommissionIncomeAccountDetails_SelectDisplay.EnableViewState = true;

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

			this.com_TransactionId.SelectedIndexChanged += new System.EventHandler(this.com_TransactionId_SelectedIndexChanged);
			this.Label_Id.Click += new System.EventHandler(this.Label_Id_Click);
			this.Label_Date.Click += new System.EventHandler(this.Label_Date_Click);
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
			, SortBy_Date
			, SortBy_TransactionId
			, SortBy_CreditLC
			, SortBy_CreditUSD
			, SortBy_DebitLC
			, SortBy_DebitUSD
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_TransactionId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid TransactionId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_TransactionId.SelectedIndex != 0) {

				TransactionId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_TransactionId.SelectedItem.Value));
			}

			repeater_AgencyCommissionIncomeAccountDetails_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, TransactionId);
			try {

				repeater_AgencyCommissionIncomeAccountDetails_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_AgencyCommissionIncomeAccountDetails' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_AgencyCommissionIncomeAccountDetails' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_AgencyCommissionIncomeAccountDetails_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_AgencyCommissionIncomeAccountDetails_CurrentSort"]) {

				case CurrentSortEnum.SortBy_Id:
					SortDirective = spS_AgencyCommissionIncomeAccountDetails.Resultset1.Fields.Column_Id.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Date:
					SortDirective = spS_AgencyCommissionIncomeAccountDetails.Resultset1.Fields.Column_Date.ColumnName;
					break;

				case CurrentSortEnum.SortBy_TransactionId:
					SortDirective = spS_AgencyCommissionIncomeAccountDetails_SelectDisplay.Resultset1.Fields.Column_TransactionId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_CreditLC:
					SortDirective = spS_AgencyCommissionIncomeAccountDetails.Resultset1.Fields.Column_CreditLC.ColumnName;
					break;

				case CurrentSortEnum.SortBy_CreditUSD:
					SortDirective = spS_AgencyCommissionIncomeAccountDetails.Resultset1.Fields.Column_CreditUSD.ColumnName;
					break;

				case CurrentSortEnum.SortBy_DebitLC:
					SortDirective = spS_AgencyCommissionIncomeAccountDetails.Resultset1.Fields.Column_DebitLC.ColumnName;
					break;

				case CurrentSortEnum.SortBy_DebitUSD:
					SortDirective = spS_AgencyCommissionIncomeAccountDetails.Resultset1.Fields.Column_DebitUSD.ColumnName;
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
			repeater_AgencyCommissionIncomeAccountDetails_SelectDisplay.DataBind();
		}

		private void Label_Id_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgencyCommissionIncomeAccountDetails_CurrentSort"] == CurrentSortEnum.SortBy_Id) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgencyCommissionIncomeAccountDetails_CurrentSort"] = CurrentSortEnum.SortBy_Id;
			}

			RefreshList();
		}

		private void Label_Date_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgencyCommissionIncomeAccountDetails_CurrentSort"] == CurrentSortEnum.SortBy_Date) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgencyCommissionIncomeAccountDetails_CurrentSort"] = CurrentSortEnum.SortBy_Date;
			}

			RefreshList();
		}

		private void Label_TransactionId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgencyCommissionIncomeAccountDetails_CurrentSort"] == CurrentSortEnum.SortBy_TransactionId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgencyCommissionIncomeAccountDetails_CurrentSort"] = CurrentSortEnum.SortBy_TransactionId;
			}

			RefreshList();
		}

		private void Label_CreditLC_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgencyCommissionIncomeAccountDetails_CurrentSort"] == CurrentSortEnum.SortBy_CreditLC) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgencyCommissionIncomeAccountDetails_CurrentSort"] = CurrentSortEnum.SortBy_CreditLC;
			}

			RefreshList();
		}

		private void Label_CreditUSD_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgencyCommissionIncomeAccountDetails_CurrentSort"] == CurrentSortEnum.SortBy_CreditUSD) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgencyCommissionIncomeAccountDetails_CurrentSort"] = CurrentSortEnum.SortBy_CreditUSD;
			}

			RefreshList();
		}

		private void Label_DebitLC_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgencyCommissionIncomeAccountDetails_CurrentSort"] == CurrentSortEnum.SortBy_DebitLC) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgencyCommissionIncomeAccountDetails_CurrentSort"] = CurrentSortEnum.SortBy_DebitLC;
			}

			RefreshList();
		}

		private void Label_DebitUSD_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgencyCommissionIncomeAccountDetails_CurrentSort"] == CurrentSortEnum.SortBy_DebitUSD) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgencyCommissionIncomeAccountDetails_CurrentSort"] = CurrentSortEnum.SortBy_DebitUSD;
			}

			RefreshList();
		}

	}
}
