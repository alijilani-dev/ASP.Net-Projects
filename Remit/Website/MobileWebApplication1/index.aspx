<%@ Page language="c#" Codebehind="index.aspx.cs" Inherits="MobileWebApplication1.MobileWebForm1" AutoEventWireup="false" %>
<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<HEAD>
	<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
	<meta name="CODE_LANGUAGE" content="C#">
	<meta name="vs_targetSchema" content="http://schemas.microsoft.com/Mobile/Page">
</HEAD>
<body Xmlns:mobile="http://schemas.microsoft.com/Mobile/WebForm">
	<mobile:Form id="Form1" runat="server" Wrapping="NoWrap">
		<P>
			<mobile:Label id="lblName" runat="server" Wrapping="Wrap">Name :</mobile:Label>
			<mobile:TextBox id="TextBox1" runat="server" Wrapping="Wrap" Size="20"></mobile:TextBox>
			<mobile:Command id="cmdSearch" runat="server">Search</mobile:Command>
		</P>
	</mobile:Form>
</body>
