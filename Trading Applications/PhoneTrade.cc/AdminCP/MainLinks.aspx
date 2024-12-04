<%@ Page Language="vb" AutoEventWireup="false" Codebehind="MainLinks.aspx.vb" Inherits="Trade.Admin.MainLinks"%>
<%@ Register TagPrefix="uc1" TagName="MenuControl" Src="MenuControl.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Main Links</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="1">
				<TR>
					<TD style="HEIGHT: 21px" align="left">
						<uc1:MenuControl id="CMenu" runat="server"></uc1:MenuControl></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 21px" align="center"><asp:label id="lblMessage" runat="server">News</asp:label></TD>
				</TR>
				<TR>
					<TD id="TDHeader" style="HEIGHT: 21px" runat="server"><asp:imagebutton id="ImgNew" runat="server" CausesValidation="False" AlternateText="New" ImageUrl="../images/icon-pencil.gif"></asp:imagebutton>&nbsp;</TD>
				</TR>
				<TR>
					<TD id="TDView" runat="server"><asp:datagrid id="DGMainLinks" runat="server" Width="100%" AutoGenerateColumns="False" AllowPaging="True">
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
								<asp:TemplateColumn HeaderText="Layout">
									<ItemTemplate>
										<asp:HyperLink id="Hlnklayout" runat="server" NavigateUrl ='<%# "LinkLayout.aspx?main_Link_ID=" & DataBinder.Eval(Container, "DataItem.Main_Links_ID") %>' ImageUrl="../images/icon-Edit.gif">
										</asp:HyperLink>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="main_links_id" HeaderText="ID"></asp:BoundColumn>
								<asp:BoundColumn DataField="link_name" HeaderText="Link name"></asp:BoundColumn>
								<asp:BoundColumn DataField="link_open_type" HeaderText="Open type"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Show">
									<ItemTemplate>
										<asp:CheckBox id=chkShow runat="server" Checked='<%# DataBinder.Eval(Container, "DataItem.Show_Flag") %>' Enabled="False">
										</asp:CheckBox>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Position">
									<ItemTemplate>
										<asp:Label id="Position" runat="server">
											<%# iif(DataBinder.Eval(Container, "DataItem.Row_Position")=1,"Top Links 1",iif(DataBinder.Eval(Container, "DataItem.Row_Position")=2,"Top Links 2","Bottom Links 3")) %>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="Redirect_Main_Link_ID" HeaderText="Redirect To">
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Redirect_Main_Link" HeaderText="Redirect Link To"></asp:BoundColumn>
								<asp:BoundColumn DataField="Links_Seq" HeaderText="Position Seq.">
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:Image id="Img" visible='<%# DataBinder.Eval(Container, "DataItem.Visible") %>' runat="server" ImageUrl='<%# "..\" & DataBinder.Eval(Container, "DataItem.Img_url") %>'>
										</asp:Image><BR>
										<asp:Image id="ImgUrl" visible='<%# DataBinder.Eval(Container, "DataItem.Visible") %>' runat="server" ImageUrl='<%# "..\" & DataBinder.Eval(Container, "DataItem.Img_url_MouseOver") %>' >
										</asp:Image>
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
								<TD style="WIDTH: 195px; HEIGHT: 20px">Main link ID</TD>
								<TD style="WIDTH: 5px; HEIGHT: 20px">:</TD>
								<TD style="WIDTH: 270px; HEIGHT: 20px"><asp:textbox id="tbMainLinkID" runat="server" ReadOnly="True"></asp:textbox></TD>
								<TD style="HEIGHT: 20px"></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 195px; HEIGHT: 41px">Link Name (used to show&nbsp;if image is not 
									specified )</TD>
								<TD style="WIDTH: 5px; HEIGHT: 41px">:</TD>
								<TD style="WIDTH: 270px; HEIGHT: 41px"><asp:textbox id="tbLinkName" runat="server" Width="206px"></asp:textbox></TD>
								<TD style="HEIGHT: 41px"><asp:requiredfieldvalidator id="RFVLinkName" runat="server" ErrorMessage="Enter Link Name" ControlToValidate="tbLinkName"></asp:requiredfieldvalidator></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 195px; HEIGHT: 1px">Link Open Type</TD>
								<TD style="WIDTH: 5px; HEIGHT: 1px">:</TD>
								<TD style="WIDTH: 270px; HEIGHT: 1px"><asp:dropdownlist id="ddlLinkOpenType" runat="server" Width="158px">
										<asp:ListItem Value="_Self" Selected="True">_Self</asp:ListItem>
										<asp:ListItem Value="_Blank">_Blank</asp:ListItem>
									</asp:dropdownlist></TD>
								<TD style="HEIGHT: 1px"></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 195px; HEIGHT: 31px">Image URL</TD>
								<TD style="WIDTH: 5px; HEIGHT: 31px">:</TD>
								<TD style="WIDTH: 270px; HEIGHT: 31px">
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
								<TD style="HEIGHT: 31px"></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 195px; HEIGHT: 38px">Image mouser Over URL&nbsp;</TD>
								<TD style="WIDTH: 5px; HEIGHT: 38px"></TD>
								<TD style="WIDTH: 270px; HEIGHT: 38px">
									<TABLE id="Table3" style="WIDTH: 246px; HEIGHT: 67px" cellSpacing="1" cellPadding="1" width="246"
										border="1">
										<TR>
											<TD id="TD_MImg" runat="server"><asp:image id="ImgMouseOverUrl" runat="server"></asp:image></TD>
										</TR>
										<TR>
											<TD id="TD_Image_MUrl_Br" runat="server"><INPUT id="Img_Mouse_Over_Url_path" style="WIDTH: 238px; HEIGHT: 22px" type="file" size="20"
													name="File1" runat="server"></TD>
										</TR>
									</TABLE>
								</TD>
								<TD style="HEIGHT: 38px"></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 195px; HEIGHT: 2px">Row Position</TD>
								<TD style="WIDTH: 5px; HEIGHT: 2px"></TD>
								<TD style="WIDTH: 270px; HEIGHT: 2px"><asp:dropdownlist id="ddlRowPosition" runat="server" Width="168px">
										<asp:ListItem Value="1" Selected="True">Top Link Row 1</asp:ListItem>
										<asp:ListItem Value="2">Top Link Row 2</asp:ListItem>
										<asp:ListItem Value="3">Footer Link 1</asp:ListItem>
									</asp:dropdownlist></TD>
								<TD style="HEIGHT: 2px"></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 195px; HEIGHT: 3px">Link Seq</TD>
								<TD style="WIDTH: 5px; HEIGHT: 3px"></TD>
								<TD style="WIDTH: 270px; HEIGHT: 3px"><asp:textbox id="tbSeqNo" runat="server" Width="56px"></asp:textbox>(e.g. 
									01)</TD>
								<TD style="HEIGHT: 3px"><asp:regularexpressionvalidator id="REVtbLinkSeq" runat="server" ErrorMessage="Enter Seq. Number" ValidationExpression="\d{2}"
										ControlToValidate="tbSeqNo"></asp:regularexpressionvalidator></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 195px; HEIGHT: 7px">Redirect To (if any)</TD>
								<TD style="WIDTH: 5px; HEIGHT: 7px"></TD>
								<TD style="WIDTH: 270px; HEIGHT: 7px"><asp:dropdownlist id="ddlRedirectTo" runat="server" Width="222px"></asp:dropdownlist></TD>
								<TD style="HEIGHT: 7px"></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 195px">Show</TD>
								<TD style="WIDTH: 5px">:</TD>
								<TD style="WIDTH: 270px"><asp:checkbox id="chkShowMainLink" runat="server"></asp:checkbox></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 195px"></TD>
								<TD style="WIDTH: 5px"></TD>
								<TD style="WIDTH: 270px"><asp:imagebutton id="imgSave" runat="server" ImageUrl="../images/icon-floppy.gif"></asp:imagebutton>&nbsp;
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
