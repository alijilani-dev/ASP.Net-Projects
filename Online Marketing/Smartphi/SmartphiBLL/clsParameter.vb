Imports GotDotNet.ApplicationBlocks.Data

Public Class clsParameter

#Region "Private Variables"
    Private pi_int_Template_id As Integer
    Private pi_int_Campaign_id As Integer
    Private pi_int_Parameter_Id As Integer
    Private pi_str_ParameterName As String
    Private pi_int_ParameterTypeID As Integer
    Private pi_str_ParameterValue As String
    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"
    Public Property CampaignID() As Integer
        Get
            Return pi_int_Campaign_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_Campaign_id = Value
        End Set
    End Property
    Public Property TemplateID() As Integer
        Get
            Return pi_int_Template_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_Template_id = Value
        End Set
    End Property
    Public Property ParameterID() As Integer
        Get
            Return pi_int_Parameter_Id
        End Get
        Set(ByVal Value As Integer)
            pi_int_Parameter_Id = Value
        End Set
    End Property
    Public Property ParameterName() As String
        Get
            Return pi_str_ParameterName
        End Get
        Set(ByVal Value As String)
            pi_str_ParameterName = Value
        End Set
    End Property
    Public Property ParameterTypeID() As Integer
        Get
            Return pi_int_ParameterTypeID
        End Get
        Set(ByVal Value As Integer)
            pi_int_ParameterTypeID = Value
        End Set
    End Property
    Public Property ParameterValue() As String
        Get
            Return pi_str_ParameterValue
        End Get
        Set(ByVal Value As String)
            pi_str_ParameterValue = Value
        End Set
    End Property
#End Region

