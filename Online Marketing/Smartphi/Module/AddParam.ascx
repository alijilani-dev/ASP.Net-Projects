<%@ Control Language="vb" AutoEventWireup="false" Codebehind="AddParam.ascx.vb" Inherits="Smartphi.AddParam" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<P><asp:label id="lblConfirm" runat="server" Visible="False">Label</asp:label><BR>
	<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
		<TR>
			<TD>Select&nbsp;template name
				<asp:dropdownlist id="ddlTemplateName" AutoPostBack="True" DataValueField="TemplateID" DataTextField="TemplateName"
					runat="server"></asp:dropdownlist></TD>
			<TD></TD>
		</TR>
		<TR id="trGridView" runat="server">
			<TD align="center" colSpan="2"><asp:datagrid id="dgParams" runat="server" DataKeyField="ParamID" BorderStyle="None" AutoGenerateColumns="False"
					CellPadding="3" Width="100%" BorderColor="#E7E7FF" BorderWidth="1px" BackColor="White" GridLines="Horizontal">
					<SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
					<AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
					<ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
					<FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
					<Columns>
						<asp:TemplateColumn HeaderText="Parameter Name">
							<HeaderStyle Font-Bold="True" Wrap="False"></HeaderStyle>
							<ItemTemplate>
								<asp:Label id=lblParamName runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ParamName") %>'>
								</asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox id="txtEditParamName" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ParamName") %>'>
								</asp:TextBox>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Type">
							<HeaderStyle Font-Bold="True" Wrap="False"></HeaderStyle>
							<ItemTemplate>
								<asp:Label id=lblParamType runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ParamType") %>'>
								</asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox id=ParamType runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ParamType") %>'>
								</asp:TextBox>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Parameter Value">
							<HeaderStyle Font-Bold="True" Wrap="False"></HeaderStyle>
							<ItemTemplate>
								<asp:Label id=lblParamValue runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ParamValue") %>'>
								</asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox id=ParamValue runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ParamValue") %>'>
								</asp:TextBox>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn Visible="False" HeaderText="Parameter Type">
							<ItemTemplate>
								<asp:Label id="lblParamTypeID" runat="server" Visible="False" Text=""></asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox id="ParamTypeID" runat="server"></asp:TextBox>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Edit">
							<HeaderStyle Font-Bold="True" Wrap="False"></HeaderStyle>
							<ItemTemplate>
								<asp:ImageButton id="imgEdit" runat="server" CausesValidation="False" CommandName="Edit" AlternateText="Edit"
									ImageUrl="..\Images\edit.gif"></asp:ImageButton>&nbsp;
								<asp:ImageButton id="imgDelete" runat="server" CausesValidation="False" CommandName="Delete" AlternateText="Delete"
									ImageUrl="..\Images\delete.gif"></asp:ImageButton>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:ImageButton id="imgSave" runat="server" CausesValidation="False" CommandName="Update" AlternateText="Update"
									ImageUrl="..\Images\save.gif"></asp:ImageButton>
								<asp:ImageButton id="imgCancel" runat="server" CausesValidation="False" CommandName="Cancel" AlternateText="Cancel"
									ImageUrl="..\Images\cancel.gif"></asp:ImageButton>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn Visible="False" HeaderText="ID">
							<ItemTemplate>
								<asp:Label id=lblParamID runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ParamID") %>'>
								</asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox id=ParamID runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ParamID") %>'>
								</asp:TextBox>
							</EditItemTemplate>
						</asp:TemplateColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
				</asp:datagrid>
			</TD>
		</TR>
		<TR id="trFormView" runat="server">
			<TD align="center" colSpan="2">
				<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="0">
					<TR>
						<TD></TD>
						<TD></TD>
					</TR>
					<TR>
						<TD>Parameter&nbsp;List</TD>
						<TD></TD>
					</TR>
					<TR>
						<TD>Parameter Name</TD>
						<TD><asp:textbox id="txtParamName" runat="server"></asp:textbox><asp:requiredfieldvalidator id="rfvParamName" runat="server" ErrorMessage="Please provide Parameter name" ControlToValidate="txtParamName">*</asp:requiredfieldvalidator></TD>
					</TR>
					<TR>
						<TD>Parameter Type</TD>
						<TD><asp:textbox id="txtParamType" runat="server" Visible="False"></asp:textbox><asp:dropdownlist id="ddlParamType" runat="server">
								<asp:ListItem Value="1">Text</asp:ListItem>
								<asp:ListItem Value="2">Image Tag</asp:ListItem>
								<asp:ListItem Value="3">Link</asp:ListItem>
							</asp:dropdownlist></TD>
					</TR>
					<TR>
						<TD>Parameter&nbsp;Value</TD>
						<TD><asp:textbox id="txtParamValue" runat="server"></asp:textbox><asp:requiredfieldvalidator id="rfvDefaultValue" runat="server" ErrorMessage="Please provide a Default Value"
								ControlToValidate="txtParamValue">*</asp:requiredfieldvalidator></TD>
					</TR>
					<TR>
						<TD>Select Template</TD>
						<TD><asp:listbox id="lstTemplate" DataValueField="TemplateID" DataTextField="TemplateName" runat="server"
								Width="152px"></asp:listbox><BR>
							Select multiple groups by holding shift key&nbsp;</TD>
					</TR>
					<TR>
						<TD></TD>
						<TD></TD>
					</TR>
					<TR>
						<TD></TD>
						<TD><asp:button id="btnCreate" runat="server" Text="Create New Parameter"></asp:button>&nbsp;</TD>
					</TR>
					<TR>
						<TD></TD>
						<TD></TD>
					</TR>
				</TABLE>
			</TD>
		</TR>
	</TABLE>
</P>
