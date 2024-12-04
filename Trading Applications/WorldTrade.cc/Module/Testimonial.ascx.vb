Public Class Testimonial
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents DLTestimonial As System.Web.UI.WebControls.DataList
    Protected WithEvents TDAction As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TDView As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents imgCancel As System.Web.UI.WebControls.ImageButton
    Protected WithEvents imgSave As System.Web.UI.WebControls.ImageButton
    Protected WithEvents RFVText As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents tbtestomonial As System.Web.UI.WebControls.TextBox
    Protected WithEvents tbid As System.Web.UI.WebControls.TextBox

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
    Private pi_Obj_Testimonials As Trade_BL.Testimonials
#End Region
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        pi_Obj_Testimonials = New Trade_BL.Testimonials
        If Page.IsPostBack = False Then
            DLTestimonial.DataSource = pi_Obj_Testimonials.GetPortalTestimonials(Session(Session_str_Portal_ID))
            DLTestimonial.DataBind()

        End If
        If Session(Session_str_UserName) <> "" Then ' user is logged in
            Dim dt As New DataTable
      dt = pi_Obj_Testimonials.GetMemberTestimonials(Session(Session_str_Portal_ID), Session(Session_str_UserName))
      If dt.Rows.Count > 0 Then
        tbtestomonial.Text = dt.Rows(0).Item("TText")
        tbid.Text = dt.Rows(0).Item("TID")
      Else
        tbid.Text = 0
      End If
      TDAction.Visible = True

    Else
      TDAction.Visible = False
    End If
    End Sub

    Private Sub imgSave_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgSave.Click
        pi_Obj_Testimonials.Member_Id = Session(Session_str_UserName)
        pi_Obj_Testimonials.Portal_ID = Session(Session_str_Portal_ID)
        pi_Obj_Testimonials.Text = tbtestomonial.Text
        If tbid.Text = "" Then
            pi_Obj_Testimonials.Testimonial_ID = 0
        Else
            pi_Obj_Testimonials.Testimonial_ID = tbid.Text
        End If

        If pi_Obj_Testimonials.Testimonial_ID > 0 Then
            'update
            pi_Obj_Testimonials.Update()
            tbid.Text = pi_Obj_Testimonials.Testimonial_ID
        Else
            pi_Obj_Testimonials.Insert()
            tbid.Text = pi_Obj_Testimonials.Testimonial_ID
        End If
    End Sub

    Private Sub imgCancel_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgCancel.Click

    End Sub
End Class
