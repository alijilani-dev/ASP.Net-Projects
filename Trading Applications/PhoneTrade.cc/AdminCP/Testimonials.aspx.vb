Namespace Admin
    Public Class Tetimonials
        Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

        'This call is required by the Web Form Designer.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

        End Sub
        Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
        Protected WithEvents ImgNew As System.Web.UI.WebControls.ImageButton
        Protected WithEvents RFVText As System.Web.UI.WebControls.RequiredFieldValidator
        Protected WithEvents imgSave As System.Web.UI.WebControls.ImageButton
        Protected WithEvents imgCancel As System.Web.UI.WebControls.ImageButton
        Protected WithEvents TDHeader As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents TDView As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents TDAction As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents DGTestimonials As System.Web.UI.WebControls.DataGrid
        Protected WithEvents tbTID As System.Web.UI.WebControls.TextBox
        Protected WithEvents tbT_Detail As System.Web.UI.WebControls.TextBox
        Protected WithEvents chkShowTestimonials As System.Web.UI.WebControls.CheckBox
        Protected WithEvents ddlMember As System.Web.UI.WebControls.DropDownList

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
        Private Const pi_strCTestimonials_id As String = "Tid"
        Private Const pi_strCTestimonials_detail As String = "TText"
        Private Const pi_strCTestimonials_member_id As String = "member_id"
        Private Const pi_strCTestimonials_portal_id As String = "portal_id"
        Private Const pi_strCshow_flag As String = "show_flag"

#End Region

#Region "Private variables"
        Private pi_Obj_Testimonials As Trade_BL.Testimonials
        Private dt_Testimonials As DataTable
#End Region

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Put user code to initialize the page here
            Response.Cache.SetCacheability(HttpCacheability.NoCache)
            If Session(Session_str_Admin) = "FALSE" Then
                Response.Redirect("InvalidUser.htm")
                Response.End()
            End If
            dt_Testimonials = New DataTable
            If Page.IsPostBack = False Then
                lblMessage.Text = "Testimonials Listing"
                FillMember()
                ShowTestimonialsDetails()

            End If

        End Sub

        Private Sub DGTestimonials_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGTestimonials.SelectedIndexChanged
            Dim annid As Integer
            Try
                lblMessage.Text = "Edit Testimonials"
                annid = DGTestimonials.DataKeys.Item(DGTestimonials.SelectedIndex)
            Catch ex As Exception
                annid = 0
            End Try

            Try
                FillTestimonialsDetails(annid)
            Catch ex As Exception
                'TDHeader.Visible = True
                TDView.Visible = True
                TDAction.Visible = False
                Throw ex
            End Try
        End Sub

        Private Sub imgCancel_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgCancel.Click
            ShowTestimonialsDetails()
            lblMessage.Text = "Testimonials Listing"
        End Sub

        Private Sub imgSave_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgSave.Click
            Dim strImg As String
            pi_Obj_Testimonials = New Trade_BL.Testimonials

            pi_Obj_Testimonials.Testimonial_ID = Convert.ToInt32("0" & tbtID.Text)
            pi_Obj_Testimonials.Text = tbT_Detail.Text
            pi_Obj_Testimonials.Portal_ID = Session(Session_str_Portal_ID)
      pi_Obj_Testimonials.Member_Id = ddlMember.SelectedItem.Value
            pi_Obj_Testimonials.Show_Flag = IIf(chkShowTestimonials.Checked = True, 1, 0)

            If pi_Obj_Testimonials.Testimonial_ID > 0 Then
                ' edit
                If pi_Obj_Testimonials.Update() = True Then

                    lblMessage.Text = "Updation done successfully, click Cancel to View Testimonials Listing"
                    FillTestimonialsDetails(pi_Obj_Testimonials.Testimonial_ID)
                End If
            Else
                ' add new
               
                If pi_Obj_Testimonials.Insert() = True Then
                    lblMessage.Text = "Testimonials Added Successfully, Add New Testimonials"
                    FillTestimonialsDetails(pi_Obj_Testimonials.Testimonial_ID)
                End If
            End If

        End Sub

