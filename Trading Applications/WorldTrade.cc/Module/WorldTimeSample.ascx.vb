Public Class WorldTimeSample
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblDate As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        'lblDate.Text = DateTime.Today.Now.ToString("dddd, dd MMMM yyyy")

        'lblDubaiTime.Text = DateAndTime.TimeString
        'lblNYTime.Text = DateAndTime.TimeString
        'lblLondonTime.Text = DateAndTime.TimeString
        'lblHongKongtime.Text = DateAndTime.TimeString
    End Sub

End Class