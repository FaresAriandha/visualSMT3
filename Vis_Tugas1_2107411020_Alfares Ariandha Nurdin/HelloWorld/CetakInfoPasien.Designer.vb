<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InfoPasien
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
        Me.PcbPasien = New System.Windows.Forms.PictureBox()
        Me.Nama = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblNIK = New System.Windows.Forms.Label()
        Me.LblJK = New System.Windows.Forms.Label()
        Me.LblAddress = New System.Windows.Forms.Label()
        CType(Me.PcbPasien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PcbPasien
        '
        Me.PcbPasien.Location = New System.Drawing.Point(982, 47)
        Me.PcbPasien.Name = "PcbPasien"
        Me.PcbPasien.Size = New System.Drawing.Size(186, 186)
        Me.PcbPasien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PcbPasien.TabIndex = 0
        Me.PcbPasien.TabStop = False
        Me.PcbPasien.UseWaitCursor = True
        '
        'Nama
        '
        Me.Nama.AutoSize = True
        Me.Nama.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Nama.Location = New System.Drawing.Point(68, 47)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(170, 30)
        Me.Nama.TabIndex = 1
        Me.Nama.Text = "Nama Lengkap"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(68, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(68, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(68, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NIK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(255, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 30)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(255, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 30)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(255, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 30)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(255, 250)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 30)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = ":"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblName.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblName.Location = New System.Drawing.Point(280, 48)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(119, 29)
        Me.LblName.TabIndex = 9
        Me.LblName.Text = "Name Place"
        '
        'LblNIK
        '
        Me.LblNIK.AutoSize = True
        Me.LblNIK.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblNIK.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblNIK.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblNIK.Location = New System.Drawing.Point(280, 115)
        Me.LblNIK.Name = "LblNIK"
        Me.LblNIK.Size = New System.Drawing.Size(98, 29)
        Me.LblNIK.TabIndex = 10
        Me.LblNIK.Text = "NIK Place"
        '
        'LblJK
        '
        Me.LblJK.AutoSize = True
        Me.LblJK.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblJK.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblJK.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblJK.Location = New System.Drawing.Point(280, 184)
        Me.LblJK.Name = "LblJK"
        Me.LblJK.Size = New System.Drawing.Size(90, 29)
        Me.LblJK.TabIndex = 11
        Me.LblJK.Text = "JK Place"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblAddress.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblAddress.Location = New System.Drawing.Point(280, 251)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(140, 29)
        Me.LblAddress.TabIndex = 12
        Me.LblAddress.Text = "Address Place"
        '
        'InfoPasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1205, 522)
        Me.Controls.Add(Me.LblAddress)
        Me.Controls.Add(Me.LblJK)
        Me.Controls.Add(Me.LblNIK)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.PcbPasien)
        Me.Name = "InfoPasien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak Info Pasien"
        CType(Me.PcbPasien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PcbPasien As PictureBox
    Friend WithEvents Nama As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblNIK As Label
    Friend WithEvents LblJK As Label
    Friend WithEvents LblAddress As Label
End Class
