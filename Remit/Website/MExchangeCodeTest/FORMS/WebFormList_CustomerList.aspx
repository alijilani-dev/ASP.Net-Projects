<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_CustomerList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_CustomerList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>CustomerList table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_CustomerList" method="post" runat="server">
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
						<DropDownLists:WebDropDownList_CustomerCardList id="com_CardId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CustomerCardList>
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
					</td>
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_MasterCountryList id="com_Nationality" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_MasterCountryList>
					</td>
					<td>
					</td>
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_CustomerList.aspx?Action=Add&ReturnToUrl=WebFormList_CustomerList.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_LoginName" runat="server" CssClass="TableHeader" EnableViewState="false">
							LoginName
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Password" runat="server" CssClass="TableHeader" EnableViewState="false">
							Password
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_FirstName" runat="server" CssClass="TableHeader" EnableViewState="false">
							FirstName
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_LastName" runat="server" CssClass="TableHeader" EnableViewState="false">
							LastName
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_CardId" runat="server" CssClass="TableHeader" EnableViewState="false">
							Card
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Address" runat="server" CssClass="TableHeader" EnableViewState="false">
							Address
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Telephone" runat="server" CssClass="TableHeader" EnableViewState="false">
							Telephone
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Fax" runat="server" CssClass="TableHeader" EnableViewState="false">
							Fax
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Mobile" runat="server" CssClass="TableHeader" EnableViewState="false">
							Mobile
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Email" runat="server" CssClass="TableHeader" EnableViewState="false">
							Email
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_IDType" runat="server" CssClass="TableHeader" EnableViewState="false">
							IDType
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_IDDetails" runat="server" CssClass="TableHeader" EnableViewState="false">
							IDDetails
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_IDExpirationDate" runat="server" CssClass="TableHeader" EnableViewState="false">
							IDExpirationDate
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Nationality" runat="server" CssClass="TableHeader" EnableViewState="false">
							Nationality
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Active" runat="server" CssClass="TableHeader" EnableViewState="false">
							Active
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_CustomerList_SelectDisplay id="repeater_CustomerList_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CustomerList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_CustomerList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CustomerList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_CustomerList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "LoginName") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Password") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "FirstName") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "LastName") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "CardId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Address") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Telephone") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Fax") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Mobile") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Email") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "IDType") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "IDDetails") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "IDExpirationDate") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Nationality_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Active") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_CustomerList_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>
