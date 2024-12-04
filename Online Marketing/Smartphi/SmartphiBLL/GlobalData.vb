Imports GotDotNet.ApplicationBlocks.Data

Public Module GlobalData
    ' Constants
    Friend Const gs_ProviderAssembly As String = "GotDotNet.ApplicationBlocks.Data"

    ' Variables
    Private ms_ConnString As String
    Private ms_ProviderClass As String
    Private mo_DataHelper As AdoHelper

    ' Property which returns the connection string set by the Application.
    Friend ReadOnly Property ConnectionString() As String
        Get
            Return ms_ConnString
        End Get
    End Property

    ' Property which return the Provider Class used by the ADOHelper.
    Friend ReadOnly Property ProviderClass() As String
        Get
            Return ms_ProviderClass
        End Get
    End Property

    ' Property which returns instance of ADOHelper.
    Friend ReadOnly Property DataHelper() As AdoHelper
        Get
            Return mo_DataHelper
        End Get
    End Property

    Public Sub pg_SetConnectionString(ByVal vs_ConnString As String)
        ms_ConnString = vs_ConnString
    End Sub

    Public Sub pg_SetProviderClass(ByVal vs_ProviderClass As String)
        ms_ProviderClass = gs_ProviderAssembly & "." & vs_ProviderClass
        mo_DataHelper = AdoHelper.CreateHelper(gs_ProviderAssembly, ms_ProviderClass)
    End Sub

    'Public Function GetParameterValues(Optional ByVal prm_Pram_ID As Integer = 0) As DataTable
    '    Dim idbparameter(1) As IDataParameter
    '    Dim ds As New DataSet
    '    'ADO Helper
    '    Dim pi_helper As AdoHelper
    '    ' Create and Fill the DataSet
    '    Dim myDatatable As New DataTable
    '    Try
    '        pi_helper = DataHelper
    '        If prm_Template_ID = 0 Then
    '            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_PARAMETER")
    '        Else
    '            idbparameter(0) = GlobalData.DataHelper.GetParameter("@param_id", DbType.Int32, 4, ParameterDirection.Input)
    '            idbparameter(0).Value = prm_Pram_ID
    '            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_PARAMETER_VALUES", idbparameter)
    '        End If
    '        myDatatable = ds.Tables(0)
    '    Catch ex As Exception
    '        System.Diagnostics.Debug.WriteLine(ex.Message)

    '    End Try
    '    ' Return the table
    '    Return myDatatable
    'End Function

#Region "Public constant for the Session Names"
    Public Const Session_str_Admin As String = "Admin"
    Public Const Session_str_UserName As String = "UserName"
    Public Const Session_str_MembName As String = "MemberName"
    Public Session_str_MemberID As String = "MemberID"
    Public Session_str_CampaginID As String = "CampaginID"
    Public Session_str_CampaginGUID As String = "CampaginGUID"
    Public Session_str_TemplateID As String = "TemplateID"
    Public str_ImagePath_Format As String = "<img id='{0}' src='{1}'>"
#End Region

End Module