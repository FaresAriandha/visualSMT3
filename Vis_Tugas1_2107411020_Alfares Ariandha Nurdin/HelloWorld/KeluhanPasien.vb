Public Class KeluhanPasien
    Dim keluhan As String = ""
    Dim keluhan_arrlist As New List(Of String)
    Dim keluhan_arrlist_id As New List(Of String)
    Dim layanan As New List(Of String) From {"Inap", "Poliklinik", "Spesialis"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxLayanan.DataSource = layanan
    End Sub

    Private Sub BtnShowKeluhan_Click(sender As Object, e As EventArgs) Handles BtnShowKeluhan.Click
        If ChkPusing.Checked() Then
            keluhan += (ChkPusing.Text + " ")
            keluhan_arrlist.Add(ChkPusing.Text)
        End If
        If ChkMual.Checked() Then
            keluhan += (ChkMual.Text + " ")
            keluhan_arrlist.Add(ChkMual.Text)
        End If
        If ChkDemam.Checked() Then
            keluhan += (ChkDemam.Text + " ")
            keluhan_arrlist.Add(ChkDemam.Text)

        End If

        MsgBox(keluhan, MsgBoxStyle.OkOnly, "Info")

        Dim keluhan_str = String.Join(" ", keluhan_arrlist.ToArray)

        MsgBox(keluhan_str, MsgBoxStyle.OkOnly, "Info")

        keluhan = ""

        keluhan_arrlist.Clear()

    End Sub

    Private Sub BtnTransfer_Click(sender As Object, e As EventArgs) Handles BtnTransfer.Click
        ListBoxKeluhan.Items.Clear()

        If ChkPusing.Checked() Then
            keluhan_arrlist.Add(ChkPusing.Text)
        End If
        If ChkMual.Checked() Then
            keluhan_arrlist.Add(ChkMual.Text)
        End If
        If ChkDemam.Checked() Then
            keluhan_arrlist.Add(ChkDemam.Text)

        End If

        For Each kel In keluhan_arrlist
            ListBoxKeluhan.Items.Add(kel)
        Next

        keluhan_arrlist.Clear()
    End Sub

    Private Sub BtnToLsb2_Click(sender As Object, e As EventArgs) Handles BtnToLsb2.Click

        Dim add_item = TxtBoxLsb2.Text
        LsbKeluhan2.Items.Add(add_item)
    End Sub

    Private Sub BtnSelectedItem_Click(sender As Object, e As EventArgs) Handles BtnSelectedItem.Click
        MsgBox(LsbKeluhan2.SelectedItem(), MsgBoxStyle.OkOnly, "Show Keluhan")
    End Sub

    Private Sub BtnShowCHKLSBX_Click(sender As Object, e As EventArgs) Handles BtnShowCHKLSBX.Click
        For i = 0 To CheckedListBoxKeluhan.Items.Count - 1
            Dim Item As Object = CheckedListBoxKeluhan.Items(i)

            If CheckedListBoxKeluhan.GetItemChecked(i) Then
                keluhan_arrlist.Add(CheckedListBoxKeluhan.Items(i))
            End If
        Next

        Dim keluhan_str2 = String.Join(", ", keluhan_arrlist.ToArray)

        MsgBox(keluhan_str2, MsgBoxStyle.OkOnly, "Info")
        keluhan_arrlist.Clear()
    End Sub

    Private Sub BtnListCheck_Click(sender As Object, e As EventArgs) Handles BtnListCheck.Click
        ' unchecked All item, (Reset Selected Item)

        For i As Integer = 0 To CheckedListBoxKeluhan.Items.Count - 1
            CheckedListBoxKeluhan.SetItemChecked(i, False)
        Next

        If ChkPusing.Checked() Then
            keluhan_arrlist_id.Add(0)
        End If
        If ChkMual.Checked() Then
            keluhan_arrlist_id.Add(1)
        End If
        If ChkDemam.Checked() Then
            keluhan_arrlist_id.Add(2)
        End If

        For Each kel In keluhan_arrlist_id
            'MessageBox.Show(kel)
            CheckedListBoxKeluhan.SetItemChecked(kel, True)
        Next

        keluhan_arrlist_id.Clear()

    End Sub

    Private Sub BtnComboBox_Click(sender As Object, e As EventArgs) Handles BtnComboBox.Click
        Dim layanan_item = ComboBoxLayanan.SelectedItem()
        MsgBox(layanan_item, MsgBoxStyle.OkOnly, "Info")
    End Sub
End Class