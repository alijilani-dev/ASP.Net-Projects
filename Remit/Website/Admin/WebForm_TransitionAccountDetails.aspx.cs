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
	/// Summary description for WebForm_TransitionAccountDetails.
	/// </summary>
	public class WebForm_TransitionAccountDetails : System.Web.UI.Page {

		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_CreditDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_CreditDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_CreditDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_DebitDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_DebitDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_DebitDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_TransactionId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionDetails com_TransactionId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_CreditLC;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_CreditLC;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_CreditLC;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_CreditUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_CreditUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_CreditUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_DebitLC;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_DebitLC;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_DebitLC;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_DebitUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_DebitUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_DebitUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_CommissionCreditLC;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_CommissionCreditLC;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_CommissionCreditLC;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_CommissionCreditUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_CommissionCreditUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_CommissionCreditUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_CommissionDebitLC;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_CommissionDebitLC;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_CommissionDebitLC;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_CommissionDebitUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_CommissionDebitUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_CommissionDebitUSD;
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
		public WebForm_TransitionAccountDetails() {

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

			labError_CreditDateTime.Visible = false;
			labError_DebitDateTime.Visible = false;
			labError_CreditLC.Visible = false;
			labError_CreditUSD.Visible = false;
			labError_DebitLC.Visible = false;
			labError_DebitUSD.Visible = false;
			labError_CommissionCreditLC.Visible = false;
			labError_CommissionCreditUSD.Visible = false;
			labError_CommissionDebitLC.Visible = false;
			labError_CommissionDebitUSD.Visible = false;

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

			com_TransactionId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
			try {

				com_TransactionId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
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

			Evernet.MoneyExchange.AbstractClasses.Abstract_TransitionAccountDetails oAbstract_TransitionAccountDetails = new Evernet.MoneyExchange.AbstractClasses.Abstract_TransitionAccountDetails(ConnectionString);

			if (!oAbstract_TransitionAccountDetails.Refresh(CurrentID)) {

				MainDisplay.Visible = false;
				ErrorDisplay.Visible = true;
				lab_Error.Text = String.Format("No record with ID: {0}", CurrentID.ToString());
				return;
			}

			if (!oAbstract_TransitionAccountDetails.Col_CreditDateTime.IsNull) {

				txt_CreditDateTime.Text = oAbstract_TransitionAccountDetails.Col_CreditDateTime.Value.ToString();
			}
			else {

				txt_CreditDateTime.Text = String.Empty;
			}

			if (!oAbstract_TransitionAccountDetails.Col_DebitDateTime.IsNull) {

				txt_DebitDateTime.Text = oAbstract_TransitionAccountDetails.Col_DebitDateTime.Value.ToString();
			}
			else {

				txt_DebitDateTime.Text = String.Empty;
			}

			com_TransactionId.Items.FindByValue(Convert.ToString(oAbstract_TransitionAccountDetails.Col_TransactionId)).Selected = true;

			if (!oAbstract_TransitionAccountDetails.Col_CreditLC.IsNull) {

				txt_CreditLC.Text = oAbstract_TransitionAccountDetails.Col_CreditLC.Value.ToString();
			}
			else {

				txt_CreditLC.Text = String.Empty;
			}

			if (!oAbstract_TransitionAccountDetails.Col_CreditUSD.IsNull) {

				txt_CreditUSD.Text = oAbstract_TransitionAccountDetails.Col_CreditUSD.Value.ToString();
			}
			else {

				txt_CreditUSD.Text = String.Empty;
			}

			if (!oAbstract_TransitionAccountDetails.Col_DebitLC.IsNull) {

				txt_DebitLC.Text = oAbstract_TransitionAccountDetails.Col_DebitLC.Value.ToString();
			}
			else {

				txt_DebitLC.Text = String.Empty;
			}

			if (!oAbstract_TransitionAccountDetails.Col_DebitUSD.IsNull) {

				txt_DebitUSD.Text = oAbstract_TransitionAccountDetails.Col_DebitUSD.Value.ToString();
			}
			else {

				txt_DebitUSD.Text = String.Empty;
			}

			if (!oAbstract_TransitionAccountDetails.Col_CommissionCreditLC.IsNull) {

				txt_CommissionCreditLC.Text = oAbstract_TransitionAccountDetails.Col_CommissionCreditLC.Value.ToString();
			}
			else {

				txt_CommissionCreditLC.Text = String.Empty;
			}

			if (!oAbstract_TransitionAccountDetails.Col_CommissionCreditUSD.IsNull) {

				txt_CommissionCreditUSD.Text = oAbstract_TransitionAccountDetails.Col_CommissionCreditUSD.Value.ToString();
			}
			else {

				txt_CommissionCreditUSD.Text = String.Empty;
			}

			if (!oAbstract_TransitionAccountDetails.Col_CommissionDebitLC.IsNull) {

				txt_CommissionDebitLC.Text = oAbstract_TransitionAccountDetails.Col_CommissionDebitLC.Value.ToString();
			}
			else {

				txt_CommissionDebitLC.Text = String.Empty;
			}

			if (!oAbstract_TransitionAccountDetails.Col_CommissionDebitUSD.IsNull) {

				txt_CommissionDebitUSD.Text = oAbstract_TransitionAccountDetails.Col_CommissionDebitUSD.Value.ToString();
			}
			else {

				txt_CommissionDebitUSD.Text = String.Empty;
			}

		}

		private void EmptyControls() {

			txt_CreditDateTime.Text = String.Empty;
			txt_DebitDateTime.Text = String.Empty;
			com_TransactionId.SelectedIndex = 0;
			txt_CreditLC.Text = String.Empty;
			txt_CreditUSD.Text = String.Empty;
			txt_DebitLC.Text = String.Empty;
			txt_DebitUSD.Text = String.Empty;
			txt_CommissionCreditLC.Text = String.Empty;
			txt_CommissionCreditUSD.Text = String.Empty;
			txt_CommissionDebitLC.Text = String.Empty;
			txt_CommissionDebitUSD.Text = String.Empty;
		}

		private void cmdAdd_Click(object sender, System.EventArgs e) {

			if (ReturnURL.Visible) {

				Response.Redirect(String.Format("WebForm_TransitionAccountDetails.aspx?Action=Add&ReturnToUrl={0}&ReturnToDisplay={1}", ReturnURL.NavigateUrl, ReturnURL.Text));
			}
			else {

				Response.Redirect("WebForm_TransitionAccountDetails.aspx?Action=Add");
			}
		}

		private void cmdUpdate_Click(object sender, System.EventArgs e) {

			if (!CheckValues()) {
			
				return;
			}

			if (Action == ActionEnum.Edit) {

				Params.spU_TransitionAccountDetails Param = null;
				SPs.spU_TransitionAccountDetails SP = null;

				Param = new Params.spU_TransitionAccountDetails();

				Param.SetUpConnection(ConnectionString);

				Param.Param_Id = CurrentID;

				if (txt_CreditDateTime.Text.Trim() != String.Empty) {

					Param.Param_CreditDateTime = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_CreditDateTime.Text));
				}

				if (txt_DebitDateTime.Text.Trim() != String.Empty) {

					Param.Param_DebitDateTime = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_DebitDateTime.Text));
				}

				Param.Param_TransactionId = new Guid(com_TransactionId.SelectedItem.Value);

				if (txt_CreditLC.Text.Trim() != String.Empty) {

					Param.Param_CreditLC = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CreditLC.Text));
				}

				if (txt_CreditUSD.Text.Trim() != String.Empty) {

					Param.Param_CreditUSD = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CreditUSD.Text));
				}

				if (txt_DebitLC.Text.Trim() != String.Empty) {

					Param.Param_DebitLC = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_DebitLC.Text));
				}

				if (txt_DebitUSD.Text.Trim() != String.Empty) {

					Param.Param_DebitUSD = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_DebitUSD.Text));
				}

				if (txt_CommissionCreditLC.Text.Trim() != String.Empty) {

					Param.Param_CommissionCreditLC = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CommissionCreditLC.Text));
				}

				if (txt_CommissionCreditUSD.Text.Trim() != String.Empty) {

					Param.Param_CommissionCreditUSD = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CommissionCreditUSD.Text));
				}

				if (txt_CommissionDebitLC.Text.Trim() != String.Empty) {

					Param.Param_CommissionDebitLC = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CommissionDebitLC.Text));
				}

				if (txt_CommissionDebitUSD.Text.Trim() != String.Empty) {

					Param.Param_CommissionDebitUSD = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CommissionDebitUSD.Text));
				}

				SP = new SPs.spU_TransitionAccountDetails();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_TransitionAccountDetails.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", CurrentID.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_TransitionAccountDetails.aspx?Action=Edit&ID={0}", CurrentID.ToString()));
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

				Params.spI_TransitionAccountDetails Param = null;
				SPs.spI_TransitionAccountDetails SP = null;

				Param = new Params.spI_TransitionAccountDetails();

				Param.SetUpConnection(ConnectionString);

				if (txt_CreditDateTime.Text.Trim() != String.Empty) {

					Param.Param_CreditDateTime = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_CreditDateTime.Text));
				}

				if (txt_DebitDateTime.Text.Trim() != String.Empty) {

					Param.Param_DebitDateTime = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_DebitDateTime.Text));
				}

				Param.Param_TransactionId = new Guid(com_TransactionId.SelectedItem.Value);

				if (txt_CreditLC.Text.Trim() != String.Empty) {

					Param.Param_CreditLC = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CreditLC.Text));
				}

				if (txt_CreditUSD.Text.Trim() != String.Empty) {

					Param.Param_CreditUSD = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CreditUSD.Text));
				}

				if (txt_DebitLC.Text.Trim() != String.Empty) {

					Param.Param_DebitLC = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_DebitLC.Text));
				}

				if (txt_DebitUSD.Text.Trim() != String.Empty) {

					Param.Param_DebitUSD = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_DebitUSD.Text));
				}

				if (txt_CommissionCreditLC.Text.Trim() != String.Empty) {

					Param.Param_CommissionCreditLC = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CommissionCreditLC.Text));
				}

				if (txt_CommissionCreditUSD.Text.Trim() != String.Empty) {

					Param.Param_CommissionCreditUSD = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CommissionCreditUSD.Text));
				}

				if (txt_CommissionDebitLC.Text.Trim() != String.Empty) {

					Param.Param_CommissionDebitLC = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CommissionDebitLC.Text));
				}

				if (txt_CommissionDebitUSD.Text.Trim() != String.Empty) {

					Param.Param_CommissionDebitUSD = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CommissionDebitUSD.Text));
				}

				SP = new SPs.spI_TransitionAccountDetails();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_TransitionAccountDetails.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", Param.Param_Id.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_TransitionAccountDetails.aspx?Action=Edit&ID={0}", Param.Param_Id.ToString()));
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

			Params.spD_TransitionAccountDetails Param = null;
			SPs.spD_TransitionAccountDetails SP = null;

			Param = new Params.spD_TransitionAccountDetails();

			Param.SetUpConnection(ConnectionString);

			Param.Param_Id = CurrentID;

			SP = new SPs.spD_TransitionAccountDetails();

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

				System.Data.SqlTypes.SqlDateTime value = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_CreditDateTime.Text));
			}

			catch {

				labError_CreditDateTime.Text = "INVALID";
				labError_CreditDateTime.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDateTime value = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_DebitDateTime.Text));
			}

			catch {

				labError_DebitDateTime.Text = "INVALID";
				labError_DebitDateTime.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CreditLC.Text));
			}

			catch {

				labError_CreditLC.Text = "INVALID";
				labError_CreditLC.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CreditUSD.Text));
			}

			catch {

				labError_CreditUSD.Text = "INVALID";
				labError_CreditUSD.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_DebitLC.Text));
			}

			catch {

				labError_DebitLC.Text = "INVALID";
				labError_DebitLC.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_DebitUSD.Text));
			}

			catch {

				labError_DebitUSD.Text = "INVALID";
				labError_DebitUSD.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CommissionCreditLC.Text));
			}

			catch {

				labError_CommissionCreditLC.Text = "INVALID";
				labError_CommissionCreditLC.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CommissionCreditUSD.Text));
			}

			catch {

				labError_CommissionCreditUSD.Text = "INVALID";
				labError_CommissionCreditUSD.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CommissionDebitLC.Text));
			}

			catch {

				labError_CommissionDebitLC.Text = "INVALID";
				labError_CommissionDebitLC.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_CommissionDebitUSD.Text));
			}

			catch {

				labError_CommissionDebitUSD.Text = "INVALID";
				labError_CommissionDebitUSD.Visible = true;
				status = false;
			}

			return(status);
		}
	}
}
