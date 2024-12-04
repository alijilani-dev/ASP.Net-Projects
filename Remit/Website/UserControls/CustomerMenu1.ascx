<%@ Control Language="c#" AutoEventWireup="false" Codebehind="CustomerMenu1.ascx.cs" Inherits="Evernet.MoneyExchange.UserControls.CustomerMenu1" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<table width="100%" border="0" cellspacing="0" cellpadding="0">
	<tr align="center">
		<td>
			<asp:HyperLink id="hlnkHome" ImageUrl="/images/layoutImages/Menu1_N_Home.png" NavigateUrl="/Customer/Home.aspx"
				runat="server"></asp:HyperLink></td>
		<td></td>
		<td></td>
		<td></td>
		<td>
			<asp:HyperLink id="hlnkContactUs" runat="server" ImageUrl="/images/layoutimages/Menu1_N_ContactUs.png"></asp:HyperLink></td>
		<TD>
			<asp:HyperLink id="hlnkLogOff" runat="server" NavigateUrl="/Customer/Logoff.aspx" ImageUrl="/images/layoutimages/Menu1_N_Logoff.png"></asp:HyperLink></TD>
	</tr>
</table>
