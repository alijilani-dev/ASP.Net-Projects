<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_CountryAvailablePaymentModeList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_CountryAvailablePaymentModeList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>CountryAvailablePaymentModeList table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_CountryAvailablePaymentModeList" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				<tr class="TableFilter" align="middle">
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_CountryList id="com_CountryId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CountryList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_PaymentModeList id="com_PaymentMode" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_PaymentModeList>
					</td>
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_CountryAvailablePaymentModeList.aspx?Action=Add&ReturnToUrl=WebFormList_CountryAvailablePaymentModeList.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_CountryId" runat="server" CssClass="TableHeader" EnableViewState="false">
							Country
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PaymentMode" runat="server" CssClass="TableHeader" EnableViewState="false">
							PaymentMode
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_CountryAvailablePaymentModeList_SelectDisplay id="repeater_CountryAvailablePaymentModeList_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CountryAvailablePaymentModeList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_CountryAvailablePaymentModeList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CountryAvailablePaymentModeList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_CountryAvailablePaymentModeList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "CountryId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PaymentMode_Display") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_CountryAvailablePaymentModeList_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>
