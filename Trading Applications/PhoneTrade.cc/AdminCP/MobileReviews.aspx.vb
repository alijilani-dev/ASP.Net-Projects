Namespace Admin
    Public Class MobileReviews
        Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

        'This call is required by the Web Form Designer.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

        End Sub
        Protected WithEvents imgCancel As System.Web.UI.WebControls.ImageButton
        Protected WithEvents imgSave As System.Web.UI.WebControls.ImageButton
        Protected WithEvents RFVText As System.Web.UI.WebControls.RequiredFieldValidator
        Protected WithEvents ImgNew As System.Web.UI.WebControls.ImageButton
        Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
        Protected WithEvents TDHeader As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents TDView As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents TDAction As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents DGMobileReview As System.Web.UI.WebControls.DataGrid
        Protected WithEvents chkShowMobileReview As System.Web.UI.WebControls.CheckBox
        Protected WithEvents ddlModel As System.Web.UI.WebControls.DropDownList
        Protected WithEvents ddlBrand As System.Web.UI.WebControls.DropDownList
        Protected WithEvents tbMRID As System.Web.UI.WebControls.TextBox
        Protected WithEvents tbMobileReview As System.Web.UI.WebControls.TextBox

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
        Private Const pi_strC_MR_ID As String = "MR_id"
        Private Const pi_strC_MobileReview As String = "MobileReview"
        Private Const pi_strC_ManufCode As String = "ManufCode"
        Private Const pi_strC_MobileSrNo As String = "MobileSrNo"
        Private Const pi_strC_Status As String = "Status"
        Private Const pi_strCshow_flag As String = "show_flag"


#End Region

#Region "Private variables"
        Private pi_Obj_MobileReview As Trade_BL.Review
        Private dt_MobileReview As DataTable
        Private pi_obj_MobileModel As New Trade_BL.MobileModel
        Private pi_obj_Brand As New Trade_BL.Manufacturer

#End Region

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Put user code to initialize the page here
            Response.Cache.SetCacheability(HttpCacheability.NoCache)
            If Session(Session_str_Admin) = "FALSE" Then
                Response.Redirect("InvalidUser.htm")
                Response.End()
            End If
            dt_MobileReview = New DataTable
            If Page.IsPostBack = False Then
                lblMessage.Text = "Mobile Review Listing"
                ShowMobileReviewDetails()
                FillBrand()
            End If

        End Sub

        Private Sub DGMobileReview_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGMobileReview.SelectedIndexChanged
            Dim annid As Integer
            Try
                lblMessage.Text = "Edit Mobile Review"
                annid = DGMobileReview.DataKeys.Item(DGMobileReview.SelectedIndex)
            Catch ex As Exception
                annid = 0
            End Try

            Try
                FillMobileReviewDetails(annid)
            Catch ex As Exception
                'TDHeader.Visible = True
                TDView.Visible = True
                TDAction.Visible = False
                Throw ex
            End Try
        End Sub

        Private Sub imgCancel_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgCancel.Click
            ShowMobileReviewDetails()
            lblMessage.Text = "Mobile Review Listing"
        End Sub

        Private Sub imgSave_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgSave.Click
            Dim strImg As String
            pi_Obj_MobileReview = New Trade_BL.Review

            pi_Obj_MobileReview.MR_id = Convert.ToInt32("0" & tbMRID.Text)
            pi_Obj_MobileReview.MobileReview = tbMobileReview.Text
            pi_Obj_MobileReview.Portal_id = Session(Session_str_Portal_ID)
            pi_Obj_MobileReview.Status = IIf(chkShowMobileReview.Checked = True, 0, 1)
      pi_Obj_MobileReview.MobileSrNo = ddlModel.SelectedItem.Value

            If pi_Obj_MobileReview.MR_id > 0 Then
                ' edit
                If pi_Obj_MobileReview.Update() = True Then

                    lblMessage.Text = "Updation done successfully, click Cancel to View Mobile Review Listing"
                    FillMobileReviewDetails(pi_Obj_MobileReview.MR_id)
                End If
            Else
                ' add new
                If pi_Obj_MobileReview.Insert() = True Then
                    lblMessage.Text = "Mobile Review Added Successfully, Add New Mobile Review"
                    FillMobileReviewDetails(pi_Obj_MobileReview.MR_id)
                End If
            End If

        End Sub

