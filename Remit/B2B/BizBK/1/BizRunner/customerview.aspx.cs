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
	/// Summary description for customerview.
	/// </summary>
	public class customerview : System.Web.UI.MobileControls.MobilePage
	{
		protected System.Web.UI.MobileControls.Label lblDate;
		protected System.Web.UI.MobileControls.Label lblStatus;
		protected System.Web.UI.MobileControls.Label lblType;
		protected System.Web.UI.MobileControls.Command cmdCancel;
		protected System.Web.UI.MobileControls.Label lblCompanyName;
		protected System.Web.UI.MobileControls.Label lblContactName;
		protected System.Web.UI.MobileControls.TextBox txtContactName;
		protected System.Web.UI.MobileControls.TextBox txtMobile;
		protected System.Web.UI.MobileControls.Label lblEmail;
		protected System.Web.UI.MobileControls.TextBox txtCompanyName;
		protected System.Web.UI.MobileControls.TextBox txtAddress;
		protected System.Web.UI.MobileControls.TextBox txtEmail;
		protected System.Web.UI.MobileControls.TextBox txtTelephone;
		protected System.Web.UI.MobileControls.Command cmdManageServices;
		protected System.Web.UI.MobileControls.Command cmdBack;
		protected System.Web.UI.MobileControls.Form frmCustomers;
		protected System.Web.UI.MobileControls.Form frmCustomerDetails;
		protected System.Web.UI.MobileControls.Command cmdPrevious;
		protected System.Web.UI.MobileControls.Command cmdNext;
		protected System.Web.UI.MobileControls.Form frmMessage;
		protected System.Web.UI.MobileControls.Label lblMsg;
		protected System.Web.UI.MobileControls.Label lblHeading;
		protected System.Web.UI.MobileControls.Command cmdAddCustomer;
		protected System.Web.UI.MobileControls.List CustomersList;
		protected System.Web.UI.MobileControls.Command cmdReturn;
		protected System.Web.UI.MobileControls.Command cmdAdd;
		protected System.Web.UI.MobileControls.Command cmdUpdate;
		protected System.Web.UI.MobileControls.Command cmdBacktoRec;
		protected System.Web.UI.MobileControls.Command cmdDelete;
		string strBizRunConn = (string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("BizRun.ConnectionString").GetValue(0);
		int n_CurrentRec = 0;
		//int ndsPos = 0;
		DataSet ds = null;

		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				ds = GetCustomerData();
				CustomersList.DataSource = ds;
				CustomersList.DataBind();
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
			this.CustomersList.ItemCommand += new System.Web.UI.MobileControls.ListCommandEventHandler(this.CustomersList_ItemCommand);
			this.cmdAddCustomer.Click += new System.EventHandler(this.cmdAddCustomer_Click);
			this.cmdReturn.Click += new System.EventHandler(this.cmdReturn_Click);
			this.cmdPrevious.Click += new System.EventHandler(this.cmdPrevious_Click);
			this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
			this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
			this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
			this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
			this.cmdBacktoRec.Click += new System.EventHandler(this.cmdBacktoRec_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private void CustomersList_ItemCommand(object sender, System.Web.UI.MobileControls.ListCommandEventArgs e)
		{
			// Get the DataValueField for the Item.
			n_CurrentRec = int.Parse(e.ListItem.Value);
			//Session["CurrentRec"] = n_CurrentRec;
			Session["CurrentRec"] = e.ListItem.Index;

			// Fill Cutomer Information into the form and display;
			if (!FillCustomerInfo(n_CurrentRec))
			{
				lblMsg.Text = "No valid record exists for selected customer.";
				ActiveForm = frmMessage;
			}
		}

		private DataSet GetCustomerData()
		{
			string strQuery = "Select Id, CompanyName, ContactName, Address, Mobile, Telephone, Email From CustomerList order by Id";
			ds = SqlHelper.ExecuteDataset(strBizRunConn,
				CommandType.Text,
				strQuery);
			return ds;
		}

		private bool FillCustomerInfo(int nRec)
		{			
			// Use the DataValueField to pull data from DB.
			string strQuery = "Select Id, CompanyName, ContactName, Address, Mobile, Telephone, Email From CustomerList where Id = " + nRec.ToString();
			DataSet dsCustomerInfo = SqlHelper.ExecuteDataset(strBizRunConn,
				CommandType.Text,
				strQuery);
			DataRow drCustomerInfo = null;

			try
			{
				drCustomerInfo = dsCustomerInfo.Tables[0].Rows[0];//ds.Tables[0].Rows[nRec];
			}
			catch{}
			
			if (drCustomerInfo == null)
				return false;

			// Fill the form with respective values.
			txtCompanyName.Text = drCustomerInfo["CompanyName"].ToString();
			txtContactName.Text = drCustomerInfo["ContactName"].ToString();
			txtMobile.Text = drCustomerInfo["Mobile"].ToString();
			txtAddress.Text = drCustomerInfo["Address"].ToString();
			txtEmail.Text = drCustomerInfo["Email"].ToString();
			txtTelephone.Text = drCustomerInfo["Telephone"].ToString();
			ActiveForm = frmCustomerDetails;
			return true;
		}

		#region Navigation Commands.
		private void cmdPrevious_Click(object sender, System.EventArgs e)
		{
			int n_CurrentRec = int.Parse(Session["CurrentRec"].ToString());
			
			if(n_CurrentRec > 0)
			{
				n_CurrentRec = n_CurrentRec - 1;
				Session["CurrentRec"] = n_CurrentRec;
				FillCustomerInfo(n_CurrentRec);
			}
			else
			{
				lblMsg.Text = "No valid record exists for selected customer.";
				ActiveForm = frmMessage;
			}
		}

		private void cmdNext_Click(object sender, System.EventArgs e)
		{
			int n_CurrentRec = int.Parse(Session["CurrentRec"].ToString());
			n_CurrentRec = n_CurrentRec + 1;
			Session["CurrentRec"] = n_CurrentRec;
			if (!FillCustomerInfo(n_CurrentRec))
			{
				lblMsg.Text = "No valid record exists for selected customer.";
				ActiveForm = frmMessage;
			}
		}

		private void cmdReturn_Click(object sender, System.EventArgs e)
		{
			this.RedirectToMobilePage("controlpanel.aspx");
		}
		#endregion Navigation Commands.
		#region Manipulation Commands.
		private void cmdAddCustomer_Click(object sender, System.EventArgs e)
		{
			ActiveForm = frmCustomerDetails;
		}

		private void cmdAdd_Click(object sender, System.EventArgs e)
		{
			int nResult = SqlHelper.ExecuteNonQuery(strBizRunConn,
				CommandType.Text,
				@"INSERT INTO CustomerList(CompanyName, ContactName, Address, Telephone, Mobile, Email) Values ('" +
				txtCompanyName.Text + "','" + txtContactName.Text + "','" + txtAddress.Text + "','" +
				txtTelephone.Text + "','" + txtMobile.Text + "','" + txtEmail.Text + "')");
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
			int nCurrentRec = int.Parse(Session["CurrentRec"].ToString());
			int nResult = SqlHelper.ExecuteNonQuery(strBizRunConn,
			CommandType.Text,
			@"Update CustomerList Set CompanyName = '" + txtCompanyName.Text + "' ," + 
			 "ContactName = '" + txtContactName.Text + "' ," +
			 "Address     = '" + txtAddress.Text     + "' ," +
			 "Telephone   = '" + txtTelephone.Text   + "' ," +
			 "Mobile      = '" + txtMobile.Text      + "' ," +
			 "Email       = '" + txtEmail.Text       + "' where Id = " + ds.Tables[0].Rows[nCurrentRec]["Id"].ToString() );

			if (nResult > 0){
				lblMsg.Text = "Record successfully added.";
				ActiveForm = frmMessage;
			}else{
				lblMsg.Text = "An error occurred while executing the command.";
				ActiveForm = frmMessage;
			}
		}

		private void cmdDelete_Click(object sender, System.EventArgs e)
		{
			int nResult = SqlHelper.ExecuteNonQuery(strBizRunConn,
				CommandType.Text,
				@"Delete from CustomerList where Id = " + Session["CurrentRec"].ToString() );

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
		#endregion Manipulation Commands.
		private void cmdBacktoRec_Click(object sender, System.EventArgs e)
		{
			ActiveForm = frmCustomerDetails;
		}
	}
}
