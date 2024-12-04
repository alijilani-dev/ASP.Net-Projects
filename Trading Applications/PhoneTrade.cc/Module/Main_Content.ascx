<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Main_Content.ascx.vb" Inherits="Trade.Main_Content" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" height="100%" border="0">
	<TR>
		<TD>
			<asp:datalist id="DLContent" runat="server" BorderStyle="None" Width="100%" Height="100%">
				<ItemTemplate>
					<asp:Image id=Img runat="server" ImageUrl='<%# DataBinder.Eval(Container, "DataItem.Content_Image_Url") %>' AlternateText="">
					</asp:Image><BR>
					<iframe id=Iframe1 src='<%# DataBinder.Eval(Container.dataitem, "Content_Text_Url")%>' Width="100%" height="100%" runat="server">
					</iframe>
				</ItemTemplate>
			</asp:datalist>
		</TD>
	</TR>
</TABLE>
