Imports System.IO

Public Class FormRegistrasi
    Public Shared Kamar As Integer = 100
    Public Shared foto_pasien
    Public Shared NIK
    Public Shared Nama
    Public Shared Alamat
    Public Shared jenisKelamin As String
    Public Shared tanggal_lahir
    Public Shared layanan_value
    Public Shared catatan_dokter
    Public Shared keluhan_list As New List(Of String)
    Dim layanan As New List(Of String) From {"Inap", "Poliklinik", "Spesialis"}

    Dim maxLengthAlamat = 100
    Dim currLengthAlamat = 0

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        LblJmlKmr.Text = Kamar.ToString()
        LblTotalCharAlamat.Text = currLengthAlamat.ToString()
        ComboBoxLyn.DataSource = layanan
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
        tanggal_lahir = DatePickTanggalLahir.Value.ToString("dd MMMM yyyy")
        layanan_value = ComboBoxLyn.SelectedItem()
        catatan_dokter = RTBoxCatatan.Text
        foto_pasien = OpenFileDialog1.FileName

        '' Check Checkbox Value
        '' ====================


        If ChkPusing.Checked() Then
            keluhan_list.Add(ChkPusing.Text)
        End If
        If ChkMual.Checked() Then
            keluhan_list.Add(ChkMual.Text)
        End If
        If ChkDemam.Checked() Then
            keluhan_list.Add(ChkDemam.Text)

        End If

        '' Kurangi Jumlah Kamar
        '' ===================

        Kamar -= 1


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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnOpenFoto.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|Image|*.bmp|All Format|*.*"
        OpenFileDialog1.ShowDialog()
        PicFoto.Load(OpenFileDialog1.FileName)
        'If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    PicFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        'End If
    End Sub

    Private Sub BtnKeluhan_Click(sender As Object, e As EventArgs) Handles BtnKeluhan.Click
        KeluhanPasien.Show()
    End Sub

    Private Sub BtnDate_Click(sender As Object, e As EventArgs) Handles BtnDate.Click
        MsgBox(DatePickTanggalLahir.Value.ToString("dd-MMMM-yyyy"), MsgBoxStyle.OkOnly, "Show Date")
    End Sub

    Private Sub BtnTime_Click(sender As Object, e As EventArgs) Handles BtnTime.Click
        MsgBox(TimePickerTime.Value.ToShortTimeString, MsgBoxStyle.OkOnly, "Show Time")
    End Sub

    Private Sub BtnCurrTime_Click(sender As Object, e As EventArgs) Handles BtnCurrTime.Click
        Dim current_time = DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss")
        MsgBox(current_time, MsgBoxStyle.OkOnly, "Show Time")
    End Sub

    Private Sub TambahKamarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKamarToolStripMenuItem.Click
        FormAddRoom.Show()
    End Sub

    Private Sub KeluhanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluhanToolStripMenuItem.Click
        KeluhanPasien.Show()
    End Sub

    Private Sub BtnOpenCatatan_Click(sender As Object, e As EventArgs) Handles BtnOpenCatatan.Click
        Dim fileReader As System.IO.StreamReader
        OpenFileDialog2.InitialDirectory = "D:\PNJ\TI 2021-2025\SEM 3\Pemrograman Visual\Latihan\TXT"
        OpenFileDialog2.Title = "Buka Catatan Dokter"
        OpenFileDialog2.Filter = "Text File [*.txt]|*.txt|All Files [*.*]|*.*"
        If OpenFileDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
            OpenFileDialog2.OpenFile()
            fileReader = File.OpenText(OpenFileDialog2.FileName)
            RTBoxCatatan.Text = fileReader.ReadToEnd
            fileReader.Close()
        End If
    End Sub

    Private Sub Pertemuan5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pertemuan5ToolStripMenuItem.Click
        Pertemuan5.Show()
    End Sub

    Private Sub Pertemuan6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pertemuan6ToolStripMenuItem.Click
        Pertemuan_6.Show()
    End Sub

End Class
