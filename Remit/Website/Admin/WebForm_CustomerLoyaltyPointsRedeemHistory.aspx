<%@ Page language="c#" Codebehind="WebForm_CustomerLoyaltyPointsRedeemHistory.aspx.cs" AutoEventWireup="false" Inherits="Evernet.MoneyExchange.Web.Forms.WebForm_CustomerLoyaltyPointsRedeemHistory" %>
<%@ Register TagPrefix="DropDownLists" Namespace="Evernet.MoneyExchange.Web.DropDownLists" Assembly="mexchange" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
	<head>
		<title>CustomerLoyaltyPointsRedeemHistory table content management</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link href="StyleSheet.css" type="text/css" rel="stylesheet">
	</head>
	<body class="FormStyle">
		<asp:panel id="ErrorDisplay" runat="server" visible="false">
			<asp:Label id="lab_Error" runat="server" CssClass="ErrorDisplayStyle"></asp:Label>
		</asp:panel>
		<asp:HyperLink id="ReturnURL" runat="server" CssClass="EditHyperLink" EnableViewState="true" Visible="false" NavigateUrl="" Text="Return">
		</asp:HyperLink>
		<asp:panel id="MainDisplay" runat="server">
			<form id="WebForm_CustomerLoyaltyPointsRedeemHistory" method="post" runat="server">
				<table border="0" cellspacing="10" cellpadding="5">
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							Id (update this label in the 'Olymars/ColumnLabel' extended property of the 'Id' column)
						</td>
						<td>
							<asp:TextBox id="txt_Id" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="1" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_Id" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							Date (update this label in the 'Olymars/ColumnLabel' extended property of the 'Date' column)
						</td>
						<td>
							<asp:TextBox id="txt_Date" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="2" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_Date" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							CustomerId (update this label in the 'Olymars/ColumnLabel' extended property of the 'CustomerId' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_CustomerList id="com_CustomerId" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="3">
							</DropDownLists:WebDropDownList_CustomerList>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							ProductsId (update this label in the 'Olymars/ColumnLabel' extended property of the 'ProductsId' column)
						</td>
						<td>
							<DropDownLists:WebDropDownList_ProductsList id="com_ProductsId" runat="server" CssClass="MandatoryComboBoxStyle" tabIndex="4">
							</DropDownLists:WebDropDownList_ProductsList>
						</td>
					</tr>
					<tr>
						<td align="Right" class="MandatoryLabelStyle">
							Points (update this label in the 'Olymars/ColumnLabel' extended property of the 'Points' column)
						</td>
						<td>
							<asp:TextBox id="txt_Points" runat="server" CssClass="MandatoryTextBoxStyle" tabIndex="5" ></asp:TextBox>
						</td>
						<td>
							<asp:Label EnableViewState="False" Visible="False" runat="Server" id="labError_Points" CssClass="ErrorStyle"></asp:Label>
						</td>
					</tr>
					<tr>
					</tr>
					<tr>
						<td>
						</td>
						<td align="center">
							<table border="0" cellspacing="10" cellpadding="5">
								<tr align="center">
									<td>
										<asp:Button id="cmdRefresh" runat="server" Text="Refresh" CssClass="ButtonStyle" tabIndex="6"></asp:Button>
									</td>
									<td>
										<asp:Button id="cmdDelete" runat="server" Text="Delete" CssClass="ButtonStyle" tabIndex="7"></asp:Button>
									</td>
									<td>
										<asp:Button id="cmdUpdate" runat="server" Text="Update" CssClass="ButtonStyle" tabIndex="8"></asp:Button>
									</td>
								</tr>
							</table>
						</td>
					</tr>
				</table>
			</form>
		</asp:panel>
	</body>
</html>
