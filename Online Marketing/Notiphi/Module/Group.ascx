<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Group.ascx.vb" Inherits="Notiphi.GroupControl" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<asp:label id="lblConfirm" runat="server" Visible="False"></asp:label><BR>
<script language="javascript">
function EnableFunctions()
{
	document.getElementById("_ctl8_btnEdit").disabled=false;
	document.getElementById("_ctl8_btnDelete").disabled=false;
}
</script>
<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
	<TR>
		<TD class="hdnnews">Manage Group(s)</TD>
		<TD></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 318px" align="center">
			<p align="left"><asp:listbox id="lstGroup" runat="server" Height="128px" SelectionMode="Multiple" DataTextField="GroupName"
					DataValueField="GroupID" Width="232px" CssClass="txtbox"></asp:listbox><BR>
				<asp:button id="btnNew" runat="server" CssClass="button" Text="New" CausesValidation="False"></asp:button>&nbsp;
				<asp:button id="btnEdit" runat="server" CssClass="button" Text="Edit" CausesValidation="False"
					Enabled="False"></asp:button>&nbsp;
				<asp:button id="btnDelete" runat="server" CssClass="button" Text="Delete" CausesValidation="False"
					Enabled="False"></asp:button>&nbsp;
				<asp:button id="btnViewContact" runat="server" Visible="False" CssClass="button" Text="View Contact"
					CausesValidation="False"></asp:button></p>
		</TD>
		<TD></TD>
	</TR>
</TABLE>
<BR>
<BR>
<TABLE class="txt" id="tblGroup" cellSpacing="1" cellPadding="1" width="100%" border="0"
	runat="server">
	<TR>
		<TD class="hdnnews" colSpan="2">Group:
			<asp:label id="lblMode" runat="server"></asp:label></TD>
	</TR>
	<TR>
		<TD width="168">Group Name:</TD>
		<TD><asp:textbox id="txtGroupName" runat="server" CssClass="txtbox"></asp:textbox><asp:requiredfieldvalidator id="rfvGroupName" tabIndex="1" runat="server" ErrorMessage="Please provide group name"
				ControlToValidate="txtGroupName"></asp:requiredfieldvalidator></TD>
	</TR>
	<TR>
		<TD width="168"></TD>
		<TD><asp:button id="btnCreate" tabIndex="2" runat="server" CssClass="button" Text="Create New Group"></asp:button><asp:button id="btnUpdate" tabIndex="2" runat="server" CssClass="button" Text="Update Group Name"></asp:button></TD>
	</TR>
</TABLE>
<BR>
