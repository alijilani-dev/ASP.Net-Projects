<%@ Page language="c#" Codebehind="WebForm_AgentCommissionSplitList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebForm_AgentCommissionSplitList" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
	<head>
		<title>AgentCommissionSplitList table content management</title>
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
			<form id="WebForm_AgentCommissionSplitList" method="post" runat="server">
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
							CurrentAccountId (update this label in the 'Olymars/ColumnLabel' extended property of the 'CurrentAccountId' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_AgentMaster id="com_CurrentAccountId" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="2">
							</DropDownLists:WebDropDownList_AgentMaster>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							EndNodeAccountId (update this label in the 'Olymars/ColumnLabel' extended property of the 'EndNodeAccountId' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_AgentMaster id="com_EndNodeAccountId" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="3">
							</DropDownLists:WebDropDownList_AgentMaster>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							PayInCommission (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayInCommission' column)
						</td>
						<td>
							<asp:TextBox id="txt_PayInCommission" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="4" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_PayInCommission" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							PayOutCommission (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayOutCommission' column)
						</td>
						<td>
							<asp:TextBox id="txt_PayOutCommission" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="5" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_PayOutCommission" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							Level (update this label in the 'Olymars/ColumnLabel' extended property of the 'Level' column)
						</td>
						<td>
							<asp:TextBox id="txt_Level" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="6" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_Level" CssClass="ErrorStyle"></asp:Label>
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
										<asp:Button id="cmdRefresh" runat="server" Text="Refresh" CssClass="ButtonStyle" tabIndex="7"></asp:Button>
									</td>
									<td>
										<asp:Button id="cmdDelete" runat="server" Text="Delete" CssClass="ButtonStyle" tabIndex="8"></asp:Button>
									</td>
									<td>
										<asp:Button id="cmdUpdate" runat="server" Text="Update" CssClass="ButtonStyle" tabIndex="9"></asp:Button>
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
