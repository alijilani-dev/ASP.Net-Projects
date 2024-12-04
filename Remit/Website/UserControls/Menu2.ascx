<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Menu2.ascx.cs" Inherits="Evernet.MoneyExchange.UserControls.Menu2" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<table id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0" runat="server">
	<tr id="tr_Spacer" runat="server" visible="true">
		<td id="td_Spacer" runat="server" visible="true">&nbsp;<asp:image id="img_Spacer" runat="server" ImageUrl="../images/layoutImages/spacer.jpg"></asp:image></td>
	</tr>
	<tr id="tr_CurrencyManager" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkCurrencyManager" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Currency Management" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/WebFormList_CurrencyList.aspx"
				Visible="False" Font-Bold="True">Currency Management</asp:hyperlink></td>
	</tr>
	<tr id="tr_SCurrencyManager" runat="server" visible="false">
		<td id="td_SCurrencyManager" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="tr_CountryManager" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkCountryManager" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Country Management" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/WebFormList_CountryList.aspx"
				Visible="False" Font-Bold="True">Country Management</asp:hyperlink></td>
	</tr>
	<tr id="tr_SCountryManager" runat="server" visible="false">
		<td id="td_SCountryManager" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="tr_PurposeOfTransfer" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkPurposeOfTransfer" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Purpose of Transfer" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="../Admin/WebFormList_PurposeOfTransferList.aspx"
				Visible="False" Font-Bold="True">Purpose of Transfer</asp:hyperlink></td>
	</tr>
	<tr id="tr_SPurposeOfTransfer" runat="server" visible="false">
		<td id="td_SPurposeOfTransfer" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="tr_CountryMOP" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkCountryMOP" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Country - Mode of Payment" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/WebFormList_CountryAvailablePaymentModeList.aspx"
				Visible="False" Font-Bold="True">Country - Mode of Payment</asp:hyperlink></td>
	</tr>
	<tr id="tr_SCountryMOP" runat="server" visible="false">
		<td id="td_SCountryMOP" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="tr_CountryPermissionList" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkCountryPermissionList" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Country Permission List" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="../Admin/WebFormList_CountryTransactionPermissionList.aspx"
				Visible="False" Font-Bold="True">Country Permission List</asp:hyperlink></td>
	</tr>
	<tr id="tr_SCountryPermissionList" runat="server" visible="false">
		<td id="td_SCountryPermissionList" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="tr_BankExchangeRate" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkBankExchangeRate" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Exchange Rates" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="../Admin/WebFormList_BankExchangeRateList.aspx"
				Visible="false" Font-Bold="True"> Exchange Rates</asp:hyperlink></td>
	</tr>
	<tr id="tr_SBankExchangeRate" runat="server" visible="false">
		<td id="td_SBankExchangeRate" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="tr_AgencyExchangeMargin" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkAgencyExchangeMargin" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="SR Exchange Margin" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="../Admin/WebFormList_AgencyExchangeRateList.aspx"
				Visible="false" Font-Bold="True">SR Exchange Margin</asp:hyperlink></td>
	</tr>
	<tr id="tr_SAgencyExchangeMargin" runat="server" visible="false">
		<td id="td_SAgencyExchangeMargin" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="tr_AgentExchangeMargin" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkAgentExchangeMargin" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Agent Exchange Margin" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="../Admin/WebFormList_AgentExchangeRateList.aspx"
				Visible="false" Font-Bold="True">Agent Exchange Margin</asp:hyperlink></td>
	</tr>
	<tr id="tr_SAgentExchangeMargin" runat="server" visible="false">
		<td id="td_SAgentExchangeMargin" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="tr_CommissionSlabManager" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkCommissionSlabManager" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Commission Slabs" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="../Admin/WebFormList_CommissionSlabMaster.aspx"
				Visible="false" Font-Bold="True"> Commission Slabs</asp:hyperlink></td>
	</tr>
	<tr id="tr_SCommissionSlabManager" runat="server" visible="false">
		<td id="td_SCommissionSlabManager" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="tr_LocationManager" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkLocationManager" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Location Management" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/WebFormList_LocationList.aspx"
				Visible="false" Font-Bold="True">Location Management</asp:hyperlink></td>
	</tr>
	<tr id="tr_SLocationManager" runat="server" visible="false">
		<td id="td_SLocationManager" runat="server" visible="false">&nbsp;</td>
	</tr>
	<TR id="tr_AgentAccountManagement" runat="server" visible="false">
		<TD align="center"><asp:hyperlink id="hlnkAgentAccountManagement" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Agent Accounts" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/WebFormList_AgentMaster.aspx"
				Visible="false" Font-Bold="True">Agent Accounts</asp:hyperlink></TD>
	</TR>
	<tr id="tr_SAgentAccountManagement" runat="server" visible="false">
		<td id="td_SAgentAccountManagement" runat="server" visible="false">&nbsp;</td>
	</tr>
	<TR id="tr_AgentGroupList" runat="server" visible="false">
		<TD align="center"><asp:hyperlink id="hlnkAgentGroupList" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Agent Groups" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="../Admin/WebFormList_AgentGroupList.aspx"
				Visible="False" Font-Bold="True"> Agent Groups</asp:hyperlink></TD>
	</TR>
	<tr id="tr_SAgentGroupList" runat="server" visible="false">
		<td id="td_SAgentGroupList" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="tr_AgentManager" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkAgentManager" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Agent Management" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/WebFormList_AgentLocationList.aspx"
				Visible="false" Font-Bold="True">Agent Management</asp:hyperlink></td>
	</tr>
	<tr id="tr_SAgentManager" runat="server" visible="false">
		<td id="td_SAgentManager" runat="server" visible="false">&nbsp;</td>
	</tr>
	<TR id="tr_AgentMOP" runat="server" visible="false">
		<TD align="center"><asp:hyperlink id="hlnkAgentMOP" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Agent - Mode of Payment" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="../Admin/WebFormList_AgentAvailablePaymentModeList.aspx"
				Visible="False" Font-Bold="True">Agent - Mode of Payment</asp:hyperlink></TD>
	</TR>
	<tr id="tr_SAgentMOP" runat="server" visible="false">
		<td id="td_SAgentMOP" runat="server" visible="false">&nbsp;</td>
	</tr>
	<TR id="tr_BankMOP" runat="server" visible="false">
		<TD align="center"><asp:hyperlink id="hlnkBankMOP" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Bank - Mode of Payment" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="../Admin/BankAvailablePaymentModeList.aspx"
				Visible="False" Font-Bold="True">Bank - Mode of Payment</asp:hyperlink></TD>
	</TR>
	<tr id="tr_SBankMOP" runat="server" visible="false">
		<td id="td_SBankMOP" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="tr_BankManager" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkBankManager" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Bank Management" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/WebFormList_BankList.aspx"
				Visible="False" Font-Bold="True">Bank Management</asp:hyperlink></td>
	</tr> <!-- Added by Ali  05 March 2005.->
  <tr id="tr_SBankManager" runat="server" visible="false">
		<td id="td_SBankManager" runat="server" visible="false">&nbsp;</td>
	</tr> <!-- Added code finishes here. ->
  <tr id="tr_TransactionManager" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkTransactionManager" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Transaction Management" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/ManageTransaction.aspx"
				Visible="False" Font-Bold="True">Transaction Management</asp:hyperlink></td>
	</tr>
	<tr id="tr_STransactionManager" runat="server" visible="false">
		<td id="td_STransactionManager" runat="server" visible="false">&nbsp;</td>
	</tr>
	<TR id="tr_InitiateTransaction" runat="server" visible="false">
		<TD align="center"><asp:hyperlink id="hlnkInitiateTransaction" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Send" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/InitiateTransfer.aspx" Visible="false"
				Font-Bold="True">Send</asp:hyperlink></TD>
	</TR>
	<tr id="tr_SInitiateTransaction" runat="server" visible="false">
		<td id="td_SInitiateTransaction" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="Tr_SInitiateTransfer" runat="server" visible="false">
		<td id="Td_SInitiateTransfer" runat="server" visible="false">&nbsp;</td>
	</tr>
	<TR id="tr_DailyRates" runat="server" visible="false">
		<TD id="td_DailyRates" align="center"><asp:hyperlink id="hlnkDailyRates" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Daily Rates" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/DailyRates.aspx" Visible="false" Font-Bold="True">Daily Rates</asp:hyperlink></TD>
	</TR>
	<tr id="Tr_SDailyRates" runat="server" visible="false">
		<td id="Td_SDailyRates" runat="server" visible="false">&nbsp;</td>
	</tr>
	<TR id="tr_IncomingTransaction" runat="server" visible="false">
		<TD align="center"><asp:hyperlink id="hlnkIncomingTransaction" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Receive" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/ViewIncomingTransaction.aspx"
				Visible="false" Font-Bold="True">Receive</asp:hyperlink></TD>
	</TR>
	<tr id="tr_SIncomingTransaction" runat="server" visible="false">
		<td id="td_SIncomingTransaction" runat="server" visible="false">&nbsp;</td>
	</tr>
	<TR id="tr_PendingTransaction" runat="server" visible="false">
		<TD align="center"><asp:hyperlink id="hlnkPendingTransaction" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Pending for Approval" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/ViewPendingTransaction.aspx"
				Visible="false" Font-Bold="True">Pending for Approval</asp:hyperlink></TD>
	</TR>
	<tr id="tr_SPendingTransaction" runat="server" visible="false">
		<td id="td_SPendingTransaction" runat="server" visible="false">&nbsp;</td>
	</tr>
	<TR id="tr_OpenTransaction" runat="server" visible="false">
		<TD style="HEIGHT: 15px" align="center"><asp:hyperlink id="hlnkOpenTransaction" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="View" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/ViewOpenTransaction.aspx" Visible="false" Font-Bold="True">View</asp:hyperlink></TD>
	</TR>
	<tr id="tr_SOpenTransaction" runat="server" visible="false">
		<td id="td_SOpenTransaction" runat="server" visible="false">&nbsp;</td>
	</tr>
	<TR id="tr_ViewDrafts" runat="server" visible="false">
		<TD align="center"><asp:hyperlink id="hlnkViewDrafts" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="View Draft's" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="../Admin/ViewDraftTransactions.aspx"
				Visible="False" Font-Bold="True">View Drafts</asp:hyperlink></TD>
	</TR>
	<tr id="tr_SViewDrafts" runat="server" visible="false">
		<td id="td_SViewDrafts" runat="server" visible="false">&nbsp;</td>
	</tr>
	<TR id="tr_ViewTransactionStatus" runat="server" visible="false">
		<TD align="center"><asp:hyperlink id="hlnkViewTransactionStatus" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="View Transaction Status" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="../Admin/ViewTransactionStatus.aspx"
				Visible="False" Font-Bold="True">View Transaction Status</asp:hyperlink></TD>
	</TR>
	<tr id="tr_SViewTransactionStatus" runat="server" visible="false">
		<td id="td_SViewTransactionStatus" runat="server" visible="false">&nbsp;</td>
	</tr>
	<TR id="tr_SentTransactions" runat="server" visible="false">
		<TD align="center"><asp:hyperlink id="hlnkSentTransactions" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Sent Transactions" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/ViewSentTransactions.aspx"
				Visible="False" Font-Bold="True">Sent Transactions</asp:hyperlink></TD>
	</TR>
	<tr id="tr_SSentTransactions" runat="server" visible="false">
		<td id="td_SSentTransactions" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="tr_SRUserManagement" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkSRUserManagement" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="SR Users" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="../Admin/SRUserManagement.aspx" Visible="False"
				Font-Bold="True">SR Users</asp:hyperlink></td>
	</tr>
	<tr id="tr_SSRUserManagement" runat="server" visible="false">
		<td id="td_SSRUserManagement" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="tr_SRUserRole" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkSRUserRole" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="SR User Roles" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="../Admin/SRUserRoleManagement.aspx"
				Visible="False" Font-Bold="True">SR User Roles</asp:hyperlink></td>
	</tr>
	<tr id="tr_SSRUserRole" runat="server" visible="false">
		<td id="td_SSRUserRole" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="tr_UserManager" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkUserManager" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="User Management" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/WebFormList_UserList.aspx"
				Visible="False" Font-Bold="True">User Management</asp:hyperlink></td>
	</tr>
	<tr id="tr_SUserManager" runat="server" visible="false">
		<td id="td_SUserManager" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="tr_UserRoleManagement" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkUserRoleManagement" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="User Roles" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/WebFormList_UserRoleAssignmentList.aspx"
				Visible="False" Font-Bold="True"> User Roles</asp:hyperlink></td>
	</tr>
	<tr id="tr_SUserRoleManagement" runat="server" visible="false">
		<td id="td_SUserRoleManagement" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="tr_CustomerManager" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkCustomerManager" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Customer Management" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/WebFormList_CustomerList.aspx"
				Visible="False" Font-Bold="True">Customer Management</asp:hyperlink></td>
	</tr>
	<tr id="tr_SCustomerManager" runat="server" visible="false">
		<td id="td_SCustomerManager" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="tr_CustomerCardManagement" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkCustomerCardManagement" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Customer Cards" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/WebFormList_CustomerCardList.aspx"
				Visible="false" Font-Bold="True"> Customer Cards</asp:hyperlink></td>
	</tr>
	<tr id="tr_SCustomerCardManagement" runat="server" visible="false">
		<td id="td_SCustomerCardManagement" runat="server" visible="false">&nbsp;</td>
	</tr>
	<TR id="tr_BulkCardAssignment" runat="server" visible="false">
		<TD align="center"><asp:hyperlink id="hlnkBulkCardAssignment" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Bulk Card Assignment" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/BulkCardAssigner.aspx"
				Visible="False" Font-Bold="True">Bulk Card Assignment</asp:hyperlink></TD>
	</TR>
	<tr id="tr_SBulkCardAssignment" runat="server" visible="false">
		<td id="td_SBulkCardAssignment" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="tr_ViewExchangeRate" runat="server" visible="false">
		<td align="center"><asp:hyperlink id="hlnkViewExchangeRate" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="View Exchange Rates" Font-Size="X-Small" Font-Names="Verdana" Visible="False" Font-Bold="True">View Exchange Rates</asp:hyperlink></td>
	</tr>
	<tr id="tr_SViewExchangeRate" runat="server" visible="false">
		<td id="td_SViewExchangeRate" runat="server" visible="false">&nbsp;</td>
	</tr>
	<tr id="tr_ChangePassword" runat="server">
		<td align="center"><asp:hyperlink id="hlnkChangePassword" style="TEXT-DECORATION: none" runat="server" ForeColor="White"
				ToolTip="Change Login Password" Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="../Admin/ChangePassword.aspx"
				Font-Bold="True">Change Login Password</asp:hyperlink></td>
	</tr>
	<tr id="tr_SChangePassword" runat="server">
		<td id="td_SChangePassword" align="center" runat="server">&nbsp;</td>
	</tr>
</table>
