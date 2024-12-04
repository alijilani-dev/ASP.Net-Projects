<%@ Page Language="vb" AutoEventWireup="false" Codebehind="mMobileDetail.aspx.vb" Inherits="Trade.mMobileDetail" %>
<%@ Register TagPrefix="uc1" TagName="MobileDetail" Src="../Module/MobileDetail.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>mMobileDetail</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<uc1:MobileDetail id="MobileDetails" runat="server"></uc1:MobileDetail>
		</form>
	</body>
</HTML>
