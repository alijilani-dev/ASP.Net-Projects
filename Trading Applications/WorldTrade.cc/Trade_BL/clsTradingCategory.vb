Imports System.Data
Imports GotDotNet.ApplicationBlocks.Data

Public Class TradingCategory

#Region "Private Variables"

    Private pi_int_trading_cat_id As Integer
    Private pi_int_portal_id As Integer
    Private pi_str_trading_cat_desc As String


    Private pi_intUserID As Integer

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"


    Public Property trading_cat_id() As Integer
        Get
            Return pi_int_trading_cat_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_trading_cat_id = Value
        End Set
    End Property

    Public Property portal_id() As Integer
        Get
            Return pi_int_portal_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_portal_id = Value
        End Set
    End Property

    Public Property trading_cat_desc() As String
        Get
            Return pi_str_trading_cat_desc
        End Get
        Set(ByVal Value As String)
            pi_str_trading_cat_desc = Value
        End Set
    End Property




#End Region

#Region "get Select ALL / SINGLE trading Category"
    Public Function GetTradingCategories(Optional ByVal prm_Trading_Cat_ID As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prm_Trading_Cat_ID = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_TRADING_CATEGORY")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@trading_cat_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_Trading_Cat_ID
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_TRADING_CATEGORY", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
#End Region

#Region "INSERT Trading Category"

#End Region

#Region "DELETE Trading Category"

#End Region

#Region "UPDATE Trading Category"

#End Region


End Class

