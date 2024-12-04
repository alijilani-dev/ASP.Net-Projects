'***************************************************************************************
'Class Name			:  Global Data ()
'Programmer			:  Vishal
'Date				    :  16-08-2005
'Description		:  It encompasses methods and fields accessed across the project
'                  makes use of the GotDotNet.ApplicationBlocks.Data Library
'Edited On			:   
'Edited By			:
'Reason		     	:
'List Of pending changes      :
'***************************************************************************************
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

  '***********************************************************************************
  'Programmer				      :  Vishal
  'Date Of Creation			  :  16-08-2005
  'Description				    :  Set the Connection String used by the Application.
  'Accepted Parameters		:  -
  'Return Values			    :  -
  'Global Variables Accessed	:  -
  'Global Variables Modified	:  -
  '
  'Called by				      :
  'Called					        :
  '
  'Tables/Fields Accessed	:  -
  '
  'Last Edited By			    :
  'Last Edited On			    :
  'Reason				          :
  '***********************************************************************************
  Public Sub pg_SetConnectionString(ByVal vs_ConnString As String)
    ms_ConnString = vs_ConnString
  End Sub

  '***********************************************************************************
  'Programmer				      :  Vishal
  'Date Of Creation			  :  16-08-2005
  'Description				    :  Set the Provider Class within the ADOHelper used by the Application.
  'Accepted Parameters		:  -
  'Return Values			    :  -
  'Global Variables Accessed	:  -
  'Global Variables Modified	:  -
  '
  'Called by				      :  
  'Called					        :
  '
  'Tables/Fields Accessed	:  -
  '
  'Last Edited By			    :
  'Last Edited On			    :
  'Reason				          :
  '***********************************************************************************
  Public Sub pg_SetProviderClass(ByVal vs_ProviderClass As String)
    ms_ProviderClass = gs_ProviderAssembly & "." & vs_ProviderClass
    mo_DataHelper = AdoHelper.CreateHelper(gs_ProviderAssembly, ms_ProviderClass)
    End Sub

#Region "Public constant for the Session Names"
    Public Const Session_str_Admin As String = "Admin"
    Public Const Session_str_UserName As String = "UserName"
    Public Const Session_str_Portal_ID As String = "Portal_ID"
    Public Const Session_str_Portal_Name As String = "Portal_Name"
    Public Const Session_str_Portal_Url As String = "Portal_Url"
    Public Const Session_str_Portal_Logo As String = "Portal_Logo"
    Public Const Session_str_Portal_StyleSheet As String = "Portal_StyleSheet"
    Public Const Session_Str_Cur_Main_Link_ID As String = "Main_Link_ID"
    Public Const Session_Str_Cur_Sub_Link_ID As String = "Sub_Link_ID"
    Public Const Session_ffSearchCriteria As String = "ffSearch"
#End Region

End Module