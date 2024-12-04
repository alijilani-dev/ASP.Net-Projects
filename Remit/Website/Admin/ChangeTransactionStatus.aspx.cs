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
using Microsoft.ApplicationBlocks.Data;
using Evernet.MoneyExchange.BusinessLogic;
using Evernet.Shared;

namespace Evernet.MoneyExchange.Admin {
	/// <summary>
	/// Summary description for ChangeTransactionStatus.
	/// </summary>
	public class ChangeTransactionStatus : System.Web.UI.Page {
		protected System.Web.UI.WebControls.Label lblToStatus;
		protected System.Web.UI.WebControls.Button butYes;
		protected System.Web.UI.WebControls.HyperLink hlnkBack;
		protected System.Web.UI.WebControls.Label lblFromStatus;
	
		private void Page_Load(object sender, System.EventArgs e) {
			// Put user code to initialize the page here

			if(Request["Id"]==null){
				Response.Redirect("Home.aspx");
			}

			if(!IsPostBack) {
				Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails aoTrans
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails(ConfigHelper.ConStr);
				aoTrans.Refresh(new Guid(Request["Id"]));

				Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionStatusList aoFromStatus
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionStatusList(ConfigHelper.ConStr);
				Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionStatusList aoToStatus
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionStatusList(ConfigHelper.ConStr);

				aoFromStatus.Refresh(aoTrans.Col_Status);
				if(Request["Status"]!=null)
					aoToStatus.Refresh(Request["Status"].ToString());

				lblFromStatus.Text = aoFromStatus.Col_Name.Value;
				lblToStatus.Text = aoToStatus.Col_Name.Value;
				if(Request["ru"]!=null)
					hlnkBack.NavigateUrl = Request["ru"].ToString();
				else
					hlnkBack.NavigateUrl = "ViewTransactionStatus.aspx";
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
			this.butYes.Click += new System.EventHandler(this.butYes_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private void butYes_Click(object sender, System.EventArgs e) {
			string strStatus = Request["Status"].ToString();
			string query = string.Empty;

			if(strStatus=="UnPaid" && IsAgencyEmployee())
				query = "Update TransactionDetails Set Status='"+ strStatus +"' Where Id='"+ Request["Id"] +"'";
			else if(strStatus=="UnPaid" && !User.IsInRole(UserRoles.AgentLocationPayInTransactonApprover.ToString()) && !User.IsInRole(UserRoles.TransactionStatusViewer.ToString()))
				query = "Update TransactionDetails Set Status='PendingApproval' Where Id='"+ Request["Id"] +"'";
			else
				query = "Update TransactionDetails Set Status='"+ strStatus +"' Where Id='"+ Request["Id"] +"'";

			SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			String strReturnUrl = string.Empty;

			if(Request["ru"]!=null)
				strReturnUrl = Request["ru"].ToString();
			else
				strReturnUrl = "ViewTransactionStatus.aspx";

			Response.Redirect(strReturnUrl);
		}

		private bool IsAgencyEmployee()
		{
			try 
			{
				Evernet.MoneyExchange.AbstractClasses.Abstract_UserList aoUser 
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(ConfigHelper.ConStr);
				aoUser.Refresh(new Guid(User.Identity.Name));
				if(aoUser.Col_IsAgencyEmployee.Value) 
					return true;
				else
					return false;
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) 
			{
				if (customException.Parameter.SqlException != null) 
				{
					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_AgentMaster' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					return false;
				}
				else if (customException.Parameter.OtherException != null) 
				{
					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_AgentMaster' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					return false;
				}
				else 
				{
					throw;
					return false;
				}
			}
		}
	}
}