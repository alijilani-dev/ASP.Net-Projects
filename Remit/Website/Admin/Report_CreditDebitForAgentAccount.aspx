<%@ Page language="c#" Codebehind="Report_CreditDebitForAgentAccount.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.Report_CreditDebitForAgentAccount" %>
<html><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
<head>

<!-- InstanceBeginEditable name="doctitle" -->
<title>ARY Speed Remit :: Credit / Debit Report</title>
<!-- InstanceEndEditable -->
<!-- InstanceBeginEditable name="head" -->
		


<link href="/Admin/StyleSheet.css" rel="stylesheet" type="text/css">
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
                  <td align="center"><font size="4" face="Arial, Helvetica, sans-serif"><!-- InstanceBeginEditable name="Heading" --> &nbsp;Credit / Debit Report <!-- InstanceEndEditable --></font></td>
                  </tr>
              </table></td>
            </tr>
            <tr>
              <td valign="top"><table width="100%"  border="0" cellspacing="0" cellpadding="0">
                <tr>
                  <td align="center" valign="top"><!-- InstanceBeginEditable name="MainContent" --><table width="100%" border="0" cellpadding="0">
																<tr>
																	<td class="TableRow">
																		<table width="100%" border="0" cellpadding="0">
																			<tr>
																				<td width="180" align="right" class="TableRow">Select Agent Account:
																				</td>
																				<td><asp:DropDownList id="ddlAgentAccount" runat="server" DataTextField="Display" DataValueField="ID1"></asp:DropDownList></td>
																			</tr>
																			<tr>
																				<td align="right" class="TableRow">Account Type:
																				</td>
																				<td><asp:DropDownList id="ddlAccountType" runat="server"></asp:DropDownList></td>
																			</tr>
																		</table>
																	</td>
																</tr>
																<TR>
																	<TD><table width="100%" border="0" cellpadding="0">
																			<tr class="TableRow">
																				<td width="25%">Start Date
																				</td>
																				<td width="25%">
																					<asp:TextBox id="txtStartDate" runat="server" Columns="11" MaxLength="11"></asp:TextBox></td>
																				<td width="25%">End Date :
																				</td>
																				<td width="25%">
																					<asp:TextBox id="txtEndDate" runat="server" Columns="11" MaxLength="11"></asp:TextBox></td>
																			</tr>
																			<TR>
																				<TD align="right" width="25%"></TD>
																				<TD width="25%"><FONT face="Arial" size="1"><EM>(11 Oct 2004)</EM></FONT></TD>
																				<TD align="right" width="25%"></TD>
																				<TD width="25%"><FONT face="Arial" size="1"><EM>(11 Oct 2005)</EM></FONT></TD>
																			</TR>
																		</table>
																	</TD>
																</TR>
																<TR>
																	<TD>&nbsp;</TD>
																</TR>
																<TR>
																	<TD>&nbsp;
																		<asp:Button id="butFilter" runat="server" Text="Filter"></asp:Button></TD>
																</TR>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td>
																		<asp:DataGrid id="dgrdAccounts" runat="server" Width="100%" AutoGenerateColumns="False">
																			<HeaderStyle Font-Size="X-Small" Font-Bold="True" HorizontalAlign="Center"></HeaderStyle>
																			<Columns>
																				<asp:BoundColumn DataField="TransactionNumber" HeaderText="SR TR No">
																					<ItemStyle Wrap="False"></ItemStyle>
																				</asp:BoundColumn>
																				<asp:BoundColumn DataField="CreditLC" HeaderText="Credit(LC)"></asp:BoundColumn>
																				<asp:BoundColumn DataField="CreditInUSD" HeaderText="Credit-USD"></asp:BoundColumn>
																				<asp:BoundColumn DataField="DebitLC" HeaderText="Debit(LC)"></asp:BoundColumn>
																				<asp:BoundColumn DataField="DebitInUSD" HeaderText="Debit-USD"></asp:BoundColumn>
																				<asp:BoundColumn DataField="SettlementStatus" HeaderText="Settlement Status"></asp:BoundColumn>
																				<asp:BoundColumn DataField="AccountType" HeaderText="AccountType"></asp:BoundColumn>
																			</Columns>
																		</asp:DataGrid></td>
																</tr>
															</table><!-- InstanceEndEditable --></td>
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
