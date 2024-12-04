Namespace Admin
    Public Class MainLinks
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

        Protected WithEvents imgSave As System.Web.UI.WebControls.ImageButton
        Protected WithEvents imgCancel As System.Web.UI.WebControls.ImageButton
        Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
        Protected WithEvents ImgNew As System.Web.UI.WebControls.ImageButton
        Protected WithEvents DGMainLinks As System.Web.UI.WebControls.DataGrid
        Protected WithEvents tbMainLinkID As System.Web.UI.WebControls.TextBox
        Protected WithEvents RFVLinkName As System.Web.UI.WebControls.RequiredFieldValidator
        Protected WithEvents tbLinkName As System.Web.UI.WebControls.TextBox
        Protected WithEvents ddlLinkOpenType As System.Web.UI.WebControls.DropDownList
        Protected WithEvents ImgMouseOverUrl As System.Web.UI.WebControls.Image
        Protected WithEvents Img_Url_path As System.Web.UI.HtmlControls.HtmlInputFile
        Protected WithEvents Img_Mouse_Over_Url_path As System.Web.UI.HtmlControls.HtmlInputFile
        Protected WithEvents chkShowMainLink As System.Web.UI.WebControls.CheckBox
        Protected WithEvents ddlRedirectTo As System.Web.UI.WebControls.DropDownList
        Protected WithEvents ddlRowPosition As System.Web.UI.WebControls.DropDownList
        Protected WithEvents Img_Url As System.Web.UI.WebControls.Image
        Protected WithEvents tbSeqNo As System.Web.UI.WebControls.TextBox
        Protected WithEvents REVtbLinkSeq As System.Web.UI.WebControls.RegularExpressionValidator
        Protected WithEvents TD_Image_MUrl_Br As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents TD_Image_Url_Br As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents TD_MImg As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents TD_Img As System.Web.UI.HtmlControls.HtmlTableCell

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
        Private Const pi_strCmain_links_id As String = "main_links_id"
        Private Const pi_strCportal_id As String = "portal_id"
        Private Const pi_strClink_name As String = "link_name"
        Private Const pi_strClink_url As String = "link_url"
        Private Const pi_strClink_open_type As String = "link_open_type"
        Private Const pi_strCshow_flag As String = "show_flag"
        Private Const pi_strCImg_url As String = "Img_url"
        Private Const pi_strCImg_url_MouseOver As String = "Img_url_MouseOver"
        Private Const pi_strCRow_Position As String = "Row_Position"
        Private Const pi_strCRedirect_Main_Link_ID As String = "Redirect_Main_Link_ID"
        Private Const pi_strCLinks_Seq As String = "Links_Seq"

        Private Const pi_strCRedirectLinkName As String = "RedirectLinkName"


#End Region

#Region "Private variables"
        Private pi_Obj_MainLinks As Trade_BL.MainLinks
        Private dt_MainLinks As DataTable
