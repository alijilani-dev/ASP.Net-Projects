

Public Class CommonFormBL

  '*******************************************************************
  'Class Name			: clsCommonFormBL
  'Programmer			:  Ashish
  'Date			    :  05-03-2005
  'Description		: Retrive Dataset For Perticular Table 
  'Edited On			:   
  'Edited By			:
  'Reason		     	:
  'List Of pending changes :
  '***************************************************************************************
#Region "Private property"
  Private pi_helper As AdoHelper
  Private pi_TableName As String
  Private pi_FormName As String
  Private pi_Dataset As DataSet
  Private pi_ID As Integer
  Private pi_GroupID As Integer
  Private pi_UserID As Integer
  'Transactions
  Private pi_IDBtra As IDbTransaction
  'Connection
  Private pi_IDBcon As IDbConnection

#End Region
#Region "Public Property"
  Public Property Table() As String
    Get
      Return pi_TableName
    End Get
    Set(ByVal Value As String)
      pi_TableName = Value
    End Set
  End Property
  Public Property Form() As String
    Get
      Return pi_FormName
    End Get
    Set(ByVal Value As String)
      pi_FormName = Value
    End Set
  End Property
  Public Property ID() As Int32
    Get
      Return pi_ID
    End Get
    Set(ByVal Value As Int32)
      pi_ID = Value
    End Set
  End Property
  Public Property Group() As Int32
    Get
      Return pi_GroupID
    End Get
    Set(ByVal Value As Int32)
      pi_GroupID = Value
    End Set
  End Property
  Public Property UserID() As Int32
    Get
      Return pi_UserID
    End Get
    Set(ByVal Value As Int32)
      pi_UserID = Value
    End Set
  End Property
#End Region
#Region "Class method"
  Protected Sub Dispose()
    If Not pi_helper Is Nothing Then pi_helper = Nothing
    If Not pi_IDBcon Is Nothing Then pi_IDBcon = Nothing
    If Not pi_IDBtra Is Nothing Then pi_IDBtra = Nothing
  End Sub
#End Region
#Region "Private And Public Method"
  Public Function GetDataset() As DataSet
    Try
      Dim pi_arrIDataParam() As IDataParameter
      pi_helper = GlobalData.DataHelper
      pi_arrIDataParam = pi_helper.GetSpParameterSet(GlobalData.ConnectionString, "USP_Select_Common_" & pi_TableName)

      Dim pi_arrObjValues(0) As Object
      If pi_GroupID = 0 Then
        pi_arrObjValues(0) = DBNull.Value
      Else
        pi_arrObjValues(0) = pi_GroupID
      End If
      pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
      If pi_arrIDataParam.Length = 0 Then
        Return pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_Select_Common_" & pi_TableName)
      Else
        Return pi_helper.ExecuteDataset(GlobalData.ConnectionString, "USP_Select_Common_" & pi_TableName, pi_arrObjValues)
      End If

    Catch ex As DataException
      Throw New ValidationException(ex.Message)
    Finally
      If (pi_IDBcon.State = ConnectionState.Open) Then
        pi_IDBcon.Close()
      End If
    End Try

  End Function
  Public Function Delete() As Int32
    Dim pi_arrobject(1) As Object
    Dim pi_RowsAffected As Int16
    Try
      pi_arrobject(0) = pi_ID
      pi_arrobject(1) = pi_UserID
      pi_helper = GlobalData.DataHelper
      pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
      pi_IDBcon.Open()
      pi_IDBtra = pi_IDBcon.BeginTransaction
      pi_RowsAffected = pi_helper.ExecuteNonQuery(pi_IDBtra, "USP_DELETE_" & pi_TableName, pi_arrobject)
      If (pi_RowsAffected > 0) Then
        pi_IDBtra.Commit()
        Return pi_RowsAffected
      Else
        pi_IDBtra.Rollback()
        Return 0
      End If
    Catch ex As Exception
      If (pi_IDBtra Is Nothing) Then
        pi_IDBtra.Rollback()
      End If
      Throw New ValidationException("Delete Operation is Aborted")
    Finally
      If (pi_IDBcon.State = ConnectionState.Open) Then
        pi_IDBcon.Close()
      End If
    End Try

  End Function


#End Region
End Class
