Imports SmartPhi_BL
Public Class UpdateMailSettings
    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents btnUpdate As System.Web.UI.WebControls.Button
    Protected WithEvents tblGroup As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents txtSMTPServer As System.Web.UI.WebControls.TextBox
    Protected WithEvents rfv1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtSMTPUserName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSMTPPassword As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtServerport As System.Web.UI.WebControls.TextBox
    Protected WithEvents rfv2 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents rfv3 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents rfv4 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents lblConfirm As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region
    Private pi_obj_Members As New clsMember
    Private strMemberGUID As String

    Public Property MemberGUID() As String
        Get
            Return strMemberGUID
        End Get
        Set(ByVal Value As String)
            strMemberGUID = Value
        End Set
    End Property

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim prmMemberID As Integer
        prmMemberID = CInt(Session(Session_str_MemberID))
        pi_obj_Members.SMTPServer = txtSMTPServer.Text
        pi_obj_Members.SMTPUserName = txtSMTPUserName.Text
        pi_obj_Members.SMTPPassword = txtSMTPPassword.Text
        pi_obj_Members.SMTPServerPort = txtServerport.Text
        pi_obj_Members.MemberID = Session(Session_str_MemberID)

        If prmMemberID = 0 Then
            prmMemberID = pi_obj_Members.GetMemberID(New Guid(Me.MemberGUID))
        End If

        Try

            If pi_obj_Members.UpdateMailSetting(prmMemberID) = True Then
                lblConfirm.Visible = True
                lblConfirm.Text = "SMTP settings are updated successfully."
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class
