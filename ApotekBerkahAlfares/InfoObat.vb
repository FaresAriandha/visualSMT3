Public Class InfoObat

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        LblNamaObat.Text = Dashboard.kelasApotek.GSNamaObat
        LblTipeKonsumsi.Text = Dashboard.kelasApotek.GSTipeKonsumsi
        LblTglMasuk.Text = Dashboard.kelasApotek.GSTglMasuk
        LblTglKadaluarsa.Text = Dashboard.kelasApotek.GSTglKadaluarsa
        LblStok.Text = Dashboard.kelasApotek.GSStok
        LblHargaSatuan.Text = Dashboard.kelasApotek.GSHargaSatuan
        LblSatuan.Text = Dashboard.kelasApotek.GSSatuan

        For Each info In Dashboard.kelasApotek.GSInfoTambahan
            ListBoxInfo.Items.Add(info)
        Next

        PCBObatInfo.Load(Dashboard.kelasApotek.GSFotoObat)
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        ListBoxInfo.Items.Clear()
        Me.Close()
    End Sub
End Class