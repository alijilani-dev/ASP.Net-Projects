<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Carrers.ascx.vb" Inherits="Trade.Carrers" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<asp:DataList id="DLCareers" runat="server">
	<ItemTemplate>
		<asp:Literal id=lt_anntext runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.career_text") %>'>
		</asp:Literal>
	</ItemTemplate>
</asp:DataList>
