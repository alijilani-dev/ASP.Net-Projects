<%@ Page language="c#" Codebehind="Search.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Admin.search" smartNavigation="False"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Search</title>
		<META http-equiv="Content-Type" content="text/html; charset=windows-1252">
		<meta content="False" name="vs_showGrid">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#cfcfcf" MS_POSITIONING="flowlayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="WIDTH: 504px; HEIGHT: 121px" cellSpacing="1" cellPadding="1"
				border="0">
				<TR>
					<TD>
						<asp:repeater id="rptResults" runat="server">
							<ItemTemplate>
								<TABLE border="0" bordercolor="#000000">
									<TR class="TableRow" align="center">
										<TD><!--<a href="#" onclick="window.opener.Form1.txtTransactionNumber.value='<%# String.Format("{0}", DataBinder.Eval(Container.DataItem, "SRTR") ) %>';">static</a><BR>-->
											<asp:HyperLink id="hlnkSelect" runat="server" NavigateUrl='<%# String.Format("InitiateTransfer.aspx?SRTR={0}", DataBinder.Eval(Container.DataItem, "LastName") )%>' EnableViewState="false" CssClass="EditHyperLink" Visible="false"> view details </asp:HyperLink></TD>
										<TD>
											<asp:HyperLink id=hlnkDelete runat="server" NavigateUrl='<%# String.Format("InitiateTransfer.aspx?ID={0}&amp;ReturnToUrl=WebFormList_BankExchangeRateList.aspx&amp;ReturnToDisplay=Backtothelist", DataBinder.Eval(Container.DataItem, "LastName") ) %>' EnableViewState="false" CssClass="EditHyperLink" Visible="true"> view details </asp:HyperLink></TD>
										<TD><%# DataBinder.Eval(Container.DataItem, "FirstName") %></TD>
										<TD><%# DataBinder.Eval(Container.DataItem, "LastName") %></TD>
										<TD><%# DataBinder.Eval(Container.DataItem, "BFirstName") %></TD>
										<TD><%# DataBinder.Eval(Container.DataItem, "BLastName") %></TD>
									</TR>
								</TABLE>
							</ItemTemplate>
						</asp:repeater>
					</TD>
				</TR>
			</TABLE>
			<TABLE>
				<TR>
					<TD style="WIDTH: 158px" colSpan="2"><asp:label id="lblSearch" runat="server" Font-Bold="True" Font-Names="Verdana">Search</asp:label></TD>
					<TD style="WIDTH: 155px" colSpan="2"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 158px; HEIGHT: 16px" colSpan="2"><asp:label id="lblCustomerDetails" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="X-Small">Customer Details</asp:label></TD>
					<TD style="WIDTH: 155px; HEIGHT: 16px" colSpan="2"><asp:label id="lblBeneficieryDetails" runat="server" Font-Bold="True" Font-Names="Verdana"
							Font-Size="X-Small" Width="136px">Beneficiery Details</asp:label></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 133px"></TD>
					<TD></TD>
					<TD style="WIDTH: 155px"></TD>
					<TD></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 133px" align="right"><asp:label id="lblCustFName" runat="server" Font-Names="Verdana" Font-Size="X-Small">First Name:</asp:label></TD>
					<TD><asp:textbox id="txtCFirstName" runat="server"></asp:textbox></TD>
					<TD style="WIDTH: 155px" align="right"><asp:label id="lblBeneFName" runat="server" Font-Names="Verdana" Font-Size="X-Small">First Name:</asp:label></TD>
					<TD><asp:textbox id="txtBFirstName" runat="server"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 133px" align="right"><asp:label id="lblCustLName" runat="server" Font-Names="Verdana" Font-Size="X-Small">Last Name:</asp:label></TD>
					<TD><asp:textbox id="txtCLastName" runat="server"></asp:textbox></TD>
					<TD style="WIDTH: 155px" align="right"><asp:label id="lblBeneLName" runat="server" Font-Names="Verdana" Font-Size="X-Small">Last Name:</asp:label></TD>
					<TD><asp:textbox id="txtBLastName" runat="server"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 133px"></TD>
					<TD align="center" colSpan="2"><asp:button id="btnSearchName" runat="server" Font-Names="Verdana" Font-Size="X-Small" Width="100px"
							Text="Search Name"></asp:button></TD>
					<TD></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 133px"></TD>
					<TD></TD>
					<TD style="WIDTH: 155px"></TD>
					<TD></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 133px" align="right"><asp:label id="lblStartRange" runat="server" Font-Names="Verdana" Font-Size="X-Small">Start Range:</asp:label></TD>
					<TD><asp:textbox id="txtStartRange" runat="server"></asp:textbox></TD>
					<TD style="WIDTH: 155px" align="right"><asp:label id="lblEndRange" runat="server" Font-Names="Verdana" Font-Size="X-Small">End Range:</asp:label></TD>
					<TD><asp:textbox id="txtEndRange" runat="server"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 133px"></TD>
					<TD align="center" colSpan="2"><asp:button id="btnSearchRange" runat="server" Font-Names="Verdana" Font-Size="X-Small" Width="100px"
							Text="Search Range"></asp:button></TD>
					<TD></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 133px"></TD>
					<TD></TD>
					<TD style="WIDTH: 155px"></TD>
					<TD></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 132px; HEIGHT: 24px" align="right"><asp:label id="lblCardNo" runat="server" Font-Names="Verdana" Font-Size="X-Small">Card No. :</asp:label></TD>
					<TD style="HEIGHT: 24px"><asp:textbox id="txtCardNo" runat="server"></asp:textbox></TD>
					<TD style="WIDTH: 155px; HEIGHT: 24px"></TD>
					<TD style="HEIGHT: 24px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 132px"></TD>
					<TD align="center" colSpan="2"><asp:button id="btnCardNo" runat="server" Font-Names="Verdana" Font-Size="X-Small" Width="100px"
							Text="Search Cards"></asp:button></TD>
					<TD></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 132px"></TD>
					<TD></TD>
					<TD style="WIDTH: 155px"></TD>
					<TD></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
