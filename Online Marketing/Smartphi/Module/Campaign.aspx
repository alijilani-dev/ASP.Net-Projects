<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Campaign.aspx.vb" Inherits="Smartphi.Campaign"%>
<%@ Register TagPrefix="uc1" TagName="Top" Src="Top.ascx" %>
<%@ Register TagPrefix="uc1" TagName="EditTemplate" Src="EditTemplate.ascx" %>
<%@ Register TagPrefix="uc1" TagName="SelectTemplate" Src="SelectTemplate.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Schedule" Src="Schedule.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Template</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../smart.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body bottomMargin="0" leftMargin="0" background="../images/bg_pg.jpg" topMargin="0" onLoad="FP_preloadImgs(/*url*/'../images/btn_abt_ovr.jpg', /*url*/'../images/btn_feature_ovr.jpg', /*url*/'../images/btn_login_ovr.jpg', /*url*/'../images/btn_demo_ovr.jpg', /*url*/'../images/btn_cntct_ovr.jpg', /*url*/'../images/btn_managecontacts_ovr.jpg', /*url*/'../images/btn_campaign_ovr.jpg', /*url*/'../images/btn_reports_ovr.jpg', /*url*/'../images/btn_myprofile_ovr.jpg')"
		rightMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table id="Template" cellSpacing="0" cellPadding="0" width="701" align="center" bgColor="#ffffff"
				background="../images/bg_pg.jpg" border="0" runat="server">
				<tr>
					<td style="HEIGHT: 127px"><uc1:top id="Top1" runat="server"></uc1:top></td>
				</tr>
				<tr id="Middle" runat="server">
					<td style="BORDER-RIGHT: #dedede 1px solid; BORDER-LEFT: #dedede 1px solid">
						<TABLE id="table6" cellSpacing="4" cellPadding="4" width="100%" border="0">
							<TR>
								<TD>
									<DIV align="center">
										<TABLE id="table7" cellSpacing="1" cellPadding="0" width="90%" border="0">
											<TR>
												<TD>&nbsp;
												</TD>
											</TR>
											<TR>
												<TD>
													<DIV align="center">
														<TABLE id="table8" cellSpacing="1" cellPadding="0" border="0">
															<TR>
																<TD align="center"><A href="Group.aspx"><IMG id="img6" onMouseOver="FP_swapImg(1,1,/*id*/'img6',/*url*/'../images/btn_managecontacts_ovr.jpg');"
																			onmouseout="FP_swapImgRestore('../images/btn_managecontacts.jpg')" src="../images/btn_managecontacts.jpg" border="0"></A></TD>
																<TD align="center"><A href="Campaign.aspx"><IMG id="img7" onMouseOver="FP_swapImg(1,1,/*id*/'img7',/*url*/'../images/btn_campaign_ovr.jpg');"
																			onmouseout="FP_swapImgRestore()" src="../images/btn_campaign_ovr.jpg" border="0"></A></TD>
																<TD align="center"><A href="Reports.aspx"><IMG id="img8" onMouseOver="FP_swapImg(1,1,/*id*/'img8',/*url*/'../images/btn_reports_ovr.jpg');"
																			onmouseout="FP_swapImgRestore()" src="../images/btn_reports.jpg" border="0"></A></TD>
																<TD align="center"><A href="MyProfile.aspx"><IMG id="img9" onMouseOver="FP_swapImg(1,1,/*id*/'img9',/*url*/'../images/btn_myprofile_ovr.jpg');"
																			onmouseout="FP_swapImgRestore(); FP_swapImgRestore()" src="../images/btn_myprofile.jpg" border="0"></A></TD>
															</TR>
														</TABLE>
													</DIV>
												</TD>
											</TR>
											<TR>
												<TD>
													<TABLE id="table9" class="txt" bgColor="#d2e1f1" height="22" cellSpacing="0" cellPadding="0"
														width="100%" border="0">
														<TR>
															<TD>&nbsp;<img border="0" src="../images/bullet.gif" width="5" height="9">
																<asp:HyperLink id="hlnkCreateCampaign" runat="server" NavigateUrl="Campaign.aspx">Create Campaign</asp:HyperLink>&nbsp;&nbsp;<img border="0" src="../images/bullet.gif" width="5" height="9">
																<asp:HyperLink id="hlnkManageCampaign" runat="server" NavigateUrl="Campaign.aspx?mode=2">Manage Campaign</asp:HyperLink></TD>
														</TR>
													</TABLE>
												</TD>
											</TR>
											<TR>
												<TD style="BORDER-RIGHT: #d2e1f1 1px solid; BORDER-TOP: #d2e1f1 1px solid; BORDER-LEFT: #d2e1f1 1px solid; BORDER-BOTTOM: #d2e1f1 1px solid">
													<TABLE id="Table1" cellPadding="2" width="100%" border="0">
														<TR>
															<TD colSpan="3" style="HEIGHT: 21px"><asp:label id="lblConfirm" runat="server" ForeColor="Red"></asp:label></TD>
														</TR>
														<TR>
															<TD id="tdCampaign" colSpan="3" runat="server">
																<TABLE class="txt" id="tblStep2" width="100%" border="0">
																	<TR>
																		<TD colSpan="2" class="hdnnews">Add&nbsp;New Campaign</TD>
																	</TR>
																	<TR>
																		<TD width="20%">Campaign Name:</TD>
																		<TD width="78%"><asp:textbox id="txtCampaignName" class="txtbox" runat="server" Width="400"></asp:textbox><BR>
																			<asp:requiredfieldvalidator id="rfvCampaignName" Display="Dynamic" runat="server" ControlToValidate="txtCampaignName">Please provide a valid Campaign Name</asp:requiredfieldvalidator></TD>
																	</TR>
																	<TR>
																		<TD width="20%">Subject of Mail:</TD>
																		<TD width="78%"><asp:textbox id="txtSubject" class="txtbox" runat="server" Width="400"></asp:textbox><BR>
																			<asp:requiredfieldvalidator id="rfvSubject" runat="server" Display="Dynamic" ControlToValidate="txtSubject"
																				ErrorMessage="RequiredFieldValidator">Please provide a Mail Subject</asp:requiredfieldvalidator></TD>
																	</TR>
																	<TR>
																		<TD width="20%"></TD>
																		<TD width="78%"><FONT size="+0"><asp:button id="btnNext" class="button" runat="server" Text="Next"></asp:button>&nbsp;
																				<asp:button id="btnUpdate" runat="server" class="button" Text="Update" Visible="False"></asp:button><asp:textbox id="txtCampaignId" runat="server" Visible="False"></asp:textbox></FONT></TD>
																	</TR>
																</TABLE>
																<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
																	<TR>
																		<TD colSpan="3"></TD>
																	</TR>
																	<TR>
																		<TD colSpan="3"><asp:datagrid id="dgCampaign" CssClass="txt" runat="server" Width="100%" ForeColor="Black" CellPadding="4"	BackColor="White" BorderWidth="1px" BorderStyle="solid" BorderColor="#AACCFF" AutoGenerateColumns="False">
																				<FooterStyle BackColor="#CCCC99"></FooterStyle>
																				<SelectedItemStyle Font-Bold="True" ForeColor="#103352" BackColor="#C1E1FF"></SelectedItemStyle>
																				<AlternatingItemStyle BackColor="#F0F6FF"></AlternatingItemStyle>
																				<ItemStyle Wrap="False" BackColor="#DEEFFF"></ItemStyle>
																				<HeaderStyle Font-Bold="True" Height="30px" CssClass="gridhead"></HeaderStyle>
																				<Columns>
																					<asp:TemplateColumn HeaderText="Name">
																						<ItemTemplate>
																							<asp:Label id="lblCampaign" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.CampaignName") %>'>
																							</asp:Label>
																						</ItemTemplate>
																					</asp:TemplateColumn>
																					<asp:TemplateColumn HeaderText="Subject">
																						<ItemTemplate>
																							<asp:Label id="lblSubject" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Subject") %>'>
																							</asp:Label>
																						</ItemTemplate>
																					</asp:TemplateColumn>
																					<asp:TemplateColumn HeaderText="Edit/ Delete">
																						<ItemTemplate>
																							<asp:ImageButton id="ibtnEdit" runat="server" ImageUrl="..\images\edit.gif" CausesValidation="False"
																								AlternateText="Edit" CommandName="Edit"></asp:ImageButton>&nbsp;
																							<asp:ImageButton id="ibtnDelete" runat="server" ImageUrl="..\images\delete.gif" CausesValidation="False"
																								AlternateText="Delete" CommandName="Delete"></asp:ImageButton>
																						</ItemTemplate>
																					</asp:TemplateColumn>
																					<asp:TemplateColumn Visible="False" HeaderText="ID">
																						<ItemTemplate>
																							<asp:Label id="lblCampaignId" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.CampaignID") %>'>
																							</asp:Label>
																						</ItemTemplate>
																					</asp:TemplateColumn>
																				</Columns>
																				<PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#F7F7DE" Mode="NumericPages"></PagerStyle>
																			</asp:datagrid></TD>
																	</TR>
																	<TR>
																		<TD colSpan="3"></TD>
																	</TR>
																</TABLE>
															</TD>
														</TR>
														<TR>
															<TD id="tdselectTemplate" colSpan="3" runat="server">
																<TABLE class="txt" id="tblStep1" cellSpacing="4" cellPadding="4" width="100%" border="0">
																	<TR>
																		<TD width="220" height="25" class="hdnnews">Select Template</TD>
																		<TD width="450"></TD>
																		<TD width="402"></TD>
																	</TR>
																	<TR>
																		<TD height="22" style="BORDER-RIGHT: #b6d5f1 1px solid; BORDER-TOP: #b6d5f1 1px solid; BORDER-LEFT: #b6d5f1 1px solid; BORDER-BOTTOM: #b6d5f1 1px solid"
																			background="../images/bg_buttons.gif">
																			<b>Category</b></TD>
																		<TD bordercolor="#b6d5f1" style="BORDER-RIGHT: #b6d5f1 1px solid; BORDER-TOP: #b6d5f1 1px solid; BORDER-LEFT: #b6d5f1 1px solid; BORDER-BOTTOM: #b6d5f1 1px solid"
																			background="../images/bg_buttons.gif">
																			<b>Templates</b></TD>
																		<TD bordercolor="#b6d5f1" style="BORDER-RIGHT: #b6d5f1 1px solid; BORDER-TOP: #b6d5f1 1px solid; BORDER-LEFT: #b6d5f1 1px solid; BORDER-BOTTOM: #b6d5f1 1px solid"
																			background="../images/bg_buttons.gif">
																			<b>Preview</b></TD>
																	</TR>
																	<TR>
																		<TD valign="top" style="BORDER-RIGHT: #b6d5f1 1px solid; BORDER-TOP: #b6d5f1 1px solid; BORDER-LEFT: #b6d5f1 1px solid; BORDER-BOTTOM: #b6d5f1 1px solid"
																			bordercolor="#b6d5f1" bgcolor="#f0f6ff"><asp:listbox id="lstCategory" runat="server" DataValueField="CategoryID" DataTextField="CategoryName"
																				AutoPostBack="True"></asp:listbox><br>
																			<asp:requiredfieldvalidator id="rfvCategory" Display="Dynamic" runat="server" ControlToValidate="lstCategory"
																				ErrorMessage="Please select a Category">*</asp:requiredfieldvalidator></TD>
																		<TD valign="top" style="BORDER-RIGHT: #b6d5f1 1px solid; BORDER-TOP: #b6d5f1 1px solid; BORDER-LEFT: #b6d5f1 1px solid; BORDER-BOTTOM: #b6d5f1 1px solid"
																			bordercolor="#b6d5f1" bgcolor="#f0f6ff"><asp:listbox id="lstTemplate" runat="server" DataValueField="TemplateID" DataTextField="TemplateName"
																				AutoPostBack="True"></asp:listbox><BR>
																			<asp:requiredfieldvalidator id="rfvTemplate" runat="server" Display="Dynamic" ControlToValidate="lstTemplate"
																				ErrorMessage="Please select a Template">*</asp:requiredfieldvalidator></TD>
																		<TD align="center" style="BORDER-RIGHT: #b6d5f1 1px solid; BORDER-TOP: #b6d5f1 1px solid; BORDER-LEFT: #b6d5f1 1px solid; BORDER-BOTTOM: #b6d5f1 1px solid"
																			bordercolor="#b6d5f1" bgcolor="#f0f6ff"><asp:Image ID="Image1" ImageAlign="Middle" runat="server" ImageUrl="../images/noimage.gif"></asp:Image></TD>
																	</TR>
																	<TR>
																		<TD></TD>
																		<TD></TD>
																		<TD></TD>
																	</TR>
																	<TR>
																		<TD><asp:Button CssClass="button" ID="btnBack" runat="server" Text="Back"></asp:Button>
																			<asp:Button CssClass="button" ID="btnCancel" runat="server" Text="Cancel"></asp:Button></TD>
																		<TD>&nbsp;</TD>
																		<TD align="right"><asp:Button ID="btnSaveTemplate" runat="server" Text="Save and Next >>" CssClass="button" CausesValidation="False"></asp:Button></TD>
																	</TR>
																</TABLE>
															</TD>
														</TR>
														<TR>
															<TD id="tdFooter" colSpan="3" runat="server"></TD>
														</TR>
														<TR>
															<TD colSpan="3"></TD>
														</TR>
														<TR>
															<TD></TD>
															<TD></TD>
															<TD></TD>
														</TR>
													</TABLE>
												</TD>
											</TR>
										</TABLE>
									</DIV>
								</TD>
							</TR>
							<TR>
								<TD>&nbsp;
								</TD>
							</TR>
						</TABLE>
					</td>
				</tr>
				<tr>
					<td>
						<table id="table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<tr>
								<td><map name="FPMap0"><area shape="RECT" coords="554,5,589,22" href="http://www.smartphi.com/"><area shape="RECT" coords="612,5,647,22" href="help.aspx"><area shape="RECT" coords="672,5,699,21" href="faq.aspx"></map><IMG height="27" alt="" src="../images/footer.jpg" width="701" useMap="#FPMap0" border="0"></td>
							</tr>
							<tr>
								<td><IMG height="49" alt="" src="../images/copyright.jpg" width="701"></td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
