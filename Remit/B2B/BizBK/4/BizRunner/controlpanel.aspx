<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<%@ Page language="c#" Codebehind="controlpanel.aspx.cs" Inherits="BizRunner.controlpanel" AutoEventWireup="false" %>
<HEAD>
	<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
	<meta name="CODE_LANGUAGE" content="C#">
	<meta name="vs_targetSchema" content="http://schemas.microsoft.com/Mobile/Page">
</HEAD>
<body Xmlns:mobile="http://schemas.microsoft.com/Mobile/WebForm">
	<mobile:Form id="frmControlPanel" runat="server" title="Control Panel">
		<TABLE>
			<TR>
				<TD colSpan="3">
					<mobile:Label id="lblWelcome" runat="server">Welcome</mobile:Label>
					<mobile:Label id="lblUserName" runat="server"></mobile:Label>
				</TD>
			</TR>
			<TR>
				<TD></TD>
				<TD align="centre">
					<mobile:Image id="imgCustomerView" runat="server" ImageUrl="file:///C:\Documents and Settings\Administrator\Desktop\CustomerView.jpg"
						NavigateUrl="customerview.aspx"></mobile:Image>
				</TD>
				<TD></TD>
			</TR>
			<TR>
				<TD></TD>
				<TD align="centre">
					<mobile:Image id="imgTaskView" runat="server" ImageUrl="file:///C:\Documents and Settings\Administrator\Desktop\Task View.jpg"
						NavigateUrl="servicesview.aspx"></mobile:Image>
				</TD>
				<TD></TD>
			</TR>
			<TR>
				<TD></TD>
				<TD>
					<mobile:Command id="cmdResources" runat="server">Resource View</mobile:Command>
				</TD>
				<TD></TD>
			</TR>
			<TR>
				<TD></TD>
				<TD>
					<mobile:Command id="cmdSecurity" runat="server">Security View</mobile:Command>
				</TD>
				<TD></TD>
			</TR>
		</TABLE>
	</mobile:Form>
</body>
