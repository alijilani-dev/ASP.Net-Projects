<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_CountryTransactionPermissionList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_CountryTransactionPermissionList" %>

<html><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
<head>

<!-- InstanceBeginEditable name="doctitle" -->
<title>ARY Speed Remit :: Country Permission List</title>
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
                  <td align="center"><font size="4" face="Arial, Helvetica, sans-serif"><!-- InstanceBeginEditable name="Heading" --> &nbsp;Country Permission List <!-- InstanceEndEditable --></font></td>
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
                        <td><DropDownLists:WebDropDownList_CountryList id="com_BaseCountryId" runat="server" AutoPostBack="True" CssClass="Filter"> </DropDownLists:WebDropDownList_CountryList> </td>
                        <td><DropDownLists:WebDropDownList_CountryList id="com_TargetCountryId" runat="server" AutoPostBack="True" CssClass="Filter"> </DropDownLists:WebDropDownList_CountryList> </td>
                        <td><DropDownLists:WebDropDownList_CountryTransactionPermissionTypeList id="com_PermissionType" runat="server" AutoPostBack="True" CssClass="Filter"> </DropDownLists:WebDropDownList_CountryTransactionPermissionTypeList> </td>
                      </tr>
                      <tr class="TableHeader" align="middle">
                        <td><asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_CountryTransactionPermissionList.aspx?Action=Add&ReturnToUrl=WebFormList_CountryTransactionPermissionList.aspx&ReturnToDisplay=Back to the list"> Add </asp:HyperLink>
                        </td>
                        <td><asp:linkbutton id="Label_BaseCountryId" runat="server" CssClass="TableHeader" EnableViewState="false"> BaseCountry </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_TargetCountryId" runat="server" CssClass="TableHeader" EnableViewState="false"> TargetCountry </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_PermissionType" runat="server" CssClass="TableHeader" EnableViewState="false"> PermissionType </asp:linkbutton>
                        </td>
                      </tr>
                      <Repeaters:WebRepeaterCustom_spS_CountryTransactionPermissionList_SelectDisplay id="repeater_CountryTransactionPermissionList_SelectDisplay" runat="server">
                      <ItemTemplate>
                        <tr class="TableRow" align="center">
                          <td><asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CountryTransactionPermissionList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_CountryTransactionPermissionList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'> Edit </asp:HyperLink>
                              <br>
                              <asp:HyperLink id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CountryTransactionPermissionList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_CountryTransactionPermissionList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'> Delete </asp:HyperLink>
                          </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "BaseCountryId_Display") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "TargetCountryId_Display") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "PermissionType_Display") %> </td>
                        </tr>
                      </ItemTemplate>
                      </Repeaters:WebRepeaterCustom_spS_CountryTransactionPermissionList_SelectDisplay>
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
