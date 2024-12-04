<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Member.ascx.vb" Inherits="Smartphi.Member" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="0">
	<TR>
		<TD style="WIDTH: 173px">New member sign-up form</TD>
		<TD></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 173px">Member / Company name</TD>
		<TD>
			<asp:TextBox id="txtMemberName" runat="server"></asp:TextBox>
			<asp:RequiredFieldValidator id="rfv1" runat="server" ErrorMessage="Please provide Member/Company name" Display="Dynamic"
				ControlToValidate="txtMemberName"></asp:RequiredFieldValidator></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 173px; HEIGHT: 24px">Address</TD>
		<TD style="HEIGHT: 24px">
			<asp:TextBox id="txtAddress" runat="server" TextMode="MultiLine" Width="184px" Height="48px"></asp:TextBox>
			<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="Please provide member/company address"
				Display="Dynamic" ControlToValidate="txtAddress"></asp:RequiredFieldValidator></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 173px">City</TD>
		<TD>
			<asp:TextBox id="txtCity" runat="server"></asp:TextBox></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 173px">Country</TD>
		<TD>
			<asp:DropDownList id="ddlCountry" runat="server" Width="152px"></asp:DropDownList></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 173px">Phone no</TD>
		<TD>
			<asp:TextBox id="txtPhoneNo" runat="server"></asp:TextBox>
			<asp:RequiredFieldValidator id="rfvPhone" runat="server" ErrorMessage="Please provide phone no." Display="Dynamic"
				ControlToValidate="txtPhoneNo"></asp:RequiredFieldValidator></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 173px">Fax No</TD>
		<TD>
			<asp:TextBox id="txtFaxNo" runat="server"></asp:TextBox></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 173px">Contact person name</TD>
		<TD>
			<asp:TextBox id="txtContactperson" runat="server"></asp:TextBox>
			<asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server" ErrorMessage="Please provide contact person name"
				Display="Dynamic" ControlToValidate="txtContactperson"></asp:RequiredFieldValidator></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 173px">Mobile No</TD>
		<TD>
			<asp:TextBox id="txtMobileNo" runat="server"></asp:TextBox>
			<asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server" ErrorMessage="Please provide mobile no"
				Display="Dynamic" ControlToValidate="txtMobileNo"></asp:RequiredFieldValidator></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 173px"></TD>
		<TD></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 173px">User name</TD>
		<TD>
			<asp:TextBox id="txtUserName" runat="server"></asp:TextBox>
			<asp:RequiredFieldValidator id="RequiredFieldValidator6" runat="server" ErrorMessage="Please provide user name"
				Display="Dynamic" ControlToValidate="txtUserName"></asp:RequiredFieldValidator></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 173px"></TD>
		<TD>
			<asp:Button id="btnRegister" runat="server" Text="Register"></asp:Button>&nbsp;
			<asp:Button id="btnCancel" runat="server" Text="Cancel"></asp:Button></TD>
	</TR>
</TABLE>
