<%@ Page language="c#" Codebehind="WebForm_AgentCommissionIncomeAccount.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebForm_AgentCommissionIncomeAccount" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
	<head>
		<title>AgentCommissionIncomeAccount table content management</title>
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
			<form id="WebForm_AgentCommissionIncomeAccount" method="post" runat="server">
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
							CreditDateTime (update this label in the 'Olymars/ColumnLabel' extended property of the 'CreditDateTime' column)
						</td>
						<td>
							<asp:TextBox id="txt_CreditDateTime" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="2" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_CreditDateTime" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							DebitDateTime (update this label in the 'Olymars/ColumnLabel' extended property of the 'DebitDateTime' column)
						</td>
						<td>
							<asp:TextBox id="txt_DebitDateTime" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="3" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_DebitDateTime" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							AgentAccountId (update this label in the 'Olymars/ColumnLabel' extended property of the 'AgentAccountId' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_AgentMaster id="com_AgentAccountId" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="4">
							</DropDownLists:WebDropDownList_AgentMaster>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							TransactionId (update this label in the 'Olymars/ColumnLabel' extended property of the 'TransactionId' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_TransactionDetails id="com_TransactionId" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="5">
							</DropDownLists:WebDropDownList_TransactionDetails>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							CommissionCreditLC (update this label in the 'Olymars/ColumnLabel' extended property of the 'CommissionCreditLC' column)
						</td>
						<td>
							<asp:TextBox id="txt_CommissionCreditLC" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="6" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_CommissionCreditLC" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							CommissionCreditUSD (update this label in the 'Olymars/ColumnLabel' extended property of the 'CommissionCreditUSD' column)
						</td>
						<td>
							<asp:TextBox id="txt_CommissionCreditUSD" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="7" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_CommissionCreditUSD" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							CommissionDebitLC (update this label in the 'Olymars/ColumnLabel' extended property of the 'CommissionDebitLC' column)
						</td>
						<td>
							<asp:TextBox id="txt_CommissionDebitLC" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="8" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_CommissionDebitLC" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							CommissionDebitUSD (update this label in the 'Olymars/ColumnLabel' extended property of the 'CommissionDebitUSD' column)
						</td>
						<td>
							<asp:TextBox id="txt_CommissionDebitUSD" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="9" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_CommissionDebitUSD" CssClass="ErrorStyle"></asp:Label>
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
										<asp:Button id="cmdRefresh" runat="server" Text="Refresh" CssClass="ButtonStyle" tabIndex="10"></asp:Button>
									</td>
									<td>
										<asp:Button id="cmdDelete" runat="server" Text="Delete" CssClass="ButtonStyle" tabIndex="11"></asp:Button>
									</td>
									<td>
										<asp:Button id="cmdUpdate" runat="server" Text="Update" CssClass="ButtonStyle" tabIndex="12"></asp:Button>
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
