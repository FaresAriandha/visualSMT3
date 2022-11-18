

Public Class Pertemuan5
    Dim colors As DialogResult

    Private Sub BtnChangeColor_Click(sender As Object, e As EventArgs) Handles BtnChangeColor.Click
        colors = ColorDialog1.ShowDialog()
        If colors = Windows.Forms.DialogResult.OK Then
            LblColorChange.ForeColor = ColorDialog1.Color
            LblColorCode.Text = ColorDialog1.Color.ToArgb
            TxtColorCode.Text = ColorDialog1.Color.ToArgb
            PnlColorChange.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub BtnChangeGreen_Click(sender As Object, e As EventArgs) Handles BtnChangeGreen.Click
        LblColorChange.ForeColor = Color.FromArgb("-16711808")
    End Sub
End Class