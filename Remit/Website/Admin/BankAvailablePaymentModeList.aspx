<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Page language="c#" Codebehind="BankAvailablePaymentModeList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.BankAvailablePaymentModeList" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: Bank Payment Mode List</title><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
		<!-- InstanceBeginEditable name="doctitle" -->
		<!-- InstanceEndEditable -->
		<!-- InstanceBeginEditable name="head" -->
		<!-- InstanceEndEditable -->
		<link href="/css/InnerPage.css" rel="stylesheet" type="text/css">
			<link href="/Admin/StyleSheet.css" rel="stylesheet" type="text/css">
	</HEAD>
	<body leftmargin="0" topmargin="0">
		<form id="Form1" runat="server" method="post">
			<table width="100%" height="100%" border="0" cellpadding="0" cellspacing="0" bgcolor="black">
				<tr>
					<td><table width="100%" border="0" cellspacing="0" cellpadding="0">
							<tr>
								<td width="42">&nbsp;</td>
								<td align="center"><font style="LETTER-SPACING: 2pt" face="verdana" color="#ffffff" size="5">We 
										Understand Your Needs...</font></td>
								<td width="42">&nbsp;</td>
								<td width="257"><IMG SRC="/images/layoutImages/logo.jpg" ALT=""></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td height="100%" valign="top"><table width="100%" height="100%" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td valign="top" bgcolor="#cfcfcf"><table width="100%" border="0" cellspacing="0" cellpadding="0">
										<tr>
											<td><table width="100%" border="0" cellspacing="0" cellpadding="0">
													<tr>
														<td align="center"><font size="4" face="Arial, Helvetica, sans-serif"><!-- InstanceBeginEditable name="Heading" --> 
																&nbsp;Bank Payment Mode List <!-- InstanceEndEditable --></font></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
													<tr>
														<td align="center" valign="top"><!-- InstanceBeginEditable name="MainContent" -->
															<table width="100%" border="0" cellspacing="0" cellpadding="0">
																<tr>
																	<td>
																		<asp:Label id="lblMessage" runat="server"></asp:Label></td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td>
																		<asp:DataGrid id="dgrdList" runat="server" Width="100%" AutoGenerateColumns="False">
																			<HeaderStyle Font-Bold="True"></HeaderStyle>
																			<Columns>
																				<asp:HyperLinkColumn Text="Delete" DataNavigateUrlField="Id" DataNavigateUrlFormatString="?Mode=Delete&amp;Id={0}"></asp:HyperLinkColumn>
																				<asp:BoundColumn DataField="BankName" HeaderText="Bank Name"></asp:BoundColumn>
																				<asp:BoundColumn DataField="PaymentModeName" HeaderText="Payment Mode"></asp:BoundColumn>
																			</Columns>
																		</asp:DataGrid></td>
																</tr>
																<tr>
																	<td>
																		<asp:HyperLink id="hlnkAddNew" runat="server" NavigateUrl="?Mode=Add">Add New Association</asp:HyperLink></td>
																</tr>
																<tr>
																	<td><b> </b>
																	</td>
																</tr>
																<tr>
																	<td>
																		<asp:Panel id="pnlAddEdit" runat="server">
																			<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
																				<TR>
																					<TD width="45%"><B>New Mode Of Payment </B>
																					</TD>
																					<TD></TD>
																				</TR>
																				<TR>
																					<TD align="right" width="45%">Bank Name :
																					</TD>
																					<TD>
																						<asp:DropDownList id="ddlBankList" runat="server"></asp:DropDownList></TD>
																				</TR>
																				<TR>
																					<TD align="right">Mode Of Payment :
																					</TD>
																					<TD>
																						<asp:DropDownList id="ddlPaymentMode" runat="server"></asp:DropDownList></TD>
																				</TR>
																				<TR>
																					<TD>&nbsp;</TD>
																					<TD>
																						<asp:Button id="butAdd" runat="server" Width="100px" Text="Add"></asp:Button></TD>
																				</TR>
																			</TABLE>
																		</asp:Panel>
																	</td>
																</tr>
															</table>
															<!-- InstanceEndEditable --></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td valign="top">&nbsp;</td>
										</tr>
									</table>
								</td>
								<td width="260" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
										<tr>
											<td height="46">&nbsp;</td>
										</tr>
										<tr>
											<td align="center" height="48"><font face="verdana" color="#ffffff" size="4">Send Money 
													to Your Destination</font><br>
												<br>
											</td>
										</tr>
										<tr>
											<td height="46" valign="top"><uc1:StatusInfo id="StatusInfo1" runat="server"></uc1:StatusInfo></td>
										</tr>
										<tr>
											<td valign="top"><uc1:Menu2 id="Menu2" runat="server"></uc1:Menu2></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td height="45"><uc1:Menu1 id="Menu11" runat="server"></uc1:Menu1></td>
				</tr>
				<tr>
					<td><font color="#ffffff" size="1" face="Arial, Helvetica, sans-serif">© 2004-2005 ARY 
							Speed Remit. All rights reserved </font>
					</td>
				</tr>
			</table>
		</form>
		<!-- InstanceEnd -->
	</body>
</HTML>
