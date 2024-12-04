Imports NotiPhi_BL
Public Class Purchase

    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblConfirm As System.Web.UI.WebControls.Label
    Protected WithEvents btnViewContact As System.Web.UI.WebControls.Button
    Protected WithEvents lblMode As System.Web.UI.WebControls.Label
    Protected WithEvents btnHistory As System.Web.UI.WebControls.Button
    Protected WithEvents lblTotalCredit As System.Web.UI.WebControls.Label
    Protected WithEvents lblCredit As System.Web.UI.WebControls.Label
    Protected WithEvents lblDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblPurchaseDate As System.Web.UI.WebControls.Label
    Protected WithEvents btnPurchase As System.Web.UI.WebControls.Button
    Protected WithEvents ddlCreditAmount As System.Web.UI.WebControls.DropDownList
    Protected WithEvents btnRequest As System.Web.UI.WebControls.Button
    Protected WithEvents tblPurchase As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents hlnkRateList As System.Web.UI.WebControls.HyperLink
    Protected WithEvents dgRateList As System.Web.UI.WebControls.DataGrid
    Protected WithEvents txtCreditstoPurchase As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblRateList As System.Web.UI.WebControls.Label
    Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RangeValidator1 As System.Web.UI.WebControls.RangeValidator

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

#Region "Private variables"
    Private pi_obj_Credits As New clsCredit
    Private pi_obj_Member As New clsMember
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetMemberCredit()
        tblPurchase.Visible = False
        lblMode.Text = " [NEW]"
        'btnHistory.Visible = False
        LoadCreditAmounts()
    End Sub

    Private Sub btnRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRequest.Click

        tblPurchase.Visible = True
        lblConfirm.Visible = False
        LoadCreditAmounts()

    End Sub

    Private Sub GetMemberCredit()

        Dim dtMemberCredit As DataTable = pi_obj_Credits.GetMemberCredit(35)
        Dim drMemberCredit As DataRow = dtMemberCredit.Rows(0)
        Dim dat As DateTime
        dat = DateTime.Parse(drMemberCredit("DateLastPurchased").ToString)
        lblDate.Text = dat.ToShortDateString
        lblCredit.Text = drMemberCredit("TotalCredits").ToString

    End Sub

    Private Sub LoadCreditAmounts()

        Dim dt As New DataTable
        dt = pi_obj_Credits.GetCreditRateList() '(1)
        dgRateList.DataSource = dt
        dgRateList.DataBind()

    End Sub

    Private Sub btnPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchase.Click

        If IsInt(txtCreditstoPurchase.Text) Then
            Session(Session_str_MemberID) = 35
            pi_obj_Credits.MemberID = Session(Session_str_MemberID)
            pi_obj_Credits.TotalCredits = txtCreditstoPurchase.Text
            pi_obj_Credits.DateLastPurchased = DateTime.Now

            Try
                pi_obj_Credits.MasterCode = pi_obj_Member.GetMemberMasterCode(Session(Session_str_MemberID))
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine(ex.Message)
                Return
            End Try

            If (pi_obj_Credits.MasterCode > 0) Then
                If (pi_obj_Credits.AddUserCredits(txtCreditstoPurchase.Text, Session(Session_str_MemberID))) Then
                    GetMemberCredit()
                    txtCreditstoPurchase.Text = ""
                End If
            End If

        Else
            lblConfirm.Text = "Please insert a valid amount."
        End If

    End Sub

    Function IsInt(ByVal strNumber As String) As Boolean
        If strNumber = Nothing Then
            Return (False)
        Else
            Dim X As Integer

            For X = 0 To strNumber.Length - 1
                If Not (Char.IsNumber(strNumber, X)) Then Return (False)
            Next

            Return (True)
        End If
    End Function

    Private Sub btnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistory.Click

    End Sub

End Class
