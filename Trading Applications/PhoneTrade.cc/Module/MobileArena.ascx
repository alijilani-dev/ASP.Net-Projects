<%@ Register TagPrefix="uc1" TagName="MobileDetail" Src="MobileDetail.ascx" %>
<%@ Control Language="vb" AutoEventWireup="false" Codebehind="MobileArena.ascx.vb" Inherits="Trade.MobileArena" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
		<td vAlign="top">
		<table border="0" width="100%" id="table13" cellspacing="1">
			<tr>
				<td><TABLE id="table53" style="BORDER-RIGHT: #3f8bd7 1px solid; BORDER-TOP: #3f8bd7 1px solid; BORDER-LEFT: #3f8bd7 1px solid; BORDER-BOTTOM: #3f8bd7 1px solid; BACKGROUND-REPEAT: repeat-x"
								cellSpacing="0" cellPadding="0" width="176" background="../images/bg_cell.gif" border="0">
								<TR>
									<TD width="3" rowSpan="4"></TD>
									<TD width="168" colSpan="3" height="3"></TD>
									<TD width="3" rowSpan="4"></TD>
								</TR>
								<TR>
									<TD class="boxhdn" bgColor="#3f8bd7" colSpan="3" height="19">&nbsp;Top 
									Trading Phones</TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 36px" width="1" rowSpan="2"></TD>
									<TD style="HEIGHT: 36px" vAlign="top" width="160" rowSpan="2"><IFRAME name="I4" align="middle" src="ScrollerPage\Offer.aspx" frameBorder="0" width="166"
											scrolling="no" height="90"></IFRAME>
									</TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 40px" width="1"></TD>
								</TR>
							</TABLE></td>
			</tr>
			<tr>
					<TD align="center" height="4"></TD>
				</tr>
			<tr>
				<td align=center><asp:datalist id="ddlLeftMobileMenu" runat="server" RepeatColumns="1">
				<ItemTemplate>
					<TABLE class="normaltext" id="Table4" style="BORDER-RIGHT: #cccccc 1px solid; BORDER-TOP: #cccccc 1px solid; BORDER-LEFT: #cccccc 1px solid; WIDTH: 176px; BORDER-BOTTOM: #cccccc 1px solid; HEIGHT: 45px"
						borderColor="#000000" cellSpacing="0" cellPadding="0" width="176" border="0">
						<TR>
							<TD align="center">
								<asp:ImageButton id=imgLeftMobiles runat="server" ImageUrl='<%# "~/Images/Models/" &amp; DataBinder.Eval(Container, "DataItem.LoGo") %>'>
								</asp:ImageButton>
								<asp:Label id=lblLeftMenuBrand runat="server" Visible="false" text='<%# DataBinder.Eval(Container, "DataItem.ManufCode") %>'>
								</asp:Label>
								<asp:Label id=lblLeftManufName runat="server" Visible="false" text='<%# DataBinder.Eval(Container, "DataItem.ManufName") %>'>
								</asp:Label></TD>
						</TR>
					</TABLE>
				</ItemTemplate>
			</asp:datalist></td>
			</tr>
		</table>
		</td>
		<td vAlign="top" align="center" width="100%">
			<TABLE id="Table8" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD align="center"><IFRAME style="WIDTH: 470px; HEIGHT: 60px" name="IfAdv" align="middle" src="HTMLPages/Ad_MobileReviews.htm"
							frameBorder="0" scrolling="no"></IFRAME>
					</TD>
				</TR>
			</TABLE>
			<br>
			<div align="center">
				<TABLE class="normaltext" id="Table1" cellSpacing="1" border="0">
					<TR>
						<TD><asp:imagebutton id="ImgReview" DESIGNTIMEDRAGDROP="501" runat="server" ImageUrl="../images/indeximage.JPG"></asp:imagebutton></TD>
						<TD><asp:imagebutton id="ImgCatalogue" DESIGNTIMEDRAGDROP="340" runat="server" ImageUrl="../images/indeximage1.JPG"></asp:imagebutton></TD>
						<TD><asp:imagebutton id="ImgSecrets" runat="server" ImageUrl="../images/indeximage2.JPG"></asp:imagebutton></TD>
					</TR>
				</TABLE>
			</div>
			<TABLE class="normaltext" id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD id="TDReview" style="HEIGHT: 187px" align="center" runat="server">
						<TABLE id="tblMain" cellSpacing="1" width="650">
							<TR>
								<TD style="BORDER-RIGHT: #a5d1fe 1px solid; BORDER-TOP: #a5d1fe 1px solid; BORDER-LEFT: #a5d1fe 1px solid; BORDER-BOTTOM: #a5d1fe 1px solid"
									align="center"><asp:DataList ID="DLReview" runat="server" RepeatColumns="2">
                                  <itemtemplate>
                                    <table class="normaltext" id="Table3" cellspacing="1" cellpadding="1" width="100%" border="0">
                                      <tr>
                                        <td colspan="2"></td>
                                      </tr>
                                      <tr>
                                        <td align="center" width="75"><asp:HyperLink ID=ImgSmall runat="server" ImageUrl='<%# "../Images/Models/" &amp; DataBinder.Eval(Container, "DataItem.ImgFile2") %>' Target="_parent" NavigateUrl='<%# "../PortalDefault.aspx?Main_Links_ID=5&amp;MobileSrNo=" &amp; DataBinder.Eval(Container, "DataItem.SrNo") %>' BorderColor="#EEEEEE" BorderWidth="1"> </asp:HyperLink></td>
                                        <td width="250"><b>
                                          <asp:Label ID=lblModelNo runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ManufName") &amp; " - " &amp; DataBinder.Eval(Container, "DataItem.ModelNo") %>'> </asp:Label>
                                          </b>&nbsp;
                                          <asp:Label ID=lblRVMobileSrNo runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.SrNo") %>'>Label</asp:Label>
                                          <br />
                                          <asp:Literal ID=ltReview runat="server" Text='<%# mid(DataBinder.Eval(Container, "DataItem.Descriptions"),1,50) %>'> </asp:Literal>
                                          <asp:HyperLink ID=lnkBut runat="server" Target="_parent" NavigateUrl='<%# "../PortalDefault.aspx?Main_Links_ID=5&amp;MobileSrNo=" &amp; DataBinder.Eval(Container, "DataItem.SrNo") %>'>More ...</asp:HyperLink>
                                          <br />                                        </td>
                                      </tr>
                                    </table>
                                  </itemtemplate>
							    </asp:DataList></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD id="TDCatalogueBrand" align="center" runat="server">
						<TABLE id="tblMain1" cellSpacing="1" width="520" border="0">
							<TR>
								<TD class="normaltext" style="BORDER-RIGHT: #a5d1fe 1px solid; BORDER-TOP: #a5d1fe 1px solid; BORDER-LEFT: #a5d1fe 1px solid; BORDER-BOTTOM: #a5d1fe 1px solid"
									align="center"><asp:label id="lblSelectedBrandName" runat="server" Visible="False"></asp:label><asp:datalist id="DLCatalogueBrand" runat="server" RepeatColumns="4" RepeatDirection="Horizontal">
										<ItemTemplate>
											<TABLE class="normaltext" id="Table4" borderColor="#000000" cellSpacing="1" cellPadding="1"
												width="82" border="0">
												<TR>
													<TD align="center">
														<asp:Image id="Image1" runat="server" ImageUrl="../images/BrandImageHeader.gif"></asp:Image><BR>
														<asp:ImageButton id=ImageButton3 runat="server" ImageUrl='<%# "~/Images/Models/" &amp; DataBinder.Eval(Container, "DataItem.LoGo") %>'>
														</asp:ImageButton>
														<asp:Label id=lblBrand runat="server" Visible="false" text='<%# DataBinder.Eval(Container, "DataItem.ManufCode") %>'>
														</asp:Label>
														<asp:Label id=lblBrandName runat="server" Visible="false" text='<%# DataBinder.Eval(Container, "DataItem.ManufName") %>'>
														</asp:Label></TD>
												</TR>
												<TR>
												</TR>
											</TABLE>
										</ItemTemplate>
									</asp:datalist></TD>
							</TR>
						</TABLE>
						<BR>
					</TD>
				</TR>
				<TR>
					<TD id="TDCatalogue" align="center" runat="server">
						<TABLE id="Table9" cellSpacing="1" width="600" border="0">
							<TR>
								<TD class="normaltext" style="BORDER-RIGHT: #a5d1fe 1px solid; BORDER-TOP: #a5d1fe 1px solid; BORDER-LEFT: #a5d1fe 1px solid; BORDER-BOTTOM: #a5d1fe 1px solid"
									align="center"><BR>
									<asp:label id="lblSelected" runat="server" Visible="False" CssClass="normalText" Font-Bold="True"
										ForeColor="#0066CC"></asp:label><asp:datalist id="DLCatalogue" runat="server" RepeatColumns="7">
										<ItemTemplate>
											<BR>
											<TABLE class="normaltext" id="Table5" cellSpacing="2" cellPadding="2" width="100%" border="0">
												<TR>
													<TD align="center" colSpan="2"><EM></EM>
														<asp:Label id=Label2 runat="server" Font-Bold="True" ForeColor="#0066CC" Text='<%# DataBinder.Eval(Container, "DataItem.ModelNo") %>'>
														</asp:Label>&nbsp;
														<asp:Label id=lblCTMobileSrNo runat="server" Visible="False" ForeColor="#0066CC" Text='<%# DataBinder.Eval(Container, "DataItem.SrNo") %>'>Label</asp:Label></TD>
												</TR>
												<TR>
													<TD align="center">
														<asp:ImageButton id=ImageButton1 runat="server" ImageUrl='<%# "~/Images/Models/" &amp; DataBinder.Eval(Container, "DataItem.ImgFile2") %>' BorderColor="#EEEEEE" BorderWidth="1" Height="70" Width="70">
														</asp:ImageButton></TD> <!--<TD>
								<asp:Literal id=Literal1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Descriptions") %>'>
								</asp:Literal><BR>
								<asp:LinkButton id="Linkbutton2" runat="server">More ...</asp:LinkButton>
							</TD> --></TR>
											</TABLE>
										</ItemTemplate>
									</asp:datalist></TD>
							</TR>
						</TABLE>
						<BR>
					</TD>
				</TR>
				<TR>
					<TD id="TDSecrets" align="center" runat="server">
						<TABLE id="tblMain4" cellSpacing="1" width="650">
							<TR>
								<TD class="normaltext" style="BORDER-RIGHT: #a5d1fe 1px solid; BORDER-TOP: #a5d1fe 1px solid; BORDER-LEFT: #a5d1fe 1px solid; BORDER-BOTTOM: #a5d1fe 1px solid"
									align="center"><asp:DataList ID="DLSecrets" runat="server" RepeatColumns="2">
                                  <itemtemplate>
                                    <table id="Table12" cellspacing="3" cellpadding="1" width="80%" border="0" class="normaltext">
                                      <tr>
                                        <td colspan="2"><asp:Label ID=Label4 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ModelNo") %>'> </asp:Label>
                                          &nbsp;
                                          <asp:Label ID=lblSRMobileSrNo runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.SrNo") %>'>Label</asp:Label></td>
                                      </tr>
                                      <tr>
                                        <td align="center"><asp:ImageButton ID=ImageButton2 ImageUrl='<%# "../" &amp; DataBinder.Eval(Container, "DataItem.ImgFile2") %>' runat="server"> </asp:ImageButton></td>
                                        <td><asp:Literal ID=Literal2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.MobileSecret") %>'> </asp:Literal>
                                            <br />
                                            <asp:LinkButton ID="Linkbutton4" runat="server">More ...</asp:LinkButton></td>
                                      </tr>
                                    </table>
                                  </itemtemplate>
							    </asp:DataList></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD id="TDMobileDetails" runat="server">
						<TABLE class="normaltext" id="Table6" cellSpacing="1" cellPadding="1" width="100%" border="0">
							<TR>
								<TD><uc1:mobiledetail id="mMobileDetail" runat="server"></uc1:mobiledetail></TD>
								<TD></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</td>
		<td vAlign="top">
			<TABLE id="Table10" cellSpacing="1" width="98%" border="0">
				<TR>
					<TD align="center">
							<iframe name="I1" src="ScrollerPage\latestmobiles.aspx" frameBorder="0" width="176" height="121"
								scrolling="no"></iframe>
						</TD>
				</TR>
				<TR>
					<TD align="center" height="4"></TD>
				</TR>
				<TR>
					<TD align="center">
						<asp:HyperLink id="hprLink1" runat="server" BorderWidth="1" BorderColor="#CCCCCC" ImageUrl="~\Images\Models\lg.gif" Width="176" Height="60" NavigateUrl="http://www.lge.com"
							Target="_blank"></asp:HyperLink></TD>
				</TR>
				<TR>
				  <TD align="center">
						<asp:HyperLink id="hprLink2" runat="server" BorderWidth="1" BorderColor="#CCCCCC" ImageUrl="~\Images\Models\motorola.gif" Width="176" Height="60" NavigateUrl="http://www.motorola.com"
							Target="_blank"></asp:HyperLink></TD>
				</TR>
				<TR>
					<TD align="center">
						<asp:HyperLink id="hprLink3" runat="server"  BorderWidth="1" BorderColor="#CCCCCC"  ImageUrl="~\Images\Models\nokia.gif" Width="176" Height="60" NavigateUrl="http://www.nokia.com"
							Target="_blank"></asp:HyperLink></TD>
				</TR>
				<TR>
					<TD align="center">
						<asp:HyperLink id="Hyperlink1" runat="server"  BorderWidth="1" BorderColor="#CCCCCC"  ImageUrl="~\Images\Models\siemens.gif" Width="176" Height="60" NavigateUrl="http://www.siemens.com"
							Target="_blank"></asp:HyperLink></TD>
				</TR>
				<TR>
				  <TD align="center">
						<asp:HyperLink id="Hyperlink2"  BorderWidth="1" BorderColor="#CCCCCC"  runat="server" ImageUrl="~\Images\Models\samsung.gif" Width="176" Height="60" NavigateUrl="http://www.samsung.com"
							Target="_blank"></asp:HyperLink></TD>
				</TR>
				<TR>
					<TD align="center">
						<asp:HyperLink id="Hyperlink3"  BorderWidth="1" BorderColor="#CCCCCC" runat="server" ImageUrl="~\Images\Models\se.gif" Width="176" Height="60" NavigateUrl="http://www.sonyericsson.com/"
							Target="_blank"></asp:HyperLink></TD>
				</TR>
		  </TABLE>
		</td>
	</tr>
</table>