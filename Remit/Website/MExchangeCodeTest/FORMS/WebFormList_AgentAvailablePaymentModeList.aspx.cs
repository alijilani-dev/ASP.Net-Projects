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
	/// Summary description for WebFormList_AgentAvailablePaymentModeList.
	/// </summary>
	public class WebFormList_AgentAvailablePaymentModeList: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_AgentAvailablePaymentModeList() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_AgentAvailablePaymentModeList_SelectDisplay repeater_AgentAvailablePaymentModeList_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentLocationList com_AgentId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_PaymentModeList com_PaymentMode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AgentId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PaymentMode;
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

				// com_PaymentMode
				System.Data.SqlTypes.SqlString colPaymentMode = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["PaymentMode"] != String.Empty) {
				
					try {
					
						colPaymentMode = Request.Params["PaymentMode"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_PaymentMode.Initialize(ConnectionString, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
				try {

					com_PaymentMode.RefreshData(colPaymentMode);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_PaymentModeList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_PaymentModeList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_PaymentMode.Items.Insert(0, "Show all");

				// Any sort preferences?
				CurrentSortEnum sortColumn = CurrentSortEnum.SortBy_AgentId;
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

				if (ViewState["WebFormList_AgentAvailablePaymentModeList_CurrentSort"] == null) {

					ViewState.Add("WebFormList_AgentAvailablePaymentModeList_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_AgentAvailablePaymentModeList_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_AgentAvailablePaymentModeList_SelectDisplay.EnableViewState = true;

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
			this.com_PaymentMode.SelectedIndexChanged += new System.EventHandler(this.com_PaymentMode_SelectedIndexChanged);
			this.Label_AgentId.Click += new System.EventHandler(this.Label_AgentId_Click);
			this.Label_PaymentMode.Click += new System.EventHandler(this.Label_PaymentMode_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_AgentId
			, SortBy_PaymentMode
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_AgentId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_PaymentMode_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid AgentId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_AgentId.SelectedIndex != 0) {

				AgentId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_AgentId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlString PaymentMode = System.Data.SqlTypes.SqlString.Null;
			if (com_PaymentMode.SelectedIndex != 0) {

				PaymentMode = new System.Data.SqlTypes.SqlString(com_PaymentMode.SelectedItem.Value);
			}

			repeater_AgentAvailablePaymentModeList_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, AgentId, PaymentMode);
			try {

				repeater_AgentAvailablePaymentModeList_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_AgentAvailablePaymentModeList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_AgentAvailablePaymentModeList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_AgentAvailablePaymentModeList_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_AgentAvailablePaymentModeList_CurrentSort"]) {

				case CurrentSortEnum.SortBy_AgentId:
					SortDirective = spS_AgentAvailablePaymentModeList_SelectDisplay.Resultset1.Fields.Column_AgentId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PaymentMode:
					SortDirective = spS_AgentAvailablePaymentModeList_SelectDisplay.Resultset1.Fields.Column_PaymentMode_Display.ColumnName;
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
			repeater_AgentAvailablePaymentModeList_SelectDisplay.DataBind();
		}

		private void Label_AgentId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentAvailablePaymentModeList_CurrentSort"] == CurrentSortEnum.SortBy_AgentId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentAvailablePaymentModeList_CurrentSort"] = CurrentSortEnum.SortBy_AgentId;
			}

			RefreshList();
		}

		private void Label_PaymentMode_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentAvailablePaymentModeList_CurrentSort"] == CurrentSortEnum.SortBy_PaymentMode) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentAvailablePaymentModeList_CurrentSort"] = CurrentSortEnum.SortBy_PaymentMode;
			}

			RefreshList();
		}

	}
}
