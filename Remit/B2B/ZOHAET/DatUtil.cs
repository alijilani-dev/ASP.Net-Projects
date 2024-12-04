#region Namespaces.
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.ApplicationBlocks.Data;
using System.Windows.Forms;

#endregion Namespaces.
namespace ZOHAET
{
	/// <summary>
	/// Summary description for DatTool.
	/// </summary>
	public class DatUtil
	{
		DataSet ds_Dat;
		SqlConnection ARYSRET_Conn;
		public DatUtil()
		{
			StringBuilder sr_Dat = new StringBuilder();
			DataSet ds_Agent = GetAgentData();
			String strPathBase = (String) System.Configuration.ConfigurationSettings.AppSettings.GetValues("fswZohaET.Path").GetValue(0);
			String strPath1 = strPathBase + @"\ENV00000UK005" + DateTime.Now.Day.ToString().PadLeft(2,'0') + DateTime.Now.Month.ToString().PadLeft(2,'0') + DateTime.Now.Hour.ToString().PadLeft(2,'0') + DateTime.Now.Minute.ToString().PadLeft(2,'0') + ".txt";
			FileInfo fi_Dat = new FileInfo(strPath1);
			
			if(ds_Agent.Tables[0].Rows.Count !=0)
			{
				if(!fi_Dat.Exists)
				{
					StreamWriter sw_Dat = fi_Dat.CreateText();
					//for(int i=0; i<ds_Agent.Tables[0].Rows.Count; i++)

					int counter = 4;
					if(ds_Agent.Tables[0].Rows.Count<4)
						counter = ds_Agent.Tables[0].Rows.Count;
					for(int i=0; i<counter; i++)
					{
						#region File Content.
						sr_Dat.Append(TrimtoSize(10, GetMaxBatchNumber().ToString().PadLeft(10,' '),'L',' '));										//
						sr_Dat.Append(TrimtoSize(10, ds_Agent.Tables[0].Rows[i]["Is_branch"].ToString().PadLeft(10,' '),'L',' '));					//Is_branch
						sr_Dat.Append(TrimtoSize(40, ds_Agent.Tables[0].Rows[i]["Is_name"].ToString().PadLeft(40,' '),'L',' '));					//Is_name
						sr_Dat.Append(TrimtoSize(60, ds_Agent.Tables[0].Rows[i]["Is_address"].ToString().PadLeft(60,' '),'L',' '));					//Is_address
						sr_Dat.Append(TrimtoSize(12, ds_Agent.Tables[0].Rows[i]["Id_tel1"].ToString().PadLeft(12,' '),'L',' '));					//Id_tel1
						sr_Dat.Append(TrimtoSize(12, ds_Agent.Tables[0].Rows[i]["Id_tel2"].ToString().PadLeft(12,' '),'L',' '));						//Id_tel2
						sr_Dat.Append(TrimtoSize(12, ds_Agent.Tables[0].Rows[i]["Id_zip"].ToString().PadLeft(12,' '),'L',' '));							//Id_zip
						sr_Dat.Append(TrimtoSize(10, ds_Agent.Tables[0].Rows[i]["Is_city"].ToString().PadLeft(10,' '),'L',' '));						//Is_city
						sr_Dat.Append(TrimtoSize(10, ds_Agent.Tables[0].Rows[i]["Is_state"].ToString().PadLeft(10,' '),'L',' '));						//Is_state
						sr_Dat.Append(TrimtoSize(10, ds_Agent.Tables[0].Rows[i]["Is_country"].ToString().PadLeft(10,' '),'L',' '));						//Is_country
						sr_Dat.Append(TrimtoSize(05, ds_Agent.Tables[0].Rows[i]["Is_tip_id"].ToString().PadLeft(5,' '),'L',' '));						//Is_tip_id
						sr_Dat.Append(TrimtoSize(15, ds_Agent.Tables[0].Rows[i]["Is_num_id"].ToString().PadLeft(15,' '),'L',' '));						//Is_num_id
						sr_Dat.Append(TrimtoSize(50,(ds_Agent.Tables[0].Rows[i]["Is_bitmap"].ToString() + GetMaxBatchNumber().ToString() + ".BMP").PadLeft(50,' '),'L',' '));//ls_bitmap
						sr_Dat.Append(TrimtoSize(15, GetMaxBatchNumber().ToString().PadLeft(15,' '),'L',' '));											//ld_receiver
						sr_Dat.Append(TrimtoSize(02, ds_Agent.Tables[0].Rows[i]["Is_payment"].ToString().PadLeft(2,' '),'L',' '));						//Is_payment
						sr_Dat.Append(TrimtoSize(02, ds_Agent.Tables[0].Rows[i]["Is_currency"].ToString().PadLeft(2,' '),'L',' '));						//Is_currency
						sr_Dat.Append(TrimtoSize(02, ds_Agent.Tables[0].Rows[i]["Is_flag"].ToString().PadLeft(2,' '),'L',' '));							//Is_flag
						string strdelims = "-";
						char[] delimiter = strdelims.ToCharArray();
						string[] split = null;
						split=ds_Agent.Tables[0].Rows[i]["Is_city1"].ToString().Split(delimiter,3);													//
						sr_Dat.Append(TrimtoSize(05, split[0].PadLeft(5,' '),'L',' '));																	//Is_city1
						sr_Dat.Append(TrimtoSize(05, split[1].PadLeft(5,' '),'L',' '));																	//ls_state1
						sr_Dat.Append(TrimtoSize(05, ds_Agent.Tables[0].Rows[i]["Is_country1"].ToString().PadLeft(5,' '),'L',' '));						//ls_country1
						sr_Dat.Append(TrimtoSize(10, split[2].PadLeft(10,' '),'L',' '));																//ls_branch_pag
						sr_Dat.Append(TrimtoSize(10, ds_Agent.Tables[0].Rows[i]["Is_cashier"].ToString().PadLeft(10,' '),'L',' '));						//Is_cashier
						sr_Dat.Append(TrimtoSize(40, ds_Agent.Tables[0].Rows[i]["Is_name_rec"].ToString().PadLeft(40,' '),'L',' '));					//Is_name_rec
						//sr_Dat.Append(TrimtoSize(60, ds_Agent.Tables[0].Rows[i]["Is_address_rec"].ToString().PadLeft(60,' '),'L',' '));					//Is_address_rec //before changing for \r\n replacement code.
						sr_Dat.Append(TrimtoSize(60, (ds_Agent.Tables[0].Rows[i]["Is_address_rec"].ToString()).Replace('\r',' ').Replace('\n',' ').PadLeft(60,' '),'L',' '));					//Is_address_rec
						sr_Dat.Append(TrimtoSize(12, ds_Agent.Tables[0].Rows[i]["Is_tel1_rec"].ToString().PadLeft(12,' '),'L',' '));					//Is_tel1_rec
						sr_Dat.Append(TrimtoSize(12, ds_Agent.Tables[0].Rows[i]["Is_tel2_rec"].ToString().PadLeft(12,' '),'L',' '));					//Is_tel2_rec
						sr_Dat.Append(TrimtoSize(07, ds_Agent.Tables[0].Rows[i]["Is_zip_rec"].ToString().PadLeft(7,' '),'L',' '));						//Is_zip_rec
						sr_Dat.Append(TrimtoSize(15, ds_Agent.Tables[0].Rows[i]["Id_amount"].ToString().PadLeft(15,' '),'L',' '));						//Id_amount
						sr_Dat.Append(TrimtoSize(15, ds_Agent.Tables[0].Rows[i]["Id_rate"].ToString().PadLeft(15,' '),'L',' '));						//Id_rate
						sr_Dat.Append(TrimtoSize(15, ds_Agent.Tables[0].Rows[i]["Id_telex"].ToString().PadLeft(15,' '),'L',' '));						//Id_telex
						sr_Dat.Append(TrimtoSize(15, ds_Agent.Tables[0].Rows[i]["Id_urgency"].ToString().PadLeft(15,' '),'L',' '));						//Id_urgency
						sr_Dat.Append(TrimtoSize(01, ds_Agent.Tables[0].Rows[i]["Is_recomendado"].ToString().PadLeft(1,' '),'L',' '));					//Is_recomendado
						sr_Dat.Append(TrimtoSize(16, ds_Agent.Tables[0].Rows[i]["Is_mod_pay"].ToString().PadRight(16,' '),'R',' '));					//Is_mod_pay
						sr_Dat.Append(TrimtoSize(30, ds_Agent.Tables[0].Rows[i]["Is_acc"].ToString().PadLeft(30,' '),'L',' '));							//Is_acc
						sr_Dat.Append(TrimtoSize(15, ds_Agent.Tables[0].Rows[i]["Id_exchange"].ToString().PadLeft(15,' '),'L',' '));					//Id_exchange
						sr_Dat.Append(TrimtoSize(15, ds_Agent.Tables[0].Rows[i]["Id_total"].ToString().PadLeft(15,' '),'L',' '));						//Id_total
						sr_Dat.Append(TrimtoSize(01, ds_Agent.Tables[0].Rows[i]["Is_modo_pago"].ToString().PadLeft(1,' '),'L',' '));					//Is_modo_pago
						sr_Dat.Append(TrimtoSize(15, ds_Agent.Tables[0].Rows[i]["Id_porc_comision"].ToString().PadLeft(15,' '),'L',' '));				//Id_porc_comision
						sr_Dat.Append(TrimtoSize(15, ds_Agent.Tables[0].Rows[i]["Id_total_pago"].ToString().PadLeft(15,' '),'L',' '));					//Id_total_pago
						sr_Dat.Append(TrimtoSize(200,ds_Agent.Tables[0].Rows[i]["Is_notes"].ToString().PadLeft(200,' '),'L',' '));						//Is_notes
						sr_Dat.Append(TrimtoSize(15, ds_Agent.Tables[0].Rows[i]["Id_exchange_com"].ToString().PadLeft(15,' '),'L',' '));				//Id_exchange_com
						sr_Dat.Append(TrimtoSize(15, ds_Agent.Tables[0].Rows[i]["Id_telex_com"].ToString().PadLeft(15,' '),'L',' '));					//Id_telex_com
						sr_Dat.Append(TrimtoSize(15, ds_Agent.Tables[0].Rows[i]["Id_ref"].ToString().PadLeft(15,' '),'L',' '));							//Id_ref
						sr_Dat.Append(TrimtoSize(35, ds_Agent.Tables[0].Rows[i]["Is_bank"].ToString().PadLeft(35,' '),'L',' '));						//Is_bank
						sr_Dat.Append(TrimtoSize(15, ds_Agent.Tables[0].Rows[i]["Id_total_modo_pago"].ToString().PadLeft(15,' '),'L',' '));				//Id_total_modo_pago
						sr_Dat.Append(TrimtoSize(15, ds_Agent.Tables[0].Rows[i]["Id_total_modo_pago_comp"].ToString().PadLeft(15,' '),'L',' '));		//Id_total_modo_pago_comp
						sr_Dat.Append(TrimtoSize(15, ds_Agent.Tables[0].Rows[i]["Is_sucursal_banco"].ToString().PadLeft(15,' '),'L',' '));				//Is_sucursal_banco
						sr_Dat.Append(TrimtoSize(15, ds_Agent.Tables[0].Rows[i]["Is_clave"].ToString().PadLeft(15,' '),'L',' '));						//Is_clave
						sr_Dat.Append(TrimtoSize(10, ds_Agent.Tables[0].Rows[i]["Id_birthday_sender"].ToString().PadLeft(10,' '),'L',' '));				//Id_birthday_sender
						sr_Dat.Append(TrimtoSize(192, ((String)("Zoha TN-" + ds_Agent.Tables[0].Rows[i]["TrNo"].ToString())).PadLeft(192,' '),'L',' '));//TrNo

						#endregion File Content.
						if( (UpdateDBZohaETtxt(ds_Agent.Tables[0],i)) && (CreditPayOutAgentAccount(ds_Agent.Tables[0],i)) )		// Also Performs Accounting Entries.
						{
							sw_Dat.WriteLine(sr_Dat);sr_Dat.Remove(0,sr_Dat.Length);
							UpdateStatus(ds_Agent.Tables[0],i);
						}
						else
						{
							//fi_Dat.Delete();
							MessageBox.Show("Problem parsing record number:(" + i.ToString() + "). Please upload manually.");
						}
					}
					sw_Dat.Flush();
					sw_Dat.Close();
				}
				//else{MessageBox.Show("File already exists.");}
			}
			//else{MessageBox.Show("No data to upload.");}
		}

