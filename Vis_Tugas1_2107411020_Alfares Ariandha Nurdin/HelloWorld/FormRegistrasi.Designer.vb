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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnKeluhan = New System.Windows.Forms.Button()
        CType(Me.PicHospital, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicHospital
        '
        Me.PicHospital.BackgroundImage = Global.HelloWorld.My.Resources.Resources.logo_pnj
        Me.PicHospital.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PicHospital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicHospital.ErrorImage = Nothing
        Me.PicHospital.InitialImage = Nothing
        Me.PicHospital.Location = New System.Drawing.Point(30, 22)
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
        Me.Label1.Location = New System.Drawing.Point(269, 22)
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
        Me.Label2.Location = New System.Drawing.Point(269, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(331, 90)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Jl. Prof. DR. G.A. Siwabessy, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kampus Universitas Indonesia " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Depok 16425" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtBoxNIK
        '
        Me.TxtBoxNIK.Location = New System.Drawing.Point(295, 287)
        Me.TxtBoxNIK.Name = "TxtBoxNIK"
        Me.TxtBoxNIK.Size = New System.Drawing.Size(341, 31)
        Me.TxtBoxNIK.TabIndex = 3
        '
        'TxtBoxNama
        '
        Me.TxtBoxNama.Location = New System.Drawing.Point(295, 345)
        Me.TxtBoxNama.Name = "TxtBoxNama"
        Me.TxtBoxNama.Size = New System.Drawing.Size(341, 31)
        Me.TxtBoxNama.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(140, 287)
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
        Me.Label4.Location = New System.Drawing.Point(140, 346)
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
        Me.Label6.Location = New System.Drawing.Point(789, 76)
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
        Me.LblJmlKmr.Location = New System.Drawing.Point(1013, 76)
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
        Me.BtnAddRoom.Location = New System.Drawing.Point(793, 143)
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
        Me.BtnAddPatient.Location = New System.Drawing.Point(918, 736)
        Me.BtnAddPatient.Name = "BtnAddPatient"
        Me.BtnAddPatient.Size = New System.Drawing.Size(288, 55)
        Me.BtnAddPatient.TabIndex = 13
        Me.BtnAddPatient.Text = "Tambah Pasien"
        Me.BtnAddPatient.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(723, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 30)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Alamat"
        '
        'RTB_Alamat
        '
        Me.RTB_Alamat.Location = New System.Drawing.Point(835, 279)
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
        Me.GroupBox1.Location = New System.Drawing.Point(140, 422)
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
        Me.LblTotalCharAlamat.Location = New System.Drawing.Point(1130, 411)
        Me.LblTotalCharAlamat.Name = "LblTotalCharAlamat"
        Me.LblTotalCharAlamat.Size = New System.Drawing.Size(49, 30)
        Me.LblTotalCharAlamat.TabIndex = 18
        Me.LblTotalCharAlamat.Text = "100"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(140, 631)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 30)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Upload Foto"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(295, 625)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 42)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(461, 615)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Padding = New System.Windows.Forms.Padding(10)
        Me.PictureBox1.Size = New System.Drawing.Size(175, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(723, 493)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 30)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Keluhan"
        '
        'BtnKeluhan
        '
        Me.BtnKeluhan.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnKeluhan.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnKeluhan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnKeluhan.Location = New System.Drawing.Point(835, 487)
        Me.BtnKeluhan.Name = "BtnKeluhan"
        Me.BtnKeluhan.Size = New System.Drawing.Size(212, 42)
        Me.BtnKeluhan.TabIndex = 23
        Me.BtnKeluhan.Text = "Tambah Keluhan"
        Me.BtnKeluhan.UseVisualStyleBackColor = False
        '
        'FormRegistrasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(1353, 821)
        Me.Controls.Add(Me.BtnKeluhan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
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
        Me.Name = "FormRegistrasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Registrasi"
        CType(Me.PicHospital, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnKeluhan As Button
End Class
