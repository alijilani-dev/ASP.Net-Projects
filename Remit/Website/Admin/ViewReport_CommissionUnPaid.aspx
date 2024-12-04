<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Page language="c#" Codebehind="ViewReport_CommissionUnPaid.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.ViewReport_CommissionUnPaid" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: </title><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
		<!-- InstanceBeginEditable name="doctitle" -->
		<!-- InstanceEndEditable -->
		<!-- InstanceBeginEditable name="head" -->
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<!-- InstanceEndEditable --><LINK href="/css/InnerPage.css" type="text/css" rel="stylesheet"><LINK href="/Admin/StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body leftMargin="0" topMargin="0">
		<form id="Form1" method="post" runat="server">
			<table height="100%" cellSpacing="0" cellPadding="0" width="100%" bgColor="black" border="0">
				<tr>
					<td>
						<table cellSpacing="0" cellPadding="0" width="100%" border="0">
							<tr>
								<td width="42">&nbsp;</td>
								<td align="center"><font style="LETTER-SPACING: 2pt" face="verdana" color="#ffffff" size="5">We 
										Understand Your Needs...</font></td>
								<td width="42">&nbsp;</td>
								<td width="257"><IMG alt="" src="/images/layoutImages/logo.jpg"></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td vAlign="top" height="100%">
						<table height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<tr>
								<td vAlign="top" bgColor="#cfcfcf">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td>
												<table cellSpacing="0" cellPadding="0" width="100%" border="0">
													<tr>
														<td align="center"><font face="Arial, Helvetica, sans-serif" size="4"><!-- InstanceBeginEditable name="Heading" --> 
																&nbsp;Commission UnPaid Account <!-- InstanceEndEditable --></font></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td vAlign="top">
												<table cellSpacing="0" cellPadding="0" width="100%" border="0">
													<tr>
														<td vAlign="top" align="center"><!-- InstanceBeginEditable name="MainContent" -->
															<table cellSpacing="0" cellPadding="0" width="100%" border="0">
																<tr>
																	<td><asp:label id="lblMessage" runat="server"></asp:label></td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td align="center">
																		<table cellSpacing="0" cellPadding="0" width="350" border="0">
																			<tr>
																				<td align="right" width="140">Select Currency :
																				</td>
																				<td><asp:dropdownlist id="ddlCurrencyList" runat="server" DataValueField="ID1" DataTextField="Display"></asp:dropdownlist></td>
																			</tr>
																			<tr>
																				<td align="right">Start Date :
																				</td>
																				<td><asp:textbox id="txtStartDate" runat="server"></asp:textbox></td>
																			</tr>
																			<TR>
																				<TD align="right"></TD>
																				<TD><FONT color="red" size="1"><EM>(ex: 12 Jan 2004)</EM></FONT></TD>
																			</TR>
																			<tr>
																				<td align="right">End Date :
																				</td>
																				<td><asp:textbox id="txtEndDate" runat="server"></asp:textbox></td>
																			</tr>
																		</table>
																	</td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td align="center"><asp:button id="butDisplay" runat="server" Text="Display"></asp:button></td>
																</tr>
																<TR>
																	<TD>&nbsp;</TD>
																</TR>
																<TR>
																	<TD align="center">&nbsp;
																		<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="360" border="0">
																			<TR>
																				<TD style="HEIGHT: 14px" width="80"></TD>
																				<TD style="HEIGHT: 14px" align="center"><STRONG>
																						<asp:Label id="lblFC1" runat="server">FC</asp:Label></STRONG></TD>
																				<TD style="HEIGHT: 14px" align="right" width="50"></TD>
																				<TD style="HEIGHT: 14px" align="center" width="60"><STRONG>
																						<asp:Label id="lblUSD1" runat="server">USD</asp:Label></STRONG></TD>
																			</TR>
																			<TR>
																				<TD>Total Credit :</TD>
																				<TD align="right"></TD>
																				<TD align="right" width="25"></TD>
																				<TD align="right"></TD>
																			</TR>
																			<TR>
																				<TD style="HEIGHT: 15px">Total Debit :</TD>
																				<TD style="HEIGHT: 15px" align="right"></TD>
																				<TD style="HEIGHT: 15px" align="right" width="25"></TD>
																				<TD style="HEIGHT: 15px" align="right"></TD>
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
																<TR>
																	<TD>&nbsp;</TD>
																</TR>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td align="center"><asp:datagrid id="dgrdAccounts" runat="server" BackColor="White" AutoGenerateColumns="False" BorderColor="Black"
																			Width="90%">
																			<HeaderStyle Font-Bold="True" HorizontalAlign="Center"></HeaderStyle>
																			<Columns>
																				<asp:BoundColumn DataField="VoucherNumber" HeaderText="Voucher No"></asp:BoundColumn>
																				<asp:BoundColumn DataField="FinalDate" HeaderText="Date" DataFormatString="{0: dd MMM yyyy}"></asp:BoundColumn>
																				<asp:BoundColumn DataField="Particulars" HeaderText="Particulars"></asp:BoundColumn>
																				<asp:BoundColumn DataField="DebitLC2" HeaderText="Debit (LC)" DataFormatString="{0:#########0.00}"></asp:BoundColumn>
																				<asp:BoundColumn DataField="DebitUSD2" HeaderText="Debit (USD)" DataFormatString="{0:#########0.00}"></asp:BoundColumn>
																				<asp:BoundColumn DataField="CreditLC2" HeaderText="Credit (LC)" DataFormatString="{0:#########0.00}"></asp:BoundColumn>
																				<asp:BoundColumn DataField="CreditUSD2" HeaderText="Credit (USD)" DataFormatString="{0:#########0.00}"></asp:BoundColumn>
																			</Columns>
																		</asp:datagrid>
																		<asp:HyperLink id="hlnkPrintView" runat="server" Visible="False" Target="_blank">Print View</asp:HyperLink></td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td align="center">
																		<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="400" border="0">
																			<TR>
																				<TD><STRONG>Closing Balance Details</STRONG></TD>
																			</TR>
																			<TR>
																				<TD>
																					<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="360" border="0">
																						<TR>
																							<TD width="80"></TD>
																							<TD align="center"><STRONG>FC</STRONG></TD>
																							<TD align="right" width="50"></TD>
																							<TD align="center" width="60"><STRONG>USD</STRONG></TD>
																						</TR>
																						<TR>
																							<TD>Total Credit :</TD>
																							<TD align="right"><asp:label id="lblTotalCredit" runat="server"></asp:label></TD>
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
