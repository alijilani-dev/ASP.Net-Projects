<%@ Control Language="vb" AutoEventWireup="false" Codebehind="TradeFloorView.ascx.vb" Inherits="Trade.TradeFloorView" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<%@ Register TagPrefix="uc1" TagName="TraderDetails" Src="TraderDetails.ascx" %>
<table width="100%" border="0">
	<TR>
		<TD align="center"><IFRAME style="WIDTH: 470px; HEIGHT: 60px" name="IfAdv" align="middle" src="HTMLPages/Ad_TradingFloor.htm"
				frameBorder="0" scrolling="no"></IFRAME>
		</TD>
	</TR>
</table>
<table height="5" width="100%" border="0">
	<TR>
		<TD></TD>
	</TR>
</table>
<table height="30" width="100%" border="0">
	<TR>
		<TD width="157"></TD>
		<TD>
			<TABLE id="TblSearchWizard" style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid; BACKGROUND-REPEAT: repeat-x"
				cellSpacing="0" cellPadding="0" width="78%" background="../images/bg_cell.gif" border="0"
				runat="server">
				<TR>
					<TD style="COLOR: white; BACKGROUND-REPEAT: no-repeat" width="99%" bgColor="#cf8e40"
						height="19">&nbsp;<B><FONT face="Verdana" size="2">Search Wizard</FONT></B></TD>
				</TR>
				<TR>
					<TD width="168" height="3"></TD>
				</TR>
				<TR>
					<TD id="TDSearchForm" align="center" height="3" runat="server">
						<TABLE id="table26" cellPadding="0" width="99%" border="0">
							<TR>
								<TD class="normaltext" style="WIDTH: 105px; HEIGHT: 39px" vAlign="middle" noWrap align="right"
									width="95">I want to view:
								</TD>
								<TD class="normaltext" style="WIDTH: 215px; HEIGHT: 39px" vAlign="middle" width="217"><asp:checkbox id="chkbuy" runat="server" Font-Size="8pt" Text="Buy " Checked="True"></asp:checkbox><asp:checkbox id="chkSell" runat="server" Font-Size="8pt" Text="Sell " Checked="True"></asp:checkbox><asp:checkbox id="chkAnnouncement" runat="server" Font-Size="8pt" Text="Announcement" Checked="True"></asp:checkbox></TD>
								<TD class="normaltext" style="WIDTH: 343px; HEIGHT: 39px" width="343">&nbsp;&nbsp; 
									&nbsp;Brand :
									<asp:dropdownlist id="ddlBrand" runat="server" Width="100px" CssClass="box"></asp:dropdownlist>&nbsp;
									<asp:dropdownlist id="ddlModel" runat="server" CssClass="box"></asp:dropdownlist></TD>
								<TD class="normaltext" rowSpan="2"><asp:imagebutton id="ImgGo" runat="server" BorderWidth="0px" ImageUrl="../images/btn_go.gif" CommandName="ImgGo"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD class="normaltext" style="WIDTH: 95px" width="95"></TD>
								<TD class="normaltext" style="WIDTH: 217px" align="right" width="217">
									<asp:dropdownlist id="ddlLastPostings" runat="server" Width="153px" CssClass="box">
										<asp:ListItem Value="0">Today</asp:ListItem>
										<asp:ListItem Value="1">Today and Yesterday</asp:ListItem>
										<asp:ListItem Value="150" Selected="True">Recent Postings</asp:ListItem>
									</asp:dropdownlist></TD>
								<TD class="normaltext" width="403" colSpan="2">&nbsp;Country :
									<asp:dropdownlist id="DDLCountry" runat="server" CssClass="box"></asp:dropdownlist><BR>
									<asp:label id="Label7" runat="server" CssClass="footer" ForeColor="#3300ff" Visible="False">Details</asp:label></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD id="TDSeparator" runat="server"></TD>
	</TR>
</table>
<table height="5" width="100%" border="0">
	<TR>
		<TD></TD>
	</TR>
