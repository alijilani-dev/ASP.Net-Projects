<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_TransactionModificationMessageList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_TransactionModificationMessageList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>TransactionModificationMessageList table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_TransactionModificationMessageList" method="post" runat="server">
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
						<DropDownLists:WebDropDownList_UserList id="com_UserId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_UserList>
					</td>
					<td>
					</td>
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_TransactionModificationMessageList.aspx?Action=Add&ReturnToUrl=WebFormList_TransactionModificationMessageList.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_Id" runat="server" CssClass="TableHeader" EnableViewState="false">
							Id (update this label in the 'Olymars/ColumnLabel' extended property of the 'Id' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_TransactionId" runat="server" CssClass="TableHeader" EnableViewState="false">
							TransactionId (update this label in the 'Olymars/ColumnLabel' extended property of the 'TransactionId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Date" runat="server" CssClass="TableHeader" EnableViewState="false">
							Date (update this label in the 'Olymars/ColumnLabel' extended property of the 'Date' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_UserId" runat="server" CssClass="TableHeader" EnableViewState="false">
							UserId (update this label in the 'Olymars/ColumnLabel' extended property of the 'UserId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Message" runat="server" CssClass="TableHeader" EnableViewState="false">
							Message (update this label in the 'Olymars/ColumnLabel' extended property of the 'Message' column)
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_TransactionModificationMessageList_SelectDisplay id="repeater_TransactionModificationMessageList_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_TransactionModificationMessageList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_TransactionModificationMessageList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_TransactionModificationMessageList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_TransactionModificationMessageList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Id") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "TransactionId") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Date") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "UserId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Message") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_TransactionModificationMessageList_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>
