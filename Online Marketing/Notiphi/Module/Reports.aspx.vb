Imports NotiPhi_BL
Public Class Reports
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Middle As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents Table1 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tdContent As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents hlnkTrackRpt As System.Web.UI.WebControls.HyperLink

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        If (CInt(Session(Session_str_MemberID)) = 0 Or Session(Session_str_MemberID) Is Nothing) Then
            Response.Redirect("..\Login.aspx")
        End If

        Dim strModule As String
        Try
            strModule = Request.QueryString("module").ToString()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
            strModule = String.Empty
        End Try
        If strModule.ToString().Trim() = "1" Then
            'showTrackReport()
            Response.Redirect("Tracking.aspx")
        ElseIf strModule = "2" Then

        End If
    End Sub

    Public Sub showTrackReport()

        Dim ctrl_TD_Group As Control ' td where we have to show the content control specified in module    
        ctrl_TD_Group = Me.FindControl("tdContent")
        ctrl_TD_Group.Visible = True
        Try
            ctrl_TD_Group.Controls.Add(Me.LoadControl("TrackReport.ascx"))
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
        End Try

    End Sub

End Class
