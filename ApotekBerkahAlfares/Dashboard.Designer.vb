<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBoxObat = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PCBobatDashboard = New System.Windows.Forms.PictureBox()
        Me.BtnAddGambar = New System.Windows.Forms.Button()
        Me.BtnShowInfo = New System.Windows.Forms.Button()
        Me.TxtNamaObat = New System.Windows.Forms.TextBox()
        Me.TxtStok = New System.Windows.Forms.TextBox()
        Me.TxtHargaSatuan = New System.Windows.Forms.TextBox()
        Me.DTPMasuk = New System.Windows.Forms.DateTimePicker()
        Me.DTPKadaluarsa = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RDSegera = New System.Windows.Forms.RadioButton()
        Me.RDRutin = New System.Windows.Forms.RadioButton()
        Me.ComBoxSatuan = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CBRacikan = New System.Windows.Forms.CheckBox()
        Me.CBEfekSamping = New System.Windows.Forms.CheckBox()
        Me.CBResepDokter = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PCBobatDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(21, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List Obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(273, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Form Tambah Obat"
        '
        'ListBoxObat
        '
        Me.ListBoxObat.FormattingEnabled = True
        Me.ListBoxObat.ItemHeight = 15
        Me.ListBoxObat.Location = New System.Drawing.Point(21, 60)
        Me.ListBoxObat.Name = "ListBoxObat"
        Me.ListBoxObat.Size = New System.Drawing.Size(163, 334)
        Me.ListBoxObat.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(273, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama Obat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(273, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tipe Konsumsi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(273, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tanggal Masuk"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(273, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tanggal Kadaluarsa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(273, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Stok Awal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(273, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 21)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Satuan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(273, 348)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 21)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Harga Satuan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(273, 382)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 21)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Info Tambahan"
        '
        'PCBobatDashboard
        '
        Me.PCBobatDashboard.Location = New System.Drawing.Point(654, 18)
        Me.PCBobatDashboard.Name = "PCBobatDashboard"
        Me.PCBobatDashboard.Size = New System.Drawing.Size(119, 132)
        Me.PCBobatDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCBobatDashboard.TabIndex = 11
        Me.PCBobatDashboard.TabStop = False
        '
        'BtnAddGambar
        '
        Me.BtnAddGambar.Location = New System.Drawing.Point(654, 162)
        Me.BtnAddGambar.Name = "BtnAddGambar"
        Me.BtnAddGambar.Size = New System.Drawing.Size(119, 23)
        Me.BtnAddGambar.TabIndex = 12
        Me.BtnAddGambar.Text = "Tambah Gambar"
        Me.BtnAddGambar.UseVisualStyleBackColor = True
        '
        'BtnShowInfo
        '
        Me.BtnShowInfo.Location = New System.Drawing.Point(654, 455)
        Me.BtnShowInfo.Name = "BtnShowInfo"
        Me.BtnShowInfo.Size = New System.Drawing.Size(119, 23)
        Me.BtnShowInfo.TabIndex = 13
        Me.BtnShowInfo.Text = "Info Obat"
        Me.BtnShowInfo.UseVisualStyleBackColor = True
        '
        'TxtNamaObat
        '
        Me.TxtNamaObat.Location = New System.Drawing.Point(400, 58)
        Me.TxtNamaObat.Name = "TxtNamaObat"
        Me.TxtNamaObat.Size = New System.Drawing.Size(207, 23)
        Me.TxtNamaObat.TabIndex = 14
        '
        'TxtStok
        '
        Me.TxtStok.Location = New System.Drawing.Point(400, 273)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.Size = New System.Drawing.Size(207, 23)
        Me.TxtStok.TabIndex = 15
        '
        'TxtHargaSatuan
        '
        Me.TxtHargaSatuan.Location = New System.Drawing.Point(400, 346)
        Me.TxtHargaSatuan.Name = "TxtHargaSatuan"
        Me.TxtHargaSatuan.Size = New System.Drawing.Size(207, 23)
        Me.TxtHargaSatuan.TabIndex = 16
        '
        'DTPMasuk
        '
        Me.DTPMasuk.CustomFormat = "dddd, MMMM dd yyyy"
        Me.DTPMasuk.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPMasuk.Location = New System.Drawing.Point(400, 199)
        Me.DTPMasuk.Name = "DTPMasuk"
        Me.DTPMasuk.Size = New System.Drawing.Size(207, 23)
        Me.DTPMasuk.TabIndex = 17
        '
        'DTPKadaluarsa
        '
        Me.DTPKadaluarsa.CustomFormat = "dddd, MMMM dd yyyy"
        Me.DTPKadaluarsa.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPKadaluarsa.Location = New System.Drawing.Point(400, 236)
        Me.DTPKadaluarsa.Name = "DTPKadaluarsa"
        Me.DTPKadaluarsa.Size = New System.Drawing.Size(207, 23)
        Me.DTPKadaluarsa.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RDSegera)
        Me.GroupBox1.Controls.Add(Me.RDRutin)
        Me.GroupBox1.Location = New System.Drawing.Point(400, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 88)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipe Konsumsi"
        '
        'RDSegera
        '
        Me.RDSegera.AutoSize = True
        Me.RDSegera.Location = New System.Drawing.Point(17, 51)
        Me.RDSegera.Name = "RDSegera"
        Me.RDSegera.Size = New System.Drawing.Size(60, 19)
        Me.RDSegera.TabIndex = 1
        Me.RDSegera.TabStop = True
        Me.RDSegera.Text = "Segera"
        Me.RDSegera.UseVisualStyleBackColor = True
        '
        'RDRutin
        '
        Me.RDRutin.AutoSize = True
        Me.RDRutin.Location = New System.Drawing.Point(17, 26)
        Me.RDRutin.Name = "RDRutin"
        Me.RDRutin.Size = New System.Drawing.Size(53, 19)
        Me.RDRutin.TabIndex = 0
        Me.RDRutin.TabStop = True
        Me.RDRutin.Text = "Rutin"
        Me.RDRutin.UseVisualStyleBackColor = True
        '
        'ComBoxSatuan
        '
        Me.ComBoxSatuan.FormattingEnabled = True
        Me.ComBoxSatuan.Items.AddRange(New Object() {"Strip", "Kaplet", "Tablet", "Botol", "Pcs"})
        Me.ComBoxSatuan.Location = New System.Drawing.Point(400, 314)
        Me.ComBoxSatuan.Name = "ComBoxSatuan"
        Me.ComBoxSatuan.Size = New System.Drawing.Size(207, 23)
        Me.ComBoxSatuan.TabIndex = 20
        Me.ComBoxSatuan.Text = "-- Pilih Jenis Satuan --"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CBRacikan)
        Me.GroupBox2.Controls.Add(Me.CBEfekSamping)
        Me.GroupBox2.Controls.Add(Me.CBResepDokter)
        Me.GroupBox2.Location = New System.Drawing.Point(400, 382)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(207, 102)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Info Tambahan"
        '
        'CBRacikan
        '
        Me.CBRacikan.AutoSize = True
        Me.CBRacikan.Location = New System.Drawing.Point(17, 73)
        Me.CBRacikan.Name = "CBRacikan"
        Me.CBRacikan.Size = New System.Drawing.Size(67, 19)
        Me.CBRacikan.TabIndex = 2
        Me.CBRacikan.Text = "Racikan"
        Me.CBRacikan.UseVisualStyleBackColor = True
        '
        'CBEfekSamping
        '
        Me.CBEfekSamping.AutoSize = True
        Me.CBEfekSamping.Location = New System.Drawing.Point(17, 48)
        Me.CBEfekSamping.Name = "CBEfekSamping"
        Me.CBEfekSamping.Size = New System.Drawing.Size(98, 19)
        Me.CBEfekSamping.TabIndex = 1
        Me.CBEfekSamping.Text = "Efek Samping"
        Me.CBEfekSamping.UseVisualStyleBackColor = True
        '
        'CBResepDokter
        '
        Me.CBResepDokter.AutoSize = True
        Me.CBResepDokter.Location = New System.Drawing.Point(17, 23)
        Me.CBResepDokter.Name = "CBResepDokter"
        Me.CBResepDokter.Size = New System.Drawing.Size(130, 19)
        Me.CBResepDokter.TabIndex = 0
        Me.CBResepDokter.Text = "Butuh Resep Dokter"
        Me.CBResepDokter.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 503)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ComBoxSatuan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DTPKadaluarsa)
        Me.Controls.Add(Me.DTPMasuk)
        Me.Controls.Add(Me.TxtHargaSatuan)
        Me.Controls.Add(Me.TxtStok)
        Me.Controls.Add(Me.TxtNamaObat)
        Me.Controls.Add(Me.BtnShowInfo)
        Me.Controls.Add(Me.BtnAddGambar)
        Me.Controls.Add(Me.PCBobatDashboard)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBoxObat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.PCBobatDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBoxObat As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PCBobatDashboard As PictureBox
    Friend WithEvents BtnAddGambar As Button
    Friend WithEvents BtnShowInfo As Button
    Friend WithEvents TxtNamaObat As TextBox
    Friend WithEvents TxtStok As TextBox
    Friend WithEvents TxtHargaSatuan As TextBox
    Friend WithEvents DTPMasuk As DateTimePicker
    Friend WithEvents DTPKadaluarsa As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RDSegera As RadioButton
    Friend WithEvents RDRutin As RadioButton
    Friend WithEvents ComBoxSatuan As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CBRacikan As CheckBox
    Friend WithEvents CBEfekSamping As CheckBox
    Friend WithEvents CBResepDokter As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
