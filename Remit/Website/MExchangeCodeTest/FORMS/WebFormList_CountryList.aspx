<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_CountryList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_CountryList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>CountryList table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_CountryList" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				<tr class="TableFilter" align="middle">
					<td>
					</td>
					<td>
					</td>
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_CurrencyList id="com_BaseCurrency" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CurrencyList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_TransactionTypeList id="com_AllowedInternationalTransactionType" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_TransactionTypeList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_TransactionTypeList id="com_AllowedDomesticTransactionType" runat="server" AutoPostBack="True" CssClass="Filter">
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
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_CountryList.aspx?Action=Add&ReturnToUrl=WebFormList_CountryList.aspx&ReturnToDisplay=Back to the list">
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
						<asp:linkbutton id="Label_BaseCurrency" runat="server" CssClass="TableHeader" EnableViewState="false">
							BaseCurrency
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_AllowedInternationalTransactionType" runat="server" CssClass="TableHeader" EnableViewState="false">
							AllowedInternationalTransactionType
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_AllowedDomesticTransactionType" runat="server" CssClass="TableHeader" EnableViewState="false">
							AllowedDomesticTransactionType
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_TotalInboundThresholdPerYearPerPerson" runat="server" CssClass="TableHeader" EnableViewState="false">
							TotalInboundThresholdPerYearPerPerson
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_MaximumTransactionsPerYearPerPersonToOneBeneficery" runat="server" CssClass="TableHeader" EnableViewState="false">
							MaximumTransactionsPerYearPerPersonToOneBeneficery
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_TransactionYearStartDate" runat="server" CssClass="TableHeader" EnableViewState="false">
							TransactionYearStartDate
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_TransactionYearEndDate" runat="server" CssClass="TableHeader" EnableViewState="false">
							TransactionYearEndDate
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_OutboundIDRequirementThreshold" runat="server" CssClass="TableHeader" EnableViewState="false">
							OutboundIDRequirementThreshold
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_OutboundThresholdPerTransaction" runat="server" CssClass="TableHeader" EnableViewState="false">
							OutboundThresholdPerTransaction
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_CanPayOutUSD" runat="server" CssClass="TableHeader" EnableViewState="false">
							CanPayOutUSD
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_Active" runat="server" CssClass="TableHeader" EnableViewState="false">
							Active
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_CountryList_SelectDisplay id="repeater_CountryList_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CountryList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_CountryList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CountryList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_CountryList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
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
								<%# DataBinder.Eval(Container.DataItem, "BaseCurrency_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "AllowedInternationalTransactionType_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "AllowedDomesticTransactionType_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "TotalInboundThresholdPerYearPerPerson") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "MaximumTransactionsPerYearPerPersonToOneBeneficery") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "TransactionYearStartDate") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "TransactionYearEndDate") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "OutboundIDRequirementThreshold") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "OutboundThresholdPerTransaction") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "CanPayOutUSD") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "Active") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_CountryList_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>
