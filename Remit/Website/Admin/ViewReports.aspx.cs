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
using Evernet.MoneyExchange.BusinessLogic;
using Microsoft.ApplicationBlocks.Data;
using Evernet.Shared;

namespace Evernet.MoneyExchange.Admin {
	/// <summary>
	/// Summary description for ViewReports.
	/// </summary>
	public class ViewReports : System.Web.UI.Page {
		protected System.Web.UI.WebControls.HyperLink hlnkSRIncomeAccount;
		protected System.Web.UI.WebControls.HyperLink hlnkUnpaidCommissionReport;
		protected System.Web.UI.WebControls.HyperLink hlnkExposure;
		protected System.Web.UI.WebControls.HyperLink hlnkExchangeEarning;
		protected System.Web.UI.WebControls.HyperLink hlnkPrincipleCommissionUnpaid;
	
		private void Page_Load(object sender, System.EventArgs e) {
			// Put user code to initialize the page here
			if(User.IsInRole(UserRoles.Administrator.ToString()) ||
				User.IsInRole(UserRoles.ReportsManagerAgencyReportsViewer.ToString())
				) {
				hlnkPrincipleCommissionUnpaid.Visible=true;
				hlnkSRIncomeAccount.Visible=true;
				hlnkUnpaidCommissionReport.Visible=true;
				hlnkExposure.Visible=true;
				hlnkExchangeEarning.Visible=true;
			}

			if(User.IsInRole(UserRoles.ReportsManagerAgentReportsViewer.ToString())) {
				Evernet.MoneyExchange.AbstractClasses.Abstract_CountryList aoCountry
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_CountryList(ConfigHelper.ConStr);

				Guid countryId = UserManager.GetCountryForUser(new Guid(User.Identity.Name));

				if(aoCountry.Refresh(countryId)) {

					if(aoCountry.Col_AllowedInternationalTransactionType.Value=="SendReceive" 
						||
						aoCountry.Col_AllowedInternationalTransactionType.Value=="Send") {
						Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList aoAgent
							= new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList(ConfigHelper.ConStr);

						Guid agentId = UserManager.GetAgentForUser(new Guid(User.Identity.Name));

						if(aoAgent.Refresh(agentId)) {
							if(aoAgent.Col_AllowedInternationalTransactionType.Value=="SendReceive"
								||
								aoAgent.Col_AllowedInternationalTransactionType.Value=="Send") {
							
								hlnkExchangeEarning.Visible=true;
							}
						}
					}
				}
			}
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e) {
			InitializeComponent();
			base.OnInit(e);
		}
		
		private void InitializeComponent() {    
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
