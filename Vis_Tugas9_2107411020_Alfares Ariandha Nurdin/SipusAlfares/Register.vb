Public Class Register
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Login.objLogin = New Pengguna()
    End Sub
    Private Sub BtnMasuk_Click(sender As Object, e As EventArgs) Handles BtnMasuk.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click
        Login.objLogin.GSusername = TxtUsernameReg.Text
        Login.objLogin.GSpassword = TxtPassReg.Text
        Login.objLogin.setUserPassKoleksi(Login.objLogin.GSusername(), Login.objLogin.GSpassword(), TxtFullNameReg.Text)
        'If status = True Then
        '    MsgBox("Registrasi Berhasil", MsgBoxStyle.OkOnly, "Sukses")
        'Else
        '    MsgBox("Registrasi Gagal", MsgBoxStyle.Critical, "Gagal")
        'End If
        TxtFullNameReg.Select()
        TxtFullNameReg.Text = ""
        TxtUsernameReg.Text = ""
        TxtPassReg.Text = ""
        'Login.Show()
        'Me.Close()
    End Sub

    Private Sub Register_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TxtFullNameReg.Select()
        TxtFullNameReg.Text = ""
        TxtUsernameReg.Text = ""
        TxtPassReg.Text = ""
        'Dim login = New Login()
        'login.Close()
    End Sub

    Private Sub TxtPassReg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassReg.KeyPress
        TxtPassReg.PasswordChar = "*"c
    End Sub
End Class