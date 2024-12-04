<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Popmail.aspx.vb" Inherits="Smartphi.PopMail" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Popmail2</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form2" method="post" runat="server">
			<table width="100%">
				<TR>
					<TD align="right" width="50%">Server</TD>
					<TD align="left" width="50%">
						<asp:TextBox id="srv" runat="server"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD align="right" width="50%">Username</TD>
					<TD align="left" width="50%">
						<asp:TextBox id="Usr" runat="server"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD align="right" width="50%">pwd</TD>
					<TD align="left" width="50%">
						<asp:TextBox id="Passwd" runat="server"></asp:TextBox></TD>
				</TR>
				<tr>
					<td align="right" width="50%"></td>
					<td align="left" width="50%">
						<asp:button id="Button2" runat="server" Text="Get Mail"></asp:button></td>
				</tr>
				<tr>
					<td align="center" colSpan="2">
						<asp:literal id="Answer" runat="server" Text="sdss"></asp:literal></td>
				</tr>
				<tr>
					<td align="center" colSpan="2">
						<asp:table id="AnswerTable" runat="server" Visible="false" BackColor="LightGrey"></asp:table></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
