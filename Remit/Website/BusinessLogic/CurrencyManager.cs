using System;
using System.Data;
using System.Data.SqlClient;
using Evernet.Shared;
using Microsoft.ApplicationBlocks.Data;

namespace Evernet.MoneyExchange.BusinessLogic {
	public class CurrencyManager {

//		public static Guid GetCurrencyId(string currencyCode) {
//			Guid currencyId = Guid.Empty;
//
//			//string conStr = "Server=(local); User Id=mexchange; Password=mexchange2004;Database=mexchange";
//
//			if(currencyCode!=null) {
//				SqlParameter paraCurrencyCode = new SqlParameter("@currencyCode",SqlDbType.NVarChar,3);
//				paraCurrencyCode.Value = currencyCode;
//
//				SqlParameter paraCurrencyId = new SqlParameter("@currencyId",SqlDbType.UniqueIdentifier);
//				paraCurrencyId.Direction = ParameterDirection.Output;
//
//				SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
//					CommandType.StoredProcedure,
//					"sp_getCurrencyIdForCode",
//					paraCurrencyCode,
//					paraCurrencyId);
//
//				currencyId = (Guid) paraCurrencyId.Value;
//
//			}
//			return currencyId;
//		}
	}
}
