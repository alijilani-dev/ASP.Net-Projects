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
	public class resourceviewdeleteme: System.Web.UI.MobileControls.MobilePage
	{
		#region Declarations.
		protected System.Web.UI.MobileControls.Command cmdBack;
		protected System.Web.UI.MobileControls.Command cmdCancel;
		protected System.Web.UI.MobileControls.List lstResources;
		protected System.Web.UI.MobileControls.Command cmdAdd;
		protected System.Web.UI.MobileControls.Command cmdUpdate;
		protected System.Web.UI.MobileControls.Command cmdDelete;
		protected System.Web.UI.MobileControls.Form frmResourceView;
		protected System.Web.UI.MobileControls.Command Command4;
		protected System.Web.UI.MobileControls.Command Command5;
		protected System.Web.UI.MobileControls.Command cmdNext;
		protected System.Web.UI.MobileControls.Command cmdSales;
		protected System.Web.UI.MobileControls.Command cmdCosts;
		protected System.Web.UI.MobileControls.Command cmdPrev;
		protected System.Web.UI.MobileControls.TextBox txtDescription;
		protected System.Web.UI.MobileControls.Label lblDescription;
		protected System.Web.UI.MobileControls.Label lblCost;
		protected System.Web.UI.MobileControls.TextBox txtTitle;
		protected System.Web.UI.MobileControls.Label lblTitle;
		protected System.Web.UI.MobileControls.TextBox txtCost;
		protected System.Web.UI.MobileControls.Form frmResourceDetails;
		protected System.Web.UI.MobileControls.Command cmdBacktoRec;
		protected System.Web.UI.MobileControls.Label lblMsg;
		protected System.Web.UI.MobileControls.Label lblHeading;
		protected System.Web.UI.MobileControls.Form frmMessage;
		string strBizRunConn = (string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("BizRun.ConnectionString").GetValue(0);
		DataSet ds = null;
		protected System.Web.UI.MobileControls.Command cmdAddNew;
		protected System.Web.UI.MobileControls.Label lblTotalCost;
		protected System.Web.UI.MobileControls.Label lblTotalResCost;
		int n_CurrentRec = 0;
		#endregion Declarations.
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				Session["CurrentResIndex"] = 0;
				Session["CurrentRes"] = 0;
				ds = GetResourcesData();
				lstResources.DataSource = ds;
				lstResources.DataBind();
				lblTotalResCost.Text = GetTotalCost().ToString();
			}
			else
			{
				ds = GetResourcesData();
				lblTotalResCost.Text = GetTotalCost().ToString();
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
			this.lstResources.ItemCommand += new System.Web.UI.MobileControls.ListCommandEventHandler(this.lstResources_ItemCommand);
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
		private int GetTotalCost()
		{
			int nTotalCost = 0;
			for (int i=0; i<ds.Tables[0].Rows.Count; i++)
			{
				nTotalCost += int.Parse(ds.Tables[0].Rows[i]["Cost"].ToString());
			}
			return nTotalCost;
		}

		private DataSet GetResourcesData()
		{
			string strQuery = "select Id, Name, Description, Cost from ResourceList order by Id";
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
			string strQuery = "select Id, Name, Description, Cost from ResourceList where Id = " + nRec.ToString() + " order by Id";
			DataSet dsResourceInfo = SqlHelper.ExecuteDataset(strBizRunConn,
				CommandType.Text,
				strQuery);
			DataRow drResourceInfo = null;

			try
			{
				drResourceInfo = dsResourceInfo.Tables[0].Rows[0];//ds.Tables[0].Rows[nRec];
			}
			catch{}
			
			if (drResourceInfo == null)
				return false;

			// Fill the form with respective values.
			txtTitle.Text = drResourceInfo["Name"].ToString();
			txtCost.Text = drResourceInfo["Cost"].ToString();
			txtDescription.Text = drResourceInfo["Description"].ToString();
			ActiveForm = frmResourceDetails;
			return true;
		}

		#region Manipulation Commands.
		private void cmdAdd_Click(object sender, System.EventArgs e)
		{
			int nResult = SqlHelper.ExecuteNonQuery(strBizRunConn,
				CommandType.Text,
				@"INSERT INTO ResourceList(Name, Cost, Description) Values ('" +
				txtTitle.Text + "','" + txtCost.Text + "','" + txtDescription.Text + "')");
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
				@"Update ResourceList Set " + 
				"Name		 = '" + txtTitle.Text			+ "' ," +
				"Cost	     = '" + txtCost.Text			+ "' ," +
				"Description = '" + txtDescription.Text		+ "' where Id = " + ds.Tables[0].Rows[nCurrentRec]["Id"].ToString() );

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
				@"Delete from ResourceList where Id = " + ds.Tables[0].Rows[nCurrentRec]["Id"].ToString() );

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
			ActiveForm = frmResourceDetails;
		}

		private void cmdBacktoRec_Click(object sender, System.EventArgs e)
		{
			ActiveForm = frmResourceDetails;
		}

		private void cmdBack_Click(object sender, System.EventArgs e)
		{
			this.RedirectToMobilePage("resourceview.aspx");
		}

		private void cmdCancel_Click(object sender, System.EventArgs e)
		{
			this.RedirectToMobilePage("resourceview.aspx");
			ActiveForm = frmResourceView;
		}
		#endregion Navigation Commands.
	}
}
