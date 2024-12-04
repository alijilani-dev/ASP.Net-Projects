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
							<TABLE id="tblSearch" runat="server" style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid; BACKGROUND-REPEAT: repeat-x"
								cellSpacing="0" cellPadding="0" width="468" background="../images/bg_cell.gif" border="0">
								<TR>
									<TD width="3" rowSpan="3"></TD>
									<TD width="168" height="3"></TD>
									<TD width="3" rowSpan="3"></TD>
								</TR>
								<TR>
									<TD id="TDCountries" runat="server" class="boxhdn" align="center" width="99%" bgColor="#cf8e40"
										height="25">View by:</FONT>&nbsp;
										<asp:dropdownlist id="DDLCountry" runat="server" EnableViewState="False" CssClass="Box" AutoPostBack="True"
											Width="199px"></asp:dropdownlist>
									</TD>
									<TD id="TDBack" runat="server" class="boxhdn" align="center" width="99%" bgColor="#cf8e40"
										height="25"><asp:hyperlink id="hlnkBack" runat="server" ForeColor="white" Visible="False" EnableViewState="False"
											NavigateUrl="javascript:history.go(-1)">Click Here to Go Back</asp:hyperlink></TD>
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
						<asp:HyperLink id="hlnkAll" Visible="False" CssClass="linkMember" Font-Size="7pt" runat="server"
							NavigateUrl="../PortalDefault.aspx?Main_Links_ID=2"> Show Entire Listing&nbsp;&nbsp;&nbsp; </asp:HyperLink>
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
						<asp:Panel id="pnlTDListing" runat="server" Visible="False" EnableViewState="False">
							<TABLE class="normaltext" id="tblDataList1" style="WIDTH: 625px; HEIGHT: 20px" cellSpacing="1"
								cellPadding="1" width="672" border="0">
								<%
								For Each Dr in DsTDDirectory.tables(0).rows 
								nCounter = nCounter + 1
								%>
								<TR 
              bgColor='<%= IIf( (nCounter Mod 2) <> 0 ,"#FFE2B4","#FFFFFF") %>'>
									<TD class="tdRight" vAlign="middle" align="left" width="3%"><IMG 
                  height=14 src="Images/NewTrader<%=Dr!NewTrader%>.gif" 
                width=30></TD>
									<TD class="normaltext" noWrap align="left" width="49%"><B><A 
                  href="PortalDefault.aspx?Main_links_id=2&amp;Member_ID=<%=Dr!member_id%>"><%= Dr!member_company %></A></B></TD>
									<TD class="tdRight" noWrap align="left" width="18%"><%= Dr!country_name %></TD>
									<TD class="tdRight" align="center" width="15%"><A 
                  href="PortalDefault.aspx?Main_links_id=2&amp;Member_ID=<%=Dr!member_id%>"><IMG title="Click to see Member Details" height="20" alt="Phone Number" src="Images/icon_phn.gif"
												width="20" border="0"></A></TD>
									<TD class="tdRight" align="center" width="15%"><A class=tdRight 
                  href="mailto:<%= Dr!company_email %>?subject=Enquiry from phonetrade.cc"><IMG height="20" alt="[ Email ]" src="Images/icon_email.gif" width="20" border="0"></A></TD>
								</TR>
								<% Next %>
							</TABLE>
						</asp:Panel>
					</TD>
				</TR>
				<TR>
					<TD align="center">
						<asp:Panel id="pnlFFListing" runat="server" Visible="False" EnableViewState="False">
							<TABLE class="normaltext" id="tblDataList2" style="WIDTH: 625px; HEIGHT: 20px" cellSpacing="1"
								cellPadding="1" width="672" border="0">
								<%
								For Each Dr in DsFFDirectory.tables(0).rows
								nCounter = nCounter + 1
								%>
								<TR 
              bgColor='<%= IIf( (nCounter Mod 2) <> 0 ,"#FFE2B4","#FFFFFF") %>'>
									<TD class="tdRight" noWrap align="left" width="60%"><A 
                  href="PortalDefault.aspx?Main_links_id=3&amp;Member_ID=<%=Dr!member_id%>"><%= Dr!member_company %></A><BR>
										<%= Dr!country_name %>
									</TD>
									<TD class="tdRight" noWrap align="center" width="15%">Tel : +<%= Replace(Dr!company_phone,"*"," ") %></TD>
									<TD class="tdRight" align="center" width="15%"><A class=tdRight 
                  href="mailto:<%= Dr!company_email %>?subject=Enquiry from phonetrade.cc"><IMG height="20" alt="[ Email ]" src="Images/icon_email.gif" width="20" border="0"></A></TD>
								</TR>
								<%
								Next
								%>
							</TABLE>
						</asp:Panel>
					</TD>
				</TR>
				<TR>
					<TD id="TDTraderDetails" runat="server"><uc1:traderdetails id="cTraderDetail" runat="server"></uc1:traderdetails></TD>
				</TR>
			</TABLE>
		</td>
		<td id="TD_RIGHT_ADV" vAlign="top" align="right" runat="server"></td>
	</tr>
</table>