</table>
<TABLE id="TblDataGrid" style="BACKGROUND-REPEAT: repeat-x" cellSpacing="0" cellPadding="0"
	width="100%" align="center" border="0" runat="server">
	<TR>
		<TD width="168" height="3"></TD>
	</TR>
	<TR>
		<TD height="3">
			<asp:datagrid id="DGTradeFloorView" runat="server" Width="96%" BorderWidth="1px" BorderStyle="None"
				BorderColor="White" AllowSorting="True" HorizontalAlign="Center" CellPadding="0" AutoGenerateColumns="False"
				EnableViewState="False" GridLines="Horizontal">
				<SelectedItemStyle BackColor="Yellow"></SelectedItemStyle>
				<AlternatingItemStyle CssClass="normaltext" VerticalAlign="Middle" BackColor="#FFF4E7"></AlternatingItemStyle>
				<ItemStyle HorizontalAlign="Center" CssClass="normaltext" VerticalAlign="Middle" BackColor="#FFE5C6"></ItemStyle>
				<HeaderStyle Wrap="False" Height="25px" BorderWidth="30px" BorderStyle="Solid" BorderColor="Black"
					CssClass="normalbold"></HeaderStyle>
				<Columns>
					<asp:BoundColumn Visible="False" DataField="country_flag_Img_url" HeaderText="Flag"></asp:BoundColumn>
					<asp:BoundColumn Visible="False" DataField="company_Logo_Url" HeaderText="Logo"></asp:BoundColumn>
					<asp:TemplateColumn HeaderText="  ">
						<ItemStyle CssClass="tdright"></ItemStyle>
						<ItemTemplate></ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="  ">
						<HeaderStyle CssClass="logoheader"></HeaderStyle>
						<ItemStyle Width="130px" CssClass="tdLogo"></ItemStyle>
						<ItemTemplate>
							<a href='PortalDefault.aspx?Main_Links_ID=2&Member_ID=<%# DataBinder.Eval(Container, "DataItem.member_Id") %>'><img src='images/logo/<%# iif(DataBinder.Eval(Container, "DataItem.company_Logo_Url").Tostring().trim()="","noimage.gif",DataBinder.Eval(Container, "DataItem.company_Logo_Url")) %>' border="0px" height="60px" width="120px"></a>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:BoundColumn Visible="False" DataField="Trading_Id" HeaderText="Trader">
						<HeaderStyle CssClass="gridheader"></HeaderStyle>
					</asp:BoundColumn>
					<asp:BoundColumn Visible="False" DataField="Member_ID" HeaderText="Member">
						<HeaderStyle CssClass="gridheader"></HeaderStyle>
					</asp:BoundColumn>
					<asp:TemplateColumn HeaderText="  ">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" CssClass="gridoffertype" VerticalAlign="Middle"></ItemStyle>
						<ItemTemplate>
							<asp:Image id="ImgBugSell" EnableViewState="False" runat="server" BorderWidth="0" ImageUrl='<%# "~/images/" &amp; DataBinder.Eval(Container, "DataItem.BUYSELL") &amp; ".gif" %>' ImageAlign="Left">
							</asp:Image>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:BoundColumn DataField="Status" HeaderText=" ">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" VerticalAlign="Middle"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="MODELNo" HeaderText="Prod.Type">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" VerticalAlign="Middle"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="Brand" HeaderText="Brand">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" VerticalAlign="Middle"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="Quantity" HeaderText="Qty.">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" VerticalAlign="Middle"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn Visible="False" DataField="Price" HeaderText="Price">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" VerticalAlign="Middle"></ItemStyle>
					</asp:BoundColumn>
					<asp:TemplateColumn HeaderText="Specs.">
					<HeaderStyle HorizontalAlign="Center" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
					<ItemStyle HorizontalAlign="Left"></ItemStyle>
						<ItemTemplate>
							<asp:Label id="lblSpec" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Spec") %>'>
							</asp:Label>
								<TABLE class="normaltext" background="../images/bg_cell.gif" id="Table_Detail" style="BORDER-RIGHT: #FFC57D 1px solid; BORDER-TOP: #FFC57D 1px solid; MARGIN: 1px; BORDER-LEFT: #FFC57D 1px solid; BORDER-BOTTOM: #FFC57D 1px solid; DISPLAY: none"
									cellSpacing="0" cellPadding="0" width="220" border="0" runat="server">
									<TR id="trPrice" runat="server" valign="top">
										<TD vAlign="top" noWrap>Price</TD>
										<TD style="WIDTH: 5px" vAlign="top">:</TD>
										<TD vAlign="top">
											<asp:Label id=Label3 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Price")%>' EnableViewState="False">
											</asp:Label></TD>
									</TR>
									<TR id="trShippingTerms" runat="server">
										<TD style="HEIGHT: 21px" vAlign="top">Shp. Terms</TD>
										<TD style="WIDTH: 5px; HEIGHT: 21px" vAlign="top">:</TD>
										<TD style="HEIGHT: 21px" vAlign="top">
											<asp:Label id=Label6 runat="server" EnableViewState="False" TExt='<%# DataBinder.Eval(Container, "DataItem.ShippingTerms") %> ' cssclass="normaltext">
											</asp:Label></TD>
									</TR>
									<TR id="trComments" runat="server">
										<TD vAlign="top">Comments</TD>
										<TD style="WIDTH: 5px" vAlign="top">:</TD>
										<TD vAlign="top" align="left">
											<asp:Label id="lblComments" runat="server" EnableViewState="False" TExt='<%# Server.HtmlDecode(DataBinder.Eval(Container, "DataItem.post_desc")) %>'>
											</asp:Label></TD>
									</TR>
								</TABLE>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn>
						<HeaderStyle Font-Size="8pt" Font-Names="Verdana" Font-Bold="True" HorizontalAlign="Center" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemTemplate>
							<asp:Panel id="pnlDetails" runat="server" HorizontalAlign="Right" EnableViewState="False">
								<IMG alt="Click for Details" id="imggo" src="images/showdetails.gif" align="middle" style="cursor:hand;display='';visibility=''" onclick="javascript:if(<%# "TradeMainCtrl_TFViewCtrl_DGTradeFloorView__ctl" & (DataBinder.Eval(Container,"ItemIndex")+2) & "_Table_Detail" %>.style.display==''){<%# "TradeMainCtrl_TFViewCtrl_DGTradeFloorView__ctl" & (DataBinder.Eval(Container,"ItemIndex")+2) & "_Table_Detail" %>.style.display='none'}else{<%# "TradeMainCtrl_TFViewCtrl_DGTradeFloorView__ctl" & (DataBinder.Eval(Container,"ItemIndex")+2) & "_Table_Detail" %>.style.display=''};" ></asp:Panel>
							<asp:Panel id="pnlPostingDetails" runat="server" EnableViewState="False">
								<asp:Label id="lblAnnouncement" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Post_Desc") %>' CssClass="normaltext" Visible="False" EnableViewState="False"></asp:Label>
							</asp:Panel>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="  ">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" Font-Size="9px" Width="165px" CssClass="tdcontact" VerticalAlign="Top"></ItemStyle>
						<ItemTemplate>
							<asp:Panel id="Panel1" runat="server" EnableViewState="False">
								<img src='images/spacer_con.gif' width="160px" height="1px"><BR>
								<img src='country/<%# DataBinder.Eval(Container, "DataItem.country_flag_Img_url") %>' width="18px" height="12px">
								<b><font color="#cf8e40"><%# DataBinder.Eval(Container, "DataItem.Member_company") %></font></b><br>
								<asp:Label id="Label8" style="font-name: verdana" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.RequestDate") &amp; " GMT" %>' EnableViewState="False"></asp:Label><br>
								<%# "Tel: +" & Replace(DataBinder.Eval(Container, "DataItem.company_phone"),"-"," ") %><br>
								<%# "Mob: +" & Replace(DataBinder.Eval(Container, "DataItem.company_contact1_mobile"),"*"," ") %><br>
								<a href="<%# "mailto:" & DataBinder.Eval(Container, "DataItem.company_email") & "?subject=Message from WorldTrade.cc" %>"><img src="../images/icn_msgme.gif" border="0" width="16px" height="12px" ></a>
							</asp:Panel>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:BoundColumn Visible="False" DataField="Trade_Type" HeaderText="Trade Type"></asp:BoundColumn>
				</Columns>
			</asp:datagrid></TD>
	</TR>
</TABLE>
<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="96%" align="center" border="0">
	<TR>
		<TD></TD>
	</TR>
	<TR>
		<TD id="TDTraderDetails" runat="server"><uc1:traderdetails id="TraderDetailData" runat="server" Visible="False"></uc1:traderdetails></TD>
	</TR>
	<TR>
		<TD id="TDTradeFloorView" align="center" runat="server"></TD>
	</TR>
</TABLE>
</FONT>
