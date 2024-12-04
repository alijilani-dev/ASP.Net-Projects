Public Class TradeFloor
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents pnlShippingDetails As System.Web.UI.WebControls.Panel
    Protected WithEvents DataList1 As System.Web.UI.WebControls.DataList
    Protected WithEvents ddlProviderLogo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Table20 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents TblDetails As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents Confirm As Confirmation
    Protected WithEvents tbl_buySell1 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Radiobutton1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Radiobutton2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Dropdownlist3 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Textbox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Textbox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Requiredfieldvalidator2 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents Textbox3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Dropdownlist4 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Requiredfieldvalidator3 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents Rangevalidator2 As System.Web.UI.WebControls.RangeValidator
    Protected WithEvents Dropdownlist5 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Dropdownlist6 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Dropdownlist7 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Dropdownlist8 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Textbox4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Dropdownlist9 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Dropdownlist10 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Textbox5 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Requiredfieldvalidator4 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents Dropdownlist11 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Textbox6 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Textbox7 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Linkbutton1 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Linkbutton2 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Imagebutton1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Imagebutton2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Table3 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents lblComments As System.Web.UI.WebControls.Label
    Protected WithEvents trTradeFloorView As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents TDSummaryView As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TDFormView As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents Table1 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents btnHideSummary As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ImgbtnAdd As System.Web.UI.WebControls.ImageButton
    Protected WithEvents lblMemberId As System.Web.UI.WebControls.Label
    Protected WithEvents lblRequestedFrom As System.Web.UI.WebControls.Label
    Protected WithEvents lblTradeType As System.Web.UI.WebControls.Label
    Protected WithEvents lblBrand As System.Web.UI.WebControls.Label
    Protected WithEvents lblModel As System.Web.UI.WebControls.Label
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label
    Protected WithEvents lblSpec As System.Web.UI.WebControls.Label
    Protected WithEvents lblQuantity As System.Web.UI.WebControls.Label
    Protected WithEvents lblPrice As System.Web.UI.WebControls.Label
    Protected WithEvents lblWarranty As System.Web.UI.WebControls.Label
    Protected WithEvents lblPackage As System.Web.UI.WebControls.Label
    Protected WithEvents lblShippingTerms As System.Web.UI.WebControls.Label
    Protected WithEvents lblCountry As System.Web.UI.WebControls.Label
    Protected WithEvents lblStockLocation As System.Web.UI.WebControls.Label
    Protected WithEvents lblLocation As System.Web.UI.WebControls.Label
    Protected WithEvents lblComment As System.Web.UI.WebControls.Label
    Protected WithEvents DGTradeFloorView As System.Web.UI.WebControls.DataGrid
    Protected WithEvents ibtnPosttoTF As System.Web.UI.WebControls.ImageButton
    Protected WithEvents RVPrice As System.Web.UI.WebControls.RangeValidator
    Protected WithEvents RFVQuantity As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RFVPrice As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents rdoBuy As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rdoSell As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rdoPostComment As System.Web.UI.WebControls.RadioButton
    Protected WithEvents ddlBrand As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlModel As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtQuantity As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlCurrency As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtPrice As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDate As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlShippingTerms As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlCountry As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlStockLocation As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtLocation As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtComment As System.Web.UI.WebControls.TextBox
    Protected WithEvents chkGrouping As System.Web.UI.WebControls.CheckBox
    Protected WithEvents ImgbtnCancel As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnShowSummary As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnPostTF As System.Web.UI.WebControls.ImageButton
    Protected WithEvents IbtnUpdatePosting As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Table19 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tbl_buySell As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents TblPostOffer As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tbl_Comment As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents Requiredfieldvalidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents rblist As System.Web.UI.WebControls.RadioButtonList
    Protected WithEvents TblPhoneModel As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents TblStockSpecs As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents TblShippingDetails As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents TblPostingType As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents TD_ShippingDetails As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents RVQty As System.Web.UI.WebControls.RangeValidator
    Protected WithEvents Table_Detail As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents lblTypeComments As System.Web.UI.WebControls.Label
    Protected WithEvents lblAnnouncement As System.Web.UI.WebControls.Label
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents ImgD As System.Web.UI.WebControls.Image
    Protected WithEvents hlnkCurrencyConverter As System.Web.UI.WebControls.HyperLink
    Protected WithEvents txtSpecs As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtWarranty As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPackaging As System.Web.UI.WebControls.TextBox
    ' Protected WithEvents txtManufName As System.Web.UI.WebControls.TextBox
    'Protected WithEvents CvManuf As System.Web.UI.WebControls.CustomValidator
    Protected WithEvents table31xx As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents trOther1 As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents trOther2 As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents trOther3 As System.Web.UI.HtmlControls.HtmlTableRow
    'Protected WithEvents lblManufValidator As System.Web.UI.WebControls.Label
    Protected WithEvents table31 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents Requiredfieldvalidator5 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents lblModelValidator As System.Web.UI.WebControls.Label
    Protected WithEvents lblManufValidator As System.Web.UI.WebControls.Label
    Protected WithEvents CvManuf As System.Web.UI.WebControls.CustomValidator
    Protected WithEvents CVModel As System.Web.UI.WebControls.CustomValidator
    Protected WithEvents txtModelNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtManufName As System.Web.UI.WebControls.TextBox
    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub
#End Region

#Region "Private Variables"
    Private pi_obj_TradeFloor As New Trade_BL.TradeFloor
    Private pi_Portal_ID As Integer
    Private pi_dt_TradeFloor As New DataTable
    Private pi_obj_member As New Trade_BL.Member
    Private pi_dt_member As New DataTable
    Private pi_obj_Currency As Trade_BL.Currency
    Private pi_obj_MobileModel As New Trade_BL.ProductCategory
    Private pi_obj_Brand As New Trade_BL.Manufacturer
    Private pi_obj_Country As Trade_BL.Country
#End Region
#Region "Private Constant"
    Private Const pi_ddlCountry_DataTextField As String = "Country_Name"
    Private Const pi_ddlCountry_DataValueField As String = "Country_ID1"
