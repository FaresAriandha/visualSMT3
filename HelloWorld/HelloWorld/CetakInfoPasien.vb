Public Class InfoPasien
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblName.Text = FormRegistrasi.Nama
        LblNIK.Text = FormRegistrasi.NIK.Trim
        LblJK.Text = FormRegistrasi.jenisKelamin
        LblAddress.Text = FormRegistrasi.Alamat

        PcbPasien.Image = Image.FromFile(FormRegistrasi.openFile.FileName)
    End Sub

End Class