<%@ Page Language="vb" AutoEventWireup="false" Codebehind="default.aspx.vb" Inherits="Trade.Admin._default"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>default</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table2" height="100%" cellSpacing="1" cellPadding="1" width="100%" border="0">
				<TR>
					<TD vAlign="middle" align="center">
						<TABLE id="Table1" style="WIDTH: 485px; HEIGHT: 57px" cellSpacing="1" cellPadding="1" width="485"
							border="0">
							<TR>
								<TD style="WIDTH: 88px">
									<asp:Label id="lblPortal" runat="server" EnableViewState="False">Portal</asp:Label></TD>
								<TD style="WIDTH: 4px">:</TD>
								<TD style="WIDTH: 229px">
									<asp:DropDownList id="ddlportal" runat="server" Width="176px"></asp:DropDownList></TD>
								<TD>
									<asp:RequiredFieldValidator id="RFV_selectPortal" runat="server" ErrorMessage="Select Portal" ControlToValidate="ddlportal">* </asp:RequiredFieldValidator></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 88px">
									<asp:Label id="lblusername" runat="server" EnableViewState="False">User Name</asp:Label></TD>
								<TD style="WIDTH: 4px">:</TD>
								<TD style="WIDTH: 229px">
									<asp:TextBox id="tbusername" runat="server" Width="176px">administrator</asp:TextBox></TD>
								<TD>
									<asp:RequiredFieldValidator id="RFVUsername" runat="server" ErrorMessage="Username can not be blank" ControlToValidate="tbusername">*</asp:RequiredFieldValidator></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 88px; HEIGHT: 2px">
									<asp:Label id="lblpassword" runat="server" EnableViewState="False">Password</asp:Label></TD>
								<TD style="WIDTH: 4px; HEIGHT: 2px">:</TD>
								<TD style="WIDTH: 229px; HEIGHT: 2px">
									<asp:TextBox id="tbpasswrod" runat="server" Width="176px" TextMode="Password"></asp:TextBox></TD>
								<TD style="HEIGHT: 2px">
									<asp:RequiredFieldValidator id="RFVPassword" runat="server" ErrorMessage="passwrod can not be blank" ControlToValidate="tbpasswrod">*</asp:RequiredFieldValidator></TD>
							</TR>
							<TR>
								<TD align="center" colSpan="4">
									<asp:Label id="lblinvaliduser" runat="server" ForeColor="#0000C0">Invalid User, Please enter valid username and password </asp:Label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 88px"></TD>
								<TD style="WIDTH: 4px"></TD>
								<TD style="WIDTH: 229px" align="center">
									<asp:Button id="btnlogin" runat="server" Text="Log in" EnableViewState="False"></asp:Button>&nbsp;&nbsp;
									<asp:Button id="btnclose" runat="server" Text="Close" EnableViewState="False"></asp:Button></TD>
								<TD></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
