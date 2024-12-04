<%@ Page language="c#" Codebehind="WebForm_CustomerList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebForm_CustomerList" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>

<html><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
<head>

<!-- InstanceBeginEditable name="doctitle" -->
<title>ARY Speed Remit :: </title>
<!-- InstanceEndEditable -->
<!-- InstanceBeginEditable name="head" -->
		
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link href="StyleSheet.css" type="text/css" rel="stylesheet">
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
                    <asp:panel id="ErrorDisplay" runat="server" visible="false">
                      <asp:Label id="lab_Error" runat="server" CssClass="ErrorDisplayStyle"></asp:Label>
                    </asp:panel>
                    <asp:HyperLink id="ReturnURL" runat="server" CssClass="EditHyperLink" EnableViewState="true" Visible="false" NavigateUrl="" Text="Return"> </asp:HyperLink>
                    <asp:panel id="MainDisplay" runat="server">
                      <table border="0" cellspacing="10" cellpadding="5">
                        <tr>
                          <td align="Right" class="MandatoryLabelStyle"> LoginName </td>
                          <td><asp:TextBox id="txt_LoginName" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="1" ReadOnly="true" ></asp:TextBox>
                          </td>
                          <td><asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_LoginName" CssClass="ErrorStyle"></asp:Label>
                          </td>
                        </tr>
                        <tr>
                          <td align="Right" class="OptionalLabelStyle"> Password </td>
                          <td><asp:TextBox CssClass="OptionalTextBoxStyle" id="txt_Password" runat="server" tabIndex="2" TextMode="Password" ></asp:TextBox>
                          </td>
                          <td><asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_Password" CssClass="ErrorStyle"></asp:Label>
                          </td>
                        </tr>
                        <tr>
                          <td align="Right" class="MandatoryLabelStyle"> FirstName </td>
                          <td><asp:TextBox id="txt_FirstName" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="3" ReadOnly="true" ></asp:TextBox>
                          </td>
                          <td><asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_FirstName" CssClass="ErrorStyle"></asp:Label>
                          </td>
                        </tr>
                        <tr>
                          <td align="Right" class="MandatoryLabelStyle"> LastName </td>
                          <td><asp:TextBox id="txt_LastName" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="4" ReadOnly="true" ></asp:TextBox>
                          </td>
                          <td><asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_LastName" CssClass="ErrorStyle"></asp:Label>
                          </td>
                        </tr>
                        <tr>
                          <td align="Right" class="OptionalLabelStyle"> Card </td>
                          <td><DropDownLists:WebDropDownList_CustomerCardList Enabled="false" id="com_CardId" runat="server" CssClass="OptionalComboBoxStyle" tabIndex="5"> </DropDownLists:WebDropDownList_CustomerCardList> </td>
                        </tr>
                        <tr>
                          <td align="Right" class="OptionalLabelStyle"> Address </td>
                          <td><asp:TextBox id="txt_Address" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="6" ReadOnly="true" ></asp:TextBox>
                          </td>
                          <td><asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_Address" CssClass="ErrorStyle"></asp:Label>
                          </td>
                        </tr>
                        <tr>
                          <td align="Right" class="OptionalLabelStyle"> Telephone </td>
                          <td><asp:TextBox id="txt_Telephone" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="7" ReadOnly="true" ></asp:TextBox>
                          </td>
                          <td><asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_Telephone" CssClass="ErrorStyle"></asp:Label>
                          </td>
                        </tr>
                        <tr>
                          <td align="Right" class="OptionalLabelStyle"> Fax </td>
                          <td><asp:TextBox id="txt_Fax" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="8" ReadOnly="true" ></asp:TextBox>
                          </td>
                          <td><asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_Fax" CssClass="ErrorStyle"></asp:Label>
                          </td>
                        </tr>
                        <tr>
                          <td align="Right" class="OptionalLabelStyle"> Mobile </td>
                          <td><asp:TextBox id="txt_Mobile" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="9" ReadOnly="true" ></asp:TextBox>
                          </td>
                          <td><asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_Mobile" CssClass="ErrorStyle"></asp:Label>
                          </td>
                        </tr>
                        <tr>
                          <td align="Right" class="OptionalLabelStyle"> Email </td>
                          <td><asp:TextBox id="txt_Email" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="10" ReadOnly="true" ></asp:TextBox>
                          </td>
                          <td><asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_Email" CssClass="ErrorStyle"></asp:Label>
                          </td>
                        </tr>
                        <tr>
                          <td align="Right" class="OptionalLabelStyle"> IDType </td>
                          <td><asp:TextBox id="txt_IDType" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="11" ReadOnly="true" ></asp:TextBox>
                          </td>
                          <td><asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_IDType" CssClass="ErrorStyle"></asp:Label>
                          </td>
                        </tr>
                        <tr>
                          <td align="Right" class="OptionalLabelStyle"> IDDetails </td>
                          <td><asp:TextBox id="txt_IDDetails" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="12" ReadOnly="true" ></asp:TextBox>
                          </td>
                          <td><asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_IDDetails" CssClass="ErrorStyle"></asp:Label>
                          </td>
                        </tr>
                        <tr>
                          <td align="Right" class="OptionalLabelStyle"> IDExpirationDate </td>
                          <td><asp:TextBox id="txt_IDExpirationDate" runat="server" CssClass="OptionalTextBoxStyle" tabIndex="13" ReadOnly="true" ></asp:TextBox>
                          </td>
                          <td><asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_IDExpirationDate" CssClass="ErrorStyle"></asp:Label>
                          </td>
                        </tr>
                        <tr>
                          <td align="Right" class="OptionalLabelStyle"> Nationality </td>
                          <td><DropDownLists:WebDropDownList_MasterCountryList Enabled="false" id="com_Nationality" runat="server" CssClass="OptionalComboBoxStyle" tabIndex="14"> </DropDownLists:WebDropDownList_MasterCountryList> </td>
                        </tr>
                        <tr>
                          <td></td>
                          <td><asp:CheckBox id="chk_Active" runat="server" Text="Active" CssClass="MandatoryCheckBoxStyle" tabIndex="15"></asp:CheckBox>
                          </td>
                        </tr>
                        <tr> </tr>
                        <tr>
                          <td></td>
                          <td align="center"><table border="0" cellspacing="10" cellpadding="5">
                              <tr align="center">
                                <td><asp:Button id="cmdRefresh" runat="server" Text="Refresh" CssClass="ButtonStyle" tabIndex="16"></asp:Button>
                                </td>
                                <td><asp:Button id="cmdDelete" runat="server" Text="Delete" CssClass="ButtonStyle" tabIndex="17"></asp:Button>
                                </td>
                                <td><asp:Button id="cmdUpdate" runat="server" Text="Update" CssClass="ButtonStyle" tabIndex="18"></asp:Button>
                                </td>
                              </tr>
                          </table></td>
                        </tr>
                      </table>
                    </asp:panel>
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
