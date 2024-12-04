<%@ Control Language="vb" AutoEventWireup="false" Codebehind="TradeFloor.ascx.vb" Inherits="Trade.TradeFloor" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<%@ Register TagPrefix="uc1" TagName="Confirmation" Src="Confirmation.ascx" %>
<meta content="True" name="vs_showGrid">
<script language="javascript">
<!--
    function ClientOnChange() {
       if (typeof(Page_Validators) == "undefined")
          return;
       document.all["lblOutput"].innerText = Page_IsValid ? "Page is Valid!" : "Some of the required fields are empty";
    }
// -->
</script>
<div align="center">
	<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="735" border="0" runat="server">
		<TR>
			<TD id="TDFormView" colSpan="2" runat="server">
				<TABLE id="tblForm" cellSpacing="1" cellPadding="1" width="100%" border="0">
					<TR>
						<TD width="100%" colSpan="1">
							<TABLE id="Table20" borderColor="#ccccff" cellSpacing="0" cellPadding="0" width="99%" border="0"
								runat="server">
								<TR>
									<TD>
										<DIV align="center">
											<TABLE class="MainTable" id="tbl_buySell" style="BORDER-RIGHT: #4a70af 1px solid; BORDER-TOP: #4a70af 1px solid; BORDER-LEFT: #4a70af 1px solid; BORDER-BOTTOM: #4a70af 1px solid"
												width="100%" align="center" bgColor="#eef3ff" runat="server">
												<TR>
													<TD class="boxhdn" bgColor="#3f8bd7" height="21">&nbsp;Posting Preview</TD>
												</TR>
												<TR>
													<TD style="FONT-FAMILY: Verdana" bgColor="#eef3ff" height="21"><asp:datagrid id="DGTradeFloorView" runat="server" GridLines="Horizontal" EnableViewState="False"
															Width="100%" AutoGenerateColumns="False" CellPadding="0" HorizontalAlign="Center" AllowSorting="True" BorderColor="White" BorderStyle="None" BorderWidth="1px">
															<SelectedItemStyle BackColor="Yellow"></SelectedItemStyle>
															<AlternatingItemStyle CssClass="normaltext" VerticalAlign="Middle" BackColor="#F3F7FC"></AlternatingItemStyle>
															<ItemStyle HorizontalAlign="Center" CssClass="normaltext" VerticalAlign="Middle" BackColor="#E5EFF9"></ItemStyle>
															<HeaderStyle Wrap="False" Height="25px" BorderWidth="30px" BorderStyle="Solid" BorderColor="Black"
																CssClass="normalbold"></HeaderStyle>
															<Columns>
																<asp:TemplateColumn HeaderText="  ">
																	<ItemStyle CssClass="tdright"></ItemStyle>
																	<ItemTemplate>
																		<asp:Image id="ImgFlag" runat="server" Width="18px" ImageUrl='<%# DataBinder.Eval(Container, "DataItem.country_flag_Img_url") %>' EnableViewState="False" Height="12px">
																		</asp:Image>
																	</ItemTemplate>
																</asp:TemplateColumn>
																<asp:TemplateColumn HeaderText="  ">
																	<ItemStyle Width="70px" CssClass="tdright"></ItemStyle>
																	<ItemTemplate>
																		<asp:HyperLink id="hlnkMemberID" Visible="True" runat="server" EnableViewState="False" ImageUrl='<%# "~/images/logo/" &amp; iif(DataBinder.Eval(Container, "DataItem.company_Logo_Url").Tostring().trim()="","noimage.gif",DataBinder.Eval(Container, "DataItem.company_Logo_Url")) %>'>
																		</asp:HyperLink>
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
																		<asp:Image id="ImgBugSell" runat="server" BorderWidth="0" EnableViewState="False" ImageUrl='<%# "~/images/" &amp; DataBinder.Eval(Container, "DataItem.BUYSELL") &amp; ".gif" %>' ImageAlign="Left">
																		</asp:Image>
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
																		<asp:HyperLink id="hlnkModel" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.MODELNo") %>'>
																		</asp:HyperLink>
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
																<asp:BoundColumn DataField="MoreSpec" HeaderText="Specs.">
																	<HeaderStyle HorizontalAlign="Center" CssClass="gridheader" VerticalAlign="Middle"></HeaderStyle>
																	<ItemStyle Wrap="False" HorizontalAlign="Left" VerticalAlign="Middle"></ItemStyle>
																</asp:BoundColumn>
																<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="" CancelText="" EditText="[Edit]"></asp:EditCommandColumn>
																<asp:ButtonColumn Text="[Delete]" CommandName="Delete"></asp:ButtonColumn>
															</Columns>
														</asp:datagrid></TD>
												</TR>
												<TR>
													<TD style="FONT-FAMILY: Verdana; HEIGHT: 17px" align="center" bgColor="#eef3ff" height="17"><asp:imagebutton id="ibtnPosttoTF" runat="server" ImageUrl="../images/btn_admin_postDone.jpg" CausesValidation="False"
															CommandName="PostDirect" Visible="False"></asp:imagebutton></TD>
												</TR>
												<TR>
													<TD class="normaltext" style="FONT-FAMILY: Verdana" align="center" bgColor="#eef3ff"
														height="5"><asp:label id="lblMsg" runat="server" Visible="False" Font-Size="XX-Small" ForeColor="Red">Label</asp:label></TD>
												</TR>
											</TABLE>
										</DIV>
										<TABLE cellSpacing="0" cellPadding="0">
											<TR>
												<TD><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></TD>
											</TR>
										</TABLE>
										<TABLE id="TblPostOffer" style="BORDER-RIGHT: #6288c7 1px solid; BORDER-TOP: #6288c7 1px solid; BORDER-LEFT: #6288c7 1px solid; BORDER-BOTTOM: #6288c7 1px solid"
											cellSpacing="1" width="100%" align="center" bgColor="#eef3ff" border="0" runat="server">
											<TR>
												<TD class="boxhdn" style="HEIGHT: 21px" bgColor="#3f8bd7">&nbsp;Post 
													Offer&nbsp;&nbsp;&nbsp;</TD>
											</TR>
											<TR>
												<TD><IMG height="3" src="file:///C|/Documents and Settings/Nabeel/My Documents/images/spacer_3px.gif"
														width="3" border="0"></TD>
											</TR>
											<TR>
												<TD>
													<DIV align="center">
														<TABLE class="MainTable" id="TblPostingType" cellSpacing="0" cellPadding="0" width="98%"
															bgColor="white" runat="server">
															<TR>
																<TD valignS="middle"><SPAN style="VERTICAL-ALIGN: middle">
																		<TABLE class="MainTable" id="Table4" cellSpacing="0" cellPadding="0" width="100%" bgColor="white">
																			<TR>
																				<TD bgColor="#f3f7fc">
																					<TABLE id="Table8" cellSpacing="0" cellPadding="0">
																						<TR>
																							<TD class="titleTd" style="FONT-WEIGHT: bold; FONT-SIZE: 10pt; COLOR: #4e80b0; FONT-FAMILY: verdana; HEIGHT: 20px"
																								vAlign="middle" width="94">&nbsp;&nbsp;I want to:&nbsp;&nbsp;</TD>
																							<TD style="HEIGHT: 20px" width="58"><asp:radiobutton id="rdoBuy" runat="server" EnableViewState="False" GroupName="GrpRadio" Text="BUY"
																									AutoPostBack="True" CssClass="normaltext"></asp:radiobutton></TD>
																							<TD class="titleTd" style="HEIGHT: 20px" width="9">&nbsp;&nbsp;</TD>
																							<TD style="HEIGHT: 20px" width="58"><asp:radiobutton id="rdoSell" runat="server" EnableViewState="False" GroupName="GrpRadio" Text="SELL"
																									AutoPostBack="True" CssClass="normaltext"></asp:radiobutton></TD>
																							<TD style="HEIGHT: 20px" width="8"></TD>
																							<TD style="HEIGHT: 20px" width="348"><asp:radiobutton id="rdoPostComment" runat="server" EnableViewState="False" GroupName="GrpRadio"
																									Text="Make an Announcement" AutoPostBack="True" CssClass="normaltext"></asp:radiobutton></TD>
																						</TR>
																						<TR>
																							<TD class="titleTd" style="FONT-WEIGHT: bold; FONT-SIZE: 10pt; COLOR: #4e80b0; FONT-FAMILY: verdana"
																								vAlign="middle" width="94"></TD>
																							<TD width="58"></TD>
																							<TD class="titleTd" width="9"></TD>
																							<TD width="58"></TD>
																							<TD width="8"></TD>
																							<TD width="348"></TD>
																						</TR>
																					</TABLE>
																				</TD>
																			</TR>
																		</TABLE>
																	</SPAN>
																</TD>
															</TR>
															<TR>
																<TD bgColor="#eef3ff" height="5"></TD>
															</TR>
														</TABLE>
														</SPAN></DIV>
												</TD>
											</TR>
										</TABLE>
										<table id="TblDetails" cellSpacing="0" cellPadding="0" width="735" align="center" border="0"
											runat="server">
											<TR>
												<TD><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></TD>
											</TR>
											<tr>
												<td>
													<TABLE id="TblPhoneModel" style="BORDER-RIGHT: #4a70af 1px solid; BORDER-TOP: #4a70af 1px solid; BORDER-LEFT: #4a70af 1px solid; BORDER-BOTTOM: #4a70af 1px solid"
														cellSpacing="0" cellPadding="0" width="100%" align="center">
														<TR vAlign="top" height="27">
															<TD style="BACKGROUND-IMAGE: url(../images/postform_bar_bg.gif); VERTICAL-ALIGN: middle; BORDER-BOTTOM: #6288c7 1px solid; BACKGROUND-REPEAT: repeat-x">
																<TABLE id="table29" cellSpacing="0" cellPadding="0" width="232" border="0">
																	<TR>
																		<TD width="33">&nbsp;<IMG height="26" src="../images/postform_a.gif" width="26" align="middle" border="0">
																		</TD>
																		<TD class="titleTd" vAlign="middle">
																			<P align="left"><B><FONT face="Verdana" color="#fea300" size="1">&nbsp;Choose Phone 
																						Model&nbsp; </FONT></B>
																			</P>
																		</TD>
																	</TR>
																</TABLE>
															</TD>
														</TR>
														<TR>
															<TD style="FONT-WEIGHT: bold; FONT-SIZE: 11px; COLOR: #4e80b0; FONT-FAMILY: verdana"
																height="20">
																<TABLE id="table31">
																	<TR>
																		<TD style="FONT-WEIGHT: bold; FONT-SIZE: 11px; COLOR: #4e80b0; FONT-FAMILY: verdana"
																			width="143" height="20">&nbsp;&nbsp;&nbsp;Choose your <B>Brand:</B></TD>
																		<TD class="titleTd" vAlign="middle">
																			<P align="left"><asp:dropdownlist id="ddlBrand" runat="server" Width="153px" AutoPostBack="True" CssClass="box" BackColor="#EEF3FF"
																					Font-Bold="true"></asp:dropdownlist></P>
																		</TD>
																		<TD style="FONT-WEIGHT: bold; FONT-SIZE: 11px; COLOR: #4e80b0; FONT-FAMILY: verdana"
																			width="42">Model:</TD>
																		<TD class="titleTd"><asp:dropdownlist id="ddlModel" runat="server" Width="152px" CssClass="box" BackColor="#EEF3FF"></asp:dropdownlist></TD>
																		<TD>
																			<DIV id="ModelDiv0">&nbsp;</DIV>
																		</TD>
																	</TR>
																</TABLE>
															</TD>
														</TR>
														<TR>
															<TD style="FONT-WEIGHT: bold; FONT-SIZE: 11px; COLOR: #4e80b0; FONT-FAMILY: verdana"
																height="20">&nbsp;&nbsp;&nbsp;&nbsp;If other model number (e.g. <FONT color="#0000ff">
																	9300i</FONT> or <FONT color="#0000ff">D600</FONT>) enter it: <SPAN class="titleTd">
																	&nbsp;
																	<asp:textbox id="txtModelNo" runat="server" EnableViewState="False" CssClass="box" MaxLength="20"></asp:textbox><asp:customvalidator id="CVModel" runat="server" EnableViewState="False" CssClass="normaltext" Enabled="False"
																		Display="Dynamic" ControlToValidate="txtModelNo" ErrorMessage="Either select or specify some model." EnableClientScript="False" OnServerValidate="CVModel_ServerValidate">Either select or specify some model.</asp:customvalidator>&nbsp;
																	<asp:label id="lblModelValidator" runat="server" EnableViewState="False" Visible="False" Font-Size="8pt"
																		ForeColor="Red" CssClass="normaltext">Either select or specify some model.</asp:label></SPAN></TD>
														</TR>
														<TR id="Search_TR" style="DISPLAY: none">
															<TD align="center" height="5"></TD>
														</TR>
													</TABLE>
												</td>
											</tr>
											<TR>
												<TD><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></TD>
											</TR>
											<tr>
												<td>
													<TABLE class="MainTable" id="TblStockSpecs" style="BORDER-RIGHT: #4a70af 1px solid; BORDER-TOP: #4a70af 1px solid; BORDER-LEFT: #4a70af 1px solid; BORDER-BOTTOM: #4a70af 1px solid"
														cellSpacing="0" cellPadding="0" width="100%" bgColor="white" runat="server">
														<TR vAlign="top" height="27">
															<TD style="BACKGROUND-IMAGE: url(../images/postform_bar_bg.gif); VERTICAL-ALIGN: middle; BORDER-BOTTOM: #6288c7 1px solid; BACKGROUND-REPEAT: repeat-x; HEIGHT: 34px"
																colSpan="8">
																<TABLE id="table35" style="WIDTH: 158px; HEIGHT: 28px" cellSpacing="0" cellPadding="0"
																	width="158" border="0">
																	<TR>
																		<TD>&nbsp;<IMG height="26" src="../images/postform_b.gif" width="26" align="middle" border="0">&nbsp;
																		</TD>
																		<TD class="titleTd" vAlign="middle"><B><FONT face="Verdana" color="#fea300" size="1">Stock 
																					Specification</FONT></B></TD>
																	</TR>
																</TABLE>
															</TD>
														</TR>
														<TR style="HEIGHT: 30px; BACKGROUND-COLOR: #f3f7fc">
															<TD colSpan="8" height="5"><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></TD>
														</TR>
														<TR style="HEIGHT: 20px; BACKGROUND-COLOR: #f3f7fc">
															<TD class="titleTd" vAlign="middle" width="12%"><B><FONT face="Verdana" color="#515c66" size="1">&nbsp;&nbsp;Quantity:&nbsp;
																	</FONT></B>
															</TD>
															<TD width="20%"><asp:textbox id="txtQuantity" runat="server" Width="85px" CssClass="box" MaxLength="15"></asp:textbox><asp:rangevalidator id="RVQty" runat="server" Visible="False" CssClass="error" Enabled="False" Display="Dynamic"
																	ControlToValidate="txtQuantity" ErrorMessage="Invalid Quantity" MinimumValue="1" MaximumValue="9999999" Type="Integer"></asp:rangevalidator><asp:requiredfieldvalidator id="RFVQuantity" runat="server" CssClass="error" Display="Dynamic" ControlToValidate="txtQuantity"
																	ErrorMessage="Quantity Can not be blank"></asp:requiredfieldvalidator></TD>
															<TD width="1%">&nbsp;</TD>
															<TD width="7%"><B><FONT face="Verdana" color="#515c66" size="1">Status:</FONT></B></TD>
															<TD width="19%"><asp:dropdownlist id="ddlStatus" runat="server" CssClass="box">
																	<asp:ListItem Value="1" Selected="True">Simfree</asp:ListItem>
																	<asp:ListItem Value="2">Network</asp:ListItem>
																	<asp:ListItem Value="3">Refurbished</asp:ListItem>
																	<asp:ListItem Value="4">CMR Stock</asp:ListItem>
																</asp:dropdownlist></TD>
															<TD width="1%">&nbsp;</TD>
															<TD class="titleTd" vAlign="middle" width="5%"><B><FONT face="Verdana" color="#515c66" size="1">Price:&nbsp;
																	</FONT></B>
															</TD>
															<TD vAlign="middle" width="35%"><asp:dropdownlist id="ddlCurrency" runat="server" CssClass="box"></asp:dropdownlist>&nbsp;
																<asp:textbox id="txtPrice" runat="server" Width="48px" CssClass="box" MaxLength="4">0</asp:textbox><asp:hyperlink id="hlnkCurrencyConverter" style="CURSOR: hand" runat="server" ForeColor="Blue"
																	CssClass="footer" NavigateUrl="" Target="_blank" Font-Underline="True">Currency Converter</asp:hyperlink><BR>
																<asp:rangevalidator id="RVPrice" runat="server" CssClass="error" Display="Dynamic" ControlToValidate="txtPrice"
																	ErrorMessage="Invalid Price" MinimumValue="0" MaximumValue="9999999" Type="Currency"></asp:rangevalidator><asp:requiredfieldvalidator id="RFVPrice" runat="server" Visible="False" CssClass="error" Display="Dynamic"
																	ControlToValidate="txtPrice" ErrorMessage="Price Can not be blank. "></asp:requiredfieldvalidator></TD>
														</TR>
														<TR style="DISPLAY: block; HEIGHT: 30px; BACKGROUND-COLOR: #e5eff9">
															<TD class="titleTd" style="BACKGROUND-COLOR: #eef3ff" width="12%"><STRONG><FONT face="Verdana" color="#515c66" size="1">&nbsp; 
																		Specification:</FONT></STRONG></TD>
															<TD style="BACKGROUND-COLOR: #eef3ff" width="88%" colSpan="7"><asp:textbox id="txtMoreSpecs" runat="server" Width="290px" CssClass="box" MaxLength="50" ToolTip="Type here if you select Others in Specification Field."></asp:textbox><B><FONT face="Verdana" color="#515c66" size="1"></FONT></B></TD>
														</TR>
													</TABLE>
												</td>
											</tr>
											<TR>
												<TD><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></TD>
											</TR>
											<tr>
												<td id="TD_ShippingDetails" runat="server"><asp:panel id="pnlShippingDetails" runat="server" EnableViewState="False" Visible="False">
														<TABLE class="MainTable" id="TblShippingDetails" style="BORDER-RIGHT: #4a70af 1px solid; BORDER-TOP: #4a70af 1px solid; BORDER-LEFT: #4a70af 1px solid; BORDER-BOTTOM: #4a70af 1px solid"
															cellSpacing="0" cellPadding="0" width="100%" bgColor="white" runat="server">
															<TR vAlign="top" height="10">
																<TD style="BACKGROUND-IMAGE: url(../images/postform_bar_bg.gif); VERTICAL-ALIGN: middle; BORDER-BOTTOM: #6288c7 1px solid; BACKGROUND-REPEAT: repeat-x"
																	colSpan="5">
																	<TABLE id="table39" cellSpacing="0" cellPadding="0" width="140" border="0">
																		<TR>
																			<TD>&nbsp;<IMG height="26" src="../images/postform_c.gif" width="26" align="middle" border="0">&nbsp;
																			</TD>
																			<TD class="titleTd" vAlign="middle"><B><FONT face="Verdana" color="#fea300" size="1">Shipping 
																						Details</FONT></B></TD>
																		</TR>
																	</TABLE>
																</TD>
															</TR>
															<TR style="HEIGHT: 2px; BACKGROUND-COLOR: #f3f7fc">
																<TD colSpan="5"><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0">
																</TD>
															</TR>
															<TR style="HEIGHT: 10px; BACKGROUND-COLOR: #eef3ff">
																<TD class="titleTd" vAlign="middle" width="106"><B><FONT face="Verdana" color="#515c66" size="1">&nbsp;&nbsp;Shipping 
																			Terms:&nbsp; </FONT></B>
																</TD>
																<TD vAlign="middle" width="186">
																	<asp:dropdownlist id="ddlShippingTerms" runat="server" EnableViewState="False" CssClass="box">
																		<asp:ListItem Value="0" Selected="True">Select..</asp:ListItem>
																		<asp:ListItem Value="1">C&amp;F</asp:ListItem>
																		<asp:ListItem Value="2">CIF</asp:ListItem>
																		<asp:ListItem Value="5">EX Works</asp:ListItem>
																		<asp:ListItem Value="14">FOB</asp:ListItem>
																	</asp:dropdownlist></TD>
																<TD width="11">&nbsp;</TD>
																<TD class="titleTd" vAlign="middle" width="74"><B><FONT face="Verdana" color="#515c66" size="1">Country:&nbsp;
																		</FONT></B>
																</TD>
																<TD vAlign="middle" width="221">
																	<asp:dropdownlist id="ddlCountry" runat="server" EnableViewState="False" CssClass="box"></asp:dropdownlist>&nbsp;
																	<asp:requiredfieldvalidator id="Requiredfieldvalidator1" runat="server" Font-Size="1px" ErrorMessage="Country Can not be blank"
																		ControlToValidate="ddlCountry"></asp:requiredfieldvalidator></TD>
															</TR>
															<TR style="HEIGHT: 10px; BACKGROUND-COLOR: #f3f7fc">
																<TD colSpan="5"><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></TD>
															</TR>
														</TABLE>
													</asp:panel></td>
											</tr>
										</table>
									</TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
				</TABLE>
				<TABLE id="tbl_Comment" style="BORDER-RIGHT: #6288c7 1px solid; BORDER-TOP: #6288c7 1px solid; BORDER-LEFT: #6288c7 1px solid; BORDER-BOTTOM: #6288c7 1px solid"
					cellSpacing="0" cellPadding="0" width="99.5%" align="center" bgColor="#eef3ff" border="0"
					runat="server">
					<TR>
						<TD vAlign="top" align="center">
							<TABLE class="MainTable" id="Table19" cellSpacing="0" cellPadding="0" width="100%" bgColor="white">
								<TR vAlign="top" height="27">
									<TD style="BACKGROUND-IMAGE: url(../images/postform_bar_bg.gif); VERTICAL-ALIGN: middle; BORDER-BOTTOM: #6288c7 1px solid; BACKGROUND-REPEAT: repeat-x"
										colSpan="5">
										<TABLE id="Table21" cellSpacing="0" cellPadding="0" width="199" border="0">
											<TR>
												<TD width="40">&nbsp;
													<asp:image id="ImgD" runat="server" EnableViewState="False" ImageUrl="../images/postform_c.gif"></asp:image>&nbsp;
												</TD>
												<TD class="titleTd" vAlign="middle" width="159"><B><FONT face="Verdana" color="#fea300" size="1"><asp:label id="lblTypeComments" runat="server" EnableViewState="False">Add your Comments</asp:label></FONT></B></TD>
											</TR>
										</TABLE>
									</TD>
								</TR>
								<TR style="HEIGHT: 5px; BACKGROUND-COLOR: #f3f7fc">
									<TD colSpan="5"><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></TD>
								</TR>
								<TR style="HEIGHT: 30px; BACKGROUND-COLOR: #eef3ff">
									<TD class="titleTd" width="18%"><B><FONT face="Verdana" color="#515c66" size="1">&nbsp;&nbsp;
												<asp:label id="lblAnnouncement" runat="server" EnableViewState="False">Comment:</asp:label>&nbsp;
											</FONT></B>
									</TD>
									<TD colSpan="3"><asp:textbox id="txtComment" runat="server" Width="350px" CssClass="box" MaxLength="250" Height="60px"
											TextMode="MultiLine"></asp:textbox></TD>
									<td id="tdCharCounter" align="left" width="31%" runat="server">
										<SCRIPT>
										displaylimit("","TradeMainCtrl__ctl6_txtComment",250)
										</SCRIPT>
									</td>
								</TR>
								<TR style="HEIGHT: 5px; BACKGROUND-COLOR: #f3f7fc">
									<TD colSpan="5"><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
				</TABLE>
			</TD>
		</TR>
		<TR>
			<TD style="HEIGHT: 11px" align="left" colSpan="2">&nbsp;<asp:checkbox id="chkGrouping" runat="server" EnableViewState="False" Text="I want to POST more ITEMS"
					CssClass="normaltext"></asp:checkbox>
			</TD>
		</TR>
		<TR>
			<TD align="left" width="81%"><asp:imagebutton id="btnShowSummary" runat="server" ImageUrl="../images/btn_admin_ViewPost.jpg" CommandName="ShowSummary"
					Visible="False"></asp:imagebutton>&nbsp;
				<asp:imagebutton id="btnPostTF" runat="server" EnableViewState="False" ImageUrl="../images/btn_Post_request.jpg"
					CommandName="PostDirect"></asp:imagebutton><asp:imagebutton id="IbtnUpdatePosting" runat="server" ImageUrl="../images/btn_Post_update.jpg" CausesValidation="false"
					CommandName="HideSummary"></asp:imagebutton><asp:imagebutton id="IbtnSaveChanges" runat="server" ImageUrl="../images/btn_admin_savechanges.jpg"
					CausesValidation="false" CommandName="SaveChanges" Visible="False"></asp:imagebutton><asp:imagebutton id="IbtnDeletePosting" runat="server" ImageUrl="../images/btn_admin_deletepost.jpg"
					CommandName="ShowSummary" Visible="False"></asp:imagebutton></TD>
			<TD align="left" width="19%"><asp:imagebutton id="ImgbtnCancel" runat="server" ImageUrl="../images/btn_Cancel_request.jpg" CausesValidation="False"></asp:imagebutton></TD>
		</TR>
		<TR>
			<TD align="left">&nbsp;</TD>
			<TD align="left">&nbsp;</TD>
		</TR>
	</TABLE>
	</TD></TR></TABLE></TD></TR><TR>
		<TD id="TDSummaryView" runat="server"></TD>
	</TR>
	<TR>
		<TD></TD>
	</TR>
	</TABLE></div>
