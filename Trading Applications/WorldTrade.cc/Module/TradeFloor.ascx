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
<uc1:confirmation id="Confirm" DESIGNTIMEDRAGDROP="88" runat="server" Visible="False"></uc1:confirmation>
<div align="center">
	<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="615" border="0" runat="server">
		<TR>
			<TD id="TDFormView" colSpan="2" runat="server">
				<TABLE id="tblForm" cellSpacing="1" cellPadding="1" width="100%" border="0">
					<TR>
						<TD width="100%" colSpan="1">
							<TABLE id="Table20" borderColor="#ccccff" cellSpacing="0" cellPadding="0" width="100%"
								border="0" runat="server">
								<TR>
									<TD>
										<DIV align="center">
											<TABLE class="MainTable" id="tbl_buySell" style="BORDER-RIGHT: #ffbf55 1px solid; BORDER-TOP: #ffbf55 1px solid; BORDER-LEFT: #ffbf55 1px solid; BORDER-BOTTOM: #ffbf55 1px solid"
												width="600" align="center" bgColor="#fff4e7" runat="server">
												<TR>
													<TD class="boxhdn" bgColor="#cf8e40" height="21">&nbsp;Last Postings</TD>
												</TR>
												<TR>
													<TD style="FONT-FAMILY: Verdana" bgColor="#fff4e7" height="21"><asp:datagrid id="DGTradeFloorView" runat="server" Visible="False" BorderWidth="0px" BorderStyle="None"
															BorderColor="Gainsboro" AllowSorting="True" HorizontalAlign="Center" SelectedItemStyle-BackColor="#ff9966" CellPadding="0" AutoGenerateColumns="False"
															Width="100%">
															<SelectedItemStyle BackColor="Yellow"></SelectedItemStyle>
															<EditItemStyle BackColor="#FFC0C0"></EditItemStyle>
															<AlternatingItemStyle CssClass="normaltext" VerticalAlign="Middle" BackColor="#FFF2E6"></AlternatingItemStyle>
															<ItemStyle HorizontalAlign="Center" CssClass="normaltext" VerticalAlign="Middle" BackColor="FloralWhite"></ItemStyle>
															<HeaderStyle Font-Size="8pt" Font-Names="Verdana" Font-Bold="True" HorizontalAlign="Center" Height="25px"
																BorderWidth="30px" ForeColor="White" BorderStyle="Solid" BorderColor="Black" CssClass="normalbold"
																VerticalAlign="Middle" BackColor="#CF8E40"></HeaderStyle>
															<Columns>
																<asp:BoundColumn Visible="False" DataField="country_flag_Img_url" HeaderText="Flag"></asp:BoundColumn>
																<asp:BoundColumn Visible="False" DataField="company_Logo_Url" HeaderText="Logo"></asp:BoundColumn>
																<asp:BoundColumn Visible="False" DataField="Trading_Id" HeaderText="Trader"></asp:BoundColumn>
																<asp:BoundColumn Visible="False" DataField="Member_ID" HeaderText="Member"></asp:BoundColumn>
																<asp:TemplateColumn HeaderText="Flag">
																	<ItemTemplate>
																		<asp:Image id=ImgFlag runat="server" Width="18px" ImageUrl='<%# DataBinder.Eval(Container, "DataItem.country_flag_Img_url") %>' Height="12px">
																		</asp:Image>
																	</ItemTemplate>
																</asp:TemplateColumn>
																<asp:TemplateColumn HeaderText="Logo">
																	<ItemTemplate>
																		<asp:ImageButton id=ImgLogo runat="server" Width="120px" ImageUrl='<%# "~/images/logo/" &amp; DataBinder.Eval(Container, "DataItem.company_Logo_Url") %>' BorderColor="Gainsboro" BorderWidth="1px" Height="60px" ImageAlign="Middle" CausesValidation="False">
																		</asp:ImageButton>
																	</ItemTemplate>
																</asp:TemplateColumn>
																<asp:TemplateColumn HeaderText="Deal">
																	<ItemTemplate>
																		<asp:Image id=ImgBugSell runat="server" ImageUrl='<%# "~/images/" &amp; DataBinder.Eval(Container, "DataItem.BUYSELL") &amp; ".gif" %>' ImageAlign="Middle">
																		</asp:Image>
																	</ItemTemplate>
																</asp:TemplateColumn>
																<asp:BoundColumn DataField="MODELNo" HeaderText="Prod.Type"></asp:BoundColumn>
																<asp:BoundColumn DataField="Brand" HeaderText="Brand"></asp:BoundColumn>
																<asp:BoundColumn DataField="Quantity" HeaderText="Quantity"></asp:BoundColumn>
																<asp:BoundColumn Visible="False" DataField="Price" HeaderText="Price"></asp:BoundColumn>
																<asp:BoundColumn DataField="Spec" HeaderText="Specifications"></asp:BoundColumn>
																<asp:BoundColumn Visible="False" DataField="Trade_Type" HeaderText="Trade Type"></asp:BoundColumn>
																<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" CancelText="" EditText="[Edit]"></asp:EditCommandColumn>
																<asp:ButtonColumn Text="[Delete]" CommandName="Delete"></asp:ButtonColumn>
															</Columns>
														</asp:datagrid></TD>
												</TR>
												<TR>
													<TD style="FONT-FAMILY: Verdana" align="center" bgColor="#fff4e7" height="21"><asp:imagebutton id="ibtnPosttoTF" runat="server" Visible="False" ImageUrl="../images/btn_admin_postDone.jpg"
															CausesValidation="False" CommandName="PostDirect"></asp:imagebutton></TD>
												</TR>
												<TR>
													<TD class="normaltext" style="FONT-FAMILY: Verdana" align="center" bgColor="#fff4e7"
														height="5"></TD>
												</TR>
											</TABLE>
										</DIV>
										<TABLE cellSpacing="0" cellPadding="0">
											<TR>
												<TD><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></TD>
											</TR>
										</TABLE>
										<TABLE id="TblPostOffer" style="BORDER-RIGHT: #ffbf55 1px solid; BORDER-TOP: #ffbf55 1px solid; BORDER-LEFT: #ffbf55 1px solid; BORDER-BOTTOM: #ffbf55 1px solid"
											cellSpacing="1" width="98%" align="center" bgColor="#fff4e7" border="0" runat="server">
											<TR>
												<TD class="boxhdn" style="HEIGHT: 21px" bgColor="#cf8e40">&nbsp;Post 
													Offer&nbsp;&nbsp;&nbsp;</TD>
											</TR>
											<TR style="BACKGROUND-COLOR: #fff4e7">
												<TD><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></TD>
											</TR>
											<TR style="BACKGROUND-COLOR: #fff4e7">
												<TD>
													<DIV align="center">
														<TABLE class="MainTable" id="TblPostingType" cellSpacing="0" cellPadding="0" width="98%"
															bgColor="#fff4e7" runat="server">
															<TR>
																<TD valignS="middle"><SPAN style="VERTICAL-ALIGN: middle">
																		<TABLE class="MainTable" id="Table4" cellSpacing="0" cellPadding="0" width="100%">
																			<TR>
																				<TD>
																					<TABLE id="Table8" cellSpacing="0" cellPadding="0">
																						<TR>
																							<TD class="titleTd" style="FONT-WEIGHT: bold; FONT-SIZE: 10pt; COLOR: #b34700; FONT-FAMILY: verdana"
																								vAlign="middle" width="94">&nbsp;&nbsp;I want to:&nbsp;&nbsp;</TD>
																							<TD width="58"><asp:radiobutton id="rdoBuy" runat="server" EnableViewState="False" GroupName="GrpRadio" Text="BUY"
																									AutoPostBack="True" CssClass="normaltext"></asp:radiobutton></TD>
																							<TD class="titleTd" width="9">&nbsp;&nbsp;</TD>
																							<TD width="58"><asp:radiobutton id="rdoSell" runat="server" EnableViewState="False" GroupName="GrpRadio" Text="SELL"
																									AutoPostBack="True" CssClass="normaltext"></asp:radiobutton></TD>
																							<TD width="8"></TD>
																							<TD width="348"><asp:radiobutton id="rdoPostComment" runat="server" EnableViewState="False" GroupName="GrpRadio"
																									Text="Make an Announcement" AutoPostBack="True" CssClass="normaltext"></asp:radiobutton></TD>
																						</TR>
																						<TR>
																							<TD class="titleTd" style="FONT-WEIGHT: bold; FONT-SIZE: 10pt; COLOR: #b34700; FONT-FAMILY: verdana"
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
																<TD bgColor="#fff4e7" height="5"></TD>
															</TR>
														</TABLE>
														</SPAN></DIV>
												</TD>
											</TR>
										</TABLE>
										<table id="TblDetails" cellSpacing="0" cellPadding="0" width="600" align="center" border="0"
											runat="server">
											<TR>
												<TD><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></TD>
											</TR>
											<tr>
												<td>
													<TABLE id="TblPhoneModel" style="BORDER-RIGHT: #ffbf55 1px solid; BORDER-TOP: #ffbf55 1px solid; BORDER-LEFT: #ffbf55 1px solid; BORDER-BOTTOM: #ffbf55 1px solid"
														cellSpacing="0" cellPadding="0" width="100%" align="center">
														<TR vAlign="top" height="27">
															<TD style="BACKGROUND-IMAGE: url(../images/postform_bar_bg.gif); VERTICAL-ALIGN: middle; BORDER-BOTTOM: #ffbf55 1px solid; BACKGROUND-REPEAT: repeat-x">
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
														<TR style="BACKGROUND-COLOR: #fff9f0">
															<TD style="FONT-WEIGHT: bold; FONT-SIZE: 11px; COLOR: #b34700; FONT-FAMILY: verdana"
																height="20">
																<TABLE id="table31" style="WIDTH: 475px" width="475" runat="server">
																	<TR id="trOther1">
																		<TD style="FONT-WEIGHT: bold; FONT-SIZE: 11px; WIDTH: 62px; COLOR: #b34700; FONT-FAMILY: verdana; HEIGHT: 12px"
																			width="62" height="12">Product:</TD>
																		<TD class="titleTd" style="WIDTH: 115px; HEIGHT: 12px" vAlign="middle" width="115">
																			<P align="left"><asp:dropdownlist id="ddlModel" runat="server" Width="152px" CssClass="box" Font-Bold="True" BackColor="#fff4e7"></asp:dropdownlist></P>
																		</TD>
																		<TD style="FONT-WEIGHT: bold; FONT-SIZE: 11px; WIDTH: 51px; COLOR: #b34700; FONT-FAMILY: verdana; HEIGHT: 12px"
																			width="51">
																			<P align="left"><SPAN class="titleTd">If other </SPAN>
																			</P>
																		</TD>
																		<TD class="titleTd" style="FONT-WEIGHT: bold; FONT-SIZE: 11px; WIDTH: 65px; COLOR: #b34700; FONT-FAMILY: verdana; HEIGHT: 12px"
																			noWrap width="65" colSpan="2"><SPAN class="titleTd"><asp:textbox id="txtModelNo" runat="server" EnableViewState="False" CssClass="box" MaxLength="20"></asp:textbox></SPAN><asp:customvalidator id="CVModel" runat="server" Width="278px" EnableViewState="False" CssClass="normaltext"
																				Enabled="False" Display="Dynamic" ControlToValidate="txtModelNo" ErrorMessage="Either select or specify some Product type." EnableClientScript="False" OnServerValidate="CVModel_ServerValidate">Either select or specify some Product type.</asp:customvalidator><asp:label id="lblModelValidator" runat="server" Visible="False" Width="275px" EnableViewState="False"
																				CssClass="normaltext" Font-Size="8pt" ForeColor="Red">Either select or specify some Product type.</asp:label></TD>
																	</TR>
																	<TR id="trOther2">
																		<TD style="FONT-WEIGHT: bold; FONT-SIZE: 11px; WIDTH: 62px; COLOR: #b34700; FONT-FAMILY: verdana"
																			width="62">Brand:</TD>
																		<TD class="titleTd" style="WIDTH: 115px" vAlign="middle" width="115"><SPAN class="titleTd"><asp:dropdownlist id="ddlBrand" runat="server" Width="153px" CssClass="box" Font-Bold="true" BackColor="#fff4e7"></asp:dropdownlist></SPAN></TD>
																		<TD style="FONT-WEIGHT: bold; FONT-SIZE: 11px; WIDTH: 51px; COLOR: #b34700; FONT-FAMILY: verdana"
																			width="51">
																			<P align="left"><SPAN class="titleTd">If other</SPAN>
																			</P>
																		</TD>
																		<TD class="titleTd" style="FONT-WEIGHT: bold; FONT-SIZE: 11px; WIDTH: 65px; COLOR: #b34700; FONT-FAMILY: verdana"
																			noWrap width="65" colSpan="2"><asp:textbox id="txtManufName" runat="server" EnableViewState="False" CssClass="box" MaxLength="20"></asp:textbox><asp:customvalidator id="CvManuf" runat="server" Width="278px" EnableViewState="False" CssClass="normaltext"
																				Enabled="False" Display="Dynamic" ControlToValidate="txtModelNo" ErrorMessage="Either select or specify some Brand." EnableClientScript="False" OnServerValidate="CVModel_ServerValidate">Either select or specify some Brand.</asp:customvalidator><asp:label id="lblManufValidator" runat="server" Visible="False" Width="275px" EnableViewState="False"
																				CssClass="normaltext" Font-Size="8pt" ForeColor="Red">Either select or specify some Brand.</asp:label></TD>
																	</TR>
																</TABLE>
															</TD>
														</TR>
														<TR id="Search_TR" style="HEIGHT: 5px; BACKGROUND-COLOR: #fff4e7">
															<TD colSpan="5"><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></TD>
														</TR>
													</TABLE>
												</td>
											</tr>
											<TR>
												<TD><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></TD>
											</TR>
											<tr>
												<td>
													<TABLE class="MainTable" id="TblStockSpecs" style="BORDER-RIGHT: #ffbf55 1px solid; BORDER-TOP: #ffbf55 1px solid; BORDER-LEFT: #ffbf55 1px solid; BORDER-BOTTOM: #ffbf55 1px solid"
														cellSpacing="0" cellPadding="0" width="100%" bgColor="white" runat="server">
														<TR vAlign="top" height="27">
															<TD style="BACKGROUND-IMAGE: url(../images/postform_bar_bg.gif); VERTICAL-ALIGN: middle; BORDER-BOTTOM: #ffbf55 1px solid; BACKGROUND-REPEAT: repeat-x; HEIGHT: 34px"
																colSpan="5">
																<TABLE id="table35" style="WIDTH: 158px; HEIGHT: 28px" cellSpacing="0" cellPadding="0"
																	width="158" border="0"> <!-- DESIGNTIMEDRAGDROP="6394">-->
																	<TR>
																		<TD>&nbsp;<IMG height="26" src="../images/postform_b.gif" width="26" align="middle" border="0">&nbsp;
																		</TD>
																		<TD class="titleTd" vAlign="middle"><B><FONT face="Verdana" color="#fea300" size="1">Stock 
																					Specification</FONT></B></TD>
																	</TR>
																</TABLE>
															</TD>
														</TR>
														<TR style="HEIGHT: 5px; BACKGROUND-COLOR: #fff4e7">
															<TD colSpan="5"><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></TD>
														</TR>
														<TR style="HEIGHT: 20px; BACKGROUND-COLOR: #fff9f0">
															<TD class="titleTd" vAlign="middle" width="18%"><B><FONT face="Verdana" color="#b34700" size="1">&nbsp;Quantity:&nbsp;
																	</FONT></B>
															</TD>
															<TD width="31%"><asp:textbox id="txtQuantity" runat="server" Width="85px" CssClass="box" MaxLength="15"></asp:textbox><asp:rangevalidator id="RVQty" runat="server" Visible="False" CssClass="error" Enabled="False" Display="Dynamic"
																	ControlToValidate="txtQuantity" ErrorMessage="Invalid Quantity" MinimumValue="1" MaximumValue="9999999" Type="Integer"></asp:rangevalidator><asp:requiredfieldvalidator id="RFVQuantity" runat="server" CssClass="error" Display="Dynamic" ControlToValidate="txtQuantity"
																	ErrorMessage="Quantity Can not be blank"></asp:requiredfieldvalidator></TD>
															<TD width="2%">&nbsp;</TD>
															<TD class="titleTd" vAlign="middle" width="12%"><B><FONT face="Verdana" color="#b34700" size="1">Price:&nbsp;
																	</FONT></B>
															</TD>
															<TD vAlign="middle" width="37%"><asp:dropdownlist id="ddlCurrency" runat="server" CssClass="box"></asp:dropdownlist>&nbsp;
																<asp:textbox id="txtPrice" runat="server" Width="48px" CssClass="box" MaxLength="4">0</asp:textbox><BR>
																<asp:hyperlink id="hlnkCurrencyConverter" runat="server" CssClass="footer" ForeColor="Blue" NavigateUrl=""
																	Target="_blank" Font-Underline="True">Currency Converter</asp:hyperlink><BR>
																<asp:rangevalidator id="RVPrice" runat="server" CssClass="error" Display="Dynamic" ControlToValidate="txtPrice"
																	ErrorMessage="Invalid Price" MinimumValue="0" MaximumValue="9999999" Type="Currency"></asp:rangevalidator><asp:requiredfieldvalidator id="RFVPrice" runat="server" Visible="False" CssClass="error" Display="Dynamic"
																	ControlToValidate="txtPrice" ErrorMessage="Price Can not be blank. "></asp:requiredfieldvalidator></TD>
														</TR>
														<TR id="Tr1" style="DISPLAY: block; HEIGHT: 30px; BACKGROUND-COLOR: #fff4e7">
															<TD class="titleTd" width="18%"><B><FONT style="BACKGROUND-COLOR: #fff4e7" face="Verdana" color="#b34700" size="1">&nbsp;Specification:</FONT></B></TD>
															<TD width="31%"><!-- <asp:ListItem Value="0">Select...</asp:ListItem>--><asp:textbox id="txtSpecs" runat="server" Width="85px" CssClass="box" MaxLength="15"></asp:textbox><asp:requiredfieldvalidator id="Requiredfieldvalidator5" runat="server" CssClass="error" Display="Dynamic" ControlToValidate="txtSpecs"
																	ErrorMessage="Spcification can not be empty."></asp:requiredfieldvalidator></TD>
															<TD width="2%">&nbsp;</TD>
															<TD class="titleTd" width="12%"><B><FONT face="Verdana" color="#b34700" size="1">Warranty:</FONT></B></TD>
															<TD width="37%"><!--<asp:ListItem Value="1">Euro Specs.</asp:ListItem>--><asp:textbox id="txtWarranty" runat="server" Width="85px" CssClass="box" MaxLength="15"></asp:textbox> <!-- <asp:ListItem Value="0">Select..</asp:ListItem>--></TD>
														</TR>
														<TR id="OnlyPhones" style="DISPLAY: block; HEIGHT: 20px; BACKGROUND-COLOR: #fff9f0">
															<TD class="titleTd" width="18%"><B><FONT face="Verdana" color="#b34700" size="1"><B><FONT face="Verdana" color="#b34700" size="1">&nbsp;Packaging</FONT></B>:</FONT></B></TD>
															<TD width="31%"><asp:textbox id="txtPackaging" runat="server" Width="85px" CssClass="box" MaxLength="15"></asp:textbox><!--<asp:ListItem Value="0">Select..</asp:ListItem>--></TD>
															<TD width="2%">&nbsp;</TD>
															<TD class="titleTd" width="12%"><B><FONT face="Verdana" color="#b34700" size="1"></FONT></B></TD>
															<TD width="37%">&nbsp;
																<asp:textbox id="txtDate" runat="server" Visible="False" Width="25px" CssClass="box" MaxLength="10"
																	Enabled="False"></asp:textbox></TD>
														</TR>
													</TABLE>
												</td>
											</tr>
											<TR>
												<TD><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></TD>
											</TR>
											<tr>
												<td id="TD_ShippingDetails" runat="server"><asp:panel id="pnlShippingDetails" runat="server" Visible="False" EnableViewState="False">
														<TABLE class="MainTable" id="TblShippingDetails" style="BORDER-RIGHT: #ffbf55 1px solid; BORDER-TOP: #ffbf55 1px solid; BORDER-LEFT: #ffbf55 1px solid; BORDER-BOTTOM: #ffbf55 1px solid"
															cellSpacing="0" cellPadding="0" width="100%" bgColor="#fff9f0" runat="server">
															<TR vAlign="top" height="27">
																<TD style="BACKGROUND-IMAGE: url(../images/postform_bar_bg.gif); VERTICAL-ALIGN: middle; BORDER-BOTTOM: #ffbf55 1px solid; BACKGROUND-REPEAT: repeat-x"
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
															<TR style="HEIGHT: 5px; BACKGROUND-COLOR: #fff9f0">
																<TD colSpan="5"></TD>
															</TR>
															<TR style="HEIGHT: 20px; BACKGROUND-COLOR: #fff9f0">
																<TD class="titleTd" vAlign="middle" width="106"><B><FONT face="Verdana" color="#b34700" size="1">&nbsp;&nbsp;Shipping 
																			Terms:&nbsp; </FONT></B>
																</TD>
																<TD vAlign="middle" width="186">
																	<asp:dropdownlist id="ddlShippingTerms" runat="server" CssClass="box" EnableViewState="False">
																		<asp:ListItem Value="0" Selected="True">Select..</asp:ListItem>
																		<asp:ListItem Value="1">C&amp;F</asp:ListItem>
																		<asp:ListItem Value="2">CIF</asp:ListItem>
																		<asp:ListItem Value="5">EX Works</asp:ListItem>
																		<asp:ListItem Value="14">FOB</asp:ListItem>
																	</asp:dropdownlist></TD>
																<TD width="11">&nbsp;</TD>
																<TD class="titleTd" vAlign="middle" width="74"><B><FONT face="Verdana" color="#b34700" size="1">Country:&nbsp;
																		</FONT></B>
																</TD>
																<TD vAlign="middle" width="221">
																	<asp:dropdownlist id="ddlCountry" runat="server" CssClass="box" EnableViewState="False"></asp:dropdownlist>&nbsp;
																	<asp:requiredfieldvalidator id="Requiredfieldvalidator1" runat="server" ErrorMessage="Country Can not be blank"
																		ControlToValidate="ddlCountry" Font-Size="1px"></asp:requiredfieldvalidator></TD>
															</TR>
															<TR style="HEIGHT: 20px; BACKGROUND-COLOR: #fff9f0">
																<TD class="titleTd" width="106"><B><FONT face="Verdana" color="#b34700" size="1">&nbsp;&nbsp;Stock 
																			Location:</FONT></B></TD>
																<TD width="186">
																	<asp:dropdownlist id="ddlStockLocation" runat="server" CssClass="box" EnableViewState="False">
																		<asp:ListItem Value="0" Selected="True">Select..</asp:ListItem>
																		<asp:ListItem Value="1">Freight Forwarder</asp:ListItem>
																		<asp:ListItem Value="2">Own Warehouse</asp:ListItem>
																		<asp:ListItem Value="4">Other</asp:ListItem>
																		<asp:ListItem Value="5">Pauls Freight UK</asp:ListItem>
																		<asp:ListItem Value="6">Hawks UK</asp:ListItem>
																		<asp:ListItem Value="7">Interken UK</asp:ListItem>
																		<asp:ListItem Value="8">AFI UK</asp:ListItem>
																		<asp:ListItem Value="9">WWL Netherlands</asp:ListItem>
																	</asp:dropdownlist></TD>
																<TD width="11">&nbsp;</TD>
																<TD class="titleTd"><B><FONT face="Verdana" color="#b34700" size="1">If Other:</FONT></B></TD>
																<TD width="221">
																	<asp:textbox id="txtLocation" runat="server" CssClass="box" EnableViewState="False" MaxLength="100"></asp:textbox></TD>
															</TR>
															<TR style="HEIGHT: 5px; BACKGROUND-COLOR: #fff9f0">
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
				<TABLE id="tbl_Comment" style="BORDER-RIGHT: #ffbf55 1px solid; BORDER-TOP: #ffbf55 1px solid; BORDER-LEFT: #ffbf55 1px solid; BORDER-BOTTOM: #ffbf55 1px solid"
					cellSpacing="0" cellPadding="0" width="600" align="center" bgColor="#fff4e7" border="0"
					runat="server">
					<TR>
						<TD vAlign="top" align="center">
							<TABLE class="MainTable" id="Table19" cellSpacing="0" cellPadding="0" width="100%" bgColor="white">
								<TR vAlign="top" height="27">
									<TD style="BACKGROUND-IMAGE: url(../images/postform_bar_bg.gif); VERTICAL-ALIGN: middle; BORDER-BOTTOM: #ffbf55 1px solid; BACKGROUND-REPEAT: repeat-x"
										colSpan="5">
										<TABLE id="Table21" cellSpacing="0" cellPadding="0" width="199" border="0">
											<TR>
												<TD width="40">&nbsp;
													<asp:image id="ImgD" runat="server" ImageUrl="../images/postform_c.gif" EnableViewState="False"></asp:image>&nbsp;
												</TD>
												<TD class="titleTd" vAlign="middle" width="159"><B><FONT face="Verdana" color="#fea300" size="1"><asp:label id="lblTypeComments" runat="server" EnableViewState="False">Add your Comments</asp:label></FONT></B></TD>
											</TR>
										</TABLE>
									</TD>
								</TR>
								<TR style="HEIGHT: 5px; BACKGROUND-COLOR: #fff4e7">
									<TD colSpan="5"><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></TD>
								</TR>
								<TR style="HEIGHT: 30px; BACKGROUND-COLOR: #fff4e7">
									<TD class="titleTd" width="18%"><B><FONT face="Verdana" color="#b34700" size="1">&nbsp;&nbsp;
												<asp:label id="lblAnnouncement" runat="server" EnableViewState="False">Comment:</asp:label>&nbsp;
											</FONT></B>
									</TD>
									<TD colSpan="3"><asp:textbox id="txtComment" runat="server" Width="300px" CssClass="box" MaxLength="1000" TextMode="MultiLine"
											Height="50px"></asp:textbox></TD>
									<td align="left" width="31%">
										<script>
												displaylimit("","TradeMainCtrl__ctl6_txtComment",1000)
										</script>
									</td>
								</TR>
								<TR style="HEIGHT: 5px; BACKGROUND-COLOR: #fff4e7">
									<TD colSpan="5"><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
				</TABLE>
			</TD>
		</TR>
		<TR>
			<TD style="HEIGHT: 20px" align="left" colSpan="2">&nbsp;<asp:checkbox id="chkGrouping" runat="server" EnableViewState="False" Text="I want to POST more ITEMS"
					CssClass="normaltext"></asp:checkbox>
			</TD>
		</TR>
		<TR>
			<TD align="left" width="81%"><asp:imagebutton id="btnShowSummary" runat="server" Visible="False" ImageUrl="../images/btn_admin_ViewPost.jpg"
					CommandName="ShowSummary"></asp:imagebutton>&nbsp;
				<asp:imagebutton id="btnPostTF" runat="server" ImageUrl="../images/btn_Post_request.jpg" CommandName="PostDirect"
					EnableViewState="False"></asp:imagebutton>&nbsp;
				<asp:imagebutton id="IbtnUpdatePosting" runat="server" ImageUrl="../images/btn_Post_update.jpg" CausesValidation="false"
					CommandName="HideSummary"></asp:imagebutton></TD>
			<TD align="left" width="19%"><asp:imagebutton id="ImgbtnCancel" runat="server" ImageUrl="../images/btn_Cancel_request.jpg" CausesValidation="False"></asp:imagebutton></TD>
		</TR>
		<TR>
			<TD align="left">&nbsp;</TD>
			<TD align="left">&nbsp;</TD>
		</TR>
	</TABLE>
	</TD></TR></TABLE></TD></TR><TR>
		<TD id="TDSummaryView" runat="server">
			<TABLE id="tblSummary" cellSpacing="1" cellPadding="1" width="100%" border="0">
				<TR>
					<TD>
						<TABLE class="normaltext" id="Table_Detail" cellSpacing="1" cellPadding="1" width="100%"
							border="0" runat="server">
							<TR>
								<TD style="BORDER-RIGHT: #ffeaaa 1px solid; BORDER-TOP: #ffeaaa 1px solid; BORDER-LEFT: #ffeaaa 1px solid; BORDER-BOTTOM: #ffeaaa 1px solid"
									background="file:///C|/Documents and Settings/Nabeel/My Documents/images/bg_centre.gif"
									colSpan="3" height="25"><STRONG>Confirm Your Post</STRONG>&nbsp;from the ID :
									<asp:label id="lblMemberId" runat="server" CssClass="normaltext" Font-Bold="True" BackColor="Transparent">MemberID</asp:label>, 
									Dated:&nbsp;&nbsp; <IMG alt="UAE Time" src="file:///C|/Documents and Settings/Nabeel/My Documents/My Received Files/images/icon_clock.gif"
										align="middle">&nbsp;
									<asp:label id="lblRequestedFrom" runat="server" CssClass="normaltext" BackColor="Transparent">RequestedFrom</asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 30px"></TD>
								<TD style="WIDTH: 9px"></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 30px; HEIGHT: 20px">Trade Type</TD>
								<TD style="WIDTH: 9px; HEIGHT: 20px">:</TD>
								<TD style="HEIGHT: 20px"><asp:label id="lblTradeType" runat="server" CssClass="normaltext">TradeType</asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 74px; HEIGHT: 20px">Brand - Model</TD>
								<TD style="WIDTH: 9px; HEIGHT: 20px">:</TD>
								<TD style="HEIGHT: 20px"><asp:label id="lblBrand" runat="server" CssClass="normaltext">Brand</asp:label>&nbsp;-
									<asp:label id="lblModel" runat="server" CssClass="normaltext">Model</asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 74px">Status</TD>
								<TD style="WIDTH: 9px">:</TD>
								<TD><asp:label id="lblStatus" runat="server" CssClass="normaltext">Status</asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 74px">Specification</TD>
								<TD style="WIDTH: 9px">:</TD>
								<TD><asp:label id="lblSpec" runat="server" CssClass="normaltext">Spec</asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 74px">Quantity</TD>
								<TD style="WIDTH: 9px">:</TD>
								<TD><asp:label id="lblQuantity" runat="server" CssClass="normaltext">Quantity</asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 74px">Price</TD>
								<TD style="WIDTH: 9px">:</TD>
								<TD><asp:label id="lblPrice" runat="server" CssClass="normaltext">Price</asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 74px; HEIGHT: 21px">Warranty</TD>
								<TD style="WIDTH: 9px; HEIGHT: 21px">:</TD>
								<TD style="HEIGHT: 21px"><asp:label id="lblWarranty" runat="server" CssClass="normaltext">Warranty</asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 74px">Packaging</TD>
								<TD style="WIDTH: 9px">:</TD>
								<TD><asp:label id="lblPackage" runat="server" CssClass="normaltext">Package</asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 74px; HEIGHT: 21px">&nbsp;</TD>
								<TD style="WIDTH: 9px; HEIGHT: 21px">&nbsp;</TD>
								<TD style="HEIGHT: 21px">&nbsp;</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 74px; HEIGHT: 21px">Shipping Terms</TD>
								<TD style="WIDTH: 9px; HEIGHT: 21px">:</TD>
								<TD style="HEIGHT: 21px"><asp:label id="lblShippingTerms" runat="server" CssClass="normaltext">ShippingTerms</asp:label>&nbsp;,&nbsp;
									<asp:label id="lblCountry" runat="server" CssClass="normaltext">Country</asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 74px; HEIGHT: 21px">Stock Location</TD>
								<TD style="WIDTH: 9px; HEIGHT: 21px">:</TD>
								<TD style="HEIGHT: 21px"><asp:label id="lblStockLocation" runat="server" CssClass="normaltext">StockLocation</asp:label>&nbsp;,
									<asp:label id="lblLocation" runat="server" CssClass="normaltext">Location</asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 74px"></TD>
								<TD style="WIDTH: 9px"></TD>
								<TD><A href='mailto:<%# DataBinder.Eval(Container, "DataItem.company_email") %>?subject=Enquiry from Phonetrade.cc - Trading Floor!' ></A></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 74px">Comments</TD>
								<TD style="WIDTH: 9px">:</TD>
								<TD><asp:label id="lblComment" runat="server" CssClass="normaltext">Comment</asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 74px">&nbsp;</TD>
								<TD style="WIDTH: 9px">&nbsp;</TD>
								<TD>&nbsp;</TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD>&nbsp;
						<asp:imagebutton id="btnHideSummary" runat="server" ImageUrl="../images/btn_admin_EditPosting.jpg"
							CausesValidation="false" CommandName="HideSummary"></asp:imagebutton>&nbsp;&nbsp;
						<asp:imagebutton id="ImgbtnAdd" runat="server" ImageUrl="../images/btn_Post_request.jpg" CommandName="PostIndirect"></asp:imagebutton></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD></TD>
	</TR>
	</TABLE></div>
<!--<TR>
		<TD style="WIDTH: 25px"></TD>
		<TD style="WIDTH: 120px">Provider Logo:</TD>
		<TD style="WIDTH: 731px"><asp:dropdownlist id="ddlProviderLogo" runat="server" CssClass="box">
				<asp:ListItem Value="0" Selected="True">Yes</asp:ListItem>
				<asp:ListItem Value="1">No</asp:ListItem>
			</asp:dropdownlist></TD>
		<TD style="WIDTH: 329px"></TD>
		<TD></TD>
	</TR>-->
