<%@ Page language="c#" Codebehind="WebFormInternal_AdminTop.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormInternal_AdminTop" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
	<head>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script id="clientEventHandlersJS" language="javascript">
<!--
			function window_onload()
			{
				parent.frames("main").location.replace("<%=FrameEditURL%>");
			}

			function cmdAddNewRecord_onclick()
			{
				AdminTop.<%=ComboBoxName%>.selectedIndex = 0;
				parent.frames("main").location.replace("<%=FrameAddURL%>");
			}
//-->
		</script>
		<link href="StyleSheet.css" type="text/css" rel="stylesheet">
	</head>
	<body ms_positioning="GridLayout" language="javascript" onload="return window_onload();" class="AdminTopFormStyle">
		<form id="AdminTop" method="post" runat="server">
			<table>
				<tr>
					<td class="TablesLabelStyle">
						Tables:
					</td>
					<td class="RecordsLabelStyle">
						Records:
					</td>
				</tr>
				<tr>
					<td>
						<asp:dropdownlist id="comDatabaseTablesList" style="Z-INDEX: 100" runat="server" CssClass="TablesDropDownStyle" AutoPostBack="True">
							<asp:ListItem Value="AgencyCommissionIncomeAccountDetails" Selected="True">AgencyCommissionIncomeAccountDetails</asp:ListItem>
							<asp:ListItem Value="AgencyDifferenceIncomeAccountDetails">AgencyDifferenceIncomeAccountDetails</asp:ListItem>
							<asp:ListItem Value="AgencyExchangeRateList">AgencyExchangeRateList</asp:ListItem>
							<asp:ListItem Value="AgentAccountDetails">AgentAccountDetails</asp:ListItem>
							<asp:ListItem Value="AgentAccountType">AgentAccountType</asp:ListItem>
							<asp:ListItem Value="AgentAvailablePaymentModeList">AgentAvailablePaymentModeList</asp:ListItem>
							<asp:ListItem Value="AgentCommissionIncomeAccount">AgentCommissionIncomeAccount</asp:ListItem>
							<asp:ListItem Value="AgentCommissionSplitList">AgentCommissionSplitList</asp:ListItem>
							<asp:ListItem Value="AgentExchangeRateList">AgentExchangeRateList</asp:ListItem>
							<asp:ListItem Value="AgentGroupList">AgentGroupList</asp:ListItem>
							<asp:ListItem Value="AgentLocationList">AgentLocationList</asp:ListItem>
							<asp:ListItem Value="AgentMaster">AgentMaster</asp:ListItem>
							<asp:ListItem Value="BankExchangeRateList">BankExchangeRateList</asp:ListItem>
							<asp:ListItem Value="BankList">BankList</asp:ListItem>
							<asp:ListItem Value="BeneficeryBankList">BeneficeryBankList</asp:ListItem>
							<asp:ListItem Value="CommissionCurrencyType">CommissionCurrencyType</asp:ListItem>
							<asp:ListItem Value="CommissionSlabMaster">CommissionSlabMaster</asp:ListItem>
							<asp:ListItem Value="CommissionSplitTypeList">CommissionSplitTypeList</asp:ListItem>
							<asp:ListItem Value="CountryAllowedOutboundCurrencyList">CountryAllowedOutboundCurrencyList</asp:ListItem>
							<asp:ListItem Value="CountryAvailablePaymentModeList">CountryAvailablePaymentModeList</asp:ListItem>
							<asp:ListItem Value="CountryList">CountryList</asp:ListItem>
							<asp:ListItem Value="CountryTransactionPermissionList">CountryTransactionPermissionList</asp:ListItem>
							<asp:ListItem Value="CountryTransactionPermissionTypeList">CountryTransactionPermissionTypeList</asp:ListItem>
							<asp:ListItem Value="CurrencyExchangeType">CurrencyExchangeType</asp:ListItem>
							<asp:ListItem Value="CurrencyList">CurrencyList</asp:ListItem>
							<asp:ListItem Value="CustomerCardList">CustomerCardList</asp:ListItem>
							<asp:ListItem Value="CustomerCardStatusList">CustomerCardStatusList</asp:ListItem>
							<asp:ListItem Value="CustomerList">CustomerList</asp:ListItem>
							<asp:ListItem Value="CustomerLoyaltyPointsAccumulationHistory">CustomerLoyaltyPointsAccumulationHistory</asp:ListItem>
							<asp:ListItem Value="CustomerLoyaltyPointsRedeemHistory">CustomerLoyaltyPointsRedeemHistory</asp:ListItem>
							<asp:ListItem Value="EntityList">EntityList</asp:ListItem>
							<asp:ListItem Value="GlobalSettings">GlobalSettings</asp:ListItem>
							<asp:ListItem Value="LocationList">LocationList</asp:ListItem>
							<asp:ListItem Value="LocationTree">LocationTree</asp:ListItem>
							<asp:ListItem Value="MasterCountryList">MasterCountryList</asp:ListItem>
							<asp:ListItem Value="MasterModuleList">MasterModuleList</asp:ListItem>
							<asp:ListItem Value="OFACBannedNameList">OFACBannedNameList</asp:ListItem>
							<asp:ListItem Value="PayInAgentDifferenceIncomeAccount">PayInAgentDifferenceIncomeAccount</asp:ListItem>
							<asp:ListItem Value="PaymentHistory">PaymentHistory</asp:ListItem>
							<asp:ListItem Value="PaymentModeBaseTypeList">PaymentModeBaseTypeList</asp:ListItem>
							<asp:ListItem Value="PaymentModeList">PaymentModeList</asp:ListItem>
							<asp:ListItem Value="PaymentType">PaymentType</asp:ListItem>
							<asp:ListItem Value="ProductsList">ProductsList</asp:ListItem>
							<asp:ListItem Value="PurposeOfTransferList">PurposeOfTransferList</asp:ListItem>
							<asp:ListItem Value="TransactionDetails">TransactionDetails</asp:ListItem>
							<asp:ListItem Value="TransactionDraftList">TransactionDraftList</asp:ListItem>
							<asp:ListItem Value="TransactionModificationMessageList">TransactionModificationMessageList</asp:ListItem>
							<asp:ListItem Value="TransactionSettlementHistory">TransactionSettlementHistory</asp:ListItem>
							<asp:ListItem Value="TransactionSettlementStatusList">TransactionSettlementStatusList</asp:ListItem>
							<asp:ListItem Value="TransactionStatusList">TransactionStatusList</asp:ListItem>
							<asp:ListItem Value="TransactionTypeList">TransactionTypeList</asp:ListItem>
							<asp:ListItem Value="TransitionAccountDetails">TransitionAccountDetails</asp:ListItem>
							<asp:ListItem Value="UserAuditList">UserAuditList</asp:ListItem>
							<asp:ListItem Value="UserList">UserList</asp:ListItem>
							<asp:ListItem Value="UserRoleAssignmentList">UserRoleAssignmentList</asp:ListItem>
							<asp:ListItem Value="UserRoleList">UserRoleList</asp:ListItem>
							<asp:ListItem Value="UserRoleTypeList">UserRoleTypeList</asp:ListItem>
						</asp:dropdownlist>
					</td>
					<td>
						<DropDownLists:WebDropDownList_AgencyCommissionIncomeAccountDetails id="com_AgencyCommissionIncomeAccountDetails" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_AgencyCommissionIncomeAccountDetails>
						<DropDownLists:WebDropDownList_AgencyDifferenceIncomeAccountDetails id="com_AgencyDifferenceIncomeAccountDetails" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_AgencyDifferenceIncomeAccountDetails>
						<DropDownLists:WebDropDownList_AgencyExchangeRateList id="com_AgencyExchangeRateList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_AgencyExchangeRateList>
						<DropDownLists:WebDropDownList_AgentAccountDetails id="com_AgentAccountDetails" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_AgentAccountDetails>
						<DropDownLists:WebDropDownList_AgentAccountType id="com_AgentAccountType" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_AgentAccountType>
						<DropDownLists:WebDropDownList_AgentAvailablePaymentModeList id="com_AgentAvailablePaymentModeList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_AgentAvailablePaymentModeList>
						<DropDownLists:WebDropDownList_AgentCommissionIncomeAccount id="com_AgentCommissionIncomeAccount" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_AgentCommissionIncomeAccount>
						<DropDownLists:WebDropDownList_AgentCommissionSplitList id="com_AgentCommissionSplitList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_AgentCommissionSplitList>
						<DropDownLists:WebDropDownList_AgentExchangeRateList id="com_AgentExchangeRateList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_AgentExchangeRateList>
						<DropDownLists:WebDropDownList_AgentGroupList id="com_AgentGroupList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_AgentGroupList>
						<DropDownLists:WebDropDownList_AgentLocationList id="com_AgentLocationList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_AgentLocationList>
						<DropDownLists:WebDropDownList_AgentMaster id="com_AgentMaster" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_AgentMaster>
						<DropDownLists:WebDropDownList_BankExchangeRateList id="com_BankExchangeRateList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_BankExchangeRateList>
						<DropDownLists:WebDropDownList_BankList id="com_BankList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_BankList>
						<DropDownLists:WebDropDownList_BeneficeryBankList id="com_BeneficeryBankList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_BeneficeryBankList>
						<DropDownLists:WebDropDownList_CommissionCurrencyType id="com_CommissionCurrencyType" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_CommissionCurrencyType>
						<DropDownLists:WebDropDownList_CommissionSlabMaster id="com_CommissionSlabMaster" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_CommissionSlabMaster>
						<DropDownLists:WebDropDownList_CommissionSplitTypeList id="com_CommissionSplitTypeList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_CommissionSplitTypeList>
						<DropDownLists:WebDropDownList_CountryAllowedOutboundCurrencyList id="com_CountryAllowedOutboundCurrencyList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_CountryAllowedOutboundCurrencyList>
						<DropDownLists:WebDropDownList_CountryAvailablePaymentModeList id="com_CountryAvailablePaymentModeList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_CountryAvailablePaymentModeList>
						<DropDownLists:WebDropDownList_CountryList id="com_CountryList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_CountryList>
						<DropDownLists:WebDropDownList_CountryTransactionPermissionList id="com_CountryTransactionPermissionList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_CountryTransactionPermissionList>
						<DropDownLists:WebDropDownList_CountryTransactionPermissionTypeList id="com_CountryTransactionPermissionTypeList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_CountryTransactionPermissionTypeList>
						<DropDownLists:WebDropDownList_CurrencyExchangeType id="com_CurrencyExchangeType" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_CurrencyExchangeType>
						<DropDownLists:WebDropDownList_CurrencyList id="com_CurrencyList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_CurrencyList>
						<DropDownLists:WebDropDownList_CustomerCardList id="com_CustomerCardList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_CustomerCardList>
						<DropDownLists:WebDropDownList_CustomerCardStatusList id="com_CustomerCardStatusList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_CustomerCardStatusList>
						<DropDownLists:WebDropDownList_CustomerList id="com_CustomerList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_CustomerList>
						<DropDownLists:WebDropDownList_CustomerLoyaltyPointsAccumulationHistory id="com_CustomerLoyaltyPointsAccumulationHistory" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_CustomerLoyaltyPointsAccumulationHistory>
						<DropDownLists:WebDropDownList_CustomerLoyaltyPointsRedeemHistory id="com_CustomerLoyaltyPointsRedeemHistory" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_CustomerLoyaltyPointsRedeemHistory>
						<DropDownLists:WebDropDownList_EntityList id="com_EntityList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_EntityList>
						<DropDownLists:WebDropDownList_GlobalSettings id="com_GlobalSettings" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_GlobalSettings>
						<DropDownLists:WebDropDownList_LocationList id="com_LocationList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_LocationList>
						<DropDownLists:WebDropDownList_LocationTree id="com_LocationTree" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_LocationTree>
						<DropDownLists:WebDropDownList_MasterCountryList id="com_MasterCountryList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_MasterCountryList>
						<DropDownLists:WebDropDownList_MasterModuleList id="com_MasterModuleList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_MasterModuleList>
						<DropDownLists:WebDropDownList_OFACBannedNameList id="com_OFACBannedNameList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_OFACBannedNameList>
						<DropDownLists:WebDropDownList_PayInAgentDifferenceIncomeAccount id="com_PayInAgentDifferenceIncomeAccount" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_PayInAgentDifferenceIncomeAccount>
						<DropDownLists:WebDropDownList_PaymentHistory id="com_PaymentHistory" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_PaymentHistory>
						<DropDownLists:WebDropDownList_PaymentModeBaseTypeList id="com_PaymentModeBaseTypeList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_PaymentModeBaseTypeList>
						<DropDownLists:WebDropDownList_PaymentModeList id="com_PaymentModeList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_PaymentModeList>
						<DropDownLists:WebDropDownList_PaymentType id="com_PaymentType" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_PaymentType>
						<DropDownLists:WebDropDownList_ProductsList id="com_ProductsList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_ProductsList>
						<DropDownLists:WebDropDownList_PurposeOfTransferList id="com_PurposeOfTransferList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_PurposeOfTransferList>
						<DropDownLists:WebDropDownList_TransactionDetails id="com_TransactionDetails" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_TransactionDetails>
						<DropDownLists:WebDropDownList_TransactionDraftList id="com_TransactionDraftList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_TransactionDraftList>
						<DropDownLists:WebDropDownList_TransactionModificationMessageList id="com_TransactionModificationMessageList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_TransactionModificationMessageList>
						<DropDownLists:WebDropDownList_TransactionSettlementHistory id="com_TransactionSettlementHistory" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_TransactionSettlementHistory>
						<DropDownLists:WebDropDownList_TransactionSettlementStatusList id="com_TransactionSettlementStatusList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_TransactionSettlementStatusList>
						<DropDownLists:WebDropDownList_TransactionStatusList id="com_TransactionStatusList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_TransactionStatusList>
						<DropDownLists:WebDropDownList_TransactionTypeList id="com_TransactionTypeList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_TransactionTypeList>
						<DropDownLists:WebDropDownList_TransitionAccountDetails id="com_TransitionAccountDetails" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_TransitionAccountDetails>
						<DropDownLists:WebDropDownList_UserAuditList id="com_UserAuditList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_UserAuditList>
						<DropDownLists:WebDropDownList_UserList id="com_UserList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_UserList>
						<DropDownLists:WebDropDownList_UserRoleAssignmentList id="com_UserRoleAssignmentList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_UserRoleAssignmentList>
						<DropDownLists:WebDropDownList_UserRoleList id="com_UserRoleList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_UserRoleList>
						<DropDownLists:WebDropDownList_UserRoleTypeList id="com_UserRoleTypeList" style="Z-INDEX: 0" runat="server" CssClass="RecordsDropDownStyle" Visible="False" AutoPostBack="True">
						</DropDownLists:WebDropDownList_UserRoleTypeList>
					</td>
					<td>
						<input id="cmdAddNewRecord" type="button" value="Add a new record" language="javascript" onclick="return cmdAddNewRecord_onclick()" class="AddNewRecordButtonStyle">
					</td>
				</tr>
			</table>
		</form>
	</body>
</html>
