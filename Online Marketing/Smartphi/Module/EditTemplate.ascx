<%@ Control Language="vb" AutoEventWireup="false" Codebehind="EditTemplate.ascx.vb" Inherits="Smartphi.TemplateEditControl" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" style="HEIGHT: 32px" cellSpacing="1" cellPadding="1" width="100%" border="0">
	<TR>
		<TD colSpan="2"><span id="spnTemplate" runat="server"></span></TD>
	</TR>
	<TR>
		<TD colSpan="2"><span id="spnContent" runat="server"></span></TD>
	</TR>
	<TR>
		<TD colSpan="2"><span id="Span1" runat="server"></span></TD>
	</TR>
	<TR>
		<TD colSpan="2">
			<div id="divbtn"><INPUT id="txthCampaignID" type="hidden" runat="server">
				<p align="center">
					<asp:button id="btnPreview" runat="server" CssClass="button" Text="Preview" CommandName="Preview"></asp:button>&nbsp;
					<asp:button id="btnBack" CssClass="button" runat="server" Text="<< Back to Edit Template" Visible="False"></asp:button>&nbsp;
					<asp:button id="btnFinish" runat="server" CssClass="button" Text="Schedule Campaign >>"></asp:button><INPUT id="txthTemplateID" type="hidden" runat="server"></p>
			</div>
		</TD>
	</TR>
</TABLE>
