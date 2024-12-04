<%@ Control Language="vb" AutoEventWireup="false" Codebehind="SiteLinks.ascx.vb" Inherits="Trade.SiteLinks" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<table width="100%" bgColor="#215992" border="0">
	<TR>
		<td><IMG height="27" src="images/globe.gif" width="43" border="0"></td>
	</TR>
	<TR>
		<TD width="43" height="27" rowSpan="6"><IMG height="27" alt="" src="images/top_linkspane1_1_.jpg" width="43" border="0"></TD>
		<TD width="54" height="4"><IMG height="4" alt="" src="images/top_linkspane2_1_.jpg" width="54" border="0"></TD>
		<TD width="6" height="27" rowSpan="6"><IMG height="27" alt="" src="images/top_linkspane3_1_.jpg" width="6" border="0"></TD>
		<TD width="5" height="4"><IMG height="4" alt="" src="images/top_linkspane4_1_.jpg" width="5" border="0"></TD>
		<TD width="7" height="27" rowSpan="6"><IMG height="27" alt="" src="images/top_linkspane5_1_.jpg" width="7" border="0"></TD>
		<TD width="68" height="4"><IMG height="4" alt="" src="images/top_linkspane6_1_.jpg" width="68" border="0"></TD>
		<TD width="100%" height="27" rowSpan="6">
			<TABLE id="table3" height="27" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD width="14" height="27"><IMG height="27" src="images/top_links_left.jpg" width="14" border="0" name="Image10"></TD>
					<TD width="100%" background="images/top_links_centre.jpg" height="27">&nbsp;</TD>
					<TD width="20" height="27"><IMG height="27" src="images/top_links_right.jpg" width="20" border="0" name="Image12"></TD>
				</TR>
			</TABLE>
		</TD>
		<TD width="9" height="4"><IMG height="4" alt="" src="images/top_linkspane8_1_.jpg" width="9" border="0"></TD>
		<TD width="20" height="27" rowSpan="6"><IMG height="27" alt="" src="images/top_linkspane9_1_.jpg" width="20" border="0"></TD>
		<TD width="10" height="10" rowSpan="3"><IMG height="10" alt="" src="images/top_linkspane10_1_.jpg" width="10" border="0"></TD>
		<TD width="21" height="27" rowSpan="6"><IMG height="27" alt="" src="images/top_linkspane11_1_.jpg" width="21" border="0"></TD>
		<TD width="11" height="9" rowSpan="2"><IMG height="9" alt="" src="images/top_linkspane12_1_.jpg" width="11" border="0"></TD>
		<TD width="19" height="27" rowSpan="6"><IMG height="27" alt="" src="images/top_linkspane13_1_.jpg" width="19" border="0"></TD>
	</TR>
	<tr>
		<!-- ############################################################## --
		<td>
			<asp:datalist id="DLSiteLinks" EnableViewState="False" runat="server" RepeatDirection="Horizontal"
				RepeatColumns="3">
				<ItemTemplate>
					<asp:HyperLink id=HyperLink1 runat="server" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.portal_url") %>' ImageUrl='<%# "../" &amp; DataBinder.Eval(Container, "DataItem.portal_img_url") %>' Text='<%# DataBinder.Eval(Container, "DataItem.portal_name") %>'>
					</asp:HyperLink>
				</ItemTemplate>
			</asp:datalist>
		</td>
		-- ############################################################## -->
	</tr>
	<TR>
		<TD width="9" height="1"><IMG height="1" alt="" src="images/top_linkspane8_3_.jpg" width="9" border="0"></TD>
		<TD width="11" height="11" rowSpan="2"><A onmouseover="changeImages(/*CMP*/ 'object3', /*URL*/ 'images/top_linksimageov.jpg'); return true;"
				onmouseout="changeImages(/*CMP*/ 'object3', /*URL*/ 'images/top_linksimage.jpg'); return true;" href="javascript:;"><IMG height="11" alt="" src="images/top_linksimage.jpg" width="11" border="0" name="object3"></A></TD>
	</TR>
	<TR>
		<TD width="9" height="10"><A onmouseover="changeImages(/*CMP*/ 'object4', /*URL*/ 'images/top_linksimage1ov.jpg'); return true;"
				onmouseout="changeImages(/*CMP*/ 'object4', /*URL*/ 'images/top_linksimage1.jpg'); return true;" href="../Default.aspx"><IMG height="10" alt="" src="images/top_linksimage1.jpg" width="9" border="0" name="object4"></A></TD>
		<TD width="10" height="10"><A onmouseover="changeImages(/*CMP*/ 'object5', /*URL*/ 'images/top_linksimage2ov.jpg'); return true;"
				onmouseout="changeImages(/*CMP*/ 'object5', /*URL*/ 'images/top_linksimage2.jpg'); return true;" href="javascript:;"><IMG height="10" alt="" src="images/top_linksimage2.jpg" width="10" border="0" name="object5"></A></TD>
	</TR>
	<TR>
		<TD width="9" height="6"><IMG height="6" alt="" src="images/top_linkspane8_5_.jpg" width="9" border="0"></TD>
		<TD width="10" height="7" rowSpan="2"><IMG height="7" alt="" src="images/top_linkspane10_5_.jpg" width="10" border="0"></TD>
		<TD width="11" height="7" rowSpan="2"><IMG height="7" alt="" src="images/top_linkspane12_5_.jpg" width="11" border="0"></TD>
	</TR>
	<TR>
		<TD width="54" height="1"><IMG height="1" alt="" src="images/top_linkspane2_6_.jpg" width="54" border="0"></TD>
		<TD width="5" height="1"><IMG height="1" alt="" src="images/top_linkspane4_6_.jpg" width="5" border="0"></TD>
		<TD width="68" height="1"><IMG height="1" alt="" src="images/top_linkspane6_6_.jpg" width="68" border="0"></TD>
		<TD width="9" height="1"><IMG height="1" alt="" src="images/top_linkspane8_6_.jpg" width="9" border="0"></TD>
	</TR>
</table>
