Public Class TambahKoleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Dashboard.dataPerpus = New DataPerpus()
        DatePickTglMasuk.Format = DateTimePickerFormat.Custom
        DatePickTglMasuk.CustomFormat = "yyyy/MM/dd"

    End Sub

    Private Sub BtnAddKoleksi_Click(sender As Object, e As EventArgs) Handles BtnAddKoleksi.Click
        Dashboard.dataPerpus.GSnamaKoleksi = TxtBoxNama.Text
        Dashboard.dataPerpus.GSjenisKoleksi = CBJenisKoleksi.SelectedItem()
        Dashboard.dataPerpus.GSdeskripsiKoleksi = RTBdesc.Text
        Dashboard.dataPerpus.GSpenerbit = TxtBoxPenerbit.Text
        Dashboard.dataPerpus.GStahun = Integer.Parse(TxtBoxTahun.Text)
        Dashboard.dataPerpus.GSrakBuku = TxtBoxLocRak.Text
        Dashboard.dataPerpus.GStglMasuk = DatePickTglMasuk.Value.ToString("dd MMMM yyyy")
        Dashboard.dataPerpus.GSstok = TxtBoxStock.Text
        Dashboard.dataPerpus.resetKategori()


        'Dashboard.dataPerpus.GSlistKoleksi.Add(TxtBoxNama.Text)

        If RBEnglish.Checked Then
            Dashboard.dataPerpus.GSbahasa = RBEnglish.Text
        ElseIf RBIndonesian.Checked Then
            Dashboard.dataPerpus.GSbahasa = RBIndonesian.Text
        End If

        If CBSains.Checked() Then
            Dashboard.dataPerpus.addKategori(CBSains.Text)
        End If

        If CBSosial.Checked() Then
            Dashboard.dataPerpus.addKategori(CBSosial.Text)
        End If

        If CBTeknologi.Checked() Then
            Dashboard.dataPerpus.addKategori(CBTeknologi.Text)
        End If

        If CBBudaya.Checked() Then
            Dashboard.dataPerpus.addKategori(CBBudaya.Text)
        End If

        'MessageBox.Show(Dashboard.dataPerpus.GSnamaKoleksi.Length < )
        'MessageBox.Show(Dashboard.dataPerpus.GSfoto)
        'MessageBox.Show(Dashboard.dataPerpus.GSrakBuku)



        If validationItemData() IsNot Nothing Then
            MsgBox(validationItemData, MsgBoxStyle.Critical, "Kesalahan")
        Else
            InfoTambahKoleksi.Show()
            'Dashboard.dataPerpus.AddKoleksi(Dashboard.dataPerpus.GSnamaKoleksi())
            'Dashboard.ListBoxKoleksi.Items.Add(Dashboard.dataPerpus.GSnamaKoleksi())
            Dim convertedKoleksi = Dashboard.dataPerpus.ConvertKoleksiToString(Dashboard.dataPerpus.GSinfoKategori)
            Dashboard.koleksiData.AddDataKoleksiDatabase(Dashboard.dataPerpus.GSnamaKoleksi,
                                   Dashboard.dataPerpus.GSjenisKoleksi,
                                   Dashboard.dataPerpus.GSdeskripsiKoleksi,
                                   Dashboard.dataPerpus.GSpenerbit,
                                   Dashboard.dataPerpus.GStahun,
                                   Dashboard.dataPerpus.GSrakBuku,
                                   Dashboard.dataPerpus.GStglMasuk,
                                   Dashboard.dataPerpus.GSstok,
                                   Dashboard.dataPerpus.GSbahasa,
                                   convertedKoleksi,
                                   Dashboard.dataPerpus.GSfoto)
            'Dashboard.dataPerpus.GSlistKoleksi.Clear()
            'MsgBox(Dashboard.dataPerpus.getKoleksiDataTable)
            'Dashboard.dataPerpus.GSlistKoleksi.Remove(Dashboard.dataPerpus.GSnamaKoleksi())
        End If

    End Sub

    Public Function validationItemData()
        Dim infoKesalahan As String

        If Dashboard.dataPerpus.GSnamaKoleksi.Length = 0 Then
            infoKesalahan = "Harap Masukkan Nama Koleksinya!!"
            TxtBoxNama.Select()
        ElseIf Dashboard.dataPerpus.GSjenisKoleksi Is Nothing Then
            infoKesalahan = "Harap Masukkan Jenis Koleksinya!!"
            CBJenisKoleksi.Select()
        ElseIf Dashboard.dataPerpus.GSfoto Is Nothing Then
            infoKesalahan = "Harap Masukkan Foto Koleksinya!!"
            openFoto()
        ElseIf Dashboard.dataPerpus.GSdeskripsiKoleksi.Length = 0 Then
            infoKesalahan = "Harap Masukkan Deskripsi Koleksinya!!"
            RTBdesc.Select()
        ElseIf Dashboard.dataPerpus.GSpenerbit.Length = 0 Then
            infoKesalahan = "Harap Masukkan Penerbit Koleksinya!!"
            TxtBoxPenerbit.Select()
        ElseIf Dashboard.dataPerpus.GStahun = 0 Then
            infoKesalahan = "Harap Masukkan Tahun Terbitnya!!"
            TxtBoxTahun.Select()
        ElseIf Dashboard.dataPerpus.GSrakBuku.Length = 0 Then
            infoKesalahan = "Harap Masukkan Lokasi Raknya!!"
            TxtBoxLocRak.Select()
        ElseIf Dashboard.dataPerpus.GStglMasuk.Length = 0 Then
            infoKesalahan = "Harap Masukkan Tanggal Masuk Koleksinya!!"
            TxtBoxTahun.Select()
        ElseIf Dashboard.dataPerpus.GSstok.Length = 0 Then
            infoKesalahan = "Harap Masukkan Stok Koleksinya!!"
            TxtBoxStock.Select()
        ElseIf Dashboard.dataPerpus.GSbahasa Is Nothing Then
            infoKesalahan = "Harap Masukkan Bahasa untuk Koleksinya!!"
        ElseIf Dashboard.dataPerpus.GSinfoKategori.Count() = 0 Then
            infoKesalahan = "Harap Masukkan Kategori untuk Koleksinya!!"
        End If
        Return infoKesalahan
    End Function

    Public Sub openFoto()
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|Image|*.bmp|All Format|*.*"
        OpenFileDialog1.ShowDialog()
        Dim picKoleksiDir As String = OpenFileDialog1.FileName
        If OpenFileDialog1.FileName.Length > 0 Then
            PcbKoleksi.Load(picKoleksiDir)
        End If
        Dashboard.dataPerpus.GSfoto = picKoleksiDir
        Dashboard.dataPerpus.GSfoto = Dashboard.dataPerpus.GSfoto.Replace("\", "/")
    End Sub

    Private Sub BtnAddImage_Click(sender As Object, e As EventArgs) Handles BtnAddImage.Click
        openFoto()
    End Sub

    Private Sub TxtBoxTahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxTahun.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Harap Hanya Masukkan Angka", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub TxtBoxStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxStock.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Harap Hanya Masukkan Angka", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub TxtBoxTahun_Leave(sender As Object, e As EventArgs) Handles TxtBoxTahun.Leave
        If TxtBoxTahun.Text.Length < 1 Then
            TxtBoxTahun.Select()
            MsgBox("Harap Masukkan minimal 1 angka", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub TxtBoxStock_Leave(sender As Object, e As EventArgs) Handles TxtBoxStock.Leave
        If TxtBoxStock.Text.Length < 1 Then
            TxtBoxStock.Select()
            MsgBox("Harap Masukkan minimal 1 angka", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

End Class