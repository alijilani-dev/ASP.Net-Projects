<%@ Page language="c#" Codebehind="PrintView_AgencyCommissionIncome.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.PrintView_AgencyCommissionIncome" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>SR Commission Income Report</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
	</HEAD>
	<body leftmargin="0" topmargin="0" MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<table width="100%" border="0" cellspacing="0" cellpadding="0">
				<tr>
					<td align="center"><h1>SR Commission Income Report
						</h1>
					</td>
				</tr>
				<tr>
					<td><table width="100%" border="0" cellspacing="0" cellpadding="0">
							<tr>
								<td width="25%" align="right">From Date :
								</td>
								<td width="25%">&nbsp;
									<asp:Label id="lblFromDate" runat="server"></asp:Label></td>
								<td width="25%" align="right">To Date :
								</td>
								<td width="25%">&nbsp;
									<asp:Label id="lblToDate" runat="server"></asp:Label></td>
							</tr>
							<tr>
								<td align="right">Currency :
								</td>
								<td>&nbsp;
									<asp:Label id="lblCurrency" runat="server"></asp:Label></td>
								<td align="right">&nbsp;</td>
								<td>&nbsp;</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td>&nbsp;
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD align="center">&nbsp;
									<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="400" border="0">
										<TR>
											<TD><STRONG>Opening Balance Details</STRONG></TD>
										</TR>
										<TR>
											<TD>
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
														<TD></TD>
														<TD align="right"></TD>
														<TD align="right" width="25"></TD>
														<TD align="right"></TD>
													</TR>
													<TR>
														<TD style="HEIGHT: 15px"></TD>
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
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD>&nbsp;</TD>
							</TR>
							<TR>
								<TD align="center">
									<asp:datagrid id="dgrdAccounts" runat="server" BackColor="White" AutoGenerateColumns="False" BorderColor="Black"
										Width="90%">
										<ItemStyle HorizontalAlign="Right"></ItemStyle>
										<HeaderStyle Font-Bold="True" HorizontalAlign="Center"></HeaderStyle>
										<Columns>
											<asp:BoundColumn DataField="VoucherNumber" HeaderText="V.No"></asp:BoundColumn>
											<asp:BoundColumn DataField="Date" HeaderText="Date" DataFormatString="{0: dd MMM yyyy}">
												<ItemStyle HorizontalAlign="Center"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="TransactionNumber" HeaderText="SRTR No"></asp:BoundColumn>
											<asp:BoundColumn DataField="CurrencyCode" HeaderText="Currency"></asp:BoundColumn>
											<asp:BoundColumn DataField="DebitLC" HeaderText="Debit (FC)" DataFormatString="{0:#########0.00}"></asp:BoundColumn>
											<asp:BoundColumn DataField="DebitUSD" HeaderText="Debit (USD)" DataFormatString="{0:#########0.00}"></asp:BoundColumn>
											<asp:BoundColumn DataField="CreditLC" HeaderText="Credit (FC)" DataFormatString="{0:#########0.00}"></asp:BoundColumn>
											<asp:BoundColumn DataField="CreditUSD" HeaderText="Credit (USD)" DataFormatString="{0:#########0.00}"></asp:BoundColumn>
										</Columns>
									</asp:datagrid></TD>
							</TR>
							<TR>
								<TD>&nbsp;</TD>
							</TR>
							<TR>
								<TD align="center">
									<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="400" border="0">
										<TR>
											<TD><STRONG>Closing Balance Details</STRONG></TD>
										</TR>
										<TR>
											<TD>
												<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="360" border="0">
													<TR>
														<TD width="80"></TD>
														<TD align="center"><STRONG>
																<asp:Label id="lblFC2" runat="server">FC</asp:Label></STRONG></TD>
														<TD align="right" width="50"></TD>
														<TD align="center" width="60"><STRONG>
																<asp:Label id="lblUSD2" runat="server">USD</asp:Label></STRONG></TD>
													</TR>
													<TR>
														<TD>Total Credit :</TD>
														<TD align="right">
															<asp:label id="lblTotalCredit" runat="server"></asp:label></TD>
														<TD align="right" width="25"></TD>
														<TD align="right">
															<asp:Label id="lblTotalUSDCredit" runat="server"></asp:Label></TD>
													</TR>
													<TR>
														<TD>Total Debit :</TD>
														<TD align="right">
															<asp:Label id="lblTotalDebit" runat="server"></asp:Label></TD>
														<TD align="right" width="25"></TD>
														<TD align="right">
															<asp:Label id="lblTotalUSDDebit" runat="server"></asp:Label></TD>
													</TR>
													<TR style="BACKGROUND-COLOR: white">
														<TD>Closing Balance :</TD>
														<TD align="right">
															<asp:Label id="lblBalance" runat="server" Font-Bold="True"></asp:Label></TD>
														<TD align="right" width="25">
															<asp:Label id="lblBalanceType" runat="server"></asp:Label></TD>
														<TD align="right">
															<asp:Label id="lblBalanceUSD" runat="server" Font-Bold="True"></asp:Label></TD>
													</TR>
												</TABLE>
											</TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
						</TABLE>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
