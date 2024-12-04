<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_TransactionDraftList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_TransactionDraftList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>TransactionDraftList table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_TransactionDraftList" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				<tr class="TableFilter" align="middle">
					<td>
					</td>
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_TransactionDetails id="com_TransactionId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_TransactionDetails>
					</td>
					<td>
					</td>
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_TransactionDraftList.aspx?Action=Add&ReturnToUrl=WebFormList_TransactionDraftList.aspx&ReturnToDisplay=Back to the list">
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
						<asp:linkbutton id="Label_DraftNumber" runat="server" CssClass="TableHeader" EnableViewState="false">
							DraftNumber (update this label in the 'Olymars/ColumnLabel' extended property of the 'DraftNumber' column)
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_TransactionDraftList_SelectDisplay id="repeater_TransactionDraftList_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_TransactionDraftList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_TransactionDraftList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_TransactionDraftList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_TransactionDraftList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Id") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "TransactionId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "DraftNumber") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_TransactionDraftList_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>