#End Region
#Region "Public Properties"
    Private Property Portal_ID() As Integer
        Get
            Return pi_Portal_ID
        End Get
        Set(ByVal Value As Integer)
            pi_Portal_ID = Value
        End Set
    End Property
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pi_obj_TradeFloor = New Trade_BL.TradeFloor
        Dim dt_TradeFloor As DataTable

        If Session(Session_str_UserName) = "" Or Session(Session_str_UserName) Is Nothing Then
            Response.Redirect("PortalDefault.aspx?Main_Links_ID=24")
        End If

        dt_TradeFloor = pi_obj_TradeFloor.GetMemberGroupedTradeFloor(Session(Session_str_Portal_ID), Session(Session_str_UserName))
        DGTradeFloorView.DataSource = dt_TradeFloor
        DGTradeFloorView.DataBind()

        EnablePostingForms(Not rdoPostComment.Checked)
        rdoBuy.Checked = True

        If dt_TradeFloor.Rows.Count > 0 Then
            chkGrouping.Checked = True
            tbl_buySell.Visible = True
            DGTradeFloorView.Visible = True
            ibtnPosttoTF.Visible = True
        Else
            chkGrouping.Checked = False
            tbl_buySell.Visible = False
            DGTradeFloorView.Visible = False
            ibtnPosttoTF.Visible = False
        End If

        Dim dt_Currency As New DataTable
        Dim dt_MobileModel As New DataTable
        Dim dt_Brand As New DataTable

        Confirm.Visible = False
        Confirm.Main_Links_ID = Me.Main_Links_ID
        Confirm.Sub_Links_ID = Me.Sub_Links_ID
        Confirm.Module_ID = Me.Module_ID

        If Request("Trade_ID") <> "" Then
            FillPostingDetails(Request("Trade_ID").ToString(), False)
            rdoPostComment.Visible = False
            btnPostTF.Visible = False
            chkGrouping.Visible = False
            TDSummaryView.Visible = False
            Exit Sub
        End If

        Confirm.Message = "Your Offer has been added"
        Confirm.Todo = "To add more Click Here "
        FillCountry()
        TDSummaryView.Visible = False
        IbtnUpdatePosting.Visible = False
        If Page.IsPostBack = False Then
            txtDate.Text = DateTime.Now.ToString()

            ' Fill Currency
            pi_obj_Currency = New Trade_BL.Currency
            dt_Currency = pi_obj_Currency.GetCurrency()
            ddlCurrency.DataSource = dt_Currency
            ddlCurrency.DataTextField = "Currency_Symbol"
            ddlCurrency.DataValueField = "Currency_Code"
            ddlCurrency.DataBind()

            ' Fill Brand
            FillManufacturer()
        End If
        FillProduct()

        'trOther2.Visible = False
        'trOther3.Visible = False
    End Sub
    Private Sub FillCountry()
        pi_obj_member = New Trade_BL.Member

        Dim dt_Member As DataTable
        dt_Member = pi_obj_member.GetMembers(Session(Session_str_UserName))
        pi_obj_Country = New Trade_BL.Country
        ddlCountry.DataSource = pi_obj_Country.GetCountries()
        ddlCountry.DataTextField = pi_ddlCountry_DataTextField
        ddlCountry.DataValueField = pi_ddlCountry_DataValueField
        ddlCountry.DataBind()

        Dim li As ListItem
        li = New ListItem
        li.Text = "All"
        li.Value = "0"
        ddlCountry.Items.Add(li)

        Dim liSelection As ListItem
        liSelection = ddlCountry.Items.FindByValue(dt_Member.Rows(0)("Country_ID"))
        liSelection.Selected = True
    End Sub
    Private Sub ImgbtnAdd_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnAdd.Click
        PostOffer()
    End Sub
    Private Sub PostOffer()
        Dim ValVisible As Boolean
        If Not Page.IsValid Then
            Exit Sub
        End If

        'If Not rdoPostComment.Checked Then
        '    lblModelValidator.Visible = False
        '    lblManufValidator.Visible = False
        '    If (ddlModel.SelectedItem.Text.Trim() = "Others" And txtModelNo.Text.Trim() = "") Or (ddlBrand.SelectedItem.Text.Trim() = "Others" And txtManufName.Text.Trim() = "") Then
        '        Dim ValVisible As Boolean
        '        ValVisible = CBool((ddlModel.SelectedItem.Text.Trim() = "Others" And txtModelNo.Text.Trim() = ""))
        '        CVModel.Visible = ValVisible
        '        lblModelValidator.Visible = ValVisible
        '        trOther2.Visible = ValVisible
        '        trOther3.Visible = ValVisible
        '        txtModelNo.Visible = ValVisible

        '        ValVisible = CBool((ddlBrand.SelectedItem.Text.Trim() = "Others" And txtManufName.Text.Trim() = ""))
        '        CvManuf.Visible = ValVisible
        '        lblManufValidator.Visible = ValVisible
        '        trOther2.Visible = ValVisible
        '        trOther3.Visible = ValVisible
        '        txtManufName.Visible = ValVisible
        '        Exit Sub
        '    End If
        'End If
        'If ddlModel.SelectedItem.Text.Trim() = "Others" And txtModelNo.Text.Trim() = "" Then
        'ElseIf ddlBrand.SelectedItem.Text.Trim() = "Others" And txtManufName.Text.Trim() = "" Then
        'End If

        If ddlModel.SelectedItem.Text.Trim() = "Others" And txtModelNo.Text.Trim() = "" And Not rdoPostComment.Checked Then
            CVModel.Visible = True
            lblModelValidator.Visible = True
            'trOther2.Visible = True
            'trOther3.Visible = True
            txtModelNo.Visible = True
            ValVisible = True
        Else
            lblModelValidator.Visible = False
        End If


        If ddlBrand.SelectedItem.Text.Trim() = "Others" And txtManufName.Text.Trim() = "" And Not rdoPostComment.Checked Then
            lblManufValidator.Visible = True
            CvManuf.Visible = True
            'trOther2.Visible = True
            'trOther3.Visible = True
            txtManufName.Visible = True
            Exit Sub
        Else

            lblManufValidator.Visible = False
            If ValVisible Then Exit Sub
        End If

        Dim pi_obj_tradeFloor As Trade_BL.TradeFloor
        pi_obj_tradeFloor = New Trade_BL.TradeFloor
        pi_obj_tradeFloor.Trading_ID = 0
        pi_obj_tradeFloor.post_heading = IIf(rdoBuy.Checked = True, "BUY", "SELL")
        pi_obj_tradeFloor.Trade_Type = IIf(rdoPostComment.Checked = True, 3, IIf(rdoBuy.Checked = True, 1, 2))
        pi_obj_tradeFloor.Member_Id = Session(Session_str_UserName)

        If rdoPostComment.Checked = True Then
            pi_obj_tradeFloor.MobileSrNo = 0
        Else
            pi_obj_tradeFloor.MobileSrNo = "0" & ddlModel.SelectedItem.Value
        End If

        If ddlModel.SelectedItem.Text.Trim() = "Others" And txtModelNo.Text.Trim() <> "" Then
            pi_obj_tradeFloor.ModelNo = txtModelNo.Text
        Else
            pi_obj_tradeFloor.ModelNo = String.Empty
        End If
        'If ddlModel.SelectedItem.Text.Trim() <> "Others" Then
        '    pi_obj_tradeFloor.ModelNo = ddlModel.SelectedItem.Text
        'ElseIf txtModelNo.Text.Trim <> "" Then
        '    pi_obj_tradeFloor.ModelNo = txtModelNo.Text
        'Else
        '    pi_obj_tradeFloor.ModelNo = "All"
        'End If

        pi_obj_tradeFloor.ManufCode = ddlBrand.SelectedItem.Value

        If ddlBrand.SelectedItem.Text.Trim() = "Others" And txtManufName.Text.Trim() <> "" Then
            pi_obj_tradeFloor.OtherManufName = txtManufName.Text
        Else
            pi_obj_tradeFloor.OtherManufName = String.Empty
        End If


        'If ddlBrand.SelectedItem.Text.Trim() <> "Others" Then
        '    pi_obj_tradeFloor.OtherManufName = ddlBrand.SelectedItem.Text
        'ElseIf txtManufName.Text.Trim <> "" Then
        '    pi_obj_tradeFloor.OtherManufName = txtManufName.Text
        'Else
        '    pi_obj_tradeFloor.OtherManufName = "All"
        'End If

        If rdoPostComment.Checked = True Then
            txtQuantity.Text = "0"
        End If

        If txtQuantity.Text.Trim() <> "" Then
            pi_obj_tradeFloor.Quantity = IIf(rdoPostComment.Checked = True, 0, txtQuantity.Text)
        Else
            Exit Sub
        End If

        If rdoPostComment.Checked = True Then
            txtPrice.Text = "0"
        End If

        If txtPrice.Text.Trim() = "" Then
            txtPrice.Text = "0"
        End If

        pi_obj_tradeFloor.Price = CType(txtPrice.Text, Int32)
        pi_obj_tradeFloor.CurrencyCode = ddlCurrency.SelectedItem.Value
        pi_obj_tradeFloor.Spec = txtSpecs.Text.ToString.Trim
        pi_obj_tradeFloor.Warranty = txtWarranty.Text.ToString.Trim
        pi_obj_tradeFloor.ProviderLogo = ddlProviderLogo.SelectedItem.Value
        pi_obj_tradeFloor.Packaging = txtPackaging.Text.ToString.Trim

        If (chkGrouping.Checked = False) Or (rdoPostComment.Checked = True) Then
            pi_obj_tradeFloor.RequestDate = DateTime.Parse(DateTime.Now).AddHours(-4)
        Else
            pi_obj_tradeFloor.RequestDate = DateTime.Parse("1/1/1753 12:00:00 AM") ' HARDCODED '
        End If

        pi_obj_tradeFloor.ShippingTerms = ddlShippingTerms.SelectedItem.Text

        If ((ddlStockLocation.SelectedItem.Value = 4) Or (ddlStockLocation.SelectedItem.Value = 0)) Then
            pi_obj_tradeFloor.Location = txtLocation.Text
        Else
            pi_obj_tradeFloor.Location = ddlStockLocation.SelectedItem.Text
        End If

        pi_obj_tradeFloor.post_desc = txtComment.Text.Replace(System.Environment.NewLine, "<BR>")

        pi_obj_tradeFloor.Country_ID = ddlCountry.SelectedItem.Value
        'pi_obj_tradeFloor.Status = ddlStatus.SelectedItem.Text

        Try
            pi_obj_tradeFloor.Insert()

        Catch ex As Exception
            Throw ex
            Exit Sub
        Finally
            If (chkGrouping.Checked = False) Or (rdoPostComment.Checked = True) Then
                Response.Redirect("PortalDefault.aspx?Main_Links_ID=4")                 ' HARDCODED 'Trading Floor
            Else
                Response.Redirect("PortalDefault.aspx?Main_Links_ID=6&sub_Links_ID=1")  ' HARDCODED 'Posting Form
            End If
        End Try
    End Sub
    Private Sub btnHideSummary_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnHideSummary.Click
        TDSummaryView.Visible = False
        TDFormView.Visible = True
    End Sub
    Private Sub ImgbtnCancel_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnCancel.Click
        Response.Redirect("PortalDefault.aspx?Main_Links_ID=6&sub_Links_ID=2")      ' HARDCODED '
    End Sub
    Public Function ShowDetailsVisibility() As String
        If Session(Session_str_UserName).ToString().Trim() <> "" Then
            Return "False"
        Else
            Return "True"
        End If
    End Function
    Public Function Navigate() As String
        Return "~/PortalDefault.aspx?Main_Links_ID=24"
    End Function
    Public Function GetVisibility(ByVal btnName As String) As String
        If btnName = "imgedit" Then
            If (Session(Session_str_UserName).ToString().Trim() <> "" Or Session(Session_str_UserName) <> Nothing) And Not (Request.QueryString("sub_Links_ID") Is Nothing) Then
                Return "cursor:hand;display='';visibility=''"
            Else
                Return "cursor:hand;display='none';visibility='hidden'"
            End If
        ElseIf btnName = "imggo" Then
            If (Session(Session_str_UserName).ToString().Trim() <> "" Or Session(Session_str_UserName) <> Nothing) Then
                Return "cursor:hand;display='';visibility=''"
            Else
                Return "cursor:hand;display='none';visibility='hidden'"
            End If
        ElseIf btnName = "phone" Then
            If Session(Session_str_UserName).ToString().Trim() <> "" Or Session(Session_str_UserName) <> Nothing Then
                Return "True"
            Else
                Return "False"
            End If
        Else
            If Session(Session_str_UserName).ToString().Trim() <> "" Or Session(Session_str_UserName) <> Nothing Then
                Return "cursor:hand;display='none';visibility='hidden'"
            Else
                Return "cursor:hand;display='';visibility=''"
            End If
        End If
    End Function
    Public Function GetDetailsVisibility() As String
        If Session(Session_str_UserName).ToString().Trim() <> "" Or Session(Session_str_UserName) <> Nothing Then
            Return "True"
        Else
            Return "False"
        End If
    End Function
    Public Sub GenerateScript(ByVal dt_MobileModel As DataTable)
        ''After binding  model v have to populate the code to write 
        Dim sql As String
        Dim strFn As String

        strFn = "function change(cbo){" & vbCrLf & _
          " var x; " & vbCrLf & "x=cbo.options[cbo.selectedIndex].text;"

        strFn = strFn & "for (var i = document.Form1.TradeMainCtrl__ctl5_ddlModel." & _
         "options.length; i >= 0; i--){" & vbCrLf & _
         "document.Form1.TradeMainCtrl__ctl5_ddlModel.options[i] = null;" & vbCrLf
        strFn = strFn & "}" & vbCrLf & _
         "if (cbo.options[cbo.selectedIndex].value==0" & "){" & vbCrLf
        strFn = strFn & "document.Form1.TradeMainCtrl__ctl5_ddlModel.options[" & _
         "document.Form1.TradeMainCtrl__ctl5_ddlModel.options.length] = new Option('All','0');" & vbCrLf
        Dim strName As String
        For nCounter As Integer = 0 To dt_MobileModel.Rows.Count - 1
            If strName <> dt_MobileModel.Rows(nCounter)("ManufCode") Then
                strName = dt_MobileModel.Rows(nCounter)("ManufCode")
                strFn = strFn & "}" & vbCrLf & _
                  "if (cbo.options[cbo.selectedIndex].value==" & _
                dt_MobileModel.Rows(nCounter)("ManufCode") & "){" & vbCrLf

                strFn = strFn & "document.Form1.TradeMainCtrl__ctl5_ddlModel.options[" & _
                 "document.Form1.TradeMainCtrl__ctl5_ddlModel.options.length] = new Option('All','0');" & vbCrLf
            End If
            strFn = strFn & "document.Form1.TradeMainCtrl__ctl5_ddlModel.options[" & _
             "document.Form1.TradeMainCtrl__ctl5_ddlModel.options.length] = new Option('" & _
             dt_MobileModel.Rows(nCounter)("ModelNo") & "','" & dt_MobileModel.Rows(nCounter)("SrNo") & "');" & vbCrLf
        Next
        strFn = strFn & vbCrLf & "}" & vbCrLf & "}" & vbCrLf
        Response.Write("<SCRIPT LANGUAGE=""JavaScript"">" & vbCrLf)
        Response.Write(strFn & vbCrLf & "</SCRIPT>" & vbCrLf)

        strFn = "function getValue(cbo){alert(cbo.options[cbo.selectedIndex].value);}"
        Response.Write("<SCRIPT LANGUAGE=""JavaScript"">" & vbCrLf)
        Response.Write(strFn & vbCrLf & "</SCRIPT>" & vbCrLf)
    End Sub
    Private Sub FillPostingDetails(ByVal Trade_ID As String, ByVal lGrouped As Boolean)
        Dim dt_Search_Result As New DataTable
        Dim CriteriaSearch As String

        If MyBase.Sub_Links_ID > 0 And Session(Session_str_UserName) <> "" Then    ' Member Logged in.

            CriteriaSearch = " ( Trade_Floor.[Trading_ID] = '" & Trade_ID & "' ) "

            'dt_Search_Result = pi_obj_TradeFloor.GetMemberTradeFloor(Session(Session_str_Portal_ID), Session(Session_str_UserName), , CriteriaSearch)
            If (lGrouped) Then
                dt_Search_Result = pi_obj_TradeFloor.GetMemberGroupedTradeFloor(Session(Session_str_Portal_ID), Session(Session_str_UserName), , CriteriaSearch)
            Else
                dt_Search_Result = pi_obj_TradeFloor.GetMemberTradeFloor(Session(Session_str_Portal_ID), Session(Session_str_UserName), , CriteriaSearch)
            End If

            If Not dt_Search_Result.Rows.Count > 0 Then
                Response.Redirect("PortalDefault.aspx?Main_Links_ID=1")
            End If

            ' Fill Posting Form..'
            Dim dr_Trader As DataRow = dt_Search_Result.Rows(0)

            ' Check if it is an Announcement.
            If dr_Trader("Trade_Type").ToString() = "3" Then
                rdoBuy.Checked = False
                rdoBuy.Enabled = False
                rdoSell.Checked = False
                rdoSell.Enabled = False
                rdoPostComment.Checked = True
                TblDetails.Visible = False
                TblPostOffer.BgColor = "#eeeeee"
                lblTypeComments.Text = "Edit your Announcement "
                lblAnnouncement.Text = "Announcement: "
                txtComment.Text = dr_Trader("post_desc").ToString().Replace("<BR>", System.Environment.NewLine)
                chkGrouping.Visible = False
                ChangeFormType()
                Exit Sub
            End If

            If dr_Trader("post_heading") = "BUY" Then
                rdoBuy.Checked = True
                rdoSell.Checked = False
                rdoPostComment.Checked = False
            ElseIf dr_Trader("post_heading") = "SELL" Then
                rdoBuy.Checked = False
                rdoSell.Checked = True
                rdoPostComment.Checked = False
            Else
                rdoBuy.Checked = False
                rdoSell.Checked = False
                rdoPostComment.Checked = True
            End If
            ChangeFormType()

            FillManufacturer()
            Dim liBrand As ListItem
            Dim liModel As ListItem
            liBrand = ddlBrand.Items.FindByText(dr_Trader("Brand") & "")
            ddlBrand.SelectedIndex = -1
            If Not (liBrand Is Nothing) Then
                liBrand.Selected = True
            Else
                liBrand = ddlBrand.Items.FindByText("Others")
                'ddlBrand.SelectedIndex = -1
                liBrand.Selected = True
                txtManufName.Text = dr_Trader("OtherManufName")
                'trOther2.Visible = True
                'trOther3.Visible = True
                txtManufName.Visible = True

            End If


            FillProduct()


            liModel = ddlModel.Items.FindByText(dr_Trader("MODELNo") & "")
            ddlModel.SelectedIndex = -1
            If Not (liModel Is Nothing) Then
                liModel.Selected = True
            Else
                liModel = ddlModel.Items.FindByText("Others")
                liModel.Selected = True
                txtModelNo.Text = dr_Trader("ModelNo")
                'trOther2.Visible = True
                'trOther3.Visible = True
                txtModelNo.Visible = True
            End If
            'liModel.Selected = True

            'liModel = ddlModel.Items.FindByText("Others")
            'ddlModel.SelectedIndex = -1
            'liModel.Selected = True


            If CType(dr_Trader("Quantity"), String) <> "" Then
                txtQuantity.Text = dr_Trader("Quantity")
                '''''liModel = ddlModel.Items.FindByText("Others")
                '''''ddlModel.SelectedIndex = -1
                '''''liModel.Selected = True
            End If

            Dim strPrice As String
            strPrice = dr_Trader("Price").ToString().Trim()
            If CType(strPrice, String) = "Price on Application" Then
                txtPrice.Text = "0"
            ElseIf CType(strPrice, String) <> "" Then
                txtPrice.Text = strPrice.Substring(0, strPrice.Length - 1)
            End If

            FillCurrency()
            Dim strCurrency As String
            strCurrency = dr_Trader("Price").Trim()
            strCurrency = strCurrency.Substring(strCurrency.Length - 1, 1)
            Dim liCurrency As ListItem
            liCurrency = ddlCurrency.Items.FindByText(strCurrency.ToString())

            If Not liCurrency Is Nothing Then
                liCurrency.Selected = True
            Else
                ddlCurrency.Items.FindByText("$").Selected = True   ' Default Currency.
            End If
            txtSpecs.Text = dr_Trader("Spec") & ""
            txtPackaging.Text = dr_Trader("Packaging") & ""
            txtWarranty.Text = dr_Trader("Warranty")
            'Dim liStatus As ListItem
            'If dr_Trader("Status").ToString().Trim() <> "" Then
            '    liStatus = ddlStatus.Items.FindByText(dr_Trader("Status"))
            '    If Not liStatus Is Nothing Then
            '        ddlStatus.SelectedIndex = -1
            '        liStatus.Selected = True
            '    Else
            '        ddlStatus.SelectedIndex = -1
            '        ddlStatus.Items.FindByText("Select...").Selected = True  ' Default Status.
            '    End If
            'End If

            'Dim liSpecs As ListItem
            'liSpecs = ddlspecs.Items.FindByText(dr_Trader("Spec"))
            'If Not liSpecs Is Nothing Then
            '    ddlspecs.SelectedIndex = -1
            '    liSpecs.Selected = True
            'Else
            '    ddlspecs.SelectedIndex = -1
            '    ddlspecs.Items.FindByText("Select..").Selected = True  ' Default Specs.
            'End If

            'Dim liWarranty As ListItem
            'liWarranty = ddlWarranty.Items.FindByText(dr_Trader("Warranty"))
            'If Not liWarranty Is Nothing Then
            '    ddlWarranty.SelectedIndex = -1
            '    liWarranty.Selected = True
            'Else
            '    ddlWarranty.SelectedIndex = -1
            '    ddlWarranty.Items.FindByText("Select..").Selected = True  ' Default Warranty.
            'End If

            'Dim liPackaging As ListItem
            'liPackaging = ddlPackaging.Items.FindByText(dr_Trader("Packaging"))
            'If Not liPackaging Is Nothing Then
            '    ddlPackaging.SelectedIndex = -1
            '    liPackaging.Selected = True
            'Else
            '    ddlPackaging.SelectedIndex = -1
            '    ddlPackaging.Items.FindByText("Select...").Selected = True  ' Default Warranty.
            'End If

            ' Extract Shipping Terms from the row item.
            Dim strShippingTerms As String
            strShippingTerms = dr_Trader("ShippingTerms").ToString().Trim()
            'If strShippingTerms.IndexOf("(") > 0 Then
            strShippingTerms = strShippingTerms.Substring(0, strShippingTerms.IndexOf("(") - 1)
            'End If

            Dim liShippingTerms As ListItem
            liShippingTerms = ddlShippingTerms.Items.FindByText(strShippingTerms)
            If Not liShippingTerms Is Nothing Then
                ddlShippingTerms.SelectedIndex = -1
                liShippingTerms.Selected = True
            Else
                ddlShippingTerms.SelectedIndex = -1
                ddlShippingTerms.Items.FindByText("Select..").Selected = True  ' Default Warranty.
            End If

            txtDate.Text = DateTime.Now.ToShortDateString()

            FillCountry()
            Dim liCountry As ListItem
            liCountry = ddlCountry.Items.FindByText(dr_Trader("Country_Name"))
            If Not liCountry Is Nothing Then
                ddlCountry.SelectedIndex = -1
                liCountry.Selected = True
            Else
                ddlCountry.SelectedIndex = -1
                ddlCountry.Items.FindByText("United Arab Emirates").Selected = True  ' Default Warranty.
            End If

            Dim liStockLocation As ListItem
            liStockLocation = ddlStockLocation.Items.FindByText(dr_Trader("StockLocation").ToString().Trim())
            If Not liStockLocation Is Nothing Then
                ddlStockLocation.SelectedIndex = -1
                liStockLocation.Selected = True
            Else
                ddlStockLocation.SelectedIndex = -1
                ddlStockLocation.Items.FindByText("Select..").Selected = True  ' Default Warranty.
            End If

            txtComment.Text = dr_Trader("post_desc")
            If dr_Trader("StockLocation").ToString().Trim() <> "" Then
                ddlStockLocation.Items.FindByText(dr_Trader("StockLocation"))
            Else
                ddlStockLocation.SelectedIndex = 0
            End If

            txtLocation.Text = dr_Trader("Location")
        End If
    End Sub
    Private Sub FillManufacturer()
        Dim dt_Brand As New DataTable
        pi_obj_Brand = New Trade_BL.Manufacturer
        dt_Brand = pi_obj_Brand.GetManufacturer()

        ddlBrand.DataSource = dt_Brand
        ddlBrand.DataTextField = "ManufName"
        ddlBrand.DataValueField = "ManufCode"
        ddlBrand.DataBind()

        'FillProduct()
    End Sub
    Private Sub FillProduct()
        Dim li As ListItem
        Dim dt_MobileModel As New DataTable
        pi_obj_MobileModel = New Trade_BL.ProductCategory
        dt_MobileModel = pi_obj_MobileModel.GetProductCategory()

        ddlModel.DataSource = dt_MobileModel
        ddlModel.DataTextField = "CategoryName"
        ddlModel.DataValueField = "CategoryCode"
        ddlModel.DataBind()

        ' li = New ListItem
        ' li.Text = "Others"
        ' li.Value = "0"
        ' ddlModel.Items.Add(li)

        ddlModel.SelectedIndex = ddlModel.Items.Count - 1
    End Sub
    Private Sub FillCurrency()
        pi_obj_Currency = New Trade_BL.Currency
        Dim dt_Currency As New DataTable
        dt_Currency = pi_obj_Currency.GetCurrency()

        ddlCurrency.DataSource = dt_Currency
        ddlCurrency.DataTextField = "Currency_Symbol"
        ddlCurrency.DataValueField = "Currency_Code"
        ddlCurrency.DataBind()
    End Sub
    Private Sub IbtnUpdatePosting_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles IbtnUpdatePosting.Click
        UpdatePostingDetails(Request.QueryString("Trade_ID").ToString())
    End Sub
    Private Sub UpdatePostingDetails(ByVal Trade_ID As String, Optional ByVal lSaveChanges As Boolean = False)

        Dim pi_obj_tradeFloor As Trade_BL.TradeFloor
        pi_obj_tradeFloor = New Trade_BL.TradeFloor
        Dim dt_Search_Result As New DataTable
        Dim CriteriaSearch As String

        If Session(Session_str_UserName) <> "" Then    ' Member Logged in.
            CriteriaSearch = " ( Trade_Floor.[Trading_ID] = '" & Trade_ID & "') "
            'dt_Search_Result = pi_obj_tradeFloor.GetMemberTradeFloor(Session(Session_str_Portal_ID), Session(Session_str_UserName), , CriteriaSearch)
            If (lSaveChanges) Then
                dt_Search_Result = pi_obj_tradeFloor.GetMemberGroupedTradeFloor(Session(Session_str_Portal_ID), Session(Session_str_UserName), , CriteriaSearch)
            Else
                dt_Search_Result = pi_obj_tradeFloor.GetMemberTradeFloor(Session(Session_str_Portal_ID), Session(Session_str_UserName), , CriteriaSearch)
            End If

            If Not dt_Search_Result.Rows.Count > 0 Then     ' InValid Trading_ID (Transaction).
                Response.Redirect("PortalDefault.aspx?Main_Links_ID=1")
            End If

            ' Fill Posting Form..'
            Dim dr_Trader As DataRow = dt_Search_Result.Rows(0)

            '''''If Not Page.IsValid Then
            '''''    Exit Sub
            '''''End If
            If Not dr_Trader("Trade_Type").ToString() = "3" Then

                If ddlModel.SelectedItem.Text.Trim() = "Others" And txtModelNo.Text.Trim() = "" Then
                    lblModelValidator.Visible = True
                    Exit Sub
                Else
                    lblModelValidator.Visible = False
                End If

            End If

            ' Check if it is an Announcement.
            If dr_Trader("Trade_Type").ToString() = "3" Then
                ' Posting Announcement....
                pi_obj_tradeFloor.Trading_ID = Convert.ToInt32(Trade_ID)
                pi_obj_tradeFloor.post_heading = "BUY"      ' All Announcements are Buy Transactions.
                pi_obj_tradeFloor.Trade_Type = 3
                pi_obj_tradeFloor.Member_Id = Session(Session_str_UserName)
                pi_obj_tradeFloor.MobileSrNo = 0
                pi_obj_tradeFloor.ModelNo = String.Empty
                pi_obj_tradeFloor.OtherManufName = String.Empty
                pi_obj_tradeFloor.ManufCode = 1
                pi_obj_tradeFloor.Quantity = 0
                pi_obj_tradeFloor.Price = 0
                pi_obj_tradeFloor.CurrencyCode = 1
                pi_obj_tradeFloor.Spec = "EUROSPECS"
                pi_obj_tradeFloor.Warranty = "Other Warranty"
                pi_obj_tradeFloor.ProviderLogo = 0
                pi_obj_tradeFloor.Packaging = "Select..."
                pi_obj_tradeFloor.RequestDate = DateTime.Parse(DateTime.Now).AddHours(-4)
                pi_obj_tradeFloor.ShippingTerms = "Select.."
                pi_obj_tradeFloor.Country_ID = 1
                pi_obj_tradeFloor.Status = "Simfree"
                pi_obj_tradeFloor.StockLocation = String.Empty
                pi_obj_tradeFloor.Location = String.Empty
                pi_obj_tradeFloor.post_desc = txtComment.Text.Replace(System.Environment.NewLine, "<BR>")
            Else
                ' Posting Offers....
                ' Get the Form Values
                pi_obj_tradeFloor.Trading_ID = Convert.ToInt32(Trade_ID)
                pi_obj_tradeFloor.post_heading = IIf(rdoBuy.Checked = True, "BUY", "SELL")
                pi_obj_tradeFloor.Trade_Type = IIf(rdoPostComment.Checked = True, 3, IIf(rdoBuy.Checked = True, 1, 2))
                pi_obj_tradeFloor.Member_Id = Session(Session_str_UserName)

                If rdoPostComment.Checked = True Then
                    pi_obj_tradeFloor.MobileSrNo = 0
                Else
                    pi_obj_tradeFloor.MobileSrNo = Convert.ToDouble("0" & ddlModel.SelectedItem.Value.ToString())
                End If

                'If ddlModel.SelectedItem.Text.Trim() <> "Others" Then
                '    pi_obj_tradeFloor.ModelNo = ddlModel.SelectedItem.Text
                'ElseIf txtModelNo.Text.Trim <> "" Then
                '    pi_obj_tradeFloor.ModelNo = txtModelNo.Text
                'Else
                '    pi_obj_tradeFloor.ModelNo = "All"
                'End If
                If ddlModel.SelectedItem.Text.Trim() = "Others" And txtModelNo.Text.Trim() <> "" Then
                    pi_obj_tradeFloor.ModelNo = txtModelNo.Text
                Else
                    pi_obj_tradeFloor.ModelNo = String.Empty
                End If

                If ddlBrand.SelectedItem.Text.Trim() = "Others" And txtManufName.Text.Trim() <> "" Then
                    pi_obj_tradeFloor.OtherManufName = txtManufName.Text
                Else
                    pi_obj_tradeFloor.OtherManufName = String.Empty
                End If

                'If ddlBrand.SelectedItem.Text.Trim() <> "Others" Then
                '    pi_obj_tradeFloor.OtherManufName = ddlBrand.SelectedItem.Text
                'ElseIf txtManufName.Text.Trim <> "" Then
                '    pi_obj_tradeFloor.OtherManufName = txtManufName.Text
                'Else
                '    pi_obj_tradeFloor.OtherManufName = "All"
                'End If


                pi_obj_tradeFloor.ManufCode = ddlBrand.SelectedItem.Value

                If rdoPostComment.Checked = True Then
                    txtQuantity.Text = "0"
                    txtPrice.Text = "0"
                End If

                If txtQuantity.Text.Trim() <> "" Then
                    pi_obj_tradeFloor.Quantity = IIf(rdoPostComment.Checked = True, 0, txtQuantity.Text)
                Else
                    Page.Validate()
                    Exit Sub
                End If
                'pi_obj_tradeFloor.Quantity = txtQuantity.Text

                If txtPrice.Text.Trim() = "" Then
                    txtPrice.Text = 0
                End If

                pi_obj_tradeFloor.Price = CType(txtPrice.Text, Int64)
                pi_obj_tradeFloor.CurrencyCode = ddlCurrency.SelectedItem.Value
                pi_obj_tradeFloor.Spec = txtSpecs.Text.ToString
                pi_obj_tradeFloor.Warranty = txtWarranty.Text.ToString
                pi_obj_tradeFloor.ProviderLogo = ddlProviderLogo.SelectedItem.Value
                pi_obj_tradeFloor.Packaging = txtPackaging.Text.ToString
                pi_obj_tradeFloor.RequestDate = DateTime.Parse(DateTime.Now).AddHours(-4)
                pi_obj_tradeFloor.ShippingTerms = ddlShippingTerms.SelectedItem.Text
                pi_obj_tradeFloor.Country_ID = ddlCountry.SelectedItem.Value
                'pi_obj_tradeFloor.Status = ddlStatus.SelectedItem.Text
                pi_obj_tradeFloor.StockLocation = ddlStockLocation.SelectedItem.Text
                pi_obj_tradeFloor.Location = txtLocation.Text
                pi_obj_tradeFloor.post_desc = txtComment.Text.Replace(System.Environment.NewLine, "<BR>")

            End If
            If pi_obj_tradeFloor.Update(lSaveChanges) Then
                If (lSaveChanges) Then
                    Response.Redirect("PortalDefault.aspx?Main_Links_ID=6&sub_Links_ID=1")      ' HARDCODED '
                Else
                    Response.Redirect("PortalDefault.aspx?Main_Links_ID=6&sub_Links_ID=2")      ' HARDCODED '
                End If
            End If
            'If pi_obj_tradeFloor.Update() Then
            'Response.Redirect("PortalDefault.aspx?Main_Links_ID=6&sub_Links_ID=2")      ' HARDCODED '
            'End If
        End If

    End Sub
    'Private Sub ddlBrand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlBrand.SelectedIndexChanged
    '    'FillProduct()
    'End Sub
    Private Sub btnPostTF_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnPostTF.Click
        Dim nEditId As String
        If ((Request("Trade_ID") = Nothing) And (Session("nEditId") <> Nothing)) Then   ' Editting a group posting
            nEditId = Session("nEditId").ToString()
            Try
                If (Request("Trade_ID") = Nothing) Then '<> Nothing) Then
                    Session("nEditId") = Nothing
                    UpdatePostingDetails(nEditId, True)
                End If
            Catch ex As Exception
            End Try
        ElseIf (Request("Trade_ID") <> Nothing) Then    ' Editting an Announcement.
            UpdatePostingDetails(Request("Trade_ID").ToString(), False)
        Else                                            ' Editting an Offer.
            PostOffer()
            btnPostTF.ImageUrl = "../images/btn_Post_request.jpg"
        End If
        'PostOffer()
    End Sub
    Private Sub ibtnPosttoTF_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibtnPosttoTF.Click
        Dim pi_obj_tradeFloor As Trade_BL.TradeFloor
        If Session(Session_str_UserName) <> "" Then
            pi_obj_tradeFloor = New Trade_BL.TradeFloor
            pi_obj_tradeFloor.PostGroupedtoTradeFloor(Session(Session_str_UserName))
            Response.Redirect("PortalDefault.aspx?Main_Links_ID=4")      ' HARDCODED ' Trading Floor
        End If
    End Sub
    Private Sub btnShowSummary_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnShowSummary.Click
        ' Buy / Sell
        lblTradeType.Text = IIf(rdoBuy.Checked = True, "BUY", "SELL")
        ' Member ID
        lblMemberId.Text = Session(Session_str_UserName)
        ' Brand Number
        lblBrand.Text = ddlBrand.SelectedItem.Text
        ' 7610 / 6630
        lblModel.Text = IIf(txtModelNo.Text <> "", txtModelNo.Text, ddlModel.SelectedItem.Text)
        lblQuantity.Text = IIf(rdoPostComment.Checked = True, 0, txtQuantity.Text) 'IIf(chkPostComment.Checked = True, 0, CType(txtQuantity.Text, Int64))
        lblPrice.Text = IIf(rdoPostComment.Checked = True, 0, txtPrice.Text) 'IIf(chkPostComment.Checked = True, 0, CType(txtQuantity.Text, Int64))
        'lblStatus.Text = ddlStatus.SelectedItem.Text
        lblSpec.Text = txtSpecs.Text.ToString
        lblWarranty.Text = txtWarranty.Text.ToString
        lblPackage.Text = txtPackaging.Text.ToString
        lblRequestedFrom.Text = DateTime.Parse(txtDate.Text).ToShortDateString()
        lblShippingTerms.Text = ddlShippingTerms.SelectedItem.Text
        lblCountry.Text = ddlCountry.SelectedItem.Text
        lblStockLocation.Text = txtLocation.Text
        lblComment.Text = txtComment.Text
        TDSummaryView.Visible = True
        TDFormView.Visible = False
    End Sub
    Private Sub EnablePostingForms(ByVal lFlag As Boolean)
        TblDetails.Visible = lFlag

    End Sub
    Private Sub rdoPostComment_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoPostComment.CheckedChanged
        ChangeFormType()
    End Sub
    Private Sub rdoSell_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoSell.CheckedChanged
        ChangeFormType()

    End Sub
    Private Sub rdoBuy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoBuy.CheckedChanged
        ChangeFormType()
    End Sub
    Private Sub ChangeFormType()
        Dim flgEditting As Boolean = False

        If (Session("nEditId") <> Nothing) Then
            flgEditting = True
            rdoPostComment.Visible = False
            btnPostTF.ImageUrl = "../images/btn_admin_savechanges.jpg"
        End If

        If (rdoBuy.Checked) Then 'BUY
            rdoSell.Checked = False
            rdoPostComment.Checked = False
            EnablePostingForms(Not rdoPostComment.Checked)
            TblPostOffer.BgColor = "#eef3ff"
            pnlShippingDetails.Visible = False
            ImgD.ImageUrl = "../images/postform_c.gif"
            lblTypeComments.Text = "Add your Comments "
            lblAnnouncement.Text = "Comment: "
            If Not Request.QueryString("Trade_ID") <> "" Then
                chkGrouping.Visible = True

            End If
            btnPostTF.ImageUrl = "../images/btn_Post_request.jpg"

        ElseIf (rdoSell.Checked) Then 'SELL
            rdoBuy.Checked = False
            rdoPostComment.Checked = False
            EnablePostingForms(Not rdoPostComment.Checked)
            TblPostOffer.BgColor = "#eef3ff"
            pnlShippingDetails.Visible = True
            ImgD.ImageUrl = "../images/postform_d.gif"
            lblTypeComments.Text = "Add your Comments "
            lblAnnouncement.Text = "Comment: "
            If Not Request.QueryString("Trade_ID") <> "" Then
                chkGrouping.Visible = True

            End If
            btnPostTF.ImageUrl = "../images/btn_Post_request.jpg"

        ElseIf (rdoPostComment.Checked) Then  'Make Announcement
            rdoBuy.Checked = False
            rdoSell.Checked = False
            EnablePostingForms(Not rdoPostComment.Checked)
            TblPostOffer.BgColor = "#eeeeee"
            lblTypeComments.Text = "Type your Announcement "
            lblAnnouncement.Text = "Announcement: "
            chkGrouping.Visible = False
            btnPostTF.ImageUrl = "../images/btn_admin_postannounce.jpg"
            ImgD.ImageUrl = "../images/postform_a.gif"

        Else                                        ' BUY Posting - Default.
            rdoSell.Checked = False
            rdoPostComment.Checked = False
            EnablePostingForms(Not rdoPostComment.Checked)
            TblPostOffer.BgColor = "#eef3ff"
            pnlShippingDetails.Visible = False
            ImgD.ImageUrl = "../images/postform_c.gif"
            lblTypeComments.Text = "Add your Comments "
            lblAnnouncement.Text = "Comment: "
            If Not Request.QueryString("Trade_ID") <> "" Then
                chkGrouping.Visible = True

            End If
            btnPostTF.ImageUrl = "../images/btn_Post_request.jpg"
        End If

    End Sub
    Public Sub CVModel_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
        If ddlModel.SelectedItem.Text.Trim() = "Others" And args.Value.Trim() = "" Then
            args.IsValid = False
            'trOther2.Visible = True
            'trOther3.Visible = True
            CVModel.Visible = True
        End If
    End Sub
    Private Sub CvManuf_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
        If ddlBrand.SelectedItem.Text.Trim() = "Others" And args.Value.Trim() = "" Then
            args.IsValid = False
            'trOther2.Visible = True
            'trOther3.Visible = True
            CvManuf.Visible = True
        End If
    End Sub
    Private Sub DGTradeFloorView_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DGTradeFloorView.EditCommand
        Dim nEditId As Int32
        nEditId = Convert.ToInt32(e.Item.Cells(2).Text)
        Session("nEditId") = nEditId
        FillPostingDetails(nEditId, True)
        chkGrouping.Visible = False
        'IbtnSaveChanges.Visible = True
        btnPostTF.ImageUrl = "../images/btn_admin_savechanges.jpg"
        'btnPostTF.Visible = False
        IbtnUpdatePosting.Visible = False
        rdoPostComment.Visible = False
    End Sub
    Private Sub DGTradeFloorView_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DGTradeFloorView.DeleteCommand
        Dim nDelId As Int32
        nDelId = Convert.ToInt32(e.Item.Cells(2).Text)
        DeleteOffer(nDelId)
        Response.Redirect("PortalDefault.aspx?Main_Links_ID=6&sub_Links_ID=1")
    End Sub
    Private Sub DGTradeFloorView_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DGTradeFloorView.ItemDataBound

        Select Case e.Item.ItemType
            Case ListItemType.Item, ListItemType.AlternatingItem, ListItemType.EditItem

                Dim lbtnDelete As LinkButton
                lbtnDelete = e.Item.Cells(14).Controls(0)

                If Not (lbtnDelete Is Nothing) Then
                    lbtnDelete.Attributes.Add("onclick", "return confirm('Are you Sure you want to delete this Offer?');")
                End If

        End Select

    End Sub
    Private Sub DeleteOffer(ByVal nDelId As Int32)

        Dim pi_obj_tradeFloor As Trade_BL.TradeFloor
        pi_obj_tradeFloor = New Trade_BL.TradeFloor

        pi_obj_tradeFloor.Trading_ID = nDelId

        Try
            pi_obj_tradeFloor.Delete()

        Catch ex As Exception
            Throw ex
            Exit Sub
        End Try

    End Sub

End Class
