<%@ Control Language="vb" AutoEventWireup="false" ClassName="main_links" Codebehind="Main_Links.ascx.vb" Inherits="Trade.main_links" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<asp:datalist id="DLMainlink" RepeatDirection="Horizontal" runat="server" EnableViewState="False"
	CellPadding="0" HorizontalAlign="Center">
	<SelectedItemStyle VerticalAlign="Top"></SelectedItemStyle>
	<EditItemStyle VerticalAlign="Top"></EditItemStyle>
	<AlternatingItemStyle VerticalAlign="Top"></AlternatingItemStyle>
	<SeparatorStyle VerticalAlign="Top"></SeparatorStyle>
	<ItemStyle VerticalAlign="Top"></ItemStyle>
	<ItemTemplate>
		<asp:Label id="lblMenu" runat="server" Visible="False"></asp:Label>
		<asp:HyperLink id=hprLinks1 runat="server" Visible='<%# DataBinder.Eval(Container, "DataItem.Visible")%>' ImageUrl='<%# "../" &amp; DataBinder.Eval(Container, "DataItem.Img_url")%>' Text='<%# DataBinder.Eval(Container, "DataItem.Link_Name")%>' NavigateUrl='<%# "../PortalDefault.aspx?Main_Links_ID="&amp; DataBinder.Eval(Container, "DataItem.Main_Links_ID")%>'>
		</asp:HyperLink>
		<asp:HyperLink id=HyperLink1 runat="server" Visible='<%# iif(DataBinder.Eval(Container, "DataItem.Visible")=1,false,true)%>' Text='<%# DataBinder.Eval(Container, "DataItem.Link_Name") &amp; " | "%>' NavigateUrl='<%# "../PortalDefault.aspx?Main_Links_ID=" &amp; DataBinder.Eval(Container, "DataItem.Main_Links_ID")%>' cssclass="footer">
		</asp:HyperLink>
	</ItemTemplate>
</asp:datalist>
