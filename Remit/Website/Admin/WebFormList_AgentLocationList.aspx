<%@ Page language="c#" Codebehind="WebFormList_AgentLocationList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_AgentLocationList" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>

<html><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
<head>

<!-- InstanceBeginEditable name="doctitle" -->
<title>ARY Speed Remit :: Agent Management</title>
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
                  <td align="center"><font size="4" face="Arial, Helvetica, sans-serif"><!-- InstanceBeginEditable name="Heading" --> &nbsp;Agent Management <!-- InstanceEndEditable --></font></td>
                  </tr>
              </table></td>
            </tr>
            <tr>
              <td valign="top"><table width="100%"  border="0" cellspacing="0" cellpadding="0">
                <tr>
                  <td align="center" valign="top"><!-- InstanceBeginEditable name="MainContent" --> 
                    <table style="BORDER-COLLAPSE: collapse" cellSpacing="0" cellPadding="5" rules="all" border="1">
                      <tr class="TableFilter" align="center">
                        <td></td>
                        <td></td>
                        <td></td>
                        <td><DROPDOWNLISTS:WEBDROPDOWNLIST_AGENTMASTER id="com_AgentAccountId" runat="server" CssClass="Filter" AutoPostBack="True"></DROPDOWNLISTS:WEBDROPDOWNLIST_AGENTMASTER></td>
                        <td><DROPDOWNLISTS:WEBDROPDOWNLIST_AGENTGROUPLIST id="com_AgentGroupId" runat="server" CssClass="Filter" AutoPostBack="True"></DROPDOWNLISTS:WEBDROPDOWNLIST_AGENTGROUPLIST></td>
                        <!-- 
						<td></td>
                        <td></td> 
						-->
                        <td><DROPDOWNLISTS:WEBDROPDOWNLIST_TRANSACTIONTYPELIST id="com_AllowedDomesticTransactionType" runat="server" CssClass="Filter" AutoPostBack="True"></DROPDOWNLISTS:WEBDROPDOWNLIST_TRANSACTIONTYPELIST></td>
                        <td><DROPDOWNLISTS:WEBDROPDOWNLIST_TRANSACTIONTYPELIST id="com_AllowedInternationalTransactionType" runat="server" CssClass="Filter" AutoPostBack="True"></DROPDOWNLISTS:WEBDROPDOWNLIST_TRANSACTIONTYPELIST></td>
                        <td><DROPDOWNLISTS:WEBDROPDOWNLIST_TRANSACTIONTYPELIST id="com_ListOnWebFor" runat="server" CssClass="Filter" AutoPostBack="True"></DROPDOWNLISTS:WEBDROPDOWNLIST_TRANSACTIONTYPELIST></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td><DROPDOWNLISTS:WEBDROPDOWNLIST_LOCATIONLIST id="com_LocationId" runat="server" CssClass="Filter" AutoPostBack="True" DataTextField="Display"
							DataValueField="ID1"></DROPDOWNLISTS:WEBDROPDOWNLIST_LOCATIONLIST></td>
                        <td></td>
                        <td></td>
                      </tr>
                      <tr class="TableHeader" align="center">
                        <td><asp:hyperlink id="Add" runat="server" CssClass="EditHyperLink" NavigateUrl="WebForm_AgentLocationList.aspx?Action=Add&amp;ReturnToUrl=WebFormList_AgentLocationList.aspx&amp;ReturnToDisplay=Back to the list"
							EnableViewState="false"> Add </asp:hyperlink></td>
                        <td><asp:linkbutton id="Label_Name" runat="server" CssClass="TableHeader" EnableViewState="false"> Name </asp:linkbutton></td>
                        <td><asp:linkbutton id="Label_Code" runat="server" CssClass="TableHeader" EnableViewState="false"> Code </asp:linkbutton></td>
                        <td><asp:linkbutton id="Label_AgentAccountId" runat="server" CssClass="TableHeader" EnableViewState="false"> AgentAccount </asp:linkbutton></td>
                        <td><asp:linkbutton id="Label_AgentGroupId" runat="server" CssClass="TableHeader" EnableViewState="false"> AgentGroup </asp:linkbutton></td>
                        <!-- 
						<td><asp:linkbutton visible="false" id="Label_CreditLimitInUSD" runat="server" CssClass="TableHeader" EnableViewState="false"> CreditLimitInUSD </asp:linkbutton></td>
                        <td><asp:linkbutton visible="false" id="Label_IndividualTransactionLimit" runat="server" CssClass="TableHeader" EnableViewState="false"> IndividualTransactionLimit </asp:linkbutton></td>
						-->
                        <td><asp:linkbutton id="Label_AllowedDomesticTransactionType" runat="server" CssClass="TableHeader"
							EnableViewState="false"> AllowedDomesticTransactionType </asp:linkbutton></td>
                        <td><asp:linkbutton id="Label_AllowedInternationalTransactionType" runat="server" CssClass="TableHeader"
							EnableViewState="false"> AllowedInternationalTransactionType </asp:linkbutton></td>
                        <td><asp:linkbutton id="Label_ListOnWebFor" runat="server" CssClass="TableHeader" EnableViewState="false"> ListOnWebFor </asp:linkbutton></td>
                        <td><asp:linkbutton id="Label_Address" runat="server" CssClass="TableHeader" EnableViewState="false"> Address </asp:linkbutton></td>
                        <td><asp:linkbutton id="Label_Telephone" runat="server" CssClass="TableHeader" EnableViewState="false"> Telephone </asp:linkbutton></td>
                        <td><asp:linkbutton id="Label_Fax" runat="server" CssClass="TableHeader" EnableViewState="false"> Fax </asp:linkbutton></td>
                        <td><asp:linkbutton id="Label_Email" runat="server" CssClass="TableHeader" EnableViewState="false"> Email </asp:linkbutton></td>
                        <td><asp:linkbutton id="Label_LocationId" runat="server" CssClass="TableHeader" EnableViewState="false"> Location </asp:linkbutton></td>
                        <td><asp:linkbutton id="Label_ContactPerson" runat="server" CssClass="TableHeader" EnableViewState="false"> ContactPerson </asp:linkbutton></td>
                        <td><asp:linkbutton id="Label_Active" runat="server" CssClass="TableHeader" EnableViewState="false"> Active </asp:linkbutton></td>
                      </tr>
                      <REPEATERS:WEBREPEATERCUSTOM_SPS_AGENTLOCATIONLIST_SELECTDISPLAY id="repeater_AgentLocationList_SelectDisplay" runat="server">
                      <ItemTemplate>
                        <tr class="TableRow" align="center">
                          <td><asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_AgentLocationList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_AgentLocationList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'> Edit </asp:HyperLink>
                              <br>
                              <asp:HyperLink Visible="false" id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_AgentLocationList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_AgentLocationList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'> Delete </asp:HyperLink>
                          </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "Name") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "Code") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "AgentAccountId_Display") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "AgentGroupId_Display") %> </td>
						  <%--     
						  <td><%# DataBinder.Eval(Container.DataItem, "CreditLimitInUSD") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "IndividualTransactionLimit") %> </td> 
						  --%>
                          <td><%# DataBinder.Eval(Container.DataItem, "AllowedDomesticTransactionType_Display") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "AllowedInternationalTransactionType_Display") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "ListOnWebFor_Display") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "Address") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "Telephone") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "Fax") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "Email") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "LocationId_Display") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "ContactPerson") %> </td>
                          <td><%# DataBinder.Eval(Container.DataItem, "Active") %> </td>
                        </tr>
                      </ItemTemplate>
                      </REPEATERS:WEBREPEATERCUSTOM_SPS_AGENTLOCATIONLIST_SELECTDISPLAY>
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
