<%@ Page language="c#" Codebehind="PrintView_CommissionUnPaid.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.PrintView_CommissionUnPaid" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>PrintView_CommissionUnPaid</title>
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
					<td align="center"><h1>
							<asp:Label id="lblTitle" runat="server">Comission Unpaid Account Report</asp:Label>
							&nbsp;
						</h1>
					</td>
				</tr>
				<tr>
					<td><table width="100%" border="0" cellspacing="0" cellpadding="0">
							<tr>
								<td width="50%" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
										<tr>
											<td width="15%" align="right">From</td>
											<td width="120">&nbsp;
												<asp:Label id="lblFromDate" runat="server"></asp:Label>
											</td>
											<td width="15%" align="right">To</td>
											<td>&nbsp;&nbsp;
												<asp:Label id="lblToDate" runat="server"></asp:Label>
											</td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td align="center"><TABLE id="Table2" cellSpacing="0" cellPadding="0" width="400" border="0">
							<TR>
								<TD><STRONG>Opening Balance Details</STRONG></TD>
							</TR>
							<TR>
								<TD><TABLE id="Table3" cellSpacing="0" cellPadding="0" width="360" border="0">
										<TR>
											<TD style="HEIGHT: 14px" width="80"></TD>
											<TD style="HEIGHT: 14px" align="center"><STRONG>FC</STRONG></TD>
											<TD style="HEIGHT: 14px" align="right" width="50"></TD>
											<TD style="HEIGHT: 14px" align="center" width="60"><STRONG>USD</STRONG></TD>
										</TR>
										<TR>
											<TD></TD>
											<TD align="right"><asp:Label id="lblOpeningCredit" runat="server" Visible="False"></asp:Label></TD>
											<TD align="right" width="25"></TD>
											<TD align="right"><asp:Label id="lblOpeningUSDCredit" runat="server" Visible="False"></asp:Label></TD>
										</TR>
										<TR>
											<TD style="HEIGHT: 15px"></TD>
											<TD style="HEIGHT: 15px" align="right"><asp:Label id="lblOpeningDebit" runat="server" Visible="False"></asp:Label></TD>
											<TD style="HEIGHT: 15px" align="right" width="25"></TD>
											<TD style="HEIGHT: 15px" align="right"><asp:Label id="lblOpeningUSDDebit" runat="server" Visible="False"></asp:Label></TD>
										</TR>
										<TR style="BACKGROUND-COLOR: white">
											<TD>Opening&nbsp;Balance :</TD>
											<TD align="right"><asp:Label id="lblOpeningBalance" runat="server" Font-Bold="True"></asp:Label></TD>
											<TD align="right" width="25"><asp:Label id="lblOpeningBalanceType" runat="server"></asp:Label></TD>
											<TD align="right"><asp:Label id="lblOpeningUSDBalance" runat="server" Font-Bold="True"></asp:Label></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
						</TABLE>
					</td>
				</tr>
				<TR>
					<TD align="center">&nbsp;</TD>
				</TR>
				<tr>
					<td align="center">
						<asp:datagrid id="dgrdAccounts" runat="server" BorderColor="Black" BackColor="White" AutoGenerateColumns="False"
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
						</asp:datagrid></td>
				</tr>
				<TR>
					<TD>&nbsp;</TD>
				</TR>
				<TR>
					<TD align="center">&nbsp;
						<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="360" border="0">
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
			</table>
		</form>
	</body>
</HTML>
