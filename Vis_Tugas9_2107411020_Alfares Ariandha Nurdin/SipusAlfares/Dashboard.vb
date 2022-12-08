Public Class Dashboard
    Public Shared dataPerpus As DataPerpus
    Public Shared koleksiData As Koleksi
    Public Shared selectedCollection As String
    Public selectedTableKoleksi As Integer
    Public selectedTableKoleksiDB As Integer
    Public selectedTableKoleksiNama As String
    Dim selectedRow As DataGridViewRow

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataPerpus = New DataPerpus()
        koleksiData = New Koleksi()
        'UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub


    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        TambahKoleksi.Show()
    End Sub

    Private Sub BtnShowFormAddKoleksi_Click(sender As Object, e As EventArgs) Handles BtnShowFormAddKoleksi.Click
        TambahKoleksi.Show()
    End Sub

    Private Sub Dashboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Loading.Close()
        'ListBoxKoleksi.Items.Clear()
        'For Each kel In dataPerpus.GSlistKoleksi
        '    ListBoxKoleksi.Items.Add(kel)
        'Next
        'TugasPertemuan10.UpdateDataTableArrayList()
        'UpdateDataTableArrayList()
        ReloadDataTableDatabase()
        'dataPerpus.getKoleksiDataTable.Clear()
        'dataPerpus.GSlistKoleksi.Clear()
        'UpdateDataArrayList()
    End Sub

    Private Sub BtnShowFormDelKoleksi_Click(sender As Object, e As EventArgs) Handles BtnShowFormDelKoleksi.Click

        selectedCollection = ListBoxKoleksi.SelectedItem()
        If selectedCollection IsNot Nothing Then
            HapusKoleksi.Show()

        Else
            MsgBox("Harap Pilih Koleksi", MsgBoxStyle.Critical, "Kesalahan")

        End If
        'MessageBox.Show(dataPerpus.getKoleksiDataTable()(0)(0))
    End Sub

    Public Sub procHapus(item As String)
        dataPerpus.RemoveKoleksi(item)
        ListBoxKoleksi.Items.Remove(item)

    End Sub

    Private Sub LatihanArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LatihanArrayToolStripMenuItem.Click
        LatihanArray.Show()
    End Sub

    Private Sub TugasPertemuan10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TugasPertemuan10ToolStripMenuItem.Click
        TugasPertemuan10.Show()
    End Sub

    'List Getter and Setter

    Public Sub UpdateDataTableArrayList()
        DataGridKoleksi.Rows.Clear()
        For Each rowKoleksi In dataPerpus.getKoleksiDataTable()
            Dim dataTable As String() = {rowKoleksi(0), rowKoleksi(10), rowKoleksi(9), rowKoleksi(1), rowKoleksi(3), rowKoleksi(4)}
            DataGridKoleksi.Rows.Add(dataTable)
        Next

    End Sub

    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick
        selectedTableKoleksi = DataGridKoleksi.CurrentRow.Index
    End Sub

    Public Sub showSelectedArray()
        Dashboard.dataPerpus.resetKategori()

        Try
            Dim dataSelected As List(Of String) = dataPerpus.getKoleksiDataTable.Item(selectedTableKoleksi)
            dataPerpus.GSnamaKoleksi = dataSelected(0)
            dataPerpus.GSjenisKoleksi = dataSelected(1)
            dataPerpus.GSdeskripsiKoleksi = dataSelected(2)
            dataPerpus.GSpenerbit = dataSelected(3)
            dataPerpus.GStahun = dataSelected(4)
            dataPerpus.GSrakBuku = dataSelected(5)
            dataPerpus.GStglMasuk = dataSelected(6)
            dataPerpus.GSstok = dataSelected(7)
            dataPerpus.GSbahasa = dataSelected(8)
            Dim dataKoleksi As List(Of String) = dataPerpus.ConvertStringToKoleksi(dataSelected(9))

            For Each info_tambah In dataKoleksi
                dataPerpus.addKategori(info_tambah)
            Next
            InfoTambahKoleksi.Show()
        Catch ex As Exception
            MsgBox("Datanya masih Kosong", MsgBoxStyle.Critical, "Failure")
        End Try
    End Sub

    Public Sub showSelectedDB()
        Dim selectedKoleksi As List(Of String) = koleksiData.GetDataKoleksiByIDDatabase(selectedTableKoleksiDB)
        dataPerpus.GSnamaKoleksi = selectedKoleksi(1)
        dataPerpus.GSjenisKoleksi = selectedKoleksi(5)
        dataPerpus.GSdeskripsiKoleksi = selectedKoleksi(3)
        dataPerpus.GSpenerbit = selectedKoleksi(4)
        dataPerpus.GStahun = selectedKoleksi(6)
        dataPerpus.GSrakBuku = selectedKoleksi(7)
        dataPerpus.GStglMasuk = selectedKoleksi(8)
        dataPerpus.GSstok = selectedKoleksi(9)
        dataPerpus.GSbahasa = selectedKoleksi(10)
        Dim dataKoleksi As List(Of String) = dataPerpus.ConvertStringToKoleksi(selectedKoleksi(11))

        For Each info_tambah In dataKoleksi
            dataPerpus.addKategori(info_tambah)
        Next

        dataPerpus.GSfoto = selectedKoleksi(2)

    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        dataPerpus.resetKategori()
        Try
            showSelectedDB()
            InfoTambahKoleksi.Show()

        Catch ex As Exception
            MsgBox("You Must Min. 1 Collection", MsgBoxStyle.Critical, "Failure")
        End Try

    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKoleksiDB.DataSource = koleksiData.GetDataKoleksiDatabase()
    End Sub

    Private Sub DataGridKoleksiDB_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksiDB.CellClick
        Dim index As Integer = e.RowIndex

        selectedRow = DataGridKoleksiDB.Rows(index)
        'MsgBox(selectedRow)
        selectedTableKoleksiDB = selectedRow.Cells(0).Value
        'MsgBox(selectedTableKoleksiDB)


    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        dataPerpus.resetKategori()
        Try

            showSelectedDB()
            EditData.Show()
        Catch ex As Exception
            MsgBox("You Must Min. 1 Collection", MsgBoxStyle.Critical, "Failure")
        End Try

    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
        If selectedTableKoleksiNama IsNot Nothing Then
            HapusKoleksi.LblKoleksi.Text = selectedTableKoleksiNama
            HapusKoleksi.Show()
        Else
            MsgBox("You Must Min. 1 Collection", MsgBoxStyle.Critical, "Failure")
        End If

    End Sub
End Class
