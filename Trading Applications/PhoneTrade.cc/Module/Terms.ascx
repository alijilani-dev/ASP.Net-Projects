<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Terms.ascx.vb" Inherits="Trade.AboutUs" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<table width="100%" height="100%" border="0">
	<tr>
		<td valign=top>
			<asp:DataList BorderStyle="none" BorderWidth="0" id="DLContent" runat="server" Height="420" Width="100%">
				<ItemTemplate>
					<IFRAME id=HTMLFile Frameborder="0" src='<%# DataBinder.Eval(Container, "DataItem.Content_Text_Url")%>' width="100%" height="100%"  runat="server">
					</IFRAME>
				</ItemTemplate>
			</asp:DataList>
		</td>
	</tr>
</table>
