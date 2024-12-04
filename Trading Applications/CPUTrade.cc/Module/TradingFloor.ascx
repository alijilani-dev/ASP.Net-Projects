<%@ Control Language="vb" AutoEventWireup="false" Codebehind="TradingFloor.ascx.vb" Inherits="Trade.TradingFloor" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<P>
	<asp:LinkButton id="lnkbtnNewPost" runat="server" Visible="False">Post New Offer</asp:LinkButton>
	<asp:DataList id="DLTradeFloor" RepeatColumns="1" runat="server">
		<ItemStyle Font-Size="X-Small" Font-Names="Arial"></ItemStyle>
		<ItemTemplate>
			<TABLE id="Table7" borderColor="black" cellSpacing="0" cellPadding="0" border="0">
				<TR vAlign="top">
					<TD vAlign="top">
						<TABLE id="Table1" style="FONT-SIZE: 10pt; HEIGHT: 27px; BACKGROUND-COLOR: silver" cellSpacing="1"
							cellPadding="1" width="100%" border="0">
							<TR>
								<TD align="left">
									<asp:Label id=lblHeading runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.post_heading") %>'>
									</asp:Label></TD>
								<TD align="right">
									<asp:Label id=lbltimestamp runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.timestamp") %>'>
									</asp:Label></TD>
							</TR>
						</TABLE>
						<TABLE id="Table3" style="FONT-SIZE: 10pt" cellSpacing="1" cellPadding="1" width="100%"
							border="0">
							<TR>
								<TD>
									<asp:Literal id=Literal1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.post_desc") %>'>
									</asp:Literal></TD>
								<TD>
									<asp:ImageButton id="ImageButton1" runat="server" ImageUrl="../images/button_go.gif"></asp:ImageButton></TD>
							</TR>
						</TABLE>
						<TABLE id="Table2" style="FONT-SIZE: 10pt; COLOR: white; HEIGHT: 27px; BACKGROUND-COLOR: green"
							cellSpacing="1" cellPadding="1" width="100%" border="0">
							<TR>
								<TD>
									<asp:Image id="ImgCompany" runat="server"></asp:Image></TD>
								<TD>
									<P>
										<asp:Label id="lblContact" runat="server" Font-Names="Arial" CssClass="Style.css">Contact</asp:Label><BR>
										<asp:Label id=lblCompanyPhone runat="server" Text='<%# "Tel : " &amp; DataBinder.Eval(Container, "DataItem.company_phone") %>'>
										</asp:Label></P>
								</TD>
								<TD>
									<asp:Label id=lblContactName1 runat="server" Text='<%# "Name : " &amp; DataBinder.Eval(Container, "DataItem.company_contact1_name") %>'>
									</asp:Label><BR>
									<asp:Label id=lblContactNo1 runat="server" Text='<%# "Mob : " &amp; DataBinder.Eval(Container, "DataItem.company_contact1_mobile") %>'>
									</asp:Label></TD>
								<TD>
									<asp:Label id=lblContactName2 runat="server" Text='<%# "Name : " &amp; DataBinder.Eval(Container, "DataItem.company_contact2_name") %>'>
									</asp:Label><BR>
									<asp:Label id=lblContactNo2 runat="server" Text='<%# "Mob : " &amp; DataBinder.Eval(Container, "DataItem.company_contact2_mobile") %>'>
									</asp:Label></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
			<BR>
		</ItemTemplate>
	</asp:DataList>
	<asp:DataList id="DLTradeDetail" runat="server">
		<ItemTemplate>
			<TABLE id="Table4" cellSpacing="1" cellPadding="1" border="0">
				<TR>
					<TD bgColor="#ffffcc" colSpan="4">
						<asp:Label id=Label1 runat="server" Width="288px" Text='<%# DataBinder.Eval(Container, "DataItem.member_company") %>' EnableViewState="False">
						</asp:Label></TD>
				</TR>
				<TR>
					<TD colSpan="4">
						<asp:Image id="Image1" runat="server" EnableViewState="False"></asp:Image></TD>
				</TR>
				<TR>
					<TD vAlign="top" colSpan="2">
						<TABLE id="Table6" cellSpacing="1" cellPadding="1" width="234" bgColor="#ccccff" border="0">
							<TR>
								<TD colSpan="2"><STRONG>Company Details</STRONG></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 23px">Address</TD>
								<TD style="HEIGHT: 23px">:
									<asp:Label id="Label8" runat="server" Width="134px" EnableViewState="False">
										<%# DataBinder.Eval(Container, "DataItem.mailing_address") %>
									</asp:Label></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 25px">Country</TD>
								<TD style="HEIGHT: 25px">:
									<asp:Label id="Label9" runat="server" Width="122px" EnableViewState="False">
										<%# DataBinder.Eval(Container, "DataItem.country_id") %>
									</asp:Label></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 25px">Phone</TD>
								<TD style="HEIGHT: 25px">:
									<asp:Label id="Label10" runat="server" EnableViewState="False">
										<%# DataBinder.Eval(Container, "DataItem.company_phone") %>
									</asp:Label></TD>
							</TR>
							<TR>
								<TD>Fax</TD>
								<TD>:
									<asp:Label id="Label11" runat="server" EnableViewState="False">
										<%# DataBinder.Eval(Container, "DataItem.company_fax") %>
									</asp:Label></TD>
							</TR>
							<TR>
								<TD>Email</TD>
								<TD>:
									<asp:Label id="Label12" runat="server" EnableViewState="False">
										<%# DataBinder.Eval(Container, "DataItem.company_email") %>
									</asp:Label></TD>
							</TR>
							<TR>
								<TD>Website</TD>
								<TD>:
									<asp:Label id="Label13" runat="server" EnableViewState="False">
										<%# DataBinder.Eval(Container, "DataItem.company_website") %>
									</asp:Label></TD>
							</TR>
						</TABLE>
					</TD>
					<TD vAlign="top" colSpan="2">
						<TABLE id="Table8" cellSpacing="1" cellPadding="1" bgColor="#99ccff" border="0">
							<TR>
								<TD style="HEIGHT: 26px" colSpan="2"><STRONG>Personal Details</STRONG></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 98px">Name</TD>
								<TD>:
									<asp:Label id="Label7" runat="server" EnableViewState="False">
										<%# DataBinder.Eval(Container, "DataItem.company_contact1_name") %>
									</asp:Label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 98px">Mobile</TD>
								<TD>:
									<asp:Label id="Label6" runat="server" EnableViewState="False">
										<%# DataBinder.Eval(Container, "DataItem.company_contact1_mobile") %>
									</asp:Label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 98px">Personal Email</TD>
								<TD>:
									<asp:Label id="Label5" runat="server" EnableViewState="False">
										<%# DataBinder.Eval(Container, "DataItem.company_contact1_email") %>
									</asp:Label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 98px">Name</TD>
								<TD>:
									<asp:Label id="Label3" runat="server" EnableViewState="False">
										<%# DataBinder.Eval(Container, "DataItem.company_contact2_name") %>
									</asp:Label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 98px">Mobile</TD>
								<TD>:
									<asp:Label id="Label2" runat="server" EnableViewState="False">
										<%# DataBinder.Eval(Container, "DataItem.company_contact2_mobile") %>
									</asp:Label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 98px">Personal Email</TD>
								<TD>:
									<asp:Label id="Label4" runat="server" EnableViewState="False">
										<%# DataBinder.Eval(Container, "DataItem.company_contact2_email") %>
									</asp:Label></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</ItemTemplate>
	</asp:DataList>
	<TABLE id="tbl_Heading" cellSpacing="1" cellPadding="1" border="0" runat="server">
		<TR>
			<TD>Heading</TD>
			<TD>
				<asp:TextBox id="txtHeading" runat="server" Width="168px"></asp:TextBox>
				<asp:RequiredFieldValidator id="RFVHeading" runat="server" ErrorMessage="Enter Heading" ControlToValidate="txtHeading"></asp:RequiredFieldValidator></TD>
		</TR>
		<TR>
			<TD style="WIDTH: 103px">Description</TD>
			<TD>
				<asp:TextBox id="txtDesc" runat="server" Width="336px" TextMode="MultiLine" Height="138px"></asp:TextBox>
				<asp:RequiredFieldValidator id="RFVDesc" runat="server" ErrorMessage="Enter Description" ControlToValidate="txtDesc"></asp:RequiredFieldValidator></TD>
		</TR>
		<TR>
			<TD style="WIDTH: 103px">&nbsp;
			</TD>
			<TD>
				<asp:LinkButton id="lnkbtnAdd" runat="server">Add</asp:LinkButton>&nbsp;
				<asp:LinkButton id="lnkbtnCancel" runat="server">Cancel</asp:LinkButton></TD>
		</TR>
	</TABLE>
</P>
