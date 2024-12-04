using System;

namespace Evernet.MoneyExchange.BusinessLogic {
	[Serializable]
	public class UnitExchangeRate {
		private Currency _unitCurrency;
		private CurrencyExchangeType _exchangeType;
		private CurrencyExchangePosition _exchangePosition;
		private decimal _bidRate;
		private decimal _offerRate;

		public Currency UnitCurrency {
			get { return _unitCurrency;}
			set {_unitCurrency = value;}
		}
		
		public CurrencyExchangeType ExchangeType {
			get { return _exchangeType;}
			set { _exchangeType = value;}
		}

		public CurrencyExchangePosition ExchangePosition {
			get { return _exchangePosition;}
			set { _exchangePosition = value;}
		}

		public decimal BidRate {
			get { return _bidRate;}
			set { _bidRate = value;}
		}

		public decimal OfferRate {
			get { return _offerRate;}
			set { _offerRate = value;}
		}

		public decimal Value {
			get {
				if(_unitCurrency==null) {
					throw new Exception("Unit Currency not provided!");
				}

				decimal _exchangeRate = 0;
				switch(_exchangeType) {
					case CurrencyExchangeType.ValueEqualToUSD:
						if(_exchangePosition == CurrencyExchangePosition.PayOut) {
							_exchangeRate = 1;
						} else {
							goto case CurrencyExchangeType.ValueLessThanUSD;
						}
						break;
					case CurrencyExchangeType.ValueLessThanUSD:
						switch(_exchangePosition) {
							case CurrencyExchangePosition.PayIn:
								_exchangeRate = (_bidRate>_offerRate)?_bidRate:_offerRate;
								if(_exchangeRate!=0)
									_exchangeRate = (1/_exchangeRate);
								break;
							case CurrencyExchangePosition.PayOut:
								_exchangeRate = (_bidRate<_offerRate)?_bidRate:_offerRate;
								break;
						}
						break;
					case CurrencyExchangeType.ValueGreaterThanUSD:
						switch(_exchangePosition) {
							case CurrencyExchangePosition.PayIn:
								_exchangeRate = (_bidRate > _offerRate)?_bidRate:_offerRate;
								if(_exchangeRate<1)
									_exchangeRate = (1/_exchangeRate);
								break;
							case CurrencyExchangePosition.PayOut:
								_exchangeRate = (_bidRate < _offerRate)?_bidRate:_offerRate;
								if(_exchangeRate!=0) {
									if(_exchangeRate>1) {
										_exchangeRate = (1/_exchangeRate);
									}
								}
								break;
						}
						break;
				}
				return _exchangeRate;
			}
		}
	}
}