Public Class InfoPasien
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If Not String.IsNullOrEmpty(FormRegistrasi.foto_pasien) Then
            PcbPasien.Load(FormRegistrasi.foto_pasien)
            PcbPasien.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LblName.Text = FormRegistrasi.Nama
        LblNIK.Text = FormRegistrasi.NIK.Trim
        LblJK.Text = FormRegistrasi.jenisKelamin
        LblAddress.Text = FormRegistrasi.Alamat
        LblBirth.Text = FormRegistrasi.tanggal_lahir
        LblLayanan.Text = FormRegistrasi.layanan_value

        ListBoxKeluhan.Items.Clear()
        For Each kel In FormRegistrasi.keluhan_list
            ListBoxKeluhan.Items.Add(kel)
        Next

        FormRegistrasi.keluhan_list.Clear()

        LblCtnDok.Text = FormRegistrasi.catatan_dokter
        'PcbPasien.Image = Image.FromFile(FormRegistrasi.OpenFileDialog1.FileName)
    End Sub

End Class