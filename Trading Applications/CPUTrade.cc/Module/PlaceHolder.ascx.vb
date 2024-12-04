Public Class PlaceHolder
    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents ImgDelete As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ImgNew As System.Web.UI.WebControls.ImageButton
    Public WithEvents lstModule As System.Web.UI.WebControls.ListBox

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
    Private pi_PlaceHolder_Position As String
#End Region

#Region "Public property"
    Public Property PlaceHolder_Position() As String
        Get
            Return pi_PlaceHolder_Position
        End Get
        Set(ByVal Value As String)
            pi_PlaceHolder_Position = Value
        End Set
    End Property
#End Region

#Region "Events"

    Public Event AddNew()
    Public Event Remove()

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

    Private Sub ImgNew_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgNew.Click
        RaiseEvent AddNew()
    End Sub

    Private Sub ImgDelete_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgDelete.Click
        RaiseEvent Remove()
        Try
            lstModule.Items.RemoveAt(lstModule.SelectedIndex)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub AddIntoList(ByVal prm_str_modulename As String, Optional ByVal prm_int_Value As Integer = 0)
        Dim li As New System.web.UI.WebControls.ListItem
        li.Text = prm_str_modulename
        li.Value = prm_int_Value
        lstModule.Items.Add(li)

    End Sub
End Class
