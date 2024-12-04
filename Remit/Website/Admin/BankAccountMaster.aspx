<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Page language="c#" Codebehind="BankAccountMaster.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.BankAccountMaster" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: Bank Account Manager</title><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
		<!-- InstanceBeginEditable name="doctitle" -->
		<!-- InstanceEndEditable -->
		<!-- InstanceBeginEditable name="head" -->
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
																&nbsp;Bank Account Management <!-- InstanceEndEditable --></font></td>
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
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td>
																		<asp:DataGrid id="dgrdBankAccount" runat="server" Width="100%" AutoGenerateColumns="False" BackColor="White"
																			BorderColor="Silver" DataKeyField="Id">
																			<HeaderStyle Font-Bold="True"></HeaderStyle>
																			<Columns>
																				<asp:BoundColumn DataField="Name" HeaderText="Bank Name"></asp:BoundColumn>
																				<asp:BoundColumn DataField="AccountNumber" HeaderText="Account Number"></asp:BoundColumn>
																				<asp:BoundColumn DataField="Address" HeaderText="Address"></asp:BoundColumn>
																				<asp:BoundColumn DataField="CurrencyName" ReadOnly="True" HeaderText="Currency"></asp:BoundColumn>
																				<asp:BoundColumn DataField="CountryName" ReadOnly="True" HeaderText="Country"></asp:BoundColumn>
																				<asp:BoundColumn DataField="ContactPerson" HeaderText="ContactPerson"></asp:BoundColumn>
																				<asp:BoundColumn DataField="TelephoneNumber" HeaderText="Tel"></asp:BoundColumn>
																				<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" CancelText="Cancel" EditText="Edit">
																					<HeaderStyle Width="80px"></HeaderStyle>
																				</asp:EditCommandColumn>
																				<asp:ButtonColumn Text="Delete" CommandName="Delete"></asp:ButtonColumn>
																			</Columns>
																		</asp:DataGrid></td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td><b>Add New Bank Account</b>
																	</td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td><table width="350" border="0" cellspacing="0" cellpadding="0">
																			<TR>
																				<TD align="right" width="120">Account Number :</TD>
																				<TD>
																					<asp:TextBox id="txtAccountNumber" runat="server" EnableViewState="False"></asp:TextBox></TD>
																			</TR>
																			<tr>
																				<td width="120" align="right">Bank Name :
																				</td>
																				<td>
																					<asp:TextBox id="txtBankName" runat="server" EnableViewState="False"></asp:TextBox></td>
																			</tr>
																			<TR>
																				<TD align="right" width="120">Bank Address :</TD>
																				<TD>
																					<asp:TextBox id="txtBankAddress" runat="server" TextMode="MultiLine" EnableViewState="False"></asp:TextBox></TD>
																			</TR>
																			<tr>
																				<td align="right">Currency :
																				</td>
																				<td>
																					<asp:DropDownList id="ddlCurrencyList" runat="server" DataTextField="Display" DataValueField="Id"></asp:DropDownList></td>
																			</tr>
																			<tr>
																				<td align="right" height="2">Country :
																				</td>
																				<td height="2">
																					<asp:DropDownList id="ddlCountryList" runat="server" DataValueField="Id" DataTextField="Display"></asp:DropDownList></td>
																			</tr>
																			<tr>
																				<td align="right">Contact Person :
																				</td>
																				<td>
																					<asp:TextBox id="txtContactPerson" runat="server" EnableViewState="False"></asp:TextBox></td>
																			</tr>
																			<tr>
																				<td align="right">Tel Number :
																				</td>
																				<td>
																					<asp:TextBox id="txtTelephoneNumber" runat="server" EnableViewState="False"></asp:TextBox></td>
																			</tr>
																			<tr>
																				<td width="120" align="right">&nbsp;</td>
																				<td>
																					<asp:Button id="butAdd" runat="server" Text="Add Bank Account"></asp:Button></td>
																			</tr>
																		</table>
																	</td>
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
											<td height="46" valign="top"><uc1:StatusInfo id="StatusInfo1" runat="server"></uc1:StatusInfo></td>
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
