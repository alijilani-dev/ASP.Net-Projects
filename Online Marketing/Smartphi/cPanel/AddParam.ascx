<%@ Control Language="vb" AutoEventWireup="false" Codebehind="AddParam.ascx.vb" Inherits="Smartphi.AddParam" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<P><asp:label id="lblConfirm" Visible="False" runat="server">Label</asp:label><BR>
	<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
		<TR>
			<TD>Select&nbsp;template name
				<asp:dropdownlist id="ddlTemplateName" runat="server" DataTextField="TemplateName" DataValueField="TemplateID"
					AutoPostBack="True"></asp:dropdownlist>&nbsp;
				<asp:linkbutton id="lnkCreateParam" runat="server">Create New Parameter</asp:linkbutton></TD>
			<TD></TD>
		</TR>
		<TR id="trGridView" runat="server">
			<TD align="center" colSpan="2"><asp:datagrid id="dgParams" runat="server" GridLines="Horizontal" BackColor="White" BorderWidth="1px"
					BorderColor="#E7E7FF" Width="100%" CellPadding="3" AutoGenerateColumns="False" BorderStyle="None" DataKeyField="ParamID">
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
						<asp:TemplateColumn HeaderText="Default Value">
							<HeaderStyle Font-Bold="True" Wrap="False"></HeaderStyle>
							<ItemTemplate>
								<asp:Label id=lblParamValue runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ParamDefaultValue") %>'>
								</asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox id=ParamValue runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ParamDefaultValue") %>'>
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
				</asp:datagrid></TD>
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
						<TD><asp:textbox id="txtParamName" runat="server"></asp:textbox><asp:requiredfieldvalidator id="rfvParamName" runat="server" ControlToValidate="txtParamName" ErrorMessage="Please provide Parameter name">*</asp:requiredfieldvalidator></TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 13px">Parameter Type</TD>
						<TD style="HEIGHT: 13px"><asp:dropdownlist id="ddlParamType" runat="server" DataTextField="ParamType" DataValueField="ParamTypeID">
								<asp:ListItem Value="1">Text</asp:ListItem>
								<asp:ListItem Value="2">Link</asp:ListItem>
								<asp:ListItem Value="3">Image Path</asp:ListItem>
								<asp:ListItem Value="4">Content</asp:ListItem>
							</asp:dropdownlist></TD>
					</TR>
					<TR>
						<TD></TD>
						<TD><asp:textbox id="txtParamValue" Visible="False" runat="server"></asp:textbox><asp:requiredfieldvalidator id="rfvDefaultValue" Visible="False" runat="server" ControlToValidate="txtParamValue"
								ErrorMessage="Please provide a Default Value" Enabled="False">*</asp:requiredfieldvalidator><asp:textbox id="txtParamId" Visible="False" runat="server"></asp:textbox></TD>
					</TR>
					<TR>
						<TD>Select Template</TD>
						<TD><asp:listbox id="lstTemplate" runat="server" DataTextField="TemplateName" DataValueField="TemplateID"
								Width="152px"></asp:listbox><BR>
							Select multiple groups by holding shift key&nbsp;</TD>
					</TR>
					<TR>
						<TD></TD>
						<TD><asp:button id="btnUpdate" Visible="False" runat="server" Text="Update Parameter"></asp:button></TD>
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
