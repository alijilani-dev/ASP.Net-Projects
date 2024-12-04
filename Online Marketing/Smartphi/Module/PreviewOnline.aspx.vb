Imports System.Text
Imports System.Configuration
Imports GotDotNet.ApplicationBlocks.Data
Imports SmartPhi_BL

Public Class PreviewOnline
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents spnTemplate As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents spnContent As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents Span1 As System.Web.UI.HtmlControls.HtmlGenericControl

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private pi_obj_Parameter As New clsParameter

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim strCampaignGUID As String
        strCampaignGUID = Request.QueryString("camid").ToString
        If strCampaignGUID.Length > 0 Then          
            GetTemplate(strCampaignGUID)
        End If
    End Sub

    Private Sub GetTemplate(ByVal prmCampaignGUID As String)

        Dim objTemplate As New clsTemplate
        Dim objCampaign As New clsCampaign
        Dim dt As DataTable
        Dim strTemplatePath As String
        Dim nCampaignId As Integer
        Dim nTemplateId As Integer
        Dim prmGUID As New Guid(prmCampaignGUID)

        nCampaignId = objCampaign.GetCampaignID(prmGUID)

        dt = objTemplate.GetTemplateInfo(nCampaignId)
        If dt.Rows.Count > 0 Then
            strTemplatePath = dt.Rows(0)("TemplatePath") & ""
            nTemplateId = dt.Rows(0)("TemplateID")
            ShowPreview(prmCampaignGUID, nCampaignId, nTemplateId, strTemplatePath)
        End If

    End Sub

    Private Sub ShowPreview(ByVal prmCampaignGUID As String, ByVal prmCampaignId As Integer, ByVal prmTemplateId As Integer, ByVal prmTemplatePath As String)

        Dim strTemplate As StringBuilder = New StringBuilder
        Dim strPath As String = Server.MapPath("~")
        Dim file As New System.IO.StreamReader(strPath & "\Templates\" & prmTemplatePath)
        Dim words As String = file.ReadToEnd()
        file.Close()

        Dim dt, dtValues As DataTable
        Dim dr As DataRow
        Dim i, j As Integer

        Try
            dt = pi_obj_Parameter.GetCampaignParamValues(prmCampaignId, prmTemplateId) 'Get the param for the template id passed
        Catch ex As Exception

        End Try

        Dim StrBasePath As String = ConfigurationSettings.AppSettings("BasePath").ToString()

        If (dt.Rows.Count > 0) Then
            For i = 0 To dt.Rows.Count - 1
                dr = dt.Rows(i)
                If (dr("ParamValue").ToString() <> "") Then
                    ' CASE For each ParamTypeId
                    '--------------
                    Select Case CType(dr("ParamTypeID").ToString(), Integer)
                        'Case 1 ' Text
                        'Case 2 ' Link
                    Case 3 ' ImagePath
                            Dim strID, strImgPath As String
                            Dim chrComma As Char = Chr(44)
                            Dim nCommaIndex As Integer = dr("ParamValue").ToString().IndexOf(chrComma)
                            strID = dr("ParamValue").ToString().Substring(0, nCommaIndex)
                            strImgPath = dr("ParamValue").ToString().Substring(nCommaIndex + 1, dr("ParamValue").ToString().Length - nCommaIndex - 1)
                            strImgPath = StrBasePath + strImgPath.TrimStart(Chr(46))
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", String.Format(str_ImagePath_Format, strID, strImgPath)) 'dr("ParamValue").ToString().Trim().Replace("{*0*}", prmCampaignGUID))
                        Case 4 ' ImagePath
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", HttpUtility.HtmlDecode(dr("ParamValue").ToString().Trim().Replace("{*0*}", prmCampaignGUID)))
                        Case Else ' Content
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", dr("ParamValue").ToString().Trim().Replace("{*0*}", prmCampaignGUID))
                    End Select
                    '-------------
                    'words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", dr("ParamValue").ToString().Trim().Replace("{*0*}", prmCampaignGUID))
                    words = words.Replace("<*$" & dr("ParamName").ToString().Trim() & "/$*>", "")
                Else
                    words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", "")
                    words = words.Replace("<*$" & dr("ParamName").ToString().Trim() & "/$*>", "")
                End If
            Next

            ' Params Without values
            Try
                dt = pi_obj_Parameter.GetParameterValues(prmTemplateId) '/*HARDCODED*/
            Catch ex As Exception

            End Try
            If (dt.Rows.Count > 0) Then

                For j = 0 To dt.Rows.Count - 1
                    dr = dt.Rows(j)
                    words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", "")     ' Insert No Value
                    words = words.Replace("<*$" & dr("ParamName").ToString().Trim() & "/$*>", "")   ' Insert No Value
                Next

            End If
            ' Prams Without values
        Else
            ' New Campaign (Having no params values.)
            Try
                dt = pi_obj_Parameter.GetParameterValues(prmTemplateId) '/*HARDCODED*/
            Catch ex As Exception

            End Try
            If (dt.Rows.Count > 0) Then

                For i = 0 To dt.Rows.Count - 1
                    dr = dt.Rows(i)
                    words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", "")     ' Insert No Value
                    words = words.Replace("<*$" & dr("ParamName").ToString().Trim() & "/$*>", "")   ' Insert No Value
                Next

            End If

        End If

        spnContent.InnerHtml = words.ToString()

    End Sub

End Class
