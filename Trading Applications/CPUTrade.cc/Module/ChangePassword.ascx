<%@ Control Language="vb" AutoEventWireup="false" Codebehind="ChangePassword.ascx.vb" Inherits="Trade.ChangePassword" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<div align="center">
	<asp:Label id="lblMessage" runat="server" ForeColor="Red" Visible="False" Width="430px" Font-Names="Verdana"
		Font-Size="X-Small">Label</asp:Label><br>
	<table id="table4" style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; WIDTH: 388px; height: 150px;BORDER-BOTTOM: #cf8e40 1px solid; BACKGROUND-REPEAT: repeat-x;"
		cellspacing="0" cellpadding="0" width="388" background="../images/bg_cell.gif" border="0">
		<tbody>
			<tr>
				<td class="boxhdn" width="99%" bgcolor="#cf8e40" height="21">&nbsp;Change Password
				</td>
			</tr>
			<tr>
				<td height="3">
					<div align="center">
						<TABLE id="table5" cellSpacing="1" width="386" border="0" class="normaltext" style="WIDTH: 386px;">
							<TR>
								<TD style="WIDTH: 43%">
									<P class="normaltext" align="right">Old Password</P>
								</TD>
								<TD width="2%" valign="top">:</TD>
								<TD>
									<asp:TextBox id="tbOldPassword" runat="server" TextMode="Password" CssClass="box"></asp:TextBox><BR>
									<asp:RequiredFieldValidator id="RFVOldPassword" runat="server" ErrorMessage="Enter Old Password" ControlToValidate="tbOldPassword"
										CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 43%" class="normaltext" align="right" valign="top">
									New Password
								</TD>
								<TD width="2%" valign="top">:</TD>
								<TD style="WIDTH: 49%">
									<asp:TextBox id="tbNewPassword" runat="server" TextMode="Password" CssClass="box"></asp:TextBox><BR>
									<asp:RequiredFieldValidator id="RFVNewPassword" runat="server" ErrorMessage="Enter New Password" ControlToValidate="tbNewPassword"
										CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator></TD>
							</TR>
							<TR>
								<TD class="normaltext" style="WIDTH: 43%; HEIGHT: 13px" align="right" valign="top">
									Retype New Password
								</TD>
								<TD style="HEIGHT: 13px" width="2%" valign="top">:</TD>
								<TD style="WIDTH: 49%; HEIGHT: 13px">
									<asp:TextBox id="tbReNewPassword" runat="server" TextMode="Password" CssClass="box"></asp:TextBox><BR>
									<asp:RequiredFieldValidator id="RFVReNewPassword" runat="server" ErrorMessage="Enter Retype Password" ControlToValidate="tbReNewPassword"
										CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
									<asp:CompareValidator id="CVReNewPassword" runat="server" ControlToValidate="tbReNewPassword" ErrorMessage="Retype password is not the same as NEW PASSWORD"
										ControlToCompare="tbNewPassword" CssClass="error" Width="204px" Display="Dynamic"></asp:CompareValidator></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 43%"></TD>
								<TD width="2%"></TD>
								<TD style="WIDTH: 49%">
									<asp:Button id="butOk" runat="server" Text="Update"></asp:Button></TD>
							</TR>
						</TABLE>
					</div>
					
				</td>
			</tr>
		</tbody>
	</table>
</div>
