Public Class MemberSearch
    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Protected WithEvents tblSearch As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents DLResult As System.Web.UI.WebControls.DataList
    Protected WithEvents DDLCountry As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblcaption3 As System.Web.UI.WebControls.Label
    Protected WithEvents DLAlphabet As System.Web.UI.WebControls.DataList
    Protected WithEvents TDSearchResult As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TDCountries As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TDBack As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TDTraderDetails As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents Table5 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents TD_LEFT_ADV As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TD_RIGHT_ADV As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents hlnkCompanyLogon As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkCompany As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Linkbutton2 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents hlnkPhoneLogon As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ibtnPhone As System.Web.UI.WebControls.ImageButton
    Protected WithEvents hlnkEmailLogon As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkEmail As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkBack As System.Web.UI.WebControls.HyperLink
    Protected WithEvents ifrmffDirectory As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pnlffDirectory As System.Web.UI.WebControls.Panel
    Protected WithEvents pnlTradersDirectory As System.Web.UI.WebControls.Panel
    Protected WithEvents ifrmTradersDirectory As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pnlTDListing As System.Web.UI.WebControls.Panel
    Protected WithEvents pnlFFListing As System.Web.UI.WebControls.Panel

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
    Private pi_Obj_Member As New Trade_BL.Member
    Private pi_obj_Country As New Trade_BL.Country
    Private alphabet(25) As String
    Private pi_Member_Type_Filter As String
    Private pi_Member_Type As String
    Public DsTDDirectory As DataSet
    Public DsFFDirectory As DataSet
    Public Dr As DataRow
    Public nCounter As Int32 = 0

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
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (Request("Member_ID") <> "") Then
            cTraderDetail.FillTraderDetail(Request("Member_ID").ToString.Trim)
            'tblSearch.Visible = False
            TDCountries.Visible = False
            TDBack.Visible = True
            hlnkBack.Visible = True
            'FillCountry()
            
            If Member_Type_Filter = "freight_type = 1" Then
                pnlffDirectory.Visible = False
                pnlTradersDirectory.Visible = True
                Show_LeftRightAdv()
            Else
                pnlffDirectory.Visible = True
                pnlTradersDirectory.Visible = False
            End If

            TDSearchResult.Visible = False
            TDTraderDetails.Visible = True
            Exit Sub
        End If

        TDCountries.Visible = True
        TDBack.Visible = False
        hlnkBack.Visible = False
        'tblSearch.Visible = True
        TDSearchResult.Visible = True
        TDTraderDetails.Visible = False

        FillCountry()

        If Member_Type_Filter = "freight_type = 1" Then
            GetBindDataNew(1)
            Show_LeftRightAdv()
        Else
            GetBindDataNew(0)
            TD_LEFT_ADV.Visible = False
            TD_RIGHT_ADV.Visible = False
        End If

    End Sub
    Private Function GetBindDataNew(ByVal nFlgListing As Int32) As DataSet
        If nFlgListing > 0 Then
            DsFFDirectory = pi_Obj_Member.GetDirectory(nFlgListing, DDLCountry.SelectedItem.Value)
            pnlFFListing.Visible = True
            pnlTDListing.Visible = False
            pnlffDirectory.Visible = False
            pnlTradersDirectory.Visible = True
        Else
            DsTDDirectory = pi_Obj_Member.GetDirectory(nFlgListing, DDLCountry.SelectedItem.Value)
            pnlFFListing.Visible = False
            pnlTDListing.Visible = True
            pnlffDirectory.Visible = True
            pnlTradersDirectory.Visible = False
        End If
    End Function
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
    Private Sub DLResult_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles DLResult.ItemCommand
        cTraderDetail.FillTraderDetail(DLResult.DataKeys(e.Item.ItemIndex))
        TDSearchResult.Visible = False
        TDTraderDetails.Visible = True
    End Sub
    Private Sub DDLCountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DDLCountry.SelectedIndexChanged
        GetBindDataNew(IIf(Member_Type_Filter = "freight_type = 1", 1, 0))
        TDSearchResult.Visible = True
        TDTraderDetails.Visible = False
    End Sub
    Private Sub DataList1_ItemCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs)
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
    Private Sub DLMembers_ItemDataBound(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataListItemEventArgs)
        CType(e.Item.FindControl("hlnkCompany"), LinkButton).Visible = True
        CType(e.Item.FindControl("hlnkCompanyLogon"), HyperLink).Visible = False
        CType(e.Item.FindControl("hlnkPhoneLogon"), HyperLink).Visible = False
        CType(e.Item.FindControl("ibtnPhone"), ImageButton).Visible = True
        CType(e.Item.FindControl("hlnkEmailLogon"), HyperLink).Visible = False
        CType(e.Item.FindControl("hlnkEmail"), HyperLink).Visible = True
    End Sub

End Class