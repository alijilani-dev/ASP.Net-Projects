Imports System.Data
Imports GotDotNet.ApplicationBlocks.Data

Public Class clsCampaign

#Region "Private Variables"

    Private pi_int_campaign_id As Integer
    Private pi_str_campaign_name As String
    Private pi_int_template_id As Integer
    Private pi_str_subject As String
    Private pi_str_date_created As String
    Private pi_int_times_sent As Integer
    Private pi_int_member_id As Integer
    Private pi_str_GUID As String

#End Region

#Region "Database Components"

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"

    Public Property campaign_id() As Integer
        Get
            Return pi_int_campaign_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_campaign_id = Value
        End Set
    End Property
    Public Property campaign_name() As String
        Get
            Return pi_str_campaign_name
        End Get
        Set(ByVal Value As String)
            pi_str_campaign_name = Value
        End Set
    End Property
    Public Property template_id() As Integer
        Get
            Return pi_int_template_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_template_id = Value
        End Set
    End Property
    Public Property subject() As String
        Get
            Return pi_str_subject
        End Get
        Set(ByVal Value As String)
            pi_str_subject = Value
        End Set
    End Property
    Public Property date_created() As String
        Get
            Return pi_str_date_created
        End Get
        Set(ByVal Value As String)
            pi_str_date_created = Value
        End Set
    End Property
    Public Property times_sent() As Integer
        Get
            Return pi_int_times_sent
        End Get
        Set(ByVal Value As Integer)
            pi_int_times_sent = Value
        End Set
    End Property
    Public Property member_id() As Integer
        Get
            Return pi_int_member_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_member_id = Value
        End Set
    End Property
    Public Property GUID() As String
        Get
            Return pi_str_GUID
        End Get
        Set(ByVal Value As String)
            pi_str_GUID = Value
        End Set
    End Property

#End Region

