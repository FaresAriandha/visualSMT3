Public Class InfoTambahKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not String.IsNullOrEmpty(Dashboard.dataPerpus.GSfoto) Then
            PcbInfoKoleksi.Load(Dashboard.dataPerpus.GSfoto)
            'PcbPasien.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LblNamaKoleksi.Text = Dashboard.dataPerpus.GSnamaKoleksi
        LblJenisKoleksi.Text = Dashboard.dataPerpus.GSjenisKoleksi
        LblDeskripsi.Text = Dashboard.dataPerpus.GSdeskripsiKoleksi
        LblPenerbit.Text = Dashboard.dataPerpus.GSpenerbit
        LblTahunTerbit.Text = Dashboard.dataPerpus.GStahun
        LblRak.Text = Dashboard.dataPerpus.GSrakBuku
        LblTglMasuk.Text = Dashboard.dataPerpus.GStglMasuk
        LblStok.Text = Dashboard.dataPerpus.GSstok
        LblBahasa.Text = Dashboard.dataPerpus.GSbahasa

        ListBoxKategori.Items.Clear()
        For Each info_tambah In Dashboard.dataPerpus.GSinfoKategori
            ListBoxKategori.Items.Add(info_tambah)
        Next

        Dim data = String.Join(", ", Dashboard.dataPerpus.GSlistKoleksi.ToArray)
        'MsgBox(data, MsgBoxStyle.Critical, "Kesalahan")


    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub
End Class