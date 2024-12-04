<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Top_Banner.ascx.vb" Inherits="Trade.Top_Banner" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<asp:datalist id="DLContent" Width="100%" runat="server">
	<ItemTemplate>
		<asp:Image id=Img runat="server" ImageUrl='<%# DataBinder.Eval(Container, "DataItem.Content_Image_Url") %>'>
		</asp:Image><!--../HtmlPages/HTMLPage1.htm -->
	</ItemTemplate>
</asp:datalist>
