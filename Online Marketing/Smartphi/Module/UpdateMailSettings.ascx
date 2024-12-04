<%@ Control Language="vb" AutoEventWireup="false" Codebehind="UpdateMailSettings.ascx.vb" Inherits="Smartphi.UpdateMailSettings" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<div align="center">
	&nbsp;<TABLE class="txt" id="tblGroup" style="BORDER-RIGHT: #aaccff 1px solid; BORDER-TOP: #aaccff 1px solid; BORDER-LEFT: #aaccff 1px solid; BORDER-BOTTOM: #aaccff 1px solid"
		cellSpacing="3" width="500" border="0" runat="server">
		<TR>
			<TD class="gridhead" colSpan="2" HEIGHT="27"><b>Update Mail Settings</b>&nbsp;
				<asp:label id="lblConfirm" runat="server" Visible="False"></asp:label>&nbsp;</TD>
		</TR>
		<TR>
			<TD colspan="2" height="5"></TD>
		</TR>
		<TR>
			<TD width="168">SMTP Server:</TD>
			<TD>
				<asp:textbox id="txtSMTPServer" runat="server" CssClass="txtbox"></asp:textbox>
				<asp:requiredfieldvalidator id="rfv1" Display="Dynamic" tabIndex="1" runat="server" ControlToValidate="txtSMTPServer"
					ErrorMessage="Please provide SMTP Server name"></asp:requiredfieldvalidator></TD>
		</TR>
		<TR>
			<TD width="168">SMTP User Name:</TD>
			<TD>
				<asp:textbox id="txtSMTPUserName" runat="server" CssClass="txtbox"></asp:textbox>
				<asp:requiredfieldvalidator id="rfv2" Display="Dynamic" tabIndex="1" runat="server" ControlToValidate="txtSMTPUserName"
					ErrorMessage="Please provide SMTP User name"></asp:requiredfieldvalidator></TD>
		</TR>
		<TR>
			<TD width="168">SMTP Password:</TD>
			<TD>
				<asp:textbox id="txtSMTPPassword" runat="server" CssClass="txtbox" TextMode="Password"></asp:textbox>
				<asp:requiredfieldvalidator id="rfv3" Display="Dynamic" tabIndex="1" runat="server" ControlToValidate="txtSMTPPassword"
					ErrorMessage="Please provide SMTP password"></asp:requiredfieldvalidator></TD>
		</TR>
		<TR>
			<TD width="168">Server Port:</TD>
			<TD>
				<asp:textbox id="txtServerport" runat="server" CssClass="txtbox"></asp:textbox>
				<asp:requiredfieldvalidator id="rfv4" Display="Dynamic" tabIndex="1" runat="server" ControlToValidate="txtServerport"
					ErrorMessage="Please provide SMTP Server port"></asp:requiredfieldvalidator></TD>
		</TR>
		<TR>
			<TD width="168"></TD>
			<TD height="25">
				<asp:button id="btnUpdate" tabIndex="2" runat="server" CssClass="button" Text="Update Settings"></asp:button></TD>
		</TR>
		<TR>
			<TD valign="top" colspan="2" height="5"></TD>
		</TR>
	</TABLE>
	<p>&nbsp;</p>
</div>
