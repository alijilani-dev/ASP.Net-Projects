/*
	This C# source code was automatically generated using:

		SQL Server Centric .NET Code Generator
			v 1.0.1697.21165

			Generation Date: 11/30/2004 11:54:02 PM
			Generator name: EVERNET\kvsg
			Template last update: 10/13/2003 4:51:40 AM
			Template revision: 56177501

			SQL Server version: 08.00.0859
			Server: localhost
			Database: [mexchange]

	WARNING: This source is provided "AS IS" without warranty of any kind.
	The author disclaims all warranties, either express or implied, including
	the warranties of merchantability and fitness for a particular purpose.
	In no event shall the author or its suppliers be liable for any damages
	whatsoever including direct, indirect, incidental, consequential, loss of
	business profits or special damages, even if the author or its suppliers
	have been advised of the possibility of such damages.

	    More information: http://www.microsoft.com/france/msdn/olymars
	Latest interim build: http://www.olymars.net/latest.zip
	       Author's blog: http://blogs.msdn.com/olymars
*/

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
using Params = Evernet.MoneyExchange.DataClasses.Parameters;
using SPs = Evernet.MoneyExchange.DataClasses.StoredProcedures;

namespace Evernet.MoneyExchange.Web.Forms {

	/// <summary>
	/// Summary description for WebForm_PaymentHistory.
	/// </summary>
	public class WebForm_PaymentHistory : System.Web.UI.Page {

		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Id;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Id;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Id;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_EntryDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_EntryDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_EntryDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PaymentDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_PaymentDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_PaymentDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_PaymentCurrencyId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CurrencyList com_PaymentCurrencyId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Debit;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Debit;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Debit;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Credit;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Credit;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Credit;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Type;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_PaymentType com_Type;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Particulars;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Particulars;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Particulars;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Button cmdRefresh;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Button cmdDelete;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Panel MainDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Error;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Panel ErrorDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Button cmdUpdate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.HyperLink ReturnURL;
	
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebForm_PaymentHistory() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString;
		private ActionEnum Action = ActionEnum.None;
		private System.Data.SqlTypes.SqlGuid CurrentID = System.Data.SqlTypes.SqlGuid.Null;

		private enum ActionEnum {

			None, Add, Edit, Delete
		}

