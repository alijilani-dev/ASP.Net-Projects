
Namespace ListManagement
  Public Class ListGroupMaster

    '****************************************
    'ClassName			        :   ListGroupMaster
    'Programmer			        :   Frank
    'Date				        :   09-03-2005
    'Description		        :   Common List Group BL
    '   
    'Edited On			        :
    'Edited By			        :
    'Reason			            :
    'List Of pending changes    :
    '****************************************

#Region "Form Level Variables"
    Private pi_intID As Integer
    Private pi_intLGV_ID As Integer
    Private pi_strName As String
    Private pi_strDescription As String
    Private pi_intLast_Modified_By_sys As Integer
    'ADO Helper
    Private pi_helper As AdoHelper
    'Conn Str
    Private pi_strConn As String
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection
#End Region

#Region "Class Methods"
    Public Sub New()
      pi_helper = GlobalData.DataHelper
      pi_strConn = GlobalData.ConnectionString
    End Sub

    Protected Sub Dispose()
      If Not pi_helper Is Nothing Then pi_helper = Nothing
      If Not pi_IDBcon Is Nothing Then pi_IDBcon = Nothing
      If Not pi_IDBtra Is Nothing Then pi_IDBtra = Nothing
    End Sub
#End Region

#Region "Properties"
    Public Property ID() As Integer
      Get
        Return pi_intID
      End Get
      Set(ByVal value As Integer)
        pi_intID = value
      End Set
    End Property

    Public Property LGV_ID() As Integer
      Get
        Return pi_intLGV_ID
      End Get
      Set(ByVal value As Integer)
        pi_intLGV_ID = value
      End Set
    End Property

    Public Property Name() As String
      Get
        Return pi_strName
      End Get
      Set(ByVal value As String)
        pi_strName = value
      End Set
    End Property

    Public Property Description() As String
      Get
        Return pi_strDescription
      End Get
      Set(ByVal value As String)
        pi_strDescription = value
      End Set
    End Property

    Public Property Last_Modified_By_sys() As Integer
      Get
        Return pi_intLast_Modified_By_sys
      End Get
      Set(ByVal value As Integer)
        pi_intLast_Modified_By_sys = value
      End Set
    End Property

#End Region