#Region "Insert & Delete"

    Public Function Update(ByVal prm_NoImage As Boolean) As Boolean
        Dim idbparameter(5) As IDataParameter
        Dim idbparameter_value(3) As IDataParameter
        Dim strParamID As Integer

        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection

        objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
        objConnection.Open()
        objTransaction = objConnection.BeginTransaction()

        'Added the parameters value into the collection
        idbparameter(0) = GlobalData.DataHelper.GetParameter("@campaign_id", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(0).Value = Me.CampaignID
        idbparameter(1) = GlobalData.DataHelper.GetParameter("@template_id", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(1).Value = Me.TemplateID
        idbparameter(2) = GlobalData.DataHelper.GetParameter("@param_id", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(2).Value = Me.ParameterID
        idbparameter(3) = GlobalData.DataHelper.GetParameter("@param_value", SqlDbType.NText) ', ParameterDirection.Input)
        'idbparameter(3) = GlobalData.DataHelper.GetParameter("@param_value", Me.ParameterValue)

        If prm_NoImage Then ' Remove Current Value.
            idbparameter(3).Value = ""
        Else ' Update new Value
            idbparameter(3).Value = Me.ParameterValue
        End If

        Try
            pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_UPDATE_PARAMETER", idbparameter)

            ''Commit and close the transaction
            objTransaction.Commit()
            objConnection.Close()
            Return True

        Catch ex As Exception
            ' If any error roll back the transaction
            objTransaction.Rollback()
            objConnection.Close()
            System.Diagnostics.Debug.WriteLine(ex.Message)
            ' Return 
            Return False
            Exit Function
        End Try

    End Function
    'Public Function Update(ByVal prm_EditMode As Boolean) As Boolean
    '    Dim idbparameter(5) As IDataParameter
    '    Dim idbparameter_value(3) As IDataParameter
    '    Dim strParamID As Integer

    '    Dim objTransaction As IDbTransaction
    '    Dim objConnection As IDbConnection

    '    objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
    '    objConnection.Open()
    '    objTransaction = objConnection.BeginTransaction()

    '    'Added the parameters value into the collection
    '    If prm_EditMode Then ' Update
    '        idbparameter(0) = GlobalData.DataHelper.GetParameter("@campaign_id", DbType.Int32, 20, ParameterDirection.Input)
    '        idbparameter(0).Value = Me.CampaignID
    '        idbparameter(1) = GlobalData.DataHelper.GetParameter("@template_id", DbType.Int32, 20, ParameterDirection.Input)
    '        idbparameter(1).Value = Me.TemplateID
    '        idbparameter(2) = GlobalData.DataHelper.GetParameter("@param_id", DbType.Int32, 20, ParameterDirection.Input)
    '        idbparameter(2).Value = Me.ParameterID
    '        idbparameter(3) = GlobalData.DataHelper.GetParameter("@param_value", SqlDbType.NText) ', ParameterDirection.Input)
    '        idbparameter(3).Value = Me.ParameterValue
    '        'idbparameter(3) = GlobalData.DataHelper.GetParameter("@param_value", Me.ParameterValue)
    '    Else ' Insert
    '        idbparameter(0) = GlobalData.DataHelper.GetParameter("@param_id", DbType.Int32, 20, ParameterDirection.Output)
    '        idbparameter(0).Value = Me.ParameterID
    '        idbparameter(1) = GlobalData.DataHelper.GetParameter("@template_id", DbType.Int32, 20, ParameterDirection.Input)
    '        idbparameter(1).Value = Me.TemplateID
    '        idbparameter(2) = GlobalData.DataHelper.GetParameter("@param_name", DbType.String, 100, ParameterDirection.Input)
    '        idbparameter(2).Value = Me.ParameterName
    '        idbparameter(3) = GlobalData.DataHelper.GetParameter("@param_type_id", DbType.String, 100, ParameterDirection.Input)
    '        idbparameter(3).Value = Me.ParameterTypeID
    '    End If

    '    Try
    '        If prm_EditMode Then 'update
    '            pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_UPDATE_PARAMETER", idbparameter)
    '        Else 'insert
    '            pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_INSERT_PARAMETER", idbparameter)
    '        End If

    '        ''Commit and close the transaction
    '        objTransaction.Commit()
    '        objConnection.Close()
    '        Return True

    '    Catch ex As Exception
    '        ' If any error roll back the transaction
    '        objTransaction.Rollback()
    '        objConnection.Close()
    '        System.Diagnostics.Debug.WriteLine(ex.Message)
    '        ' Return 
    '        Return False
    '        Exit Function
    '    End Try

    'End Function
    Public Function Insert(ByVal prm_ParamID As Integer, ByVal prm_Value As String) As Boolean
        Dim idbparameter(5) As IDataParameter
        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection

        objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
        objConnection.Open()
        objTransaction = objConnection.BeginTransaction()

        'Added the parameters value into the collection
        If prm_ParamID <> Nothing Then ' Insert
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@campaign_id", DbType.Int32, 20, ParameterDirection.Input)
            idbparameter(0).Value = Me.CampaignID
            idbparameter(1) = GlobalData.DataHelper.GetParameter("@template_id", DbType.Int32, 20, ParameterDirection.Input)
            idbparameter(1).Value = Me.TemplateID
            idbparameter(2) = GlobalData.DataHelper.GetParameter("@param_id", DbType.Int32, 20, ParameterDirection.Input)
            idbparameter(2).Value = Me.ParameterID
            idbparameter(3) = GlobalData.DataHelper.GetParameter("@param_value", SqlDbType.NText) ', ParameterDirection.Input)
            idbparameter(3).Value = Me.ParameterValue
            'idbparameter(3) = GlobalData.DataHelper.GetParameter("@param_value", Me.ParameterValue)

            Try
                pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_INSERT_PARAMETER_VALUE", idbparameter)

                ''Commit and close the transaction
                objTransaction.Commit()
                objConnection.Close()

                Return True

            Catch ex As Exception
                ' If any error roll back the transaction
                objTransaction.Rollback()
                objConnection.Close()
                System.Diagnostics.Debug.WriteLine(ex.Message)
                ' Return 
                Return False
                Exit Function
            End Try
        Else ' Failure
            Return False
        End If

    End Function
    Public Function DeleteParameter(ByVal prm_ParamID As Integer) As Boolean
        Dim idbparameter(5) As IDataParameter
        Dim idbparameter_value(3) As IDataParameter
        Dim strParamID As Integer


        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection

        objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
        objConnection.Open()
        objTransaction = objConnection.BeginTransaction()

        'Added the parameters value into the collection

        idbparameter(0) = GlobalData.DataHelper.GetParameter("@param_id", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(0).Value = Me.ParameterID

        Try
            pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_DELETE_PARAMETER", idbparameter)

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

#Region " Get Functions "

    Public Function GetParamTypes() As DataTable
        'Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtParameters As New DataTable
        Try
            pi_helper = GlobalData.DataHelper

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_PARAMTYPES")
            dtParameters = ds.Tables(0)

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return dtParameters
    End Function
    Public Function GetParameterValue(Optional ByVal Param_ID As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtParameters As New DataTable
        Try
            pi_helper = GlobalData.DataHelper

            idbparameter(0) = GlobalData.DataHelper.GetParameter("@param_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = Param_ID
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_PARAMETER_VALUE", idbparameter)
            dtParameters = ds.Tables(0)

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return dtParameters
    End Function
    Public Function GetParameterValues(Optional ByVal prm_Template_ID As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet
        'ADO Helper
        Dim pi_helper As AdoHelper
        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = DataHelper
            If prm_Template_ID = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_PARAMETER")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@template_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_Template_ID
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_PARAMETER", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
    Public Function GetCampaignParamValues(Optional ByVal prm_Campaign_ID As Integer = 0, Optional ByVal prm_Template_ID As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet
        'ADO Helper
        Dim pi_helper As AdoHelper
        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Campaign_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prm_Campaign_ID
            idbparameter(1) = GlobalData.DataHelper.GetParameter("@Template_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(1).Value = prm_Template_ID
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_PARAMETER_VALUES", idbparameter)

            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
    Public Function GetParameters(Optional ByVal Member_ID As Integer = 0, Optional ByVal Template_ID As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtParameters As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            'idbparameter(0) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 4, ParameterDirection.Input)
            'idbparameter(0).Value = Member_ID

            idbparameter(0) = GlobalData.DataHelper.GetParameter("@template_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = Template_ID
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_PARAMETER", idbparameter)
            dtParameters = ds.Tables(0)

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return dtParameters
    End Function
    Public Function GetParameterDetails(ByVal Param_ID As Integer, Optional ByVal Template_ID As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtParameters As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@param_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = Param_ID

            'idbparameter(0) = GlobalData.DataHelper.GetParameter("@template_id", DbType.Int32, 4, ParameterDirection.Input)
            'idbparameter(0).Value = Template_ID
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_PARAMDETAILS", idbparameter)
            dtParameters = ds.Tables(0)

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return dtParameters
    End Function
    'Public Function GetExistingValue(ByVal prm_Campaign_ID As Integer, ByVal prm_Param_ID As Integer)
    Public Function GetExistingValue(ByVal prm_Campaign_GUID As String, ByVal prm_Param_ID As Integer)
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet
        'ADO Helper
        Dim pi_helper As AdoHelper
        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@campaign_guid", DbType.String, 36, ParameterDirection.Input)
            idbparameter(0).Value = prm_Campaign_GUID
            idbparameter(1) = GlobalData.DataHelper.GetParameter("@param_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(1).Value = prm_Param_ID
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_EXISTING_VALUES", idbparameter)

            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable

    End Function
    Public Function GetTemplates(Optional ByVal Template_ID As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtParameters As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = Template_ID

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_TEMPLATES", idbparameter)
            dtParameters = ds.Tables(0)

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return dtParameters
    End Function

#End Region

    Public Sub New()
        pi_helper = GlobalData.DataHelper
    End Sub

End Class
