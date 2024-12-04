<%@ Page Language="vb" AutoEventWireup="false" Codebehind="TestForm.aspx.vb" Inherits="Trade.TestForm" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>TestForm</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:AdRotator id="AdImgRotator" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px"
				runat="server"></asp:AdRotator>
			<asp:TextBox id="TextBox3" style="Z-INDEX: 104; LEFT: 208px; POSITION: absolute; TOP: 160px"
				runat="server" Width="152px"></asp:TextBox>
			<asp:TextBox id="TextBox2" style="Z-INDEX: 103; LEFT: 208px; POSITION: absolute; TOP: 128px"
				runat="server" Width="152px"></asp:TextBox>
			<asp:TextBox id="TextBox1" style="Z-INDEX: 102; LEFT: 208px; POSITION: absolute; TOP: 96px" runat="server"
				Width="152px"></asp:TextBox>
			<asp:RequiredFieldValidator id="RequiredFieldValidator1" style="Z-INDEX: 105; LEFT: 376px; POSITION: absolute; TOP: 104px"
				runat="server" ErrorMessage="Enter value 1" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
			<asp:RequiredFieldValidator id="RequiredFieldValidator2" style="Z-INDEX: 106; LEFT: 376px; POSITION: absolute; TOP: 136px"
				runat="server" ErrorMessage="Enter value 2" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
			<asp:RequiredFieldValidator id="RequiredFieldValidator3" style="Z-INDEX: 107; LEFT: 376px; POSITION: absolute; TOP: 168px"
				runat="server" ErrorMessage="Enter value 3" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
			<asp:Button id="Button1" style="Z-INDEX: 108; LEFT: 272px; POSITION: absolute; TOP: 192px" runat="server"
				Width="80px" Text="Button"></asp:Button>
		</form>
	</body>
</HTML>
