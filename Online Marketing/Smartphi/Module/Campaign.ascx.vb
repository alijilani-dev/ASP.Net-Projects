Public Class CampaignControl
    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents txtSubject As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCampaignName As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnSaveCampaign As System.Web.UI.WebControls.Button
    Protected WithEvents rfvCampaignName As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents rfvSubject As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents btnNext As System.Web.UI.WebControls.Button

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

#Region " Variables "
    Public pi_str_Campaign_name As String
    Public pi_str_Subject As String
#End Region

#Region " Properties"
    Public Property Campaign_name() As String
        Get
            Return pi_str_Campaign_name
        End Get
        Set(ByVal Value As String)
            pi_str_Campaign_name = Value
        End Set
    End Property
    Public Property Subject() As String
        Get
            Return pi_str_Subject

        End Get
        Set(ByVal Value As String)
            pi_str_Subject = Value
        End Set
    End Property
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        If (Campaign_name <> Nothing) Then
            txtCampaignName.Text = Campaign_name
        End If
        If (Subject <> Nothing) Then
            txtSubject.Text = Subject
        End If
    End Sub

    Private Sub txtCampaignName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCampaignName.TextChanged
        Campaign_name = txtCampaignName.Text
    End Sub

    Private Sub txtSubject_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSubject.TextChanged
        Subject = txtSubject.Text
    End Sub

End Class
