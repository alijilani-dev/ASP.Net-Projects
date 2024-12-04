<%@ Control Language="vb" AutoEventWireup="false" Codebehind="PrivatePolicy.ascx.vb" Inherits="Trade.AboutUs" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<table border="0" height="100%" width="100%">
	<tr>
		<td valign="top">
			<asp:DataList id="DLContent" runat="server" Height="420" Width="100%">
				<ItemTemplate>
					<IFRAME id=HTMLFile Frameborder="0" src='<%# DataBinder.Eval(Container, "DataItem.Content_Text_Url")%>' Width="100%" height="100%" runat="server">
					</IFRAME>
				</ItemTemplate>
			</asp:DataList>
		</td>
	</tr>
</table>
