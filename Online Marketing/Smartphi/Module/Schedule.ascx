<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Schedule.ascx.vb" Inherits="Smartphi.ScheduleControl" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<P>
	<TABLE id="tblSchedule" runat="server" visible="false"  cellSpacing="1" cellPadding="1"
		width="100%" border="0">
		<TR>
			<TD style="WIDTH: 197px">Schedule the campaign</TD>
			<TD></TD>
		</TR>
		<TR>
			<TD style="WIDTH: 197px">Schedule Date</TD>
			<TD>
				<asp:DropDownList id="ddlMonth" runat="server"></asp:DropDownList>
				<asp:DropDownList id="ddlDay" runat="server" Width="48px"></asp:DropDownList>
				<asp:DropDownList id="ddlYear" runat="server"></asp:DropDownList></TD>
		</TR>
		<TR>
			<TD style="WIDTH: 197px">Schedule Time</TD>
			<TD>
				<asp:DropDownList id="ddlHour" runat="server">
					<asp:ListItem Value="0">0</asp:ListItem>
					<asp:ListItem Value="1">1</asp:ListItem>
					<asp:ListItem Value="2">2</asp:ListItem>
					<asp:ListItem Value="3">3</asp:ListItem>
					<asp:ListItem Value="4">4</asp:ListItem>
					<asp:ListItem Value="5">5</asp:ListItem>
					<asp:ListItem Value="6">6</asp:ListItem>
					<asp:ListItem Value="7">7</asp:ListItem>
					<asp:ListItem Value="8">8</asp:ListItem>
					<asp:ListItem Value="9">9</asp:ListItem>
					<asp:ListItem Value="10">10</asp:ListItem>
					<asp:ListItem Value="11">11</asp:ListItem>
					<asp:ListItem Value="12">12</asp:ListItem>
					<asp:ListItem Value="13">13</asp:ListItem>
					<asp:ListItem Value="14">14</asp:ListItem>
					<asp:ListItem Value="15">15</asp:ListItem>
					<asp:ListItem Value="16">16</asp:ListItem>
					<asp:ListItem Value="17">17</asp:ListItem>
					<asp:ListItem Value="18">18</asp:ListItem>
					<asp:ListItem Value="19">19</asp:ListItem>
					<asp:ListItem Value="20">20</asp:ListItem>
					<asp:ListItem Value="21">21</asp:ListItem>
					<asp:ListItem Value="22">22</asp:ListItem>
					<asp:ListItem Value="23">23</asp:ListItem>
				</asp:DropDownList>
				<asp:DropDownList id="ddlMin" runat="server" Width="48px">
					<asp:ListItem Value="0">0</asp:ListItem>
					<asp:ListItem Value="15">15</asp:ListItem>
					<asp:ListItem Value="30">30</asp:ListItem>
					<asp:ListItem Value="45">45</asp:ListItem>
				</asp:DropDownList></TD>
		</TR>
		<TR>
			<TD style="WIDTH: 197px">Group(s) to which you want to send</TD>
			<TD>
				<asp:ListBox id="lstGroup" runat="server" Width="152px"></asp:ListBox><BR>
				Select multiple groups by holding shift key&nbsp;</TD>
		</TR>
		<TR>
			<TD style="WIDTH: 197px"></TD>
			<TD></TD>
		</TR>
		<TR>
			<TD style="WIDTH: 197px"></TD>
			<TD>
				<asp:Button id="btnSchedule" runat="server" Text="Make Schedule"></asp:Button>&nbsp;</TD>
		</TR>
		<TR>
			<TD style="WIDTH: 197px"></TD>
			<TD></TD>
		</TR>
	</TABLE>
</P>
<TABLE id="tblTest" runat="server" visible="false" cellSpacing="1" cellPadding="1" width="100%"
	border="0">
	<TR>
		<TD style="WIDTH: 156px">Test the campaign</TD>
		<TD></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 156px">Test email id1*</TD>
		<TD>
			<asp:TextBox id="txtEmailID1" runat="server"></asp:TextBox></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 156px">Test email id2</TD>
		<TD>
			<asp:TextBox id="txtEmailID2" runat="server"></asp:TextBox></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 156px">Test email id3</TD>
		<TD>
			<asp:TextBox id="txtEmailID3" runat="server"></asp:TextBox></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 156px"></TD>
		<TD>
			<asp:Button id="btnTest" runat="server" Text="Test now"></asp:Button></TD>
	</TR>
</TABLE>
