<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ForgotPassword.aspx.vb" Inherits="Smartphi.ForgotPassword"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Register</title>
		<meta http-equiv="Content-Language" content="en-us">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="smart.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body bottomMargin="0" leftMargin="0" background="images/bg_pg.jpg" topMargin="0" onload="FP_preloadImgs(/*url*/'images/btn_abt_ovr.jpg', /*url*/'images/btn_feature_ovr.jpg', /*url*/'images/btn_login_ovr.jpg', /*url*/'images/btn_demo_ovr.jpg', /*url*/'images/btn_cntct_ovr.jpg', /*url*/'images/btn_managecontacts_ovr.jpg', /*url*/'images/btn_campaign_ovr.jpg', /*url*/'images/btn_reports_ovr.jpg', /*url*/'images/btn_myprofile_ovr.jpg')"
		rightMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Template" cellSpacing="0" cellPadding="0" width="701" align="center" bgColor="#ffffff"
				background="images/bg_pg.jpg" border="0" runat="server">
				<TR>
					<TD style="HEIGHT: 120px">
						<TABLE id="table2" cellSpacing="0" cellPadding="0" width="100%" background="images/bg_pg.jpg"
							border="0">
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
					</TD>
				</TR>
				<TR id="Middle" runat="server">
					<TD style="BORDER-RIGHT: #dedede 1px solid; BORDER-LEFT: #dedede 1px solid">
						<div align="center"><BR>
							<BR>
							<TABLE class="txt" id="tblPassword" style="BORDER-RIGHT: #aaccff 1px solid; BORDER-TOP: #aaccff 1px solid; BORDER-LEFT: #aaccff 1px solid; BORDER-BOTTOM: #aaccff 1px solid"
								cellSpacing="3" width="500" border="0" runat="server">
								<TR>
									<TD class="gridhead" height="27"><b>Recover&nbsp;Password</b>&nbsp;</TD>
								</TR>
								<TR>
									<TD height="5">
										<div align="center">
											<TABLE class="txt" id="tbMain" cellSpacing="1" width="450" border="0" runat="server">
												<TR>
													<TD width="593" colSpan="2" height="5">&nbsp;</TD>
												</TR>
												<TR>
													<TD class="hdnnews" width="441" colSpan="2">Please provide the following 
														information
														<asp:label id="lblConfirm" runat="server" Visible="False">Label</asp:label></TD>
												</TR>
												<TR>
													<TD vAlign="top" width="265" colSpan="2">Member&nbsp;User Name:<BR>
														<asp:textbox class="txtbox" id="txtUserName" runat="server" Width="200px"></asp:textbox><asp:requiredfieldvalidator id="rfvUserName" runat="server" Display="Dynamic" ErrorMessage="Please provide user name"
															ControlToValidate="txtUserName"></asp:requiredfieldvalidator></TD>
												</TR>
												<TR>
													<TD width="284" colSpan="2"></TD>
												</TR>
												<TR>
													<TD vAlign="top" width="284" colSpan="2">Member Email ID:<BR>
														<asp:textbox class="txtbox" id="txtEmailID" runat="server" Width="200px"></asp:textbox><asp:requiredfieldvalidator id="rfvEmailId" runat="server" Display="Dynamic" ErrorMessage="Please provide email id"
															ControlToValidate="txtEmailID"></asp:requiredfieldvalidator><asp:regularexpressionvalidator id="redEmailId" runat="server" Display="Dynamic" ErrorMessage="Please provide a valid email id"
															ControlToValidate="txtEmailID" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:regularexpressionvalidator></TD>
												</TR>
												<TR>
													<TD vAlign="top" width="593" colSpan="2"></TD>
												</TR>
												<TR>
													<TD width="593" colSpan="2" height="5"></TD>
												</TR>
												<TR>
													<TD width="593" colSpan="2"><asp:button id="btnSubmit" runat="server" Text="Get New Password" CssClass="button"></asp:button></TD>
												</TR>
												<TR>
													<TD width="284" colSpan="2">&nbsp;&nbsp;</TD>
												</TR>
											</TABLE>
										</div>
										<TABLE id="tbWelcome" cellSpacing="1" cellPadding="1" width="450" align="center" border="0"
											runat="server">
											<TR>
												<TD id="tdWelcome" runat="server"></TD>
											</TR>
										</TABLE>
									</TD>
								</TR>
							</TABLE>
						</div>
						<BR>
						<TABLE id="tblThanks" cellPadding="2" width="650" border="0" runat="server" align="center">
							<TR>
								<TD style="BORDER-RIGHT: #a5d1fe 1px solid; BORDER-TOP: #a5d1fe 1px solid; BORDER-LEFT: #a5d1fe 1px solid; BORDER-BOTTOM: #a5d1fe 1px solid"
									vAlign="top">
									<TABLE class="txt" id="table40" style="WIDTH: 100%" cellPadding="0" width="637" border="0">
										<TR>
											<TD class="gridhead" height="25">&nbsp;Smartphi.com.</TD>
										</TR>
										<TR>
											<TD>&nbsp;
											</TD>
										</TR>
										<TR>
											<TD style="HEIGHT: 35px">Thank you, your account password is successfully 
												changed&nbsp;to an autogenerated text.&nbsp;You will be receiving an 
												email&nbsp;shortly with your user name and password.</TD>
										</TR>
										<TR>
											<TD>&nbsp;</TD>
										</TR>
										<TR>
											<TD></TD>
										</TR>
									</TABLE>
									<asp:HyperLink id="hlnkLogin" runat="server">Login Page</asp:HyperLink>
								</TD>
							</TR>
						</TABLE>
						<p></p>
					</TD>
				</TR>
				<TR>
					<TD>
						<TABLE id="table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD><MAP name="FPMap0"><AREA shape="RECT" coords="554,5,589,22" href="http://www.smartphi.com/"><AREA shape="RECT" coords="612,5,647,22" href="help.aspx"><AREA shape="RECT" coords="672,5,699,21" href="faq.aspx"></MAP><IMG height="27" alt="" src="images/footer.jpg" width="701" useMap="#FPMap0" border="0"></TD>
							</TR>
							<TR>
								<TD><IMG height="49" alt="" src="images/copyright.jpg" width="701"></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
