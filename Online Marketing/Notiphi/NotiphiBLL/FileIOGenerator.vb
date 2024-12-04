Imports System.Security
Imports System.Security.Permissions

Public Class FileIOGenerator
    Friend Class FileIOGenerator


        Private myFile As String() = {"C:\Examples\Test\TestFile.txt", "C:\Examples\Test\", "C:\Examples\Test\..", "C:\Temp"}

        Private myAccess As FileIOPermissionAccess() = {FileIOPermissionAccess.AllAccess, FileIOPermissionAccess.Append, FileIOPermissionAccess.NoAccess, FileIOPermissionAccess.PathDiscovery, FileIOPermissionAccess.Read, FileIOPermissionAccess.Write}

        Private fileIndex As Integer = 0


        Public Sub New()

            ResetIndex()
        End Sub 'New


        Public Sub ResetIndex()
            fileIndex = 0
        End Sub 'ResetIndex

        ' Create a FileIOPermission using FileIOPermissionAccess that is passed in.
        Public Function CreateFilePath(ByRef fileIOPerm As FileIOPermission, ByRef file As String, ByVal fpa As FileIOPermissionAccess) As Boolean

            If fileIndex = myFile.Length Then
                fileIOPerm = New FileIOPermission(PermissionState.None)
                file = ""
                fileIndex &= 1
                Return True
            End If
            If fileIndex > myFile.Length Then
                fileIOPerm = Nothing
                file = ""
                Return False
            End If

            file = myFile(fileIndex)
            fileIndex = fileIndex + 1

            Try
                fileIOPerm = New FileIOPermission(fpa, file.ToString())
                Return True
            Catch e As Exception
                Console.WriteLine(("Cannot create FileIOPermission: " & file & " " & e.ToString()))
                fileIOPerm = New FileIOPermission(PermissionState.None)
                file = ""
                Return True
            End Try
        End Function 'CreateFilePath
    End Class 'FileIOGenerator 
    ' End of FileIOGenerator.

End Class
