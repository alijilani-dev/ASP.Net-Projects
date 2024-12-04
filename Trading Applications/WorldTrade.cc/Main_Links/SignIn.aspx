<%@ Page Language="vb" AutoEventWireup="false" Codebehind="SignIn.aspx.vb" Inherits="Trade.SignIn"%>
<%@ Register TagPrefix="uc1" TagName="Member" Src="../Module/Member.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>SignIn</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout" leftMargin="0" topMargin="0">
		<form id="Form1" method="post" runat="server">
			<uc1:Member id="UCMember" runat="server"></uc1:Member>
		</form>
	</body>
</HTML>
