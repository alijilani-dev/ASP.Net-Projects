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
	/// Summary description for WebForm_AgentAccountDetails.
	/// </summary>
	public class WebForm_AgentAccountDetails : System.Web.UI.Page {

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
		protected System.Web.UI.WebControls.Label lab_AgentAccountId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentMaster com_AgentAccountId;
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
		public WebForm_AgentAccountDetails() {

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
			labError_CreditDateTime.Visible = false;
			labError_DebitDateTime.Visible = false;
			labError_CreditLC.Visible = false;
			labError_CreditUSD.Visible = false;
			labError_DebitLC.Visible = false;
			labError_DebitUSD.Visible = false;

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

			com_AgentAccountId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
			try {

				com_AgentAccountId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
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

			Evernet.MoneyExchange.AbstractClasses.Abstract_AgentAccountDetails oAbstract_AgentAccountDetails = new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentAccountDetails(ConnectionString);

			if (!oAbstract_AgentAccountDetails.Refresh(CurrentID)) {

				MainDisplay.Visible = false;
				ErrorDisplay.Visible = true;
				lab_Error.Text = String.Format("No record with ID: {0}", CurrentID.ToString());
				return;
			}

			if (!oAbstract_AgentAccountDetails.Col_Id.IsNull) {

				txt_Id.Text = oAbstract_AgentAccountDetails.Col_Id.Value.ToString();
			}
			else {

				txt_Id.Text = String.Empty;
			}
				txt_Id.ReadOnly = true;

			if (!oAbstract_AgentAccountDetails.Col_CreditDateTime.IsNull) {

				txt_CreditDateTime.Text = oAbstract_AgentAccountDetails.Col_CreditDateTime.Value.ToString();
			}
			else {

				txt_CreditDateTime.Text = String.Empty;
			}

			if (!oAbstract_AgentAccountDetails.Col_DebitDateTime.IsNull) {

				txt_DebitDateTime.Text = oAbstract_AgentAccountDetails.Col_DebitDateTime.Value.ToString();
			}
			else {

				txt_DebitDateTime.Text = String.Empty;
			}

			com_AgentAccountId.Items.FindByValue(Convert.ToString(oAbstract_AgentAccountDetails.Col_AgentAccountId)).Selected = true;

			com_TransactionId.Items.FindByValue(Convert.ToString(oAbstract_AgentAccountDetails.Col_TransactionId)).Selected = true;

			if (!oAbstract_AgentAccountDetails.Col_CreditLC.IsNull) {

				txt_CreditLC.Text = oAbstract_AgentAccountDetails.Col_CreditLC.Value.ToString();
			}
			else {

				txt_CreditLC.Text = String.Empty;
			}

			if (!oAbstract_AgentAccountDetails.Col_CreditUSD.IsNull) {

				txt_CreditUSD.Text = oAbstract_AgentAccountDetails.Col_CreditUSD.Value.ToString();
			}
			else {

				txt_CreditUSD.Text = String.Empty;
			}

			if (!oAbstract_AgentAccountDetails.Col_DebitLC.IsNull) {

				txt_DebitLC.Text = oAbstract_AgentAccountDetails.Col_DebitLC.Value.ToString();
			}
			else {

				txt_DebitLC.Text = String.Empty;
			}

			if (!oAbstract_AgentAccountDetails.Col_DebitUSD.IsNull) {

				txt_DebitUSD.Text = oAbstract_AgentAccountDetails.Col_DebitUSD.Value.ToString();
			}
			else {

				txt_DebitUSD.Text = String.Empty;
			}

		}

		private void EmptyControls() {

			txt_Id.Text = String.Empty;
			txt_CreditDateTime.Text = String.Empty;
			txt_DebitDateTime.Text = String.Empty;
			com_AgentAccountId.SelectedIndex = 0;
			com_TransactionId.SelectedIndex = 0;
			txt_CreditLC.Text = String.Empty;
			txt_CreditUSD.Text = String.Empty;
			txt_DebitLC.Text = String.Empty;
			txt_DebitUSD.Text = String.Empty;
		}

		private void cmdAdd_Click(object sender, System.EventArgs e) {

			if (ReturnURL.Visible) {

				Response.Redirect(String.Format("WebForm_AgentAccountDetails.aspx?Action=Add&ReturnToUrl={0}&ReturnToDisplay={1}", ReturnURL.NavigateUrl, ReturnURL.Text));
			}
			else {

				Response.Redirect("WebForm_AgentAccountDetails.aspx?Action=Add");
			}
		}

		private void cmdUpdate_Click(object sender, System.EventArgs e) {

			if (!CheckValues()) {
			
				return;
			}

			if (Action == ActionEnum.Edit) {

				Params.spU_AgentAccountDetails Param = null;
				SPs.spU_AgentAccountDetails SP = null;

				Param = new Params.spU_AgentAccountDetails();

				Param.SetUpConnection(ConnectionString);

				Param.Param_Id = CurrentID;

				if (txt_Id.Text.Trim() != String.Empty) {

					Param.Param_Id = new System.Data.SqlTypes.SqlGuid(new System.Guid(txt_Id.Text));
				}

				if (txt_CreditDateTime.Text.Trim() != String.Empty) {

					Param.Param_CreditDateTime = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_CreditDateTime.Text));
				}

				if (txt_DebitDateTime.Text.Trim() != String.Empty) {

					Param.Param_DebitDateTime = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_DebitDateTime.Text));
				}

				Param.Param_AgentAccountId = new Guid(com_AgentAccountId.SelectedItem.Value);

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

				SP = new SPs.spU_AgentAccountDetails();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_AgentAccountDetails.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", CurrentID.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_AgentAccountDetails.aspx?Action=Edit&ID={0}", CurrentID.ToString()));
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

				Params.spI_AgentAccountDetails Param = null;
				SPs.spI_AgentAccountDetails SP = null;

				Param = new Params.spI_AgentAccountDetails();

				Param.SetUpConnection(ConnectionString);

				if (txt_Id.Text.Trim() != String.Empty) {

					Param.Param_Id = new System.Data.SqlTypes.SqlGuid(new System.Guid(txt_Id.Text));
				}

				if (txt_CreditDateTime.Text.Trim() != String.Empty) {

					Param.Param_CreditDateTime = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_CreditDateTime.Text));
				}

				if (txt_DebitDateTime.Text.Trim() != String.Empty) {

					Param.Param_DebitDateTime = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_DebitDateTime.Text));
				}

				Param.Param_AgentAccountId = new Guid(com_AgentAccountId.SelectedItem.Value);

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

				SP = new SPs.spI_AgentAccountDetails();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_AgentAccountDetails.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", Param.Param_Id.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_AgentAccountDetails.aspx?Action=Edit&ID={0}", Param.Param_Id.ToString()));
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

			Params.spD_AgentAccountDetails Param = null;
			SPs.spD_AgentAccountDetails SP = null;

			Param = new Params.spD_AgentAccountDetails();

			Param.SetUpConnection(ConnectionString);

			Param.Param_Id = CurrentID;

			SP = new SPs.spD_AgentAccountDetails();

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

			return(status);
		}
	}
}
