<%@ Control Language="vb" AutoEventWireup="false" Codebehind="TrackReport.ascx.vb" Inherits="Smartphi.TrackReport" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE class="txt" id="Table1" cellSpacing="3" cellPadding="3" width="500" align="center"
	border="0">
	<TR>
		<TD class="hdnnews" colSpan="2">Track Reports
		</TD>
	</TR>
	<TR>
		<TD colSpan="2">
			<p dir="ltr">Select Campaign Name or Date or both of the option to generate report</p>
		</TD>
	</TR>
	<TR>
		<TD noWrap width="29%"><b>Campaign Name:</b></TD>
		<TD width="71%"><asp:dropdownlist class="txt" id="ddlCampaign" DataValueField="CampaignID" DataTextField="CampaignName"
				runat="server" AutoPostBack="True"></asp:dropdownlist></TD>
	</TR>
	<TR>
		<TD><b>Date:</b></TD>
		<TD width="71%"><asp:dropdownlist class="txt" id="ddlDate" DataValueField="ScheduledDateTime" DataTextField="DisplayDateTime"
				runat="server" DataTextFormatString="{0:dd-MMM-yyyy hh:mm}"></asp:dropdownlist>
			
		</TD>
	</TR>
	<TR>
		<TD></TD>
		<TD width="71%"><asp:button id="btnGenReport" runat="server" Text="Generate Report" CSSclass="button" CausesValidation="False"
				EnableViewState="False"></asp:button> </TD>
	</TR>
</TABLE>
<BR>
<%
nDuplicateCounter = 0
Try
If (dsReport.Tables(0).Rows.Count > 0) Then
	For nCounter = 0 to dsReport.Tables(0).Rows.Count - 1
		drReport = dsReport.Tables(0).Rows(nCounter)

		If (nCounter>0)Then
			If(drReportPrev!CampaignName = drReport!CampaignName) Then 
				nDuplicateCounter = nDuplicateCounter + 1
			End If
			If(drReportPrev!Schedule = drReport!Schedule) Then
				nDuplicateCounter = nDuplicateCounter + 1
			End If
			If(drReportPrev!DateCreated = drReport!DateCreated) Then
				nDuplicateCounter = nDuplicateCounter + 1
			End If
			If(drReportPrev!ScheduledDateTime = drReport!ScheduledDateTime) Then
				nDuplicateCounter = nDuplicateCounter + 1
			End If
			If(drReportPrev!GroupNames = drReport!GroupNames) Then
				nDuplicateCounter = nDuplicateCounter + 1
			End If
			If(drReportPrev!Subject = drReport!Subject) Then
				nDuplicateCounter = nDuplicateCounter + 1
			End If
		End If

		If ( nDuplicateCounter <= 3 ) Then 
%>
<div align="center">
	<TABLE class="txt" id="Table2" style="BORDER-RIGHT: #aaccff 1px solid; BORDER-TOP: #aaccff 1px solid; BORDER-LEFT: #aaccff 1px solid; BORDER-BOTTOM: #aaccff 1px solid"
		cellSpacing="2" cellPadding="2" width="500" border="0">
		<TR>
			<TD class="gridhead" colSpan="3">
				<strong>Campaign Name:<%= drReport!CampaignName %></strong>
			</TD>
		</TR>
		<TR>
			<TD style="WIDTH: 169px"><strong>Date Created:</strong></TD>
			<TD style="WIDTH: 1px">:</TD>
			<TD><%= drReport!DateCreated %></TD>
		</TR>
		<TR>
			<TD><strong>Scheduled Date Time:</strong></TD>
			<TD>:</TD>
			<TD><%= drReport!ScheduledDateTime %></TD>
		</TR>
		<TR>
			<TD><strong>Subject:</strong></TD>
			<TD>:</TD>
			<TD><%= drReport!Subject %></TD>
		</TR>
		<TR>
			<TD><strong>Sent By:</strong></TD>
			<TD>:</TD>
			<TD><%= drReport!MemberName %></TD>
		</TR>
		<TR>
			<TD><strong>Contact Person:</strong></TD>
			<TD>:</TD>
			<TD><%= drReport!ContactPerson %></TD>
		</TR>
		<TR>
			<TD><strong>Mails Sent:</strong></TD>
			<TD>:</TD>
			<TD><%= drReport!MailCount %></TD>
		</TR>
		<TR>
			<TD><strong>Group Name:</strong></TD>
			<TD>:</TD>
			<TD><a href='DeliveryReport.aspx?schedule=<%=drReport!Schedule%>&amp;campaign=<%=drReport!GUIDNo%>'><%= drReport!GroupNames %></a>
			</TD>
		</TR>
	</TABLE>
</div>
<br>
<%

		End If
		nDuplicateCounter = 0
		drReportPrev = drReport
	Next
Else
	Response.Write ("<font color='Red'><p align='center'>No matching record found.</p></font>")
End If

Catch ex As Exception
	Response.Write (ex.Message)

End Try

%>
<BR>
<asp:datagrid id="dgReports" runat="server" Visible="False"></asp:datagrid>
