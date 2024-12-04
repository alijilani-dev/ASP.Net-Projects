<%@ Page language="c#" Codebehind="ZohaTransactionsManagement.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.ZohaTransactionsManagement" smartNavigation="true" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
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
																Zoha Transaction&nbsp;Management <!-- InstanceEndEditable --></font></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td vAlign="top">
												<table cellSpacing="0" cellPadding="0" width="100%" border="0">
													<tr>
														<td vAlign="top" align="center"><!-- InstanceBeginEditable name="MainContent" -->
															<table cellSpacing="0" cellPadding="0" width="100%" border="0">
																<tr>
																	<td><asp:label id="lblMessage" runat="server"></asp:label></td>
																</tr>
																<tr>
																	<td>&nbsp;</td>
																</tr>
																<tr>
																	<td align="center"><asp:datagrid id="dgrdSREmployees" runat="server" DataKeyField="Id" AutoGenerateColumns="False"
																			Width="100%">
																			<HeaderStyle Font-Bold="True" HorizontalAlign="Center"></HeaderStyle>
																			<Columns>
																				<asp:TemplateColumn HeaderText="Inv. #">
																					<HeaderStyle Width="24pt"></HeaderStyle>
																					<ItemTemplate>
																						<asp:Label id="Label4" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.EnvoiceNumber") %>'>
																						</asp:Label>
																					</ItemTemplate>
																				</asp:TemplateColumn>
																				<asp:TemplateColumn HeaderText="Transaction Number">
																					<ItemTemplate>
																						<asp:Label id=Label1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TransactionNumber") %>'>
																						</asp:Label>
																					</ItemTemplate>
																				</asp:TemplateColumn>
																				<asp:TemplateColumn HeaderText="Sender Name">
																					<ItemTemplate>
																						<asp:Label id=Label2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SenderName") %>'>
																						</asp:Label>
																					</ItemTemplate>
																				</asp:TemplateColumn>
																				<asp:TemplateColumn HeaderText="PayOutDate (MM/DD/YYYY)">
																					<EditItemTemplate>
																						<asp:TextBox id=txtPayOutDateTime Columns="8" runat="server" Visible='<%# DataBinder.Eval(Container, "DataItem.Status").ToString()=="UnPaid"?true:false %>'>
																						</asp:TextBox>
																					</EditItemTemplate>
																				</asp:TemplateColumn>
																				<asp:TemplateColumn HeaderText="ID Details">
																					<EditItemTemplate>
																						<asp:TextBox id="txtCollectedBeneficeryIdDetails" Columns="8" runat="server" Visible='<%# DataBinder.Eval(Container, "DataItem.Status").ToString()=="UnPaid"?true:false %>'>
																						</asp:TextBox>
																					</EditItemTemplate>
																				</asp:TemplateColumn>
																				<asp:TemplateColumn HeaderText="Pay-In Date">
																					<ItemTemplate>
																						<asp:Label id="Label3" runat="server" Text='<%# (DateTime.Parse(DataBinder.Eval(Container, "DataItem.PayInDateTime").ToString())).ToShortDateString() %>'>
																						</asp:Label>
																					</ItemTemplate>
																				</asp:TemplateColumn>
																				<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" CancelText="Cancel" EditText="PayOut"></asp:EditCommandColumn>
																			</Columns>
																		</asp:datagrid></td>
																</tr>
																<TR>
																	<TD>&nbsp;</TD>
																</TR>
																<TR>
																	<TD align="center">
																		<table cellSpacing="0" cellPadding="0" width="450" border="0">
																			<tr>
																				<td><STRONG>&nbsp;</STRONG></td>
																			</tr>
																			<tr>
																				<td>&nbsp;</td>
																			</tr>
																			<tr>
																				<td>
																					<table cellSpacing="0" cellPadding="0" width="100%" border="0">
																						<tr>
																							<td align="right" width="150">&nbsp;</td>
																							<td></td>
																						</tr>
																						<tr>
																							<td align="right">&nbsp;</td>
																							<td></td>
																						</tr>
																						<tr>
																							<td align="right">&nbsp;</td>
																							<td></td>
																						</tr>
																					</table>
																				</td>
																			</tr>
																			<tr>
																				<td align="center"></td>
																			</tr>
																		</table>
																	</TD>
																</TR>
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
