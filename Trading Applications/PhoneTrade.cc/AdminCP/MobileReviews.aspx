<%@ Page Language="vb" AutoEventWireup="false" Codebehind="MobileReviews.aspx.vb" Inherits="Trade.Admin.MobileReviews"%>
<%@ Register TagPrefix="uc1" TagName="MenuControl" Src="MenuControl.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Mobile Reviews</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="1">
				<TR>
					<TD style="HEIGHT: 21px" align="center">
						<uc1:MenuControl id="CMenu" runat="server"></uc1:MenuControl></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 21px" align="center"><asp:label id="lblMessage" runat="server" Font-Bold="True">Mobile Reviews Listing</asp:label></TD>
				</TR>
				<TR>
					<TD id="TDHeader" style="HEIGHT: 21px" runat="server"><asp:imagebutton id="ImgNew" runat="server" CausesValidation="False" AlternateText="New" ImageUrl="../images/icon-pencil.gif"></asp:imagebutton>&nbsp;</TD>
				</TR>
				<TR>
					<TD id="TDView" runat="server"><asp:datagrid id="DGMobileReview" runat="server" Width="100%" AutoGenerateColumns="False" AllowPaging="True">
							<AlternatingItemStyle CssClass="normaltext" VerticalAlign="Middle" BackColor="#F3F7FC"></AlternatingItemStyle>
							<ItemStyle CssClass="normaltext" VerticalAlign="Middle" BackColor="#E5EFF9"></ItemStyle>
							<HeaderStyle CssClass="normalbold" BackColor="White"></HeaderStyle>
							<Columns>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:ImageButton id="Imagebutton1" runat="server" CommandName="Delete" CausesValidation="false" ImageUrl="../images/icon-delete.gif"></asp:ImageButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Edit">
									<ItemTemplate>
										<asp:ImageButton id="ImageButton3" runat="server" CommandName="Select" CausesValidation="false" ImageUrl="../images/icon-Edit.gif"></asp:ImageButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="MR_id" HeaderText="ID"></asp:BoundColumn>
								<asp:BoundColumn DataField="ManufName" HeaderText="Brand"></asp:BoundColumn>
								<asp:BoundColumn DataField="ModelNo" HeaderText="ModelNo"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="MobileReview" HeaderText="Mobile Review"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Latest">
									<ItemTemplate>
										<asp:Label id=Label1 runat="server" Text='<%# iif(DataBinder.Eval(Container, "DataItem.ReviewStatus")=0,"Yes","No") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
							<PagerStyle Mode="NumericPages"></PagerStyle>
						</asp:datagrid></TD>
				</TR>
				<TR>
					<TD id="TDAction" runat="server">
						<TABLE id="tbl_Action" cellSpacing="1" cellPadding="1" width="100%" border="1">
							<TR>
								<TD style="WIDTH: 174px; HEIGHT: 20px">Mobile Review&nbsp;ID</TD>
								<TD style="WIDTH: 5px; HEIGHT: 20px">:</TD>
								<TD style="HEIGHT: 20px"><asp:textbox id="tbMRID" runat="server" ReadOnly="True"></asp:textbox></TD>
								<TD style="HEIGHT: 20px"></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 174px">Mobile Brand</TD>
								<TD style="WIDTH: 5px">:</TD>
								<TD><asp:dropdownlist id="ddlBrand" runat="server" Width="152px" AutoPostBack="True"></asp:dropdownlist></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 174px">Mobile Model</TD>
								<TD style="WIDTH: 5px"></TD>
								<TD><asp:dropdownlist id="ddlModel" runat="server"></asp:dropdownlist></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 174px; HEIGHT: 52px">Mobile Review</TD>
								<TD style="WIDTH: 5px; HEIGHT: 52px">:</TD>
								<TD style="HEIGHT: 52px"><asp:textbox id="tbMobileReview" runat="server" Height="146px" Width="100%" TextMode="MultiLine"
										MaxLength="1000"></asp:textbox></TD>
								<TD style="HEIGHT: 52px"><asp:requiredfieldvalidator id="RFVText" runat="server" ControlToValidate="tbMobileReview" ErrorMessage="Enter Text to Shown"></asp:requiredfieldvalidator></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 174px">Latest</TD>
								<TD style="WIDTH: 5px">:</TD>
								<TD><asp:checkbox id="chkShowMobileReview" runat="server"></asp:checkbox></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 174px"></TD>
								<TD style="WIDTH: 5px"></TD>
								<TD><asp:imagebutton id="imgSave" runat="server" ImageUrl="../images/icon-floppy.gif"></asp:imagebutton>&nbsp;
									<asp:imagebutton id="imgCancel" runat="server" CausesValidation="False" ImageUrl="../images/icon-cancel.gif"></asp:imagebutton></TD>
								<TD></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
