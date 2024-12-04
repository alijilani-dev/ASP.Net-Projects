<%@ Register TagPrefix="uc1" TagName="Member" Src="../Module/Member.ascx" %>
<%@ Register TagPrefix="uc1" TagName="MenuControl" Src="MenuControl.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="MemberDetails.aspx.vb" Inherits="Trade.Admin.MemberDetails"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Member Details</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="1">
				<TR>
					<TD style="HEIGHT: 21px" align="left"><uc1:menucontrol id="CMenu" runat="server"></uc1:menucontrol></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 21px" align="left"><STRONG><asp:label id="lblMessage" runat="server">Member Listing</asp:label></STRONG></TD>
				</TR>
				<TR>
					<TD id="TDHeader" style="HEIGHT: 21px" runat="server"><asp:imagebutton id="ImgNew" runat="server" ImageUrl="../images/icon-pencil.gif" AlternateText="New"
							CausesValidation="False"></asp:imagebutton>&nbsp;</TD>
				</TR>
				<TR>
					<TD id="TDView" runat="server"><asp:datagrid id="DGMember" runat="server" AllowPaging="false" AutoGenerateColumns="False" Width="100%"
							AllowSorting="True" Font-Names="Verdana; Thahoma" Font-Size="Smaller">
							<SelectedItemStyle BackColor="Red"></SelectedItemStyle>
							<AlternatingItemStyle CssClass="normaltext" VerticalAlign="Middle" BackColor="#F3F7FC"></AlternatingItemStyle>
							<ItemStyle CssClass="normaltext" VerticalAlign="Middle" BackColor="#E5EFF9"></ItemStyle>
							<HeaderStyle Font-Bold="True" ForeColor="White" CssClass="normalbold" BackColor="Desktop"></HeaderStyle>
							<Columns>
								<asp:TemplateColumn Visible="False">
									<ItemTemplate>
										<asp:ImageButton id="Imagebutton1" runat="server" ImageUrl="../images/icon-delete.gif" CausesValidation="false"
											CommandName="Delete"></asp:ImageButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Edit">
									<ItemTemplate>
										<asp:ImageButton id="ImageButton3" runat="server" ImageUrl="../images/icon-Edit.gif" CausesValidation="false"
											CommandName="Select"></asp:ImageButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="member_id" HeaderText="UserName"></asp:BoundColumn>
								<asp:BoundColumn DataField="member_company" HeaderText="Company"></asp:BoundColumn>
								<asp:BoundColumn DataField="company_phone" HeaderText="Phone"></asp:BoundColumn>
								<asp:BoundColumn DataField="company_fax" HeaderText="Fax"></asp:BoundColumn>
								<asp:BoundColumn DataField="company_email" HeaderText="Email"></asp:BoundColumn>
								<asp:BoundColumn DataField="country_name" HeaderText="Country"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="company_website" HeaderText="website"></asp:BoundColumn>
								<asp:TemplateColumn Visible="False" HeaderText="Logo">
									<ItemTemplate>
										<asp:ImageButton id=ImageButton2 runat="server" ImageUrl='<%# DataBinder.Eval(Container, "DataItem.company_Logo_Url") %>' AlternateText="logo" CausesValidation="False">
										</asp:ImageButton>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
							<PagerStyle Mode="NumericPages"></PagerStyle>
						</asp:datagrid></TD>
				</TR>
				<TR>
					<TD id="TDAction" runat="server"><uc1:member id="updateMember" runat="server"></uc1:member></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
