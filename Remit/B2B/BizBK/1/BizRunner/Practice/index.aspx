<%@ Page language="c#" Codebehind="ObjListTest.aspx.cs" Inherits="BizRunner.TemplatedUI" AutoEventWireup="false" %>
<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<HEAD>
	<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
	<meta content="C#" name="CODE_LANGUAGE">
	<meta content="http://schemas.microsoft.com/Mobile/Page" name="vs_targetSchema">
</HEAD>
<body>
	<mobile:form id="Form1" title="Customers List" runat="server">
		<mobile:Label id="lbl_Message" runat="server" ForeColor="#FF8080" Font-Bold="True" Font-Name="Tahoma"
			Font-Size="Small" Alignment="Left"></mobile:Label>
		<mobile:List id="List1" runat="server" ForeColor="White" Font-Bold="True" Font-Name="Tahoma"
			Font-Size="Small" Alignment="Left" ItemsAsLinks="True" Decoration="Bulleted" ItemsPerPage="10"></mobile:List>
	</mobile:form>
</body>
