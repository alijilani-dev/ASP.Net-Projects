<%@ Control Language="vb" AutoEventWireup="false" Codebehind="WorldTime.ascx.vb" Inherits="Trade.WorldTime" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table2" border="0" width="100%" background="images/bg_timebar.jpg" height="29">
	<TR>
		<TD id="TD_Cur_Date" class="normal">
			<asp:Label id="lblDate" runat="server"> | Date : </asp:Label>
		</TD>
		<TD id="TD2">
			<asp:Label id="Label2" runat="server" CssClass="normalbold"> | Dubai : </asp:Label>
		</TD>
		<TD id="TD_Dubai_Time" class="normal"></TD>
		<TD id="TD4">
			<asp:Label id="Label3" runat="server" CssClass="normalbold"> | New York : </asp:Label>
		</TD>
		<TD id="TD_NY_Time" class="normal"></TD>
		<TD>
			<asp:Label id="Label4" runat="server" CssClass="normalbold"> | London : </asp:Label></TD>
		<TD id="TD_London_Time" class="normal"></TD>
		<TD>
			<asp:Label id="Label5" runat="server" CssClass="normalbold"> | Hong Kong : </asp:Label>
		</TD>
		<TD id="TD_HK_Time" class="normal"></TD>
	</TR>
</TABLE>
