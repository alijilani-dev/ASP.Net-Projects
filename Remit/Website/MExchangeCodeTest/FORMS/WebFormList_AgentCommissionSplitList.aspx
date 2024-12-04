<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_AgentCommissionSplitList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_AgentCommissionSplitList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>AgentCommissionSplitList table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_AgentCommissionSplitList" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				<tr class="TableFilter" align="middle">
					<td>
					</td>
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_AgentMaster id="com_CurrentAccountId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_AgentMaster>
					</td>
					<td>
						<DropDownLists:WebDropDownList_AgentMaster id="com_EndNodeAccountId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_AgentMaster>
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
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_AgentCommissionSplitList.aspx?Action=Add&ReturnToUrl=WebFormList_AgentCommissionSplitList.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_Id" runat="server" CssClass="TableHeader" EnableViewState="false">
							Id (update this label in the 'Olymars/ColumnLabel' extended property of the 'Id' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_CurrentAccountId" runat="server" CssClass="TableHeader" EnableViewState="false">
							CurrentAccountId (update this label in the 'Olymars/ColumnLabel' extended property of the 'CurrentAccountId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_EndNodeAccountId" runat="server" CssClass="TableHeader" EnableViewState="false">
							EndNodeAccountId (update this label in the 'Olymars/ColumnLabel' extended property of the 'EndNodeAccountId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayInCommission" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayInCommission (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayInCommission' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayOutCommission" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayOutCommission (update this label in the 'Olymars/ColumnLabel' extended property of the 'PayOutCommission' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Level" runat="server" CssClass="TableHeader" EnableViewState="false">
							Level (update this label in the 'Olymars/ColumnLabel' extended property of the 'Level' column)
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_AgentCommissionSplitList_SelectDisplay id="repeater_AgentCommissionSplitList_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_AgentCommissionSplitList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_AgentCommissionSplitList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_AgentCommissionSplitList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_AgentCommissionSplitList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Id") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "CurrentAccountId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "EndNodeAccountId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayInCommission") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayOutCommission") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Level") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_AgentCommissionSplitList_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>
