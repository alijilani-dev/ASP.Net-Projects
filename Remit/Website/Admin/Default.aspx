<%@ Page language="c#" Codebehind="Default.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin._Default" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: Login Form</title>
		<link href="/Admin/StyleSheet.css" rel="stylesheet" type="text/css">
	</HEAD>
	<body leftmargin="0" topmargin="0" MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			&nbsp;
			<asp:DataGrid id="dgrd" runat="server" AutoGenerateColumns="False">
				<Columns>
					<asp:TemplateColumn HeaderText="test">
						<ItemTemplate>
							<asp:HyperLink id=HyperLink1 runat="server"  Text="<%= testVariable.ToString() %>">
							</asp:HyperLink>
						</ItemTemplate>
					</asp:TemplateColumn>
				</Columns>
			</asp:DataGrid>
		</form>
	</body>
</HTML>
