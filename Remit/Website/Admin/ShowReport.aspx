<%@ Page language="c#" Codebehind="ShowReport.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.ShowReport" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ShowReceipt</title>
		<script language="javascript" type="text/javascript">
			var win=null;
			function printThisPage() {
				var locationToOpen = window.location.href +"&ForPrint=True";
				win = window.open(locationToOpen,"PrintWindow","height=600,width=950,location=0,menubar=0,scrollbars=1,status=1");
				window.setTimeout("win.print()",1000);
			}
		</script>
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="0">
				<TR>
					<TD>
						<P align="center"><STRONG><FONT face="Verdana" size="4">Sent Transactions Report</FONT></STRONG></P>
					</TD>
				</TR>
				<TR>
					<TD>
						<P align="center">&nbsp;</P>
					</TD>
				</TR>
				<TR>
					<TD><asp:literal id="litReceipt" runat="server"></asp:literal></TD>
				</TR>
				<TR>
					<TD></TD>
				</TR>
				<TR>
					<TD><asp:panel id="pnlNonPrint" runat="server">
							<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
								<TR>
									<TD align="center" width="33%"></TD>
									<TD align="center"><INPUT onclick="printThisPage()" type="button" size="100" value="Print"></TD>
									<TD align="center" width="33%"></TD>
								</TR>
							</TABLE>
						</asp:panel></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
