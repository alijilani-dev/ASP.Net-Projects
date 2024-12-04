Namespace Admin
    Public Class Announcements
        Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

        'This call is required by the Web Form Designer.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

        End Sub
        Protected WithEvents DGNews As System.Web.UI.WebControls.DataGrid
        Protected WithEvents ImageButton3 As System.Web.UI.WebControls.ImageButton
        Protected WithEvents TDView As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents TDAction As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents TDHeader As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents chkShowNews As System.Web.UI.WebControls.CheckBox
        Protected WithEvents tbann_id As System.Web.UI.WebControls.TextBox
        Protected WithEvents tbann_Heading As System.Web.UI.WebControls.TextBox
        Protected WithEvents tbann_Text As System.Web.UI.WebControls.TextBox
        Protected WithEvents tbann_linkurl As System.Web.UI.WebControls.TextBox
        Protected WithEvents imgSave As System.Web.UI.WebControls.ImageButton
        Protected WithEvents imgCancel As System.Web.UI.WebControls.ImageButton
        Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
        Protected WithEvents ImgNew As System.Web.UI.WebControls.ImageButton
        Protected WithEvents RFVHeading As System.Web.UI.WebControls.RequiredFieldValidator
        Protected WithEvents RFVText As System.Web.UI.WebControls.RequiredFieldValidator
        Protected WithEvents RFVLink As System.Web.UI.WebControls.RequiredFieldValidator

        'NOTE: The following placeholder declaration is required by the Web Form Designer.
        'Do not delete or move it.
        Private designerPlaceholderDeclaration As System.Object

        Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
            'CODEGEN: This method call is required by the Web Form Designer
            'Do not modify it using the code editor.
            InitializeComponent()
        End Sub

#End Region

#Region "Private Constants"
        Private Const pi_strCann_id As String = "ann_id"
        Private Const pi_strCann_Heading As String = "ann_Heading"
        Private Const pi_strCann_Text As String = "ann_Text"
        Private Const pi_strCann_TextLink_Url As String = "ann_TextLink_Url"
        Private Const pi_strCmodule_id As String = "module_id"
        Private Const pi_strCshow_flag As String = "show_flag"

#End Region

#Region "Private variables"
        Private pi_Obj_announcement As Trade_BL.Announcement
        Private dt_announcement As DataTable
#End Region

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Put user code to initialize the page here
            Response.Cache.SetCacheability(HttpCacheability.NoCache)
            If Session(Session_str_Admin) = "FALSE" Then
                Response.Redirect("InvalidUser.htm")
                Response.End()
            End If
            dt_announcement = New DataTable
            If Page.IsPostBack = False Then
                lblMessage.Text = "News Listing"
                ShowNewsDetails()
            End If

        End Sub

        Private Sub DGNews_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGNews.SelectedIndexChanged
            Dim annid As Integer
            Try
                lblMessage.Text = "Edit News"
                annid = DGNews.DataKeys.Item(DGNews.SelectedIndex)
            Catch ex As Exception
                annid = 0
            End Try

            Try
                FillNewsDetails(annid)
            Catch ex As Exception
                'TDHeader.Visible = True
                TDView.Visible = True
                TDAction.Visible = False
                Throw ex
            End Try
        End Sub

        Private Sub imgCancel_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgCancel.Click
            ShowNewsDetails()
            lblMessage.Text = "News Listing"
        End Sub

        Private Sub imgSave_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgSave.Click
            pi_Obj_announcement = New Trade_BL.Announcement

            pi_Obj_announcement.ann_id = Convert.ToInt32("0" & tbann_id.Text)
            pi_Obj_announcement.ann_Heading = tbann_Heading.Text
            pi_Obj_announcement.ann_text = tbann_Text.Text
            pi_Obj_announcement.ann_TextLink_Url = tbann_linkurl.Text
            pi_Obj_announcement.module_id = 12
            pi_Obj_announcement.show_flag = IIf(chkShowNews.Checked = True, 1, 0)
            pi_Obj_announcement.timestamp = DateTime.Now

            If pi_Obj_announcement.ann_id > 0 Then
                ' edit
                If pi_Obj_announcement.Update() = True Then
                    lblMessage.Text = "Updation done successfully, click Cancel to View News Listing"
                End If
            Else
                ' add new
                If pi_Obj_announcement.Insert() = True Then
                    lblMessage.Text = "News Added Successfully, Add New News"
                    FillNewsDetails(0)
                End If
            End If

        End Sub

