<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Product.ascx.vb" Inherits="Trade.Product" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<asp:DataList id="DLProduct" runat="server">
	<ItemTemplate>
		<TABLE id="Table9" cellSpacing="1" cellPadding="1" width="300" border="0">
			<TR>
				<TD colSpan="2">
					<asp:Label id=lblProductName runat="server" Width="282px" Text='<%# DataBinder.Eval(Container, "DataItem.product_name") %>'>
					</asp:Label>
					<asp:Button id="cmddetail" runat="server" Height="23px" Text="Details"></asp:Button></TD>
			</TR>
			<TR>
				<TD>
					<asp:HyperLink id=producthyperlink runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.short_desc") %>' ImageUrl='<%# DataBinder.Eval(Container, "DataItem.short_image_url") %>' NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.product_web_url") %>'>
					</asp:HyperLink></TD>
				<TD>
					<asp:Label id=lblShortDescription runat="server" Width="233px" Height="34px" Text='<%# DataBinder.Eval(Container, "DataItem.short_desc") %>'>
					</asp:Label></TD>
			</TR>
		</TABLE>
	</ItemTemplate>
</asp:DataList>
