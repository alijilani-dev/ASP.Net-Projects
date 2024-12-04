<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Page language="c#" Codebehind="ViewOpenTransaction.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.ViewOpenTransaction" %>
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
																&nbsp;View Transaction Detail <!-- InstanceEndEditable --></font></td>
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
																<TR>
																	<TD>&nbsp;</TD>
																</TR>
																<TR>
																	<TD>&nbsp;</TD>
																</TR>
																<tr>
																	<td align="center"><asp:label id="lblMessage" runat="server"></asp:label></td>
																</tr>
																<TR>
																	<TD><asp:label id="lblGlobalTransactionNumber" runat="server"></asp:label></TD>
																</TR>
																<TR>
																	<TD style="HEIGHT: 5px"><asp:label id="lblGlobalPayOutAmount" runat="server"></asp:label></TD>
																</TR>
																<TR>
																	<TD>&nbsp;
																		<asp:label id="lblAgentLocation" runat="server" DESIGNTIMEDRAGDROP="707" Visible="False">Agent Location :</asp:label><asp:dropdownlist id="ddlAgentLocation" runat="server" Visible="False" DataTextField="Display" DataValueField="ID1"></asp:dropdownlist><asp:panel id="Panel1" runat="server" Height="32px">
																			<P align="center">
																				<asp:Button id="btnYes" runat="server" Text="Yes" Width="50px"></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;
																				<asp:Button id="btnNo" runat="server" Text="No" Width="50px"></asp:Button></P>
																		</asp:panel></TD>
																</TR>
																<tr>
																	<td align="center"><asp:panel id="pnlStage1" runat="server" Visible="False">
																			<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="450" border="0">
																				<TR>
																					<TD>Stage 1
																					</TD>
																				</TR>
																				<TR>
																					<TD>&nbsp;</TD>
																				</TR>
																				<TR>
																					<TD>
																						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
																							<TR>
																								<TD align="right" width="180">SRTRNo :
																								</TD>
																								<TD>
																									<asp:TextBox id="txtTransactionNumber" runat="server"></asp:TextBox></TD>
																							</TR>
																						</TABLE>
																					</TD>
																				</TR>
																				<TR>
																					<TD>&nbsp;</TD>
																				</TR>
																				<TR>
																					<TD align="center">&nbsp;
																						<asp:Button id="butProceedFromStage1" runat="server" Text="Proceed to Stage 2"></asp:Button></TD>
																				</TR>
																			</TABLE>
																		</asp:panel></td>
																</tr>
																<tr>
																	<td align="center"><asp:panel id="pnlStage2" runat="server" Visible="False">
																			<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="450" border="0">
																				<TR>
																					<TD>Stage 2
																					</TD>
																				</TR>
																				<TR>
																					<TD>&nbsp;</TD>
																				</TR>
																				<TR>
																					<TD><FONT size="1">[<STRONG>Either one of the following information should match the 
																								transaction record</STRONG>]<BR>
																							[<FONT color="#0000ff">Please fill in only the fields you want to be validated and 
																								clear others</FONT>] </FONT>
																					</TD>
																				</TR>
																				<TR>
																					<TD>
																						<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="100%" border="0">
																							<TR>
																								<TD align="right" width="200">Beneficery First Name :
																								</TD>
																								<TD>
																									<asp:TextBox id="txtBeneficeryFirstName" runat="server"></asp:TextBox></TD>
																							</TR>
																							<TR>
																								<TD align="right">Originating City :
																								</TD>
																								<TD>
																									<asp:TextBox id="txtOriginLocation" runat="server"></asp:TextBox></TD>
																							</TR>
																						</TABLE>
																					</TD>
																				</TR>
																				<TR>
																					<TD>&nbsp;</TD>
																				</TR>
																				<TR>
																					<TD align="center">
																						<asp:Button id="butProceedFromStage2" runat="server" Text="Proceed to Stage 3"></asp:Button></TD>
																				</TR>
																			</TABLE>
																		</asp:panel></td>
																</tr>
																<tr>
																	<td align="center"><asp:panel id="pnlStage3" runat="server" Visible="False">
																			<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="450" border="0">
																				<TR>
																					<TD>Stage 3
																					</TD>
																				</TR>
																				<TR>
																					<TD align="center">
																						<asp:Button id="butProceedFromStage3" runat="server" Text="Proceed to Stage 4"></asp:Button></TD>
																				</TR>
																			</TABLE>
																		</asp:panel></td>
																</tr>
																<tr>
																	<td align="center"><asp:panel id="pnlStage4" runat="server" Visible="False" Height="66px">
																			<TABLE id="Table7" cellSpacing="0" cellPadding="0" width="450" border="0">
																				<TR>
																					<TD>Stage 4
																					</TD>
																				</TR>
																				<TR>
																					<TD align="center">
																						<asp:Button id="butProceedFromStage4" runat="server" Text="Proceed to PayOut Details"></asp:Button></TD>
																				</TR>
																			</TABLE>
																		</asp:panel></td>
																</tr>
																<tr>
																	<td align="center"><asp:panel id="pnlStage5" runat="server" Visible="False">
																			<TABLE id="Table9" cellSpacing="0" cellPadding="0" width="600" border="0">
																				<TR>
																					<TD>Stage 5
																					</TD>
																				</TR>
																				<TR>
																					<TD>&nbsp;</TD>
																				</TR>
																				<TR>
																					<TD>
																						<TABLE id="Table10" cellPadding="0" width="100%" border="0">
																							<TR>
																								<TD>
																									<TABLE id="Table11" cellSpacing="0" cellPadding="0" width="100%" border="0">
																										<TR>
																											<TD align="right" width="180">SRTR No&nbsp;:</TD>
																											<TD>
																												<asp:Label id="lblTransactionNumber" runat="server"></asp:Label></TD>
																										</TR>
																										<TR>
																											<TD align="right">Amount :
																											</TD>
																											<TD>
																												<asp:Label id="lblPayOutAmount" runat="server"></asp:Label></TD>
																										</TR>
																									</TABLE>
																								</TD>
																							</TR>
																							<TR>
																								<TD>&nbsp;</TD>
																							</TR>
																							<TR>
																								<TD>
																									<TABLE id="Table12" cellSpacing="0" cellPadding="0" width="100%" border="0">
																										<TR>
																											<TD width="50%"><STRONG>Beneficiary Details </STRONG>
																											</TD>
																											<TD><STRONG>Remitter Details</STRONG></TD>
																										</TR>
																										<TR>
																											<TD vAlign="top">
																												<TABLE id="Table13" cellSpacing="0" cellPadding="0" width="100%" border="0">
																													<TR>
																														<TD width="80">Name :
																														</TD>
																														<TD>
																															<asp:Label id="lblBeneficeryName" runat="server"></asp:Label></TD>
																													</TR>
																													<TR>
																														<TD>Telephone :
																														</TD>
																														<TD>
																															<asp:Label id="lblBeneficeryTelephone" runat="server"></asp:Label></TD>
																													</TR>
																													<TR>
																														<TD>Address :
																														</TD>
																														<TD>
																															<asp:Label id="lblBeneficeryAddress" runat="server"></asp:Label></TD>
																													</TR>
																												</TABLE>
																											</TD>
																											<TD vAlign="top">
																												<TABLE id="Table14" cellSpacing="0" cellPadding="0" width="100%" border="0">
																													<TR>
																														<TD width="80">Name :
																														</TD>
																														<TD>
																															<asp:Label id="lblRemitterName" runat="server"></asp:Label></TD>
																													</TR>
																													<TR>
																														<TD>Telephone :
																														</TD>
																														<TD>
																															<asp:Label id="lblRemitterTelephone" runat="server"></asp:Label></TD>
																													</TR>
																													<TR>
																														<TD>Address :
																														</TD>
																														<TD>
																															<asp:Label id="lblRemitterAddress" runat="server"></asp:Label></TD>
																													</TR>
																												</TABLE>
																											</TD>
																										</TR>
																									</TABLE>
																								</TD>
																							</TR>
																							<TR>
																								<TD style="HEIGHT: 39px">
																									<asp:ValidationSummary id="ValidationSummary1" runat="server" Width="100%"></asp:ValidationSummary></TD>
																							</TR>
																							<TR>
																								<TD>
																									<TABLE id="Table8" cellSpacing="0" cellPadding="0" width="100%" border="0">
																										<TR>
																											<TD width="120">Expected Id :
																											</TD>
																											<TD>
																												<asp:Label id="lblExpectedId" runat="server"></asp:Label></TD>
																										</TR>
																										<TR>
																											<TD>Provided Id Type :
																											</TD>
																											<TD>
																												<asp:TextBox id="txtProvidedIdType" runat="server"></asp:TextBox>
																												<asp:RequiredFieldValidator id="rfvProviderIdType" runat="server" ErrorMessage="ID type needed" Display="Dynamic"
																													EnableClientScript="False" ControlToValidate="txtProvidedIdType" Enabled="False">*</asp:RequiredFieldValidator></TD>
																										</TR>
																										<TR>
																											<TD>Provided Id Details :
																											</TD>
																											<TD>
																												<asp:TextBox id="txtProvidedIdDetails" runat="server"></asp:TextBox>
																												<asp:RequiredFieldValidator id="rfvProvidedIDDetails" runat="server" ErrorMessage="Id Details needed!" Display="Dynamic"
																													EnableClientScript="False" ControlToValidate="txtProvidedIdDetails" Enabled="False">*</asp:RequiredFieldValidator></TD>
																										</TR>
																										<TR>
																											<TD>Provided Id Expiry :
																											</TD>
																											<TD>
																												<asp:TextBox id="txtProvidedIdExpiry" runat="server"></asp:TextBox>
																												<asp:RequiredFieldValidator id="rfvProviderIdExpiry" runat="server" ErrorMessage="Id Expiry needed!" Display="Dynamic"
																													EnableClientScript="False" ControlToValidate="txtProvidedIdExpiry" Enabled="False">*</asp:RequiredFieldValidator></TD>
																										</TR>
																										<TR>
																											<TD>&nbsp;</TD>
																											<TD><FONT size="1">(format: 12 Jan 2005&nbsp;(or) mm/dd/yyyy)</FONT></TD>
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
																						<asp:Button id="butPayOut" runat="server" Text="PayOut"></asp:Button></TD>
																				</TR>
																			</TABLE>
																		</asp:panel></td>
																</tr>
																<tr>
																	<td align="center">&nbsp;</td>
																</tr>
															</table>
															<!-- InstanceEndEditable --></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td vAlign="top">&nbsp;</td>
										</tr>
									</table>
								</td>
								<td vAlign="top" width="260">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0">
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
											<td vAlign="top" height="46"><uc1:statusinfo id="StatusInfo1" runat="server"></uc1:statusinfo></td>
										</tr>
										<tr>
											<td vAlign="top"><uc1:menu2 id="Menu2" runat="server"></uc1:menu2></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td height="45"></td>
				</tr>
				<tr>
					<td><font face="Arial, Helvetica, sans-serif" color="#ffffff" size="1">© 2004-2005 ARY 
							Speed Remit. All rights reserved </font>
					</td>
				</tr>
			</table>
		</form>
		<!-- InstanceEnd -->
	</body>
</HTML>
