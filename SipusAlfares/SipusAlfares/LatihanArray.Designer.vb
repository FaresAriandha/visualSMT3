<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LatihanArray
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxArrayStatic = New System.Windows.Forms.ListBox()
        Me.ListBoxArrayDynamic = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBoxArrayMulti = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBoxArrayList = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBoxHashTable = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBoxSortedList = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBoxStack = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBoxQueue = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Demo Array Static"
        '
        'ListBoxArrayStatic
        '
        Me.ListBoxArrayStatic.FormattingEnabled = True
        Me.ListBoxArrayStatic.ItemHeight = 20
        Me.ListBoxArrayStatic.Location = New System.Drawing.Point(17, 47)
        Me.ListBoxArrayStatic.Name = "ListBoxArrayStatic"
        Me.ListBoxArrayStatic.Size = New System.Drawing.Size(186, 184)
        Me.ListBoxArrayStatic.TabIndex = 4
        '
        'ListBoxArrayDynamic
        '
        Me.ListBoxArrayDynamic.FormattingEnabled = True
        Me.ListBoxArrayDynamic.ItemHeight = 20
        Me.ListBoxArrayDynamic.Location = New System.Drawing.Point(264, 47)
        Me.ListBoxArrayDynamic.Name = "ListBoxArrayDynamic"
        Me.ListBoxArrayDynamic.Size = New System.Drawing.Size(186, 184)
        Me.ListBoxArrayDynamic.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(264, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Demo Array Dynamic"
        '
        'ListBoxArrayMulti
        '
        Me.ListBoxArrayMulti.FormattingEnabled = True
        Me.ListBoxArrayMulti.ItemHeight = 20
        Me.ListBoxArrayMulti.Location = New System.Drawing.Point(505, 47)
        Me.ListBoxArrayMulti.Name = "ListBoxArrayMulti"
        Me.ListBoxArrayMulti.Size = New System.Drawing.Size(186, 184)
        Me.ListBoxArrayMulti.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(505, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Demo Array Multi"
        '
        'ListBoxArrayList
        '
        Me.ListBoxArrayList.FormattingEnabled = True
        Me.ListBoxArrayList.ItemHeight = 20
        Me.ListBoxArrayList.Location = New System.Drawing.Point(17, 290)
        Me.ListBoxArrayList.Name = "ListBoxArrayList"
        Me.ListBoxArrayList.Size = New System.Drawing.Size(186, 184)
        Me.ListBoxArrayList.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(17, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Demo Array List"
        '
        'ListBoxHashTable
        '
        Me.ListBoxHashTable.FormattingEnabled = True
        Me.ListBoxHashTable.ItemHeight = 20
        Me.ListBoxHashTable.Location = New System.Drawing.Point(746, 47)
        Me.ListBoxHashTable.Name = "ListBoxHashTable"
        Me.ListBoxHashTable.Size = New System.Drawing.Size(351, 184)
        Me.ListBoxHashTable.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(746, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Demo Hash Table"
        '
        'ListBoxSortedList
        '
        Me.ListBoxSortedList.FormattingEnabled = True
        Me.ListBoxSortedList.ItemHeight = 20
        Me.ListBoxSortedList.Location = New System.Drawing.Point(505, 290)
        Me.ListBoxSortedList.Name = "ListBoxSortedList"
        Me.ListBoxSortedList.Size = New System.Drawing.Size(186, 184)
        Me.ListBoxSortedList.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(505, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Demo Sorted List"
        '
        'ListBoxStack
        '
        Me.ListBoxStack.FormattingEnabled = True
        Me.ListBoxStack.ItemHeight = 20
        Me.ListBoxStack.Location = New System.Drawing.Point(746, 290)
        Me.ListBoxStack.Name = "ListBoxStack"
        Me.ListBoxStack.Size = New System.Drawing.Size(186, 184)
        Me.ListBoxStack.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(746, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Demo Stack"
        '
        'ListBoxQueue
        '
        Me.ListBoxQueue.FormattingEnabled = True
        Me.ListBoxQueue.ItemHeight = 20
        Me.ListBoxQueue.Location = New System.Drawing.Point(982, 290)
        Me.ListBoxQueue.Name = "ListBoxQueue"
        Me.ListBoxQueue.Size = New System.Drawing.Size(186, 184)
        Me.ListBoxQueue.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(982, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 25)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Demo Queue"
        '
        'LatihanArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 555)
        Me.Controls.Add(Me.ListBoxQueue)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ListBoxStack)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListBoxSortedList)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBoxHashTable)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBoxArrayList)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBoxArrayMulti)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBoxArrayDynamic)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBoxArrayStatic)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LatihanArray"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LatihanArray"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxArrayStatic As ListBox
    Friend WithEvents ListBoxArrayDynamic As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBoxArrayMulti As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBoxArrayList As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBoxHashTable As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBoxSortedList As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ListBoxStack As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBoxQueue As ListBox
    Friend WithEvents Label8 As Label
End Class
