Imports System.Data.SqlClient

Public Class AnnouncementsDB

  Public Sub New()
  End Sub


  Public Function AddAnnouncement(ByVal moduleId As Integer, ByVal itemId As Integer, ByVal userName As String, ByVal title As String, ByVal expireDate As DateTime, ByVal description As String, ByVal moreLink As String, ByVal mobileMoreLink As String, ByVal imageUrl As String, ByVal imageWidth As String, ByVal imageHeight As String) As Integer
    If (userName.Length < 1) Then
      userName = "unknown"
    End If
    Dim connection1 As New SqlConnection(ConfigurationSettings.AppSettings.Item("connectionString"))
    Dim command1 As New SqlCommand("pmAddAnnouncement", connection1)
    command1.CommandType = CommandType.StoredProcedure
    Dim parameter1 As New SqlParameter("@ItemID", SqlDbType.Int, 4)
    parameter1.Direction = ParameterDirection.Output
    command1.Parameters.Add(parameter1)
    Dim parameter2 As New SqlParameter("@ModuleId", SqlDbType.Int, 4)
    parameter2.Value = moduleId
    command1.Parameters.Add(parameter2)
    Dim parameter3 As New SqlParameter("@UserName", SqlDbType.NVarChar, 100)
    parameter3.Value = userName
    command1.Parameters.Add(parameter3)
    Dim parameter4 As New SqlParameter("@Title", SqlDbType.NVarChar, 150)
    parameter4.Value = title
    command1.Parameters.Add(parameter4)
    Dim parameter5 As New SqlParameter("@MoreLink", SqlDbType.NVarChar, 256)
    parameter5.Value = moreLink
    command1.Parameters.Add(parameter5)
    Dim parameter6 As New SqlParameter("@MobileMoreLink", SqlDbType.NVarChar, 256)
    parameter6.Value = mobileMoreLink
    command1.Parameters.Add(parameter6)
    Dim parameter7 As New SqlParameter("@ExpireDate", SqlDbType.DateTime, 8)
    parameter7.Value = expireDate
    command1.Parameters.Add(parameter7)
    Dim parameter8 As New SqlParameter("@Description", SqlDbType.NVarChar, 2000)
    parameter8.Value = description
    command1.Parameters.Add(parameter8)
    Dim parameter9 As New SqlParameter("@ImageUrl", SqlDbType.NVarChar, 256)
    parameter9.Value = imageUrl
    command1.Parameters.Add(parameter9)
    Dim parameter10 As New SqlParameter("@ImageWidth", SqlDbType.NVarChar, 5)
    parameter10.Value = imageWidth
    command1.Parameters.Add(parameter10)
    Dim parameter11 As New SqlParameter("@ImageHeight", SqlDbType.NVarChar, 5)
    parameter11.Value = imageHeight
    command1.Parameters.Add(parameter11)
    connection1.Open()
    command1.ExecuteNonQuery()
    connection1.Close()
    Return CType(parameter1.Value, Integer)
  End Function

  Public Sub DeleteAnnouncement(ByVal itemID As Integer)
    Dim connection1 As New SqlConnection(ConfigurationSettings.AppSettings.Item("connectionString"))
    Dim command1 As New SqlCommand("pmDeleteAnnouncement", connection1)
    command1.CommandType = CommandType.StoredProcedure
    Dim parameter1 As New SqlParameter("@ItemID", SqlDbType.Int, 4)
    parameter1.Value = itemID
    command1.Parameters.Add(parameter1)
    connection1.Open()
    command1.ExecuteNonQuery()
    connection1.Close()
  End Sub

  Public Function GetAnnouncements(ByVal moduleId As Integer) As DataSet
    Dim connection1 As New SqlConnection(ConfigurationSettings.AppSettings.Item("connectionString"))
    Dim adapter1 As New SqlDataAdapter("pmGetAnnouncements", connection1)
    adapter1.SelectCommand.CommandType = CommandType.StoredProcedure
    Dim parameter1 As New SqlParameter("@ModuleId", SqlDbType.Int, 4)
    parameter1.Value = moduleId
    adapter1.SelectCommand.Parameters.Add(parameter1)
    Dim set1 As New DataSet()
    adapter1.Fill(set1)
    Return set1
  End Function

  Public Function GetSingleAnnouncement(ByVal itemId As Integer) As SqlDataReader
    Dim connection1 As New SqlConnection(ConfigurationSettings.AppSettings.Item("connectionString"))
    Dim command1 As New SqlCommand("pmGetSingleAnnouncement", connection1)
    command1.CommandType = CommandType.StoredProcedure
    Dim parameter1 As New SqlParameter("@ItemId", SqlDbType.Int, 4)
    parameter1.Value = itemId
    command1.Parameters.Add(parameter1)
    connection1.Open()
    Return command1.ExecuteReader(CommandBehavior.CloseConnection)
  End Function


  Public Sub UpdateAnnouncement(ByVal moduleId As Integer, ByVal itemId As Integer, ByVal userName As String, ByVal title As String, ByVal expireDate As DateTime, ByVal description As String, ByVal moreLink As String, ByVal mobileMoreLink As String, ByVal imageUrl As String, ByVal imageWidth As String, ByVal imageHeight As String)
    If (userName.Length < 1) Then
      userName = "unknown"
    End If
    Dim connection1 As New SqlConnection(ConfigurationSettings.AppSettings.Item("connectionString"))
    Dim command1 As New SqlCommand("pmUpdateAnnouncement", connection1)
    command1.CommandType = CommandType.StoredProcedure
    Dim parameter1 As New SqlParameter("@ItemID", SqlDbType.Int, 4)
    parameter1.Value = itemId
    command1.Parameters.Add(parameter1)
    Dim parameter2 As New SqlParameter("@UserName", SqlDbType.NVarChar, 100)
    parameter2.Value = userName
    command1.Parameters.Add(parameter2)
    Dim parameter3 As New SqlParameter("@Title", SqlDbType.NVarChar, 150)
    parameter3.Value = title
    command1.Parameters.Add(parameter3)
    Dim parameter4 As New SqlParameter("@MoreLink", SqlDbType.NVarChar, 256)
    parameter4.Value = moreLink
    command1.Parameters.Add(parameter4)
    Dim parameter5 As New SqlParameter("@MobileMoreLink", SqlDbType.NVarChar, 256)
    parameter5.Value = mobileMoreLink
    command1.Parameters.Add(parameter5)
    Dim parameter6 As New SqlParameter("@ExpireDate", SqlDbType.DateTime, 8)
    parameter6.Value = expireDate
    command1.Parameters.Add(parameter6)
    Dim parameter7 As New SqlParameter("@Description", SqlDbType.NVarChar, 2000)
    parameter7.Value = description
    command1.Parameters.Add(parameter7)
    Dim parameter8 As New SqlParameter("@ImageUrl", SqlDbType.NVarChar, 256)
    parameter8.Value = imageUrl
    command1.Parameters.Add(parameter8)
    Dim parameter9 As New SqlParameter("@ImageWidth", SqlDbType.NVarChar, 5)
    parameter9.Value = imageWidth
    command1.Parameters.Add(parameter9)
    Dim parameter10 As New SqlParameter("@ImageHeight", SqlDbType.NVarChar, 5)
    parameter10.Value = imageHeight
    command1.Parameters.Add(parameter10)
    connection1.Open()
    command1.ExecuteNonQuery()
    connection1.Close()
  End Sub




End Class
