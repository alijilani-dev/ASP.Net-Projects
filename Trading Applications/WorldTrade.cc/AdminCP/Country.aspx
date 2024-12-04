<%@ Register TagPrefix="uc1" TagName="MenuControl" Src="MenuControl.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Country.aspx.vb" Inherits="Trade.Admin.Countrys"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Country</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="1">
				<TR>
					<TD style="HEIGHT: 21px" align="left">
						<uc1:MenuControl id="CMenu" runat="server"></uc1:MenuControl></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 21px" align="center">
						<asp:Label id="lblMessage" runat="server">Press Release Listing</asp:Label></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 21px" id="TDHeader" runat="server">
						<asp:ImageButton id="ImgNew" runat="server" ImageUrl="../images/icon-pencil.gif" AlternateText="New"
							CausesValidation="False"></asp:ImageButton>&nbsp;</TD>
				</TR>
				<TR>
					<TD id="TDView" runat="server" style="HEIGHT: 140px">
						<asp:DataGrid id="DGCountry" runat="server" Width="100%" AutoGenerateColumns="False" Height="374px"
							AllowPaging="True">
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
								<asp:BoundColumn Visible="False" DataField="Country_id" HeaderText="ID"></asp:BoundColumn>
								<asp:BoundColumn DataField="Country_Short_Code" HeaderText="Country Code"></asp:BoundColumn>
								<asp:BoundColumn DataField="Country_Name" HeaderText="Country Name"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Flag Image">
									<ItemTemplate>
										<asp:Image id=ImageButton2 runat="server" AlternateText="New" ImageUrl='<%# DataBinder.Eval(Container, "DataItem.country_flag_Img_url") %>'>
										</asp:Image>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
							<PagerStyle Mode="NumericPages"></PagerStyle>
						</asp:DataGrid></TD>
				</TR>
				<TR>
					<TD id="TDAction" runat="server">
						<TABLE id="tbl_Action" cellSpacing="1" cellPadding="1" width="100%" border="1">
							<TR>
								<TD style="WIDTH: 255px; HEIGHT: 20px">Country id</TD>
								<TD style="WIDTH: 5px; HEIGHT: 20px">:</TD>
								<TD style="HEIGHT: 20px">
									<asp:TextBox id="tbCountryID" runat="server" ReadOnly="True"></asp:TextBox></TD>
								<TD style="HEIGHT: 20px"></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 255px">
									Country&nbsp;Code</TD>
								<TD style="WIDTH: 5px">:</TD>
								<TD>
									<asp:TextBox id="tbCountryCode" runat="server" MaxLength="2" Width="56px" Height="24px"></asp:TextBox></TD>
								<TD>
									<asp:RequiredFieldValidator id="RFVCountryCode" runat="server" ErrorMessage="Enter Country Code" ControlToValidate="tbCountryCode"></asp:RequiredFieldValidator></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 255px; HEIGHT: 52px">
									Country Name</TD>
								<TD style="WIDTH: 5px; HEIGHT: 52px">:</TD>
								<TD style="HEIGHT: 52px">
									<asp:TextBox id="tbCountryName" runat="server" Width="288px" MaxLength="100" TextMode="MultiLine"
										Height="55px"></asp:TextBox></TD>
								<TD style="HEIGHT: 52px">
									<asp:RequiredFieldValidator id="RFVCname" runat="server" ErrorMessage="Enter Country Name" ControlToValidate="tbCountryName"></asp:RequiredFieldValidator></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 255px; HEIGHT: 30px">
									Country Flag</TD>
								<TD style="WIDTH: 5px; HEIGHT: 30px">:</TD>
								<TD style="HEIGHT: 30px">
									<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="300" border="1">
										<TR>
											<TD id="TDImage" runat="server">
												<asp:Image id="ImgCountry" runat="server"></asp:Image></TD>
										</TR>
										<TR>
											<TD><INPUT id="C_Img" style="WIDTH: 280px; HEIGHT: 22px" type="file" size="27" name="File1"
													runat="server"></TD>
										</TR>
									</TABLE>
								</TD>
								<TD style="HEIGHT: 30px">
									<asp:RequiredFieldValidator id="RFVLink" runat="server" ErrorMessage="Enter Link for flag" ControlToValidate="C_Img"></asp:RequiredFieldValidator></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 255px"></TD>
								<TD style="WIDTH: 5px"></TD>
								<TD>
									<asp:ImageButton id="imgSave" runat="server" ImageUrl="../images/icon-floppy.gif"></asp:ImageButton>&nbsp;
									<asp:ImageButton id="imgCancel" runat="server" ImageUrl="../images/icon-cancel.gif" CausesValidation="False"></asp:ImageButton></TD>
								<TD></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
