Public Class MemberSearch
    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents DLResult As System.Web.UI.WebControls.DataList
    Protected WithEvents DDLCountry As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblcaption3 As System.Web.UI.WebControls.Label
    Protected WithEvents DLAlphabet As System.Web.UI.WebControls.DataList
    Protected WithEvents TDSearchResult As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TDTraderDetails As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents DLMembers As System.Web.UI.WebControls.DataList
    Protected WithEvents ImgGo As System.Web.UI.WebControls.ImageButton
    Protected WithEvents tbCompanyName As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblCaption2 As System.Web.UI.WebControls.Label
    Protected WithEvents lblCaption As System.Web.UI.WebControls.Label
    Protected WithEvents lblCaption1 As System.Web.UI.WebControls.Label
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents Table5 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents TD_LEFT_ADV As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TD_RIGHT_ADV As System.Web.UI.HtmlControls.HtmlTableCell

    Protected WithEvents hlnkCompanyLogon As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkCompany As System.Web.UI.WebControls.LinkButton
    Protected WithEvents hlnkPhoneLogon As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ibtnPhone As System.Web.UI.WebControls.ImageButton
    Protected WithEvents hlnkEmailLogon As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkEmail As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkAll As System.Web.UI.WebControls.HyperLink
    Protected WithEvents ifrmffDirectory As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pnlffDirectory As System.Web.UI.WebControls.Panel
    Protected WithEvents pnlTradersDirectory As System.Web.UI.WebControls.Panel
    Protected WithEvents ifrmTradersDirectory As System.Web.UI.HtmlControls.HtmlGenericControl

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

#Region "Private Controls"

    Protected WithEvents cTraderDetail As TraderDetails

#End Region
#Region "Private variables for controls like combo/label "

    Private pi_DLLCountry_DataTextField As String = "Country_Name"
    Private pi_DLLCountry_DataValueField As String = "Country_ID1"

#End Region
#Region "Private variables"

    Private Criteria As String
    Private ln_LoggedIn As Boolean
    Private pi_Obj_Member As New Trade_BL.Member
    Private pi_obj_Country As New Trade_BL.Country
    Private alphabet(25) As String
    Private pi_Member_Type_Filter As String
    Private pi_Member_Type As String

