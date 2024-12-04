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
using Evernet.Shared;

namespace Evernet.MoneyExchange.Admin {
	/// <summary>
	/// Summary description for ShowOpenTransaction.
	/// </summary>
	public class ShowOpenTransaction : System.Web.UI.Page {
		protected System.Web.UI.WebControls.TextBox txtTransactionNumber;
		protected System.Web.UI.WebControls.TextBox txtBeneficeryFirstName;
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.Button butProceed;
		protected System.Web.UI.WebControls.TextBox txtBeneficeryLastName;
	
		private void Page_Load(object sender, System.EventArgs e) {
			// Put user code to initialize the page here
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
			this.butProceed.Click += new System.EventHandler(this.butProceed_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void butProceed_Click(object sender, System.EventArgs e) {
			DataSet ds1 = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select Id, BeneficeryId From TransactionDetails Where TransactionNumber='"+ txtTransactionNumber.Text +"' And Status='UnPaid'");

			if(ds1.Tables[0].Rows.Count>0) {
				DataSet ds2 = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					"Select FirstName, LastName From CustomerList Where Id='"+ ds1.Tables[0].Rows[0]["BeneficeryId"].ToString() +"' And FirstName='"+ txtBeneficeryFirstName.Text +"' and LastName='"+ txtBeneficeryLastName.Text +"' ");

				if(ds2.Tables[0].Rows.Count>0) {
					Response.Redirect("PayOutOpenTransaction.aspx?Id="+ds1.Tables[0].Rows[0]["Id"].ToString());
				} else {
					lblMessage.Text = "FirstName / LastName of the beneficery is not matching";
				}

			} else {
				lblMessage.Text = "No Transaction found with the provided number!";
			}
		}
	}
}
