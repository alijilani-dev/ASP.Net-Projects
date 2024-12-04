<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Page language="c#" Codebehind="WebForm_GBPBankExchangeRateList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebForm_GBPBankExchangeRateList" %>
<%@ OutputCache Duration="1" VaryByParam="*" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: </title><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
		<!-- InstanceBeginEditable name="doctitle" -->
		<!-- InstanceEndEditable -->
		<!-- InstanceBeginEditable name="head" -->
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="StyleSheet.css" type="text/css" rel="stylesheet">
		<!-- InstanceEndEditable --><LINK href="/css/InnerPage.css" type="text/css" rel="stylesheet"><LINK href="/Admin/StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body leftMargin="0" topMargin="0">
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
											<td>
												<table cellSpacing="0" cellPadding="0" width="100%" border="0">
													<tr>
														<td align="center"><font face="Arial, Helvetica, sans-serif" size="4"><!-- InstanceBeginEditable name="Heading" -->
																&nbsp;GBP Bank Exchange Rate Management <!-- InstanceEndEditable --></font></td>
													</tr>
												</table>
											</td>
										</tr>
										<TR>
											<TD>
												<P align="center"><asp:label id="lab_Error" runat="server" CssClass="ErrorDisplayStyle"></asp:label></P>
											</TD>
										</TR>
										<TR>
											<TD>
												<P align="center"><asp:hyperlink id="ReturnURL" runat="server" CssClass="EditHyperLink" Text="Return" Visible="false"
														EnableViewState="true" NavigateUrl=""></asp:hyperlink></P>
											</TD>
										</TR>
										<tr>
											<td vAlign="top">
												<table cellSpacing="0" cellPadding="0" width="100%" border="0">
													<tr>
														<td vAlign="top" align="center"><!-- InstanceBeginEditable name="MainContent" -->
															<TABLE id="Table1" cellSpacing="10" cellPadding="5" border="0">
																<TR>
																	<TD class="MandatoryLabelStyle" align="right">Currency
																	</TD>
																	<TD><asp:label id="lblCurrency" runat="server" Width="296px"></asp:label></TD>
																</TR>
																<TR>
																	<TD class="MandatoryLabelStyle" align="right">ExchangeType
																	</TD>
																	<TD><DROPDOWNLISTS:WEBDROPDOWNLIST_CURRENCYEXCHANGETYPE id="com_ExchangeType" tabIndex="2" runat="server" CssClass="MandatoryComboBoxStyle"></DROPDOWNLISTS:WEBDROPDOWNLIST_CURRENCYEXCHANGETYPE></TD>
																</TR>
																<TR>
																	<TD class="OptionalLabelStyle" align="right">BidRate
																	</TD>
																	<TD><asp:textbox id="txt_BidRate" tabIndex="3" runat="server" CssClass="OptionalTextBoxStyle"></asp:textbox></TD>
																	<TD><asp:label id="labError_BidRate" runat="Server" CssClass="ErrorStyle" Visible="False" EnableViewState="False"></asp:label></TD>
																</TR>
																<TR>
																	<TD class="MandatoryLabelStyle" align="right">OfferRate
																	</TD>
																	<TD><asp:textbox id="txt_OfferRate" tabIndex="4" runat="server" CssClass="MandatoryTextBoxStyle"></asp:textbox></TD>
																	<TD><asp:label id="labError_OfferRate" runat="Server" CssClass="ErrorStyle" Visible="False" EnableViewState="False"></asp:label></TD>
																</TR>
																<TR>
																</TR>
																<TR>
																	<TD></TD>
																	<TD align="center">
																		<TABLE id="Table2" cellSpacing="10" cellPadding="5" border="0">
																			<TR align="center">
																				<TD><asp:button id="cmdRefresh" tabIndex="5" runat="server" CssClass="ButtonStyle" Text="Refresh"></asp:button></TD>
																				<TD></TD>
																				<TD><asp:button id="cmdUpdate" tabIndex="7" runat="server" CssClass="ButtonStyle" Text="Update"></asp:button></TD>
																			</TR>
																		</TABLE>
																	</TD>
																</TR>
															</TABLE>
															<!-- InstanceEndEditable --></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td vAlign="top">&nbsp;</td>
										</tr>
									</table>
								</td>
								<td vAlign="top" width="260">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0">
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
											<td style="COLOR: #ffffff" vAlign="top" height="46"><uc1:statusinfo id="StatusInfo1" runat="server"></uc1:statusinfo></td>
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
