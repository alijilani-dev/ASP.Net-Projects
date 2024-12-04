Public Class TradeFloor

#Region "Private Variables"

    Private pi_str_Error As String
    Private pi_int_Trading_ID As Integer
    Private pi_str_post_heading As String
    Private pi_Int_Trade_Type As Integer
    Private pi_Str_Member_Id As String
    Private pi_Int_MobileSrNo As Double
    Private pi_Str_ModelNo As String
    Private pi_Str_OtherManufName As String
    Private pi_Int_ManufCode As Double
    Private pi_Int_Quantity As String
    Private pi_Int_Price As Double
    Private pi_Int_CurrencyCode As Integer
    Private pi_Str_Spec As String
    Private pi_Str_Warranty As String
    Private pi_Bit_ProviderLogo As Boolean
    Private pi_Str_Packaging As String
    Private pi_dat_RequestDate As DateTime
    Private pi_Str_ShippingTerms As String
    Private pi_Str_Location As String
    Private pi_Str_post_desc As String
    Private pi_Int_Status As String
    Private pi_Str_StockLocation As String
    Private pi_intUserID As Integer
    ' ** Ali **: Reason: Add country information along with the posted offer information comming from TradeFloor.ascx
    Private pi_int_Country_ID As Integer
    ' ** Ali **:

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"
    Public Property Message() As String
        Get
            Return pi_str_Error
        End Get
        Set(ByVal Value As String)
            pi_str_Error = Value
        End Set
    End Property
    Public Property Trading_ID() As Integer
        Get
            Return pi_int_Trading_ID
        End Get
        Set(ByVal Value As Integer)
            pi_int_Trading_ID = Value
        End Set
    End Property
    Public Property post_heading() As String
        Get
            Return pi_str_post_heading
        End Get
        Set(ByVal Value As String)
            pi_str_post_heading = Value
        End Set
    End Property
    Public Property Trade_Type() As Integer
        Get
            Return pi_Int_Trade_Type
        End Get
        Set(ByVal Value As Integer)
            pi_Int_Trade_Type = Value
        End Set
    End Property
    Public Property Member_Id() As String
        Get
            Return pi_Str_Member_Id
        End Get
        Set(ByVal Value As String)
            pi_Str_Member_Id = Value
        End Set
    End Property
    Public Property MobileSrNo() As Double
        Get
            Return pi_Int_MobileSrNo
        End Get
        Set(ByVal Value As Double)
            pi_Int_MobileSrNo = Value
        End Set
    End Property
    Public Property ModelNo() As String
        Get
            Return pi_Str_ModelNo
        End Get
        Set(ByVal Value As String)
            pi_Str_ModelNo = Value
        End Set
    End Property
    Public Property ManufCode() As Double
        Get
            Return pi_Int_ManufCode
        End Get
        Set(ByVal Value As Double)
            pi_Int_ManufCode = Value
        End Set
    End Property
    Public Property OtherManufName() As String
        Get
            Return pi_Str_OtherManufName
        End Get
        Set(ByVal Value As String)
            pi_Str_OtherManufName = Value
        End Set
    End Property


    Public Property Quantity() As String
        Get
            Return pi_Int_Quantity
        End Get
        Set(ByVal Value As String)
            pi_Int_Quantity = Value
        End Set
    End Property
    Public Property Price() As Double
        Get
            Return pi_Int_Price
        End Get
        Set(ByVal Value As Double)
            pi_Int_Price = Value
        End Set
    End Property

    Public Property CurrencyCode() As Integer
        Get
            Return pi_Int_CurrencyCode
        End Get
        Set(ByVal Value As Integer)
            pi_Int_CurrencyCode = Value
        End Set
    End Property
    Public Property Spec() As String
        Get
            Return pi_Str_Spec
        End Get
        Set(ByVal Value As String)
            pi_Str_Spec = Value
        End Set
    End Property

    Public Property Warranty() As String
        Get
            Return pi_Str_Warranty
        End Get
        Set(ByVal Value As String)
            pi_Str_Warranty = Value
        End Set
    End Property
    Public Property ProviderLogo() As Boolean
        Get
            Return pi_Bit_ProviderLogo
        End Get
        Set(ByVal Value As Boolean)
            pi_Bit_ProviderLogo = Value
        End Set
    End Property
    Public Property Packaging() As String
        Get
            Return pi_Str_Packaging
        End Get
        Set(ByVal Value As String)
            pi_Str_Packaging = Value
        End Set
    End Property
    Public Property RequestDate() As DateTime
        Get
            Return pi_dat_RequestDate
        End Get
        Set(ByVal Value As DateTime)
            pi_dat_RequestDate = Value
        End Set
    End Property
    Public Property ShippingTerms() As String
        Get
            Return pi_Str_ShippingTerms
        End Get
        Set(ByVal Value As String)
            pi_Str_ShippingTerms = Value
        End Set
    End Property
    ' ** Ali **: Reason: Add country information along with the posted offer information comming from TradeFloor.ascx
    Public Property Country_ID() As Integer
        Get
            Return pi_int_Country_ID
        End Get
        Set(ByVal Value As Integer)
            pi_int_Country_ID = Value
        End Set
    End Property
    Public Property StockLocation() As String
        Get
            Return pi_Str_StockLocation
        End Get
        Set(ByVal Value As String)
            pi_Str_StockLocation = Value
        End Set
    End Property
    ' ** Ali **:
    Public Property Location() As String
        Get
            Return pi_Str_Location
        End Get
        Set(ByVal Value As String)
            pi_Str_Location = Value
        End Set
    End Property
    Public Property post_desc() As String
        Get
            Return pi_Str_post_desc
        End Get
        Set(ByVal Value As String)
            pi_Str_post_desc = Value
        End Set
    End Property
    Public Property Status() As String
        Get
            Return pi_Int_Status
        End Get
        Set(ByVal Value As String)
            pi_Int_Status = Value
        End Set
    End Property
