Namespace Admin
    Public Class PressReleases
        Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

        'This call is required by the Web Form Designer.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

        End Sub
        Protected WithEvents ImageButton3 As System.Web.UI.WebControls.ImageButton
        Protected WithEvents TDView As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents TDAction As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents TDHeader As System.Web.UI.HtmlControls.HtmlTableCell

        Protected WithEvents imgSave As System.Web.UI.WebControls.ImageButton
        Protected WithEvents imgCancel As System.Web.UI.WebControls.ImageButton
        Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
        Protected WithEvents ImgNew As System.Web.UI.WebControls.ImageButton
        Protected WithEvents RFVHeading As System.Web.UI.WebControls.RequiredFieldValidator
        Protected WithEvents RFVText As System.Web.UI.WebControls.RequiredFieldValidator
        Protected WithEvents RFVLink As System.Web.UI.WebControls.RequiredFieldValidator
        Protected WithEvents DGPressRelease As System.Web.UI.WebControls.DataGrid
        Protected WithEvents tbPRID As System.Web.UI.WebControls.TextBox
        Protected WithEvents tbPR_Text As System.Web.UI.WebControls.TextBox
        Protected WithEvents tbPR_Detail As System.Web.UI.WebControls.TextBox
        Protected WithEvents PR_Img As System.Web.UI.HtmlControls.HtmlInputFile
        Protected WithEvents chkShowPressRelease As System.Web.UI.WebControls.CheckBox
        Protected WithEvents TDImage As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents ImgPR As System.Web.UI.WebControls.Image

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
        Private Const pi_strCpress_release_id As String = "press_release_id"
        Private Const pi_strCpress_release_text As String = "press_release_text"
        Private Const pi_strCpress_release_detail As String = "press_release_detail"
        Private Const pi_strCpress_release_image As String = "press_release_image"
        Private Const pi_strCmodule_id As String = "module_id"
        Private Const pi_strCshow_flag As String = "show_flag"

#End Region

#Region "Private variables"
        Private pi_Obj_pressrelease As Trade_BL.PressRelease
        Private dt_PressRelease As DataTable
#End Region

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Put user code to initialize the page here
            Response.Cache.SetCacheability(HttpCacheability.NoCache)
            If Session(Session_str_Admin) = "FALSE" Then
                Response.Redirect("InvalidUser.htm")
                Response.End()
            End If
            dt_PressRelease = New DataTable
            If Page.IsPostBack = False Then
                lblMessage.Text = "Press Release Listing"
                ShowPressReleaseDetails()
            End If

        End Sub

        Private Sub DGPressRelease_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGPressRelease.SelectedIndexChanged
            Dim annid As Integer
            Try
                lblMessage.Text = "Edit Press Release"
                annid = DGPressRelease.DataKeys.Item(DGPressRelease.SelectedIndex)
            Catch ex As Exception
                annid = 0
            End Try

            Try
                FillPressReleaseDetails(annid)
            Catch ex As Exception
                'TDHeader.Visible = True
                TDView.Visible = True
                TDAction.Visible = False
                Throw ex
            End Try
        End Sub

        Private Sub imgCancel_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgCancel.Click
            ShowPressReleaseDetails()
            lblMessage.Text = "Press Release Listing"
        End Sub

        Private Sub imgSave_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgSave.Click
            Dim strImg As String
            pi_Obj_pressrelease = New Trade_BL.PressRelease

            pi_Obj_pressrelease.press_release_id = Convert.ToInt32("0" & tbPRID.Text)
            pi_Obj_pressrelease.press_release_text = tbPR_Text.Text
            pi_Obj_pressrelease.press_release_Detail = tbPR_Detail.Text
            pi_Obj_pressrelease.press_release_image = PR_Img.Value
            pi_Obj_pressrelease.module_id = 12
            pi_Obj_pressrelease.show_flag = IIf(chkShowPressRelease.Checked = True, 1, 0)
            pi_Obj_pressrelease.timestamp = DateTime.Now

            If pi_Obj_pressrelease.press_release_id > 0 Then
                ' edit
                strImg = Server.MapPath("..\Images") & "\" & pi_Obj_pressrelease.press_release_id & "." & Strings.Right(PR_Img.Value, PR_Img.Value.Length - Strings.InStrRev(PR_Img.Value, "\"))

                Try
                    PR_Img.PostedFile.SaveAs(strImg)
                    pi_Obj_pressrelease.press_release_image = "..\Images\" & pi_Obj_pressrelease.press_release_id & "." & Strings.Right(PR_Img.Value, PR_Img.Value.Length - Strings.InStrRev(PR_Img.Value, "\"))
                Catch Exc As Exception
                    lblMessage.Text = "Please enter proper Image file "
                    lblMessage.Visible = True
                    Exit Sub
                End Try

                If pi_Obj_pressrelease.Update() = True Then

                    lblMessage.Text = "Updation done successfully, click Cancel to View Press Release Listing"
                    FillPressReleaseDetails(pi_Obj_pressrelease.press_release_id)
                End If
            Else
                ' add new
                strImg = Server.MapPath("..\Images") & "\" & pi_Obj_pressrelease.press_release_id & "." & Strings.Right(PR_Img.Value, PR_Img.Value.Length - Strings.InStrRev(PR_Img.Value, "\"))

                Try
                    PR_Img.PostedFile.SaveAs(strImg)
                    pi_Obj_pressrelease.press_release_image = "..\Images\" & pi_Obj_pressrelease.press_release_id & "." & Strings.Right(PR_Img.Value, PR_Img.Value.Length - Strings.InStrRev(PR_Img.Value, "\"))
                Catch Exc As Exception
                    lblMessage.Text = "Please enter proper Image file "
                    lblMessage.Visible = True
                    Exit Sub
                End Try
                If pi_Obj_pressrelease.Insert() = True Then
                    lblMessage.Text = "Press Release Added Successfully, Add New Press Release"
                    FillPressReleaseDetails(pi_Obj_pressrelease.press_release_id)
                End If
            End If

        End Sub

