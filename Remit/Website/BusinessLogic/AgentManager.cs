using System;
using System.Data;
using System.Data.SqlClient;
using Evernet.Shared;
using Microsoft.ApplicationBlocks.Data;

namespace Evernet.MoneyExchange.BusinessLogic {
	public class AgentManager {
//		public static decimal GetRemainingCredit(Guid agentId) {
//			// sum up all the credit and convert to USD
//			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
//				CommandType.StoredProcedure,
//				"Select ");
//			// sum up all debits and convert to USD
//		}

		public static Guid GetAgentAccountForAgentLocation(Guid agentLocationId) {
			Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList aoAgentLocation
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList(ConfigHelper.ConStr);

			Guid agentAccountId = Guid.Empty;

			if(aoAgentLocation.Refresh(agentLocationId)) {
//				Evernet.MoneyExchange.AbstractClasses.Abstract_AgentGroupList aoAgentGroup
//					= new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentGroupList(ConfigHelper.ConStr);
//
//				aoAgentGroup.Refresh(aoAgentLocation.Col_AgentGroupId);
//
//				agentAccountId = aoAgentGroup.Col_AgentAccountId.Value;

				agentAccountId = aoAgentLocation.Col_AgentAccountId.Value;
			} else {
				throw new Exception("Mentioned Agent Location does not exist!");
			}

			return agentAccountId;
		}

		public static decimal GetRemainingCreditForAgentLocation(Guid agentLocation) {
			return GetRemainingCreditForAgentAccount(GetAgentAccountForAgentLocation(agentLocation));
		}

		public static decimal GetRemainingCreditForAgentAccount(Guid agentAccountId) {
			decimal creditLimit = 0;
			decimal totalCredit = 0;
			decimal totalDebit = 0;

			// Find the credit limit
			Evernet.MoneyExchange.AbstractClasses.Abstract_AgentMaster aoAgentAccount
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentMaster(ConfigHelper.ConStr);

			if(aoAgentAccount.Refresh(agentAccountId)) {
				if(!aoAgentAccount.Col_CreditLimitInUSD.IsNull) {
					creditLimit = aoAgentAccount.Col_CreditLimitInUSD.Value;
				}
			} else {
				throw new Exception("Mentioned Agent Account does not exist!");
			}

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From dbo.fn_getCurrentCreditDetailsForAgentAccount('"+ agentAccountId.ToString() +"')");

			if(ds.Tables[0].Rows.Count>0) {
				DataRow dr = ds.Tables[0].Rows[0];
				if(dr["TotalCredit"] != DBNull.Value) {
					totalCredit = decimal.Parse(dr["TotalCredit"].ToString());
				} 

				if(dr["TotalDebit"] != DBNull.Value) {
					totalDebit = decimal.Parse(dr["TotalDebit"].ToString());
				}
			}

			return (creditLimit - totalDebit) + totalCredit;
		}
	}
}