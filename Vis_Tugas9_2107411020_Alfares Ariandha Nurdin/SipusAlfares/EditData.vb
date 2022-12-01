Public Class EditData
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not String.IsNullOrEmpty(Dashboard.dataPerpus.GSfoto) Then
            PcbKoleksi.Load(Dashboard.dataPerpus.GSfoto)
            'PcbPasien.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        TxtBoxNama.Text = Dashboard.dataPerpus.GSnamaKoleksi
        CBJenisKoleksi.SelectedItem = Dashboard.dataPerpus.GSjenisKoleksi
        RTBdesc.Text = Dashboard.dataPerpus.GSdeskripsiKoleksi
        TxtBoxPenerbit.Text = Dashboard.dataPerpus.GSpenerbit
        TxtBoxTahun.Text = Dashboard.dataPerpus.GStahun
        TxtBoxLocRak.Text = Dashboard.dataPerpus.GSrakBuku
        DatePickTglMasuk.Text = Dashboard.dataPerpus.GStglMasuk
        TxtBoxStock.Text = Dashboard.dataPerpus.GSstok

        If Dashboard.dataPerpus.GSbahasa() = "Bahasa Indonesia" Then
            RBIndonesian.Checked = True
        Else
            RBEnglish.Checked = True
        End If


        For Each info_tambah In Dashboard.dataPerpus.GSinfoKategori
            If info_tambah = "Sains" Then
                CBSains.Checked = True
            ElseIf info_tambah = "Sosial" Then
                CBSosial.Checked = True
            ElseIf info_tambah = "Teknologi" Then
                CBTeknologi.Checked = True
            ElseIf info_tambah = "Budaya" Then
                CBBudaya.Checked = True
            End If
        Next

        Dashboard.dataPerpus.resetKategori()
    End Sub

    Private Sub BtnUpdateImage_Click(sender As Object, e As EventArgs) Handles BtnUpdateImage.Click
        TambahKoleksi.openFoto()
    End Sub

    Private Sub BtnUpdateKoleksi_Click(sender As Object, e As EventArgs) Handles BtnUpdateKoleksi.Click
        Dashboard.dataPerpus.GSnamaKoleksi = TxtBoxNama.Text.ToString()
        Dashboard.dataPerpus.GSjenisKoleksi = CBJenisKoleksi.SelectedItem().ToString()
        Dashboard.dataPerpus.GSdeskripsiKoleksi = RTBdesc.Text.ToString()
        Dashboard.dataPerpus.GSpenerbit = TxtBoxPenerbit.Text.ToString()
        Dashboard.dataPerpus.GStahun = TxtBoxTahun.Text
        Dashboard.dataPerpus.GSrakBuku = TxtBoxLocRak.Text.ToString()
        Dashboard.dataPerpus.GStglMasuk = DatePickTglMasuk.Value.ToString("yyyy/MM/dd")
        Dashboard.dataPerpus.GSstok = Integer.Parse(TxtBoxStock.Text)
        Dashboard.dataPerpus.resetKategori()
        'Dashboard.dataPerpus.GSlistKoleksi.Add(TxtBoxNama.Text)
        'InfoTambahKoleksi.ListBoxKategori.Items.Clear()

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



        If TambahKoleksi.validationItemData() IsNot Nothing Then
            MsgBox(TambahKoleksi.validationItemData(), MsgBoxStyle.Critical, "Kesalahan")
        Else

            'Dashboard.dataPerpus.AddKoleksi(Dashboard.dataPerpus.GSnamaKoleksi())
            'Dashboard.ListBoxKoleksi.Items.Add(Dashboard.dataPerpus.GSnamaKoleksi())
            'InfoTambahKoleksi.ListBoxKategori.Items.Clear()
            Dim convertedKoleksi = Dashboard.dataPerpus.ConvertKoleksiToString(Dashboard.dataPerpus.GSinfoKategori)
            MsgBox(Dashboard.selectedTableKoleksiDB)
            'MsgBox(Dashboard.dataPerpus.GSjenisKoleksi)
            Dashboard.koleksiData.UpdateDataKoleksiByIDDatabase(
                                   Dashboard.selectedTableKoleksiDB,
                                   Dashboard.dataPerpus.GSnamaKoleksi,
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

            InfoTambahKoleksi.Show()
            Dashboard.dataPerpus.GSlistKoleksi.Clear()

            'MsgBox(Dashboard.dataPerpus.getKoleksiDataTable)
            'Dashboard.dataPerpus.GSlistKoleksi.Remove(Dashboard.dataPerpus.GSnamaKoleksi())
        End If
    End Sub
End Class