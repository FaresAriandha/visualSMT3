<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pertemuan5
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
        Me.BtnChangeColor = New System.Windows.Forms.Button()
        Me.LblColorChange = New System.Windows.Forms.Label()
        Me.LblColorCode = New System.Windows.Forms.Label()
        Me.TxtColorCode = New System.Windows.Forms.TextBox()
        Me.PnlColorChange = New System.Windows.Forms.Panel()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.BtnChangeGreen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnChangeColor
        '
        Me.BtnChangeColor.Location = New System.Drawing.Point(45, 52)
        Me.BtnChangeColor.Name = "BtnChangeColor"
        Me.BtnChangeColor.Size = New System.Drawing.Size(151, 40)
        Me.BtnChangeColor.TabIndex = 0
        Me.BtnChangeColor.Text = "Change Color"
        Me.BtnChangeColor.UseVisualStyleBackColor = True
        '
        'LblColorChange
        '
        Me.LblColorChange.AutoSize = True
        Me.LblColorChange.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblColorChange.Location = New System.Drawing.Point(63, 112)
        Me.LblColorChange.Name = "LblColorChange"
        Me.LblColorChange.Size = New System.Drawing.Size(116, 36)
        Me.LblColorChange.TabIndex = 1
        Me.LblColorChange.Text = "Text Color"
        '
        'LblColorCode
        '
        Me.LblColorCode.AutoSize = True
        Me.LblColorCode.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblColorCode.Location = New System.Drawing.Point(74, 165)
        Me.LblColorCode.Name = "LblColorCode"
        Me.LblColorCode.Size = New System.Drawing.Size(93, 25)
        Me.LblColorCode.TabIndex = 2
        Me.LblColorCode.Text = "Color Code"
        '
        'TxtColorCode
        '
        Me.TxtColorCode.Location = New System.Drawing.Point(49, 206)
        Me.TxtColorCode.Name = "TxtColorCode"
        Me.TxtColorCode.Size = New System.Drawing.Size(137, 31)
        Me.TxtColorCode.TabIndex = 3
        '
        'PnlColorChange
        '
        Me.PnlColorChange.Location = New System.Drawing.Point(50, 257)
        Me.PnlColorChange.Name = "PnlColorChange"
        Me.PnlColorChange.Size = New System.Drawing.Size(136, 81)
        Me.PnlColorChange.TabIndex = 4
        '
        'BtnChangeGreen
        '
        Me.BtnChangeGreen.Location = New System.Drawing.Point(261, 139)
        Me.BtnChangeGreen.Name = "BtnChangeGreen"
        Me.BtnChangeGreen.Size = New System.Drawing.Size(151, 66)
        Me.BtnChangeGreen.TabIndex = 5
        Me.BtnChangeGreen.Text = "Change Green Color"
        Me.BtnChangeGreen.UseVisualStyleBackColor = True
        '
        'Pertemuan5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnChangeGreen)
        Me.Controls.Add(Me.PnlColorChange)
        Me.Controls.Add(Me.TxtColorCode)
        Me.Controls.Add(Me.LblColorCode)
        Me.Controls.Add(Me.LblColorChange)
        Me.Controls.Add(Me.BtnChangeColor)
        Me.Name = "Pertemuan5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pertemuan5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnChangeColor As Button
    Friend WithEvents LblColorChange As Label
    Friend WithEvents LblColorCode As Label
    Friend WithEvents TxtColorCode As TextBox
    Friend WithEvents PnlColorChange As Panel
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents BtnChangeGreen As Button
End Class
