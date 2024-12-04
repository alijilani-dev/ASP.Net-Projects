<%@ Register TagPrefix="uc1" TagName="Top" Src="Top.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Finish.aspx.vb" Inherits="Smartphi.Finish" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Finish</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../smart.css" type="text/css" rel="stylesheet">
		<script language="javascript">
		function GetDate() 
		{
		var dd = document.getElementById("ddlDay").value;
		var mm =document.getElementById("ddlMonth").value;
		var yy = document.getElementById("ddlYear").value;
		var hh = document.getElementById("ddlHour").value;
		var min = document.getElementById("ddlMin").value;
		
		var txtDate =  "" + ((mm < 10) ? "0" : "") + mm + "/" + ((dd < 10) ? "0" : "") + dd + "/" +  yy + " " + hh + ":" + min;
		
		document.getElementById("txtValidDate").value = txtDate;
//		window.alert(txtDate);
		}
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout" background="../images/bg_pg.jpg">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Template" style="Z-INDEX: 103; LEFT: 128px; POSITION: absolute; TOP: 0px" cellSpacing="0"
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
													<TABLE id="table9" cellSpacing="0" cellPadding="0" width="100%" class="txt" bgColor="#d2e1f1" height="22" border="0">
														<TR>
															<TD>&nbsp;&nbsp;&nbsp;&nbsp;
																<asp:HyperLink id="hlnkTrackRpt" runat="server" NavigateUrl="Reports.aspx?module=1">Track Report</asp:HyperLink></TD>
														</TR>
													</TABLE>
												</TD>
											</TR>
											<TR>
												<TD style="BORDER-RIGHT: #d2e1f1 1px solid; BORDER-TOP: #d2e1f1 1px solid; BORDER-LEFT: #d2e1f1 1px solid; BORDER-BOTTOM: #d2e1f1 1px solid">
													<TABLE id="Table3" cellSpacing="1" cellPadding="1" width="100%" border="0" runat="server">
														<TR>
															<TD colSpan="2">
																<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="0">
																	<TR>
																		<TD style="WIDTH: 13px"></TD>
																		<TD>
																			<asp:radiobutton id="rdoTest" runat="server" Text="Test campaign" Checked="True" GroupName="grp1"></asp:radiobutton></TD>
																	</TR>
																	<TR>
																		<TD style="WIDTH: 13px"></TD>
																		<TD>
																			<asp:radiobutton id="rdoSchedule" runat="server" Text="Schedule campaign" GroupName="grp1"></asp:radiobutton></TD>
																	</TR>
																	<TR>
																		<TD style="WIDTH: 13px"></TD>
																		<TD>
																			<asp:button id="btnNext" runat="server" CssClass="button" Text="Next" CausesValidation="False" Width="72px"></asp:button></TD>
																	</TR>
																	<TR>
																		<TD style="WIDTH: 13px"></TD>
																		<TD></TD>
																	</TR>
																	<TR>
																		<TD style="WIDTH: 13px"></TD>
																		<TD></TD>
																	</TR>
																</TABLE>
																<asp:Label id="lblConfirm" runat="server" Visible="False"></asp:Label>
																<BR>
																<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
																	<TR>
																		<TD id="tdContent" runat="server">
																			<table id="tblSchedule" cellspacing="3" cellpadding="3" width="100%" border="0" runat="server"
																					visible="false">
                                                                              <tr>
                                                                                <td style="WIDTH: 197px" class="hdnnews">Schedule the campaign</td>
                                                                                <td></td>
                                                                              </tr>
                                                                              <tr>
                                                                                <td style="WIDTH: 197px; HEIGHT: 16px" valign="top"><b>Schedule Date:</b></td>
                                                                                <td style="HEIGHT: 16px"><asp:DropDownList ID="ddlMonth" runat="server"></asp:DropDownList>
                                                                                    <asp:DropDownList ID="ddlDay" runat="server" Width="48px"></asp:DropDownList>
                                                                                    <asp:DropDownList ID="ddlYear" runat="server"></asp:DropDownList></td>
                                                                              </tr>
                                                                              <tr>
                                                                                <td style="WIDTH: 197px" valign="top"><b>Schedule Time:</b></td>
                                                                                <td><asp:DropDownList ID="ddlHour" runat="server">
                                                                                    <asp:ListItem Value="00">0</asp:ListItem>
                                                                                    <asp:ListItem Value="01">1</asp:ListItem>
                                                                                    <asp:ListItem Value="02">2</asp:ListItem>
                                                                                    <asp:ListItem Value="03">3</asp:ListItem>
                                                                                    <asp:ListItem Value="04">4</asp:ListItem>
                                                                                    <asp:ListItem Value="05">5</asp:ListItem>
                                                                                    <asp:ListItem Value="06">6</asp:ListItem>
                                                                                    <asp:ListItem Value="07">7</asp:ListItem>
                                                                                    <asp:ListItem Value="08">8</asp:ListItem>
                                                                                    <asp:ListItem Value="09">9</asp:ListItem>
                                                                                    <asp:ListItem Value="10">10</asp:ListItem>
                                                                                    <asp:ListItem Value="11">11</asp:ListItem>
                                                                                    <asp:ListItem Value="12">12</asp:ListItem>
                                                                                    <asp:ListItem Value="13">13</asp:ListItem>
                                                                                    <asp:ListItem Value="14">14</asp:ListItem>
                                                                                    <asp:ListItem Value="15">15</asp:ListItem>
                                                                                    <asp:ListItem Value="16">16</asp:ListItem>
                                                                                    <asp:ListItem Value="17">17</asp:ListItem>
                                                                                    <asp:ListItem Value="18">18</asp:ListItem>
                                                                                    <asp:ListItem Value="19">19</asp:ListItem>
                                                                                    <asp:ListItem Value="20">20</asp:ListItem>
                                                                                    <asp:ListItem Value="21">21</asp:ListItem>
                                                                                    <asp:ListItem Value="22">22</asp:ListItem>
                                                                                    <asp:ListItem Value="23">23</asp:ListItem>
                                                                                  </asp:DropDownList>
                                                                                    <asp:DropDownList ID="ddlMin" runat="server" Width="48px">
                                                                                      <asp:ListItem Value="00">0</asp:ListItem>
                                                                                      <asp:ListItem Value="15">15</asp:ListItem>
                                                                                      <asp:ListItem Value="30">30</asp:ListItem>
                                                                                      <asp:ListItem Value="45">45</asp:ListItem>
                                                                                    </asp:DropDownList>
                                                                                    <asp:TextBox ID="txtValidDate" runat="server"></asp:TextBox>
                                                                                    <asp:RegularExpressionValidator ID="revDate" runat="server" ValidationExpression="^(([0-2]\d|[3][0-1])\/([0]\d|[1][0-2])\/[2][0]\d{2})$|^(([0-2]\d|[3][0-1])\/([0]\d|[1][0-2])\/[2][0]\d{2}\s([0-1]\d|[2][0-3])\:[0-5]\d)$"
																								ErrorMessage="Invalid date, Please try again" ControlToValidate="txtValidDate"></asp:RegularExpressionValidator></td>
                                                                              </tr>
                                                                              <tr>
                                                                                <td style="WIDTH: 197px" valign="top"><b>Select Group:</b></td>
                                                                                <td><asp:ListBox ID="lstGroup" runat="server" Width="152px" SelectionMode="Multiple" DataTextField="GroupName"
																								DataValueField="GroupID"></asp:ListBox>
                                                                                    <asp:DropDownList ID="ddlGroupName" runat="server" Width="128px" AutoPostBack="True" DataTextField="GroupName"
																								DataValueField="GroupID" Visible="False"></asp:DropDownList></td>
                                                                              </tr>
                                                                              <tr>
                                                                                <td style="WIDTH: 197px"></td>
                                                                                <td></td>
                                                                              </tr>
                                                                              <tr>
                                                                                <td style="WIDTH: 197px"></td>
                                                                                <td><asp:Button ID="btnSchedule" CssClass="button" runat="server" Text="Make Schedule"></asp:Button></td>
                                                                              </tr>
                                                                              <tr>
                                                                                <td style="WIDTH: 197px"></td>
                                                                                <td></td>
                                                                              </tr>
                                                                            </table>
																			<P>
																		  </P>
