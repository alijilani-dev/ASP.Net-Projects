<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebForm_AgentLocationList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebForm_AgentLocationList" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: Agent Management</title><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
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
																&nbsp;Agent Management <!-- InstanceEndEditable --></font></td>
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
																		<TD class="MandatoryLabelStyle" align="right">Code
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_Code" tabIndex="2" runat="server" CssClass="MandatoryTextBoxStyle"></asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_Code" runat="Server" CssClass="ErrorStyle" Visible="False" EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD class="MandatoryLabelStyle" align="right">AgentAccount
																		</TD>
																		<TD>
																			<DropDownLists:WebDropDownList_AgentMaster id="com_AgentAccountId" tabIndex="3" runat="server" CssClass="MandatoryComboBoxStyle"></DropDownLists:WebDropDownList_AgentMaster></TD>
																	</TR>
																	<TR>
																		<TD class="OptionalLabelStyle" align="right">AgentGroup
																		</TD>
																		<TD>
																			<DropDownLists:WebDropDownList_AgentGroupList id="com_AgentGroupId" tabIndex="4" runat="server" CssClass="OptionalComboBoxStyle"></DropDownLists:WebDropDownList_AgentGroupList></TD>
																	</TR>
																	<TR>
																		<TD class="MandatoryLabelStyle" align="right">CreditLimitInUSD
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_CreditLimitInUSD" tabIndex="5" runat="server" CssClass="MandatoryTextBoxStyle"
																				Enabled="False">-1</asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_CreditLimitInUSD" runat="Server" CssClass="ErrorStyle" Visible="False"
																				EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD class="MandatoryLabelStyle" align="right">IndividualTransactionLimit
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_IndividualTransactionLimit" tabIndex="6" runat="server" CssClass="MandatoryTextBoxStyle"
																				Enabled="False">-1</asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_IndividualTransactionLimit" runat="Server" CssClass="ErrorStyle" Visible="False"
																				EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD class="MandatoryLabelStyle" align="right">AllowedDomesticTransactionType
																		</TD>
																		<TD>
																			<DropDownLists:WebDropDownList_TransactionTypeList id="com_AllowedDomesticTransactionType" tabIndex="7" runat="server" CssClass="MandatoryComboBoxStyle"></DropDownLists:WebDropDownList_TransactionTypeList></TD>
																	</TR>
																	<TR>
																		<TD class="MandatoryLabelStyle" align="right">AllowedInternationalTransactionType
																		</TD>
																		<TD>
																			<DropDownLists:WebDropDownList_TransactionTypeList id="com_AllowedInternationalTransactionType" tabIndex="8" runat="server" CssClass="MandatoryComboBoxStyle"></DropDownLists:WebDropDownList_TransactionTypeList></TD>
																	</TR>
																	<TR>
																		<TD class="MandatoryLabelStyle" align="right">ListOnWebFor
																		</TD>
																		<TD>
																			<DropDownLists:WebDropDownList_TransactionTypeList id="com_ListOnWebFor" tabIndex="9" runat="server" CssClass="MandatoryComboBoxStyle"></DropDownLists:WebDropDownList_TransactionTypeList></TD>
																	</TR>
																	<TR>
																		<TD class="OptionalLabelStyle" align="right">Address
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_Address" tabIndex="10" runat="server" CssClass="OptionalTextBoxStyle"></asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_Address" runat="Server" CssClass="ErrorStyle" Visible="False" EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD class="OptionalLabelStyle" align="right">Telephone
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_Telephone" tabIndex="11" runat="server" CssClass="OptionalTextBoxStyle"></asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_Telephone" runat="Server" CssClass="ErrorStyle" Visible="False" EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD class="OptionalLabelStyle" align="right">Fax
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_Fax" tabIndex="12" runat="server" CssClass="OptionalTextBoxStyle"></asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_Fax" runat="Server" CssClass="ErrorStyle" Visible="False" EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD class="OptionalLabelStyle" align="right">Email
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_Email" tabIndex="13" runat="server" CssClass="OptionalTextBoxStyle"></asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_Email" runat="Server" CssClass="ErrorStyle" Visible="False" EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD class="OptionalLabelStyle" align="right">Location
																		</TD>
																		<TD>
																			<DropDownLists:WebDropDownList_LocationList id="com_LocationId" tabIndex="14" runat="server" CssClass="OptionalComboBoxStyle"></DropDownLists:WebDropDownList_LocationList></TD>
																	</TR>
																	<TR>
																		<TD class="OptionalLabelStyle" align="right">ContactPerson
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_ContactPerson" tabIndex="15" runat="server" CssClass="OptionalTextBoxStyle"></asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_ContactPerson" runat="Server" CssClass="ErrorStyle" Visible="False"
																				EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD></TD>
																		<TD>
																			<asp:CheckBox id="chk_Active" tabIndex="16" runat="server" CssClass="MandatoryCheckBoxStyle" Text="Active"></asp:CheckBox></TD>
																	</TR>
																	<TR>
																	</TR>
																	<TR>
																		<TD></TD>
																		<TD align="center">
																			<TABLE cellSpacing="10" cellPadding="5" border="0">
																				<TR align="center">
																					<TD>
																						<asp:Button id="cmdRefresh" tabIndex="17" runat="server" CssClass="ButtonStyle" Text="Refresh"></asp:Button></TD>
																					<TD>
																						<asp:Button id="cmdDelete" tabIndex="18" runat="server" CssClass="ButtonStyle" Text="Delete"></asp:Button></TD>
																					<TD>
																						<asp:Button id="cmdUpdate" tabIndex="19" runat="server" CssClass="ButtonStyle" Text="Update"></asp:Button></TD>
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
											<td height="46" valign="top" style="COLOR:#ffffff"><uc1:StatusInfo id="StatusInfo1" runat="server"></uc1:StatusInfo></UC1:STATUSINFO></td>
										</tr>
										<tr>
											<td valign="top"><uc1:Menu2 id="Menu2" runat="server"></uc1:Menu2></UC1:MENU2></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td height="45"><uc1:Menu1 id="Menu11" runat="server"></uc1:Menu1></UC1:MENU1></td>
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
