<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Menu1.ascx.cs" Inherits="Evernet.MoneyExchange.UserControls.Menu1" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<table width="100%" border="0" cellspacing="0" cellpadding="0">
	<tr align="center">
		<td>
			<asp:HyperLink id="hlnkHome" ForeColor="White" style="TEXT-DECORATION:none" ToolTip="Home" Font-Size="X-Small"
				Font-Names="Verdana" NavigateUrl="/Admin/Home.aspx" runat="server" Font-Bold="True">Home</asp:HyperLink></td>
		<td>
			<asp:HyperLink id="hlnkGlobalSettings" ForeColor="White" style="TEXT-DECORATION:none" ToolTip="Global Settings"
				Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/GlobalSettings.aspx" runat="server"
				Visible="False" Font-Bold="True">Global Settings</asp:HyperLink></td>
		<td>
			<asp:HyperLink id="hlnkReports" ForeColor="White" style="TEXT-DECORATION:none" ToolTip="Reports"
				Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="../Admin/ViewReports.aspx" runat="server"
				Visible="false" Font-Bold="True">Reports</asp:HyperLink></td>
		<td><IMG src="../images/layoutImages/new.gif">
			<asp:HyperLink id="hlnkTracking" ForeColor="White" style="TEXT-DECORATION:none" ToolTip="Tracking"
				Font-Size="X-Small" Font-Names="Verdana" Target="_blank" NavigateUrl="../Tracking/Tracking.aspx" runat="server"
				Visible="true" Font-Bold="True">Tracking</asp:HyperLink></td>
		<td>
			<asp:HyperLink id="hlnkContactUs" ForeColor="White" style="TEXT-DECORATION:none" ToolTip="Contact Us"
				Font-Size="X-Small" Font-Names="Verdana" runat="server" Font-Bold="True" NavigateUrl="../Admin/ContactInfo.aspx">Contact Us</asp:HyperLink></td>
		<TD>
			<asp:HyperLink id="hlnkLogOff" ForeColor="White" style="TEXT-DECORATION:none" ToolTip="Log Off"
				Font-Size="X-Small" Font-Names="Verdana" NavigateUrl="/Admin/Logoff.aspx" runat="server" Font-Bold="True">Log Off</asp:HyperLink></TD>
	</tr>
</table>
