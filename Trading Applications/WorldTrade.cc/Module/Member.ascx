<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Member.ascx.vb" Inherits="Trade.Member" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<%@ Register TagPrefix="uc1" TagName="Confirmation" Src="Confirmation.ascx" %>
<HEAD>
</HEAD>
<meta content="SharePoint.WebPartPage.Document" name="ProgId">
<meta content="full" name="WebPartPageExpansion">
<TABLE id="table18" height="25" cellSpacing="0" cellPadding="0" width="100%" align="center"
	border="0">
</TABLE>
<div align="center">
	<TABLE class="normaltext" id="TBMember" cellSpacing="1" cellPadding="1" width="640" border="0"
		runat="server">
		<TR>
			<TD align="center">
				<asp:Label id="lblMessage" runat="server" Visible="False" ForeColor="Red"></asp:Label><BR>
				<TABLE class="normaltext" id="Table2" style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid; BACKGROUND-REPEAT: repeat-x"
					width="100%" border="0">
					<TR>
						<TD class="boxhdn" align="left" bgColor="#cf8e40" colSpan="4" height="21">&nbsp;Member 
							Details</TD>
					</TR>
					<TR>
						<TD class="HeadingWithBackGround" align="left" colSpan="4">
							<p align="center"><font face="Verdana" size="1"><asp:label id="lblUserNameDuplicate" runat="server" ForeColor="Red">User Name Duplicate </asp:label></font><INPUT id="tbHPassword" type="hidden" runat="server"></p>
						</TD>
					</TR>
					<TR>
						<TD align="left" colSpan="4">
							<table class="MainTable" id="Table4" style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid"
								cellSpacing="1" cellPadding="1" width="99%" align="center" bgColor="white">
								<tr vAlign="top" height="27">
									<td style="BACKGROUND-IMAGE: url(../images/postform_bar_bg.gif); VERTICAL-ALIGN: middle; BORDER-BOTTOM: #cf8e40 1px solid; BACKGROUND-REPEAT: repeat-x"
										colSpan="4">
										<table cellSpacing="0" cellPadding="0" width="100%" border="0">
											<tr>
												<td vAlign="middle" width="152"><b><font face="Verdana" color="#fea300" size="1">&nbsp;</font><font face="Verdana" color="#cf8e40" size="1">COMPANY 
															INFORMATION</font></b></td>
											</tr>
										</table>
									</td>
								</tr>
								<tr style="HEIGHT: 5px; BACKGROUND-COLOR: #fff9f0">
									<td colSpan="4"><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></td>
								</tr>
								<tr style="HEIGHT: 20px; BACKGROUND-COLOR: #fff9f0">
									<td class="titleTd" width="123">&nbsp;&nbsp;Company Name: &nbsp;</td>
									<td style="WIDTH: 215px" width="221"><asp:textbox class="box" id="tbCompName" runat="server" MaxLength="100"></asp:textbox><font face="Verdana" size="1"><asp:requiredfieldvalidator id="RFVCompName" runat="server" Display="Dynamic" ErrorMessage="Enter Company Name"
												ControlToValidate="tbCompName"></asp:requiredfieldvalidator></font></td>
									<td class="titleTd" width="77">User&nbsp;Name:
									</td>
									<td class="error" width="186"><asp:textbox class="box" id="tbUserName" runat="server" MaxLength="100"></asp:textbox><FONT size="1"><FONT face="Verdana" color="#ff3300">*</FONT>
										</FONT><font face="Verdana" size="1">
											<asp:requiredfieldvalidator id="RFVUserName" runat="server" Display="Dynamic" ErrorMessage="Enter UserName"
												ControlToValidate="tbUserName"></asp:requiredfieldvalidator></font></td>
								</tr>
								<tr id="TRPassword" style="HEIGHT: 20px; BACKGROUND-COLOR: #fff9f0" runat="server">
									<td class="titleTd" id="TD1">&nbsp;&nbsp;Password:</td>
									<td style="WIDTH: 216px"><asp:textbox class="box" id="tbPassword" runat="server" MaxLength="20"></asp:textbox>
										<FONT face="Verdana" color="#ff3300" size="1">*</FONT><font face="Verdana" size="1">&nbsp;(20 
											characters max)</font></td>
									<td>&nbsp;</td>
									<td>&nbsp;</td>
								</tr>
								<tr style="HEIGHT: 20px; BACKGROUND-COLOR: #fff9f0">
									<td class="titleTd">&nbsp;&nbsp;Company Type:</td>
									<td colSpan="3">
										<TABLE class="normaltext" id="Table7" cellSpacing="1" cellPadding="1" width="100%" border="0">
											<TR>
												<TD class="normalText" style="WIDTH: 209px" width="209"><asp:checkbox id="chkCompanyTypeEI" runat="server" Text="Exporter / Importer"></asp:checkbox></TD>
												<TD class="normalText" style="WIDTH: 192px" width="192"><asp:checkbox id="chkCompanyTypeDR" runat="server" Text="Dealer / Reseller"></asp:checkbox></TD>
												<TD class="normalText" width="35%"><asp:checkbox id="chkCompanyTypeR" runat="server" Text="Retailer"></asp:checkbox></TD>
											</TR>
											<TR>
												<TD class="normalText" style="WIDTH: 209px"><asp:checkbox id="chkCompanyTypeSP" runat="server" Text="Service Provider"></asp:checkbox></TD>
												<TD class="normalText" style="WIDTH: 192px"><asp:checkbox id="chkCompanyTypeFF" runat="server" Text="Freight forwarder"></asp:checkbox></TD>
												<TD class="normalText"></TD>
											</TR>
										</TABLE>
										<asp:checkbox id="chkCompanyTypeM" runat="server" Text="Manufacturer" Visible="False"></asp:checkbox></td>
								</tr>
								<tr style="HEIGHT: 20px; BACKGROUND-COLOR: #fff9f0">
									<td class="titleTd">&nbsp;&nbsp;Mailing address:</td>
									<td class="error" colSpan="3"><asp:textbox class="box" id="tbAddress" runat="server" MaxLength="500" TextMode="MultiLine" Width="226px"
											Height="30px"></asp:textbox>
										<FONT face="Verdana" color="#ff3300" size="1">*</FONT><font face="Verdana" size="1">
											<asp:requiredfieldvalidator id="RFVMailingAdd" runat="server" Display="Dynamic" ErrorMessage="Enter Mailing Address"
												ControlToValidate="tbAddress"></asp:requiredfieldvalidator></font></td>
								</tr>
								<tr style="HEIGHT: 20px; BACKGROUND-COLOR: #fff9f0">
									<td class="titleTd">&nbsp;&nbsp;Country:</td>
									<td class="error" colSpan="3"><asp:dropdownlist id="DDLCountry" runat="server" CssClass="Box"></asp:dropdownlist>
										<FONT face="Verdana" color="#ff3300" size="1">*</FONT> <FONT face="Verdana" size="1">
											<asp:requiredfieldvalidator id="ReqFVCountry" runat="server" Display="Dynamic" ErrorMessage="Select Country"
												ControlToValidate="DDLCountry"></asp:requiredfieldvalidator></FONT>&nbsp;&nbsp;</td>
								</tr>
								<tr style="HEIGHT: 20px; BACKGROUND-COLOR: #fff9f0">
									<td class="titleTd">&nbsp;&nbsp;Phone:
									</td>
									<td><FONT face="Verdana" size="1">+</FONT><asp:textbox class="box" id="tbPhoneCountry" runat="server" MaxLength="4" Width="30px"></asp:textbox>&nbsp;<asp:textbox class="box" id="tbPhoneAreaCode" runat="server" MaxLength="4" Width="35px"></asp:textbox>&nbsp;<asp:textbox class="box" id="tbPhoneNo" runat="server" MaxLength="8" Width="75px"></asp:textbox><FONT face="Verdana" color="#ff3300" size="1">*
											<asp:requiredfieldvalidator id="RFVPhone" runat="server" Display="Dynamic" ErrorMessage="Enter Phone No." ControlToValidate="tbPhoneNo"></asp:requiredfieldvalidator></FONT></td>
									<td><span class="titleTd">Fax:</span></td>
									<td><FONT face="Verdana" size="1">+</FONT><asp:textbox class="box" id="tbFaxCountry" runat="server" MaxLength="4" Width="30px"></asp:textbox>&nbsp;<asp:textbox class="box" id="tbFaxAreaCode" runat="server" MaxLength="4" Width="35px"></asp:textbox>&nbsp;<asp:textbox class="box" id="tbFaxNo" runat="server" MaxLength="8" Width="75px"></asp:textbox></td>
								</tr>
								<tr style="HEIGHT: 20px; BACKGROUND-COLOR: #fff9f0">
									<td class="titleTd">&nbsp;&nbsp;Email:</td>
									<td class="error" style="WIDTH: 216px"><asp:textbox class="box" id="tbEmailID" runat="server" MaxLength="50"></asp:textbox>
										<FONT face="Verdana" color="#ff3300" size="1">*</FONT> <font face="Verdana" size="1">
											<br>
											<asp:requiredfieldvalidator id="RFVEmailID" runat="server" Display="Dynamic" ErrorMessage="Enter Email ID" ControlToValidate="tbEmailID"></asp:requiredfieldvalidator><asp:regularexpressionvalidator id="REVEmailID" runat="server" Display="Dynamic" ErrorMessage="Enter Correct Email ID"
												ControlToValidate="tbEmailID" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:regularexpressionvalidator></font></td>
									<td class="titletd">Website:</td>
									<td><asp:textbox class="box" id="tbWebSite" runat="server" MaxLength="50"></asp:textbox></td>
								</tr>
								<tr style="HEIGHT: 5px; BACKGROUND-COLOR: #fff9f0">
									<td colSpan="4"><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></td>
								</tr>
							</table>
							<TABLE id="Table3" height="4" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD></TD>
								</TR>
							</TABLE>
							<table class="MainTable" id="table4" style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid"
								cellSpacing="1" cellPadding="1" width="99%" align="center" bgColor="white">
								<tr vAlign="top" height="27">
									<td style="BACKGROUND-IMAGE: url(../images/postform_bar_bg.gif); VERTICAL-ALIGN: middle; BORDER-BOTTOM: #cf8e40 1px solid; BACKGROUND-REPEAT: repeat-x"
										colSpan="4">
										<table cellSpacing="0" cellPadding="0" width="100%" border="0">
											<tr>
												<td vAlign="middle" width="152"><b><font face="Verdana" color="#fea300" size="1">&nbsp;</font><font face="Verdana" color="#cf8e40" size="1">CONTACT 
															INFO.</font></b></td>
											</tr>
										</table>
									</td>
								</tr>
								<tr style="HEIGHT: 5px; BACKGROUND-COLOR: #fff9f0">
									<td colSpan="4"><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></td>
								</tr>
								<tr style="HEIGHT: 20px; BACKGROUND-COLOR: #fff9f0">
									<td class="titleTd" width="122">&nbsp;&nbsp;Contact Person: &nbsp;</td>
									<td class="error" width="220"><asp:textbox class="box" id="tbContactPersonName1" runat="server"></asp:textbox>
										<FONT face="Verdana" color="#ff3300" size="1">*</FONT><font style="WIDTH: 215px" face="Verdana" size="1"><asp:requiredfieldvalidator id="ReqFVContact1" runat="server" Display="Dynamic" ErrorMessage="Enter Contact"
												ControlToValidate="tbContactPersonName1"></asp:requiredfieldvalidator></font></td>
									<td class="titleTd" width="75">Email: &nbsp;</td>
									<td width="190"><asp:textbox class="box" id="tbEmailID1" runat="server"></asp:textbox><font face="Verdana" size="1"><asp:regularexpressionvalidator id="REVEmailID1" runat="server" Display="Dynamic" ErrorMessage="Enter Correct Email ID"
												ControlToValidate="tbEmailID1" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:regularexpressionvalidator></font></td>
								</tr>
								<tr style="HEIGHT: 20px; BACKGROUND-COLOR: #fff9f0">
									<td class="titleTd">&nbsp;&nbsp;Mobile No:</td>
									<td colSpan="3"><FONT face="Verdana" size="1">+</FONT><asp:textbox class="box" id="tbMobileCountry1" runat="server" MaxLength="4" Width="30px"></asp:textbox>&nbsp;<asp:textbox class="box" id="tbMobilePhoneAreaCode1" runat="server" MaxLength="6" Width="45px"></asp:textbox>&nbsp;<asp:textbox class="box" id="tbMobileNo1" runat="server" MaxLength="12" Width="75px"></asp:textbox><FONT face="Verdana" color="#ff3300" size="1">*</FONT>
										<font face="Verdana" size="1">
											<asp:requiredfieldvalidator id="RFVCont_per_phoneNo" runat="server" Display="Dynamic" ErrorMessage="Enter Mobile No."
												ControlToValidate="tbMobileNo1"></asp:requiredfieldvalidator></font></td>
								</tr>
								<tr style="HEIGHT: 5px; BACKGROUND-COLOR: #fff9f0">
									<td colSpan="4"><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></td>
								</tr>
								<tr style="HEIGHT: 20px; BACKGROUND-COLOR: #fff9f0">
									<td class="titleTd">&nbsp;&nbsp;Contact Person:
									</td>
									<td><asp:textbox class="box" id="tbContactPersonName2" runat="server"></asp:textbox></td>
									<td><span class="titleTd">Email: </span>
									</td>
									<td><asp:textbox class="box" id="tbEmailID2" runat="server"></asp:textbox><font face="Verdana" size="1"><asp:regularexpressionvalidator id="REVEmailID2" runat="server" Display="Dynamic" ErrorMessage="Enter Correct Email ID"
												ControlToValidate="tbEmailID2" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:regularexpressionvalidator></font></td>
								</tr>
								<tr style="HEIGHT: 20px; BACKGROUND-COLOR: #fff9f0">
									<td class="titleTd">&nbsp;&nbsp;Mobile No:</td>
									<td colSpan="3"><FONT face="Verdana" size="1">+</FONT><asp:textbox class="box" id="tbMobileCountry2" runat="server" MaxLength="4" Width="30px"></asp:textbox>&nbsp;<asp:textbox class="box" id="tbMobilePhoneAreaCode2" runat="server" MaxLength="6" Width="45px"></asp:textbox>&nbsp;<asp:textbox class="box" id="tbMobileNo2" runat="server" MaxLength="12" Width="75px"></asp:textbox></td>
								</tr>
								<tr style="HEIGHT: 5px; BACKGROUND-COLOR: #fff9f0">
									<td colSpan="4"><IMG height="3" src="../images/spacer_3px.gif" width="3" border="0"></td>
								</tr>
							</table>
							<TABLE id="Table3" height="4" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD></TD>
								</TR>
							</TABLE>
							<table class="MainTable" id="Table5" style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid"
								cellSpacing="1" cellPadding="1" width="99%" align="center" bgColor="white">
								<tr vAlign="top" height="27">
									<td style="VERTICAL-ALIGN: middle; BACKGROUND-REPEAT: repeat-x"
										width="100%"><B><FONT face="Verdana" color="#fea300" size="1">
												<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0" style="VERTICAL-ALIGN: middle; BACKGROUND-REPEAT: repeat-x">
													<TR>
														<TD><STRONG><FONT color="#cf8e40" size="1">&nbsp;DEALING IN</FONT></STRONG></TD>
														<TD>
															<asp:datalist id="DLDealingIn" runat="server" Height="30px" Width="531px" CssClass="normalText"
																RepeatDirection="Horizontal" RepeatColumns="3" ItemStyle-HorizontalAlign="left">
																<ItemStyle HorizontalAlign="Center" CssClass="normaltext"></ItemStyle>
																<ItemTemplate>
																	<asp:CheckBox id=chkDealingIn runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Trading_Cat_Desc") %>'>
																	</asp:CheckBox>
																</ItemTemplate>
															</asp:datalist></TD>
													</TR>
													<TR>
														<TD></TD>
														<TD></TD>
													</TR>
												</TABLE>
											</FONT></B>
									</td>
								</tr>
							</table>
							<TABLE id="tbl_AdminUpdate" width="98%" align="center" border="0" runat="server">
								<TR class="TableBackGround">
									<TD style="WIDTH: 222px" align="right">&nbsp;</TD>
									<TD>&nbsp;
										<asp:button id="btnUpdateInformation" runat="server" Text="Update Information"></asp:button><!--<input class=Buttons onClick=javascript:history.back(); type=button value=" Cancel " name=btnCancel>--></TD>
								</TR>
							</TABLE>
							<TABLE id="tbl_TermsAgree" width="98%" align="center" border="0" runat="server">
								<TR class="TableBackGround">
									<TD class="normalText" align="center" colSpan="2"><asp:checkbox id="chkIAgree" runat="server" Text="I Agree to the Terms and Condition" CssClass="normaltext"></asp:checkbox>&nbsp;
										<asp:button id="cmdSignIn" runat="server" Text="Sign In"></asp:button>
										<!--<input class=Buttons onClick=javascript:history.back(); type=button value=" Cancel " name=btnCancel>--></TD>
								</TR>
								<TR class="TableBackGround">
									<TD style="WIDTH: 222px" align="right"></TD>
									<TD></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
				</TABLE>
				<!--
				<TABLE class="normaltext" id="Table1" width="100%" border="0">
					<TR>
						<TD class="HeadingWithBackGround" align="left" colSpan="3"><STRONG><U>Company Logo</U></STRONG></TD>
					</TR>
					<TR>
						<TD align="left" width="33%" colSpan="3"><INPUT id="CompanyLogoFile" type="file" size="44" name="File1" runat="server"></TD>
					</TR>
				</TABLE>
					<BR>
				-->
				<TABLE class="normaltext" id="Tbl_LogoImage" style="BORDER-RIGHT: #c0c0c0 1px solid; BORDER-TOP: #c0c0c0 1px solid; DISPLAY: none; VISIBILITY: hidden; BORDER-LEFT: #c0c0c0 1px solid; BORDER-BOTTOM: #c0c0c0 1px solid"
					cellSpacing="1" cellPadding="1" width="100%" border="0" runat="server">
					<TR>
						<TD style="WIDTH: 225px" align="left"><STRONG><U>Logo Details</U></STRONG></TD>
						<TD></TD>
					</TR>
					<TR id="tr_companyLogofile" runat="server">
						<TD style="WIDTH: 225px" align="right">Logo File</TD>
						<TD><INPUT id="CompanyLogoFile" type="file"></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 225px"></TD>
						<TD><asp:image id="LogoImage" runat="server"></asp:image></TD>
					</TR>
				</TABLE>
			</TD>
		</TR>
	</TABLE>
</div>
<TABLE id="tbWelcome" runat="server" style="WIDTH: 641px; HEIGHT: 15px" cellSpacing="0"
	cellPadding="0" width="641" align="center" border="0">
	<TR>
		<TD id="TD_WelcomeMsg"></TD>
	</TR>
</TABLE>
