<%@ Page language="c#" Codebehind="PrintView_CurrencyExposure.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.PrintView_CurrencyExposure" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>PrintView_CurrencyExposure</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
	</HEAD>
	<body leftmargin="0" topmargin="0" MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<table width="100%" border="0" cellspacing="0" cellpadding="0">
				<tr>
					<td align="center">&nbsp;</td>
				</tr>
				<tr>
					<td align="center">&nbsp;Currency Exposure Cum Chart of Account as on
						<asp:Label id="lblDateTime" runat="server"></asp:Label></td>
				</tr>
				<tr>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td align="center">&nbsp;[Exposure Agents Report] &nbsp;
						<asp:DataGrid id="dgrdAgentsReport" runat="server" AutoGenerateColumns="False" BorderColor="Black"
							BackColor="White" ShowFooter="True">
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
							<HeaderStyle Font-Bold="True" HorizontalAlign="Center"></HeaderStyle>
							<FooterStyle HorizontalAlign="Right"></FooterStyle>
							<Columns>
								<asp:BoundColumn DataField="AccountNumber" HeaderText="Acc No"></asp:BoundColumn>
								<asp:BoundColumn DataField="Name" HeaderText="Name">
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Code" HeaderText="Currency Code">
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
								<asp:TemplateColumn HeaderText="FC Amount">
									<ItemTemplate>
										<asp:Label id=Label1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.FCAmount", "{0:########0.00}") %>'>
										</asp:Label>
									</ItemTemplate>
									<FooterTemplate>
										<STRONG>Total</STRONG>
									</FooterTemplate>
									<EditItemTemplate>
										<asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.FCAmount", "{0:########0.00}") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="USD Amount">
									<ItemTemplate>
										<asp:Label id=Label2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.USDAmount", "{0:########0.00}") %>'>
										</asp:Label>
									</ItemTemplate>
									<FooterTemplate>
										<asp:Label id=lblAgentReportsTotal runat="server" Text="<%# agentReportsTotal.ToString() %>">
										</asp:Label>
									</FooterTemplate>
									<EditItemTemplate>
										<asp:TextBox id=TextBox2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.USDAmount", "{0:########0.00}") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="Average" HeaderText="Average" DataFormatString="{0:########0.000000}"></asp:BoundColumn>
								<asp:BoundColumn DataField="RevRate" HeaderText="RevRate" DataFormatString="{0:########0.000000}"></asp:BoundColumn>
								<asp:BoundColumn DataField="PL" HeaderText="Profit / Loss" DataFormatString="{0:########0.00}"></asp:BoundColumn>
							</Columns>
						</asp:DataGrid>&nbsp;[Unpaid Accounts] &nbsp;
						<asp:DataGrid id="dgrdUnpaidAccounts" runat="server" AutoGenerateColumns="False" BorderColor="Black"
							BackColor="White" ShowFooter="True">
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
							<HeaderStyle Font-Bold="True" HorizontalAlign="Center"></HeaderStyle>
							<FooterStyle HorizontalAlign="Right"></FooterStyle>
							<Columns>
								<asp:BoundColumn DataField="AccountNumber" HeaderText="Acc No"></asp:BoundColumn>
								<asp:BoundColumn DataField="Name" HeaderText="Name">
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Code" HeaderText="Currency Code">
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
								<asp:TemplateColumn HeaderText="FC Amount">
									<ItemTemplate>
										<asp:Label id=Label3 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.FCAmount", "{0:########0.00}") %>'>
										</asp:Label>
									</ItemTemplate>
									<FooterTemplate>
										<STRONG>Total</STRONG>
									</FooterTemplate>
									<EditItemTemplate>
										<asp:TextBox id=TextBox3 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.FCAmount", "{0:########0.00}") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="USD Amount">
									<ItemTemplate>
										<asp:Label id=Label4 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.USDAmount", "{0:########0.00}") %>'>
										</asp:Label>
									</ItemTemplate>
									<FooterTemplate>
										<asp:Label id=lblUnpaidAccountTotal runat="server" Text="<%# unpaidAccountReportsTotal.ToString() %>">
										</asp:Label>
									</FooterTemplate>
									<EditItemTemplate>
										<asp:TextBox id=TextBox4 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.USDAmount", "{0:########0.00}") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="Average" HeaderText="Average" DataFormatString="{0:########0.000000}"></asp:BoundColumn>
								<asp:BoundColumn DataField="RevRate" HeaderText="RevRate" DataFormatString="{0:########0.000000}"></asp:BoundColumn>
								<asp:BoundColumn DataField="PL" HeaderText="Profit / Loss" DataFormatString="{0:########0.00}"></asp:BoundColumn>
							</Columns>
						</asp:DataGrid>&nbsp;[SR Commission Income Account] &nbsp;
						<asp:DataGrid id="dgrdAgencyCommissionIncomeAccounts" runat="server" AutoGenerateColumns="False"
							BorderColor="Black" BackColor="White" ShowFooter="True">
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
							<HeaderStyle Font-Bold="True" HorizontalAlign="Center"></HeaderStyle>
							<FooterStyle HorizontalAlign="Right"></FooterStyle>
							<Columns>
								<asp:BoundColumn DataField="AccountNumber" HeaderText="Acc No"></asp:BoundColumn>
								<asp:BoundColumn DataField="Name" HeaderText="Name">
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Code" HeaderText="Currency Code">
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
								<asp:TemplateColumn HeaderText="FC Amount">
									<ItemTemplate>
										<asp:Label id=Label5 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.FCAmount", "{0:########0.00}") %>'>
										</asp:Label>
									</ItemTemplate>
									<FooterTemplate>
										<STRONG>Total</STRONG>
									</FooterTemplate>
									<EditItemTemplate>
										<asp:TextBox id=TextBox5 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.FCAmount", "{0:########0.00}") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="USD Amount">
									<ItemTemplate>
										<asp:Label id=Label6 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.USDAmount", "{0:########0.00}") %>'>
										</asp:Label>
									</ItemTemplate>
									<FooterTemplate>
										<asp:Label id=lblAgencyCommissionIncomeTotal runat="server" Text="<%# srCommissionIncomeAccountsTotal.ToString() %>">
										</asp:Label>
									</FooterTemplate>
									<EditItemTemplate>
										<asp:TextBox id=TextBox6 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.USDAmount", "{0:########0.00}") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="Average" HeaderText="Average" DataFormatString="{0:########0.000000}"></asp:BoundColumn>
								<asp:BoundColumn DataField="RevRate" HeaderText="RevRate" DataFormatString="{0:########0.000000}"></asp:BoundColumn>
								<asp:BoundColumn DataField="PL" HeaderText="Profit / Loss" DataFormatString="{0:########0.00}"></asp:BoundColumn>
							</Columns>
						</asp:DataGrid>&nbsp;
						<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="450" border="0">
							<TR>
								<TD align="right" width="50%">Balance :
								</TD>
								<TD width="50%">
									<asp:Label id="lblBalance" runat="server"></asp:Label></TD>
							</TR>
							<TR>
								<TD>&nbsp;</TD>
								<TD>&nbsp;</TD>
							</TR>
						</TABLE>
					</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
