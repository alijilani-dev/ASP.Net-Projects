<%@ Page language="c#" Codebehind="servicesview.aspx.cs" Inherits="BizRunner.taskview" AutoEventWireup="false" %>
<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<HEAD>
	<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
	<meta content="C#" name="CODE_LANGUAGE">
	<meta content="http://schemas.microsoft.com/Mobile/Page" name="vs_targetSchema">
</HEAD>
<body Xmlns:mobile="http://schemas.microsoft.com/Mobile/WebForm">
	<mobile:form id="frmServicesView" title="Task View" Wrapping="NoWrap" runat="server">
		<mobile:SelectionList id="SelectionList1" runat="server"></mobile:SelectionList>
		<mobile:List id="ServicesList" runat="server" Wrapping="NoWrap" Font-Name="Verdana" Font-Size="Small"
			Decoration="Numbered" DataTextField="Title" DataValueField="Id" Alignment="Left"></mobile:List>
		<mobile:Command id="cmdAddNew" runat="server">Add new Service</mobile:Command>
		<mobile:Command id="cmdBacktoControlPanel" runat="server">Back to Control Panel</mobile:Command>
	</mobile:form>
	<mobile:form id="frmServicesDetails" title="Customer View" Wrapping="NoWrap" runat="server" StyleReference="subcommand"
		Alignment="Left">
		<TABLE id="Table1" cellSpacing="1" cellPadding="1" border="1">
			<TR>
				<TD width="142" colSpan="2">
					<mobile:Label id="lblTitle" runat="server">Service Title:</mobile:Label>
				</TD>
				<TD width="100">
					<mobile:TextBox id="txtTitle" runat="server"></mobile:TextBox>
				</TD>
				<TD>
					<mobile:Label id="lblStatus" runat="server">Status:</mobile:Label>
				</TD>
				<TD width="100">
					<mobile:TextBox id="txtStatus" runat="server"></mobile:TextBox>
				</TD>
			</TR>
			<TR>
				<TD width="142" colSpan="2" height="3">
					<mobile:Label id="lblStartDate" runat="server">Start Date:</mobile:Label>
				</TD>
				<TD width="100" height="3">
					<mobile:TextBox id="txtStartDate" runat="server"></mobile:TextBox>
				</TD>
				<TD width="100" height="3">
					<mobile:Label id="lblEndDate" runat="server">End Date:</mobile:Label>
				</TD>
				<TD width="100" height="3">
					<mobile:TextBox id="txtEndDate" runat="server"></mobile:TextBox>
				</TD>
			</TR>
			<TR>
				<TD width="142" colSpan="2" height="3">
					<mobile:Label id="lblCustomerName" runat="server">Customer Name:</mobile:Label>
				</TD>
				<TD width="100" height="3">
					<mobile:TextBox id="txtCustomerName" runat="server"></mobile:TextBox>
				</TD>
				<TD width="100" height="3">
					<mobile:Label id="lblRepresentativeName" runat="server">Representative Name:</mobile:Label>
				</TD>
				<TD width="100" height="3">
					<mobile:TextBox id="txtRepresentativeName" runat="server"></mobile:TextBox>
				</TD>
			</TR>
			<TR>
				<TD width="142" colSpan="2" height="3">
					<mobile:Label id="lblType" runat="server">Service Type</mobile:Label>
				</TD>
				<TD width="100" height="3">
					<mobile:TextBox id="txtType" runat="server"></mobile:TextBox>
				</TD>
				<TD width="100" height="3">
					<mobile:Label id="lblCategory" runat="server">Category</mobile:Label>
				</TD>
				<TD width="100" height="3">
					<mobile:SelectionList id="slCategory" runat="server"></mobile:SelectionList>
				</TD>
			</TR>
			<TR>
				<TD width="142" colSpan="2" height="3">
					<mobile:Label id="lblDescription" runat="server">Description</mobile:Label>
				</TD>
				<TD width="100" height="3">
					<mobile:TextBox id="txtDescription" runat="server"></mobile:TextBox>
				</TD>
				<TD width="100" height="3"></TD>
				<TD width="100" height="3"></TD>
			</TR>
			<TR>
				<TD width="142" colSpan="2" height="3"></TD>
				<TD width="100" height="3"></TD>
				<TD width="100" height="3"></TD>
				<TD width="100" height="3"></TD>
			</TR>
			<TR>
				<TD width="142" colSpan="2" height="3">
					<mobile:Command id="cmdPrev" runat="server">&lt;</mobile:Command>
				</TD>
				<TD width="100" height="3">
					<mobile:Command id="cmdCosts" runat="server">Manage Costs</mobile:Command>
				</TD>
				<TD width="100" height="3">
					<mobile:Command id="cmdSales" runat="server">Manage Sales</mobile:Command>
				</TD>
				<TD width="100" height="3">
					<mobile:Command id="cmdNext" runat="server">&gt;</mobile:Command>
				</TD>
			</TR>
			<TR>
				<TD width="142" colSpan="2" height="3">
					<mobile:Command id="cmdAdd" runat="server">Add Service</mobile:Command>
				</TD>
				<TD width="100" colSpan="2" height="3">
					<mobile:Command id="cmdUpdate" runat="server">Update Service</mobile:Command>
				</TD>
				<TD width="100" height="3">
					<mobile:Command id="cmdDelete" runat="server">Delete Service</mobile:Command>
				</TD>
			</TR>
			<TR>
				<TD width="142" colSpan="2" height="3">
					<mobile:Command id="cmdBack" runat="server">Back</mobile:Command>
				</TD>
				<TD width="100" height="3"></TD>
				<TD width="100" height="3"></TD>
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
		BackColor="LightBlue" Alignment="Left" ForeColor="IndianRed">
		<mobile:Label id="lblHeading" runat="server" ForeColor="Black" Font-Bold="True">Message:</mobile:Label>
		<mobile:Label id="lblMsg" runat="server"></mobile:Label>
		<mobile:Command id="cmdBacktoRec" runat="server" ForeColor="Black">Back to Record</mobile:Command>
	</mobile:Form>
</body>
