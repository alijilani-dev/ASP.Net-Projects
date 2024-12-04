<%@ Page Language="vb" AutoEventWireup="false" Codebehind="News.aspx.vb" Inherits="Trade.News" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>News</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<table class="normaltext" bgcolor="#d0e8f8" cellSpacing="0" cellPadding="0" align="center">
			<tr>
				<td align="center" bgcolor="#ffffff"><IMG src="../images/hdn_latestnews.jpg"></td>
			</tr>
			<tr>
				<td>
					<div id="containerPhones" style="DISPLAY: inline; VISIBILITY: visible; OVERFLOW: hidden; WIDTH: 190px; BORDER-TOP-STYLE: none; BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; HEIGHT: 220px; BACKGROUND-COLOR: transparent; BORDER-BOTTOM-STYLE: none">
						<div id="Phones" onmouseover="javascript:wait();" style="VISIBILITY: visible; POSITION: relative"
							onmouseout="javascript:continu();">
							<asp:Repeater id="RNews" runat="server">
								<ItemTemplate>
									<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0" class="normaltext">
										<TR>
											<TD bgColor="#0066aa">
												<asp:HyperLink id="lnkPressHead" runat="server" ForeColor="White" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.ann_TextLink_Url") %>' Target=_blank>
													<%# DataBinder.Eval(Container, "DataItem.ann_Heading") %>
												</asp:HyperLink></TD>
										</TR>
										<TR>
											<TD>
												<asp:Label id="lblDetail" runat="server">
													<%# DataBinder.Eval(Container, "DataItem.ann_text") %>
												</asp:Label></TD>
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
	</body>
</HTML>
