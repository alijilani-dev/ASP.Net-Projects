
Public Class Advertisement
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents AdImgRotator As System.Web.UI.WebControls.AdRotator
    Protected WithEvents DLAdvertisement As System.Web.UI.WebControls.DataList
    Protected WithEvents imgAdvTop As System.Web.UI.WebControls.Image
    Protected WithEvents imgAdvBottom As System.Web.UI.WebControls.Image

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
    'Private pi_Module_ID As Integer
    Private pi_obj_Advertisement As New Trade_BL.Advertisement
#End Region

#Region "Public Properties"

#End Region
    '''Private Sub WriteXmlToFile(ByVal thisDataSet As DataSet)
    '''    If thisDataSet Is Nothing Then
    '''        Return
    '''    End If
    '''    ' Create a file name to write to.
    '''    Dim filename As String = "c:\AdXML.XML"
    '''    ' Create the FileStream to write with.
    '''    Dim myFileStream As New System.IO.FileStream _
    '''       (filename, System.IO.FileMode.Create)
    '''    ' Create an XmlTextWriter with the fileStream.
    '''    Dim myXmlWriter As New System.Xml.XmlTextWriter _
    '''       (myFileStream, System.Text.Encoding.Unicode)
    '''    ' Write to the file with the WriteXml method.
    '''    thisDataSet.WriteXml(myXmlWriter)
    '''    myXmlWriter.Close()
    '''End Sub
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        Dim ds_Ads_Single As New DataSet
        Dim dt_Ads_Single As New DataTable
        Dim dt_Ads_All As New DataTable
        'Dim s As New AdRotator
        's.AdvertisementFile = "a.xml"
        dt_Ads_Single = pi_obj_Advertisement.GetModuleAdvertisement(MyBase.Module_ID, MyBase.Placeholder, "Single").Copy

        If dt_Ads_Single.Rows.Count > 0 Then
            AdImgRotator.Visible = True
            'get the data
            dt_Ads_Single.TableName = "AD"
            ds_Ads_Single.DataSetName = "Advertisements"
            'copying the data into the new datatable
            ds_Ads_Single.Tables.Add(dt_Ads_Single)
            'ds_Ads_Single.WriteXml(Server.MapPath("AdXML.XML"))
            '''WriteXmlToFile(ds_Ads_Single)
            AdImgRotator.AdvertisementFile = "AdXML.XML" 'Server.MapPath("AdXML.XML")   ' "p.xml" 'ds_Ads_Single.GetXml()
        Else
            AdImgRotator.Visible = False
        End If

        dt_Ads_All = pi_obj_Advertisement.GetModuleAdvertisement(MyBase.Module_ID, MyBase.Placeholder, "General")

        If dt_Ads_All.Rows.Count > 0 Then
            If dt_Ads_All.Rows(0)("ad_position").ToString = "LEVEL3" Then
                imgAdvBottom.Visible = False
                imgAdvTop.Visible = False
            End If
            DLAdvertisement.Visible = True
            DLAdvertisement.DataSource = dt_Ads_All 'pi_obj_Advertisement.GetModuleAdvertisement(MyBase.Module_ID, MyBase.Placeholder, "General")
            DLAdvertisement.DataBind()
        Else
            DLAdvertisement.Visible = False
        End If

        If AdImgRotator.Visible = False And DLAdvertisement.Visible = False Then
            Me.Visible = False
        End If

    End Sub


#Region "Public Methods"
    Public Function getAdXML(ByRef dt As DataTable) As DataSet
        Dim ds_Ads_Single_New As New DataSet
        Dim dt_Ads_Single_New As New DataTable
        Dim dt_Ads_Single_Column_New As New DataColumn

        '<ImageUrl>...</ImageUrl>
        '<NavigateUrl>...</NavigateUrl>
        '<AlternateText>...</AlternateText>
        '<Keyword>...</Keyword>
        '<Impressions>...</Impressions>
        Try
            dt_Ads_Single_Column_New = New DataColumn
            dt_Ads_Single_Column_New.ColumnName = "ImageUrl"
            dt_Ads_Single_Column_New.DataType = GetType(String)
            dt_Ads_Single_New.Columns.Add(dt_Ads_Single_Column_New)

            dt_Ads_Single_Column_New = New DataColumn
            dt_Ads_Single_Column_New.ColumnName = "NavigateUrl"
            dt_Ads_Single_Column_New.DataType = GetType(String)
            dt_Ads_Single_New.Columns.Add(dt_Ads_Single_Column_New)

            dt_Ads_Single_Column_New = New DataColumn
            dt_Ads_Single_Column_New.ColumnName = "AlternateText"
            dt_Ads_Single_Column_New.DataType = GetType(String)
            dt_Ads_Single_New.Columns.Add(dt_Ads_Single_Column_New)

            dt_Ads_Single_Column_New = New DataColumn
            dt_Ads_Single_Column_New.ColumnName = "Keyword"
            dt_Ads_Single_Column_New.DataType = GetType(String)
            dt_Ads_Single_New.Columns.Add(dt_Ads_Single_Column_New)

            dt_Ads_Single_Column_New = New DataColumn
            dt_Ads_Single_Column_New.ColumnName = "Impressions"
            dt_Ads_Single_Column_New.DataType = GetType(String)
            dt_Ads_Single_New.Columns.Add(dt_Ads_Single_Column_New)

            dt_Ads_Single_New.TableName = "AD"

            ds_Ads_Single_New.DataSetName = "Advertisement"

            'copying the data into the new datatable

            ds_Ads_Single_New.Tables.Add(dt_Ads_Single_New)

            Return ds_Ads_Single_New

        Catch ex As Exception

        End Try

    End Function
#End Region

    'Private Sub AdImgRotator_AdCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.AdCreatedEventArgs) Handles AdImgRotator.AdCreated
    '    Dim ai As AcmeAdServer.AdInfo
    '    Dim ws As New AcmeAdServer.AdService
    '    Dim keyword As String

    '    keyword = CType(sender, AdRotator).KeywordFilter
    '    ai = ws.GetNextAd(keyword)

    '    e.ImageUrl = ai.ImageUrl
    '    e.NavigateUrl = ai.NavigateUrl
    '    e.AlternateText = ai.AltText
    'End Sub
End Class
