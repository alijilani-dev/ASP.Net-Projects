<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Advertisement.aspx.vb" Inherits="Trade.Admin.Advertisement"%>
<%@ Register TagPrefix="uc1" TagName="MenuControl" Src="MenuControl.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Advertisement</title>
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
					<TD style="HEIGHT: 21px" align="center"><asp:label id="lblMessage" runat="server">Advertisement</asp:label></TD>
				</TR>
				<TR>
					<TD id="TDHeader" style="HEIGHT: 21px" runat="server"><asp:imagebutton id="ImgNew" runat="server" ImageUrl="../images/icon-pencil.gif" AlternateText="New"
							CausesValidation="False"></asp:imagebutton>&nbsp;</TD>
				</TR>
				<TR>
					<TD id="TDView" runat="server"><asp:datagrid id="DGAdvertisement" runat="server" Width="100%" AllowPaging="True" AutoGenerateColumns="False">
							<AlternatingItemStyle CssClass="normaltext" VerticalAlign="Middle" BackColor="#F3F7FC"></AlternatingItemStyle>
							<ItemStyle CssClass="normaltext" VerticalAlign="Middle" BackColor="#E5EFF9"></ItemStyle>
							<HeaderStyle CssClass="normalbold" BackColor="Silver"></HeaderStyle>
							<Columns>
								<asp:TemplateColumn Visible="False">
									<ItemTemplate>
										<asp:ImageButton id="ImgDelete" runat="server" CommandName="Delete" CausesValidation="false" ImageUrl="../images/icon-delete.gif"></asp:ImageButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Edit">
									<ItemTemplate>
										<asp:ImageButton id="ImageButton3" runat="server" CommandName="Select" CausesValidation="false" ImageUrl="../images/icon-Edit.gif"></asp:ImageButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="advert_id" HeaderText="ID"></asp:BoundColumn>
								<asp:BoundColumn DataField="member_company" HeaderText="Member Company"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Image Url">
									<ItemTemplate>
										<asp:Image id="Img" runat="server" ImageUrl='<%# "..\" & DataBinder.Eval(Container, "DataItem.advert_image_url") %>'>
										</asp:Image>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="advert_alt_text" HeaderText="Image Alternate Text"></asp:BoundColumn>
								<asp:BoundColumn DataField="advert_priority" HeaderText="Priority">
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="advert_type" HeaderText="Type"></asp:BoundColumn>
								<asp:BoundColumn DataField="ad_Position" HeaderText="Position">
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
							</Columns>
							<PagerStyle Mode="NumericPages"></PagerStyle>
						</asp:datagrid></TD>
				</TR>
				<TR>
					<TD id="TDAction" runat="server">
						<TABLE id="tbl_Action" cellSpacing="1" cellPadding="1" width="100%" border="1">
							<TR>
								<TD>Advertisement&nbsp;ID</TD>
								<TD>:</TD>
								<TD><asp:textbox id="tbAd_ID" runat="server" ReadOnly="True"></asp:textbox></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD>Select Member</TD>
								<TD>:</TD>
								<TD><asp:dropdownlist id="ddlMember" runat="server" Width="152px"></asp:dropdownlist></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD>Image URL</TD>
								<TD>:</TD>
								<TD>
									<TABLE id="Table2" style="WIDTH: 231px; HEIGHT: 67px" cellSpacing="1" cellPadding="1" width="231"
										border="1">
										<TR>
											<TD id="TD_Img" runat="server"><asp:image id="Img_Url" runat="server"></asp:image></TD>
										</TR>
										<TR>
											<TD id="TD_Image_Url_Br" runat="server"><INPUT id="Img_Url_path" style="WIDTH: 238px; HEIGHT: 22px" type="file" size="20" name="File1"
													runat="server"></TD>
										</TR>
									</TABLE>
								</TD>
								<TD></TD>
							</TR>
							<TR>
								<TD>Image Alternate Text</TD>
								<TD>:</TD>
								<TD><asp:textbox id="tbAlternate_Text" runat="server"></asp:textbox></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD>Priority Seq.</TD>
								<TD>:</TD>
								<TD><asp:textbox id="tbSeqNo" runat="server" Width="56px"></asp:textbox>(e.g. 01)</TD>
								<TD><asp:regularexpressionvalidator id="REVtbLinkSeq" runat="server" ControlToValidate="tbSeqNo" ErrorMessage="Enter Seq. Number"
										ValidationExpression="\d{2}"></asp:regularexpressionvalidator></TD>
							</TR>
							<TR>
								<TD>Type of Advertisement</TD>
								<TD>:</TD>
								<TD><asp:dropdownlist id="ddlAdType" runat="server" Width="222px">
										<asp:ListItem Value="1" Selected="True">GENERAL</asp:ListItem>
										<asp:ListItem Value="2">SINGLE</asp:ListItem>
									</asp:dropdownlist></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD>Ad Position</TD>
								<TD>:</TD>
								<TD><asp:dropdownlist id="ddlPosition" runat="server" Width="222px">
										<asp:ListItem Value="LEVEL1">LEVEL1</asp:ListItem>
										<asp:ListItem Value="LEVEL2">LEVEL2</asp:ListItem>
										<asp:ListItem Value="LEVEL3">LEVEL3</asp:ListItem>
										<asp:ListItem Value="LEVEL4">LEVEL4</asp:ListItem>
										<asp:ListItem Value="LEVEL5">LEVEL5</asp:ListItem>
										<asp:ListItem Value="LEVEL6">LEVEL6</asp:ListItem>
										<asp:ListItem Value="LEVEL7">LEVEL7</asp:ListItem>
										<asp:ListItem Value="LEVEL8" Selected="True">LEVEL8</asp:ListItem>
										<asp:ListItem Value="LEVEL9">LEVEL9</asp:ListItem>
										<asp:ListItem Value="LEVEL10">LEVEL10</asp:ListItem>
										<asp:ListItem Value="LEVEL11">LEVEL11</asp:ListItem>
										<asp:ListItem Value="LEVEL12">LEVEL12</asp:ListItem>
									</asp:dropdownlist>
								</TD>
								<TD></TD>
							</TR>
							<TR>
								<TD></TD>
								<TD></TD>
								<TD><asp:imagebutton id="imgSave" runat="server" ImageUrl="../images/icon-floppy.gif"></asp:imagebutton>&nbsp;
									<asp:imagebutton id="imgCancel" runat="server" ImageUrl="../images/icon-cancel.gif" CausesValidation="False"></asp:imagebutton></TD>
								<TD></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
