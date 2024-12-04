<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Page language="c#" Codebehind="ViewSentTransactions.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.ViewSentTransactions" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: </title><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
		<!-- InstanceBeginEditable name="doctitle" -->
		<!-- InstanceEndEditable -->
		<!-- InstanceBeginEditable name="head" -->
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<!-- InstanceEndEditable --><LINK href="/css/InnerPage.css" type="text/css" rel="stylesheet"><LINK href="/Admin/StyleSheet.css" type="text/css" rel="stylesheet">
		<script language="javascript">
           function openWindow(url) {
           window.open(url,'SpeedRemit','height=600,width=1024,location=0,toolbar=0,scrollbars=1');
           return false;
           }
		</script>
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
																&nbsp;View Sent Transactions <!-- InstanceEndEditable --></font></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td vAlign="top" align="center">
												<table cellSpacing="0" cellPadding="0" width="100%" border="0">
													<tr>
														<td style="HEIGHT: 354px" vAlign="top" align="center"><!-- InstanceBeginEditable name="MainContent" -->
															<table cellSpacing="0" cellPadding="0" width="100%" border="0">
																<tr>
																	<td>&nbsp;&nbsp;&nbsp;
																		<asp:label id="lblMessage" runat="server"></asp:label></td>
																</tr>
																<TR>
																	<TD>&nbsp;</TD>
																</TR>
																<TR>
																	<TD>
																		<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
																			<TR>
																				<TD width="120"></TD>
																				<TD width="120">Login :</TD>
																				<TD><asp:dropdownlist id="ddlLoginNames" runat="server" DataTextField="Display" DataValueField="ID1" AutoPostBack="True"></asp:dropdownlist></TD>
																			</TR>
																			<TR>
																				<TD style="HEIGHT: 4px" width="120"></TD>
																				<TD style="HEIGHT: 4px" width="120">Status :</TD>
																				<TD style="HEIGHT: 4px"><asp:dropdownlist id="ddlStatus" runat="server">
																						<asp:ListItem Value="%">All </asp:ListItem>
																						<asp:ListItem Value="Paid">Paid</asp:ListItem>
																						<asp:ListItem Value="UnPaid">UnPaid</asp:ListItem>
																					</asp:dropdownlist></TD>
																			</TR>
																			<TR>
																				<TD width="120"></TD>
																				<TD width="120">Start Date :</TD>
																				<TD><asp:textbox id="txtStartDate" runat="server"></asp:textbox></TD>
																			</TR>
																			<TR>
																				<TD width="120"></TD>
																				<TD width="120">End Date :</TD>
																				<TD><asp:textbox id="txtEndDate" runat="server"></asp:textbox></TD>
																			</TR>
																			<TR>
																				<TD width="120"></TD>
																				<TD width="120"></TD>
																				<TD><asp:button id="butDisplay" runat="server" Text="Display"></asp:button></TD>
																			</TR>
																		</TABLE>
																	</TD>
																</TR>
																<TR>
																	<TD align="center">&nbsp;</TD>
																</TR>
																<TR>
																	<TD align="center">&nbsp;</TD>
																</TR>
																<tr>
																	<td>&nbsp;&nbsp;&nbsp;
																		<asp:label id="lblCashOverCounter" runat="server" Visible="False" Font-Size="X-Small" Font-Bold="True">Cash Over Counter (COC)</asp:label></td>
																</tr>
																<TR>
																	<TD></TD>
																</TR>
																<tr>
																	<td align="center"><asp:datagrid id="dgrdTransactionDetails" runat="server" AllowSorting="True" ForeColor="Black"
																			GridLines="None" CellPadding="2" BackColor="LightGoldenrodYellow" BorderWidth="1px" BorderColor="Tan" AutoGenerateColumns="False"
																			Width="95%">
																			<SelectedItemStyle ForeColor="GhostWhite" BackColor="DarkSlateBlue"></SelectedItemStyle>
																			<AlternatingItemStyle BackColor="PaleGoldenrod"></AlternatingItemStyle>
																			<HeaderStyle Font-Bold="True" BackColor="Tan"></HeaderStyle>
																			<FooterStyle BackColor="Tan"></FooterStyle>
																			<Columns>
																				<asp:BoundColumn DataField="PayInAgentUserId_LoginName" HeaderText="User"></asp:BoundColumn>
																				<asp:BoundColumn DataField="TransactionNumber" HeaderText="SRTR No"></asp:BoundColumn>
																				<asp:BoundColumn DataField="PayInDateTime" SortExpression="PayInDateTime" HeaderText="Date"></asp:BoundColumn>
																				<asp:BoundColumn DataField="Remitter" HeaderText="Remitter"></asp:BoundColumn>
																				<asp:BoundColumn DataField="PayInAmount" SortExpression="PayInAmount" HeaderText="PayIn Amount" DataFormatString="{0:##########0.000}"></asp:BoundColumn>
																				<asp:BoundColumn DataField="PayOutAmount" HeaderText="Payout Amount" DataFormatString="{0:##########0.000}"></asp:BoundColumn>
																				<asp:BoundColumn DataField="PayOutCurrencyId_Code" HeaderText="PayOut Currency"></asp:BoundColumn>
																				<asp:BoundColumn DataField="Status_Name" SortExpression="Status_Name" HeaderText="Status"></asp:BoundColumn>
																				<asp:HyperLinkColumn Text="Details" DataNavigateUrlField="Id" DataNavigateUrlFormatString="ShowReceipt.aspx?Id={0}"></asp:HyperLinkColumn>
																				<asp:TemplateColumn>
																					<ItemTemplate>
																						<asp:HyperLink id="hlnkBlock" runat="server" Text="Block" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.Id", "ChangeTransactionStatus.aspx?Id={0}&amp;Status=AgentBlocked&amp;ru=ViewSentTransactions.aspx") %>' Enabled='<%# canChangeStatus(DataBinder.Eval(Container, "DataItem.Status"),"AgentBlocked") %>'>Block</asp:HyperLink>
																					</ItemTemplate>
																				</asp:TemplateColumn>
																				<asp:TemplateColumn>
																					<ItemTemplate>
																						<asp:HyperLink id="hlnkUnBlock" runat="server" Text="Un-Block" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.Id", "ChangeTransactionStatus.aspx?Id={0}&amp;Status=UnPaid&amp;ru=ViewSentTransactions.aspx") %>' Enabled='<%# canChangeStatus(DataBinder.Eval(Container, "DataItem.Status"),"UnPaid") %>'>Un-Block</asp:HyperLink>
																					</ItemTemplate>
																				</asp:TemplateColumn>
																			</Columns>
																			<PagerStyle HorizontalAlign="Center" ForeColor="DarkSlateBlue" BackColor="PaleGoldenrod"></PagerStyle>
																		</asp:datagrid>
																		<P align="left">&nbsp;&nbsp;&nbsp;&nbsp;
																			<asp:label id="lblTotalCOC" runat="server" Visible="False" Font-Bold="True"></asp:label></P>
																	</td>
																</tr>
															</table>
															<!-- InstanceEndEditable <asp:button id="btnReport" runat="server" Text="Generate Report" Visible="False"></asp:button>-->
															&nbsp;</td>
													</tr>
													<TR>
														<TD vAlign="top" align="center">&nbsp;</TD>
													</TR>
													<TR>
														<TD vAlign="top" align="center">
															<P align="left">&nbsp;&nbsp;&nbsp;
																<asp:label id="lblBankTransfer" runat="server" Visible="False" Font-Size="X-Small" Font-Bold="True">Bank Transfer (DTH/DTB/CTA)</asp:label></P>
														</TD>
													</TR>
													<TR>
														<TD vAlign="top" align="center"></TD>
													</TR>
													<TR>
														<TD vAlign="top" align="center">
															<asp:datagrid id="dgrdDraftDetails" runat="server" AllowSorting="True" ForeColor="Black" GridLines="None"
																CellPadding="2" BackColor="LightGoldenrodYellow" BorderWidth="1px" BorderColor="Tan" AutoGenerateColumns="False"
																Width="95%">
																<SelectedItemStyle ForeColor="GhostWhite" BackColor="DarkSlateBlue"></SelectedItemStyle>
																<AlternatingItemStyle BackColor="PaleGoldenrod"></AlternatingItemStyle>
																<HeaderStyle Font-Bold="True" BackColor="Tan"></HeaderStyle>
																<FooterStyle BackColor="Tan"></FooterStyle>
																<Columns>
																	<asp:BoundColumn DataField="PayInAgentUserId_LoginName" HeaderText="User"></asp:BoundColumn>
																	<asp:BoundColumn DataField="TransactionNumber" HeaderText="SRTR No"></asp:BoundColumn>
																	<asp:BoundColumn DataField="PayInDateTime" SortExpression="PayInDateTime" HeaderText="Date"></asp:BoundColumn>
																	<asp:BoundColumn DataField="Remitter" HeaderText="Remitter"></asp:BoundColumn>
																	<asp:BoundColumn DataField="PayInAmount" SortExpression="PayInAmount" HeaderText="PayIn Amount" DataFormatString="{0:##########0.000}"></asp:BoundColumn>
																	<asp:BoundColumn DataField="PayOutAmount" HeaderText="Payout Amount" DataFormatString="{0:##########0.000}"></asp:BoundColumn>
																	<asp:BoundColumn DataField="PayOutCurrencyId_Code" HeaderText="PayOut Currency"></asp:BoundColumn>
																	<asp:BoundColumn DataField="Status_Name" SortExpression="Status_Name" HeaderText="Status"></asp:BoundColumn>
																	<asp:HyperLinkColumn Text="Details" DataNavigateUrlField="Id" DataNavigateUrlFormatString="ShowReceipt.aspx?Id={0}"></asp:HyperLinkColumn>
																	<asp:TemplateColumn>
																		<ItemTemplate>
																			<asp:HyperLink id="hlnkBlockBank" runat="server" Text="Block" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.Id", "ChangeTransactionStatus.aspx?Id={0}&amp;Status=AgentBlocked&amp;ru=ViewSentTransactions.aspx") %>' Enabled='<%# canChangeStatus(DataBinder.Eval(Container, "DataItem.Status"),"AgentBlocked") %>'>Block</asp:HyperLink>
																		</ItemTemplate>
																	</asp:TemplateColumn>
																	<asp:TemplateColumn>
																		<ItemTemplate>
																			<asp:HyperLink id="hlnkUnBlockBank" runat="server" Text="Un-Block" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.Id", "ChangeTransactionStatus.aspx?Id={0}&amp;Status=UnPaid&amp;ru=ViewSentTransactions.aspx") %>' Enabled='<%# canChangeStatus(DataBinder.Eval(Container, "DataItem.Status"),"UnPaid") %>'>Un-Block</asp:HyperLink>
																		</ItemTemplate>
																	</asp:TemplateColumn>
																</Columns>
																<PagerStyle HorizontalAlign="Center" ForeColor="DarkSlateBlue" BackColor="PaleGoldenrod"></PagerStyle>
															</asp:datagrid>
															<P align="left">&nbsp;&nbsp;&nbsp;&nbsp;
																<asp:label id="lblTotalBTs" runat="server" Visible="False" Font-Bold="True"></asp:label></P>
														</TD>
													</TR>
												</table>
												&nbsp;</td>
										</tr>
										<tr>
											<td vAlign="top" align="center">&nbsp;<A onclick="return openWindow('Redirector.aspx?ru=ShowReport.aspx%3fType%3dForSentTrans')"
													href="javascript:void()">Generate Report</A></td>
										</tr>
										<TR>
											<TD vAlign="top" align="center">&nbsp;</TD>
										</TR>
										<TR>
											<TD vAlign="top" align="center">&nbsp;</TD>
										</TR>
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
