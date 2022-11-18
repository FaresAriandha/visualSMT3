Public Class Dashboard
    Public Shared kelasApotek As fungsiApotek

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        kelasApotek = New fungsiApotek()
    End Sub


    Private Sub BtnShowInfo_Click(sender As Object, e As EventArgs) Handles BtnShowInfo.Click
        kelasApotek.GSNamaObat = TxtNamaObat.Text
        kelasApotek.GSTglMasuk = DTPMasuk.Value.ToString("dd MMMM yyyy")
        kelasApotek.GSTglKadaluarsa = DTPKadaluarsa.Value.ToString("dd MMMM yyyy")
        kelasApotek.GSStok = TxtStok.Text
        kelasApotek.GSSatuan = ComBoxSatuan.SelectedItem()
        kelasApotek.GSHargaSatuan = TxtHargaSatuan.Text
        kelasApotek.GSFotoObat = OpenFileDialog1.FileName

        kelasApotek.GSInfoTambahan.Clear()

        If CBResepDokter.Checked() Then
            kelasApotek.GSInfoTambahan.Add(CBResepDokter.Text)
        End If

        If CBEfekSamping.Checked() Then
            kelasApotek.GSInfoTambahan.Add(CBEfekSamping.Text)
        End If

        If CBRacikan.Checked() Then
            kelasApotek.GSInfoTambahan.Add(CBRacikan.Text)
        End If


        If kelasApotek.GSNamaObat.Length = 0 Or kelasApotek.GSTglKadaluarsa.Length = 0 Or kelasApotek.GSHargaSatuan.Length = 0 Or kelasApotek.GSSatuan Is Nothing Then
            MsgBox("Harap lengkap semuanya dengan benar yaa", MsgBoxStyle.Critical, "Peringatan")
        Else
            InfoObat.Show()
            kelasApotek.GSListObat.Add(kelasApotek.GSNamaObat)
        End If


    End Sub



    Private Sub Dashboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        For Each obat In kelasApotek.GSListObat
            ListBoxObat.Items.Add(obat)
        Next

        kelasApotek.GSListObat.Clear()
    End Sub

    Private Sub BtnAddGambar_Click(sender As Object, e As EventArgs) Handles BtnAddGambar.Click
        OpenFileDialog1.InitialDirectory = "~/Downloads/"
        OpenFileDialog1.Title = "Cari Gambar"
        OpenFileDialog1.Filter = "Image JPG|*.jpg|Image PNG|*.png|Image JPEG|*.jpeg|Image BMP|*.bmp"
        OpenFileDialog1.ShowDialog()

        PCBobatDashboard.Load(OpenFileDialog1.FileName)

    End Sub

    Private Sub RDRutin_CheckedChanged(sender As Object, e As EventArgs) Handles RDRutin.CheckedChanged
        kelasApotek.GSTipeKonsumsi = RDRutin.Text
    End Sub

    Private Sub RDSegera_CheckedChanged(sender As Object, e As EventArgs) Handles RDSegera.CheckedChanged
        kelasApotek.GSTipeKonsumsi = RDSegera.Text
    End Sub

    Private Sub TxtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStok.KeyPress
        If Not Char.IsNumber(e.KeyChar) And e.KeyChar <> Chr(Keys.Delete) And e.KeyChar <> Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Harap isi dengan angka yaaa", MsgBoxStyle.Critical, "Peringatan")
        End If
    End Sub

    Private Sub TxtHargaSatuan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHargaSatuan.KeyPress
        If Not Char.IsNumber(e.KeyChar) And e.KeyChar <> Chr(Keys.Delete) And e.KeyChar <> Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Harap isi dengan angka yaaa", MsgBoxStyle.Critical, "Peringatan")
        End If
    End Sub
End Class