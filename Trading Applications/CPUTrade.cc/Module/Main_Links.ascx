<%@ Control Language="vb" AutoEventWireup="false" ClassName="main_links" Codebehind="Main_Links.ascx.vb" Inherits="Trade.main_links" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<asp:datalist id="DLMainlink" RepeatDirection="Horizontal" runat="server" EnableViewState="False"
	CellPadding="0" HorizontalAlign="Center">
	<SelectedItemStyle VerticalAlign="Middle"></SelectedItemStyle>
	<EditItemStyle VerticalAlign="Middle"></EditItemStyle>
	<AlternatingItemStyle VerticalAlign="Middle"></AlternatingItemStyle>
	<ItemStyle VerticalAlign="Middle"></ItemStyle>
	<ItemTemplate>
		<asp:HyperLink id=hprLinks1 runat="server" ImageUrl='<%# "../" &amp; DataBinder.Eval(Container, "DataItem.Img_url")%>' Text='<%# DataBinder.Eval(Container, "DataItem.Link_Name")%>' NavigateUrl='<%# "../PortalDefault.aspx?Main_Links_ID="&amp; DataBinder.Eval(Container, "DataItem.Main_Links_ID")%>' Visible='<%# DataBinder.Eval(Container, "DataItem.Visible")%>'></asp:HyperLink>
		<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Link_Name") &amp; " | "%>' NavigateUrl='<%# "../PortalDefault.aspx?Main_Links_ID=" &amp; DataBinder.Eval(Container, "DataItem.Main_Links_ID")%>' Visible='<%# iif(DataBinder.Eval(Container, "DataItem.Visible")=1,false,true)%>' cssclass="footer"></asp:HyperLink>
	</ItemTemplate>
</asp:datalist>
