<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Page language="c#" Codebehind="InitiateTransfer.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.InitiateTransfer" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: Initiate Transfer Screen</title>
		<META http-equiv="Pragma" content="no-cache">
		<META http-equiv="Expires" content="-1">
		<!-- InstanceBegin template="/Templates/Minimal.dwt" codeOutsideHTMLIsLocked="false" -->
		<!-- InstanceBeginEditable name="doctitle" -->
		<!-- InstanceEndEditable -->
		<!-- InstanceBeginEditable name="head" -->
		<style type="text/css">TD { FONT-SIZE: 11px; FONT-FAMILY: tahoma }
	INPUT { FONT-SIZE: 11px; FONT-FAMILY: tahoma }
	SELECT { FONT-SIZE: 11px; FONT-FAMILY: tahoma }
	</style>
		<!-- InstanceEndEditable --><LINK href="/css/InnerPage.css" type="text/css" rel="stylesheet"><LINK href="/WebForms/StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body leftMargin="0" topMargin="0">
		<form id="Form1" method="post" runat="server">
			<table height="100%" cellSpacing="0" cellPadding="0" width="100%" bgColor="black" border="0">
				<tr>
					<td vAlign="top" height="100%">
						<table height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<tr>
								<td vAlign="top" bgColor="#cfcfcf">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td align="right">
												<table height="0" cellSpacing="0" cellPadding="0" width="100%" border="0">
													<tr>
														<td vAlign="bottom" bgColor="#000000" height="42">
															<table cellSpacing="0" cellPadding="0" width="100%" border="0">
																<tr>
																	<td vAlign="bottom"></td>
																</tr>
																<TR>
																	<TD vAlign="middle" align="center"><font style="LETTER-SPACING: 2pt" face="verdana" color="#ffffff" size="5"><IMG height="42" alt="" src="/images/layoutImages/logo.jpg" width="257" align="left">We 
																			Understand Your Needs...</font>
																	</TD>
																</TR>
															</table>
														</td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td>
												<table cellSpacing="0" cellPadding="0" width="100%" border="0">
													<TR>
														<TD align="center"></TD>
													</TR>
													<tr>
														<td align="center" height="22"><font face="Arial, Helvetica, sans-serif" size="4"><!-- InstanceBeginEditable name="Heading" --> 
																&nbsp;Initiate Transfer Screen <!-- InstanceEndEditable --></font></td>
													</tr>
													<TR>
														<TD align="center">
															<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
																<TR>
																	<TD align="center">
																		<TABLE id="Table5" cellPadding="0" width="100%" border="0">
																		</TABLE>
																		<TABLE id="Table33" cellPadding="0" width="100%" border="0">
																		</TABLE>
																		<asp:panel id="pnlExistingCustomer" runat="server" Height="26px">
																			<TABLE id="Table34" cellSpacing="1" cellPadding="1" width="80%" border="0">
																				<TR>
																					<TD align="center" width="334" colSpan="1" height="15"><STRONG>&nbsp;</STRONG></TD>
																					<TD align="center" width="334" colSpan="1" height="15">&nbsp;</TD>
																				</TR>
																				<TR>
																					<TD align="center" width="334" colSpan="2">
																						<asp:label id="lblCustomerCardMessage" runat="server" ForeColor="OrangeRed" Font-Bold="True"
																							Width="665px"></asp:label></TD>
																				</TR>
																				<TR>
																					<TD align="center" width="334" colSpan="2">
																						<asp:checkbox id="chbxCreateNewCustomer" runat="server" Font-Bold="True" Enabled="False" AutoPostBack="True"
																							Text="Create new customer" Visible="False"></asp:checkbox></TD>
																				</TR>
																				<TR>
																					<TD align="center" width="334"><STRONG>
																							<HR width="100%" noShade SIZE="2">
																						</STRONG><STRONG>Customer Card Information</STRONG>
																						<HR noShade>
																					</TD>
																					<TD align="center">
																						<HR noShade>
																						&nbsp;<STRONG>&nbsp;Previous Transaction&nbsp;Information
																							<HR width="100%" noShade SIZE="2">
																						</STRONG>
																					</TD>
																				</TR>
																				<TR>
																					<TD align="center" width="334">Customer Card No:
																						<asp:TextBox id="txtCustomerCardNumber" runat="server"></asp:TextBox>&nbsp;&nbsp;</TD>
																					<TD align="center">SR Transaction&nbsp;No:&nbsp;
																						<asp:TextBox id="txtTransactionNumber" runat="server"></asp:TextBox></TD>
																				</TR>
																				<TR>
																					<TD align="center" width="334">
																						<asp:Button id="butCheckCustomerCard" runat="server" Width="167px" Text="Get Card Details" CausesValidation="False"></asp:Button></TD>
																					<TD align="center">
																						<asp:Button id="butCheckSRTRNumber" runat="server" Width="167px" Text="Get Transaction Details"
																							CausesValidation="False"></asp:Button></TD>
																				</TR>
																				<TR>
																					<TD align="center" width="334"></TD>
																					<TD align="center"></TD>
																				</TR>
																				<TR>
																					<TD align="center" width="334" colSpan="2"><A onclick="window.open('search.aspx');" href="search.aspx">Search 
																							Customer</A>
																						<asp:Button id="brnSearch" runat="server" Text="Search Customer" Visible="False"></asp:Button></TD>
																				</TR>
																			</TABLE>
																		</asp:panel></TD>
																</TR>
																<TR>
																	<TD align="center">
																		<HR noShade>
																	</TD>
																</TR>
															</TABLE>
														</TD>
													</TR>
												</table>
											</td>
										</tr>
										<tr>
											<td vAlign="top">
												<table cellSpacing="0" cellPadding="0" width="100%" border="0">
													<tr>
														<td vAlign="top"><!-- InstanceBeginEditable name="MainContent" -->
															<table cellPadding="0" width="100%" border="0">
																<tr>
																	<td align="center"><asp:panel id="pnlTopPanel" runat="server">
																			<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
																				<TR>
																					<TD vAlign="top" align="center" width="50%">
																						<TABLE id="Table1" cellPadding="0" width="100%" border="0">
																							<TR>
																								<TD align="right" width="40%">Origin Country :
																								</TD>
																								<TD>
																									<asp:DropDownList id="ddlOriginCountry" runat="server" AutoPostBack="True" DataValueField="ID1" DataTextField="Display"></asp:DropDownList></TD>
																							</TR>
																							<TR>
																								<TD align="right">Origin Location :
																								</TD>
																								<TD>
																									<asp:DropDownList id="ddlOriginLocation" runat="server" AutoPostBack="True" DataValueField="ID1" DataTextField="Display"></asp:DropDownList></TD>
																							</TR>
																							<TR>
																								<TD align="right">Origin Agent :
																								</TD>
																								<TD>
																									<asp:DropDownList id="ddlOriginAgent" runat="server" AutoPostBack="True" DataValueField="ID1" DataTextField="Display"></asp:DropDownList></TD>
																							</TR>
																							<TR>
																								<TD align="right">Origin User :
																								</TD>
																								<TD>
																									<asp:DropDownList id="ddlOriginUser" runat="server" AutoPostBack="True" DataValueField="ID1" DataTextField="Display"></asp:DropDownList></TD>
																							</TR>
																							<TR>
																								<TD align="right">Balance Credit [USD]&nbsp;:
																								</TD>
																								<TD>
																									<asp:Label id="lblCreditBalance" runat="server"></asp:Label></TD>
																							</TR>
																						</TABLE>
																					</TD>
																					<TD vAlign="top" width="50%">
																						<asp:Panel id="pnlDestinationSelection" runat="server"> <!-- Start -->
																							<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="100%" border="0">
																								<TR>
																									<TD>
																										<TABLE id="Table7" cellPadding="0" width="100%" border="0">
																											<TR>
																												<TD width="80">
																													<HR noShade>
																												</TD>
																												<TD noWrap align="center" width="160"><STRONG>Destination Selection</STRONG>
																												</TD>
																												<TD>
																													<HR noShade>
																												</TD>
																											</TR>
																										</TABLE>
																									</TD>
																								</TR>
																								<TR>
																									<TD align="center">
																										<asp:Label id="lblDestinationSelectionMessage" runat="server"></asp:Label></TD>
																								</TR>
																								<TR>
																									<TD>
																										<TABLE id="Table8" cellPadding="0" width="100%" border="0">
																											<TR>
																												<TD align="right" width="35%" height="16">Country :
																												</TD>
																												<TD height="16">
																													<asp:DropDownList id="ddlDestinationCountry" runat="server" AutoPostBack="True" DataValueField="ID1"
																														DataTextField="Display"></asp:DropDownList></TD>
																											</TR>
																											<TR>
																												<TD align="right" height="18">Mode of Payment :
																												</TD>
																												<TD height="18">
																													<asp:DropDownList id="ddlDestinationModeOfPayment" runat="server" AutoPostBack="True" DataValueField="ID1"
																														DataTextField="Display"></asp:DropDownList></TD>
																											</TR>
																											<TR>
																												<TD align="right" height="12">Location :
																												</TD>
																												<TD height="12">
																													<asp:DropDownList id="ddlDestinationLocation" runat="server" AutoPostBack="True" DataValueField="ID1"
																														DataTextField="Display"></asp:DropDownList></TD>
																											</TR>
																											<TR>
																												<TD align="right">Agent Address :
																												</TD>
																												<TD>
																													<asp:TextBox id="txtDestinationAgentAddress" runat="server"></asp:TextBox>&nbsp;
																													<asp:Button id="butDestinationAgentFilter" runat="server" Text="Filter" CausesValidation="False"></asp:Button></TD>
																											</TR>
																										</TABLE>
																									</TD>
																								</TR>
																								<TR>
																									<TD>
																										<HR noShade>
																									</TD>
																								</TR>
																							</TABLE> <!--  End --></asp:Panel></TD>
																				</TR>
																			</TABLE>
																		</asp:panel></td>
																</tr>
																<tr>
																	<td align="center"><asp:label id="lblMessage" runat="server" Width="100%" Font-Bold="True" ForeColor="OrangeRed"></asp:label></td>
																</tr>
																<tr>
																	<td align="center"><asp:validationsummary id="ValidationSummary1" runat="server" Height="34px" Width="100%" Font-Bold="True"
																			ForeColor="OrangeRed"></asp:validationsummary></td>
																</tr>
																<tr>
																	<td align="center"><asp:panel id="pnlMiddlePart" runat="server">
																			<TABLE id="Table2" cellPadding="0" width="90%" border="0">
																				<TR>
																					<TD>
																						<asp:Panel id="pnlDestinationEntityDetails" runat="server">
																							<TABLE id="Table9" cellSpacing="0" cellPadding="0" width="100%" border="0">
																								<TR>
																									<TD>
																										<TABLE id="Table10" cellPadding="0" width="100%" border="0">
																											<TR>
																												<TD width="80">
																													<HR noShade>
																												</TD>
																												<TD noWrap align="center" width="180"><STRONG>Destination Agent / Bank</STRONG>
																												</TD>
																												<TD>
																													<HR noShade>
																												</TD>
																											</TR>
																										</TABLE>
																									</TD>
																								</TR>
																								<TR>
																									<TD>
																										<TABLE id="Table11" cellPadding="0" width="100%" border="0">
																											<TR>
																												<TD>
																													<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
																														<TR>
																															<TD width="30%">
																																<TABLE id="Table12" cellPadding="0" width="100%" border="0">
																																	<TR>
																																		<TD noWrap align="right" width="35%">Purpose Of Transfer :
																																		</TD>
																																		<TD>
																																			<asp:DropDownList id="ddlPurposeOfTransfer" runat="server" DataValueField="ID1" DataTextField="Display"></asp:DropDownList></TD>
																																	</TR>
																																</TABLE>
																															</TD>
																															<TD vAlign="top">
																																<asp:Panel id="pnlDestinationAgent" runat="server">
																																	<TABLE id="Table13" cellPadding="0" width="100%" border="0">
																																		<TR>
																																			<TD noWrap align="right" width="35%">Select Recommended SR Agent :
																																			</TD>
																																			<TD>
																																				<asp:DropDownList id="ddlDestinationAgent" runat="server" AutoPostBack="True" DataValueField="ID1"
																																					DataTextField="Display"></asp:DropDownList></TD>
																																		</TR>
																																	</TABLE>
																																</asp:Panel>
																																<asp:Panel id="pnlDestinationBank" runat="server">
																																	<TABLE id="Table14" cellPadding="0" width="100%" border="0">
																																		<TR>
																																			<TD noWrap align="right" width="35%">Select&nbsp;Recommended Draft&nbsp;Bank :
																																			</TD>
																																			<TD>
																																				<asp:DropDownList id="ddlDestinationBank" runat="server" DataValueField="ID1" DataTextField="Display"></asp:DropDownList></TD>
																																		</TR>
																																	</TABLE>
																																</asp:Panel></TD>
																														</TR>
																													</TABLE>
																												</TD>
																											</TR>
																										</TABLE>
																									</TD>
																								</TR>
																								<TR>
																									<TD>
																										<HR noShade>
																									</TD>
																								</TR>
																							</TABLE>
																						</asp:Panel></TD>
																				</TR>
																				<TR>
																					<TD align="center">&nbsp;</TD>
																				</TR>
																				<TR>
																					<TD>
																						<asp:Panel id="pnlTransactionInformation" runat="server">
																							<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
																								<TR>
																									<TD vAlign="top" width="50%">
																										<TABLE id="Table15" cellSpacing="0" cellPadding="0" width="100%" border="0">
																											<TR>
																												<TD>
																													<TABLE id="Table16" cellPadding="0" width="100%" border="0">
																														<TR>
																															<TD width="80">
																																<HR noShade>
																															</TD>
																															<TD noWrap align="center" width="180"><STRONG>Transaction Information</STRONG>
																															</TD>
																															<TD>
																																<HR noShade>
																															</TD>
																														</TR>
																													</TABLE>
																												</TD>
																											</TR>
																											<TR>
																												<TD>&nbsp;
																													<asp:Label id="lblTransactionInformationMessage" runat="server" Width="100%"></asp:Label></TD>
																											</TR>
																											<TR>
																												<TD>
																													<TABLE id="Table17" cellPadding="0" width="100%" border="0">
																														<TR>
																															<TD align="right" width="35%">PayIn Currency :
																															</TD>
																															<TD>
																																<asp:DropDownList id="ddlPayInCurrency" runat="server" DataValueField="ID1" DataTextField="Display"></asp:DropDownList></TD>
																														</TR>
																														<TR>
																															<TD align="right" height="23">PayOut Currency :
																															</TD>
																															<TD height="23">
																																<asp:DropDownList id="ddlPayOutCurrency" runat="server" AutoPostBack="True" DataValueField="ID1" DataTextField="Display"></asp:DropDownList></TD>
																														</TR>
																														<TR>
																															<TD align="right">Exchange Rate :</TD>
																															<TD>
																																<asp:TextBox id="txtExchangeRate" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>&nbsp;
																																<asp:Panel id="pnlExchangeRateRangeInfo" runat="server" Visible="False">Exchange rate can 
                                be altered within 