		private System.Globalization.CultureInfo CurrentUserCulture;
		private void Page_Load(object sender, System.EventArgs e) {

			string Language = "en-US";
			if (Request.UserLanguages.Length != 0) {

				Language = Request.UserLanguages[0];
			}

			CurrentUserCulture = System.Globalization.CultureInfo.CreateSpecificCulture(Language);
			System.Threading.Thread.CurrentThread.CurrentUICulture = CurrentUserCulture;
			System.Threading.Thread.CurrentThread.CurrentCulture = CurrentUserCulture;

			/*
				Add the following in your web.config file
				<appSettings>
					<add key="mexchange ConnectionString" value="Data Source=localhost; Initial Catalog=mexchange; Integrated Security=SSPI" />
				</appSettings>
			*/
			if (ConfigurationSettings.AppSettings["mexchange ConnectionString"] != null) {

				ConnectionString = ConfigurationSettings.AppSettings["mexchange ConnectionString"];
			}

			else if (Application["ConnectionString"] != null) {

				ConnectionString = Application["ConnectionString"].ToString().Trim();
			}

			else {

				ConnectionString = String.Empty;
			}

			if (!Page.IsPostBack) {

				if (Request.Params["ReturnToUrl"] != null) {

					ReturnURL.NavigateUrl = Request.Params["ReturnToUrl"].ToString();
					if (Request.Params["ReturnToDisplay"] != null) {

						ReturnURL.Text = Request.Params["ReturnToDisplay"].ToString();
					}
					ReturnURL.Visible = true;
				}
			}

			labError_Id.Visible = false;
			labError_EntryDateTime.Visible = false;
			labError_PaymentDateTime.Visible = false;
			labError_Debit.Visible = false;
			labError_Credit.Visible = false;

			if (Request.Params["Action"] != null) {

				switch(Request.Params["Action"].ToString()) {

					case "Add":
						Action = ActionEnum.Add;
						CurrentID = System.Data.SqlTypes.SqlGuid.Null;
						break;

					case "Edit":
						Action = ActionEnum.Edit;
						object ID = Request.Params["ID"];

						if (ID != null) {

							try {

								CurrentID = new Guid(Request.Params["ID"].ToString());
							}
							catch {

								MainDisplay.Visible = false;
								ErrorDisplay.Visible = true;
								lab_Error.Text = "ERROR: Action=Edit-> ID supplied is not a valid Guid";
								return;
							}
						}
						else {

							MainDisplay.Visible = false;
							ErrorDisplay.Visible = true;
							lab_Error.Text = "ERROR: Action=Edit-> No ID was supplied";
							return;
						}
						break;

					case "Delete":
						Action = ActionEnum.Delete;
						if (Request.Params["ID"] != null) {

							try {

								CurrentID = new Guid(Request.Params["ID"].ToString());
							}
							catch {

								MainDisplay.Visible = false;
								ErrorDisplay.Visible = true;
								lab_Error.Text = "ERROR: Action=Edit-> ID supplied is not a valid Int32";
								return;
							}
							cmdDelete_Click(null, null);
							return;
						}
						else {

							MainDisplay.Visible = false;
							ErrorDisplay.Visible = true;
							lab_Error.Text = "ERROR: Action=Delete-> No ID was supplied";
							return;
						}

					default:
						Action = ActionEnum.None;
						CurrentID = System.Data.SqlTypes.SqlGuid.Null;
						MainDisplay.Visible = false;
						ErrorDisplay.Visible = true;
						lab_Error.Text = "ERROR: Action must be Add, Edit Or Delete";
						return;
				}

				if (!Page.IsPostBack) {

					RefreshAll();
				}
			}

			else {

				MainDisplay.Visible = false;
				ErrorDisplay.Visible = true;
				lab_Error.Text = "ERROR: No Action was supplied";
			}
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

			this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
			this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
			this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void RefreshForeignTables() {

			com_PaymentCurrencyId.Initialize(ConnectionString);
			try {

				com_PaymentCurrencyId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CurrencyList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CurrencyList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}

			com_Type.Initialize(ConnectionString);
			try {

				com_Type.RefreshData(System.Data.SqlTypes.SqlString.Null);
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_PaymentType' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_PaymentType' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}

		}

		private void UpdateForm() {

			if (Action == ActionEnum.Edit || Action == ActionEnum.None) {

				cmdRefresh.Visible = true;
				cmdDelete.Visible = true;
				cmdUpdate.Visible = true;
				cmdUpdate.Text = "Update";
				RefreshRecord();
			}
			else {

				cmdRefresh.Visible = false;
				cmdDelete.Visible = false;
				cmdUpdate.Visible = true;
				cmdUpdate.Text = "OK";
				EmptyControls();
			}
		}

		private void RefreshAll() {

			RefreshForeignTables();
			UpdateForm();
		}

		private void cmdRefresh_Click(object sender, System.EventArgs e) {

			RefreshAll();
		}

		private void RefreshRecord() {

			Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentHistory oAbstract_PaymentHistory = new Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentHistory(ConnectionString);

			if (!oAbstract_PaymentHistory.Refresh(CurrentID)) {

				MainDisplay.Visible = false;
				ErrorDisplay.Visible = true;
				lab_Error.Text = String.Format("No record with ID: {0}", CurrentID.ToString());
				return;
			}

			if (!oAbstract_PaymentHistory.Col_Id.IsNull) {

				txt_Id.Text = oAbstract_PaymentHistory.Col_Id.Value.ToString();
			}
			else {

				txt_Id.Text = String.Empty;
			}
				txt_Id.ReadOnly = true;

			if (!oAbstract_PaymentHistory.Col_EntryDateTime.IsNull) {

				txt_EntryDateTime.Text = oAbstract_PaymentHistory.Col_EntryDateTime.Value.ToString();
			}
			else {

				txt_EntryDateTime.Text = String.Empty;
			}

			if (!oAbstract_PaymentHistory.Col_PaymentDateTime.IsNull) {

				txt_PaymentDateTime.Text = oAbstract_PaymentHistory.Col_PaymentDateTime.Value.ToString();
			}
			else {

				txt_PaymentDateTime.Text = String.Empty;
			}

			com_PaymentCurrencyId.Items.FindByValue(Convert.ToString(oAbstract_PaymentHistory.Col_PaymentCurrencyId)).Selected = true;

			if (!oAbstract_PaymentHistory.Col_Debit.IsNull) {

				txt_Debit.Text = oAbstract_PaymentHistory.Col_Debit.Value.ToString();
			}
			else {

				txt_Debit.Text = String.Empty;
			}

			if (!oAbstract_PaymentHistory.Col_Credit.IsNull) {

				txt_Credit.Text = oAbstract_PaymentHistory.Col_Credit.Value.ToString();
			}
			else {

				txt_Credit.Text = String.Empty;
			}

			com_Type.Items.FindByValue(Convert.ToString(oAbstract_PaymentHistory.Col_Type)).Selected = true;

			if (!oAbstract_PaymentHistory.Col_Particulars.IsNull) {

				txt_Particulars.Text = oAbstract_PaymentHistory.Col_Particulars.Value.ToString();
			}
			else {

				txt_Particulars.Text = String.Empty;
			}

		}

		private void EmptyControls() {

			txt_Id.Text = String.Empty;
			txt_EntryDateTime.Text = String.Empty;
			txt_PaymentDateTime.Text = String.Empty;
			com_PaymentCurrencyId.SelectedIndex = 0;
			txt_Debit.Text = String.Empty;
			txt_Credit.Text = String.Empty;
			com_Type.SelectedIndex = 0;
			txt_Particulars.Text = String.Empty;
		}

		private void cmdAdd_Click(object sender, System.EventArgs e) {

			if (ReturnURL.Visible) {

				Response.Redirect(String.Format("WebForm_PaymentHistory.aspx?Action=Add&ReturnToUrl={0}&ReturnToDisplay={1}", ReturnURL.NavigateUrl, ReturnURL.Text));
			}
			else {

				Response.Redirect("WebForm_PaymentHistory.aspx?Action=Add");
			}
		}

		private void cmdUpdate_Click(object sender, System.EventArgs e) {

			if (!CheckValues()) {
			
				return;
			}

			if (Action == ActionEnum.Edit) {

				Params.spU_PaymentHistory Param = null;
				SPs.spU_PaymentHistory SP = null;

				Param = new Params.spU_PaymentHistory();

				Param.SetUpConnection(ConnectionString);

				Param.Param_Id = CurrentID;

				if (txt_Id.Text.Trim() != String.Empty) {

					Param.Param_Id = new System.Data.SqlTypes.SqlGuid(new System.Guid(txt_Id.Text));
				}

				if (txt_EntryDateTime.Text.Trim() != String.Empty) {

					Param.Param_EntryDateTime = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_EntryDateTime.Text));
				}

				if (txt_PaymentDateTime.Text.Trim() != String.Empty) {

					Param.Param_PaymentDateTime = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_PaymentDateTime.Text));
				}

