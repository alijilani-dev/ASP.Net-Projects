using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using Microsoft.ApplicationBlocks.Data;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace WebApplication1
{
	/// <summary>
	/// Summary description for DataGridTraversal.
	/// </summary>
	public class DataGridTraversal : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(Request["Id"]==null) 
			{
				Response.Write("Transaction Id is required!");
				return;
			}

			string receiptType = "ForPayIn";
			if(Request["Type"]!=null) 
			{
				receiptType = Request["Type"];
			}

			bool forPrint=false;
			bool showTransactionLink = true;
			Guid transId = new Guid(Request["Id"]);
			SqlConnection sqlConn = new SqlConnection("Server=spr01; User Id=mexchange; Password=syncmaster591S; Database=mexchangedemo2");
			String strSel = "Select * from TransactionDetails where Id = '" + transId.ToString() + "' ";
			SqlCommand cmdSel = new SqlCommand(strSel);
			cmdSel.Connection = sqlConn;
			DataSet ds = new DataSet();

			/////////////////////////////////////////////////
			// Set up parameters (15 inputs 0 outputs) 
			SqlParameter [] arParms = new SqlParameter[15];

			// @ID Input Parameter 
			arParms[0] = new SqlParameter("@ID", SqlDbType.UniqueIdentifier ); 
			arParms[0].Direction = ParameterDirection.Input;
			arParms[0].Value = transId;

			// @CustomerId Output Parameter
			arParms[1] = new SqlParameter("@CustomerId", SqlDbType.UniqueIdentifier);
			arParms[1].Direction = ParameterDirection.Input;
			arParms[1].Value = DBNull.Value;

			// @BeneficeryId Output Parameter
			arParms[2] = new SqlParameter("@BeneficeryId", SqlDbType.UniqueIdentifier);
			arParms[2].Direction = ParameterDirection.Input;
			arParms[2].Value = DBNull.Value;

			// @BeneficeryBankId Output Parameter
			arParms[3] = new SqlParameter("@BeneficeryBankId", SqlDbType.UniqueIdentifier);
			arParms[3].Direction = ParameterDirection.Input;
			arParms[3].Value = DBNull.Value;
			
			// @BeneficeryBankId Output Parameter
			arParms[4] = new SqlParameter("@PaymentMode", SqlDbType.NVarChar,50);
			arParms[4].Direction = ParameterDirection.Input;
			arParms[4].Value = DBNull.Value;
			
			// @BeneficeryBankId Output Parameter
			arParms[5] = new SqlParameter("@PurposeOfTransfer", SqlDbType.NVarChar,50);
			arParms[5].Direction = ParameterDirection.Input;
			arParms[5].Value = DBNull.Value;
			
			// @BeneficeryBankId Output Parameter
			arParms[6] = new SqlParameter("@PayInCurrencyId", SqlDbType.UniqueIdentifier);
			arParms[6].Direction = ParameterDirection.Input;
			arParms[6].Value = DBNull.Value;
			
			// @BeneficeryBankId Output Parameter
			arParms[7] = new SqlParameter("@PayOutCurrencyId", SqlDbType.UniqueIdentifier);
			arParms[7].Direction = ParameterDirection.Input;
			arParms[7].Value = DBNull.Value;
			
			// @BeneficeryBankId Output Parameter
			arParms[8] = new SqlParameter("@AssociatedBankId", SqlDbType.UniqueIdentifier);
			arParms[8].Direction = ParameterDirection.Input;
			arParms[8].Value = DBNull.Value;
			
			// @BeneficeryBankId Output Parameter
			arParms[9] = new SqlParameter("@PayInAgentUserId", SqlDbType.UniqueIdentifier);
			arParms[9].Direction = ParameterDirection.Input;
			arParms[9].Value = DBNull.Value;
			
			// @BeneficeryBankId Output Parameter
			arParms[10] = new SqlParameter("@PayInAgentLocationId", SqlDbType.UniqueIdentifier);
			arParms[10].Direction = ParameterDirection.Input;
			arParms[10].Value = DBNull.Value;
			
			// @BeneficeryBankId Output Parameter
			arParms[11] = new SqlParameter("@PayOutAgentUserId", SqlDbType.UniqueIdentifier);
			arParms[11].Direction = ParameterDirection.Input;
			arParms[11].Value = DBNull.Value;
			
			// @BeneficeryBankId Output Parameter
			arParms[12] = new SqlParameter("@Status", SqlDbType.UniqueIdentifier);
			arParms[12].Direction = ParameterDirection.Input;
			arParms[12].Value = DBNull.Value;
			
			// @BeneficeryBankId Output Parameter
			arParms[13] = new SqlParameter("@SettlementStatus", SqlDbType.UniqueIdentifier);
			arParms[13].Direction = ParameterDirection.Input;
			arParms[13].Value = DBNull.Value;

			// @BeneficeryBankId Output Parameter
			arParms[14] = new SqlParameter("@ReturnXML", SqlDbType.UniqueIdentifier);
			arParms[14].Direction = ParameterDirection.Input;
			arParms[14].Value = 0;//DBNull.Value;
			/////////////////////////////////////////////////
			try
			{
				sqlConn.Open();
				//SqlHelper.ExecuteDataset(sqlConn,CommandType.Text,strSel);
				ds = SqlHelper.ExecuteDataset(sqlConn,"spS_TransactionDetails_Full",arParms);
			}
			catch(SqlException ex)
			{
				Response.Write("SqlException Occured! Message: " + ex.Message);
				return;
			}
			finally
			{
				sqlConn.Close();
			}
			for (int i=0; i<ds.Tables[0].Rows.Count; i++)
			{
				for (int j=0; j<ds.Tables[0].Columns.Count; j++)
				{
					Response.Write(":" + ds.Tables[0].Rows[i][j].ToString());
				}
			}
			Response.Write("Successful." + ds.Tables[0].Rows[0][0].ToString());
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
