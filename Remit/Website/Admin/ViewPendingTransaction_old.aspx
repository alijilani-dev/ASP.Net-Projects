<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Page language="c#" Codebehind="ViewPendingTransaction_old.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.ViewPendingTransaction" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: </title><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
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
														<td align="center"><font size="4" face="Arial, Helvetica, sans-serif"><!-- InstanceBeginEditable name="Heading" --> 
																&nbsp;View Pending Transactions <!-- InstanceEndEditable --></font></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
													<tr>
														<td align="center" valign="top"><!-- InstanceBeginEditable name="MainContent" -->
															&nbsp;
															<table width="100%" border="0" cellspacing="0" cellpadding="0">
																<tr>
																	<td>
																		<asp:Label id="lblMessage" runat="server"></asp:Label></td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td align="center"><table width="90%" border="0" cellspacing="0" cellpadding="0">
																			<tr>
																				<td>PayOut Transactions</td>
																			</tr>
																			<tr>
																				<td>
																					<asp:DataGrid id="dgrdPayOut" runat="server" AutoGenerateColumns="False" BorderColor="Tan" BorderWidth="1px"
																						BackColor="LightGoldenrodYellow" CellPadding="2" GridLines="None" ForeColor="Black" Width="100%">
																						<FooterStyle BackColor="Tan"></FooterStyle>
																						<SelectedItemStyle ForeColor="GhostWhite" BackColor="DarkSlateBlue"></SelectedItemStyle>
																						<AlternatingItemStyle BackColor="PaleGoldenrod"></AlternatingItemStyle>
																						<HeaderStyle Font-Bold="True" BackColor="Tan"></HeaderStyle>
																						<Columns>
																							<asp:BoundColumn DataField="TransactionNumber" HeaderText="SRTR No"></asp:BoundColumn>
																							<asp:BoundColumn DataField="PayOutAgentUserId_LoginName" HeaderText="Agent Login"></asp:BoundColumn>
																							<asp:BoundColumn DataField="PayInAmount" HeaderText="PayIn Amount"></asp:BoundColumn>
																							<asp:HyperLinkColumn Text="Approve" DataNavigateUrlField="Id" DataNavigateUrlFormatString="ApproveTransaction.aspx?Id={0}"></asp:HyperLinkColumn>
																						</Columns>
																						<PagerStyle HorizontalAlign="Center" ForeColor="DarkSlateBlue" BackColor="PaleGoldenrod"></PagerStyle>
																					</asp:DataGrid></td>
																			</tr>
																		</table>
																	</td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td align="center"><table width="90%" border="0" cellspacing="0" cellpadding="0">
																			<tr>
																				<td>PayIn Transactions</td>
																			</tr>
																			<tr>
																				<td>
																					<asp:DataGrid id="dgrdPayIn" runat="server" AutoGenerateColumns="False" BorderColor="Tan" BorderWidth="1px"
																						BackColor="LightGoldenrodYellow" CellPadding="2" GridLines="None" ForeColor="Black" Width="100%">
																						<FooterStyle BackColor="Tan"></FooterStyle>
																						<SelectedItemStyle ForeColor="GhostWhite" BackColor="DarkSlateBlue"></SelectedItemStyle>
																						<AlternatingItemStyle BackColor="PaleGoldenrod"></AlternatingItemStyle>
																						<HeaderStyle Font-Bold="True" BackColor="Tan"></HeaderStyle>
																						<Columns>
																							<asp:BoundColumn DataField="TransactionNumber" HeaderText="SRTR No"></asp:BoundColumn>
																							<asp:BoundColumn DataField="PayInAgentUserId_LoginName" HeaderText="Agent Login"></asp:BoundColumn>
																							<asp:BoundColumn DataField="PayOutAmount" HeaderText="PayOut Amount"></asp:BoundColumn>
																							<asp:HyperLinkColumn Text="Approve" DataNavigateUrlField="Id" DataNavigateUrlFormatString="ApproveTransaction.aspx?Id={0}"></asp:HyperLinkColumn>
																						</Columns>
																						<PagerStyle HorizontalAlign="Center" ForeColor="DarkSlateBlue" BackColor="PaleGoldenrod"></PagerStyle>
																					</asp:DataGrid></td>
																			</tr>
																		</table>
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
