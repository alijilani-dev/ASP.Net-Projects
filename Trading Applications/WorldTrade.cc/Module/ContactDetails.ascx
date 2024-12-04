<%@ Control Language="vb" AutoEventWireup="false" Codebehind="ContactDetails.ascx.vb" Inherits="Trade.ContactDetails" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<asp:DataList id="DLContactDetails" runat="server">
	<ItemTemplate>
		<asp:Literal id=lt_anntext runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.contact_text") %>'>
		</asp:Literal>
	</ItemTemplate>
</asp:DataList>
