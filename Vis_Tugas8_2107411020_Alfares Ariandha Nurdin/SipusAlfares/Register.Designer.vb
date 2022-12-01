<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnDaftar = New System.Windows.Forms.Button()
        Me.BtnMasuk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPassReg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtUsernameReg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtFullNameReg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImage = Global.SipusAlfares.My.Resources.Resources.PNJ
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.SipusAlfares.My.Resources.Resources.PNJ
        Me.PictureBox1.Location = New System.Drawing.Point(598, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'BtnDaftar
        '
        Me.BtnDaftar.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnDaftar.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnDaftar.Location = New System.Drawing.Point(372, 260)
        Me.BtnDaftar.Name = "BtnDaftar"
        Me.BtnDaftar.Size = New System.Drawing.Size(146, 33)
        Me.BtnDaftar.TabIndex = 22
        Me.BtnDaftar.Text = "Sign Up"
        Me.BtnDaftar.UseVisualStyleBackColor = False
        '
        'BtnMasuk
        '
        Me.BtnMasuk.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnMasuk.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnMasuk.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnMasuk.Location = New System.Drawing.Point(200, 260)
        Me.BtnMasuk.Name = "BtnMasuk"
        Me.BtnMasuk.Size = New System.Drawing.Size(146, 33)
        Me.BtnMasuk.TabIndex = 21
        Me.BtnMasuk.Text = "Sign In"
        Me.BtnMasuk.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(60, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 39)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "REGISTER SIPUS"
        '
        'TxtPassReg
        '
        Me.TxtPassReg.Location = New System.Drawing.Point(315, 203)
        Me.TxtPassReg.Name = "TxtPassReg"
        Me.TxtPassReg.Size = New System.Drawing.Size(203, 27)
        Me.TxtPassReg.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(200, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 25)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Password"
        '
        'TxtUsernameReg
        '
        Me.TxtUsernameReg.Location = New System.Drawing.Point(315, 157)
        Me.TxtUsernameReg.Name = "TxtUsernameReg"
        Me.TxtUsernameReg.Size = New System.Drawing.Size(203, 27)
        Me.TxtUsernameReg.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(200, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Username"
        '
        'TxtFullNameReg
        '
        Me.TxtFullNameReg.Location = New System.Drawing.Point(315, 109)
        Me.TxtFullNameReg.Name = "TxtFullNameReg"
        Me.TxtFullNameReg.Size = New System.Drawing.Size(203, 27)
        Me.TxtFullNameReg.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(200, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 25)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Full Name"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SipusAlfares.My.Resources.Resources._1807385
        Me.ClientSize = New System.Drawing.Size(712, 367)
        Me.Controls.Add(Me.TxtFullNameReg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnDaftar)
        Me.Controls.Add(Me.BtnMasuk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPassReg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtUsernameReg)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnDaftar As Button
    Friend WithEvents BtnMasuk As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPassReg As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtUsernameReg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtFullNameReg As TextBox
    Friend WithEvents Label3 As Label
End Class
