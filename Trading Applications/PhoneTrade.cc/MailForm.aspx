<%@ Page Language="vb" AutoEventWireup="false" Codebehind="MailForm.aspx.vb" Inherits="Trade.MailForm"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>MailForm</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:DropDownList id="ddlMonth" style="Z-INDEX: 101; LEFT: 200px; POSITION: absolute; TOP: 176px"
				runat="server" Width="120px"></asp:DropDownList>
			<asp:RadioButton id="rdoType3" style="Z-INDEX: 105; LEFT: 208px; POSITION: absolute; TOP: 248px"
				runat="server" Width="160px" Text="Activated members"></asp:RadioButton>
			<asp:RadioButton id="rdoType2" style="Z-INDEX: 104; LEFT: 328px; POSITION: absolute; TOP: 216px"
				runat="server" Width="160px" Text="Deactivated members"></asp:RadioButton>
			<asp:DropDownList id="ddlYear" style="Z-INDEX: 102; LEFT: 320px; POSITION: absolute; TOP: 176px" runat="server"></asp:DropDownList>
			<asp:RadioButton id="rdoType1" style="Z-INDEX: 103; LEFT: 208px; POSITION: absolute; TOP: 216px"
				runat="server" Width="96px" Text="All Membes"></asp:RadioButton>
			<asp:Button id="btnMail" style="Z-INDEX: 106; LEFT: 248px; POSITION: absolute; TOP: 280px" runat="server"
				Width="136px" Text="Send Mail"></asp:Button>
		</form>
	</body>
</HTML>
