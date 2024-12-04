<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Confirmation.ascx.vb" Inherits="Trade.Confirmation" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="TDMessage" cellSpacing="1" cellPadding="1" width="100%" border="0" runat="server" class="normaltext">
	<TR>
		<TD>
			<asp:Label id="lblMessage" runat="server" ></asp:Label></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblTodo" runat="server"></asp:Label>&nbsp;
			<asp:HyperLink id="Hlnk" runat="server"></asp:HyperLink></TD>
	</TR>
</TABLE>
