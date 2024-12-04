using System;
using System.Data;
using System.Data.SqlTypes;
using Evernet.Shared;
using Params = Evernet.MoneyExchange.DataClasses.Parameters;
using SPs = Evernet.MoneyExchange.DataClasses.StoredProcedures;
using Microsoft.ApplicationBlocks.Data;

namespace Evernet.MoneyExchange.BusinessLogic {
	public class CurrencyExchangeManager {
		public static string USDCode="USD";
		public static string USDName="United States Dollar";
		public static CurrencyGroupList USDCurrencyGroup = CurrencyGroupList.ValueEqualToUSD;

		public static TransactionExchangeRate GetExchangeRateForAgent(Guid accountId, Guid payInCurrencyId, Guid payOutCurrencyId) {
			TransactionExchangeRate ter = new TransactionExchangeRate();
			/********************************************************
			 * 
			 * Variables used in the calculation
			 * 
			 * *****************************************************/

			// Originating currency
			decimal payinBankExchangeRate = decimal.One;
			decimal payinAgencyExchangeMargin = decimal.Zero;
			decimal payinAgencyExchangeRate = decimal.One;
			decimal payinAgentExchangeMargin = decimal.Zero;
			decimal payinAgentExchangeRate = decimal.One;
			CurrencyGroupList payinCurrencyGroup = CurrencyGroupList.ValueLessThanUSD;
			

			// Destination currency
			decimal payoutBankExchangeRate = decimal.One;
			decimal payoutAgencyExchangeMargin = decimal.Zero;
			decimal payoutAgencyExchangeRate = decimal.One;
			decimal payoutAgentExchangeMargin = decimal.Zero;
			decimal payoutAgentExchangeRate = decimal.One;
			CurrencyGroupList payoutCurrencyGroup = CurrencyGroupList.ValueLessThanUSD;

			// Final exchange rates
			//			decimal finalBankExchangeRate = decimal.One;
			//			decimal finalAgencyExchangeRate = decimal.One;
			//			decimal finalAgentExchangeRate = decimal.One;
			//			decimal finalExchangeRate = decimal.One;

			// Limits
			decimal payinAgentMaximumMargin = decimal.Zero;
			decimal payinAgentMinimumMargin = decimal.Zero;
			decimal payoutAgentMaximumMargin = decimal.Zero;
			decimal payoutAgentMinimumMargin = decimal.Zero;

			

			// Get the details for currency
			Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList aoPayInCurrency
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList(ConfigHelper.ConStr);

			Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList aoPayOutCurrency
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList(ConfigHelper.ConStr);

			aoPayInCurrency.Refresh(payInCurrencyId);
			aoPayOutCurrency.Refresh(payOutCurrencyId);

			ter.PayInCurrencyId = payInCurrencyId;
			ter.PayOutCurrencyId = payOutCurrencyId;

			ter.PayInCurrencyName = aoPayInCurrency.Col_Name.Value;
			ter.PayInCurrencyCode = aoPayInCurrency.Col_Code.Value;

			ter.PayOutCurrencyName = aoPayOutCurrency.Col_Name.Value;
			ter.PayOutCurrencyCode = aoPayOutCurrency.Col_Code.Value;
			
			//Declare the parameters
			Params.spS_SRExchangeRateList prmSPayInAgencyExchangeList
				= new Params.spS_SRExchangeRateList();
			
			Params.spS_SRExchangeRateList prmSPayOutAgencyExchangeList
				= new Params.spS_SRExchangeRateList();

			Params.spS_AgentExchangeRate prmSPayInAgentExchangeRate 
				= new Params.spS_AgentExchangeRate();

			Params.spS_AgentExchangeRate prmSPayOutAgentExchangeRate 
				= new Params.spS_AgentExchangeRate();
			
			// declare the stored procedures
			SPs.spS_SRExchangeRateList spSAgencyExchangeRateList = new SPs.spS_SRExchangeRateList();

			SPs.spS_AgentExchangeRate spSAgentExchangeRateList = new SPs.spS_AgentExchangeRate();

			// Setup the connection
			prmSPayInAgencyExchangeList.SetUpConnection(ConfigHelper.ConStr);
			prmSPayOutAgencyExchangeList.SetUpConnection(ConfigHelper.ConStr);
			prmSPayInAgentExchangeRate.SetUpConnection(ConfigHelper.ConStr);
			prmSPayOutAgentExchangeRate.SetUpConnection(ConfigHelper.ConStr);

			// Set the parameters
			prmSPayInAgencyExchangeList.Param_CurrencyId = payInCurrencyId;
			
			prmSPayOutAgencyExchangeList.Param_CurrencyId = payOutCurrencyId;
			
			prmSPayInAgentExchangeRate.Param_CurrencyId = payInCurrencyId;
			prmSPayInAgentExchangeRate.Param_AccountId = accountId;
			
			prmSPayOutAgentExchangeRate.Param_CurrencyId = payOutCurrencyId;
			prmSPayOutAgentExchangeRate.Param_AccountId = accountId;
			
			// Set the dataset's
			DataSet dsPayInAgency = null;
			DataSet dsPayOutAgency = null;
			DataSet dsPayInAgent = null;
			DataSet dsPayOutAgent = null;

			// Retrieve the information
			spSAgencyExchangeRateList.Execute(
				ref prmSPayInAgencyExchangeList,
				ref dsPayInAgency);

			spSAgencyExchangeRateList.Execute(
				ref prmSPayOutAgencyExchangeList,
				ref dsPayOutAgency);

			spSAgentExchangeRateList.Execute(
				ref prmSPayInAgentExchangeRate,
				ref dsPayInAgent);

			spSAgentExchangeRateList.Execute(
				ref prmSPayOutAgentExchangeRate,
				ref dsPayOutAgent);

			DataTable dtPayInAgency = dsPayInAgency.Tables[0];
			DataTable dtPayOutAgency = dsPayOutAgency.Tables[0];
			DataTable dtPayInAgent = dsPayInAgent.Tables[0];
			DataTable dtPayOutAgent = dsPayOutAgent.Tables[0];

			// Calculate Agency Exchange Rate For PayIn Currency
			if(dtPayInAgency.Rows.Count>0) {
				DataRow dr = dtPayInAgency.Rows[0];
				payinBankExchangeRate = decimal.Parse(dr["BankRate"].ToString());
				payinAgencyExchangeMargin = decimal.Parse(dr["MarginPercent"].ToString());
       
				payinAgentMaximumMargin = decimal.Parse(dr["MaximumAgentMargin"].ToString());
				payinAgentMinimumMargin = decimal.Parse(dr["MinimumAgentMargin"].ToString());

				payinCurrencyGroup = (CurrencyGroupList) Enum.Parse(typeof(CurrencyGroupList),dr["ExchangeType"].ToString(),true);

				switch(payinCurrencyGroup) {
					case CurrencyGroupList.ValueEqualToUSD:
						goto case CurrencyGroupList.ValueLessThanUSD;
					case CurrencyGroupList.ValueLessThanUSD:
						payinAgencyExchangeRate = payinBankExchangeRate + (payinBankExchangeRate * (payinAgencyExchangeMargin/100));
						break;
					case CurrencyGroupList.ValueGreaterThanUSD:
						payinAgencyExchangeRate = payinBankExchangeRate - (payinBankExchangeRate * (payinAgencyExchangeMargin/100));
						break;
				}

				ter.PayInCurrencyId = payInCurrencyId;
				ter.PayInBankExchangeRate = payinBankExchangeRate;
				ter.PayInAgencyExchangeMargin = payinAgencyExchangeMargin;
				ter.PayInAgencyExchangeRate = payinAgencyExchangeRate;
				ter.PayInCurrencyGroup = payinCurrencyGroup;
			} else {
				throw new Exception("No Agency exchange rate details are present for the provided payin currency");
			}

			// Calculate Agent Exchange Rate For PayIn Currency
			if(dtPayInAgent.Rows.Count>0) {
				DataRow dr = dtPayInAgent.Rows[0];

				payinAgentExchangeMargin = decimal.Parse(dr["MarginPercent"].ToString());

				if(payinAgentExchangeMargin<payinAgentMinimumMargin
					||
					payinAgentExchangeMargin>payinAgentMaximumMargin) {
					payinAgentExchangeMargin = payinAgentMinimumMargin;
				}

				switch(payinCurrencyGroup) {
					case CurrencyGroupList.ValueGreaterThanUSD:
						payinAgentExchangeRate = payinBankExchangeRate - (payinBankExchangeRate * ((payinAgencyExchangeMargin+payinAgentExchangeMargin)/100));
						break;
					case CurrencyGroupList.ValueLessThanUSD:
						payinAgentExchangeRate = payinBankExchangeRate + (payinBankExchangeRate * ((payinAgencyExchangeMargin+payinAgentExchangeMargin)/100));
						break;
				}
				ter.PayInAgentExchangeMargin = payinAgentExchangeMargin;
				ter.PayInAgentExchangeRate = payinAgentExchangeRate;
			} else {
				//throw new Exception("No Agent exchange rate details are present for the provided payin currency");
				ter.PayInAgentExchangeMargin=0;
				ter.PayInAgentExchangeRate=ter.PayInAgencyExchangeRate;
			}

			// Check if the payin currency and payout currency are same
			if(payInCurrencyId==payOutCurrencyId) {
				ter.PayOutBankExchangeRate = ter.PayInBankExchangeRate;
				ter.PayOutAgencyExchangeMargin = 0;
				ter.PayOutAgencyExchangeRate = ter.PayOutBankExchangeRate;
				ter.PayOutAgentExchangeMargin = 0;
				ter.PayOutAgentExchangeRate = ter.PayOutBankExchangeRate;
			}else {

				// Calculate Agency Exchange Rate For PayOut Currency
				if(ter.PayOutCurrencyCode=="USD") {
					ter.PayOutCurrencyGroup = CurrencyGroupList.ValueEqualToUSD;
					ter.PayOutCurrencyCode="USD";
					ter.PayOutBankExchangeRate=1;
					ter.PayOutAgencyExchangeMargin=0;
					ter.PayOutAgencyExchangeRate=1;
					ter.PayOutAgentExchangeMargin=0;
					ter.PayOutAgentExchangeRate=1;
				} else {
					if(dtPayOutAgency.Rows.Count>0) {
						DataRow dr = dtPayOutAgency.Rows[0];

						payoutBankExchangeRate = decimal.Parse(dr["BankRate"].ToString());
						payoutAgencyExchangeMargin = decimal.Parse(dr["MarginPercent"].ToString());
						payoutCurrencyGroup = (CurrencyGroupList) Enum.Parse(typeof(CurrencyGroupList),
							dr["ExchangeType"].ToString(),true);
					
						payoutAgentMaximumMargin = decimal.Parse(dr["MaximumAgentMargin"].ToString());
						payoutAgentMinimumMargin = decimal.Parse(dr["MinimumAgentMargin"].ToString());

						switch(payoutCurrencyGroup) {
							case CurrencyGroupList.ValueGreaterThanUSD:
								payoutAgencyExchangeRate = payoutBankExchangeRate + (payoutBankExchangeRate * (payoutAgencyExchangeMargin/100));
								break;
							case CurrencyGroupList.ValueLessThanUSD:
								payoutAgencyExchangeRate = payoutBankExchangeRate - (payoutBankExchangeRate * (payoutAgencyExchangeMargin/100));
								break;
						}
					
						ter.PayOutBankExchangeRate = payoutBankExchangeRate;
						ter.PayOutAgencyExchangeMargin = payoutAgencyExchangeMargin;
						ter.PayOutAgencyExchangeRate = payoutAgencyExchangeRate;
						ter.PayOutCurrencyGroup = payoutCurrencyGroup;
					} else {
						throw new Exception("No Agency exchange rate details are present for the provided payout currency");
					}
        
					// Calculate the Agent exchange rate for PayOut currency
					if(dtPayOutAgent.Rows.Count>0) {
						DataRow dr = dtPayOutAgent.Rows[0];

						payoutAgentExchangeMargin = decimal.Parse(dr["MarginPercent"].ToString());

						if(payoutAgentExchangeMargin<payoutAgentMinimumMargin
							||
							payoutAgentExchangeMargin>payoutAgentMaximumMargin) {
							payoutAgentExchangeMargin = payoutAgentMinimumMargin;
						}

						switch(payoutCurrencyGroup) {
							case CurrencyGroupList.ValueGreaterThanUSD:
								payoutAgentExchangeRate = payoutBankExchangeRate + (payoutBankExchangeRate * ((payoutAgencyExchangeMargin+payoutAgentExchangeMargin)/100));
								break;
							case CurrencyGroupList.ValueLessThanUSD:
								payoutAgentExchangeRate = payoutBankExchangeRate - (payoutBankExchangeRate * ((payoutAgencyExchangeMargin+payoutAgentExchangeMargin)/100));
								break;
						}

						ter.PayOutAgentExchangeMargin = payoutAgentExchangeMargin;
						ter.PayOutAgentExchangeRate = payoutAgentExchangeRate;

					} else {
						//throw new Exception("No Agent exchange rate details are present for the provided payout currency");
						ter.PayOutAgentExchangeMargin=0;
						ter.PayOutAgentExchangeRate=ter.PayOutAgencyExchangeRate;
					}
				}
			}
			return ter;
		}
		/*public static CurrencyExchangeRate GetBankExchangeRateToUSD(Guid payinCurrencyId) {
			
			// Originating currency
			CurrencyExchangeRate cerPayIn = new CurrencyExchangeRate();	

			// Destination currency
//			CurrencyExchangeRate cerPayOut = new CurrencyExchangeRate();
//			cerPayOut.PayInCurrencyCode = USDCode;
//			cerPayOut.PayInCurrencyName = USDName;
//			cerPayOut.PayInCurrencyGroup = USDCurrencyGroup;
//			cerPayOut.PayOutCurrencyCode = USDCode;
//			cerPayOut.PayOnCurrencyName = USDName;
//			cerPayOut.PayOutCurrencyGroup = USDCurrencyGroup;
//			cerPayOut.ExchangeRate = decimal.One;
//
			Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList aoCurrency 
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList(ConfigHelper.ConStr);

			aoCurrency.Refresh(payinCurrencyId);

			cerPayIn.PayInCurrencyId = payinCurrencyId;
			cerPayIn.PayInCurrencyCode = aoCurrency.Col_Code.ToString();
			cerPayIn.PayInCurrencyName = aoCurrency.Col_Name.ToString();
			cerPayIn.PayOutCurrencyCode = USDCode;
			cerPayIn.PayOutCurrencyName = USDName;
			cerPayIn.PayOutCurrencyGroup = USDCurrencyGroup;

			Params.spS_SRExchangeRateList prmSBankExchangeRate 
				= new Evernet.MoneyExchange.DataClasses.Parameters.spS_SRExchangeRateList();
			SPs.spS_SRExchangeRateList spSBankExchangeRate
				= new Evernet.MoneyExchange.DataClasses.StoredProcedures.spS_SRExchangeRateList();

			prmSBankExchangeRate.SetUpConnection(ConfigHelper.ConStr);
			prmSBankExchangeRate.Param_CurrencyId = payinCurrencyId;

			DataSet dsBank = null;

			spSBankExchangeRate.Execute(
				ref prmSBankExchangeRate,
				ref dsBank);

			DataTable dtBank = dsBank.Tables[0];
			
			if(dtBank.Rows.Count>0) {
				DataRow dr = dtBank.Rows[0];
				cerPayIn.PayOutCurrencyGroup = (CurrencyGroupList) Enum.Parse(typeof(CurrencyGroupList),dr["ExchangeType"].ToString(),true);
				cerPayIn.ExchangeRate = decimal.Parse(dr["BankRate"].ToString());
			} else {
				throw new Exception("No Bank exchange rate details present for the provided currency");
			}
			return cerPayIn;
		}

		public static CurrencyExchangeRate GetAgencyExchangeRateToUSD(Guid payinCurrencyId){
			CurrencyExchangeRate cer = GetBankExchangeRateToUSD(payinCurrencyId);

			Params.spS_SRExchangeRateList prmSAgencyExchange
				= new Evernet.MoneyExchange.DataClasses.Parameters.spS_SRExchangeRateList();

			SPs.spS_SRExchangeRateList spSAgencyExchange
				= new Evernet.MoneyExchange.DataClasses.StoredProcedures.spS_SRExchangeRateList();

			DataSet dsAgency = null;

			prmSAgencyExchange.SetUpConnection(ConfigHelper.ConStr);
			prmSAgencyExchange.Param_CurrencyId = payinCurrencyId;

			spSAgencyExchange.Execute(
				ref prmSAgencyExchange,
				ref dsAgency);

			DataTable dtAgency = dsAgency.Tables[0];

			if(dtAgency.Rows.Count>0) {
				DataRow dr = dtAgency.Rows[0];
				decimal agencyExMargin = decimal.Parse(dr["MarginPercent"].ToString());
				cer.ExchangeRate = cer.ExchangeRate + (cer.ExchangeRate * (agencyExMargin/100));
			} else {
				throw new Exception("No Agency exchange details are available for the provided currency");
			}
			
			return cer;
		}

		public static CurrencyExchangeRate GetAgentExchangeRateToUSD(Guid agentAccountId, Guid payinCurrencyId) {
			CurrencyExchangeRate cer = GetAgencyExchangeRateToUSD(payinCurrencyId);

			Params.spS_AgentExchangeRate pmrSAgentExchange 
				= new Evernet.MoneyExchange.DataClasses.Parameters.spS_AgentExchangeRate();
			SPs.spS_AgentExchangeRate spSAgentExchange
				= new Evernet.MoneyExchange.DataClasses.StoredProcedures.spS_AgentExchangeRate();

			pmrSAgentExchange.SetUpConnection(ConfigHelper.ConStr);
			pmrSAgentExchange.Param_CurrencyId = payinCurrencyId;
			pmrSAgentExchange.Param_AccountId = agentAccountId;

			DataSet dsAgent = null;

			spSAgentExchange.Execute(
				ref pmrSAgentExchange,
				ref dsAgent);

			DataTable dtAgent = dsAgent.Tables[0];

			if(dtAgent.Rows.Count>0) {
				DataRow dr = dtAgent.Rows[0];
				decimal agentMargin = decimal.Parse(dr["MarginPercent"].ToString());
				cer.ExchangeRate = cer.ExchangeRate + (cer.ExchangeRate * (agentMargin/100));
			} 

			return cer;
		}

*/
		public static decimal GetAgencyExchangeRateForCurrency(Guid currencyId) {
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From SRExchangeRateList Where CurrencyId='"+currencyId.ToString()+"'");

			DataTable dt = ds.Tables[0];

			DataRow dr = dt.Rows[0];

			decimal bankRate = decimal.Parse(dr["BankRate"].ToString());
			decimal margin = decimal.Parse(dr["MarginPercent"].ToString());
			CurrencyGroupList currencyGroup = (CurrencyGroupList) Enum.Parse(typeof(CurrencyGroupList),dr["ExchangeType"].ToString());

			decimal exchangeRate = decimal.One;

			switch(currencyGroup) {
				case CurrencyGroupList.ValueEqualToUSD:
					goto case CurrencyGroupList.ValueLessThanUSD;
				case CurrencyGroupList.ValueLessThanUSD:
					exchangeRate = bankRate - (bankRate * (margin/100));
					break;
				case CurrencyGroupList.ValueGreaterThanUSD:
					exchangeRate = bankRate + (bankRate * (margin/100));
					break;
			}

			return exchangeRate;
		}

