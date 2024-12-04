Public Class TradeFloorView
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents DGTradeFloorView As System.Web.UI.WebControls.DataGrid
    Protected WithEvents ibtnDelete As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents pnlDetails As System.Web.UI.WebControls.Panel
    'Protected WithEvents pnlEditPosting As System.Web.UI.WebControls.Panel
    Protected WithEvents pnlPostingDetails As System.Web.UI.WebControls.Panel
    Protected WithEvents pnlShippingDetails As System.Web.UI.WebControls.Panel
    Protected WithEvents trShippingTerms As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents trStockLocation As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents lblPrice As System.Web.UI.WebControls.Label
    Protected WithEvents lblWarranty As System.Web.UI.WebControls.Label
    Protected WithEvents lblPackaging As System.Web.UI.WebControls.Label
    Protected WithEvents lblShippingTerms As System.Web.UI.WebControls.Label
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents lblStockLocation As System.Web.UI.WebControls.Label
    Protected WithEvents TraderDetailData As TraderDetails
    Protected WithEvents TD1 As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TD2 As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TDSeparator As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TDSearch As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TD3 As System.Web.UI.HtmlControls.HtmlTableCell
    'Protected WithEvents Label7 As System.Web.UI.WebControls.Label ' Commented out from HTML View.. 21/03/2006
    'Protected WithEvents TDTraderDetails As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TDTradeFloorView As System.Web.UI.HtmlControls.HtmlTableCell
    'Protected WithEvents dg As System.Web.UI.WebControls.DataGrid
    'Protected WithEvents dg1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents ImageButton1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ddlModel As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlLastPostings As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DDLCountry As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Imagebutton2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents pnlContacts As System.Web.UI.WebControls.Panel
    Protected WithEvents chkbuy1 As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chkSell1 As System.Web.UI.WebControls.CheckBox
    Protected WithEvents ddlBrand1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents chkbuy As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chkSell As System.Web.UI.WebControls.CheckBox
    Protected WithEvents ddlBrand0 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlModel0 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlLastPostings0 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DDLCountry0 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlModel1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlLastPostings1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DDLCountry1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlBrand As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Table1 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents TblSearchWizard As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents TblDataGrid As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents ImgGo As System.Web.UI.WebControls.ImageButton
    Protected WithEvents TDSearchForm As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents chkAnnouncement As System.Web.UI.WebControls.CheckBox
    'Protected WithEvents ImageButton3 As System.Web.UI.WebControls.ImageButton
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
    Private pi_obj_TradeFloor As Trade_BL.TradeFloor
    Private pi_obj_MobileModel As Trade_BL.MobileModel
    Private pi_obj_Brand As Trade_BL.Manufacturer
    Private pi_obj_Country As Trade_BL.Country
    'Private pi_obj_Currency As Trade_BL.Currency
    Private pi_Member_Profile_ID As String
    Dim dt_Search_Result As DataTable
#End Region

#Region "Properties"
    Public Property Member_Profile_ID() As String
        Get
            Return pi_Member_Profile_ID
        End Get
        Set(ByVal Value As String)
            pi_Member_Profile_ID = Value
        End Set
    End Property
#End Region

