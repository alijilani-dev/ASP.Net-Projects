Imports System.Data
Imports GotDotNet.ApplicationBlocks.Data

Public Class Country

#Region "Private Variables"

    Private pi_int_country_id As Integer
    Private pi_str_country_short_code As String
    Private pi_str_country_name As String
    Private pi_str_country_flag_Img_url As String
    Private pi_intUserID As Integer

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"

    Public Property country_id() As Integer
        Get
            Return pi_int_country_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_country_id = Value
        End Set
    End Property

    Public Property country_short_code() As String
        Get
            Return pi_str_country_short_code
        End Get
        Set(ByVal Value As String)
            pi_str_country_short_code = Value
        End Set
    End Property

    Public Property country_name() As String
        Get
            Return pi_str_country_name
        End Get
        Set(ByVal Value As String)
            pi_str_country_name = Value
        End Set
    End Property

    Public Property country_flag_Img_url() As String
        Get
            Return pi_str_country_flag_Img_url
        End Get
        Set(ByVal Value As String)
            pi_str_country_flag_Img_url = Value
        End Set
    End Property
#End Region

#Region "get Select ALL / SINGLE Country"
    Public Function GetCountries(Optional ByVal vid As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If vid = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_COUNTRY")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@Country_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = vid
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_COUNTRY", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
    Public Function GetAllCountries(Optional ByVal vid As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If vid = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_COUNTRY_ALL")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@Country_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = vid
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_COUNTRY_ALL", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

#End Region

#Region "INSERT Country"
    Public Function Insert() As Boolean

        Dim idb_Country_parameter(4) As IDataParameter
        Dim dt_row As DataRow

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '@country_id int,
        '@country_short_code varchar(2) = NULL,
        '@country_name varchar(100) = NULL,
        '@country_flag_Img_url varchar(100)=NULL

        idb_Country_parameter(0) = GlobalData.DataHelper.GetParameter("@country_id", DbType.Int32, 4, ParameterDirection.InputOutput)
        idb_Country_parameter(0).Value = Me.country_id
        idb_Country_parameter(1) = GlobalData.DataHelper.GetParameter("@country_short_code", DbType.String, 2, ParameterDirection.Input)
        idb_Country_parameter(1).Value = Me.country_short_code
        idb_Country_parameter(2) = GlobalData.DataHelper.GetParameter("@country_name", DbType.String, 100, ParameterDirection.Input)
        idb_Country_parameter(2).Value = Me.country_name
        idb_Country_parameter(3) = GlobalData.DataHelper.GetParameter("@country_flag_Img_url", DbType.String, 100, ParameterDirection.Input)
        idb_Country_parameter(3).Value = Me.country_flag_Img_url

        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_INSERT_Country", idb_Country_parameter)
            Me.country_id = idb_Country_parameter(0).Value

            pi_IDBtra.Commit()

            pi_IDBcon.Close()
            ' Return 
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

#End Region

#Region "DELETE Country"
    Public Function Delete(Optional ByVal prm_Country_id As Integer = 0) As Boolean

        Dim idb_Country_parameter(1) As IDataParameter

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '@ann_id int = NULL

        If prm_Country_id = 0 Then
            idb_Country_parameter(0) = GlobalData.DataHelper.GetParameter("@country_id", DbType.Int32, 4, ParameterDirection.Input)
            idb_Country_parameter(0).Value = Me.country_id
        Else
            idb_Country_parameter(0) = GlobalData.DataHelper.GetParameter("@country_id", DbType.Int32, 4, ParameterDirection.Input)
            idb_Country_parameter(0).Value = prm_Country_id
        End If

        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_DELETE_Country", idb_Country_parameter)

            pi_IDBtra.Commit()

            pi_IDBcon.Close()
            ' Return 
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

#End Region

#Region "UPDATE Country"
    Public Function Update() As Boolean


        Dim idb_Country_parameter(4) As IDataParameter
        Dim dt_row As DataRow

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '@country_id int,
        '@country_short_code varchar(2) = NULL,
        '@country_name varchar(100) = NULL,
        '@country_flag_Img_url varchar(100)=NULL

        idb_Country_parameter(0) = GlobalData.DataHelper.GetParameter("@country_id", DbType.Int32, 4, ParameterDirection.Input)
        idb_Country_parameter(0).Value = Me.country_id
        idb_Country_parameter(1) = GlobalData.DataHelper.GetParameter("@country_short_code", DbType.String, 2, ParameterDirection.Input)
        idb_Country_parameter(1).Value = Me.country_short_code
        idb_Country_parameter(2) = GlobalData.DataHelper.GetParameter("@country_name", DbType.String, 100, ParameterDirection.Input)
        idb_Country_parameter(2).Value = Me.country_name
        idb_Country_parameter(3) = GlobalData.DataHelper.GetParameter("@country_flag_Img_url", DbType.String, 100, ParameterDirection.Input)
        idb_Country_parameter(3).Value = Me.country_flag_Img_url

        Try
            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_UPDATE_Country", idb_Country_parameter)

            pi_IDBtra.Commit()

            pi_IDBcon.Close()
            ' Return 
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

#End Region

    Public Sub New()
        pi_helper = GlobalData.DataHelper
    End Sub
End Class