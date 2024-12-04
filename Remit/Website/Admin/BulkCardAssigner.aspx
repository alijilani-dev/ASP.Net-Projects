<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Page language="c#" Codebehind="BulkCardAssigner.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.BulkCardAssigner" %>
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
																&nbsp;Bulk Customer Card Management <!-- InstanceEndEditable --></font></td>
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
																	<td>
																		<asp:Label id="lblMessage" runat="server"></asp:Label></td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td align="center"><table width="350" border="0" cellspacing="0" cellpadding="0">
																			<TR>
																				<TD align="right" style="HEIGHT: 14px">Agent Account :</TD>
																				<TD style="HEIGHT: 14px">
																					<asp:DropDownList id="ddlAgentAccount" runat="server" AutoPostBack="True" DataValueField="ID1" DataTextField="Display"></asp:DropDownList></TD>
																			</TR>
																			<tr>
																				<td align="right" style="HEIGHT: 13px">Select Agent :
																				</td>
																				<td style="HEIGHT: 13px">
																					<asp:DropDownList id="ddlAgent" runat="server" DataTextField="Display" DataValueField="ID1" AutoPostBack="True"></asp:DropDownList></td>
																			</tr>
																			<tr>
																				<td align="right">Select Prefix :
																				</td>
																				<td>
																					<asp:TextBox id="txtPrefixCode" runat="server" MaxLength="6" ReadOnly="True" Enabled="False"></asp:TextBox>
																					<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="&amp;lt;Prefix is needed"
																						EnableClientScript="False" ControlToValidate="txtPrefixCode" Display="Dynamic"></asp:RequiredFieldValidator></td>
																			</tr>
																			<TR>
																				<TD align="right">Formatting :</TD>
																				<TD>
																					<asp:TextBox id="txtFormatString" runat="server" MaxLength="5" ReadOnly="True" Enabled="False">00000</asp:TextBox>
																					<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ErrorMessage="&amp;lt; Formatting string is required"
																						EnableClientScript="False" ControlToValidate="txtFormatString" Display="Dynamic"></asp:RequiredFieldValidator><BR>
																					<FONT size="1">(ex: '0000' for '3' will produce '0003')</FONT></TD>
																			</TR>
																			<tr>
																				<td align="right">Set Start Range :
																				</td>
																				<td>
																					<asp:TextBox id="txtStartRange" runat="server">1</asp:TextBox></td>
																			</tr>
																			<tr>
																				<td align="right">Set End Range&nbsp; :
																				</td>
																				<td>
																					<asp:TextBox id="txtEndRange" runat="server">1</asp:TextBox></td>
																			</tr>
																			<tr>
																				<td align="right">&nbsp;</td>
																				<td>&nbsp;</td>
																			</tr>
																		</table>
																	</td>
																</tr>
																<tr>
																	<td align="center">
																		<asp:Button id="butCreateAndAssign" runat="server" Text="Create and Assign"></asp:Button></td>
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
