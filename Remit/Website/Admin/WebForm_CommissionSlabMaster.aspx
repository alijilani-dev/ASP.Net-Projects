<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebForm_CommissionSlabMaster.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebForm_CommissionSlabMaster" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: Commission Slab Management</title><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
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
																Commission Slab Management <!-- InstanceEndEditable --></font></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
													<tr>
														<td align="center" valign="top"><!-- InstanceBeginEditable name="MainContent" -->
															<asp:Panel ID="ErrorDisplay" runat="server" Visible="false">
																<asp:Label id="lab_Error" runat="server" CssClass="ErrorDisplayStyle"></asp:Label>
															</asp:Panel>
															<asp:HyperLink ID="ReturnURL" runat="server" CssClass="EditHyperLink" EnableViewState="true" Visible="false"
																NavigateUrl="" Text="Return"></asp:HyperLink>
															<asp:Panel ID="MainDisplay" runat="server">
																<TABLE cellSpacing="10" cellPadding="5" border="0">
																	<TR>
																		<TD class="MandatoryLabelStyle" align="right">PayInCountry
																		</TD>
																		<TD>
																			<DropDownLists:WebDropDownList_CountryList id="com_PayInCountryId" tabIndex="1" runat="server" CssClass="MandatoryComboBoxStyle"></DropDownLists:WebDropDownList_CountryList></TD>
																	</TR>
																	<TR>
																		<TD class="MandatoryLabelStyle" align="right">PayOutCountry
																		</TD>
																		<TD>
																			<DropDownLists:WebDropDownList_CountryList id="com_PayOutCountryId" tabIndex="2" runat="server" CssClass="MandatoryComboBoxStyle"></DropDownLists:WebDropDownList_CountryList></TD>
																	</TR>
																	<TR>
																		<TD class="MandatoryLabelStyle" align="right">ModeOfPayment
																		</TD>
																		<TD>
																			<DropDownLists:WebDropDownList_PaymentModeList id="com_ModeOfPayment" tabIndex="3" runat="server" CssClass="MandatoryComboBoxStyle"></DropDownLists:WebDropDownList_PaymentModeList></TD>
																	</TR>
																	<TR>
																		<TD class="MandatoryLabelStyle" align="right">StartRange
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_StartRange" tabIndex="4" runat="server" CssClass="MandatoryTextBoxStyle"></asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_StartRange" runat="Server" Visible="False" CssClass="ErrorStyle" EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD class="MandatoryLabelStyle" align="right">EndRange
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_EndRange" tabIndex="5" runat="server" CssClass="MandatoryTextBoxStyle"></asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_EndRange" runat="Server" Visible="False" CssClass="ErrorStyle" EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD class="MandatoryLabelStyle" align="right">BaseToBaseCommissionAmount
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_BaseToBaseCommissionAmount" tabIndex="6" runat="server" CssClass="MandatoryTextBoxStyle"></asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_BaseToBaseCommissionAmount" runat="Server" Visible="False" CssClass="ErrorStyle"
																				EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD class="MandatoryLabelStyle" align="right">BaseToUSDCommissionAmount
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_BaseToUSDCommissionAmount" tabIndex="7" runat="server" CssClass="MandatoryTextBoxStyle"></asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_BaseToUSDCommissionAmount" runat="Server" Visible="False" CssClass="ErrorStyle"
																				EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD class="MandatoryLabelStyle" align="right">PayInCommissionType
																		</TD>
																		<TD>
																			<DropDownLists:WebDropDownList_CommissionSplitTypeList id="com_PayInCommissionType" tabIndex="8" runat="server" CssClass="MandatoryComboBoxStyle"></DropDownLists:WebDropDownList_CommissionSplitTypeList></TD>
																	</TR>
																	<TR>
																		<TD class="MandatoryLabelStyle" align="right">PayInCommissionAmount
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_PayInCommissionAmount" tabIndex="9" runat="server" CssClass="MandatoryTextBoxStyle"></asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_PayInCommissionAmount" runat="Server" Visible="False" CssClass="ErrorStyle"
																				EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																		<TD class="MandatoryLabelStyle" align="right">PayOutCommissionType
																		</TD>
																		<TD>
																			<DropDownLists:WebDropDownList_CommissionSplitTypeList id="com_PayOutCommissionType" tabIndex="10" runat="server" CssClass="MandatoryComboBoxStyle"></DropDownLists:WebDropDownList_CommissionSplitTypeList></TD>
																	</TR>
																	<TR>
																		<TD class="MandatoryLabelStyle" align="right">PayOutCurrencyType
																		</TD>
																		<TD>
																			<DropDownLists:WebDropDownList_CommissionCurrencyType id="com_PayOutCurrencyType" tabIndex="11" runat="server" CssClass="MandatoryComboBoxStyle"></DropDownLists:WebDropDownList_CommissionCurrencyType></TD>
																	</TR>
																	<TR>
																		<TD class="MandatoryLabelStyle" align="right">PayOutCommissionAmount
																		</TD>
																		<TD>
																			<asp:TextBox id="txt_PayOutCommissionAmount" tabIndex="12" runat="server" CssClass="MandatoryTextBoxStyle"></asp:TextBox></TD>
																		<TD>
																			<asp:Label id="labError_PayOutCommissionAmount" runat="Server" Visible="False" CssClass="ErrorStyle"
																				EnableViewState="False"></asp:Label></TD>
																	</TR>
																	<TR>
																	</TR>
																	<TR>
																		<TD></TD>
																		<TD align="center">
																			<TABLE cellSpacing="10" cellPadding="5" border="0">
																				<TR align="center">
																					<TD>
																						<asp:Button id="cmdRefresh" tabIndex="13" runat="server" CssClass="ButtonStyle" Text="Refresh"></asp:Button></TD>
																					<TD>
																						<asp:Button id="cmdDelete" tabIndex="14" runat="server" CssClass="ButtonStyle" Text="Delete"></asp:Button></TD>
																					<TD>
																						<asp:Button id="cmdUpdate" tabIndex="15" runat="server" CssClass="ButtonStyle" Text="Update"></asp:Button></TD>
																				</TR>
																			</TABLE>
																		</TD>
																	</TR>
																</TABLE>
															</asp:Panel>
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