#Region "Private Constants"
    Private Const pi_DLLCountry_DataTextField As String = "Country_Name"
    Private Const pi_DLLCountry_DataValueField As String = "Country_ID1"
    'Private Const pi_Brand_Up As Int32 = 0
    'Private Const pi_Brand_Down As Int32 = 1
    'Private Const pi_Model_Up As Int32 = 2
    'Private Const pi_Model_Down As Int32 = 3
    'Private Const pi_Quantity_Up As Int32 = 4
    'Private Const pi_Quantity_Down As Int32 = 5
    'Private Const pi_Buy As Int32 = 6
    'Private Const pi_Sell As Int32 = 7
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dt_Filtered As New DataTable
        Me.ID = "TFViewCtrl"
        pi_obj_TradeFloor = New Trade_BL.TradeFloor
        Member_Profile_ID = 2
        If Page.IsPostBack = False Then

            FillCountry()
            FillBrand()

            If Request.QueryString("ManufCode") <> "" And Request.QueryString("MobileSrNo") <> "" Then
                chkbuy.Checked = True
                chkSell.Checked = True
                chkAnnouncement.Checked = True

                ddlBrand.SelectedItem.Value = Request("ManufCode")
                FillModels()

                ddlModel.SelectedItem.Value = Request("MobileSrNo")
                FilterGo()

                Exit Sub

            End If
            FilterGo()
        End If

    End Sub
    Private Sub ImgGo_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgGo.Click
        FilterGo()
    End Sub
    Public Sub FilterGo()

        Dim dt_Search_Result As New DataTable
        Dim CriteriaSearch As String
        dt_Search_Result = pi_obj_TradeFloor.GetMemberTradeFloor(Session(Session_str_Portal_ID), "", (IIf(ddlLastPostings.SelectedItem.Value <= 10, False, True)), GetSearchCriteria())
        DGTradeFloorView.DataSource = dt_Search_Result
        DGTradeFloorView.DataKeyField = "Member_ID"
        DGTradeFloorView.DataBind()

    End Sub
    Private Sub FillCountry()
        pi_obj_Country = New Trade_BL.Country
        DDLCountry.DataSource = pi_obj_Country.GetCountries()
        DDLCountry.DataTextField = pi_DLLCountry_DataTextField
        DDLCountry.DataValueField = pi_DLLCountry_DataValueField
        DDLCountry.DataBind()
        Dim li As ListItem
        li = New ListItem
        li.Text = "All"
        li.Value = "0"
        DDLCountry.Items.Add(li)
        DDLCountry.SelectedIndex = DDLCountry.Items.Count - 1
        pi_obj_Country = Nothing
    End Sub
    Private Sub FillBrand()

        Dim dt_Brand As New DataTable
        pi_obj_Brand = New Trade_BL.Manufacturer
        dt_Brand = pi_obj_Brand.GetManufacturer()

        ddlBrand.DataSource = dt_Brand
        ddlBrand.DataTextField = "ManufName"
        ddlBrand.DataValueField = "ManufCode"
        ddlBrand.DataBind()
        'Ali Remote Scripting.
        'ddlBrand.Attributes.Add("onChange", "javascript:change(this);")
        'Ali Remote Scripting.
        Dim li As ListItem
        li = New ListItem
        li.Text = "All"
        li.Value = "0"
        ddlBrand.Items.Add(li)
        ddlBrand.SelectedIndex = ddlBrand.Items.Count - 1
        'Ali Remote Scripting.
        FillModels()
        'Ali Remote Scripting.
        pi_obj_Brand = Nothing

    End Sub
    Private Sub FillModels()
        Dim dt_MobileModel As New DataTable
        pi_obj_MobileModel = New Trade_BL.MobileModel
        Dim li As ListItem
        li = New ListItem
        li.Text = "All"
        li.Value = "0"
        ddlModel.Items.Clear()
        ddlModel.Items.Add(li)
        ddlModel.SelectedIndex = ddlModel.Items.Count - 1
        'GenerateScript(dt_MobileModel)
        pi_obj_MobileModel = Nothing
    End Sub
    'Public Sub GenerateScript(ByVal dt_MobileModel As DataTable)
    '    ''After binding  model v have to populate the code to write 
    '    Dim sql As String
    '    Dim strFn As String

    '    strFn = "function change(cbo){" & vbCrLf & _
    '      " var x; " & vbCrLf & "x=cbo.options[cbo.selectedIndex].text;"

    '    strFn = strFn & "for (var i = document.Form1.TradeMainCtrl_TFViewCtrl_ddlModel." & _
    '     "options.length; i >= 0; i--){" & vbCrLf & _
    '     "document.Form1.TradeMainCtrl_TFViewCtrl_ddlModel.options[i] = null;" & vbCrLf
    '    strFn = strFn & "}" & vbCrLf & _
    '     "if (cbo.options[cbo.selectedIndex].value==0" & "){" & vbCrLf
    '    strFn = strFn & "document.Form1.TradeMainCtrl_TFViewCtrl_ddlModel.options[" & _
    '     "document.Form1.TradeMainCtrl_TFViewCtrl_ddlModel.options.length] = new Option('All','0');" & vbCrLf
    '    Dim strName As String
    '    'Do While DR.Read
    '    For nCounter As Integer = 0 To dt_MobileModel.Rows.Count - 1
    '        If strName <> dt_MobileModel.Rows(nCounter)("ManufCode") Then
    '            strName = dt_MobileModel.Rows(nCounter)("ManufCode")
    '            strFn = strFn & "}" & vbCrLf & _
    '              "if (cbo.options[cbo.selectedIndex].value==" & _
    '            dt_MobileModel.Rows(nCounter)("ManufCode") & "){" & vbCrLf

    '            strFn = strFn & "document.Form1.TradeMainCtrl_TFViewCtrl_ddlModel.options[" & _
    '             "document.Form1.TradeMainCtrl_TFViewCtrl_ddlModel.options.length] = new Option('All','0');" & vbCrLf
    '        End If
    '        strFn = strFn & "document.Form1.TradeMainCtrl_TFViewCtrl_ddlModel.options[" & _
    '         "document.Form1.TradeMainCtrl_TFViewCtrl_ddlModel.options.length] = new Option('" & _
    '         dt_MobileModel.Rows(nCounter)("ModelNo") & "','" & dt_MobileModel.Rows(nCounter)("SrNo") & "');" & vbCrLf
    '    Next
    '    'Loop
    '    strFn = strFn & vbCrLf & "}" & vbCrLf & "}" & vbCrLf
    '    Response.Write("<SCRIPT LANGUAGE=""JavaScript"">" & vbCrLf)
    '    Response.Write(strFn & vbCrLf & "</SCRIPT>" & vbCrLf)
    '    'cmd1.Connection.Close()
    'End Sub

