<%@ Control Language="vb" AutoEventWireup="false" Codebehind="SelectTemplate.ascx.vb" Inherits="Smartphi.TemplateControl" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="tblStep1" style="WIDTH: 802px; HEIGHT: 192px" cellSpacing="1" cellPadding="1"
	width="802" border="0">
	<TR>
		<TD style="WIDTH: 183px; HEIGHT: 25px">Select Template</TD>
		<TD style="WIDTH: 232px; HEIGHT: 25px"></TD>
		<TD style="HEIGHT: 25px"></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 183px">Category</TD>
		<TD style="WIDTH: 232px">Templetes</TD>
		<TD>Preview</TD>
	</TR>
	<TR>
		<TD style="WIDTH: 183px"><asp:listbox id="lstCategory" runat="server" DataValueField="CategoryID" DataTextField="CategoryName"
				AutoPostBack="True"></asp:listbox>
			<asp:RequiredFieldValidator id="rfvCategory" runat="server" ErrorMessage="Please select a Category" ControlToValidate="lstCategory">*</asp:RequiredFieldValidator></TD>
		<TD style="WIDTH: 232px"><asp:listbox id="lstTemplate" runat="server" DataValueField="TemplateID" DataTextField="TemplateName"
				AutoPostBack="True"></asp:listbox><BR>
			<asp:RequiredFieldValidator id="rfvTemplate" runat="server" ErrorMessage="Please select a Template" ControlToValidate="lstTemplate">*</asp:RequiredFieldValidator></TD>
		<TD><asp:image id="Image1" runat="server" ImageUrl="..\images\noimage.gif"></asp:image></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 183px"></TD>
		<TD style="WIDTH: 232px"></TD>
		<TD></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 183px"><asp:button id="btnSaveTemplate" runat="server" CausesValidation="False" Text="Save and Next"
				Width="96px"></asp:button>&nbsp;
			<asp:button id="btnCancel" runat="server" Text="Cancel" Width="64px"></asp:button></TD>
		<TD style="WIDTH: 232px"><FONT>&nbsp;</FONT></TD>
		<TD></TD>
	</TR>
</TABLE>
<BR>
