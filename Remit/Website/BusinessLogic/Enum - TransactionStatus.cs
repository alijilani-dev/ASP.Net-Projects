namespace Evernet.MoneyExchange.BusinessLogic {
	public enum TransactionStatus {
		AgencyBlocked,
		AgentBlocked,
		CancelledWithoutRefund,
		CancelledWithRefund,
		OFACBlocked,
		Paid,
		PendingApproval,
		Rejected,
		UnPaid,
		PendingPayOutApproval
	}
}