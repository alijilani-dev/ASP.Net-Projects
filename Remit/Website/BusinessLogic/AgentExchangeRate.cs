using System;

namespace Evernet.MoneyExchange.BusinessLogic {
	[Serializable]
	public class AgentExchangeRate {
		public AgencyExchangeRate AgencyRate;
		public decimal AgentMarginPercent=0;
		public Guid AgentAccountId = Guid.Empty;

		public decimal Value {
			get {
				if(AgencyRate==null) {
					throw new Exception("BankRate not initialized");
				}

				decimal finalRate = AgencyRate.Value;

//				if(AgencyRate.Value<1) {
//					finalRate = finalRate + (finalRate * (AgentMarginPercent/100));
//				} else {
					finalRate = finalRate - (finalRate * (AgentMarginPercent/100));
//				}

				return finalRate;
			}
		}

		public decimal MaximumAllowedRate {
			get {
				decimal finalRate = this.Value;

				finalRate -= finalRate * (this.AgencyRate.MaximumAgentMargin/100);

				return finalRate;
			}
		}

		public decimal MinimumAllowedRate {
			get {
				decimal finalRate = this.Value;

				finalRate -= finalRate * (this.AgencyRate.MinimumAgentMargin/100);

				return finalRate;
			}
		}

		public decimal PayInValue {
			get {
				if(AgencyRate==null) {
					throw new Exception("BankRate not initialized");
				}

				decimal finalRate = AgencyRate.PayInValue;

//				if(AgencyRate.PayInValue<1) {
//					finalRate = finalRate + (finalRate * (AgentMarginPercent/100));
//				} else {
					finalRate = finalRate - (finalRate * (AgentMarginPercent/100));
//				}

				return finalRate;
			}
		}


		public decimal PayOutValue {
			get {
				if(AgencyRate==null) {
					throw new Exception("BankRate not initialized");
				}

				decimal finalRate = AgencyRate.PayOutValue;

//				if(AgencyRate.PayOutValue<1) {
//					finalRate = finalRate + (finalRate * (AgentMarginPercent/100));
//				} else {
					finalRate = finalRate - (finalRate * (AgentMarginPercent/100));
				//}

				return finalRate;
			}
		}
	}
}