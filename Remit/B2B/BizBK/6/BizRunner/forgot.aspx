<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<%@ Page language="c#" Codebehind="forgot.aspx.cs" Inherits="BizRunner.MobileWebForm2" AutoEventWireup="false" %>
<HEAD>
	<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
	<meta name="CODE_LANGUAGE" content="C#">
	<meta name="vs_targetSchema" content="http://schemas.microsoft.com/Mobile/Page">
</HEAD>
<body Xmlns:mobile="http://schemas.microsoft.com/Mobile/WebForm">
	<mobile:Form id="frmForgot" runat="server" title="Forgot Password">
		<TABLE id="tblforgot">
			<TR>
				<TD>
					<mobile:Label id="lblUserName" runat="server">User Name</mobile:Label>
				</TD>
				<TD colSpan="3">
					<mobile:TextBox id="txtUserName" runat="server"></mobile:TextBox>
				</TD>
			</TR>
			<TR>
				<TD>
					<mobile:Label id="lblEmail" runat="server">Email</mobile:Label>
				</TD>
				<TD colSpan="3">
					<mobile:TextBox id="txtEmail" runat="server"></mobile:TextBox>
				</TD>
			</TR>
			<TR>
				<TD></TD>
				<TD colSpan="3"></TD>
			</TR>
			<TR>
				<TD align="center" colSpan="2">
					<mobile:Command id="cmdSendPswd" runat="server">Email my password</mobile:Command>
				</TD>
				<TD>
					<mobile:Command id="cmdCancel" runat="server">Cancel</mobile:Command>
				</TD>
			</TR>
		</TABLE>
	</mobile:Form>
	<mobile:Form id="frmMessage" title="Message" runat="server" Font-Name="Verdana" Font-Size="Small"
		Alignment="Left" ForeColor="IndianRed" BackColor="LightBlue">
		<mobile:Label id="lblHeading" runat="server" ForeColor="Black" Font-Bold="True">Message:</mobile:Label>
		<mobile:Label id="lblMsg" runat="server"></mobile:Label>
		<mobile:Command id="cmdBacktoRec" runat="server" ForeColor="Black">Back to Login Form</mobile:Command>
	</mobile:Form>
</body>
