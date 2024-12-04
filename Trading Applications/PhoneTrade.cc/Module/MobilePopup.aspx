<%@ Register TagPrefix="uc1" TagName="MobileDetail_Popup" Src="MobileDetail_Popup.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="MobilePopup.aspx.vb" Inherits="Trade.MobilePopup" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>MobilePopup</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0" runat="server">
				<TR>
					<TD></TD>
				</TR>
				<TR>
					<TD align="center">
						<TABLE class="normaltext" id="Table8" cellSpacing="4" cellPadding="2" width="448" border="0"
							style="WIDTH: 448px; HEIGHT: 98px">
							<TR>
								<TD class="boxhdn" style="BORDER-RIGHT: #3f8bd7 1px solid; BORDER-TOP: #3f8bd7 1px solid; BORDER-LEFT: #3f8bd7 1px solid; BORDER-BOTTOM: #3f8bd7 1px solid"
									align="center" bgColor="#3f8bd7" colSpan="2" height="25"><B>&nbsp; </B>
									<asp:label id="lblModelNo" runat="server" Font-Bold="True">Label</asp:label></TD>
							</TR>
							<TR>
								<TD style="BORDER-RIGHT: #3f8bd7 1px solid; BORDER-TOP: #3f8bd7 1px solid; BORDER-LEFT: #3f8bd7 1px solid; BORDER-BOTTOM: #3f8bd7 1px solid"
									vAlign="middle" align="center" width="116">
									<asp:imagebutton id="imgMain" runat="server" ImageAlign="Middle"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD style="BORDER-RIGHT: #3f8bd7 1px solid; BORDER-TOP: #3f8bd7 1px solid; BORDER-LEFT: #3f8bd7 1px solid; BORDER-BOTTOM: #3f8bd7 1px solid"
									align="center" colSpan="2">
									<asp:HyperLink id="hlnkDetails" Font-Bold="True" runat="server">Get more details</asp:HyperLink></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