#End Region
#Region "Public Properties"
    Public Property Member_Type_Filter() As String
        Get
            Return pi_Member_Type_Filter
        End Get
        Set(ByVal Value As String)
            pi_Member_Type_Filter = Value
        End Set
    End Property

    Public Property Member_Type() As String
        Get
            Return pi_Member_Type
        End Get
        Set(ByVal Value As String)
            pi_Member_Type = Value
        End Set
    End Property

    Public Property LoggedIn() As Boolean
        Get
            Return ln_LoggedIn
        End Get
        Set(ByVal Value As Boolean)
            ln_LoggedIn = Value
        End Set
    End Property
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''Coded added to show the left and right adv if FF is selected
        If Member_Type_Filter = "freight_type = 1" Then
            Show_LeftRightAdv()
            DLResult.Visible = True
            DLMembers.Visible = False
            pnlffDirectory.Visible = False
            pnlTradersDirectory.Visible = True
        Else
            TD_LEFT_ADV.Visible = False
            TD_RIGHT_ADV.Visible = False
            pnlffDirectory.Visible = True
            pnlTradersDirectory.Visible = False
        End If

        Dim i As Int16
        If Session(Session_str_UserName) <> "" Then
            LoggedIn = True
        Else
            LoggedIn = False
        End If

        lblCaption.Text = Member_Type
        lblCaption1.Text = Member_Type
        lblCaption2.Text = Member_Type
        lblcaption3.Text = Member_Type
        FillCountry()

        If (Request("Member_ID") <> "") Then
            cTraderDetail.FillTraderDetail(Request("Member_ID").ToString.Trim)
            hlnkAll.Visible = False
            TDSearchResult.Visible = False
            TDTraderDetails.Visible = True

            DLAlphabet.DataSource = alphabet
            DLAlphabet.DataBind()
            GetBindData()
            Exit Sub
        End If

        TDSearchResult.Visible = True
        TDTraderDetails.Visible = False

        If Page.IsPostBack = False Then
            For i = 65 To 90
                alphabet(i - 65) = Chr(i)
            Next
            FillCountry()
            DLAlphabet.DataSource = alphabet
            DLAlphabet.DataBind()
            '' Code added by Basheer on Jan09 06 time 11.50am
            GetBindData()
        Else
        End If

    End Sub

    Private Sub FillCountry()
        DDLCountry.DataSource = pi_obj_Country.GetCountries()
        DDLCountry.DataTextField = pi_DLLCountry_DataTextField
        DDLCountry.DataValueField = pi_DLLCountry_DataValueField
        DDLCountry.DataBind()

        Dim sysitem As New ListItem
        sysitem.Text = "----- All Countries ----"
        sysitem.Value = 0
        sysitem.Selected = True
        DDLCountry.Items.Add(sysitem)
    End Sub

    Private Sub DLAlphabet_ItemCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles DLAlphabet.ItemCommand

        Try
            If DDLCountry.SelectedItem.Value = 0 Then
                Criteria = " AND ((member_Company LIKE '" & alphabet(e.Item.ItemIndex) & "%') AND (" & Member_Type_Filter & "))"
            Else
                Criteria = " AND ((member_Company LIKE '" & alphabet(e.Item.ItemIndex) & "%') AND ((Country_ID='" & DDLCountry.SelectedItem.Value & "') AND (" & Member_Type_Filter & ")))"
            End If
        Catch ex As Exception
            Criteria = ""
        End Try

        tbCompanyName.Text = alphabet(e.Item.ItemIndex)

        Dim dt_MemberSearch As New DataTable
        dt_MemberSearch = pi_Obj_Member.GetMembers()

        If Criteria = "" Then
            dt_MemberSearch.DefaultView.RowFilter = "Portal_ID = " & Session(Session_str_Portal_ID)
        Else
            dt_MemberSearch.DefaultView.RowFilter = " ((Portal_ID = " & Session(Session_str_Portal_ID) & ") " & Criteria & ") "
        End If

        If Not Member_Type_Filter = "freight_type = 1" Then
            ' Commented by Ali for Alignment of process
            DLMembers.DataSource = dt_MemberSearch.DefaultView.DataViewManager.DataSet.Tables(0)
            DLMembers.DataKeyField = "member_id"
            DLMembers.DataBind()
        Else
            DLResult.DataSource = dt_MemberSearch.DefaultView.DataViewManager.DataSet.Tables(0)
            DLResult.DataKeyField = "member_id"
            DLResult.DataBind()
        End If

    End Sub

    Private Sub ImgGo_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        ' then run below code
        GetBindData()
        '''Code commented by Basheer on 9th Jan 06
        '''Placed this code in a SUB and called from here
        ''''Try
        ''''    If DDLCountry.SelectedItem.Value = 0 Then
        ''''        Criteria = " AND member_Company LIKE '" & tbCompanyName.Text & "%' AND " & Member_Type_Filter
        ''''    Else
        ''''        Criteria = " AND member_Company LIKE '" & tbCompanyName.Text & "%' AND Country_ID=" & DDLCountry.SelectedItem.Value & " AND " & Member_Type_Filter
        ''''    End If
        ''''Catch
        ''''    Criteria = ""
        ''''End Try

        ''''Dim dt_MemberSearch As New DataTable
        ''''dt_MemberSearch = pi_Obj_Member.GetMembers()

        ''''If Criteria = "" Then
        ''''    dt_MemberSearch.DefaultView.RowFilter = "Portal_ID = " & Session(Session_str_Portal_ID)
        ''''Else
        ''''    dt_MemberSearch.DefaultView.RowFilter = "Portal_ID = " & Session(Session_str_Portal_ID) & " " & Criteria
        ''''End If

        ''''DLResult.DataSource = dt_MemberSearch.DefaultView.DataViewManager.DataSet.Tables(0)
        ''''DLResult.DataKeyField = "member_id"
        ''''DLResult.DataBind()
    End Sub

    Private Sub DLResult_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles DLResult.ItemCommand
        cTraderDetail.FillTraderDetail(DLResult.DataKeys(e.Item.ItemIndex))
        TDSearchResult.Visible = False
        TDTraderDetails.Visible = True
    End Sub

    Private Sub GetBindData()
        Try
            If DDLCountry.SelectedItem.Value = 0 Then
                Criteria = " AND ((member_Company LIKE '" & tbCompanyName.Text & "%') AND (" & Member_Type_Filter & ")) "
            Else
                Criteria = " AND ((member_Company LIKE '" & tbCompanyName.Text & "%') AND ((Country_ID='" & DDLCountry.SelectedItem.Value & "') AND (" & Member_Type_Filter & ")))"
            End If
        Catch
            Criteria = ""
        End Try

        Dim dt_MemberSearch As New DataTable
        dt_MemberSearch = pi_Obj_Member.GetMembers()

        If Criteria = "" Then
            dt_MemberSearch.DefaultView.RowFilter = " (Portal_ID = " & Session(Session_str_Portal_ID) & ") "
        Else
            dt_MemberSearch.DefaultView.RowFilter = " ((Portal_ID = " & Session(Session_str_Portal_ID) & ") " & Criteria & ") "
        End If

        If dt_MemberSearch.DefaultView.DataViewManager.DataSet.Tables(0).Rows.Count > 0 Then
            If Not Member_Type_Filter = "freight_type = 1" Then
                DLMembers.DataSource = dt_MemberSearch.DefaultView.DataViewManager.DataSet.Tables(0)
                DLMembers.DataKeyField = "member_id"
                DLMembers.DataBind()
            Else
                ' Commented by Ali for Alignment of process
                DLResult.DataSource = dt_MemberSearch.DefaultView.DataViewManager.DataSet.Tables(0)
                DLResult.DataKeyField = "member_id"
                DLResult.DataBind()
            End If
        Else
            '   ***********************
            '   *    **************   *
            '   *    *USELESS AREA*   *
            '   *    **************   *
            '   ***********************
            If Not Member_Type_Filter = "freight_type = 1" Then
                DLMembers.DataSource = dt_MemberSearch.DefaultView.DataViewManager.DataSet.Tables(0)
                DLMembers.DataKeyField = "member_id"
                DLMembers.DataBind()
            Else
                ' Commented by Ali for Alignment of process
                DLResult.DataSource = dt_MemberSearch.DefaultView.DataViewManager.DataSet.Tables(0)
                DLResult.DataKeyField = "member_id"
                DLResult.DataBind()
            End If
            lblMessage.Text = "No Matching record found."
            lblMessage.Visible = True
        End If

    End Sub

    Private Sub DDLCountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DDLCountry.SelectedIndexChanged
        GetBindData()
        TDSearchResult.Visible = True
        TDTraderDetails.Visible = False
    End Sub

    Private Sub DLMembers_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles DLMembers.ItemCommand

        cTraderDetail.FillTraderDetail(DLMembers.DataKeys(e.Item.ItemIndex))
        TDSearchResult.Visible = False
        TDTraderDetails.Visible = True

    End Sub

    Public Sub Show_LeftRightAdv()

        Dim ctrl_TD_LEFT_ADV As Control
        ctrl_TD_LEFT_ADV = Me.FindControl("TD_LEFT_ADV")
        ctrl_TD_LEFT_ADV.Visible = True
        Dim ctrl_TD_RIGHT_ADV As Control
        ctrl_TD_RIGHT_ADV = Me.FindControl("TD_RIGHT_ADV")
        ctrl_TD_RIGHT_ADV.Visible = True

        Try
            ctrl_TD_LEFT_ADV.Controls.Add(Me.LoadControl("../Module/FFDLeftAdv.ascx"))
            ctrl_TD_RIGHT_ADV.Controls.Add(Me.LoadControl("../Module/FFDRightAdv.ascx"))
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
        End Try

    End Sub

    Private Sub DLMembers_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataListItemEventArgs) Handles DLMembers.ItemDataBound
        If (Session(Session_str_UserName) <> "") And (Session(Session_str_UserName).ToString().Trim() <> String.Empty) Then 'And (e.Item.ItemType = ListItemType.Item) 
            CType(e.Item.FindControl("hlnkCompany"), LinkButton).Visible = True
            CType(e.Item.FindControl("hlnkCompanyLogon"), HyperLink).Visible = False
            CType(e.Item.FindControl("hlnkPhoneLogon"), HyperLink).Visible = False
            CType(e.Item.FindControl("ibtnPhone"), ImageButton).Visible = True
            CType(e.Item.FindControl("hlnkEmailLogon"), HyperLink).Visible = False
            CType(e.Item.FindControl("hlnkEmail"), HyperLink).Visible = True
        End If
    End Sub

End Class