#End Region

#Region "get Select ALL / SINGLE TradeFloor"
    Public Function GetModuleTradeFloor(ByVal prm_Portal_ID As Integer, Optional ByVal prm_HotOffer As Boolean = False) As DataTable
        Dim idbparameter(2) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Portal_ID", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prm_Portal_ID

            If prm_HotOffer = True Then
                idbparameter(1) = GlobalData.DataHelper.GetParameter("@HotOffer", DbType.Boolean, 1, ParameterDirection.Input)
                idbparameter(1).Value = 1
            End If
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_Get_TradeFloors", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
    Public Function GetMemberTradeFloor(ByVal prm_Portal_ID As Integer, ByVal prm_Member_ID As String, Optional ByVal prm_HotOffer As Boolean = False, Optional ByVal prmCondition As String = "") As DataTable
        Dim idbparameter(3) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Portal_ID", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prm_Portal_ID

            If prm_Member_ID <> "" Then
                idbparameter(1) = GlobalData.DataHelper.GetParameter("@Member_ID", DbType.String, 20, ParameterDirection.Input)
                idbparameter(1).Value = prm_Member_ID
            End If

            If prm_HotOffer = True Then
                idbparameter(2) = GlobalData.DataHelper.GetParameter("@HotOffer", DbType.Boolean, 1, ParameterDirection.Input)
                idbparameter(2).Value = 1
            End If

            idbparameter(3) = GlobalData.DataHelper.GetParameter("@Condition", DbType.String, 3000, ParameterDirection.Input)
            idbparameter(3).Value = prmCondition

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_GET_OPTIMIZED_TRADE_FLOOR_MEMAREA", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
    ''Function added by Basheer to get the 2 days HOT OFFER from the Trading Floor
    Public Function GetHotOffer(Optional ByVal prm_Days As Integer = 2) As DataTable
        Dim idbparameter(0) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@days_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prm_Days

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_TRADING_HOTOFFER_NEW", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
    Public Function GetMemberGroupedTradeFloor(ByVal prm_Portal_ID As Integer, ByVal prm_Member_ID As String, Optional ByVal prm_HotOffer As Boolean = False, Optional ByVal prmCondition As String = "") As DataTable
        Dim idbparameter(3) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Portal_ID", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prm_Portal_ID

            If prm_Member_ID <> "" Then
                idbparameter(1) = GlobalData.DataHelper.GetParameter("@Member_ID", DbType.String, 20, ParameterDirection.Input)
                idbparameter(1).Value = prm_Member_ID
            End If

            If prm_HotOffer = True Then
                idbparameter(2) = GlobalData.DataHelper.GetParameter("@HotOffer", DbType.Boolean, 1, ParameterDirection.Input)
                idbparameter(2).Value = 1
            End If

            idbparameter(3) = GlobalData.DataHelper.GetParameter("@Condition", DbType.String, 3000, ParameterDirection.Input)
            idbparameter(3).Value = prmCondition

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_GET_TRADE_FLOOR_GROUPEDMEMAREA", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
    Public Function PostGroupedtoTradeFloor(ByVal prm_Member_ID As String) As DataTable
        Dim idbparameter(3) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            '    pi_helper = GlobalData.DataHelper
            '    idbparameter(0) = GlobalData.DataHelper.GetParameter("@Portal_ID", DbType.Int32, 4, ParameterDirection.Input)
            '    idbparameter(0).Value = prm_Portal_ID

            If prm_Member_ID <> "" Then
                idbparameter(1) = GlobalData.DataHelper.GetParameter("@Member_ID", DbType.String, 20, ParameterDirection.Input)
                idbparameter(1).Value = prm_Member_ID
            End If

            'If prm_HotOffer = True Then
            '    idbparameter(2) = GlobalData.DataHelper.GetParameter("@HotOffer", DbType.Boolean, 1, ParameterDirection.Input)
            '    idbparameter(2).Value = 1
            'End If

            'idbparameter(3) = GlobalData.DataHelper.GetParameter("@Condition", DbType.String, 3000, ParameterDirection.Input)
            'idbparameter(3).Value = prmCondition

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_POST_GROUPED_TO_TRADE_FLOOR", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
    Public Function GetTradeFloor(Optional ByVal prm_Trading_ID As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prm_Trading_ID = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_TRADE_FLOOR")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@Trading_ID", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_Trading_ID
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_TRADE_FLOOR", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
    Public Function UpdateGroupTimeStamp(ByVal prm_Member_ID As String, ByVal prm_TradeIDs As String, Optional ByVal prm_ReqDate As String = "") As Boolean
        Dim idbparameter(3) As IDataParameter
        'Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper

            If prm_Member_ID <> "" Then
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@Member_ID", DbType.String, 20, ParameterDirection.Input)
                idbparameter(0).Value = prm_Member_ID
            End If

            idbparameter(1) = GlobalData.DataHelper.GetParameter("@TradeIDs", DbType.String, 150, ParameterDirection.Input)
            idbparameter(1).Value = prm_TradeIDs

            If prm_ReqDate <> "" Then
                idbparameter(2) = GlobalData.DataHelper.GetParameter("@ReqDate", DbType.String, 150, ParameterDirection.Input)
                idbparameter(2).Value = prm_ReqDate
            End If

            pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
            pi_IDBcon.Open()
            pi_IDBtra = pi_IDBcon.BeginTransaction()

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_UPDATE_GROUP_TIMESTAMP", idbparameter)
            pi_IDBtra.Commit()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
            pi_IDBtra.Rollback()
            pi_IDBcon.Close()
            Return False

        End Try
        ' Return the table
        Return True
    End Function
    Public Function DeleteGroupedPosting(ByVal prm_Member_ID As String, ByVal prm_TradeIDs As String) As Boolean
        Dim idbparameter(3) As IDataParameter
        'Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper

            If prm_Member_ID <> "" Then
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@Member_ID", DbType.String, 20, ParameterDirection.Input)
                idbparameter(0).Value = prm_Member_ID
            End If

            idbparameter(1) = GlobalData.DataHelper.GetParameter("@TradeIDs", DbType.String, 150, ParameterDirection.Input)
            idbparameter(1).Value = prm_TradeIDs

            pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
            pi_IDBcon.Open()
            pi_IDBtra = pi_IDBcon.BeginTransaction()

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_DELETE_GROUPED_POSTING", idbparameter)
            pi_IDBtra.Commit()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
            pi_IDBtra.Rollback()
            pi_IDBcon.Close()
            Return False

        End Try
        ' Return the table
        Return True
    End Function
#End Region

#Region "INSERT TradeFloor"
    Public Function Insert() As Boolean

        Dim idb_TradeFloor_parameter(20) As IDataParameter
        Dim dt_row As DataRow

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        idb_TradeFloor_parameter(0) = GlobalData.DataHelper.GetParameter("@Trading_ID", DbType.Int32, 4, ParameterDirection.InputOutput)
        idb_TradeFloor_parameter(0).Value = Me.Trading_ID

        idb_TradeFloor_parameter(1) = GlobalData.DataHelper.GetParameter("@post_heading", DbType.String, 100, ParameterDirection.Input)
        idb_TradeFloor_parameter(1).Value = Me.post_heading

        idb_TradeFloor_parameter(2) = GlobalData.DataHelper.GetParameter("@Trade_Type", DbType.Int32, 4, ParameterDirection.Input)
        idb_TradeFloor_parameter(2).Value = Me.Trade_Type

        idb_TradeFloor_parameter(3) = GlobalData.DataHelper.GetParameter("@Member_Id", DbType.String, 20, ParameterDirection.Input)
        idb_TradeFloor_parameter(3).Value = Me.Member_Id

        idb_TradeFloor_parameter(4) = GlobalData.DataHelper.GetParameter("@MobileSrNo", DbType.Int32, 4, ParameterDirection.Input)
        idb_TradeFloor_parameter(4).Value = Me.MobileSrNo

        idb_TradeFloor_parameter(5) = GlobalData.DataHelper.GetParameter("@ModelNo", DbType.String, 20, ParameterDirection.Input)
        idb_TradeFloor_parameter(5).Value = Me.ModelNo

        idb_TradeFloor_parameter(6) = GlobalData.DataHelper.GetParameter("@ManufCode", DbType.Int32, 4, ParameterDirection.Input)
        idb_TradeFloor_parameter(6).Value = Me.ManufCode

        idb_TradeFloor_parameter(7) = GlobalData.DataHelper.GetParameter("@Quantity", DbType.String, 15, ParameterDirection.Input)
        idb_TradeFloor_parameter(7).Value = Me.Quantity

        idb_TradeFloor_parameter(8) = GlobalData.DataHelper.GetParameter("@Price", DbType.Double, 8, ParameterDirection.Input)
        idb_TradeFloor_parameter(8).Value = Me.Price

        idb_TradeFloor_parameter(9) = GlobalData.DataHelper.GetParameter("@CurrencyCode", DbType.Int32, 4, ParameterDirection.Input)
        idb_TradeFloor_parameter(9).Value = Me.CurrencyCode

        idb_TradeFloor_parameter(10) = GlobalData.DataHelper.GetParameter("@Spec", DbType.String, 100, ParameterDirection.Input)
        idb_TradeFloor_parameter(10).Value = Me.Spec

        idb_TradeFloor_parameter(11) = GlobalData.DataHelper.GetParameter("@Warranty", DbType.String, 100, ParameterDirection.Input)
        idb_TradeFloor_parameter(11).Value = Me.Warranty

        idb_TradeFloor_parameter(12) = GlobalData.DataHelper.GetParameter("@ProviderLogo", DbType.Boolean, 1, ParameterDirection.Input)
        idb_TradeFloor_parameter(12).Value = Me.ProviderLogo

        idb_TradeFloor_parameter(13) = GlobalData.DataHelper.GetParameter("@Packaging", DbType.String, 100, ParameterDirection.Input)
        idb_TradeFloor_parameter(13).Value = Me.Packaging

        idb_TradeFloor_parameter(14) = GlobalData.DataHelper.GetParameter("@RequestDate", DbType.DateTime, 8, ParameterDirection.Input)
        idb_TradeFloor_parameter(14).Value = Me.RequestDate


        idb_TradeFloor_parameter(15) = GlobalData.DataHelper.GetParameter("@ShippingTerms", DbType.String, 100, ParameterDirection.Input)
        idb_TradeFloor_parameter(15).Value = Me.ShippingTerms

        ' ** Ali **: Reason: Add country information along with the posted offer information comming from TradeFloor.ascx
        idb_TradeFloor_parameter(19) = GlobalData.DataHelper.GetParameter("@Country_ID", DbType.Int32, 4, ParameterDirection.Input)
        idb_TradeFloor_parameter(19).Value = Me.Country_ID
        ' ** Ali **

        idb_TradeFloor_parameter(16) = GlobalData.DataHelper.GetParameter("@Location", DbType.String, 100, ParameterDirection.Input)
        idb_TradeFloor_parameter(16).Value = Me.Location


        idb_TradeFloor_parameter(17) = GlobalData.DataHelper.GetParameter("@post_desc", DbType.String, 1000, ParameterDirection.Input)
        idb_TradeFloor_parameter(17).Value = Me.post_desc

        idb_TradeFloor_parameter(18) = GlobalData.DataHelper.GetParameter("@Status", DbType.String, 20, ParameterDirection.Input)
        idb_TradeFloor_parameter(18).Value = Me.Status

        idb_TradeFloor_parameter(19) = GlobalData.DataHelper.GetParameter("@OtherManufName", DbType.String, 100, ParameterDirection.Input)
        idb_TradeFloor_parameter(19).Value = Me.OtherManufName
        'Try

        pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_INSERT_TRADE_FLOOR", idb_TradeFloor_parameter)

        pi_IDBtra.Commit()

        pi_IDBcon.Close()
        ' Return 
        Return True

        'Catch ex As Exception
        '    pi_IDBtra.Rollback()
        '    pi_IDBcon.Close()
        '    System.Diagnostics.Debug.WriteLine(ex.Message)
        '    ' Return 
        '    Return False
        '    Exit Function
        'End Try
    End Function

#End Region

#Region "DELETE TradeFloor"
    Public Function Delete() As Boolean

        Dim idb_TradeFloor_parameter(1) As IDataParameter
        Dim dt_row As DataRow

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        idb_TradeFloor_parameter(0) = GlobalData.DataHelper.GetParameter("@Trading_ID", DbType.Int32, 4, ParameterDirection.Input)
        idb_TradeFloor_parameter(0).Value = Me.Trading_ID

        pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_DELETE_TRADE_FLOOR", idb_TradeFloor_parameter)

        pi_IDBtra.Commit()

        pi_IDBcon.Close()

        Return True

    End Function
#End Region

#Region "UPDATE TradeFloor"
    Public Function Update(Optional ByVal lSaveChanges As Boolean = False) As Boolean

        Dim idb_TradeFloor_parameter(21) As IDataParameter
        Dim dt_row As DataRow

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        idb_TradeFloor_parameter(0) = GlobalData.DataHelper.GetParameter("@Trading_ID", DbType.Int32, 4, ParameterDirection.Input)
        idb_TradeFloor_parameter(0).Value = Me.Trading_ID
        idb_TradeFloor_parameter(1) = GlobalData.DataHelper.GetParameter("@post_heading", DbType.String, 100, ParameterDirection.Input)
        idb_TradeFloor_parameter(1).Value = Me.post_heading
        idb_TradeFloor_parameter(2) = GlobalData.DataHelper.GetParameter("@Trade_Type", DbType.Int32, 4, ParameterDirection.Input)
        idb_TradeFloor_parameter(2).Value = Me.Trade_Type
        idb_TradeFloor_parameter(3) = GlobalData.DataHelper.GetParameter("@Member_Id", DbType.String, 20, ParameterDirection.Input)
        idb_TradeFloor_parameter(3).Value = Me.Member_Id
        idb_TradeFloor_parameter(4) = GlobalData.DataHelper.GetParameter("@MobileSrNo", DbType.Int32, 4, ParameterDirection.Input)
        idb_TradeFloor_parameter(4).Value = Me.MobileSrNo
        idb_TradeFloor_parameter(5) = GlobalData.DataHelper.GetParameter("@ModelNo", DbType.String, 20, ParameterDirection.Input)
        idb_TradeFloor_parameter(5).Value = Me.ModelNo
        idb_TradeFloor_parameter(6) = GlobalData.DataHelper.GetParameter("@ManufCode", DbType.Int32, 4, ParameterDirection.Input)
        idb_TradeFloor_parameter(6).Value = Me.ManufCode
        idb_TradeFloor_parameter(7) = GlobalData.DataHelper.GetParameter("@Quantity", DbType.String, 15, ParameterDirection.Input)
        idb_TradeFloor_parameter(7).Value = Me.Quantity
        idb_TradeFloor_parameter(8) = GlobalData.DataHelper.GetParameter("@Price", DbType.Double, 8, ParameterDirection.Input)
        idb_TradeFloor_parameter(8).Value = Me.Price
        idb_TradeFloor_parameter(9) = GlobalData.DataHelper.GetParameter("@CurrencyCode", DbType.Int32, 4, ParameterDirection.Input)
        idb_TradeFloor_parameter(9).Value = Me.CurrencyCode
        idb_TradeFloor_parameter(10) = GlobalData.DataHelper.GetParameter("@Spec", DbType.String, 100, ParameterDirection.Input)
        idb_TradeFloor_parameter(10).Value = Me.Spec
        idb_TradeFloor_parameter(11) = GlobalData.DataHelper.GetParameter("@Warranty", DbType.String, 100, ParameterDirection.Input)
        idb_TradeFloor_parameter(11).Value = Me.Warranty
        idb_TradeFloor_parameter(12) = GlobalData.DataHelper.GetParameter("@ProviderLogo", DbType.Boolean, 1, ParameterDirection.Input)
        idb_TradeFloor_parameter(12).Value = Me.ProviderLogo
        idb_TradeFloor_parameter(13) = GlobalData.DataHelper.GetParameter("@Packaging", DbType.String, 100, ParameterDirection.Input)
        idb_TradeFloor_parameter(13).Value = Me.Packaging
        If (lSaveChanges) Then
            idb_TradeFloor_parameter(14) = GlobalData.DataHelper.GetParameter("@RequestDate", DbType.DateTime, 8, ParameterDirection.Input)
            idb_TradeFloor_parameter(14).Value = "1753-01-01 00:00:00.000"
        Else
            idb_TradeFloor_parameter(14) = GlobalData.DataHelper.GetParameter("@RequestDate", DbType.DateTime, 8, ParameterDirection.Input)
            idb_TradeFloor_parameter(14).Value = Me.RequestDate
        End If

        idb_TradeFloor_parameter(15) = GlobalData.DataHelper.GetParameter("@ShippingTerms", DbType.String, 100, ParameterDirection.Input)
        idb_TradeFloor_parameter(15).Value = Me.ShippingTerms
        ' Country ID Missing.
        idb_TradeFloor_parameter(16) = GlobalData.DataHelper.GetParameter("@Location", DbType.String, 100, ParameterDirection.Input)
        idb_TradeFloor_parameter(16).Value = Me.Location
        idb_TradeFloor_parameter(17) = GlobalData.DataHelper.GetParameter("@post_desc", DbType.String, 1000, ParameterDirection.Input)
        idb_TradeFloor_parameter(17).Value = Me.post_desc
        idb_TradeFloor_parameter(18) = GlobalData.DataHelper.GetParameter("@Status", DbType.String, 20, ParameterDirection.Input)
        idb_TradeFloor_parameter(18).Value = Me.Status
        idb_TradeFloor_parameter(19) = GlobalData.DataHelper.GetParameter("@StockLocation", DbType.String, 20, ParameterDirection.Input)
        idb_TradeFloor_parameter(19).Value = Me.StockLocation
        idb_TradeFloor_parameter(20) = GlobalData.DataHelper.GetParameter("@CountryID", DbType.Int32, 4, ParameterDirection.Input)
        idb_TradeFloor_parameter(20).Value = Me.Country_ID
        idb_TradeFloor_parameter(21) = GlobalData.DataHelper.GetParameter("@OtherManufName", DbType.String, 100, ParameterDirection.Input)
        idb_TradeFloor_parameter(21).Value = Me.OtherManufName
        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_UPDATE_TRADE_FLOOR", idb_TradeFloor_parameter)

            pi_IDBtra.Commit()

            pi_IDBcon.Close()
            ' Return 
            Return True

        Catch ex As Exception
            pi_IDBtra.Rollback()
            pi_IDBcon.Close()
            pi_str_Error = ex.Message
            System.Diagnostics.Debug.WriteLine(ex.Message)
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
