<%@ Page Language="vb" AutoEventWireup="false" Codebehind="NewMember.aspx.vb" Inherits="Trade.NewMember" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>NewMember</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<div align="center">
			<table style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid; BACKGROUND-REPEAT: repeat-x"
				cellSpacing="0" cellPadding="0" width="176" height="387" background="../images/bg_cell.gif"
				border="0" id="table47">
				<tr>
					<td width="3" rowSpan="4">
						<img height="1" width="3"></td>
					<td width="168" colSpan="2" height="3"></td>
					<td width="3" rowSpan="4">
						<img height="1" width="3"></td>
				</tr>
				<tr>
					<td class="boxhdn" style="color: white; background-repeat: no-repeat" colSpan="2" height="19"
						bgcolor="#cf8e40">
						&nbsp;New Members</td>
				</tr>
				<tr>
					<td width="91">
						<img height="1" width="5"></td>
					<td width="77">
						<img height="1" width="5"></td>
				</tr>
				<tr>
					<td width="168" valign="top" colspan="2">
						<div id="containerPhones" style="DISPLAY: inline; VISIBILITY: visible; OVERFLOW: hidden; WIDTH: 168px; HEIGHT: 360px; BORDER-TOP-STYLE: none; BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; BACKGROUND-COLOR: transparent; BORDER-BOTTOM-STYLE: none">
							<div id="Phones" onmouseover="javascript:wait();" style="VISIBILITY: visible; POSITION: relative"
								onmouseout="javascript:continu();" align="center">
								<asp:Repeater id="RNewMember" runat="server">
									<ItemTemplate>
										<TABLE width="96%" border="0" align="center" cellPadding="1" cellSpacing="2" id="Table1">
											<TR>
												<TD align="center" vAlign="middle" bgColor="white">
													<img id="imgLogo" src='<%# "../images/Logo/" & DataBinder.Eval(Container, "DataItem.company_Logo_Url") %>'>
													<!--
														<asp:HyperLink id="hlnkLogo" Font-Bold="True" ForeColor="#0000C0" runat="server" CssClass="footer" ImageUrl='<%# "..\" & DataBinder.Eval(Container, "DataItem.company_Logo_Url") %>' NavigateUrl='<%# "http://" & DataBinder.Eval(Container, "DataItem.company_website") %>' Target="_blank" >
															</asp:HyperLink><BR>
													-->
													<br>
													<asp:HyperLink ID=hlinkcompanyName Font-Bold="True" ForeColor="#0000C0" runat="server" CssClass="titleTD" NavigateUrl='<%# "../PortalDefault.aspx?Main_Links_ID=2&Member_ID=" & DataBinder.Eval(Container, "DataItem.Member_ID") %>' Target="_parent">
														<%# DataBinder.Eval(Container, "DataItem.member_company") %>
													</asp:HyperLink>
													<!--
														<%# " [" & DataBinder.Eval(Container, "DataItem.country_Name") & "]" %>
														<BR>
													-->
													<asp:HyperLink ID=hlinkemail runat="server" CssClass="footer" NavigateUrl='<%# "mailto:" & DataBinder.Eval(Container, "DataItem.company_email") & "?subject=Enquiry from phonetrade.cc" %>' Visible="False">[ Email ]</asp:HyperLink>
												</TD>
											</TR>
										</TABLE>
									</ItemTemplate>
								</asp:Repeater>
							</div>
						</div>
					</td>
				</tr>
			</table>
			<SCRIPT language="JavaScript">
<!-- Begin
var step=parseFloat(window.containerPhones.style.posTop)+parseFloat(window.containerPhones.style.posHeight);
var diff=(window.Phones.style.top-window.Phones.scrollHeight);
var scrollspeed=50; //Millisecs
function scrollPhones()
{
	window.Phones.style.top = step;
	step-=2;
	if((parseFloat(window.Phones.style.posTop))<=diff)
	{
		step=parseFloat(window.containerPhones.style.posTop)+parseFloat(window.containerPhones.style.posHeight);
	}
}
var retval=setInterval("scrollPhones();",scrollspeed);

function wait()
{
	clearInterval(retval);
}

function continu()
{
	retval = setInterval("scrollPhones();",scrollspeed);
}
//  End -->
			</SCRIPT>
		</div>
	</body>
</HTML>
