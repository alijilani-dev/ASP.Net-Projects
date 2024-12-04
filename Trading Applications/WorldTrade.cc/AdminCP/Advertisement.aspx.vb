Namespace Admin
    Public Class Advertisement
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
        Protected WithEvents Img_Url_path As System.Web.UI.HtmlControls.HtmlInputFile
        Protected WithEvents Img_Url As System.Web.UI.WebControls.Image
        Protected WithEvents tbSeqNo As System.Web.UI.WebControls.TextBox
        Protected WithEvents REVtbLinkSeq As System.Web.UI.WebControls.RegularExpressionValidator
        Protected WithEvents TD_Image_Url_Br As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents TD_Img As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents tbAd_ID As System.Web.UI.WebControls.TextBox
        Protected WithEvents ddlMember As System.Web.UI.WebControls.DropDownList
        Protected WithEvents tbAlternate_Text As System.Web.UI.WebControls.TextBox
        Protected WithEvents ddlAdType As System.Web.UI.WebControls.DropDownList
        Protected WithEvents ddlPosition As System.Web.UI.WebControls.DropDownList
        Protected WithEvents DGAdvertisement As System.Web.UI.WebControls.DataGrid

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
        Private Const pi_strCAd_id As String = "advert_id"
        Private Const pi_strCportal_id As String = "portal_id"
        Private Const pi_strCadvert_image_url As String = "advert_image_url"
        Private Const pi_strCadvert_alt_text As String = "advert_alt_text"

        Private Const pi_strCmodule_id As String = "module_id"
        Private Const pi_strCmember_id As String = "member_id"
        Private Const pi_strCadvert_type_id As String = "advert_type_id"

        Private Const pi_strCPosition As String = "ad_Position"
        Private Const pi_strCLinks_Seq As String = "advert_priority"




#End Region

#Region "Private variables"
        Private pi_Obj_Advertisement As Trade_BL.Advertisement
        Private dt_Advertisement As DataTable
