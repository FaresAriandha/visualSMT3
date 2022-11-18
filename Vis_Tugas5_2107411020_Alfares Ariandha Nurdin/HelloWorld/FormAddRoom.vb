Public Class FormAddRoom
    Public totalAddKamar As Integer = 0

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FormRegistrasi.fungsiKamar = New FungsiKamar()
        LblCurrRoom.Text = FormRegistrasi.Kamar.ToString()
        Txt_FAR_Total.Text = totalAddKamar
        If totalAddKamar < 1 Then
            Btn_FAR_Remove.Enabled = True
        End If
    End Sub

    Private Sub Btn_FAR_Remove_Click(sender As Object, e As EventArgs) Handles Btn_FAR_Remove.Click
        totalAddKamar = totalAddKamar - 1
        Txt_FAR_Total.Text = totalAddKamar


        If totalAddKamar < 1 Then
            Btn_FAR_Remove.Enabled = False
        End If
    End Sub

    Private Sub Btn_FAR_Add_Click(sender As Object, e As EventArgs) Handles Btn_FAR_Add.Click
        totalAddKamar = totalAddKamar + 1
        Txt_FAR_Total.Text = totalAddKamar


        If totalAddKamar >= 1 Then
            Btn_FAR_Remove.Enabled = True
        End If
    End Sub

    Private Sub Btn_FAR_AddRoom_Click(sender As Object, e As EventArgs) Handles Btn_FAR_AddRoom.Click
        ' FormRegistrasi.Kamar += totalAddKamar
        FormRegistrasi.fungsiKamar.GSJumlahKamar = FormRegistrasi.Kamar
        FormRegistrasi.Kamar = FormRegistrasi.fungsiKamar.TambahKamar(totalAddKamar)
        Me.Close()
    End Sub

    Private Sub BtnARBack_Click(sender As Object, e As EventArgs) Handles BtnARBack.Click
        Me.Close()
    End Sub
End Class