#Region "Procedures"
    '****************************************
    'Programmer				    :   Frank
    'Date Of Creation			:   09-03-2005
    'Description				:   Gets Family Name
    '			
    'Accepted Parameters		:   --
    'Return Values			    :   
    'Global Variables Accessed	:   
    'Global Variables Modified	:
    '
    'Called by				    :
    'Called					    :
    '
    'Tables/Fields Accessed		:
    '
    'Last Edited By			    :
    'Last Edited On			    :
    'Reason				        :
    '
    '****************************************
    Public Function getFamily(ByVal strValue As String)
      Dim msql As String
      msql = "Select LGV_Name from List_Group_Value " & _
             " where LGV_ID = " & strValue

      Try
        Return pi_helper.ExecuteDataset(pi_strConn, CommandType.Text, msql)

      Catch ex As Exception
        Throw ex
      End Try

    End Function
    '****************************************
    'Programmer				    :   Frank
    'Date Of Creation			:   09-03-2005
    'Description				:   Gets all rows of one group
    '			
    'Accepted Parameters		:   --
    'Return Values			    :   
    'Global Variables Accessed	:   
    'Global Variables Modified	:
    '
    'Called by				    :
    'Called					    :
    '
    'Tables/Fields Accessed		:
    '
    'Last Edited By			    :
    'Last Edited On			    :
    'Reason				        :
    '
    '****************************************
        Public Function getGroup() As DataSet
            Dim arr_parIDBValues(0) As IDbDataParameter

            arr_parIDBValues(0) = pi_helper.GetParameter("@LGM_LGV_ID", DbType.Int32, 4, 1)
            arr_parIDBValues(0).Value = pi_intLGV_ID

            Try
        Return pi_helper.ExecuteDataset(pi_strConn, "USP_Select_List_Group_Master", arr_parIDBValues)

            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '****************************************
        'Programmer				    :   Naitik
        'Date Of Creation			:   17-03-2005
        'Description				:   Gets rows of Particular group
        '			
        'Accepted Parameters		:   --
        'Return Values			    :   
        'Global Variables Accessed	:   
        'Global Variables Modified	:
        '
        'Called by				    :
        'Called					    :
        '
        'Tables/Fields Accessed		:
        '
        'Last Edited By			    :
        'Last Edited On			    :
        'Reason				        :
        '
        '****************************************
        Public Function getGroupVal() As DataSet
            Dim arr_parIDBValues(0) As IDbDataParameter

            arr_parIDBValues(0) = pi_helper.GetParameter("@LGM_LGV_ID", DbType.Int32, 4, 1)
            arr_parIDBValues(0).Value = pi_intLGV_ID

            Try
                Return pi_helper.ExecuteDataset(pi_strConn, "USP_Select_List_Group_Master", arr_parIDBValues)

            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '****************************************
        'Programmer				    :   Frank
        'Date Of Creation			:   09-03-2005
        'Description				:   'Started Prcodedure for Select
        '			
        'Accepted Parameters		:   --
        'Return Values			    :   
        'Global Variables Accessed	:   
        'Global Variables Modified	:
        '
        'Called by				    :
        'Called					    :
        '
        'Tables/Fields Accessed		:
        '
        'Last Edited By			    :
        'Last Edited On			    :
        'Reason				        :
        '
        '****************************************
        Public Function getData()
            Dim arr_parIDBValues(0) As IDbDataParameter

            arr_parIDBValues(0) = pi_helper.GetParameter("@LGM_ID", DbType.Int32, 4, 1)
            arr_parIDBValues(0).Value = pi_intID

            Try
                Return pi_helper.ExecuteDataset(pi_strConn, "USP_Select_List_Group_Master_Single", arr_parIDBValues)

            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '****************************************
        'Programmer				    :   Frank
        'Date Of Creation			:   09-03-2005
        'Description				:   'Started Prcodedure for Insert
        '			
        'Accepted Parameters		:   --
        'Return Values			    :   
        'Global Variables Accessed	:   
        'Global Variables Modified	:
        '
        'Called by				    :
        'Called					    :
        '
        'Tables/Fields Accessed		:
        '
        'Last Edited By			    :
        'Last Edited On			    :
        'Reason				        :
        '
        '****************************************
        Public Function Insert()
            Dim arr_parIDBValues(4) As IDbDataParameter

            arr_parIDBValues(0) = pi_helper.GetParameter("@LGM_LGV_ID", DbType.Int32, 4, 1)
            arr_parIDBValues(0).Value = pi_intLGV_ID

            arr_parIDBValues(1) = pi_helper.GetParameter("@LGM_Name", DbType.String, 64, 1)
            arr_parIDBValues(1).Value = pi_strName

            arr_parIDBValues(2) = pi_helper.GetParameter("@LGM_Description", DbType.String, 256, 1)
            arr_parIDBValues(2).Value = pi_strDescription

            arr_parIDBValues(3) = pi_helper.GetParameter("@LGM_Entered_By_sys", DbType.Int32, 4, 1)
            arr_parIDBValues(3).Value = pi_intLast_Modified_By_sys

            arr_parIDBValues(4) = pi_helper.GetParameter("@LGM_Last_Modified_By_sys", DbType.Int32, 4, 1)
            arr_parIDBValues(4).Value = pi_intLast_Modified_By_sys

            Try
                pi_IDBcon = pi_helper.GetConnection(pi_strConn)
                pi_IDBcon.Open()
                pi_IDBtra = pi_IDBcon.BeginTransaction(IsolationLevel.Serializable)

                pi_intID = pi_helper.ExecuteScalar(pi_IDBtra, "USP_Insert_List_Group_Master", arr_parIDBValues)

                pi_IDBtra.Commit()
                Return pi_intID
            Catch ex As Exception
                If Not (pi_IDBtra Is Nothing) Then
                    pi_IDBtra.Rollback()
                End If
                Throw ex
            Finally
                If (pi_IDBcon.State = ConnectionState.Open) Then
                    pi_IDBcon.Close()
                End If
            End Try
        End Function
        '****************************************
        'Programmer				    :   Frank
        'Date Of Creation			:   09-03-2005
        'Description				:   'Started Prcodedure for Update
        '			
        'Accepted Parameters		:   --
        'Return Values			    :   
        'Global Variables Accessed	:   
        'Global Variables Modified	:
        '
        'Called by				    :
        'Called					    :
        '
        'Tables/Fields Accessed		:
        '
        'Last Edited By			    :
        'Last Edited On			    :
        'Reason				        :
        '
        '****************************************
        Public Function Update()
            Dim arr_parIDBValues(4) As IDbDataParameter

            arr_parIDBValues(0) = pi_helper.GetParameter("@LGM_ID", DbType.Int32, 4, 1)
            arr_parIDBValues(0).Value = pi_intID

            arr_parIDBValues(1) = pi_helper.GetParameter("@LGM_LGV_ID", DbType.Int32, 4, 1)
            arr_parIDBValues(1).Value = pi_intLGV_ID

            arr_parIDBValues(2) = pi_helper.GetParameter("@LGM_Name", DbType.String, 64, 1)
            arr_parIDBValues(2).Value = pi_strName

            arr_parIDBValues(3) = pi_helper.GetParameter("@LGM_Description", DbType.String, 256, 1)
            arr_parIDBValues(3).Value = pi_strDescription

            arr_parIDBValues(4) = pi_helper.GetParameter("@LGM_Last_Modified_By_sys", DbType.Int32, 4, 1)
            arr_parIDBValues(4).Value = pi_intLast_Modified_By_sys

            Try
                pi_IDBcon = pi_helper.GetConnection(pi_strConn)
                pi_IDBcon.Open()
                pi_IDBtra = pi_IDBcon.BeginTransaction(IsolationLevel.Serializable)

                pi_intID = pi_helper.ExecuteScalar(pi_IDBtra, "USP_Update_List_Group_Master", arr_parIDBValues)

                pi_IDBtra.Commit()
                Return pi_intID
            Catch ex As Exception
                If Not (pi_IDBtra Is Nothing) Then
                    pi_IDBtra.Rollback()
                End If
                Throw ex
            Finally
                If (pi_IDBcon.State = ConnectionState.Open) Then
                    pi_IDBcon.Close()
                End If
            End Try
        End Function
        '****************************************
        'Programmer				    :   Frank
        'Date Of Creation			:   09-03-2005
        'Description				:   'Started Prcodedure for Delete
        '			
        'Accepted Parameters		:   --
        'Return Values			    :   
        'Global Variables Accessed	:   
        'Global Variables Modified	:
        '
        'Called by				    :
        'Called					    :
        '
        'Tables/Fields Accessed		:
        '
        'Last Edited By			    :
        'Last Edited On			    :
        'Reason				        :
        '
        '****************************************
        Public Function Delete()
            Dim arr_parIDBValues(1) As IDbDataParameter

            arr_parIDBValues(0) = pi_helper.GetParameter("@LGM_ID", DbType.Int32, 4, 1)
            arr_parIDBValues(0).Value = pi_intID

            arr_parIDBValues(1) = pi_helper.GetParameter("@UserId", DbType.Int32, 4, 1)
            arr_parIDBValues(1).Value = pi_intLast_Modified_By_sys

            Try
                pi_IDBcon = pi_helper.GetConnection(pi_strConn)
                pi_IDBcon.Open()
                pi_IDBtra = pi_IDBcon.BeginTransaction(IsolationLevel.Serializable)

                pi_intID = pi_helper.ExecuteScalar(pi_IDBtra, "USP_Delete_List_Group_Master", arr_parIDBValues)

                pi_IDBtra.Commit()
                Return pi_intID
            Catch ex As Exception
                If Not (pi_IDBtra Is Nothing) Then
                    pi_IDBtra.Rollback()
                End If
                Throw ex
            Finally
                If (pi_IDBcon.State = ConnectionState.Open) Then
                    pi_IDBcon.Close()
                End If
            End Try
        End Function

#End Region

  End Class
End Namespace