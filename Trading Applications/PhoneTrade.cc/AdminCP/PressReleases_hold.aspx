<%@ Page Language="vb" AutoEventWireup="false" Codebehind="PressReleases.aspx.vb" Inherits="Trade.Admin.PressReleases"%>
<%@ Register TagPrefix="uc1" TagName="MenuControl" Src="MenuControl.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Press releases</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="1">
				<TR>
					<TD style="HEIGHT: 21px" align="center">
						<uc1:MenuControl id="CMenu" runat="server"></uc1:MenuControl></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 21px" align="center">
						<asp:Label id="lblMessage" runat="server" Font-Bold="True">Press Release Listing</asp:Label></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 21px" id="TDHeader" runat="server">
						<asp:ImageButton id="ImgNew" runat="server" ImageUrl="../images/icon-pencil.gif" AlternateText="New"
							CausesValidation="False"></asp:ImageButton>&nbsp;</TD>
				</TR>
				<TR>
					<TD id="TDView" runat="server">
						<asp:DataGrid id="DGPressRelease" runat="server" Width="100%" AutoGenerateColumns="False" AllowPaging="True">
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
								<asp:BoundColumn Visible="False" DataField="press_release_id" HeaderText="ID"></asp:BoundColumn>
								<asp:BoundColumn DataField="press_release_image" HeaderText="Press Image"></asp:BoundColumn>
								<asp:BoundColumn DataField="press_release_text" HeaderText="Press Text"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="press_release_detail" HeaderText="press release detail"></asp:BoundColumn>
								<asp:BoundColumn DataField="Show_Flag" HeaderText="Show"></asp:BoundColumn>
							</Columns>
							<PagerStyle Mode="NumericPages"></PagerStyle>
						</asp:DataGrid></TD>
				</TR>
				<TR>
					<TD id="TDAction" runat="server">
						<TABLE id="tbl_Action" cellSpacing="1" cellPadding="1" width="100%" border="1">
							<TR>
								<TD style="WIDTH: 255px; HEIGHT: 20px">Press Release&nbsp;id</TD>
								<TD style="WIDTH: 5px; HEIGHT: 20px">:</TD>
								<TD style="HEIGHT: 20px">
									<asp:TextBox id="tbPRID" runat="server" ReadOnly="True"></asp:TextBox></TD>
								<TD style="HEIGHT: 20px"></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 255px">Press Release Text</TD>
								<TD style="WIDTH: 5px">:</TD>
								<TD>
									<asp:TextBox id="tbPR_Text" runat="server" MaxLength="255" Width="237px" Height="70px" TextMode="MultiLine"></asp:TextBox></TD>
								<TD>
									<asp:RequiredFieldValidator id="RFVHeading" runat="server" ErrorMessage="Enter Heading" ControlToValidate="tbPR_Text"></asp:RequiredFieldValidator></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 255px; HEIGHT: 52px">Press Release Details</TD>
								<TD style="WIDTH: 5px; HEIGHT: 52px">:</TD>
								<TD style="HEIGHT: 52px">
									<asp:TextBox id="tbPR_Detail" runat="server" Width="100%" MaxLength="1000" TextMode="MultiLine"
										Height="146px"></asp:TextBox></TD>
								<TD style="HEIGHT: 52px">
									<asp:RequiredFieldValidator id="RFVText" runat="server" ErrorMessage="Enter Text to Shown" ControlToValidate="tbPR_Detail"></asp:RequiredFieldValidator></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 255px; HEIGHT: 30px">
									Press Release Image</TD>
								<TD style="WIDTH: 5px; HEIGHT: 30px">:</TD>
								<TD style="HEIGHT: 30px">
									<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="300" border="1">
										<TR>
											<TD id="TDImage" runat="server">
												<asp:Image id="ImgPR" runat="server"></asp:Image></TD>
										</TR>
										<TR>
											<TD><INPUT id="PR_Img" style="WIDTH: 280px; HEIGHT: 22px" type="file" size="27" name="File1"
													runat="server"></TD>
										</TR>
									</TABLE>
								</TD>
								<TD style="HEIGHT: 30px">
									<asp:RequiredFieldValidator id="RFVLink" runat="server" ErrorMessage="Enter Link to visit" ControlToValidate="PR_Img"></asp:RequiredFieldValidator></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 255px">Show</TD>
								<TD style="WIDTH: 5px">:</TD>
								<TD>
									<asp:CheckBox id="chkShowPressRelease" runat="server"></asp:CheckBox></TD>
								<TD></TD>
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
