namespace Evernet.MoneyExchange.UserControls {
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using Evernet.MoneyExchange.BusinessLogic;

	public class Menu1 : System.Web.UI.UserControl {
		protected System.Web.UI.WebControls.HyperLink hlnkHome;
		protected System.Web.UI.WebControls.HyperLink hlnkReports;
		protected System.Web.UI.WebControls.HyperLink hlnkTracking;
		protected System.Web.UI.WebControls.HyperLink hlnkLogOff;
		protected System.Web.UI.WebControls.HyperLink hlnkContactUs;
		protected System.Web.UI.WebControls.HyperLink hlnkGlobalSettings;

		private void Page_Load(object sender, System.EventArgs e) {
			// Put user code to initialize the page here
			if(!IsPostBack) {
				ManageControlVisibility();
			}
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e) {
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ManageControlVisibility() {
			if(Context.User.Identity.IsAuthenticated) {
				if(!Context.User.IsInRole(UserRoles.Administrator.ToString())) {
					if(Context.User.IsInRole(UserRoles.ReportsManagerAgentReportsViewer.ToString())
						||
						Context.User.IsInRole(UserRoles.ReportsManagerAgencyReportsViewer.ToString())) {
						hlnkReports.Visible = true;
					}
				} else {
					hlnkGlobalSettings.Visible=true;
					//hlnkTracking.Visible = true;
					//hlnkManagement.Visible=true;
					hlnkReports.Visible = true;
					hlnkContactUs.Visible=false;
				}
			}
		}
	}
}