<%@ Control Language="vb" AutoEventWireup="false" Codebehind="MenuControl.ascx.vb" Inherits="Trade.MenuControl" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="0" style="HEIGHT: 51px">
	<TR>
		<TD colSpan="8" bgColor="#eeeeee" height="80">
			<P align="center"><STRONG>Welcome Administrator </STRONG>
				<asp:LinkButton id="lnkButLogOut" runat="server" CausesValidation="False">Log Out</asp:LinkButton><STRONG>&nbsp;&nbsp;</STRONG></P>
		</TD>
	</TR>
	<TR>
		<TD style="WIDTH: 85px; HEIGHT: 21px" align="center">
			<asp:hyperlink id="hlnkNews" NavigateUrl="..\adminCP\news.aspx" Target="_self" runat="server" Width="40px">News</asp:hyperlink></TD>
		<TD style="HEIGHT: 21px" align="center">
			<asp:hyperlink id="hlnkCountry" runat="server" Width="48px" Target="_self" NavigateUrl="..\adminCP\Country.aspx">Country</asp:hyperlink></TD>
		<TD style="HEIGHT: 21px" align="center">
			<asp:hyperlink id="hlnkTestimonial" NavigateUrl="..\adminCP\Testimonials.aspx" Target="_self" runat="server"
				Width="80px">Testimonials</asp:hyperlink></TD>
		<TD style="HEIGHT: 21px" align="center">
			<asp:hyperlink id="hlnkMainlinks" runat="server" Width="72px" Target="_self" NavigateUrl="..\adminCP\MainLinks.aspx">Main Links</asp:hyperlink></TD>
		<TD style="HEIGHT: 21px" align="center">
			<asp:hyperlink id="hlnkMobileReview" runat="server" Width="102px" Target="_self" NavigateUrl="..\adminCP\MobileReviews.aspx">Mobile Reviews</asp:hyperlink></TD>
		<TD style="WIDTH: 105px; HEIGHT: 21px" align="center">
			<asp:hyperlink id="hlnkPr" runat="server" Width="91px" Target="_self" NavigateUrl="..\adminCP\PressReleases.aspx">Press Releases</asp:hyperlink></TD>
		<TD style="HEIGHT: 21px" align="center">
			<asp:hyperlink id="hlnkMembers" runat="server" Width="96px" Target="_self" NavigateUrl="..\adminCP\MemberDetails.aspx">MemberDetails</asp:hyperlink></TD>
		<TD style="HEIGHT: 21px" align="center">
			<asp:hyperlink id="hlnkAdvertisement" runat="server" Width="96px" Target="_self" NavigateUrl="..\adminCP\Advertisement.aspx">Advertisement</asp:hyperlink></TD>
	</TR>
</TABLE>
