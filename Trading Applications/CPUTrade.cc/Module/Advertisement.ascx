<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Advertisement.ascx.vb" Inherits="Trade.Advertisement" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" border="0" align="center" width="130">
	<TR>
		<TD vAlign="middle" align="center"> 
			<a href="../PortalDefault.aspx?Main_Links_ID=34" ><asp:Image id="imgAdvTop" runat="server" ImageUrl="../images/bar_ad_top.gif" BorderWidth="1px" BorderColor="#CCCCCC"></asp:Image></a></TD>
	</TR>
	<TR>
		<TD vAlign="middle" align="center">
			<asp:datalist id="DLAdvertisement" runat="server" width="130px" CellPadding="2" HorizontalAlign="Center"
				CellSpacing="2">
				<ItemStyle HorizontalAlign="Center"></ItemStyle>
				<ItemTemplate>
					<asp:HyperLink id="Img" BorderWidth="1px" BorderColor="#CCCCCC" ImageUrl='<%# "../" &amp; DataBinder.Eval(Container, "DataItem.advert_image_url") %>' runat="server" AlternateText='<%# DataBinder.Eval(Container, "DataItem.advert_alt_text") %>' NavigateUrl='<%# "../PortalDefault.aspx?Main_Links_ID=2&Member_ID=" & DataBinder.Eval(Container, "DataItem.member_id") %>'>
					</asp:HyperLink>
				</ItemTemplate>
			</asp:datalist>
			<asp:AdRotator id="AdImgRotator" runat="server"></asp:AdRotator></TD>
	</TR>
	<TR>
		<TD align="center" vAlign="middle">
			<asp:Image id="imgAdvBottom" runat="server" ImageUrl="../images/bar_ad_bottom.gif"></asp:Image></TD>
	</TR>
</TABLE>