#End Region

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Put user code to initialize the page here
            Response.Cache.SetCacheability(HttpCacheability.NoCache)

            If Session(Session_str_Admin) = "FALSE" Then
                Response.Redirect("InvalidUser.htm")
                Response.End()
            End If
            dt_Advertisement = New DataTable
            If Page.IsPostBack = False Then
                FillMember()
                lblMessage.Text = "Advertisement"
                ShowAdvertisementDetails()
            End If

        End Sub

        Private Sub DGAdvertisement_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGAdvertisement.SelectedIndexChanged
            Dim annid As Integer
            Try
                lblMessage.Text = "Edit Advertisement"
                annid = DGAdvertisement.DataKeys.Item(DGAdvertisement.SelectedIndex)
            Catch ex As Exception
                annid = 0
            End Try

            Try
                FillAdvertisementDetails(annid)
            Catch ex As Exception
                'TDHeader.Visible = True
                TDView.Visible = True
                TDAction.Visible = False
                Throw ex
            End Try
        End Sub

        Private Sub imgCancel_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgCancel.Click
            ShowAdvertisementDetails()
            lblMessage.Text = "Advertisement"
        End Sub

        Private Sub imgSave_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgSave.Click
            Dim strImg As String
            pi_Obj_Advertisement = New Trade_BL.Advertisement

            pi_Obj_Advertisement.advert_id = tbAd_ID.Text

            'pi_Obj_Advertisement. = Session(Session_str_Portal_ID)
            
            If Img_Url_path.Value <> "" Then
                ' add new
                strImg = Server.MapPath("..\Images\Advs\") & "\" & Strings.Right(Img_Url_path.Value, Img_Url_path.Value.Length - Strings.InStrRev(Img_Url_path.Value, "\"))
                pi_Obj_Advertisement.advert_image_url = "Images/Advs/" & Strings.Right(Img_Url_path.Value, Img_Url_path.Value.Length - Strings.InStrRev(Img_Url_path.Value, "\"))
                Try
                    Img_Url_path.PostedFile.SaveAs(strImg)

                Catch Exc As Exception
                    lblMessage.Text = "Please enter proper Image file "
                    lblMessage.Visible = True
                    Exit Sub
                End Try
            End If

            pi_Obj_Advertisement.advert_alt_text = tbAlternate_Text.Text
            pi_Obj_Advertisement.advert_type_id = ddlAdType.SelectedValue
            pi_Obj_Advertisement.member_id = ddlMember.SelectedValue
            pi_Obj_Advertisement.module_id = 9
            pi_Obj_Advertisement.timestamp = DateTime.Now

            pi_Obj_Advertisement.Ad_Position = ddlPosition.SelectedValue
            pi_Obj_Advertisement.advert_priority = tbSeqNo.Text


            If pi_Obj_Advertisement.advert_id > 0 Then
                ' edit
                If pi_Obj_Advertisement.Update() = True Then
                    lblMessage.Text = "Updation done successfully, click Cancel to View Advertisement"
                End If
            Else
                ' add new
                If pi_Obj_Advertisement.Insert() = True Then
                    lblMessage.Text = "Advertisement Added Successfully, Add New Advertisement"
                    FillAdvertisementDetails(0)
                End If
            End If

        End Sub

#Region "Functions "
        Public Sub FillMember()
            Dim dt_member As New DataTable
            Dim pi_obj_member As Trade_BL.Member
            pi_obj_member = New Trade_BL.Member

            dt_member = pi_obj_member.GetMembers()

            ddlMember.DataSource = dt_member
            ddlMember.DataTextField = "Member_ID"
            ddlMember.DataValueField = "Member_ID"
            ddlMember.DataBind()

        End Sub

        Public Sub FillAdvertisementDetails(ByVal prmADID As Integer)
            'TDHeader.Visible = False
            TDView.Visible = False
            TDAction.Visible = True
            If prmADID > 0 Then
                TD_Img.Visible = True

                pi_Obj_Advertisement = New Trade_BL.Advertisement

                dt_Advertisement = pi_Obj_Advertisement.GetAdvertisement(prmADID)

                tbAd_ID.Text = Convert.ToString(dt_Advertisement.Rows(0).Item(pi_strCAd_id))
                ddlMember.SelectedValue = Convert.ToString(dt_Advertisement.Rows(0).Item(pi_strCmember_id))
                Img_Url.ImageUrl = "..\" & Convert.ToString(dt_Advertisement.Rows(0).Item(pi_strCadvert_image_url))
                tbAlternate_Text.Text = Convert.ToString(dt_Advertisement.Rows(0).Item(pi_strCadvert_alt_text))

                tbSeqNo.Text = Format(CType(dt_Advertisement.Rows(0).Item(pi_strCLinks_Seq), Integer), "00")

                ddlAdType.SelectedValue = Convert.ToString(dt_Advertisement.Rows(0).Item(pi_strCadvert_type_id))
                ddlPosition.SelectedValue = Convert.ToString(dt_Advertisement.Rows(0).Item(pi_strCPosition))

            Else
                Dim dt_Links_seqNo As New DataTable
                pi_Obj_Advertisement = New Trade_BL.Advertisement
                tbAd_ID.Text = "0"
                TD_Img.Visible = False
                Img_Url.ImageUrl = ""
                tbAlternate_Text.Text = ""
                tbSeqNo.Text = "00"
            End If
        End Sub
        Public Sub ShowAdvertisementDetails()
            Try
                pi_Obj_Advertisement = New Trade_BL.Advertisement
                dt_Advertisement = pi_Obj_Advertisement.GetAdvertisement()

                Dim dtcolumn As New DataColumn
                dtcolumn.ColumnName = "Selected"
                dtcolumn.DataType = GetType(Boolean)
                dtcolumn.DefaultValue = 0

                dt_Advertisement.Columns.Add(dtcolumn)

                DGAdvertisement.DataKeyField = "advert_id"
                DGAdvertisement.DataSource = dt_Advertisement

                If dt_Advertisement.Rows.Count = ((DGAdvertisement.PageCount - 1) * DGAdvertisement.PageSize) Then
                    DGAdvertisement.CurrentPageIndex = DGAdvertisement.CurrentPageIndex - 1
                End If

                DGAdvertisement.DataBind()

                'TDHeader.Visible = True
                TDView.Visible = True
                TDAction.Visible = False
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

        Private Sub ImgNew_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgNew.Click
            lblMessage.Text = "Add New Advertisement ...."
            FillAdvertisementDetails(0)
        End Sub

        Private Sub ImgDelete_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)
            Dim dr As DataRow()
            Dim icounter As Integer
            Try
                pi_Obj_Advertisement = New Trade_BL.Advertisement

                If TDAction.Visible = True Then
                    'pi_Obj_Advertisement.Delete(tbMainLinkID.Text)
                    lblMessage.Text = "Add New Advertisement ...."
                    FillAdvertisementDetails(0)
                Else
                    Exit Sub
                    dr = CType(DGAdvertisement.DataSource, DataTable).Select("Selected = 1")
                    If dr.Length > 0 Then
                        For icounter = 0 To dr.Length - 1
                            ''pi_Obj_Advertisement.Delete(Convert.ToInt32(dr(icounter).Item(pi_strCann_id)))
                        Next
                        FillAdvertisementDetails(0)
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

#Region "Delete current selected Record"
        Private Sub DGAdvertisement_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DGAdvertisement.DeleteCommand
            pi_Obj_Advertisement = New Trade_BL.Advertisement

            If TDView.Visible = True Then
                'pi_Obj_Advertisement.Delete(DGNews.DataKeys(e.Item.ItemIndex))
                'ShowAdvertisementDetails()
            End If

        End Sub
#End Region

#Region "Page Changed"
        Private Sub DGAdvertisement_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DGAdvertisement.PageIndexChanged
            DGAdvertisement.CurrentPageIndex = e.NewPageIndex
            ShowAdvertisementDetails()
        End Sub
#End Region


    End Class
End Namespace
