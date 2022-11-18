<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TugasPertemuan10
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridKoleksi = New System.Windows.Forms.DataGridView()
        Me.namaKoleksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fotoKoleksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenisKoleksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.penerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahunTerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnBack = New System.Windows.Forms.Button()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridKoleksi
        '
        Me.DataGridKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.namaKoleksi, Me.fotoKoleksi, Me.jenisKoleksi, Me.penerbit, Me.tahunTerbit})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridKoleksi.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridKoleksi.Location = New System.Drawing.Point(12, 12)
        Me.DataGridKoleksi.Name = "DataGridKoleksi"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridKoleksi.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridKoleksi.RowHeadersWidth = 51
        Me.DataGridKoleksi.RowTemplate.Height = 29
        Me.DataGridKoleksi.Size = New System.Drawing.Size(804, 188)
        Me.DataGridKoleksi.TabIndex = 0
        '
        'namaKoleksi
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.namaKoleksi.DefaultCellStyle = DataGridViewCellStyle1
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
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(655, 380)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(161, 49)
        Me.BtnBack.TabIndex = 1
        Me.BtnBack.Text = "Back Home"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'TugasPertemuan10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 450)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.DataGridKoleksi)
        Me.Name = "TugasPertemuan10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TugasPertemuan10"
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridKoleksi As DataGridView
    Friend WithEvents namaKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents fotoKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents jenisKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents penerbit As DataGridViewTextBoxColumn
    Friend WithEvents tahunTerbit As DataGridViewTextBoxColumn
    Friend WithEvents BtnBack As Button
End Class
