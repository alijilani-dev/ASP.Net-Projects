<%@ Page language="c#" Codebehind="WebForm_AgencyDifferenceIncomeAccountDetails.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebForm_AgencyDifferenceIncomeAccountDetails" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
	<head>
		<title>AgencyDifferenceIncomeAccountDetails table content management</title>
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
			<form id="WebForm_AgencyDifferenceIncomeAccountDetails" method="post" runat="server">
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
						<td align="Right" class="OptionalLabelStyle">
							CreditDateTime (update this label in the 'Olymars/ColumnLabel' extended property of the 'CreditDateTime' column)
						</td>
						<td>
							<asp:TextBox id="txt_CreditDateTime" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="2" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_CreditDateTime" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="OptionalLabelStyle">
							DebitDateTime (update this label in the 'Olymars/ColumnLabel' extended property of the 'DebitDateTime' column)
						</td>
						<td>
							<asp:TextBox id="txt_DebitDateTime" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="3" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_DebitDateTime" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							TransactionId (update this label in the 'Olymars/ColumnLabel' extended property of the 'TransactionId' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_TransactionDetails id="com_TransactionId" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="4">
							</DropDownLists:WebDropDownList_TransactionDetails>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							CreditLC (update this label in the 'Olymars/ColumnLabel' extended property of the 'CreditLC' column)
						</td>
						<td>
							<asp:TextBox id="txt_CreditLC" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="5" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_CreditLC" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							CreditUSD (update this label in the 'Olymars/ColumnLabel' extended property of the 'CreditUSD' column)
						</td>
						<td>
							<asp:TextBox id="txt_CreditUSD" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="6" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_CreditUSD" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							DebitLC (update this label in the 'Olymars/ColumnLabel' extended property of the 'DebitLC' column)
						</td>
						<td>
							<asp:TextBox id="txt_DebitLC" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="7" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_DebitLC" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							DebitUSD (update this label in the 'Olymars/ColumnLabel' extended property of the 'DebitUSD' column)
						</td>
						<td>
							<asp:TextBox id="txt_DebitUSD" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="8" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_DebitUSD" CssClass="ErrorStyle"></asp:Label>
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
										<asp:Button id="cmdRefresh" runat="server" Text="Refresh" CssClass="ButtonStyle" tabIndex="9"></asp:Button>
									</td>
									<td>
										<asp:Button id="cmdDelete" runat="server" Text="Delete" CssClass="ButtonStyle" tabIndex="10"></asp:Button>
									</td>
									<td>
										<asp:Button id="cmdUpdate" runat="server" Text="Update" CssClass="ButtonStyle" tabIndex="11"></asp:Button>
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
