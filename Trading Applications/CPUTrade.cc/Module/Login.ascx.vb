Public Class Login
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblloginHeader As System.Web.UI.WebControls.Label
    Protected WithEvents lblusername As System.Web.UI.WebControls.Label
    Protected WithEvents tbUserName As System.Web.UI.WebControls.TextBox
    Protected WithEvents RqFVUsername As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents lblPassword As System.Web.UI.WebControls.Label
    Protected WithEvents tbPassword As System.Web.UI.WebControls.TextBox
    Protected WithEvents RqFVUserpwd As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents chkAdmin As System.Web.UI.WebControls.CheckBox
    Protected WithEvents cmdLogin As System.Web.UI.WebControls.Button
    Protected WithEvents cmdclear As System.Web.UI.WebControls.Button
    Protected WithEvents tblmainLogin As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents lblUser As System.Web.UI.WebControls.Label
    Protected WithEvents HyperLink1 As System.Web.UI.WebControls.HyperLink
    Protected WithEvents HyperLink2 As System.Web.UI.WebControls.HyperLink
    Protected WithEvents HyperLink3 As System.Web.UI.WebControls.HyperLink
    Protected WithEvents HyperLink4 As System.Web.UI.WebControls.HyperLink
    Protected WithEvents tblWelcome As System.Web.UI.HtmlControls.HtmlTable

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
    Private pi_obj_member As New Trade_BL.Member
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here

        ' here if uername is present then some one is loged in
        ' that is sure
        ' if that is the admin then show him login box
        ' and if he is not a admin then donot show his login dialog box again
        tblWelcome.Visible = (Session(Session_str_UserName).ToString.Trim <> "")

        '        hypsignup.NavigateUrl = "../main_links/SignUp.aspx?Main_Links_ID=" & MyBase.Main_Links_ID
        Session(Session_Str_Cur_Main_Link_ID) = MyBase.Main_Links_ID

        If Session(Session_str_Admin) = False _
                And Session(Session_str_UserName) <> "" Then
            'Me.Visible = False
            tblmainLogin.Visible = False
            lblUser.Visible = True
            lblUser.Text = "Welcome, " & Session(Session_str_UserName)
        Else '.style.display==''
            'Me.Visible = True
            tblmainLogin.Visible = True
            lblUser.Visible = False
            lblUser.Text = ""
        End If
        'Me.Attributes.Add("onLoad", "javascript:document.Form1.tbUserName.focus();")
        'onload="javascript:document.Form1.TextBox1.focus();"> 
        If Request.QueryString("Login") = "failed" Then
            lblloginHeader.Visible = True
            lblloginHeader.Text = "User Name or Password is incorrect, Please try again"
        End If
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbUserName.Text = ""
        tbPassword.Text = ""
    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        Dim iPortalID As Integer
        iPortalID = Session(Session_str_Portal_ID)
        If chkAdmin.Checked = False Then
            If pi_obj_member.IsValidMember(iPortalID, tbUserName.Text.Trim, tbPassword.Text.Trim) Then
                Session(Session_str_Admin) = False
                Session(Session_str_UserName) = tbUserName.Text.Trim
                If MyBase.Redirect_Main_Links_ID > 0 Then
                    Response.Redirect("PortalDefault.aspx?Main_Links_ID=" & MyBase.Redirect_Main_Links_ID)
                Else
                    Response.Redirect("PortalDefault.aspx?Main_Links_ID=" & MyBase.Main_Links_ID)
                End If
            Else
                tbUserName.Text = ""
                tbPassword.Text = ""
                lblloginHeader.Text = "User Name or Password is incorrect, Please try again"
            End If
        Else
            If String.Compare(tbUserName.Text.Trim, "admin") <= 0 And _
                String.Compare(tbPassword.Text.Trim, "sandy") <= 0 Then
                Session(Session_str_Admin) = True
                Session(Session_str_UserName) = tbUserName.Text.Trim
                Response.Redirect("Default.aspx?Portal_ID=" & iPortalID)
            Else
                tbUserName.Text = ""
                tbPassword.Text = ""
                lblloginHeader.Text = "User Name or Password is incorrect, Please try again"
            End If
        End If
    End Sub
End Class
