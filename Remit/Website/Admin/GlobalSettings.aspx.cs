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
using Evernet.Shared;
using Microsoft.ApplicationBlocks.Data;

namespace Evernet.MoneyExchange.Admin {
	/// <summary>
	/// Summary description for GlobalSettings.
	/// </summary>
	public class GlobalSettings : System.Web.UI.Page {
		protected System.Web.UI.WebControls.TextBox txtName;
		protected System.Web.UI.WebControls.TextBox txtAdminEmail;
		protected System.Web.UI.WebControls.TextBox txtTechEmail;
		protected System.Web.UI.WebControls.TextBox txtGlobalThreshold;
		protected System.Web.UI.WebControls.CheckBox cbxActive;
		protected System.Web.UI.WebControls.Label lblStatus;
		protected System.Web.UI.WebControls.Button butUpdate;
	
		private void Page_Load(object sender, System.EventArgs e) {
			if(!IsPostBack) {
				BindValues();
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
			this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void BindValues() {
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From GlobalSettings Where Id=1");

			if(ds.Tables[0].Rows.Count>0) {
				DataRow dr = ds.Tables[0].Rows[0];
				txtName.Text = dr["Name"].ToString();
				txtAdminEmail.Text = dr["AdministrativeEmail"].ToString();
				txtTechEmail.Text = dr["TechnicalEmail"].ToString();
				txtGlobalThreshold.Text = dr["TransactionThresholdUSD"].ToString();
				cbxActive.Checked = Convert.ToBoolean(dr["Active"].ToString());
			}
		}

		private void butUpdate_Click(object sender, System.EventArgs e) {
			string sqlUpdate = "Update GlobalSettings Set Name='"+ txtName.Text +"',AdministrativeEmail='"+ txtAdminEmail.Text +"',TechnicalEmail='"+ txtTechEmail.Text +"',TransactionThresholdUSD="+ Convert.ToDecimal(txtGlobalThreshold.Text) +",Active="+ (cbxActive.Checked?"1":"0") +" Where Id=1";

			SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
				CommandType.Text,
				sqlUpdate);

			lblStatus.Text = "Global settings updated successfully!";
		}
	}
}
