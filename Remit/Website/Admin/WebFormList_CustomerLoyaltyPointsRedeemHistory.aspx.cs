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
	/// Summary description for WebFormList_CustomerLoyaltyPointsRedeemHistory.
	/// </summary>
	public class WebFormList_CustomerLoyaltyPointsRedeemHistory: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_CustomerLoyaltyPointsRedeemHistory() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_CustomerLoyaltyPointsRedeemHistory_SelectDisplay repeater_CustomerLoyaltyPointsRedeemHistory_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CustomerList com_CustomerId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_ProductsList com_ProductsId;
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
		protected System.Web.UI.WebControls.LinkButton Label_CustomerId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_ProductsId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Points;
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

				// com_CustomerId
				System.Data.SqlTypes.SqlGuid colCustomerId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["CustomerId"] != String.Empty) {
				
					try {
					
						colCustomerId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["CustomerId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_CustomerId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null);
				try {

					com_CustomerId.RefreshData(colCustomerId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CustomerList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CustomerList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_CustomerId.Items.Insert(0, "Show all");

				// com_ProductsId
				System.Data.SqlTypes.SqlGuid colProductsId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["ProductsId"] != String.Empty) {
				
					try {
					
						colProductsId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["ProductsId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_ProductsId.Initialize(ConnectionString);
				try {

					com_ProductsId.RefreshData(colProductsId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_ProductsList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_ProductsList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_ProductsId.Items.Insert(0, "Show all");

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

				if (ViewState["WebFormList_CustomerLoyaltyPointsRedeemHistory_CurrentSort"] == null) {

					ViewState.Add("WebFormList_CustomerLoyaltyPointsRedeemHistory_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_CustomerLoyaltyPointsRedeemHistory_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_CustomerLoyaltyPointsRedeemHistory_SelectDisplay.EnableViewState = true;

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

			this.com_CustomerId.SelectedIndexChanged += new System.EventHandler(this.com_CustomerId_SelectedIndexChanged);
			this.com_ProductsId.SelectedIndexChanged += new System.EventHandler(this.com_ProductsId_SelectedIndexChanged);
			this.Label_Id.Click += new System.EventHandler(this.Label_Id_Click);
			this.Label_Date.Click += new System.EventHandler(this.Label_Date_Click);
			this.Label_CustomerId.Click += new System.EventHandler(this.Label_CustomerId_Click);
			this.Label_ProductsId.Click += new System.EventHandler(this.Label_ProductsId_Click);
			this.Label_Points.Click += new System.EventHandler(this.Label_Points_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_Id
			, SortBy_Date
			, SortBy_CustomerId
			, SortBy_ProductsId
			, SortBy_Points
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_CustomerId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_ProductsId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid CustomerId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_CustomerId.SelectedIndex != 0) {

				CustomerId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_CustomerId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlGuid ProductsId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_ProductsId.SelectedIndex != 0) {

				ProductsId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_ProductsId.SelectedItem.Value));
			}

			repeater_CustomerLoyaltyPointsRedeemHistory_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, CustomerId, ProductsId);
			try {

				repeater_CustomerLoyaltyPointsRedeemHistory_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_CustomerLoyaltyPointsRedeemHistory' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_CustomerLoyaltyPointsRedeemHistory' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_CustomerLoyaltyPointsRedeemHistory_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_CustomerLoyaltyPointsRedeemHistory_CurrentSort"]) {

				case CurrentSortEnum.SortBy_Id:
					SortDirective = spS_CustomerLoyaltyPointsRedeemHistory.Resultset1.Fields.Column_Id.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Date:
					SortDirective = spS_CustomerLoyaltyPointsRedeemHistory.Resultset1.Fields.Column_Date.ColumnName;
					break;

				case CurrentSortEnum.SortBy_CustomerId:
					SortDirective = spS_CustomerLoyaltyPointsRedeemHistory_SelectDisplay.Resultset1.Fields.Column_CustomerId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_ProductsId:
					SortDirective = spS_CustomerLoyaltyPointsRedeemHistory_SelectDisplay.Resultset1.Fields.Column_ProductsId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Points:
					SortDirective = spS_CustomerLoyaltyPointsRedeemHistory.Resultset1.Fields.Column_Points.ColumnName;
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
			repeater_CustomerLoyaltyPointsRedeemHistory_SelectDisplay.DataBind();
		}

		private void Label_Id_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerLoyaltyPointsRedeemHistory_CurrentSort"] == CurrentSortEnum.SortBy_Id) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerLoyaltyPointsRedeemHistory_CurrentSort"] = CurrentSortEnum.SortBy_Id;
			}

			RefreshList();
		}

		private void Label_Date_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerLoyaltyPointsRedeemHistory_CurrentSort"] == CurrentSortEnum.SortBy_Date) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerLoyaltyPointsRedeemHistory_CurrentSort"] = CurrentSortEnum.SortBy_Date;
			}

			RefreshList();
		}

		private void Label_CustomerId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerLoyaltyPointsRedeemHistory_CurrentSort"] == CurrentSortEnum.SortBy_CustomerId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerLoyaltyPointsRedeemHistory_CurrentSort"] = CurrentSortEnum.SortBy_CustomerId;
			}

			RefreshList();
		}

		private void Label_ProductsId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerLoyaltyPointsRedeemHistory_CurrentSort"] == CurrentSortEnum.SortBy_ProductsId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerLoyaltyPointsRedeemHistory_CurrentSort"] = CurrentSortEnum.SortBy_ProductsId;
			}

			RefreshList();
		}

		private void Label_Points_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerLoyaltyPointsRedeemHistory_CurrentSort"] == CurrentSortEnum.SortBy_Points) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerLoyaltyPointsRedeemHistory_CurrentSort"] = CurrentSortEnum.SortBy_Points;
			}

			RefreshList();
		}

	}
}
