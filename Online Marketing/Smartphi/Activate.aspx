<%@ Register TagPrefix="uc1" TagName="UpdateMailSettings" Src="Module/UpdateMailSettings.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Activate.aspx.vb" Inherits="Smartphi.Activate"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Activate</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
		<LINK href="smart.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 103; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="1"
				cellPadding="1" width="100%" border="0">
				<TR>
					<TD id="tdActivate" runat="server">
						<TABLE id="tbActivate" cellPadding="2" width="650" border="0" runat="server">
							<TR>
								<TD style="BORDER-RIGHT: #a5d1fe 1px solid; BORDER-TOP: #a5d1fe 1px solid; BORDER-LEFT: #a5d1fe 1px solid; BORDER-BOTTOM: #a5d1fe 1px solid"
									vAlign="top">
									<TABLE class="txt" id="Table2" style="WIDTH: 100%" cellPadding="0" width="637" border="0">
										<TR>
											<TD class="gridhead" height="25">Smartphi.com</TD>
										</TR>
										<TR>
											<TD>Provide us your SMTP settings to activate your account. These settings are 
												required to SEND scheduled&nbsp;mails.</TD>
										</TR>
										<TR>
											<TD id="tdContent" runat="server">&nbsp;</TD>
										</TR>
										<TR>
											<TD></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD id="tdMain" runat="server">
						<TABLE id="tbMain" cellPadding="2" width="650" border="0" runat="server">
							<TR>
								<TD style="BORDER-RIGHT: #a5d1fe 1px solid; BORDER-TOP: #a5d1fe 1px solid; BORDER-LEFT: #a5d1fe 1px solid; BORDER-BOTTOM: #a5d1fe 1px solid"
									vAlign="top">
									<TABLE class="txt" id="table40" style="WIDTH: 100%" cellPadding="0" width="637" border="0">
										<TR>
											<TD class="gridhead" height="25">&nbsp;Smartphi.com.</TD>
										</TR>
										<TR>
											<TD>&nbsp;
											</TD>
										</TR>
										<TR>
											<TD style="HEIGHT: 35px">Thank you, your account is&nbsp;activated.&nbsp;You will 
												be receiving an email&nbsp;shortly with your user name and password.</TD>
										</TR>
										<TR>
											<TD>&nbsp;</TD>
										</TR>
										<TR>
											<TD></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
			&nbsp;
		</form>
	</body>
</HTML>
