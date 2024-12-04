<%@ Page language="c#" Codebehind="PrintView_ExchangeEarnings.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.PrintView_ExchangeEarnings" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>PrintView_ExchangeEarnings</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
	</HEAD>
	<body leftMargin="0" topMargin="0" MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td align="center"><asp:label id="lblTitle" runat="server">Principle Commission Account Report</asp:label>&nbsp;
					</td>
				</tr>
				<tr>
					<td>
						<table cellSpacing="0" cellPadding="0" width="100%" border="0">
							<tr>
								<td vAlign="top" width="50%">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td align="right" width="120">Agent Account :
											</td>
											<td><asp:label id="lblAgentAccount" runat="server"></asp:label></td>
										</tr>
										<tr>
											<td align="right">Account Currency :
											</td>
											<td><asp:label id="lblAccountCurrency" runat="server"></asp:label></td>
										</tr>
									</table>
								</td>
								<td vAlign="top" width="50%">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td align="right" width="15%">From</td>
											<td width="120"><asp:label id="lblFromDate" runat="server"></asp:label></td>
											<td align="right" width="15%">To</td>
											<td><asp:label id="lblToDate" runat="server"></asp:label></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td>&nbsp;
						<asp:datagrid id="dgrdExchangeEarning" runat="server" BackColor="White" BorderColor="Black" ShowFooter="True"
							AutoGenerateColumns="False" Width="100%">
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
							<HeaderStyle Font-Size="X-Small" Font-Bold="True" HorizontalAlign="Center"></HeaderStyle>
							<FooterStyle HorizontalAlign="Right"></FooterStyle>
							<Columns>
								<asp:BoundColumn DataField="VoucherNumber" HeaderText="V . No"></asp:BoundColumn>
								<asp:BoundColumn DataField="PayInDateTime" HeaderText="Date" DataFormatString="{0: dd MMM yyyy}"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="SRTR No">
									<ItemTemplate>
										<asp:Label id=Label3 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TransactionNumber") %>'>
										</asp:Label>
									</ItemTemplate>
									<FooterTemplate>
										<STRONG>Total</STRONG>
									</FooterTemplate>
									<EditItemTemplate>
										<asp:TextBox id=TextBox3 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TransactionNumber") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="PayIn Amount">
									<ItemTemplate>
										<asp:Label id=Label4 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PayInAmount", "{0:########0.000}") %>'>
										</asp:Label>
									</ItemTemplate>
									<FooterTemplate>
										<asp:Label id=lblTotalPayinAmount runat="server" Text="<%# totalPayInAmount %>">
										</asp:Label>
									</FooterTemplate>
									<EditItemTemplate>
										<asp:TextBox id=TextBox4 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PayInAmount", "{0:########0.000}") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="SR Amount">
									<ItemTemplate>
										<asp:Label id=Label2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.AgencyAmount") %>'>
										</asp:Label>
									</ItemTemplate>
									<FooterTemplate>
										<asp:Label id=lblTotalAgencyAmount runat="server" Text="<%# totalAgencyEarning %>">
										</asp:Label>
									</FooterTemplate>
									<EditItemTemplate>
										<asp:TextBox id=TextBox2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.AgencyAmount") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Earnings">
									<ItemTemplate>
										<asp:Label id=Label1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Earnings") %>'>
										</asp:Label>
									</ItemTemplate>
									<FooterTemplate>
										<asp:Label id=lblTotalEarning runat="server" Text="<%# totalEarning %>">
										</asp:Label>
									</FooterTemplate>
									<EditItemTemplate>
										<asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Earnings") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
							</Columns>
						</asp:datagrid></td>
				</tr>
				<TR>
					<TD align="center">&nbsp;
					</TD>
				</TR>
			</table>
		</form>
	</body>
</HTML>
