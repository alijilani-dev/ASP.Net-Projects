<%@ Page language="c#" Codebehind="WebForm_AgentMaster.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebForm_AgentMaster" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: Agent Account Master</title><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
		<!-- InstanceBeginEditable name="doctitle" -->
		<!-- InstanceEndEditable -->
		<!-- InstanceBeginEditable name="head" -->
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link href="StyleSheet.css" type="text/css" rel="stylesheet">
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
																&nbsp;Agent Account Master <!-- InstanceEndEditable --></font></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
													<tr>
														<td align="center" valign="top"><!-- InstanceBeginEditable name="MainContent" -->
															<asp:panel id="ErrorDisplay" runat="server" visible="false">
																<asp:Label id="lab_Error" runat="server" CssClass="ErrorDisplayStyle"></asp:Label>
															</asp:panel>
															<asp:HyperLink id="ReturnURL" runat="server" CssClass="EditHyperLink" EnableViewState="true" Visible="false"
																NavigateUrl="" Text="Return"></asp:HyperLink>
															<asp:panel id="MainDisplay" runat="server">
																<TABLE cellSpacing="10" cellPadding="5" border="0">
																	<TR>
																		<TD class="MandatoryLabelStyle" align="right">Name
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_Name" tabIndex="1" runat="server" CssClass="MandatoryTextBoxStyle"></asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_Name" runat="Server" CssClass="ErrorStyle" Visible="False" EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD class="OptionalLabelStyle" align="right">Number
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_Number" tabIndex="2" runat="server" CssClass="OptionalTextBoxStyle"></asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_Number" runat="Server" CssClass="ErrorStyle" Visible="False" EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD class="OptionalLabelStyle" align="right">CreditLimitIn USD
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_CreditLimitInUSD" tabIndex="3" runat="server" CssClass="OptionalTextBoxStyle"></asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_CreditLimitInUSD" runat="Server" CssClass="ErrorStyle" Visible="False"
																				EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD class="OptionalLabelStyle" align="right">PayInThreshold (FC)
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_PayInThreshold" tabIndex="4" runat="server" CssClass="OptionalTextBoxStyle"></asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_PayInThreshold" runat="Server" CssClass="ErrorStyle" Visible="False"
																				EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD class="OptionalLabelStyle" align="right">BankSwiftCode
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_BankSwiftCode" tabIndex="5" runat="server" CssClass="OptionalTextBoxStyle"></asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_BankSwiftCode" runat="Server" CssClass="ErrorStyle" Visible="False"
																				EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD class="OptionalLabelStyle" align="right">DraftStatusUrl
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_DraftStatusUrl" tabIndex="6" runat="server" CssClass="OptionalTextBoxStyle"></asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_DraftStatusUrl" runat="Server" CssClass="ErrorStyle" Visible="False"
																				EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD class="OptionalLabelStyle" align="right">DraftStatusVariable
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_DraftStatusVariable" tabIndex="7" runat="server" CssClass="OptionalTextBoxStyle"></asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_DraftStatusVariable" runat="Server" CssClass="ErrorStyle" Visible="False"
																				EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD class="OptionalLabelStyle" align="right">Country
																		</TD>
																		<TD>
																			<DropDownLists:WebDropDownList_CountryList id="com_CountryId" tabIndex="8" runat="server" CssClass="OptionalComboBoxStyle"></DropDownLists:WebDropDownList_CountryList></TD>
																	</TR>
																	<TR>
																		<TD></TD>
																		<TD>
																			<asp:CheckBox id="chk_Active" tabIndex="9" runat="server" CssClass="MandatoryCheckBoxStyle" Text="Active"></asp:CheckBox></TD>
																	</TR>
																	<TR>
																	</TR>
																	<TR>
																		<TD></TD>
																		<TD align="center">
																			<TABLE cellSpacing="10" cellPadding="5" border="0">
																				<TR align="center">
																					<TD>
																						<asp:Button id="cmdRefresh" tabIndex="10" runat="server" CssClass="ButtonStyle" Text="Refresh"></asp:Button></TD>
																					<TD>
																						<asp:Button id="cmdDelete" tabIndex="11" runat="server" CssClass="ButtonStyle" Text="Delete"></asp:Button></TD>
																					<TD>
																						<asp:Button id="cmdUpdate" tabIndex="12" runat="server" CssClass="ButtonStyle" Text="Update"></asp:Button></TD>
																				</TR>
																			</TABLE>
																		</TD>
																	</TR>
																</TABLE>
															</asp:panel>
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
