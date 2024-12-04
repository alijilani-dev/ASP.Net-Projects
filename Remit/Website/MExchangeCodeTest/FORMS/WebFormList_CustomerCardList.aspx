<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_CustomerCardList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_CustomerCardList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>CustomerCardList table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_CustomerCardList" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				<tr class="TableFilter" align="middle">
					<td>
					</td>
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_AgentLocationList id="com_AgentId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_AgentLocationList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_CustomerCardStatusList id="com_Status" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CustomerCardStatusList>
					</td>
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_CustomerCardList.aspx?Action=Add&ReturnToUrl=WebFormList_CustomerCardList.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_Code" runat="server" CssClass="TableHeader" EnableViewState="false">
							Code
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_AgentId" runat="server" CssClass="TableHeader" EnableViewState="false">
							AgentId
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Status" runat="server" CssClass="TableHeader" EnableViewState="false">
							Status
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_CustomerCardList_SelectDisplay id="repeater_CustomerCardList_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CustomerCardList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_CustomerCardList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CustomerCardList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_CustomerCardList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Code") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "AgentId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Status_Display") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_CustomerCardList_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>
