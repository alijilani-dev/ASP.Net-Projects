<%@ Page language="c#" Codebehind="ObjListTest.aspx.cs" Inherits="BizRunner.TemplatedUI" AutoEventWireup="false" %>
<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<script language="c#" runat="server">
</script>
<mobile:form id="myForm" runat="server">
	<mobile:Label id="Label1" runat="server">.</mobile:Label>
	<mobile:Label id="Label2" runat="server"></mobile:Label>
	<mobile:Command id=Command1 runat="server" Text="Button1" CommandName="Button1" OnItemCommand="Command_Click" CommandArgument='sdfg'>No</mobile:Command>
	<mobile:Command id="Command2" runat="server" Text="Button2" CommandName="Button2" OnItemCommand="Command_Click"	CommandArgument="2">Yes</mobile:Command>
</mobile:form>
