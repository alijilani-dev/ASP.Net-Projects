using System;

namespace Evernet.MoneyExchange.BusinessLogic {
	[Serializable]
	public class Currency {
		private Guid _currencyId;
		private string _code;
		private string _name;
		private int _scale=0;

		public Guid Id {
			get { return _currencyId;}
			set { _currencyId = value;}
		}

		public string Code {
			get { return _code;}
			set { _code = value;}
		}

		public string Name {
			get { return _name;}
			set { _name = value;}
		}

		public int Scale {
			get { return _scale;}
			set { _scale = value;}
		}

	}
}
