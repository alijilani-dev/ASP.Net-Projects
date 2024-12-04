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
	/// Summary description for taskview.
	/// </summary>
	public class taskview : System.Web.UI.MobileControls.MobilePage
	{
		#region Declarations.
		protected System.Web.UI.MobileControls.Form frmServicesView;
		protected System.Web.UI.MobileControls.Label lblDescription;
		protected System.Web.UI.MobileControls.Label lblCategory;
		protected System.Web.UI.MobileControls.Label lblTitle;
		protected System.Web.UI.MobileControls.TextBox txtTitle;
		protected System.Web.UI.MobileControls.Label lblStatus;
		protected System.Web.UI.MobileControls.TextBox txtStatus;
		protected System.Web.UI.MobileControls.Label lblStartDate;
		protected System.Web.UI.MobileControls.TextBox txtStartDate;
		protected System.Web.UI.MobileControls.Label lblEndDate;
		protected System.Web.UI.MobileControls.TextBox txtEndDate;
		protected System.Web.UI.MobileControls.Label lblCustomerName;
		protected System.Web.UI.MobileControls.TextBox txtCustomerName;
		protected System.Web.UI.MobileControls.Label lblRepresentativeName;
		protected System.Web.UI.MobileControls.TextBox txtRepresentativeName;
		protected System.Web.UI.MobileControls.Label lblType;
		protected System.Web.UI.MobileControls.TextBox txtType;
		protected System.Web.UI.MobileControls.SelectionList SelectionList1;
		protected System.Web.UI.MobileControls.Command cmdBacktoRec;
		protected System.Web.UI.MobileControls.Label lblMsg;
		protected System.Web.UI.MobileControls.Label lblHeading;
		protected System.Web.UI.MobileControls.Form frmMessage;
		protected System.Web.UI.MobileControls.Form frmServicesDetails;
		protected System.Web.UI.MobileControls.SelectionList slCategory;
		protected System.Web.UI.MobileControls.TextBox txtDescription;
		protected System.Web.UI.MobileControls.Command cmdCosts;
		protected System.Web.UI.MobileControls.Command cmdSales;
		protected System.Web.UI.MobileControls.Command cmdPrev;
		protected System.Web.UI.MobileControls.Command cmdNext;
		protected System.Web.UI.MobileControls.Command cmdAdd;
		protected System.Web.UI.MobileControls.Command cmdUpdate;
		protected System.Web.UI.MobileControls.Command cmdDelete;
		protected System.Web.UI.MobileControls.Command cmdBack;
		protected System.Web.UI.MobileControls.Command cmdCancel;
		protected System.Web.UI.MobileControls.List ServicesList;
		protected System.Web.UI.MobileControls.Command cmdAddNew;
		protected System.Web.UI.MobileControls.Command cmdBacktoControlPanel;
		#endregion Declarations.
		string strBizRunConn = (string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("BizRun.ConnectionString").GetValue(0);
		DataSet ds = null;
		int n_CurrentRec = 0;

		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				ds = GetServicesData();
				ServicesList.DataSource = ds;
				ServicesList.DataBind();
			}else
				ds = GetServicesData();
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
			this.ServicesList.ItemCommand += new System.Web.UI.MobileControls.ListCommandEventHandler(this.ServicesList_ItemCommand);
			this.cmdAddNew.Click += new System.EventHandler(this.cmdAddNew_Click);
			this.cmdPrev.Click += new System.EventHandler(this.cmdPrev_Click);
			this.cmdCosts.Click += new System.EventHandler(this.cmdCosts_Click);
			this.cmdSales.Click += new System.EventHandler(this.cmdSales_Click);
			this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
			this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
			this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
			this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
			this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
			this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
			this.cmdBacktoRec.Click += new System.EventHandler(this.cmdBacktoRec_Click);
			this.cmdBacktoControlPanel.Click += new System.EventHandler(this.cmdBacktoControlPanel_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private DataSet GetServicesData()
		{
			string strQuery = "Select sr.Id, sr.Title, sr.CustomerId, sr.RepresentativeId, sr.ServicesType, sr.Status, sr.StartDate, sr.EndDate, sr.Description from ServicesRecord sr where sr.CustomerId = '" + Session["CustomerId"].ToString() + "' order by Id";
			ds = SqlHelper.ExecuteDataset(strBizRunConn,
				CommandType.Text,
				strQuery);
			return ds;
		}

		private void ServicesList_ItemCommand(object sender, System.Web.UI.MobileControls.ListCommandEventArgs e)
		{
			// Get the DataValueField for the Item.
			n_CurrentRec = int.Parse(e.ListItem.Value);
			//Session["CurrentRec"] = n_CurrentRec;
			Session["CurrentRec"] = e.ListItem.Index;
			Session["ServiceIndex"] = e.ListItem.Index;
			Session["ServiceId"] = e.ListItem.Value;

			// Fill Cutomer Information into the form and display;
			if (!FillServicesInfo(n_CurrentRec))
			{
				lblMsg.Text = "No valid record exists for selected Service.";
				ActiveForm = frmMessage;
			}
		}

		private bool FillServicesInfo(int nRec)
		{			
			// Use the DataValueField to pull data from DB.
			string strQuery = "select sr.Id, sr.Title, cl.CompanyName, ul.FirstName + ' ' + ul.LastName as Representative, sr.ServicesType, sr.Status, sr.StartDate, sr.EndDate, sr.Description from ServicesRecord sr join CustomerList cl on sr.CustomerId = cl.Id join UserList ul on sr.RepresentativeId = ul.Id where sr.Id = " + nRec.ToString();
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
			txtTitle.Text = drCustomerInfo["Title"].ToString();
			txtStatus.Text = drCustomerInfo["Status"].ToString();
			txtStartDate.Text = drCustomerInfo["StartDate"].ToString();
			txtEndDate.Text = drCustomerInfo["EndDate"].ToString();
			txtCustomerName.Text = drCustomerInfo["CompanyName"].ToString();
			txtRepresentativeName.Text = drCustomerInfo["Representative"].ToString();
			txtType.Text = drCustomerInfo["ServicesType"].ToString();
			txtDescription.Text = drCustomerInfo["Description"].ToString();
			ActiveForm = frmServicesDetails;
			return true;
		}

		private void cmdBacktoRec_Click(object sender, System.EventArgs e)
		{
			ActiveForm = frmServicesDetails;
		}

		#region Manipulation Commands.
		private void cmdAdd_Click(object sender, System.EventArgs e)
		{
			int nResult = SqlHelper.ExecuteNonQuery(strBizRunConn,
				CommandType.Text,
				@"INSERT INTO ServicesRecord(Title, CustomerId, RepresentativeId, ServicesType, Status, StartDate, EndDate, Description) Values ('" +
				txtTitle.Text + "'," + Session["CustomerId"].ToString() + ",'" + Session["UserId"].ToString() + "','" +
				//txtTitle.Text + "','" + txtCustomerName.Text + "','" + txtRepresentativeName.Text + "','" +
				txtType.Text + "','" + txtStatus.Text + "','" + txtStartDate.Text + "','" + txtEndDate.Text + "','" + txtDescription.Text + "')");
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
				@"Update ServicesRecord Set
				Title ='"				+ txtTitle.Text					+ @"', 
				--CustomerId = "		+ txtCustomerName.Text			+ @",
				--RepresentativeId = "	+ txtRepresentativeName.Text	+ @"',
				ServicesType ='"		+ txtType.Text					+ @"',
				Status ='"				+ txtStatus.Text				+ @"',
				StartDate ='"			+ txtStartDate.Text				+ @"',
				EndDate ='"				+ txtEndDate.Text				+ @"', 
				Description ='"			+ txtDescription.Text			+ @"'
				where Id = " + ds.Tables[0].Rows[nCurrentRec]["Id"].ToString());

			if (nResult > 0)
			{
				lblMsg.Text = "Record successfully Updated.";
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
				@"Delete from ServicesRecord where Id = " + ds.Tables[0].Rows[nCurrentRec]["Id"].ToString());
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
		#region Navigation Commands.
		private void cmdPrev_Click(object sender, System.EventArgs e)
		{
			int nIndex = int.Parse(Session["ServiceIndex"].ToString());
			int n_CurrentRec = 0;
			if (nIndex>0)
			{
				nIndex--;
				n_CurrentRec = int.Parse(ds.Tables[0].Rows[nIndex]["Id"].ToString());
				FillServicesInfo(n_CurrentRec);
				Session["ServiceId"] = n_CurrentRec;
				Session["ServiceIndex"] = nIndex;
			}
			else
			{
				lblMsg.Text = "No valid record exists for selected service.";
				ActiveForm = frmMessage;
			}
		}

		private void cmdNext_Click(object sender, System.EventArgs e)
		{
			int nIndex = int.Parse(Session["ServiceIndex"].ToString());
			int n_CurrentRec = 0;
			if (nIndex < ds.Tables[0].Rows.Count-1)
			{
				nIndex++;
				n_CurrentRec = int.Parse(ds.Tables[0].Rows[nIndex]["Id"].ToString());
				FillServicesInfo(n_CurrentRec);
				Session["ServiceId"] = n_CurrentRec;
				Session["ServiceIndex"] = nIndex;
			}
			else
			{
				lblMsg.Text = "No valid record exists for selected service.";
				ActiveForm = frmMessage;
			}
		}

		private void cmdBack_Click(object sender, System.EventArgs e)
		{
			this.RedirectToMobilePage("servicesview.aspx");
		}

		private void cmdCancel_Click(object sender, System.EventArgs e)
		{
			//this.RedirectToMobilePage("servicesview.aspx");
			ActiveForm = frmServicesView;
		}
		#endregion Navigation Commands.
		private void cmdCosts_Click(object sender, System.EventArgs e)
		{
		
		}

		private void cmdAddNew_Click(object sender, System.EventArgs e)
		{
			ActiveForm = frmServicesDetails;
		}

		private void cmdSales_Click(object sender, System.EventArgs e)
		{
			this.RedirectToMobilePage("resourceview.aspx");
		}

		private void cmdBacktoControlPanel_Click(object sender, System.EventArgs e)
		{
			this.RedirectToMobilePage("controlpanel.aspx");
		}
	}
}