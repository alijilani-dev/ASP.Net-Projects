Imports SmartPhi_BL
Public Class Unsubscribe
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents tbMain As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tdMessage As System.Web.UI.HtmlControls.HtmlTableCell

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

#Region "Private variable"
    Private pi_obj_Contact As New clsContact
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim reqModule As String
        reqModule = Request.QueryString("contid") & ""
        tbMain.Visible = False
        If reqModule.ToString.Length > 0 Then
            If Unsubscribe(CInt(reqModule)) Then
                tbMain.Visible = True
                tdMessage.InnerHtml = "Thanks but sorry that you have unsubscribed from the mailing list."
            Else
                tbMain.Visible = True
                tdMessage.InnerHtml = "Sorry, we could not validate your request now. Please try again later."
            End If
        End If
    End Sub
    Function Unsubscribe(ByVal reqModule As Integer) As Boolean
        Try
            If pi_obj_Contact.UpdateUnsubscribeStatus(reqModule) Then
                Return True
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.Write(ex.Message)
            Return False
        End Try

    End Function

End Class
