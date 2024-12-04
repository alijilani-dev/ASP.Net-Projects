<%@ Page language="c#" Codebehind="CreateCustomer.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.CreateCustomer" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>CreateCustomer</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<style type="text/css">TD { FONT-SIZE: 11px; FONT-FAMILY: tahoma }
	INPUT { FONT-SIZE: 11px; FONT-FAMILY: tahoma }
	SELECT { FONT-SIZE: 11px; FONT-FAMILY: tahoma }
		</style>
	</HEAD>
	<body bgColor="silver" ms_positioning="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table3" style="Z-INDEX: 103; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="1"
				cellPadding="1" width="100%" border="0">
				<TR>
					<TD align="center"><asp:label id="lblHeading" runat="server" Font-Size="Medium" Font-Names="Tahoma" Font-Bold="True"
							Width="172px" Height="24px">Customer Creation</asp:label></TD>
				</TR>
				<TR>
					<TD>
						<P align="center"><asp:label id="lblMessage" runat="server" Font-Size="XX-Small" Font-Names="Tahoma" Font-Bold="True"
								ForeColor="Blue" EnableViewState="False"></asp:label></P>
					</TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 42px" align="center"><STRONG>Customer Card No. :</STRONG>
						<asp:textbox id="txtCustomerCardNo" tabIndex="1" runat="server" Font-Bold="True" Width="162px"></asp:textbox>&nbsp;
						<asp:button id="btnCheckCardStatus" runat="server" EnableViewState="False" Text="Check Card Status"></asp:button>&nbsp;</TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 15px" align="center"><FONT size="1"></FONT></TD>
				</TR>
				<TR>
					<TD align="center">
						<TABLE id="Table1" style="WIDTH: 830px; HEIGHT: 330px" cellPadding="0" width="830" align="center"
							border="0">
							<TR>
								<TD style="WIDTH: 99px; HEIGHT: 26px" align="left"><STRONG>Customer Details</STRONG></TD>
								<TD style="WIDTH: 10px; HEIGHT: 26px" align="center"></TD>
								<TD style="WIDTH: 221px; HEIGHT: 26px"></TD>
								<TD style="WIDTH: 108px; HEIGHT: 26px" align="left"><STRONG>Beneficiary Details</STRONG>
								</TD>
								<TD style="WIDTH: 9px; HEIGHT: 26px" align="center"></TD>
								<TD style="HEIGHT: 26px"></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 99px; HEIGHT: 26px" align="left" colSpan="1" rowSpan="1">First 
									Name</TD>
								<TD style="WIDTH: 10px; HEIGHT: 26px" align="center">:</TD>
								<TD style="WIDTH: 221px; HEIGHT: 26px"><asp:textbox id="txtCustFirstName" tabIndex="2" runat="server" Width="167px"></asp:textbox></TD>
								<TD style="WIDTH: 108px; HEIGHT: 26px" align="left" colSpan="1" rowSpan="1">First 
									Name</TD>
								<TD style="WIDTH: 9px; HEIGHT: 26px" align="center">:</TD>
								<TD style="HEIGHT: 26px"><asp:textbox id="txtBenFirstName" runat="server" Width="169px" Height="21px"></asp:textbox></TD>
							</TR>
							<TR>
								<P align="center">
								<P align="center">&nbsp;
									<TD style="WIDTH: 99px; HEIGHT: 25px" align="left">Last Name</TD>
									<TD style="WIDTH: 10px; HEIGHT: 25px" align="center">:</TD>
									<TD style="WIDTH: 221px; HEIGHT: 25px"><asp:textbox id="txtCustLastName" tabIndex="3" runat="server" Width="167px"></asp:textbox></TD>
									<TD style="WIDTH: 108px; HEIGHT: 25px" align="left" width="108">Last Name</TD>
									<TD style="WIDTH: 9px; HEIGHT: 25px" align="center">:</TD>
									<TD style="HEIGHT: 25px"><asp:textbox id="txtBenLastName" runat="server" Width="169px"></asp:textbox></TD>
								</P>
							</TR>
							<TR>
								<TD style="WIDTH: 99px; HEIGHT: 14px" align="left">E-mail Address</TD>
								<TD style="WIDTH: 10px; HEIGHT: 14px" align="center">:</TD>
								<TD style="WIDTH: 221px; HEIGHT: 14px"><asp:textbox id="txtCustEmail" tabIndex="4" runat="server" Width="167px"></asp:textbox></TD>
								<TD style="WIDTH: 108px; HEIGHT: 14px" align="left">E-mail Address</TD>
								<TD style="WIDTH: 9px; HEIGHT: 14px" align="center">:</TD>
								<TD style="HEIGHT: 14px"><asp:textbox id="txtBenEmail" runat="server" Width="169px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 99px; HEIGHT: 67px" align="left">Address</TD>
								<TD style="WIDTH: 10px; HEIGHT: 67px" align="center">:</TD>
								<TD style="WIDTH: 221px; HEIGHT: 67px"><asp:textbox id="txtCustAddress" tabIndex="5" runat="server" Width="212px" Height="63px" TextMode="MultiLine"></asp:textbox></TD>
								<TD style="WIDTH: 108px; HEIGHT: 67px" align="left">Address</TD>
								<TD style="WIDTH: 9px; HEIGHT: 67px" align="center">:</TD>
								<TD style="HEIGHT: 67px"><asp:textbox id="txtBenAddress" runat="server" Width="214px" Height="67px" TextMode="MultiLine"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 99px; HEIGHT: 25px" align="left">Telephone
								</TD>
								<TD style="WIDTH: 10px; HEIGHT: 25px" align="center">:</TD>
								<TD style="WIDTH: 221px; HEIGHT: 25px"><asp:textbox id="txtCustTelephone" tabIndex="6" runat="server" Width="167px"></asp:textbox></TD>
								<TD style="WIDTH: 108px; HEIGHT: 25px" align="left">Telephone
								</TD>
								<TD style="WIDTH: 9px; HEIGHT: 25px" align="center">:</TD>
								<TD style="HEIGHT: 25px"><asp:textbox id="txtBenTelephone" runat="server" Width="169"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 99px" align="left">Mobile</TD>
								<TD style="WIDTH: 10px" align="center">:</TD>
								<TD style="WIDTH: 221px"><asp:textbox id="txtCustMobile" tabIndex="7" runat="server" Width="167px"></asp:textbox></TD>
								<TD style="WIDTH: 108px" align="left">Mobile</TD>
								<TD style="WIDTH: 9px" align="center">:</TD>
								<TD><asp:textbox id="txtBenMobile" runat="server" Width="169"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 99px" align="left">ID Type</TD>
								<TD style="WIDTH: 10px" align="center">:</TD>
								<TD style="WIDTH: 221px"><asp:textbox id="txtCustIDType" tabIndex="8" runat="server" Width="167px"></asp:textbox></TD>
								<TD style="WIDTH: 108px" align="left">ID Type</TD>
								<TD style="WIDTH: 9px" align="center">:</TD>
								<TD><asp:textbox id="txtBenIDType" runat="server" Width="169"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 99px" align="left">ID Number</TD>
								<TD style="WIDTH: 10px" align="center">:</TD>
								<TD style="WIDTH: 221px"><asp:textbox id="txtCustIDNumber" tabIndex="9" runat="server" Width="167px"></asp:textbox></TD>
								<TD style="WIDTH: 108px" align="left">ID Number</TD>
								<TD style="WIDTH: 9px" align="center">:</TD>
								<TD><asp:textbox id="txtBenIDNumber" runat="server" Width="169"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 99px" align="left">ID Expiry
								</TD>
								<TD style="WIDTH: 10px" align="center">:</TD>
								<TD style="WIDTH: 221px"><asp:textbox id="txtCustIDExpiry" tabIndex="10" runat="server" Width="168px"></asp:textbox></TD>
								<TD style="WIDTH: 108px" align="left">ID Expiry
								</TD>
								<TD style="WIDTH: 9px" align="center">:</TD>
								<TD><asp:textbox id="txtBenIDExpiryDate" runat="server" Width="169"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 99px; HEIGHT: 16px" align="left">Nationality</TD>
								<TD style="WIDTH: 10px; HEIGHT: 16px" align="center">:</TD>
								<TD style="WIDTH: 221px; HEIGHT: 16px"><asp:dropdownlist id="ddlCustNationality" runat="server" Width="168px" DataTextField="Display" DataValueField="ID1"></asp:dropdownlist></TD>
								<TD style="WIDTH: 108px; HEIGHT: 16px" align="left">Nationality</TD>
								<TD style="WIDTH: 9px; HEIGHT: 16px" align="center">:</TD>
								<TD style="HEIGHT: 16px"><asp:dropdownlist id="ddlBenNationality" runat="server" Width="168px" DataTextField="Display" DataValueField="ID1"></asp:dropdownlist></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 547px; HEIGHT: 194px" colSpan="4">
									<P><STRONG><BR>
											Beneficiary Bank Details</STRONG></P>
									<P>
										<TABLE id="Table2" style="WIDTH: 431px; HEIGHT: 128px" cellSpacing="0" cellPadding="0"
											width="431" align="center" border="0">
											<TR>
												<TD style="WIDTH: 111px"></TD>
												<TD style="WIDTH: 10px" align="center"></TD>
												<TD align="left"></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 111px">Account Number</TD>
												<TD style="WIDTH: 10px" align="center">:</TD>
												<TD align="left" colSpan="1" rowSpan="1"><asp:textbox id="txtAccountNumber" runat="server" Width="168px"></asp:textbox></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 111px">Bank Name</TD>
												<TD style="WIDTH: 10px" align="center">:</TD>
												<TD><asp:textbox id="txtBankName" runat="server" Width="168px"></asp:textbox></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 111px">Branch Name</TD>
												<TD style="WIDTH: 10px" align="center">:</TD>
												<TD><asp:textbox id="txtBranchName" runat="server" Width="168px"></asp:textbox></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 111px">Address
												</TD>
												<TD style="WIDTH: 10px" align="center">:</TD>
												<TD align="left"><asp:textbox id="txtBankAddress" runat="server" Width="216px" Height="56px" TextMode="MultiLine"></asp:textbox></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 111px; HEIGHT: 22px">Postal/Zip Code</TD>
												<TD style="WIDTH: 10px; HEIGHT: 22px" align="center">:</TD>
												<TD style="HEIGHT: 22px"><asp:textbox id="txtZipCode" runat="server" Width="168px"></asp:textbox></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 111px">Country</TD>
												<TD style="WIDTH: 10px" align="center">:</TD>
												<TD><asp:dropdownlist id="ddlBenBankCountry" runat="server" Width="168px" DataTextField="Display" DataValueField="ID1"></asp:dropdownlist></TD>
											</TR>
										</TABLE>
									</P>
								</TD>
								<TD style="WIDTH: 9px; HEIGHT: 194px"></TD>
								<TD style="WIDTH: 172px; HEIGHT: 194px">
									<P>&nbsp;</P>
									<P>&nbsp;</P>
									<P>&nbsp;</P>
								</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 396px" colSpan="6">
									<P align="center"><asp:button id="btnCreateCustomer" runat="server" Font-Bold="True" Width="114px" Text="Create"
											Visible="False"></asp:button></P>
								</TD>
							</TR>
						</TABLE>
						<P align="center"><asp:button id="Button1" runat="server" Font-Bold="True" Width="114px" Text="Create"></asp:button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							<BR>
						</P>
						<P align="center">&nbsp;</P>
					</TD>
				</TR>
			</TABLE>
			<BR>
			<br>
			<br>
			<P align="center">&nbsp;</P>
		</form>
	</body>
</HTML>