#Region "Functions "
        Public Sub FillNewsDetails(ByVal prmann_id As Integer)
            'TDHeader.Visible = False
            TDView.Visible = False
            TDAction.Visible = True
            If prmann_id > 0 Then
                pi_Obj_announcement = New Trade_BL.Announcement

                dt_announcement = pi_Obj_announcement.GetAnnouncement(prmann_id)

                tbann_id.Text = Convert.ToString(dt_announcement.Rows(0).Item(pi_strCann_id))
                tbann_Heading.Text = Convert.ToString(dt_announcement.Rows(0).Item(pi_strCann_Heading))
                tbann_Text.Text = Convert.ToString(dt_announcement.Rows(0).Item(pi_strCann_Text))
                tbann_linkurl.Text = Convert.ToString(dt_announcement.Rows(0).Item(pi_strCann_TextLink_Url))
                'tbmoduleid.Text = Convert.ToString(dt_announcement.Rows(0).Item(pi_strCmodule_id))
                chkShowNews.Checked = IIf(Convert.ToBoolean(dt_announcement.Rows(0).Item(pi_strCshow_flag)) = True, True, False)
            Else
                pi_Obj_announcement = New Trade_BL.Announcement
                tbann_id.Text = "0"
                tbann_Heading.Text = ""
                tbann_Text.Text = ""
                tbann_linkurl.Text = ""
                chkShowNews.Checked = False
            End If
        End Sub
        Public Sub ShowNewsDetails()
            Try
                pi_Obj_announcement = New Trade_BL.Announcement
                dt_announcement = pi_Obj_announcement.GetAnnouncement(0)

                Dim dtcolumn As New DataColumn
                dtcolumn.ColumnName = "Selected"
                dtcolumn.DataType = GetType(Boolean)
                dtcolumn.DefaultValue = 0

                dt_announcement.Columns.Add(dtcolumn)

                DGNews.DataKeyField = "ann_id"

                If dt_announcement.Rows.Count = ((DGNews.PageCount - 1) * DGNews.PageSize) Then
                    DGNews.CurrentPageIndex = DGNews.CurrentPageIndex - 1
                End If
                DGNews.DataSource = dt_announcement
                DGNews.DataBind()

                'TDHeader.Visible = True
                TDView.Visible = True
                TDAction.Visible = False
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

        Private Sub ImgNew_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgNew.Click
            lblMessage.Text = "Add New News ...."
            FillNewsDetails(0)
        End Sub

        Private Sub ImgDelete_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)
            Dim dr As DataRow()
            Dim icounter As Integer
            Try
                pi_Obj_announcement = New Trade_BL.Announcement

                If TDAction.Visible = True Then
                    pi_Obj_announcement.Delete(tbann_id.Text)
                    lblMessage.Text = "Add New News ...."
                    FillNewsDetails(0)
                Else
                    Exit Sub
                    dr = CType(DGNews.DataSource, DataTable).Select("Selected = 1")
                    If dr.Length > 0 Then
                        For icounter = 0 To dr.Length - 1
                            pi_Obj_announcement.Delete(Convert.ToInt32(dr(icounter).Item(pi_strCann_id)))
                        Next
                        FillNewsDetails(0)
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

#Region "Delete current selected Record"
        Private Sub DGNews_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DGNews.DeleteCommand
            pi_Obj_announcement = New Trade_BL.Announcement

            If TDView.Visible = True Then
                pi_Obj_announcement.Delete(DGNews.DataKeys(e.Item.ItemIndex))
                ShowNewsDetails()
            End If

        End Sub
#End Region

#Region "Page Changed"
        Private Sub DGNews_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DGNews.PageIndexChanged
            DGNews.CurrentPageIndex = e.NewPageIndex
            ShowNewsDetails()
        End Sub
#End Region
    End Class
End Namespace
