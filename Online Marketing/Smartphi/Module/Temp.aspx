<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Temp.aspx.vb" Inherits="Smartphi.Temp"%>
<%@ Register TagPrefix="uc1" TagName="Top" Src="Top.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Template</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<script language="javascript" type="text/javascript">
		
		function GetPopup(params) 
		{
			var dialogInputArg = new Array("Param1", "Param2");
			var dlgSettings = "center:yes;help:No;resizable:No;status:No;scroll:Yes;dialogWidth=800px;dialogHeight=600px";
			var argAdrBk = window.showModalDialog("EditContents.aspx?Mode=Preview&" + params , dialogInputArg, dlgSettings);
			
			if (argAdrBk == null)
			{
				/*window.alert("Please select a recipient again.")*/
			}
			else
			{
			
			}
		}
		
		function ShowPreview() 
		{
			var ParmtxthCampaignID = document.getElementById("EditTemplate1_txthCampaignID").value;
			var ParmtxthTemplateID = document.getElementById("EditTemplate1_txthTemplateID").value;
			var dialogInputArg = new Array(ParmtxthCampaignID, ParmtxthTemplateID);
			var dlgSettings = "center:yes;help:No;resizable:No;status:No;scroll:Yes;dialogWidth=800px;dialogHeight=600px";
			var argAdrBk = window.showModalDialog("Preview.aspx?Mode=Preview", dialogInputArg, dlgSettings);
			
			if (argAdrBk == null)
			{
				/*window.alert("Problem parsing template.");*/
			}
			else
			{
			
			}
		}

		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout" background="../images/bg_pg.jpg" onload="FP_preloadImgs(/*url*/'../images/btn_abt_ovr.jpg', /*url*/'../images/btn_feature_ovr.jpg', /*url*/'../images/btn_login_ovr.jpg', /*url*/'../images/btn_demo_ovr.jpg', /*url*/'../images/btn_cntct_ovr.jpg', /*url*/'../images/btn_managecontacts_ovr.jpg', /*url*/'../images/btn_campaign_ovr.jpg', /*url*/'../images/btn_reports_ovr.jpg', /*url*/'../images/btn_myprofile_ovr.jpg')"
		bottomMargin="0" leftMargin="0" topMargin="0" rightMargin="0">
		<form id="frmPreview" method="post" runat="server">
			<table border="0" id="Template" runat="server" cellspacing="0" cellpadding="0" width="701"
				bgcolor="#ffffff" align="center" background="../images/bg_pg.jpg">
				<tr>
					<td style="HEIGHT: 127px">
						<uc1:Top id="Top1" runat="server"></uc1:Top>
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
																<TD align="center"><A href="javascript:;"><IMG id="img6" onmouseover="FP_swapImg(1,1,/*id*/'img6',/*url*/'../images/btn_managecontacts_ovr.jpg');"
																			onmouseout="FP_swapImgRestore('../images/btn_managecontacts.jpg')" src="../images/btn_managecontacts.jpg" border="0"></A></TD>
																<TD align="center"><A href="javascript:;"><IMG id="img7" onmouseover="FP_swapImg(1,1,/*id*/'img7',/*url*/'../images/btn_campaign_ovr.jpg');"
																			onmouseout="FP_swapImgRestore()" src="../images/btn_campaign.jpg" border="0"></A></TD>
																<TD align="center"><A href="javascript:;"><IMG id="img8" onmouseover="FP_swapImg(1,1,/*id*/'img8',/*url*/'../images/btn_reports_ovr.jpg');"
																			onmouseout="FP_swapImgRestore()" src="../images/btn_reports.jpg" border="0"></A></TD>
																<TD align="center"><A href="javascript:;"><IMG id="img9" onmouseover="FP_swapImg(1,1,/*id*/'img9',/*url*/'../images/btn_myprofile_ovr.jpg');"
																			onmouseout="FP_swapImgRestore(); FP_swapImgRestore()" src="../images/btn_myprofile.jpg" border="0"></A></TD>
															</TR>
														</TABLE>
													</DIV>
												</TD>
											</TR>
											<TR>
												<TD>
													<TABLE id="table9" cellSpacing="0" cellPadding="0" width="100%" bgColor="#ffdfe4" border="0">
														<TR>
															<TD>&nbsp;</TD>
														</TR>
													</TABLE>
												</TD>
											</TR>
											<TR>
												<TD>
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
										<area href="http://www.smartphi.com/" shape="RECT" coords="554,5,589,22">
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
