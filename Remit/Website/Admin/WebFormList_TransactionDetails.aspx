<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_TransactionDetails.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_TransactionDetails" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>TransactionDetails table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_TransactionDetails" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				<tr class="TableFilter" align="middle">
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_CustomerList id="com_CustomerId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CustomerList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_CustomerList id="com_BeneficeryId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CustomerList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_BeneficeryBankList id="com_BeneficeryBankId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_BeneficeryBankList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_PaymentModeList id="com_PaymentMode" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_PaymentModeList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_PurposeOfTransferList id="com_PurposeOfTransfer" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_PurposeOfTransferList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_CurrencyList id="com_PayInCurrencyId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CurrencyList>
					</td>
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_CurrencyList id="com_PayOutCurrencyId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CurrencyList>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_BankList id="com_AssociatedBankId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_BankList>
					</td>
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_UserList id="com_PayInAgentUserId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_UserList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_AgentLocationList id="com_PayInAgentLocationId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_AgentLocationList>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_UserList id="com_PayOutAgentUserId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_UserList>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_TransactionStatusList id="com_Status" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_TransactionStatusList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_TransactionSettlementStatusList id="com_SettlementStatus" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_TransactionSettlementStatusList>
					</td>
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_TransactionDetails.aspx?Action=Add&ReturnToUrl=WebFormList_TransactionDetails.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_Id" runat="server" CssClass="TableHeader" EnableViewState="false">
							Id (update this label in the 'Olymars/ColumnLabel' extended property of the 'Id' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_VoucherNumber" runat="server" CssClass="TableHeader" EnableViewState="false">
							VoucherNumber (update this label in the 'Olymars/ColumnLabel' extended property of the 'VoucherNumber' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_TransactionNumber" runat="server" CssClass="TableHeader" EnableViewState="false">
							TransactionNumber (update this label in the 'Olymars/ColumnLabel' extended property of the 'TransactionNumber' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_CustomerId" runat="server" CssClass="TableHeader" EnableViewState="false">
							CustomerId (update this label in the 'Olymars/ColumnLabel' extended property of the 'CustomerId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_BeneficeryId" runat="server" CssClass="TableHeader" EnableViewState="false">
							BeneficeryId (update this label in the 'Olymars/ColumnLabel' extended property of the 'BeneficeryId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_BeneficeryBankId" runat="server" CssClass="TableHeader" EnableViewState="false">
							BeneficeryBankId (update this label in the 'Olymars/ColumnLabel' extended property of the 'BeneficeryBankId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PaymentMode" runat="server" CssClass="TableHeader" EnableViewState="false">
							PaymentMode (update this label in the 'Olymars/ColumnLabel' extended property of the 'PaymentMode' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PurposeOfTransfer" runat="server" CssClass="TableHeader" EnableViewState="false">
							PurposeOfTransfer (update this label in the 'Olymars/ColumnLabel' extended property of the 'PurposeOfTransfer' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayInCurrencyId" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayInCurrencyId (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayInCurrencyId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayInAmount" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayInAmount (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayInAmount' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayOutCurrencyId" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayOutCurrencyId (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayOutCurrencyId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayOutAmount" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayOutAmount (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayOutAmount' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Commission" runat="server" CssClass="TableHeader" EnableViewState="false">
							Commission (update this label in the 'Olymars/ColumnLabel' extended property of the 'Commission' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Question" runat="server" CssClass="TableHeader" EnableViewState="false">
							Question (update this label in the 'Olymars/ColumnLabel' extended property of the 'Question' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Answer" runat="server" CssClass="TableHeader" EnableViewState="false">
							Answer (update this label in the 'Olymars/ColumnLabel' extended property of the 'Answer' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_MessageToBeneficery" runat="server" CssClass="TableHeader" EnableViewState="false">
							MessageToBeneficery (update this label in the 'Olymars/ColumnLabel' extended property of the 'MessageToBeneficery' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_MessageToPayOutAgent" runat="server" CssClass="TableHeader" EnableViewState="false">
							MessageToPayOutAgent (update this label in the 'Olymars/ColumnLabel' extended property of the 'MessageToPayOutAgent' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_BankExchangeRateForPayInCurrency" runat="server" CssClass="TableHeader" EnableViewState="false">
							BankExchangeRateForPayInCurrency (update this label in the 'Olymars/ColumnLabel' extended property of the 'BankExchangeRateForPayInCurrency' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_BankExchangeRateForPayOutCurrency" runat="server" CssClass="TableHeader" EnableViewState="false">
							BankExchangeRateForPayOutCurrency (update this label in the 'Olymars/ColumnLabel' extended property of the 'BankExchangeRateForPayOutCurrency' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayInCurrencyGroup" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayInCurrencyGroup (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayInCurrencyGroup' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayOutCurrencyGroup" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayOutCurrencyGroup (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayOutCurrencyGroup' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_FinalBankExchangeRate" runat="server" CssClass="TableHeader" EnableViewState="false">
							FinalBankExchangeRate (update this label in the 'Olymars/ColumnLabel' extended property of the 'FinalBankExchangeRate' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_AgencyMarginPercent" runat="server" CssClass="TableHeader" EnableViewState="false">
							AgencyMarginPercent (update this label in the 'Olymars/ColumnLabel' extended property of the 'AgencyMarginPercent' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_AgencyExchangeRate" runat="server" CssClass="TableHeader" EnableViewState="false">
							AgencyExchangeRate (update this label in the 'Olymars/ColumnLabel' extended property of the 'AgencyExchangeRate' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_AgentMarginPercent" runat="server" CssClass="TableHeader" EnableViewState="false">
							AgentMarginPercent (update this label in the 'Olymars/ColumnLabel' extended property of the 'AgentMarginPercent' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_AgentExchangeRate" runat="server" CssClass="TableHeader" EnableViewState="false">
							AgentExchangeRate (update this label in the 'Olymars/ColumnLabel' extended property of the 'AgentExchangeRate' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_AssociatedBankId" runat="server" CssClass="TableHeader" EnableViewState="false">
							AssociatedBankId (update this label in the 'Olymars/ColumnLabel' extended property of the 'AssociatedBankId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayOutLocationId" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayOutLocationId (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayOutLocationId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayInAgentUserId" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayInAgentUserId (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayInAgentUserId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayInAgentLocationId" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayInAgentLocationId (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayInAgentLocationId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayInDateTime" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayInDateTime (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayInDateTime' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_RecommendedPayOutAgentId" runat="server" CssClass="TableHeader" EnableViewState="false">
							RecommendedPayOutAgentId (update this label in the 'Olymars/ColumnLabel' extended property of the 'RecommendedPayOutAgentId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_ActualPayOutAgentId" runat="server" CssClass="TableHeader" EnableViewState="false">
							ActualPayOutAgentId (update this label in the 'Olymars/ColumnLabel' extended property of the 'ActualPayOutAgentId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayOutAgentUserId" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayOutAgentUserId (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayOutAgentUserId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayOutDateTime" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayOutDateTime (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayOutDateTime' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_CollectedBeneficeryIdDetails" runat="server" CssClass="TableHeader" EnableViewState="false">
							CollectedBeneficeryIdDetails (update this label in the 'Olymars/ColumnLabel' extended property of the 'CollectedBeneficeryIdDetails' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_IsOpenTransaction" runat="server" CssClass="TableHeader" EnableViewState="false">
							IsOpenTransaction (update this label in the 'Olymars/ColumnLabel' extended property of the 'IsOpenTransaction' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Status" runat="server" CssClass="TableHeader" EnableViewState="false">
							Status (update this label in the 'Olymars/ColumnLabel' extended property of the 'Status' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_SettlementStatus" runat="server" CssClass="TableHeader" EnableViewState="false">
							SettlementStatus (update this label in the 'Olymars/ColumnLabel' extended property of the 'SettlementStatus' column)
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_TransactionDetails_SelectDisplay id="repeater_TransactionDetails_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_TransactionDetails.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_TransactionDetails.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_TransactionDetails.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_TransactionDetails.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Id") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "VoucherNumber") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "TransactionNumber") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "CustomerId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "BeneficeryId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "BeneficeryBankId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PaymentMode_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PurposeOfTransfer_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayInCurrencyId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayInAmount") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayOutCurrencyId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayOutAmount") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Commission") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Question") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Answer") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "MessageToBeneficery") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "MessageToPayOutAgent") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "BankExchangeRateForPayInCurrency") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "BankExchangeRateForPayOutCurrency") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayInCurrencyGroup") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayOutCurrencyGroup") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "FinalBankExchangeRate") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "AgencyMarginPercent") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "AgencyExchangeRate") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "AgentMarginPercent") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "AgentExchangeRate") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "AssociatedBankId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayOutLocationId") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayInAgentUserId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayInAgentLocationId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayInDateTime") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "RecommendedPayOutAgentId") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "ActualPayOutAgentId") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayOutAgentUserId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayOutDateTime") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "CollectedBeneficeryIdDetails") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "IsOpenTransaction") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Status_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "SettlementStatus_Display") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_TransactionDetails_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>
