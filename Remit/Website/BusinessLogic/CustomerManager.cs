using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using Evernet.Shared;

namespace Evernet.MoneyExchange.BusinessLogic {
	public class CustomerManager {
		public static Guid GetCustomerIdForCardCode(string cardCode) {
			Guid customerId = Guid.Empty;
			
			// Find the Card Id
			DataSet ds1 = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select Id From CustomerCardList Where Code='"+ cardCode.ToString() +"'");

			if(ds1.Tables[0].Rows.Count>0) {
				// Get the customer who has the card id
				DataSet ds2 = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					"Select Id,LoginName From CustomerList Where CardId='"+ ds1.Tables[0].Rows[0]["Id"].ToString() +"'");

				if(ds2.Tables[0].Rows.Count>0) {
					customerId = new Guid(ds2.Tables[0].Rows[0]["Id"].ToString());
				}
			}

			return customerId;
		}

		public static Guid GetCustomerIdForLoginName(string loginName) {
			Guid customerId = Guid.Empty;

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From CustomerList Where LoginName = '"+ loginName +"'");

			if(ds.Tables[0].Rows.Count>0) {
				customerId = new Guid(ds.Tables[0].Rows[0]["Id"].ToString());
			}

			return customerId;
		}
	}
}