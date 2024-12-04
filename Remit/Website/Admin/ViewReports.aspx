<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Page language="c#" Codebehind="ViewReports.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.ViewReports" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: Reports</title><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
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
														<td align="center"><font size="4" face="Arial, Helvetica, sans-serif"><!-- InstanceBeginEditable name="Heading" -->  &nbsp;Reports<!-- InstanceEndEditable --></font></td>
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
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td><a href="ViewReport_PrincipleCommission.aspx">Principal &amp; Commission Account / 
																			Commission Income Account</a>
																	</td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td>
																		<asp:HyperLink id="hlnkPrincipleCommissionUnpaid" runat="server" Visible="False" NavigateUrl="ViewReport_PrincipleCommissionUnPaid.aspx">Unpaid Principal Report</asp:HyperLink></td>
																</tr>
															</table>
															<!-- InstanceEndEditable --> &nbsp;</td>
													</tr>
												</table>
												<asp:HyperLink id="hlnkSRIncomeAccount" runat="server" Visible="False" NavigateUrl="ViewReport_AgencyCommissionIncome.aspx">SR Commission Income Account</asp:HyperLink></td>
										</tr>
										<TR>
											<TD vAlign="top">&nbsp;</TD>
										</TR>
										<TR>
											<TD style="HEIGHT: 15px" vAlign="top">
												<asp:HyperLink id="hlnkUnpaidCommissionReport" runat="server" NavigateUrl="ViewReport_CommissionUnPaid.aspx"
													Visible="False">Unpaid Commission Report</asp:HyperLink></TD>
										</TR>
										<TR>
											<TD style="HEIGHT: 15px" vAlign="top">&nbsp;</TD>
										</TR>
										<TR>
											<TD style="HEIGHT: 15px" vAlign="top">
												<asp:HyperLink id="hlnkExposure" runat="server" Visible="False" NavigateUrl="ViewReport_CurrencyExposure.aspx">Exposure Statement</asp:HyperLink></TD>
										</TR>
										<TR>
											<TD style="HEIGHT: 15px" vAlign="top">&nbsp;</TD>
										</TR>
										<TR>
											<TD style="HEIGHT: 15px" vAlign="top">
												<asp:HyperLink id="hlnkExchangeEarning" runat="server" Visible="False" NavigateUrl="ViewReport_ExchangeEarnings.aspx">Exchange Earnings</asp:HyperLink></TD>
										</TR>
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
												<br>
											</td>
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
