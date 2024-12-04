Public Class ContactUs
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblEnquiry As System.Web.UI.WebControls.Label
    Protected WithEvents butSubmit As System.Web.UI.WebControls.Button
    Protected WithEvents txtcontactName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCompanyName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPhone As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEmail As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtComments As System.Web.UI.WebControls.TextBox
    Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
    Protected WithEvents RFVContactname As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RFVCompanyName As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RFVComments As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents REVEmail As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents RFVPhone As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents Table2 As System.Web.UI.HtmlControls.HtmlTable
  Protected WithEvents lblthanku As System.Web.UI.WebControls.Label
  Protected WithEvents RFVEmail As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents lblportalname As System.Web.UI.WebControls.Label
  Protected WithEvents tblEnquiry As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents LogoImage As System.Web.UI.WebControls.Image
    Protected WithEvents TBMember As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents Tbl_LogoImage As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tr_companyLogofile As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents tblThanks As System.Web.UI.HtmlControls.HtmlTable

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
    Private pi_obj_Enquiry As Trade_BL.Enquiry
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        lblportalname.Text = Session(Session_str_Portal_Name)
    End Sub

    Private Sub butSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSubmit.Click
        pi_obj_Enquiry = New Trade_BL.Enquiry
        pi_obj_Enquiry.Enquiry_Id = 0
        pi_obj_Enquiry.Portal_ID = Session(Session_str_Portal_ID)
        pi_obj_Enquiry.ContactName = txtcontactName.Text
        pi_obj_Enquiry.CompanyName = txtCompanyName.Text
        pi_obj_Enquiry.Phone = txtPhone.Text
        pi_obj_Enquiry.Email = txtEmail.Text
        pi_obj_Enquiry.Comments = txtComments.Text

        lblthanku.Text = ""
        If pi_obj_Enquiry.Insert Then
            'lblthanku.Text = "Thank you for enquiring " & Session(Session_str_Portal_Name) & ", we will let you know about your enquiry to your mail id, <BR> you can post another enquiry <BR> Thank You"
            lblthanku.Visible = False
            Show_ThanksMessage()
            txtcontactName.Text = ""
            txtCompanyName.Text = ""
            txtPhone.Text = ""
            txtEmail.Text = ""
            txtComments.Text = ""
        End If
    End Sub
    Public Sub Show_ThanksMessage()

        Dim ctrl_TD_Thanks_Msg As Control ' td where we have to show the content control specified in module
        tblThanks.Visible = True
        ctrl_TD_Thanks_Msg = Me.FindControl("TD_Thanks_Msg")
        ctrl_TD_Thanks_Msg.Visible = True
        Try
            ctrl_TD_Thanks_Msg.Controls.Add(Me.LoadControl("../Module/ThanksEnquiry.ascx"))
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
        End Try
    End Sub

End Class
