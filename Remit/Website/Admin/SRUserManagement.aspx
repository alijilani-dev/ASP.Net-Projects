<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Page language="c#" Codebehind="SRUserManagement.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.SRUserManagement" %>
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
																&nbsp;SR User Management <!-- InstanceEndEditable --></font></td>
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
																	<td>
																		<asp:DataGrid id="dgrdSREmployees" runat="server" Width="100%" AutoGenerateColumns="False" DataKeyField="Id"
																			EnableViewState="False">
																			<HeaderStyle Font-Bold="True" HorizontalAlign="Center"></HeaderStyle>
																			<Columns>
																				<asp:TemplateColumn HeaderText="Login Name">
																					<ItemTemplate>
																						<asp:Label id=Label1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.LoginName") %>'>
																						</asp:Label>
																					</ItemTemplate>
																					<EditItemTemplate>
																						<asp:TextBox id=txtEditLoginName runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.LoginName") %>'>
																						</asp:TextBox>
																					</EditItemTemplate>
																				</asp:TemplateColumn>
																				<asp:TemplateColumn>
																					<EditItemTemplate>
																						<asp:TextBox id=txtLoginPassword runat="server" TextMode="Password" Text='<%# DataBinder.Eval(Container, "DataItem.LoginPassword") %>'>
																						</asp:TextBox>
																					</EditItemTemplate>
																				</asp:TemplateColumn>
																				<asp:TemplateColumn HeaderText="Email Id">
																					<ItemTemplate>
																						<asp:Label id=Label2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Email") %>'>
																						</asp:Label>
																					</ItemTemplate>
																					<EditItemTemplate>
																						<asp:TextBox id=txtEditEmail runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Email") %>'>
																						</asp:TextBox>
																					</EditItemTemplate>
																				</asp:TemplateColumn>
																				<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" CancelText="Cancel" EditText="Edit"></asp:EditCommandColumn>
																				<asp:TemplateColumn>
																					<ItemTemplate>
																						<asp:LinkButton id=LinkButton1 runat="server" Text="Delete" CausesValidation="False" CommandName="Delete" Visible='<%# DataBinder.Eval(Container, "DataItem.CanBeEdited").ToString()=="True"?true:false %>'>Delete</asp:LinkButton>
																					</ItemTemplate>
																				</asp:TemplateColumn>
																			</Columns>
																		</asp:DataGrid></td>
																</tr>
																<TR>
																	<TD>&nbsp;</TD>
																</TR>
																<TR>
																	<TD align="center"><table width="450" border="0" cellspacing="0" cellpadding="0">
																			<tr>
																				<td><STRONG>Create New User </STRONG>
																				</td>
																			</tr>
																			<tr>
																				<td>&nbsp;</td>
																			</tr>
																			<tr>
																				<td><table width="100%" border="0" cellspacing="0" cellpadding="0">
																						<tr>
																							<td width="150" align="right">Login Name :
																							</td>
																							<td>
																								<asp:TextBox id="txtLoginName" runat="server"></asp:TextBox></td>
																						</tr>
																						<tr>
																							<td align="right">Password :
																							</td>
																							<td>
																								<asp:TextBox id="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
																						</tr>
																						<tr>
																							<td align="right">Email Id :
																							</td>
																							<td>
																								<asp:TextBox id="txtEmailId" runat="server"></asp:TextBox></td>
																						</tr>
																					</table>
																				</td>
																			</tr>
																			<tr>
																				<td align="center">
																					<asp:Button id="butCreate" runat="server" Text="Create User"></asp:Button></td>
																			</tr>
																		</table>
																	</TD>
																</TR>
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