<TABLE id="tblTest" cellSpacing="3" cellPadding="3" width="100%" border="0" runat="server"
																				visible="false">
																				<TR>
																					<TD style="WIDTH: 197px" class="hdnnews">Test the campaign</TD>
																					<TD></TD>
																				</TR>
																				<TR>
																					<TD style="WIDTH: 197px" valign="top"><b>Test email id1*:</b></TD>
																					<TD>
																						<asp:textbox class="txtbox" id="txtEmailID1" runat="server"></asp:textbox>
																						<asp:requiredfieldvalidator id="rfvEmailID1" runat="server" ErrorMessage="Please provide atleast one email id to test the created campaign"
																							ControlToValidate="txtEmailID1" Display="Dynamic"></asp:requiredfieldvalidator></TD>
																				</TR>
																				<TR>
																					<TD style="WIDTH: 197px" valign="top"><b>Test email id2:</b></TD>
																					<TD>
																						<asp:textbox class="txtbox" id="txtEmailID2" runat="server"></asp:textbox></TD>
																				</TR>
																				<TR>
																					<TD style="WIDTH: 197px" valign="top"><b>Test email id3:</b></TD>
																					<TD>
																						<asp:textbox class="txtbox" id="txtEmailID3" runat="server"></asp:textbox></TD>
																				</TR>
																				<TR>
																					<TD style="WIDTH: 197px" valign="top"></TD>
																					<TD>
																						<asp:button id="btnTest" CssClass="button" runat="server" Text="Test now"></asp:button></TD>
																				</TR>
																		  </TABLE>																	  </TD>
																	</TR>
																</TABLE>
															</TD>
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
					</TD>
				</TR>
				<TR>
					<TD>
						<TABLE id="table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD><MAP name="FPMap0"><AREA shape="RECT" coords="554,5,589,22" href="http://www.smartphi.com/"><AREA shape="RECT" coords="612,5,647,22" href="help.aspx"><AREA shape="RECT" coords="672,5,699,21" href="faq.aspx"></MAP><IMG height="27" alt="" src="../images/footer.jpg" width="701" useMap="#FPMap0" border="0"></TD>
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