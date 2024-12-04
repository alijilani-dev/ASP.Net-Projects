<%@ Page Language="vb" AutoEventWireup="false" Codebehind="MemberArea.aspx.vb" Inherits="Notiphi.MemberArea1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Notiphi</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="Notiphi.css" type="text/css" rel="stylesheet">
		<script language="javascript" src="imanip.js"></script>
		<script language="JavaScript">
<!--
function FP_preloadImgs() {//v1.0
 var d=document,a=arguments; if(!d.FP_imgs) d.FP_imgs=new Array();
 for(var i=0; i<a.length; i++) { d.FP_imgs[i]=new Image; d.FP_imgs[i].src=a[i]; }
}
// -->
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout" background="images/bg_pg.jpg" onload="FP_preloadImgs(/*url*/'images/btn_abt_ovr.jpg', /*url*/'images/btn_feature_ovr.jpg', /*url*/'images/btn_login_ovr.jpg', /*url*/'images/btn_demo_ovr.jpg', /*url*/'images/btn_cntct_ovr.jpg')"
		bottomMargin="0" leftMargin="0" topMargin="0" rightMargin="0">
		<form id="Form1" method="post" runat="server">
			<table border="0" id="Template" runat="server" cellspacing="0" cellpadding="0" width="701"
				bgcolor="#ffffff" align="center" background="images/bg_pg.jpg">
				<tr>
					<td style="HEIGHT: 127px">
						<TABLE id="table2" cellSpacing="0" cellPadding="0" width="100%" border="0" background="images/bg_pg.jpg">
							<TR>
								<TD><A href="http://www.Notiphi.com/"><IMG height="101" alt="" src="images//logo.jpg" width="272" border="0"></A></TD>
								<TD><MAP name="FPMap1"><AREA shape="RECT" coords="351,1,427,99" href="contact.aspx"><AREA shape="RECT" coords="271,2,346,99" href="demo.aspx"><AREA shape="RECT" coords="190,3,264,98" href="login.aspx"><AREA shape="RECT" coords="109,4,183,98" href="features.aspx"><AREA shape="RECT" coords="7,4,104,98" href="about_company.aspx"></MAP><IMG height="101" alt="" src="images//top_lnk_img.jpg" width="429" useMap="#FPMap1" border="0"></TD>
							</TR>
							<TR>
								<TD colSpan="2">
									<TABLE id="table3" cellSpacing="0" cellPadding="0" bgColor="#ffffff" border="0">
										<TR>
											<TD background="images//bg_main_lnk.jpg" width="272">
												<TABLE class="txt" id="tbLogin" runat="server" cellSpacing="1" cellPadding="1" width="100%"
													border="0">
													<TR>
														<TD style="WIDTH: 146px"><font color="#ffffff">Welcome&nbsp;
																<asp:Label id="lblTitle1" runat="server" ForeColor="#ffffff"></asp:Label></font></TD>
														<TD align="center">
															<asp:HyperLink id="HyperLink1" ForeColor="#FFFFFF" runat="server" NavigateUrl="../Login.aspx?mode=logout">Logout</asp:HyperLink></TD>
													</TR>
												</TABLE>
											</TD>
											<TD><A href="about_company.aspx"><IMG id="img1" onmouseover="FP_swapImg(1,1,/*id*/'img1',/*url*/'images/btn_abt_ovr.jpg')"
														onmouseout="FP_swapImgRestore()" height="27" src="images//btn_abt.jpg" width="105" border="0"></A></TD>
											<TD><A href="features.aspx"><IMG id="img2" onmouseover="FP_swapImg(1,1,/*id*/'img2',/*url*/'images/btn_feature_ovr.jpg')"
														onmouseout="FP_swapImgRestore()" height="27" src="images//btn_feature.jpg" width="81" border="0"></A></TD>
											<TD><A href="login.aspx"><IMG id="img3" onmouseover="FP_swapImg(1,1,/*id*/'img3',/*url*/'images/btn_login_ovr.jpg')"
														onmouseout="FP_swapImgRestore()" height="27" src="images//btn_login.jpg" width="81" border="0"></A></TD>
											<TD><A href="demo.aspx"><IMG id="img4" onmouseover="FP_swapImg(1,1,/*id*/'img4',/*url*/'images/btn_demo_ovr.jpg')"
														onmouseout="FP_swapImgRestore()" height="27" src="images//btn_demo.jpg" width="81" border="0"></A></TD>
											<TD><A href="contacts.aspx"><IMG id="img5" onmouseover="FP_swapImg(1,1,/*id*/'img5',/*url*/'images/btn_cntct_ovr.jpg')"
														onmouseout="FP_swapImgRestore()" height="27" src="images//btn_cntct.jpg" width="81" border="0"></A></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
						</TABLE>
					</td>
				</tr>
				<tr id="Middle" runat="server">
					<td style="BORDER-RIGHT: #dedede 1px solid; BORDER-LEFT: #dedede 1px solid">
						<TABLE id="table6" cellSpacing="4" cellPadding="4" width="100%" border="0">
							<TR>
								<TD>
									&nbsp;</TD>
							</TR>
							<TR>
								<TD>
									<div align="center">
										<table border="0" width="680" id="table10" cellspacing="0" cellpadding="0">
											<tr>
												<td width="477">
													<TABLE BORDER="0" CELLPADDING="0" CELLSPACING="0" WIDTH="477" HEIGHT="400" id="table11">
														<TR>
															<TD WIDTH="225" HEIGHT="62" background="images/img_userhome_1x1.jpg">
																<table border="0" width="100%" id="table12" cellspacing="3" cellpadding="3">
																	<tr>
																		<td>
																			<p align="center"><b><font size="2" face="Verdana">Welcome,
																						<asp:Label id="lblTitle" runat="server">Label</asp:Label></font></b></p>
																		</td>
																	</tr>
																</table>
															</TD>
															<TD ROWSPAN="11" COLSPAN="1" WIDTH="252" HEIGHT="400">
																<IMG NAME="img_userhome1" SRC="images/img_userhome_1x2.jpg" WIDTH="252" HEIGHT="400"
																	BORDER="0"></TD>
														</TR>
														<TR>
															<TD ROWSPAN="1" COLSPAN="1" WIDTH="225" HEIGHT="16">
																<IMG NAME="img_userhome2" SRC="images/img_userhome_2x1.jpg" WIDTH="225" HEIGHT="16" BORDER="0"></TD>
														</TR>
														<TR>
															<TD ROWSPAN="1" COLSPAN="1" WIDTH="225" HEIGHT="52">
																<a href="Module/Group.aspx?module=2"><IMG NAME="img_userhome3" SRC="images/img_userhome_3x1.jpg" WIDTH="225" HEIGHT="52" BORDER="0"></a></TD>
														</TR>
														<TR>
															<TD ROWSPAN="1" COLSPAN="1" WIDTH="225" HEIGHT="6">
																<IMG NAME="img_userhome4" SRC="images/img_userhome_4x1.jpg" WIDTH="225" HEIGHT="6" BORDER="0"></TD>
														</TR>
														<TR>
															<TD ROWSPAN="1" COLSPAN="1" WIDTH="225" HEIGHT="52">
																<a href="Module/SendSMS.aspx"><IMG NAME="img_userhome5" SRC="images/img_userhome_5x1.jpg" WIDTH="225" HEIGHT="52" BORDER="0"></a></TD>
														</TR>
														<TR>
															<TD ROWSPAN="1" COLSPAN="1" WIDTH="225" HEIGHT="7">
																<IMG NAME="img_userhome6" SRC="images/img_userhome_6x1.jpg" WIDTH="225" HEIGHT="7" BORDER="0"></TD>
														</TR>
														<TR>
															<TD ROWSPAN="1" COLSPAN="1" WIDTH="225" HEIGHT="52">
																<a href="Module/Reports.aspx?module=1"><IMG NAME="img_userhome7" SRC="images/img_userhome_7x1.jpg" WIDTH="225" HEIGHT="52" BORDER="0"></a></TD>
														</TR>
														<TR>
															<TD ROWSPAN="1" COLSPAN="1" WIDTH="225" HEIGHT="5">
																<IMG NAME="img_userhome8" SRC="images/img_userhome_8x1.jpg" WIDTH="225" HEIGHT="5" BORDER="0"></TD>
														</TR>
														<TR>
															<TD ROWSPAN="1" COLSPAN="1" WIDTH="225" HEIGHT="53">
																<a href="Module/MyProfile.aspx?module=1"><IMG NAME="img_userhome9" SRC="images/img_userhome_9x1.jpg" WIDTH="225" HEIGHT="53" BORDER="0"></a></TD>
														</TR>
														<TR>
															<TD ROWSPAN="1" COLSPAN="1" WIDTH="225" HEIGHT="6">
																<IMG NAME="img_userhome10" SRC="images/img_userhome_10x1.jpg" WIDTH="225" HEIGHT="6"
																	BORDER="0"></TD>
														</TR>
														<TR>
															<TD ROWSPAN="1" COLSPAN="1" WIDTH="225" HEIGHT="89">
																<IMG NAME="img_userhome11" SRC="images/img_userhome_11x1.jpg" WIDTH="225" HEIGHT="89"
																	BORDER="0"></TD>
														</TR>
													</TABLE>
												</td>
												<td width="4">&nbsp;</td>
												<td>
													<div align="center">
														<table border="0" width="100%" id="table13" cellpadding="3" cellspacing="3">
															<tr>
																<td><b><font size="1" face="Verdana">Quick Reports:</font></b></td>
															</tr>
															<tr>
																<td style="BORDER-RIGHT: #e4e4e4 1px solid; BORDER-TOP: #e4e4e4 1px solid; BORDER-LEFT: #e4e4e4 1px solid; BORDER-BOTTOM: #e4e4e4 1px solid"
																	height="100">&nbsp;</td>
															</tr>
															<tr>
																<td><b><font face="Verdana" size="1">Scheduled Campaigns:</font></b></td>
															</tr>
														</table>
														<table border="0" width="100%" id="table14" cellpadding="3" cellspacing="3">
															<tr>
																<td style="BORDER-RIGHT: #e4e4e4 1px solid; BORDER-TOP: #e4e4e4 1px solid; BORDER-LEFT: #e4e4e4 1px solid; BORDER-BOTTOM: #e4e4e4 1px solid"
																	height="100">&nbsp;</td>
															</tr>
														</table>
													</div>
												</td>
											</tr>
										</table>
									</div>
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
						<TABLE id="table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD><MAP name="FPMap0"><AREA shape="RECT" coords="554,5,589,22" href="http://www.Notiphi.com/"><AREA shape="RECT" coords="612,5,647,22" href="help.aspx"><AREA shape="RECT" coords="672,5,699,21" href="faq.aspx"></MAP><IMG height="27" alt="" src="images/footer.jpg" width="701" useMap="#FPMap0" border="0"></TD>
							</TR>
							<TR>
								<TD><IMG height="49" alt="" src="images/copyright.jpg" width="701"></TD>
							</TR>
						</TABLE>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
