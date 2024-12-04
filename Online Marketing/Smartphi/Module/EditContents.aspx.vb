Imports SmartPhi_BL
Imports System.IO
Imports System.Security
Imports System.Security.Permissions

Public Class EditContents
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents txtEditor As FredCK.FCKeditorV2.FCKeditor
    Protected WithEvents btnCancelContent As System.Web.UI.WebControls.Button
    Protected WithEvents tdEditor As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents tblEditor As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tblContent As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tblImagePath As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tblLinks As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tblText As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents txtTextValue As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnSubmitText As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancelText As System.Web.UI.WebControls.Button
    Protected WithEvents btnSubmitLink As System.Web.UI.WebControls.Button
    Protected WithEvents btnSubmitContent As System.Web.UI.WebControls.Button
    Protected WithEvents btnSubmitImagePath As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancelLink As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancelImagePath As System.Web.UI.WebControls.Button
    Protected WithEvents txtLinkURL As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtLinkText As System.Web.UI.WebControls.TextBox
    Protected WithEvents uplImagePath As System.Web.UI.HtmlControls.HtmlInputFile
    Protected WithEvents lblMsg As System.Web.UI.WebControls.Label
    Protected WithEvents Middle As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents btnUpdateText As System.Web.UI.WebControls.Button
    Protected WithEvents btnUpdateContent As System.Web.UI.WebControls.Button
    Protected WithEvents btnUpdateLink As System.Web.UI.WebControls.Button
    Protected WithEvents btnUpdateImage As System.Web.UI.WebControls.Button
    Protected WithEvents chkRemoveImage As System.Web.UI.WebControls.CheckBox

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
    Private nCampaignId, nParamTypeId, nParamId, nTemplateId As New Integer
    Private strCampaignguid As String
    Private lEditMode As Boolean
    Private lUpdated As Boolean

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (CInt(Session(Session_str_MemberID)) = 0 Or Session(Session_str_MemberID) Is Nothing) Then
            Response.Redirect("..\Login.aspx")
        End If

        If (Page.IsPostBack) Then
            Dim scriptString As String = "<script language=JavaScript>window.opener = self;window.opener.close();window.close();</script>"
            RegisterStartupScript("startup", scriptString)
        End If

        Dim dt As DataTable
        Try
            nParamTypeId = Request.QueryString("typeid").ToString.Trim()
            nParamId = Request.QueryString("paramid").ToString.Trim()
            nTemplateId = CInt(Session(Session_str_TemplateID))
            nCampaignId = Session(Session_str_CampaginID).ToString().Trim()
            strCampaignguid = Request.QueryString("campid").ToString.Trim()
            dt = pi_obj_Parameter.GetExistingValue(strCampaignguid, nParamId)
            If (dt.Rows.Count > 0) Then
                lEditMode = True
            Else
                lEditMode = False
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try

        RenderForm(nParamTypeId, "")
        If (lEditMode) And (Not Page.IsPostBack) Then
            GetParamValue(nParamTypeId)
        End If
        btnCancelText.Attributes.Add("onclick", "javascript:window.close();return false;")
        btnCancelLink.Attributes.Add("onclick", "javascript:window.close();return false;")
        btnCancelImagePath.Attributes.Add("onclick", "javascript:window.close();return false;")
        btnCancelContent.Attributes.Add("onclick", "javascript:window.close();return false;")
        chkRemoveImage.Attributes.Add("onclick", "javascript:enableupload();return true;")

    End Sub

    Private Sub RenderForm(ByVal nParamTypeId As Integer, ByVal strParamValue As String)

        Select Case nParamTypeId
            Case 1 ' Text
                tblText.Visible = True
                tblLinks.Visible = False
                tblImagePath.Visible = False
                tblContent.Visible = False
                If (lEditMode) Then
                    btnUpdateText.Visible = True
                    btnSubmitText.Visible = False
                Else
                    btnUpdateText.Visible = False
                    btnSubmitText.Visible = True
                End If
            Case 2 ' Link
                tblText.Visible = False
                tblLinks.Visible = True
                tblImagePath.Visible = False
                tblContent.Visible = False
                If (lEditMode) Then
                    btnUpdateLink.Visible = True
                    btnSubmitLink.Visible = False
                Else
                    btnUpdateLink.Visible = False
                    btnSubmitLink.Visible = True
                End If
            Case 3 ' ImagePath
                tblText.Visible = False
                tblLinks.Visible = False
                tblImagePath.Visible = True
                tblContent.Visible = False
                If (lEditMode) Then
                    btnUpdateImage.Visible = True
                    btnSubmitImagePath.Visible = False
                Else
                    btnUpdateImage.Visible = False
                    btnSubmitImagePath.Visible = True
                End If
            Case 4 ' Content
                tblText.Visible = False
                tblLinks.Visible = False
                tblImagePath.Visible = False
                tblContent.Visible = True
                If (lEditMode) Then
                    btnUpdateContent.Visible = True
                    btnSubmitContent.Visible = False
                Else
                    btnUpdateContent.Visible = False
                    btnSubmitContent.Visible = True
                End If
        End Select

    End Sub

    Private Function GetParamValue(ByVal nParamTypeId As Integer) As String

        Dim strParamValue As String
        If Not (lEditMode) Then

            Select Case nParamTypeId
                Case 1 ' Text
                    strParamValue = txtTextValue.Text
                Case 2 ' Link
                    strParamValue = String.Format("<a href='http://{0}'>{1}</a>", txtLinkURL.Text, txtLinkText.Text)
                Case 3 ' ImagePath
                    Dim strFileName As String = Strings.Right(uplImagePath.Value, uplImagePath.Value.Length - Strings.InStrRev(uplImagePath.Value, "\"))
                    Dim strFolderPath As String = Server.MapPath("~") & "\Templates\" & nCampaignId.ToString()
                    Dim strAbsolFolderPath As String = "../Templates/" & nCampaignId.ToString() + "/images/"
                    Dim strServerPath As String = strFolderPath + "\images\" + strFileName
                    Dim strRemotePath As String = strAbsolFolderPath + strFileName
                    '*********** 
                    Try
                        Dim lCampaginPath, lImagePath As Boolean
                        GetDirectoryPermissions(strFolderPath, strFileName)
                        lCampaginPath = CreateDirectory(strFolderPath)
                        GetDirectoryPermissions(strFolderPath + "\images\", strFileName)
                        lImagePath = CreateDirectory(strFolderPath + "\images")
                        If (lCampaginPath And lImagePath) Then
                            uplImagePath.PostedFile.SaveAs(strServerPath)
                        End If
                    Catch ex As Exception
                        System.Diagnostics.Debug.WriteLine(ex.Message)
                    End Try
                    '***********
                    'strParamValue = String.Format("<img id='{0}' src='{1}'>", nParamId.ToString(), strFileName)
                    strParamValue = String.Format("{0},{1}", nParamId.ToString(), strRemotePath)
                    ''strParamValue = String.Format("<img id='{0}' src='{1}'>", nParamId.ToString(), strRemotePath)
                Case 4 ' Content
                    strParamValue = Server.HtmlEncode(txtEditor.Value)
            End Select

        Else

            Dim dt As DataTable
            strCampaignguid = Request.QueryString("campid").ToString.Trim()
            dt = pi_obj_Parameter.GetExistingValue(strCampaignguid, nParamId)
            Dim strCurrentValue = dt.Rows(0)("ParamValue").ToString()

            Select Case nParamTypeId

                Case 1 ' Text
                    txtTextValue.Text = strCurrentValue
                    lUpdated = True
                Case 2 ' Link
                    '"<a href='{0}'>{1}</a>"
                    '   href='Url'
                    Dim strLinkUrl, strLinkText As String
                    Dim chrColon, chrLessthan, chrGreaterthan
                    chrColon = Chr(39)
                    chrLessthan = Chr(60)
                    chrGreaterthan = Chr(62)
                    Dim nlinkStart, nTextStart, nlinkEnd, nTextEnd As Integer
                    nlinkStart = CType(strCurrentValue.IndexOf(chrColon), Integer)
                    nlinkEnd = CType(strCurrentValue.LastIndexOf(chrColon), Integer)
                    txtLinkURL.Text = strCurrentValue.Substring(nlinkStart + 1, (nlinkEnd - nlinkStart) - 1)
                    ' >Text</a>
                    nTextStart = CType(strCurrentValue.IndexOf(chrGreaterthan), Integer)
                    nTextEnd = CType(strCurrentValue.LastIndexOf(chrLessthan), Integer)
                    txtLinkText.Text = strCurrentValue.SubString(nTextStart + 1, (nTextEnd - nTextStart) - 1)
                    lUpdated = True
                Case 3 ' ImagePath
                    strParamValue = ""
                    lUpdated = True
                Case 4 ' Content
                    'txtEditor.Value = HttpUtility.HtmlEncode(strCurrentValue)
                    txtEditor.Value = HttpUtility.HtmlDecode(strCurrentValue)
                    lUpdated = True

            End Select

        End If

        Return strParamValue

    End Function

    Private Function GetUpdateValue(ByVal nParamTypeId As Integer) As String

        Dim strParamValue As String

        Select Case nParamTypeId
            Case 1 ' Text
                strParamValue = txtTextValue.Text
            Case 2 ' Link
                strParamValue = String.Format("<a href='{0}'>{1}</a>", txtLinkURL.Text, txtLinkText.Text)
            Case 3 ' ImagePath
                Dim strFileName As String = Strings.Right(uplImagePath.Value, uplImagePath.Value.Length - Strings.InStrRev(uplImagePath.Value, "\"))
                Dim strFolderPath As String = Server.MapPath("~") & "\Templates\" & nCampaignId.ToString()
                Dim strAbsolFolderPath As String = "../Templates/" + nCampaignId.ToString() + "/images/"
                Dim strServerPath As String = strFolderPath + "\images\" + strFileName
                Dim strRemotePath As String = strAbsolFolderPath + strFileName
                '*********** 
                Try
                    Dim lCampaginPath, lImagePath As Boolean
                    GetDirectoryPermissions(strFolderPath, strFileName)
                    lCampaginPath = CreateDirectory(strFolderPath)
                    GetDirectoryPermissions(strFolderPath + "\images\", strFileName)
                    lImagePath = CreateDirectory(strFolderPath + "\images")
                    If (lCampaginPath And lImagePath) Then
                        uplImagePath.PostedFile.SaveAs(strServerPath)
                    End If
                Catch ex As Exception
                    System.Diagnostics.Debug.WriteLine(ex.Message)
                End Try
                '***********
                'strParamValue = String.Format("<img id='{0}' src='{1}'>", nParamId.ToString(), strRemotePath.ToString())
                strParamValue = String.Format("{0},{1}", nParamId.ToString(), strRemotePath)
                ''strParamValue = String.Format("<img id='{0}' src='{1}'>", nParamId.ToString(), strRemotePath)
            Case 4 ' Content
                strParamValue = HttpUtility.HtmlEncode(txtEditor.Value)
        End Select

        Return strParamValue

    End Function

    Private Function CreateDirectory(ByVal strImagePath As String) As Boolean

        Try
            ' Determine whether the directory exists.
            If Directory.Exists(strImagePath) Then
                System.Diagnostics.Debug.WriteLine("That path exists already.")
                Return True
            End If

            ' Try to create the directory.
            Dim di As DirectoryInfo = Directory.CreateDirectory(strImagePath)
            System.Diagnostics.Debug.WriteLine("The directory was created successfully at " & Directory.GetCreationTime(strImagePath))
            Return True

        Catch e As Exception
            System.Diagnostics.Debug.WriteLine("The process failed: " & e.Message.ToString())
            Return False
        End Try

    End Function

    Private Function GetDirectoryPermissions(ByVal strDirPath As String, ByVal strFileName As String) As Boolean

        Try
            Dim ObjPermission As New FileIOPermission(FileIOPermissionAccess.Write, strDirPath)
            ObjPermission.AddPathList(FileIOPermissionAccess.Write, strDirPath)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try

    End Function

#Region " Text Param "

    Private Sub btnSubmitText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitText.Click

        pi_obj_Parameter.CampaignID = nCampaignId
        pi_obj_Parameter.TemplateID = CInt(Request("tempid").ToString())
        pi_obj_Parameter.ParameterID = nParamId
        pi_obj_Parameter.ParameterValue = GetParamValue(nParamTypeId)
        Try
            pi_obj_Parameter.Insert(nParamId, GetParamValue(nParamTypeId))
        Catch ex As Exception
            Page.RegisterClientScriptBlock("CloseWindow", "<Script>alert('A problem occurred while adding parameter value.');window.close();</script>")
            System.Diagnostics.Debug.WriteLine(ex.Message)
            Exit Sub
        End Try
        Page.RegisterClientScriptBlock("CloseWindow", "<Script>alert('The parameter value has been added successfully.');window.close();</script>")

    End Sub
    Private Sub btnUpdateText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateText.Click

        pi_obj_Parameter.CampaignID = nCampaignId
        pi_obj_Parameter.TemplateID = CInt(Request("tempid").ToString()) 'nTemplateId
        pi_obj_Parameter.ParameterID = nParamId
        pi_obj_Parameter.ParameterValue = GetUpdateValue(nParamTypeId)
        Try
            pi_obj_Parameter.Update(lEditMode)
        Catch ex As Exception
            lblMsg.Text = "A problem occurred while updating parameter value."
            Page.RegisterClientScriptBlock("CloseWindow", "<Script>alert('A problem occurred while updating parameter value.');window.close();</script>")

            System.Diagnostics.Debug.WriteLine(ex.Message)
            Exit Sub
        End Try
        Page.RegisterClientScriptBlock("CloseWindow", "<Script>alert('The parameter value has been Updated successfully.');window.close();</script>")

    End Sub

#End Region

#Region " Link Param "

    Private Sub btnSubmitLink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitLink.Click

        pi_obj_Parameter.CampaignID = nCampaignId
        pi_obj_Parameter.TemplateID = CInt(Request("tempid").ToString()) 'nTemplateId
        pi_obj_Parameter.ParameterID = nParamId
        pi_obj_Parameter.ParameterValue = GetParamValue(nParamTypeId)
        Try
            pi_obj_Parameter.Insert(nParamId, GetParamValue(nParamTypeId))
        Catch ex As Exception
            Page.RegisterClientScriptBlock("CloseWindow", "<Script>alert('A problem occurred while adding parameter value.');window.close();</script>")
            System.Diagnostics.Debug.WriteLine(ex.Message)
            Exit Sub
        End Try
        Page.RegisterClientScriptBlock("CloseWindow", "<Script>alert('The parameter value has been added successfully.');window.close();</script>")

    End Sub
    Private Sub btnUpdateLink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateLink.Click
        pi_obj_Parameter.CampaignID = nCampaignId
        pi_obj_Parameter.TemplateID = CInt(Request("tempid").ToString()) 'nTemplateId
        pi_obj_Parameter.ParameterID = nParamId
        pi_obj_Parameter.ParameterValue = GetUpdateValue(nParamTypeId)
        Try
            pi_obj_Parameter.Update(lEditMode)
        Catch ex As Exception
            Page.RegisterClientScriptBlock("CloseWindow", "<Script>alert('A problem occurred while updating parameter value.');window.close();</script>")
            System.Diagnostics.Debug.WriteLine(ex.Message)
            Exit Sub
        End Try
        Page.RegisterClientScriptBlock("CloseWindow", "<Script>alert('The parameter value has been Updated successfully.');window.close();</script>")

    End Sub

#End Region

#Region " Image Path Param "

    Private Sub btnSubmitImagePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitImagePath.Click

        pi_obj_Parameter.CampaignID = nCampaignId
        pi_obj_Parameter.TemplateID = CInt(Request("tempid").ToString()) 'nTemplateId
        pi_obj_Parameter.ParameterID = nParamId
        pi_obj_Parameter.ParameterValue = GetParamValue(nParamTypeId)
        Try
            If (chkRemoveImage.Checked) Then ' BlankImage
                pi_obj_Parameter.Insert(nParamId, "")
            Else
                pi_obj_Parameter.Insert(nParamId, pi_obj_Parameter.ParameterValue)
            End If
        Catch ex As Exception
            Page.RegisterClientScriptBlock("CloseWindow", "<Script>alert('A problem occurred while adding parameter value.');window.close();</script>")
            System.Diagnostics.Debug.WriteLine(ex.Message)
            Exit Sub
        End Try
        Page.RegisterClientScriptBlock("CloseWindow", "<Script>alert('The parameter value has been added successfully.');window.close();</script>")

    End Sub
    Private Sub btnUpdateImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateImage.Click

        pi_obj_Parameter.CampaignID = nCampaignId
        pi_obj_Parameter.TemplateID = CInt(Request("tempid").ToString()) 'nTemplateId
        pi_obj_Parameter.ParameterID = nParamId
        pi_obj_Parameter.ParameterValue = GetUpdateValue(nParamTypeId)
        Try
            pi_obj_Parameter.Update(chkRemoveImage.Checked)
        Catch ex As Exception
            Page.RegisterClientScriptBlock("CloseWindow", "<Script>alert('A problem occurred while updating parameter value.');window.close();</script>")
            System.Diagnostics.Debug.WriteLine(ex.Message)
            Exit Sub
        End Try
        Page.RegisterClientScriptBlock("CloseWindow", "<Script>alert('The parameter value has been Updated successfully.');window.close();</script>")

    End Sub

#End Region

#Region " Content Param "

    Private Sub btnSubmitContent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitContent.Click

        pi_obj_Parameter.CampaignID = nCampaignId
        pi_obj_Parameter.TemplateID = CInt(Request("tempid").ToString()) 'nTemplateId
        pi_obj_Parameter.ParameterID = nParamId
        pi_obj_Parameter.ParameterValue = GetParamValue(nParamTypeId)
        Try
            pi_obj_Parameter.Insert(nParamId, GetParamValue(nParamTypeId))
        Catch ex As Exception
            Page.RegisterClientScriptBlock("CloseWindow", "<Script>alert('A problem occurred while adding parameter value.');window.close();</script>")
            System.Diagnostics.Debug.WriteLine(ex.Message)
            Exit Sub
        End Try
        Page.RegisterClientScriptBlock("CloseWindow", "<Script>alert('The parameter value has been added successfully.');window.close();</script>")

    End Sub

    Private Sub btnUpdateContent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateContent.Click

        pi_obj_Parameter.CampaignID = nCampaignId
        pi_obj_Parameter.TemplateID = CInt(Request("tempid").ToString()) 'nTemplateId
        pi_obj_Parameter.ParameterID = nParamId
        pi_obj_Parameter.ParameterValue = GetUpdateValue(nParamTypeId)
        Try
            pi_obj_Parameter.Update(lEditMode)
        Catch ex As Exception
            Page.RegisterClientScriptBlock("CloseWindow", "<Script>alert('A problem occurred while updating parameter value.');window.close();</script>")
            System.Diagnostics.Debug.WriteLine(ex.Message)
            Exit Sub
        End Try
        Page.RegisterClientScriptBlock("CloseWindow", "<Script>alert('The parameter value has been Updated successfully.');window.close();</script>")

    End Sub

#End Region

    Private Sub chkRemoveImage_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkRemoveImage.CheckedChanged
        uplImagePath.Disabled = chkRemoveImage.Checked
    End Sub

End Class
