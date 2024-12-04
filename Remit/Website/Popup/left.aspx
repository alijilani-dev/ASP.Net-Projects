<%@ Page language="c#" Codebehind="left.aspx.cs" AutoEventWireup="false" Inherits="Popup.left" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>left</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout" bgColor="#ffff66">
		<form id="Form1" method="post" runat="server">
			<asp:Panel id="Panel1" style="Z-INDEX: 105; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Width="96px" Height="160px" BackColor="Silver">
				<P>&nbsp;
					<asp:HyperLink id="HyperLink1" runat="server" Target="right" NavigateUrl="http://www.yahoo.com"
						ToolTip="Goto Yahoo.." Font-Names="Verdana" Font-Size="Smaller">Yahoo</asp:HyperLink></P>
				<P>&nbsp;
					<asp:HyperLink id="HyperLink2" runat="server" Target="right" NavigateUrl="http://www.google.com"
						ToolTip="Goto Google.." Font-Names="Verdana" Font-Size="Smaller">Google</asp:HyperLink></P>
				<P>&nbsp;
					<asp:HyperLink id="HyperLink3" runat="server" Target="right" NavigateUrl="http://www.microsoft.com/sharepoint/"
						ToolTip="Goto SharePoint.." Font-Names="Verdana" Font-Size="Smaller">SharePoint</asp:HyperLink></P>
				<P>&nbsp;
					<asp:Label id="Label1" runat="server" Width="80px" Height="24px" Font-Names="Verdana" Font-Size="Smaller">Press a link above..</asp:Label></P>
			</asp:Panel>
		</form>
	</body>
</HTML>
