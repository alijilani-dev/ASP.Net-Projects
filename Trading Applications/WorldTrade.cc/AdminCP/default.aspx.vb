Namespace Admin


Public Class _default
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

        End Sub
    Protected WithEvents tbpasswrod As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblpassword As System.Web.UI.WebControls.Label
    Protected WithEvents tbusername As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblusername As System.Web.UI.WebControls.Label
    Protected WithEvents ddlportal As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblPortal As System.Web.UI.WebControls.Label
    Protected WithEvents btnlogin As System.Web.UI.WebControls.Button
    Protected WithEvents btnclose As System.Web.UI.WebControls.Button
    Protected WithEvents RFV_selectPortal As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RFVUsername As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RFVPassword As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents lblinvaliduser As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

#Region "Private variables"
    Private pi_obj_masteraccount As Trade_BL.MasterAccount
        Private pi_obj_portal As Trade_BL.Portal
#End Region

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Put user code to initialize the page here
            lblinvaliduser.Visible = False

            'fill the portal combo if not posted back
            If Page.IsPostBack = False Then
                FillPortalCombo()
            Else
                pi_obj_masteraccount = New Trade_BL.MasterAccount
            End If

        End Sub

#Region "General Functions"
        Public Sub FillPortalCombo()
            Dim dt_portal As DataTable
            Dim obj_portal As New Trade_BL.Portal

            Try
                dt_portal = New DataTable
                dt_portal = obj_portal.GetPortal(0)

                ddlportal.DataTextField = "portal_name"
                ddlportal.DataValueField = "portal_id"
                ddlportal.DataSource = dt_portal

                ddlportal.DataBind()
            Catch ex As Exception
                Throw ex
            Finally
                dt_portal = Nothing
                dt_portal = Nothing
            End Try
        End Sub
#End Region

        Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
            If pi_obj_masteraccount.IsValid(0, tbusername.Text, tbpasswrod.Text) = True Then
                Dim dt As New DataTable
                Dim dr As DataRow

                Dim portal_id As Integer

                Session(Session_str_Admin) = "TRUE"
                Try
                    ' get the portal id from the query string 
                    ' of the default.aspx
                    ' if portal_id is specified then
                    ' then portal is independed visited
                    ' if Session object of portal_id is Zero 
                    ' that means it has to be initialize to default portal
          portal_id = ddlportal.SelectedItem.Value

                Catch ex As Exception
                    portal_id = 0
                End Try

                ' this procedure gets the portal details like Id, Name
                ' if portal_ID is present i.e. > 0 then
                ' just get the details of portal and store that 
                ' into the session variables
                ' else if portal_ID is ZERO then get the 
                ' assume the first portal is default portal
                ' and proceed further
                pi_obj_portal = New Trade_BL.Portal
                dt = pi_obj_portal.GetPortal(portal_id)
                If dt.Rows.Count > 0 Then
                    dr = dt.Rows(0)
                    ' portal related information into the session
                    ' for the current session
                    Session(Session_str_Portal_ID) = dr("Portal_ID")
                    Session(Session_str_Portal_Name) = dr("Portal_Name")
                    Session(Session_str_Portal_Url) = "http://localhost/Trade/" 'dr("Portal_Url")
                    Session(Session_str_Portal_Logo) = dr("Portal_Logo")
                    Session(Session_str_Portal_StyleSheet) = dr("Portal_StyleSheet")
                End If
                Response.Redirect("Main.aspx")
            Else
                lblinvaliduser.Visible = True
            End If
        End Sub
End Class
End Namespace
