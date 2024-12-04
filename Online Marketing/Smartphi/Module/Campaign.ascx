<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Campaign.ascx.vb" Inherits="Smartphi.CampaignControl" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="tblStep2" style="WIDTH: 802px; HEIGHT: 88px" cellSpacing="1" cellPadding="1"
	width="802" border="0">
	<TR>
		<TD style="WIDTH: 130px" colSpan="2">Add&nbsp;Campaign</TD>
	</TR>
	<TR>
		<TD style="WIDTH: 131px; HEIGHT: 19px">Campaign Name</TD>
		<TD style="HEIGHT: 19px"><asp:textbox id="txtCampaignName" runat="server" Width="184px"></asp:textbox><asp:requiredfieldvalidator id="rfvCampaignName" runat="server" ControlToValidate="txtCampaignName">Please provide a valid Campaign Name</asp:requiredfieldvalidator></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 131px; HEIGHT: 17px">Subject of the mail</TD>
		<TD style="HEIGHT: 17px"><asp:textbox id="txtSubject" runat="server" Width="320px"></asp:textbox><asp:requiredfieldvalidator id="rfvSubject" runat="server" ControlToValidate="txtSubject" ErrorMessage="RequiredFieldValidator">Please provide a Mail Subject</asp:requiredfieldvalidator></TD>
	</TR>
	<TR>
		<TD></TD>
		<TD><FONT size="+0"></FONT></TD>
	</TR>
</TABLE>