		public static CurrencyGroupList GetCurrencyGroupForCurrency(Guid currencyId) {
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select ExchangeType From SRExchangeRateList Where CurrencyId='"+ currencyId.ToString() +"'");
			DataRow dr = ds.Tables[0].Rows[0];

			CurrencyGroupList groupList = (CurrencyGroupList) Enum.Parse(typeof(CurrencyGroupList),dr["ExchangeType"].ToString());

			return groupList;
		}

		public static decimal GetAgencyExchangeRateBetweenCurrencies(Guid payinCurrency, Guid payoutCurrency) {
			decimal payinExchangeRate = GetAgencyExchangeRateForCurrency(payinCurrency);
			decimal payoutExchangeRate = GetAgencyExchangeRateForCurrency(payoutCurrency);

			CurrencyGroupList PayInCurrencyGroup = GetCurrencyGroupForCurrency(payinCurrency);
			CurrencyGroupList PayOutCurrencyGroup = GetCurrencyGroupForCurrency(payoutCurrency);

			decimal finalrate = decimal.Zero;
			switch(PayInCurrencyGroup) {
				case CurrencyGroupList.ValueLessThanUSD:
				switch(PayOutCurrencyGroup) {
					case CurrencyGroupList.ValueLessThanUSD:
						finalrate = payoutExchangeRate / payinExchangeRate;
						break;
					case CurrencyGroupList.ValueGreaterThanUSD:
						finalrate = (1/payinExchangeRate) / payoutExchangeRate;
						break;
					case CurrencyGroupList.ValueEqualToUSD: // ? Is this needed ?
						finalrate = 1/payinExchangeRate;
						break;
				}
					break;
				case CurrencyGroupList.ValueGreaterThanUSD:
				switch(PayOutCurrencyGroup) {
					case CurrencyGroupList.ValueLessThanUSD:
						finalrate = payinExchangeRate / (1/payoutExchangeRate);
						break;
					case CurrencyGroupList.ValueGreaterThanUSD:
						finalrate = (1/payinExchangeRate) / payoutExchangeRate;
						break;
					case CurrencyGroupList.ValueEqualToUSD:
						finalrate = payinExchangeRate;
						break;
				}
					break;
			}
			return finalrate;
		}
		public static decimal GetAgencyUSDAmountForCurrency(Guid currencyId, decimal amount) {
			decimal agencyExchange = GetAgencyExchangeRateForCurrency(currencyId);
			CurrencyGroupList cGroup = GetCurrencyGroupForCurrency(currencyId);

			decimal finalValue = 0;
			switch(cGroup) {
				case CurrencyGroupList.ValueLessThanUSD:
					finalValue = amount / agencyExchange;
					break;
				case CurrencyGroupList.ValueGreaterThanUSD:
					finalValue = amount * agencyExchange;
					break;
			}

			return finalValue;
		}
		public static decimal GetAgencyPayOutAmount(Guid payinCurrencyId, decimal payinAmount, Guid payoutCurrencyId) {
			return payinAmount * GetAgencyExchangeRateBetweenCurrencies(payinCurrencyId, payoutCurrencyId);
		}
   	}
}