#Region "Functions "
        Public Sub FillPressReleaseDetails(ByVal prmann_id As Integer)
            'TDHeader.Visible = False
            TDView.Visible = False
            TDAction.Visible = True
            If prmann_id > 0 Then
                pi_Obj_pressrelease = New Trade_BL.PressRelease
                dt_PressRelease = pi_Obj_pressrelease.GetPressRelease(prmann_id)

                tbPRID.Text = Convert.ToString(dt_PressRelease.Rows(0).Item(pi_strCpress_release_id))
                tbPR_Text.Text = Convert.ToString(dt_PressRelease.Rows(0).Item(pi_strCpress_release_text))
                tbPR_Detail.Text = Convert.ToString(dt_PressRelease.Rows(0).Item(pi_strCpress_release_detail))
                'PR_Img.Value = Convert.ToString(dt_PressRelease.Rows(0).Item(pi_strCpress_release_image))
                'tbmoduleid.Text = Convert.ToString(dt_PressRelease.Rows(0).Item(pi_strCmodule_id))
                chkShowPressRelease.Checked = IIf(Convert.ToBoolean(dt_PressRelease.Rows(0).Item(pi_strCshow_flag)) = True, True, False)
                ImgPR.ImageUrl = Convert.ToString(dt_PressRelease.Rows(0).Item(pi_strCpress_release_image))
                TDImage.Visible = True

            Else
                pi_Obj_pressrelease = New Trade_BL.PressRelease
                tbPRID.Text = "0"
                tbPR_Text.Text = ""
                tbPR_Detail.Text = ""
                'PR_Img.Value = ""
                chkShowPressRelease.Checked = False
                TDImage.Visible = False
            End If
        End Sub
        Public Sub ShowPressReleaseDetails()
            Try
                pi_Obj_pressrelease = New Trade_BL.PressRelease
                dt_PressRelease = pi_Obj_pressrelease.GetPressRelease(0)

                Dim dtcolumn As New DataColumn
                dtcolumn.ColumnName = "Selected"
                dtcolumn.DataType = GetType(Boolean)
                dtcolumn.DefaultValue = 0

                dt_PressRelease.Columns.Add(dtcolumn)

                DGPressRelease.DataKeyField = "press_release_id"
                DGPressRelease.DataSource = dt_PressRelease

                If dt_PressRelease.Rows.Count = ((DGPressRelease.PageCount - 1) * DGPressRelease.PageSize) Then
                    DGPressRelease.CurrentPageIndex = DGPressRelease.CurrentPageIndex - 1
                End If

                DGPressRelease.DataBind()

                'TDHeader.Visible = True
                TDView.Visible = True
                TDAction.Visible = False
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region


        Private Sub ImgNew_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgNew.Click
            lblMessage.Text = "Add New Press Release ...."
            FillPressReleaseDetails(0)
        End Sub

        Private Sub ImgDelete_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)
            Dim dr As DataRow()
            Dim icounter As Integer
            Try
                pi_Obj_pressrelease = New Trade_BL.PressRelease

                If TDAction.Visible = True Then
                    pi_Obj_pressrelease.Delete(tbPRID.Text)
                    lblMessage.Text = "Add New Press Release ...."
                    FillPressReleaseDetails(0)
                Else
                    Exit Sub
                    dr = CType(DGPressRelease.DataSource, DataTable).Select("Selected = 1")
                    If dr.Length > 0 Then
                        For icounter = 0 To dr.Length - 1
                            'pi_Obj_pressrelease.Delete(Convert.ToInt32(dr(icounter).Item(pi_strCann_id)))
                        Next
                        FillPressReleaseDetails(0)
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#Region "Delete current selected Record"
        Private Sub DGPressRelease_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DGPressRelease.DeleteCommand
            pi_Obj_pressrelease = New Trade_BL.PressRelease

            If TDView.Visible = True Then
                pi_Obj_pressrelease.Delete(DGPressRelease.DataKeys(e.Item.ItemIndex))
                ShowPressReleaseDetails()
            End If

        End Sub
#End Region

#Region "Page Changed"
        Private Sub DGPressRelease_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DGPressRelease.PageIndexChanged
            DGPressRelease.CurrentPageIndex = e.NewPageIndex
            ShowPressReleaseDetails()
        End Sub
#End Region
    End Class
End Namespace
