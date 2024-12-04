<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_BankList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_BankList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>BankList table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_BankList" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				<tr class="TableFilter" align="middle">
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_AgentMaster id="com_AccountId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_AgentMaster>
					</td>
					<td>
						<DropDownLists:WebDropDownList_LocationList id="com_LocationId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_LocationList>
					</td>
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_BankList.aspx?Action=Add&ReturnToUrl=WebFormList_BankList.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_Name" runat="server" CssClass="TableHeader" EnableViewState="false">
							Name
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_BranchName" runat="server" CssClass="TableHeader" EnableViewState="false">
							BranchName
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_InternalCode" runat="server" CssClass="TableHeader" EnableViewState="false">
							InternalCode
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_ExternalCode" runat="server" CssClass="TableHeader" EnableViewState="false">
							ExternalCode
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Address" runat="server" CssClass="TableHeader" EnableViewState="false">
							Address
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_ZipCode" runat="server" CssClass="TableHeader" EnableViewState="false">
							ZipCode
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_AccountId" runat="server" CssClass="TableHeader" EnableViewState="false">
							Account
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_LocationId" runat="server" CssClass="TableHeader" EnableViewState="false">
							City/Division
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_BankList_SelectDisplay id="repeater_BankList_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_BankList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_BankList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_BankList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_BankList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Name") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "BranchName") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "InternalCode") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "ExternalCode") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Address") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "ZipCode") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "AccountId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "LocationId_Display") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_BankList_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>
