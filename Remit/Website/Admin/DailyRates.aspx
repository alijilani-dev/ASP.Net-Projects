<%@ Page language="c#" Codebehind="DailyRates.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.DailyRates" %>
<%@ Register TagPrefix="uc1" TagName="Menu2" Src="/UserControls/Menu2.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu1" Src="/UserControls/Menu1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="StatusInfo" Src="/UserControls/StatusInfo.ascx" %>
<HTML>
	<HEAD>
		<title>ARY Speed Remit :: Home</title><!-- InstanceBegin template="/Templates/InnerPage2.dwt" codeOutsideHTMLIsLocked="false" -->
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
		<!-- InstanceBeginEditable name="doctitle" -->
		<!-- InstanceEndEditable -->
		<!-- InstanceBeginEditable name="head" --><LINK href="/css/InnerPage.css" type="text/css" rel="stylesheet">
			<!-- InstanceEndEditable --><LINK href="/css/InnerPage.css" type="text/css" rel="stylesheet"><LINK href="/Admin/StyleSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body leftMargin="0" topMargin="0">
		<script language="javascript">
           function openWindow(url) {
           window.open(url,'SpeedRemit','height=600,width=750,location=0,toolbar=0,scrollbars=1');
           return false;
           }
		</script>
		<form id="Form1" method="post" runat="server">
			<table height="100%" cellSpacing="0" cellPadding="0" width="100%" bgColor="black" border="0">
				<tr>
					<td>
						<table cellSpacing="0" cellPadding="0" width="100%" border="0">
							<tr>
								<td width="42">&nbsp;</td>
								<td align="center"><font style="LETTER-SPACING: 2pt" face="verdana" color="#ffffff" size="5">We 
										Understand Your Needs...</font></td>
								<td width="42">&nbsp;</td>
								<td width="257"><IMG alt="" src="/images/layoutImages/logo.jpg"></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td vAlign="top" height="100%">
						<table height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<tr>
								<td vAlign="top" bgColor="#cfcfcf" align="center">
									<P>&nbsp;</P>
									<P><STRONG><FONT size="2">Today's Rates</FONT></STRONG></P>
									<asp:datagrid id="dgrdRateList" runat="server" BorderColor="Tan" BorderWidth="1px" BackColor="LightGoldenrodYellow"
										CellPadding="2" GridLines="None" ForeColor="Black" AutoGenerateColumns="False" Width="325px">
										<FooterStyle BackColor="Tan"></FooterStyle>
										<SelectedItemStyle ForeColor="GhostWhite" BackColor="DarkSlateBlue"></SelectedItemStyle>
										<AlternatingItemStyle BackColor="PaleGoldenrod"></AlternatingItemStyle>
										<HeaderStyle Font-Bold="True" BackColor="Tan"></HeaderStyle>
										<Columns>
											<asp:BoundColumn DataField="PayOutCountryName" SortExpression="PayOutCountryName" HeaderText="Country"></asp:BoundColumn>
											<asp:BoundColumn DataField="FinalRate" SortExpression="FinalRate" HeaderText="        Rate">
												<HeaderStyle HorizontalAlign="Right"></HeaderStyle>
												<ItemStyle HorizontalAlign="Right"></ItemStyle>
											</asp:BoundColumn>
										</Columns>
										<PagerStyle HorizontalAlign="Center" ForeColor="DarkSlateBlue" BackColor="PaleGoldenrod"></PagerStyle>
									</asp:datagrid>
									<P>&nbsp;</P>
									<P>&nbsp;</P>
								</td>
								<td vAlign="top" width="260">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td height="46">&nbsp;</td>
										</tr>
										<tr>
											<td align="center" height="48">
												<P><font face="verdana" color="#ffffff" size="4">Send Money to Your Destination</font><br>
												</P>
												<P><FONT face="Trebuchet MS" color="#ffffff" size="3"><EM><STRONG> <a href="javascript:void()" onClick="return openWindow('SpeedEast.htm')" style="TEXT-DECORATION:none">
																	<img src="../images/layoutimages/glowing_star.gif" border="0">&nbsp;<FONT color="#ff6600">Speed 
																		East</FONT> </a></STRONG></EM></FONT><FONT face="Trebuchet MS" color="#ffffff" size="3">
														<EM><STRONG>
																<BR>
																<a href="javascript:void()" onClick="return openWindow('SpeedNepal.htm')" style="TEXT-DECORATION:none">
																	<img src="../images/layoutimages/glowing_star.gif" border="0">&nbsp;<FONT color="#ff6600">Speed 
																		Nepal</FONT></a></STRONG></EM></FONT>&nbsp;</P>
											</td>
										</tr>
										<tr>
											<td vAlign="top"><uc1:statusinfo id="StatusInfo1" runat="server"></uc1:statusinfo></td>
										</tr>
										<tr>
											<td vAlign="top"><uc1:menu2 id="Menu2" runat="server"></uc1:menu2></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td height="45"><uc1:menu1 id="Menu11" runat="server"></uc1:menu1></td>
				</tr>
				<tr>
					<td><font face="Arial, Helvetica, sans-serif" color="#ffffff" size="1">© 2004-2005 ARY 
							Speed Remit. All rights reserved </font>
					</td>
				</tr>
			</table>
		</form>
		<!-- InstanceEnd -->
	</body>
</HTML>
