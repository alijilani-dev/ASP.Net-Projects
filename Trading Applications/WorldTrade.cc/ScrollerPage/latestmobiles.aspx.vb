Public Class Latestmobiles
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
    Public Latest As String = ""

#Region "private variables "
    Private pi_Obj_Review As Trade_BL.Review
#End Region
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''Put user code to initialize the page here
        '''Dim dt_Search_Result As New DataTable
        '''Dim CriteriaSearch As String

        '''pi_obj_TradeFloor = New Trade_BL.TradeFloor
        '''dt_Search_Result = pi_obj_TradeFloor.GetHotOffer()

        '''CriteriaSearch = CriteriaSearch & " ( Trade_Type = 1 Or Trade_Type = 2  ) "
        '''dt_Search_Result.DefaultView.RowFilter = CriteriaSearch
        ''''''Coded created on 25th Jan to have image slide show effect
        '''Dim dataRow As DataRow
        '''Dim i As Integer = 0
        '''Dim clr As String
        '''For Each dataRow In dt_Search_Result.Rows
        '''    If dataRow("MobileSrNo") & "" <> "0" Then
        '''        strPhotos = strPhotos & "arr_Models[" & i & "]={BGclr:'" & clr & "',manuf:'" & Replace(dataRow("Brand"), vbCrLf, "") & _
        '''            "', model:'" & dataRow("ModelNo") & "', gif:'" & dataRow("ImgFile2") & _
        '''            "', links:'" & dataRow("MobileSrNo") & "'};" & vbCrLf
        '''        If i Mod 2 = 0 Then clr = "#D7E6FF" Else clr = "white"
        '''        i = i + 1
        '''    End If
        '''Next
        Dim dt_Search_Result As New DataTable
        Dim dataRow As DataRow
        Dim i As Integer = 0
        Dim clr As String

        If Not Page.IsPostBack Then
            pi_Obj_Review = New Trade_BL.Review
            dt_Search_Result = pi_Obj_Review.GetLatestMobiles
            clr = "white"
            For Each dataRow In dt_Search_Result.Rows
                Latest = Latest & "arr_Models_new[" & i & "]={BGclr:'" & clr & "',manuf:'" & Replace(dataRow("ManufName"), vbCrLf, "") & _
                    "', model:'" & dataRow("ModelNo") & "', gif:'" & dataRow("ImgFile2") & _
                    "', code:'" & dataRow("ManufCode") & _
                    "', links:'" & dataRow("SrNo") & "'};" & vbCrLf
                If i Mod 2 = 0 Then clr = "#D7E6FF" Else clr = "white"
                i = i + 1
            Next
        End If
    End Sub
    '   /%arr_Models_new[0] = {BGclr:"white", manuf:"Sony Ericsson", model:"W900", gif:"Thumb/m_w900-70.jpg", links:"223"};
    'arr_Models_new[1] = {BGclr:"#D7E6FF", manuf:"NOKIA", model:"6230i", gif:"Thumb/m_nokia-6230i-70.jpg", links:"153"};
    'arr_Models_new[2] = {BGclr:"white", manuf:"NOKIA", model:"9300i", gif:"Thumb/m_9300i-70.jpg", links:"308"};
    'arr_Models_new[3] = {BGclr:"#D7E6FF", manuf:"SAMSUNG", model:"Z107", gif:"Thumb/m_z107-70.jpg", links:"304"};
    'arr_Models_new[4] = {BGclr:"white", manuf:"NOKIA", model:"7380", gif:"Thumb/m_7380-70.jpg", links:"222"};
    'arr_Models_new[5] = {BGclr:"#D7E6FF", manuf:"Sony Ericsson", model:"D750i", gif:"Thumb/m_D750i-70.jpg", links:"311"};
    'arr_Models_new[6] = {BGclr:"white", manuf:"NOKIA", model:"7370", gif:"Thumb/m_7370-70.jpg", links:"221"};
    'arr_Models_new[7] = {BGclr:"#D7E6FF", manuf:"NOKIA", model:"7360", gif:"Thumb/m_7360-70.jpg", links:"236"};
    ''%/
End Class
