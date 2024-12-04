<%@ Page language="c#" Codebehind="Login.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Login" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Login</title>
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table2" height="100%" cellPadding="0" width="100%" border="0">
				<TR>
					<TD height="120">&nbsp;</TD>
				</TR>
				<TR>
					<TD align="center">
						<TABLE id="Table3" cellPadding="0" width="400" border="0">
							<TR>
								<TD>&nbsp;</TD>
							</TR>
							<TR>
								<TD>
									<asp:Label id="lblErrorMessage" runat="server" ForeColor="#C04000" Font-Size="X-Small"></asp:Label></TD>
							</TR>
							<TR>
								<TD>
									<TABLE id="Table1" cellPadding="0" width="100%" border="0">
										<TR>
											<TD align="right" width="35%"><STRONG><FONT face="Arial, Helvetica, sans-serif" size="2">Login 
														Name : </FONT></STRONG>
											</TD>
											<TD>
												<asp:TextBox id="txtLoginName" runat="server" MaxLength="50" Columns="25" BorderWidth="1px" BorderStyle="Solid"></asp:TextBox></TD>
										</TR>
										<TR>
											<TD align="right"><STRONG><FONT face="Arial, Helvetica, sans-serif" size="2">Password : </FONT>
												</STRONG>
											</TD>
											<TD>
												<asp:TextBox id="txtPassword" runat="server" MaxLength="50" Columns="25" BorderWidth="1px" BorderStyle="Solid"
													TextMode="Password"></asp:TextBox></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD>&nbsp;</TD>
							</TR>
							<TR>
								<TD align="center">
									<asp:Button id="butLogin" runat="server" BorderWidth="1px" Height="35px" Font-Bold="True" Width="150px"
										BackColor="WhiteSmoke" Text="Login"></asp:Button></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD height="80">&nbsp;</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