		private DataSet GetAgentData()
		{
			//Is_Address: Speed Remit WorldWide FZCO, Dubai Airport Free Zone, Dubai, UAE.
			//C:\DOCUMENT\0027-584.BMP	
			ARYSRET_Conn = new SqlConnection((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("ZOHAET.ConnectionString").GetValue(0));
			string strQuery = string.Empty;
			strQuery = @"select	td.transactionnumber as Id_sender, 'UK005' as Is_branch, (cl.FirstName + ' ' + cl.LastName) as Is_name, 
	pl.name	as Is_address, 
	case when len(ltrim(cl.telephone)) > 1 then cl.telephone 
	     when len(ltrim(cl.mobile))	   > 1 then cl.mobile 
	     else ' ' 
	End 
	as Id_tel1, 
	'0' as Id_tel2, '0' as Id_zip, 
	'UK02' as Is_city, 'UK01' as Is_state, 
	'UK' as Is_country, 'NN' as Is_tip_id, 
	case when len(ltrim(cl.Iddetails)) > 0 then cl.Iddetails 
	     else ' ' 
	End 
	as Is_num_id, 
	'C:\DOCUMENT\UK005-' as Is_bitmap, 
	td.transactionnumber as Id_receiver, 'C' as Is_payment,

	-------------------------------------
	case when am.name like '%BTK%' then ' T' 
	     when am.name like '%INR%' then 'IR' 
	End
	-------------------------------------
	as Is_currency, 
	
	'I' as Is_flag, al.agentcode as Is_city1, 
	al.agentcode as Is_state1, 
	-------------------------------------
	case 	when am.name like '%BTK%' then 'BAN' 
	     	when am.name like '%INR%' then 'IND' 
	End
	-------------------------------------
	as Is_country1, al.agentcode as Is_branch_pag, 
	'ADM' as Is_cashier, rtrim(bl.firstname + ' ' + bl.lastname) as Is_name_rec, 

	-------------------------------------
	case 	when am.name like '%BTK%' then bl.address
		when am.name like '%INR%' then ( Substring(ll.name, 1, (charindex('-', ll.Name))-1)  + ', India')
	End
	-------------------------------------
	as Is_address_rec, 
	case 	when len(ltrim(bl.telephone)) > 1 then bl.telephone 
	     	when len(ltrim(bl.mobile))    > 1 then bl.mobile 
	     	else '-' 
	End 
	as Is_tel1_rec, 
	'0' as Is_tel2_rec, 
	'0' as Is_zip_rec,
--(td.payinamount * td.bankexchangerateforpayincurrency) as Id_amount, 
	--td.bankexchangerateforpayoutcurrency,
	(td.payoutamount / td.bankexchangerateforpayoutcurrency) as Id_amount, 
	td.bankexchangerateforpayoutcurrency as Id_rate, 
	'0' as Id_telex, '0' as Id_urgency, '0' as Is_recomendado, 'P' as Is_mod_pay, '0' as Is_acc, 
	'0' as Id_exchange, (td.payinamount * td.bankexchangerateforpayincurrency) as Id_total, 'N' as Is_modo_pago, 
	-------------------------------------
	case 	when am.name like '%BTK%' then '3' 
	     	when am.name like '%INR%' then '4.5' 
	End	
	as Id_porc_comision, 
	-------------------------------------
	td.payoutamount as Id_total_pago, ' ' as Is_notes, '0' as Id_exchange_com, '0' as Id_telex_com, '0' as Id_ref, ' ' as Is_bank, 
	'0' as Id_total_modo_pago, '0' as Id_total_modo_pago_comp, '0' as Is_sucursal_banco, '0' as Is_clave, ' ' as Id_birthday_sender,
	td.TransactionNumber as TrNo
from 	TransactionDetails td 
	INNER JOIN CustomerList cl on td.CustomerId = cl.Id 
	INNER JOIN CustomerList bl on td.beneficeryId = bl.Id 
	INNER JOIN AgentLocationList al on td.RecommendedPayOutAgentId = al.Id 
	INNER JOIN LocationList ll on al.LocationId = ll.Id 
	JOIN AgentMaster am On al.AgentAccountId = am.Id 
	JOIN PayInLocations pl On pl.Id = td.PayinagentlocationId
where 	am.name like 'zoha%' and td.status='UnPaid' and td.ExportStatus IS NULL Order By td.PayInDateTime ";
			#region Abandoned Query.
	/*strQuery = @"select	td.transactionnumber as Id_sender, 'UK005' as Is_branch, (cl.FirstName + ' ' + cl.LastName) as Is_name, 
	pl.name	as Is_address, 
	case when len(ltrim(cl.telephone)) > 1 then cl.telephone 
	     when len(ltrim(cl.mobile))	   > 1 then cl.mobile 
	     else ' ' 
	End 
	as Id_tel1, 
	'0' as Id_tel2, '0' as Id_zip, 
	'UK02' as Is_city, 'UK01' as Is_state, 
	'UK' as Is_country, 'NN' as Is_tip_id, 
	case when len(ltrim(cl.Iddetails)) > 0 then cl.Iddetails 
	     else ' ' 
	End 
	as Is_num_id, 
	'C:\DOCUMENT\UK005-' as Is_bitmap, 
	td.transactionnumber as Id_receiver, 'C' as Is_payment, 'IR' as Is_currency, 
	'I' as Is_flag, al.agentcode as Is_city1, 
	al.agentcode as Is_state1, 'IND' as Is_country1, al.agentcode as Is_branch_pag, 
	'ADM' as Is_cashier, rtrim(bl.firstname + ' ' + bl.lastname) as Is_name_rec, 
	(Substring(ll.name, 1, (charindex('-', ll.Name))-1)  + ', India')  as Is_address_rec, 
	case when len(ltrim(bl.telephone)) > 1 then bl.telephone 
	     when len(ltrim(bl.mobile))    > 1 then bl.mobile 
	     else '-' 
	End 
	as Is_tel1_rec, 
	'0' as Is_tel2_rec, 
	'0' as Is_zip_rec,
--(td.payinamount * td.bankexchangerateforpayincurrency) as Id_amount, 
	--td.bankexchangerateforpayoutcurrency,
	(td.payoutamount / td.bankexchangerateforpayoutcurrency) as Id_amount, 
	td.bankexchangerateforpayoutcurrency as Id_rate, 
	'0' as Id_telex, '0' as Id_urgency, '0' as Is_recomendado, 'P' as Is_mod_pay, '0' as Is_acc, 
	'0' as Id_exchange, (td.payinamount * td.bankexchangerateforpayincurrency) as Id_total, 'N' as Is_modo_pago, '5' as Id_porc_comision, 
	td.payoutamount as Id_total_pago, ' ' as Is_notes, '0' as Id_exchange_com, '0' as Id_telex_com, '0' as Id_ref, ' ' as Is_bank, 
	'0' as Id_total_modo_pago, '0' as Id_total_modo_pago_comp, '0' as Is_sucursal_banco, '0' as Is_clave, ' ' as Id_birthday_sender,
	td.TransactionNumber as TrNo
from 	TransactionDetails td 
	INNER JOIN CustomerList cl on td.CustomerId = cl.Id 
	INNER JOIN CustomerList bl on td.beneficeryId = bl.Id 
	INNER JOIN AgentLocationList al on td.RecommendedPayOutAgentId = al.Id 
	INNER JOIN LocationList ll on al.LocationId = ll.Id 
	JOIN AgentMaster am On al.AgentAccountId = am.Id 
	JOIN PayInLocations pl On pl.Id = td.PayinagentlocationId
where 	am.name like 'zoha%' and td.status='UnPaid' and td.ExportStatus IS NULL";*/
			#endregion Abandoned Query.
				ds_Dat = SqlHelper.ExecuteDataset(ARYSRET_Conn, CommandType.Text, strQuery);
				return ds_Dat;
		}

		private bool UpdateDBZohaETtxt(DataTable dt_params, int n_Row)
		{
			#region DB Contents..
			#region DB Content.
			
			/*ARYSRET_Conn = new SqlConnection((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("ZOHAET.ConnectionString").GetValue(0));;
			StringBuilder sb_Query = new StringBuilder(string.Empty);
			sb_Query.Append("INSERT INTO ZohaETtxt ([Id], [ld_sender], [ls_branch], [ls_name], [ls_address], [ld_tel1], [ld_tel2], [ld_zip], [ls_city], [ls_state], [ls_country], [ls_tip_id], [ls_num_id], [ls_bitmap], [ld_receiver], [ls_payment], [ls_currency], [ls_flag], [ls_city1], [ls_state1], [ls_country1], [ls_branch_pag], [ls_cashier], [ls_name_rec], [ls_address_rec], [ls_tel1_rec], [ls_tel2_rec], [ls_zip_rec], [ld_amount], [ld_rate], [ld_telex], [ld_urgency], [ls_recomendado], [ls_mod_pay], [ls_acc], [ld_exchange], [ld_total], [ls_modo_pago], [ld_porc_comision], [ld_total_pago], [ls_notes], [ld_exchange_com], [ld_telex_com], [ld_ref], [ls_bank], [ld_total_modo_pago], [ld_total_modo_pago_comp], [ls_sucursal_banco], [ls_clave], [ld_birthday_sender], [TransactionNumber] ) ");
			sb_Query.Append(" VALUES( ");
			
			sb_Query.Append(GetMaxBatchNumber().ToString()														+ ", ");//Id
			sb_Query.Append("'" + GetMaxBatchNumber().ToString()												+ "', ");//Id_sender
			//sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_sender"].ToString()								+ "', ");//D_DD_DOC_DAT
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_branch"].ToString().PadLeft(10,' ')					+ "', ");//Is_branch
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_name"].ToString().PadLeft(40,' ')					+ "', ");//Is_name
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_address"].ToString().PadRight(60,' ')				+ "', ");//Is_address
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_tel1"].ToString().PadLeft(12,' ')					+ "', ");//Id_tel1
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_tel2"].ToString().PadLeft(12,' ')					+ "', ");//Id_tel2
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_zip"].ToString().PadLeft(12,' ')					+ "', ");//Id_zip
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_city"].ToString().PadLeft(10,' ')					+ "', ");//Is_city
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_state"].ToString().PadLeft(10,' ')					+ "', ");//Is_state
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_country"].ToString().PadLeft(10,' ')				+ "', ");//Is_country
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_tip_id"].ToString().PadLeft(5,' ')					+ "', ");//Is_tip_id
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_num_id"].ToString().PadLeft(15,' ')					+ "', ");//Is_num_id*
			sb_Query.Append("'" + (dt_params.Rows[n_Row]["Is_bitmap"].ToString() + GetMaxBatchNumber().ToString() + ".BMP").PadLeft(50,' ')+ "', ");//Is_bitmap
			//sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_bitmap"].ToString().PadLeft(50,' ')				+ "', ");//V_SEN_ADD2*
			//sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_receiver"].ToString().PadLeft(15,' ')				+ "', ");//V_SEN_ADD3*
			sb_Query.Append("'" + GetMaxBatchNumber().ToString().PadLeft(15,' ')								+ "', ");//ld_receiver
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_payment"].ToString().PadLeft(2,' ')					+ "', ");//Is_payment*
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_currency"].ToString().PadLeft(2,' ')				+ "', ");//Is_currency
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_flag"].ToString().PadLeft(2,' ')					+ "', ");//Is_flag
			string strdelims = "-";
			char[] delimiter = strdelims.ToCharArray();
			string[] split = null;
			split= dt_params.Rows[n_Row]["Is_city1"].ToString().Split(delimiter,3);
			sb_Query.Append("'" + split[0].PadLeft(5,' ')														+ "', ");//Is_city1
			sb_Query.Append("'" + split[1].PadLeft(5,' ')														+ "', ");//Is_state1
			//sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_state1"]				+ "', ");//V_SEN_PHO_NO
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_country1"].ToString().PadLeft(5,' ')				+ "', ");//Is_country1
			sb_Query.Append("'" + split[2].PadLeft(10,' ')														+ "', ");//Is_branch_pag
			//sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_branch_pag"]			+ "', ");//CB_PURP
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_cashier"].ToString().PadLeft(10,' ')				+ "', ");//Is_cashier
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_name_rec"].ToString().PadLeft(40,' ')				+ "', ");//Is_name_rec
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_address_rec"].ToString().PadLeft(60,' ')			+ "', ");//Is_address_rec
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_tel1_rec"].ToString().PadLeft(12,' ')				+ "', ");//Is_tel1_rec
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_tel2_rec"].ToString().PadLeft(12,' ')				+ "', ");//Is_tel2_rec
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_zip_rec"].ToString().PadLeft(7,' ')					+ "', ");//Is_zip_rec
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_amount"].ToString().PadLeft(15,' ')					+ "', ");//Id_amount
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_rate"].ToString().PadLeft(15,' ')					+ "', ");//Id_rate
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_telex"].ToString().PadLeft(15,' ')					+ "', ");//Id_telex
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_urgency"].ToString().PadLeft(15,' ')				+ "', ");//Id_urgency
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_recomendado"].ToString().PadLeft(1,' ')				+ "', ");//Is_recomendado
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_mod_pay"].ToString().PadRight(16,' ')				+ "', ");//Is_mod_pay
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_acc"].ToString().PadLeft(30,' ')					+ "', ");//Is_acc
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_exchange"].ToString().PadLeft(15,' ')				+ "', ");//Id_exchange
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_total"].ToString().PadLeft(15,' ')					+ "', ");//Id_total
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_modo_pago"].ToString().PadLeft(1,' ')				+ "', ");//Is_modo_pago
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_porc_comision"].ToString().PadLeft(15,' ')			+ "', ");//Id_porc_comision
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_total_pago"].ToString().PadLeft(15,' ')				+ "', ");//Id_total_pago
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_notes"].ToString().PadLeft(200,' ')					+ "', ");//Is_notes
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_exchange_com"].ToString().PadLeft(15,' ')			+ "', ");//Id_exchange_com
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_telex_com"].ToString().PadLeft(15,' ')				+ "', ");//Id_telex_com
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_ref"].ToString().PadLeft(15,' ')					+ "', ");//Id_ref
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_bank"].ToString().PadLeft(35,' ')					+ "', ");//Is_bank
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_total_modo_pago"].ToString().PadLeft(15,' ')		+ "', ");//Id_total_modo_pago
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_total_modo_pago_comp"].ToString().PadLeft(15,' ')	+ "', ");//Id_total_modo_pago_comp
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_sucursal_banco"].ToString().PadLeft(15,' ')			+ "', ");//Is_sucursal_banco
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_clave"].ToString().PadLeft(15,' ')					+ "', ");//Is_clave
			sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_birthday_sender"].ToString().PadLeft(10,' ')		+ "', ");//Id_birthday_sender
			//sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_sender"].ToString().PadLeft(15,' ')				+ "', ");//
			sb_Query.Append("'" + ((String)("Zoha TN-" + dt_params.Rows[n_Row]["TrNo"].ToString())).PadLeft(192,' ')+ "' ) ");//TransactionNumber
			*/
			#endregion DB Content.
			ARYSRET_Conn = new SqlConnection((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("ZOHAET.ConnectionString").GetValue(0));;
			StringBuilder sb_Query = new StringBuilder(string.Empty);
			sb_Query.Append("INSERT INTO ZohaETtxt ([Id], [ld_sender], [ls_branch], [ls_name], [ls_address], [ld_tel1], [ld_tel2], [ld_zip], [ls_city], [ls_state], [ls_country], [ls_tip_id], [ls_num_id], [ls_bitmap], [ld_receiver], [ls_payment], [ls_currency], [ls_flag], [ls_city1], [ls_state1], [ls_country1], [ls_branch_pag], [ls_cashier], [ls_name_rec], [ls_address_rec], [ls_tel1_rec], [ls_tel2_rec], [ls_zip_rec], [ld_amount], [ld_rate], [ld_telex], [ld_urgency], [ls_recomendado], [ls_mod_pay], [ls_acc], [ld_exchange], [ld_total], [ls_modo_pago], [ld_porc_comision], [ld_total_pago], [ls_notes], [ld_exchange_com], [ld_telex_com], [ld_ref], [ls_bank], [ld_total_modo_pago], [ld_total_modo_pago_comp], [ls_sucursal_banco], [ls_clave], [ld_birthday_sender], [TransactionNumber] ) ");
			sb_Query.Append(" VALUES( ");
			
			sb_Query.Append(GetMaxBatchNumber().ToString()														+ ", ");//Id
			sb_Query.Append("'" + GetMaxBatchNumber().ToString()												+ "', ");//Id_sender
			//sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_sender"].ToString()								+ "', ");//D_DD_DOC_DAT
			sb_Query.Append("'" + TrimtoSize(10, dt_params.Rows[n_Row]["Is_branch"].ToString().PadLeft(10,' '),'L',' ')					+ "', ");//Is_branch
			sb_Query.Append("'" + TrimtoSize(40, dt_params.Rows[n_Row]["Is_name"].ToString().PadLeft(40,' '),'L',' ')					+ "', ");//Is_name
			sb_Query.Append("'" + TrimtoSize(60, dt_params.Rows[n_Row]["Is_address"].ToString().PadRight(60,' '), 'R',' ')				+ "', ");//Is_address
			sb_Query.Append("'" + TrimtoSize(12, dt_params.Rows[n_Row]["Id_tel1"].ToString().PadLeft(12,' '),'L',' ')					+ "', ");//Id_tel1
			sb_Query.Append("'" + TrimtoSize(12, dt_params.Rows[n_Row]["Id_tel2"].ToString().PadLeft(12,' '),'L',' ')					+ "', ");//Id_tel2
			sb_Query.Append("'" + TrimtoSize(12, dt_params.Rows[n_Row]["Id_zip"].ToString().PadLeft(12,' '),'L',' ')					+ "', ");//Id_zip
			sb_Query.Append("'" + TrimtoSize(10, dt_params.Rows[n_Row]["Is_city"].ToString().PadLeft(10,' '),'L',' ')					+ "', ");//Is_city
			sb_Query.Append("'" + TrimtoSize(10, dt_params.Rows[n_Row]["Is_state"].ToString().PadLeft(10,' '),'L',' ')					+ "', ");//Is_state
			sb_Query.Append("'" + TrimtoSize(10, dt_params.Rows[n_Row]["Is_country"].ToString().PadLeft(10,' '),'L',' ')				+ "', ");//Is_country
			sb_Query.Append("'" + TrimtoSize(05, dt_params.Rows[n_Row]["Is_tip_id"].ToString().PadLeft(5,' '),'L',' ')					+ "', ");//Is_tip_id
			sb_Query.Append("'" + TrimtoSize(15, dt_params.Rows[n_Row]["Is_num_id"].ToString().PadLeft(15,' '),'L',' ')					+ "', ");//Is_num_id*
			sb_Query.Append("'" + TrimtoSize(50,(dt_params.Rows[n_Row]["Is_bitmap"].ToString() + GetMaxBatchNumber().ToString() + ".BMP").PadLeft(50,' '),'L',' ')+ "', ");//Is_bitmap
			//sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_bitmap"].ToString().PadLeft(50,' ')				+ "', ");//V_SEN_ADD2*
			//sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_receiver"].ToString().PadLeft(15,' ')				+ "', ");//V_SEN_ADD3*
			sb_Query.Append("'" + TrimtoSize(15, GetMaxBatchNumber().ToString().PadLeft(15,' '),'L',' ')								+ "', ");//ld_receiver
			sb_Query.Append("'" + TrimtoSize(02, dt_params.Rows[n_Row]["Is_payment"].ToString().PadLeft(2,' '),'L',' ')					+ "', ");//Is_payment*
			sb_Query.Append("'" + TrimtoSize(02, dt_params.Rows[n_Row]["Is_currency"].ToString().PadLeft(2,' '),'L',' ')				+ "', ");//Is_currency
			sb_Query.Append("'" + TrimtoSize(02, dt_params.Rows[n_Row]["Is_flag"].ToString().PadLeft(2,' '),'L',' ')					+ "', ");//Is_flag
			string strdelims = "-";
			char[] delimiter = strdelims.ToCharArray();
			string[] split = null;
			split= dt_params.Rows[n_Row]["Is_city1"].ToString().Split(delimiter,3);
			sb_Query.Append("'" + TrimtoSize(05, split[0].PadLeft(5,' '),'L',' ')														+ "', ");//Is_city1
			sb_Query.Append("'" + TrimtoSize(05, split[1].PadLeft(5,' '),'L',' ')														+ "', ");//Is_state1
			//sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_state1"]				+ "', ");//V_SEN_PHO_NO
			sb_Query.Append("'" + TrimtoSize(05, dt_params.Rows[n_Row]["Is_country1"].ToString().PadLeft(5,' '),'L',' ')				+ "', ");//Is_country1
			sb_Query.Append("'" + TrimtoSize(10, split[2].PadLeft(10,' '),'L',' ')														+ "', ");//Is_branch_pag
			//sb_Query.Append("'" + dt_params.Rows[n_Row]["Is_branch_pag"]			+ "', ");//CB_PURP
			sb_Query.Append("'" + TrimtoSize(10, dt_params.Rows[n_Row]["Is_cashier"].ToString().PadLeft(10,' '),'L',' ')				+ "', ");//Is_cashier
			sb_Query.Append("'" + TrimtoSize(40, dt_params.Rows[n_Row]["Is_name_rec"].ToString().PadLeft(40,' '),'L',' ')				+ "', ");//Is_name_rec
			sb_Query.Append("'" + TrimtoSize(60, dt_params.Rows[n_Row]["Is_address_rec"].ToString().PadLeft(60,' '),'L',' ')			+ "', ");//Is_address_rec
			sb_Query.Append("'" + TrimtoSize(12, dt_params.Rows[n_Row]["Is_tel1_rec"].ToString().PadLeft(12,' '),'L',' ')				+ "', ");//Is_tel1_rec
			sb_Query.Append("'" + TrimtoSize(12, dt_params.Rows[n_Row]["Is_tel2_rec"].ToString().PadLeft(12,' '),'L',' ')				+ "', ");//Is_tel2_rec
			sb_Query.Append("'" + TrimtoSize(07, dt_params.Rows[n_Row]["Is_zip_rec"].ToString().PadLeft(7,' '),'L',' ')					+ "', ");//Is_zip_rec
			sb_Query.Append("'" + TrimtoSize(15, dt_params.Rows[n_Row]["Id_amount"].ToString().PadLeft(15,' '),'L',' ')					+ "', ");//Id_amount
			sb_Query.Append("'" + TrimtoSize(15, dt_params.Rows[n_Row]["Id_rate"].ToString().PadLeft(15,' '),'L',' ')					+ "', ");//Id_rate
			sb_Query.Append("'" + TrimtoSize(15, dt_params.Rows[n_Row]["Id_telex"].ToString().PadLeft(15,' '),'L',' ')					+ "', ");//Id_telex
			sb_Query.Append("'" + TrimtoSize(15, dt_params.Rows[n_Row]["Id_urgency"].ToString().PadLeft(15,' '),'L',' ')				+ "', ");//Id_urgency
			sb_Query.Append("'" + TrimtoSize(01, dt_params.Rows[n_Row]["Is_recomendado"].ToString().PadLeft(1,' '),'L',' ')				+ "', ");//Is_recomendado
			sb_Query.Append("'" + TrimtoSize(16, dt_params.Rows[n_Row]["Is_mod_pay"].ToString().PadRight(16,' '),'R',' ')				+ "', ");//Is_mod_pay
			sb_Query.Append("'" + TrimtoSize(30, dt_params.Rows[n_Row]["Is_acc"].ToString().PadLeft(30,' '),'L',' ')					+ "', ");//Is_acc
			sb_Query.Append("'" + TrimtoSize(15, dt_params.Rows[n_Row]["Id_exchange"].ToString().PadLeft(15,' '),'L',' ')				+ "', ");//Id_exchange
			sb_Query.Append("'" + TrimtoSize(15, dt_params.Rows[n_Row]["Id_total"].ToString().PadLeft(15,' '),'L',' ')					+ "', ");//Id_total
			sb_Query.Append("'" + TrimtoSize(01, dt_params.Rows[n_Row]["Is_modo_pago"].ToString().PadLeft(1,' '),'L',' ')				+ "', ");//Is_modo_pago
			sb_Query.Append("'" + TrimtoSize(15, dt_params.Rows[n_Row]["Id_porc_comision"].ToString().PadLeft(15,' '),'L',' ')			+ "', ");//Id_porc_comision
			sb_Query.Append("'" + TrimtoSize(15, dt_params.Rows[n_Row]["Id_total_pago"].ToString().PadLeft(15,' '),'L',' ')				+ "', ");//Id_total_pago
			sb_Query.Append("'" + TrimtoSize(200,dt_params.Rows[n_Row]["Is_notes"].ToString().PadLeft(200,' '),'L',' ')					+ "', ");//Is_notes
			sb_Query.Append("'" + TrimtoSize(15, dt_params.Rows[n_Row]["Id_exchange_com"].ToString().PadLeft(15,' '),'L',' ')			+ "', ");//Id_exchange_com
			sb_Query.Append("'" + TrimtoSize(15, dt_params.Rows[n_Row]["Id_telex_com"].ToString().PadLeft(15,' '),'L',' ')				+ "', ");//Id_telex_com
			sb_Query.Append("'" + TrimtoSize(15, dt_params.Rows[n_Row]["Id_ref"].ToString().PadLeft(15,' '),'L',' ')					+ "', ");//Id_ref
			sb_Query.Append("'" + TrimtoSize(35, dt_params.Rows[n_Row]["Is_bank"].ToString().PadLeft(35,' '),'L',' ')					+ "', ");//Is_bank
			sb_Query.Append("'" + TrimtoSize(15, dt_params.Rows[n_Row]["Id_total_modo_pago"].ToString().PadLeft(15,' '),'L',' ')		+ "', ");//Id_total_modo_pago
			sb_Query.Append("'" + TrimtoSize(15, dt_params.Rows[n_Row]["Id_total_modo_pago_comp"].ToString().PadLeft(15,' '),'L',' ')	+ "', ");//Id_total_modo_pago_comp
			sb_Query.Append("'" + TrimtoSize(15, dt_params.Rows[n_Row]["Is_sucursal_banco"].ToString().PadLeft(15,' '),'L',' ')			+ "', ");//Is_sucursal_banco
			sb_Query.Append("'" + TrimtoSize(15, dt_params.Rows[n_Row]["Is_clave"].ToString().PadLeft(15,' '),'L',' ')					+ "', ");//Is_clave
			sb_Query.Append("'" + TrimtoSize(10, dt_params.Rows[n_Row]["Id_birthday_sender"].ToString().PadLeft(10,' '),'L',' ')			+ "', ");//Id_birthday_sender
			//sb_Query.Append("'" + dt_params.Rows[n_Row]["Id_sender"].ToString().PadLeft(15,' ')				+ "', ");//
			sb_Query.Append("'" + TrimtoSize(192,((String)("Zoha TN-" + dt_params.Rows[n_Row]["TrNo"].ToString())).PadLeft(192,' '),'L',' ')+ "' ) ");//TransactionNumber
			#endregion DB Contents..
			SqlCommand cmd_Dat = new SqlCommand(sb_Query.ToString(), ARYSRET_Conn);
			int n_Result = 0;
			try
			{
				cmd_Dat.Connection.Open();
				n_Result = cmd_Dat.ExecuteNonQuery();
			}
			catch(SqlException ex)
			{
				if (ex.Number == 547)
				{
					cmd_Dat.Connection.Close();
					MessageBox.Show(ex.Message,"Zoha Electronic Transfer");
				}
				else
				{
					cmd_Dat.Connection.Close();
					MessageBox.Show(ex.Message,"Zoha Electronic Transfer");
				}
			}
			cmd_Dat.Connection.Close();
			if(n_Result>0)
				return true;
			else
				return false;
		}

		private bool CreditPayOutAgentAccount(DataTable dt_params, int n_Row)
		{
			string strTranNo = dt_params.Rows[n_Row]["Id_sender"].ToString();
			string strTranID = GetTranId(strTranNo.Trim());
			Guid transId = new Guid(strTranID.ToString());
			//Guid userId =  new Guid(GetZohaETId());	// New User created for Zoha in specific.
			//Guid agentAccountId = GetAgentAccountForUser(userId);
			string srv = GetAgentAccountForService(dt_params.Rows[n_Row]["Is_country1"].ToString());
			Guid agentAccountId = new Guid(srv);
			String strCon = System.Configuration.ConfigurationSettings.AppSettings.GetValues("ZOHAET.ConnectionString").GetValue(0).ToString();
			Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails aoTrans
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails(strCon);
			aoTrans.Refresh(transId);
			Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList aoPaymentMode
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList(strCon);
			aoPaymentMode.Refresh(aoTrans.Col_PaymentMode.Value);

			System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon);
			con.Open();
			System.Data.SqlClient.SqlTransaction trans = con.BeginTransaction();
			try 
			{
				DataSet ds = SqlHelper.ExecuteDataset(trans,
					CommandType.Text,
					"Select * From TransitionAccountDetails Where TransactionId='"+ transId.ToString() +"'");
				DataRow dr = ds.Tables[0].Rows[0];
				SqlHelper.ExecuteNonQuery(trans,
					CommandType.Text,
					"Insert Into AgentAccountDetails			Values (newid(), getdate() ,NULL, '" + agentAccountId.ToString() + "','" + transId.ToString() + "'," + dr["CreditLC"].ToString() +","+ dr["CreditUSD"].ToString() +",0,0)");
				SqlHelper.ExecuteNonQuery(trans,
					CommandType.Text,
					"Insert Into AgentCommissionIncomeAccount	Values (newid(), getdate() ,NULL, '" + agentAccountId.ToString() + "','" + transId.ToString() + "','" + dr["CommissionCreditLC"].ToString() +"','"+ dr["CommissionCreditUSD"].ToString() +"',0,0)");
			}
			catch(Exception ex)
			{
				trans.Rollback();
				MessageBox.Show("Error: " + ex.Message,"Zoha Electronic Transfer");
				return false;
			}
			trans.Commit();
			return true;
		}
		
		private string GetTranId(String strTranNumber)
		{
			String strTransQuery = "Select Id from TransactionDetails where TransactionNumber = '" + strTranNumber + "'";
			SqlConnection ARYSRET_Conn = new SqlConnection((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("ZOHAET.ConnectionString").GetValue(0));;
			SqlCommand cmd_Sel = new SqlCommand(strTransQuery, ARYSRET_Conn);
			SqlDataAdapter daZohaETInput = new SqlDataAdapter();
			DataSet dsZohaETInput = new DataSet();
			daZohaETInput.SelectCommand = cmd_Sel;

			int n_Result = 0;
			try
			{
				cmd_Sel.Connection.Open();
				n_Result = daZohaETInput.Fill(dsZohaETInput);
			}
			catch(SqlException ex)
			{
				if (ex.Number == 547)
				{
					MessageBox.Show(ex.Message);
				}
				else
				{
					MessageBox.Show(ex.Message);
				}
			}
			finally
			{
				cmd_Sel.Connection.Close();
			}

			if(n_Result>0)
				return dsZohaETInput.Tables[0].Rows[0]["Id"].ToString();
			else
				return string.Empty;
		}
		
		public int GetMaxBatchNumber()
		{
			DataSet ds_BNumb = new DataSet("ZohaETtxt");
			ARYSRET_Conn = new SqlConnection((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("ZOHAET.ConnectionString").GetValue(0));
			string str_Query = "Select max(Id) As Id from ZohaETtxt";
			SqlCommand cmd_Select = new SqlCommand(str_Query, ARYSRET_Conn);
			cmd_Select.CommandTimeout = 20;
			SqlDataAdapter da_BNumb = new SqlDataAdapter(str_Query,ARYSRET_Conn);
			da_BNumb.SelectCommand = ARYSRET_Conn.CreateCommand();
			da_BNumb.SelectCommand.CommandText = str_Query;
			da_BNumb.Fill(ds_BNumb,"ZohaETtxt");
			if(ds_BNumb.Tables["ZohaETtxt"].Rows[0]["Id"] != DBNull.Value)
				return Convert.ToInt32(ds_BNumb.Tables["ZohaETtxt"].Rows[0]["Id"].ToString())+1;
			else
				return 1;
		}

		private bool UpdateStatus(DataTable dt_params, int n_Row)
		{
			ARYSRET_Conn = new SqlConnection((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("ZOHAET.ConnectionString").GetValue(0));
			StringBuilder sb_Query = new StringBuilder(string.Empty);
			//sb_Query.Append("Update TransactionDetails set ExportStatus = 'E' where transactionnumber = '" + dt_params.Rows[n_Row]["Id_sender"].ToString().Trim() + "'" );
			sb_Query.Append("Update TransactionDetails set ExportStatus = 'E', Status = 'Processed' where transactionnumber = '" + dt_params.Rows[n_Row]["Id_sender"].ToString().Trim() + "'" );
			SqlCommand cmd_Dat = new SqlCommand(sb_Query.ToString(), ARYSRET_Conn);
			int n_Result = 0;
			try
			{
				cmd_Dat.Connection.Open();
				n_Result = cmd_Dat.ExecuteNonQuery();
			}
			catch(SqlException ex)
			{
				if (ex.Number == 547)
				{
					cmd_Dat.Connection.Close();
					MessageBox.Show(ex.Message);
				}
				else
				{
					cmd_Dat.Connection.Close();
					MessageBox.Show(ex.Message);
				}
			}
			finally
			{
				cmd_Dat.Connection.Close();
			}
			if(n_Result>0)
				return true;
			else
				return false;
		}

		public Guid GetAgentAccountForUser(Guid userId)
		{
			Guid agentAccountId = Guid.Empty;
			String strCon = System.Configuration.ConfigurationSettings.AppSettings.GetValues("ZOHAET.ConnectionString").GetValue(0).ToString();
			Evernet.MoneyExchange.AbstractClasses.Abstract_UserList aoUserList = new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(strCon);
			try
			{
				aoUserList.Refresh(userId);

				if(!aoUserList.Col_AgentAccountId.IsNull) 
				{
					agentAccountId = aoUserList.Col_AgentAccountId.Value;
				} 
				else 
				{
					MessageBox.Show("No Agent Account present for provided user");//throw new UserException("No Agent Account present for provided user");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return agentAccountId;
		}

		public String GetAgentAccountForService(String strService)
		{
			String strAgentNumber = "09101";
			switch (strService)
			{
				case "IND":
					strAgentNumber = "09101";
					break;
				case "BAN":
					strAgentNumber = "09102";
					break;
			}
			String strQuery = "Select Id from AgentMaster where Number = " + strAgentNumber;
			SqlConnection ARYSRET_Conn = new SqlConnection((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("ZOHAET.ConnectionString").GetValue(0));
			SqlCommand cmd_Sel = new SqlCommand(strQuery, ARYSRET_Conn);
			SqlDataAdapter daZohaETInput = new SqlDataAdapter();
			DataSet dsZohaETInput = new DataSet();
			daZohaETInput.SelectCommand = cmd_Sel;
			
			//DataSet dsZohaETInput = new DataSet();
			
			int n_Result = 0;
			try
			{
				//dsZohaETInput = SqlHelper.ExecuteDataset(ARYSRET_Conn, CommandType.Text, strQuery);
				//n_Result = dsZohaETInput.Tables[0].Rows.Count;
				cmd_Sel.Connection.Open();
				n_Result = daZohaETInput.Fill(dsZohaETInput);
			}
			catch(SqlException ex)
			{
				if (ex.Number == 547)
				{
					MessageBox.Show(ex.Message);
				}
				else
				{
					MessageBox.Show(ex.Message);
				}
			}
			finally
			{
				cmd_Sel.Connection.Close();
			}

			//if(n_Result>0)
				return dsZohaETInput.Tables[0].Rows[0]["Id"].ToString();
			//else
				//return string.Empty;
		}
		
		public String GetZohaETId()
		{
			SqlConnection ARYSRET_Conn = new SqlConnection((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("ZOHAET.ConnectionString").GetValue(0));;
			///HARDCODED///
			String strTransQuery = "Select Id from UserList where LoginName = 'ZohaET'"; /*HardCoded Name of Zoha Users*/
			///HARDCODED///
			SqlCommand cmd_Sel = new SqlCommand(strTransQuery, ARYSRET_Conn);
			SqlDataAdapter daZohaETInput = new SqlDataAdapter();
			DataSet dsZohaETInput = new DataSet();
			daZohaETInput.SelectCommand = cmd_Sel;

			int n_Result = 0;
			try
			{
				cmd_Sel.Connection.Open();
				n_Result = daZohaETInput.Fill(dsZohaETInput);
			}
			catch(SqlException ex)
			{
				MessageBox.Show(ex.Message,"Zoha Electronic Transfer");
			}
			finally
			{
				cmd_Sel.Connection.Close();
			}
			if(n_Result>0)
				return dsZohaETInput.Tables[0].Rows[0]["Id"].ToString();
			else
				return string.Empty;
		}
	
		public String TrimtoSize(int nSize, String strText, char chLooseEnd, char chPad)
		{
			int nDiff;
			if(strText.Length > nSize)
			{
				nDiff = strText.Length-nSize;
				// Trimming Loose Corner.
				if(chLooseEnd == 'R')
				{
					strText = strText.Substring(0, (strText.Length)-nDiff );
				}
				else if (chLooseEnd == 'L')
				{
					strText = strText.Substring(nDiff,nSize);//recheck
				}
			}
			else if(strText.Length < nSize)
			{
				// Padding Loose Corner.
				if(chLooseEnd != ' ')
				{
					if(chLooseEnd == 'R')
					{
						strText = strText.PadRight(nSize, chPad);
					}
					else if (chLooseEnd == 'L')
					{
						strText = strText.PadLeft(nSize, chPad);
					}
				}
			}
			return strText;
		}
	}
}