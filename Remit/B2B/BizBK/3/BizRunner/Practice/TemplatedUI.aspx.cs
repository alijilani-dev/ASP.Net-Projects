using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Microsoft.ApplicationBlocks.Data;

namespace BizRunner
{
	/// <summary>
	/// Summary description for TemplatedUI.
	/// </summary>
	public class TemplatedUI : System.Web.UI.MobileControls.MobilePage
	{
		protected System.Web.UI.MobileControls.Label Label1;
		protected System.Web.UI.MobileControls.Label Label2;
		protected System.Web.UI.MobileControls.Command Command1;
		protected System.Web.UI.MobileControls.Command Command2;
		private void Page_Load(object sender, System.EventArgs e)
		{
			if (!IsPostBack)
			{
				SqlConnection strBizRunConn = new SqlConnection((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("MExchange.ConnectionString").GetValue(0));
				string strQuery = "Select Id, LoginName as Name From UserList";
				DataSet ds = SqlHelper.ExecuteDataset(strBizRunConn,
					CommandType.Text,
					strQuery);

				//Command1.DataSource = ds;
				//Command1.DataBind();
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		protected void Command_Click(object sender, CommandEventArgs e)
		{
			if (e.CommandName.ToString()=="Command1")
			{
				Label1.Text = "You clicked Button1.";
			}
			else if (e.CommandName.ToString()=="Command2")
			{
				Label1.Text = "You clicked Button2.";
			}  
		}

	}
}
