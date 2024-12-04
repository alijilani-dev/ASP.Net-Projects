Public Class ff_Search
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents DDLCountry As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Img1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents DLAlphabet As System.Web.UI.WebControls.DataList
    Protected WithEvents tbCompanyName As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox1234 As System.Web.UI.WebControls.TextBox

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

#Region "Private variables for controls like combo/label "
    Private pi_DLLCountry_DataTextField As String = "Country_Name"
    Private pi_DLLCountry_DataValueField As String = "Country_ID1"
    
#End Region

#Region "Private Variables"
    Private pi_obj_Country As New Trade_BL.Country
    Private alphabet(25) As String
#End Region
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        Dim i As Int16

        For i = 65 To 90
            alphabet(i - 65) = Chr(i)
        Next

        If Page.IsPostBack = False Then
            DDLCountry.DataSource = pi_obj_Country.GetCountries()
            DDLCountry.DataTextField = pi_DLLCountry_DataTextField
            DDLCountry.DataValueField = pi_DLLCountry_DataValueField
            DDLCountry.DataBind()

            Dim sysitem As New ListItem
            sysitem.Text = "----- All Counteries ----"
            sysitem.Value = 0
            sysitem.Selected = True
            DDLCountry.Items.Add(sysitem)

            DLAlphabet.DataSource = alphabet
            DLAlphabet.DataBind()
            Response.Write("<BR> Hi - I - 1 ")
        Else
      If DDLCountry.SelectedItem.Value = 0 Then
        Session(Session_ffSearchCriteria) = " AND member_Company LIKE '" & tbCompanyName.Text & "%'"
      Else
                Session(Session_ffSearchCriteria) = " AND member_Company LIKE '" & tbCompanyName.Text & "%' AND Country_ID1=" & DDLCountry.SelectedItem.Value
      End If
      'Response.Write("<BR> Hi - I - 4 " & Session(Session_ffSearchCriteria))
        End If


        'Response.Write("--- ST --uytu- " & Request(TextBox1234.ClientID) & " ---- END -yut--- ")

    End Sub

    'Private Sub DLAlphabet_ItemCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs)
    '    Session(Session_ffSearchCriteria) = " AND Member_Company Like '" & alphabet(e.Item.ItemIndex) & "%'"
    '    Response.Write("<BR> Hi - 4 " & Session(Session_ffSearchCriteria))
    'End Sub

    Private Sub Img1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Img1.Click
    End Sub

    Private Sub DLAlphabet_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DLAlphabet.SelectedIndexChanged

    End Sub

    Private Sub DLAlphabet_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataListItemEventArgs) Handles DLAlphabet.ItemDataBound
        Dim lnkBut As LinkButton

        lnkBut = e.Item.FindControl("linkbut1")
        lnkBut.Attributes.Add("onclick", "javaScript:SetFilter('" & alphabet(e.Item.ItemIndex) & "','" & TextBox1234.ClientID & "')")

    End Sub
End Class
