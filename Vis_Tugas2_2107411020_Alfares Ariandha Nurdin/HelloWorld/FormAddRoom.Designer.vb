﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddRoom
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
        Me.Btn_FAR_Remove = New System.Windows.Forms.Button()
        Me.Txt_FAR_Total = New System.Windows.Forms.TextBox()
        Me.Btn_FAR_AddRoom = New System.Windows.Forms.Button()
        Me.LblCurrRoom = New System.Windows.Forms.Label()
        Me.Btn_FAR_Add = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(192, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kamar Tersedia Saat Ini"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_FAR_Remove
        '
        Me.Btn_FAR_Remove.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_FAR_Remove.Location = New System.Drawing.Point(127, 277)
        Me.Btn_FAR_Remove.Name = "Btn_FAR_Remove"
        Me.Btn_FAR_Remove.Size = New System.Drawing.Size(70, 45)
        Me.Btn_FAR_Remove.TabIndex = 1
        Me.Btn_FAR_Remove.Text = "-"
        Me.Btn_FAR_Remove.UseVisualStyleBackColor = True
        '
        'Txt_FAR_Total
        '
        Me.Txt_FAR_Total.Location = New System.Drawing.Point(237, 285)
        Me.Txt_FAR_Total.Name = "Txt_FAR_Total"
        Me.Txt_FAR_Total.Size = New System.Drawing.Size(316, 31)
        Me.Txt_FAR_Total.TabIndex = 3
        '
        'Btn_FAR_AddRoom
        '
        Me.Btn_FAR_AddRoom.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_FAR_AddRoom.Location = New System.Drawing.Point(284, 343)
        Me.Btn_FAR_AddRoom.Name = "Btn_FAR_AddRoom"
        Me.Btn_FAR_AddRoom.Size = New System.Drawing.Size(223, 46)
        Me.Btn_FAR_AddRoom.TabIndex = 4
        Me.Btn_FAR_AddRoom.Text = "Add Room"
        Me.Btn_FAR_AddRoom.UseVisualStyleBackColor = True
        '
        'LblCurrRoom
        '
        Me.LblCurrRoom.Font = New System.Drawing.Font("Franklin Gothic Demi", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblCurrRoom.Location = New System.Drawing.Point(333, 152)
        Me.LblCurrRoom.Name = "LblCurrRoom"
        Me.LblCurrRoom.Size = New System.Drawing.Size(126, 67)
        Me.LblCurrRoom.TabIndex = 5
        Me.LblCurrRoom.Text = "10"
        Me.LblCurrRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_FAR_Add
        '
        Me.Btn_FAR_Add.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_FAR_Add.Location = New System.Drawing.Point(596, 277)
        Me.Btn_FAR_Add.Name = "Btn_FAR_Add"
        Me.Btn_FAR_Add.Size = New System.Drawing.Size(70, 45)
        Me.Btn_FAR_Add.TabIndex = 6
        Me.Btn_FAR_Add.Text = "+"
        Me.Btn_FAR_Add.UseVisualStyleBackColor = True
        '
        'FormAddRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_FAR_Add)
        Me.Controls.Add(Me.LblCurrRoom)
        Me.Controls.Add(Me.Btn_FAR_AddRoom)
        Me.Controls.Add(Me.Txt_FAR_Total)
        Me.Controls.Add(Me.Btn_FAR_Remove)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormAddRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Add Room"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_FAR_Remove As Button
    Friend WithEvents Txt_FAR_Total As TextBox
    Friend WithEvents Btn_FAR_AddRoom As Button
    Friend WithEvents LblCurrRoom As Label
    Friend WithEvents Btn_FAR_Add As Button
End Class
