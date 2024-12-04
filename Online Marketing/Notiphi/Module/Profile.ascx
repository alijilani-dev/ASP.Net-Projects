<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Profile.ascx.vb" Inherits="Notiphi.Profile" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<div align="center">
	&nbsp;<TABLE class="txt" id="table1" style="BORDER-RIGHT: #aaccff 1px solid; BORDER-TOP: #aaccff 1px solid; BORDER-LEFT: #aaccff 1px solid; BORDER-BOTTOM: #aaccff 1px solid"
		cellSpacing="3" width="500" border="0" runat="server">
		<TR>
			<TD class="gridhead" HEIGHT="27"><b>Update Profile!</b>&nbsp;</TD>
		</TR>
		<TR>
			<TD height="5">
				<div align="center">
					<TABLE class="txt" id="table2" cellSpacing="3" width="450" border="0" runat="server">
						<TR>
							<TD width="593" height="5" colspan="2"></TD>
						</TR>
						<TR>
							<TD class="hdnnews" width="441" colSpan="2">Member / Company Information
								<asp:label id="lblConfirm" runat="server" Visible="False">Label</asp:label></TD>
						</TR>
						<TR>
							<TD vAlign="top" width="265"><b>Member / Company Name:</b><BR>
								<asp:textbox class="txtbox" id="txtMemberName" runat="server" Width="200px"></asp:textbox>
								<asp:requiredfieldvalidator id="rfvMemberName" runat="server" ControlToValidate="txtMemberName" ErrorMessage="Please provide member / company name"
									Display="Dynamic"></asp:requiredfieldvalidator></TD>
							<TD vAlign="top" width="278"><b>Preferred User Name:</b><BR>
								<asp:textbox class="txtbox" id="txtUserName" runat="server" Width="200px" ReadOnly="True"></asp:textbox>
								<asp:requiredfieldvalidator id="rfvUserName" runat="server" ControlToValidate="txtUserName" ErrorMessage="Please provide user name"
									Display="Dynamic"></asp:requiredfieldvalidator></TD>
						</TR>
						<TR>
							<TD width="284"><b>Company Telephone:</b><BR>
								<asp:textbox class="txtbox" id="txtPhoneNo" runat="server" Width="200px"></asp:textbox>
								<asp:requiredfieldvalidator id="rfvTelephoneNo" runat="server" ControlToValidate="txtPhoneNo" ErrorMessage="Please provide company telephone"
									Display="Dynamic"></asp:requiredfieldvalidator></TD>
							<TD width="309" valign="top"><b>Fax No:</b><BR>
								<asp:textbox class="txtbox" id="txtFaxNo" runat="server" Width="200px"></asp:textbox></TD>
						</TR>
						<TR>
							<TD width="284">&nbsp;</TD>
							<TD width="309"></TD>
						</TR>
						<TR>
							<TD class="hdnnews" width="284">Contact Information</TD>
							<TD width="309"></TD>
						</TR>
						<TR>
							<TD vAlign="top" width="284"><b>Contact Person Name:</b><BR>
								<asp:textbox class="txtbox" id="txtContactPerson" runat="server" Width="200px"></asp:textbox>
								<asp:requiredfieldvalidator id="rfvFirstName" runat="server" ControlToValidate="txtContactPerson" ErrorMessage="Please provide first name"
									Display="Dynamic"></asp:requiredfieldvalidator></TD>
							<TD vAlign="top" width="309"><b>Contact No / Mobile No:</b><BR>
								<asp:textbox class="txtbox" id="txtMobileNo" runat="server" Width="200px"></asp:textbox></TD>
						</TR>
						<TR>
							<TD vAlign="top" width="284"><b>Email ID:</b><BR>
								<asp:textbox class="txtbox" id="txtEmailID" runat="server" Width="200px"></asp:textbox>
								<asp:requiredfieldvalidator id="rfvEmailId" runat="server" ControlToValidate="txtEmailID" ErrorMessage="Please provide email id"
									Display="Dynamic"></asp:requiredfieldvalidator>
								<asp:regularexpressionvalidator id="redEmailId" runat="server" ControlToValidate="txtEmailID" ErrorMessage="Please provide a valid email id"
									Display="Dynamic" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:regularexpressionvalidator></TD>
							<TD vAlign="top" width="309"><b>City:</b><BR>
								<asp:textbox class="txtbox" id="txtCity" runat="server" Width="200px"></asp:textbox></TD>
						</TR>
						<TR>
							<TD vAlign="top" width="284"><b>Contact Address:</b><BR>
								<asp:textbox class="txtbox" id="txtAddress" runat="server" Width="200px" Height="56px" TextMode="MultiLine"></asp:textbox></TD>
							<TD vAlign="top" width="309"><b>Country:</b><BR>
								<asp:dropdownlist class="txtbox" id="ddlCountry" runat="server" Width="200px" DataTextField="CountryName"
									DataValueField="CountryID"></asp:dropdownlist>
								<asp:requiredfieldvalidator id="rfvCountry" runat="server" ControlToValidate="ddlCountry" ErrorMessage="Please provide country"
									Display="Dynamic"></asp:requiredfieldvalidator></TD>
						</TR>
						<TR>
							<TD width="284">&nbsp;</TD>
							<TD width="309"></TD>
						</TR>
						<TR>
							<TD width="593" colSpan="2">
								<p align="left">
									<asp:button CssClass="button" id="btnSubmit" runat="server" Text="Save Changes"></asp:button></p>
							</TD>
						</TR>
					</TABLE>
				</div>
			</TD>
		</TR>
	</TABLE>
	<p>&nbsp;</p>
</div>
