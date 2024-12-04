<%@ Register TagPrefix="uc1" TagName="TraderDetails" Src="TraderDetails.ascx" %>
<%@ Control Language="vb" AutoEventWireup="false" Codebehind="MemberSearch.ascx.vb" Inherits="Trade.MemberSearch" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<table id="Table5" cellSpacing="0" cellPadding="0" width="100%" border="0" runat="server">
	<tr>
		<td id="TD_LEFT_ADV" style="WIDTH: 17px" vAlign="top" runat="server"></td>
		<td vAlign="top" align="center" width="100%">
			<TABLE class="normaltext" id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
				<TR>
					<TD align="center" colSpan="3">
						<asp:panel id="pnlffDirectory" runat="server" EnableViewState="False">
							<IFRAME id="ifrmffDirectory" style="DISPLAY: block; VISIBILITY: visible; WIDTH: 470px; HEIGHT: 60px"
								tabIndex="0" name="IfAdv" align="middle" src="HTMLPages/Ad_TradersDirectory.htm" frameBorder="no"
								scrolling="no" runat="server"></IFRAME>
						</asp:panel><asp:panel id="pnlTradersDirectory" runat="server" EnableViewState="False"><IFRAME id="ifrmTradersDirectory" style="DISPLAY: block; VISIBILITY: visible; WIDTH: 470px; HEIGHT: 60px"
								tabIndex="0" name="IfAdv" align="middle" src="HTMLPages/Ad_FFDirectory.htm" frameBorder="no" scrolling="no" runat="server"></IFRAME>
						</asp:panel><BR>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3">
						<DIV align="center">
							<TABLE id="tblSearch" runat="server" style="BORDER-RIGHT: #3f8bd7 1px solid; BORDER-TOP: #3f8bd7 1px solid; BORDER-LEFT: #3f8bd7 1px solid; BORDER-BOTTOM: #3f8bd7 1px solid; BACKGROUND-REPEAT: repeat-x"	cellSpacing="0" cellPadding="0" width="468" background="../images/bg_cell.gif" border="0">
								<TR>
									<TD width="3" rowSpan="3"></TD>
									<TD width="168" height="3"></TD>
									<TD width="3" rowSpan="3"></TD>
								</TR>
								<TR>
									<TD id="TDCountries" runat="server" class="boxhdn" align="center" width="99%" bgColor="#3f8bd7" height="25">View 
										by:</FONT>&nbsp;
										<asp:dropdownlist id="DDLCountry" runat="server" EnableViewState="False" CssClass="Box" AutoPostBack="True" Width="199px"></asp:dropdownlist>
									</TD>
									<TD id="TDBack" runat="server" class="boxhdn" align="center" width="99%" bgColor="#3f8bd7" height="25"><asp:hyperlink id="hlnkBack" runat="server" ForeColor="white" Visible="False" EnableViewState="False" NavigateUrl="javascript:history.go(-1)">Click Here to Go Back</asp:hyperlink></td>
								</TR>
								<TR>
									<TD width="168" height="3"></TD>
								</TR>
							</TABLE>
						</DIV>
					</TD>
				</TR>
				<TR>
					<TD vAlign="bottom" align="right" width="10%"></TD>
					<TD noWrap align="center" colSpan="2">
						<asp:datalist id="DLAlphabet" runat="server" EnableViewState="False" CssClass="linkMember" ForeColor="Silver" RepeatColumns="50"
							RepeatDirection="Horizontal" Visible="False" Font-Size="X-Small">
							<ItemTemplate>
								<asp:LinkButton id=linkbut1 runat="server" Font-Size="7pt" Text="<%# Container.DataItem %>">
								</asp:LinkButton>&nbsp;&nbsp;
							</ItemTemplate>
						</asp:datalist>
					</TD>
				</TR>
			</TABLE>
			<TABLE class="normaltext" id="tblResult" cellSpacing="1" cellPadding="1" width="100%" border="0">
				<TR>
					<TD align="center"><asp:label id="lblMessage" runat="server" Visible="False" EnableViewState="False"></asp:label></TD>
				</TR>
				<TR>
					<TD><asp:label id="lblcaption3" runat="server" EnableViewState="False" Visible="False" Font-Bold="True"></asp:label>&nbsp;
					</TD>
				</TR>
				<TR>
					<TD id="TDSearchResult" align="center" runat="server">
						<asp:Panel id="pnlTDListing" runat="server" Visible="False" EnableViewState="False">
							<Table id="tblDataList1" class="normaltext" style="WIDTH: 625px; HEIGHT: 20px" cellSpacing="1" cellPadding="1" width="672" border="0">
								<%
								For Each Dr in DsTDDirectory.tables(0).rows 
								nCounter = nCounter + 1
								%>
								<TR bgcolor='<%= IIf( (nCounter Mod 2) <> 0 ,"#F0F8FF","#FFFFFF") %>'>
									<TD class="tdRight" align="left" valign="center" width="3%"><img width="30" height="14" src="Images/NewTrader<%=Dr!NewTrader%>.gif"></TD>
									<TD align="left" width="49%" class="normaltext" nowrap><b><a href="PortalDefault.aspx?Main_links_id=2&amp;Member_ID=<%=Dr!member_id%>"><%= Dr!member_company %></a></b></TD>
									<TD class="tdRight" align="left" width="18%" nowrap><%= Dr!country_name %></TD>
									<TD class="tdRight" align="center" width="15%"><a href="PortalDefault.aspx?Main_links_id=2&amp;Member_ID=<%=Dr!member_id%>"><img title="Click to see Member Details" width="20" height="20" src="Images/icon_phn.gif" alt="Phone Number" border="0" /></a></TD>
									<TD class="tdRight" align="center" width="15%"><a class="tdRight" href="mailto:<%= Dr!company_email %>?subject=Enquiry from phonetrade.cc"><img width="20" height="20" src="Images/icon_email.gif" alt="[ Email ]" border="0" /></a></TD>
								</TR>
								<% Next %>
							</Table>
						</asp:Panel>
					</TD>
				</TR>
				<TR>
					<TD align="center" >
						<asp:Panel id="pnlFFListing" runat="server" Visible="False" EnableViewState="False">
							<Table id="tblDataList2" class="normaltext" style="WIDTH: 625px; HEIGHT: 20px" cellSpacing="1" cellPadding="1" width="672" border="0">
								<%
								For Each Dr in DsFFDirectory.tables(0).rows 
								nCounter = nCounter + 1
								%>
								<TR bgcolor='<%= IIf( (nCounter Mod 2) <> 0 ,"#F0F8FF","#FFFFFF") %>'>
									<TD class="tdRight" align="left" valign="center" width="3%"><a href="PortalDefault.aspx?Main_links_id=3&amp;Member_ID=<%=Dr!member_id%>"><img src="Images/logo/<%= IIf(Dr!company_Logo_Url.Tostring().trim()="","noimage.gif",Dr!company_Logo_Url) %>" border=0></a></TD>
									<TD class="tdRight" align="left" width="60%" nowrap><a href="PortalDefault.aspx?Main_links_id=3&amp;Member_ID=<%=Dr!member_id%>"><%= Dr!member_company %></a><BR><%= Dr!country_name %></TD>
									<TD class="tdRight" align="center" width="15%" nowrap> Tel : +<%= Replace(Dr!company_phone,"*"," ") %></TD>
									<TD class="tdRight" align="center" width="15%"><a class="tdRight" href="mailto:<%= Dr!company_email %>?subject=Enquiry from phonetrade.cc"><img width="20" height="20" src="Images/icon_email.gif" alt="[ Email ]" border="0" /></a></TD>
								</TR>
								<%
								Next
								%>
							</Table>
						</asp:Panel>
					</TD>
				</TR>
				<TR>
					<TD id="TDTraderDetails" runat="server"><uc1:traderdetails id="cTraderDetail" runat="server" EnableViewState="False"></uc1:traderdetails></TD>
				</TR>
			</TABLE>
		</td>
		<td id="TD_RIGHT_ADV" vAlign="top" align="right" runat="server"></td>
	</tr>
</table>
