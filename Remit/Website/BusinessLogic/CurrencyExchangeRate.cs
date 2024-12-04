using System;

namespace Evernet.MoneyExchange.BusinessLogic {
	public class CurrencyExchangeRate {

		public Guid PayInCurrencyId = Guid.Empty;
		public string PayInCurrencyName = string.Empty;
		public string PayInCurrencyCode = string.Empty;
		public CurrencyGroupList PayInCurrencyGroup = CurrencyGroupList.ValueLessThanUSD;
		
		public Guid PayOutCurrencyId = Guid.Empty;
		public string PayOutCurrencyName = string.Empty;
		public string PayOutCurrencyCode = string.Empty;
		public CurrencyGroupList PayOutCurrencyGroup = CurrencyGroupList.ValueLessThanUSD;

		public decimal ExchangeRate = decimal.One;
	}
}
