<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Purchase.ascx.vb" Inherits="Notiphi.Purchase" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<asp:label id="lblConfirm" Visible="False" runat="server"></asp:label><BR>
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
				<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="300" border="0">
					<TR>
						<TD><asp:label id="lblPurchaseDate" runat="server">Purchase Date</asp:label></TD>
						<TD><asp:label id="lblDate" runat="server"></asp:label></TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 2px"><asp:label id="lblTotalCredit" runat="server">Total Credit</asp:label></TD>
						<TD style="HEIGHT: 2px"><asp:label id="lblCredit" runat="server"></asp:label></TD>
					</TR>
					<TR>
						<TD></TD>
						<TD></TD>
					</TR>
				</TABLE>
				<BR>
				<asp:button id="btnRequest" runat="server" CausesValidation="False" Text="Request Credit" CssClass="button"></asp:button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:button id="btnViewContact" Visible="False" runat="server" CausesValidation="False" Text="View Contact"
					CssClass="button"></asp:button></p>
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
		<TD><asp:textbox id="txtCreditstoPurchase" runat="server" Width="72px"></asp:textbox>&nbsp;
			<asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" ErrorMessage="Please specify the number of credits required."
				ControlToValidate="txtCreditstoPurchase" Enabled="False" Display="Dynamic"></asp:requiredfieldvalidator><asp:rangevalidator id="RangeValidator1" runat="server" ErrorMessage="Only 1-10000 credits can be purchased online. For Bulk Credits contact us at 00971-04-6017540"
				MaximumValue="10000" MinimumValue="1" ControlToValidate="txtCreditstoPurchase" Enabled="False" Display="Dynamic"></asp:rangevalidator></TD>
	</TR>
	<TR>
		<TD width="168">Rate:</TD>
		<TD><asp:label id="lblRateList" runat="server" CssClass="hdnnews"></asp:label><asp:datagrid id="dgRateList" runat="server" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px"
				BackColor="White" CellPadding="4" GridLines="Vertical" ForeColor="Black" AutoGenerateColumns="False">
				<FooterStyle BackColor="#CCCC99"></FooterStyle>
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#CE5D5A"></SelectedItemStyle>
				<AlternatingItemStyle BackColor="White"></AlternatingItemStyle>
				<ItemStyle BackColor="#F7F7DE"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#6B696B"></HeaderStyle>
				<Columns>
					<asp:BoundColumn HeaderText="No of Messages" DataField="Description" HeaderStyle-Width="200"></asp:BoundColumn>
					<asp:BoundColumn HeaderText="USD" DataField="RateUSD"></asp:BoundColumn>
					<asp:BoundColumn HeaderText="AED" DataField="RateAED"></asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#F7F7DE" Mode="NumericPages"></PagerStyle>
			</asp:datagrid></TD>
	</TR>
	<TR>
		<TD width="168"></TD>
		<TD><asp:button id="btnPurchase" tabIndex="2" runat="server" Text="Purchase Credit" CssClass="button"></asp:button>&nbsp;<asp:button id="btnHistory" tabIndex="2" runat="server" CausesValidation="False" Text="View Purchase History"
				CssClass="button"></asp:button></TD>
	</TR>
</TABLE>
