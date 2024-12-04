<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Testimonial.ascx.vb" Inherits="Trade.Testimonial" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR>
		<TD align="center"><IFRAME style="WIDTH: 470px; HEIGHT: 60px" name="IfAdv" align="middle" src="HTMLPages/Ad_Testimonials.htm"
				frameBorder="0" scrolling="no"></IFRAME>
		</TD>
	</TR>
</TABLE>
<br>
<div align="center">
	<TABLE id="Table2" cellSpacing="2" cellPadding="2" width="650" border="0">
		<TR>
			<TD style="BORDER-RIGHT: #a5d1fe 1px solid; BORDER-TOP: #a5d1fe 1px solid; BORDER-LEFT: #a5d1fe 1px solid; BORDER-BOTTOM: #a5d1fe 1px solid"
				id="TDView" runat="server">
				<asp:DataList id="DLTestimonial" runat="server" Width="100%">
					<AlternatingItemStyle BackColor="#EEEEEE"></AlternatingItemStyle>
					<ItemTemplate>
						<TABLE class="normaltext" id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD colSpan="2">
									<asp:Label id="lblText" runat="server" ForeColor="#0000C0">
										<%# DataBinder.Eval(Container, "DataItem.TText") %>
									</asp:Label></TD>
							</TR>
							<TR>
								<TD class="normaltext" width="79%">
									<asp:Label id="lblMemberName" runat="server" ForeColor="Blue" Font-Bold="True">
										<%# DataBinder.Eval(Container, "DataItem.Member_Company") & " - " & DataBinder.Eval(Container, "DataItem.Country_Name") %>
									</asp:Label></TD>
								<TD align="right" width="21%">
									<asp:Label id="lblPostedOn" runat="server" Visible="False" ForeColor="black" Font-Bold="True"
										Font-Size="7pt">
										<%# DataBinder.Eval(Container, "DataItem.TestimonialDateTime") %>
									</asp:Label></TD>
							</TR>
							<TR>
								<TD colSpan="2">&nbsp;&nbsp;
								</TD>
							</TR>
						</TABLE>
					</ItemTemplate>
				</asp:DataList></TD>
		</TR>
		<TR>
			<TD id="TDAction" runat="server"><br>
				<TABLE id="tbl_Action" cellSpacing="1" cellPadding="1" width="100%" border="0" class="normaltext">
					<TR>
						<TD width="149" class="normaltext"></TD>
						<TD width="7">&nbsp;</TD>
						<TD width="352">
							<asp:TextBox id="tbtestomonial" class="box" Visible="false" Width="350px" runat="server" MaxLength="1000"
								TextMode="MultiLine" Height="45px"></asp:TextBox></TD>
						<TD width="130">
							<asp:RequiredFieldValidator id="RFVText" runat="server" Visible="false" ControlToValidate="tbtestomonial" ErrorMessage="Enter Text to Shown"
								Display="Dynamic"></asp:RequiredFieldValidator></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 149px"></TD>
						<TD style="WIDTH: 7px"></TD>
						<TD>
							<asp:ImageButton id="imgSave" runat="server" ImageUrl="../images/icon-floppy.gif" Visible="false"
								EnableViewState="False"></asp:ImageButton>&nbsp;
							<asp:ImageButton id="imgCancel" runat="server" ImageUrl="../images/icon-cancel.gif" CausesValidation="False"
								Visible="false" EnableViewState="False"></asp:ImageButton>
							<asp:TextBox id="tbid" runat="server" Visible="False"></asp:TextBox></TD>
						<TD></TD>
					</TR>
				</TABLE>
			</TD>
		</TR>
	</TABLE>
</div>
