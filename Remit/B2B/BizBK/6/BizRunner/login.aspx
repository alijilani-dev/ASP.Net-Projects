<%@ Page language="c#" Codebehind="login.aspx.cs" Inherits="BizRunner.MobileWebForm1" AutoEventWireup="false" %>
<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<HEAD>
	<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
	<meta name="CODE_LANGUAGE" content="C#">
	<meta name="vs_targetSchema" content="http://schemas.microsoft.com/Mobile/Page">
</HEAD>
<body Xmlns:mobile="http://schemas.microsoft.com/Mobile/WebForm">
	<mobile:Form id="frmLogin" runat="server" title="Login View">
		<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="300" border="1">
			<TR>
				<TD colSpan="3">
					<mobile:Label id="lblMessage" runat="server" Wrapping="Wrap"></mobile:Label>
				</TD>
			</TR>
			<TR>
				<TD>
					<mobile:Label id="lblLogin" runat="server">Login</mobile:Label>
				</TD>
				<TD></TD>
				<TD>
					<mobile:TextBox id="txtLogin" runat="server"></mobile:TextBox>
				</TD>
			</TR>
			<TR>
				<TD>
					<mobile:Label id="lblPswd" runat="server">Password</mobile:Label>
				</TD>
				<TD></TD>
				<TD>
					<mobile:TextBox id="txtPswd" runat="server"></mobile:TextBox>
				</TD>
			</TR>
			<TR>
				<TD>
					<mobile:Command id="cmdSignIn" runat="server" Wrapping="NoWrap">Sign In</mobile:Command>
				</TD>
				<TD></TD>
				<TD>
					<mobile:Command id="cmdReset" runat="server" Wrapping="NoWrap">Reset</mobile:Command>
				</TD>
			</TR>
			<TR>
				<TD colSpan="3">
					<mobile:Link id="lnkForgotPswd" runat="server" NavigateUrl="forgot.aspx">Forgot Password</mobile:Link>
				</TD>
			</TR>
		</TABLE>
	</mobile:Form>
	<mobile:Form id="frmMessage" title="Message" runat="server" BackColor="LightBlue" ForeColor="IndianRed"
		Alignment="Left" Font-Size="Small" Font-Name="Verdana">
		<mobile:Label id="lblHeading" runat="server" ForeColor="Black" Font-Bold="True">Message:</mobile:Label>
		<mobile:Label id="lblMsg" runat="server"></mobile:Label>
		<mobile:Command id="cmdBacktoRec" runat="server" ForeColor="Black">Back to Login Form</mobile:Command>
	</mobile:Form>
</body>
