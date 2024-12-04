<%@ Page language="c#" Codebehind="ViewReport_ExchangeEarnings.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.ViewReport_ExchangeEarnings" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: Exchange Earning Report</title><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
		<!-- InstanceBeginEditable name="doctitle" -->
		<!-- InstanceEndEditable -->
		<!-- InstanceBeginEditable name="head" -->
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
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
																&nbsp;Exchange Earning Report <!-- InstanceEndEditable --></font></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td vAlign="top">
												<table cellSpacing="0" cellPadding="0" width="100%" border="0">
													<tr>
														<td vAlign="top" align="center"><!-- InstanceBeginEditable name="MainContent" -->
															<table cellSpacing="0" cellPadding="0" width="500" border="0">
																<tr>
																	<td>
																		<table cellSpacing="0" cellPadding="0" width="100%" border="0">
																			<TR>
																				<TD align="right" width="120"></TD>
																				<TD><asp:label id="lblMessage" runat="server"></asp:label></TD>
																			</TR>
																			<tr>
																				<td align="right" width="120">Agent Account :
																				</td>
																				<td><asp:dropdownlist id="ddlAgentAccount" runat="server" DataTextField="Name" DataValueField="Id"></asp:dropdownlist></td>
																			</tr>
																			<tr>
																				<td align="right">Start Date :
																				</td>
																				<td><asp:textbox id="txtStartDate" runat="server"></asp:textbox></td>
																			</tr>
																			<tr>
																				<td align="right">&nbsp;</td>
																				<td><font color="#ff0000" size="1">(ex: 12 Jan 2004)</font>
																				</td>
																			</tr>
																			<tr>
																				<td align="right">End Date :
																				</td>
																				<td><asp:textbox id="txtEndDate" runat="server"></asp:textbox></td>
																			</tr>
																			<TR>
																				<TD align="right"></TD>
																				<TD><asp:button id="butDisplay" runat="server" Text="Display"></asp:button></TD>
																			</TR>
																		</table>
																	</td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td align="center"><asp:datagrid id="dgrdExchangeEarning" runat="server" Width="100%" AutoGenerateColumns="False"
																			ShowFooter="True" BorderColor="Black" BackColor="White">
																			<ItemStyle HorizontalAlign="Right"></ItemStyle>
																			<HeaderStyle Font-Size="X-Small" Font-Bold="True" HorizontalAlign="Center"></HeaderStyle>
																			<FooterStyle HorizontalAlign="Right"></FooterStyle>
																			<Columns>
																				<asp:BoundColumn DataField="VoucherNumber" HeaderText="V . No"></asp:BoundColumn>
																				<asp:BoundColumn DataField="PayInDateTime" HeaderText="Date" DataFormatString="{0: dd MMM yyyy}"></asp:BoundColumn>
																				<asp:TemplateColumn HeaderText="SRTR No">
																					<ItemTemplate>
																						<asp:Label id=Label3 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TransactionNumber") %>'>
																						</asp:Label>
																					</ItemTemplate>
																					<FooterTemplate>
																						<STRONG>Total</STRONG>
																					</FooterTemplate>
																					<EditItemTemplate>
																						<asp:TextBox id=TextBox3 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TransactionNumber") %>'>
																						</asp:TextBox>
																					</EditItemTemplate>
																				</asp:TemplateColumn>
																				<asp:TemplateColumn HeaderText="PayIn Amount">
																					<ItemTemplate>
																						<asp:Label id=Label4 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PayInAmount", "{0:########0.000}") %>'>
																						</asp:Label>
																					</ItemTemplate>
																					<FooterTemplate>
																						<asp:Label id=lblTotalPayinAmount runat="server" Text="<%# totalPayInAmount %>">
																						</asp:Label>
																					</FooterTemplate>
																					<EditItemTemplate>
																						<asp:TextBox id=TextBox4 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PayInAmount", "{0:########0.000}") %>'>
																						</asp:TextBox>
																					</EditItemTemplate>
																				</asp:TemplateColumn>
																				<asp:TemplateColumn HeaderText="SR Amount">
																					<ItemTemplate>
																						<asp:Label id=Label2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.AgencyAmount") %>'>
																						</asp:Label>
																					</ItemTemplate>
																					<FooterTemplate>
																						<asp:Label id=lblTotalAgencyAmount runat="server" Text="<%# totalAgencyEarning %>">
																						</asp:Label>
																					</FooterTemplate>
																					<EditItemTemplate>
																						<asp:TextBox id=TextBox2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.AgencyAmount") %>'>
																						</asp:TextBox>
																					</EditItemTemplate>
																				</asp:TemplateColumn>
																				<asp:TemplateColumn HeaderText="Earnings">
																					<ItemTemplate>
																						<asp:Label id=Label1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Earnings") %>'>
																						</asp:Label>
																					</ItemTemplate>
																					<FooterTemplate>
																						<asp:Label id=lblTotalEarning runat="server" Text="<%# totalEarning %>">
																						</asp:Label>
																					</FooterTemplate>
																					<EditItemTemplate>
																						<asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Earnings") %>'>
																						</asp:TextBox>
																					</EditItemTemplate>
																				</asp:TemplateColumn>
																			</Columns>
																		</asp:datagrid>
																		<asp:HyperLink id="hlnkPrintView" runat="server" Visible="False">Print View</asp:HyperLink></td>
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
