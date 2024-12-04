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

namespace BizRunner.Practice
{
	/// <summary>
	/// Summary description for index.
	/// </summary>
	public class index : System.Web.UI.MobileControls.MobilePage
	{
		protected System.Web.UI.MobileControls.Label lbl_Message;
		protected System.Web.UI.MobileControls.List List1;
		protected System.Web.UI.MobileControls.Form Form1;

		private void Page_Load(object sender, System.EventArgs e)
		{
			//if (!IsPostBack)
			{
				SqlConnection strBizRunConn = new SqlConnection((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("MExchange.ConnectionString").GetValue(0));
				string strQuery = "Select Id, LoginName as Name From UserList";
				DataSet ds = SqlHelper.ExecuteDataset(strBizRunConn,
					CommandType.Text,
					strQuery);
				/*for (int i = 0; i < ds.Tables[0].Rows.Count ; i++)
				{
					Link lnk = new Link();
					Command cmdtemp = new Command();
					cmdtemp.Text = ds.Tables[0].Rows[i]["Name"].ToString();
					lnk.NavigateUrl = "index.aspx?id=" + ds.Tables[0].Rows[i]["Id"].ToString();
					lnk.Text = ds.Tables[0].Rows[i]["Name"].ToString();
					myForm.Controls.Add(cmdtemp);
					myForm.Controls.Add(lnk);
				}*/
					for(int x=0;x<5;x++)
					{
						string id = ds.Tables[0].Rows[x]["Id"].ToString();
						string name = "";
						name += "[" + id + "] ";
						name += ds.Tables[0].Rows[x]["Name"].ToString() + " ";
						//name += listdetails.Tables[1].Rows[x].ItemArray.GetValue(2).ToString();

						System.Web.UI.MobileControls.MobileListItem item = new MobileListItem("asdf","CustomerDetails.aspx?ID=" + "asdf");
						List1.Items.Add(item);
					}

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
	}
}
