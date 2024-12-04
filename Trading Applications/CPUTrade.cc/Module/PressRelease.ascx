<%@ Control Language="vb" AutoEventWireup="false" Codebehind="PressRelease.ascx.vb" Inherits="Trade.PressRelease" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR>
		<TD align="center" height="5PX"></TD>
	</TR>
	<TR>
		<TD align="center"><IFRAME style="WIDTH: 650px; HEIGHT: 150px" name="IfAdv" align="middle" src="ScrollerPage/News.htm"
				frameBorder="0" scrolling="no"></IFRAME>
		</TD>
	</TR>
	<TR>
		<TD align="center" height="8PX"></TD>
	</TR>
</TABLE>
<table border="0" width="650" id="table3" cellpadding="2" align="center">
	<tr>
		<td style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid">
		<asp:DataList id="DLPressRelease" runat="server" Width="100%" HorizontalAlign="Center">
	<HeaderTemplate>
		<asp:Label id="Label1" runat="server" Font-Bold="True" ForeColor="#FFF9F0" Visible="false"
			Font-Size="Larger">Press Releases</asp:Label>
	</HeaderTemplate>
	<ItemTemplate> </P></P></P></P></P><!--webbot bot="Include" U-Include="../HTMLPages/HTMLPage1.htm.htm" TAG="BODY" -->
		<TABLE width="99%" border="0" align="center" cellPadding="1" cellSpacing="1" class="normaltext"
			id="Table1">
			<TR bgcolor="#fff4e7">
				<TD>
					<table width="100%" height="20" border="0" cellpadding="0" cellspacing="0">
						<tr>
							<td width="75%">
								<asp:Label ID="lblPressHead" runat="server" Font-Bold="True" ForeColor="#B34700" Font-Size="9pt">
									<%# DataBinder.Eval(Container, "DataItem.press_release_text") %>
								</asp:Label></td>
							<td align="right">
								<asp:Label ID="lblPostedOn" runat="server" ForeColor="black" Font-Bold="True" Font-Size="7pt" >
									<%# DataBinder.Eval(Container, "DataItem.timestamp1") %>
								</asp:Label>
								&nbsp;</td>
						</tr>
					</table>
				</TD>
			</TR>
			<TR>
				<TD>
					<asp:Label id="lblDetail" runat="server">
						<%# DataBinder.Eval(Container, "DataItem.press_release_detail") %>
					</asp:Label></TD>
			</TR>
			<TR>
				<TD>
					<!--
						<asp:Image id=ImgPress runat="server" ImageUrl='<%# DataBinder.Eval(Container, "DataItem.press_release_image") %>' AlternateText="-">
						</asp:Image>
					-->
				</TD>
			</TR>
		</TABLE>
		<BR>
	</ItemTemplate>
</asp:DataList>
</td>
	</tr>
</table>

&nbsp;&nbsp;&nbsp;