				Param.Param_PaymentCurrencyId = new Guid(com_PaymentCurrencyId.SelectedItem.Value);

				if (txt_Debit.Text.Trim() != String.Empty) {

					Param.Param_Debit = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_Debit.Text));
				}

				if (txt_Credit.Text.Trim() != String.Empty) {

					Param.Param_Credit = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_Credit.Text));
				}

				Param.Param_Type = Convert.ToString(com_Type.SelectedItem.Value);

				if (txt_Particulars.Text.Trim() != String.Empty) {

					Param.Param_Particulars = new System.Data.SqlTypes.SqlString(txt_Particulars.Text);
				}

				SP = new SPs.spU_PaymentHistory();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_PaymentHistory.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", CurrentID.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_PaymentHistory.aspx?Action=Edit&ID={0}", CurrentID.ToString()));
					}
					return;
				}
				else {

					if (Param.SqlException != null) {

						throw Param.SqlException;
					}

					if (Param.OtherException != null) {

						throw Param.OtherException;
					}
				}
			}

			else {

				Params.spI_PaymentHistory Param = null;
				SPs.spI_PaymentHistory SP = null;

				Param = new Params.spI_PaymentHistory();

				Param.SetUpConnection(ConnectionString);

				if (txt_Id.Text.Trim() != String.Empty) {

					Param.Param_Id = new System.Data.SqlTypes.SqlGuid(new System.Guid(txt_Id.Text));
				}

				if (txt_EntryDateTime.Text.Trim() != String.Empty) {

					Param.Param_EntryDateTime = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_EntryDateTime.Text));
				}

				if (txt_PaymentDateTime.Text.Trim() != String.Empty) {

					Param.Param_PaymentDateTime = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_PaymentDateTime.Text));
				}

				Param.Param_PaymentCurrencyId = new Guid(com_PaymentCurrencyId.SelectedItem.Value);

				if (txt_Debit.Text.Trim() != String.Empty) {

					Param.Param_Debit = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_Debit.Text));
				}

				if (txt_Credit.Text.Trim() != String.Empty) {

					Param.Param_Credit = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_Credit.Text));
				}

				Param.Param_Type = Convert.ToString(com_Type.SelectedItem.Value);

				if (txt_Particulars.Text.Trim() != String.Empty) {

					Param.Param_Particulars = new System.Data.SqlTypes.SqlString(txt_Particulars.Text);
				}

				SP = new SPs.spI_PaymentHistory();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_PaymentHistory.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", Param.Param_Id.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_PaymentHistory.aspx?Action=Edit&ID={0}", Param.Param_Id.ToString()));
					}
					return;
				}
				else {

					if (Param.SqlException != null) {

						throw Param.SqlException;
					}

					if (Param.OtherException != null) {

						throw Param.OtherException;
					}
				}
			}
		}

		private void cmdDelete_Click(object sender, System.EventArgs e) {

			Params.spD_PaymentHistory Param = null;
			SPs.spD_PaymentHistory SP = null;

			Param = new Params.spD_PaymentHistory();

			Param.SetUpConnection(ConnectionString);

			Param.Param_Id = CurrentID;

			SP = new SPs.spD_PaymentHistory();

			if (SP.Execute(ref Param)) {

				Param.Dispose();
				SP.Dispose();

				MainDisplay.Visible = false;
				ErrorDisplay.Visible = true;
				lab_Error.Text = String.Format("Record with ID: {0} was successfully deleted!", CurrentID.ToString());

				return;
			}
			else {

				if (Param.SqlException != null) {

					throw Param.SqlException;
				}

				if (Param.OtherException != null) {

					throw Param.OtherException;
				}
			}
		}

		private bool CheckValues() {

			bool status = true;
			try {

				System.Data.SqlTypes.SqlGuid value = new System.Data.SqlTypes.SqlGuid(new System.Guid(txt_Id.Text));
			}

			catch {

				labError_Id.Text = "INVALID";
				labError_Id.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDateTime value = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_EntryDateTime.Text));
			}

			catch {

				labError_EntryDateTime.Text = "INVALID";
				labError_EntryDateTime.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDateTime value = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_PaymentDateTime.Text));
			}

			catch {

				labError_PaymentDateTime.Text = "INVALID";
				labError_PaymentDateTime.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_Debit.Text));
			}

			catch {

				labError_Debit.Text = "INVALID";
				labError_Debit.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_Credit.Text));
			}

			catch {

				labError_Credit.Text = "INVALID";
				labError_Credit.Visible = true;
				status = false;
			}

			return(status);
		}
	}
}
