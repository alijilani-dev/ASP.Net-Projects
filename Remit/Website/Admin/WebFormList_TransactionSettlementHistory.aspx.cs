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
	/// Summary description for WebFormList_TransactionSettlementHistory.
	/// </summary>
	public class WebFormList_TransactionSettlementHistory: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_TransactionSettlementHistory() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_TransactionSettlementHistory_SelectDisplay repeater_TransactionSettlementHistory_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_PaymentHistory com_PaymentId;
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
		protected System.Web.UI.WebControls.LinkButton Label_PaymentId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_TransactionId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_SettlementAmount;
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

				// com_PaymentId
				System.Data.SqlTypes.SqlGuid colPaymentId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["PaymentId"] != String.Empty) {
				
					try {
					
						colPaymentId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["PaymentId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_PaymentId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null);
				try {

					com_PaymentId.RefreshData(colPaymentId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_PaymentHistory' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_PaymentHistory' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_PaymentId.Items.Insert(0, "Show all");

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

				if (ViewState["WebFormList_TransactionSettlementHistory_CurrentSort"] == null) {

					ViewState.Add("WebFormList_TransactionSettlementHistory_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_TransactionSettlementHistory_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_TransactionSettlementHistory_SelectDisplay.EnableViewState = true;

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

			this.com_PaymentId.SelectedIndexChanged += new System.EventHandler(this.com_PaymentId_SelectedIndexChanged);
			this.com_TransactionId.SelectedIndexChanged += new System.EventHandler(this.com_TransactionId_SelectedIndexChanged);
			this.Label_Id.Click += new System.EventHandler(this.Label_Id_Click);
			this.Label_PaymentId.Click += new System.EventHandler(this.Label_PaymentId_Click);
			this.Label_TransactionId.Click += new System.EventHandler(this.Label_TransactionId_Click);
			this.Label_SettlementAmount.Click += new System.EventHandler(this.Label_SettlementAmount_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_Id
			, SortBy_PaymentId
			, SortBy_TransactionId
			, SortBy_SettlementAmount
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_PaymentId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_TransactionId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid PaymentId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_PaymentId.SelectedIndex != 0) {

				PaymentId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_PaymentId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlGuid TransactionId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_TransactionId.SelectedIndex != 0) {

				TransactionId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_TransactionId.SelectedItem.Value));
			}

			repeater_TransactionSettlementHistory_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, PaymentId, TransactionId);
			try {

				repeater_TransactionSettlementHistory_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_TransactionSettlementHistory' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_TransactionSettlementHistory' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_TransactionSettlementHistory_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_TransactionSettlementHistory_CurrentSort"]) {

				case CurrentSortEnum.SortBy_Id:
					SortDirective = spS_TransactionSettlementHistory.Resultset1.Fields.Column_Id.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PaymentId:
					SortDirective = spS_TransactionSettlementHistory_SelectDisplay.Resultset1.Fields.Column_PaymentId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_TransactionId:
					SortDirective = spS_TransactionSettlementHistory_SelectDisplay.Resultset1.Fields.Column_TransactionId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_SettlementAmount:
					SortDirective = spS_TransactionSettlementHistory.Resultset1.Fields.Column_SettlementAmount.ColumnName;
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
			repeater_TransactionSettlementHistory_SelectDisplay.DataBind();
		}

		private void Label_Id_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionSettlementHistory_CurrentSort"] == CurrentSortEnum.SortBy_Id) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionSettlementHistory_CurrentSort"] = CurrentSortEnum.SortBy_Id;
			}

			RefreshList();
		}

		private void Label_PaymentId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionSettlementHistory_CurrentSort"] == CurrentSortEnum.SortBy_PaymentId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionSettlementHistory_CurrentSort"] = CurrentSortEnum.SortBy_PaymentId;
			}

			RefreshList();
		}

		private void Label_TransactionId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionSettlementHistory_CurrentSort"] == CurrentSortEnum.SortBy_TransactionId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionSettlementHistory_CurrentSort"] = CurrentSortEnum.SortBy_TransactionId;
			}

			RefreshList();
		}

		private void Label_SettlementAmount_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_TransactionSettlementHistory_CurrentSort"] == CurrentSortEnum.SortBy_SettlementAmount) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_TransactionSettlementHistory_CurrentSort"] = CurrentSortEnum.SortBy_SettlementAmount;
			}

			RefreshList();
		}

	}
}
