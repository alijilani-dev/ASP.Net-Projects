﻿<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_AgencyExchangeRateList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_AgencyExchangeRateList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>AgencyExchangeRateList table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_AgencyExchangeRateList" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				<tr class="TableFilter" align="middle">
					<td>
					</td>
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_CountryList id="com_PayInCountryId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CountryList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_CountryList id="com_PayOutCountryId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CountryList>
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
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_AgencyExchangeRateList.aspx?Action=Add&ReturnToUrl=WebFormList_AgencyExchangeRateList.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_ExchangeSetName" runat="server" CssClass="TableHeader" EnableViewState="false">
							ExchangeSetName
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayInCountryId" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayInCountryId
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayOutCountryId" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayOutCountryId
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayOutCurrencyId" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayOutCurrencyId 
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_MarginPercent" runat="server" CssClass="TableHeader" EnableViewState="false">
							MarginPercent
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_MaximumAgentMargin" runat="server" CssClass="TableHeader" EnableViewState="false">
							MaximumAgentMargin
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_MinimumAgentMargin" runat="server" CssClass="TableHeader" EnableViewState="false">
							MinimumAgentMargin 
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_AgencyExchangeRateList_SelectDisplay id="repeater_AgencyExchangeRateList_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_AgencyExchangeRateList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_AgencyExchangeRateList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_AgencyExchangeRateList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_AgencyExchangeRateList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "ExchangeSetName") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayInCountryId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayOutCountryId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayOutCurrencyId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "MarginPercent") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "MaximumAgentMargin") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "MinimumAgentMargin") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_AgencyExchangeRateList_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>