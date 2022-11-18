Public Class TugasPertemuan10

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dashboard.dataPerpus = New DataPerpus()
        'UpdateDataTableArrayList()
    End Sub
    Public Sub UpdateDataTableArrayList()
        'DataGridKoleksi.Rows.Clear()

        For Each rowKoleksi In Dashboard.dataPerpus.getKoleksiDataTable()
            Dim dataTable As String() = {rowKoleksi(0), rowKoleksi(10), rowKoleksi(1), rowKoleksi(3), rowKoleksi(4)}
            DataGridKoleksi.Rows.Add(dataTable)
        Next


    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub
End Class