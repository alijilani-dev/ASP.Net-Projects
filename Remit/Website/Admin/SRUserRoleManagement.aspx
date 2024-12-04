<%@ Page language="c#" Codebehind="SRUserRoleManagement.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.SRUserRoleManagement" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
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
																&nbsp;SR User Role Management <!-- InstanceEndEditable --></font></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
													<tr>
														<td align="center" valign="top"><!-- InstanceBeginEditable name="MainContent" -->
															<table width="100%" border="1" cellpadding="0" cellspacing="0" bordercolor="#ff6600">
																<tr>
																	<td>
																		<asp:Label id="lblMessage" runat="server"></asp:Label></td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td>
																		<asp:DataGrid id="dgrdSRUserList" runat="server" AutoGenerateColumns="False" Width="100%">
																			<HeaderStyle Font-Bold="True" HorizontalAlign="Center"></HeaderStyle>
																			<Columns>
																				<asp:BoundColumn DataField="LoginName" HeaderText="Login Name"></asp:BoundColumn>
																				<asp:HyperLinkColumn Text="Set Roles" DataNavigateUrlField="Id" DataNavigateUrlFormatString="SRUserRoleManagement.aspx?Id={0}&amp;Mode=Edit">
																					<ItemStyle HorizontalAlign="Center"></ItemStyle>
																				</asp:HyperLinkColumn>
																			</Columns>
																		</asp:DataGrid></td>
																</tr>
																<tr>
																	<td>
																		<asp:Panel id="pnlRoleAssigner" runat="server" Visible="False">
																			<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="0">
																				<TR>
																					<TD></TD>
																				</TR>
																				<TR>
																					<TD>Currently Selected User: <STRONG>
																							<asp:Label id="lblSeletedUser" runat="server"></asp:Label></STRONG></TD>
																				</TR>
																				<TR>
																					<TD align="center">
																						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="450" border="0">
																							<TR>
																								<TD style="HEIGHT: 14px" align="center" width="200"><STRONG>Assigned Roles</STRONG></TD>
																								<TD style="HEIGHT: 14px"></TD>
																								<TD style="HEIGHT: 14px" align="center" width="200"><STRONG>Available Roles</STRONG></TD>
																							</TR>
																							<TR>
																								<TD align="center">
																									<asp:ListBox id="lbxAssignedRoles" runat="server" Rows="15" DataValueField="Value" DataTextField="Name"></asp:ListBox></TD>
																								<TD vAlign="middle">
																									<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
																										<TR>
																											<TD align="center">
																												<asp:Button id="butAdd" runat="server" Width="80px" BorderWidth="1px" BorderStyle="Solid" BorderColor="Black"
																													Text="<<Add" Font-Bold="True"></asp:Button></TD>
																										</TR>
																										<TR>
																											<TD align="center"></TD>
																										</TR>
																										<TR>
																											<TD align="center">
																												<asp:Button id="butRemove" runat="server" Width="80px" BorderWidth="1px" BorderStyle="Solid"
																													BorderColor="Black" Text="Remove>>" Font-Bold="True"></asp:Button></TD>
																										</TR>
																									</TABLE>
																								</TD>
																								<TD align="center">
																									<asp:ListBox id="lbxAvailableRoles" runat="server" Rows="15" DataValueField="Value" DataTextField="Name"></asp:ListBox></TD>
																							</TR>
																							<TR>
																								<TD></TD>
																								<TD></TD>
																								<TD></TD>
																							</TR>
																						</TABLE>
																					</TD>
																				</TR>
																			</TABLE>
																		</asp:Panel></td>
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
