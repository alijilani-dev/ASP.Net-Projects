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
using Evernet.MoneyExchange.BusinessLogic;
using System.IO;

namespace Evernet.MoneyExchange.Admin {
	
	public class ExportUnPaidDraftToExcel : System.Web.UI.Page {
		private void Page_Load(object sender, System.EventArgs e) {
			// Put user code to initialize the page here
			Response.Clear();
			Response.Buffer=true;
			Guid accountId = UserManager.GetAgentAccountForUser(new Guid(User.Identity.Name));

			Evernet.MoneyExchange.AbstractClasses.Abstract_AgentMaster aoAgentAccount
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentMaster(ConfigHelper.ConStr);

            aoAgentAccount.Refresh(accountId);
            
			string fileName = "/ExportQueries/"+aoAgentAccount.Col_Name.ToString()+".sql";
			string globalFileName = "/ExportQueries/Global.sql";

			fileName = Server.MapPath(fileName);
			globalFileName = Server.MapPath(globalFileName);

			if(!File.Exists(fileName)) {
				fileName = globalFileName;

				if(!File.Exists(fileName)) {
					throw new Exception("Could not find agent account specific or global query template!");
				}
			}

			StreamReader sr = new StreamReader(fileName);
			string fileQuery = sr.ReadToEnd();
			sr.Close();

////			string query = @"Select 
////				td.Id,
////				td.TransactionNumber,
////				td.PayInDateTime,
////				bl.Name as BankName,
////				blst.FirstName +', '+ blst.LastName as BeneficiaryName,
////				bbl.AccountNumber,
////				bbl.Name as BenBankName,
////				bbl.BranchName as BenBranchName,
////				td.PayOutAmount
////				From TransactionDetails td 
////				Join PaymentModeList pml
////				On td.PaymentMode = pml.Value
////				And pml.ChannelThrough='Bank'
////				And (pml.FinalEntity='Bank' Or pml.FinalEntity='Home')
////				Join BankList bl
////				On td.AssociatedBankId = bl.Id
////				Join AgentMaster am
////				On bl.AccountId = am.Id
////				Join CustomerList blst
////				On td.BeneficeryId = blst.Id
////				Left Outer Join BeneficeryBankList bbl
////				On td.BeneficeryBankId = bbl.Id
////				Where Status = 'UnPaid'
////				And AssociatedBankId In (Select Id From BankList Where AccountId = '"+ accountId.ToString() +"') Order by BankName, PayInDateTime";
///
			fileQuery = fileQuery.Replace("{AgentAccountId}",accountId.ToString());
			Trace.Write("File Query",fileQuery);
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				fileQuery);

			// string csv = Utilities.ExportToCSV(ds);

			Response.ContentType = "application/unknown";
			Response.AddHeader("content-disposition", "attachment;filename=UnPaidDrafts.txt");
			// Response.Write(csv);
			StreamWriter sw = new StreamWriter(Response.OutputStream);
			string text = string.Empty;
			foreach(DataRow dr in ds.Tables[0].Rows) {
				for(int i=0;i<ds.Tables[0].Columns.Count;i++) {
					text = dr[i].ToString();
					text = text.Replace("\n","  ");
					text = text.Replace("\r","");
					//text = text.Replace("\l","");
					sw.Write(text);
				}
				// Response.Write("\n\r");
				sw.WriteLine();
			}

			sw.Close();

			Response.Flush();
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
