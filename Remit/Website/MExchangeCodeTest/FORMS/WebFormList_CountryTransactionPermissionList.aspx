<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_CountryTransactionPermissionList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_CountryTransactionPermissionList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>CountryTransactionPermissionList table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_CountryTransactionPermissionList" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				<tr class="TableFilter" align="middle">
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_CountryList id="com_BaseCountryId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CountryList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_CountryList id="com_TargetCountryId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CountryList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_CountryTransactionPermissionTypeList id="com_PermissionType" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CountryTransactionPermissionTypeList>
					</td>
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_CountryTransactionPermissionList.aspx?Action=Add&ReturnToUrl=WebFormList_CountryTransactionPermissionList.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_BaseCountryId" runat="server" CssClass="TableHeader" EnableViewState="false">
							BaseCountry
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_TargetCountryId" runat="server" CssClass="TableHeader" EnableViewState="false">
							TargetCountry
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PermissionType" runat="server" CssClass="TableHeader" EnableViewState="false">
							PermissionType
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_CountryTransactionPermissionList_SelectDisplay id="repeater_CountryTransactionPermissionList_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CountryTransactionPermissionList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_CountryTransactionPermissionList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CountryTransactionPermissionList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_CountryTransactionPermissionList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "BaseCountryId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "TargetCountryId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PermissionType_Display") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_CountryTransactionPermissionList_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>
