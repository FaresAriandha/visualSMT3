Public Class FormRegistrasi
    Public Shared Kamar As Integer = 100
    Public NIK As String
    Public Nama As String
    Public Alamat As String
    Public jenisKelamin As String
    Public openFile As New OpenFileDialog

    Dim maxLengthAlamat = 100
    Dim currLengthAlamat = 0

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        LblJmlKmr.Text = Kamar.ToString()
        LblTotalCharAlamat.Text = currLengthAlamat.ToString()
    End Sub

    Private Sub BtnAddRoom_Click(sender As Object, e As EventArgs) Handles BtnAddRoom.Click
        Dim tambah_kamar = New FormAddRoom()
        FormAddRoom.Show()
    End Sub

    Private Sub FormRegistrasi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LblJmlKmr.Text = Kamar
    End Sub


    Private Sub BtnAddPatient_Click(sender As Object, e As EventArgs) Handles BtnAddPatient.Click
        NIK = TxtBoxNIK.Text
        NIK = NIK.Trim
        Nama = TxtBoxNama.Text
        Alamat = RTB_Alamat.Text
        If Nama.Length > 0 And NIK.Length > 0 And Alamat.Length > 0 And Not jenisKelamin Is Nothing Then
            InfoPasien.Show()
        Else
            MsgBox("Harap Lengkapi Formnya dengan data benar yak hehe", MsgBoxStyle.Critical, "Kesalahan")
        End If


    End Sub

    Private Sub RdMale_CheckedChanged(sender As Object, e As EventArgs) Handles RdMale.CheckedChanged
        jenisKelamin = "Laki-laki"
    End Sub

    Private Sub RdFemale_CheckedChanged(sender As Object, e As EventArgs) Handles RdFemale.CheckedChanged
        jenisKelamin = "Perempuan"
    End Sub

    Private Sub TxtBoxNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxNIK.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Harap Hanya Masukkan Angka", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub TxtBoxNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Harap Hanya Masukkan String", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub TxtBoxNama_Leave(sender As Object, e As EventArgs) Handles TxtBoxNama.Leave
        If TxtBoxNama.Text.Length < 1 Then
            TxtBoxNama.Select()
            MsgBox("Harap Masukkan minimal 1 string", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub TxtBoxNIK_Leave(sender As Object, e As EventArgs) Handles TxtBoxNIK.Leave
        If TxtBoxNIK.Text.Length < 1 Then
            TxtBoxNIK.Select()
            MsgBox("Harap Masukkan minimal 1 angka", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub RTB_Alamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RTB_Alamat.KeyPress
        If Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            currLengthAlamat += 1
        ElseIf e.KeyChar = Chr(Keys.Back) And currLengthAlamat > 0 Then
            currLengthAlamat -= 1
        ElseIf e.KeyChar = Chr(Keys.Delete) And currLengthAlamat > 0 Then
            currLengthAlamat -= 1
            LblTotalCharAlamat.Text = currLengthAlamat.ToString()
        End If

        If RTB_Alamat.Text.Length >= maxLengthAlamat Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                currLengthAlamat = 100
                MsgBox("Alamat tidak boleh > 100 karakter yakkk", MsgBoxStyle.Critical, "Kesalahan")
            End If
        End If

        LblTotalCharAlamat.Text = currLengthAlamat.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openFile.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If openFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFile.FileName)

        End If
    End Sub
End Class
