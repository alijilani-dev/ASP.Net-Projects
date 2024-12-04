using System;

namespace Evernet.MoneyExchange.BusinessLogic {
	public class TransactionValidationResult {
		private bool wasSuccess = false;
		private string message = String.Empty;

		public bool WasSuccess {
			get { return wasSuccess;}
		}

		public string Message {
			get { return message;}
		}

		private TransactionValidationResult(){}

		public TransactionValidationResult(bool result, string mes) {
			this.wasSuccess = result;
			this.message=mes;
		}
	}
}
