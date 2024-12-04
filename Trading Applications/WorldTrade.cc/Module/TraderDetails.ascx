<%@ Control Language="vb" AutoEventWireup="false" Codebehind="TraderDetails.ascx.vb" Inherits="Trade.TraderDetails" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<asp:DataList ID="DLTradeDetail" Width="650" HorizontalAlign="Center" runat="server">
	<ItemTemplate>
		<TABLE id="Table11" borderColor="#cf8e40" cellSpacing="2" cellPadding="2" width="650" align="center"
			border="1">
			<TR>
				<TD>
					<TABLE class="normaltext" id="Table4" cellSpacing="1" cellPadding="1" width="650" align="center"
						border="0">
						<TR>
							<TD align="center" bgColor="#cf8e40" colSpan="5" height="25">
								<asp:Label id=Label1 runat="server" EnableViewState="False" Font-Bold="true" ForeColor="#FFF9F0" Font-Size="9pt" Text='<%# DataBinder.Eval(Container, "DataItem.member_company") %>'>
								</asp:Label></TD>
						</TR>
						<TR>
							<TD align="center" colSpan="5">
								<asp:Image id=Image1 runat="server" EnableViewState="False" BorderWidth="1px" BorderColor="#CCCCCC" ImageUrl='<%# "../images/MainImage/" &amp; iif(DataBinder.Eval(Container, "DataItem.company_Logo_Url_Main").Tostring().trim()="","NoImage_big.gif",DataBinder.Eval(Container, "DataItem.company_Logo_Url_Main")) %>'>
								</asp:Image></TD>
						</TR>
						<TR>
							<TD align="center" colSpan="5">
								<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
									<TR>
										<TD vAlign="top" background="../images/bg_cell.gif">
											<TABLE class="normaltext" id="Table6" cellSpacing="1" cellPadding="1" width="300" border="0">
												<TR>
													<TD colSpan="2"><STRONG>Company Details</STRONG></TD>
												</TR>
												<TR>
													<TD vAlign="top">Address:</TD>
													<TD width="70%">
														<asp:Label id="Label8" runat="server" Width="134px" EnableViewState="False">
															<%# DataBinder.Eval(Container, "DataItem.mailing_address") %>
														</asp:Label></TD>
												</TR>
												<TR>
													<TD>Country:</TD>
													<TD>
														<asp:Label id="Label9" runat="server" Width="122px" EnableViewState="False">
															<%# DataBinder.Eval(Container, "DataItem.country_name") %>
														</asp:Label></TD>
												</TR>
												<TR>
													<TD>Phone:</TD>
													<TD class="normaltext">
														<asp:Label id="Label10" runat="server" EnableViewState="False"> +<%# Replace (DataBinder.Eval(Container, "DataItem.company_phone"),"*"," ") %> </asp:Label></TD>
												</TR>
												<TR>
													<TD>Fax:</TD>
													<TD class="normaltext">
														<asp:Label id="Label11" runat="server" EnableViewState="False"> +<%# Replace (DataBinder.Eval(Container, "DataItem.company_fax"),"*"," ") %> </asp:Label></TD>
												</TR>
												<TR>
													<TD>Email:</TD>
													<TD>
														<asp:Label id="Label12" runat="server" EnableViewState="False">
															<%# DataBinder.Eval(Container, "DataItem.company_email") %>
														</asp:Label></TD>
												</TR>
												<TR>
													<TD>Website:</TD>
													<TD>
														<asp:Label id="Label13" runat="server" EnableViewState="False">
															<%# DataBinder.Eval(Container, "DataItem.company_website") %>
														</asp:Label></TD>
												</TR>
											</TABLE>
										</TD>
										<TD width="3"></TD>
										<TD vAlign="top" background="../images/bg_cell.gif">
											<TABLE class="normaltext" id="Table8" cellSpacing="1" cellPadding="1" width="300" border="0">
												<TR>
													<TD colSpan="2"><STRONG>Personal Details</STRONG></TD>
												</TR>
												<TR>
													<TD>Name:</TD>
													<TD>
														<asp:Label id="Label7" runat="server" EnableViewState="False">
															<%# DataBinder.Eval(Container, "DataItem.company_contact1_name") %>
														</asp:Label></TD>
												</TR>
												<TR>
													<TD>Mobile:</TD>
													<TD class="normaltext">
														<asp:Label id="Label6" runat="server" EnableViewState="False"> +<%# Replace (DataBinder.Eval(Container, "DataItem.company_contact1_mobile"),"*"," ") %> </asp:Label></TD>
												</TR>
												<TR>
													<TD>Email:</TD>
													<TD class="normaltext">
														<asp:Label id="Label5" runat="server" EnableViewState="False">
															<%# DataBinder.Eval(Container, "DataItem.company_contact1_email") %>
														</asp:Label></TD>
												</TR>
												<TR>
													<TD>Name:</TD>
													<TD>
														<asp:Label id="Label3" runat="server" EnableViewState="False">
															<%# DataBinder.Eval(Container, "DataItem.company_contact2_name") %>
														</asp:Label></TD>
												</TR>
												<TR>
													<TD>Mobile:</TD>
													<TD class="normaltext">
														<asp:Label id="Label2" runat="server" EnableViewState="False"> +<%# Replace (DataBinder.Eval(Container, "DataItem.company_contact2_mobile"),"*"," ") %> </asp:Label></TD>
												</TR>
												<TR>
													<TD>Email:</TD>
													<TD>
														<asp:Label id="Label4" runat="server" EnableViewState="False">
															<%# DataBinder.Eval(Container, "DataItem.company_contact2_email") %>
														</asp:Label></TD>
												</TR>
											</TABLE>
										</TD>
									</TR>
								</TABLE>
							</TD>
						</TR>
					</TABLE>
					<BR>
					<TABLE id="Table15" cellSpacing="0" cellPadding="0" width="100%" border="0">
						<TR>
							<TD align="left">
								<asp:Label id="lblProfile" runat="server" CssClass="normalText">
									<%# server.htmlDecode(DataBinder.Eval(Container, "DataItem.Profile").Tostring) %>
								</asp:Label></TD>
						</TR>
					</TABLE>
				</TD>
			</TR>
		</TABLE>
	</ItemTemplate>
</asp:DataList>
