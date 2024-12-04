using System;

namespace Evernet.MoneyExchange.BusinessLogic {
	[Serializable]
	public class AgencyExchangeRate {
		public Guid PayInCountry = Guid.Empty;
		public Guid PayOutCountry = Guid.Empty;
		public BankExchangeRate BankRate;
		public decimal AgencyMarginPercent=0;
		public string ExchangeSetName = string.Empty;
		public Guid ExchangeRateId=Guid.Empty;
		public decimal MaximumAgentMargin=0;
		public decimal MinimumAgentMargin=0;

		public decimal Value {
			get {
				if(BankRate==null) {
					throw new Exception("BankRate not initialized");
				}

				decimal finalRate = BankRate.Value;

				//if(BankRate.Value<1) {
					finalRate = finalRate - (finalRate * (AgencyMarginPercent/100));
//				} else {
//					finalRate = finalRate + (finalRate * (AgencyMarginPercent/100));
//				}

				return finalRate;
			}
		}

		public decimal PayInValue {
			get {
				if(BankRate==null) {
					throw new Exception("BankRate not initialized");
				}

				decimal finalRate = BankRate.PayInUnitExchangeRate.Value;

				//if(BankRate.PayInUnitExchangeRate.Value<1) {
					finalRate = finalRate + (finalRate * (AgencyMarginPercent/100));
//				} else {
//					finalRate = finalRate - (finalRate * (AgencyMarginPercent/100));
//				}

				return finalRate;
			}
		}

		public decimal PayOutValue {
			get {
				if(BankRate==null) {
					throw new Exception("BankRate not initialized");
				}

				decimal finalRate = BankRate.PayOutUnitExchangeRate.Value;

				// if(BankRate.PayOutUnitExchangeRate.Value<1) {
					finalRate = finalRate + (finalRate * (AgencyMarginPercent/100));
//				} else {
//					finalRate = finalRate - (finalRate * (AgencyMarginPercent/100));
//				}

				return finalRate;
			}
		}
	}
}
