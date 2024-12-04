<%@ Control Language="vb" AutoEventWireup="false" Codebehind="TradeFloorView.ascx.vb" Inherits="Trade.TradeFloorView" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<%@ Register TagPrefix="uc1" TagName="TraderDetails" Src="TraderDetails.ascx" %>
<table width="100%" border="0">
	<TR>
		<TD align="center"><IFRAME style="WIDTH: 470px; HEIGHT: 60px" name="IfAdv" align="middle" src="HTMLPages/Ad_TradingFloor.htm"
				frameBorder="0" scrolling="no"></IFRAME>
		</TD>
	</TR>
	<TR>
		<TD height="5px"></TD>
	</TR>
</table>
<table height="30" width="100%" border="0">
	<TR>
		<TD width="135"></TD>
		<TD>
			<TABLE id="TblSearchWizard" style="BORDER: #3f8bd7 1px solid; BACKGROUND-REPEAT: repeat-x"
				cellSpacing="0" cellPadding="0" width="80%" background="../images/bg_cell.gif" border="0"
				runat="server">
				<TR>
					<TD style="COLOR: white; BACKGROUND-REPEAT: no-repeat" width="99%" bgColor="#3f8bd7"
						height="19">&nbsp;<B><FONT face="Verdana" size="2">Search Wizard</FONT></B></TD>
				</TR>
				<TR>
					<TD width="168" height="3"></TD>
				</TR>
				<TR>
					<TD id="TDSearchForm" align="center" height="3" runat="server">
						<TABLE id="table26" cellPadding="0" width="99%" border="0">
							<TR valign="middle">
								<TD class="normaltext" style="WIDTH: 105px; HEIGHT: 25px" noWrap align="right"
									width="95">I want to view:
								</TD>
								<TD class="normaltext" style="WIDTH: 215px; HEIGHT: 25px"><asp:checkbox id="chkbuy" runat="server" Checked="True" Text="Buy " Font-Size="8pt"></asp:checkbox><asp:checkbox id="chkSell" runat="server" Checked="True" Text="Sell " Font-Size="8pt"></asp:checkbox><asp:checkbox id="chkAnnouncement" runat="server" Checked="True" Text="Announcement" Font-Size="8pt"></asp:checkbox></TD>
								<TD class="normaltext" style="WIDTH: 343px; HEIGHT: 25px">&nbsp;&nbsp; 
									&nbsp;Brand :
									<asp:dropdownlist id="ddlBrand" runat="server" CssClass="box" Width="100px"></asp:dropdownlist>&nbsp;
									<asp:dropdownlist id="ddlModel" runat="server" CssClass="box"></asp:dropdownlist></TD>
								<TD class="normaltext" rowSpan="2"><asp:imagebutton id="ImgGo" runat="server" CommandName="ImgGo" ImageUrl="../images/btn_go.gif" BorderWidth="0px"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD class="normaltext" style="WIDTH: 95px; HEIGHT: 25px"></TD>
								<TD class="normaltext" style="WIDTH: 217px" align="right" width="217"><asp:dropdownlist id="ddlLastPostings" runat="server" CssClass="box" Width="153px">
										<asp:ListItem Value="150" Selected="True">Recent Postings</asp:ListItem>
										<asp:ListItem Value="0">Today</asp:ListItem>
										<asp:ListItem Value="1">Today and Yesterday</asp:ListItem>
									</asp:dropdownlist></TD>
								<TD class="normaltext" width="403" colSpan="2">&nbsp;Country :
									<asp:dropdownlist id="DDLCountry" runat="server" CssClass="box"></asp:dropdownlist><BR>
								</TD>
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
<TABLE id="TblDataGrid" style="BACKGROUND-REPEAT: repeat-x" cellSpacing="0" cellPadding="0"
	width="100%" align="center" border="0" runat="server">
	<TR>
		<TD width="168" height="3"></TD>
	</TR>
	<TR>
		<TD height="3"><asp:datagrid id="DGTradeFloorView" runat="server" Width="98%" BorderWidth="1px" GridLines="Horizontal"
				EnableViewState="False" AutoGenerateColumns="False" CellPadding="0" HorizontalAlign="Center" AllowSorting="True"
				BorderColor="White" BorderStyle="None">
				<AlternatingItemStyle CssClass="normaltext" VerticalAlign="Middle" BackColor="#F3F7FC"></AlternatingItemStyle>
				<ItemStyle HorizontalAlign="Center" CssClass="normaltext" VerticalAlign="Middle" BackColor="#E5EFF9"></ItemStyle>
				<HeaderStyle Wrap="False" Height="25px" BorderWidth="30px" BorderStyle="Solid" BorderColor="Black" CssClass="normalbold"></HeaderStyle>
				<Columns>
					<asp:BoundColumn Visible="False" DataField="country_flag_Img_url" HeaderText="Flag">
					</asp:BoundColumn>
					<asp:BoundColumn Visible="False" DataField="company_Logo_Url" HeaderText="Logo">
					</asp:BoundColumn>
					<asp:TemplateColumn HeaderText="  ">
						<ItemStyle CssClass="tdright"></ItemStyle>
						<ItemTemplate>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="  ">
						<HeaderStyle CssClass="logoheader"></HeaderStyle>
						<ItemStyle CssClass="tdLogo" Width="130px"></ItemStyle>
						<ItemTemplate>
							<a href='../Portaldefault.aspx?Main_Links_ID=2&Member_ID=<%# DataBinder.Eval(Container, "DataItem.member_Id") %>'><img src='images/logo/<%# iif(DataBinder.Eval(Container, "DataItem.company_Logo_Url").Tostring().trim()="","noimage.gif",DataBinder.Eval(Container, "DataItem.company_Logo_Url")) %>' border="0px" height="60px" width="120px"></a>
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
						<ItemStyle HorizontalAlign="Center" CssClass="gridoffertype" VerticalAlign="Middle"></ItemStyle>
						<ItemTemplate>
							<img src='images/<%# DataBinder.Eval(Container, "DataItem.BUYSELL") %>.gif' width="40px" height="8px" align="middle"></a>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:BoundColumn DataField="Status" HeaderText=" ">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" CssClass="vline" VerticalAlign="Middle"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="Brand" HeaderText="Brand">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" CssClass="vline" VerticalAlign="Middle" Wrap=False ></ItemStyle>
					</asp:BoundColumn>
					<asp:TemplateColumn HeaderText="Model">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" CssClass="vline" Wrap="False"></ItemStyle>
						<ItemTemplate>
							<%# DataBinder.Eval(Container, "DataItem.MODELNo") %>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:BoundColumn DataField="Quantity" HeaderText="Qty.">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" CssClass="vline" VerticalAlign="Middle" Wrap=False ></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn Visible="False" DataField="Price" HeaderText="Price">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" CssClass="vline" VerticalAlign="Middle"></ItemStyle>
					</asp:BoundColumn>
					<asp:TemplateColumn HeaderText="Specs.">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap=False ></ItemStyle>
						<ItemTemplate>
							<asp:Label runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.MoreSpec") %>'>
							</asp:Label>
								<TABLE id="Table_Detail" runat="server" class="normaltext" background="../images/bg_cell.gif"
									style="BORDER: #CFE0FF thin solid; MARGIN: 1px; DISPLAY: none"
									cellSpacing="0" cellPadding="0" width="220" border="0" align="left">
									<TR id="trPrice" runat="server" valign="top">
										<TD width="30px" noWrap>Price</TD>
										<TD style="WIDTH: 5px; HEIGHT: 21px">:</TD>
										<TD>
											<asp:Label id="lblPrice" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Price")%>' EnableViewState="False">
											</asp:Label></TD>
									</TR>
									<TR id="trShippingTerms" runat="server" valign="top">
										<TD vAlign="top" nowrap>Shp. Terms</TD>
										<TD style="WIDTH: 5px; HEIGHT: 21px">:</TD>
										<TD>
											<asp:Label id="lblShippingTerms" runat="server" EnableViewState="False" text='<%# DataBinder.Eval(Container, "DataItem.ShippingTerms") %> ' cssclass="normaltext">
											</asp:Label></TD>
									</TR>
									<!--<TR id="trStockLocation" runat="server" Visible="False" valign="top">
										<TD>Stk. Loc.</TD>
										<TD style="WIDTH: 5px; HEIGHT: 21px">:</TD>
										<TD>
											<asp:Label id="lblStockLocation" runat="server" EnableViewState="False" text='<%# DataBinder.Eval(Container, "DataItem.Location") %>' cssclass="normaltext">
											</asp:Label></TD>
									</TR>-->
									<TR id="trComments" runat="server" valign="top">
										<TD>Comments</TD>
										<TD>:</TD>
										<TD align="left">
											<asp:Label id=Label12 runat="server" EnableViewState="False" text='<%# Server.HtmlDecode(DataBinder.Eval(Container, "DataItem.post_desc")) %>'>
											</asp:Label></TD>
									</TR>
								</TABLE>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn>
						<HeaderStyle Font-Size="8pt" Font-Names="Verdana" Font-Bold="True" HorizontalAlign="Center" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle VerticalAlign="middle"></ItemStyle>
						<ItemTemplate>
							<asp:Panel id="pnlDetails" runat="server" EnableViewState="False" HorizontalAlign="Right" >
								<IMG alt="Click for Details" id="imggo" src="images/showdetails.gif" align="middle" style="<% =GetVisibility("imggo")%>" onclick="javascript:if(<%# "TradeMainCtrl_TFViewCtrl_DGTradeFloorView__ctl" & (DataBinder.Eval(Container,"ItemIndex")+2) & "_Table_Detail" %>.style.display==''){<%# "TradeMainCtrl_TFViewCtrl_DGTradeFloorView__ctl" & (DataBinder.Eval(Container,"ItemIndex")+2) & "_Table_Detail" %>.style.display='none'}else{<%# "TradeMainCtrl_TFViewCtrl_DGTradeFloorView__ctl" & (DataBinder.Eval(Container,"ItemIndex")+2) & "_Table_Detail" %>.style.display=''};" ></asp:Panel>
							<asp:Panel id="pnlPostingDetails" runat="server" EnableViewState="False" Visible="False">
								<asp:Label id="lblAnnouncement" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Post_Desc") %>' CssClass="normaltext" Visible="True" EnableViewState="False">
								</asp:Label>
							</asp:Panel>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="  ">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" Font-Size="9px" Width="165px" CssClass="tdcontact" VerticalAlign="Top"></ItemStyle>
						<ItemTemplate>
							<img src='images/spacer_con.gif' width="160px" height="1px"><BR>
							<img src='country/<%# DataBinder.Eval(Container, "DataItem.country_flag_Img_url") %>' width="18px" height="12px">
							<b><font color="#3f8bd7"><%# DataBinder.Eval(Container, "DataItem.Member_company") %></font></b><br>
							<asp:Label id=Label8 style="font-name: verdana" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.RequestDate") &amp; " GMT" %>' EnableViewState="False"></asp:Label><br>
							<%# "Tel: +" & Replace(DataBinder.Eval(Container, "DataItem.company_phone"),"-"," ") %><br>
							<%# "Mob: +" & Replace(DataBinder.Eval(Container, "DataItem.company_contact1_mobile"),"*"," ") %><br>
							<a href="<%# "mailto:" & DataBinder.Eval(Container, "DataItem.company_email") & "?subject=Message from PhoneTrade.cc" %>"><img src="../images/icn_msgme.gif" border="0" width="16px" height="12px" ></a>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:BoundColumn Visible="False" DataField="Trade_Type" HeaderText="   ">
						<HeaderStyle CssClass="conheader"></HeaderStyle>
					</asp:BoundColumn>
				</Columns>
			</asp:datagrid>
		</TD>
	</TR>
</TABLE>