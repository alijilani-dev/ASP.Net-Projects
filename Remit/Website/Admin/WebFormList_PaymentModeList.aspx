<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_PaymentModeList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_PaymentModeList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>PaymentModeList table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_PaymentModeList" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				<tr class="TableFilter" align="middle">
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_PaymentModeBaseTypeList id="com_BaseType" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_PaymentModeBaseTypeList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_EntityList id="com_ChannelThrough" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_EntityList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_EntityList id="com_FinalEntity" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_EntityList>
					</td>
					<td>
					</td>
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_PaymentModeList.aspx?Action=Add&ReturnToUrl=WebFormList_PaymentModeList.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_Name" runat="server" CssClass="TableHeader" EnableViewState="false">
							Name
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Value" runat="server" CssClass="TableHeader" EnableViewState="false">
							Value
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_BaseType" runat="server" CssClass="TableHeader" EnableViewState="false">
							BaseType
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_ChannelThrough" runat="server" CssClass="TableHeader" EnableViewState="false">
							ChannelThrough
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_FinalEntity" runat="server" CssClass="TableHeader" EnableViewState="false">
							FinalEntity
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Prefix" runat="server" CssClass="TableHeader" EnableViewState="false">
							Prefix
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_PaymentModeList_SelectDisplay id="repeater_PaymentModeList_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_PaymentModeList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_PaymentModeList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Value") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_PaymentModeList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_PaymentModeList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Value") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Name") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Value") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "BaseType_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "ChannelThrough_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "FinalEntity_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Prefix") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_PaymentModeList_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>
