<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Page language="c#" Codebehind="CreditToAccount.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.CreditToAccount" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: Credit To Account</title><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
		<!-- InstanceBeginEditable name="doctitle" -->
		<!-- InstanceEndEditable -->
		<!-- InstanceBeginEditable name="head" -->
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
																&nbsp;Credit To Account<!-- InstanceEndEditable --></font></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td vAlign="top">
												<table cellSpacing="0" cellPadding="0" width="100%" border="0">
													<TR>
														<TD vAlign="top" align="center">
															<asp:Label id="lblMessage" runat="server"></asp:Label></TD>
													</TR>
													<tr>
														<td vAlign="top" align="center"><!-- InstanceBeginEditable name="MainContent" -->
															&nbsp;
															<table cellSpacing="0" cellPadding="0" width="100%" border="0">
																<tr>
																	<td>
																		<table cellSpacing="0" cellPadding="0" width="100%" border="0">
																			<tr align="center">
																				<td noWrap align="center">Payment Type :
																				</td>
																				<td align="left"><asp:dropdownlist id="ddlPaymentType" runat="server" AutoPostBack="True">
																						<asp:ListItem Value="Credit">Credit to Agent Account</asp:ListItem>
																						<asp:ListItem Value="Debit">Debit to Agent Account</asp:ListItem>
																					</asp:dropdownlist></td>
																				<td align="center">&nbsp;</td>
																				<td align="center">&nbsp;</td>
																				<td align="center">&nbsp;</td>
																			</tr>
																			<tr align="center">
																				<td noWrap>&nbsp;</td>
																				<td>&nbsp;</td>
																				<td>&nbsp;</td>
																				<td>&nbsp;</td>
																				<td>&nbsp;</td>
																			</tr>
																			<tr align="center">
																				<td noWrap width="20%" height="14"><b>Select Account</b></td>
																				<td width="20%" height="14"><b>Amount (USD) </b>
																				</td>
																				<td width="20%" height="14"><b>Exchange Rate </b>
																				</td>
																				<td width="20%" height="14">&nbsp;</td>
																				<td width="20%" height="14"><b>FC (
																						<asp:label id="lblFC1" runat="server"></asp:label>) </b>
																				</td>
																			</tr>
																			<tr>
																				<td noWrap><asp:dropdownlist id="ddlAgentAccountList" runat="server" AutoPostBack="True" DataTextField="Name"
																						DataValueField="Id"></asp:dropdownlist></td>
																				<td><asp:textbox id="txtAmountUSD" runat="server" Columns="6">0.0</asp:textbox></td>
																				<td><asp:textbox id="txtAmountExchange" runat="server" Columns="6">0.0</asp:textbox></td>
																				<td><asp:button id="butCalculate" runat="server" Text="Calculate"></asp:button></td>
																				<td><asp:textbox id="txtTotalPaying" runat="server" Columns="6">0.0</asp:textbox></td>
																			</tr>
																		</table>
																	</td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td>
																		<table cellSpacing="0" cellPadding="0" width="100%" border="0">
																			<tr>
																				<td align="center" width="36%"><asp:listbox id="lbxAllUnPaidTransactions" runat="server" DataTextField="Display" DataValueField="Id"></asp:listbox></td>
																				<td>
																					<table cellSpacing="0" cellPadding="0" width="100%" border="0">
																						<tr>
																							<td align="center"><asp:button id="butSelect" runat="server" Text="Select >>" Width="120px"></asp:button></td>
																						</tr>
																						<tr>
																							<td align="center">&nbsp;</td>
																						</tr>
																						<tr>
																							<td align="center"><asp:button id="butRemove" runat="server" Text="<< Remove" Width="120px"></asp:button></td>
																						</tr>
																					</table>
																				</td>
																				<td align="center" width="36%"><asp:listbox id="lbxSelectedTransactions" runat="server"></asp:listbox></td>
																			</tr>
																			<tr>
																				<td>&nbsp;</td>
																				<td align="right">Total (
																					<asp:label id="lblFC2" runat="server"></asp:label>)&nbsp;:
																				</td>
																				<td><asp:label id="lblTotalTrans" runat="server">0.0</asp:label></td>
																			</tr>
																		</table>
																	</td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td>Cancelling Transactions:</td>
																</tr>
																<tr>
																	<td>
																		<table cellSpacing="0" cellPadding="0" width="100%" border="0">
																			<tr>
																				<td align="center" width="36%"><asp:listbox id="lbxAvailableCancellingTrans" runat="server" DataValueField="Id" DataTextField="Display"></asp:listbox></td>
																				<td>
																					<table cellSpacing="0" cellPadding="0" width="100%" border="0">
																						<tr>
																							<td align="center"><asp:button id="butSelectCancellingTrans" runat="server" Text="Select >>" Width="120px"></asp:button></td>
																						</tr>
																						<tr>
																							<td align="center">&nbsp;</td>
																						</tr>
																						<tr>
																							<td align="center"><asp:button id="butRemoveCancellingTrans" runat="server" Text="<< Remove" Width="120px"></asp:button></td>
																						</tr>
																					</table>
																				</td>
																				<td align="center" width="36%"><asp:listbox id="lbxSelectedCancellingTrans" runat="server"></asp:listbox></td>
																			</tr>
																			<TR>
																				<TD align="center" width="36%"></TD>
																				<TD align="right">Total :</TD>
																				<TD align="left" width="36%"><asp:label id="lblTotalCancellingAmount" runat="server">0.0</asp:label></TD>
																			</TR>
																		</table>
																	</td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td>Current On Account :&nbsp;
																		<asp:label id="lblCurrentOnAccount" runat="server">0.0</asp:label></td>
																</tr>
																<tr>
																	<td>&nbsp;
																		<asp:radiobutton id="rbutUseCurrentOnAccount" runat="server" Text="Use Current OnAccount" GroupName="CurrentOnAccount"></asp:radiobutton>&nbsp;&nbsp;
																		<asp:radiobutton id="rbutSaveCurrentOnAccount" runat="server" Text="Save Current OnAccount for Future Use"
																			GroupName="CurrentOnAccount" Checked="True"></asp:radiobutton></td>
																</tr>
																<tr>
																	<td height="14">Previous OnAccount Record:
																	</td>
																</tr>
																<TR>
																	<TD>&nbsp;</TD>
																</TR>
																<tr>
																	<td>
																		<table cellSpacing="0" cellPadding="0" width="100%" border="0">
																			<tr>
																				<td align="center" width="36%"><asp:listbox id="lbxOnAccountAvailable" runat="server"></asp:listbox></td>
																				<td>
																					<table cellSpacing="0" cellPadding="0" width="100%" border="0">
																						<tr>
																							<td align="center"><asp:button id="butSelectOnAccount" runat="server" Text="Select >>" Width="120px"></asp:button></td>
																						</tr>
																						<tr>
																							<td align="center">&nbsp;</td>
																						</tr>
																						<tr>
																							<td align="center"><asp:button id="butRemoveOnAccount" runat="server" Text="<< Remove" Width="120px"></asp:button></td>
																						</tr>
																					</table>
																				</td>
																				<td align="center" width="36%"><asp:listbox id="lbxOnAccountSelected" runat="server"></asp:listbox></td>
																			</tr>
																			<TR>
																				<TD align="center" width="36%"></TD>
																				<TD align="right">Total&nbsp; :</TD>
																				<TD align="left" width="36%"><asp:label id="lblTotalOnAccount" runat="server">0.0</asp:label></TD>
																			</TR>
																		</table>
																	</td>
																</tr>
																<tr>
																	<td>&nbsp;Total Dr/Cr :
																		<asp:label id="lblTotalAmount" runat="server">0.0</asp:label></td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td>Select Bank:
																		<asp:dropdownlist id="ddlBankList" runat="server" DataTextField="Name" DataValueField="Id"></asp:dropdownlist></td>
																</tr>
																<tr>
																	<td>
																		<table cellSpacing="0" cellPadding="0" width="100%" border="0">
																			<tr align="center">
																				<td width="33%"><b>FC</b></td>
																				<td width="33%"><b>Rate</b></td>
																				<TD width="33%"></TD>
																				<td width="33%"><b>USD</b></td>
																			</tr>
																			<tr align="center">
																				<td><asp:textbox id="txtFCAmount" runat="server" Columns="6">0.0</asp:textbox></td>
																				<td><asp:textbox id="txtExchangeRate" runat="server" Columns="6">0.0</asp:textbox></td>
																				<TD><asp:button id="butCalculate2" runat="server" Text="Calculate"></asp:button></TD>
																				<td><asp:textbox id="txtUSDAmount" runat="server" Columns="6">0.0</asp:textbox></td>
																			</tr>
																		</table>
																	</td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td><asp:button id="butFinalCalculate" runat="server" Text="Final Calculate"></asp:button></td>
																</tr>
																<tr>
																	<td>
																		<table cellSpacing="0" cellPadding="0" width="400" border="0">
																			<tr>
																				<td align="right" width="140">Transaction Amount :
																				</td>
																				<td><asp:label id="lblTransactionAmount" runat="server"></asp:label></td>
																			</tr>
																			<tr>
																				<td align="right" width="140">Paying Amount :
																				</td>
																				<td><asp:label id="lblPayingAmount" runat="server"></asp:label></td>
																			</tr>
																			<tr>
																				<td align="right" width="140">Cancelling Transaction Amount :
																				</td>
																				<td><asp:label id="lblCancellingTransactionAmount" runat="server"></asp:label></td>
																			</tr>
																			<tr>
																				<td align="right" width="140">OnAccount Balance :
																				</td>
																				<td><asp:label id="lblOnAccountBalanceAmount" runat="server"></asp:label></td>
																			</tr>
																			<tr>
																				<td align="right" width="140">&nbsp;</td>
																				<td>&nbsp;</td>
																			</tr>
																			<tr>
																				<td align="right">Total Credit :
																				</td>
																				<td><asp:label id="lblTotalCreditAmount" runat="server"></asp:label></td>
																			</tr>
																		</table>
																	</td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td><asp:button id="butCreditToAccount" runat="server" Text="Credit To Agent Account"></asp:button></td>
																</tr>
															</table>
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
											<td height="48"><IMG alt="" src="/images/layoutImages/Banner_SendMoney.jpg"></td>
										</tr>
										<tr>
											<td vAlign="top" height="46"><uc1:statusinfo id="StatusInfo1" runat="server"></uc1:statusinfo></td>
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
