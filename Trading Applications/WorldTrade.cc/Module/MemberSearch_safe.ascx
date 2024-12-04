<%@ Control Language="vb" AutoEventWireup="false" Codebehind="MemberSearch.ascx.vb" Inherits="Trade.MemberSearch" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<%@ Register TagPrefix="uc1" TagName="TraderDetails" Src="TraderDetails.ascx" %>
<table id="Table5" cellSpacing="0" cellPadding="0" width="100%" border="0" runat="server">
	<tr>
		<td id="TD_LEFT_ADV" style="WIDTH: 17px" vAlign="top" runat="server"></td>
		<td vAlign="top" align="center" width="100%">
			<TABLE class="normaltext" id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
				<TR>
					<TD align="center" colSpan="3">
						<asp:Panel id="pnlffDirectory" runat="server">
							<IFRAME id="ifrmffDirectory" style="DISPLAY: block; VISIBILITY: visible; WIDTH: 470px; HEIGHT: 60px"
								tabIndex="0" name="IfAdv" align="middle" src="HTMLPages/Ad_TradersDirectory.htm" frameBorder="no"
								scrolling="no" runat="server"></IFRAME>
						</asp:Panel>
						<asp:Panel id="pnlTradersDirectory" runat="server">
							<IFRAME id="ifrmTradersDirectory" style="DISPLAY: block; VISIBILITY: visible; WIDTH: 470px; HEIGHT: 60px"
								tabIndex="0" name="IfAdv" align="middle" src="HTMLPages/Ad_FFDirectory.htm" frameBorder="no"
								scrolling="no" runat="server"></IFRAME>
						</asp:Panel>
						<BR>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3">
						<DIV align="center">
							<TABLE id="table4" style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid; BACKGROUND-REPEAT: repeat-x"
								cellSpacing="0" cellPadding="0" width="468" background="../images/bg_cell.gif" border="0">
								<TR>
									<TD width="3" rowSpan="3"></TD>
									<TD width="168" height="3"></TD>
									<TD width="3" rowSpan="3"></TD>
								</TR>
								<TR>
									<TD class="boxhdn" align="center" width="99%" bgColor="#cf8e40" height="25">View 
										by:</FONT>&nbsp;
										<asp:dropdownlist id="DDLCountry" runat="server" CssClass="Box" AutoPostBack="True" Width="199px"></asp:dropdownlist></TD>
								</TR>
								<TR>
									<TD width="168" height="3"></TD>
								</TR>
							</TABLE>
						</DIV>
					</TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 13px" align="center" colSpan="3"><TABLE class="normaltext" id="Table3" style="DISPLAY: none; VISIBILITY: hidden; WIDTH: 932px; HEIGHT: 45px"
							cellSpacing="0" cellPadding="0" width="932" border="0">
							<TR>
								<TD style="WIDTH: 304px">Country<BR>
									<FONT color="#000000">If you are a
										<asp:label id="lblCaption1" runat="server">Label</asp:label>&nbsp;and you are 
										not listed here please send us your details.</FONT></TD>
								<TD style="WIDTH: 340px"><asp:label id="lblCaption" runat="server" Visible="False" Font-Bold="True" Font-Names="Verdana"
										Font-Size="X-Small">Caption</asp:label></TD>
								<TD><SPAN class="contact">You can get list of&nbsp;
										<asp:label id="lblCaption2" runat="server">Label</asp:label>'s&nbsp;Countrywise 
										and or Company Name wise.</SPAN>&nbsp;&nbsp;</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 304px">Company&nbsp;Name</TD>
								<TD style="WIDTH: 340px"><asp:textbox id="tbCompanyName" runat="server" Visible="False"></asp:textbox><asp:imagebutton id="ImgGo" runat="server" Visible="False" ImageUrl="../images/go.gif"></asp:imagebutton></TD>
								<TD></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD valign="bottom" align="right" width="10%">
					</TD>
					<TD noWrap align="center" colSpan="2">
						<asp:datalist id="DLAlphabet" runat="server" CssClass="linkMember" Font-Size="X-Small" ForeColor="Silver"
							RepeatColumns="50" RepeatDirection="Horizontal" Visible="False">
							<ItemTemplate>
								<asp:LinkButton id=linkbut1 runat="server" Font-Size="7pt" Text="<%# Container.DataItem  %>">
								</asp:LinkButton>&nbsp;&nbsp;
							</ItemTemplate>
						</asp:datalist>
						<asp:HyperLink id="hlnkAll" CssClass="linkMember" Font-Size="7pt" runat="server" NavigateUrl="../PortalDefault.aspx?Main_Links_ID=2"> Show Entire Listing&nbsp;&nbsp;&nbsp; </asp:HyperLink>
					</TD>
				</TR>
			</TABLE>
			<TABLE class="normaltext" id="tblResult" cellSpacing="1" cellPadding="1" width="100%" border="0">
				<TR>
					<TD align="center"><asp:label id="lblMessage" runat="server" Visible="False">lblMessage</asp:label></TD>
				</TR>
				<TR>
					<TD><asp:label id="lblcaption3" runat="server" Visible="False" Font-Bold="True">Label</asp:label>&nbsp;
					</TD>
				</TR>
				<TR>
					<TD id="TDSearchResult" align="center" runat="server">
						<asp:datalist id="DLMembers" runat="server" Width="625px" HorizontalAlign="Center">
							<AlternatingItemStyle BackColor="#FFE5C6"></AlternatingItemStyle>
							<ItemTemplate>
								<TABLE class="normaltext" style="WIDTH: 625px; HEIGHT: 20px" cellSpacing="1" cellPadding="1"
									width="672" border="0">
									<TR id="TblSearchResult">
										<TD class="tdRight" align="left" width="49%">
											<asp:LinkButton id="hlnkCompany" runat="server" CssClass="linkMember" Visible="False" Font-Bold="True"
												ToolTip="Click to see Member Details" CommandName="LinkButton2" EnableViewState="False">
												<%# DataBinder.Eval(Container, "DataItem.member_company") %>
											</asp:LinkButton>
											<asp:HyperLink id="hlnkCompanyLogon" runat="server" CssClass="linkMember" Visible="True" Font-Bold="True" 
												ToolTip="Login to view Member Details" NavigateUrl="../PortalDefault.aspx?Main_Links_ID=24"
												EnableViewState="False">
												<%# DataBinder.Eval(Container, "DataItem.member_company") %>
											</asp:HyperLink></TD>
										<TD class="tdRight" align="left" width="31%">
											<asp:Label id="Label1" runat="server" EnableViewState="False">
												<%# DataBinder.Eval(Container, "DataItem.country_name") %>
											</asp:Label></TD>
										<TD class="tdRight" align="center" width="10%">
											<asp:HyperLink id="hlnkPhoneLogon" runat="server" Visible="True" ImageUrl="../Images/icon_phn.gif"
												NavigateUrl="../PortalDefault.aspx?Main_Links_ID=24" EnableViewState="False"></asp:HyperLink>
											<asp:ImageButton id="ibtnPhone" runat="server" Visible="False" ImageUrl="../Images/icon_phn.gif"
												ToolTip="Click to see Member Details" CommandName="ibtnPhone" AlternateText="Phone Number" causesvalidation="False"
												EnableViewState="False"></asp:ImageButton></TD>
										<TD align="center" width="10%">
											<asp:HyperLink id=hlnkEmail runat="server" CssClass="footer" Visible="False" ImageUrl="../Images/icon_email.gif" ToolTip='<%# DataBinder.Eval(Container, "DataItem.company_email") %>' NavigateUrl='<%# "mailto:" &amp; DataBinder.Eval(Container, "DataItem.company_email") &amp; "?subject=Enquiry from phonetrade.cc" %>' EnableViewState="False">[ Email ]</asp:HyperLink>
											<asp:HyperLink id="hlnkEmailLogon" runat="server" Visible="True" ImageUrl="../Images/icon_email.gif"
												ToolTip="Members only" NavigateUrl="../PortalDefault.aspx?Main_Links_ID=24" EnableViewState="False"></asp:HyperLink></TD>
									</TR>
								</TABLE>
							</ItemTemplate>
						</asp:datalist><asp:datalist id="DLResult" runat="server" Width="625px" Visible="False" HorizontalAlign="Center">
							<AlternatingItemStyle BackColor="#FFE5C6"></AlternatingItemStyle>
							<ItemTemplate>
								<TABLE class="normaltext" id="Table1" style="WIDTH: 625px; HEIGHT: 20px" cellSpacing="1"
									cellPadding="1" border="0">
									<TR>
										<TD class="tdRight" align="left">
											<asp:ImageButton id=ibtnFFLogo runat="server" ImageUrl='<%# "../images/logo/" &amp; iif(DataBinder.Eval(Container, "DataItem.company_Logo_Url").Tostring().trim()="","noimage.gif",DataBinder.Eval(Container, "DataItem.company_Logo_Url")) %>' ImageAlign="Left" AlternateText="Member Logo" CausesValidation="False" ToolTip="Click for Member Profile" CommandName="ibtnFFLogo">
											</asp:ImageButton></TD>
										<TD class="tdRight" align="left" width="49%">
											<asp:LinkButton id="LinkButton1" runat="server" CssClass="linkMember" Font-Bold="True">
												<%# DataBinder.Eval(Container, "DataItem.member_company") %>
											</asp:LinkButton>
											<asp:HyperLink id=hlinkcompanyName runat="server" Visible="False" Font-Bold="True" ForeColor="#0000C0" Target="_blank" NavigateUrl='<%# "http://" &amp; DataBinder.Eval(Container, "DataItem.company_website") %>'>
												<%# DataBinder.Eval(Container, "DataItem.member_company") %>
											</asp:HyperLink><BR>
											<asp:Label id="lblcountry" runat="server">
												<%# DataBinder.Eval(Container, "DataItem.country_name") %>
											</asp:Label></TD>
										<TD class="tdRight" align="left"></TD>
										<TD class="tdRight" noWrap align="left" width="15%">
											<asp:Label id="lblTelNo" runat="server">Tel : +<%# Replace(DataBinder.Eval(Container, "DataItem.company_phone"),"*"," ") %></asp:Label></TD>
										<TD align="center" width="21%">
											<asp:HyperLink id=hlinkemail runat="server" CssClass="footer" Visible="True" ImageUrl="../Images/icon_email.gif" ToolTip='<%# DataBinder.Eval(Container, "DataItem.company_email").ToString().Trim() %>' NavigateUrl='<%# "mailto:" &amp; DataBinder.Eval(Container, "DataItem.company_email") &amp; "?subject=Enquiry from phonetrade.cc" %>'>[ Email ]</asp:HyperLink>
										</TD>
									</TR>
								</TABLE>
							</ItemTemplate>
						</asp:datalist></TD>
				</TR>
				<TR>
					<TD id="TDTraderDetails" runat="server"><uc1:traderdetails id="cTraderDetail" runat="server"></uc1:traderdetails></TD>
				</TR>
			</TABLE>
		</td>
		<td id="TD_RIGHT_ADV" vAlign="top" align="right" runat="server"></td>
	</tr>
</table>
