Imports System.Security.Cryptography

Public Class Pengguna
    Private username
    Private password
    Private TripleDes As New TripleDESCryptoServiceProvider
    Private koleksiUser As New ArrayList()

    Public Sub New()
        koleksiUser.Add({"admin", "admin"})
        koleksiUser.Add({"fares", "fares"})
    End Sub

    Public Property GSusername() As String
        Get
            Return username

        End Get
        Set(ByVal value As String)
            username = value
        End Set
    End Property

    Public Property GSpassword() As String
        Get
            Return password
        End Get
        Set(ByVal value As String)
            password = value
        End Set
    End Property

    Public Function EncryptData(ByVal plainText As String) As String

        'Convert the plaintext string to a byte array
        Dim plainTextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plainText)

        'Create the stream
        Dim ms As New System.IO.MemoryStream
        'Create the encoder to write to the stream
        Dim encStream As New CryptoStream(ms,
                TripleDes.CreateEncryptor(),
                System.Security.Cryptography.CryptoStreamMode.Write)

        'Use the crypto stream to write the byte array to the stream
        encStream.Write(plainTextBytes, 0, plainTextBytes.Length)
        encStream.FlushFinalBlock()

        'Convert the encrypted stream to a printable string.
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function CheckAuth(ByVal username As String, ByVal plainPassword As String) As String
        'Static Password
        'Dim realPassword As String = EncryptData("1234")
        'Dim realUsername As String = "fares"

        For Each akun In koleksiUser

            If String.Compare(username, akun(0)) = 0 And String.Compare(EncryptData(plainPassword), EncryptData(akun(1))) = 0 Then
                Return "Login Berhasil"
            ElseIf String.Compare(username, akun(0)) <> 0 Then
                Return "Username not find"
            Else
                Return "Wrong password"
            End If
        Next


        'MsgBox(String.Join(", ", koleksiUser.ToArray))
    End Function

    Public Function setUserPassKoleksi(userName As String, pass As String, fullName As String)
        'For Each kel In koleksiUser
        '    MsgBox("info")
        '    If userName = kel(0) Then
        '        Return False
        '    End If
        'Next
        'pass = EncryptData(pass)
        koleksiUser.Add({userName, pass, fullName})
        'counter += 1
        'MsgBox(koleksiUser(counter)(0))

        'For kel = 0 To counter
        '    MsgBox(kel)
        '    MsgBox(koleksiUser(kel)(0))
        'Next
        'MsgBox(counter)
        'Return True
    End Function

End Class
