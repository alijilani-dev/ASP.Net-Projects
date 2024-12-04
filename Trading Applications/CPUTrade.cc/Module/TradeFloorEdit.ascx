<%@ Control Language="vb" AutoEventWireup="false" Codebehind="TradeFloorEdit.ascx.vb" Inherits="Trade.TradeFloorEdit" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<%@ Register TagPrefix="uc1" TagName="TraderDetails" Src="TraderDetails.ascx" %>
<table width="100%" border="0">
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
			<TABLE id="TblSearchWizard" style="BORDER-RIGHT: #cf8e5d 1px solid; BORDER-TOP: #cf8e5d 1px solid; BORDER-LEFT: #cf8e5d 1px solid; BORDER-BOTTOM: #cf8e5d 1px solid; BACKGROUND-REPEAT: repeat-x"
				cellSpacing="0" cellPadding="0" width="78%" background="../images/bg_cell.gif" border="0"
				runat="server">
				<TR>
					<TD style="COLOR: white; BACKGROUND-REPEAT: no-repeat" width="99%" bgColor="#cf8e40"
						height="19">&nbsp;<B><FONT face="Verdana" size="2">Edit Posting</FONT></B></TD>
				</TR>
				<TR>
					<TD width="168" height="3"></TD>
				</TR>
				<TR>
					<TD id="TDSearchForm" align="center" height="3" runat="server">
						<TABLE id="table26" style="WIDTH: 585px" cellPadding="0" width="585" border="0">
							<TR>
								<TD class="normaltext" style="WIDTH: 100px" vAlign="middle" noWrap align="right" width="95">I 
									want to view:
								</TD>
								<TD class="normaltext" style="WIDTH: 343px" width="343">
									<asp:dropdownlist id="ddlLastPostings" runat="server" Width="153px" CssClass="box">
										<asp:ListItem Value="0">Today</asp:ListItem>
										<asp:ListItem Value="1">Today and Yesterday</asp:ListItem>
										<asp:ListItem Value="150" Selected="True">Recent Postings</asp:ListItem>
										<asp:ListItem Value="7">Last Week</asp:ListItem>
									</asp:dropdownlist><asp:imagebutton id="ImgGo" runat="server" BorderWidth="0px" ImageUrl="../images/btn_go.gif" CommandName="ImgGo"></asp:imagebutton>
								</TD>
								<TD class="normaltext"></TD>
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
		<TD width="168" height="3">
		</TD>
	</TR>
	<TR>
		<TD align="right" height="3">
			<TABLE id="Table5" cellSpacing="0" cellPadding="0" border="0" style="TEXT-ALIGN: right">
				<TR>
					<TD></TD>
					<TD>
						<asp:imagebutton id="IbtnTopEditSelection" runat="server" CommandName="EditSelection" ImageUrl="../images/btn_admin_editSelection.jpg"></asp:imagebutton>&nbsp;
						<asp:imagebutton id="IbtnTopDeleteSelection" runat="server" CommandName="DeleteSelection" ImageUrl="../images/btn_admin_deleteSelection.jpg"></asp:imagebutton>&nbsp;
						<asp:imagebutton id="IbtnTopRePostSelection" runat="server" CommandName="RepostSelection" ImageUrl="../images/btn_admin_postDone.jpg"></asp:imagebutton>&nbsp;
					</TD>
					<TD width="150">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</TD>
				</TR>
				<TR>
					<TD></TD>
					<TD></TD>
					<TD width="150" height="10"></TD>
				</TR>
			</TABLE>
			<asp:datagrid id="DGTradeFloorView" runat="server" Width="96%" BorderWidth="1px" BorderStyle="None"
				BorderColor="White" AllowSorting="True" HorizontalAlign="Center" CellPadding="0" AutoGenerateColumns="False"
				GridLines="Horizontal">
				<SelectedItemStyle BackColor="Yellow"></SelectedItemStyle>
				<AlternatingItemStyle CssClass="normaltext" VerticalAlign="Middle" BackColor="#FFF2E6"></AlternatingItemStyle>
				<ItemStyle HorizontalAlign="Center" CssClass="normaltext" VerticalAlign="Middle" BackColor="FloralWhite"></ItemStyle>
				<HeaderStyle Wrap="False" Height="25px" BorderWidth="30px" BorderStyle="Solid" BorderColor="Black"
					CssClass="normalbold"></HeaderStyle>
				<Columns>
					<asp:BoundColumn Visible="False" DataField="country_flag_Img_url" HeaderText="Flag">
						<HeaderStyle CssClass="gridheader"></HeaderStyle>
					</asp:BoundColumn>
					<asp:BoundColumn Visible="False" DataField="company_Logo_Url" HeaderText="Logo">
						<HeaderStyle CssClass="gridheader"></HeaderStyle>
					</asp:BoundColumn>
					<asp:TemplateColumn HeaderText="  ">
						<ItemStyle CssClass="tdright"></ItemStyle>
						<ItemTemplate>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="  ">
						<ItemStyle Width="70px" CssClass="tdright"></ItemStyle>
						<ItemTemplate>
							<asp:HyperLink id="hlnkMemberID" runat="server" Visible="True" ImageUrl='<%# "~/images/logo/" &amp; iif(DataBinder.Eval(Container, "DataItem.company_Logo_Url").Tostring().trim()="","noimage.gif",DataBinder.Eval(Container, "DataItem.company_Logo_Url")) %>' NavigateUrl='<%# "../Portaldefault.aspx?Main_Links_ID=" &amp; Member_Profile_ID.toString() & iif(Member_Profile_ID.toString()="2","&Member_ID=" & DataBinder.Eval(Container, "DataItem.member_Id"),"")%>' EnableViewState="False"></asp:HyperLink>
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
							<asp:Image id="ImgBugSell" EnableViewState="False" runat="server" BorderWidth="0" ImageUrl='<%# "~/images/" &amp; DataBinder.Eval(Container, "DataItem.BUYSELL") &amp; ".gif" %>' ImageAlign="Left"></asp:Image>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:BoundColumn DataField="Status" HeaderText=" ">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" VerticalAlign="Middle"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="Brand" HeaderText="Brand">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" VerticalAlign="Middle"></ItemStyle>
					</asp:BoundColumn>
					<asp:TemplateColumn HeaderText="Model">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left"></ItemStyle>
						<ItemTemplate>
							<asp:HyperLink id=hlnkModel runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.MODELNo") %>'></asp:HyperLink>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:BoundColumn DataField="Quantity" HeaderText="Qty.">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" VerticalAlign="Middle"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn Visible="False" DataField="Price" HeaderText="Price">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" VerticalAlign="Middle"></ItemStyle>
					</asp:BoundColumn>
					<asp:TemplateColumn HeaderText="Specs.">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" VerticalAlign="Middle"></ItemStyle>
						<ItemTemplate>
							<asp:Label runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Spec") %>'></asp:Label>
							<TABLE id="Table_Detail" runat="server" class="normaltext" background="../images/bg_cell.gif"
								style="BORDER-RIGHT: #cf8e40 thin solid; BORDER-TOP: #cf8e40 thin solid; MARGIN: 1px; BORDER-LEFT: #cf8e40 thin solid; BORDER-BOTTOM: #cf8e40 thin solid; DISPLAY: none"
								cellSpacing="0" cellPadding="0" width="220" border="0">
								<TR id="trPrice" runat="server">
									<TD vAlign="top" noWrap>Price</TD>
									<TD style="WIDTH: 5px" vAlign="top">:</TD>
									<TD vAlign="top"><asp:Label id="Label3" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Price")%>' EnableViewState="False"></asp:Label></TD>
								</TR>
								<TR id="trShippingTerms" runat="server" Visible='<%# iif(DataBinder.Eval(Container, "DataItem.BUYSELL").Tostring().trim()="BUY",False,True) %>'>
									<TD style="HEIGHT: 21px" vAlign="top" nowrap>Shp. Terms</TD>
									<TD style="WIDTH: 5px; HEIGHT: 21px" vAlign="top">:</TD>
									<TD style="HEIGHT: 21px" vAlign="top"><asp:Label id=Label6 runat="server" EnableViewState="False" TExt='<%# DataBinder.Eval(Container, "DataItem.ShippingTerms") %> ' cssclass="normaltext"></asp:Label></TD>
								</TR>
								<TR id="trStockLocation" runat="server" Visible='<%# iif(DataBinder.Eval(Container, "DataItem.BUYSELL").Tostring().trim()="BUY",False,True) %>'>
									<TD style="HEIGHT: 21px" vAlign="top">Stk. Loc.</TD>
									<TD style="WIDTH: 5px; HEIGHT: 21px" vAlign="top">:</TD>
									<TD style="HEIGHT: 21px" vAlign="top"><asp:Label id="Label14" runat="server" EnableViewState="False" TExt='<%# DataBinder.Eval(Container, "DataItem.Location") %>' cssclass="normaltext"></asp:Label></TD>
								</TR>
								<TR id="trComments" runat="server" Visible='<%# iif(DataBinder.Eval(Container, "DataItem.post_desc").Tostring().trim()="No Comments.",False,True) %>'>
									<TD vAlign="top">Comments</TD>
									<TD style="WIDTH: 5px" vAlign="top">:</TD>
									<TD align="left" vAlign="top"><asp:Label id="Label12" runat="server" EnableViewState="False" TExt='<%# Server.HtmlDecode(DataBinder.Eval(Container, "DataItem.post_desc")) %>'></asp:Label></TD>
								</TR>
							</TABLE>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Select">
						<HeaderStyle Font-Size="8pt" Font-Names="Verdana" Font-Bold="True" HorizontalAlign="Center" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemTemplate>
							<asp:Panel id="pnlPostingDetails" runat="server" EnableViewState="False">
								<asp:Label id="lblAnnouncement" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Post_Desc") %>' CssClass="normaltext" Visible="False" EnableViewState="False"></asp:Label>
							</asp:Panel>
							<TABLE id="Table_Tools" runat="server" cellSpacing="0" cellPadding="0" align="right">
								<TR>
									<TD align="right">
										<asp:Panel id="pnlDetails" runat="server" EnableViewState="False" HorizontalAlign="Right">
											<IMG alt="Click for Details" id="imggo" src="images/showdetails.gif" align="middle" style="<% =GetVisibility("imggo")%>" onclick="javascript:if(<%# "TradeMainCtrl_TFViewCtrl_DGTradeFloorView__ctl" & (DataBinder.Eval(Container,"ItemIndex")+2) & "_Table_Detail" %>.style.display==''){<%# "TradeMainCtrl_TFViewCtrl_DGTradeFloorView__ctl" & (DataBinder.Eval(Container,"ItemIndex")+2) & "_Table_Detail" %>.style.display='none'}else{<%# "TradeMainCtrl_TFViewCtrl_DGTradeFloorView__ctl" & (DataBinder.Eval(Container,"ItemIndex")+2) & "_Table_Detail" %>.style.display=''};" ></asp:Panel>
									</TD>
									<TD align="right">
										<asp:CheckBox id="chkTools" runat="server"></asp:CheckBox>
									</TD>
								</TR>
							</TABLE>
							<asp:Panel id="pnlEditPosting" Visible="False" runat="server" EnableViewState="False" HorizontalAlign="Right">
								<asp:ImageButton id="ibtnEdit" runat="server" CommandName="EditRow" ImageUrl="../images/btn_editpost.gif" EnableViewState="False" Visible="True" ToolTip="Click to Edit Announcement"></asp:ImageButton>
								<asp:ImageButton id="ibtnDelete" runat="server" CommandName="DeleteRow" ImageUrl="../images/btn_delete.jpg" EnableViewState="False" Visible="True" ToolTip="Click to Delete Announcement"></asp:ImageButton>
							</asp:Panel>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="  ">
						<HeaderStyle HorizontalAlign="Left" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle HorizontalAlign="Left" Width="150px" CssClass="tdleft" VerticalAlign="Top"></ItemStyle>
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
			</asp:datagrid><BR>
			<TABLE id="Table3" cellSpacing="0" cellPadding="0" border="0" style="TEXT-ALIGN: right">
				<TR>
					<TD></TD>
					<TD><asp:imagebutton id="IbtnEditSelection" runat="server" ImageUrl="../images/btn_admin_editSelection.jpg"
							CommandName="EditSelection"></asp:imagebutton>&nbsp;
						<asp:imagebutton id="IbtnDeleteSelection" runat="server" ImageUrl="../images/btn_admin_deleteSelection.jpg"
							CommandName="DeleteSelection"></asp:imagebutton>&nbsp;
						<asp:imagebutton id="IbtnRePostSelection" runat="server" ImageUrl="../images/btn_admin_postDone.jpg"
							CommandName="RepostSelection"></asp:imagebutton>&nbsp;
					</TD>
					<TD width="150">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</TD>
				</TR>
			</TABLE>
		</TD>
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
