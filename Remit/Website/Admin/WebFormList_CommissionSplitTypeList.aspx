﻿<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_CommissionSplitTypeList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_CommissionSplitTypeList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>CommissionSplitTypeList table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_CommissionSplitTypeList" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_CommissionSplitTypeList.aspx?Action=Add&ReturnToUrl=WebFormList_CommissionSplitTypeList.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_Name" runat="server" CssClass="TableHeader" EnableViewState="false">
							Name (update this label in the 'Olymars/ColumnLabel' extended property of the 'Name' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Value" runat="server" CssClass="TableHeader" EnableViewState="false">
							Value (update this label in the 'Olymars/ColumnLabel' extended property of the 'Value' column)
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeater_CommissionSplitTypeList id="repeater_CommissionSplitTypeList_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CommissionSplitTypeList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_CommissionSplitTypeList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Value") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CommissionSplitTypeList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_CommissionSplitTypeList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Value") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Name") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Value") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeater_CommissionSplitTypeList>
			</table>
		</form>
	</body>
</HTML>