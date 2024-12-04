<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<%@ Page language="c#" Codebehind="MobileWebForm1.aspx.cs" Inherits="BizRunner.Practice.MobileWebForm1" AutoEventWireup="false" %>
<body>
	<mobile:form id="Form1" title="Customers List" runat="server">
		<mobile:Label id="lbl_Message" runat="server" Alignment="Left" Font-Size="Small" Font-Name="Tahoma"	Font-Bold="True" ForeColor="#FF8080"></mobile:Label>
		<TABLE>
			<TR>
				<TD width="20" nowrap="true">
					<mobile:List id="List1" runat="server" Alignment="Left" Font-Size="Small" Font-Name="Tahoma" Font-Bold="True" ForeColor="White" ItemsPerPage="10" Decoration="Bulleted" ItemsAsLinks="True"></mobile:List>
				</TD>
				<TD nowrap="true">
					<mobile:List id="List2" runat="server" Alignment="Left" Font-Size="Small" Font-Name="Tahoma" Font-Bold="True" ForeColor="White" ItemsPerPage="10" Decoration="Bulleted" ItemsAsLinks="True"></mobile:List>
				</TD>
			</TR>
		</TABLE>
	</mobile:form>
</body>
