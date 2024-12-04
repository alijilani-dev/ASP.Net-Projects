<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Page language="c#" Codebehind="WebFormList_BankList.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebFormList_BankList" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<%@ Register TagPrefix="Repeaters" Namespace="Evernet.MoneyExchange.Web.Repeaters" Assembly="mexchange" %>
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
																&nbsp;Bank Management <!-- InstanceEndEditable --></font></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
													<tr>
														<td align="center" valign="top"><!-- InstanceBeginEditable name="MainContent" -->
															<table rules="all" style="BORDER-COLLAPSE:collapse" cellSpacing="0" cellPadding="5" border="1">
																<tr class="TableFilter" align="center">
																	<td></td>
																	<td></td>
																	<td></td>
																	<td></td>
																	<td></td>
																	<td></td>
																	<td></td>
																	<td><DropDownLists:WebDropDownList_AgentMaster id="com_AccountId" runat="server" AutoPostBack="True" CssClass="Filter"></DropDownLists:WebDropDownList_AgentMaster>
																	</td>
																	<td><DropDownLists:WebDropDownList_LocationList id="com_LocationId" runat="server" AutoPostBack="True" CssClass="Filter"></DropDownLists:WebDropDownList_LocationList>
																	</td>
																</tr>
																<tr class="TableHeader" align="center">
																	<td><asp:HyperLink id="Add" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl="WebForm_BankList.aspx?Action=Add&amp;ReturnToUrl=WebFormList_BankList.aspx&amp;ReturnToDisplay=Back to the list"> Add </asp:HyperLink>
																	</td>
																	<td><asp:linkbutton id="Label_Name" runat="server" CssClass="TableHeader" EnableViewState="false"> Name </asp:linkbutton>
																	</td>
																	<td><asp:linkbutton id="Label_BranchName" runat="server" CssClass="TableHeader" EnableViewState="false"> BranchName </asp:linkbutton>
																	</td>
																	<td><asp:linkbutton id="Label_InternalCode" runat="server" CssClass="TableHeader" EnableViewState="false"> InternalCode </asp:linkbutton>
																	</td>
																	<td><asp:linkbutton id="Label_ExternalCode" runat="server" CssClass="TableHeader" EnableViewState="false"> ExternalCode </asp:linkbutton>
																	</td>
																	<td><asp:linkbutton id="Label_Address" runat="server" CssClass="TableHeader" EnableViewState="false"> Address </asp:linkbutton>
																	</td>
																	<td><asp:linkbutton id="Label_ZipCode" runat="server" CssClass="TableHeader" EnableViewState="false"> ZipCode </asp:linkbutton>
																	</td>
																	<td><asp:linkbutton id="Label_AccountId" runat="server" CssClass="TableHeader" EnableViewState="false"> Account </asp:linkbutton>
																	</td>
																	<td><asp:linkbutton id="Label_LocationId" runat="server" CssClass="TableHeader" EnableViewState="false"> City/Division </asp:linkbutton>
																	</td>
																</tr>
																<Repeaters:WebRepeaterCustom_spS_BankList_SelectDisplay id="repeater_BankList_SelectDisplay" runat="server">
																	<ItemTemplate>
																		<tr class="TableRow" align="center">
																			<td>
																				<asp:HyperLink id="Edit" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_BankList.aspx?Action=Edit&ID={0}&ReturnToUrl=WebFormList_BankList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'> Edit </asp:HyperLink>
																				<br>
																				<asp:HyperLink Visible="false" id="Delete" runat="server" CssClass="EditHyperLink" EnableViewState="false" NavigateUrl='<%# String.Format("WebForm_BankList.aspx?Action=Delete&ID={0}&ReturnToUrl=WebFormList_BankList.aspx&ReturnToDisplay=Back to the list", DataBinder.Eval(Container.DataItem, "Id") ) %>'> Delete </asp:HyperLink>
																			</td>
																			<td><%# DataBinder.Eval(Container.DataItem, "Name") %>
																			</td>
																			<td><%# DataBinder.Eval(Container.DataItem, "BranchName") %>
																			</td>
																			<td><%# DataBinder.Eval(Container.DataItem, "InternalCode") %>
																			</td>
																			<td><%# DataBinder.Eval(Container.DataItem, "ExternalCode") %>
																			</td>
																			<td><%# DataBinder.Eval(Container.DataItem, "Address") %>
																			</td>
																			<td><%# DataBinder.Eval(Container.DataItem, "ZipCode") %>
																			</td>
																			<td><%# DataBinder.Eval(Container.DataItem, "AccountId_Display") %>
																			</td>
																			<td><%# DataBinder.Eval(Container.DataItem, "LocationId_Display") %>
																			</td>
																		</tr>
																	</ItemTemplate>
																</Repeaters:WebRepeaterCustom_spS_BankList_SelectDisplay>
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
											<td height="46" valign="top" style="COLOR:#ffffff"><uc1:StatusInfo id="StatusInfo1" runat="server"></uc1:StatusInfo></UC1:STATUSINFO></td>
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
