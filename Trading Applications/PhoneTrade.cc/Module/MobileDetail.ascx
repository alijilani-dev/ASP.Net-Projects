<%@ Control Language="vb" AutoEventWireup="false" Codebehind="MobileDetail.ascx.vb" Inherits="Trade.MobileDetail" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<div align="center">
	<TABLE id="Table8" cellPadding="2" width="650" border="0" class="normaltext" cellspacing="4">
		<TR>
			<TD align="center" style="BORDER-RIGHT: #3f8bd7 1px solid; BORDER-TOP: #3f8bd7 1px solid; BORDER-LEFT: #3f8bd7 1px solid; BORDER-BOTTOM: #3f8bd7 1px solid"
				colspan="2" bgcolor="#3f8bd7" class="boxhdn" height="25">
				<b>&nbsp; </b>
				<asp:Label id="lblDetialModelNo" runat="server" Font-Bold="True">Label</asp:Label></TD>
		</TR>
		<TR>
			<TD align="center" style="BORDER-RIGHT: #3f8bd7 1px solid; BORDER-TOP: #3f8bd7 1px solid; BORDER-LEFT: #3f8bd7 1px solid; BORDER-BOTTOM: #3f8bd7 1px solid"
				width="116">
				<asp:ImageButton id="imgMain" ImageAlign="Middle" runat="server"></asp:ImageButton></TD>
			<TD class="normaltext" style="BORDER-RIGHT: #3f8bd7 1px solid; BORDER-TOP: #3f8bd7 1px solid; BORDER-LEFT: #3f8bd7 1px solid; BORDER-BOTTOM: #3f8bd7 1px solid"
				width="510" valign="top">
				<asp:Label id="lblDetialModel" class="normaltext" EnableViewState="False" runat="server">Label</asp:Label></TD>
		</TR>
		<TR>
			<TD align="center" style="BORDER-RIGHT: #3f8bd7 1px solid; BORDER-TOP: #3f8bd7 1px solid; BORDER-LEFT: #3f8bd7 1px solid; BORDER-BOTTOM: #3f8bd7 1px solid"
				colspan="2">
				<TABLE id="table13" cellSpacing="0" cellPadding="0" width="100%" border="0" class="normaltext">
					<TR>
						<TD width="314" valign="top" class="normaltext">
							<table border="0" width="100%" id="table14" cellpadding="2">
								<tr>
									<td width="98" valign="top" class="normaltext">
										<b>Weight</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblWeight" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>Phone Book</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblPhoneBook" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>Display Info</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblDisplayInfo" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>Custom Tone</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblCustomizeTone" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>Battery Info</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblBatteryInfo" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>GPRS</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblGPRS" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>SMS / Email</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblSMS" EnableViewState="False" runat="server">Label</asp:Label>
										&nbsp;/
										<asp:Label id="lblEmailMsg" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>Clock / Alarm</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblClock" EnableViewState="False" runat="server">Label</asp:Label>
										&nbsp;/
										<asp:Label id="lblAlarm" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>Infrared</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblInfrared" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>Model3G</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblModel3G" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>Mobile Colors</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblMobilecolors" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
							</table>
						</TD>
						<TD valign="top">
							<table border="0" width="100%" id="table15" cellpadding="2">
								<tr>
									<td width="98" valign="top" class="normaltext"><b>Dimension</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblDimension" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>Call Records</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblCallRecord" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>Display Size</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lbldisplaySize" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>Vibration</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblVibration" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>OS Type</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblOSType" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>Data Speed</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblDataSpeed" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>MMS / IM</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblMMS" EnableViewState="False" runat="server">Label</asp:Label>
										&nbsp;/
										<asp:Label id="lblInstantMsg" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>Bluetooth</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblBlueTooth" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>Games</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblGames" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>Camera</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblCamera" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
								<tr>
									<td width="98" valign="top" class="normaltext"><b>Camera Info</b></td>
									<td valign="top" class="normaltext">:
										<asp:Label id="lblCamerainfo" EnableViewState="False" runat="server">Label</asp:Label>
									</td>
								</tr>
							</table>
						</TD>
					</TR>
				</TABLE>
			</TD>
		</TR>
		<TR>
			<TD align="center" style="BORDER-RIGHT: #3f8bd7 1px solid; BORDER-TOP: #3f8bd7 1px solid; BORDER-LEFT: #3f8bd7 1px solid; BORDER-BOTTOM: #3f8bd7 1px solid"
				colspan="2">
				<p align="left"><b>Features </b>:
					<asp:Label id="lblFeatures" EnableViewState="False" runat="server">Label</asp:Label></p>
			</TD>
		</TR>
	</TABLE>
</div>
