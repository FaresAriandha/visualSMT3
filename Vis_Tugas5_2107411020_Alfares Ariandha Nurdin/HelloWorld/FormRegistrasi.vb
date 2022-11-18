Imports System.IO

Public Class FormRegistrasi
    Public Shared Kamar As Integer = 100
    Private foto_pasien
    Private NIK
    Private Nama
    Private Alamat
    Private jenisKelamin As String
    Private tanggal_lahir
    Private layanan_value
    Private catatan_dokter
    Private keluhan_list As New List(Of String)
    Dim layanan As New List(Of String) From {"Inap", "Poliklinik", "Spesialis"}

    Public Shared fungsiKamar As FungsiKamar

    Dim maxLengthAlamat = 100
    Dim currLengthAlamat = 0

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        fungsiKamar = New FungsiKamar()
        ' LblJmlKmr.Text = Kamar
        'LblJmlKmr.Text = fungsiKamar.GSJumlahKamar
        LblTotalCharAlamat.Text = currLengthAlamat.ToString()
        ComboBoxLyn.DataSource = layanan
    End Sub

    Private Sub BtnAddRoom_Click(sender As Object, e As EventArgs) Handles BtnAddRoom.Click
        Dim tambah_kamar = New FormAddRoom()
        FormAddRoom.Show()
    End Sub

    Private Sub FormRegistrasi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' LblJmlKmr.Text = Kamar
        fungsiKamar.GSJumlahKamar = Kamar
        LblJmlKmr.Text = fungsiKamar.GSJumlahKamar
    End Sub


    Private Sub BtnAddPatient_Click(sender As Object, e As EventArgs) Handles BtnAddPatient.Click
        GSNIK = TxtBoxNIK.Text
        GSNIK = NIK.Trim
        GSNama = TxtBoxNama.Text
        GSAlamat = RTB_Alamat.Text
        GSTglLahir = DatePickTanggalLahir.Value.ToString("dd MMMM yyyy")
        GSLayanan = ComboBoxLyn.SelectedItem()
        GSCatatan = RTBoxCatatan.Text
        GSFoto = OpenFileDialog1.FileName

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

        GSKeluhan = keluhan_list

        '' Kurangi Jumlah Kamar
        '' ===================




        If GSNama.Length > 0 And GSNIK.Length > 0 And GSAlamat.Length > 0 And Not GSJenisKelamin Is Nothing And TxtHariInap.Text.Length > 0 Then
            TxtHariInap.Text = ""
            LblTotalBiaya.Text = "Harap isi"
            InfoPasien.Show()
            Kamar -= 1
        Else
            keluhan_list.Clear()
            MsgBox("Harap Lengkapi Formnya dengan data benar yak hehe", MsgBoxStyle.Critical, "Kesalahan")
        End If


    End Sub

    Private Sub RdMale_CheckedChanged(sender As Object, e As EventArgs) Handles RdMale.CheckedChanged
        GSJenisKelamin = "Laki-laki"
    End Sub

    Private Sub RdFemale_CheckedChanged(sender As Object, e As EventArgs) Handles RdFemale.CheckedChanged
        GSJenisKelamin = "Perempuan"
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


    Private Sub TxtHariInap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHariInap.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Harap Hanya Masukkan Angka", MsgBoxStyle.Critical, "Kesalahan")
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

    Private Sub TxtHariInap_Leave(sender As Object, e As EventArgs) Handles TxtHariInap.Leave
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

    Private Sub BtnHitungBiaya_Click(sender As Object, e As EventArgs) Handles BtnHitungBiaya.Click
        If TxtHariInap.Text.Length > 0 Then
            fungsiKamar.SHariInap = Integer.Parse(TxtHariInap.Text)
            Dim biaya As Integer = fungsiKamar.HitungBiaya()
            LblTotalBiaya.Text = "Rp. " & biaya
        End If
    End Sub

    Public Property GSNama() As String
        Get
            Return Nama
        End Get
        Set(ByVal value As String)
            Nama = value
        End Set
    End Property


    Public Property GSNIK() As String
        Get
            Return NIK
        End Get
        Set(ByVal value As String)
            NIK = value
        End Set
    End Property

    Public Property GSJenisKelamin() As String
        Get
            Return jenisKelamin
        End Get
        Set(ByVal value As String)
            jenisKelamin = value
        End Set
    End Property

    Public Property GSAlamat() As String
        Get
            Return Alamat
        End Get
        Set(ByVal value As String)
            Alamat = value
        End Set
    End Property

    Public Property GSTglLahir() As String
        Get
            Return tanggal_lahir
        End Get
        Set(ByVal value As String)
            tanggal_lahir = value
        End Set
    End Property


    Public Property GSLayanan() As String
        Get
            Return layanan_value
        End Get
        Set(ByVal value As String)
            layanan_value = value
        End Set
    End Property

    Public Property GSCatatan() As String
        Get
            Return catatan_dokter
        End Get
        Set(ByVal value As String)
            catatan_dokter = value
        End Set
    End Property

    Public Property GSFoto() As String
        Get
            Return foto_pasien
        End Get
        Set(ByVal value As String)
            foto_pasien = value
        End Set
    End Property

    Public Property GSKeluhan() As List(Of String)
        Get
            Return keluhan_list
        End Get
        Set(ByVal value As List(Of String))
            keluhan_list = value
        End Set
    End Property

    Private Sub FormRegistrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblTarifInap.Text = "Rp." & fungsiKamar.GSTarifInap() & " /Malam"
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub DatePickTanggalLahir_ValueChanged(sender As Object, e As EventArgs) Handles DatePickTanggalLahir.ValueChanged

    End Sub
End Class
