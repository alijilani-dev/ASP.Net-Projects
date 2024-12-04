<%@ Page language="c#" Codebehind="ShowOpenTransaction.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.ShowOpenTransaction" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ShowOpenTransaction</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<P>&nbsp;</P>
			<P>
				<asp:Label id="lblMessage" runat="server"></asp:Label></P>
			<P>Transaction Number
				<asp:TextBox id="txtTransactionNumber" runat="server"></asp:TextBox></P>
			<P>Beneficery First Name
				<asp:TextBox id="txtBeneficeryFirstName" runat="server"></asp:TextBox></P>
			<P>Beneficery Last Name
				<asp:TextBox id="txtBeneficeryLastName" runat="server"></asp:TextBox></P>
			<P>
				<asp:Button id="butProceed" runat="server" Text="Proceed"></asp:Button></P>
		</form>
	</body>
</HTML>
