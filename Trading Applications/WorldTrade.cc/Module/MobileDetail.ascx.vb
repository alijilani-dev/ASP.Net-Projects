Public Class MobileDetail
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblDetialModel As System.Web.UI.WebControls.Label
    Protected WithEvents lblDetialModelNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblFeatures As System.Web.UI.WebControls.Label
    Protected WithEvents lblCamerainfo As System.Web.UI.WebControls.Label
    Protected WithEvents lblCamera As System.Web.UI.WebControls.Label
    Protected WithEvents lblMobilecolors As System.Web.UI.WebControls.Label
    Protected WithEvents lblGames As System.Web.UI.WebControls.Label
    Protected WithEvents lblModel3G As System.Web.UI.WebControls.Label
    Protected WithEvents lblBlueTooth As System.Web.UI.WebControls.Label
    Protected WithEvents lblInfrared As System.Web.UI.WebControls.Label
    Protected WithEvents lblAlarm As System.Web.UI.WebControls.Label
    Protected WithEvents lblClock As System.Web.UI.WebControls.Label
    Protected WithEvents lblInstantMsg As System.Web.UI.WebControls.Label
    Protected WithEvents lblEmailMsg As System.Web.UI.WebControls.Label
    Protected WithEvents lblMMS As System.Web.UI.WebControls.Label
    Protected WithEvents lblSMS As System.Web.UI.WebControls.Label
    Protected WithEvents lblDataSpeed As System.Web.UI.WebControls.Label
    Protected WithEvents lblGPRS As System.Web.UI.WebControls.Label
    Protected WithEvents lblOSType As System.Web.UI.WebControls.Label
    Protected WithEvents lblBatteryInfo As System.Web.UI.WebControls.Label
    Protected WithEvents lblVibration As System.Web.UI.WebControls.Label
    Protected WithEvents lblCustomizeTone As System.Web.UI.WebControls.Label
    Protected WithEvents lbldisplaySize As System.Web.UI.WebControls.Label
    Protected WithEvents lblDisplayInfo As System.Web.UI.WebControls.Label
    Protected WithEvents lblCallRecord As System.Web.UI.WebControls.Label
    Protected WithEvents lblPhoneBook As System.Web.UI.WebControls.Label
    Protected WithEvents lblDimension As System.Web.UI.WebControls.Label
    Protected WithEvents lblWeight As System.Web.UI.WebControls.Label
    Protected WithEvents imgMain As System.Web.UI.WebControls.ImageButton

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

  '#Region "Public Properties"
  '    Public Property Mobile_SrNo() As Integer
  '        Get
  '            Return Pi_Mobile_SrNo
  '        End Get
  '        Set(ByVal Value As Integer)
  '            Pi_Mobile_SrNo = Value
  '        End Set
  '    End Property
  '#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here

    End Sub

    Public Sub FillMobileDetails(ByVal Mobile_SrNo As Integer)
        Dim dt_Mdetails As New DataTable
        Pi_Mobile_SrNo = Mobile_SrNo

        pi_Obj_MobileModel = New Trade_BL.MobileModel
        Try
            dt_Mdetails = pi_Obj_MobileModel.GetMobileModel(Mobile_SrNo)
            lblDetialModelNo.Text = dt_Mdetails.Rows(0).Item("ManufName") & " - " & dt_Mdetails.Rows(0).Item("ModelNo")
            lblDetialModel.Text = dt_Mdetails.Rows(0).Item("Descriptions")
            lblWeight.Text = "" & dt_Mdetails.Rows(0).Item("Weight")
            lblDimension.Text = "" & dt_Mdetails.Rows(0).Item("Dimension")
            lblPhoneBook.Text = "" & dt_Mdetails.Rows(0).Item("PhoneBook")
            lblCallRecord.Text = "" & dt_Mdetails.Rows(0).Item("CallRecords")
            lblDisplayInfo.Text = "" & dt_Mdetails.Rows(0).Item("DisplayInfo")
            lbldisplaySize.Text = "" & dt_Mdetails.Rows(0).Item("dispSize")
            lblCustomizeTone.Text = IIf(dt_Mdetails.Rows(0).Item("CustomizeTone") = True, "YES", "NO")
            lblVibration.Text = IIf(dt_Mdetails.Rows(0).Item("Vibration") = True, "YES", "NO")
            lblBatteryInfo.Text = "" & dt_Mdetails.Rows(0).Item("BatteryInfo")
            lblOSType.Text = "" & dt_Mdetails.Rows(0).Item("OSType")
            lblGPRS.Text = "" & dt_Mdetails.Rows(0).Item("GPRS")
            lblDataSpeed.Text = "" & dt_Mdetails.Rows(0).Item("DataSpeed")
            lblSMS.Text = IIf(dt_Mdetails.Rows(0).Item("SMS") = True, "YES", "NO")
            lblMMS.Text = IIf(dt_Mdetails.Rows(0).Item("MMS") = True, "YES", "NO")
            lblEmailMsg.Text = IIf(dt_Mdetails.Rows(0).Item("EmailMsg") = True, "YES", "NO")
            lblInstantMsg.Text = IIf(dt_Mdetails.Rows(0).Item("InstantMsg") = True, "YES", "NO")
            lblClock.Text = IIf(dt_Mdetails.Rows(0).Item("Clock") = True, "YES", "NO")
            lblAlarm.Text = IIf(dt_Mdetails.Rows(0).Item("Alarm") = True, "YES", "NO")
            lblInfrared.Text = IIf(dt_Mdetails.Rows(0).Item("Infrared") = True, "YES", "NO")
            lblBlueTooth.Text = IIf(dt_Mdetails.Rows(0).Item("BlueTooth") = True, "YES", "NO")
            lblModel3G.Text = IIf(dt_Mdetails.Rows(0).Item("Model3G") = True, "YES", "NO")
            lblGames.Text = "" & dt_Mdetails.Rows(0).Item("Games")
            lblMobilecolors.Text = "" & dt_Mdetails.Rows(0).Item("Mobilecolor")
            lblCamera.Text = IIf(dt_Mdetails.Rows(0).Item("Camera") = True, "YES", "NO")
            lblCamerainfo.Text = "" & dt_Mdetails.Rows(0).Item("Camerainfo")
            lblFeatures.Text = "" & dt_Mdetails.Rows(0).Item("Features")

            imgMain.ImageUrl = "~/Images/Models/" & dt_Mdetails.Rows(0).Item("ImgFile1")

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Class
