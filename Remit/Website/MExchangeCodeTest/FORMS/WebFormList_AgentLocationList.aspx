<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_AgentLocationList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_AgentLocationList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>AgentLocationList table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_AgentLocationList" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				<tr class="TableFilter" align="middle">
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
						<DropDownLists:WebDropDownList_AgentGroupList id="com_AgentGroupId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_AgentGroupList>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_TransactionTypeList id="com_AllowedDomesticTransactionType" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_TransactionTypeList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_TransactionTypeList id="com_AllowedInternationalTransactionType" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_TransactionTypeList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_TransactionTypeList id="com_ListOnWebFor" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_TransactionTypeList>
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
						<DropDownLists:WebDropDownList_LocationList id="com_LocationId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_LocationList>
					</td>
					<td>
					</td>
					<td>
					</td>
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_AgentLocationList.aspx?Action=Add&ReturnToUrl=WebFormList_AgentLocationList.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_Name" runat="server" CssClass="TableHeader" EnableViewState="false">
							Name
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Code" runat="server" CssClass="TableHeader" EnableViewState="false">
							Code
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_AgentAccountId" runat="server" CssClass="TableHeader" EnableViewState="false">
							AgentAccount
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_AgentGroupId" runat="server" CssClass="TableHeader" EnableViewState="false">
							AgentGroup
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_CreditLimitInUSD" runat="server" CssClass="TableHeader" EnableViewState="false">
							CreditLimitInUSD
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_IndividualTransactionLimit" runat="server" CssClass="TableHeader" EnableViewState="false">
							IndividualTransactionLimit
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_AllowedDomesticTransactionType" runat="server" CssClass="TableHeader" EnableViewState="false">
							AllowedDomesticTransactionType
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_AllowedInternationalTransactionType" runat="server" CssClass="TableHeader" EnableViewState="false">
							AllowedInternationalTransactionType
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_ListOnWebFor" runat="server" CssClass="TableHeader" EnableViewState="false">
							ListOnWebFor
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
						<asp:linkbutton id="Label_Email" runat="server" CssClass="TableHeader" EnableViewState="false">
							Email
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_LocationId" runat="server" CssClass="TableHeader" EnableViewState="false">
							Location
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_ContactPerson" runat="server" CssClass="TableHeader" EnableViewState="false">
							ContactPerson
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Active" runat="server" CssClass="TableHeader" EnableViewState="false">
							Active
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_AgentLocationList_SelectDisplay id="repeater_AgentLocationList_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_AgentLocationList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_AgentLocationList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_AgentLocationList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_AgentLocationList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Name") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Code") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "AgentAccountId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "AgentGroupId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "CreditLimitInUSD") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "IndividualTransactionLimit") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "AllowedDomesticTransactionType_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "AllowedInternationalTransactionType_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "ListOnWebFor_Display") %>
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
								<%# DataBinder.Eval(Container.DataItem, "Email") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "LocationId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "ContactPerson") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Active") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_AgentLocationList_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>