#Region "Defining Search Criterias"
    'Public Function getQuantityCriteria() As String
    '    Dim intQtyFrom As Integer
    '    Dim intQtyTo As Integer
    '    Try
    '        intQtyFrom = CType(txtQuantityFrom.Text, Integer)
    '    Catch ex As Exception
    '        intQtyFrom = 0
    '    End Try

    '    Try
    '        intQtyTo = CType(txtQuantityTo.Text, Integer)
    '    Catch ex As Exception
    '        intQtyTo = 0
    '    End Try

    '    If intQtyFrom = 0 And intQtyTo = 0 Then
    '        Return ""
    '    ElseIf intQtyFrom <> 0 And intQtyTo <> 0 Then
    '        Return " AND (Quantity >=" & intQtyFrom & " AND Quantity <=" & intQtyTo & ") "
    '    ElseIf intQtyFrom <> 0 Then
    '        Return " AND Quantity >=" & intQtyFrom & " "
    '    ElseIf intQtyTo <> 0 Then
    '        Return " AND Quantity <=" & intQtyTo & " "
    '    End If

    'End Function
    'Public Function getPriceCriteria() As String
    '    Dim dblPriceFrom As Double
    '    Dim dblPriceTo As Double
    '    Dim strcurrency As String

    '    Try
    '        dblPriceFrom = CType(txtPriceFrom.Text, Double)
    '    Catch ex As Exception
    '        dblPriceFrom = 0
    '    End Try

    '    Try
    '        dblPriceTo = CType(txtPriceTo.Text, Double)
    '    Catch ex As Exception
    '        dblPriceTo = 0
    '    End Try
    '    If dblPriceFrom > 0 Or dblPriceTo > 0 Then
    '        strcurrency = " AND CurrencyCode = " & ddlCurrency.SelectedItem.Value
    '    Else
    '        strcurrency = ""
    '    End If

    '    If dblPriceFrom = 0 And dblPriceTo = 0 Then
    '        Return strcurrency & ""
    '    ElseIf dblPriceFrom <> 0 And dblPriceTo <> 0 Then
    '        Return strcurrency & " AND (CostPrice >=" & dblPriceFrom & " AND CostPrice <=" & dblPriceTo & ") "
    '    ElseIf dblPriceFrom <> 0 Then
    '        Return strcurrency & " AND CostPrice >=" & dblPriceFrom & " "
    '    ElseIf dblPriceTo <> 0 Then
    '        Return strcurrency & " AND CostPrice <=" & dblPriceTo & " "
    '    End If

    'End Function
    'Public Function getSpecsCriteria() As String
    '    If ddlspecs.SelectedItem.Value = 0 Then
    '        Return ""
    '    Else
    '        Return " AND Spec ='" & ddlspecs.SelectedItem.Text & "' "
    '    End If
    'End Function
    'Public Function getWarrantyCriteria() As String
    '    If ddlWarranty.SelectedItem.Value = 0 Then
    '        Return ""
    '    Else
    '        Return " AND Warranty ='" & ddlWarranty.SelectedItem.Text & "' "
    '    End If
    'End Function
    'Public Function getPackagingCriteria() As String
    '    If ddlPackaging.SelectedItem.Value = 0 Then
    '        Return ""
    '    Else
    '        Return " AND Packaging ='" & ddlPackaging.SelectedItem.Text & "' "
    '    End If
    'End Function
    'Public Function getShippingCriteria() As String
    '    If ddlShippingTerms.SelectedItem.Value = 0 Then
    '        Return ""
    '    Else
    '        Return " AND ShippingTerms ='" & ddlShippingTerms.SelectedItem.Text & "' "
    '    End If
    'End Function
    'Public Function getProviderCriteria() As String
    '    If ddlProviderLogo.SelectedItem.Value = 0 Then
    '        Return ""
    '    ElseIf ddlProviderLogo.SelectedItem.Value = 1 Then
    '        Return " AND ProviderLogo = 1 "
    '    ElseIf ddlProviderLogo.SelectedItem.Value = 2 Then
    '        Return " AND ProviderLogo = 0 "
    '    End If
    'End Function
    'Public Function getCountryCriteria() As String
    '    If DDLCountry.SelectedItem.Value = 0 Then
    '        Return ""
    '    Else
    '        Return " AND Country_Name = '" & DDLCountry.SelectedItem.Text & "%'"
    '    End If
    'End Function
    'Public Function getSort() As String
    '    Select Case ddlSort.SelectedItem.Value
    '        Case pi_Brand_Up
    '            'order by brand asc
    '            Return "brand asc"
    '        Case pi_Brand_Down
    '            'order by brand desc
    '            Return "brand asc"
    '        Case pi_Model_Up
    '            'order by brand asc
    '            Return "Model asc"
    '        Case pi_Model_Down
    '            'order by brand desc
    '            Return "Model asc"
    '        Case pi_Quantity_Up
    '            'order by quantity asc
    '            Return "quantity asc"
    '        Case pi_Quantity_Down
    '            'order by quantity desc
    '            Return "quantity Desc"
    '        Case pi_Buy
    '            Return "Trade_Type Asc"
    '        Case pi_Sell
    '            Return "Trade_Type Desc"
    '    End Select
    'End Function
    Public Function getSQLDate() As String
        Return DateTime.Now.Month & "-" & DateTime.Now.Day & "-" & DateTime.Now.Year
    End Function
    Public Function getPostingTime() As String
        '''''Select Case ddlLastPostings.SelectedItem.Value
        '''''    Case -1 'All
        '''''        Return ""
        '''''    Case 0 'Today
        '''''        Return " AND PostingDateTime_DayDiff = 0 "
        '''''    Case 1 'Yesterday and Today
        '''''        Return " AND PostingDateTime_DayDiff <= 1 "
        '''''    Case 7 'Last Weeks
        '''''        Return " AND PostingDateTime_DayDiff <= 7 "
        '''''    Case 14 'Last 2 Weeks
        '''''        Return " AND PostingDateTime_DayDiff <= 14 "
        '''''    Case 21 'Last 3 Weeks
        '''''        Return " AND PostingDateTime_DayDiff <= 21 "
        '''''    Case 101 'Last Months
        '''''        Return " AND PostingDateTime_MonthDiff <= 1 "
        '''''    Case 102 'Last 3 Months
        '''''        Return " AND PostingDateTime_MonthDiff <= 3 "
        '''''    Case 102 'Last 6 Months
        '''''        Return " AND PostingDateTime_MonthDiff <= 6 "
        '''''End Select
        Select Case ddlLastPostings.SelectedItem.Value
            Case -1 'All
                Return ""
            Case 0 'Today
                Return " ( DATEDIFF ( day , Trade_Floor.[RequestDate] , getdate()) = 0 ) "
            Case 1 'Yesterday and Today
                Return " ( DATEDIFF ( day , Trade_Floor.[RequestDate] , getdate()) <= 1 ) "
            Case 3 'Last 3 Days
                Return " ( DATEDIFF ( day , Trade_Floor.[RequestDate] , getdate()) <= 3 ) "
            Case 7 'Last Weeks
                Return " ( DATEDIFF ( day , Trade_Floor.[RequestDate] , getdate()) <= 7 ) "
            Case 14 'Last 2 Weeks
                Return " ( DATEDIFF ( day , Trade_Floor.[RequestDate] , getdate()) <= 14 ) "
            Case 21 'Last 3 Weeks
                Return " ( DATEDIFF ( day , Trade_Floor.[RequestDate] , getdate()) <= 21 ) "
            Case 101 'Last Months
                Return " ( DATEDIFF ( month , Trade_Floor.[RequestDate] , getdate()) <= 1 ) "
            Case 102 'Last 3 Months
                Return " ( DATEDIFF ( month , Trade_Floor.[RequestDate] , getdate()) <= 3 ) "
            Case 150 'Last 6 Months
                Return " ( 1=1 ) "
        End Select

    End Function
