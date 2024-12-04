<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Login.ascx.vb" Inherits="Trade.Login" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<HEAD>
</HEAD>
<style>
DIV.Section1 { page: Section1 }
LI.MsoNormal { FONT-SIZE: 12pt; MARGIN: 0cm 0cm 0pt; FONT-FAMILY: "Verdana" }
</style>
<div align="center">
	<TABLE id="tblmainLogin" cellSpacing="1" cellPadding="1" border="0" runat="server" class="normaltext">
		<TR>
			<TD align="center" vAlign="top" height="200">
				<table border="0" width="606" id="table13" cellspacing="0" cellpadding="0">
					<tr>
						<td width="606">
							<p align="center">
							<IFRAME style="WIDTH: 470px; HEIGHT: 60px" name="IfAdv" align="middle" src="HTMLPages/Ad_MembersLogin.htm"
				frameBorder="0" scrolling="no"></IFRAME></td>
					</tr>
					<tr>
						<td width="606">
							&nbsp;</td>
					</tr>
					<tr>
						<td width="606">
							<div align="center">
								<table border="0" width="580" id="table135" cellspacing="0" cellpadding="0">
									<tr>
										<td valign="top" width="287">
											<div align="center">
												<TABLE id="table136" style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid; BACKGROUND-REPEAT: repeat-x"
													cellSpacing="0" cellPadding="0" width="100%" background="../images/bg_cell.gif" border="0"
													height="150">
													<TR>
														<TD height="3" valign="top">
															<table border="0" width="100%" id="table137" cellpadding="2">
																<tr>
																	<td bgcolor="#cf8e40" class="boxhdn">
																		Login Now</td>
																</tr>
																<tr>
																	<td valign="top">
																		<div align="center">
																			<TABLE id="table138" cellSpacing="1" border="0" class="normaltext" width="100%">
																				<TR>
																					<TD align="center" colSpan="2" id="TDLoginHeader" valign="bottom">&nbsp;</TD>
																				</TR>
																				<TR>
																					<TD align="center" colSpan="2" id="TDLoginHeader" valign="bottom"><STRONG>
																							<asp:Label id="lblloginHeader" runat="server">This area is only for registered members.</asp:Label></STRONG></TD>
																				</TR>
																				<TR>
																					<TD>
																						<asp:Label id="lblusername" runat="server" CssClass="normaltext">User Name</asp:Label></TD>
																					<TD>
																						<asp:TextBox id="tbUserName" runat="server" MaxLength="50" class="box"></asp:TextBox>
																						<asp:RequiredFieldValidator id="RqFVUsername" runat="server" ErrorMessage="*" ControlToValidate="tbUserName"></asp:RequiredFieldValidator></TD>
																				</TR>
																				<TR>
																					<TD>
																						<asp:Label id="lblPassword" runat="server" CssClass="normaltext">Password</asp:Label></TD>
																					<TD>
																						<asp:TextBox id="tbPassword" runat="server" MaxLength="50" TextMode="Password" class="box"></asp:TextBox>
																						<asp:RequiredFieldValidator id="RqFVUserpwd" runat="server" ErrorMessage="*" ControlToValidate="tbPassword"></asp:RequiredFieldValidator></TD>
																				</TR>
																				<TR>
																					<TD align="center" colSpan="2">
																						<asp:CheckBox id="chkAdmin" runat="server" Text="Admin Login" Width="117px" Font-Bold="True" Visible="False"></asp:CheckBox></TD>
																				</TR>
																				<TR>
																					<TD align="center" colSpan="2">
																						&nbsp;<asp:Button id="cmdLogin" runat="server" Text="Login" Width="67px"></asp:Button>&nbsp;&nbsp;
																					</TD>
																				</TR>
																			</TABLE>
																		</div>
																	</td>
																</tr>
															</table>
														</TD>
													</TR>
												</TABLE>
											</div>
										</td>
										<td width="6"></td>
										<td valign="top" width="287">
											<div align="center">
												<TABLE id="table139" style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid; BACKGROUND-REPEAT: repeat-x"
													cellSpacing="0" cellPadding="0" width="100%" background="../images/bg_cell.gif" border="0"
													height="150">
													<TR>
														<TD height="3" valign="top">
															<table border="0" width="100%" id="table140" cellpadding="2">
																<tr>
																	<td bgcolor="#cf8e40" class="boxhdn">
																		New User? Register Now</td>
																</tr>
																<tr>
																	<td valign="top" class="normaltext">
																		<div align="center">
																			<TABLE cellSpacing="1" border="0" class="normaltext" width="100%">
																				<TR>
																					<TD align="center" valign="bottom">&nbsp;</TD>
																				</TR>
																				<TR>
																					<TD align="center" valign="bottom">
																						<p align="left">Register now to enjoy <b>Premium Membership</b> benefits and get 
																							Unlimited Access to:</FONT></p>
																					</TD>
																				</TR>
																				<TR>
																					<TD align="center" valign="bottom">
																						<p align="left">
																							<font color="#000000"><img border="0" src="../images/bullet.gif" width="11" height="11">&nbsp; 
																								Post your stocks on Trading Floor.</font></p>
																					</TD>
																				</TR>
																				<TR>
																					<TD align="center" valign="bottom">
																						<p align="left"><font color="#000000"> <img border="0" src="../images/bullet.gif" width="11" height="11">&nbsp; 
																								Unlimited Access! to Traders Directory.</font></p>
																					</TD>
																				</TR>
																				<TR>
																					<TD align="center" valign="bottom">
																						<p align="center">
																							<b><a href="PortalDefault.aspx?Main_Links_ID=25"><u><font color="#f7342d">Register Now</font></u></a></b></p>
																					</TD>
																				</TR>
																			</TABLE>
																		</div>
																	</td>
																</tr>
															</table>
														</TD>
													</TR>
												</TABLE>
											</div>
										</td>
									</tr>
								</table>
							</div>
						</td>
					</tr>
				</table>
			</TD>
		</TR>
		<TR>
			<TD align="center" style="FONT-SIZE: 10pt; FONT-FAMILY: Arial; HEIGHT: 23px">
				&nbsp;</TD>
		</TR>
	</TABLE>
