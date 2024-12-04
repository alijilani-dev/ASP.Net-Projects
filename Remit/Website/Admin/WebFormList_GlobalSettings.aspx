<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_GlobalSettings.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_GlobalSettings" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>GlobalSettings table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_GlobalSettings" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_GlobalSettings.aspx?Action=Add&ReturnToUrl=WebFormList_GlobalSettings.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_Name" runat="server" CssClass="TableHeader" EnableViewState="false">
							Name
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_AdministrativeEmail" runat="server" CssClass="TableHeader" EnableViewState="false">
							AdministrativeEmail
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_TechnicalEmail" runat="server" CssClass="TableHeader" EnableViewState="false">
							TechnicalEmail
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_TransactionThreshold" runat="server" CssClass="TableHeader" EnableViewState="false">
							TransactionThreshold
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_TransactionNumberFormat" runat="server" CssClass="TableHeader" EnableViewState="false">
							TransactionNumberFormat
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_TransactionThresholdUSD" runat="server" CssClass="TableHeader" EnableViewState="false">
							TransactionThresholdUSD
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Active" runat="server" CssClass="TableHeader" EnableViewState="false">
							Active
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeater_GlobalSettings id="repeater_GlobalSettings_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_GlobalSettings.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_GlobalSettings.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_GlobalSettings.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_GlobalSettings.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Name") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "AdministrativeEmail") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "TechnicalEmail") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "TransactionThreshold") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "TransactionNumberFormat") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "TransactionThresholdUSD") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Active") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeater_GlobalSettings>
			</table>
		</form>
	</body>
</HTML>
