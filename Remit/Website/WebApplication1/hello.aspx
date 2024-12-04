<%@ Page language="c#" Codebehind="hello.aspx.cs" AutoEventWireup="false" Inherits="WebApplication1.hello" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>hello</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:TextBox id="textbox1" style="Z-INDEX: 101; LEFT: 80px; POSITION: absolute; TOP: 16px" runat="server"
				Width="384px"></asp:TextBox>
			<a href="#" onclick="window.opener.Form1.textbox1.value='hello world';">back</a>
			<asp:Button id="Button1" style="Z-INDEX: 102; LEFT: 480px; POSITION: absolute; TOP: 16px" runat="server"
				Text="Button"></asp:Button>
		</form>
		</A>
	</body>
</HTML>
