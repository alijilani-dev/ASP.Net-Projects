<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_BeneficeryBankList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_BeneficeryBankList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>BeneficeryBankList table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_BeneficeryBankList" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				<tr class="TableFilter" align="middle">
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_CustomerList id="com_CustomerId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CustomerList>
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
						<DropDownLists:WebDropDownList_CountryList id="com_CountryId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CountryList>
					</td>
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_BeneficeryBankList.aspx?Action=Add&ReturnToUrl=WebFormList_BeneficeryBankList.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_CustomerId" runat="server" CssClass="TableHeader" EnableViewState="false">
							Customer
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_AccountNumber" runat="server" CssClass="TableHeader" EnableViewState="false">
							AccountNumber
						</asp:linkbutton>
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
						<asp:linkbutton id="Label_CountryId" runat="server" CssClass="TableHeader" EnableViewState="false">
							Country
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_BeneficeryBankList_SelectDisplay id="repeater_BeneficeryBankList_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_BeneficeryBankList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_BeneficeryBankList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_BeneficeryBankList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_BeneficeryBankList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "CustomerId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "AccountNumber") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Name") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "BranchName") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Address") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "ZipCode") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "CountryId_Display") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_BeneficeryBankList_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>
