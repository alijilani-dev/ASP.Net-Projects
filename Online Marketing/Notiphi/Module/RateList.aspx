<%@ Page Language="vb" AutoEventWireup="false" Codebehind="RateList.aspx.vb" Inherits="Notiphi.RateList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Template</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../Notiphi.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="GridLayout" background="../images/bg_pg.jpg" onload="FP_preloadImgs(/*url*/'../images/btn_abt_ovr.jpg', /*url*/'../images/btn_feature_ovr.jpg', /*url*/'../images/btn_login_ovr.jpg', /*url*/'../images/btn_demo_ovr.jpg', /*url*/'../images/btn_cntct_ovr.jpg', /*url*/'../images/btn_managecontacts_ovr.jpg', /*url*/'../images/btn_campaign_ovr.jpg', /*url*/'../images/btn_reports_ovr.jpg', /*url*/'../images/btn_myprofile_ovr.jpg')"
		bottomMargin="0" leftMargin="0" topMargin="0" rightMargin="0">
		<form id="frmPreview" method="post" runat="server">
			<table border="0" id="Template" runat="server" cellspacing="0" cellpadding="0" width="701"
				bgcolor="#ffffff" align="center" background="../images/bg_pg.jpg">
				<tr>
					<td style="HEIGHT: 127px">
					</td>
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
																<TD align="center"><A href="Group.aspx"><IMG id="img6" onmouseover="FP_swapImg(1,1,/*id*/'img6',/*url*/'../images/btn_managecontacts_ovr.jpg');"
																			onmouseout="FP_swapImgRestore('../images/btn_managecontacts.jpg')" src="../images/btn_managecontacts_ovr.jpg" border="0"></A></TD>
																<TD align="center"><A href="Campaign.aspx"><IMG id="img7" onmouseover="FP_swapImg(1,1,/*id*/'img7',/*url*/'../images/btn_campaign_ovr.jpg');"
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
													<TABLE class="txt" bgColor="#d2e1f1" height="22" id="table9" cellSpacing="0" cellPadding="0"
														width="100%" border="0">
														<TR>
															<TD>&nbsp;<img border="0" src="../images/bullet.gif" width="5" height="9">
																<asp:HyperLink id="hlnkManageGroup" runat="server" NavigateUrl="Group.aspx?module=1">Manage Group</asp:HyperLink>&nbsp;&nbsp;<img border="0" src="../images/bullet.gif" width="5" height="9">
																<asp:HyperLink id="hlnkManageContact" runat="server" NavigateUrl="Group.aspx?module=2">Manage Contacts</asp:HyperLink>
															</TD>
														</TR>
													</TABLE>
												</TD>
											</TR>
											<TR>
												<TD>
												</TD>
											</TR>
											<TR>
												<TD style="BORDER-RIGHT: #d2e1f1 1px solid; BORDER-TOP: #d2e1f1 1px solid; BORDER-LEFT: #d2e1f1 1px solid; BORDER-BOTTOM: #d2e1f1 1px solid">
													<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="0" runat="server">
														<TR>
															<TD id="tdContent" colSpan="2" runat="server">
																<uc1:Purchase id="Purchase1" runat="server"></uc1:Purchase></UC1:PURCHASE></TD>
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
								<TD>&nbsp;
								</TD>
							</TR>
						</TABLE>
					</td>
				</tr>
				<tr>
					<td>
						<table border="0" width="100%" id="table5" cellspacing="0" cellpadding="0">
							<tr>
								<td>
									<map name="FPMap0">
										<area href="http://www.Notiphi.com/" shape="RECT" coords="554,5,589,22">
										<area href="help.aspx" shape="RECT" coords="612,5,647,22">
										<area href="faq.aspx" shape="RECT" coords="672,5,699,21">
									</map><img src="../images/footer.jpg" width="701" height="27" border="0" alt="" usemap="#FPMap0"></td>
							</tr>
							<tr>
								<td>
									<img src="../images/copyright.jpg" width="701" height="49" alt=""></td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
