<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistrasi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PicHospital = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBoxNIK = New System.Windows.Forms.TextBox()
        Me.TxtBoxNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RdMale = New System.Windows.Forms.RadioButton()
        Me.RdFemale = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblJmlKmr = New System.Windows.Forms.Label()
        Me.BtnAddRoom = New System.Windows.Forms.Button()
        Me.BtnAddPatient = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RTB_Alamat = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblTotalCharAlamat = New System.Windows.Forms.Label()
        Me.BtnOpenFoto = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.BtnKeluhan = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBoxLyn = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkDemam = New System.Windows.Forms.CheckBox()
        Me.ChkMual = New System.Windows.Forms.CheckBox()
        Me.ChkPusing = New System.Windows.Forms.CheckBox()
        Me.DatePickTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.BtnDate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RTBoxCatatan = New System.Windows.Forms.RichTextBox()
        Me.TimePickerTime = New System.Windows.Forms.DateTimePicker()
        Me.BtnTime = New System.Windows.Forms.Button()
        Me.BtnCurrTime = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluhanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnOpenCatatan = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PicHospital, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicHospital
        '
        Me.PicHospital.BackgroundImage = Global.HelloWorld.My.Resources.Resources.logo_pnj
        Me.PicHospital.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PicHospital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicHospital.ErrorImage = Nothing
        Me.PicHospital.InitialImage = Nothing
        Me.PicHospital.Location = New System.Drawing.Point(39, 66)
        Me.PicHospital.Name = "PicHospital"
        Me.PicHospital.Padding = New System.Windows.Forms.Padding(10)
        Me.PicHospital.Size = New System.Drawing.Size(175, 176)
        Me.PicHospital.TabIndex = 0
        Me.PicHospital.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(278, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rumah Sakit PNJ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(278, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(331, 90)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Jl. Prof. DR. G.A. Siwabessy, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kampus Universitas Indonesia " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Depok 16425" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtBoxNIK
        '
        Me.TxtBoxNIK.Location = New System.Drawing.Point(446, 325)
        Me.TxtBoxNIK.Name = "TxtBoxNIK"
        Me.TxtBoxNIK.Size = New System.Drawing.Size(341, 31)
        Me.TxtBoxNIK.TabIndex = 3
        '
        'TxtBoxNama
        '
        Me.TxtBoxNama.Location = New System.Drawing.Point(446, 383)
        Me.TxtBoxNama.Name = "TxtBoxNama"
        Me.TxtBoxNama.Size = New System.Drawing.Size(341, 31)
        Me.TxtBoxNama.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(281, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 30)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NIM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(281, 384)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 30)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nama"
        '
        'RdMale
        '
        Me.RdMale.AutoSize = True
        Me.RdMale.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RdMale.Location = New System.Drawing.Point(47, 50)
        Me.RdMale.Name = "RdMale"
        Me.RdMale.Size = New System.Drawing.Size(112, 34)
        Me.RdMale.TabIndex = 8
        Me.RdMale.TabStop = True
        Me.RdMale.Text = "Laki-laki"
        Me.RdMale.UseVisualStyleBackColor = True
        '
        'RdFemale
        '
        Me.RdFemale.AutoSize = True
        Me.RdFemale.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RdFemale.Location = New System.Drawing.Point(47, 90)
        Me.RdFemale.Name = "RdFemale"
        Me.RdFemale.Size = New System.Drawing.Size(140, 34)
        Me.RdFemale.TabIndex = 9
        Me.RdFemale.TabStop = True
        Me.RdFemale.Text = "Perempuan"
        Me.RdFemale.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.SeaShell
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(1150, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Label6.Size = New System.Drawing.Size(204, 47)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Jumlah Kamar"
        '
        'LblJmlKmr
        '
        Me.LblJmlKmr.BackColor = System.Drawing.Color.SeaShell
        Me.LblJmlKmr.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblJmlKmr.Location = New System.Drawing.Point(1374, 55)
        Me.LblJmlKmr.Name = "LblJmlKmr"
        Me.LblJmlKmr.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.LblJmlKmr.Size = New System.Drawing.Size(112, 47)
        Me.LblJmlKmr.TabIndex = 11
        Me.LblJmlKmr.Text = "10"
        Me.LblJmlKmr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnAddRoom
        '
        Me.BtnAddRoom.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnAddRoom.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAddRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAddRoom.Location = New System.Drawing.Point(1154, 122)
        Me.BtnAddRoom.Name = "BtnAddRoom"
        Me.BtnAddRoom.Size = New System.Drawing.Size(332, 55)
        Me.BtnAddRoom.TabIndex = 12
        Me.BtnAddRoom.Text = "Tambah Kamar"
        Me.BtnAddRoom.UseVisualStyleBackColor = False
        '
        'BtnAddPatient
        '
        Me.BtnAddPatient.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnAddPatient.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAddPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAddPatient.Location = New System.Drawing.Point(1232, 1096)
        Me.BtnAddPatient.Name = "BtnAddPatient"
        Me.BtnAddPatient.Size = New System.Drawing.Size(254, 49)
        Me.BtnAddPatient.TabIndex = 13
        Me.BtnAddPatient.Text = "Tambah Pasien"
        Me.BtnAddPatient.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(281, 807)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 30)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Alamat"
        '
        'RTB_Alamat
        '
        Me.RTB_Alamat.Location = New System.Drawing.Point(446, 807)
        Me.RTB_Alamat.Name = "RTB_Alamat"
        Me.RTB_Alamat.Size = New System.Drawing.Size(274, 162)
        Me.RTB_Alamat.TabIndex = 15
        Me.RTB_Alamat.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.RdFemale)
        Me.GroupBox1.Controls.Add(Me.RdMale)
        Me.GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(278, 447)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 162)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jenis Kelamin"
        '
        'LblTotalCharAlamat
        '
        Me.LblTotalCharAlamat.AutoSize = True
        Me.LblTotalCharAlamat.BackColor = System.Drawing.SystemColors.Info
        Me.LblTotalCharAlamat.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTotalCharAlamat.Location = New System.Drawing.Point(741, 939)
        Me.LblTotalCharAlamat.Name = "LblTotalCharAlamat"
        Me.LblTotalCharAlamat.Size = New System.Drawing.Size(49, 30)
        Me.LblTotalCharAlamat.TabIndex = 18
        Me.LblTotalCharAlamat.Text = "100"
        '
        'BtnOpenFoto
        '
        Me.BtnOpenFoto.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnOpenFoto.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnOpenFoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnOpenFoto.Location = New System.Drawing.Point(39, 507)
        Me.BtnOpenFoto.Name = "BtnOpenFoto"
        Me.BtnOpenFoto.Size = New System.Drawing.Size(175, 42)
        Me.BtnOpenFoto.TabIndex = 20
        Me.BtnOpenFoto.Text = "Tambah Foto"
        Me.BtnOpenFoto.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PicFoto
        '
        Me.PicFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PicFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicFoto.ErrorImage = Nothing
        Me.PicFoto.InitialImage = Nothing
        Me.PicFoto.Location = New System.Drawing.Point(39, 325)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Padding = New System.Windows.Forms.Padding(10)
        Me.PicFoto.Size = New System.Drawing.Size(175, 176)
        Me.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicFoto.TabIndex = 21
        Me.PicFoto.TabStop = False
        '
        'BtnKeluhan
        '
        Me.BtnKeluhan.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnKeluhan.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnKeluhan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnKeluhan.Location = New System.Drawing.Point(1005, 1096)
        Me.BtnKeluhan.Name = "BtnKeluhan"
        Me.BtnKeluhan.Size = New System.Drawing.Size(212, 49)
        Me.BtnKeluhan.TabIndex = 23
        Me.BtnKeluhan.Text = "Ke Form PER 4"
        Me.BtnKeluhan.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(281, 651)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 30)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Tanggal Lahir"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(986, 326)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 30)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Layanan"
        '
        'ComboBoxLyn
        '
        Me.ComboBoxLyn.FormattingEnabled = True
        Me.ComboBoxLyn.Location = New System.Drawing.Point(1111, 326)
        Me.ComboBoxLyn.Name = "ComboBoxLyn"
        Me.ComboBoxLyn.Size = New System.Drawing.Size(224, 33)
        Me.ComboBoxLyn.TabIndex = 34
        Me.ComboBoxLyn.Text = "Inap"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.ChkDemam)
        Me.GroupBox2.Controls.Add(Me.ChkMual)
        Me.GroupBox2.Controls.Add(Me.ChkPusing)
        Me.GroupBox2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(986, 397)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(190, 184)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Keluhan"
        '
        'ChkDemam
        '
        Me.ChkDemam.AutoSize = True
        Me.ChkDemam.Location = New System.Drawing.Point(31, 130)
        Me.ChkDemam.Name = "ChkDemam"
        Me.ChkDemam.Size = New System.Drawing.Size(108, 34)
        Me.ChkDemam.TabIndex = 2
        Me.ChkDemam.Text = "Demam"
        Me.ChkDemam.UseVisualStyleBackColor = True
        '
        'ChkMual
        '
        Me.ChkMual.AutoSize = True
        Me.ChkMual.Location = New System.Drawing.Point(31, 90)
        Me.ChkMual.Name = "ChkMual"
        Me.ChkMual.Size = New System.Drawing.Size(83, 34)
        Me.ChkMual.TabIndex = 1
        Me.ChkMual.Text = "Mual"
        Me.ChkMual.UseVisualStyleBackColor = True
        '
        'ChkPusing
        '
        Me.ChkPusing.AutoSize = True
        Me.ChkPusing.Location = New System.Drawing.Point(31, 50)
        Me.ChkPusing.Name = "ChkPusing"
        Me.ChkPusing.Size = New System.Drawing.Size(98, 34)
        Me.ChkPusing.TabIndex = 0
        Me.ChkPusing.Text = "Pusing"
        Me.ChkPusing.UseVisualStyleBackColor = True
        '
        'DatePickTanggalLahir
        '
        Me.DatePickTanggalLahir.Location = New System.Drawing.Point(442, 649)
        Me.DatePickTanggalLahir.Name = "DatePickTanggalLahir"
        Me.DatePickTanggalLahir.Size = New System.Drawing.Size(278, 31)
        Me.DatePickTanggalLahir.TabIndex = 36
        '
        'BtnDate
        '
        Me.BtnDate.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnDate.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnDate.Location = New System.Drawing.Point(750, 649)
        Me.BtnDate.Name = "BtnDate"
        Me.BtnDate.Size = New System.Drawing.Size(137, 32)
        Me.BtnDate.TabIndex = 37
        Me.BtnDate.Text = "Show Date"
        Me.BtnDate.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(986, 615)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 30)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Catatan Dokter"
        '
        'RTBoxCatatan
        '
        Me.RTBoxCatatan.Location = New System.Drawing.Point(984, 667)
        Me.RTBoxCatatan.Name = "RTBoxCatatan"
        Me.RTBoxCatatan.Size = New System.Drawing.Size(478, 161)
        Me.RTBoxCatatan.TabIndex = 39
        Me.RTBoxCatatan.Text = ""
        '
        'TimePickerTime
        '
        Me.TimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TimePickerTime.Location = New System.Drawing.Point(442, 712)
        Me.TimePickerTime.Name = "TimePickerTime"
        Me.TimePickerTime.Size = New System.Drawing.Size(278, 31)
        Me.TimePickerTime.TabIndex = 40
        '
        'BtnTime
        '
        Me.BtnTime.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnTime.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnTime.Location = New System.Drawing.Point(750, 711)
        Me.BtnTime.Name = "BtnTime"
        Me.BtnTime.Size = New System.Drawing.Size(137, 32)
        Me.BtnTime.TabIndex = 41
        Me.BtnTime.Text = "Show Time"
        Me.BtnTime.UseVisualStyleBackColor = False
        '
        'BtnCurrTime
        '
        Me.BtnCurrTime.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnCurrTime.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCurrTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCurrTime.Location = New System.Drawing.Point(750, 767)
        Me.BtnCurrTime.Name = "BtnCurrTime"
        Me.BtnCurrTime.Size = New System.Drawing.Size(137, 32)
        Me.BtnCurrTime.TabIndex = 42
        Me.BtnCurrTime.Text = "Current Time"
        Me.BtnCurrTime.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Info
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem, Me.KamarToolStripMenuItem, Me.Pertemuan4ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1528, 38)
        Me.MenuStrip1.TabIndex = 43
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(73, 34)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'KamarToolStripMenuItem
        '
        Me.KamarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKamarToolStripMenuItem})
        Me.KamarToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.KamarToolStripMenuItem.Name = "KamarToolStripMenuItem"
        Me.KamarToolStripMenuItem.Size = New System.Drawing.Size(87, 34)
        Me.KamarToolStripMenuItem.Text = "Kamar"
        '
        'TambahKamarToolStripMenuItem
        '
        Me.TambahKamarToolStripMenuItem.Name = "TambahKamarToolStripMenuItem"
        Me.TambahKamarToolStripMenuItem.Size = New System.Drawing.Size(248, 38)
        Me.TambahKamarToolStripMenuItem.Text = "Tambah Kamar"
        '
        'Pertemuan4ToolStripMenuItem
        '
        Me.Pertemuan4ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeluhanToolStripMenuItem, Me.Pertemuan5ToolStripMenuItem})
        Me.Pertemuan4ToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Pertemuan4ToolStripMenuItem.Name = "Pertemuan4ToolStripMenuItem"
        Me.Pertemuan4ToolStripMenuItem.Size = New System.Drawing.Size(95, 34)
        Me.Pertemuan4ToolStripMenuItem.Text = "Latihan"
        '
        'KeluhanToolStripMenuItem
        '
        Me.KeluhanToolStripMenuItem.Name = "KeluhanToolStripMenuItem"
        Me.KeluhanToolStripMenuItem.Size = New System.Drawing.Size(230, 38)
        Me.KeluhanToolStripMenuItem.Text = "Keluhan"
        '
        'Pertemuan5ToolStripMenuItem
        '
        Me.Pertemuan5ToolStripMenuItem.Name = "Pertemuan5ToolStripMenuItem"
        Me.Pertemuan5ToolStripMenuItem.Size = New System.Drawing.Size(230, 38)
        Me.Pertemuan5ToolStripMenuItem.Text = "Pertemuan 5"
        '
        'BtnOpenCatatan
        '
        Me.BtnOpenCatatan.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnOpenCatatan.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnOpenCatatan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnOpenCatatan.Location = New System.Drawing.Point(1319, 850)
        Me.BtnOpenCatatan.Name = "BtnOpenCatatan"
        Me.BtnOpenCatatan.Size = New System.Drawing.Size(143, 42)
        Me.BtnOpenCatatan.TabIndex = 44
        Me.BtnOpenCatatan.Text = "Buka File"
        Me.BtnOpenCatatan.UseVisualStyleBackColor = False
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'FormRegistrasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(1528, 1170)
        Me.Controls.Add(Me.BtnOpenCatatan)
        Me.Controls.Add(Me.BtnCurrTime)
        Me.Controls.Add(Me.BtnTime)
        Me.Controls.Add(Me.TimePickerTime)
        Me.Controls.Add(Me.RTBoxCatatan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnDate)
        Me.Controls.Add(Me.DatePickTanggalLahir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ComboBoxLyn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnKeluhan)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.BtnOpenFoto)
        Me.Controls.Add(Me.LblTotalCharAlamat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RTB_Alamat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnAddPatient)
        Me.Controls.Add(Me.BtnAddRoom)
        Me.Controls.Add(Me.LblJmlKmr)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtBoxNama)
        Me.Controls.Add(Me.TxtBoxNIK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicHospital)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormRegistrasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Registrasi"
        CType(Me.PicHospital, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicHospital As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBoxNIK As TextBox
    Friend WithEvents TxtBoxNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RdMale As RadioButton
    Friend WithEvents RdFemale As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents LblJmlKmr As Label
    Friend WithEvents BtnAddRoom As Button
    Friend WithEvents BtnAddPatient As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents RTB_Alamat As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblTotalCharAlamat As Label
    Friend WithEvents BtnOpenFoto As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents BtnKeluhan As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBoxLyn As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ChkDemam As CheckBox
    Friend WithEvents ChkMual As CheckBox
    Friend WithEvents ChkPusing As CheckBox
    Friend WithEvents DatePickTanggalLahir As DateTimePicker
    Friend WithEvents BtnDate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents RTBoxCatatan As RichTextBox
    Friend WithEvents TimePickerTime As DateTimePicker
    Friend WithEvents BtnTime As Button
    Friend WithEvents BtnCurrTime As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pertemuan4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluhanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnOpenCatatan As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents Pertemuan5ToolStripMenuItem As ToolStripMenuItem
End Class
