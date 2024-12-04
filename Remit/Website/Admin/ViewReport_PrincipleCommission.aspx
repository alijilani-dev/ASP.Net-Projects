<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Page language="c#" Codebehind="ViewReport_PrincipleCommission.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.ViewReport_PrincipleCommission" %>
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
																&nbsp;Principal Commission Account Report <!-- InstanceEndEditable --></font></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td vAlign="top">
												<table cellSpacing="0" cellPadding="0" width="100%" border="0">
													<tr>
														<td vAlign="top" align="center"><!-- InstanceBeginEditable name="MainContent" -->
															&nbsp;
															<table cellSpacing="0" cellPadding="0" width="100%" border="0">
																<tr>
																	<td align="center">
																		<table cellSpacing="0" cellPadding="0" width="90%" border="0">
																			<tr>
																				<td align="right" width="200">Select Agent Account :
																				</td>
																				<td><asp:dropdownlist id="ddlAgentAccountList" runat="server" DataTextField="Display" DataValueField="ID1"></asp:dropdownlist></td>
																			</tr>
																			<TR>
																				<TD align="right">Select Report Type :</TD>
																				<TD><asp:dropdownlist id="ddlReportType" runat="server" AutoPostBack="True">
																						<asp:ListItem Value="PC">Principal &amp; Commission</asp:ListItem>
																						<asp:ListItem Value="52428800">Commission Income</asp:ListItem>
																					</asp:dropdownlist></TD>
																			</TR>
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
																	<td align="center"><asp:button id="butDisplay" runat="server" Text="Display"></asp:button></td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td><asp:label id="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="True"></asp:label></td>
																</tr>
																<TR>
																	<TD align="center">
																		<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="400" border="0">
																			<TR>
																				<TD><STRONG>Opening Balance Details</STRONG></TD>
																			</TR>
																			<TR>
																				<TD>
																					<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="360" border="0">
																						<TR>
																							<TD style="HEIGHT: 14px" width="80"></TD>
																							<TD style="HEIGHT: 14px" align="center"><STRONG><asp:label id="lblFC1" runat="server">FC</asp:label></STRONG></TD>
																							<TD style="HEIGHT: 14px" align="right" width="50"></TD>
																							<TD style="HEIGHT: 14px" align="center" width="60"><STRONG><asp:label id="lblUSD1" runat="server">USD</asp:label></STRONG></TD>
																						</TR>
																						<TR>
																							<TD style="HEIGHT: 13px"></TD>
																							<TD style="HEIGHT: 13px" align="right"></TD>
																							<TD style="HEIGHT: 13px" align="right" width="25"></TD>
																							<TD style="HEIGHT: 13px" align="right"></TD>
																						</TR>
																						<TR>
																							<TD style="HEIGHT: 15px"></TD>
																							<TD style="HEIGHT: 15px" align="right"></TD>
																							<TD style="HEIGHT: 15px" align="right" width="25"></TD>
																							<TD style="HEIGHT: 15px" align="right"></TD>
																						</TR>
																						<TR style="BACKGROUND-COLOR: white">
																							<TD>Opening&nbsp;Balance :</TD>
																							<TD align="right"><asp:label id="lblOpeningBalance" runat="server" Font-Bold="True"></asp:label></TD>
																							<TD align="right" width="25"><asp:label id="lblOpeningBalanceType" runat="server"></asp:label></TD>
																							<TD align="right"><asp:label id="lblOpeningUSDBalance" runat="server" Font-Bold="True"></asp:label></TD>
																						</TR>
																					</TABLE>
																				</TD>
																			</TR>
																		</TABLE>
																	</TD>
																</TR>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td align="center"><asp:datagrid id="dgrdAccountReport" runat="server" AutoGenerateColumns="False" BackColor="White"
																			BorderColor="Black">
																			<HeaderStyle Font-Size="X-Small" Font-Bold="True" HorizontalAlign="Center"></HeaderStyle>
																			<Columns>
																				<asp:BoundColumn DataField="VoucherNumber" HeaderText="V.No">
																					<ItemStyle HorizontalAlign="Center"></ItemStyle>
																				</asp:BoundColumn>
																				<asp:BoundColumn DataField="FinalDate" HeaderText="Date" DataFormatString="{0:dd MMM yyyy}"></asp:BoundColumn>
																				<asp:BoundColumn DataField="Particulars" HeaderText="Particulars"></asp:BoundColumn>
																				<asp:BoundColumn DataField="DebitLC" HeaderText="Debit (LC)" DataFormatString="{0:##########.00}">
																					<ItemStyle HorizontalAlign="Right"></ItemStyle>
																				</asp:BoundColumn>
																				<asp:BoundColumn DataField="DebitUSD" HeaderText="Debit (USD)" DataFormatString="{0:##########.00}">
																					<ItemStyle HorizontalAlign="Right"></ItemStyle>
																				</asp:BoundColumn>
																				<asp:BoundColumn DataField="CreditLC" HeaderText="Credit (LC)" DataFormatString="{0:##########.00}">
																					<ItemStyle HorizontalAlign="Right"></ItemStyle>
																				</asp:BoundColumn>
																				<asp:BoundColumn DataField="CreditUSD" HeaderText="Credit (USD)" DataFormatString="{0:##########.00}">
																					<ItemStyle HorizontalAlign="Right"></ItemStyle>
																				</asp:BoundColumn>
																				<asp:BoundColumn DataField="Location" HeaderText="Location" DataFormatString="{0}">
																					<ItemStyle HorizontalAlign="Left"></ItemStyle>
																				</asp:BoundColumn>
																				<asp:BoundColumn DataField="FinalDate" HeaderText="Time" DataFormatString="{0: hh:mm:ss}"></asp:BoundColumn>
																				<asp:TemplateColumn>
																					<ItemTemplate>
																						<asp:HyperLink id=HyperLink1 runat="server" Text="View Details..." Visible='<%# (ddlReportType.SelectedValue=="PC") %>' NavigateUrl='<%# (ddlReportType.SelectedValue=="PC")?(DataBinder.Eval(Container,"DataItem.Mode").ToString()=="S"?DataBinder.Eval(Container, "DataItem.TransId","ShowReceipt.aspx?Id={0}").ToString():DataBinder.Eval(Container, "DataItem.TransId","ShowReceipt.aspx?Id={0}&amp;Type=ForPayOut").ToString()):"" %>'>View Details...</asp:HyperLink>
																					</ItemTemplate>
																				</asp:TemplateColumn>
																			</Columns>
																		</asp:datagrid></td>
																</tr>
															</table>
															<!-- InstanceEndEditable -->
															<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="400" border="0">
																<TR>
																	<TD><STRONG>Closing Balance Details</STRONG></TD>
																</TR>
																<TR>
																	<TD>
																		<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="360" border="0">
																			<TR>
																				<TD width="80"></TD>
																				<TD align="center"><STRONG><asp:label id="lblFC2" runat="server">FC</asp:label></STRONG></TD>
																				<TD align="right" width="50"></TD>
																				<TD align="center" width="60"><STRONG><asp:label id="lblUSD2" runat="server">USD</asp:label></STRONG></TD>
																			</TR>
																			<TR>
																				<TD>Total Credit :</TD>
																				<TD align="right"><asp:label id="lblTotalCredit" runat="server"></asp:label></TD>
																				<TD align="right" width="25"></TD>
																				<TD align="right"><asp:label id="lblTotalUSDCredit" runat="server"></asp:label></TD>
																			</TR>
																			<TR>
																				<TD>Total Debit :</TD>
																				<TD align="right"><asp:label id="lblTotalDebit" runat="server"></asp:label></TD>
																				<TD align="right" width="25"></TD>
																				<TD align="right"><asp:label id="lblTotalUSDDebit" runat="server"></asp:label></TD>
																			</TR>
																			<TR style="BACKGROUND-COLOR: white">
																				<TD>Closing Balance :</TD>
																				<TD align="right"><asp:label id="lblBalance" runat="server" Font-Bold="True"></asp:label></TD>
																				<TD align="right" width="25"><asp:label id="lblBalanceType" runat="server"></asp:label></TD>
																				<TD align="right"><asp:label id="lblBalanceUSD" runat="server" Font-Bold="True"></asp:label></TD>
																			</TR>
																		</TABLE>
																	</TD>
																</TR>
															</TABLE>
														</td>
													</tr>
													<TR>
														<TD vAlign="top" align="center"><asp:hyperlink id="hlnkPrintView" runat="server" Visible="False" Target="_blank">Print View</asp:hyperlink></TD>
													</TR>
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
											<td height="48"><IMG alt="" src="/images/layoutImages/Banner_SendMoney.jpg"></td>
										</tr>
										<tr>
											<td style="COLOR: #ffffff" vAlign="top" height="46"><uc1:statusinfo id="StatusInfo1" runat="server"></uc1:statusinfo></td>
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
					<td height="45"><uc1:menu1 id="Menu11" runat="server"></uc1:menu1></td>
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
