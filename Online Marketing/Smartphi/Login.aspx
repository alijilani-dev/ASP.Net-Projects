<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Login.aspx.vb" Inherits="Smartphi.Login" %>
<%@ Register TagPrefix="uc1" TagName="Footer" Src="Module/Footer.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Template</title>
		<meta name="ProgId" content="SharePoint.WebPartPage.Document">
		<meta name="WebPartPageExpansion" content="full">
		<meta http-equiv="Content-Language" content="en-us">
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="smart.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="GridLayout" background="images/bg_pg.jpg" onload="FP_preloadImgs(/*url*/'images/btn_abt_ovr.jpg', /*url*/'images/btn_feature_ovr.jpg', /*url*/'images/btn_login_ovr.jpg', /*url*/'images/btn_demo_ovr.jpg', /*url*/'images/btn_cntct_ovr.jpg', /*url*/'images/btn_managecontacts_ovr.jpg', /*url*/'images/btn_campaign_ovr.jpg', /*url*/'images/btn_reports_ovr.jpg', /*url*/'images/btn_myprofile_ovr.jpg')"
		bottomMargin="0" leftMargin="0" topMargin="0" rightMargin="0">
		<form id="Form1" method="post" runat="server">
			<table border="0" id="Template" runat="server" cellspacing="0" cellpadding="0" width="701"
				bgcolor="#ffffff" align="center" background="images/bg_pg.jpg">
				<tr>
					<td style="HEIGHT: 127px">
						<TABLE id="table2" cellSpacing="0" cellPadding="0" width="100%" border="0" background="images/bg_pg.jpg">
							<TR>
								<TD><A href="http://www.smartphi.com/"><IMG height="101" alt="" src="images//logo.jpg" width="272" border="0"></A></TD>
								<TD><MAP name="FPMap1"><AREA shape="RECT" coords="351,1,427,99" href="contact.aspx"><AREA shape="RECT" coords="271,2,346,99" href="demo.aspx"><AREA shape="RECT" coords="190,3,264,98" href="login.aspx"><AREA shape="RECT" coords="109,4,183,98" href="features.aspx"><AREA shape="RECT" coords="7,4,104,98" href="about_company.aspx"></MAP><IMG height="101" alt="" src="images//top_lnk_img.jpg" width="429" useMap="#FPMap1" border="0"></TD>
							</TR>
							<TR>
								<TD colSpan="2">
									<TABLE id="table3" cellSpacing="0" cellPadding="0" bgColor="#ffffff" border="0">
										<TR>
											<TD><IMG height="27" alt="" src="images//bg_main_lnk.jpg" width="272"></TD>
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
									<DIV align="center">
										&nbsp;<p><asp:Label id="lblInvalid" runat="server" Width="360px">Label</asp:Label></p>
										<div align="center">
											<TABLE BORDER="0" CELLPADDING="0" CELLSPACING="0" WIDTH="312" HEIGHT="171" id="table7">
												<TR>
													<TD ROWSPAN="3" COLSPAN="1" WIDTH="21" HEIGHT="171">
														<IMG NAME="loginbox0" SRC="images/loginbox_1x1.jpg" WIDTH="21" HEIGHT="171" BORDER="0"></TD>
													<TD ROWSPAN="1" COLSPAN="1" WIDTH="272" HEIGHT="47">
														<IMG NAME="loginbox1" SRC="images/loginbox_1x2.jpg" WIDTH="272" HEIGHT="47" BORDER="0"></TD>
													<TD ROWSPAN="3" COLSPAN="1" WIDTH="19" HEIGHT="171">
														<IMG NAME="loginbox2" SRC="images/loginbox_1x3.jpg" WIDTH="19" HEIGHT="171" BORDER="0"></TD>
												</TR>
												<TR>
													<TD ROWSPAN="1" COLSPAN="1" WIDTH="272" HEIGHT="113"><TABLE class="txt" id="Table1" cellSpacing="1" width="100%" border="0">
															<TR>
																<TD valign="middle" width="71">User Name</TD>
																<TD width="194">
																	<asp:TextBox class="txtbox" id="txtUserName" runat="server"></asp:TextBox>
																	<asp:RequiredFieldValidator id="rfvUserName" Display="Dynamic" runat="server" ErrorMessage="Please provide user name"
																		ControlToValidate="txtUserName"></asp:RequiredFieldValidator></TD>
															</TR>
															<TR>
																<TD valign="middle" width="71">Password</TD>
																<TD width="194">
																	<asp:TextBox class="txtbox" id="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
																	<asp:RequiredFieldValidator id="rfvPwd" runat="server" Display="Dynamic" ErrorMessage="Please provide password"
																		ControlToValidate="txtPassword"></asp:RequiredFieldValidator></TD>
															</TR>
															<TR>
																<TD width="71"></TD>
																<TD width="194">
																	<asp:Button id="btnSignIn" runat="server" Text="Sign In"></asp:Button>
																	<br>
																	<asp:HyperLink id="hlnkForgetPwd" runat="server" NavigateUrl="ForgotPassword.aspx">Forgot Password</asp:HyperLink>&nbsp;<br>
																	New user!
																	<asp:HyperLink id="hlnkRegister" runat="server" NavigateUrl="Register.aspx">Register</asp:HyperLink>&nbsp;here.</TD>
															</TR>
														</TABLE>
													</TD>
												</TR>
												<TR>
													<TD ROWSPAN="1" COLSPAN="1" WIDTH="272" HEIGHT="11">
														<IMG NAME="loginbox4" SRC="images/loginbox_3x1.jpg" WIDTH="272" HEIGHT="11" BORDER="0"></TD>
												</TR>
											</TABLE>
										</div>
										<p>&nbsp;</p>
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
						<uc1:Footer id="Footer1" runat="server"></uc1:Footer>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
