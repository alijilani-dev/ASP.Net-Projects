<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Phones.aspx.vb" Inherits="Trade.Phones" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Phones</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
	</HEAD>
	<body>
		<table class="normaltext" bgcolor="#f7e1ba">
			<tr>
				<td align="middle" bgcolor="FFFFFF"><IMG src="../images/hdn_latestphones.jpg"></td>
			</tr>
			<tr>
				<td>
					<div id="containerPhones" style="DISPLAY: inline; VISIBILITY: visible; OVERFLOW: hidden; WIDTH: 190px; BORDER-TOP-STYLE: none; BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; HEIGHT: 220px; BACKGROUND-COLOR: transparent; BORDER-BOTTOM-STYLE: none">
						<div id="Phones" onmouseover="javascript:wait();" style="VISIBILITY: visible; POSITION: relative" onmouseout="javascript:continu();">
							<asp:Repeater id="DLPhone" runat="server">
								<ItemTemplate>
									<asp:HyperLink id="Hyperlink2" runat="server" ImageUrl='<%# "../" & DataBinder.Eval(Container, "DataItem.ImgFile2") %>' NavigateUrl='<%# "../PortalDefault.aspx?Main_Links_ID=5&MobileSrNo=" & DataBinder.Eval(Container, "DataItem.SrNo") %>' Target="_parent" CssClass="footer">
										<!--<%# DataBinder.Eval(Container, "DataItem.ModelNo") %>-->
									</asp:HyperLink>
									<asp:HyperLink id="Hyperlink1" runat="server" NavigateUrl='<%# "../PortalDefault.aspx?Main_Links_ID=5&MobileSrNo=" & DataBinder.Eval(Container, "DataItem.SrNo") %>' Target="_parent" CssClass="footer">
										<%# DataBinder.Eval(Container, "DataItem.ModelNo") %>
									</asp:HyperLink>
									<BR>
									<BR>
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
	</body>
</HTML>
