Public Class TradeFloor
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Table1 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents Table3 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents Table20 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents pnlShippingDetails As System.Web.UI.WebControls.Panel
    Protected WithEvents DGTradeFloorView As System.Web.UI.WebControls.DataGrid
    Protected WithEvents DataList1 As System.Web.UI.WebControls.DataList
    Protected WithEvents ddlProviderLogo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TblDetails As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tbl_buySell1 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents Radiobutton1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Radiobutton2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Textbox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Textbox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Textbox3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Textbox4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Textbox5 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Textbox6 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Textbox7 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Rangevalidator2 As System.Web.UI.WebControls.RangeValidator
    Protected WithEvents Requiredfieldvalidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents Requiredfieldvalidator2 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents Requiredfieldvalidator3 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents Requiredfieldvalidator4 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents Dropdownlist3 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Dropdownlist4 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Dropdownlist5 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Dropdownlist6 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Dropdownlist7 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Dropdownlist8 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Dropdownlist9 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Dropdownlist10 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Dropdownlist11 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Linkbutton1 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Linkbutton2 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Imagebutton1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Imagebutton2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents lblComments As System.Web.UI.WebControls.Label
    Protected WithEvents trTradeFloorView As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents TDSummaryView As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TDFormView As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents ibtnPosttoTF As System.Web.UI.WebControls.ImageButton
    Protected WithEvents RVPrice As System.Web.UI.WebControls.RangeValidator
    Protected WithEvents RFVQuantity As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RFVPrice As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents rdoBuy As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rdoSell As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rdoPostComment As System.Web.UI.WebControls.RadioButton
    Protected WithEvents ddlBrand As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlModel As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtPrice As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtModelNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtQuantity As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlCurrency As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlStatus As System.Web.UI.WebControls.DropDownList
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
    Protected WithEvents rblist As System.Web.UI.WebControls.RadioButtonList
    Protected WithEvents Table19 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tbl_buySell As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents TblPostOffer As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tbl_Comment As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents TblPhoneModel As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents TblStockSpecs As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents TblShippingDetails As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents TblPostingType As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents TD_ShippingDetails As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents RVQty As System.Web.UI.WebControls.RangeValidator
    Protected WithEvents lblTypeComments As System.Web.UI.WebControls.Label
    Protected WithEvents lblAnnouncement As System.Web.UI.WebControls.Label
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents lblModelValidator As System.Web.UI.WebControls.Label
    Protected WithEvents lblMsg As System.Web.UI.WebControls.Label
    Protected WithEvents ImgD As System.Web.UI.WebControls.Image
    Protected WithEvents CVModel As System.Web.UI.WebControls.CustomValidator
    Protected WithEvents hlnkCurrencyConverter As System.Web.UI.WebControls.HyperLink
    Protected WithEvents IbtnDelete As System.Web.UI.WebControls.ImageButton
    Protected WithEvents IbtnDeletePosting As System.Web.UI.WebControls.ImageButton
    Protected WithEvents IbtnSaveChanges As System.Web.UI.WebControls.ImageButton
    Protected WithEvents tdCharCounter As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents txtMoreSpecs As System.Web.UI.WebControls.TextBox
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
    Private pi_obj_MobileModel As New Trade_BL.MobileModel
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
        hlnkCurrencyConverter.Attributes.Add("onClick", "window.open('../HTMLPages/CurrConverter.htm','Curr','width=250,height=300');")
        If Session(Session_str_UserName) = "" Or Session(Session_str_UserName) Is Nothing Then
            Response.Redirect("PortalDefault.aspx?Main_Links_ID=24")
        End If

        ibtnPosttoTF.Attributes.Add("onclick", "return confirm('Are you sure you want to send Grouped Postings to Trading Floor?');")
        chkGrouping.Attributes.Add("onMouseover", "ddrivetip('By Checking this option, You will be able to <b>Post your stock as a Group</b> to Trading Floor','#DFDFFF', 300)")
        chkGrouping.Attributes.Add("onMouseout", "hideddrivetip()")
        chkGrouping.Attributes.Add("Style", "CURSOR: hand;")

        pi_obj_TradeFloor = New Trade_BL.TradeFloor
        Dim dt_TradeFloor As DataTable

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

        ChangeFormType()    ' for Disappearing rdoPostComment while changing Buy Editting to Sell Editting.
        If Request("Trade_ID") <> "" Then
            FillPostingDetails(Request("Trade_ID").ToString(), False)
            chkGrouping.Visible = False
            btnPostTF.ImageUrl = "../images/btn_admin_savechanges.jpg"
            IbtnUpdatePosting.Visible = False
            rdoPostComment.Visible = False
            Exit Sub
        ElseIf Session("nEditId") <> Nothing Then
            FillPostingDetails(Session("nEditId").ToString(), True)
            chkGrouping.Visible = False
            btnPostTF.ImageUrl = "../images/btn_admin_savechanges.jpg"
            IbtnUpdatePosting.Visible = False
            rdoPostComment.Visible = False
            Exit Sub
        End If

        FillCountry()
        IbtnUpdatePosting.Visible = False
        If Page.IsPostBack = False Then
            ' Fill Currency
            pi_obj_Currency = New Trade_BL.Currency
            dt_Currency = pi_obj_Currency.GetCurrency()
            ddlCurrency.DataSource = dt_Currency
            ddlCurrency.DataTextField = "Currency_Symbol"
            ddlCurrency.DataValueField = "Currency_Code"
            ddlCurrency.DataBind()
            ' Fill Brand
            FillBrand()
        End If

        FillModels()
    End Sub

    Private Sub FillPostingDetails(ByVal Trade_ID As String, ByVal lGrouped As Boolean)
        Dim dt_Search_Result As New DataTable
        Dim CriteriaSearch As String

        If MyBase.Sub_Links_ID > 0 And Session(Session_str_UserName) <> "" Then    ' Member Logged in.

            CriteriaSearch = " Trade_Floor.[Trading_ID] = '" & Trade_ID & "' "

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

            FillBrand()
            Dim liBrand As ListItem
            Dim liModel As ListItem
            liBrand = ddlBrand.Items.FindByText(dr_Trader("Brand"))
            ddlBrand.SelectedIndex = -1
            liBrand.Selected = True

            FillModels()

            Try
                liModel = ddlModel.Items.FindByText(dr_Trader("MODELNo"))
                ddlModel.SelectedIndex = -1
                liModel.Selected = True
            Catch ex As Exception
                liModel = ddlModel.Items.FindByText("Other Model")
                ddlModel.SelectedIndex = -1
                liModel.Selected = True
                txtModelNo.Text = dr_Trader("ModelNo")
            End Try

            If CType(dr_Trader("Quantity"), String) <> "" Then
                txtQuantity.Text = dr_Trader("Quantity")
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

            Dim liStatus As ListItem
            If dr_Trader("Status").ToString().Trim() <> "" Then
                liStatus = ddlStatus.Items.FindByText(dr_Trader("Status"))
                If Not liStatus Is Nothing Then
                    ddlStatus.SelectedIndex = -1
                    liStatus.Selected = True
                Else
                    ddlStatus.SelectedIndex = -1
                    ddlStatus.Items.FindByText("Select...").Selected = True  ' Default Status.
                End If
            End If
            txtMoreSpecs.Text = dr_Trader("MoreSpec").ToString()

            ' Extract Shipping Terms from the row item.
            Dim strShippingTerms As String
            strShippingTerms = dr_Trader("ShippingTerms").ToString().Trim()
            strShippingTerms = strShippingTerms.Substring(0, strShippingTerms.IndexOf("(") - 1)

            Dim liShippingTerms As ListItem
            liShippingTerms = ddlShippingTerms.Items.FindByText(strShippingTerms)
            If Not liShippingTerms Is Nothing Then
                ddlShippingTerms.SelectedIndex = -1
                liShippingTerms.Selected = True
            Else
                ddlShippingTerms.SelectedIndex = -1
                ddlShippingTerms.Items.FindByText("Select..").Selected = True  ' Default Warranty.
            End If

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

            txtComment.Text = dr_Trader("post_desc")

        End If
    End Sub

    Private Sub UpdatePostingDetails(ByVal Trade_ID As String, Optional ByVal lSaveChanges As Boolean = False)

        Dim pi_obj_tradeFloor As Trade_BL.TradeFloor
        pi_obj_tradeFloor = New Trade_BL.TradeFloor
        Dim dt_Search_Result As New DataTable
        Dim CriteriaSearch As String

        If Session(Session_str_UserName) <> "" Then    ' Member Logged in.
            CriteriaSearch = " Trade_Floor.[Trading_ID] = '" & Trade_ID & "' "

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

            If Not dr_Trader("Trade_Type").ToString() = "3" Then

                If ddlModel.SelectedItem.Text.Trim() = "Other Model" And txtModelNo.Text.Trim() = "" Then
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
                pi_obj_tradeFloor.ManufCode = 1
                pi_obj_tradeFloor.Quantity = 0
                pi_obj_tradeFloor.Price = 0
                pi_obj_tradeFloor.CurrencyCode = 1
                pi_obj_tradeFloor.MoreSpec = ""
                pi_obj_tradeFloor.ProviderLogo = 0
                pi_obj_tradeFloor.RequestDate = DateTime.Parse(DateTime.Now) '.AddHours(-4) ' HARDCODED GMT Time
                pi_obj_tradeFloor.ShippingTerms = "Select.."
                pi_obj_tradeFloor.Country_ID = 1
                pi_obj_tradeFloor.Status = "Simfree"
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

                If ddlModel.SelectedItem.Text.Trim() <> "Other Model" Then
                    pi_obj_tradeFloor.ModelNo = ddlModel.SelectedItem.Text
                ElseIf txtModelNo.Text.Trim <> "" Then
                    pi_obj_tradeFloor.ModelNo = txtModelNo.Text
                Else
                    pi_obj_tradeFloor.ModelNo = "All"
                End If

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

                If txtPrice.Text.Trim() = "" Then
                    txtPrice.Text = 0
                End If

                pi_obj_tradeFloor.Price = CType(txtPrice.Text, Int64)
                pi_obj_tradeFloor.CurrencyCode = ddlCurrency.SelectedItem.Value
                pi_obj_tradeFloor.MoreSpec = txtMoreSpecs.Text
                pi_obj_tradeFloor.RequestDate = DateTime.Parse(DateTime.Now) '.AddHours(-4) ' HARDCODED GMT Time
                pi_obj_tradeFloor.ShippingTerms = ddlShippingTerms.SelectedItem.Text
                pi_obj_tradeFloor.Country_ID = ddlCountry.SelectedItem.Value
                pi_obj_tradeFloor.Status = ddlStatus.SelectedItem.Text
                pi_obj_tradeFloor.post_desc = txtComment.Text.Replace(System.Environment.NewLine, "<BR>")

            End If
            If pi_obj_tradeFloor.Update(lSaveChanges) Then
                If (lSaveChanges) Then
                    Response.Redirect("PortalDefault.aspx?Main_Links_ID=6&sub_Links_ID=1")      ' HARDCODED '
                Else
                    Response.Redirect("PortalDefault.aspx?Main_Links_ID=6&sub_Links_ID=2")      ' HARDCODED '
                End If
            End If
        End If
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

    Private Sub PostOffer()

        If Not Page.IsValid Then
            Exit Sub
        End If

        If ddlModel.SelectedItem.Text.Trim() = "Other Model" And txtModelNo.Text.Trim() = "" And Not rdoPostComment.Checked Then
            CVModel.Visible = True
            lblModelValidator.Visible = True
            Exit Sub
        Else
            lblModelValidator.Visible = False
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

        If ddlModel.SelectedItem.Text.Trim() <> "Other Model" Then
            pi_obj_tradeFloor.ModelNo = ddlModel.SelectedItem.Text
        ElseIf txtModelNo.Text.Trim <> "" Then
            pi_obj_tradeFloor.ModelNo = txtModelNo.Text
        Else
            pi_obj_tradeFloor.ModelNo = "All"
        End If

        pi_obj_tradeFloor.ManufCode = ddlBrand.SelectedItem.Value

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
        pi_obj_tradeFloor.MoreSpec = txtMoreSpecs.Text
        If (chkGrouping.Checked = False) Or (rdoPostComment.Checked = True) Then
            pi_obj_tradeFloor.RequestDate = DateTime.Parse(DateTime.Now) '.AddHours(-4) ' HARDCODED GMT Time
        Else
            pi_obj_tradeFloor.RequestDate = DateTime.Parse("1/1/1753 12:00:00 AM") ' HARDCODED '
        End If
        pi_obj_tradeFloor.ShippingTerms = ddlShippingTerms.SelectedItem.Text
        pi_obj_tradeFloor.post_desc = txtComment.Text.Replace(System.Environment.NewLine, "<BR>")
        pi_obj_tradeFloor.Country_ID = ddlCountry.SelectedItem.Value
        pi_obj_tradeFloor.Status = ddlStatus.SelectedItem.Text

        pi_obj_tradeFloor.Status = ddlStatus.SelectedItem.Text

        Try
            pi_obj_tradeFloor.Insert()

        Catch ex As Exception
            Throw ex
            Exit Sub
        Finally
            pi_obj_tradeFloor = Nothing
            If (chkGrouping.Checked = False) Or (rdoPostComment.Checked = True) Then
                Response.Redirect("PortalDefault.aspx?Main_Links_ID=4")                 ' HARDCODED 'Trading Floor
            Else
                Response.Redirect("PortalDefault.aspx?Main_Links_ID=6&sub_Links_ID=1")  ' HARDCODED 'Posting Form
            End If
        End Try
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
        li.Value = "253"
        ddlCountry.Items.Add(li)

        Dim liSelection As ListItem
        liSelection = ddlCountry.Items.FindByValue(dt_Member.Rows(0)("Country_ID"))
        liSelection.Selected = True
    End Sub

    Private Sub FillBrand()
        Dim dt_Brand As New DataTable
        pi_obj_Brand = New Trade_BL.Manufacturer
        dt_Brand = pi_obj_Brand.GetManufacturer()

        ddlBrand.DataSource = dt_Brand
        ddlBrand.DataTextField = "ManufName"
        ddlBrand.DataValueField = "ManufCode"
        ddlBrand.DataBind()

        FillModels()
    End Sub

    Private Sub FillModels()
        Dim li As ListItem
        Dim dt_MobileModel As New DataTable
        pi_obj_MobileModel = New Trade_BL.MobileModel
        dt_MobileModel = pi_obj_MobileModel.GetBrandMobileModel(ddlBrand.SelectedItem.Value)

        ddlModel.DataSource = dt_MobileModel
        ddlModel.DataTextField = "ModelNo"
        ddlModel.DataValueField = "SrNo"
        ddlModel.DataBind()

        li = New ListItem
        li.Text = "Other Model"
        li.Value = "0"
        ddlModel.Items.Add(li)

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
            pnlShippingDetails.Visible = False
            ImgD.ImageUrl = "../images/postform_c.gif"
            lblTypeComments.Text = "Add your Comments "
            lblAnnouncement.Text = "Comment: "
            txtComment.Height = Unit.Parse("60")
            txtComment.Width = Unit.Parse("350")
            txtComment.MaxLength = 250
            tdCharCounter.InnerHtml = "<SCRIPT>displaylimit('', 'TradeMainCtrl__ctl6_txtComment', 250)</SCRIPT>"
            If Not Request.QueryString("Trade_ID") <> "" Then   ' Editting an Announcement.
                chkGrouping.Visible = True
            End If

            btnPostTF.ImageUrl = "../images/btn_Post_request.jpg"

        ElseIf (rdoSell.Checked) Then 'SELL
            rdoBuy.Checked = False
            rdoPostComment.Checked = False
            EnablePostingForms(Not rdoPostComment.Checked)
            pnlShippingDetails.Visible = True
            ImgD.ImageUrl = "../images/postform_d.gif"
            lblTypeComments.Text = "Add your Comments "
            lblAnnouncement.Text = "Comment: "
            txtComment.Height = Unit.Parse("60")
            txtComment.Width = Unit.Parse("350")
            txtComment.MaxLength = 250
            tdCharCounter.InnerHtml = "<SCRIPT>displaylimit('', 'TradeMainCtrl__ctl6_txtComment', 250)</SCRIPT>"
            If Not Request.QueryString("Trade_ID") <> "" Then
                chkGrouping.Visible = True
            End If

            If (Not flgEditting) Then
                btnPostTF.ImageUrl = "../images/btn_Post_request.jpg"
            End If

        ElseIf (rdoPostComment.Checked) Then  'Make Announcement
            rdoBuy.Checked = False
            rdoSell.Checked = False
            EnablePostingForms(Not rdoPostComment.Checked)
            TblPostOffer.BgColor = "#eeeeee"
            lblTypeComments.Text = "Type your Announcement "
            lblAnnouncement.Text = "Announcement: "
            chkGrouping.Visible = False
            If (Not flgEditting) Then
                btnPostTF.ImageUrl = "../images/btn_admin_postannounce.jpg"
            End If
            ImgD.ImageUrl = "../images/postform_a.gif"
            txtComment.Height = Unit.Parse("150")
            txtComment.MaxLength = 1000
            tdCharCounter.InnerHtml = "<SCRIPT>displaylimit('', 'TradeMainCtrl__ctl6_txtComment', 1000)</SCRIPT>"

        Else                                    ' BUY Posting - Default.
            rdoSell.Checked = False
            rdoPostComment.Checked = False
            EnablePostingForms(Not rdoPostComment.Checked)
            TblPostOffer.BgColor = "#eef3ff"
            pnlShippingDetails.Visible = False
            ImgD.ImageUrl = "../images/postform_c.gif"
            lblTypeComments.Text = "Add your Comments "
            lblAnnouncement.Text = "Comment: "
            txtComment.Height = Unit.Parse("60")
            txtComment.Width = Unit.Parse("350")
            txtComment.MaxLength = 250
            tdCharCounter.InnerHtml = "<SCRIPT>displaylimit('', 'TradeMainCtrl__ctl6_txtComment', 250)</SCRIPT>"
            If Not Request.QueryString("Trade_ID") <> "" Then
                chkGrouping.Visible = True
            End If
            btnPostTF.ImageUrl = "../images/btn_Post_request.jpg"
        End If

    End Sub

    Private Sub EnablePostingForms(ByVal lFlag As Boolean)
        TblDetails.Visible = lFlag
    End Sub

    Private Sub ImgbtnAdd_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        PostOffer()
    End Sub

    Private Sub ImgbtnCancel_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnCancel.Click
        Session("nEditId") = Nothing
        Response.Redirect("PortalDefault.aspx?Main_Links_ID=6&sub_Links_ID=2")      ' HARDCODED '
    End Sub

    Private Sub ibtnPosttoTF_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibtnPosttoTF.Click
        Dim pi_obj_tradeFloor As Trade_BL.TradeFloor
        If Session(Session_str_UserName) <> "" Then
            pi_obj_tradeFloor = New Trade_BL.TradeFloor
            pi_obj_tradeFloor.PostGroupedtoTradeFloor(Session(Session_str_UserName))
            Response.Redirect("PortalDefault.aspx?Main_Links_ID=4")      ' HARDCODED ' Trading Floor
        End If
    End Sub

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
    End Sub

    Public Sub CVModel_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles CVModel.ServerValidate
        If ddlModel.SelectedItem.Text.Trim() = "Other Model" And args.Value.Trim() = "" Then
            args.IsValid = False
            CVModel.Visible = True
        End If
    End Sub

    Private Sub IbtnUpdatePosting_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles IbtnUpdatePosting.Click
        UpdatePostingDetails(Request.QueryString("Trade_ID").ToString())
    End Sub

    Private Sub ddlBrand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlBrand.SelectedIndexChanged
        FillModels()
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

    Private Sub DGTradeFloorView_PreRender(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGTradeFloorView.PreRender
        Dim dgItem As DataGridItem

        For Each dgItem In DGTradeFloorView.Items
            If (dgItem.ItemIndex > 0 And dgItem.ItemIndex < DGTradeFloorView.Items.Count) Then

                dgItem.Cells(0).Visible = False
                dgItem.Cells(1).Visible = False

            End If
        Next

        DGTradeFloorView.Items(0).Cells(0).RowSpan = DGTradeFloorView.Items.Count + 1
        DGTradeFloorView.Items(0).Cells(1).RowSpan = DGTradeFloorView.Items.Count + 1
        DGTradeFloorView.Items(0).Cells(0).BackColor = System.Drawing.Color.LightBlue
    End Sub

    Private Sub DGTradeFloorView_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DGTradeFloorView.DeleteCommand
        Dim nDelId As Int32
        nDelId = Convert.ToInt32(e.Item.Cells(2).Text)
        DeleteOffer(nDelId)
        Response.Redirect("PortalDefault.aspx?Main_Links_ID=6&sub_Links_ID=1")
    End Sub

    Private Sub DGTradeFloorView_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DGTradeFloorView.EditCommand
        Dim nEditId As Int32
        nEditId = Convert.ToInt32(e.Item.Cells(2).Text)
        Session("nEditId") = nEditId
        FillPostingDetails(nEditId, True)
        chkGrouping.Visible = False
        btnPostTF.ImageUrl = "../images/btn_admin_savechanges.jpg"
        IbtnUpdatePosting.Visible = False
        rdoPostComment.Visible = False
    End Sub

    Private Sub DGTradeFloorView_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DGTradeFloorView.ItemDataBound

        Select Case e.Item.ItemType
            Case ListItemType.Item, ListItemType.AlternatingItem, ListItemType.EditItem

                Dim lbtnDelete As LinkButton
                lbtnDelete = e.Item.Cells(12).Controls(0)

                If Not (lbtnDelete Is Nothing) Then
                    lbtnDelete.Attributes.Add("onclick", "return confirm('Are you Sure you want to delete this Offer?');")
                End If

        End Select

    End Sub

End Class
