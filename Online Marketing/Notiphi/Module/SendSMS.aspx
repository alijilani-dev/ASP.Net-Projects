<%@ Register TagPrefix="uc1" TagName="Top" Src="Top.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="SendSMS.aspx.vb" Inherits="Notiphi.SendSMS"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>SendSMS</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<script language="javascript">
	<!--				
		function calcCharLeft(f) {
				
			var lnTxt, lnTA, lnTotal;
			var intmaxLength;
			var charleft;	
			var intCredit;		
			intmaxLength = 160;			
			lnTxt = 0;
			lnTA = 0;
			lnTotal = 0;			
			lnTA = document.frmSMS.txtMessage.value.length;
			lnTotal = lnTA; 			
			supportsKeys = true;
			clipped = false;			
			if (lnTotal > intmaxLength) {
				if (f == 'TA') {
					document.frmSMS.txtMessage.value = document.frmSMS.txtMessage.value.substring(0, intmaxLength - lnTxt);
				}
				
				charleft = 0;
				clipped = true;
			} else {
				charleft = intmaxLength - lnTotal;
			}				
			
			
			document.frmSMS.txtChrLeft.value = charleft;	
			return clipped;
		}		
	//-->
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="frmSMS" method="post" runat="server">
			<TABLE id="Template" style="Z-INDEX: 102; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="701" align="center" bgColor="#ffffff" background="../images/bg_pg.jpg"
				border="0" runat="server">
				<TR>
					<TD style="HEIGHT: 127px">
						<uc1:Top id="Top1" runat="server"></uc1:Top></TD>
				</TR>
				<TR id="Middle" runat="server">
					<TD style="BORDER-RIGHT: #dedede 1px solid; BORDER-LEFT: #dedede 1px solid"><TABLE id="table6" cellSpacing="4" cellPadding="4" width="100%" border="0">
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
																<TD align="center"><A href="Group.aspx"><IMG id="img6" onmouseover="FP_swapImg(1,1,/*id*/'img6',/*url*/'../images/btn_managecontacts_ovr.jpg');"
																			onmouseout="FP_swapImgRestore('../images/btn_managecontacts.jpg')" src="../images/btn_managecontacts_ovr.jpg" border="0"></A></TD>
																<TD align="center"><A href="SendSMS.aspx"><IMG id="img7" onmouseover="FP_swapImg(1,1,/*id*/'img7',/*url*/'../images/btn_campaign_ovr.jpg');"
																			onmouseout="FP_swapImgRestore()" src="../images/btn_campaign.jpg" border="0"></A></TD>
																<TD align="center"><A href="Reports.aspx"><IMG id="img8" onmouseover="FP_swapImg(1,1,/*id*/'img8',/*url*/'../images/btn_reports_ovr.jpg');"
																			onmouseout="FP_swapImgRestore()" src="../images/btn_reports.jpg" border="0"></A></TD>
																<TD align="center"><A href="MyProfile.aspx"><IMG id="img9" onmouseover="FP_swapImg(1,1,/*id*/'img9',/*url*/'../images/btn_myprofile_ovr.jpg');"
																			onmouseout="FP_swapImgRestore(); FP_swapImgRestore()" src="../images/btn_myprofile.jpg" border="0"></A></TD>
															</TR>
														</TABLE>
													</DIV>
												</TD>
											</TR>
											<TR>
												<TD>
													<TABLE class="txt" id="table9" height="22" cellSpacing="0" cellPadding="0" width="100%"
														bgColor="#d2e1f1" border="0">
														<TR>
															<TD>&nbsp;<IMG height="9" src="../images/bullet.gif" width="5" border="0">
																<asp:HyperLink id="hlnkSendSMS" runat="server" NavigateUrl="Group.aspx?module=2">Send Messages to Individuals</asp:HyperLink>&nbsp;&nbsp;<IMG height="9" src="../images/bullet.gif" width="5" border="0">
																<asp:HyperLink id="hlnkManageContact" runat="server" NavigateUrl="Group.aspx?module=2">Send Messages to a Group</asp:HyperLink></TD>
														</TR>
													</TABLE>
												</TD>
											</TR>
											<TR>
												<TD></TD>
											</TR>
											<TR>
												<TD style="BORDER-RIGHT: #d2e1f1 1px solid; BORDER-TOP: #d2e1f1 1px solid; BORDER-LEFT: #d2e1f1 1px solid; BORDER-BOTTOM: #d2e1f1 1px solid">
													<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="0" runat="server">
														<TR>
															<TD id="tdContent" colSpan="2" runat="server">
																<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
																	<TR>
																		<TD style="WIDTH: 95px" vAlign="top">Mobile Number</TD>
																		<TD>
																			<asp:TextBox id="txtMobile" runat="server" CssClass="txtbox"></asp:TextBox>
																			<asp:requiredfieldvalidator id="rfv1" tabIndex="1" runat="server" ErrorMessage="Please provide mobile no." Display="Dynamic"
																				ControlToValidate="txtMobile"></asp:requiredfieldvalidator><BR>
																			<asp:HyperLink id="hlnkFromPhoneBook" runat="server" NavigateUrl="Group.aspx?module=2">From PhoneBook</asp:HyperLink></TD>
																		<TD>e.g. 97150XXXXXXX (971 is a country code, without leading zeros)</TD>
																	</TR>
																	<TR>
																		<TD style="WIDTH: 95px">Message</TD>
																		<TD>
																			<asp:TextBox id="txtMessage" runat="server" Columns="40" TextMode="MultiLine" Rows="5" CssClass="txtbox"></asp:TextBox><BR>
																			<asp:requiredfieldvalidator id="Requiredfieldvalidator1" tabIndex="1" runat="server" ErrorMessage="Please provide Message to send."
																				Display="Dynamic" ControlToValidate="txtMessage"></asp:requiredfieldvalidator></TD>
																		<TD></TD>
																	</TR>
																	<TR>
																		<TD style="WIDTH: 95px"></TD>
																		<TD>Characters left&nbsp;<INPUT disabled size="3" value="160" name="txtChrLeft" class="txtbox"></TD>
																		<TD></TD>
																	</TR>
																	<TR>
																		<TD style="WIDTH: 95px">Sender Name</TD>
																		<TD>
																			<asp:TextBox id="txtSender" runat="server" CssClass="txtbox"></asp:TextBox><BR>
																			<asp:requiredfieldvalidator id="Requiredfieldvalidator2" tabIndex="1" runat="server" ErrorMessage="Please provide sender name."
																				Display="Dynamic" ControlToValidate="txtSender"></asp:requiredfieldvalidator></TD>
																		<TD></TD>
																	</TR>
																	<TR>
																		<TD style="WIDTH: 95px"></TD>
																		<TD>
																			<asp:CheckBox id="chkFlash" runat="server" Text="Send as Flash Message"></asp:CheckBox></TD>
																		<TD></TD>
																	</TR>
																	<TR>
																		<TD style="WIDTH: 95px"></TD>
																		<TD>
																			<asp:Button id="btnSubmit" runat="server" Text="Send SMS" CssClass="button"></asp:Button>
																			<asp:Button id="Button1" runat="server" Text="Button"></asp:Button></TD>
																		<TD></TD>
																	</TR>
																</TABLE>
															</TD>
														</TR>
														<TR>
															<TD colSpan="2"></TD>
														</TR>
													</TABLE>
												</TD>
											</TR>
										</TABLE>
									</DIV>
								</TD>
							</TR>
							<TR>
								<TD>
								</TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD>
						<TABLE id="table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD><MAP name="FPMap0"><AREA shape="RECT" coords="554,5,589,22" href="http://www.Notiphi.com/"><AREA shape="RECT" coords="612,5,647,22" href="help.aspx"><AREA shape="RECT" coords="672,5,699,21" href="faq.aspx"></MAP><IMG height="27" alt="" src="../images/footer.jpg" width="701" useMap="#FPMap0" border="0"></TD>
							</TR>
							<TR>
								<TD><IMG height="49" alt="" src="../images/copyright.jpg" width="701"></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
