<%@ Page language="c#" Codebehind="ViewReport_PrincipleCommissionUnPaid.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.ViewReport_PrincipleCommissionUnPaid" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: </title><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
		<!-- InstanceBeginEditable name="doctitle" -->
		<!-- InstanceEndEditable -->
		<!-- InstanceBeginEditable name="head" -->
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
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
																&nbsp;View Principle UnPaid Report <!-- InstanceEndEditable --></font></td>
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
																	<td align="center"><table width="350" border="0" cellspacing="0" cellpadding="0">
																			<tr>
																				<td width="140" align="right">Select Currency :
																				</td>
																				<td>
																					<asp:DropDownList id="ddlCurrencyList" runat="server" DataTextField="Display" DataValueField="ID1"></asp:DropDownList></td>
																			</tr>
																			<tr>
																				<td align="right">Start Date :
																				</td>
																				<td>
																					<asp:TextBox id="txtStartDate" runat="server"></asp:TextBox></td>
																			</tr>
																			<TR>
																				<TD align="right"></TD>
																				<TD><FONT color="red" size="1"><EM>(ex: 12 Jan 2004)</EM></FONT></TD>
																			</TR>
																			<tr>
																				<td align="right">End Date :
																				</td>
																				<td>
																					<asp:TextBox id="txtEndDate" runat="server"></asp:TextBox></td>
																			</tr>
																		</table>
																	</td>
																</tr>
																<tr>
																	<td align="center">
																		<asp:Button id="butDisplay" runat="server" Text="Display"></asp:Button></td>
																</tr>
																<tr>
																	<td>
																		<asp:Label id="lblMessage" runat="server"></asp:Label></td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<TR>
																	<TD align="center">
																		<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="400" border="0">
																			<TR>
																				<TD><STRONG>Opening Balance Details</STRONG></TD>
																			</TR>
																			<TR>
																				<TD>
																					<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="360" border="0">
																						<TR>
																							<TD style="HEIGHT: 14px" width="80"></TD>
																							<TD style="HEIGHT: 14px" align="center"><STRONG>FC</STRONG></TD>
																							<TD style="HEIGHT: 14px" align="right" width="50"></TD>
																							<TD style="HEIGHT: 14px" align="center" width="60"><STRONG>USD</STRONG></TD>
																						</TR>
																						<TR>
																							<TD></TD>
																							<TD align="right">
																								<asp:Label id="lblOpeningCredit" runat="server" Visible="False"></asp:Label></TD>
																							<TD align="right" width="25"></TD>
																							<TD align="right">
																								<asp:Label id="lblOpeningUSDCredit" runat="server" Visible="False"></asp:Label></TD>
																						</TR>
																						<TR>
																							<TD style="HEIGHT: 15px"></TD>
																							<TD style="HEIGHT: 15px" align="right">
																								<asp:Label id="lblOpeningDebit" runat="server" Visible="False"></asp:Label></TD>
																							<TD style="HEIGHT: 15px" align="right" width="25"></TD>
																							<TD style="HEIGHT: 15px" align="right">
																								<asp:Label id="lblOpeningUSDDebit" runat="server" Visible="False"></asp:Label></TD>
																						</TR>
																						<TR style="BACKGROUND-COLOR: white">
																							<TD>Opening&nbsp;Balance :</TD>
																							<TD align="right">
																								<asp:Label id="lblOpeningBalance" runat="server" Font-Bold="True"></asp:Label></TD>
																							<TD align="right" width="25">
																								<asp:Label id="lblOpeningBalanceType" runat="server"></asp:Label></TD>
																							<TD align="right">
																								<asp:Label id="lblOpeningUSDBalance" runat="server" Font-Bold="True"></asp:Label></TD>
																						</TR>
																					</TABLE>
																				</TD>
																			</TR>
																		</TABLE>
																		&nbsp;</TD>
																</TR>
																<TR>
																	<TD align="center">&nbsp;</TD>
																</TR>
																<tr>
																	<td align="center">
																		<asp:DataGrid id="dgrdAccounts" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="Black">
																			<HeaderStyle Font-Bold="True" HorizontalAlign="Center"></HeaderStyle>
																			<Columns>
																				<asp:BoundColumn DataField="VoucherNumber" HeaderText="Voucher No"></asp:BoundColumn>
																				<asp:BoundColumn DataField="FinalDate" HeaderText="Date" DataFormatString="{0: dd MMM yyyy}"></asp:BoundColumn>
																				<asp:BoundColumn DataField="Particulars" HeaderText="Particulars"></asp:BoundColumn>
																				<asp:BoundColumn DataField="FC" HeaderText="FC"></asp:BoundColumn>
																				<asp:BoundColumn DataField="DebitLC2" HeaderText="Debit (FC)" DataFormatString="{0:0.00}">
																					<ItemStyle HorizontalAlign="Right"></ItemStyle>
																				</asp:BoundColumn>
																				<asp:BoundColumn DataField="DebitUSD2" HeaderText="Debit (USD)" DataFormatString="{0:0.00}">
																					<ItemStyle HorizontalAlign="Right"></ItemStyle>
																				</asp:BoundColumn>
																				<asp:BoundColumn DataField="CreditLC2" HeaderText="Credit (FC)" DataFormatString="{0:0.00}">
																					<ItemStyle HorizontalAlign="Right"></ItemStyle>
																				</asp:BoundColumn>
																				<asp:BoundColumn DataField="CreditUSD2" HeaderText="Credit (USD)" DataFormatString="{0:0.00}">
																					<ItemStyle HorizontalAlign="Right"></ItemStyle>
																				</asp:BoundColumn>
																			</Columns>
																		</asp:DataGrid>
																		<asp:HyperLink id="hlnkPrintView" runat="server" Visible="False" Target="_blank">Print View</asp:HyperLink></td>
																</tr>
																<TR>
																	<TD align="center">
																		<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="400" border="0">
																			<TR>
																				<TD><STRONG>Closing Balance Details</STRONG></TD>
																			</TR>
																			<TR>
																				<TD><TABLE id="Table1" cellSpacing="0" cellPadding="0" width="360" border="0">
																						<TR>
																							<TD width="80"></TD>
																							<TD align="center"><STRONG>FC</STRONG></TD>
																							<TD align="right" width="50"></TD>
																							<TD align="center" width="60"><STRONG>USD</STRONG></TD>
																						</TR>
																						<TR>
																							<TD>Total Credit :</TD>
																							<TD align="right"><asp:Label id="lblTotalCredit" runat="server"></asp:Label></TD>
																							<TD align="right" width="25"></TD>
																							<TD align="right"><asp:Label id="lblTotalUSDCredit" runat="server"></asp:Label></TD>
																						</TR>
																						<TR>
																							<TD>Total Debit :</TD>
																							<TD align="right"><asp:Label id="lblTotalDebit" runat="server"></asp:Label></TD>
																							<TD align="right" width="25"></TD>
																							<TD align="right"><asp:Label id="lblTotalUSDDebit" runat="server"></asp:Label></TD>
																						</TR>
																						<TR style="BACKGROUND-COLOR: white">
																							<TD>Closing Balance :</TD>
																							<TD align="right"><asp:Label id="lblBalance" runat="server" Font-Bold="True"></asp:Label></TD>
																							<TD align="right" width="25"><asp:Label id="lblBalanceType" runat="server"></asp:Label></TD>
																							<TD align="right"><asp:Label id="lblBalanceUSD" runat="server" Font-Bold="True"></asp:Label></TD>
																						</TR>
																					</TABLE>
																				</TD>
																			</TR>
																		</TABLE>
																	</TD>
																</TR>
																<TR>
																	<TD align="center"></TD>
																</TR>
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
												<br></td>
										</tr>
										<tr>
											<td height="46" valign="top" style="COLOR:#ffffff"><uc1:StatusInfo id="StatusInfo1" runat="server"></uc1:StatusInfo></td>
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
					<td height="45"><uc1:Menu1 id="Menu1" runat="server"></uc1:Menu1></td>
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
