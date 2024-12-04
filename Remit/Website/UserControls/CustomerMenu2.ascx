<%@ Control Language="c#" AutoEventWireup="false" Codebehind="CustomerMenu2.ascx.cs" Inherits="Evernet.MoneyExchange.UserControls.CustomerMenu2" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<table width="100%" border="0" cellspacing="0" cellpadding="0">
	<tr>
		<td align="center">
			<!-- See Comments/Comments.xml(CommentID: 28020501)
				<asp:HyperLink id="Hyperlink1" ImageUrl="/images/layoutImages/Menu2_N_TransactionMan.png"
				NavigateUrl="/Customer/ManageTransaction.aspx" runat="server"></asp:HyperLink></td>->

			<asp:HyperLink id="hlnkTransactionManager" ForeColor="LightGray" style="TEXT-DECORATION:none" ToolTip="Transaction Management"
				Font-Size="x-small" Font-Names="helvetica" NavigateUrl="/Customer/ManageTransaction.aspx" runat="server">Transaction Management</asp:HyperLink></td>
	</tr>
	<tr>
		<td align="center">
			<!-- See Comments/Comments.xml(CommentID: 28020501)
				<asp:HyperLink id="Hyperlink1" runat="server" ImageUrl="/images/layoutImages/Menu2_N_ViewExchangeRate.png"></asp:HyperLink></td>->
			<asp:HyperLink id="hlnkViewExchangeRate" ForeColor="LightGray" style="TEXT-DECORATION:none" ToolTip="View Exchange Rates"
				Font-Size="x-small" Font-Names="helvetica" runat="server">View Exchange Rates</asp:HyperLink></td>
	</tr>
	<tr>
		<td align="center">
			<!-- See Comments/Comments.xml(CommentID: 28020501)
			<asp:HyperLink id="hlnkChangePassword" runat="server" ImageUrl="/images/layoutImages/Menu2_N_ChangeLoginPassword.png"></asp:HyperLink></td>->
			<asp:HyperLink id="hlnkChangePassword" ForeColor="LightGray" style="TEXT-DECORATION:none" ToolTip="Change Login Password"
				Font-Size="x-small" Font-Names="helvetica" runat="server">Change Login Password</asp:HyperLink></td>
	</tr>
</table>
