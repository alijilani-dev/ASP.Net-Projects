using System;

namespace Evernet.MoneyExchange.BusinessLogic {
	[Serializable]
	public class TransactionExchangeRate {

		public Guid PayInCurrencyId = Guid.Empty;
		public string PayInCurrencyCode = string.Empty;
		public string PayInCurrencyName = string.Empty;
		public CurrencyGroupList PayInCurrencyGroup = CurrencyGroupList.ValueEqualToUSD;

		public decimal PayInAmount = decimal.Zero;

		public decimal PayInBankExchangeRate = decimal.Zero;
		public decimal PayInAgencyExchangeMargin = decimal.Zero;
		public decimal PayInAgencyExchangeRate = decimal.One;
		public decimal PayInAgentExchangeMargin = decimal.Zero;
		public decimal PayInAgentExchangeRate = decimal.One;
		
		public Guid PayOutCurrencyId = Guid.Empty;
		public string PayOutCurrencyCode = string.Empty;
		public string PayOutCurrencyName = string.Empty;
		public CurrencyGroupList PayOutCurrencyGroup = CurrencyGroupList.ValueEqualToUSD;

		public decimal PayOutAmount = decimal.Zero;

		public decimal PayOutBankExchangeRate = decimal.Zero;
		public decimal PayOutAgencyExchangeMargin = decimal.Zero;
		public decimal PayOutAgencyExchangeRate = decimal.One;
		public decimal PayOutAgentExchangeMargin = decimal.Zero;
		public decimal PayOutAgentExchangeRate = decimal.One;

		public decimal ExchangeRate {
			get {
				return GetFinalExchangeRate(PayInAgentExchangeRate,PayOutAgentExchangeRate);
			}
		}

		public decimal AgencyExchangeRate {
			get {
				return GetFinalExchangeRate(PayInAgencyExchangeRate, PayOutAgencyExchangeRate);
			}
		}


		public decimal BankExchangeRate {
			get {
				return GetFinalExchangeRate(PayInBankExchangeRate, PayOutBankExchangeRate);
			}
		}

		private decimal GetFinalExchangeRate(decimal payinExchangeRate, decimal payoutExchangeRate) {
			decimal finalrate = decimal.Zero;
			switch(PayInCurrencyGroup) {
				case CurrencyGroupList.ValueLessThanUSD:
				switch(PayOutCurrencyGroup) {
					case CurrencyGroupList.ValueLessThanUSD:
						finalrate = payoutExchangeRate / payinExchangeRate;
						FinalRateFormula = "payoutExchangeRate / payinExchangeRate";
						break;
					case CurrencyGroupList.ValueGreaterThanUSD:
						finalrate = (1/payinExchangeRate) / payoutExchangeRate;
						FinalRateFormula = "(1/payinExchangeRate) / payoutExchangeRate";
						break;
					case CurrencyGroupList.ValueEqualToUSD: // ? Is this needed ?
						finalrate = 1/payinExchangeRate;
						FinalRateFormula = "1/payinExchangeRate";
						break;
				}
					break;
				case CurrencyGroupList.ValueGreaterThanUSD:
				switch(PayOutCurrencyGroup) {
					case CurrencyGroupList.ValueLessThanUSD:
						finalrate = payinExchangeRate / (1/payoutExchangeRate);
						FinalRateFormula = "payinExchangeRate / (1/payoutExchangeRate)";
						break;
					case CurrencyGroupList.ValueGreaterThanUSD:
						finalrate = (1/payinExchangeRate) / payoutExchangeRate;
						FinalRateFormula = "(1/payinExchangeRate) / payoutExchangeRate";
						break;
					case CurrencyGroupList.ValueEqualToUSD:
						finalrate = payinExchangeRate;
						FinalRateFormula = "payinExchangeRate";
						break;
				}
					break;
			}
			return finalrate;
		}

		public decimal PayInAgencyAmountInUSD {
			get {
				decimal payinInUSD = decimal.Zero;
				switch(PayInCurrencyGroup) {
					case CurrencyGroupList.ValueEqualToUSD:
						goto case CurrencyGroupList.ValueLessThanUSD;
					case CurrencyGroupList.ValueLessThanUSD:
						payinInUSD = (PayInAmount) / PayInAgencyExchangeRate;
						break;
					case CurrencyGroupList.ValueGreaterThanUSD:
						payinInUSD = (PayInAmount) * PayInAgencyExchangeRate;
						break;
				}
				return payinInUSD;
			}
		}


		public decimal PayOutAgencyAmountInUSD {
			get {
				decimal payoutInUSD = decimal.Zero;
				switch(PayOutCurrencyGroup) {
					case CurrencyGroupList.ValueEqualToUSD:
						goto case CurrencyGroupList.ValueLessThanUSD;
					case CurrencyGroupList.ValueLessThanUSD:
						payoutInUSD = (PayOutAmount) / PayOutAgencyExchangeRate;
						break;
					case CurrencyGroupList.ValueGreaterThanUSD:
						payoutInUSD = (PayOutAmount) * PayOutAgencyExchangeRate;
						break;
				}
				return payoutInUSD;
			}
		}

		public string FinalRateFormula = String.Empty;

		public decimal Commission = decimal.Zero;
	}
}
