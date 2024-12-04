<%@ Control Language="vb" AutoEventWireup="false" Codebehind="center_ad.ascx.vb" Inherits="Trade.center_ad" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<P>
	<asp:datalist id="DLAdvertisement" Width="160px" runat="server" Height="168px">
		<ItemTemplate>
			<P>
				<asp:Image id=Img runat="server" ImageUrl='<%# DataBinder.Eval(Container, "DataItem.advert_image_url") %>' AlternateText='<%# DataBinder.Eval(Container, "DataItem.advert_alt_text") %>'>
				</asp:Image></P>
		</ItemTemplate>
	</asp:datalist></P>
