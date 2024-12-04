<%@ Control Language="vb" AutoEventWireup="false" Codebehind="RateList.ascx.vb" Inherits="Notiphi.RateList1" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<asp:label id="lblConfirm" runat="server" Visible="False"></asp:label><BR>
<script language="javascript">
function EnableFunctions()
{
	document.getElementById("_ctl8_btnEdit").disabled=false;
	document.getElementById("_ctl8_btnDelete").disabled=false;
}
</script>
<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
	<TR>
		<TD class="hdnnews" style="WIDTH: 296px">Current Credit (s)</TD>
		<TD></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 296px" align="center">
			<p align="left">
				<BR>
				<asp:button id="btnRequest" runat="server" CssClass="button" Text="Request Credit" CausesValidation="False"></asp:button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:button id="btnViewContact" runat="server" Visible="False" CssClass="button" Text="View Contact"
					CausesValidation="False"></asp:button></p>
		</TD>
		<TD></TD>
	</TR>
</TABLE>
<BR>
<BR>
<TABLE class="txt" id="tblPurchase" cellSpacing="1" cellPadding="1" width="100%" border="0"
	runat="server">
	<TR>
		<TD class="hdnnews" colSpan="2">Purchase:
			<asp:label id="lblMode" runat="server"></asp:label></TD>
	</TR>
	<TR>
		<TD width="168">Number of Credits:</TD>
		<TD>
			<asp:DropDownList id="ddlCreditAmount" runat="server" DataTextField="DisplayText" DataValueField="ValueText"></asp:DropDownList></TD>
	</TR>
	<TR>
		<TD width="168">
			Rate:</TD>
		<TD>
			<asp:HyperLink id="hlnkRateList" runat="server" NavigateUrl="RateList.aspx">Rate List</asp:HyperLink></TD>
	</TR>
	<TR>
		<TD width="168"></TD>
		<TD><asp:button id="btnPurchase" tabIndex="2" runat="server" CssClass="button" Text="Purchase Credit"></asp:button><asp:button id="btnUpdate" tabIndex="2" runat="server" CssClass="button" Text="View Purchase History"></asp:button></TD>
	</TR>
</TABLE>
<BR>