#Region "Functions "
        Public Sub FillMobileReviewDetails(ByVal prm_MR_id As Integer)
            'TDHeader.Visible = False
            TDView.Visible = False
            TDAction.Visible = True
            If prm_MR_id > 0 Then
                pi_Obj_MobileReview = New Trade_BL.Review
                dt_MobileReview = pi_Obj_MobileReview.GetReview(prm_MR_id)

                tbMRID.Text = Convert.ToString(dt_MobileReview.Rows(0).Item(pi_strC_MR_ID))
                tbMobileReview.Text = Convert.ToString(dt_MobileReview.Rows(0).Item(pi_strC_MobileReview))
                chkShowMobileReview.Checked = IIf(Convert.ToBoolean(dt_MobileReview.Rows(0).Item(pi_strC_Status)) = True, True, False)
        ddlBrand.SelectedItem.Value = dt_MobileReview.Rows(0).Item(pi_strC_ManufCode)
                FillModels()
        ddlModel.SelectedItem.Value = dt_MobileReview.Rows(0).Item(pi_strC_MobileSrNo)
            Else
                pi_Obj_MobileReview = New Trade_BL.Review
                tbMRID.Text = "0"
                tbMobileReview.Text = ""
                chkShowMobileReview.Checked = True
            End If
        End Sub
        Public Sub ShowMobileReviewDetails()
            Try
                pi_Obj_MobileReview = New Trade_BL.Review
                dt_MobileReview = pi_Obj_MobileReview.GetReview(0)

                Dim dtcolumn As New DataColumn
                dtcolumn.ColumnName = "Selected"
                dtcolumn.DataType = GetType(Boolean)
                dtcolumn.DefaultValue = 0

                dt_MobileReview.Columns.Add(dtcolumn)

                DGMobileReview.DataKeyField = "MR_id"
                DGMobileReview.DataSource = dt_MobileReview

                If dt_MobileReview.Rows.Count = ((DGMobileReview.PageCount - 1) * DGMobileReview.PageSize) Then
                    DGMobileReview.CurrentPageIndex = DGMobileReview.CurrentPageIndex - 1
                End If

                DGMobileReview.DataBind()

                'TDHeader.Visible = True
                TDView.Visible = True
                TDAction.Visible = False
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region


        Private Sub ImgNew_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgNew.Click
            lblMessage.Text = "Add New Mobile Review ...."
            FillMobileReviewDetails(0)
        End Sub

        Private Sub ImgDelete_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)
            Dim dr As DataRow()
            Dim icounter As Integer
            Try
                pi_Obj_MobileReview = New Trade_BL.Review

                If TDAction.Visible = True Then
                    pi_Obj_MobileReview.Delete(tbMRID.Text)
                    lblMessage.Text = "Add New Mobile Review ...."
                    FillMobileReviewDetails(0)
                Else
                    Exit Sub
                    dr = CType(DGMobileReview.DataSource, DataTable).Select("Selected = 1")
                    If dr.Length > 0 Then
                        For icounter = 0 To dr.Length - 1
                            'pi_Obj_MobileReview.Delete(Convert.ToInt32(dr(icounter).Item(pi_strCann_id)))
                        Next
                        FillMobileReviewDetails(0)
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub


        Private Sub FillBrand()

            Dim dt_Brand As New DataTable
            pi_obj_Brand = New Trade_BL.Manufacturer

            dt_Brand = pi_obj_Brand.GetManufacturer()

            ddlBrand.DataSource = dt_Brand
            ddlBrand.DataTextField = "ManufName"
            ddlBrand.DataValueField = "ManufCode"
            ddlBrand.DataBind()

            FillModels()
        End Sub
        Private Sub FillModels()

            'Dim li As ListItem
            Dim dt_MobileModel As New DataTable
            pi_obj_MobileModel = New Trade_BL.MobileModel

            'li = New ListItem
            'li.Text = "_Other Models"
            'li.Value = "0"

            dt_MobileModel = pi_obj_MobileModel.GetBrandMobileModel(ddlBrand.SelectedItem.Value)

            ddlModel.DataSource = dt_MobileModel
            ddlModel.DataTextField = "ModelNo"
            ddlModel.DataValueField = "SrNo"
            ddlModel.DataBind()
            'ddlModel.Items.Add(li)
            ddlModel.SelectedIndex = 0

        End Sub

        Private Sub ddlBrand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlBrand.SelectedIndexChanged
            FillModels()
        End Sub

#Region "Delete current selected Record"
        Private Sub DGMobileReview_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DGMobileReview.DeleteCommand
            pi_Obj_MobileReview = New Trade_BL.Review

            If TDView.Visible = True Then
                pi_Obj_MobileReview.Delete(DGMobileReview.DataKeys(e.Item.ItemIndex))
                ShowMobileReviewDetails()
            End If

        End Sub
#End Region

#Region "Page Changed"
        Private Sub DGMobileReview_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DGMobileReview.PageIndexChanged
            DGMobileReview.CurrentPageIndex = e.NewPageIndex
            ShowMobileReviewDetails()
        End Sub
#End Region
    End Class
End Namespace
