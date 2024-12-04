<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<%@ Page language="c#" Codebehind="securityview.aspx.cs" Inherits="BizRunner.securityview" AutoEventWireup="false" %>
<HEAD>
	<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
	<meta name="CODE_LANGUAGE" content="C#">
	<meta name="vs_targetSchema" content="http://schemas.microsoft.com/Mobile/Page">
</HEAD>
<body Xmlns:mobile="http://schemas.microsoft.com/Mobile/WebForm">
	<mobile:Form id="frmSecurityView" runat="server" title="Security View">
		<mobile:List id="lstSecurity" runat="server" Wrapping="NoWrap" Font-Name="Verdana" Font-Size="Small"
			Decoration="Numbered" DataValueField="Id" DataTextField="LoginName"></mobile:List>
		<mobile:Label id="lblTotalCost" runat="server" Font-Name="Verdana" Font-Size="Small" Font-Bold="True">Total Users:</mobile:Label>
		<mobile:Label id="lblTotalUsers" runat="server"></mobile:Label>
		<mobile:Command id="cmdAddNew" runat="server">Add new User</mobile:Command>
		<mobile:Command id="cmdBacktoControlPanel" runat="server">Back to Control Panel</mobile:Command>
	</mobile:Form>
	<mobile:form id="frmUserDetails" title="User Details" runat="server" Wrapping="NoWrap" StyleReference="subcommand"
		Alignment="Left">
		<TABLE id="Table2" cellSpacing="1" cellPadding="1" border="1">
			<TR>
				<TD width="142" colSpan="2">
					<mobile:Label id="lblLoginName" runat="server">LoginName:</mobile:Label>
				</TD>
				<TD width="100">
					<mobile:TextBox id="txtLoginName" runat="server"></mobile:TextBox>
				</TD>
				<TD width="151">
					<mobile:Label id="lblPassword" runat="server">Password:</mobile:Label>
				</TD>
				<TD width="100">
					<mobile:TextBox id="txtPassword" runat="server"></mobile:TextBox>
				</TD>
			</TR>
			<TR>
				<TD width="142" colSpan="2">
					<mobile:Label id="lblFirstName" runat="server">First Name:</mobile:Label>
				</TD>
				<TD width="100">
					<mobile:TextBox id="txtFirstName" runat="server"></mobile:TextBox>
				</TD>
				<TD width="151">
					<mobile:Label id="lblLastName" runat="server">Last Name:</mobile:Label>
				</TD>
				<TD width="100">
					<mobile:TextBox id="txtLastName" runat="server"></mobile:TextBox>
				</TD>
			</TR>
			<TR>
				<TD width="142" colSpan="2">
					<mobile:Label id="lblEmail" runat="server">Email:</mobile:Label>
				</TD>
				<TD width="100">
					<mobile:TextBox id="txtEmail" runat="server"></mobile:TextBox>
				</TD>
				<TD width="151">
					<mobile:Label id="lblMobile" runat="server">Mobile No:</mobile:Label>
				</TD>
				<TD width="100">
					<mobile:TextBox id="txtMobile" runat="server"></mobile:TextBox>
				</TD>
			</TR>
			<TR>
				<TD width="142" colSpan="2" height="3"></TD>
				<TD width="100" height="3"></TD>
				<TD width="151" height="3"></TD>
				<TD width="100" height="3"></TD>
			</TR>
			<TR>
				<TD width="142" colSpan="2" height="3"></TD>
				<TD width="100" height="3"></TD>
				<TD width="151" height="3"></TD>
				<TD width="100" height="3"></TD>
			</TR>
			<TR>
				<TD width="142" colSpan="2" height="3">
					<mobile:Command id="cmdPrev" runat="server">&lt;</mobile:Command>
				</TD>
				<TD width="100" height="3">
					<mobile:Command id="cmdRoles" runat="server">Manage Roles</mobile:Command>
				</TD>
				<TD width="151" height="3">
					<mobile:Command id="cmdSales" runat="server">Manage</mobile:Command>
				</TD>
				<TD width="100" height="3">
					<mobile:Command id="cmdNext" runat="server">&gt;</mobile:Command>
				</TD>
			</TR>
			<TR>
				<TD width="142" colSpan="2" height="3">
					<mobile:Command id="cmdAdd" runat="server">Add User</mobile:Command>
				</TD>
				<TD width="325" colSpan="2" height="3">
					<mobile:Command id="cmdUpdate" runat="server" Alignment="Left">Update User</mobile:Command>
				</TD>
				<TD width="100" height="3">
					<mobile:Command id="cmdDelete" runat="server">Delete User</mobile:Command>
				</TD>
			</TR>
			<TR>
				<TD width="142" colSpan="2" height="3">
					<mobile:Command id="cmdBack" runat="server">Back</mobile:Command>
				</TD>
				<TD width="100" height="3">
					<mobile:Command id="Command4" runat="server">Update Resource</mobile:Command>
				</TD>
				<TD width="151" height="3">
					<mobile:Command id="Command5" runat="server">Add Resource</mobile:Command>
				</TD>
				<TD width="100" height="3">
					<mobile:Command id="cmdCancel" runat="server">Cancel</mobile:Command>
				</TD>
			</TR>
			<TR>
				<TD width="100" colSpan="5" height="3"></TD>
			</TR>
		</TABLE>
	</mobile:form>
	<mobile:Form id="frmMessage" title="Message" runat="server" Font-Name="Verdana" Font-Size="Small"
		Alignment="Left" BackColor="LightBlue" ForeColor="IndianRed">
		<mobile:Label id="lblHeading" runat="server" Font-Bold="True" ForeColor="Black">Message:</mobile:Label>
		<mobile:Label id="lblMsg" runat="server"></mobile:Label>
		<mobile:Command id="cmdBacktoRec" runat="server" ForeColor="Black">Back to Record</mobile:Command>
	</mobile:Form>
</body>
