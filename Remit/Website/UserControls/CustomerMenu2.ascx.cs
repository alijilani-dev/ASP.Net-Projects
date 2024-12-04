namespace Evernet.MoneyExchange.UserControls {
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using Evernet.MoneyExchange.BusinessLogic;

	public class CustomerMenu2 : System.Web.UI.UserControl {
		protected System.Web.UI.WebControls.HyperLink hlnkTransactionManager;
		protected System.Web.UI.WebControls.HyperLink hlnkViewExchangeRate;
		protected System.Web.UI.WebControls.HyperLink hlnkChangePassword;

		private void Page_Load(object sender, System.EventArgs e) {
			// Put user code to initialize the page here
//			if(!IsPostBack) {
//				ManageControlVisibility();
//			}
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

//		private void ManageControlVisibility() {
//			if(Context.User.Identity.IsAuthenticated) {
//				if(!Context.User.IsInRole(UserRoles.Administrator.ToString())) {
//					if(Context.User.IsInRole(UserRoles.CurrencyManager.ToString())) {
//						hlnkCurrencyManager.Visible=true;
//					}
//					if(Context.User.IsInRole(UserRoles.CountryManager.ToString())) {
//						hlnkCountryManager.Visible=true;
//					}
//					if(Context.User.IsInRole(UserRoles.AgencyExchangeRateManager.ToString())
//						||
//						Context.User.IsInRole(UserRoles.AgentExchangeRateManager.ToString())
//						) {
//						hlnkAgencyExchangeRateManager.Visible=true;
//					}
//					if(Context.User.IsInRole(UserRoles.CommissionSlabManager.ToString())) {
//						hlnkCommissionSlabManager.Visible=true;
//					}
//					if(Context.User.IsInRole(UserRoles.LocationManager.ToString())) {
//						hlnkLocationManager.Visible=true;
//					}
//					if(Context.User.IsInRole(UserRoles.AgentManager.ToString())) {
//						hlnkAgentManager.Visible=true;
//					}
//					if(Context.User.IsInRole(UserRoles.BankManager.ToString())) {
//						hlnkBankManager.Visible=true;
//					}
//					
//				} else {
//					hlnkCurrencyManager.Visible=true;
//					hlnkCountryManager.Visible=true;
//					hlnkAgencyExchangeRateManager.Visible=true;
//					hlnkCommissionSlabManager.Visible=true;
//					hlnkLocationManager.Visible=true;
//					hlnkAgentManager.Visible=true;
//					hlnkBankManager.Visible=true;
//					hlnkUserManager.Visible=true;
//					hlnkCustomerManager.Visible=true;
//				}
//			}
//		}
	}
}
