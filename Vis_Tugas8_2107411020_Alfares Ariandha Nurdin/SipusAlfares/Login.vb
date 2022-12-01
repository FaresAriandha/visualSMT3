Public Class Login
    Public Shared objLogin As Pengguna
    Dim AuthStatus As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objLogin = New Pengguna()
    End Sub
    Private Sub BtnSignIn_Click(sender As Object, e As EventArgs) Handles BtnSignIn.Click
        objLogin.GSusername = TxtUsername.Text
        objLogin.GSpassword = TxtPass.Text
        AuthStatus = objLogin.CheckAuth(objLogin.GSusername(), objLogin.GSpassword())

        If objLogin.GSusername.Length = 0 Or objLogin.GSpassword.Length = 0 Then
            MsgBox("You must enter correctly form field", MsgBoxStyle.Critical, "Failure")
        Else
            If AuthStatus = "Login Berhasil" Then
                Loading.Show()
                Dashboard.Show()
                'Me.Close()
            Else
                Dim info As String = AuthStatus
                MsgBox(info, MsgBoxStyle.Critical, "Failure")
            End If
        End If


    End Sub

    Private Sub TxtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPass.KeyPress
        TxtPass.PasswordChar = "*"c
    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        Register.Show()
    End Sub

    Private Sub Login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TxtUsername.Select()
        TxtUsername.Text = ""
        TxtPass.Text = ""
    End Sub
End Class