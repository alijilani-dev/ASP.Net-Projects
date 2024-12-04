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

						if(_payinUnitExchangeRate.Value>0) {
							finalRate = (1/_payinUnitExchangeRate.Value);
						} else {
							finalRate = _payinUnitExchangeRate.Value;
						}
						break;
					case CurrencyExchangeType.ValueGreaterThanUSD:
						if(_payinUnitExchangeRate.Value>0) {
							finalRate = _payinUnitExchangeRate.Value;
						} else {
							finalRate = (1/_payinUnitExchangeRate.Value);
						}
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
						if(_payoutUnitExchangeRate.Value>0) {
							finalRate = _payoutUnitExchangeRate.Value;
						} else {
							finalRate = (1/_payoutUnitExchangeRate.Value);
						}
						break;
					case CurrencyExchangeType.ValueGreaterThanUSD:
						if(_payoutUnitExchangeRate.Value>0) {
							finalRate = (1/_payoutUnitExchangeRate.Value);
						} else {
							finalRate = _payoutUnitExchangeRate.Value;
						}
						break;
				}
				return finalRate;
			}
		}
	}
}