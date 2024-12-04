<%@ Register TagPrefix="uc1" TagName="Announcement" Src="Announcement.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Testimonial" Src="Testimonial.ascx" %>
<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Home.ascx.vb" Inherits="Trade.Home1" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<LINK href="Styles.css" type="text/css" rel="stylesheet">
<div align="center">
	<TABLE class="innertxt" id="Table2" cellSpacing="0" cellPadding="0" width="1000" bgColor="#ffffff"
		border="0">
		<TR>
			<TD vAlign="top" width="176" rowSpan="3">
				<table id="table8" cellSpacing="0" cellPadding="0" width="100%" border="0">
					<tr>
						<td vAlign="top">
							<table id="tblLogin" runat="server" style="BORDER-RIGHT: #3f8bd7 1px solid; BORDER-TOP: #3f8bd7 1px solid; BORDER-LEFT: #3f8bd7 1px solid; BORDER-BOTTOM: #3f8bd7 1px solid; BACKGROUND-REPEAT: repeat-x"
								cellSpacing="0" cellPadding="0" width="176" background="../images/login_bg.gif" border="0">
								<tr>
									<td width="3" rowSpan="7"></td>
									<td width="168" colSpan="3" height="3"></td>
									<td width="3" rowSpan="7"></td>
								</tr>
								<tr>
									<td class="boxhdn" bgColor="#3f8bd7" colSpan="3" height="19">&nbsp;Login</td>
								</tr>
								<tr>
									<td width="6" rowSpan="2"></td>
									<td class="normaltext" width="157"><b>User Name:</b><br>
										<asp:textbox id="tbUserName" runat="server" MaxLength="50" CssClass="box" Width="118px"></asp:textbox></td>
									<td width="5" rowSpan="2"></td>
								</tr>
								<tr>
									<td class="normaltext" width="157"><b>Password:</b><br>
										<asp:textbox id="tbPassword" runat="server" MaxLength="50" CssClass="box" TextMode="Password"
											Width="116px"></asp:textbox><A href="javascript:;"></A></td>
								</tr>
								<tr>
									<td width="6"></td>
									<td align="left" colSpan="2">
										<table id="table46" cellSpacing="0" cellPadding="0" width="100%" border="0">
											<tr>
												<td width="131"><A style="FONT-SIZE: 10px" href="../PortalDefault.aspx?Main_Links_ID=25">Register!</A><br>
													<A style="FONT-SIZE: 10px" href="../PortalDefault.aspx?Main_Links_ID=9">Forgot Your 
														Password?</A></td>
												<td><asp:imagebutton id="imgLogin" runat="server" ImageUrl="../images/btn_go.gif"></asp:imagebutton><A href="javascript:;"></A></td>
											</tr>
										</table>
									</td>
								</tr>
								<tr>
									<td colspan="3" height="3"></td>
								</tr>
							</table>
							<TABLE id="tblMembMenu" style="BORDER-RIGHT: #3f8bd7 1px solid; BORDER-TOP: #3f8bd7 1px solid; BORDER-LEFT: #3f8bd7 1px solid; BORDER-BOTTOM: #3f8bd7 1px solid; BACKGROUND-REPEAT: repeat-x"
								cellSpacing="0" cellPadding="0" width="176" background="../images/login_bg.gif" border="0"
								runat="server">
								<TR>
									<TD width="3" rowSpan="6"></TD>
									<TD colSpan="3" height="3"></TD>
									<TD width="3" rowSpan="6"></TD>
								</TR>
								<TR>
									<TD class="boxhdn" bgColor="#3f8bd7" colSpan="3" height="19">&nbsp;Member Menu
									</TD>
								</TR>
								<TR>
									<TD width="2" rowSpan="2"></TD>
									<TD width="163" height="5"></TD>
									<TD width="2" rowSpan="2"></TD>
								</TR>
								<TR>
									<TD width="163" valign="top">
										<asp:DataList ID="DLSublinks" runat="server" EnableViewState="False" valign="middle" Width="100%">
											<itemtemplate>
												&nbsp;&nbsp;
												<asp:HyperLink ID=HyperLink1 runat="server" NavigateUrl='<%# "../PortalDefault.aspx?Main_Links_ID=" &amp; DataBinder.Eval(Container, "DataItem.Main_Links_ID") &amp; "&amp;sub_Links_ID=" &amp; DataBinder.Eval(Container, "DataItem.Sub_Links_ID") %>' Text='<%# DataBinder.Eval(Container, "DataItem.Sub_Link_Name") %>' CssClass="memenu">
												</asp:HyperLink>
											</itemtemplate>
										</asp:DataList></TD>
								</TR>
								<TR>
									<TD align="center" colSpan="3" height="5"></TD>
								</TR>
							</TABLE>
						</td>
					</tr>
					<tr>
						<td vAlign="top" height="4"></td>
					</tr>
					<tr>
						<td vAlign="top">
							<table id="table49" style="BORDER-RIGHT: #3f8bd7 1px solid; BORDER-TOP: #3f8bd7 1px solid; BORDER-LEFT: #3f8bd7 1px solid; BORDER-BOTTOM: #3f8bd7 1px solid; BACKGROUND-REPEAT: repeat-x"
								cellSpacing="0" cellPadding="0" width="176" background="../images/login_bg.gif" border="0">
								<tr>
									<td width="3" rowSpan="6"></td>
									<td width="168" colSpan="3" height="3"></td>
									<td width="3" rowSpan="6"></td>
								</tr>
								<tr>
									<td class="boxhdn" bgColor="#3f8bd7" colSpan="3" height="19">&nbsp;Search</td>
								</tr>
								<tr>
									<td width="6" rowSpan="3" style="HEIGHT: 36px"><IMG height="1" src="../images/empty.gif" width="5"></td>
									<td class="normaltext" width="157">I want to:
										<asp:CheckBox id="chkbuy" runat="server" Text="Buy" Checked="True"></asp:CheckBox>
										<asp:CheckBox id="chkSell" runat="server" Text="Sell" Checked="True"></asp:CheckBox>
									</td>
									<td width="5" rowSpan="3" style="HEIGHT: 36px"><IMG height="1" src="../images/empty.gif" width="5"></td>
								</tr>
								<tr>
									<td class="normaltext" width="157" style="HEIGHT: 40px">Brand:
										<asp:dropdownlist id="ddlBrand" runat="server" CssClass="box" Width="153px" BackColor="#EEF3FF" Font-Bold="true"
											AutoPostBack="True"></asp:dropdownlist></td>
								</tr>
								<tr>
									<td class="normaltext" width="157" style="HEIGHT: 21px">Model:
										<asp:dropdownlist id="ddlModel" runat="server" CssClass="box" Width="152px" BackColor="#EEF3FF"></asp:dropdownlist></td>
								</tr>
								<tr>
									<td width="6"><IMG height="1" src="../images/empty.gif" width="5"></td>
									<td align="left" colSpan="2">
										<table id="table50" cellSpacing="0" cellPadding="0" width="100%" border="0">
											<tr>
												<td width="131" height="25">&nbsp;</td>
												<td>
													<asp:imagebutton id="imgSearch" runat="server" ImageUrl="../images/btn_go.gif" ToolTip="Login now!"></asp:imagebutton><A href="javascript:;"></A></td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td vAlign="top" height="4"></td>
					</tr>
					<tr>
						<td vAlign="top"><TABLE id="table53" style="BORDER-RIGHT: #3f8bd7 1px solid; BORDER-TOP: #3f8bd7 1px solid; BORDER-LEFT: #3f8bd7 1px solid; BORDER-BOTTOM: #3f8bd7 1px solid; BACKGROUND-REPEAT: repeat-x"
								cellSpacing="0" cellPadding="0" width="176" background="../images/bg_cell.gif" border="0">
								<TR>
									<TD width="3" rowSpan="4"></TD>
									<TD width="168" colSpan="3" height="3"></TD>
									<TD width="3" rowSpan="4"></TD>
								</TR>
								<TR>
									<TD class="boxhdn" bgColor="#3f8bd7" colSpan="3" height="19">&nbsp;Top Trading 
										Phones</TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 36px" width="1" rowSpan="2"></TD>
									<TD style="HEIGHT: 36px" vAlign="top" width="160" rowSpan="2"><IFRAME name="I4" align="middle" src="ScrollerPage\Offer.aspx" frameBorder="0" width="166"
											scrolling="no" height="90"></IFRAME>
									</TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 40px" width="1"></TD>
								</TR>
							</TABLE>
						</td>
					</tr>
				</table>
			</TD>
			<TD width="5" rowSpan="3">&nbsp;</TD>
			<TD valign="top">
				<p align="center" valign="top">
					<asp:image id="ImgHome" runat="server" ImageUrl="../images/home_img.jpg"></asp:image></p>
			</TD>
			<TD vAlign="top" width="5" rowSpan="3">&nbsp;</TD>
			<TD vAlign="top" width="176" rowSpan="3">
				<table border="0" width="100%" id="table54" cellspacing="0" cellpadding="0">
					<tr>
						<td>
							<iframe name="I5" src="ScrollerPage\latestmobiles.aspx" frameBorder="0" width="176" height="121"
								scrolling="no"></iframe>
						</td>
					</tr>
					<tr>
						<td height="4"></td>
					</tr>
					<tr>
						<td>
							<iframe name="I6" src="ScrollerPage\NewMember.aspx" frameBorder="0" width="176" height="262"
								scrolling="no"></iframe>
						</td>
					</tr>
				</table>
			</TD>
		</TR>
		<TR>
			<TD vAlign="top">
				<TABLE class="innertxt" id="table5" cellSpacing="0" cellPadding="0" border="0" width="100%">
					<TR>
						<TD class="nomrmaltext" id="TD_Home_Text" runat="server">&nbsp;
							<TABLE id="table6" cellSpacing="1" width="100%" border="0">
								<TR>
									<TD class="normaltext"><p align="justify"><b>PhoneTrade.cc</b> is specially designed as 
											a B2B mobile trade portal for import / export companies, service companies, 
											wholesalers and distributors of mobile phone handsets. We are committed to 
											providing high-quality and cost-effective services to our members.
											<br>
											<br>
											We strive to make the functions as user-friendly as possible on this web site. 
											Our specially-designed <b><a target="_parent" href="../PortalDefault.aspx?Main_Links_ID=2">
													Traders Directory</a></b>, <b><a target="_parent" href="../PortalDefault.aspx?Main_Links_ID=3">
													Freight Forwarders Directory</a></b> and the heart of our site, the <b><a target="_parent" href="../PortalDefault.aspx?Main_Links_ID=4">
													TRADING FLOOR</a></b>, will all greatly help our members to achieve 
											their goals on this web site.
										</p>
										<p align="justify">Member satisfaction is always the first priority for 
											PhoneTrade.cc. We are constantly focusing on improving the quality and 
											user-friendliness of this web site, and are trying our very best to meet and 
											exceed the expectations of our members.
										</p>
										<p>Be a part of one of the best Cellular Stock Exchange network!!! <b><a target="_parent" href="../PortalDefault.aspx?Main_Links_ID=25">
												Join today</b></p>
										</A>
									</TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
					<TR>
						<TD></TD>
					</TR>
					<TR>
						<TD>
						</TD>
					</TR>
				</TABLE>
			</TD>
		</TR>
	</TABLE>
</div>

