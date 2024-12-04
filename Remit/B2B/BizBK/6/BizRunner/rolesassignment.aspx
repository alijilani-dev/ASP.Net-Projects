<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<%@ Page language="c#" Codebehind="rolesassignment.aspx.cs" Inherits="BizRunner.RolesAssignment" AutoEventWireup="false" %>
<HEAD>
	<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
	<meta name="CODE_LANGUAGE" content="C#">
	<meta name="vs_targetSchema" content="http://schemas.microsoft.com/Mobile/Page">
</HEAD>
<body Xmlns:mobile="http://schemas.microsoft.com/Mobile/WebForm">
	<P>
		<mobile:Form id="frmRoles" runat="server">
			<mobile:Label id="lblUserName" runat="server" Font-Bold="True" Font-Size="Small" Font-Name="Verdana">User Name</mobile:Label>
			<mobile:SelectionList id="slUsers" runat="server" DataTextField="LoginName" DataValueField="Id"></mobile:SelectionList>
			<mobile:Label id="lblAvailableRoles" runat="server" Font-Bold="True" Font-Size="Small" Font-Name="Verdana">Available Roles (Click to add)</mobile:Label>
			<mobile:List id="lstAvailableRoles" runat="server" Font-Size="Small" Font-Name="Verdana" DataTextField="Name"
				DataValueField="Id" Decoration="Numbered" Wrapping="NoWrap"></mobile:List>
			<mobile:Label id="lblAssignedRoles" runat="server" Font-Bold="True" Font-Size="Small" Font-Name="Verdana">Assigned Roles (Click to remove)</mobile:Label>
			<mobile:List id="lstAssignedRoles" runat="server" DataTextField="Name" DataValueField="Id" Decoration="Numbered"
				Wrapping="NoWrap"></mobile:List>
			<mobile:Command id="cmdOK" runat="server">OK</mobile:Command>
			<mobile:Command id="cmdCancel" runat="server">Cancel</mobile:Command>
		</mobile:Form>
	</P>
	<P>
		<mobile:Form id="frmMessage" title="Message" runat="server" Alignment="Left" BackColor="LightBlue"
			ForeColor="IndianRed" Font-Name="Verdana" Font-Size="Small">
			<mobile:Label id="lblHeading" runat="server" Font-Bold="True" ForeColor="Black">Message:</mobile:Label>
			<mobile:Label id="lblMsg" runat="server"></mobile:Label>
			<mobile:Command id="cmdBacktoRec" runat="server" ForeColor="Black">Back to Record</mobile:Command>
		</mobile:Form>
	</P>
</body>
