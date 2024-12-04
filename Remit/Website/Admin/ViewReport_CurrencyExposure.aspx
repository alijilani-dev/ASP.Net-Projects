<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Page language="c#" Codebehind="ViewReport_CurrencyExposure.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.ViewReport_CurrencyExposure" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: Exposure Report</title><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
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
													<TR>
														<TD align="center">&nbsp;
															<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
																<TR>
																	<TD align="right" width="180">Report Date :</TD>
																	<TD>
																		<asp:TextBox id="txtReportDate" runat="server"></asp:TextBox>&nbsp;
																		<asp:Button id="butGetReport" runat="server" Text="Get Report"></asp:Button></TD>
																</TR>
															</TABLE>
														</TD>
													</TR>
													<TR>
														<TD align="center">&nbsp;Report Date :
															<asp:Label id="lblReportTime" runat="server"></asp:Label></TD>
													</TR>
													<tr>
														<td align="center"><font size="4" face="Arial, Helvetica, sans-serif"><!-- InstanceBeginEditable name="Heading" -->
																&nbsp;Currency Exposure Cum Chart of Account as on
																<asp:Label id="lblDateTime" runat="server"></asp:Label></font></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
													<tr>
														<td align="center" valign="top"><!-- InstanceBeginEditable name="MainContent" -->
															&nbsp;
															<table width="100%" border="0" cellspacing="0" cellpadding="0">
																<tr>
																	<td>[Exposure Agents Report]
																	</td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td align="center">
																		<asp:DataGrid id="dgrdAgentsReport" runat="server" AutoGenerateColumns="False" BorderColor="Black"
																			BackColor="White" ShowFooter="True">
																			<FooterStyle HorizontalAlign="Right"></FooterStyle>
																			<ItemStyle HorizontalAlign="Right"></ItemStyle>
																			<HeaderStyle Font-Bold="True" HorizontalAlign="Center"></HeaderStyle>
																			<Columns>
																				<asp:BoundColumn DataField="AccountNumber" HeaderText="Acc No"></asp:BoundColumn>
																				<asp:BoundColumn DataField="Name" HeaderText="Name">
																					<ItemStyle HorizontalAlign="Center"></ItemStyle>
																				</asp:BoundColumn>
																				<asp:BoundColumn DataField="Code" HeaderText="Currency Code">
																					<ItemStyle HorizontalAlign="Center"></ItemStyle>
																				</asp:BoundColumn>
																				<asp:TemplateColumn HeaderText="FC Amount">
																					<ItemTemplate>
																						<asp:Label id=Label1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.FCAmount", "{0:########0.00}") %>'>
																						</asp:Label>
																					</ItemTemplate>
																					<FooterTemplate>
																						<STRONG>Total</STRONG>
																					</FooterTemplate>
																					<EditItemTemplate>
																						<asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.FCAmount", "{0:########0.00}") %>'>
																						</asp:TextBox>
																					</EditItemTemplate>
																				</asp:TemplateColumn>
																				<asp:TemplateColumn HeaderText="USD Amount">
																					<ItemTemplate>
																						<asp:Label id=Label2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.USDAmount", "{0:########0.00}") %>'>
																						</asp:Label>
																					</ItemTemplate>
																					<FooterTemplate>
																						<asp:Label id=lblAgentReportsTotal runat="server" Text="<%# agentReportsTotal.ToString() %>">
																						</asp:Label>
																					</FooterTemplate>
																					<EditItemTemplate>
																						<asp:TextBox id=TextBox2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.USDAmount", "{0:########0.00}") %>'>
																						</asp:TextBox>
																					</EditItemTemplate>
																				</asp:TemplateColumn>
																				<asp:BoundColumn DataField="Average" HeaderText="Average" DataFormatString="{0:########0.000000}"></asp:BoundColumn>
																				<asp:BoundColumn DataField="RevRate" HeaderText="RevRate" DataFormatString="{0:########0.000000}"></asp:BoundColumn>
																				<asp:TemplateColumn HeaderText="Profit / (Loss)">
																					<ItemTemplate>
																						<asp:Label id=Label7 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PL", "{0:########0.00}") %>' ForeColor='<%# decimal.Round(Convert.ToDecimal(DataBinder.Eval(Container, "DataItem.PL").ToString()),2)!=0?((decimal.Round(Convert.ToDecimal(DataBinder.Eval(Container, "DataItem.PL").ToString()),2)>0)?System.Drawing.Color.Green:System.Drawing.Color.Red):System.Drawing.Color.Black %>'>
																						</asp:Label>
																					</ItemTemplate>
																					<EditItemTemplate>
																						<asp:TextBox id=TextBox7 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PL", "{0:########0.00}") %>'>
																						</asp:TextBox>
																					</EditItemTemplate>
																				</asp:TemplateColumn>
																			</Columns>
																		</asp:DataGrid></td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td>[Unpaid Accounts]
																	</td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td align="center">
																		<asp:DataGrid id="dgrdUnpaidAccounts" runat="server" AutoGenerateColumns="False" BorderColor="Black"
																			BackColor="White" ShowFooter="True">
																			<FooterStyle HorizontalAlign="Right"></FooterStyle>
																			<ItemStyle HorizontalAlign="Right"></ItemStyle>
																			<HeaderStyle Font-Bold="True" HorizontalAlign="Center"></HeaderStyle>
																			<Columns>
																				<asp:BoundColumn DataField="AccountNumber" HeaderText="Acc No"></asp:BoundColumn>
																				<asp:BoundColumn DataField="Name" HeaderText="Name">
																					<ItemStyle HorizontalAlign="Center"></ItemStyle>
																				</asp:BoundColumn>
																				<asp:BoundColumn DataField="Code" HeaderText="Currency Code">
																					<ItemStyle HorizontalAlign="Center"></ItemStyle>
																				</asp:BoundColumn>
																				<asp:TemplateColumn HeaderText="FC Amount">
																					<ItemTemplate>
																						<asp:Label id=Label3 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.FCAmount", "{0:########0.00}") %>'>
																						</asp:Label>
																					</ItemTemplate>
																					<FooterTemplate>
																						<STRONG>Total</STRONG>
																					</FooterTemplate>
																					<EditItemTemplate>
																						<asp:TextBox id=TextBox3 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.FCAmount", "{0:########0.00}") %>'>
																						</asp:TextBox>
																					</EditItemTemplate>
																				</asp:TemplateColumn>
																				<asp:TemplateColumn HeaderText="USD Amount">
																					<ItemTemplate>
																						<asp:Label id=Label4 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.USDAmount", "{0:########0.00}") %>'>
																						</asp:Label>
																					</ItemTemplate>
																					<FooterTemplate>
																						<asp:Label id=lblUnpaidAccountTotal runat="server" Text="<%# unpaidAccountReportsTotal.ToString() %>">
																						</asp:Label>
																					</FooterTemplate>
																					<EditItemTemplate>
																						<asp:TextBox id=TextBox4 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.USDAmount", "{0:########0.00}") %>'>
																						</asp:TextBox>
																					</EditItemTemplate>
																				</asp:TemplateColumn>
																				<asp:BoundColumn DataField="Average" HeaderText="Average" DataFormatString="{0:########0.000000}"></asp:BoundColumn>
																				<asp:BoundColumn DataField="RevRate" HeaderText="RevRate" DataFormatString="{0:########0.000000}"></asp:BoundColumn>
																				<asp:TemplateColumn HeaderText="Profit / (Loss)">
																					<ItemTemplate>
																						<asp:Label id=Label8 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PL", "{0:########0.00}") %>' ForeColor='<%# decimal.Round(Convert.ToDecimal(DataBinder.Eval(Container, "DataItem.PL").ToString()),2)!=0?((decimal.Round(Convert.ToDecimal(DataBinder.Eval(Container, "DataItem.PL").ToString()),2)>0)?System.Drawing.Color.Green:System.Drawing.Color.Red):System.Drawing.Color.Black %>'>
																						</asp:Label>
																					</ItemTemplate>
																					<EditItemTemplate>
																						<asp:TextBox id=TextBox8 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PL", "{0:########0.00}") %>'>
																						</asp:TextBox>
																					</EditItemTemplate>
																				</asp:TemplateColumn>
																			</Columns>
																		</asp:DataGrid></td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td>[SR Commission Income Account]
																	</td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td align="center">
																		<asp:DataGrid id="dgrdAgencyCommissionIncomeAccounts" runat="server" AutoGenerateColumns="False"
																			BorderColor="Black" BackColor="White" ShowFooter="True">
																			<FooterStyle HorizontalAlign="Right"></FooterStyle>
																			<ItemStyle HorizontalAlign="Right"></ItemStyle>
																			<HeaderStyle Font-Bold="True" HorizontalAlign="Center"></HeaderStyle>
																			<Columns>
																				<asp:BoundColumn DataField="AccountNumber" HeaderText="Acc No"></asp:BoundColumn>
																				<asp:BoundColumn DataField="Name" HeaderText="Name">
																					<ItemStyle HorizontalAlign="Center"></ItemStyle>
																				</asp:BoundColumn>
																				<asp:BoundColumn DataField="Code" HeaderText="Currency Code">
																					<ItemStyle HorizontalAlign="Center"></ItemStyle>
																				</asp:BoundColumn>
																				<asp:TemplateColumn HeaderText="FC Amount">
																					<ItemTemplate>
																						<asp:Label id=Label5 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.FCAmount", "{0:########0.00}") %>'>
																						</asp:Label>
																					</ItemTemplate>
																					<FooterTemplate>
																						<STRONG>Total</STRONG>
																					</FooterTemplate>
																					<EditItemTemplate>
																						<asp:TextBox id=TextBox5 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.FCAmount", "{0:########0.00}") %>'>
																						</asp:TextBox>
																					</EditItemTemplate>
																				</asp:TemplateColumn>
																				<asp:TemplateColumn HeaderText="USD Amount">
																					<ItemTemplate>
																						<asp:Label id=Label6 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.USDAmount", "{0:########0.00}") %>'>
																						</asp:Label>
																					</ItemTemplate>
																					<FooterTemplate>
																						<asp:Label id=lblAgencyCommissionIncomeTotal runat="server" Text="<%# srCommissionIncomeAccountsTotal.ToString() %>">
																						</asp:Label>
																					</FooterTemplate>
																					<EditItemTemplate>
																						<asp:TextBox id=TextBox6 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.USDAmount", "{0:########0.00}") %>'>
																						</asp:TextBox>
																					</EditItemTemplate>
																				</asp:TemplateColumn>
																				<asp:BoundColumn DataField="Average" HeaderText="Average" DataFormatString="{0:########0.000000}"></asp:BoundColumn>
																				<asp:BoundColumn DataField="RevRate" HeaderText="RevRate" DataFormatString="{0:########0.000000}"></asp:BoundColumn>
																				<asp:TemplateColumn HeaderText="Profit / (Loss)">
																					<ItemTemplate>
																						<asp:Label id=Label9 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PL", "{0:########0.00}") %>' ForeColor='<%# decimal.Round(Convert.ToDecimal(DataBinder.Eval(Container, "DataItem.PL").ToString()),2)!=0?((decimal.Round(Convert.ToDecimal(DataBinder.Eval(Container, "DataItem.PL").ToString()),2)>0)?System.Drawing.Color.Green:System.Drawing.Color.Red):System.Drawing.Color.Black %>'>
																						</asp:Label>
																					</ItemTemplate>
																					<EditItemTemplate>
																						<asp:TextBox id=TextBox9 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PL", "{0:########0.00}") %>'>
																						</asp:TextBox>
																					</EditItemTemplate>
																				</asp:TemplateColumn>
																			</Columns>
																		</asp:DataGrid></td>
																</tr>
																<tr>
																	<td align="center">&nbsp;
																		<asp:HyperLink id="hlnkPrintView" runat="server" Target="_blank">Print View</asp:HyperLink></td>
																</tr>
																<tr>
																	<td align="center"><table width="450" border="0" cellspacing="0" cellpadding="0">
																			<tr>
																				<td width="50%" align="right">Balance :
																				</td>
																				<td width="50%">
																					<asp:Label id="lblBalance" runat="server"></asp:Label></td>
																			</tr>
																			<tr>
																				<td>&nbsp;</td>
																				<td>&nbsp;</td>
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
