<%@ Page language="c#" Codebehind="openerwindow.aspx.cs" AutoEventWireup="false" Inherits="WebApplication1.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:TextBox id="textbox1" style="Z-INDEX: 101; LEFT: 80px; POSITION: absolute; TOP: 40px" runat="server"></asp:TextBox>
			<asp:Button id="Button1" style="Z-INDEX: 102; LEFT: 256px; POSITION: absolute; TOP: 40px" runat="server"
				Text="Button"></asp:Button>
			<a href="#" onclick="window.open('hello.aspx');">some link text </a>
			<asp:Label id="Label1" style="Z-INDEX: 103; LEFT: 24px; POSITION: absolute; TOP: 88px" runat="server"
				Width="544px" Height="144px">Label</asp:Label>
			<asp:Label id="lblMessage" style="Z-INDEX: 104; LEFT: 128px; POSITION: absolute; TOP: 8px"
				runat="server" ForeColor="Red"></asp:Label>
		</form>
	</body>
</HTML>
