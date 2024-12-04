<%@ Control Language="vb" AutoEventWireup="false" Codebehind="ContactUs.ascx.vb" Inherits="Trade.ContactUs" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1"  cellSpacing="0" cellPadding="5" width="100%" border="0">
	<TR>
		<TD><B>Head office</B></TD>
		<TD></TD>
		<TD></TD>
	</TR>
	<TR>
		<TD>
			<P>
				<asp:Label id="lblportalname" runat="server" ForeColor="#FF8000" Font-Bold="True">Label</asp:Label><BR>
				<BR>
				Mob: +971 50 2052150 Fax: +971 4 3688073</P>
		</TD>
		<TD>
			<P>&nbsp;</P>
		</TD>
		<TD>By e-mail: feel free to contact us anytime.
			<BR>
			<BR>
			For product and services questions:<BR>
			<A href="mailto:info@phonetrade.cc">info@phonetrade.cc</A></TD>
	</TR>
	<TR>
		<TD colSpan="3">
			<asp:Label id="lblthanku" DESIGNTIMEDRAGDROP="240" runat="server" ForeColor="Maroon"></asp:Label></TD>
	</TR>
</TABLE>
<TABLE id="TDEnquiry" cellSpacing="0" cellPadding="5" width="100%" border="1" runat="server">
	<TR>
		<TD align="center" colSpan="3" bgColor="#ffffcc">
			<asp:Label id="lblEnquiry" runat="server" EnableViewState="False">Enquiry Form</asp:Label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 33px" align="center" colSpan="3">
			<asp:ValidationSummary id="ValidationSummary1" runat="server" Height="40px"></asp:ValidationSummary></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 108px">Contact Name</TD>
		<TD>&nbsp;:
		</TD>
		<TD>
			<asp:TextBox id="txtcontactName" runat="server" Width="232px" MaxLength="100"></asp:TextBox>*
			<asp:RequiredFieldValidator id="RFVContactname" runat="server" ErrorMessage="Enter Contact name" ControlToValidate="txtcontactName"></asp:RequiredFieldValidator></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 108px">Company Name</TD>
		<TD>&nbsp;:
		</TD>
		<TD>
			<asp:TextBox id="txtCompanyName" runat="server" Width="232px" MaxLength="100"></asp:TextBox>*
			<asp:RequiredFieldValidator id="RFVCompanyName" runat="server" ErrorMessage="Enter Company name" ControlToValidate="txtCompanyName"></asp:RequiredFieldValidator></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 108px">Phone</TD>
		<TD>&nbsp;:
		</TD>
		<TD>
			<asp:TextBox id="txtPhone" runat="server" Width="232px" MaxLength="100"></asp:TextBox>*
			<asp:RequiredFieldValidator id="RFVPhone" runat="server" ErrorMessage="Enter Phone" ControlToValidate="txtPhone"></asp:RequiredFieldValidator></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 108px">Email</TD>
		<TD>&nbsp;:
		</TD>
		<TD>
			<asp:TextBox id="txtEmail" runat="server" Width="232px" MaxLength="255"></asp:TextBox>*
			<asp:RequiredFieldValidator id="RFVEmail" runat="server" ErrorMessage="Enter Email" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator id="REVEmail" runat="server" ErrorMessage="Enter valid Email Address" ControlToValidate="txtEmail"
				ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 108px">Comments</TD>
		<TD>&nbsp;:
		</TD>
		<TD vAlign="top">
			<asp:TextBox id="txtComments" runat="server" TextMode="MultiLine" Width="296px" Height="146px"
				MaxLength="1000"></asp:TextBox>*(1000 chars)
			<asp:RequiredFieldValidator id="RFVComments" runat="server" ErrorMessage="Enter Comments" ControlToValidate="txtComments"></asp:RequiredFieldValidator></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 130px" align="center" colSpan="3">
			<asp:Button id="butSubmit" runat="server" Width="63px" Text="Submit"></asp:Button></TD>
	</TR>
</TABLE>
