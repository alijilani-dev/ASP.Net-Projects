Imports System.Text
Imports System.Configuration
Imports GotDotNet.ApplicationBlocks.Data
Imports SmartPhi_BL

Public Class TemplateEditControl
    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents spnTemplate As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents spnContent As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents Span1 As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents btnFinish As System.Web.UI.WebControls.Button
    Protected WithEvents btnPreview As System.Web.UI.WebControls.Button
    Protected WithEvents txthCampaignID As System.Web.UI.HtmlControls.HtmlInputHidden
    Protected WithEvents txthTemplateID As System.Web.UI.HtmlControls.HtmlInputHidden
    Protected WithEvents btnBack As System.Web.UI.WebControls.Button

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

        If (CInt(Session(Session_str_MemberID)) = 0 Or Session(Session_str_MemberID) Is Nothing) Then
            Response.Redirect("..\Login.aspx")
        End If

        Dim nCampaignId As Integer
        Dim nTemplateId As Integer = CInt(Session(Session_str_TemplateID))
        nCampaignId = CInt(Session(Session_str_CampaginID))
        If (Request.Form("txthTemplateID") <> Nothing) Or (Request("Mode") = "Preview") Then
            GetTemplate(nCampaignId, True)
            Exit Sub
        End If
        If CInt(nCampaignId) > 0 Then
            GetTemplate(nCampaignId, False)
            Exit Sub
        End If

        btnBack.Attributes.Add("onclick", "javascript:history.navigate(-1);")
        btnPreview.Attributes.Add("onclick", "javascript:ShowPreview();return false;")

    End Sub

    Private Sub GetTemplate(ByVal prmCampaignId As Integer, Optional ByVal prmPreview As Boolean = False)

        Dim objTemplate As New clsTemplate
        Dim dt As DataTable
        Dim strTemplatePath As String
        Dim nTemplateId As Integer
        dt = objTemplate.GetTemplateInfo(prmCampaignId)
        If dt.Rows.Count > 0 Then
            strTemplatePath = dt.Rows(0)("TemplatePath") & ""
            nTemplateId = dt.Rows(0)("TemplateID")
            If (prmPreview) Then
                ShowPreview(strTemplatePath, nTemplateId)
                btnBack.Visible = True
                btnPreview.Visible = False
                Exit Sub
            End If
            EditTemplate(strTemplatePath, nTemplateId)
            btnBack.Visible = False
            btnPreview.Visible = True
        End If

    End Sub

    Private Sub EditTemplate(Optional ByVal prmTemplatePath As String = "", Optional ByVal prmTemplateId As Integer = 0)

        Dim strTemplate As StringBuilder = New StringBuilder
        Dim strPath As String = Server.MapPath("~")
        Dim file As New System.IO.StreamReader(strPath & "\Templates\" & prmTemplatePath)
        Dim words As String = file.ReadToEnd()
        file.Close()

        Dim dt, dtValues As DataTable
        Dim dr As DataRow
        Dim i, j As Integer
        Dim strMode As String
        Dim nCampaignId As Integer = CInt(Session(Session_str_CampaginID))

        Try
            dt = pi_obj_Parameter.GetCampaignParamValues(nCampaignId, prmTemplateId) 'Get the param for the template id passed
            strMode = Request("Mode").ToString()
        Catch ex As Exception
            strMode = String.Empty
        End Try

        If (dt.Rows.Count > 0) Then

            Dim StrBasePath As String = ConfigurationSettings.AppSettings("BasePath").ToString()

            For i = 0 To dt.Rows.Count - 1
                dr = dt.Rows(i)
                If (dr("ParamValue").ToString() <> "") Then
                    ' CASE For each ParamTypeId
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
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", String.Format(str_ImagePath_Format, strID, strImgPath)) 'dr("ParamValue").ToString().Trim().Replace("{*0*}", Session(Session_str_CampaginGUID).ToString()))
                        Case 4 ' ImagePath
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", HttpUtility.HtmlDecode(dr("ParamValue").ToString().Trim().Replace("{*0*}", Session(Session_str_CampaginGUID).ToString())))
                        Case Else ' Content
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", dr("ParamValue").ToString().Trim().Replace("{*0*}", Session(Session_str_CampaginGUID).ToString()))
                    End Select
                Else
                    words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", dr("ParamDefaultValue").ToString().Trim().Replace("{*0*}", Session(Session_str_CampaginGUID).ToString()))
                End If
                words = words.Replace("<*$" & dr("ParamName").ToString().Trim() & "/$*>", dr("EditText").ToString().Trim().Replace("{*0*}", Session(Session_str_CampaginGUID).ToString()))
            Next
            ' Params Without values
            Try
                dt = pi_obj_Parameter.GetParameterValues(prmTemplateId) '/*HARDCODED*/
            Catch ex As Exception
                strMode = String.Empty
            End Try
            If (dt.Rows.Count > 0) Then

                For i = 0 To dt.Rows.Count - 1
                    dr = dt.Rows(i)
                    words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", dr("ParamDefaultValue").ToString().Trim().Replace("{*0*}", Session(Session_str_CampaginGUID).ToString()))
                    words = words.Replace("<*$" & dr("ParamName").ToString().Trim() & "/$*>", dr("EditText").ToString().Trim().Replace("{*0*}", Session(Session_str_CampaginGUID).ToString()))
                Next

            End If
            ' Params Without values
        Else
            ' New Campaign (Having no params values.)
            Try
                dt = pi_obj_Parameter.GetParameterValues(prmTemplateId) '/*HARDCODED*/
            Catch ex As Exception
                strMode = String.Empty
            End Try
            If (dt.Rows.Count > 0) Then

                For i = 0 To dt.Rows.Count - 1
                    dr = dt.Rows(i)
                    words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", dr("ParamDefaultValue").ToString().Trim().Replace("{*0*}", Session(Session_str_CampaginGUID).ToString())) 'Session(Session_str_CampaginID).ToString()))
                    words = words.Replace("<*$" & dr("ParamName").ToString().Trim() & "/$*>", dr("EditText").ToString().Trim().Replace("{*0*}", Session(Session_str_CampaginGUID).ToString())) 'Session(Session_str_CampaginID).ToString()))
                Next

            End If

        End If

        spnContent.InnerHtml = words.ToString()

    End Sub

    Private Sub ShowPreview(Optional ByVal prmTemplatePath As String = "", Optional ByVal prmTemplateId As Integer = 0)

        Dim strTemplate As StringBuilder = New StringBuilder
        Dim strPath As String = Server.MapPath("~")
        Dim file As New System.IO.StreamReader(strPath & "\Templates\" & prmTemplatePath)
        Dim words As String = file.ReadToEnd()
        file.Close()

        Dim dt, dtValues As DataTable
        Dim dr As DataRow
        Dim i, j As Integer
        Dim strMode As String
        Dim nCampaignId As Integer = CInt(Session(Session_str_CampaginID))

        Try
            dt = pi_obj_Parameter.GetCampaignParamValues(nCampaignId, prmTemplateId) 'Get the param for the template id passed
            strMode = Request("Mode").ToString()
        Catch ex As Exception
            strMode = String.Empty
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
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", String.Format(str_ImagePath_Format, strID, strImgPath)) 'dr("ParamValue").ToString().Trim().Replace("{*0*}", Session(Session_str_CampaginGUID).ToString()))
                        Case 4 ' ImagePath
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", HttpUtility.HtmlDecode(dr("ParamValue").ToString().Trim().Replace("{*0*}", Session(Session_str_CampaginGUID).ToString())))
                        Case Else ' Content
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", dr("ParamValue").ToString().Trim().Replace("{*0*}", Session(Session_str_CampaginGUID).ToString()))
                    End Select
                    '-------------
                    'words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", dr("ParamValue").ToString().Trim().Replace("{*0*}", Session(Session_str_CampaginGUID).ToString()))
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
                strMode = String.Empty
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
                strMode = String.Empty
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

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim nCampaignId As Integer

        nCampaignId = CInt(Session(Session_str_CampaginID))
        If CInt(nCampaignId) > 0 Then
            GetTemplate(nCampaignId, True)
            Exit Sub
        End If

    End Sub

    Private Sub btnFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinish.Click
        Response.Redirect("Finish.aspx")
    End Sub

End Class