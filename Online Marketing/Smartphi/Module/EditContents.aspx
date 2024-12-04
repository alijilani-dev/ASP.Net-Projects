<%@ Page Language="vb" AutoEventWireup="false" Codebehind="EditContents.aspx.vb" Inherits="Smartphi.EditContents" validateRequest="false" %>
<%@ Register TagPrefix="uc1" TagName="Top" Src="Top.ascx" %>
<%@ Register TagPrefix="fckeditorv2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Template</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<base target="_self">
		<script language=javascript>
		function enableupload()
		{
			var chkRemoveImg = document.frmContents.uplImagePath;
			if(chkRemoveImg.disabled)
				chkRemoveImg.disabled = false;
			else
				chkRemoveImg.disabled = true;
		}
		</script>
	</HEAD>
	<body bottomMargin="0" leftMargin="0" topMargin="0" rightMargin="0" MS_POSITIONING="GridLayout">
		<table id="Template" cellSpacing="0" cellPadding="0" width="100%" align="left" bgColor="#ffffff"
			border="0" runat="server">
			<tr id="Middle" runat="server">
				<td style="BORDER-RIGHT: #dedede 1px solid; BORDER-LEFT: #dedede 1px solid">
					<TABLE id="table6" cellSpacing="4" cellPadding="4" width="100%" border="0">
						<TR>
							<TD>
								<DIV align="center">
									<TABLE id="table7" cellSpacing="1" cellPadding="0" width="90%" border="0">
										<TR>
											<TD>&nbsp;
											</TD>
										</TR>
										<TR>
											<TD>
												<TABLE id="table9" cellSpacing="0" cellPadding="0" width="100%" bgColor="#ffdfe4" border="0">
												</TABLE>
												<INPUT id="myHiddenField" type="hidden" value="text">
											</TD>
										</TR>
										<TR>
											<TD>
												<form id="frmContents" method="post" runat="server">
													<asp:label id="lblMsg" runat="server" Font-Size="Smaller" Font-Names="Verdana" ForeColor="Red"></asp:label>
													<TABLE id="tblText" cellSpacing="1" cellPadding="1" width="100%" border="0" runat="server">
														<TR>
															<TD width="132" bgColor="#ffdfe4" colSpan="2">Describe your Links</TD>
														</TR>
														<TR>
															<TD width="132"></TD>
															<TD></TD>
														</TR>
														<TR>
															<TD width="132">Text&nbsp;:</TD>
															<TD><asp:textbox id="txtTextValue" runat="server" MaxLength="5000" Width="100%"></asp:textbox></TD>
														</TR>
														<TR>
															<TD width="132"></TD>
															<TD></TD>
														</TR>
														<TR>
															<TD width="132"></TD>
															<TD><asp:button id="btnSubmitText" runat="server" Text="Update Parameter"></asp:button><asp:button id="btnUpdateText" runat="server" Text="Update Value"></asp:button>&nbsp;
																<asp:button id="btnCancelText" runat="server" Text="Cancel"></asp:button></TD>
														</TR>
													</TABLE>
													<TABLE id="tblContent" cellSpacing="0" cellPadding="0" width="100%" background="../images/bg_cell.gif"
														border="0" runat="server">
														<TR>
															<TD class="boxhdn" width="99%" bgColor="#ffdfe4" height="21">&nbsp;Edit Template 
																content</TD>
														</TR>
														<TR>
															<TD height="3">
																<TABLE class="normaltext" id="tblEditor" cellSpacing="1" width="100%" border="0" runat="server">
																	<TR>
																		<TD style="WIDTH: 60%; HEIGHT: 24px" align="center"><FCKEDITORV2:FCKEDITOR id="txtEditor" runat="server" Width="100%" ToolbarSet="MyToolbar" BasePath="~/FCKeditor/"
																				Height="250px"></FCKEDITORV2:FCKEDITOR><BR>
																			<asp:button id="btnSubmitContent" runat="server" Text="Update Parameter"></asp:button><asp:button id="btnUpdateContent" runat="server" Text="Update Value"></asp:button>&nbsp;
																			<asp:button id="btnCancelContent" runat="server" Text="Cancel"></asp:button></TD>
																	</TR>
																</TABLE>
															</TD>
														</TR>
													</TABLE>
													<TABLE id="tblLinks" cellSpacing="1" cellPadding="1" width="100%" border="0" runat="server">
														<TR>
															<TD style="WIDTH: 132px" width="132" bgColor="#ffdfe4" colSpan="2">Describe your 
																Links</TD>
														</TR>
														<TR>
															<TD style="WIDTH: 132px" width="132"></TD>
															<TD></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 132px" width="132">URL : {http://}</TD>
															<TD><asp:textbox id="txtLinkURL" runat="server" Width="100%"></asp:textbox></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 132px" width="132">Anchor Text :</TD>
															<TD><asp:textbox id="txtLinkText" runat="server" MaxLength="10000" Width="100%"></asp:textbox></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 132px" width="132"></TD>
															<TD></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 132px" width="132"></TD>
															<TD><asp:button id="btnSubmitLink" runat="server" Text="Update Parameter"></asp:button><asp:button id="btnUpdateLink" runat="server" Text="Update Value"></asp:button>&nbsp;
																<asp:button id="btnCancelLink" runat="server" Text="Cancel"></asp:button></TD>
														</TR>
													</TABLE>
													<TABLE id="tblImagePath" cellSpacing="1" cellPadding="1" width="100%" border="0" runat="server">
														<TR>
															<TD style="WIDTH: 132px; HEIGHT: 21px" width="132" bgColor="#ffdfe4" colSpan="2">
																Describe&nbsp;the Image</TD>
														</TR>
														<TR>
															<TD style="WIDTH: 132px" width="132" colSpan="2"></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 132px" width="132">Select Image path
															</TD>
															<TD><INPUT id="uplImagePath" dir="ltr" type="file" runat="server">&nbsp;</TD>
														</TR>
														<TR>
															<TD style="WIDTH: 132px" width="132"></TD>
															<TD>
																<asp:CheckBox id="chkRemoveImage" runat="server" Text="Remove Image"></asp:CheckBox></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 132px" width="132"></TD>
															<TD><asp:button id="btnSubmitImagePath" runat="server" Text="Update Parameter"></asp:button><asp:button id="btnUpdateImage" runat="server" Text="Update Value"></asp:button>&nbsp;
																<asp:button id="btnCancelImagePath" runat="server" Text="Cancel"></asp:button></TD>
														</TR>
													</TABLE>
												</form>
											</TD>
										</TR>
									</TABLE>
								</DIV>
							</TD>
						</TR>
					</TABLE>
				</td>
			</tr>
		</table>
	</body>
</HTML>
