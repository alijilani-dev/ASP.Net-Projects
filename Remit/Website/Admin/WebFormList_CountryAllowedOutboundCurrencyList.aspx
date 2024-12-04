<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_CountryAllowedOutboundCurrencyList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_CountryAllowedOutboundCurrencyList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>CountryAllowedOutboundCurrencyList table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_CountryAllowedOutboundCurrencyList" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_CountryAllowedOutboundCurrencyList.aspx?Action=Add&ReturnToUrl=WebFormList_CountryAllowedOutboundCurrencyList.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_CountryId" runat="server" CssClass="TableHeader" EnableViewState="false">
							CountryId (update this label in the 'Olymars/ColumnLabel' extended property of the 'CountryId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_CurrencyId" runat="server" CssClass="TableHeader" EnableViewState="false">
							CurrencyId (update this label in the 'Olymars/ColumnLabel' extended property of the 'CurrencyId' column)
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeater_CountryAllowedOutboundCurrencyList id="repeater_CountryAllowedOutboundCurrencyList_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CountryAllowedOutboundCurrencyList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_CountryAllowedOutboundCurrencyList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CountryAllowedOutboundCurrencyList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_CountryAllowedOutboundCurrencyList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "CountryId") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "CurrencyId") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeater_CountryAllowedOutboundCurrencyList>
			</table>
		</form>
	</body>
</HTML>
