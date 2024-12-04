Imports NotiPhi_BL
Public Class Group
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Middle As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents Table1 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tdContent As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents hlnkManageContact As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkManageGroup As System.Web.UI.WebControls.HyperLink

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region
    Private pi_obj_Groups As New clsGroup

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        If (CInt(Session(Session_str_MemberID)) = 0 Or Session(Session_str_MemberID) Is Nothing) Then
            Response.Redirect("..\Login.aspx")
        End If

        Dim reqModule As String
        reqModule = Request.QueryString("module") & ""
        Dim dtGroups As DataTable = pi_obj_Groups.GetGroups(Session(Session_str_MemberID), True)

        If (dtGroups.Rows.Count > 0) Then
            If (reqModule.ToString.Length > 0) And (reqModule = "1") Then
                ShowGroup()
            ElseIf (reqModule.ToString.Length > 0) And (reqModule = "2") Then
                ShowContact()
            Else
                ShowGroup()
            End If
        Else
            If (reqModule = "2") And (Not Page.IsPostBack) Then
                RegisterClientScriptBlock("NoGroups", "<Script>alert('No group exists. Please add a group before adding a contact.');</script>")
            End If
            ShowGroup()
        End If

    End Sub
    Public Sub ShowGroup()

        Dim ctrl_TD_Group As Control ' td where we have to show the content control specified in module    
        ctrl_TD_Group = Me.FindControl("tdContent")
        ctrl_TD_Group.Visible = True
        Try
            ctrl_TD_Group.Controls.Add(Me.LoadControl("Group.ascx"))
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
        End Try
    End Sub
    Public Sub ShowContact()

        Dim ctrl_TD_Group As Control ' td where we have to show the content control specified in module    
        ctrl_TD_Group = Me.FindControl("tdContent")
        ctrl_TD_Group.Visible = True
        Try
            ctrl_TD_Group.Controls.Add(Me.LoadControl("ContactList.ascx"))
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
        End Try
    End Sub

End Class
