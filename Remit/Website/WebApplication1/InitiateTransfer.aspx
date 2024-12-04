<%@ Page language="c#" Codebehind="InitiateTransfer.aspx.cs" AutoEventWireup="false" Inherits="WebApplication1.InitiateTransfer" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<script language="C#" runat="server">
	</script>
	<body>
		<form method="get" runat="server" ID="Form1">
			<h3><font face="Verdana">Caching Data</font></h3>
			<ASP:DataGrid id="MyDataGrid" runat="server" Width="700" BackColor="#ccccff" BorderColor="black"
				ShowFooter="false" CellPadding="3" CellSpacing="0" Font-Name="Verdana" Font-Size="8pt" HeaderStyle-BackColor="#aaaad" />
			<P><i><asp:label id="CacheMsg" runat="server" /></i></P>
		</form>		
	</body>
</HTML>
