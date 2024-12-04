<%@ Control Language="vb" AutoEventWireup="false" Codebehind="AboutUs.ascx.vb" Inherits="Trade.AboutUs" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<table width="100%" border="0">
	<TR>
		<TD align="center">
			<IFRAME style="WIDTH: 470px; HEIGHT: 60px" name="IfAdv" align="middle" src="HTMLPages/Advertisement.htm"
				frameBorder="0" scrolling="no"></IFRAME>
			<BR>
		</TD>
	</TR>
</table>
<table id="table4" style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid; BACKGROUND-REPEAT: repeat-x"
	cellspacing="0" cellpadding="0" width="100%" background="../images/bg_cell.gif" border="0">
	<tbody>
		<tr>
			<td width="3" rowspan="3"></td>
			<td width="168" height="3"></td>
			<td width="3" rowspan="3"></td>
		</tr>
		<tr>
			<td class="boxhdn" width="99%" bgcolor="#cf8e40" height="19">&nbsp;About Us
			</td>
		</tr>
		<tr>
			<td width="168" height="3"></td>
		</tr>
	</tbody>
</table>
<table width="100%" height="100%" border="0">
	<tr>
		<td>
			<asp:DataList id="DLContent" runat="server" Height="100%" Width="100%">
				<ItemTemplate>
					<IFRAME id=HTMLFile Frameborder="0" src='<%# DataBinder.Eval(Container, "DataItem.Content_Text_Url")%>' width="100%" height="100%" runat="server" class=normaltext>
					</IFRAME>
				</ItemTemplate>
			</asp:DataList>
		</td>
	</tr>
</table>
