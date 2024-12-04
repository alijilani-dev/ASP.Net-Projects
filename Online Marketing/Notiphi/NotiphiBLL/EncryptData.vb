Imports System.Security.Cryptography
Imports System.Text
Public Class clsEncryptData
    Private characterArray() As Char

    Function Encrypt(ByVal strText As String) As Byte()

        'The array of bytes that will contain the encrypted value of strPlainText
        Dim hashedDataBytes As Byte()

        'The encoder class used to convert strPlainText to an array of bytes
        Dim encoder As New UTF8Encoding

        'Create an instance of the MD5CryptoServiceProvider class
        Dim md5Hasher As New MD5CryptoServiceProvider

        'Call ComputeHash, passing in the plain-text string as an array of bytes
        'The return value is the encrypted value, as an array of bytes
        hashedDataBytes = md5Hasher.ComputeHash(encoder.GetBytes(strText))
        Return hashedDataBytes

    End Function

    Public Sub New()
        characterArray = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray
    End Sub

    Private Function GetRandomCharacter() As Char

        Randomize()
        Dim location As Int32 = -1
        While Not (location >= 0 AndAlso location <= Me.characterArray.GetUpperBound(0))
            location = Convert.ToInt32(Me.characterArray.GetUpperBound(0) * Rnd() + 1)
        End While

        Return Me.characterArray(location)

    End Function

    Public Function GenerateRandomPassword(ByVal prmPasswordLength As Integer) As String

        Dim count As Int32
        Dim sb As New StringBuilder
        sb.Capacity = prmPasswordLength

        For count = 0 To prmPasswordLength - 1
            sb.Append(GetRandomCharacter())
        Next count

        If (Not sb Is Nothing) Then
            Return sb.ToString
        End If

        Return String.Empty

    End Function

    '''    'Encrypt the text
    '''Public Function EncryptText(ByVal strText As String) As String
    '''    'Return Encrypt(strText, "&%#@?,:*")
    '''        Return Encrypt(strText, "&%#@?,:*")
    '''End Function

    ''''Decrypt the text 
    '''Public Function DecryptText(ByVal strText As String) As String
    '''    'Return Decrypt(strText, "&%#@?,:*")
    '''        Return Decrypt(strText, "&%#@?,:*")
    '''End Function

    ''''The function used to encrypt the text
    '''Private Function Encrypt(ByVal strText As String, ByVal strEncrKey As String) As String
    '''    Dim byKey() As Byte = {}
    '''    Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}

    '''    Try
    '''        byKey = System.Text.Encoding.UTF8.GetBytes(Left(strEncrKey, 8))

    '''        Dim des As New DESCryptoServiceProvider
    '''        Dim inputByteArray() As Byte = System.Text.Encoding.UTF8.GetBytes(strText)
    '''        Dim ms As New System.IO.MemoryStream
    '''        Dim cs As New CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write)
    '''        cs.Write(inputByteArray, 0, inputByteArray.Length)
    '''        cs.FlushFinalBlock()
    '''        Return Convert.ToBase64String(ms.ToArray())

    '''    Catch ex As Exception
    '''        Return ex.Message
    '''    End Try

    '''End Function

    ''''The function used to decrypt the text
    '''Private Function Decrypt(ByVal strText As String, ByVal sDecrKey As String) As String
    '''    Dim byKey() As Byte = {}
    '''    Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
    '''    Dim inputByteArray(strText.Length) As Byte

    '''    Try
    '''        byKey = System.Text.Encoding.UTF8.GetBytes(Left(sDecrKey, 8))
    '''        Dim des As New DESCryptoServiceProvider
    '''        inputByteArray = Convert.FromBase64String(strText)
    '''        Dim ms As New System.IO.MemoryStream
    '''        Dim cs As New CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write)

    '''        cs.Write(inputByteArray, 0, inputByteArray.Length)
    '''        cs.FlushFinalBlock()
    '''        Dim encoding As System.Text.Encoding = System.Text.Encoding.UTF8

    '''        Return encoding.GetString(ms.ToArray())

    '''    Catch ex As Exception
    '''        Return ex.Message
    '''    End Try

    '''    End Function
    '''    Sub DisplayEncryptedText(ByVal sender As Object, ByVal e As EventArgs)

    '''        Dim md5Hasher As New MD5CryptoServiceProvider

    '''        Dim hashedDataBytes As Byte()
    '''        Dim encoder As New UTF8Encoding

    '''        hashedDataBytes = md5Hasher.ComputeHash(encoder.GetBytes("basheer"))


    '''    End Sub
    '''    Public Function MD5SaltedHashEncryption(ByVal ToEncrypt As String) As Byte()
    '''        Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
    '''        Dim textencoder As UTF8Encoding = New UTF8Encoding

    '''        Dim hashedbytes As Byte()
    '''        Dim saltedhash As Byte()

    '''        hashedbytes = md5.ComputeHash(System.Convert.FromBase64String(ToEncrypt))

    '''        ToEncrypt += System.Convert.ToBase64String(hashedbytes)

    '''        saltedhash = md5.ComputeHash(textencoder.GetBytes(ToEncrypt))

    '''        md5.Clear()
    '''        md5 = Nothing

    '''        Return saltedhash
    '''    End Function



End Class
