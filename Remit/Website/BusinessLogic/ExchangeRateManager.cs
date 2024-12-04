using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using Evernet.Shared;

namespace Evernet.MoneyExchange.BusinessLogic {
	public class ExchangeRateManager {
		public static UnitExchangeRate GetUnitExchangeRateForCurrency(Currency inCurrency, CurrencyExchangePosition position) {
			UnitExchangeRate unit = new UnitExchangeRate();
			unit.UnitCurrency = inCurrency;
			unit.ExchangePosition = position;

			if(inCurrency.Code!="USD") {
				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					"Select * From BankExchangeRateList Where CurrencyId='"+ inCurrency.Id.ToString() +"'");

				if(ds.Tables[0].Rows.Count>0) {
				
			
					DataRow dr = ds.Tables[0].Rows[0];
					unit.BidRate = decimal.Parse(dr["BidRate"].ToString());
					unit.OfferRate = decimal.Parse(dr["OfferRate"].ToString());
					unit.ExchangeType = (CurrencyExchangeType) Enum.Parse(typeof(CurrencyExchangeType),dr["ExchangeType"].ToString());
				}
			} else {
				unit.BidRate = 1;
				unit.OfferRate = 1;
				unit.ExchangeType = CurrencyExchangeType.ValueEqualToUSD;
			}

			return unit;
		}

		public static BankExchangeRate GetBankExchangeRate(UnitExchangeRate payinCurrencyRate, UnitExchangeRate payoutCurrencyRate) {
			BankExchangeRate bankRate = new BankExchangeRate();
			bankRate.PayInUnitExchangeRate = payinCurrencyRate;
			bankRate.PayOutUnitExchangeRate = payoutCurrencyRate;
			return bankRate;
		}

		public static AgencyExchangeRate GetAgencyExchangeRate(BankExchangeRate bankRate, Guid payInCountry, Guid payOutCountry) {
			AgencyExchangeRate agencyRate = new AgencyExchangeRate();
			agencyRate.BankRate = bankRate;
			agencyRate.PayInCountry = payInCountry;
			agencyRate.PayOutCountry = payOutCountry;

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From AgencyExchangeRateList Where PayInCountryId='"+ payInCountry.ToString() +"' And PayOutCountryId='"+ payOutCountry.ToString() +"' And PayOutCurrencyId='"+ bankRate.PayOutUnitExchangeRate.UnitCurrency.Id.ToString() +"'");

			if(ds.Tables[0].Rows.Count>0) {
				DataRow dr = ds.Tables[0].Rows[0];

				agencyRate.AgencyMarginPercent = decimal.Parse(dr["MarginPercent"].ToString());
				agencyRate.ExchangeSetName = dr["ExchangeSetName"].ToString();
				agencyRate.ExchangeRateId = new Guid(dr["Id"].ToString());
				agencyRate.MaximumAgentMargin = decimal.Parse(dr["MaximumAgentMargin"].ToString());
				agencyRate.MinimumAgentMargin = decimal.Parse(dr["MinimumAgentMargin"].ToString());
			}

			return agencyRate;
		}

		public static AgentExchangeRate GetAgentExchangeRate(AgencyExchangeRate agencyRate, Guid agentAccountId) {
			AgentExchangeRate agentRate = new AgentExchangeRate();
			agentRate.AgencyRate = agencyRate;
			
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From AgentExchangeRateList Where AgentAccountId='"+ agentAccountId.ToString() +"' And AgencyExchangeRateId='"+ agencyRate.ExchangeRateId.ToString() +"'");

			if(	ds.Tables[0].Rows.Count>0){
				DataRow dr = ds.Tables[0].Rows[0];
				agentRate.AgentMarginPercent = decimal.Parse(dr["MarginPercent"].ToString());
			} else {
				agentRate.AgentMarginPercent=0;
			}

			return agentRate;
		}

	}
}
