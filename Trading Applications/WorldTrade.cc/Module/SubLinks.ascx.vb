Public Class SubLinks
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblUser As System.Web.UI.WebControls.Label
    Protected WithEvents DLSublinks As System.Web.UI.WebControls.DataList
    Protected WithEvents lblUsers As System.Web.UI.WebControls.Label

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
    Private pi_obj_sub_Links As New Trade_BL.Sublinks
    Private pi_web_Path As String
#End Region

#Region "Public Properties"
#End Region

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Dim dt_SubLinks As New DataTable
        DLSublinks.Attributes.Add("onmouseover", "this.firstChild.bgcolor='blue'")
    dt_SubLinks = pi_obj_sub_Links.GetPortalSublinks(Session("Portal_ID"), MyBase.Main_Links_ID)
    dt_SubLinks.DefaultView.RowFilter = "Show_Flag=1"
    DLSublinks.DataSource = dt_SubLinks.DefaultView
    'DLSublinks.DataKeyField = "Main_Links_ID"
    DLSublinks.DataBind()
    'End If
        If CType(Session(Session_str_Admin), Boolean) = False _
                And CType(Session(Session_str_UserName), String) <> "" Then
            DLSublinks.Visible = True
        Else
            DLSublinks.Visible = False
        End If
        pi_web_Path = "~/"
        lblUsers.Text = "Welcome " & Session(Session_str_UserName)
  End Sub

  'Private Sub DLSublinks_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles DLSublinks.ItemCommand
  '    ' Retrieve the data table from session state.
  '    Dim dt As DataTable = CType(ViewState("PortalMainSubLinks"), DataTable)

  '    ' Retrieve the data row to delete from the data table. 
  '    ' Use the DataKeys property of the DataGrid control to get 
  '    ' the primary key value of the selected row. 
  '    ' Search the Rows collection of the data table for this value. 
  '    Dim dr As DataRow
  '    dr = dt.Rows(e.Item.ItemIndex)
  '    'Session(Session_Str_Cur_Main_Link_ID) = DLMainlinks.DataKeys(e.Item.ItemIndex) 'dr("Main_Links_ID")
  '    Response.Redirect(pi_web_Path & dr("sub_Link_Url") & "?Sub_Links_ID=" & dr("Sub_Links_ID"))

  'End Sub

End Class
