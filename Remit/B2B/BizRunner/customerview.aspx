<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<%@ Page language="c#" Codebehind="customerview.aspx.cs" Inherits="BizRunner.customerview" AutoEventWireup="false" %>
<script language="c#" id="Script1" runat="server"></script>
<mobile:form id="frmCustomers" title="Customers View" runat="server" BackColor="LightBlue" Alignment="Left">
	<TABLE id="tblCustomers" cellSpacing="1" cellPadding="1" border="0">
		<TR>
			<TD width="100" colSpan="2">
				<mobile:List id="CustomersList" runat="server" Font-Size="Small" Font-Name="Verdana" Decoration="Numbered"
					StyleReference="title" Wrapping="NoWrap" DataValueField="Id" DataTextField="CompanyName"
					Font-Bold="False"></mobile:List></TD>
		</TR>
		<TR>
			<TD width="100">
				<mobile:Command id="cmdAddCustomer" runat="server">Add new Customer</mobile:Command></TD>
			<TD width="100">
				<mobile:Command id="cmdReturn" runat="server">Return to Control Panel</mobile:Command></TD>
		</TR>
	</TABLE>
</mobile:form>
<mobile:form id="frmCustomerDetails" title="Customer Details" runat="server" BackColor="LightBlue"
	Font-Size="Small" Font-Name="Verdana" StyleReference="subcommand" Wrapping="NoWrap" PagerStyle-NextPageText="Next"
	PagerStyle-PreviousPageText="Previous" PagerStyle-Wrapping="NoWrap" PagerStyle-Alignment="Left"
	Paginate="True" Alignment="Left">
	<TABLE id="tblDetails" cellSpacing="1" cellPadding="1" border="0">
		<TR>
			<TD width="100" colSpan="2">
				<mobile:Label id="lblCompanyName" runat="server" Font-Bold="True">Company Name:</mobile:Label></TD>
			<TD width="100">
				<mobile:TextBox id="txtCompanyName" runat="server" EnableViewState="False"></mobile:TextBox></TD>
			<TD>
				<mobile:Label id="lblDate" runat="server" Font-Bold="True">Telephone:</mobile:Label></TD>
			<TD width="100">
				<mobile:TextBox id="txtTelephone" runat="server" EnableViewState="False"></mobile:TextBox></TD>
		</TR>
		<TR>
			<TD width="100" colSpan="2" height="3">
				<mobile:Label id="lblContactName" runat="server" Font-Bold="True">Contact Name:</mobile:Label></TD>
			<TD width="100" height="3">
				<mobile:TextBox id="txtContactName" runat="server" EnableViewState="False"></mobile:TextBox></TD>
			<TD width="100" height="3">
				<mobile:Label id="lblStatus" runat="server" Font-Bold="True">Mobile:</mobile:Label></TD>
			<TD width="100" height="3">
				<mobile:TextBox id="txtMobile" runat="server" EnableViewState="False"></mobile:TextBox></TD>
		</TR>
		<TR>
			<TD width="100" colSpan="2" height="3">
				<mobile:Label id="lblType" runat="server" Font-Bold="True">Address:</mobile:Label></TD>
			<TD width="100" colSpan="3" height="3">
				<mobile:TextBox id="txtAddress" runat="server" EnableViewState="False" Size="40"></mobile:TextBox></TD>
		</TR>
		<TR>
			<TD width="100" colSpan="2" height="3">
				<mobile:Label id="lblEmail" runat="server" Font-Bold="True">Email:</mobile:Label></TD>
			<TD width="100" height="3">
				<mobile:TextBox id="txtEmail" runat="server" EnableViewState="False"></mobile:TextBox></TD>
			<TD width="100" height="3"></TD>
			<TD width="100" height="3"></TD>
		</TR>
		<TR>
			<TD width="100" colSpan="2" height="3">
				<mobile:Command id="cmdPrevious" runat="server">&lt;</mobile:Command></TD>
			<TD width="100" colSpan="2" height="3">
				<mobile:Command id="cmdManageServices" runat="server">Manage Services</mobile:Command></TD>
			<TD width="100" height="3">
				<mobile:Command id="cmdNext" runat="server">&gt;</mobile:Command></TD>
		</TR>
		<TR>
			<TD width="100" colSpan="2" height="3">
				<mobile:Command id="cmdAdd" runat="server">Add Customer</mobile:Command></TD>
			<TD width="100" colSpan="2" height="3">
				<mobile:Command id="cmdUpdate" runat="server">Update Customer</mobile:Command></TD>
			<TD width="100" height="3">
				<mobile:Command id="cmdDelete" runat="server">Delete Customer</mobile:Command></TD>
		</TR>
		<TR>
			<TD width="100" colSpan="2" height="3">
				<mobile:Command id="cmdBack" runat="server">Back</mobile:Command></TD>
			<TD width="100" colSpan="2" height="3"></TD>
			<TD width="100" height="3">
				<mobile:Command id="cmdCancel" runat="server">Cancel</mobile:Command></TD>
		</TR>
		<TR>
			<TD width="100" colSpan="5" height="3"></TD>
		</TR>
	</TABLE>
</mobile:form>
<mobile:Form id="frmMessage" title="Message" runat="server" Font-Size="Small" Font-Name="Verdana"
	BackColor="LightBlue" ForeColor="IndianRed" Alignment="Left">
	<mobile:Label id="lblHeading" runat="server" Font-Bold="True" ForeColor="Black">Message:</mobile:Label>
	<mobile:Label id="lblMsg" runat="server"></mobile:Label>
	<mobile:Command id="cmdBacktoRec" runat="server" ForeColor="Black">Back to Record</mobile:Command>
</mobile:Form></TR></TBODY></TABLE>
