using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Evernet.Shared;
using Microsoft.ApplicationBlocks.Data;

namespace Evernet.MoneyExchange.Admin
{
	/// <summary>
	/// Summary description for ShowReport.
	/// </summary>
	public class ShowReport : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal litReceipt;
		protected System.Web.UI.WebControls.Button butNewTransaction;
		protected System.Web.UI.WebControls.Button butHome;
		protected System.Web.UI.WebControls.Button butBack;
		protected System.Web.UI.WebControls.Panel pnlNonPrint;
		string[] nstrTitles;
		
		private void Page_Load(object sender, System.EventArgs e)
		{
			string strReportType = "ForSentTrans";

			if(Request["Type"]!=null) 
			{
				strReportType = Request["Type"];
			}
			else
			{
				Response.Write("Report Type is reuired!");
				return;
			}

			if(strReportType.ToString()=="ForSentTrans")
			{
				nstrTitles = new string[]{"User","SRTR No","Date","Remitter","PayIn Amt.","PayOut Amt.","PayOut Currency","Status"};
			}
			else
			{}

			//bool forPrint=false;//;
			//bool showTransactionLink = false;

			if(Request["ForPrint"]!=null)
			{
				if(bool.Parse(Request["ForPrint"]))
				{
					pnlNonPrint.Visible=false;	
				}
			}
			//String strQry = (String)Session["ReportQry"];
			GenerateReport((String)Session["ReportQryCOC"]);
			GenerateReport((String)Session["ReportQryDTB"]);
			#region commented.
			//Guid transId = new Guid(Request["Id"]);

			/*******************************
			 * 
			 * 
			 * Load the Template file
			 * 
			 * 
			 * ***************/
			/*
			string templateFile = String.Empty;

			if(strReportType=="ForSentTrans") 
			{
				templateFile = "/Admin/CashTransactionReceiptTemplate.htm";
				if(dr["PayOutCurrencyId_Code"].ToString() == "Rs.")
					templateFile = "/Admin/CashZohaTransactionReceiptTemplate.htm";
			} 
			else if(aoPaymentMode.Col_FinalEntity.Value=="Bank") 
			{
				templateFile = "/Admin/BankTransactionReceiptTemplate.htm";
			} 

			templateFile = Server.MapPath(templateFile);

			if(!File.Exists(templateFile)) 
			{
				Response.Write("Report Template File not Found!");
				return;
			}

			StreamReader sr = new StreamReader(templateFile);

			string fileContent = sr.ReadToEnd();

			sr.Close();

			/*******************************

            
			fileContent = fileContent.Replace("{Date}",tDT.ToString("dd MMM yyyy"));
			fileContent = fileContent.Replace("{Time}",tDT.ToString("hh:mm:ss"));
			if(dsEMCNumber.Tables[0].Rows[0]["EMCNumber"] != DBNull.Value)
				fileContent = fileContent.Replace("{EMCNumber}",dsEMCNumber.Tables[0].Rows[0]["EMCNumber"].ToString());
			else
				fileContent = fileContent.Replace("<b>Exclusive Membership Card No: </b>{EMCNumber}"," ");

			// Special case, if payout is IDR, show it in USD
			if((dr["PayInCurrencyId_Code"].ToString()=="QAR" && dr["PayOutCurrencyId_Code"].ToString()=="IDR") && receiptType=="ForPayIn") 
			{
				decimal bankRate = decimal.Parse(dr["BankExchangeRateForPayOutCurrency"].ToString());
				decimal agentMarginPercent = decimal.Parse(dr["AgentMarginPercent"].ToString());
				decimal agencyMarginPercent = decimal.Parse(dr["AgencyMarginPercent"].ToString());
				decimal finalRate = bankRate - (bankRate * (agentMarginPercent/100)) - (bankRate * (agencyMarginPercent/100));
				fileContent = fileContent.Replace("{ForeignCurrencyAmount}", decimal.Round(decimal.Parse(dr["PayOutAmount"].ToString()) / finalRate,2).ToString());
				fileContent = fileContent.Replace("{ForeignCurrencyCode}","USD");
				fileContent = fileContent.Replace("{ExchangeRate}", "");
			} 
			else 
			{
				fileContent = fileContent.Replace("{ForeignCurrencyAmount}", decimal.Round(decimal.Parse(dr["PayOutAmount"].ToString()),aoPayOutCurrency.Col_Scale.Value).ToString());
				fileContent = fileContent.Replace("{ForeignCurrencyCode}",dr["PayOutCurrencyId_Code"].ToString());
				fileContent = fileContent.Replace("{ExchangeRate}", decimal.Round(decimal.Parse(dr["AgentExchangeRate"].ToString()), 6).ToString());
			}*
			litReceipt.Text=fileContent;
			/*
			if(forPrint) 
			{
				pnlNonPrint.Visible=false;			
			}
			if(showTransactionLink)
				butNewTransaction.Visible=true;
			else
				butNewTransaction.Visible=false;*/
			#endregion commented.
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
		private void butNewTransaction_Click(object sender, System.EventArgs e) 
		{

		}

		private void butHome_Click(object sender, System.EventArgs e) 
		{
			Response.Redirect("Home.aspx");
		}

		private void btnBack_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("ViewIncomingTransaction.aspx");
		}

