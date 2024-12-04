Public Class Offer
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents ROffers As System.Web.UI.WebControls.Repeater
    Protected WithEvents ImageButton1 As System.Web.UI.WebControls.ImageButton

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region
    Public strPhotos As String = ""
    Public strPhotosLink As String = ""

#Region "private variables "
    Private pi_obj_TradeFloor As Trade_BL.TradeFloor
#End Region
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        Dim dt_Search_Result As New DataTable
        Dim CriteriaSearch As String

        pi_obj_TradeFloor = New Trade_BL.TradeFloor
        dt_Search_Result = pi_obj_TradeFloor.GetHotOffer()

        CriteriaSearch = CriteriaSearch & " ( Trade_Type = 1 Or Trade_Type = 2  ) "
        'CriteriaSearch = CriteriaSearch & " (and ImgFile2<>'')"
        dt_Search_Result.DefaultView.RowFilter = CriteriaSearch
        '''Coded created on 25th Jan to have image slide show effect
        Dim dataRow As DataRow
        Dim i As Integer = 0
        Dim clr As String
        For Each dataRow In dt_Search_Result.Rows
            If dataRow("MobileSrNo") & "" <> "0" Then
                strPhotos = strPhotos & "arr_Models[" & i & "]={BGclr:'" & clr & "',manuf:'" & Replace(dataRow("Brand"), vbCrLf, "") & _
                    "', model:'" & dataRow("ModelNo") & "', gif:'" & dataRow("ImgFile2") & _
                    "', code:'" & dataRow("ManufCode") & _
                    "', links:'" & dataRow("MobileSrNo") & "'};" & vbCrLf
                If i Mod 2 = 0 Then clr = "#D7E6FF" Else clr = "white"
                i = i + 1
            End If
            'strPhotos = strPhotos & "photos[" & i & "]='../Images/Models/" & dataRow("ImgFile1") & "'" & vbCrLf
            'strPhotosLink = strPhotosLink & "photoslink[" & i & "]='" & dataRow("MobileSrNo") & "'" & vbCrLf
        Next


        'Response.Write("<SCRIPT type=text/javascript>")
        'Response.Write("var photos=new Array()")
        'Response.Write("var photoslink=new Array()")
        'Response.Write(strPhotos)
        'Response.Write(strPhotosLink)
        'Response.Write("</script>")


        'Response.Write(CriteriaSearch)
        'ViewState("dt_Search_Result") = dt_Search_Result


        '''Commented by Basheer on 25th Jan
        '''dt_Search_Result.DefaultView.RowFilter = CriteriaSearch        
        '''ROffers.DataSource = dt_Search_Result
        '''ROffers.DataBind()

        ''' Commented on Design HTML view and placed here, if requires in later we can use from here.
        '''<asp:HyperLink id="Hyperlink2_OLD2" runat="server" ImageUrl='<%# "../" & DataBinder.Eval(Container, "DataItem.ImgFile2") %>' NavigateUrl='<%#  "../PortalDefault.aspx?Main_Links_ID=4&ManufCode=" & DataBinder.Eval(Container, "DataItem.ManufCode") & "&MobileSrNo=" & DataBinder.Eval(Container, "DataItem.MobileSrNo")%>' Target=_parent CssClass="footer">
        '''<%# DataBinder.Eval(Container, "DataItem.ModelNo") %></asp:HyperLink>
        '''<asp:HyperLink id="Hyperlink1_OLD1" runat="server" NavigateUrl='<%# "../PortalDefault.aspx?Main_Links_ID=5&MobileSrNo=" & DataBinder.Eval(Container, "DataItem.MobileSrNo") %>' Target=_Parent CssClass="footer">
        '''<%# "&nbsp;" & DataBinder.Eval(Container,"DataItem.Brand") & "&nbsp;&nbsp;" & DataBinder.Eval(Container, "DataItem.ModelNo") %>

    End Sub
    '''DIV tags removed from the HTML design.
    '''To be placed on the desing in between the comments REFER.
    '''<div id="containerPhones" style="DISPLAY: inline; VISIBILITY: visible; OVERFLOW: hidden; WIDTH: 166px; BORDER-TOP-STYLE: none; BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; HEIGHT: 90px; BACKGROUND-COLOR: transparent; BORDER-BOTTOM-STYLE: none"
    '''	align="center">
    '''	<div id="Phones" onmouseover="javascript:wait();" style="VISIBILITY: visible; POSITION: relative"
    '''		onmouseout="javascript:continu();" align="center">
    '''		<asp:Repeater id="ROffers" runat="server">
    '''			<ItemTemplate>
    '''				<TABLE id="Table1" cellSpacing="2" cellPadding="1" width="100%" align="center" border="0">
    '''					<TR>
    '''						<TD bgColor="white" style="WIDTH: 89px" vAlign="middle" align="center">
    '''							<asp:HyperLink id="Hyperlink2" runat="server" ImageUrl='<%# "../" & DataBinder.Eval(Container, "DataItem.ImgFile2") %>' NavigateUrl='<%# "../PortalDefault.aspx?Main_Links_ID=5&MobileSrNo=" & DataBinder.Eval(Container, "DataItem.MobileSrNo") %>' Target=_parent CssClass="footer"><!--<%# DataBinder.Eval(Container, "DataItem.ModelNo") %>--></asp:HyperLink>
    '''						</TD>
    '''						<TD bgColor="white" vAlign="middle" align="center" colSpan="2">
    '''							<asp:HyperLink id="Hyperlink1" runat="server" NavigateUrl='<%# "../PortalDefault.aspx?Main_Links_ID=5&MobileSrNo=" & DataBinder.Eval(Container, "DataItem.MobileSrNo") %>' Target=_Parent CssClass="footer"><%# "&nbsp;" & DataBinder.Eval(Container,"DataItem.Brand") & "&nbsp;&nbsp;" & DataBinder.Eval(Container, "DataItem.ModelNo") %></asp:HyperLink>
    '''						</TD>
    '''					</TR>
    '''				</TABLE>
    '''				<!--
    '''				<asp:HyperLink id="Hyperlink3" runat="server" NavigateUrl='<%# "mailto:" & DataBinder.Eval(Container, "DataItem.Company_email") & "?subject=Enquiry from phonetrade.cc of " & DataBinder.Eval(Container, "DataItem.Brand") & " - " & DataBinder.Eval(Container, "DataItem.ModelNo") & " for Price " & DataBinder.Eval(Container, "DataItem.Price") %>' CssClass="footer" Visible="False">
    '''					<%# "[ " & DataBinder.Eval(Container, "DataItem.post_heading") & " ][ Price " & DataBinder.Eval(Container, "DataItem.Price") & " ]" %>
    '''				</asp:HyperLink> -->
    '''			</ItemTemplate>
    '''		</asp:Repeater>
    '''	</div>
    '''</div>

    '''Script has removed from the HTML design and kept here for later use if needed.
    '''<SCRIPT language="JavaScript">
    '''<!-- Begin
    '''var step=parseFloat(window.containerPhones.style.posTop)+parseFloat(window.containerPhones.style.posHeight);
    '''var diff=(window.Phones.style.top-window.Phones.scrollHeight);
    '''var scrollspeed=50; //Millisecs
    '''    Function scrollPhones()
    '''{
    '''	window.Phones.style.top = step;
    '''	step-=2;
    '''        If ((parseFloat(window.Phones.style.posTop)) <= diff) Then
    '''	{
    '''		step=parseFloat(window.containerPhones.style.posTop)+parseFloat(window.containerPhones.style.posHeight);
    '''	}
    '''}
    '''var retval=setInterval("scrollPhones();",scrollspeed);

    '''function wait()
    '''{
    '''	clearInterval(retval);
    '''}

    '''function continu()
    '''{
    '''	retval = setInterval("scrollPhones();",scrollspeed);
    '''}
    '''//  End -->
    '''		</SCRIPT>
End Class
