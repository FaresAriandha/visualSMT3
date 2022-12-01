Public Class Dashboard
    Public Shared dataPerpus As DataPerpus
    Public Shared selectedCollection As String
    Public Shared selectedTableKoleksi As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataPerpus = New DataPerpus()

    End Sub


    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        TambahKoleksi.Show()
    End Sub

    Private Sub BtnShowFormAddKoleksi_Click(sender As Object, e As EventArgs) Handles BtnShowFormAddKoleksi.Click
        TambahKoleksi.Show()
    End Sub

    Private Sub Dashboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        For Each kel In dataPerpus.GSlistKoleksi
            ListBoxKoleksi.Items.Add(kel)
        Next
        'TugasPertemuan10.UpdateDataTableArrayList()
        UpdateDataTableArrayList()
        'dataPerpus.getKoleksiDataTable.Clear()
        dataPerpus.GSlistKoleksi.Clear()
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

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Dim dataSelected = dataPerpus.getKoleksiDataTable.Item(selectedTableKoleksi)

        dataPerpus.GSnamaKoleksi = dataSelected(0)
        dataPerpus.GSfoto = dataSelected(10)
        dataPerpus.GSjenisKoleksi = dataSelected(1)
        dataPerpus.GSpenerbit = dataSelected(3)
        dataPerpus.GStahun = dataSelected(4)

        Dim dataKoleksi As List(Of String) = dataPerpus.ConvertStringToKoleksi(dataSelected(9))

        For Each info_tambah In dataKoleksi
            dataPerpus.addKategori(info_tambah)
        Next



        InfoTambahKoleksi.Show()
    End Sub

End Class
