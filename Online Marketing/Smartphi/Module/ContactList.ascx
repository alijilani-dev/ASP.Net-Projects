<%@ Control Language="vb" AutoEventWireup="false" Codebehind="ContactList.ascx.vb" Inherits="Notiphi.ContactList" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE class="txt" id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
	<TR>
		<TD class="hdnnews">&nbsp;</TD>
	</TR>
	<TR>
		<TD class="hdnnews" width="44%">Select Group Name:&nbsp;&nbsp;
			<asp:dropdownlist CssClass="txtbox" id="ddlGroupName" runat="server" DataTextField="GroupName" DataValueField="GroupID"
				AutoPostBack="True"></asp:dropdownlist>&nbsp;&nbsp;<asp:button CSSclass="button" id="btnCreateNew" runat="server" Text="Create New Contact"></asp:button></TD>
	</TR>
	<TR>
		<TD align="center">&nbsp;</TD>
	</TR>
	<TR>
		<TD align="center"><asp:datagrid cssclass="txt" id="dgContacts" runat="server" Width="100%" CellPadding="4" AutoGenerateColumns="False"
				BorderWidth="1px" BorderStyle="solid" BorderColor="#AACCFF" DataKeyField="ContactID">
				<SelectedItemStyle Font-Bold="True" BackColor="#AACCFF"></SelectedItemStyle>
				<EditItemStyle Font-Bold="True" BackColor="#AACCFF"></EditItemStyle>
				<AlternatingItemStyle BackColor="#F0F6FF"></AlternatingItemStyle>
				<ItemStyle Wrap="False" BackColor="#DEEFFF"></ItemStyle>
				<HeaderStyle Font-Bold="True" Height="30px" CssClass="gridhead"></HeaderStyle>
				<Columns>
					<asp:TemplateColumn HeaderText="Contact Name">
						<ItemTemplate>
							<asp:Label id=lblContactName runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ContactName") %>'>
							</asp:Label>
						</ItemTemplate>
						<EditItemTemplate>
							<asp:TextBox CssClass="txtbox" id=ContactName runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ContactName") %>'>
							</asp:TextBox>
						</EditItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="EmailID">
						<ItemTemplate>
							<asp:Label id=lblContactEmailID runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ContactEmailID") %>'>
							</asp:Label>
						</ItemTemplate>
						<EditItemTemplate>
							<asp:TextBox CssClass="txtbox" id=EmailID runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ContactEmailID") %>'>
							</asp:TextBox>
						</EditItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Address">
						<ItemTemplate>
							<asp:Label id=lblContactAddress runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ContactAddress") %>'>
							</asp:Label>
						</ItemTemplate>
						<EditItemTemplate>
							<asp:TextBox CssClass="txtbox" id=Address runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ContactAddress") %>'>
							</asp:TextBox>
						</EditItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Active">
						<ItemTemplate>
							<asp:Label id=lblActive runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.IsActive") %>'>
							</asp:Label>
						</ItemTemplate>
						<EditItemTemplate>
							<asp:CheckBox id="Active" runat="server"></asp:CheckBox>
						</EditItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Edit">
						<ItemTemplate>
							<asp:ImageButton id="ImageButton1" runat="server" ImageUrl="..\Images\edit.gif" AlternateText="Edit"
								CommandName="Edit" CausesValidation="False"></asp:ImageButton>&nbsp;
							<asp:ImageButton id="ibtnDelete" runat="server" ImageUrl="..\Images\delete.gif" AlternateText="Delete"
								CommandName="Delete" CausesValidation="False"></asp:ImageButton>
						</ItemTemplate>
						<EditItemTemplate>
							<asp:ImageButton id="ImageButton4" runat="server" ImageUrl="..\Images\save.gif" AlternateText="Update"
								CommandName="Update" CausesValidation="False"></asp:ImageButton>
							<asp:ImageButton id="ImageButton3" runat="server" ImageUrl="..\Images\cancel.gif" AlternateText="Cancel"
								CommandName="Cancel" CausesValidation="False"></asp:ImageButton>
						</EditItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn Visible="False" HeaderText="ID">
						<ItemTemplate>
							<asp:Label id=lblContactID runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.ContactID") %>'>
							</asp:Label>
						</ItemTemplate>
						<EditItemTemplate>
							<asp:TextBox id=ContactID runat="server" CssClass="txtbox" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.ContactID") %>'>
							</asp:TextBox>
						</EditItemTemplate>
					</asp:TemplateColumn>
				</Columns>
			</asp:datagrid></TD>
	</TR>
</TABLE>
<TABLE class="txt" id="tblCreateContact" visible="False" runat="server" cellSpacing="1"
	cellPadding="1" width="100%" border="0">
	<TR>
		<TD colspan="2" class="hdnnews">
			<p align="center"><asp:label id="lblConfirm" Visible="False" runat="server">Label</asp:label></p>
		</TD>
	</TR>
	<TR>
		<TD colspan="2" class="hdnnews">&nbsp;</TD>
	</TR>
	<TR>
		<TD colspan="2" class="hdnnews">Add New Contact:</TD>
	</TR>
	<TR>
		<TD width="19%">Contact Name</TD>
		<TD width="80%"><asp:textbox CSSclass="txtbox" width="200" id="txtContactName" runat="server"></asp:textbox><asp:requiredfieldvalidator id="rfvContactName" runat="server" Display="Dynamic" ControlToValidate="txtContactName"
				ErrorMessage="Please provide contact name"></asp:requiredfieldvalidator></TD>
	</TR>
	<TR>
		<TD width="19%">Contact Address</TD>
		<TD width="80%"><asp:textbox CSSclass="txtbox" width="200" id="txtAddress" runat="server"></asp:textbox></TD>
	</TR>
	<TR>
		<TD width="19%">Email ID</TD>
		<TD width="80%"><asp:textbox CSSclass="txtbox" width="200" id="txtEmailID" runat="server"></asp:textbox><asp:requiredfieldvalidator id="rfvEmailId" Display="Dynamic" runat="server" ControlToValidate="txtEmailID"
				ErrorMessage="Please provide email id">*</asp:requiredfieldvalidator><asp:regularexpressionvalidator id="redEmailId" runat="server" ControlToValidate="txtEmailID" ErrorMessage="Please provide a valid email id"
				Display="Dynamic" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:regularexpressionvalidator></TD>
	</TR>
	<TR>
		<TD width="19%">Select Group</TD>
		<TD width="80%"><asp:listbox CSSclass="dropmenu" id="lstGroup" runat="server" SelectionMode="Multiple" DataTextField="GroupName"
				DataValueField="GroupID" Width="152px"></asp:listbox><BR>
			Select multiple groups by holding shift key&nbsp;</TD>
	</TR>
	<TR>
		<TD width="19%"></TD>
		<TD height="30" width="80%"><asp:button CSSclass="button" id="btnCreate" runat="server" Text="Create New Contact"></asp:button></TD>
	</TR>
	<TR>
		<TD width="19%"></TD>
		<TD width="80%"></TD>
	</TR>
</TABLE>
