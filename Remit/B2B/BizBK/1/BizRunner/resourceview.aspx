<%@ Page language="c#" Codebehind="resourceview.aspx.cs" Inherits="BizRunner.resourceview" AutoEventWireup="false" %>
<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<HEAD>
	<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
	<meta name="CODE_LANGUAGE" content="C#">
	<meta name="vs_targetSchema" content="http://schemas.microsoft.com/Mobile/Page">
</HEAD>
<body Xmlns:mobile="http://schemas.microsoft.com/Mobile/WebForm">
	<mobile:Form id="frmResourceView" runat="server" title="Sales View">
		<mobile:List id="lstResources" runat="server" DataTextField="Name" DataValueField="Id" Decoration="Numbered"
			Font-Size="Small" Font-Name="Verdana" Wrapping="NoWrap"></mobile:List>
		<mobile:Label id="lblTotalCost" runat="server" Font-Size="Small" Font-Name="Verdana" Font-Bold="True">Total Cost:</mobile:Label>
		<mobile:Label id="lblTotalResCost" runat="server"></mobile:Label>
		<mobile:Command id="cmdAddNew" runat="server">Add new Resource</mobile:Command>
	</mobile:Form>
<mobile:form id="frmResourceDetails" title="Resource Details" runat="server" Wrapping="NoWrap"
		StyleReference="subcommand" Alignment="Left">
		<TABLE id="Table2" cellSpacing="1" cellPadding="1" border="1">
			<TR>
				<TD width="142" colSpan="2">
					<mobile:Label id="lblTitle" runat="server">Resource Title:</mobile:Label>
				</TD>
				<TD width="100">
					<mobile:TextBox id="txtTitle" runat="server"></mobile:TextBox>
				</TD>
				<TD width="151">
					<mobile:Label id="lblCost" runat="server">Cost:</mobile:Label>
				</TD>
				<TD width="100">
					<mobile:TextBox id="txtCost" runat="server"></mobile:TextBox>
				</TD>
			</TR>
			<TR>
				<TD width="142" colSpan="2" height="3">
					<mobile:Label id="lblDescription" runat="server">Description</mobile:Label>
				</TD>
				<TD width="100" height="3">
					<mobile:TextBox id="txtDescription" runat="server"></mobile:TextBox>
				</TD>
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
					<mobile:Command id="cmdCosts" runat="server">Manage</mobile:Command>
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
					<mobile:Command id="cmdAdd" runat="server">Add Resource</mobile:Command>
				</TD>
				<TD width="325" colSpan="2" height="3">
					<mobile:Command id="cmdUpdate" runat="server" Alignment="Left">Update Resource</mobile:Command>
				</TD>
				<TD width="100" height="3">
					<mobile:Command id="cmdDelete" runat="server">Delete Resource</mobile:Command>
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
	</mobile:form>Name
<mobile:Form id="frmMessage" title="Message" runat="server" Font-Name="Verdana" Font-Size="Small"
		Alignment="Left" BackColor="LightBlue" ForeColor="IndianRed">
		<mobile:Label id="lblHeading" runat="server" ForeColor="Black" Font-Bold="True">Message:</mobile:Label>
		<mobile:Label id="lblMsg" runat="server"></mobile:Label>
		<mobile:Command id="cmdBacktoRec" runat="server" ForeColor="Black">Back to Record</mobile:Command>
	</mobile:Form>
</body>
