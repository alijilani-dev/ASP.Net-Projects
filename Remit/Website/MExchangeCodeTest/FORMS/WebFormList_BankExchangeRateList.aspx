<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_BankExchangeRateList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_BankExchangeRateList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>BankExchangeRateList table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_BankExchangeRateList" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				<tr class="TableFilter" align="middle">
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_CurrencyList id="com_CurrencyId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CurrencyList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_CurrencyExchangeType id="com_ExchangeType" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CurrencyExchangeType>
					</td>
					<td>
					</td>
					<td>
					</td>
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_BankExchangeRateList.aspx?Action=Add&ReturnToUrl=WebFormList_BankExchangeRateList.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_CurrencyId" runat="server" CssClass="TableHeader" EnableViewState="false">
							Currency
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_ExchangeType" runat="server" CssClass="TableHeader" EnableViewState="false">
							ExchangeType
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_BidRate" runat="server" CssClass="TableHeader" EnableViewState="false">
							BidRate
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_OfferRate" runat="server" CssClass="TableHeader" EnableViewState="false">
							OfferRate
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_BankExchangeRateList_SelectDisplay id="repeater_BankExchangeRateList_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_BankExchangeRateList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_BankExchangeRateList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_BankExchangeRateList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_BankExchangeRateList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "CurrencyId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "ExchangeType_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "BidRate") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "OfferRate") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_BankExchangeRateList_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>
