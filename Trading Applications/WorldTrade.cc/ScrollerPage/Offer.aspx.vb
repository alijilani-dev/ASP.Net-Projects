Public Class Offer
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents ROffers As System.Web.UI.WebControls.Repeater
    Protected WithEvents ImageButton1 As System.Web.UI.WebControls.ImageButton

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region
    Public strPhotos As String = ""
    Public strPhotosLink As String = ""

#Region "private variables "
    Private pi_obj_TradeFloor As Trade_BL.TradeFloor
#End Region
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        Dim dt_Search_Result As New DataTable
        Dim CriteriaSearch As String

        pi_obj_TradeFloor = New Trade_BL.TradeFloor
        dt_Search_Result = pi_obj_TradeFloor.GetHotOffer()

        '''Coded created on 12th Mar to have image slide show effect
        Dim dataRow As DataRow
        Dim i As Integer = 0
        Dim clr As String
        For Each dataRow In dt_Search_Result.Rows
            strPhotos = strPhotos & "arr_Models[" & i & "]={BGclr:'" & clr & "',manuf:'" & Replace(dataRow("Brand"), vbCrLf, "") & _
                "', model:'" & dataRow("ModelNo") & "', gif:'" & dataRow("Trade_Type") & _
                ".gif', code:'" & dataRow("ManufCode") & _
                "', Qty:'" & dataRow("Quantity") & _
                "', links:'" & dataRow("Trading_ID") & "'};" & vbCrLf
            If i Mod 2 = 0 Then clr = "#ffe2b4" Else clr = "white"
            i = i + 1
        Next

    End Sub
    
End Class
