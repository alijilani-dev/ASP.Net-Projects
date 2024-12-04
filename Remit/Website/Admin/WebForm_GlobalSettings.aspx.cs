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
	/// Summary description for WebForm_GlobalSettings.
	/// </summary>
	public class WebForm_GlobalSettings : System.Web.UI.Page {

		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Name;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Name;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Name;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_AdministrativeEmail;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_AdministrativeEmail;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_AdministrativeEmail;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_TechnicalEmail;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_TechnicalEmail;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_TechnicalEmail;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_TransactionThreshold;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_TransactionThreshold;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_TransactionThreshold;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_TransactionNumberFormat;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_TransactionNumberFormat;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_TransactionNumberFormat;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_TransactionThresholdUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_TransactionThresholdUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_TransactionThresholdUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.CheckBox chk_Active;
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
		public WebForm_GlobalSettings() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString;
		private ActionEnum Action = ActionEnum.None;
		private System.Data.SqlTypes.SqlByte CurrentID = System.Data.SqlTypes.SqlByte.Null;

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

			labError_TransactionThreshold.Visible = false;
			labError_TransactionThresholdUSD.Visible = false;

			if (Request.Params["Action"] != null) {

				switch(Request.Params["Action"].ToString()) {

					case "Add":
						Action = ActionEnum.Add;
						CurrentID = System.Data.SqlTypes.SqlByte.Null;
						break;

					case "Edit":
						Action = ActionEnum.Edit;
						object ID = Request.Params["ID"];

						if (ID != null) {

							try {

								CurrentID = Convert.ToByte(Request.Params["ID"].ToString());
							}
							catch {

								MainDisplay.Visible = false;
								ErrorDisplay.Visible = true;
								lab_Error.Text = "ERROR: Action=Edit-> ID supplied is not a valid Int32";
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

								CurrentID = Convert.ToByte(Request.Params["ID"].ToString());
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
						CurrentID = System.Data.SqlTypes.SqlByte.Null;
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

			UpdateForm();
		}

		private void cmdRefresh_Click(object sender, System.EventArgs e) {

			RefreshAll();
		}

		private void RefreshRecord() {

			Evernet.MoneyExchange.AbstractClasses.Abstract_GlobalSettings oAbstract_GlobalSettings = new Evernet.MoneyExchange.AbstractClasses.Abstract_GlobalSettings(ConnectionString);

			if (!oAbstract_GlobalSettings.Refresh(CurrentID)) {

				MainDisplay.Visible = false;
				ErrorDisplay.Visible = true;
				lab_Error.Text = String.Format("No record with ID: {0}", CurrentID.ToString());
				return;
			}

			if (!oAbstract_GlobalSettings.Col_Name.IsNull) {

				txt_Name.Text = oAbstract_GlobalSettings.Col_Name.Value.ToString();
			}
			else {

				txt_Name.Text = String.Empty;
			}

			if (!oAbstract_GlobalSettings.Col_AdministrativeEmail.IsNull) {

				txt_AdministrativeEmail.Text = oAbstract_GlobalSettings.Col_AdministrativeEmail.Value.ToString();
			}
			else {

				txt_AdministrativeEmail.Text = String.Empty;
			}

			if (!oAbstract_GlobalSettings.Col_TechnicalEmail.IsNull) {

				txt_TechnicalEmail.Text = oAbstract_GlobalSettings.Col_TechnicalEmail.Value.ToString();
			}
			else {

				txt_TechnicalEmail.Text = String.Empty;
			}

			if (!oAbstract_GlobalSettings.Col_TransactionThreshold.IsNull) {

				txt_TransactionThreshold.Text = oAbstract_GlobalSettings.Col_TransactionThreshold.Value.ToString();
			}
			else {

				txt_TransactionThreshold.Text = String.Empty;
			}

			if (!oAbstract_GlobalSettings.Col_TransactionNumberFormat.IsNull) {

				txt_TransactionNumberFormat.Text = oAbstract_GlobalSettings.Col_TransactionNumberFormat.Value.ToString();
			}
			else {

				txt_TransactionNumberFormat.Text = String.Empty;
			}

			if (!oAbstract_GlobalSettings.Col_TransactionThresholdUSD.IsNull) {

				txt_TransactionThresholdUSD.Text = oAbstract_GlobalSettings.Col_TransactionThresholdUSD.Value.ToString();
			}
			else {

				txt_TransactionThresholdUSD.Text = String.Empty;
			}

			if (!oAbstract_GlobalSettings.Col_Active.IsNull) {

				chk_Active.Checked = oAbstract_GlobalSettings.Col_Active.Value;
			}
			else {

				chk_Active.Checked = false;
			}

		}

		private void EmptyControls() {

			txt_Name.Text = String.Empty;
			txt_AdministrativeEmail.Text = String.Empty;
			txt_TechnicalEmail.Text = String.Empty;
			txt_TransactionThreshold.Text = String.Empty;
			txt_TransactionNumberFormat.Text = String.Empty;
			txt_TransactionThresholdUSD.Text = String.Empty;
			chk_Active.Checked = false;
		}

		private void cmdAdd_Click(object sender, System.EventArgs e) {

			if (ReturnURL.Visible) {

				Response.Redirect(String.Format("WebForm_GlobalSettings.aspx?Action=Add&ReturnToUrl={0}&ReturnToDisplay={1}", ReturnURL.NavigateUrl, ReturnURL.Text));
			}
			else {

				Response.Redirect("WebForm_GlobalSettings.aspx?Action=Add");
			}
		}

		private void cmdUpdate_Click(object sender, System.EventArgs e) {

			if (!CheckValues()) {
			
				return;
			}

			if (Action == ActionEnum.Edit) {

				Params.spU_GlobalSettings Param = null;
				SPs.spU_GlobalSettings SP = null;

				Param = new Params.spU_GlobalSettings();

				Param.SetUpConnection(ConnectionString);

				Param.Param_Id = CurrentID;

				if (txt_Name.Text.Trim() != String.Empty) {

					Param.Param_Name = new System.Data.SqlTypes.SqlString(txt_Name.Text);
				}

				if (txt_AdministrativeEmail.Text.Trim() != String.Empty) {

					Param.Param_AdministrativeEmail = new System.Data.SqlTypes.SqlString(txt_AdministrativeEmail.Text);
				}

				if (txt_TechnicalEmail.Text.Trim() != String.Empty) {

					Param.Param_TechnicalEmail = new System.Data.SqlTypes.SqlString(txt_TechnicalEmail.Text);
				}

				if (txt_TransactionThreshold.Text.Trim() != String.Empty) {

					Param.Param_TransactionThreshold = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_TransactionThreshold.Text));
				}

				if (txt_TransactionNumberFormat.Text.Trim() != String.Empty) {

					Param.Param_TransactionNumberFormat = new System.Data.SqlTypes.SqlString(txt_TransactionNumberFormat.Text);
				}

				if (txt_TransactionThresholdUSD.Text.Trim() != String.Empty) {

					Param.Param_TransactionThresholdUSD = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_TransactionThresholdUSD.Text));
				}

				Param.Param_Active = new System.Data.SqlTypes.SqlBoolean(chk_Active.Checked);
				SP = new SPs.spU_GlobalSettings();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_GlobalSettings.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", CurrentID.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_GlobalSettings.aspx?Action=Edit&ID={0}", CurrentID.ToString()));
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

				Params.spI_GlobalSettings Param = null;
				SPs.spI_GlobalSettings SP = null;

				Param = new Params.spI_GlobalSettings();

				Param.SetUpConnection(ConnectionString);

				if (txt_Name.Text.Trim() != String.Empty) {

					Param.Param_Name = new System.Data.SqlTypes.SqlString(txt_Name.Text);
				}

				if (txt_AdministrativeEmail.Text.Trim() != String.Empty) {

					Param.Param_AdministrativeEmail = new System.Data.SqlTypes.SqlString(txt_AdministrativeEmail.Text);
				}

				if (txt_TechnicalEmail.Text.Trim() != String.Empty) {

					Param.Param_TechnicalEmail = new System.Data.SqlTypes.SqlString(txt_TechnicalEmail.Text);
				}

				if (txt_TransactionThreshold.Text.Trim() != String.Empty) {

					Param.Param_TransactionThreshold = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_TransactionThreshold.Text));
				}

				if (txt_TransactionNumberFormat.Text.Trim() != String.Empty) {

					Param.Param_TransactionNumberFormat = new System.Data.SqlTypes.SqlString(txt_TransactionNumberFormat.Text);
				}

				if (txt_TransactionThresholdUSD.Text.Trim() != String.Empty) {

					Param.Param_TransactionThresholdUSD = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_TransactionThresholdUSD.Text));
				}

				Param.Param_Active = new System.Data.SqlTypes.SqlBoolean(chk_Active.Checked);
				SP = new SPs.spI_GlobalSettings();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_GlobalSettings.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", Param.Param_Id.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_GlobalSettings.aspx?Action=Edit&ID={0}", Param.Param_Id.ToString()));
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

			Params.spD_GlobalSettings Param = null;
			SPs.spD_GlobalSettings SP = null;

			Param = new Params.spD_GlobalSettings();

			Param.SetUpConnection(ConnectionString);

			Param.Param_Id = CurrentID;

			SP = new SPs.spD_GlobalSettings();

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

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_TransactionThreshold.Text));
			}

			catch {

				labError_TransactionThreshold.Text = "INVALID";
				labError_TransactionThreshold.Visible = true;
				status = false;
			}

			try {

				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_TransactionThresholdUSD.Text));
			}

			catch {

				labError_TransactionThresholdUSD.Text = "INVALID";
				labError_TransactionThresholdUSD.Visible = true;
				status = false;
			}

			return(status);
		}
	}
}
