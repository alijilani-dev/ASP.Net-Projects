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

namespace WebApplication1
{
	/// <summary>
	/// Summary description for InitiateTransfer.
	/// </summary>
	public class InitiateTransfer : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid MyDataGrid;
		protected System.Web.UI.WebControls.Label CacheMsg;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			DataView Source;

			// try to retrieve item from cache
			// if it's not there, add it

			Source = (DataView)Cache["MyDataSet"];

			if (Source == null) 
			{

				SqlConnection myConnection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["mexchange ConnectionString"].ToString());
				SqlDataAdapter myCommand = new SqlDataAdapter("select Name from AgentMaster", myConnection);

				DataSet ds = new DataSet();
				myCommand.Fill(ds, "AgentMaster");

				Source = new DataView(ds.Tables["AgentMaster"]);
				Cache["MyDataSet"] = Source;

				CacheMsg.Text = "Dataset created explicitly";
			}
			else 
			{
				CacheMsg.Text = "Dataset retrieved from cache";
			}

			MyDataGrid.DataSource=Source;
			MyDataGrid.DataBind();
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
	}
}
