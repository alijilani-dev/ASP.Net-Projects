<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<%@ Page language="c#" Codebehind="Results.aspx.cs" Inherits="MobileWebApplication1.Results" AutoEventWireup="false" %>
<HEAD>
	<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
	<meta name="CODE_LANGUAGE" content="C#">
	<meta name="vs_targetSchema" content="http://schemas.microsoft.com/Mobile/Page">
</HEAD>
<body Xmlns:mobile="http://schemas.microsoft.com/Mobile/WebForm">
	<mobile:Form id="Form1" runat="server">
		<mobile:Label id="Label1" runat="server" Wrapping="NoWrap">Label</mobile:Label>
		<mobile:Link id="Link1" runat="server" NavigateUrl="index.aspx">GetData</mobile:Link>
	</mobile:Form>
</body>