</div>
<DIV align="center">
	<TABLE id="tblWelcome" cellSpacing="1" border="0" class="normaltext" width="606" runat="server">
		<TR>
			<TD>
				<p align="center">
					<asp:Label id="lblUser" runat="server" class="Memhdn" Height="20px">.</asp:Label>&nbsp;</p>
			</TD>
		</TR>
		<TR>
			<TD>
				<div align="center">
					<TABLE id="table105" style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid; BACKGROUND-REPEAT: repeat-x"
						cellSpacing="0" cellPadding="0" width="420" background="../images/bg_cell.gif" border="0"
						height="100">
						<TR>
							<TD height="3" valign="top">
								<table border="0" width="100%" id="table107" cellspacing="4" cellpadding="4">
									<tr>
										<td>
											<table border="0" width="197" id="table108" cellspacing="0" cellpadding="0">
												<tr>
													<td>
														<a href="../PortalDefault.aspx?Main_Links_ID=6&amp;sub_Links_ID=1"><img border="0" src="../images/btn_mem_postoffer.gif" width="197" height="23"></a></td>
												</tr>
												<tr>
													<td class="normaltext">Post your BUY or SELL stock&nbsp; requests.</td>
												</tr>
											</table>
										</td>
										<td valign="top">
											<table border="0" width="197" id="table109" cellspacing="0" cellpadding="0">
												<tr>
													<td>
														<a href="../PortalDefault.aspx?Main_Links_ID=6&amp;sub_Links_ID=2"><img border="0" src="../images/btn_mem_editpost.gif" width="197" height="23"></a></td>
												</tr>
												<tr>
													<td class="normaltext">Edit or View your BUY/SELL requests.</td>
												</tr>
											</table>
										</td>
									</tr>
									<tr>
										<td valign="top">
											<table border="0" width="197" id="table110" cellspacing="0" cellpadding="0">
												<tr>
													<td>
														<a href="../PortalDefault.aspx?Main_Links_ID=6&amp;sub_Links_ID=4"><img border="0" src="../images/btn_mem_editcontact.gif" width="197" height="23"></a></td>
												</tr>
												<tr>
													<td class="normaltext">Edit your Company Info. and Contact details.</td>
												</tr>
											</table>
										</td>
										<td valign="top">
											<table border="0" width="197" id="table111" cellspacing="0" cellpadding="0">
												<tr>
													<td>
														<a href="../PortalDefault.aspx?Main_Links_ID=6&amp;sub_Links_ID=5"><img border="0" src="../images/btn_mem_editprofile.gif" width="197" height="23"></a></td>
												</tr>
												<tr>
													<td class="normaltext">Edit your Company Profile.</td>
												</tr>
											</table>
										</td>
									</tr>
									<tr>
										<td valign="top">
											<table border="0" width="197" id="table112" cellspacing="0" cellpadding="0">
												<tr>
													<td>
														<a href="../PortalDefault.aspx?Main_Links_ID=6&amp;sub_Links_ID=6"><img border="0" src="../images/btn_mem_password.gif" width="197" height="23"></a></td>
												</tr>
												<tr>
													<td class="normaltext">
														Change your Password<br>
														&nbsp;</td>
												</tr>
											</table>
										</td>
										<td valign="top">
											<table border="0" width="197" id="table113" cellspacing="0" cellpadding="0">
												<tr>
													<td>
														<a href="../PortalDefault.aspx?Main_Links_ID=6&amp;sub_Links_ID=10"><img border="0" src="../images/btn_mem_logout.gif" width="197" height="23"></a></td>
												</tr>
												<tr>
													<td class="normaltext">
														Always Logout your account.
														<br>
														&nbsp;</td>
												</tr>
											</table>
										</td>
									</tr>
								</table>
							</TD>
						</TR>
					</TABLE>
				</div>
			</TD>
		</TR>
	</TABLE>
</DIV>
<p>&nbsp;</p>
