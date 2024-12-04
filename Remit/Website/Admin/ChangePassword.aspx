<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Page language="c#" Codebehind="ChangePassword.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.ChangePassword" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: Change Password</title><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
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
																&nbsp;Change Password <!-- InstanceEndEditable --></font></td>
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
																<TR>
																	<TD>
																		<asp:ValidationSummary id="ValidationSummary1" runat="server"></asp:ValidationSummary></TD>
																</TR>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td>User :
																		<asp:Label id="lblUserLoginName" runat="server"></asp:Label>
																	</td>
																</tr>
																<tr>
																	<td align="center"><table width="500" border="0" cellspacing="0" cellpadding="0">
																			<tr>
																				<td align="right" width="200">&nbsp;</td>
																				<td>
																					<asp:CheckBox id="cbxChangeLoginPassword" runat="server" Text="Change Login Password"></asp:CheckBox></td>
																			</tr>
																			<tr>
																				<td align="right">
																					Login Password :
																				</td>
																				<td>
																					<asp:TextBox id="txtPassword1" runat="server" TextMode="Password"></asp:TextBox>
																					<asp:RequiredFieldValidator id="rfvLoginPassword" runat="server" ErrorMessage="Password is required !" Display="Dynamic"
																						EnableClientScript="False" ControlToValidate="txtPassword1" Enabled="False">*</asp:RequiredFieldValidator></td>
																			</tr>
																			<tr>
																				<td align="right">Re-type Login Password :
																				</td>
																				<td>
																					<asp:TextBox id="txtPassword2" runat="server" TextMode="Password"></asp:TextBox>
																					<asp:CompareValidator id="cvLoginPassword" runat="server" ErrorMessage="Login passwords did not match"
																						Display="Dynamic" EnableClientScript="False" ControlToValidate="txtPassword2" ControlToCompare="txtPassword1"
																						Enabled="False">*</asp:CompareValidator></td>
																			</tr>
																			<tr>
																				<td align="right">&nbsp;</td>
																				<td>&nbsp;</td>
																			</tr>
																			<tr>
																				<td align="right">&nbsp;</td>
																				<td>
																					<asp:CheckBox id="cbxChangeTransactionPassword" runat="server" Text="Change Transaction Password"></asp:CheckBox></td>
																			</tr>
																			<tr>
																				<td align="right">Transaction Password :
																				</td>
																				<td>
																					<asp:TextBox id="txtPassword3" runat="server" TextMode="Password"></asp:TextBox>
																					<asp:RequiredFieldValidator id="rfvTransactionPassword" runat="server" ErrorMessage="Transaction password is required"
																						Display="Dynamic" EnableClientScript="False" ControlToValidate="txtPassword3" Enabled="False">*</asp:RequiredFieldValidator></td>
																			</tr>
																			<tr>
																				<td align="right">Re-enter Transaction Password :
																				</td>
																				<td>
																					<asp:TextBox id="txtPassword4" runat="server" TextMode="Password"></asp:TextBox>
																					<asp:CompareValidator id="cvTransactionPassword" runat="server" ErrorMessage="Transaction Passwords did not match!"
																						Display="Dynamic" EnableClientScript="False" ControlToValidate="txtPassword4" ControlToCompare="txtPassword3"
																						Enabled="False">*</asp:CompareValidator></td>
																			</tr>
																		</table>
																	</td>
																</tr>
																<tr>
																	<td align="center">
																		<asp:Button id="butChange" runat="server" Text="Change Password"></asp:Button></td>
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
												<br></td>
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
