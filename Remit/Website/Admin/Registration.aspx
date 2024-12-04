<%@ Page language="c#" Codebehind="Registration.aspx.cs" AutoEventWireup="false" Inherits="SRM.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Registration</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD style="HEIGHT: 30px" align="right" bgColor="black">
						<asp:Image id="Image1" runat="server" ImageUrl="logo.jpg"></asp:Image></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 61px" align="center">
						<asp:Label id="Label1" runat="server" BorderStyle="Outset" Font-Bold="True" Font-Names="Arial"
							Font-Size="16pt" Width="324px" Height="8px" ForeColor="#000040">New Agent Registration Form</asp:Label></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 9px" align="center">
						<asp:Label id="Label2" runat="server" ForeColor="Red" Font-Size="10pt" Font-Names="Arial" Font-Bold="True"></asp:Label></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 603px" align="center">
						<TABLE id="tb" style="WIDTH: 642px; HEIGHT: 584px" cellSpacing="0" cellPadding="0" width="642"
							border="0" runat="server">
							<TR>
								<TD style="WIDTH: 972px"><FONT size="2"><FONT face="Arial"><STRONG></STRONG></FONT></FONT></TD>
								<TD style="WIDTH: 545px"></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 972px; HEIGHT: 2px">
									<P><FONT size="2"><FONT face="Arial"><STRONG>Company Name </STRONG></FONT></FONT><FONT size="2">
											<FONT face="Arial"><STRONG><FONT face="Arial" size="1">(As appearing in the license)</FONT></STRONG></FONT></FONT></P>
								</TD>
								<TD style="WIDTH: 545px; HEIGHT: 2px">
									<asp:TextBox id="company" runat="server" BorderStyle="Solid" Width="224px" Height="18px" BackColor="White"
										BorderColor="Black" ForeColor="Black" BorderWidth="1px" MaxLength="50"></asp:TextBox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 972px; HEIGHT: 25px">
									<P><FONT size="2"><FONT face="Arial"><STRONG>Full Address of Company</STRONG></FONT></FONT></P>
								</TD>
								<TD style="WIDTH: 545px; HEIGHT: 25px">
									<asp:TextBox id="caddress" runat="server" BorderStyle="Solid" Width="335px" Height="60px" BackColor="White"
										BorderColor="Black" ForeColor="Black" BorderWidth="1px" TextMode="MultiLine" MaxLength="250"></asp:TextBox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 972px"><FONT size="2"><FONT face="Arial"><STRONG>Contact Person</STRONG></FONT></FONT></TD>
								<TD style="WIDTH: 545px">
									<asp:TextBox id="cperson" runat="server" BorderStyle="Solid" Width="224px" Height="18px" BackColor="White"
										BorderColor="Black" ForeColor="Black" BorderWidth="1px" MaxLength="250"></asp:TextBox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 972px"><FONT size="2"><FONT face="Arial"><STRONG>Phone#</STRONG></FONT></FONT></TD>
								<TD style="WIDTH: 545px">
									<asp:TextBox id="phone" runat="server" BorderStyle="Solid" Width="176px" Height="18px" BackColor="White"
										BorderColor="Black" ForeColor="Black" BorderWidth="1px" MaxLength="250"></asp:TextBox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 972px; HEIGHT: 5px"><FONT size="2"><FONT face="Arial"><STRONG>Fax#</STRONG></FONT></FONT></TD>
								<TD style="WIDTH: 545px; HEIGHT: 5px">
									<asp:TextBox id="fax" runat="server" BorderStyle="Solid" Width="176px" Height="18px" BackColor="White"
										BorderColor="Black" ForeColor="Black" BorderWidth="1px" MaxLength="250"></asp:TextBox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 972px"><FONT size="2"><FONT face="Arial"><STRONG>Email&nbsp;&nbsp;&nbsp;&nbsp;
												<asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" Font-Names="Arial" Font-Size="8pt"
													ErrorMessage="RegularExpressionValidator" ControlToValidate="email" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Please enter valid Email</asp:RegularExpressionValidator></STRONG></FONT></FONT></TD>
								<TD style="WIDTH: 545px">
									<asp:TextBox id="email" runat="server" BorderStyle="Solid" Width="216px" Height="18px" BackColor="White"
										BorderColor="Black" ForeColor="Black" BorderWidth="1px" MaxLength="250"></asp:TextBox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 972px; HEIGHT: 19px">
									<P><FONT size="2"><FONT face="Arial"><STRONG>Head Office Address </STRONG></FONT></FONT>
										<FONT face="Arial" size="1">(Incase of more than 1 branch)</FONT></P>
								</TD>
								<TD style="WIDTH: 545px; HEIGHT: 19px">
									<asp:TextBox id="hoaddress" runat="server" BorderStyle="Solid" Width="335px" Height="60px" BackColor="White"
										BorderColor="Black" ForeColor="Black" BorderWidth="1px" TextMode="MultiLine"></asp:TextBox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 972px"><FONT size="2"><FONT face="Arial"><STRONG>Date of Establishment of 
												Company</STRONG></FONT></FONT></TD>
								<TD style="WIDTH: 545px">
									<asp:TextBox id="dateofestab" runat="server" BorderStyle="Solid" Width="168px" Height="18px"
										BackColor="White" BorderColor="Black" ForeColor="Black" BorderWidth="1px"></asp:TextBox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 972px"><FONT size="2"><FONT face="Arial"><STRONG>No. of Branches</STRONG></FONT></FONT></TD>
								<TD style="WIDTH: 545px">
									<asp:TextBox id="nob" runat="server" BorderStyle="Solid" Width="72px" Height="18px" BackColor="White"
										BorderColor="Black" ForeColor="Black" BorderWidth="1px"></asp:TextBox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 972px"><FONT size="2"><FONT face="Arial"><STRONG>Working Hours</STRONG></FONT></FONT></TD>
								<TD style="WIDTH: 545px">
									<asp:TextBox id="whours" runat="server" BorderStyle="Solid" Width="128px" Height="18px" BackColor="White"
										BorderColor="Black" ForeColor="Black" BorderWidth="1px"></asp:TextBox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 972px"><FONT size="2"><FONT face="Arial"><STRONG>Constitution</STRONG></FONT></FONT></TD>
								<TD style="WIDTH: 545px">
									<asp:DropDownList id="constitution" runat="server" Width="192px" Height="18px">
										<asp:ListItem Value="Individual">Individual</asp:ListItem>
										<asp:ListItem Value="Proprietor">Proprietor</asp:ListItem>
										<asp:ListItem Value="Partnership">Partnership</asp:ListItem>
										<asp:ListItem Value="Private Ltd. Co.">Private Ltd. Co.</asp:ListItem>
										<asp:ListItem Value="Public Ltd. Co.">Public Ltd. Co.</asp:ListItem>
										<asp:ListItem Value="Other">Other</asp:ListItem>
									</asp:DropDownList></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 972px; HEIGHT: 37px">
									<P><FONT size="2"><FONT face="Arial"><STRONG>Name of the Proprietor / Partners / Director of 
													the Organisation</STRONG></FONT></FONT></P>
								</TD>
								<TD style="WIDTH: 545px; HEIGHT: 37px">
									<asp:TextBox id="nop" runat="server" BorderStyle="Solid" Width="336px" Height="60px" BackColor="White"
										BorderColor="Black" ForeColor="Black" BorderWidth="1px" TextMode="MultiLine"></asp:TextBox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 972px">
									<P><FONT size="2"><FONT face="Arial"><STRONG>Name&nbsp;of banks with whom the account is 
													maintained </STRONG></FONT></FONT><FONT face="Arial" size="1">(Seperated 
											by Commas)</FONT></P>
								</TD>
								<TD style="WIDTH: 545px">
									<asp:TextBox id="nobanks" runat="server" BorderStyle="Solid" Width="335px" Height="60px" BackColor="White"
										BorderColor="Black" ForeColor="Black" BorderWidth="1px" TextMode="MultiLine"></asp:TextBox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 972px; HEIGHT: 45px"><FONT size="2"><FONT face="Arial"><STRONG>Can reference 
												be made to banks with whom DD arrangements are enjoyed</STRONG></FONT></FONT></TD>
								<TD style="WIDTH: 545px; HEIGHT: 45px">&nbsp;&nbsp;&nbsp;&nbsp;
									<asp:RadioButton id="ref1" runat="server" Text="Yes" Font-Bold="True" Font-Names="Arial" Font-Size="10pt"
										GroupName="Reference"></asp:RadioButton>&nbsp;&nbsp;&nbsp;&nbsp;
									<asp:RadioButton id="ref2" runat="server" Text="No" Font-Bold="True" Font-Names="Arial" Font-Size="10pt"
										GroupName="Reference"></asp:RadioButton></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 972px; HEIGHT: 43px"><FONT size="2"><FONT face="Arial"><STRONG>Number of 
												transactions expected during the first year</STRONG></FONT></FONT></TD>
								<TD style="WIDTH: 545px; HEIGHT: 43px">
									<asp:TextBox id="notrans" runat="server" BorderStyle="Solid" Width="104px" Height="18px" BackColor="White"
										BorderColor="Black" ForeColor="Black" BorderWidth="1px"></asp:TextBox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 972px; HEIGHT: 43px"><FONT face="Arial"><FONT size="2"><STRONG>Total amount 
												of transactions expected during the first year</STRONG></FONT></FONT></TD>
								<TD style="WIDTH: 545px; HEIGHT: 43px"><FONT face="Arial"><FONT size="2">
											<asp:TextBox id="aotrans" runat="server" BorderStyle="Solid" Width="168px" Height="18px" BackColor="White"
												BorderColor="Black" ForeColor="Black" BorderWidth="1px"></asp:TextBox></FONT></FONT></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 972px; HEIGHT: 57px" colSpan="2">
									<asp:CheckBox id="agree" runat="server" Text=" I hereby declare that the above-mentioned information is true to the best of my knowledge"
										Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Navy"></asp:CheckBox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 972px; HEIGHT: 57px" align="center" colSpan="2">
									<asp:Button id="Submit" runat="server" Text="Submit" Font-Bold="True" Width="109px"></asp:Button>&nbsp;&nbsp;</TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD align="center"></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 19px"></TD>
				</TR>
				<TR>
					<TD></TD>
				</TR>
				<TR>
					<TD></TD>
				</TR>
			</TABLE>
			&nbsp;
		</form>
	</body>
</HTML>
