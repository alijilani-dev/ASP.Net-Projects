<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebFormList_CustomerList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_CustomerList" %>

<html><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
<head>

<!-- InstanceBeginEditable name="doctitle" -->
<title>ARY Speed Remit :: </title>
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
                  <td align="center"><font size="4" face="Arial, Helvetica, sans-serif"><!-- InstanceBeginEditable name="Heading" --> &nbsp;Customer Management <!-- InstanceEndEditable --></font></td>
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
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td><DropDownLists:WebDropDownList_CustomerCardList id="com_CardId" runat="server" AutoPostBack="True" CssClass="Filter"> </DropDownLists:WebDropDownList_CustomerCardList> </td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td><DropDownLists:WebDropDownList_MasterCountryList id="com_Nationality" runat="server" AutoPostBack="True" CssClass="Filter"> </DropDownLists:WebDropDownList_MasterCountryList> </td>
                        <td></td>
                      </tr>
                      <tr class="TableHeader" align="middle">
                        <td><asp:HyperLink Visible="false" id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_CustomerList.aspx?Action=Add&ReturnToUrl=WebFormList_CustomerList.aspx&ReturnToDisplay=Back to the list"> Add </asp:HyperLink>
                        </td>
                        <td><asp:linkbutton id="Label_LoginName" runat="server" CssClass="TableHeader" EnableViewState="false"> LoginName </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_Password" runat="server" CssClass="TableHeader" EnableViewState="false"> Password </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_FirstName" runat="server" CssClass="TableHeader" EnableViewState="false"> FirstName </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_LastName" runat="server" CssClass="TableHeader" EnableViewState="false"> LastName </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_CardId" runat="server" CssClass="TableHeader" EnableViewState="false"> Card </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_Address" runat="server" CssClass="TableHeader" EnableViewState="false"> Address </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_Telephone" runat="server" CssClass="TableHeader" EnableViewState="false"> Telephone </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_Fax" runat="server" CssClass="TableHeader" EnableViewState="false"> Fax </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_Mobile" runat="server" CssClass="TableHeader" EnableViewState="false"> Mobile </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_Email" runat="server" CssClass="TableHeader" EnableViewState="false"> Email </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_IDType" runat="server" CssClass="TableHeader" EnableViewState="false"> IDType </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_IDDetails" runat="server" CssClass="TableHeader" EnableViewState="false"> IDDetails </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_IDExpirationDate" runat="server" CssClass="TableHeader" EnableViewState="false"> IDExpirationDate </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_Nationality" runat="server" CssClass="TableHeader" EnableViewState="false"> Nationality </asp:linkbutton>
                        </td>
                        <td><asp:linkbutton id="Label_Active" runat="server" CssClass="TableHeader" EnableViewState="false"> Active </asp:linkbutton>
                        </td>
                      </tr>
                      <Repeaters:WebRepeaterCustom_spS_CustomerList_SelectDisplay id="repeater_CustomerList_SelectDisplay" runat="server">
                      <ItemTemplate>
                        <tr class="TableRow" align="center">
                          <td><asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CustomerList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_CustomerList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'> Edit </asp:HyperLink>
                              <br>
                              <asp:HyperLink Visible="false" id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CustomerList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_CustomerList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'> Delete </asp:HyperLink>
                          </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "LoginName") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "Password") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "FirstName") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "LastName") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "CardId_Display") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "Address") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "Telephone") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "Fax") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "Mobile") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "Email") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "IDType") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "IDDetails") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "IDExpirationDate") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "Nationality_Display") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "Active") %> </td>
                        </tr>
                      </ItemTemplate>
                      </Repeaters:WebRepeaterCustom_spS_CustomerList_SelectDisplay>
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
