Imports System.IO

Public Class Main_Content
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents DLContent As System.Web.UI.WebControls.DataList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label

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
    'Private pi_Module_ID As Integer
    Private pi_obj_Content As New Trade_BL.Content
#End Region

#Region "Public Properties"

#End Region


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        Dim dt_Content As New DataTable
        dt_Content = pi_obj_Content.GetModuleContent(MyBase.Module_ID, Session(Session_str_Portal_ID))
        If dt_Content.Rows.Count > 0 Then
            DLContent.Visible = True
            Me.Visible = True
            DLContent.DataSource = dt_Content 'pi_obj_Content.GetModuleContent(MyBase.Module_ID)
            DLContent.DataBind()
        Else
            Me.Visible = False
            DLContent.Visible = False
        End If

    End Sub
End Class
