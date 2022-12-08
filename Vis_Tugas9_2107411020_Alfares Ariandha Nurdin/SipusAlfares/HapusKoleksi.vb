Public Class HapusKoleksi
    Dim indexItem As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'LblKoleksi.Text = Dashboard.selectedCollection
    End Sub

    Private Sub BtnHapusKoleksi_Click(sender As Object, e As EventArgs) Handles BtnHapusKoleksi.Click
        'Dashboard.procHapus(Dashboard.selectedCollection)

        'For Each item In Dashboard.dataPerpus.getKoleksiDataTable()
        '    If item(0) Is Dashboard.selectedCollection Then
        '        indexItem = Dashboard.dataPerpus.getKoleksiDataTable().IndexOf(item)

        '    End If
        'Nextxxxxxxxxxx

        'Dashboard.dataPerpus.RemoveKoleksiDataTable(indexItem)
        Dashboard.koleksiData.DeleteDataKoleksiByIDDatabase(Dashboard.selectedTableKoleksiDB)

        'Dim removeItem = Dashboard.dataPerpus.getKoleksiDataTable().IndexOf(Dashboard.selectedCollection)
        'MessageBox.Show(removeItem)
        'Dashboard.dataPerpus.RemoveKoleksiDataTable(removeItem)

        Me.Close()
    End Sub
End Class