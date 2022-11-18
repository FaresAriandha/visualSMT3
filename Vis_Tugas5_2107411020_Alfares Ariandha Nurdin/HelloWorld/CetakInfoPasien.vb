Public Class InfoPasien
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If Not String.IsNullOrEmpty(FormRegistrasi.GSFoto) Then
            PcbPasien.Load(FormRegistrasi.GSFoto)
            'PcbPasien.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LblName.Text = FormRegistrasi.GSNama()
        LblNIK.Text = FormRegistrasi.GSNIK.Trim
        LblJK.Text = FormRegistrasi.GSJenisKelamin
        LblAddress.Text = FormRegistrasi.GSAlamat
        LblBirth.Text = FormRegistrasi.GSTglLahir
        LblLayanan.Text = FormRegistrasi.GSLayanan
        LblJmlHari.Text = FormRegistrasi.fungsiKamar.SHariInap().ToString() & " Hari"
        LblBiayaInap.Text = "Rp. " & FormRegistrasi.fungsiKamar.HitungBiaya().ToString()

        ListBoxKeluhan.Items.Clear()
        For Each kel In FormRegistrasi.GSKeluhan
            ListBoxKeluhan.Items.Add(kel)
        Next

        FormRegistrasi.GSKeluhan.Clear()

        LblCtnDok.Text = FormRegistrasi.GSCatatan
        'PcbPasien.Image = Image.FromFile(FormRegistrasi.OpenFileDialog1.FileName)
    End Sub

    Private Sub BtnCtkPasienBack_Click(sender As Object, e As EventArgs) Handles BtnCtkPasienBack.Click
        Me.Close()
    End Sub
End Class