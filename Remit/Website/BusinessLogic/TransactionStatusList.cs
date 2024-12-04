namespace Evernet.MoneyExchange.BusinessLogic {
	public enum TransactionStatusList {
		AgencyBlocked,
		AgentBlocked,
		CancelledWithoutRefund,
		CancelledWithRefund,
		OFACBlocked,
		Paid,
		PendingApproval,
		Rejected,
		UnPaid
	}
}