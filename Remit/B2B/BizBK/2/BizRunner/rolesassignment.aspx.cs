using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.Mobile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.MobileControls;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Microsoft.ApplicationBlocks.Data;

namespace BizRunner
{
	/// <summary>
	/// Summary description for RoleAssignment.
	/// </summary>
	public class RolesAssignment : System.Web.UI.MobileControls.MobilePage
	{
		protected System.Web.UI.MobileControls.Command cmdBacktoRec;
		protected System.Web.UI.MobileControls.Label lblMsg;
		protected System.Web.UI.MobileControls.Label lblHeading;
		protected System.Web.UI.MobileControls.Form frmMessage;
		protected System.Web.UI.MobileControls.Label lblAvailableRoles;
		protected System.Web.UI.MobileControls.Label lblAssignedRoles;
		protected System.Web.UI.MobileControls.Label lblUserName;
		protected System.Web.UI.MobileControls.List lstAvailableRoles;
		protected System.Web.UI.MobileControls.List lstAssignedRoles;
		string strBizRunConn = (string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("BizRun.ConnectionString").GetValue(0);
		DataSet ds = null;
		DataSet dsUserRoles = null;
		protected System.Web.UI.MobileControls.Form frmRoles;
		protected System.Web.UI.MobileControls.Command cmdOK;
		protected System.Web.UI.MobileControls.Command cmdCancel;
		protected System.Web.UI.MobileControls.SelectionList slUsers;
		//int n_CurrentRec = 0;

		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				Session["CurrentResIndex"] = 0;
				Session["CurrentRes"] = 0;
				GetUsers();
				Refresh();
			}
			else
			{
				ds = GetAssignedRoles();
				//lblTotalUsers.Text = GetRolesCount().ToString();
			}
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
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
		private void InitializeComponent()
		{    
			this.slUsers.SelectedIndexChanged += new System.EventHandler(this.slUsers_SelectedIndexChanged);
			this.lstAvailableRoles.ItemCommand += new System.Web.UI.MobileControls.ListCommandEventHandler(this.lstAvailableRoles_ItemCommand);
			this.lstAssignedRoles.ItemCommand += new System.Web.UI.MobileControls.ListCommandEventHandler(this.lstAssignedRoles_ItemCommand);
			this.cmdBacktoRec.Click += new System.EventHandler(this.cmdBacktoRec_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion	
		private void Refresh()
		{
			ds = GetAllRoles();
			dsUserRoles = GetAssignedRoles();
			lstAssignedRoles.DataSource = dsUserRoles;
			lstAssignedRoles.DataBind();
			lstAvailableRoles.DataSource = ds;
			lstAvailableRoles.DataBind();
		}
		private void GetUsers()
		{
			if(Session["UserID"]==null)
			{
				Session["UserID"] = 0;
			}
			string strQuery = "select Id, LoginName from UserList order by LoginName";
			ds = SqlHelper.ExecuteDataset(strBizRunConn,
				CommandType.Text,
				strQuery);
			slUsers.DataSource = ds;
			slUsers.DataBind();
			int nSelectedUser = Int32.Parse(Session["UserID"].ToString());	/*HARDCODED*/
			slUsers.SelectedIndex = nSelectedUser;
		}
		private int GetRolesCount()
		{
			//int nTotalCost = ds.Tables[0].Rows.Count;
			return ds.Tables[0].Rows.Count;
		}

		private DataSet GetAllRoles()
		{
			//string strQuery = "select ul.LoginName, url.Id, url.Name, url.Value from UserList ul join UserRoleAssignmentList ural on ural.UserId = ul.Id join UserRoleList url on ural.RoleId = url.Id where ul.Id = 2 order by url.Name";
			string strQuery = "select Id, Name from UserRoleList order by url.Name";
			ds = SqlHelper.ExecuteDataset(strBizRunConn,
				CommandType.Text,
				strQuery);
			return ds;
		}

		private DataSet GetAssignedRoles()
		{
			string strQuery = "select ural.Id, url.Name from UserRoleList url join UserRoleAssignmentList ural on url.Id = ural.RoleId where ural.UserId = " + slUsers.Selection.Value.ToString() + " order by url.Name";
			dsUserRoles = SqlHelper.ExecuteDataset(strBizRunConn,
				CommandType.Text,
				strQuery);
			return dsUserRoles;
		}

		private void lstResources_ItemCommand(object sender, System.Web.UI.MobileControls.ListCommandEventArgs e)
		{
			/*
			// Get the DataValueField for the Item.
			n_CurrentRec = int.Parse(e.ListItem.Value);
			//Session["CurrentRec"] = n_CurrentRec;
			Session["CurrentRes"] = e.ListItem.Index.ToString();
			Session["CurrentResIndex"] = e.ListItem.Index.ToString();

			// Fill Cutomer Information into the form and display;
			if (!FillResourcesInfo(n_CurrentRec))
			{
				lblMsg.Text = "No valid record exists for selected Service.";
				ActiveForm = frmMessage;
			}*/
		}

		private bool FillResourcesInfo(int nRec)
		{	
			/*
			// Use the DataValueField to pull data from DB.
			string strQuery = "select Id, LoginName, Password, FirstName, LastName, Email, Mobile, IsEmployee, Active from UserList where Id = " + nRec.ToString() + " order by Id";
			DataSet dsUserInfo = SqlHelper.ExecuteDataset(strBizRunConn,
				CommandType.Text,
				strQuery);
			DataRow drUserInfo = null;

			try
			{
				drUserInfo = dsUserInfo.Tables[0].Rows[0];//ds.Tables[0].Rows[nRec];
			}
			catch{}
			
			if (drUserInfo == null)
				return false;

			// Fill the form with respective values.
			txtLoginName.Text = drUserInfo["LoginName"].ToString();
			txtPassword.Text = drUserInfo["Password"].ToString();
			txtFirstName.Text = drUserInfo["FirstName"].ToString();
			txtLastName.Text = drUserInfo["LastName"].ToString();
			txtEmail.Text = drUserInfo["Email"].ToString();
			txtMobile.Text = drUserInfo["Mobile"].ToString();
			//txtName.Text = drResourceInfo["Name"].ToString();
			//txtUserName.Text = drResourceInfo["Name"].ToString();
			//txtCost.Text = drResourceInfo["Cost"].ToString();
			//txtDescription.Text = drResourceInfo["Description"].ToString();
			ActiveForm = frmUserDetails;*/
			return true;
		}

		#region Navigation Commands.
		private void cmdOK_Click(object sender, System.EventArgs e)
		{
			this.RedirectToMobilePage("securityview.aspx");
		}

		private void cmdCancel_Click(object sender, System.EventArgs e)
		{
			this.RedirectToMobilePage("securityview.aspx");
			//ActiveForm = frmSecurityView;
		}
		#endregion Navigation Commands.
		#region Manipulation Commands.
		private void lstAvailableRoles_ItemCommand(object sender, System.Web.UI.MobileControls.ListCommandEventArgs e)
		{
			 int nResult = SqlHelper.ExecuteNonQuery(strBizRunConn,
				 CommandType.Text,
				 @"INSERT INTO UserRoleAssignmentList(UserId, RoleId) Values 
				('" + slUsers.Selection.Value.ToString() + "','" + e.ListItem.Value + "')");
			if (nResult > 0)
			{
				lblMsg.Text = "Role successfully added.";
				ActiveForm = frmMessage;
			}
			else
			{
				lblMsg.Text = "An error occurred while executing the command.";
				ActiveForm = frmMessage;
			}
		}

		private void lstAssignedRoles_ItemCommand(object sender, System.Web.UI.MobileControls.ListCommandEventArgs e)
		{
			int nCurrentRec = int.Parse(Session["CurrentResIndex"].ToString());
			int nResult = SqlHelper.ExecuteNonQuery(strBizRunConn,
				CommandType.Text,
				@"Delete from UserRoleAssignmentList where Id = " + e.ListItem.Value.ToString() );

			if (nResult > 0)
			{
				lblMsg.Text = "Record successfully deleted.";
				ActiveForm = frmMessage;
			}
			else
			{
				lblMsg.Text = "An error occurred while executing the command.";
				ActiveForm = frmMessage;
			}
		}

		#endregion Manipulation Commands.
		private void cmdBacktoRec_Click(object sender, System.EventArgs e)
		{
			this.RedirectToMobilePage("rolesassignment.aspx");
		}

		private void slUsers_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			lstAssignedRoles.Items.Clear();
			lstAvailableRoles.Items.Clear();
			lstAssignedRoles.Visible = false;
			lstAvailableRoles.Visible = false;
			int nSelectedUser = Int32.Parse(Session["UserID"].ToString());
			nSelectedUser++;
			Session["UserID"] = nSelectedUser;	/*HARDCODED*/
            Refresh();
			//lstAssignedRoles.Visible = true;
			//lstAvailableRoles.Visible = true;
			//this.RedirectToMobilePage("rolesassignment.aspx");

		}
	}
}