		private void GenerateReport(string strQry)
		{
			StringBuilder stbContent = new StringBuilder();
			DataSet dsData = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				strQry);
			stbContent.Append("<font face='Verdana'><table border='1' cellpadding='0' cellspacing='1' style='border-collapse: collapse;font-size:10px' bordercolor='#111111' width='100%' id='AutoNumber1'>");
			stbContent.Append(CreateHeaderRow());

			for (int n_Row=0 ; n_Row<dsData.Tables[0].Rows.Count ; n_Row++)
			{
				stbContent.Append("<tr>");
				for (int n_Col=0 ; n_Col<dsData.Tables[0].Columns.Count ; n_Col++)
				{
					stbContent.Append("<td><p align='centre'>");
					stbContent.Append(dsData.Tables[0].Rows[n_Row][n_Col].ToString());
					stbContent.Append("</p></td>");
					stbContent.Append("");
				}
				stbContent.Append("</tr>");
			}			
			stbContent.Append("");

			if(litReceipt.Text!= String.Empty)
			{
				stbContent.Append("<tr><td colspan='8'><b>Total Transactions: " + dsData.Tables[0].Rows.Count + "</b></td></tr></table></font>");
				litReceipt.Text += stbContent.ToString();
			}
			else
			{
				stbContent.Append("<tr><td colspan='8'><b>Total Transactions: " + dsData.Tables[0].Rows.Count + "</b></td></tr></table><table><tr><td>&nbsp;</td></tr><tr><td>&nbsp;</td></tr></table></font>");
				litReceipt.Text =  stbContent.ToString();
			}
		}

		private String CreateHeaderRow()
		{
			StringBuilder stbHeader = new StringBuilder();
			if(litReceipt.Text!= String.Empty)
			{
				stbHeader.Append("<tr><td colspan='8' align='center'><b>Bank Transfer (DTH/DTB/CTA)</b></td></tr>");
			}
			else
			{
				stbHeader.Append("<tr><td colspan='8' align='center'><b>Cash Over Counter (COC)</b></td></tr>");
			}
			stbHeader.Append("<tr>");
			for(int n_HdrCol=0; n_HdrCol<nstrTitles.GetLength(0); n_HdrCol++)
			{
				stbHeader.Append(@"<td align='center'><b>" + nstrTitles.GetValue(n_HdrCol).ToString() + "</b></td>") ;
			}
			stbHeader.Append("</tr>");
			return stbHeader.ToString();
		}
	}
}