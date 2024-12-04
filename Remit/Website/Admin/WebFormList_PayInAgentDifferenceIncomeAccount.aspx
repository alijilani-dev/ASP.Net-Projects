<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_PayInAgentDifferenceIncomeAccount.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_PayInAgentDifferenceIncomeAccount" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>PayInAgentDifferenceIncomeAccount table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_PayInAgentDifferenceIncomeAccount" method="post" runat="server">
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
						<DropDownLists:WebDropDownList_AgentMaster id="com_AgentAccountId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_AgentMaster>
					</td>
					<td>
						<DropDownLists:WebDropDownList_TransactionDetails id="com_TranasctionId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_TransactionDetails>
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
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_PayInAgentDifferenceIncomeAccount.aspx?Action=Add&ReturnToUrl=WebFormList_PayInAgentDifferenceIncomeAccount.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_Id" runat="server" CssClass="TableHeader" EnableViewState="false">
							Id (update this label in the 'Olymars/ColumnLabel' extended property of the 'Id' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_CreditDateTime" runat="server" CssClass="TableHeader" EnableViewState="false">
							CreditDateTime (update this label in the 'Olymars/ColumnLabel' extended property of the 'CreditDateTime' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_DebitDateTime" runat="server" CssClass="TableHeader" EnableViewState="false">
							DebitDateTime (update this label in the 'Olymars/ColumnLabel' extended property of the 'DebitDateTime' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_AgentAccountId" runat="server" CssClass="TableHeader" EnableViewState="false">
							AgentAccountId (update this label in the 'Olymars/ColumnLabel' extended property of the 'AgentAccountId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_TranasctionId" runat="server" CssClass="TableHeader" EnableViewState="false">
							TranasctionId (update this label in the 'Olymars/ColumnLabel' extended property of the 'TranasctionId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_CreditLC" runat="server" CssClass="TableHeader" EnableViewState="false">
							CreditLC (update this label in the 'Olymars/ColumnLabel' extended property of the 'CreditLC' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_CreditUSD" runat="server" CssClass="TableHeader" EnableViewState="false">
							CreditUSD (update this label in the 'Olymars/ColumnLabel' extended property of the 'CreditUSD' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_DebitLC" runat="server" CssClass="TableHeader" EnableViewState="false">
							DebitLC (update this label in the 'Olymars/ColumnLabel' extended property of the 'DebitLC' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_DebitUSD" runat="server" CssClass="TableHeader" EnableViewState="false">
							DebitUSD (update this label in the 'Olymars/ColumnLabel' extended property of the 'DebitUSD' column)
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_PayInAgentDifferenceIncomeAccount_SelectDisplay id="repeater_PayInAgentDifferenceIncomeAccount_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_PayInAgentDifferenceIncomeAccount.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_PayInAgentDifferenceIncomeAccount.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_PayInAgentDifferenceIncomeAccount.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_PayInAgentDifferenceIncomeAccount.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Id") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "CreditDateTime") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "DebitDateTime") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "AgentAccountId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "TranasctionId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "CreditLC") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "CreditUSD") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "DebitLC") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "DebitUSD") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_PayInAgentDifferenceIncomeAccount_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>
