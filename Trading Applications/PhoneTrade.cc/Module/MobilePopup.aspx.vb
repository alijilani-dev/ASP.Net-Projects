Public Class MobilePopup
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Table1 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents imgMain As System.Web.UI.WebControls.ImageButton
    Protected WithEvents lblModelNo As System.Web.UI.WebControls.Label
    Protected WithEvents hlnkDetails As System.Web.UI.WebControls.HyperLink

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region
#Region "private variables"
    Private Pi_Mobile_SrNo As Integer

    Private pi_Obj_MobileModel As Trade_BL.MobileModel
#End Region

#Region "Public Properties"
    Public Property MobileSrNo() As Integer
        Get
            Return Pi_Mobile_SrNo
        End Get
        Set(ByVal Value As Integer)
            Pi_Mobile_SrNo = Value
        End Set
    End Property
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillMobileDetails()
    End Sub
    Public Sub FillMobileDetails()
        Dim dt_Mdetails As New DataTable
        pi_Obj_MobileModel = New Trade_BL.MobileModel
        Try
            dt_Mdetails = pi_Obj_MobileModel.GetMobileModel(Request.QueryString("MobileSrNo"))
            lblModelNo.Text = dt_Mdetails.Rows(0)("ManufName").ToString() & " - " & dt_Mdetails.Rows(0)("ModelNo").ToString()
            imgMain.ImageUrl = "~/Images/Models/" & dt_Mdetails.Rows(0).Item("ImgFile1").ToString
            hlnkDetails.Attributes.Add("onClick", String.Format("javascript:window.close();window.opener.location.href='../PortalDefault.aspx?Main_Links_ID=5&MobileSrNo={0}';", Request.QueryString("MobileSrNo")))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
