<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Home.ascx.vb" Inherits="Trade.Home1" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<%@ Register TagPrefix="uc1" TagName="Testimonial" Src="Testimonial.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Announcement" Src="Announcement.ascx" %>
<LINK href="Styles.css" type="text/css" rel="stylesheet">
<div align="center">
	<TABLE class="innertxt" id="Table2" cellSpacing="0" cellPadding="0" width="1000" bgColor="#ffffff"
		border="0">
		<TR>
			<TD vAlign="top" width="176" rowSpan="3">
				<table id="table8" cellSpacing="0" cellPadding="0" width="100%" border="0">
					<tr>
						<td vAlign="top">
							<table id="tblLogin" runat="server" style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid; BACKGROUND-REPEAT: repeat-x"
								cellSpacing="0" cellPadding="0" width="176" background="../images/bg_cell.gif" border="0">
								<tr>
									<td width="3" rowSpan="7"></td>
									<td width="168" colSpan="3" height="3"></td>
									<td width="3" rowSpan="7"></td>
								</tr>
								<tr>
									<td class="boxhdn" bgColor="#cf8e40" colSpan="3" height="19">&nbsp;Login</td>
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
							<TABLE id="tblMembMenu" style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid; BACKGROUND-REPEAT: repeat-x"
								cellSpacing="0" cellPadding="0" width="176" background="../images/bg_cell.gif" border="0"
								runat="server">
								<TR>
									<TD width="3" rowSpan="6"></TD>
									<TD colSpan="3" height="3"></TD>
									<TD width="3" rowSpan="6"></TD>
								</TR>
								<TR>
									<TD class="boxhdn" bgColor="#cf8e40" colSpan="3" height="19">&nbsp;Member Menu
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
							<table id="table49" style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid; BACKGROUND-REPEAT: repeat-x"
								cellSpacing="0" cellPadding="0" width="176" background="../images/bg_cell.gif" border="0">
								<tr>
									<td width="3" rowSpan="6"></td>
									<td width="168" colSpan="3" height="3"></td>
									<td width="3" rowSpan="6"></td>
								</tr>
								<tr>
									<td class="boxhdn" bgColor="#cf8e40" colSpan="3" height="19">&nbsp;Search</td>
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
									<td class="normaltext" width="157" style="HEIGHT: 40px">Product:
										<asp:dropdownlist id="ddlModel" runat="server" Width="152px" CssClass="box" Font-Bold="True" BackColor="#fff4e7"></asp:dropdownlist></td>
								</tr>
								<tr>
									<td class="normaltext" width="157" style="HEIGHT: 21px">Brand:
										<asp:dropdownlist id="ddlBrand" runat="server" Width="153px" CssClass="box" Font-Bold="true" BackColor="#fff4e7"></asp:dropdownlist></td>
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
						<td vAlign="top"><TABLE id="table53" style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid; BACKGROUND-REPEAT: repeat-x"
								cellSpacing="0" cellPadding="0" width="176" background="../images/bg_cell.gif" border="0">
								<TR>
									<TD width="3" rowSpan="4"></TD>
									<TD width="168" colSpan="3" height="3"></TD>
									<TD width="3" rowSpan="4"></TD>
								</TR>
								<TR>
									<TD class="boxhdn" bgColor="#cf8e40" colSpan="3" height="19">&nbsp;Hot 
									Offers</TD>
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
						<td height="4"></td>
					</tr>
					<tr>
						<td>
							<iframe name="I6" src="ScrollerPage\NewMember.aspx" frameBorder="0" width="176" height="387"
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
									<TD class="normaltext">
									<p align="justify" dir="ltr"><b>CPUTrade.cc</b> is specially designed as 
											a B2B CPU trade portal for import / export companies, service companies, 
											wholesalers and distributors of CPU 
									trade industry<font size="2"> </font>. We are committed to 
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
										<p>Be a part of one of the best CPU Stock Exchange network!!! <b><a target="_parent" href="../PortalDefault.aspx?Main_Links_ID=25">
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
<div id="dhtmltooltip" class="normalText" align="left"></div>
<script type="text/javascript">

/***********************************************
* Cool DHTML tooltip script- © Dynamic Drive DHTML code library (www.dynamicdrive.com)
* This notice MUST stay intact for legal use
* Visit Dynamic Drive at http://www.dynamicdrive.com/ for full source code
***********************************************/

var offsetxpoint=-60 //Customize x offset of tooltip
var offsetypoint=20 //Customize y offset of tooltip
var ie=document.all
var ns6=document.getElementById && !document.all
var enabletip=false
if (ie||ns6)
var tipobj=document.all? document.all["dhtmltooltip"] : document.getElementById? document.getElementById("dhtmltooltip") : ""

function ietruebody(){
return (document.compatMode && document.compatMode!="BackCompat")? document.documentElement : document.body
}

function ddrivetip(thetext, thecolor, thewidth){
if (ns6||ie){
if (typeof thewidth!="undefined") tipobj.style.width=thewidth+"px"
if (typeof thecolor!="undefined" && thecolor!="") tipobj.style.backgroundColor=thecolor
tipobj.innerHTML=thetext
enabletip=true
return false
}
}

function positiontip(e){
if (enabletip){
var curX=(ns6)?e.pageX : event.clientX+ietruebody().scrollLeft;
var curY=(ns6)?e.pageY : event.clientY+ietruebody().scrollTop;
//Find out how close the mouse is to the corner of the window
var rightedge=ie&&!window.opera? ietruebody().clientWidth-event.clientX-offsetxpoint : window.innerWidth-e.clientX-offsetxpoint-20
var bottomedge=ie&&!window.opera? ietruebody().clientHeight-event.clientY-offsetypoint : window.innerHeight-e.clientY-offsetypoint-20

var leftedge=(offsetxpoint<0)? offsetxpoint*(-1) : -1000

//if the horizontal distance isn't enough to accomodate the width of the context menu
if (rightedge<tipobj.offsetWidth)
//move the horizontal position of the menu to the left by it's width
tipobj.style.left=ie? ietruebody().scrollLeft+event.clientX-tipobj.offsetWidth+"px" : window.pageXOffset+e.clientX-tipobj.offsetWidth+"px"
else if (curX<leftedge)
tipobj.style.left="5px"
else
//position the horizontal position of the menu where the mouse is positioned
tipobj.style.left=curX+offsetxpoint+"px"

//same concept with the vertical position
if (bottomedge<tipobj.offsetHeight)
tipobj.style.top=ie? ietruebody().scrollTop+event.clientY-tipobj.offsetHeight-offsetypoint+"px" : window.pageYOffset+e.clientY-tipobj.offsetHeight-offsetypoint+"px"
else
tipobj.style.top=curY+offsetypoint+"px"
tipobj.style.visibility="visible"
}
}

function hideddrivetip(){
if (ns6||ie){
enabletip=false
tipobj.style.visibility="hidden"
tipobj.style.left="-1000px"
tipobj.style.backgroundColor=''
tipobj.style.width=''
}
}

document.onmousemove=positiontip

</script>
