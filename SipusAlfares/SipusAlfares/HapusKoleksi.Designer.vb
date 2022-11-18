<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusKoleksi
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
        Me.LblKoleksi = New System.Windows.Forms.Label()
        Me.BtnHapusKoleksi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(207, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah ingin menghapus koleksi"
        '
        'LblKoleksi
        '
        Me.LblKoleksi.AutoSize = True
        Me.LblKoleksi.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblKoleksi.ForeColor = System.Drawing.Color.Red
        Me.LblKoleksi.Location = New System.Drawing.Point(301, 168)
        Me.LblKoleksi.Name = "LblKoleksi"
        Me.LblKoleksi.Size = New System.Drawing.Size(180, 54)
        Me.LblKoleksi.TabIndex = 1
        Me.LblKoleksi.Text = "Koleksi A"
        Me.LblKoleksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnHapusKoleksi
        '
        Me.BtnHapusKoleksi.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapusKoleksi.Location = New System.Drawing.Point(301, 293)
        Me.BtnHapusKoleksi.Name = "BtnHapusKoleksi"
        Me.BtnHapusKoleksi.Size = New System.Drawing.Size(175, 42)
        Me.BtnHapusKoleksi.TabIndex = 2
        Me.BtnHapusKoleksi.Text = "Hapus Koleksi"
        Me.BtnHapusKoleksi.UseVisualStyleBackColor = True
        '
        'HapusKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 390)
        Me.Controls.Add(Me.BtnHapusKoleksi)
        Me.Controls.Add(Me.LblKoleksi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HapusKoleksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hapus Koleksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblKoleksi As Label
    Friend WithEvents BtnHapusKoleksi As Button
End Class
