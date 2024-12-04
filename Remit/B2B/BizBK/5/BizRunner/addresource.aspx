<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<%@ Page language="c#" Codebehind="addresource.aspx.cs" Inherits="BizRunner.addresource" AutoEventWireup="false" %>
<HEAD>
	<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
	<meta content="C#" name="CODE_LANGUAGE">
	<meta content="http://schemas.microsoft.com/Mobile/Page" name="vs_targetSchema">
</HEAD>
<body Xmlns:mobile="http://schemas.microsoft.com/Mobile/WebForm">
	<mobile:form id="frmAddResource" title="Add Resource" runat="server">
		<TABLE id="Table1" height="316" cellSpacing="1" cellPadding="1" width="320" border="1">
			<TR>
				<TD>
					<mobile:Label id="lblResources" runat="server">Resources</mobile:Label>
				</TD>
				<TD>
					<mobile:SelectionList id="slReources" runat="server"></mobile:SelectionList>
				</TD>
			</TR>
			<TR>
				<TD>
					<mobile:Label id="lblCost" runat="server">Cost</mobile:Label>
				</TD>
				<TD>
					<mobile:TextBox id="txtCost" runat="server"></mobile:TextBox>
				</TD>
			</TR>
			<TR>
				<TD>
					<mobile:Label id="lblDated" runat="server">Dated</mobile:Label>
				</TD>
				<TD>
					<mobile:TextBox id="txtDated" runat="server"></mobile:TextBox>
				</TD>
			</TR>
			<TR>
				<TD>
					<mobile:Label id="lblDescription" runat="server">Description</mobile:Label>
				</TD>
				<TD>
					<mobile:TextBox id="txtDescription" runat="server"></mobile:TextBox>
				</TD>
			</TR>
			<TR>
				<TD>
					<mobile:Command id="cmdOk" runat="server">Ok</mobile:Command>
				</TD>
				<TD>
					<mobile:Command id="cmdCancel" runat="server">Cancel</mobile:Command>
				</TD>
			</TR>
		</TABLE>
	</mobile:form>
</body>