#Region "GET Campaign"

    Public Function GetCampaignInfo(Optional ByVal Campaign_id As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtCampaign As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@campaign_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = Campaign_id
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_CAMPAIGNINFO", idbparameter)
            dtCampaign = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return dtCampaign
    End Function

    Public Function GetCampaign(Optional ByVal Campaign_id As Integer = 0, Optional ByVal Member_id As String = "") As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtCampaign As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If Member_id = "" Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_CAMPAIGN")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = Member_id
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_CAMPAIGN", idbparameter)
            End If
            dtCampaign = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return dtCampaign
    End Function

    Public Function GetCampaignTemplate(Optional ByVal Campaign_id As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtCampaign As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If Campaign_id = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_CAMPAIGNTEMPLATE")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@campaign_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = Campaign_id
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_CAMPAIGNTEMPLATE", idbparameter)
            End If
            dtCampaign = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return dtCampaign
    End Function

    Public Function GetMemberCampaigns(Optional ByVal Member_id As String = "") As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtCampaign As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If Member_id = "" Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_CAMPAIGN")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@member_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = Member_id
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_MEMBER_CAMPAIGNS", idbparameter)
            End If
            dtCampaign = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return dtCampaign
    End Function

    Public Function GetCampaignSchedule(Optional ByVal prmMember_id As Integer = 0, Optional ByVal prmCampaign_id As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtCampaign As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If campaign_id = 0 Then
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@member_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prmMember_id
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_CAMPAIGNSCHEDULE_DISTINCT", idbparameter)
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@member_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prmMember_id

                idbparameter(1) = GlobalData.DataHelper.GetParameter("@campaign_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(1).Value = prmCampaign_id
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_CAMPAIGNSCHEDULE_DISTINCT", idbparameter)
            End If
            dtCampaign = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return dtCampaign
    End Function

    Public Function GetCampaignID(ByVal prm_CampaignGUID As GUID) As Integer
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtCampaign As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@GUID", DbType.Guid, 50, ParameterDirection.Input)
            idbparameter(0).Value = prm_CampaignGUID
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_GET_CAMPAIGN_ID", idbparameter)
            If ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0).Rows(0)(0)
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
            Return 0 '''No campaign id
        End Try
        
    End Function

#End Region

#Region "INSERT Campaign"

    Public Function Insert() As Boolean

        Dim idb_Campaign_parameter(7) As IDataParameter
        Dim dt_row As DataRow

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        idb_Campaign_parameter(0) = GlobalData.DataHelper.GetParameter("@campaign_id", DbType.Int32, 4, ParameterDirection.InputOutput)
        idb_Campaign_parameter(0).Value = Me.campaign_id
        idb_Campaign_parameter(1) = GlobalData.DataHelper.GetParameter("@campaign_name", DbType.String, 100, ParameterDirection.Input)
        idb_Campaign_parameter(1).Value = Me.campaign_name
        idb_Campaign_parameter(2) = GlobalData.DataHelper.GetParameter("@template_id", DbType.Int32, 4, ParameterDirection.Input)
        idb_Campaign_parameter(2).Value = Me.template_id
        idb_Campaign_parameter(3) = GlobalData.DataHelper.GetParameter("@subject", DbType.String, 100, ParameterDirection.Input)
        idb_Campaign_parameter(3).Value = Me.subject
        idb_Campaign_parameter(4) = GlobalData.DataHelper.GetParameter("@date_created", DbType.DateTime, 8, ParameterDirection.Input)
        idb_Campaign_parameter(4).Value = Me.date_created
        idb_Campaign_parameter(5) = GlobalData.DataHelper.GetParameter("@times_sent", DbType.Int32, 4, ParameterDirection.Input)
        idb_Campaign_parameter(5).Value = Me.times_sent
        idb_Campaign_parameter(6) = GlobalData.DataHelper.GetParameter("@member_id", DbType.Int32, 4, ParameterDirection.Input)
        idb_Campaign_parameter(6).Value = Me.member_id

        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_INSERT_CAMPAIGN", idb_Campaign_parameter)
            Me.campaign_id = idb_Campaign_parameter(0).Value

            pi_IDBtra.Commit()

            pi_IDBcon.Close()
            Return True

        Catch ex As Exception
            pi_IDBtra.Rollback()
            pi_IDBcon.Close()
            Throw ex
            ' Return 
            Return False
            Exit Function
        End Try
    End Function

    Public Function Update() As Boolean

        Dim idb_Campaign_parameter(2) As IDataParameter
        Dim dt_row As DataRow

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        idb_Campaign_parameter(0) = GlobalData.DataHelper.GetParameter("@campaign_id", DbType.Int32, 4, ParameterDirection.Input)
        idb_Campaign_parameter(0).Value = Me.campaign_id
        idb_Campaign_parameter(1) = GlobalData.DataHelper.GetParameter("@campaign_name", DbType.String, 100, ParameterDirection.Input)
        idb_Campaign_parameter(1).Value = Me.campaign_name
        idb_Campaign_parameter(2) = GlobalData.DataHelper.GetParameter("@subject", DbType.String, 100, ParameterDirection.Input)
        idb_Campaign_parameter(2).Value = Me.subject

        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_UPDATE_CAMPAIGN", idb_Campaign_parameter)

            pi_IDBtra.Commit()

            pi_IDBcon.Close()
            Return True

        Catch ex As Exception
            pi_IDBtra.Rollback()
            pi_IDBcon.Close()
            Throw ex

            Return False
            Exit Function
        End Try
    End Function

#End Region

#Region "DELETE Campaign"

    Public Function DeleteCampaign(ByVal prm_CampaignID As Integer) As Boolean
        Dim idbparameter(1) As IDataParameter
        Dim strParamID As Integer

        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection

        objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
        objConnection.Open()
        objTransaction = objConnection.BeginTransaction()

        'Added the parameters value into the collection

        idbparameter(0) = GlobalData.DataHelper.GetParameter("@campaign_id", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(0).Value = Me.campaign_id

        Try
            pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_DELETE_CAMPAIGN", idbparameter)

            'Commit and close the transaction
            objTransaction.Commit()
            objConnection.Close()

            Return True

        Catch ex As Exception
            'If any error roll back the transaction
            objTransaction.Rollback()
            objConnection.Close()
            System.Diagnostics.Debug.WriteLine(ex.Message)
            ' Return 
            Return False
            Exit Function
        End Try

    End Function

    Public Function DeleteCampaignParamValues(ByVal prm_CampaignID As Integer, ByVal prm_TemplateID As Integer) As Boolean
        Dim idbparameter(1) As IDataParameter
        Dim strParamID As Integer


        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection

        objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
        objConnection.Open()
        objTransaction = objConnection.BeginTransaction()

        idbparameter(0) = GlobalData.DataHelper.GetParameter("@campaign_id", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(0).Value = prm_CampaignID
        idbparameter(1) = GlobalData.DataHelper.GetParameter("@template_id", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(1).Value = prm_TemplateID

        Try
            pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_DELETE_CAMPAIGN_PARAMS", idbparameter)

            ''Commit and close the transaction
            objTransaction.Commit()
            objConnection.Close()

            Return True

        Catch ex As Exception
            'If any error roll back the transaction
            objTransaction.Rollback()
            objConnection.Close()
            System.Diagnostics.Debug.WriteLine(ex.Message)
            ' Return 
            Return False
            Exit Function
        End Try

    End Function

#End Region

#Region "UPDATE Campaign"

    'Public Function Update() As Boolean


    '    Dim idb_Country_parameter(4) As IDataParameter
    '    Dim dt_row As DataRow

    '    pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
    '    pi_IDBcon.Open()
    '    pi_IDBtra = pi_IDBcon.BeginTransaction()

    '    '@country_id int,
    '    '@country_short_code varchar(2) = NULL,
    '    '@country_name varchar(100) = NULL,
    '    '@country_flag_Img_url varchar(100)=NULL

    '    idb_Country_parameter(0) = GlobalData.DataHelper.GetParameter("@country_id", DbType.Int32, 4, ParameterDirection.Input)
    '    idb_Country_parameter(0).Value = Me.country_id
    '    idb_Country_parameter(1) = GlobalData.DataHelper.GetParameter("@country_short_code", DbType.String, 2, ParameterDirection.Input)
    '    idb_Country_parameter(1).Value = Me.country_short_code
    '    idb_Country_parameter(2) = GlobalData.DataHelper.GetParameter("@country_name", DbType.String, 100, ParameterDirection.Input)
    '    idb_Country_parameter(2).Value = Me.country_name
    '    idb_Country_parameter(3) = GlobalData.DataHelper.GetParameter("@country_flag_Img_url", DbType.String, 100, ParameterDirection.Input)
    '    idb_Country_parameter(3).Value = Me.country_flag_Img_url

    '    Try
    '        pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_UPDATE_Country", idb_Country_parameter)

    '        pi_IDBtra.Commit()

    '        pi_IDBcon.Close()
    '        ' Return 
    '        Return True

    '    Catch ex As Exception
    '        pi_IDBtra.Rollback()
    '        pi_IDBcon.Close()
    '        Throw ex
    '        ' Return 
    '        Return False
    '        Exit Function
    '    End Try
    'End Function

#End Region

    Public Sub New()
        pi_helper = GlobalData.DataHelper
    End Sub

End Class