<asp:Label id="lblMinimumExchangeRate" runat="server"></asp:Label>&nbsp;and 
<asp:Label id="lblMaximumExchangeRate" runat="server"></asp:Label></asp:Panel></TD>
																														</TR>
																														<TR>
																															<TD align="right">PayIn Amount :(<FONT color="#ff0000">*</FONT>)
																															</TD>
																															<TD>
																																<asp:TextBox id="txtPayInAmount" runat="server"></asp:TextBox></TD>
																														</TR>
																														<TR>
																															<TD align="right">PayOut Amount :(<FONT color="#ff0000">*</FONT>)
																															</TD>
																															<TD>
																																<asp:TextBox id="txtPayOutAmount" runat="server"></asp:TextBox></TD>
																														</TR>
																													</TABLE>
																												</TD>
																											</TR>
																											<TR>
																												<TD align="center">&nbsp;
																													<asp:Button id="butCalculate" runat="server" Text="Calculate" CausesValidation="False"></asp:Button></TD>
																											</TR>
																										</TABLE>
																									</TD>
																									<TD vAlign="top" width="50%"><!-- Start -->
																										<asp:Panel id="pnlTransactionDetails" runat="server">
																											<TABLE id="Table18" cellSpacing="0" cellPadding="0" width="100%" border="0">
																												<TR>
																													<TD>
																														<TABLE id="Table19" cellPadding="0" width="100%" border="0">
																															<TR>
																																<TD width="80">
																																	<HR noShade>
																																</TD>
																																<TD noWrap align="center" width="140"><STRONG>Transaction Details</STRONG></TD>
																																<TD>
																																	<HR noShade>
																																</TD>
																															</TR>
																														</TABLE>
																													</TD>
																												</TR>
																												<TR>
																													<TD align="center">Mode Of Payment :
																														<asp:Label id="lblTDModeOfPayment" runat="server"></asp:Label></TD>
																												</TR>
																												<TR>
																													<TD>
																														<TABLE id="Table20" cellPadding="0" width="100%" border="0">
																															<TR>
																																<TD noWrap align="right" width="25%" height="50">PayIn [
																																	<asp:Label id="lblTDPayInCurrency" runat="server"></asp:Label>] :
																																</TD>
																																<TD width="25%">
																																	<asp:Label id="lblTDPayInAmount" runat="server"></asp:Label></TD>
																																<TD noWrap align="right" width="25%">PayOut [
																																	<asp:Label id="lblTDPayOutCurrency" runat="server"></asp:Label>] :
																																</TD>
																																<TD width="25%">
																																	<asp:Label id="lblTDPayOutAmount" runat="server"></asp:Label></TD>
																															</TR>
																															<TR>
																																<TD noWrap align="right" height="50">Commission [
																																	<asp:Label id="lblTDCommissionCurrency" runat="server"></asp:Label>] :
																																</TD>
																																<TD>
																																	<asp:Label id="lblTDCommissionAmount" runat="server"></asp:Label></TD>
																																<TD noWrap align="right">Exchange Rate :
																																</TD>
																																<TD>
																																	<asp:Label id="lblTDExchangeRate" runat="server"></asp:Label></TD>
																															</TR>
																														</TABLE>
																													</TD>
																												</TR>
																												<TR>
																													<TD align="center" height="20"><STRONG>Total Payable [
																															<asp:Label id="lblTDTotalPayableCurrency" runat="server"></asp:Label>] :
																															<asp:Label id="lblTDTotalPayableAmount" runat="server"></asp:Label></STRONG></TD>
																												</TR>
																											</TABLE>
																										</asp:Panel><!-- End --></TD>
																								</TR>
																							</TABLE>
																						</asp:Panel></TD>
																				</TR>
																				<TR>
																					<TD align="center">
																						<HR noShade>
																					</TD>
																				</TR>
																				<TR>
																					<TD align="center">
																						<asp:Panel id="pnlCustomerDetails" runat="server">
																							<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
																								<TR vAlign="top">
																									<TD width="50%"><!-- Customer Details Start-->
																										<TABLE id="Table21" cellSpacing="0" cellPadding="0" width="100%" border="0">
																											<TR>
																												<TD>
																													<TABLE id="Table22" cellPadding="0" width="100%" border="0">
																														<TR>
																															<TD width="80">
																																<HR noShade>
																															</TD>
																															<TD noWrap align="center" width="140"><STRONG>Sender Details</STRONG>
																															</TD>
																															<TD>
																																<HR noShade>
																															</TD>
																														</TR>
																													</TABLE>
																												</TD>
																											</TR>
																											<TR>
																												<TD>
																													<asp:Label id="lblCustomerDetailsMessage" runat="server" Width="100%"></asp:Label></TD>
																											</TR>
																											<TR>
																												<TD>
																													<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
																														<TR>
																															<TD>
																																<TABLE id="Table23" cellPadding="0" width="100%" border="0">
																																	<TR>
																																		<TD noWrap align="right" width="35%">Record Status :
																																		</TD>
																																		<TD>
																																			<asp:Label id="lblCustomerRecordStatus" runat="server">New</asp:Label></TD>
																																	</TR>
																																	<TR>
																																		<TD align="right">First Name :(<FONT color="#ff0000">**</FONT>)
																																		</TD>
																																		<TD>
																																			<asp:TextBox id="txtCustomerFirstName" runat="server"></asp:TextBox>
																																			<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="Customer first name is needed"
																																				ControlToValidate="txtCustomerFirstName" EnableClientScript="False">*</asp:RequiredFieldValidator></TD>
																																	</TR>
																																	<TR>
																																		<TD align="right">Last Name :(<FONT color="#ff0000">**</FONT>)
																																		</TD>
																																		<TD>
																																			<asp:TextBox id="txtCustomerLastName" runat="server"></asp:TextBox>
																																			<asp:RequiredFieldValidator id="RequiredFieldValidator7" runat="server" ErrorMessage="Customer last name is needed"
																																				ControlToValidate="txtCustomerLastName" EnableClientScript="False">*</asp:RequiredFieldValidator></TD>
																																	</TR>
																																	<TR>
																																		<TD align="right">Email Id:
																																		</TD>
																																		<TD>
																																			<asp:TextBox id="txtCustomerEmailId" runat="server"></asp:TextBox></TD>
																																	</TR>
																																	<TR>
																																		<TD vAlign="top" align="right">Address :
																																		</TD>
																																		<TD>
																																			<asp:TextBox id="txtCustomerAddress" runat="server" TextMode="MultiLine" Columns="25" Rows="5"></asp:TextBox></TD>
																																	</TR>
																																	<TR>
																																		<TD vAlign="top" align="right">Zip :
																																		</TD>
																																		<TD>
																																			<asp:TextBox id="txtCustomerZip" runat="server"></asp:TextBox></TD>
																																	</TR>
																																</TABLE>
																															</TD>
																														</TR>
																														<TR>
																															<TD>
																																<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
																																	<TR align="center">
																																		<TD width="50%">Telephone (<FONT color="#ff0000">*</FONT>)<BR>
																																			<STRONG><FONT size="1">(recommended for customer service)</FONT></STRONG></TD>
																																		<TD width="50%">Mobile (<FONT color="#ff0000">*</FONT>)<BR>
																																			<STRONG><FONT size="1">(recommended for SRTR status)</FONT></STRONG></TD>
																																	</TR>
																																	<TR align="center">
																																		<TD>
																																			<asp:TextBox id="txtCustomerTelephone" runat="server"></asp:TextBox></TD>
																																		<TD>
																																			<asp:TextBox id="txtCustomerMobile" runat="server"></asp:TextBox></TD>
																																	</TR>
																																</TABLE>
																															</TD>
																														</TR>
																														<TR>
																															<TD>
																																<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
																																	<TR align="center">
																																		<TD width="50%">ID Type</TD>
																																		<TD width="50%">ID Number
																																		</TD>
																																	</TR>
																																	<TR align="center">
																																		<TD>
																																			<asp:TextBox id="txtCustomerIdType" runat="server"></asp:TextBox></TD>
																																		<TD>
																																			<asp:TextBox id="txtCustomerIdDetails" runat="server"></asp:TextBox></TD>
																																	</TR>
																																</TABLE>
																															</TD>
																														</TR>
																														<TR>
																															<TD>
																																<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
																																	<TR align="center">
																																		<TD width="50%">ID Expiry
																																		</TD>
																																		<TD width="50%">Nationality</TD>
																																	</TR>
																																	<TR align="center">
																																		<TD>
																																			<TABLE id="Table27" cellSpacing="0" cellPadding="0" width="100%" border="0">
																																				<TR>
																																					<TD align="center">
																																						<asp:TextBox id="txtCustomerIdExpiry" runat="server"></asp:TextBox></TD>
																																				</TR>
																																				<TR>
																																					<TD align="center"><FONT size="2"><EM>(ex: 12 Jan 2008)</EM></FONT></TD>
																																				</TR>
																																			</TABLE>
																																		</TD>
																																		<TD>
																																			<asp:DropDownList id="ddlCustomerNationality" runat="server" Width="180px" DataValueField="ID1" DataTextField="Display"></asp:DropDownList></TD>
																																	</TR>
																																</TABLE>
																															</TD>
																														</TR>
																													</TABLE>
																												</TD>
																											</TR>
																											<TR>
																												<TD>&nbsp;
																												</TD>
																											</TR>
																											<TR>
																												<TD align="right">
																													<asp:Button id="butUpdateCustomerRecord" runat="server" Text="Update Sender Record" Visible="False"
																														CausesValidation="False"></asp:Button></TD>
																											</TR>
																										</TABLE>
																									</TD>
																									<TD width="50%">
																										<asp:Panel id="pnlBeneficeryDetails" runat="server"> <!-- Start -->
																											<TABLE id="Table28" cellPadding="0" width="100%" border="0">
																												<TR>
																													<TD>
																														<TABLE id="Table29" cellPadding="0" width="100%" border="0">
																															<TR>
																																<TD width="80">
																																	<HR noShade>
																																</TD>
																																<TD noWrap align="center" width="140"><STRONG>Beneficiary Details</STRONG>
																																</TD>
																																<TD>
																																	<HR noShade>
																																</TD>
																															</TR>
																														</TABLE>
																													</TD>
																												</TR>
																												<TR>
																													<TD>&nbsp;
																														<asp:Label id="lblBeneficeryDetailsMessage" runat="server" Width="100%"></asp:Label></TD>
																												</TR>
																												<TR>
																													<TD>
																														<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
																															<TR>
																																<TD width="50%">
																																	<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
																																		<TR>
																																			<TD>Beneficiary</TD>
																																			<TD>
																																				<asp:DropDownList id="ddlBeneficerySelection" runat="server" AutoPostBack="True" DataValueField="ID1"
																																					DataTextField="Display">
																																					<asp:ListItem Value="New...">New...</asp:ListItem>
																																				</asp:DropDownList></TD>
																																		</TR>
																																	</TABLE>
																																</TD>
																																<TD width="50%">
																																	<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
																																		<TR>
																																			<TD width="50%">Record Status</TD>
																																			<TD>
																																				<asp:Label id="lblBeneficeryStatus" runat="server">New</asp:Label></TD>
																																		</TR>
																																	</TABLE>
																																</TD>
																															</TR>
																														</TABLE>
																													</TD>
																												</TR>
																												<TR>
																													<TD>
																														<TABLE id="Table30" cellSpacing="0" cellPadding="0" width="100%" border="0">
																															<TR>
																																<TD align="right" width="35%">First Name :(<FONT color="#ff0000">**</FONT>)
																																</TD>
																																<TD>
																																	<asp:TextBox id="txtBeneficeryFirstName" runat="server" MaxLength="50"></asp:TextBox>
																																	<asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" ErrorMessage="Beneficiary first name is needed"
																																		ControlToValidate="txtBeneficeryFirstName" EnableClientScript="False">*</asp:RequiredFieldValidator></TD>
																															</TR>
																															<TR>
																																<TD align="right">Last Name :(<FONT color="#ff0000">**</FONT>)
																																</TD>
																																<TD>
																																	<asp:TextBox id="txtBeneficeryLastName" runat="server" MaxLength="50"></asp:TextBox>
																																	<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ErrorMessage="Beneficiary last name is needed"
																																		ControlToValidate="txtBeneficeryLastName" EnableClientScript="False">*</asp:RequiredFieldValidator></TD>
																															</TR>
																															<TR>
																																<TD align="right">Email Id :
																																</TD>
																																<TD>
																																	<asp:TextBox id="txtBeneficeryEmailId" runat="server" MaxLength="200"></asp:TextBox></TD>
																															</TR>
																															<TR>
																																<TD align="right">
																																	<asp:Label id="lblBeneficeryAddress" runat="server">Address :</asp:Label>
																																	<asp:Label id="lblBenAddressMandarotySign" runat="server" ForeColor="Red">(**)</asp:Label>&nbsp;</TD>
																																<TD>
																																	<asp:TextBox id="txtBeneficeryAddress" runat="server" TextMode="MultiLine" Columns="25" Rows="5"></asp:TextBox>
																																	<asp:RequiredFieldValidator id="rfvBenAdddress" runat="server" Enabled="False" ErrorMessage="Beneficiary Address / Courier Address is needed!"
																																		ControlToValidate="txtBeneficeryAddress" EnableClientScript="False" Display="Dynamic">*</asp:RequiredFieldValidator></TD>
																															</TR>
																															<TR>
																																<TD align="right">Zip :
																																</TD>
																																<TD>
																																	<asp:TextBox id="txtBeneficeryZip" runat="server" MaxLength="50"></asp:TextBox><BR>
																																	<STRONG><FONT size="1">(recommended for fast service)&nbsp;</FONT></STRONG></TD>
																															</TR>
																														</TABLE>
																													</TD>
																												</TR>
																												<TR>
																													<TD>
																														<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
																															<TR align="center">
																																<TD width="50%">Telephone (<FONT color="#ff0000">*</FONT>)<BR>
																																	<STRONG><FONT size="1">(recommended for customer service)&nbsp;</FONT></STRONG></TD>
																																<TD width="50%">Mobile (<FONT color="#ff0000">*</FONT>)<BR>
																																	<STRONG><FONT size="1">(recommended for SRTR status)</FONT></STRONG></TD>
																															</TR>
																															<TR align="center">
																																<TD>
																																	<asp:TextBox id="txtBeneficeryTelephone" runat="server"></asp:TextBox></TD>
																																<TD>
																																	<asp:TextBox id="txtBeneficeryMobile" runat="server"></asp:TextBox></TD>
																															</TR>
																														</TABLE>
																													</TD>
																												</TR>
																												<TR>
																													<TD>
																														<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
																															<TR align="center">
																																<TD width="50%">Id Type
																																</TD>
																																<TD width="50%">Nationality</TD>
																															</TR>
																															<TR align="center">
																																<TD>
																																	<asp:TextBox id="txtBeneficeryIdType" runat="server"></asp:TextBox></TD>
																																<TD>
																																	<asp:DropDownList id="ddlBeneficeryNationality" runat="server" Width="180px" DataValueField="ID1"
																																		DataTextField="Display"></asp:DropDownList></TD>
																															</TR>
																														</TABLE>
																													</TD>
																												</TR>
																												<TR>
																													<TD>&nbsp;</TD>
																												</TR>
																												<TR>
																													<TD></TD>
																												</TR>
																												<TR>
																													<TD align="right">
																														<asp:Button id="butUpdateBeneficeryRecord" runat="server" Text="Update Beneficiary Record" Visible="False"
																															CausesValidation="False"></asp:Button></TD>
																												</TR>
																											</TABLE> <!-- End --></asp:Panel></TD>
																								</TR>
																							</TABLE>
																						</asp:Panel></TD>
																				</TR>
																				<TR>
																					<TD align="center">
																						<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
																							<TR vAlign="top">
																								<TD>
																									<asp:Panel id="pnlBeneficeryBankDetails" runat="server"> <!-- Start -->
																										<TABLE id="Table36" cellSpacing="0" cellPadding="0" width="100%" border="0">
																											<TR>
																												<TD>
																													<TABLE id="Table37" cellPadding="0" width="100%" border="0">
																														<TR>
																															<TD width="80">
																																<HR noShade>
																															</TD>
																															<TD noWrap align="center" width="240"><STRONG>Beneficiary Bank Details</STRONG>
																															</TD>
																															<TD>
																																<HR noShade>
																															</TD>
																														</TR>
																													</TABLE>
																												</TD>
																											</TR>
																											<TR>
																												<TD>
																													<asp:Label id="lblBeneficeryBankDetailsMessage" runat="server" Width="100%"></asp:Label></TD>
																											</TR>
																											<TR>
																												<TD>
																													<TABLE id="Table38" cellSpacing="0" cellPadding="0" width="100%" border="0">
																														<TR>
																															<TD align="right" width="35%">Bank Selection :
																															</TD>
																															<TD>
																																<asp:DropDownList id="ddlBeneficeryBankSelection" runat="server" AutoPostBack="True" DataValueField="ID1"
																																	DataTextField="Display">
																																	<asp:ListItem Value="New...">New...</asp:ListItem>
																																</asp:DropDownList></TD>
																														</TR>
																														<TR>
																															<TD align="right">Record Status :
																															</TD>
																															<TD>
																																<asp:Label id="lblBeneficeryBankRecordStatus" runat="server">New</asp:Label></TD>
																														</TR>
																													</TABLE>
																												</TD>
																											</TR>
																											<TR>
																												<TD height="44">
																													<TABLE id="Table40" cellSpacing="0" cellPadding="0" width="100%" border="0">
																														<TR>
																															<TD align="right" width="35%">Account Number :
																																<asp:Label id="lblBenBankAccountNumberMandatorySign" runat="server" ForeColor="Red">(**)</asp:Label></TD>
																															<TD>
																																<asp:TextBox id="txtBeneficeryBankAccountNumber" runat="server" Font-Bold="True" Columns="20"
																																	MaxLength="50" Font-Size="Small"></asp:TextBox>
																																<asp:RequiredFieldValidator id="rfvBenBankAccountNumber" runat="server" ErrorMessage="Bank Account Number is needed for this mode of transfer!"
																																	ControlToValidate="txtBeneficeryBankAccountNumber" EnableClientScript="False">*</asp:RequiredFieldValidator></TD>
																														</TR>
																													</TABLE>
																												</TD>
																											</TR>
																											<TR>
																												<TD height="44">
																													<asp:Panel id="pnlBenBankName" runat="server">
																														<TABLE id="Table26" cellSpacing="0" cellPadding="0" width="100%" border="0">
																															<TR>
																																<TD align="right" width="35%">Bank Name :
																																	<asp:Label id="lblBenBankNameMandatorySign" runat="server" ForeColor="Red">(**)</asp:Label></TD>
																																<TD>
																																	<asp:TextBox id="txtBeneficeryBankName" runat="server" MaxLength="150"></asp:TextBox>
																																	<asp:RequiredFieldValidator id="rfvBenBankName" runat="server" ErrorMessage="Bank Name is required for this mode of transfer!"
																																		ControlToValidate="txtBeneficeryBankName" EnableClientScript="False">*</asp:RequiredFieldValidator></TD>
																															</TR>
																														</TABLE>
																													</asp:Panel></TD>
																											</TR>
																											<TR>
																												<TD height="44">
																													<asp:Panel id="pnlBenBankBranchName" runat="server">
																														<TABLE id="Table31" cellSpacing="0" cellPadding="0" width="100%" border="0">
																															<TR>
																																<TD align="right" width="35%">Branch Name :
																																	<asp:Label id="lblBenBankBranchMandatorySign" runat="server" ForeColor="Red">(**)</asp:Label></TD>
																																<TD>
																																	<asp:TextBox id="txtBeneficeryBankBranchName" runat="server" MaxLength="150"></asp:TextBox>
																																	<asp:RequiredFieldValidator id="rfvBenBankBranchName" runat="server" ErrorMessage="Bank Branch Name is required for this mode of transfer!"
																																		ControlToValidate="txtBeneficeryBankBranchName" EnableClientScript="False">*</asp:RequiredFieldValidator></TD>
																																<TD>&nbsp;</TD>
																															</TR>
																														</TABLE>
																													</asp:Panel></TD>
																											</TR>
																											<TR>
																												<TD align="center">
																													<asp:Panel id="pnlBenBankExtraDetails" runat="server">
																														<TABLE id="Table25" cellSpacing="0" cellPadding="0" width="100%" border="0">
																															<TR>
																																<TD align="right" width="35%">Address :
																																	<asp:Label id="lblBenBankAddressMandatorySign" runat="server" ForeColor="Red" Visible="False">(**)</asp:Label></TD>
																																<TD>
																																	<asp:TextBox id="txtBeneficeryBankAddress" runat="server" TextMode="MultiLine" Columns="40" Rows="3"
																																		MaxLength="150"></asp:TextBox>
																																	<asp:RequiredFieldValidator id="rfvBenBankAddress" runat="server" ErrorMessage="Beneficiary Bank address is needed"
																																		ControlToValidate="txtBeneficeryBankAddress" EnableClientScript="False" Display="Dynamic">*</asp:RequiredFieldValidator></TD>
																															</TR>
																															<TR>
																																<TD vAlign="top" align="right">
																																	<asp:Label id="lblBankZip" runat="server">Zip :</asp:Label>
																																	<asp:Label id="lblBankZipMandatorySign" runat="server" ForeColor="Red" Visible="False">(**)</asp:Label></TD>
																																<TD>
																																	<asp:TextBox id="txtBeneficeryBankZip" runat="server" MaxLength="50"></asp:TextBox><BR>
																																	<STRONG><FONT size="1">&nbsp;
																																			<asp:Label id="lblBankZipMsg" runat="server">(recommended for fast service)</asp:Label></FONT></STRONG></TD>
																															</TR>
																															<TR>
																																<TD align="right">Country :
																																</TD>
																																<TD>
																																	<asp:DropDownList id="ddlBeneficeryBankCountry" runat="server" DataValueField="ID1" DataTextField="Display"></asp:DropDownList></TD>
																															</TR>
																														</TABLE>
																													</asp:Panel></TD>
																											</TR>
																											<TR>
																												<TD align="right">
																													<asp:Button id="butUpdateBeneficeryBankRecord" runat="server" Text="Update Bank Record" CausesValidation="False"></asp:Button></TD>
																											</TR>
																										</TABLE> <!-- End --></asp:Panel></TD>
																								<TD width="40%"><!-- Start --></TD>
																							</TR>
																						</TABLE>
																					</TD>
																				</TR>
																				<TR>
																					<TD align="center">
																						<HR noShade>
																					</TD>
																				</TR>
																			</TABLE>
																		</asp:panel></td>
																</tr>
																<tr>
																	<td align="center"><asp:panel id="pnlBottomPart" dir="ltr" runat="server" Visible="False">
																			<TABLE id="Table43" cellSpacing="0" cellPadding="0" width="100%" border="0">
																				<TR>
																					<TD>
																						<TABLE id="Table44" cellPadding="0" width="100%" border="0">
																							<TR>
																								<TD width="80">
																									<HR noShade>
																								</TD>
																								<TD noWrap align="center" width="140"><STRONG>Initiate Transfer</STRONG>
																								</TD>
																								<TD>
																									<HR noShade>
																								</TD>
																							</TR>
																						</TABLE>
																					</TD>
																				</TR>
																				<TR>
																					<TD>
																						<asp:Label id="lblInitateTransferMessage" runat="server" Width="100%"></asp:Label></TD>
																				</TR>
																				<TR>
																					<TD>
																						<TABLE id="Table45" cellSpacing="0" cellPadding="0" width="100%" border="0">
																						</TABLE>
																					</TD>
																				</TR>
																				<TR>
																					<TD align="center">
																						<asp:Button id="butInitiateTransfer" runat="server" Height="30px" Width="40%" Text="Initiate Transfer"
																							Font-Size="Medium" Font-Names="Verdana"></asp:Button></TD>
																				</TR>
																				<TR>
																					<TD align="center">
																						<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
																							<TR>
																								<TD width="50%"></TD>
																								<TD width="50%"></TD>
																							</TR>
																							<TR>
																								<TD width="50%">(<FONT color="#ff0000">**</FONT>) - Mandatory information
																								</TD>
																								<TD width="50%">(<FONT color="#ff0000">*</FONT>) - Either of the adjacent 
																									information is mandatory (one of the two)
																								</TD>
																							</TR>
																						</TABLE>
																					</TD>
																				</TR>
																				<TR>
																					<TD>
																						<HR noShade>
																					</TD>
																				</TR>
																			</TABLE>
																		</asp:panel></td>
																</tr>
															</table>
															<!-- InstanceEndEditable --></td>
													</tr>
												</table>
											</td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td height="45"><uc1:menu1 id="Menu1_bottom" runat="server"></uc1:menu1></td>
				</tr>
				<tr>
					<td><font face="Arial, Helvetica, sans-serif" color="#ffffff" size="1">� 2004-2005 ARY 
							Speed Remit. All rights reserved </font>
					</td>
				</tr>
			</table>
		</form>
		<!-- InstanceEnd -->
	</body>
</HTML>
