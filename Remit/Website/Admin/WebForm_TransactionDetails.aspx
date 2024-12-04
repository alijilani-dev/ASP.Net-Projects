<%@ Page language="c#" Codebehind="WebForm_TransactionDetails.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebForm_TransactionDetails" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
	<head>
		<title>TransactionDetails table content management</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link href="StyleSheet.css" type="text/css" rel="stylesheet">
	</head>
	<body class="FormStyle">
		<asp:panel id="ErrorDisplay" runat="server" visible="false">
			<asp:Label id="lab_Error" runat="server" CssClass="ErrorDisplayStyle"></asp:Label>
		</asp:panel>
		<asp:HyperLink id="ReturnURL" runat="server" CssClass="EditHyperLink" EnableViewState="true" Visible="false" NavigateUrl="" Text="Return">
		</asp:HyperLink>
		<asp:panel id="MainDisplay" runat="server">
			<form id="WebForm_TransactionDetails" method="post" runat="server">
				<table border="0" cellspacing="10" cellpadding="5">
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							Id (update this label in the 'Olymars/ColumnLabel' extended property of the 'Id' column)
						</td>
						<td>
							<asp:TextBox id="txt_Id" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="1" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_Id" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							VoucherNumber (update this label in the 'Olymars/ColumnLabel' extended property of the 'VoucherNumber' column)
						</td>
						<td>
							<asp:TextBox id="txt_VoucherNumber" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="2" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_VoucherNumber" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							TransactionNumber (update this label in the 'Olymars/ColumnLabel' extended property of the 'TransactionNumber' column)
						</td>
						<td>
							<asp:TextBox id="txt_TransactionNumber" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="3" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_TransactionNumber" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							CustomerId (update this label in the 'Olymars/ColumnLabel' extended property of the 'CustomerId' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_CustomerList id="com_CustomerId" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="4">
							</DropDownLists:WebDropDownList_CustomerList>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							BeneficeryId (update this label in the 'Olymars/ColumnLabel' extended property of the 'BeneficeryId' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_CustomerList id="com_BeneficeryId" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="5">
							</DropDownLists:WebDropDownList_CustomerList>
						</td>
					</tr>
					<tr>
						<td align="Right" class="OptionalLabelStyle">
							BeneficeryBankId (update this label in the 'Olymars/ColumnLabel' extended property of the 'BeneficeryBankId' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_BeneficeryBankList id="com_BeneficeryBankId" runat="server" CssClass="OptionalComboBoxStyle" tabIndex="6">
							</DropDownLists:WebDropDownList_BeneficeryBankList>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							PaymentMode (update this label in the 'Olymars/ColumnLabel' extended property of the 'PaymentMode' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_PaymentModeList id="com_PaymentMode" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="7">
							</DropDownLists:WebDropDownList_PaymentModeList>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							PurposeOfTransfer (update this label in the 'Olymars/ColumnLabel' extended property of the 'PurposeOfTransfer' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_PurposeOfTransferList id="com_PurposeOfTransfer" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="8">
							</DropDownLists:WebDropDownList_PurposeOfTransferList>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							PayInCurrencyId (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayInCurrencyId' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_CurrencyList id="com_PayInCurrencyId" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="9">
							</DropDownLists:WebDropDownList_CurrencyList>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							PayInAmount (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayInAmount' column)
						</td>
						<td>
							<asp:TextBox id="txt_PayInAmount" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="10" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_PayInAmount" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							PayOutCurrencyId (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayOutCurrencyId' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_CurrencyList id="com_PayOutCurrencyId" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="11">
							</DropDownLists:WebDropDownList_CurrencyList>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							PayOutAmount (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayOutAmount' column)
						</td>
						<td>
							<asp:TextBox id="txt_PayOutAmount" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="12" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_PayOutAmount" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							Commission (update this label in the 'Olymars/ColumnLabel' extended property of the 'Commission' column)
						</td>
						<td>
							<asp:TextBox id="txt_Commission" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="13" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_Commission" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="OptionalLabelStyle">
							Question (update this label in the 'Olymars/ColumnLabel' extended property of the 'Question' column)
						</td>
						<td>
							<asp:TextBox id="txt_Question" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="14" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_Question" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="OptionalLabelStyle">
							Answer (update this label in the 'Olymars/ColumnLabel' extended property of the 'Answer' column)
						</td>
						<td>
							<asp:TextBox id="txt_Answer" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="15" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_Answer" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="OptionalLabelStyle">
							MessageToBeneficery (update this label in the 'Olymars/ColumnLabel' extended property of the 'MessageToBeneficery' column)
						</td>
						<td>
							<asp:TextBox id="txt_MessageToBeneficery" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="16" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_MessageToBeneficery" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="OptionalLabelStyle">
							MessageToPayOutAgent (update this label in the 'Olymars/ColumnLabel' extended property of the 'MessageToPayOutAgent' column)
						</td>
						<td>
							<asp:TextBox id="txt_MessageToPayOutAgent" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="17" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_MessageToPayOutAgent" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							BankExchangeRateForPayInCurrency (update this label in the 'Olymars/ColumnLabel' extended property of the 'BankExchangeRateForPayInCurrency' column)
						</td>
						<td>
							<asp:TextBox id="txt_BankExchangeRateForPayInCurrency" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="18" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_BankExchangeRateForPayInCurrency" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							BankExchangeRateForPayOutCurrency (update this label in the 'Olymars/ColumnLabel' extended property of the 'BankExchangeRateForPayOutCurrency' column)
						</td>
						<td>
							<asp:TextBox id="txt_BankExchangeRateForPayOutCurrency" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="19" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_BankExchangeRateForPayOutCurrency" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							PayInCurrencyGroup (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayInCurrencyGroup' column)
						</td>
						<td>
							<asp:TextBox id="txt_PayInCurrencyGroup" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="20" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_PayInCurrencyGroup" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							PayOutCurrencyGroup (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayOutCurrencyGroup' column)
						</td>
						<td>
							<asp:TextBox id="txt_PayOutCurrencyGroup" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="21" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_PayOutCurrencyGroup" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							FinalBankExchangeRate (update this label in the 'Olymars/ColumnLabel' extended property of the 'FinalBankExchangeRate' column)
						</td>
						<td>
							<asp:TextBox id="txt_FinalBankExchangeRate" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="22" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_FinalBankExchangeRate" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							AgencyMarginPercent (update this label in the 'Olymars/ColumnLabel' extended property of the 'AgencyMarginPercent' column)
						</td>
						<td>
							<asp:TextBox id="txt_AgencyMarginPercent" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="23" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_AgencyMarginPercent" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="OptionalLabelStyle">
							AgencyExchangeRate (update this label in the 'Olymars/ColumnLabel' extended property of the 'AgencyExchangeRate' column)
						</td>
						<td>
							<asp:TextBox id="txt_AgencyExchangeRate" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="24" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_AgencyExchangeRate" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							AgentMarginPercent (update this label in the 'Olymars/ColumnLabel' extended property of the 'AgentMarginPercent' column)
						</td>
						<td>
							<asp:TextBox id="txt_AgentMarginPercent" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="25" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_AgentMarginPercent" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="OptionalLabelStyle">
							AgentExchangeRate (update this label in the 'Olymars/ColumnLabel' extended property of the 'AgentExchangeRate' column)
						</td>
						<td>
							<asp:TextBox id="txt_AgentExchangeRate" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="26" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_AgentExchangeRate" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="OptionalLabelStyle">
							AssociatedBankId (update this label in the 'Olymars/ColumnLabel' extended property of the 'AssociatedBankId' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_BankList id="com_AssociatedBankId" runat="server" CssClass="OptionalComboBoxStyle" tabIndex="27">
							</DropDownLists:WebDropDownList_BankList>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							PayOutLocationId (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayOutLocationId' column)
						</td>
						<td>
							<asp:TextBox id="txt_PayOutLocationId" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="28" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_PayOutLocationId" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							PayInAgentUserId (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayInAgentUserId' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_UserList id="com_PayInAgentUserId" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="29">
							</DropDownLists:WebDropDownList_UserList>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							PayInAgentLocationId (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayInAgentLocationId' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_AgentLocationList id="com_PayInAgentLocationId" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="30">
							</DropDownLists:WebDropDownList_AgentLocationList>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							PayInDateTime (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayInDateTime' column)
						</td>
						<td>
							<asp:TextBox id="txt_PayInDateTime" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="31" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_PayInDateTime" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							RecommendedPayOutAgentId (update this label in the 'Olymars/ColumnLabel' extended property of the 'RecommendedPayOutAgentId' column)
						</td>
						<td>
							<asp:TextBox id="txt_RecommendedPayOutAgentId" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="32" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_RecommendedPayOutAgentId" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="OptionalLabelStyle">
							ActualPayOutAgentId (update this label in the 'Olymars/ColumnLabel' extended property of the 'ActualPayOutAgentId' column)
						</td>
						<td>
							<asp:TextBox id="txt_ActualPayOutAgentId" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="33" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_ActualPayOutAgentId" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="OptionalLabelStyle">
							PayOutAgentUserId (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayOutAgentUserId' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_UserList id="com_PayOutAgentUserId" runat="server" CssClass="OptionalComboBoxStyle" tabIndex="34">
							</DropDownLists:WebDropDownList_UserList>
						</td>
					</tr>
					<tr>
						<td align="Right" class="OptionalLabelStyle">
							PayOutDateTime (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayOutDateTime' column)
						</td>
						<td>
							<asp:TextBox id="txt_PayOutDateTime" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="35" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_PayOutDateTime" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="OptionalLabelStyle">
							CollectedBeneficeryIdDetails (update this label in the 'Olymars/ColumnLabel' extended property of the 'CollectedBeneficeryIdDetails' column)
						</td>
						<td>
							<asp:TextBox id="txt_CollectedBeneficeryIdDetails" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="36" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_CollectedBeneficeryIdDetails" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td>
						</td>
						<td>
							<asp:CheckBox id="chk_IsOpenTransaction" runat="server" Text="IsOpenTransaction (update this label in the 'Olymars/ColumnLabel' extended property of the 'IsOpenTransaction' column)" CssClass="MandatoryCheckBoxStyle" tabIndex="37"></asp:CheckBox>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							Status (update this label in the 'Olymars/ColumnLabel' extended property of the 'Status' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_TransactionStatusList id="com_Status" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="38">
							</DropDownLists:WebDropDownList_TransactionStatusList>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							SettlementStatus (update this label in the 'Olymars/ColumnLabel' extended property of the 'SettlementStatus' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_TransactionSettlementStatusList id="com_SettlementStatus" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="39">
							</DropDownLists:WebDropDownList_TransactionSettlementStatusList>
						</td>
					</tr>
					<tr>
					</tr>
					<tr>
						<td>
						</td>
						<td align="center">
							<table border="0" cellspacing="10" cellpadding="5">
								<tr align="center">
									<td>
										<asp:Button id="cmdRefresh" runat="server" Text="Refresh" CssClass="ButtonStyle" tabIndex="40"></asp:Button>
									</td>
									<td>
										<asp:Button id="cmdDelete" runat="server" Text="Delete" CssClass="ButtonStyle" tabIndex="41"></asp:Button>
									</td>
									<td>
										<asp:Button id="cmdUpdate" runat="server" Text="Update" CssClass="ButtonStyle" tabIndex="42"></asp:Button>
									</td>
								</tr>
							</table>
						</td>
					</tr>
				</table>
			</form>
		</asp:panel>
	</body>
</html>
