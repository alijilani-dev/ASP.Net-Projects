Imports System.Data
Imports GotDotNet.ApplicationBlocks.Data

Public Class TradePortelInfo

#Region "strored procedure names "
    Private Shared Pi_STR_GetCountries As String = "GetCountries"
    Private Shared Pi_STR_GetTradingCategories As String = "GetTradingCategories"

#End Region

    Private Shared pi_objHelper As AdoHelper = Trade_BL.GlobalData.DataHelper
    Public Shared ConnectionString As String

    Public Sub New()

    End Sub

    Public Shared Function getTradingCategories() As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            ds = pi_objHelper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, Pi_STR_GetTradingCategories)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

    Public Shared Function getCountries() As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            ds = pi_objHelper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, Pi_STR_GetCountries)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
End Class

