Namespace Admin
    Public Class MemberDetails
        Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

        'This call is required by the Web Form Designer.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

        End Sub
        Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
        Protected WithEvents ImgNew As System.Web.UI.WebControls.ImageButton
        Protected WithEvents TDHeader As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents TDView As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents TDAction As System.Web.UI.HtmlControls.HtmlTableCell

        Protected WithEvents updateMember As Member
        Protected WithEvents DGMember As System.Web.UI.WebControls.DataGrid


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
        Private Const pi_strCMember_id As String = "Member_id"
        Private Const pi_strCMember_username As String = "Member_username"
        Private Const pi_strCMember_Country As String = "member_id"
        'Private Const pi_strCMember_portal_id As String = "portal_id"
        'Private Const pi_strCshow_flag As String = "show_flag"

#End Region

#Region "Private variables"
        Private pi_Obj_Member As Trade_BL.Member
        Private dt_Member As DataTable
#End Region

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Put user code to initialize the page here
            Response.Cache.SetCacheability(HttpCacheability.NoCache)

            If Session(Session_str_Admin) = "FALSE" Then
                Response.Redirect("InvalidUser.htm")
                Response.End()

            End If
            dt_Member = New DataTable
            If Page.IsPostBack = False Then
                updateMember.Admin = True
                updateMember.Member_ID = "0"
                TDHeader.Visible = False
                lblMessage.Text = "Member Listing"
                'FillMember()
                ShowMemberDetails()

            End If

        End Sub

        Private Sub DGMember_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGMember.SelectedIndexChanged
            Dim member_id As String
            Try
                lblMessage.Text = "Edit Member"
                member_id = DGMember.DataKeys.Item(DGMember.SelectedIndex)
            Catch ex As Exception
                member_id = ""
            End Try

            Try
                FillMemberDetails(member_id)
            Catch ex As Exception
                'TDHeader.Visible = True
                TDView.Visible = True
                TDAction.Visible = False
                Throw ex
            End Try
        End Sub

        'Private Sub imgCancel_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgCancel.Click
        '    ShowMemberDetails()
        '    lblMessage.Text = "Member Listing"
        'End Sub

        'Private Sub imgSave_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgSave.Click
        '    Dim strImg As String
        '    pi_Obj_Member = New Trade_BL.Member

#Region "Functions "
        Public Sub FillMemberDetails(ByVal prmmember_id As String)
            'TDHeader.Visible = False
            TDView.Visible = False
            TDAction.Visible = True
            If prmmember_id <> "" Then
                pi_Obj_Member = New Trade_BL.Member
                dt_Member = pi_Obj_Member.GetMembers(prmmember_id)

                updateMember.Admin = True
                updateMember.Member_ID = prmmember_id
                updateMember.UpdateProfile()
            Else

            End If
        End Sub
        Public Sub ShowMemberDetails()
            Try
                pi_Obj_Member = New Trade_BL.Member
                dt_Member = pi_Obj_Member.GetMembers("")

                dt_Member.DefaultView.RowFilter = "Portal_ID = " & Session(Session_str_Portal_ID)

                Dim dtcolumn As New DataColumn
                dtcolumn.ColumnName = "Selected"
                dtcolumn.DataType = GetType(Boolean)
                dtcolumn.DefaultValue = 0

                dt_Member.Columns.Add(dtcolumn)

                DGMember.DataKeyField = "Member_ID"
                DGMember.DataSource = dt_Member

                If dt_Member.Rows.Count = ((DGMember.PageCount - 1) * DGMember.PageSize) Then
                    DGMember.CurrentPageIndex = DGMember.CurrentPageIndex - 1
                End If

                DGMember.DataBind()

                'TDHeader.Visible = True
                TDView.Visible = True
                TDAction.Visible = False
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

        '    pi_Obj_Member.Testimonial_ID = Convert.ToInt32("0" & tbtID.Text)
        '    pi_Obj_Member.Text = tbT_Detail.Text
        '    pi_Obj_Member.Portal_ID = Session(Session_str_Portal_ID)
        '    pi_Obj_Member.Member_Id = ddlMember.SelectedItem.Value
        '    pi_Obj_Member.Show_Flag = IIf(chkShowMember.Checked = True, 1, 0)

        '    If pi_Obj_Member.Testimonial_ID > 0 Then
        '        ' edit
        '        If pi_Obj_Member.Update() = True Then

        '            lblMessage.Text = "Updation done successfully, click Cancel to View Member Listing"
        '            FillMemberDetails(pi_Obj_Member.Testimonial_ID)
        '        End If
        '    Else
        '        ' add new

        '        If pi_Obj_Member.Insert() = True Then
        '            lblMessage.Text = "Member Added Successfully, Add New Member"
        '            FillMemberDetails(pi_Obj_Member.Testimonial_ID)
        '        End If
        '    End If

        'End Sub

        Private Sub ImgNew_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgNew.Click
            lblMessage.Text = "Add New Member ...."
            FillMemberDetails(0)
        End Sub

        Private Sub ImgDelete_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)
            Dim dr As DataRow()
            Dim icounter As Integer
            Try
                pi_Obj_Member = New Trade_BL.Member

                If TDAction.Visible = True Then
                    'pi_Obj_Member.Delete(tbTID.Text)
                    lblMessage.Text = "Add New Member ...."
                    FillMemberDetails(0)
                Else
                    Exit Sub
                    dr = CType(DGMember.DataSource, DataTable).Select("Selected = 1")
                    If dr.Length > 0 Then
                        For icounter = 0 To dr.Length - 1
                            'pi_Obj_Member.Delete(Convert.ToInt32(dr(icounter).Item(pi_strCann_id)))
                        Next
                        FillMemberDetails(0)
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        'Public Sub FillMember()
        '    Dim dt_member As New DataTable
        '    Dim pi_obj_member As Trade_BL.Member
        '    pi_obj_member = New Trade_BL.Member

        '    dt_member = pi_obj_member.GetMembers()

        '    ddlMember.DataSource = dt_member
        '    ddlMember.DataTextField = "Member_ID"
        '    ddlMember.DataValueField = "Member_ID"
        '    ddlMember.DataBind()

        'End Sub

#Region "Delete current selected Record"
        Private Sub DGMember_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DGMember.DeleteCommand
            pi_Obj_Member = New Trade_BL.Member

            If TDView.Visible = True Then
                'pi_Obj_Member.Delete(DGMember.DataKeys(e.Item.ItemIndex))
                ShowMemberDetails()
            End If

        End Sub
#End Region

#Region "Page Changed"
        Private Sub DGMember_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DGMember.PageIndexChanged
            DGMember.CurrentPageIndex = e.NewPageIndex
            ShowMemberDetails()
        End Sub
#End Region
    End Class
End Namespace