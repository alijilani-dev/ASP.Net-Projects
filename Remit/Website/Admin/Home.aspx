<%@ Page language="c#" Codebehind="Home.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.Home" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: Home</title><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
		<!-- InstanceBeginEditable name="doctitle" -->
		<!-- InstanceEndEditable -->
		<!-- InstanceBeginEditable name="head" --><LINK href="/css/InnerPage.css" type="text/css" rel="stylesheet">
			<!-- InstanceEndEditable --><LINK href="/css/InnerPage.css" type="text/css" rel="stylesheet"><LINK href="/Admin/StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body leftMargin="0" topMargin="0" link="#000000" vlink="#000000" alink="#000000">
		<script language="javascript">
           function openWindow(url) {
           window.open(url,'SpeedRemit','height=600,width=750,location=0,toolbar=0,scrollbars=1');
           return false;
           }
		</script>
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
											<td align="right"></td>
										</tr>
										<tr>
											<td>
												<table cellSpacing="0" cellPadding="0" width="100%" border="0">
													<tr>
														<td align="center"><font face="Arial, Helvetica, sans-serif" size="4"><!-- InstanceBeginEditable name="Heading" -->  &nbsp;Home<!-- InstanceEndEditable --></font></td>
														<td width="271"></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td vAlign="top" height="242">
												<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
													<tr>
														<td vAlign="top" align="center"><!-- InstanceBeginEditable name="MainContent" -->
															&nbsp;
															<table cellPadding="0" width="100%" border="0">
																<tr>
																	<td>
																		<table cellPadding="0" width="100%" border="0">
																			<tr>
																				<td align="right" width="35%">Current User :
																				</td>
																				<td>&nbsp;
																					<asp:label id="lblCurrentUser" runat="server"></asp:label></td>
																			</tr>
																		</table>
																	</td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td>
																		<table cellPadding="0" width="100%" border="0">
																			<tr>
																				<td vAlign="top" align="right" width="35%">Roles List :
																				</td>
																				<td><asp:datagrid id="dgrdRoleList" runat="server" ShowHeader="False"></asp:datagrid></td>
																			</tr>
																		</table>
																	</td>
																</tr>
															</table>
															<!-- InstanceEndEditable --></td>
														<td vAlign="top" width="133"></td>
													</tr>
													<TR>
														<TD vAlign="top" align="center"></TD>
														<TD vAlign="top" width="133"></TD>
													</TR>
												</TABLE>
											</td>
										</tr>
										<tr>
											<td vAlign="top" align="center">
												<asp:Label id="Label1" runat="server" Font-Bold="True" Font-Names="Book Antiqua" Font-Size="Large">ARY 1 - 2 Ka 4 </asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;<font face="Book Antiqua" color="#ff0700" size="4"><b><A style="TEXT-DECORATION: none" target="_blank" href="http://www.ARYExclusive.com">Winners 
															of 1st Draw!</A></b></font></td>
										</tr>
									</table>
								</td>
								<td vAlign="top" width="260">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td height="46">&nbsp;</td>
										</tr>
										<tr>
											<td align="center" height="48">
												<P><font face="verdana" color="#ffffff" size="4">Send Money to Your Destination</font><br>
												</P>
												<P><FONT face="Trebuchet MS" color="#ffffff" size="3"><EM> <STRONG><a href="javascript:void()" onClick="return openWindow('Announcement.htm')" style="TEXT-DECORATION:none">
																	<img src="../images/layoutimages/glowing_star.gif" border="0">&nbsp;<FONT color="#ff6600">Speed 
																		Jordan</FONT> </a>
																<BR>
															</STRONG></EM></FONT><FONT face="Trebuchet MS" color="#ffffff" size="3"><EM><STRONG>
																<a href="javascript:void()" onClick="return openWindow('SpeedEast.htm')" style="TEXT-DECORATION:none">
																	<img src="../images/layoutimages/glowing_star.gif" border="0">&nbsp;<FONT color="#ff6600">Speed 
																		East</FONT> </a></STRONG></EM></FONT><FONT face="Trebuchet MS" color="#ffffff" size="3">
														<EM><STRONG>
																<BR>
																<a href="javascript:void()" onClick="return openWindow('SpeedNepal.htm')" style="TEXT-DECORATION:none">
																	<img src="../images/layoutimages/glowing_star.gif" border="0">&nbsp;<FONT color="#ff6600">Speed 
																		Nepal</FONT></a></STRONG></EM></FONT>&nbsp;</P>
											</td>
										</tr>
										<tr>
											<td vAlign="top"><uc1:statusinfo id="StatusInfo1" runat="server"></uc1:statusinfo></td>
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
