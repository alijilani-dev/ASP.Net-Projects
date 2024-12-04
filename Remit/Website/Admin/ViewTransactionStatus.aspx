<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Page language="c#" Codebehind="ViewTransactionStatus.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.ViewTransactionStatus" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: </title><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
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
													<tr>
														<td align="center"><font size="4" face="Arial, Helvetica, sans-serif"><!-- InstanceBeginEditable name="Heading" --> 
																&nbsp;Transaction Status<!-- InstanceEndEditable --></font></td>
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
																	<td align="center"><table width="400" border="0" cellspacing="0" cellpadding="0">
																			<tr>
																				<td width="180" align="right">Start Date :
																				</td>
																				<td>
																					<asp:TextBox id="txtStartDate" runat="server"></asp:TextBox></td>
																			</tr>
																			<tr>
																				<td align="right">&nbsp;</td>
																				<td>(ex: 12 Jan 2004)
																				</td>
																			</tr>
																			<tr>
																				<td align="right">End Date :
																				</td>
																				<td>
																					<asp:TextBox id="txtEndDate" runat="server"></asp:TextBox></td>
																			</tr>
																			<TR>
																				<TD align="right">Status :</TD>
																				<TD>
																					<asp:DropDownList id="ddlStatus" runat="server" DataTextField="Name" DataValueField="Value"></asp:DropDownList></TD>
																			</TR>
																			<tr>
																				<td align="right">&nbsp;</td>
																				<td>
																					<asp:Button id="butDisplay" runat="server" Text="Display by Date"></asp:Button></td>
																			</tr>
																		</table>
																	</td>
																</tr>
																<TR>
																	<TD align="center">&nbsp;</TD>
																</TR>
																<TR>
																	<TD align="center">
																		<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="300" border="0">
																			<TR>
																				<TD align="right" width="120">SR TR Number :</TD>
																				<TD>
																					<asp:TextBox id="txtTransactionNumber" runat="server"></asp:TextBox></TD>
																			</TR>
																			<TR>
																				<TD>&nbsp;</TD>
																				<TD>&nbsp;</TD>
																			</TR>
																			<TR>
																				<TD></TD>
																				<TD>
																					<asp:Button id="butDisplayByTRNum" runat="server" Text="Display by SR TR #"></asp:Button></TD>
																			</TR>
																		</TABLE>
																	</TD>
																</TR>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td align="center">
																		<asp:DataGrid id="dgrdTransactionList" runat="server" BackColor="White" BorderColor="Black" BorderWidth="1px"
																			AutoGenerateColumns="False" Width="85%">
																			<HeaderStyle Font-Bold="True" HorizontalAlign="Center"></HeaderStyle>
																			<Columns>
																				<asp:TemplateColumn HeaderText="S.No">
																					<ItemTemplate>
																						<asp:Label id=Label1 runat="server" Text="<%# serialNo++ %>">
																						</asp:Label>
																					</ItemTemplate>
																					<EditItemTemplate>
																						<asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.serialNo++") %>'>
																						</asp:TextBox>
																					</EditItemTemplate>
																				</asp:TemplateColumn>
																				<asp:BoundColumn DataField="TransactionNumber" HeaderText="SR TR #"></asp:BoundColumn>
																				<asp:BoundColumn DataField="PayInDateTime" HeaderText="Date / Time" DataFormatString="{0: dd MMM yyyy HH:mm:ss}"></asp:BoundColumn>
																				<asp:BoundColumn DataField="Status" HeaderText="Status"></asp:BoundColumn>
																				<asp:HyperLinkColumn Text="Details..." DataNavigateUrlField="Id" DataNavigateUrlFormatString="ShowReceipt.aspx?Id={0}&amp;ShowNewTransactionLink=false"></asp:HyperLinkColumn>
																				<asp:TemplateColumn Visible="False">
																					<ItemTemplate>
																						<asp:HyperLink id=HyperLink1 runat="server" Text="Cancel" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.Id", "ChangeTransactionStatus.aspx?Id={0}&amp;Status=CancelledWithoutRefund") %>' Enabled='<%# canChangeStatus(DataBinder.Eval(Container, "DataItem.Status").ToString(),"CancelledWithoutRefund") %>'>Cancel</asp:HyperLink>
																					</ItemTemplate>
																				</asp:TemplateColumn>
																				<asp:TemplateColumn Visible="False">
																					<ItemTemplate>
																						<asp:HyperLink id=HyperLink2 runat="server" Text="Cancel (With Refund)" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.Id", "ChangeTransactionStatus.aspx?Id={0}&amp;Status=CancelledWithRefund") %>' Enabled='<%# canChangeStatus(DataBinder.Eval(Container, "DataItem.Status"),"CancelledWithRefund") %>'>Cancel (With Refund)</asp:HyperLink>
																					</ItemTemplate>
																				</asp:TemplateColumn>
																				<asp:TemplateColumn>
																					<ItemTemplate>
																						<asp:HyperLink id=HyperLink3 runat="server" Text="Block" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.Id", "ChangeTransactionStatus.aspx?Id={0}&amp;Status=AgencyBlocked") %>' Enabled='<%# canChangeStatus(DataBinder.Eval(Container, "DataItem.Status"),"AgencyBlocked") %>'>Block</asp:HyperLink>
																					</ItemTemplate>
																				</asp:TemplateColumn>
																				<asp:TemplateColumn>
																					<ItemTemplate>
																						<asp:HyperLink id=HyperLink4 runat="server" Text="Un-Block" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.Id", "ChangeTransactionStatus.aspx?Id={0}&amp;Status=UnPaid") %>' Enabled='<%# canChangeStatus(DataBinder.Eval(Container, "DataItem.Status"),"UnPaid") %>'>Un-Block</asp:HyperLink>
																					</ItemTemplate>
																				</asp:TemplateColumn>
																			</Columns>
																		</asp:DataGrid>&nbsp;</td>
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
