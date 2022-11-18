<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoObat
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
        Me.LblNamaObat = New System.Windows.Forms.Label()
        Me.PCBObatInfo = New System.Windows.Forms.PictureBox()
        Me.LblTipeKonsumsi = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblTglMasuk = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblTglKadaluarsa = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblStok = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblHargaSatuan = New System.Windows.Forms.Label()
        Me.LblSatuan = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ListBoxInfo = New System.Windows.Forms.ListBox()
        Me.BtnTutup = New System.Windows.Forms.Button()
        CType(Me.PCBObatInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNamaObat
        '
        Me.LblNamaObat.AutoSize = True
        Me.LblNamaObat.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblNamaObat.Location = New System.Drawing.Point(208, 25)
        Me.LblNamaObat.Name = "LblNamaObat"
        Me.LblNamaObat.Size = New System.Drawing.Size(112, 30)
        Me.LblNamaObat.TabIndex = 2
        Me.LblNamaObat.Text = "Nama Obat"
        Me.LblNamaObat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PCBObatInfo
        '
        Me.PCBObatInfo.Location = New System.Drawing.Point(208, 69)
        Me.PCBObatInfo.Name = "PCBObatInfo"
        Me.PCBObatInfo.Size = New System.Drawing.Size(112, 105)
        Me.PCBObatInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCBObatInfo.TabIndex = 3
        Me.PCBObatInfo.TabStop = False
        '
        'LblTipeKonsumsi
        '
        Me.LblTipeKonsumsi.AutoSize = True
        Me.LblTipeKonsumsi.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTipeKonsumsi.Location = New System.Drawing.Point(241, 237)
        Me.LblTipeKonsumsi.Name = "LblTipeKonsumsi"
        Me.LblTipeKonsumsi.Size = New System.Drawing.Size(94, 21)
        Me.LblTipeKonsumsi.TabIndex = 4
        Me.LblTipeKonsumsi.Text = "Tipe Konsumsi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(42, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tipe Konsumsi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(222, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(222, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(42, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tanggal Masuk"
        '
        'LblTglMasuk
        '
        Me.LblTglMasuk.AutoSize = True
        Me.LblTglMasuk.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTglMasuk.Location = New System.Drawing.Point(241, 268)
        Me.LblTglMasuk.Name = "LblTglMasuk"
        Me.LblTglMasuk.Size = New System.Drawing.Size(96, 21)
        Me.LblTglMasuk.TabIndex = 7
        Me.LblTglMasuk.Text = "Tanggal Masuk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(222, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(42, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tanggal Kadaluarsa"
        '
        'LblTglKadaluarsa
        '
        Me.LblTglKadaluarsa.AutoSize = True
        Me.LblTglKadaluarsa.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTglKadaluarsa.Location = New System.Drawing.Point(241, 299)
        Me.LblTglKadaluarsa.Name = "LblTglKadaluarsa"
        Me.LblTglKadaluarsa.Size = New System.Drawing.Size(123, 21)
        Me.LblTglKadaluarsa.TabIndex = 10
        Me.LblTglKadaluarsa.Text = "Tanggal Kadaluarsa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(222, 330)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 21)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(42, 330)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 21)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Stok Awal"
        '
        'LblStok
        '
        Me.LblStok.AutoSize = True
        Me.LblStok.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblStok.Location = New System.Drawing.Point(241, 331)
        Me.LblStok.Name = "LblStok"
        Me.LblStok.Size = New System.Drawing.Size(67, 21)
        Me.LblStok.TabIndex = 13
        Me.LblStok.Text = "Stok Awal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(222, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 21)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(42, 360)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 21)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Harga"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(241, 361)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 21)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Rp."
        '
        'LblHargaSatuan
        '
        Me.LblHargaSatuan.AutoSize = True
        Me.LblHargaSatuan.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblHargaSatuan.Location = New System.Drawing.Point(277, 361)
        Me.LblHargaSatuan.Name = "LblHargaSatuan"
        Me.LblHargaSatuan.Size = New System.Drawing.Size(87, 21)
        Me.LblHargaSatuan.TabIndex = 19
        Me.LblHargaSatuan.Text = "Harga Satuan"
        '
        'LblSatuan
        '
        Me.LblSatuan.AutoSize = True
        Me.LblSatuan.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblSatuan.Location = New System.Drawing.Point(370, 360)
        Me.LblSatuan.Name = "LblSatuan"
        Me.LblSatuan.Size = New System.Drawing.Size(50, 21)
        Me.LblSatuan.TabIndex = 20
        Me.LblSatuan.Text = "Satuan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(222, 402)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 21)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(42, 402)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 21)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Info Tambahan"
        '
        'ListBoxInfo
        '
        Me.ListBoxInfo.FormattingEnabled = True
        Me.ListBoxInfo.ItemHeight = 15
        Me.ListBoxInfo.Location = New System.Drawing.Point(244, 402)
        Me.ListBoxInfo.Name = "ListBoxInfo"
        Me.ListBoxInfo.Size = New System.Drawing.Size(176, 94)
        Me.ListBoxInfo.TabIndex = 23
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(453, 500)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 23)
        Me.BtnTutup.TabIndex = 24
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'InfoObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 535)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.ListBoxInfo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LblSatuan)
        Me.Controls.Add(Me.LblHargaSatuan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblStok)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblTglKadaluarsa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblTglMasuk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblTipeKonsumsi)
        Me.Controls.Add(Me.PCBObatInfo)
        Me.Controls.Add(Me.LblNamaObat)
        Me.Name = "InfoObat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InfoObat"
        CType(Me.PCBObatInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNamaObat As Label
    Friend WithEvents PCBObatInfo As PictureBox
    Friend WithEvents LblTipeKonsumsi As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblTglMasuk As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblTglKadaluarsa As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblStok As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LblHargaSatuan As Label
    Friend WithEvents LblSatuan As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ListBoxInfo As ListBox
    Friend WithEvents BtnTutup As Button
End Class