#End Region

    Private Sub GroupColumn(ByRef dgMonitor As DataGrid, ByVal ColumnIndex As Int32, ByVal ColumnToHide As Int32, Optional ByVal Showcomment As Boolean = False)
        Dim ItemIndex As Int32 = 0
        Dim dgItem As DataGridItem
        Dim irowspan As Int32
        Dim iColumnCounter As Int32
        Dim strTimeStamp As String
        Dim strMTimeStamp As String
        Dim txtTimeStamp As Label
        Dim txtMTimeStamp As Label

        Dim pnl As Panel
        If Showcomment = True Then
            For Each dgItem In dgMonitor.Items
                If dgItem.ItemIndex >= 0 Then
                    'dgItem.Cells(2).BackColor = System.Drawing.Color.LightBlue
                    If dgItem.Cells(dgItem.Cells.Count - 1).Text = "3" Then 'means comment
                        For iColumnCounter = 4 To dgItem.Cells.Count - 1
                            dgItem.Cells(iColumnCounter).Visible = False
                        Next
                        dgItem.Cells(13).FindControl("Table_Detail").Visible = False
                        dgItem.Cells(13).FindControl("pnlPostingDetails").Visible = True      ' Comments
                        'dgItem.Cells(13).FindControl("lblAnnouncement").Visible = True      ' Comments
                        dgItem.Cells(13).FindControl("pnlDetails").Visible = False          ' Details Panel
                        dgItem.Cells(13).Style.Add("padding-left", "60px")
                        dgItem.Cells(13).Style.Add("padding-Top", "10px")
                        dgItem.Cells(13).Style.Add("padding-Bottom", "10px")
                        dgItem.Cells(13).Style.Add("padding-right", "60px")
                        dgItem.Cells(13).Style.Add("text-align", "left")
                        dgItem.Cells(13).Visible = True
                        dgItem.Cells(13).ColumnSpan = 8
                        dgItem.Cells(14).Visible = True
                    Else
                        dgItem.Cells(13).ColumnSpan = 2
                    End If
                End If
            Next
            Exit Sub
        End If
        irowspan = 2
        For Each dgItem In dgMonitor.Items
            If (dgItem.ItemIndex > 0 And dgItem.ItemIndex < dgMonitor.Items.Count - 1) Then
                txtMTimeStamp = CType(dgMonitor.Items(dgItem.ItemIndex - 1).Cells(14).FindControl("Label8"), Label)
                txtTimeStamp = CType(dgItem.Cells(14).FindControl("Label8"), Label)
                If ((dgItem.Cells(ColumnIndex).Text = dgMonitor.Items(dgItem.ItemIndex - 1).Cells(ColumnIndex).Text) And (dgItem.Cells(dgItem.Cells.Count - 1).Text <> "3") And (dgMonitor.Items(dgItem.ItemIndex - 1).Cells(dgItem.Cells.Count - 1).Text <> "3") And (CType(txtTimeStamp.Text, String) = CType(txtMTimeStamp.Text, String))) Then
                    'dgItem.Cells(ColumnToHide).Visible = False
                    dgItem.Cells(ColumnToHide + 1).Visible = False
                    dgItem.Cells(ColumnToHide + 12).Visible = False
                    'dgMonitor.Items(ItemIndex).Cells(ColumnToHide).RowSpan = dgMonitor.Items(ItemIndex).Cells(ColumnIndex).RowSpan + irowspan
                    dgMonitor.Items(ItemIndex).Cells(ColumnToHide + 1).RowSpan = dgMonitor.Items(ItemIndex).Cells(ColumnIndex).RowSpan + irowspan
                    dgMonitor.Items(ItemIndex).Cells(ColumnToHide + 12).RowSpan = dgMonitor.Items(ItemIndex).Cells(ColumnIndex).RowSpan + irowspan
                    irowspan = irowspan + 1
                ElseIf (dgMonitor.Items(dgItem.ItemIndex - 1).Cells(ColumnIndex).Visible = True) Then
                    ItemIndex = dgItem.ItemIndex
                    irowspan = 2
                    If (CType(dgItem.Cells(14).FindControl("Label8"), Label).Text <> dgMonitor.Items(dgItem.ItemIndex - 1).Cells(dgItem.Cells.Count - 1).Text()) Then
                        FillGridRow(dgItem, True)
                    End If
                End If
            End If
        Next
    End Sub
    Private Function GetSearchCriteria() As String

        Dim CriteriaSearch As String

        CriteriaSearch = ""

        If chkbuy.Checked = True Then
            CriteriaSearch = CriteriaSearch & " ( Trade_Floor.Trade_Type = '1' ) "
        End If

        If chkSell.Checked = True Then
            If CriteriaSearch.Trim() = "" Then
                CriteriaSearch = " ( Trade_Floor.Trade_Type = '2' ) "
            Else
                CriteriaSearch = CriteriaSearch & " OR ( Trade_Floor.Trade_Type = '2' ) "
            End If
        End If

        If chkAnnouncement.Checked = True Then
            If CriteriaSearch.Trim() = "" Then
                CriteriaSearch = " ( Trade_Floor.Trade_Type = '3' ) "
            Else
                CriteriaSearch = CriteriaSearch & " OR ( Trade_Floor.Trade_Type = '3' ) "
            End If
        End If

        If CriteriaSearch.Trim() = "" Then
            Return " 0=1 "
        End If

        If ddlBrand.SelectedItem.Value = 0 Then
            CriteriaSearch = " ( " & CriteriaSearch & " ) AND ( Trade_Floor.ManufCode " & " > 0 ) "
        Else
            CriteriaSearch = " ( " & CriteriaSearch & " ) AND ( Trade_Floor.ManufCode " & " = " & ddlBrand.SelectedItem.Value & " ) "
        End If

        'apply the model no filter from combo secondly
        If ddlModel.SelectedItem.Value <> 0 Then
            'CriteriaSearch = " ( " & CriteriaSearch & " ) AND ( Trade_Floor.ModelNo Like '%" & ddlModel.SelectedItem.Text & "%' ) "
            'Else
            CriteriaSearch = " ( " & CriteriaSearch & " ) AND ( Trade_Floor.ModelNo Like '%" & ddlModel.SelectedItem.Text & "%' ) "
        End If

        If DDLCountry.SelectedItem.Value <> 0 Then                                   ' Country "All" is not selected.

            If CriteriaSearch = "" Then
                CriteriaSearch = CriteriaSearch & " ( Country_TF.Country_ID = " & DDLCountry.SelectedItem.Value & " ) "
                'CriteriaSearch = CriteriaSearch & " ( " & pi_DLLCountry_DataValueField & " = '" & DDLCountry.SelectedItem.Value & "' ) "
            Else
                'CriteriaSearch = " ( " & CriteriaSearch & " ) AND ( " & pi_DLLCountry_DataValueField & " = '" & DDLCountry.SelectedItem.Value & "' ) "
                CriteriaSearch = " ( " & CriteriaSearch & " ) AND ( Country_TF.Country_ID = " & DDLCountry.SelectedItem.Value & " ) "
            End If

        End If

        If CriteriaSearch.Trim() = "" Then
            CriteriaSearch = getPostingTime()
        Else
            CriteriaSearch = " ( " & CriteriaSearch & " ) AND ( " & getPostingTime() & " ) "
        End If

        Return CriteriaSearch.ToString()

    End Function
    Public Function GetVisibility(ByVal btnName As String) As String
        If btnName = "imggo" Then
            If (Session(Session_str_UserName).ToString().Trim() <> "" Or Session(Session_str_UserName) <> Nothing) Then
                Return "cursor:hand;display='';visibility=''"
            Else
                Return "cursor:hand;display='';visibility=''"
            End If
        End If
    End Function
    Private Sub FillGridRow(ByVal dgItem As DataGridItem, ByVal lUpBorder As Boolean)
        Dim nCounter = 0
        If lUpBorder Then
            For nCounter = 1 To 13
                dgItem.Cells(nCounter).Style.Add("BORDER-TOP", "#FFFFFF 10px solid")
            Next
        Else
            For nCounter = 1 To 13
                dgItem.Cells(nCounter).Style.Add("BORDER-BOTTOM", "#FFFFFF 10px solid")
            Next
        End If
    End Sub
    Private Sub ddlBrand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlBrand.SelectedIndexChanged
        FillModels()
    End Sub
    Private Sub DGTradeFloorView_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGTradeFloorView.PreRender
        DGTradeFloorView.Items(0).Cells(14).Style.Add("BORDER-TOP", "#BCDDFE 1px solid")
        GroupColumn(DGTradeFloorView, 1, 3, True)
        GroupColumn(DGTradeFloorView, 1, 2)
        'GroupColumn(DGTradeFloorView, 1, 3)
        'GroupColumn(DGTradeFloorView, 1, 14)
        If (DGTradeFloorView.Items.Count > 0) Then
            FillGridRow(DGTradeFloorView.Items(DGTradeFloorView.Items.Count - 1), True)
            FillGridRow(DGTradeFloorView.Items(DGTradeFloorView.Items.Count - 1), False)
        End If
    End Sub
    Private Sub DGTradeFloorView_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DGTradeFloorView.ItemCommand
        Response.Redirect("PortalDefault.aspx?Main_Links_ID=2&Member_ID=" + DGTradeFloorView.Items(e.Item.ItemIndex).Cells(5).Text)
    End Sub
    Private Sub DGTradeFloorView_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DGTradeFloorView.ItemDataBound
        Dim nCounter As Int32
        Dim txtShippingTerms As String
        If e.Item.DataItem Is Nothing Then
            Return
        End If
        nCounter = 0

        If e.Item.ItemIndex >= 0 And e.Item.Cells(e.Item.Cells.Count - 1).Text <> "3" Then 'means not comment 
            If (DataBinder.Eval(e.Item.DataItem, "Price").ToString().Trim() = "Price on Application") Then
                e.Item.FindControl("trPrice").Visible = False
                nCounter = nCounter + 1
            End If
            If (DataBinder.Eval(e.Item.DataItem, "ShippingTerms").ToString().Substring(0, 10).Trim() = "Ask For De") Then
                e.Item.FindControl("trShippingTerms").Visible = False
                nCounter = nCounter + 1
            End If
            'If (DataBinder.Eval(e.Item.DataItem, "Location").ToString().Trim() = "Ask For Details") Then
            '    e.Item.FindControl("trStockLocation").Visible = False
            '    nCounter = nCounter + 1
            'End If
            If (DataBinder.Eval(e.Item.DataItem, "BUYSELL").ToString().Trim() = "BUY") Then
                e.Item.FindControl("trShippingTerms").Visible = False
                'e.Item.FindControl("trStockLocation").Visible = False
                nCounter = nCounter + 2
            End If
            If (DataBinder.Eval(e.Item.DataItem, "post_desc").ToString().Trim() = "No Comments.") Then
                e.Item.FindControl("trComments").Visible = False
                nCounter = nCounter + 1
            End If
            If ((DataBinder.Eval(e.Item.DataItem, "BUYSELL").ToString().Trim() = "BUY") And (nCounter >= 5)) Then
                e.Item.FindControl("Table_Detail").Visible = False
                e.Item.FindControl("pnlDetails").Visible = False

            ElseIf ((DataBinder.Eval(e.Item.DataItem, "BUYSELL").ToString().Trim() = "SELL") And (nCounter >= 3)) Then
                e.Item.FindControl("Table_Detail").Visible = False
                e.Item.FindControl("pnlDetails").Visible = False
            End If
        End If
    End Sub

End Class