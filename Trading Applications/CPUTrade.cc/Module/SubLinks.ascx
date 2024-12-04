<%@ Control Language="vb" AutoEventWireup="false" Codebehind="SubLinks.ascx.vb" Inherits="Trade.SubLinks" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<table align="center" runat="server">
	<tr>
		<TD vAlign="middle" runat="server" visible="false">
			<asp:Label id="lblUsers" runat="server" CssClass="normaltext" Font-Bold="True" Visible="False">Label</asp:Label></TD>
		<td>
			<asp:DataList id="DLSublinks" RepeatColumns="6" RepeatDirection="Horizontal" runat="server" EnableViewState="False"
				valign="middle">
				<ItemTemplate>
					<asp:HyperLink id=HyperLink1 CssClass="memenu" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Sub_Link_Name") %>' NavigateUrl='<%# "../PortalDefault.aspx?Main_Links_ID=" &amp; DataBinder.Eval(Container, "DataItem.Main_Links_ID") &amp; "&amp;sub_Links_ID=" &amp; DataBinder.Eval(Container, "DataItem.Sub_Links_ID") %>'>
					</asp:HyperLink>
				</ItemTemplate>
			</asp:DataList></td>
	</tr>
</table>
