<%@ Register TagPrefix="uc1" TagName="MenuControl" Src="MenuControl.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="LinkLayout.aspx.vb" Inherits="Trade.LinkLayout"%>
<%@ Register TagPrefix="uc1" TagName="PlaceHolder" Src="../Module/PlaceHolder.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>LinkLayout</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="1">
				<TR>
					<TD style="WIDTH: 457px" align="left" colSpan="3">
						<uc1:MenuControl id="CMenu" runat="server"></uc1:MenuControl></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 457px">
						<asp:Label id="lblMessage" runat="server" ForeColor="Red"></asp:Label></TD>
					<TD align="right" colSpan="2"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 457px">Link ID :
						<asp:label id="lblID" runat="server">Label</asp:label></TD>
					<TD align="right" colSpan="2"><asp:button id="btnSave" runat="server" Text="Save" Width="80px"></asp:button></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 457px">
						<P>Link Name :
							<asp:label id="lblname" runat="server">Label</asp:label></P>
					</TD>
					<TD align="right" colSpan="2"><asp:button id="btnCancel" runat="server" Text="Cancel" Width="80px"></asp:button></TD>
				</TR>
				<TR>
					<TD vAlign="top">
						<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="1">
							<TR>
								<TD colSpan="3"><uc1:placeholder id="PH_Level1" runat="server"></uc1:placeholder></TD>
							</TR>
							<TR>
								<TD><uc1:placeholder id="PH_Level2" runat="server"></uc1:placeholder></TD>
								<TD colSpan="2"><uc1:placeholder id="PH_Level3" runat="server"></uc1:placeholder></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 23px" colSpan="3"><uc1:placeholder id="PH_Level4" runat="server"></uc1:placeholder></TD>
							</TR>
							<TR>
								<TD colSpan="3"><uc1:placeholder id="PH_Level5" runat="server"></uc1:placeholder></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 23px" colSpan="3"><uc1:placeholder id="PH_Level7" runat="server"></uc1:placeholder></TD>
							</TR>
							<TR>
								<TD colSpan="3"><uc1:placeholder id="PH_Level8" runat="server"></uc1:placeholder></TD>
							</TR>
							<TR>
								<TD><uc1:placeholder id="PH_Level9" runat="server"></uc1:placeholder></TD>
								<TD><uc1:placeholder id="PH_Level10" runat="server"></uc1:placeholder></TD>
								<TD><uc1:placeholder id="PH_Level11" runat="server"></uc1:placeholder></TD>
							</TR>
							<TR>
								<TD colSpan="3"><uc1:placeholder id="PH_Level12" runat="server"></uc1:placeholder></TD>
							</TR>
						</TABLE>
					</TD>
					<TD vAlign="top" colSpan="2"><asp:listbox id="ModuleList" runat="server" Width="158px" Rows="25" Height="320px"></asp:listbox></TD>
				</TR>
				<TR>
					<TD vAlign="top" colSpan="3"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
