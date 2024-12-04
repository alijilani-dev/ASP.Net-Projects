<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_PaymentHistory.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_PaymentHistory" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>PaymentHistory table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_PaymentHistory" method="post" runat="server">
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
						<DropDownLists:WebDropDownList_CurrencyList id="com_PaymentCurrencyId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CurrencyList>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_PaymentType id="com_Type" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_PaymentType>
					</td>
					<td>
					</td>
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_PaymentHistory.aspx?Action=Add&ReturnToUrl=WebFormList_PaymentHistory.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_Id" runat="server" CssClass="TableHeader" EnableViewState="false">
							Id (update this label in the 'Olymars/ColumnLabel' extended property of the 'Id' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_EntryDateTime" runat="server" CssClass="TableHeader" EnableViewState="false">
							EntryDateTime (update this label in the 'Olymars/ColumnLabel' extended property of the 'EntryDateTime' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PaymentDateTime" runat="server" CssClass="TableHeader" EnableViewState="false">
							PaymentDateTime (update this label in the 'Olymars/ColumnLabel' extended property of the 'PaymentDateTime' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PaymentCurrencyId" runat="server" CssClass="TableHeader" EnableViewState="false">
							PaymentCurrencyId (update this label in the 'Olymars/ColumnLabel' extended property of the 'PaymentCurrencyId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Debit" runat="server" CssClass="TableHeader" EnableViewState="false">
							Debit (update this label in the 'Olymars/ColumnLabel' extended property of the 'Debit' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Credit" runat="server" CssClass="TableHeader" EnableViewState="false">
							Credit (update this label in the 'Olymars/ColumnLabel' extended property of the 'Credit' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Type" runat="server" CssClass="TableHeader" EnableViewState="false">
							Type (update this label in the 'Olymars/ColumnLabel' extended property of the 'Type' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Particulars" runat="server" CssClass="TableHeader" EnableViewState="false">
							Particulars (update this label in the 'Olymars/ColumnLabel' extended property of the 'Particulars' column)
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_PaymentHistory_SelectDisplay id="repeater_PaymentHistory_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_PaymentHistory.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_PaymentHistory.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_PaymentHistory.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_PaymentHistory.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Id") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "EntryDateTime") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PaymentDateTime") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PaymentCurrencyId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Debit") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Credit") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Type_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Particulars") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_PaymentHistory_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>
