Imports System.Security.Cryptography
Public Module EncryptData
    'Encrypt the text
    Public Function EncryptText(ByVal strText As String) As String
        'Return Encrypt(strText, "&%#@?,:*")
        Return Encrypt(strText, "phonecpu")
    End Function

    'Decrypt the text 
    Public Function DecryptText(ByVal strText As String) As String
        'Return Decrypt(strText, "&%#@?,:*")
        Return Decrypt(strText, "phonecpu")
    End Function

    'The function used to encrypt the text
    Private Function Encrypt(ByVal strText As String, ByVal strEncrKey As String) As String
        Dim byKey() As Byte = {}
        Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}

        Try
            byKey = System.Text.Encoding.UTF8.GetBytes(Left(strEncrKey, 8))

            Dim des As New DESCryptoServiceProvider
            Dim inputByteArray() As Byte = System.Text.Encoding.UTF8.GetBytes(strText)
            Dim ms As New System.IO.MemoryStream
            Dim cs As New CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Return Convert.ToBase64String(ms.ToArray())

        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    'The function used to decrypt the text
    Private Function Decrypt(ByVal strText As String, ByVal sDecrKey As String) As String
        Dim byKey() As Byte = {}
        Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
        Dim inputByteArray(strText.Length) As Byte

        Try
            byKey = System.Text.Encoding.UTF8.GetBytes(Left(sDecrKey, 8))
            Dim des As New DESCryptoServiceProvider
            inputByteArray = Convert.FromBase64String(strText)
            Dim ms As New System.IO.MemoryStream
            Dim cs As New CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write)

            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Dim encoding As System.Text.Encoding = System.Text.Encoding.UTF8

            Return encoding.GetString(ms.ToArray())

        Catch ex As Exception
            Return ex.Message
        End Try

    End Function
End Module