#End Region

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Put user code to initialize the page here
            Response.Cache.SetCacheability(HttpCacheability.NoCache)

            If Session(Session_str_Admin) = "FALSE" Then
                Response.Redirect("InvalidUser.htm")
                Response.End()
            End If
            dt_MainLinks = New DataTable
            If Page.IsPostBack = False Then
                lblMessage.Text = "Main / Sub Links"
                ShowMainLinksDetails()
                FillRedirectTo()
            End If
        End Sub

        Private Sub DGMainLinks_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGMainLinks.SelectedIndexChanged
            Dim annid As Integer
            Try
                lblMessage.Text = "Edit Main / Sub Links"
                annid = DGMainLinks.DataKeys.Item(DGMainLinks.SelectedIndex)
            Catch ex As Exception
                annid = 0
            End Try

            Try
                FillMainLinksDetails(annid)
            Catch ex As Exception
                'TDHeader.Visible = True
                TDView.Visible = True
                TDAction.Visible = False
                Throw ex
            End Try
        End Sub

        Private Sub imgCancel_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgCancel.Click
            ShowMainLinksDetails()
            lblMessage.Text = "Main / Sub Links"
        End Sub

        Private Sub imgSave_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgSave.Click
            Dim strImg As String
            pi_Obj_MainLinks = New Trade_BL.MainLinks

            pi_Obj_MainLinks.main_links_id = tbMainLinkID.Text
            pi_Obj_MainLinks.portal_id = Session(Session_str_Portal_ID)
            pi_Obj_MainLinks.link_name = tbLinkName.Text

            If Img_Url_path.Value <> "" Then
                ' add new
                strImg = Server.MapPath("..\Images") & "\" & Strings.Right(Img_Url_path.Value, Img_Url_path.Value.Length - Strings.InStrRev(Img_Url_path.Value, "\"))
                pi_Obj_MainLinks.Img_url = "Images/" & Strings.Right(Img_Url_path.Value, Img_Url_path.Value.Length - Strings.InStrRev(Img_Url_path.Value, "\"))
                Try
                    Img_Url_path.PostedFile.SaveAs(strImg)

                Catch Exc As Exception
                    lblMessage.Text = "Please enter proper Image file "
                    lblMessage.Visible = True
                    Exit Sub
                End Try
            End If

            If Img_Mouse_Over_Url_path.Value <> "" Then
                strImg = Server.MapPath("..\Images") & "\" & Strings.Right(Img_Mouse_Over_Url_path.Value, Img_Mouse_Over_Url_path.Value.Length - Strings.InStrRev(Img_Mouse_Over_Url_path.Value, "\"))
                pi_Obj_MainLinks.Img_url_MouseOver = "Images/" & Strings.Right(Img_Mouse_Over_Url_path.Value, Img_Mouse_Over_Url_path.Value.Length - Strings.InStrRev(Img_Mouse_Over_Url_path.Value, "\"))
                Try
                    Img_Mouse_Over_Url_path.PostedFile.SaveAs(strImg)

                Catch Exc As Exception
                    lblMessage.Text = "Please enter proper Image file "
                    lblMessage.Visible = True
                    Exit Sub
                End Try
            End If

            pi_Obj_MainLinks.link_open_type = ddlLinkOpenType.SelectedValue
            pi_Obj_MainLinks.show_flag = IIf(chkShowMainLink.Checked = True, 1, 0)

            pi_Obj_MainLinks.Row_Position = ddlRowPosition.SelectedValue
            pi_Obj_MainLinks.Redirect_Main_Link_ID = ddlRedirectTo.SelectedValue
            pi_Obj_MainLinks.Links_Seq = tbSeqNo.Text


            If pi_Obj_MainLinks.main_links_id > 0 Then
                ' edit
                If pi_Obj_MainLinks.Update() = True Then
                    lblMessage.Text = "Updation done successfully, click Cancel to View Main / Sub Links"
                End If
            Else
                ' add new
                If pi_Obj_MainLinks.Insert() = True Then
                    lblMessage.Text = "MainLinks Added Successfully, Add New MainLinks"
                    FillMainLinksDetails(0)
                End If
            End If

        End Sub

#Region "Functions "

        Public Sub FillRedirectTo()
            Dim dt_Redirect_Links As New DataTable
            dt_Redirect_Links = pi_Obj_MainLinks.GetPortalMainLinks(Session(Session_str_Portal_ID), 0)
            ddlRedirectTo.DataTextField = "Link_Name"
            ddlRedirectTo.DataValueField = "main_links_id"
            ddlRedirectTo.DataSource = dt_Redirect_Links

            ddlRedirectTo.DataBind()
            Dim li As New ListItem
            li.Text = "None"
            li.Value = "0"

            ddlRedirectTo.Items.Add(li)
            ddlRedirectTo.SelectedValue = 0

        End Sub
        Public Sub FillMainLinksDetails(ByVal prmMainlinkID As Integer)
            'TDHeader.Visible = False
            TDView.Visible = False
            TDAction.Visible = True
            If prmMainlinkID > 0 Then
                TD_Img.Visible = True
                TD_MImg.Visible = True

                pi_Obj_MainLinks = New Trade_BL.MainLinks

                dt_MainLinks = pi_Obj_MainLinks.GetMainLinks(prmMainlinkID)

                tbMainLinkID.Text = Convert.ToString(dt_MainLinks.Rows(0).Item(pi_strCmain_links_id))
                tbLinkName.Text = Convert.ToString(dt_MainLinks.Rows(0).Item(pi_strClink_name))
                ddlLinkOpenType.SelectedValue = Convert.ToString(dt_MainLinks.Rows(0).Item(pi_strClink_open_type))
                Img_Url.ImageUrl = "..\" & Convert.ToString(dt_MainLinks.Rows(0).Item(pi_strCImg_url))
                ImgMouseOverUrl.ImageUrl = "..\" & Convert.ToString(dt_MainLinks.Rows(0).Item(pi_strCImg_url_MouseOver))
                ddlRowPosition.SelectedValue = Convert.ToString(dt_MainLinks.Rows(0).Item(pi_strCRow_Position))

                tbSeqNo.Text = Format(dt_MainLinks.Rows(0).Item(pi_strCLinks_Seq), "00")

                If dt_MainLinks.Rows(0).Item(pi_strCRedirect_Main_Link_ID) Is System.DBNull.Value Then
                    ddlRedirectTo.SelectedValue = 0
                Else
                    ddlRedirectTo.SelectedValue = Convert.ToString(dt_MainLinks.Rows(0).Item(pi_strCRedirect_Main_Link_ID))
                End If

                chkShowMainLink.Checked = IIf(Convert.ToBoolean(dt_MainLinks.Rows(0).Item(pi_strCshow_flag)) = True, True, False)
            Else
                Dim dt_Links_seqNo As New DataTable
                pi_Obj_MainLinks = New Trade_BL.MainLinks
                tbMainLinkID.Text = "0"
                chkShowMainLink.Checked = False
                TD_Img.Visible = False
                TD_MImg.Visible = False
                Img_Url.ImageUrl = ""
                ImgMouseOverUrl.ImageUrl = ""
                ddlRedirectTo.SelectedValue = "0"

                dt_Links_seqNo = pi_Obj_MainLinks.GetPortalMainLinks(Session(Session_str_Portal_ID), ddlRowPosition.SelectedValue)
                tbSeqNo.Text = dt_Links_seqNo.Rows.Count + 1
            End If
        End Sub
        Public Sub ShowMainLinksDetails()
            Try
                pi_Obj_MainLinks = New Trade_BL.MainLinks
                dt_MainLinks = pi_Obj_MainLinks.GetPortalMainLinks(Session(Session_str_Portal_ID), 0)

                Dim dtcolumn As New DataColumn
                dtcolumn.ColumnName = "Selected"
                dtcolumn.DataType = GetType(Boolean)
                dtcolumn.DefaultValue = 0

                dt_MainLinks.Columns.Add(dtcolumn)

                DGMainLinks.DataKeyField = "main_links_id"
                DGMainLinks.DataSource = dt_MainLinks

                If dt_MainLinks.Rows.Count = ((DGMainLinks.PageCount - 1) * DGMainLinks.PageSize) Then
                    DGMainLinks.CurrentPageIndex = DGMainLinks.CurrentPageIndex - 1
                End If

                DGMainLinks.DataBind()

                'TDHeader.Visible = True
                TDView.Visible = True
                TDAction.Visible = False
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

        Private Sub ImgNew_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgNew.Click
            lblMessage.Text = "Add New MainLinks ...."
            FillMainLinksDetails(0)
        End Sub

        Private Sub ImgDelete_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)
            Dim dr As DataRow()
            Dim icounter As Integer
            Try
                pi_Obj_MainLinks = New Trade_BL.MainLinks

                If TDAction.Visible = True Then
                    'pi_Obj_MainLinks.Delete(tbMainLinkID.Text)
                    lblMessage.Text = "Add New MainLinks ...."
                    FillMainLinksDetails(0)
                Else
                    Exit Sub
                    dr = CType(DGMainLinks.DataSource, DataTable).Select("Selected = 1")
                    If dr.Length > 0 Then
                        For icounter = 0 To dr.Length - 1
                            ''pi_Obj_MainLinks.Delete(Convert.ToInt32(dr(icounter).Item(pi_strCann_id)))
                        Next
                        FillMainLinksDetails(0)
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

#Region "Delete current selected Record"
        Private Sub DGMainLinks_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DGMainLinks.DeleteCommand
            pi_Obj_MainLinks = New Trade_BL.MainLinks

            If TDView.Visible = True Then
                'pi_Obj_MainLinks.Delete(DGNews.DataKeys(e.Item.ItemIndex))
                'ShowMainLinksDetails()
            End If

        End Sub
#End Region

#Region "Page Changed"
        Private Sub DGMainLinks_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DGMainLinks.PageIndexChanged
            DGMainLinks.CurrentPageIndex = e.NewPageIndex
            ShowMainLinksDetails()
        End Sub
#End Region
    End Class
End Namespace
