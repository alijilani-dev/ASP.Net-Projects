using System;

namespace Evernet.MoneyExchange.BusinessLogic {
	[Serializable]
	public class BankExchangeRate {
		private UnitExchangeRate _payinUnitExchangeRate;
		private UnitExchangeRate _payoutUnitExchangeRate;

		public UnitExchangeRate PayInUnitExchangeRate {
			get { return _payinUnitExchangeRate;}
			set { _payinUnitExchangeRate = value;}
		}

		public UnitExchangeRate PayOutUnitExchangeRate {
			get { return _payoutUnitExchangeRate;}
			set { _payoutUnitExchangeRate = value;}
		}

		public decimal Value {
			get {
				return (_payinUnitExchangeRate.Value * _payoutUnitExchangeRate.Value);
			}
		}

		public decimal PayInValue {
			get {
				decimal finalRate=1;
				switch(_payinUnitExchangeRate.ExchangeType) {
					case CurrencyExchangeType.ValueEqualToUSD:
						goto case CurrencyExchangeType.ValueLessThanUSD;
						
					case CurrencyExchangeType.ValueLessThanUSD:
						finalRate = _payinUnitExchangeRate.Value;
						break;
					case CurrencyExchangeType.ValueGreaterThanUSD:
						finalRate = (1/_payinUnitExchangeRate.Value);
						break;
				}
				return finalRate;
			}
		}

		public decimal PayOutValue {
			get {
				decimal finalRate=1;
				switch(_payoutUnitExchangeRate.ExchangeType) {
					case CurrencyExchangeType.ValueEqualToUSD:
						goto case CurrencyExchangeType.ValueLessThanUSD;
						
					case CurrencyExchangeType.ValueLessThanUSD:
						finalRate = (1/_payoutUnitExchangeRate.Value);
						break;
					case CurrencyExchangeType.ValueGreaterThanUSD:
						finalRate = _payoutUnitExchangeRate.Value;
						break;
				}
				return finalRate;
			}
		}
	}
}