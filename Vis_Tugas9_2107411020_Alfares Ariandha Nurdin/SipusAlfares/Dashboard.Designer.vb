<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LatihanArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TugasPertemuan10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnShowFormAddKoleksi = New System.Windows.Forms.Button()
        Me.BtnShowFormDelKoleksi = New System.Windows.Forms.Button()
        Me.ListBoxKoleksi = New System.Windows.Forms.ListBox()
        Me.DataGridKoleksi = New System.Windows.Forms.DataGridView()
        Me.namaKoleksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fotoKoleksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KategoriBuku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenisKoleksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.penerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahunTerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.DataGridKoleksiDB = New System.Windows.Forms.DataGridView()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridKoleksiDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem, Me.LatihanArrayToolStripMenuItem, Me.TugasPertemuan10ToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(79, 29)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(248, 30)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'LatihanArrayToolStripMenuItem
        '
        Me.LatihanArrayToolStripMenuItem.Name = "LatihanArrayToolStripMenuItem"
        Me.LatihanArrayToolStripMenuItem.Size = New System.Drawing.Size(248, 30)
        Me.LatihanArrayToolStripMenuItem.Text = "Latihan Array"
        '
        'TugasPertemuan10ToolStripMenuItem
        '
        Me.TugasPertemuan10ToolStripMenuItem.Name = "TugasPertemuan10ToolStripMenuItem"
        Me.TugasPertemuan10ToolStripMenuItem.Size = New System.Drawing.Size(248, 30)
        Me.TugasPertemuan10ToolStripMenuItem.Text = "Tugas Pertemuan 10"
        '
        'BtnShowFormAddKoleksi
        '
        Me.BtnShowFormAddKoleksi.BackgroundImage = Global.SipusAlfares.My.Resources.Resources.plus__1_
        Me.BtnShowFormAddKoleksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnShowFormAddKoleksi.Location = New System.Drawing.Point(12, 45)
        Me.BtnShowFormAddKoleksi.Name = "BtnShowFormAddKoleksi"
        Me.BtnShowFormAddKoleksi.Size = New System.Drawing.Size(52, 41)
        Me.BtnShowFormAddKoleksi.TabIndex = 1
        Me.BtnShowFormAddKoleksi.UseVisualStyleBackColor = True
        '
        'BtnShowFormDelKoleksi
        '
        Me.BtnShowFormDelKoleksi.BackgroundImage = Global.SipusAlfares.My.Resources.Resources.minus__1_
        Me.BtnShowFormDelKoleksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnShowFormDelKoleksi.Location = New System.Drawing.Point(79, 45)
        Me.BtnShowFormDelKoleksi.Name = "BtnShowFormDelKoleksi"
        Me.BtnShowFormDelKoleksi.Size = New System.Drawing.Size(52, 41)
        Me.BtnShowFormDelKoleksi.TabIndex = 2
        Me.BtnShowFormDelKoleksi.UseVisualStyleBackColor = True
        '
        'ListBoxKoleksi
        '
        Me.ListBoxKoleksi.FormattingEnabled = True
        Me.ListBoxKoleksi.ItemHeight = 20
        Me.ListBoxKoleksi.Location = New System.Drawing.Point(17, 106)
        Me.ListBoxKoleksi.Name = "ListBoxKoleksi"
        Me.ListBoxKoleksi.Size = New System.Drawing.Size(766, 144)
        Me.ListBoxKoleksi.TabIndex = 3
        '
        'DataGridKoleksi
        '
        Me.DataGridKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.namaKoleksi, Me.fotoKoleksi, Me.KategoriBuku, Me.jenisKoleksi, Me.penerbit, Me.tahunTerbit})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridKoleksi.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridKoleksi.Location = New System.Drawing.Point(17, 275)
        Me.DataGridKoleksi.Name = "DataGridKoleksi"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridKoleksi.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridKoleksi.RowHeadersWidth = 51
        Me.DataGridKoleksi.RowTemplate.Height = 29
        Me.DataGridKoleksi.Size = New System.Drawing.Size(766, 188)
        Me.DataGridKoleksi.TabIndex = 4
        '
        'namaKoleksi
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.namaKoleksi.DefaultCellStyle = DataGridViewCellStyle4
        Me.namaKoleksi.HeaderText = "Nama Koleksi"
        Me.namaKoleksi.MinimumWidth = 6
        Me.namaKoleksi.Name = "namaKoleksi"
        Me.namaKoleksi.Width = 125
        '
        'fotoKoleksi
        '
        Me.fotoKoleksi.HeaderText = "Gambar Buku"
        Me.fotoKoleksi.MinimumWidth = 6
        Me.fotoKoleksi.Name = "fotoKoleksi"
        Me.fotoKoleksi.Width = 125
        '
        'KategoriBuku
        '
        Me.KategoriBuku.HeaderText = "Kategori Buku"
        Me.KategoriBuku.MinimumWidth = 6
        Me.KategoriBuku.Name = "KategoriBuku"
        Me.KategoriBuku.Width = 125
        '
        'jenisKoleksi
        '
        Me.jenisKoleksi.HeaderText = "Jenis Koleksi"
        Me.jenisKoleksi.MinimumWidth = 6
        Me.jenisKoleksi.Name = "jenisKoleksi"
        Me.jenisKoleksi.Width = 125
        '
        'penerbit
        '
        Me.penerbit.HeaderText = "Penerbit"
        Me.penerbit.MinimumWidth = 6
        Me.penerbit.Name = "penerbit"
        Me.penerbit.Width = 125
        '
        'tahunTerbit
        '
        Me.tahunTerbit.HeaderText = "Tahun Terbit"
        Me.tahunTerbit.MinimumWidth = 6
        Me.tahunTerbit.Name = "tahunTerbit"
        Me.tahunTerbit.Width = 125
        '
        'BtnSelect
        '
        Me.BtnSelect.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSelect.Location = New System.Drawing.Point(593, 544)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(172, 43)
        Me.BtnSelect.TabIndex = 5
        Me.BtnSelect.Text = "Show Selected Item"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'DataGridKoleksiDB
        '
        Me.DataGridKoleksiDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksiDB.Location = New System.Drawing.Point(17, 275)
        Me.DataGridKoleksiDB.Name = "DataGridKoleksiDB"
        Me.DataGridKoleksiDB.RowHeadersWidth = 51
        Me.DataGridKoleksiDB.RowTemplate.Height = 29
        Me.DataGridKoleksiDB.Size = New System.Drawing.Size(766, 188)
        Me.DataGridKoleksiDB.TabIndex = 6
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnUpdate.Location = New System.Drawing.Point(17, 544)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(172, 43)
        Me.BtnUpdate.TabIndex = 7
        Me.BtnUpdate.Text = "Update Data"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnRemove.Location = New System.Drawing.Point(195, 544)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(172, 43)
        Me.BtnRemove.TabIndex = 8
        Me.BtnRemove.Text = "Remove Data"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 616)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.DataGridKoleksiDB)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.DataGridKoleksi)
        Me.Controls.Add(Me.ListBoxKoleksi)
        Me.Controls.Add(Me.BtnShowFormDelKoleksi)
        Me.Controls.Add(Me.BtnShowFormAddKoleksi)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard Perpustakaan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridKoleksiDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnShowFormAddKoleksi As Button
    Friend WithEvents BtnShowFormDelKoleksi As Button
    Friend WithEvents ListBoxKoleksi As ListBox
    Friend WithEvents LatihanArrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TugasPertemuan10ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridKoleksi As DataGridView
    Friend WithEvents BtnSelect As Button
    Friend WithEvents namaKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents fotoKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents KategoriBuku As DataGridViewTextBoxColumn
    Friend WithEvents jenisKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents penerbit As DataGridViewTextBoxColumn
    Friend WithEvents tahunTerbit As DataGridViewTextBoxColumn
    Friend WithEvents DataGridKoleksiDB As DataGridView
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnRemove As Button
End Class
