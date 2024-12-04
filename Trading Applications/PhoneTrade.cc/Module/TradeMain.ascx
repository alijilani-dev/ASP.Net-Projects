<%@ Register TagPrefix="uc1" TagName="Logo" Src="Logo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Confirmation" Src="Confirmation.ascx" %>
<%@ Control Language="vb" AutoEventWireup="false" Codebehind="TradeMain.ascx.vb" Inherits="Trade.TradeMain" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<%@ Register TagPrefix="uc1" TagName="Top" Src="Top.ascx" %>
<LINK rel="stylesheet" type="text/css" href="Styles.css">
<TABLE id="Table2" cellSpacing="0" cellPadding="0" border="0" align="center" width="100%"
	bgcolor="#ffffff">
	<TR>
		<TD id="TD_Site_Links" colSpan="2" runat="server"><uc1:Top id="Top1" runat="server"></uc1:Top></TD>
	</TR>
	<TR>
		<TD id="TD_Logo" runat="server" background="images/bg_top_banner.jpg" align="left" style="HEIGHT: 76px"
			width="265"></TD>
		<TD id="TD_Top_AD_Banner" runat="server" align="center" background="images/bg_top_banner.jpg"
			style="HEIGHT: 19px" valign="middle"><IFRAME style="DISPLAY: block; VISIBILITY: visible; WIDTH: 470px; HEIGHT: 60px" tabIndex="0"
							name="I1" align="middle" src="HTMLPages/Ad_top.htm" frameBorder="no" scrolling="no">
						</IFRAME>
						</TD>
	</TR>
	<TR>
		<TD id="TD_World_Time" colSpan="2" runat="server" align="center" style="HEIGHT: 18px"></TD>
	</TR>
	<TR>
		<TD id="TD_Main_Links" colSpan="2" runat="server" align="center"></TD>
	</TR>
	<TR>
		<TD id="TD_Content_Top_Header" colSpan="2" runat="server"></TD>
	</TR>
	<TR>
		<TD id="TD_Content_Ad_Banner" colSpan="2" runat="server"></TD>
	</TR>
</TABLE>
<TABLE id="Table3" height="350" cellSpacing="1" cellPadding="0" border="0" align="center"
	width="100%" bgcolor="#ffffff" borderColor="#c0c0c0" borderColorDark="#c0c0c0" borderColorLight="#c0c0c0">
	<TR>
		<TD id="TD_Content_Left_Pane" runat="server" vAlign="top" align="left" height="100%">
		</TD>
		<TD id="TD_Content_Main_Pane" runat="server" vAlign="top" align="center" width="100%" height="100%"></TD>
		<TD id="TD_Content_Right_Pane" runat="server" vAlign="top" align="right" height="100%"></TD>
	</TR>
</TABLE>
<TABLE id="Table1" cellSpacing="1" cellPadding="1" border="0" align="center" width="100%"
	bgcolor="#ffffff">
	<TR>
		<TD id="TD_Footer" vAlign="bottom" runat="server"></TD>
	</TR>
</TABLE>