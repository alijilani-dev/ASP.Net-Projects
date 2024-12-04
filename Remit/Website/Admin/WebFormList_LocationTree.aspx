<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_LocationTree.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_LocationTree" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>LocationTree table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_LocationTree" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_LocationTree.aspx?Action=Add&ReturnToUrl=WebFormList_LocationTree.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_Id" runat="server" CssClass="TableHeader" EnableViewState="false">
							Id (update this label in the 'Olymars/ColumnLabel' extended property of the 'Id' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_LocationId" runat="server" CssClass="TableHeader" EnableViewState="false">
							LocationId (update this label in the 'Olymars/ColumnLabel' extended property of the 'LocationId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_ParentLocationId" runat="server" CssClass="TableHeader" EnableViewState="false">
							ParentLocationId (update this label in the 'Olymars/ColumnLabel' extended property of the 'ParentLocationId' column)
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Level" runat="server" CssClass="TableHeader" EnableViewState="false">
							Level (update this label in the 'Olymars/ColumnLabel' extended property of the 'Level' column)
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeater_LocationTree id="repeater_LocationTree_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_LocationTree.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_LocationTree.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_LocationTree.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_LocationTree.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Id") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "LocationId") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "ParentLocationId") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Level") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeater_LocationTree>
			</table>
		</form>
	</body>
</HTML>
