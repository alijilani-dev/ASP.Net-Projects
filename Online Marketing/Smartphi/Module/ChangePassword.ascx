<%@ Control Language="vb" AutoEventWireup="false" Codebehind="ChangePassword.ascx.vb" Inherits="Smartphi.ChangePassword" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<div align="center">
	<asp:label id="lblConfirm" runat="server" Visible="False"></asp:label>
	&nbsp;<TABLE class="txt" id="tblGroup" style="BORDER-RIGHT: #aaccff 1px solid; BORDER-TOP: #aaccff 1px solid; BORDER-LEFT: #aaccff 1px solid; BORDER-BOTTOM: #aaccff 1px solid"
		cellSpacing="3" width="500" border="0" runat="server">
		<TR>
			<TD class="gridhead" colSpan="2" height="27"><b>Change Password</b></TD>
		</TR>
		<TR>
			<TD width="168">Old password:</TD>
			<TD>
				<asp:textbox id="txtOldpwd" runat="server" CssClass="txtbox" TextMode="Password"></asp:textbox>
				<asp:requiredfieldvalidator Display="Dynamic" id="rfv1" tabIndex="1" runat="server" ControlToValidate="txtOldpwd"
					ErrorMessage="Please provide old password"></asp:requiredfieldvalidator></TD>
		</TR>
		<TR>
			<TD width="168">New password:</TD>
			<TD>
				<asp:textbox id="txtNewpwd" runat="server" CssClass="txtbox" TextMode="Password"></asp:textbox>
				<asp:requiredfieldvalidator Display="Dynamic" id="rfv2" tabIndex="1" runat="server" ControlToValidate="txtNewpwd"
					ErrorMessage="Please provide new password"></asp:requiredfieldvalidator></TD>
		</TR>
		<TR>
			<TD width="168">Retype password:</TD>
			<TD>
				<asp:textbox id="txtRetypepwd" runat="server" CssClass="txtbox" TextMode="Password"></asp:textbox>
				<asp:requiredfieldvalidator Display="Dynamic" id="rfv3" tabIndex="1" runat="server" ControlToValidate="txtRetypepwd"
					ErrorMessage="Please provide retype password"></asp:requiredfieldvalidator>
				<asp:CompareValidator id="CVReNewPassword" runat="server" CssClass="error" ControlToValidate="txtRetypepwd"
					ErrorMessage="Retype password is not the same as NEW PASSWORD" Width="288px" ControlToCompare="txtNewpwd"
					Display="Dynamic"></asp:CompareValidator></TD>
		</TR>
		<TR>
			<TD width="168"></TD>
			<TD height="25">
				<asp:button id="btnUpdate" tabIndex="2" runat="server" CssClass="button" Text="Update Password"
					CommandName="UpdatePswd"></asp:button></TD>
		</TR>
	</TABLE>
	<p>&nbsp;</p>
</div>
