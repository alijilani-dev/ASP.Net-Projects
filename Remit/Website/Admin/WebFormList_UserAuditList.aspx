<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_UserAuditList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_UserAuditList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>UserAuditList table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_UserAuditList" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				<tr class="TableFilter" align="middle">
					<td>
					</td>
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_UserList id="com_UserId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_UserList>
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
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_UserAuditList.aspx?Action=Add&ReturnToUrl=WebFormList_UserAuditList.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_Id" runat="server" CssClass="TableHeader" EnableViewState="false">
							Id (update this label in the 'Olymars/ColumnLabel' extended property of the 'Id' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_UserId" runat="server" CssClass="TableHeader" EnableViewState="false">
							UserId (update this label in the 'Olymars/ColumnLabel' extended property of the 'UserId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Date" runat="server" CssClass="TableHeader" EnableViewState="false">
							Date (update this label in the 'Olymars/ColumnLabel' extended property of the 'Date' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_MainModule" runat="server" CssClass="TableHeader" EnableViewState="false">
							MainModule (update this label in the 'Olymars/ColumnLabel' extended property of the 'MainModule' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_SubModule" runat="server" CssClass="TableHeader" EnableViewState="false">
							SubModule (update this label in the 'Olymars/ColumnLabel' extended property of the 'SubModule' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Action" runat="server" CssClass="TableHeader" EnableViewState="false">
							Action (update this label in the 'Olymars/ColumnLabel' extended property of the 'Action' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_AdditionalMessage" runat="server" CssClass="TableHeader" EnableViewState="false">
							AdditionalMessage (update this label in the 'Olymars/ColumnLabel' extended property of the 'AdditionalMessage' column)
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_UserAuditList_SelectDisplay id="repeater_UserAuditList_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_UserAuditList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_UserAuditList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_UserAuditList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_UserAuditList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Id") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "UserId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Date") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "MainModule") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "SubModule") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Action") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "AdditionalMessage") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_UserAuditList_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>
