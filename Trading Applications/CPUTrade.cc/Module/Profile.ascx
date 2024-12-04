<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Profile.ascx.vb" Inherits="Trade.Profile" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<%@ Register TagPrefix="fckeditorv2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<div align="center">
	<asp:Label id="lblMessage" runat="server" Visible="False" Font-Names="Verdana" Font-Size="X-Small"
		ForeColor="Red"></asp:Label>
	<table id="table4" style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid; BACKGROUND-REPEAT: repeat-x"
		cellSpacing="0" cellPadding="0" width="650" background="../images/bg_cell.gif" border="0">
		<tbody>
			<tr>
				<td class="boxhdn" width="99%" bgColor="#cf8e40" height="21">&nbsp;Edit My Profile</td>
			</tr>
			<tr>
				<td height="3">
					<TABLE class="normaltext" id="table5" cellSpacing="1" width="100%" border="0">
						<TR>
							<TD style="WIDTH: 60%; HEIGHT: 24px" align="center">
								<FCKEDITORV2:FCKEDITOR id="myEditor" Height="250px" runat="server" BasePath="~/FCKeditor/" ToolbarSet="MyToolbar"
									Width="100%"></FCKEDITORV2:FCKEDITOR><BR>
								<asp:button id="butOk" runat="server" Text="Update Profile"></asp:button>
							</TD>
						</TR>
					</TABLE>
				</td>
			</tr>
		</tbody>
	</table>
	<asp:requiredfieldvalidator id="idErrProfile" runat="server" CssClass="error" ControlToValidate="myEditor" ErrorMessage="Please type your company Profile"
		Display="Dynamic"></asp:requiredfieldvalidator></div>
