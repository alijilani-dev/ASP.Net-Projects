<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_CommissionSlabMaster.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_CommissionSlabMaster" %>

<html><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
<head>

<!-- InstanceBeginEditable name="doctitle" -->
<title>ARY Speed Remit :: Commission Slab Management</title>
<!-- InstanceEndEditable -->
<!-- InstanceBeginEditable name="head" -->
		
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
	<!-- InstanceEndEditable -->
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<link href="/css/InnerPage.css" rel="stylesheet" type="text/css">
<link href="/Admin/StyleSheet.css" rel="stylesheet" type="text/css">
</head>

<body leftmargin="0" topmargin="0">
<form id="Form1" runat="server" method="post">
  <table width="100%" height="100%"  border="0" cellpadding="0" cellspacing="0" bgcolor="black">
    <tr>
      <td><table width="100%"  border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td width="42">&nbsp;</td>
								<td align="center"><font style="LETTER-SPACING: 2pt" face="verdana" color="#ffffff" size="5">We 
										Understand Your Needs...</font></td>
          <td width="42">&nbsp;</td>
          <td width="257"><IMG SRC="/images/layoutImages/logo.jpg" ALT=""></td>
        </tr>
      </table></td>
    </tr>
    <tr>
      <td height="100%" valign="top"><table width="100%" height="100%"  border="0" cellpadding="0" cellspacing="0">
        <tr>
          <td valign="top" bgcolor="#CFCFCF"><table width="100%"  border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td><table width="100%"  border="0" cellspacing="0" cellpadding="0">
                <tr>
                  <td align="center"><font size="4" face="Arial, Helvetica, sans-serif"><!-- InstanceBeginEditable name="Heading" --> &nbsp;Commission Slab Management <!-- InstanceEndEditable --></font></td>
                  </tr>
              </table></td>
            </tr>
            <tr>
              <td valign="top"><table width="100%"  border="0" cellspacing="0" cellpadding="0">
                <tr>
                  <td align="center" valign="top"><!-- InstanceBeginEditable name="MainContent" --> 
                    <table rules="all" style="border-collapse:collapse;" cellSpacing="0" cellPadding="5" border="1">
                      <tr class="TableFilter" align="middle">
                        <td></td>
                        <td><DropDownLists:WebDropDownList_CountryList id="com_PayInCountryId" runat="server" AutoPostBack="True" CssClass="Filter"> </DropDownLists:WebDropDownList_CountryList> </td>
                        <td><DropDownLists:WebDropDownList_CountryList id="com_PayOutCountryId" runat="server" AutoPostBack="True" CssClass="Filter"> </DropDownLists:WebDropDownList_CountryList> </td>
                        <td><DropDownLists:WebDropDownList_PaymentModeList id="com_ModeOfPayment" runat="server" AutoPostBack="True" CssClass="Filter"> </DropDownLists:WebDropDownList_PaymentModeList> </td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td><DropDownLists:WebDropDownList_CommissionSplitTypeList id="com_PayInCommissionType" runat="server" AutoPostBack="True" CssClass="Filter"> </DropDownLists:WebDropDownList_CommissionSplitTypeList> </td>
                        <td></td>
                        <td><DropDownLists:WebDropDownList_CommissionSplitTypeList id="com_PayOutCommissionType" runat="server" AutoPostBack="True" CssClass="Filter"> </DropDownLists:WebDropDownList_CommissionSplitTypeList> </td>
                        <td><DropDownLists:WebDropDownList_CommissionCurrencyType id="com_PayOutCurrencyType" runat="server" AutoPostBack="True" CssClass="Filter"> </DropDownLists:WebDropDownList_CommissionCurrencyType> </td>
                        <td></td>
                      </tr>
                      <tr class="TableHeader" align="middle">
                        <td><asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_CommissionSlabMaster.aspx?Action=Add&ReturnToUrl=WebFormList_CommissionSlabMaster.aspx&ReturnToDisplay=Back to the list"> Add </asp:HyperLink>
                        </td>
                        <td><asp:linkbutton id="Label_PayInCountryId" runat="server" CssClass="TableHeader" EnableViewState="false"> PayInCountry </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_PayOutCountryId" runat="server" CssClass="TableHeader" EnableViewState="false"> PayOutCountry </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_ModeOfPayment" runat="server" CssClass="TableHeader" EnableViewState="false"> ModeOfPayment </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_StartRange" runat="server" CssClass="TableHeader" EnableViewState="false"> StartRange </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_EndRange" runat="server" CssClass="TableHeader" EnableViewState="false"> EndRange </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_BaseToBaseCommissionAmount" runat="server" CssClass="TableHeader" EnableViewState="false"> BaseToBaseCommissionAmount </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_BaseToUSDCommissionAmount" runat="server" CssClass="TableHeader" EnableViewState="false"> BaseToUSDCommissionAmount </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_PayInCommissionType" runat="server" CssClass="TableHeader" EnableViewState="false"> PayInCommissionType </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_PayInCommissionAmount" runat="server" CssClass="TableHeader" EnableViewState="false"> PayInCommissionAmount </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_PayOutCommissionType" runat="server" CssClass="TableHeader" EnableViewState="false"> PayOutCommissionType </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_PayOutCurrencyType" runat="server" CssClass="TableHeader" EnableViewState="false"> PayOutCurrencyType </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_PayOutCommissionAmount" runat="server" CssClass="TableHeader" EnableViewState="false"> PayOutCommissionAmount </asp:linkbutton>
                        </td>
                      </tr>
                      <Repeaters:WebRepeaterCustom_spS_CommissionSlabMaster_SelectDisplay id="repeater_CommissionSlabMaster_SelectDisplay" runat="server">
                      <ItemTemplate>
                        <tr class="TableRow" align="center">
                          <td><asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CommissionSlabMaster.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_CommissionSlabMaster.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'> Edit </asp:HyperLink>
                              <br>
                              <asp:HyperLink Visible="false" id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CommissionSlabMaster.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_CommissionSlabMaster.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'> Delete </asp:HyperLink>
                          </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "PayInCountryId_Display") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "PayOutCountryId_Display") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "ModeOfPayment_Display") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "StartRange") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "EndRange") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "BaseToBaseCommissionAmount") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "BaseToUSDCommissionAmount") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "PayInCommissionType_Display") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "PayInCommissionAmount") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "PayOutCommissionType_Display") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "PayOutCurrencyType_Display") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "PayOutCommissionAmount") %> </td>
                        </tr>
                      </ItemTemplate>
                      </Repeaters:WebRepeaterCustom_spS_CommissionSlabMaster_SelectDisplay>
                    </table>
                  <!-- InstanceEndEditable --></td>
                  </tr>
              </table></td>
            </tr>
            <tr>
              <td valign="top">&nbsp;</td>
            </tr>
          </table></td>
          <td width="260" valign="top"><table width="100%"  border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td height="46">&nbsp;</td>
            </tr>
            <tr>
											<td align="center" height="48"><font face="verdana" color="#ffffff" size="4">Send Money 
													to Your Destination</font><br>
												<br></td>
            </tr>
            <tr>
              <td height="46" valign="top" style="color:#FFFFFF "><uc1:StatusInfo id="StatusInfo1" runat="server"></uc1:StatusInfo></td>
            </tr>
            <tr>
              <td valign="top"><uc1:Menu2 id="Menu2" runat="server"></uc1:Menu2></td>
            </tr>
          </table></td>
        </tr>
      </table></td>
    </tr>
    <tr>
      <td height="45"><uc1:Menu1 id="Menu11" runat="server"></uc1:Menu1></td>
    </tr>
    <tr>
      <td><font color="#FFFFFF" size="1" face="Arial, Helvetica, sans-serif">&copy; 2004-2005 ARY Speed Remit. All rights reserved </font></td>
    </tr>
  </table>
</form>
</body>
<!-- InstanceEnd --></html>
