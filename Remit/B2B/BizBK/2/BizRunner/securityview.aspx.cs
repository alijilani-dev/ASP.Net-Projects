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
	/// Summary description for resourceview.
	/// </summary>
	public class securityview : System.Web.UI.MobileControls.MobilePage
	{
		#region Declarations.
		protected System.Web.UI.MobileControls.Command cmdBack;
		protected System.Web.UI.MobileControls.Command cmdCancel;
		protected System.Web.UI.MobileControls.Command cmdAdd;
		protected System.Web.UI.MobileControls.Command cmdUpdate;
		protected System.Web.UI.MobileControls.Command cmdDelete;
		protected System.Web.UI.MobileControls.Command Command4;
		protected System.Web.UI.MobileControls.Command Command5;
		protected System.Web.UI.MobileControls.Command cmdNext;
		protected System.Web.UI.MobileControls.Command cmdSales;
		protected System.Web.UI.MobileControls.Command cmdPrev;
		protected System.Web.UI.MobileControls.Command cmdBacktoRec;
		protected System.Web.UI.MobileControls.Label lblMsg;
		protected System.Web.UI.MobileControls.Label lblHeading;
		protected System.Web.UI.MobileControls.Form frmMessage;
		protected System.Web.UI.MobileControls.Command cmdAddNew;
		protected System.Web.UI.MobileControls.Label lblTotalCost;
		protected System.Web.UI.MobileControls.Label lblTotalUsers;
		protected System.Web.UI.MobileControls.Form frmSecurityView;
		protected System.Web.UI.MobileControls.Label lblPassword;
		protected System.Web.UI.MobileControls.TextBox txtPassword;
		protected System.Web.UI.MobileControls.Command cmdRoles;
		protected System.Web.UI.MobileControls.TextBox txtFirstName;
		protected System.Web.UI.MobileControls.Label lblFirstName;
		protected System.Web.UI.MobileControls.Label lblLastName;
		protected System.Web.UI.MobileControls.Label lblEmail;
		protected System.Web.UI.MobileControls.TextBox txtEmail;
		protected System.Web.UI.MobileControls.TextBox txtLastName;
		protected System.Web.UI.MobileControls.Label lblMobile;
		protected System.Web.UI.MobileControls.TextBox txtMobile;
		protected System.Web.UI.MobileControls.Form frmUserDetails;
		protected System.Web.UI.MobileControls.Label lblLoginName;
		protected System.Web.UI.MobileControls.TextBox txtLoginName;
		protected System.Web.UI.MobileControls.List lstSecurity;
		string strBizRunConn = (string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("BizRun.ConnectionString").GetValue(0);
		DataSet ds = null;
		int n_CurrentRec = 0;
		#endregion Declarations.
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				Session["CurrentResIndex"] = 0;
				Session["CurrentRes"] = 0;
				ds = GetUserData();
				lstSecurity.DataSource = ds;
				lstSecurity.DataBind();
				lblTotalUsers.Text = GetUserCount().ToString();
			}
			else
			{
				ds = GetUserData();
				lblTotalUsers.Text = GetUserCount().ToString();
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
			this.lstSecurity.ItemCommand += new System.Web.UI.MobileControls.ListCommandEventHandler(this.lstResources_ItemCommand);
			this.cmdAddNew.Click += new System.EventHandler(this.cmdAddNew_Click);
			this.cmdPrev.Click += new System.EventHandler(this.cmdPrev_Click);
			this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
			this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
			this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
			this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
			this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
			this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
			this.cmdBacktoRec.Click += new System.EventHandler(this.cmdBacktoRec_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private int GetUserCount()
		{
			//int nTotalCost = ds.Tables[0].Rows.Count;
			return ds.Tables[0].Rows.Count;
		}

		private DataSet GetUserData()
		{
			string strQuery = "select Id, LoginName, Password, FirstName, LastName, Email, Mobile, IsEmployee, Active from UserList order by Id";
			ds = SqlHelper.ExecuteDataset(strBizRunConn,
				CommandType.Text,
				strQuery);
			return ds;
		}

		private void lstResources_ItemCommand(object sender, System.Web.UI.MobileControls.ListCommandEventArgs e)
		{
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
			}
		}

		private bool FillResourcesInfo(int nRec)
		{			
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
			ActiveForm = frmUserDetails;
			return true;
		}

		#region Manipulation Commands.
		private void cmdAdd_Click(object sender, System.EventArgs e)
		{
			int nResult = SqlHelper.ExecuteNonQuery(strBizRunConn,
				CommandType.Text,
				@"INSERT INTO UserList(LoginName, Password, FirstName, LastName, Email, Mobile, IsEmployee, Active) Values ('" +
				txtLoginName.Text + "','" + txtPassword.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtEmail.Text + "','" + txtMobile.Text + "',1,1)");
			if (nResult > 0)
			{
				lblMsg.Text = "Record successfully added.";
				ActiveForm = frmMessage;
			}
			else
			{
				lblMsg.Text = "An error occurred while executing the command.";
				ActiveForm = frmMessage;
			}		
		}

		private void cmdUpdate_Click(object sender, System.EventArgs e)
		{
			int nCurrentRec = int.Parse(Session["CurrentResIndex"].ToString());
			int nResult = SqlHelper.ExecuteNonQuery(strBizRunConn,
				CommandType.Text,
				@"Update UserList Set " + 
				"LoginName		= '" + txtLoginName.Text			+ "' ," +
				"Password		= '" + txtPassword.Text			+ "' ," +
				"FirstName		= '" + txtFirstName.Text		+ "' ," +
				"LastName		= '" + txtLastName.Text			+ "' ," +
				"Email			= '" + txtEmail.Text			+ "' ," +
				"Mobile			= '" + txtMobile.Text			+ "' ," +
				"IsEmployee		= 1 ," +
				"Active		= 1 where Id = " + ds.Tables[0].Rows[nCurrentRec]["Id"].ToString() );


			if (nResult > 0)
			{
				lblMsg.Text = "Record successfully added.";
				ActiveForm = frmMessage;
			}
			else
			{
				lblMsg.Text = "An error occurred while executing the command.";
				ActiveForm = frmMessage;
			}
		}

		private void cmdDelete_Click(object sender, System.EventArgs e)
		{
			int nCurrentRec = int.Parse(Session["CurrentResIndex"].ToString());
			int nResult = SqlHelper.ExecuteNonQuery(strBizRunConn,
				CommandType.Text,
				@"Delete from UserList where Id = " + ds.Tables[0].Rows[nCurrentRec]["Id"].ToString() );

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
		#region Navigation Commands.
		private void cmdPrev_Click(object sender, System.EventArgs e)
		{
			int nIndex = int.Parse(Session["CurrentResIndex"].ToString());
			int n_CurrentRec = 0;
			if (nIndex>0)
			{
				nIndex--;
				n_CurrentRec = int.Parse(ds.Tables[0].Rows[nIndex]["Id"].ToString());
				FillResourcesInfo(n_CurrentRec);
				Session["CurrentResIndex"] = nIndex.ToString();
			}
			else
			{
				lblMsg.Text = "No valid record exists for selected resource.";
				ActiveForm = frmMessage;
			}		
		}

		private void cmdNext_Click(object sender, System.EventArgs e)
		{
			int nIndex = int.Parse(Session["CurrentResIndex"].ToString());
			int n_CurrentRec = 0;
			if (nIndex<ds.Tables[0].Rows.Count-1)
			{
				nIndex++;
				n_CurrentRec = int.Parse(ds.Tables[0].Rows[nIndex]["Id"].ToString());
				FillResourcesInfo(n_CurrentRec);
				Session["CurrentResIndex"] = nIndex.ToString();
			}
			else
			{
				lblMsg.Text = "No valid record exists for selected resource.";
				ActiveForm = frmMessage;
			}		
		}

		private void cmdAddNew_Click(object sender, System.EventArgs e)
		{
			ActiveForm = frmUserDetails;
		}

		private void cmdBacktoRec_Click(object sender, System.EventArgs e)
		{
			ActiveForm = frmUserDetails;
		}

		private void cmdBack_Click(object sender, System.EventArgs e)
		{
			this.RedirectToMobilePage("securityview.aspx");
		}

		private void cmdCancel_Click(object sender, System.EventArgs e)
		{
			this.RedirectToMobilePage("securityview.aspx");
			ActiveForm = frmSecurityView;
		}
		#endregion Navigation Commands.
	}
}