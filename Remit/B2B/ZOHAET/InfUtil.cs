using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.ApplicationBlocks.Data;
using System.Windows.Forms;

namespace ZOHAET
{
	/// <summary>
	/// Summary description for txtTool.
	/// </summary>
	public class InfUtil
	{
		#region Custom Declarations.
		DataSet ds_Agent;
		StreamWriter sw_Inf;
		FileInfo fi_Inf;
		string BatchFilePath = string.Empty;
		SqlConnection ARYSRET_Conn;
		int n_BATCH_SIZE = 0, n_BATCH_KEY = 0;
		decimal n_BATCH_TOTAL = 0;
		#endregion Custom Declarations.
		public InfUtil(string strPath)
		{
			BatchFilePath = ((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("WALLSET.PathBatchFileINF").GetValue(0));
			#region GetBatchNumberString.
			string strBatchNumber = GetMaxBatchNumber().ToString().Trim();
			for(int n_Counter = 0; n_Counter<strBatchNumber.Length; n_Counter++)
			{
				if(strBatchNumber.StartsWith("0"))
					strBatchNumber = strBatchNumber.Remove(0,1);
				if((5-strBatchNumber.Length) >= 0)
				{
					// pad on left.
					strBatchNumber = strBatchNumber.PadLeft(5,'0');
				}
				else
				{
					// trim extra char.
				}
			}
			#endregion GetBatchNumberString.
			// Create File Name and File.
			BatchFilePath += "ARYSR_ET" + strBatchNumber;
			//ZOHAET.str_GlobalBatchNumber = BatchFilePath;
			fi_Inf = new FileInfo(BatchFilePath + ".inf");
			sw_Inf = fi_Inf.CreateText();
			// Pull Data.
			ds_Agent = GetAgentData();
			// Develop statistics.
			int n_RemitterNameAsciiCount = GetColumnAsciiCount("RemitterFullName");
			int n_BeneficiaryNameAsciiCount = GetColumnAsciiCount("BeneficiaryName");
			int n_PayOutAmountAsciiCount = GetColumnAsciiCount("PayOutAmount");
			int n_SRCodeAsciiCount = GetColumnAsciiCount("SRCode");
			int n_TotalAsciiCount = n_RemitterNameAsciiCount+n_BeneficiaryNameAsciiCount+n_PayOutAmountAsciiCount+n_SRCodeAsciiCount;
			// File Format:
			//[BATCH_NO]|[BATCH_DATE]|[BATCH_SIZE]|[BATCH_TOTAL]|[BATCH_KEY]
			// Fill inf file.
			sw_Inf.Write(GetMaxBatchNumber().ToString() + "|");

			//DateTimeFormatInfo dt_Temp = new DateTimeFormatInfo();
			//dt_Temp.ShortDatePattern = "dd/MM/yyyy";
			DateTime dt_BDate = DateTime.Parse(DateTime.Now.ToShortDateString(), CultureInfo.CreateSpecificCulture("fr-FR").DateTimeFormat);
			
			sw_Inf.Write(dt_BDate.ToString("dd/MM/yyyy") + "|");
			n_BATCH_SIZE = ds_Agent.Tables[0].Rows.Count;
			if(ds_Agent.Tables[0].Rows.Count>0)
				n_BATCH_TOTAL = decimal.Round(GetBatchTotal(ds_Agent.Tables[0]),2);
			else
				n_BATCH_TOTAL = 0;
			n_BATCH_KEY = n_TotalAsciiCount*ds_Agent.Tables[0].Rows.Count;
			sw_Inf.Write(n_BATCH_SIZE.ToString() + "|");
			sw_Inf.Write(n_BATCH_TOTAL.ToString() + "|");
			sw_Inf.Write(n_BATCH_KEY.ToString());
			// Update Database.
			UpdateDBINF();
			sw_Inf.Close();
		}
		private int GetColumnAsciiCount(string strColumnName)
		{
			int n_RowAsciiSums = 0, n_TotalRowCount = 0, n_SumAscii = 0;
			for(int i = 0; i < ds_Agent.Tables[0].Rows.Count; i++)
			{
				// Create an ASCII encoding.
				Encoding ascii = Encoding.ASCII;
				String unicodeString = ds_Agent.Tables[0].Rows[i][strColumnName].ToString();
				// Encode the string.
				byte[] encodedBytes = ascii.GetBytes(unicodeString);
				foreach (byte b in encodedBytes) 
				{
					n_SumAscii += Convert.ToInt32(b);
					//sw_Inf.Write(" " + ((char)b) + ": " + Convert.ToInt32(b));
				}
				n_RowAsciiSums += n_SumAscii/unicodeString.Length;
				//sw_Inf.WriteLine(" RowNumber: " + i.ToString() + " " + strColumnName + ": " + unicodeString + " n_RowAsciiSums: " + n_RowAsciiSums);
				//sw_Inf.WriteLine(" AsciiSum: " + n_SumAscii.ToString());
				n_SumAscii = 0;
			}
			n_TotalRowCount = n_RowAsciiSums/ds_Agent.Tables[0].Rows.Count;
			//sw_Inf.WriteLine("---TotalRowCount: " + n_TotalRowCount.ToString());
			return n_TotalRowCount;
		}
		private bool UpdateDBINF()
		{
			//connectionString =
			ARYSRET_Conn = new SqlConnection((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("WALLSET.ConnectionString").GetValue(0));
			StringBuilder sb_Query = new StringBuilder(string.Empty);
			sb_Query.Append("INSERT INTO [ARYSRETINF]([BATCH_NO], [BATCH_DATE], [BATCH_SIZE], [BATCH_TOTAL], [BATCH_KEY]) ");
			sb_Query.Append("VALUES( ");
			sb_Query.Append(GetMaxBatchNumber().ToString() + ", ");

			DateTimeFormatInfo dt_Temp = new DateTimeFormatInfo();
			dt_Temp.ShortDatePattern = "dd/MM/yyyy";
			DateTime dt_CDate = DateTime.Parse(DateTime.Now.ToShortDateString(), CultureInfo.CreateSpecificCulture("fr-FR").DateTimeFormat);

			sb_Query.Append("'" + dt_CDate.ToString("dd/MM/yyyy") + "', ");
			sb_Query.Append(n_BATCH_SIZE.ToString() + ", ");
			sb_Query.Append(n_BATCH_TOTAL.ToString() + ", ");
			sb_Query.Append(n_BATCH_KEY.ToString() + ") ");
			SqlCommand cmd_Inf = new SqlCommand(sb_Query.ToString(), ARYSRET_Conn);
			int n_Result = 0;
			try
			{
				cmd_Inf.Connection.Open();
				n_Result = cmd_Inf.ExecuteNonQuery();
			}
			catch(SqlException ex)
			{
				if (ex.Number == 547)
				{
					cmd_Inf.Connection.Close();
					MessageBox.Show(ex.Message);
				}
				else
				{
					cmd_Inf.Connection.Close();
					MessageBox.Show(ex.Message);
				}
			}
			cmd_Inf.Connection.Close();
			if(n_Result>0)
				return true;
			else
				return false;
		}
	
		private DataSet GetAgentData()
		{
			//string connectionString = string.Empty;
			//connectionString =
			SqlConnection ARYFL_Conn = new SqlConnection((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("WALLSET.ConnectionString").GetValue(0));
			string strQuery = string.Empty;
			strQuery =  "SELECT td.PayInDateTime AS TransactionDate, td.TransactionNumber, '999999' AS SRCode, SUBSTRING(bnkl.ExternalCode, 1, 6) AS BankCode, " +
				"SUBSTRING(bnkl.ExternalCode, 8, 3) AS BranchCode, td.PayOutAmount, td.AgentExchangeRate AS ExchangeRate, 12 AS AfexCharges, " +
				"td.PayOutAmount / td.AgentExchangeRate AS PayInAmount, " +
				"CASE WHEN td.PaymentMode = 'DraftToBank' THEN 'BD' WHEN td.PaymentMode = 'DraftToHome' THEN 'SD' END AS PaymentMode, " +
				"cl.FirstName + ' ' + cl.LastName AS RemitterFullName, NULL AS POBox, NULL AS City, cl.Address AS RemitterAddress, cl.Email AS RemitterEmail, " +
				"cl.IDType, cl.IDDetails + ', ' + CAST(cl.IDExpirationDate AS char(10)) AS IDDetails, cl.Telephone, '66' AS NationalityCode, '01' AS CBPurpose, " +
				"bl.FirstName + ' ' + bl.LastName AS BeneficiaryName, bbl.AccountNumber AS AccountNumber, bbl.Address AS BankAddress, " +
				"CASE WHEN td.PaymentMode = 'DraftToBank' THEN 'The Manager ' WHEN td.PaymentMode = 'DraftToHome' THEN bl.FirstName END AS AddresseeName, " +
				"CASE WHEN td.PaymentMode = 'DraftToBank' THEN SubString(bbl.Name, 1, 40) ELSE SubString(bl.Address, 1, 40) END AS AddresseeDetails1, " +
				"CASE WHEN td.PaymentMode = 'DraftToBank' THEN SubString(bbl.BranchName, 1, 40) ELSE SubString(bl.Address, 41, 80) END AS AddresseeDetails2, " +
				"CASE WHEN td.PaymentMode = 'DraftToBank' THEN SubString(bbl.Address, 1, 40) ELSE SubString(bl.Address, 81, 120) END AS AddresseeDetails3, " +
				"CASE WHEN td.PaymentMode = 'DraftToBank' THEN SubString(bbl.Address, 41, 80) ELSE SubString(bl.Address, 121, 160) END AS AddresseeDetails4, " +
				"CASE WHEN td.PaymentMode = 'DraftToBank' THEN bbl.ZipCode ELSE SubString(bl.Address, 71, 105) END AS AddresseeDetails5, td.Status, " +
				"td.AssociatedBankId " +
				"FROM dbo.TransactionDetails td INNER JOIN " +
				"dbo.CurrencyList pincl ON td.PayInCurrencyId = pincl.Id INNER JOIN " +
				"dbo.CurrencyList poutcl ON td.PayOutCurrencyId = poutcl.Id INNER JOIN " +
				"dbo.CustomerList cl ON td.CustomerId = cl.Id INNER JOIN " +
				"dbo.CustomerList bl ON td.BeneficeryId = bl.Id LEFT OUTER JOIN	" +
				"dbo.BeneficeryBankList bbl ON td.BeneficeryBankId = bbl.Id INNER JOIN " +
				"dbo.BankList bnkl ON td.AssociatedBankId = bnkl.Id INNER JOIN " +
				"dbo.PaymentModeList pml ON td.PaymentMode = pml.Value " +
				"WHERE (td.AssociatedBankId IN " +
				"(SELECT Id FROM BankList WHERE AccountId = @AccountID)) and  td.Status LIKE 'unPaid'" +
				"ORDER BY td.VoucherNumber";
			// Call ExecuteDataset static method of SqlHelper class that returns a DataSet
			// We pass in database connection string, command type, stored procedure name and categoryID SqlParameter
			DataSet ds_Dat = SqlHelper.ExecuteDataset(ARYFL_Conn, CommandType.Text, strQuery, new SqlParameter("@AccountID", "43ABA5D3-66B0-41DD-9922-7CF4F3F87C02"));
			return ds_Dat;
		}
	
		public int GetMaxBatchNumber()
		{
			DataSet ds_BNumb = new DataSet("ARYSRETINF");
			ARYSRET_Conn = new SqlConnection((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("WALLSET.ConnectionString").GetValue(0));
			string str_Query = "Select max(BATCH_NO) As BATCH_NO from ARYSRETINF";
			SqlCommand cmd_Select = new SqlCommand(str_Query, ARYSRET_Conn);
			cmd_Select.CommandTimeout = 20;
			SqlDataAdapter da_BNumb = new SqlDataAdapter(str_Query,ARYSRET_Conn);
			da_BNumb.SelectCommand = ARYSRET_Conn.CreateCommand();
			da_BNumb.SelectCommand.CommandText = str_Query;
			da_BNumb.Fill(ds_BNumb,"ARYSRETINF");
			if(ds_BNumb.Tables["ARYSRETINF"].Rows[0]["BATCH_NO"] != DBNull.Value)
				return Convert.ToInt32(ds_BNumb.Tables["ARYSRETINF"].Rows[0]["BATCH_NO"].ToString())+1;
			else
				return 1;
		}
		private decimal GetBatchTotal(DataTable dt_Param)
		{
			decimal n_Result = 0;
			for (int i = 0; i < dt_Param.Rows.Count; i++)
			{
				if(dt_Param.Rows[i]["PayInAmount"]!=DBNull.Value)
				{n_Result += Convert.ToDecimal(dt_Param.Rows[i]["PayInAmount"].ToString());}
			}
			return n_Result;
		}
	}
}
