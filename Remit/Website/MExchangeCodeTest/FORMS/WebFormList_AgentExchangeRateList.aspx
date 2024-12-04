<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_AgentExchangeRateList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_AgentExchangeRateList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>AgentExchangeRateList table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_AgentExchangeRateList" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				<tr class="TableFilter" align="middle">
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_AgentMaster id="com_AgentAccountId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_AgentMaster>
					</td>
					<td>
						<DropDownLists:WebDropDownList_AgencyExchangeRateList id="com_AgencyExchangeRateId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_AgencyExchangeRateList>
					</td>
					<td>
					</td>
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_AgentExchangeRateList.aspx?Action=Add&ReturnToUrl=WebFormList_AgentExchangeRateList.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_AgentAccountId" runat="server" CssClass="TableHeader" EnableViewState="false">
							AgentAccount
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_AgencyExchangeRateId" runat="server" CssClass="TableHeader" EnableViewState="false">
							AgencyExchangeRate
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_MarginPercent" runat="server" CssClass="TableHeader" EnableViewState="false">
							MarginPercent
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_AgentExchangeRateList_SelectDisplay id="repeater_AgentExchangeRateList_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_AgentExchangeRateList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_AgentExchangeRateList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_AgentExchangeRateList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_AgentExchangeRateList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "AgentAccountId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "AgencyExchangeRateId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "MarginPercent") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_AgentExchangeRateList_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>
