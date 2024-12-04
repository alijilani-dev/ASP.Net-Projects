<%@ Control Language="vb" AutoEventWireup="false" Codebehind="LoginBox.ascx.vb" Inherits="Trade.Login" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<DIV align="center">
	<TABLE class="normaltext" id="table17" cellSpacing="1" cellPadding="1" border="0">
		<TR>
			<TD>
				<asp:Label id="lblusername" runat="server" CssClass="normaltext">User Name</asp:Label></TD>
			<TD>
				<asp:TextBox id="tbUserName" runat="server" CssClass="box" MaxLength="50" Width="143px"></asp:TextBox>
				<asp:RequiredFieldValidator id="RqFVUsername" runat="server" ControlToValidate="tbUserName" ErrorMessage="*"></asp:RequiredFieldValidator></TD>
		</TR>
		<TR>
			<TD>
				<asp:Label id="lblPassword" runat="server" CssClass="normaltext">User Password</asp:Label></TD>
			<TD>
				<asp:TextBox id="tbPassword" runat="server" CssClass="box" MaxLength="50" TextMode="Password"></asp:TextBox>
				<asp:RequiredFieldValidator id="RqFVUserpwd" runat="server" ControlToValidate="tbPassword" ErrorMessage="*"></asp:RequiredFieldValidator></TD>
		</TR>
		<TR>
			<TD align="center" colSpan="2" style="HEIGHT: 20px"></TD>
		</TR>
		<TR>
			<TD align="center" colSpan="2">
				<asp:Button id="cmdLogin" runat="server" Width="67px" Text="Login"></asp:Button>&nbsp;&nbsp;
				<asp:Button id="cmdclear" runat="server" Width="68px" Text="Clear" CausesValidation="False"></asp:Button></TD>
		</TR>
	</TABLE>
</DIV>
<BR>
<div align="center">
</div>
<DIV align="center">
</DIV>
