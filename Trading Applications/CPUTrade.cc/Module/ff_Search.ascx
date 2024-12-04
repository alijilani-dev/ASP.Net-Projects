<%@ Control Language="vb" AutoEventWireup="false" Codebehind="ff_Search.ascx.vb" Inherits="Trade.ff_Search" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE class="normaltext" id="Table1" cellSpacing="0" cellPadding="0" width="100%" align="center"
	border="0">
	<TR>
		<TD vAlign="top">
			<STRONG><FONT color="#ff9900">Freight Forwarder's Directory</FONT></STRONG></TD>
	</TR>
	<TR>
		<TD><FONT color="#000000" size="2">If you are a Freight Forwarder and you are not 
				listed here please send us your detailssdsdss. <A href="http://www.phonetrade.cc/NewMember.asp">
					CLICK HERE</A></FONT></TD>
	</TR>
	<TR>
		<TD>&nbsp;</TD>
	</TR>
</TABLE>
<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" align="center" border="0"
	class="normaltext">
	<TR>
		<TD vAlign="middle" align="center">
			<TABLE class="normaltext" id="Table3" style="FONT-SIZE: 10pt" cellSpacing="0" cellPadding="3"
				width="100%" border="0">
				<TR>
					<TD><STRONG>Country</STRONG></TD>
					<TD align="left"><asp:dropdownlist id="DDLCountry" runat="server"></asp:dropdownlist></TD>
					<TD>
					</TD>
					<TD align="right"><STRONG>&nbsp;&nbsp;&nbsp;</STRONG></TD>
					<TD>&nbsp;
					</TD>
				</TR>
				<TR>
					<TD><STRONG>Company&nbsp;Name&nbsp;&nbsp;&nbsp;</STRONG></TD>
					<TD align="left"><asp:textbox id="tbCompanyName" runat="server"></asp:textbox></TD>
					<TD>&nbsp;</TD>
					<TD>
						<asp:ImageButton id="Img1" runat="server" ImageUrl="images/go.gif"></asp:ImageButton>
						<A onclick="Javascript:MoveToSearch();"></A>
					</TD>
					<TD>&nbsp;
						<asp:TextBox id="TextBox1234" runat="server"></asp:TextBox></TD>
				</TR>
			</TABLE>
			<asp:DataList id="DLAlphabet" runat="server" RepeatDirection="Horizontal" RepeatColumns="18">
				<ItemTemplate>
					<asp:LinkButton id=linkbut1 runat="server" CssClass="footer" Text="<%# Container.DataItem  %>">
					</asp:LinkButton>&nbsp;|&nbsp;
				</ItemTemplate>
			</asp:DataList>
		</TD>
	</TR>
</TABLE>
