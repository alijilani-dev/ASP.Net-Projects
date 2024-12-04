<%@ Control Language="vb" AutoEventWireup="false" Codebehind="TraderDetails.ascx.vb" Inherits="Trade.TraderDetails" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<asp:DataList ID="DLTradeDetail" Width="650" HorizontalAlign="Center" runat="server">
  <itemtemplate>
    <table id="Table11" bordercolor="#99ccff" cellspacing="2" cellpadding="2" width="650" align="center"
			border="1">
      <tr>
        <td><table class="normaltext" id="Table4" cellspacing="1" cellpadding="1" width="650" align="center"
						border="0">
          <tr>
            <td align="center" bgcolor="#99ccff" colspan="5" height="25"><asp:Label ID=Label1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.member_company") %>' Font-Size="9pt" ForeColor="#003399" Font-Bold="true" EnableViewState="False"> </asp:Label></td>
          </tr>
          <tr>
            <td colspan="5" align="center"><asp:Image ID=Image1 runat="server" EnableViewState="False" 
            ImageUrl='<%# "../images/MainImage/" &amp; iif(DataBinder.Eval(Container, "DataItem.company_Logo_Url_Main").Tostring().trim()="","NoImage_big.gif",DataBinder.Eval(Container, "DataItem.company_Logo_Url_Main")) %>' BorderColor="#CCCCCC" BorderWidth="1px"></asp:Image></td>
          </tr>
          <tr>
            <td colspan="5" align="center"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td bgcolor="#e1f0ff" valign="top"><table class="normaltext" id="Table6" cellspacing="1" cellpadding="1" width="300" bgcolor="#e1f0ff"
									border="0">
                  <tr>
                    <td colspan="2"><strong>Company Details</strong></td>
                  </tr>
                  <tr>
                    <td valign="top">Address:</td>
                    <td width="70%"><asp:Label ID="Label8" Width="134px" runat="server" EnableViewState="False"> <%# DataBinder.Eval(Container, "DataItem.mailing_address") %> </asp:Label></td>
                  </tr>
                  <tr>
                    <td>Country:</td>
                    <td><asp:Label ID="Label9" Width="122px" runat="server" EnableViewState="False"> <%# DataBinder.Eval(Container, "DataItem.country_name") %> </asp:Label></td>
                  </tr>
                  <tr>
                    <td>Phone:</td>
                    <td class="normaltext"><asp:Label ID="Label10" runat="server" EnableViewState="False"> +<%# Replace (DataBinder.Eval(Container, "DataItem.company_phone"),"*"," ") %> </asp:Label></td>
                  </tr>
                  <tr>
                    <td>Fax:</td>
                    <td class="normaltext"><asp:Label ID="Label11" runat="server" EnableViewState="False"> +<%# Replace (DataBinder.Eval(Container, "DataItem.company_fax"),"*"," ") %> </asp:Label></td>
                  </tr>
                  <tr>
                    <td>Email:</td>
                    <td><asp:Label ID="Label12" runat="server" EnableViewState="False"> <%# DataBinder.Eval(Container, "DataItem.company_email") %> </asp:Label></td>
                  </tr>
                  <tr>
                    <td>Website:</td>
                    <td><asp:Label ID="Label13" runat="server" EnableViewState="False"> <%# DataBinder.Eval(Container, "DataItem.company_website") %> </asp:Label></td>
                  </tr>
                </table></td>
                <td width="3"></td>
                <td bgcolor="#e1f0ff" valign="top"><table class="normaltext" id="Table8" cellspacing="1" cellpadding="1" width="300" bgcolor="#e1f0ff"
									border="0">
                  <tr>
                    <td colspan="2"><strong>Personal Details</strong></td>
                  </tr>
                  <tr>
                    <td>Name:</td>
                    <td><asp:Label ID="Label7" runat="server" EnableViewState="False"> <%# DataBinder.Eval(Container, "DataItem.company_contact1_name") %> </asp:Label></td>
                  </tr>
                  <tr>
                    <td>Mobile:</td>
                    <td class="normaltext"><asp:Label ID="Label6" runat="server" EnableViewState="False"> +<%# Replace (DataBinder.Eval(Container, "DataItem.company_contact1_mobile"),"*"," ") %> </asp:Label></td>
                  </tr>
                  <tr>
                    <td> Email:</td>
                    <td class="normaltext"><asp:Label ID="Label5" runat="server" EnableViewState="False"> <%# DataBinder.Eval(Container, "DataItem.company_contact1_email") %> </asp:Label></td>
                  </tr>
                  <tr>
                    <td>Name:</td>
                    <td><asp:Label ID="Label3" runat="server" EnableViewState="False"> <%# DataBinder.Eval(Container, "DataItem.company_contact2_name") %> </asp:Label></td>
                  </tr>
                  <tr>
                    <td>Mobile:</td>
                    <td class="normaltext"><asp:Label ID="Label2" runat="server" EnableViewState="False"> +<%# Replace (DataBinder.Eval(Container, "DataItem.company_contact2_mobile"),"*"," ") %> </asp:Label></td>
                  </tr>
                  <tr>
                    <td>Email:</td>
                    <td><asp:Label ID="Label4" runat="server" EnableViewState="False"> <%# DataBinder.Eval(Container, "DataItem.company_contact2_email") %> </asp:Label></td>
                  </tr>
                </table></td>
              </tr>
            </table></td>
          </tr>
        </table>
            <br />
            <table id="Table15" cellspacing="0" cellpadding="0" width="100%" border="0">
              <tr>
                <td align="left"><asp:Label ID="lblProfile" runat="server" CssClass="normalText"> <%# server.htmlDecode(DataBinder.Eval(Container, "DataItem.Profile").Tostring) %> </asp:Label></td>
              </tr>
          </table></td>
      </tr>
    </table>
  </itemtemplate>
</asp:DataList>
