using System;

namespace Evernet.MoneyExchange.BusinessLogic {
	#region CommissionRate
	/// <summary>
	/// This object represents the properties and methods of a CommissionRate.
	/// </summary>
	[Serializable]
	public class CommissionRate {
		protected Guid _payInCountryId = Guid.Empty;
		protected Guid _payOutCountryId = Guid.Empty;
		protected string _modeOfPayment = String.Empty;
		protected decimal _startRange;
		protected decimal _endRange;
		protected decimal _baseToBaseCommissionAmount;
		protected decimal _baseToUSDCommissionAmount;
		protected CommissionType _payInCommissionType = CommissionType.Percentage;
		protected decimal _payInCommissionAmount;
		protected CommissionType _payOutCommissionType = CommissionType.Percentage;
		protected CommissionCurrencyType _payOutCurrencyType = CommissionCurrencyType.Base;
		protected decimal _payOutCommissionAmount;
		protected bool rangeFound=false;
		
		#region Public Properties
		public Guid PayInCountryId {
			get {return _payInCountryId;}
			set {_payInCountryId = value;}
		}

		public Guid PayOutCountryId {
			get {return _payOutCountryId;}
			set {_payOutCountryId = value;}
		}

		public string ModeOfPayment {
			get {return _modeOfPayment;}
			set {_modeOfPayment = value;}
		}

		public decimal StartRange {
			get {return _startRange;}
			set {_startRange = value;}
		}

		public decimal EndRange {
			get {return _endRange;}
			set {_endRange = value;}
		}

		public decimal BaseToBaseCommissionAmount {
			get {return _baseToBaseCommissionAmount;}
			set {_baseToBaseCommissionAmount = value;}
		}

		public decimal BaseToUSDCommissionAmount {
			get {return _baseToUSDCommissionAmount;}
			set {_baseToUSDCommissionAmount = value;}
		}

		public CommissionType PayInCommissionType {
			get {return _payInCommissionType;}
			set {_payInCommissionType = value;}
		}

		public decimal PayInCommissionAmount {
			get {return _payInCommissionAmount;}
			set {_payInCommissionAmount = value;}
		}

		public CommissionType PayOutCommissionType {
			get {return _payOutCommissionType;}
			set {_payOutCommissionType = value;}
		}

		public CommissionCurrencyType PayOutCurrencyType {
			get {return _payOutCurrencyType;}
			set {_payOutCurrencyType = value;}
		}

		public decimal PayOutCommissionAmount {
			get {return _payOutCommissionAmount;}
			set {_payOutCommissionAmount = value;}
		}

		public bool RangeFound {
			get { return rangeFound;}
			set { rangeFound=value;}
		}
		#endregion
	}
	#endregion

}
