<%@ Control Language="vb" AutoEventWireup="false" Codebehind="DeliveryReport.ascx.vb" Inherits="Smartphi.DeliveryReport1" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<P>
<TABLE class="txt" id="Table2" cellSpacing="2" cellPadding="2" width="100%" border="0">
	<TR>
		  <TD class="hdnnews">Schedule Delivery Report:</TD>
  </TR>
	<TR>
		<TD class="hdnnews" width="44%">
		  <asp:datagrid id="dgReport" runat="server" Width="100%" CellPadding="4" AutoGenerateColumns="False"
					BorderStyle="solid" cssclass="txt" DataKeyField="ContactID" BorderColor="#AACCFF" BorderWidth="1px" BackColor="White" GridLines="Vertical" ForeColor="Black">
		    <FooterStyle BackColor="#CCCC99"></FooterStyle>
		    <SelectedItemStyle Font-Bold="True" ForeColor="#103352" BackColor="#C1E1FF"></SelectedItemStyle>
		    <AlternatingItemStyle BackColor="#F0F6FF"></AlternatingItemStyle>
		    <ItemStyle BackColor="#DEEFFF"></ItemStyle>
		    <HeaderStyle Font-Bold="True" CssClass="gridhead"></HeaderStyle>
		    <Columns>
		      <asp:TemplateColumn HeaderText="Group Name">
		        <ItemTemplate>
		          <asp:Label id=lblGroupName runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.GroupName") %>'>	              </asp:Label>
	            </ItemTemplate>
		    </asp:TemplateColumn>
		      <asp:TemplateColumn HeaderText="Contact Name">
		        <ItemTemplate>
		          <asp:Label id="lblContactName" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ContactName") %>'>	              </asp:Label>
	            </ItemTemplate>
		    </asp:TemplateColumn>
		      <asp:TemplateColumn HeaderText="EmailID">
		        <ItemStyle Wrap="False"></ItemStyle>
		        <ItemTemplate>
		          <asp:Label id=lblContactEmailID runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ContactEmailID") %>'>	              </asp:Label>
	            </ItemTemplate>
		    </asp:TemplateColumn>
		      <asp:TemplateColumn HeaderText="Sent">
		        <ItemTemplate>
		          <asp:Label id=lblSent runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.StatusSend") %>'>	              </asp:Label>
	            </ItemTemplate>
		    </asp:TemplateColumn>
		      <asp:TemplateColumn HeaderText="Delivered">
		        <ItemTemplate>
		          <asp:Label id=lblDelivered runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.DeliveryStatus") %>'>	              </asp:Label>
	            </ItemTemplate>
		    </asp:TemplateColumn>
		      <asp:TemplateColumn HeaderText="Opened">
		        <ItemTemplate>
		          <asp:Label id=lblOpened runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Opened") %>'>	              </asp:Label>
	            </ItemTemplate>
		    </asp:TemplateColumn>
		      <asp:TemplateColumn HeaderText="Date Opened">
		        <ItemStyle Wrap="False"></ItemStyle>
		        <ItemTemplate>
		          <asp:Label id=lblScheduleTime runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.DateOpened") %>'>	              </asp:Label>
	            </ItemTemplate>
		    </asp:TemplateColumn>
		      <asp:TemplateColumn HeaderText="IP Addr">
		        <ItemTemplate>
		          <asp:Label id=lblIPAddress runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.IPAddr") %>'>	              </asp:Label>
	            </ItemTemplate>
		    </asp:TemplateColumn>
		      <asp:TemplateColumn Visible="False" HeaderText="ID">
		        <ItemTemplate>
		          <asp:Label id=lblContactID runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ContactID") %>'>	              </asp:Label>
	            </ItemTemplate>
		    </asp:TemplateColumn>
	        </Columns>
		    <PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#F7F7DE" Mode="NumericPages"></PagerStyle>
	      </asp:datagrid></TD></TR>
	<TR>
		<TD align="center"></TD>
	</TR>
  </TABLE>
</P>
