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
using Evernet.Shared;
using Microsoft.ApplicationBlocks.Data;

namespace Evernet.MoneyExchange.Admin {

	public class DailyRates : System.Web.UI.Page {
		protected System.Web.UI.WebControls.DataGrid dgrdRateList;
	
		private void Page_Load(object sender, System.EventArgs e) 
		
					{
			//			hlink_News.Attributes.Add("onclick","window.open('SpeedEast.htm', null, 'location=no,width=800,height=600,status=no,resizable=no,scrollbars=yes,toolbar=no,menubar=no');");
			// Put user code to initialize the page here
			if(!IsPostBack) 
							{
								Guid userId = new Guid(Context.User.Identity.Name);
								//				string roles = UserManager.GetUserRoles(userId);
								//				string[] roleList = roles.Split(new char[]{'|'});
				//				dgrdRoleList.DataSource = roleList;
				//				dgrdRoleList.DataBind();

				string query = "Select PayOutCountryName, cast(round(FinalRate, 6, 6) as decimal(12,6)) as FinalRate From DailyExchangeRateList derl Join AgentMaster am On am.CountryId = derl.PayInCountryId Join UserList ul On ul.AgentAccountId = am.Id Where ul.Id ='"+  User.Identity.Name +"' Order by PayOutCountryName";

				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					query);

				dgrdRateList.DataSource= ds;
				dgrdRateList.DataBind();

/*
				Evernet.MoneyExchange.AbstractClasses.Abstract_UserList aoUser
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(ConfigHelper.ConStr);

				aoUser.Refresh(userId);
*/
				//lblCurrentUser.Text = aoUser.Col_LoginName.Value;
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {    
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}