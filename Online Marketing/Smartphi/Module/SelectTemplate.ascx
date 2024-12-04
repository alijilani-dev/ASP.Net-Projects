<%@ Control Language="vb" AutoEventWireup="false" Codebehind="SelectTemplate.ascx.vb" Inherits="Smartphi.TemplateControl" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE class="txt" id="tblStep1" style="WIDTH: 802px; HEIGHT: 192px" cellSpacing="1" cellPadding="1"
	width="802" border="0">
	<TR>
		<TD class="hdnnews">Select Template:</TD>
		<TD style="HEIGHT: 26px" colspan="2">&nbsp;</TD>
	</TR>
	<TR>
		<TD style="WIDTH: 183px" height="21"><b>Category</b></TD>
		<TD style="WIDTH: 232px" height="21"><b>Templates</b></TD>
		<TD height="21"><b>Preview</b></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 183px"><asp:listbox id="lstCategory" runat="server" DataValueField="CategoryID" DataTextField="CategoryName"
				AutoPostBack="True"></asp:listbox>
			<asp:RequiredFieldValidator id="rfvCategory" runat="server" Display="Dynamic" ErrorMessage="Please select a Category" ControlToValidate="lstCategory">*</asp:RequiredFieldValidator></TD>
		<TD style="WIDTH: 232px"><asp:listbox id="lstTemplate" runat="server" DataValueField="TemplateID" DataTextField="TemplateName"
				AutoPostBack="True"></asp:listbox><BR>
			<asp:RequiredFieldValidator id="rfvTemplate" runat="server" ErrorMessage="Please select a Template" Display="Dynamic" ControlToValidate="lstTemplate">*</asp:RequiredFieldValidator></TD>
		<TD>
		<p align="center"><asp:image id="Image1" runat="server" ImageUrl="..\images\noimage.gif"></asp:image></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 183px"></TD>
		<TD style="WIDTH: 232px"></TD>
		<TD></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 183px"><asp:button CssClass="button" id="btnSaveTemplate" runat="server" CausesValidation="False" Text="Save and Next"
				Width="96px"></asp:button>&nbsp;
			<asp:button id="btnCancel" runat="server" CssClass="button" Text="Cancel" Width="64px"></asp:button></TD>
		<TD style="WIDTH: 232px"><FONT>&nbsp;</FONT></TD>
		<TD></TD>
	</TR>
</TABLE>
<BR>