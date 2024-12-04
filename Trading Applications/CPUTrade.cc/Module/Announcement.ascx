<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Announcement.ascx.vb" Inherits="Trade.Announcement" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<asp:DataList id="DLAnnouncement" runat="server" Width="100%">
	<HeaderTemplate>
		<asp:Label id="Label2" runat="server" Font-Bold="True" ForeColor="#C04000" Font-Size="Larger">General Anouncements</asp:Label>
	</HeaderTemplate>
	<ItemTemplate>
		<TABLE id="Table1" cellSpacing="5" cellPadding="1" width="100%" border="0" class="normaltext">
			<TR>
				<TD bgColor="#0066ff">
					<asp:HyperLink id="lnkPressHead" runat="server" ForeColor="White" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.ann_TextLink_Url") %>' Target=_blank>
						<%# DataBinder.Eval(Container, "DataItem.ann_Heading") %>
					</asp:HyperLink></TD>
			</TR>
			<TR>
				<TD>
					<asp:Label id="lblPostedOn" runat="server" ForeColor="#C04000" Font-Italic="True" Font-Size="X-Small">
						<%# DataBinder.Eval(Container, "DataItem.timestamp") %>
					</asp:Label></TD>
			</TR>
			<TR>
				<TD>
					<asp:Label id="lblDetail" runat="server">
						<%# DataBinder.Eval(Container, "DataItem.ann_text") %>
					</asp:Label></TD>
			</TR>
			<TR>
				<TD></TD>
			</TR>
		</TABLE>
	</ItemTemplate>
</asp:DataList>