#Region "Functions "
        Public Sub FillTestimonialsDetails(ByVal prmann_id As Integer)
            'TDHeader.Visible = False
            TDView.Visible = False
            TDAction.Visible = True
            If prmann_id > 0 Then
                pi_Obj_Testimonials = New Trade_BL.Testimonials
                dt_Testimonials = pi_Obj_Testimonials.GetTestimonials(prmann_id)

                tbTID.Text = Convert.ToString(dt_Testimonials.Rows(0).Item(pi_strCTestimonials_id))
                tbT_Detail.Text = Convert.ToString(dt_Testimonials.Rows(0).Item(pi_strCTestimonials_detail))
        ddlMember.SelectedItem.Value = Convert.ToString(dt_Testimonials.Rows(0).Item(pi_strCTestimonials_member_id))
                chkShowTestimonials.Checked = IIf(Convert.ToBoolean(dt_Testimonials.Rows(0).Item(pi_strCshow_flag)) = True, True, False)
                ddlMember.Enabled = False
            Else
                ddlMember.Enabled = True
                pi_Obj_Testimonials = New Trade_BL.Testimonials
                tbTID.Text = "0"

                tbT_Detail.Text = ""
                chkShowTestimonials.Checked = False
            End If
        End Sub
        Public Sub ShowTestimonialsDetails()
            Try
                pi_Obj_Testimonials = New Trade_BL.Testimonials
                dt_Testimonials = pi_Obj_Testimonials.GetTestimonials(0)

                Dim dtcolumn As New DataColumn
                dtcolumn.ColumnName = "Selected"
                dtcolumn.DataType = GetType(Boolean)
                dtcolumn.DefaultValue = 0

                dt_Testimonials.Columns.Add(dtcolumn)

                DGTestimonials.DataKeyField = "Tid"
                DGTestimonials.DataSource = dt_Testimonials

                If dt_Testimonials.Rows.Count = ((DGTestimonials.PageCount - 1) * DGTestimonials.PageSize) Then
                    DGTestimonials.CurrentPageIndex = DGTestimonials.CurrentPageIndex - 1
                End If

                DGTestimonials.DataBind()

                'TDHeader.Visible = True
                TDView.Visible = True
                TDAction.Visible = False
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region


        Private Sub ImgNew_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgNew.Click
            lblMessage.Text = "Add New Testimonials ...."
            FillTestimonialsDetails(0)
        End Sub

        Private Sub ImgDelete_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)
            Dim dr As DataRow()
            Dim icounter As Integer
            Try
                pi_Obj_Testimonials = New Trade_BL.Testimonials

                If TDAction.Visible = True Then
                    pi_Obj_Testimonials.Delete(tbTID.Text)
                    lblMessage.Text = "Add New Testimonials ...."
                    FillTestimonialsDetails(0)
                Else
                    Exit Sub
                    dr = CType(DGTestimonials.DataSource, DataTable).Select("Selected = 1")
                    If dr.Length > 0 Then
                        For icounter = 0 To dr.Length - 1
                            'pi_Obj_Testimonials.Delete(Convert.ToInt32(dr(icounter).Item(pi_strCann_id)))
                        Next
                        FillTestimonialsDetails(0)
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

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

#Region "Delete current selected Record"
        Private Sub DGTestimonials_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DGTestimonials.DeleteCommand
            pi_Obj_Testimonials = New Trade_BL.Testimonials

            If TDView.Visible = True Then
                pi_Obj_Testimonials.Delete(DGTestimonials.DataKeys(e.Item.ItemIndex))
                ShowTestimonialsDetails()
            End If

        End Sub
#End Region

#Region "Page Changed"
        Private Sub DGTestimonials_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DGTestimonials.PageIndexChanged
            DGTestimonials.CurrentPageIndex = e.NewPageIndex
            ShowTestimonialsDetails()
        End Sub
#End Region
    End Class
End Namespace
