<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Page language="c#" Codebehind="WebFormList_CurrencyList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_CurrencyList" %>
<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: Currency Management</title><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
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
																&nbsp;Currency Management</font></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
													<tr>
														<td align="center" valign="top"><!-- InstanceBeginEditable name="MainContent" -->
															<table rules="all" style="BORDER-COLLAPSE:collapse" cellSpacing="0" cellPadding="5" border="1">
																<tr class="TableHeader" align="center">
																	<td>
																		<asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_CurrencyList.aspx?Action=Add&amp;ReturnToUrl=WebFormList_CurrencyList.aspx&amp;ReturnToDisplay=Back to the list">
							Add
						</asp:HyperLink>
																	</td>
																	<td>
																		<asp:linkbutton id="Label_Name" runat="server" CssClass="TableHeader" EnableViewState="false">
							Name
						</asp:linkbutton>
																	</td>
																	<td>
																		<asp:linkbutton id="Label_Code" runat="server" CssClass="TableHeader" EnableViewState="false">
							Code
						</asp:linkbutton>
																	</td>
																	<td>
																		<asp:linkbutton id="Label_Scale" runat="server" CssClass="TableHeader" EnableViewState="false">
							Scale
						</asp:linkbutton>
																	</td>
																</tr>
																<Repeaters:WebRepeater_CurrencyList id="repeater_CurrencyList_SelectDisplay" runat="server">
																	<ItemTemplate>
																		<tr class="TableRow" align="center">
																			<td>
																				<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CurrencyList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_CurrencyList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Edit
								</asp:HyperLink>
																				<br>
																				<asp:HyperLink Visible="false" id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_CurrencyList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_CurrencyList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'>
									Delete
								</asp:HyperLink>
																			</td>
																			<td>
																				<%# DataBinder.Eval(Container.DataItem, "Name") %>
																			</td>
																			<td>
																				<%# DataBinder.Eval(Container.DataItem, "Code") %>
																			</td>
																			<td>
																				<%# DataBinder.Eval(Container.DataItem, "Scale") %>
																			</td>
																		</tr>
																	</ItemTemplate>
																</Repeaters:WebRepeater_CurrencyList>
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
											<td height="46" valign="top"><uc1:StatusInfo id="StatusInfo1" runat="server"></uc1:StatusInfo></UC1:STATUSINFO></td>
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
