Imports GotDotNet.ApplicationBlocks.Data
Namespace ListManagement
    'Description *******************************************************************
    'Class Name               : AccreditationMaster
    'Programmer               : Bhavesh Shura 
    'Date                     : 01-04-2005
    'Description              : 
    'Edited On                : 
    'Edited By                : 
    'Reason                   : 
    'List Of pending changes  : 
    '*******************************************************************

    Public Class AccreditationMasterBL
#Region " Variables "
        Private pi_adoHelper As AdoHelper 'Ado Helper
        Private pi_IDbConn As IDbConnection 'Connection Object
        Private pi_IDbTran As IDbTransaction 'Transaction Object
        Private pi_strCnStr As String ' Connection String

        Private pi_intACM_Id As Integer ' ACM_ID
        Private pi_strACM_Code As String 'ACM_Code
        Private pi_strACM_Name As String 'ACM_Name
        Private pi_strACM_Description As String 'ACM_Description
        Private pi_intACM_Accreditation_Type As Integer 'ACM_AccredationType
        Private pi_intACM_AM_ID As Integer 'ACM_AM_ID
        Private pi_datACM_Date_Entered As DateTime
        Private pi_datACM_Date_Modified As DateTime
        Private pi_intACM_Entered_By As Integer
        Private pi_intACM_Last_Modified_By As Integer
        Private pi_ACM_Archieved As Integer

    'Private pi_addACM_Address As New ListManagement.AddressBL()
#End Region

#Region " Essential Class Methods "
        Public Sub New()
            pi_adoHelper = GlobalData.DataHelper
            pi_strCnStr = GlobalData.ConnectionString
        End Sub
        Public Sub Dispose()
            If Not pi_adoHelper Is Nothing Then pi_adoHelper = Nothing
            If Not pi_IDbTran Is Nothing Then pi_IDbTran = Nothing
            If Not pi_IDbConn Is Nothing Then pi_IDbConn = Nothing
            MyBase.Finalize()
        End Sub
#End Region

#Region " Properties "
        Public Property ID() As Integer
            Get
                Return pi_intACM_Id
            End Get
            Set(ByVal Value As Integer)
                pi_intACM_Id = Value
            End Set
        End Property
        Public Property Code() As String
            Get
                Return pi_strACM_Code
            End Get
            Set(ByVal Value As String)
                pi_strACM_Code = Value
            End Set
        End Property

        Public Property AccreditationName() As String
            Get
                Return pi_strACM_Name
            End Get
            Set(ByVal Value As String)
                pi_strACM_Name = Value
            End Set
        End Property

        Public Property Description() As String
            Get
                Return pi_strACM_Description
            End Get
            Set(ByVal Value As String)
                pi_strACM_Description = Value
            End Set
        End Property

        Public Property AccreditationType() As Integer
            Get
                Return pi_intACM_Accreditation_Type
            End Get
            Set(ByVal Value As Integer)
                pi_intACM_Accreditation_Type = Value
            End Set
        End Property

        Public Property AddressMaster_Id() As Integer
            Get
                Return pi_intACM_AM_ID
            End Get
            Set(ByVal Value As Integer)
                pi_intACM_AM_ID = Value
            End Set
        End Property

    'Public Property AccreditationAddress() As ListManagement.AddressBL
    '    Get
    '        Return pi_addACM_Address
    '    End Get
    '    Set(ByVal Value As ListManagement.AddressBL)
    '        pi_addACM_Address = Value
    '    End Set
    'End Property

        Public Property DateEntered() As DateTime
            Get
                Return pi_datACM_Date_Entered
            End Get
            Set(ByVal Value As DateTime)
                pi_datACM_Date_Entered = Value
            End Set
        End Property

        Public Property DateModified() As DateTime
            Get
                Return pi_datACM_Date_Modified
            End Get
            Set(ByVal Value As DateTime)
                pi_datACM_Date_Modified = Value
            End Set
        End Property

        Public Property LastModified() As Integer
            Get
                Return pi_intACM_Last_Modified_By
            End Get
            Set(ByVal Value As Integer)
                pi_intACM_Last_Modified_By = Value
            End Set
        End Property
#End Region

