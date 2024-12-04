<%@ Control Language="vb" ClassName="PlaceHolder" AutoEventWireup="false" Codebehind="PlaceHolder.ascx.vb" Inherits="Trade.PlaceHolder" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="176" border="1">
	<TR>
		<TD style="WIDTH: 175px">
			<asp:ListBox id="lstModule" Width="160px" runat="server" Height="56px" Rows="3"></asp:ListBox></TD>
		<TD>
			<asp:ImageButton id="ImgNew" Width="14px" runat="server" CausesValidation="False" AlternateText="New"
				ImageUrl="../images/icon-Floppy.gif" Height="14px"></asp:ImageButton><BR>
			<asp:ImageButton id="ImgDelete" runat="server" ImageUrl="../images/icon-delete.gif"></asp:ImageButton></TD>
	</TR>
</TABLE>
