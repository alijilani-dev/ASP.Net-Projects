<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_CommissionSlabMaster.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_CommissionSlabMaster" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>CommissionSlabMaster table content management</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="WebFormList_CommissionSlabMaster" method="post" runat="server">
			<table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
				<tr class="TableFilter" align="middle">
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_CountryList id="com_PayInCountryId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CountryList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_CountryList id="com_PayOutCountryId" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CountryList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_PaymentModeList id="com_ModeOfPayment" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_PaymentModeList>
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
						<DropDownLists:WebDropDownList_CommissionSplitTypeList id="com_PayInCommissionType" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CommissionSplitTypeList>
					</td>
					<td>
					</td>
					<td>
						<DropDownLists:WebDropDownList_CommissionSplitTypeList id="com_PayOutCommissionType" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CommissionSplitTypeList>
					</td>
					<td>
						<DropDownLists:WebDropDownList_CommissionCurrencyType id="com_PayOutCurrencyType" runat="server" AutoPostBack="True" CssClass="Filter">
						</DropDownLists:WebDropDownList_CommissionCurrencyType>
					</td>
					<td>
					</td>
				</tr>
				<tr class="TableHeader" align="middle">
					<td>
						<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_CommissionSlabMaster.aspx?Action=Add&ReturnToUrl=WebFormList_CommissionSlabMaster.aspx&ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
					</td>
					<td>
						<asp:linkbutton id="Label_PayInCountryId" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayInCountry
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayOutCountryId" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayOutCountry
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_ModeOfPayment" runat="server" CssClass="TableHeader" EnableViewState="false">
							ModeOfPayment
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_StartRange" runat="server" CssClass="TableHeader" EnableViewState="false">
							StartRange
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_EndRange" runat="server" CssClass="TableHeader" EnableViewState="false">
							EndRange
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_BaseToBaseCommissionAmount" runat="server" CssClass="TableHeader" EnableViewState="false">
							BaseToBaseCommissionAmount
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_BaseToUSDCommissionAmount" runat="server" CssClass="TableHeader" EnableViewState="false">
							BaseToUSDCommissionAmount
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayInCommissionType" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayInCommissionType
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayInCommissionAmount" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayInCommissionAmount
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayOutCommissionType" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayOutCommissionType
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayOutCurrencyType" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayOutCurrencyType
						</asp:linkbutton>
					</td>
					<td>
						<asp:linkbutton id="Label_PayOutCommissionAmount" runat="server" CssClass="TableHeader" EnableViewState="false">
							PayOutCommissionAmount
						</asp:linkbutton>
					</td>
				</tr>
				<Repeaters:WebRepeaterCustom_spS_CommissionSlabMaster_SelectDisplay id="repeater_CommissionSlabMaster_SelectDisplay" runat="server">
					<ItemTemplate>
						<tr class="TableRow" align="center">
							<td>
								<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CommissionSlabMaster.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_CommissionSlabMaster.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
								<br>
								<asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CommissionSlabMaster.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_CommissionSlabMaster.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayInCountryId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayOutCountryId_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "ModeOfPayment_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "StartRange") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "EndRange") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "BaseToBaseCommissionAmount") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "BaseToUSDCommissionAmount") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayInCommissionType_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayInCommissionAmount") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayOutCommissionType_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayOutCurrencyType_Display") %>
							</td>
							<td>
								<%# DataBinder.Eval(Container.DataItem, "PayOutCommissionAmount") %>
							</td>
						</tr>
					</ItemTemplate>
				</Repeaters:WebRepeaterCustom_spS_CommissionSlabMaster_SelectDisplay>
			</table>
		</form>
	</body>
</HTML>
