<%@ Control Language="vb" AutoEventWireup="false" Codebehind="ContactList.ascx.vb" Inherits="Notiphi.ContactList" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE class="txt" id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
	<TR>
		<TD class="hdnnews">&nbsp;</TD>
	</TR>
	<TR>
		<TD class="hdnnews" width="44%">Select Group Name:&nbsp;&nbsp;
			<asp:dropdownlist id="ddlGroupName" CssClass="txtbox" runat="server" DataTextField="GroupName" DataValueField="GroupID"
				AutoPostBack="True" Width="168px"></asp:dropdownlist>&nbsp;&nbsp;<asp:button id="btnCreateNew" runat="server" CSSclass="button" Text="Create New Contact"></asp:button>&nbsp;</TD>
	</TR>
	<TR>
		<TD align="center">&nbsp;</TD>
	</TR>
	<TR>
		<TD align="center"><asp:datagrid id="dgContacts" runat="server" Width="100%" cssclass="txt" CellPadding="4" AutoGenerateColumns="False"
				BorderWidth="1px" BorderStyle="Solid" BorderColor="#AACCFF" DataKeyField="ContactID">
				<SelectedItemStyle Font-Bold="True" BackColor="#AACCFF"></SelectedItemStyle>
				<EditItemStyle Font-Bold="True" BackColor="#AACCFF"></EditItemStyle>
				<AlternatingItemStyle BackColor="#F0F6FF"></AlternatingItemStyle>
				<ItemStyle Wrap="False" BackColor="#DEEFFF"></ItemStyle>
				<HeaderStyle Font-Bold="True" Height="30px" CssClass="gridhead"></HeaderStyle>
				<Columns>
					<asp:TemplateColumn HeaderText="Contact Mobile">
						<ItemTemplate>
							<asp:Label id=lblContactMobile runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ContactMobileNo") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Contact Name">
						<ItemTemplate>
							<asp:Label id=lblContactName runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ContactName") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="EmailID">
						<ItemTemplate>
							<asp:Label id=lblContactEmailID runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ContactEmailID") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Active">
						<ItemTemplate>
							<asp:Label id=lblActive runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.IsActive") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Edit">
						<ItemTemplate>
							<asp:ImageButton id="ImageButton1" runat="server" ImageUrl="..\Images\edit.gif" AlternateText="Edit"
								CommandName="Edit" CausesValidation="False"></asp:ImageButton>&nbsp;
							<asp:ImageButton id="ibtnDelete" runat="server" ImageUrl="..\Images\delete.gif" AlternateText="Delete"
								CommandName="Delete" CausesValidation="False"></asp:ImageButton>
						</ItemTemplate>
						<EditItemTemplate>
							<asp:ImageButton id="ImageButton4" runat="server" Visible="False" ImageUrl="..\Images\save.gif" AlternateText="Update"
								CommandName="Update" CausesValidation="False"></asp:ImageButton>
							<asp:ImageButton id="ImageButton3" runat="server" ImageUrl="..\Images\cancel.gif" AlternateText="Cancel"
								CommandName="Cancel" CausesValidation="False"></asp:ImageButton>
						</EditItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn Visible="False" HeaderText="ID">
						<ItemTemplate>
							<asp:Label id=lblContactID runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ContactID") %>' Visible="false">
							</asp:Label>
						</ItemTemplate>
						<EditItemTemplate>
							<asp:TextBox id=ContactID CssClass="txtbox" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ContactID") %>' Visible="false">
							</asp:TextBox>
						</EditItemTemplate>
					</asp:TemplateColumn>
				</Columns>
			</asp:datagrid></TD>
	</TR>
</TABLE>
<TABLE class="txt" id="tblCreateContact" cellSpacing="1" cellPadding="1" width="100%" border="0"
	runat="server" visible="False">
	<TR>
		<TD class="hdnnews" colSpan="2">
			<p align="center"><asp:label id="lblConfirm" runat="server" Visible="False">Label</asp:label></p>
		</TD>
	</TR>
	<TR>
		<TD class="hdnnews" colSpan="2">&nbsp;</TD>
	</TR>
	<TR>
		<TD class="hdnnews" style="HEIGHT: 17px" colSpan="2"><asp:label id="lblTitle" CssClass="hdnnews" runat="server">Add New Contact:</asp:label></TD>
	</TR>
	<TR>
		<TD width="19%">Mobile No</TD>
		<TD width="80%"><asp:textbox id="txtMobileno" runat="server" CSSclass="txtbox" width="200" MaxLength="20"></asp:textbox>e.g. 
			97146016000 (971 is a country code)
			<asp:requiredfieldvalidator id="Requiredfieldvalidator1" runat="server" ErrorMessage="Please provide mobile no."
				ControlToValidate="txtMobileno" Display="Dynamic"></asp:requiredfieldvalidator><asp:textbox id="txtContactID" runat="server" Visible="False"></asp:textbox></TD>
	</TR>
	<TR>
		<TD width="19%">Contact Name</TD>
		<TD width="80%"><asp:textbox id="txtContactName" runat="server" CSSclass="txtbox" width="200"></asp:textbox><asp:requiredfieldvalidator id="rfvContactName" runat="server" ErrorMessage="Please provide contact name" ControlToValidate="txtContactName"
				Display="Dynamic"></asp:requiredfieldvalidator>
			<asp:textbox id="txtGroupIDstoDelete" runat="server" Visible="False"></asp:textbox></TD>
	</TR>
	<TR>
		<TD width="19%">Email ID</TD>
		<TD width="80%"><asp:textbox id="txtEmailID" runat="server" CSSclass="txtbox" width="200"></asp:textbox><asp:requiredfieldvalidator id="rfvEmailId" runat="server" ErrorMessage="Please provide email id" ControlToValidate="txtEmailID"
				Display="Dynamic">*</asp:requiredfieldvalidator><asp:regularexpressionvalidator id="redEmailId" runat="server" ErrorMessage="Please provide a valid email id" ControlToValidate="txtEmailID"
				Display="Dynamic" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:regularexpressionvalidator></TD>
	</TR>
	<TR>
		<TD vAlign="top" width="19%">Status</TD>
		<TD width="80%"><asp:radiobuttonlist id="rblStatus" runat="server" RepeatDirection="Horizontal">
				<asp:ListItem Value="1" Selected="True">Active</asp:ListItem>
				<asp:ListItem Value="0">Inactive</asp:ListItem>
			</asp:radiobuttonlist></TD>
	</TR>
	<TR>
		<TD vAlign="top" width="19%">Select Group</TD>
		<TD width="80%"><asp:checkboxlist id="chkLstGroup" runat="server" DataTextField="GroupName" DataValueField="GroupID"></asp:checkboxlist></TD>
	</TR>
	<TR>
		<TD width="19%"></TD>
		<TD width="80%" height="30"><asp:button id="btnCreate" runat="server" CSSclass="button" Text="Create New Contact" Visible="False"></asp:button>&nbsp;
			<asp:button id="btnUpdateContact" runat="server" CSSclass="button" Text="Update Contact" Visible="False"></asp:button></TD>
	</TR>
	<TR>
		<TD width="19%"></TD>
		<TD width="80%"></TD>
	</TR>
</TABLE>
