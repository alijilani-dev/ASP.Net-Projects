﻿<%@ Page language="c#" Codebehind="WebForm_PaymentModeList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebForm_PaymentModeList" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
	<head>
		<title>PaymentModeList table content management</title>
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
			<form id="WebForm_PaymentModeList" method="post" runat="server">
				<table border="0" cellspacing="10" cellpadding="5">
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							Name
						</td>
						<td>
							<asp:TextBox id="txt_Name" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="1" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_Name" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							Value
						</td>
						<td>
							<asp:TextBox id="txt_Value" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="2" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_Value" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							BaseType
						</td>
						<td>
							<DropDownLists:WebDropDownList_PaymentModeBaseTypeList id="com_BaseType" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="3">
							</DropDownLists:WebDropDownList_PaymentModeBaseTypeList>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							ChannelThrough
						</td>
						<td>
							<DropDownLists:WebDropDownList_EntityList id="com_ChannelThrough" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="4">
							</DropDownLists:WebDropDownList_EntityList>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							FinalEntity
						</td>
						<td>
							<DropDownLists:WebDropDownList_EntityList id="com_FinalEntity" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="5">
							</DropDownLists:WebDropDownList_EntityList>
						</td>
					</tr>
					<tr>
						<td align="Right" class="OptionalLabelStyle">
							Prefix
						</td>
						<td>
							<asp:TextBox id="txt_Prefix" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="6" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_Prefix" CssClass="ErrorStyle"></asp:Label>
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