#Region " Methods and Procedures "
        '*******************************************************************
        'Programmer                 : Bhavesh Shura
        'Date Of Creation           : 01-04-2005
        'Description                : getAccreditation
        'Accepted Parameters        : Accreditation_Id (ACM_Id)
        'Return Values              : DataRow (Row return for ACM_ID)
        'Global Variables Accessed  : 
        'Global Variables Modified  : 
        'Called by                  : 
        'Calls                      :
        'Tables/Fields Accessed		:
        'Last Edited By             : 
        'Last Edited On             : 
        'Reason                     :
        '*******************************************************************************
        Public Function getAccreditation(ByVal parm_ACM_ID As String) As DataRow
            Dim arr_objValues(0) As Object
            arr_objValues(0) = parm_ACM_ID
            Try
                Return pi_adoHelper.ExecuteDataset(pi_strCnStr, _
                "USP_SELECT_Accreditation_Master", arr_objValues).Tables(0).Rows(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        '*******************************************************************
        'Programmer                 : Bhavesh Shura
        'Date Of Creation           : 01-04-2005
        'Description                : getAccreditations
        'Accepted Parameters        : --
        'Return Values              : DataSet (Accreditation List from AccreditationMaster)
        'Global Variables Accessed  : 
        'Global Variables Modified  : 
        'Called by                  : 
        'Calls                      :
        'Tables/Fields Accessed		:
        'Last Edited By             : 
        'Last Edited On             : 
        'Reason                     :
        '*******************************************************************************
        Public Function getAccreditations() As DataSet
            Try
                Return pi_adoHelper.ExecuteDataset(pi_strCnStr, CommandType.StoredProcedure, "USP_Select_Accreditation_Master")
            Catch ex As Exception
                Throw ex
            End Try

        End Function

        '*******************************************************************
        'Programmer                 : Bhavesh Shura
        'Date Of Creation           : 01-04-2005
        'Description                : IsCodeUnique
        'Accepted Parameters        : Transaction
        'Return Values              : Int32 (Indicating whether there is a ACM_Code already exists)
        'Global Variables Accessed  : 
        'Global Variables Modified  : 
        'Called by                  : 
        'Calls                      :
        'Tables/Fields Accessed		:
        'Last Edited By             : 
        'Last Edited On             : 
        'Reason                     :
        '*******************************************************************************
        Public Function IsCodeUnique(ByVal vDbTran As IDbTransaction) As Int32
            Dim strSQL As String
            Dim iCnt As Integer
            strSQL = "SELECT COUNT(ACM_CODE) FROM Accreditation_Master " & _
                     "WHERE ACM_Code = '" & pi_strACM_Code & "' AND ACM_Archived_sys = 0 AND ACM_ID <> " & pi_intACM_Id
            iCnt = pi_adoHelper.ExecuteScalar(vDbTran, CommandType.Text, strSQL)
            Return iCnt
        End Function

        '*******************************************************************
        'Programmer                 : Bhavesh Shura
        'Date Of Creation           : 1st Apr 2005
        'Description                : Insert Operation
        'Accepted Parameters        : --
        'Return Values              : --
        'Global Variables Accessed  : 
        'Global Variables Modified  : 
        'Called by                  : 
        'Calls                      :
        'Tables/Fields Accessed		:
        'Last Edited By             : 
        'Last Edited On             : 
        'Reason                     :
        '*******************************************************************************
        Public Sub Insert()
            Dim arr_objValues(5) As Object ' Parameter for UPS_INSERT_Accreditation_Master
            Dim intTranSuccessful As Short
            Try
                'Fill arr_objValues
                arr_objValues(0) = pi_strACM_Code
                arr_objValues(1) = pi_strACM_Name
                arr_objValues(2) = pi_strACM_Description
                arr_objValues(3) = pi_intACM_Accreditation_Type
                '                arr_objValues(4) = pi_intACM_AM_ID
                arr_objValues(5) = pi_intACM_Last_Modified_By

                'End arr_objValues

                pi_IDbConn = pi_adoHelper.GetConnection(pi_strCnStr)
                pi_IDbConn.Open()
                pi_IDbTran = pi_IDbConn.BeginTransaction(IsolationLevel.Serializable)

                'arr_objValues(4) = pi_addACM_Address.SaveAddress(pi_IDbTran)

        'If pi_addACM_Address Is Nothing Then
        '    arr_objValues(4) = DBNull.Value
        'Else
        '    arr_objValues(4) = pi_addACM_Address.SaveAddress(pi_IDbTran)
        'End If

                If IsCodeUnique(pi_IDbTran) > 0 Then
          Throw New ValidationException("Accreditation Code Exists")
                Else
                    intTranSuccessful = pi_adoHelper.ExecuteNonQuery(pi_IDbTran, "USP_INSERT_Accreditation_Master", arr_objValues)
                    If intTranSuccessful > 0 Then
                        pi_IDbTran.Commit()
                    Else
                        If Not (pi_IDbTran Is Nothing) Then
                            pi_IDbTran.Rollback()
                        End If
                    End If
                End If

            Catch ex As Exception
                If Not (pi_IDbTran Is Nothing) Then
                    pi_IDbTran.Rollback()
                    Throw ex
                End If
            Finally
                If (pi_IDbConn.State = ConnectionState.Open) Then
                    pi_IDbConn.Close()
                End If
            End Try
        End Sub

        '*******************************************************************
        'Programmer                 : Bhavesh Shura
        'Date Of Creation           : 01-04-2005
        'Description                : Update Operation
        'Accepted Parameters        : --
        'Return Values              : --
        'Global Variables Accessed  : 
        'Global Variables Modified  : 
        'Called by                  : 
        'Calls                      :
        'Tables/Fields Accessed		:
        'Last Edited By             : 
        'Last Edited On             : 
        'Reason                     :
        '*******************************************************************************
        Public Sub Update()
            Dim arr_objValues(6) As Object ' Parameter for UPS_INSERT_Accreditation_Master
            Dim intTranSuccessful As Short
            Try
                'Fill arr_objValues
                arr_objValues(0) = pi_intACM_Id
                arr_objValues(1) = pi_strACM_Code
                arr_objValues(2) = pi_strACM_Name
                arr_objValues(3) = pi_strACM_Description
                arr_objValues(4) = pi_intACM_Accreditation_Type
                'ACM_AM_ID is set later after transaction Begins.......
                arr_objValues(6) = pi_intACM_Last_Modified_By

                'End arr_objValues

                pi_IDbConn = pi_adoHelper.GetConnection(pi_strCnStr)
                pi_IDbConn.Open()
                pi_IDbTran = pi_IDbConn.BeginTransaction(IsolationLevel.Serializable)

        'If pi_addACM_Address Is Nothing Then
        '    arr_objValues(5) = DBNull.Value
        'Else
        '    arr_objValues(5) = pi_addACM_Address.SaveAddress(pi_IDbTran)
        'End If

                If IsCodeUnique(pi_IDbTran) > 0 Then
          Throw New ValidationException("Accreditation Code Exists")
                Else
                    intTranSuccessful = pi_adoHelper.ExecuteNonQuery(pi_IDbTran, "USP_UPDATE_Accreditation_Master", arr_objValues)
                    If intTranSuccessful > 0 Then
                        pi_IDbTran.Commit()
                    Else
                        If Not (pi_IDbTran Is Nothing) Then
                            pi_IDbTran.Rollback()
                        End If
                    End If
                End If

            Catch ex As Exception
                If Not (pi_IDbTran Is Nothing) Then
                    pi_IDbTran.Rollback()
                    Throw ex
                End If
            Finally
                If (pi_IDbConn.State = ConnectionState.Open) Then
                    pi_IDbConn.Close()
                End If
            End Try
        End Sub

        '*******************************************************************
        'Programmer                 : Bhavesh Shura
        'Date Of Creation           : 01-04-2005
        'Description                : Delete Operation
        'Accepted Parameters        : --
        'Return Values              : --
        'Global Variables Accessed  : 
        'Global Variables Modified  : 
        'Called by                  : 
        'Calls                      :
        'Tables/Fields Accessed		:
        'Last Edited By             : 
        'Last Edited On             : 
        'Reason                     :
        '*******************************************************************************
        Public Sub Delete()
            Dim arr_objValues(1) As Object
            Dim intTranSuccessful As Short

            arr_objValues(0) = pi_intACM_Id
            arr_objValues(1) = pi_intACM_Last_Modified_By

            Try
                pi_IDbConn = pi_adoHelper.GetConnection(pi_strCnStr)
                pi_IDbConn.Open()
                pi_IDbTran = pi_IDbConn.BeginTransaction

                intTranSuccessful = pi_adoHelper.ExecuteNonQuery(pi_IDbTran, "USP_Delete_Accreditation_Master", arr_objValues)

                If intTranSuccessful > 0 Then
                    pi_IDbTran.Commit()
                Else
                    pi_IDbTran.Rollback()
                End If

            Catch ex As Exception
                If Not (pi_IDbTran Is Nothing) Then
                    pi_IDbTran.Rollback()
                    Throw ex
                End If
            Finally
                If (pi_IDbConn.State = ConnectionState.Open) Then
                    pi_IDbConn.Close()
                End If
            End Try
        End Sub

#End Region
    End Class
End Namespace
