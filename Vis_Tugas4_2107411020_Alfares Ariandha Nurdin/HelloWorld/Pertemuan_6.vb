Imports System.Net.Security

Public Class Pertemuan_6


    ' Tipe Variable dan Value nya

    Dim artists As Short = 2500
    Dim hours As UShort = 5000
    Dim population As Integer = 375000
    Dim seconds As Integer = 3000000
    Dim bugs As Long = 7800000016
    Dim sandGrains As ULong = 1800000000000000000
    Dim unitCost As Single = 899.99
    Dim pi As Double = 3.1415926535
    Dim debt As Decimal = 7600300.5D
    Dim retkey As Byte = 13
    Dim negNum As SByte = -20
    Dim unicodeChar As Char = "A"c
    Dim greeting As String = "hello world"
    Dim flag As Boolean = True
    Dim birthday As Date = #3/17/1900#

    Dim Result
    Dim Age
    Dim i As Integer

    Private Sub BtnPow_Click(sender As Object, e As EventArgs) Handles BtnPow.Click
        If TxtBoxB.Text.Length > 0 And TxtBoxA.Text.Length > 0 Then
            Result = TxtBoxB.Text ^ TxtBoxA.Text
            TxtBoxHasil.Text = Result
        Else
            MsgBox("Harap Isi data terlebih dahulu", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub BtnMultiply_Click(sender As Object, e As EventArgs) Handles BtnMultiply.Click
        If TxtBoxB.Text.Length > 0 And TxtBoxA.Text.Length > 0 Then
            Result = TxtBoxA.Text * TxtBoxB.Text
            TxtBoxHasil.Text = Result
        Else
            MsgBox("Harap Isi data terlebih dahulu", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub BtnSubstract_Click(sender As Object, e As EventArgs) Handles BtnSubstract.Click
        If TxtBoxB.Text.Length > 0 And TxtBoxA.Text.Length > 0 Then
            Result = TxtBoxA.Text - TxtBoxB.Text
            TxtBoxHasil.Text = Result
        Else
            MsgBox("Harap Isi data terlebih dahulu", MsgBoxStyle.Critical, "Kesalahan")
        End If

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtBoxB.Text.Length > 0 And TxtBoxA.Text.Length > 0 Then
            Result = Integer.Parse(TxtBoxA.Text) + Integer.Parse(TxtBoxB.Text)
            TxtBoxHasil.Text = Result
        Else
            MsgBox("Harap Isi data terlebih dahulu", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub BtnDivideFloat_Click(sender As Object, e As EventArgs) Handles BtnDivideFloat.Click

        If TxtBoxB.Text.Length > 0 And TxtBoxA.Text.Length > 0 Then
            Result = TxtBoxB.Text / TxtBoxA.Text
            TxtBoxHasil.Text = Result
        Else
            MsgBox("Harap Isi data terlebih dahulu", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub BtnDivideInt_Click(sender As Object, e As EventArgs) Handles BtnDivideInt.Click
        If TxtBoxB.Text.Length > 0 And TxtBoxA.Text.Length > 0 Then
            Result = TxtBoxB.Text \ TxtBoxA.Text
            TxtBoxHasil.Text = Result
        Else
            MsgBox("Harap Isi data terlebih dahulu", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod.Click
        If TxtBoxB.Text.Length > 0 And TxtBoxA.Text.Length > 0 Then
            Result = TxtBoxB.Text Mod TxtBoxA.Text
            TxtBoxHasil.Text = Result
        Else
            MsgBox("Harap Isi data terlebih dahulu", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub BtnConcat_Click(sender As Object, e As EventArgs) Handles BtnConcat.Click
        If TxtBoxB.Text.Length > 0 And TxtBoxA.Text.Length > 0 Then
            Result = TxtBoxA.Text & TxtBoxB.Text
            TxtBoxHasil.Text = Result
        Else
            MsgBox("Harap Isi data terlebih dahulu", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub BtnToString_Click(sender As Object, e As EventArgs) Handles BtnToString.Click
        Dim originInt As Integer = 12345
        Dim convertString As String
        convertString = originInt.ToString()
        TxtConvertedString.Text = convertString
    End Sub

    Private Sub BtnToInteger_Click(sender As Object, e As EventArgs) Handles BtnToInteger.Click
        Dim originString As String = "12345"
        Dim convertInteger As Integer
        convertInteger = Integer.Parse(originString) + 10
        TxtConvertedInteger.Text = convertInteger
    End Sub

    Private Sub BtnToIntegerCInt_Click(sender As Object, e As EventArgs) Handles BtnToIntegerCInt.Click
        Dim originDouble As Double = 3.1415926535
        Dim convertDblToInt As Integer
        convertDblToInt = CInt(originDouble) + 10
        TxtConvertedInteger.Text = convertDblToInt
    End Sub

    Private Sub ListBoxExampleVariable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxExampleVariable.SelectedIndexChanged
        Dim tipeVariable As String = ListBoxExampleVariable.SelectedItem()
        ' If Statement

        If tipeVariable = "Short" Then
            TxtVariableWithIF.Text = artists
        ElseIf tipeVariable = "UShort" Then
            TxtVariableWithIF.Text = hours
        ElseIf tipeVariable = "Integer" Then
            TxtVariableWithIF.Text = population
        ElseIf tipeVariable = "UInteger" Then
            TxtVariableWithIF.Text = seconds
        ElseIf tipeVariable = "Long" Then
            TxtVariableWithIF.Text = bugs
        ElseIf tipeVariable = "ULong" Then
            TxtVariableWithIF.Text = sandGrains
        ElseIf tipeVariable = "Single" Then
            TxtVariableWithIF.Text = unitCost
        ElseIf tipeVariable = "Double" Then
            TxtVariableWithIF.Text = pi
        ElseIf tipeVariable = "Decimal" Then
            TxtVariableWithIF.Text = debt
        ElseIf tipeVariable = "Byte" Then
            TxtVariableWithIF.Text = retkey
        ElseIf tipeVariable = "SByte" Then
            TxtVariableWithIF.Text = negNum
        ElseIf tipeVariable = "Char" Then
            TxtVariableWithIF.Text = unicodeChar
        ElseIf tipeVariable = "String" Then
            TxtVariableWithIF.Text = greeting
        ElseIf tipeVariable = "Boolean" Then
            TxtVariableWithIF.Text = flag.ToString()
        ElseIf tipeVariable = "Date" Then
            TxtVariableWithIF.Text = birthday
        End If
    End Sub

    Private Sub ListBoxTipeVariableWithSwicth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTipeVariableWithSwitch.SelectedIndexChanged
        Dim tipeVariable As String = ListBoxTipeVariableWithSwitch.SelectedItem()
        Select Case tipeVariable
            Case "Short"
                TxtVariableWithSwitch.Text = artists
            Case "UShort"
                TxtVariableWithSwitch.Text = hours
            Case "Integer"
                TxtVariableWithSwitch.Text = population
            Case "UInteger"
                TxtVariableWithSwitch.Text = seconds
            Case "Long"
                TxtVariableWithSwitch.Text = bugs
            Case "ULong"
                TxtVariableWithSwitch.Text = sandGrains
            Case "Single"
                TxtVariableWithSwitch.Text = unitCost
            Case "Double"
                TxtVariableWithSwitch.Text = pi
            Case "Decimal"
                TxtVariableWithSwitch.Text = debt
            Case "Byte"
                TxtVariableWithSwitch.Text = retkey
            Case "SByte"
                TxtVariableWithSwitch.Text = negNum
            Case "Char"
                TxtVariableWithSwitch.Text = unicodeChar
            Case "String"
                TxtVariableWithSwitch.Text = greeting
            Case "Boolean"
                TxtVariableWithSwitch.Text = flag.ToString()
            Case "Date"
                TxtVariableWithSwitch.Text = birthday
        End Select
    End Sub



    Private Sub TxtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAge.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Harap Hanya Masukkan Angka", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub TxtAge_TextChanged(sender As Object, e As EventArgs) Handles TxtAge.TextChanged
        If TxtAge.Text.Length > 0 Then
            Age = Integer.Parse(TxtAge.Text)
            If Age >= 0 And Age <= 5 Then
                LblWithIf.Text = "Balita"
            ElseIf Age > 5 And Age <= 11 Then
                LblWithIf.Text = "Kanak-kanak"
            ElseIf Age > 11 And Age <= 16 Then
                LblWithIf.Text = "Remaja Awal"

            ElseIf Age > 16 And Age <= 25 Then
                LblWithIf.Text = "Remaja Akhir"

            ElseIf Age > 25 And Age <= 35 Then
                LblWithIf.Text = "Dewasa Awal"

            ElseIf Age > 35 And Age <= 45 Then
                LblWithIf.Text = "Dewasa Akhir"
            ElseIf Age > 45 And Age <= 55 Then
                LblWithIf.Text = "Lansia Awal"

            ElseIf Age > 55 And Age <= 65 Then
                LblWithIf.Text = "Lansia Akhir"

            ElseIf Age > 65 Then
                LblWithIf.Text = "Manula"

            End If

            Select Case Age
                Case 0 To 5
                    LblWithSwitch.Text = "Balita"
                Case 6 To 11
                    LblWithSwitch.Text = "Kanak-kanak"
                Case 12 To 16
                    LblWithSwitch.Text = "Remaja Awal"
                Case 17 To 25
                    LblWithSwitch.Text = "Remaja Akhir"
                Case 26 To 35
                    LblWithSwitch.Text = "Dewasa Awal"
                Case 36 To 45
                    LblWithSwitch.Text = "Dewasa Akhir"
                Case 46 To 55
                    LblWithSwitch.Text = "Lansia Awal"
                Case 56 To 65
                    LblWithSwitch.Text = "Lansia Akhir"
                Case > 65
                    LblWithSwitch.Text = "Manula"
            End Select
        Else
            LblWithIf.Text = "Kategori Umur"
            LblWithSwitch.Text = "Kategori Umur"
        End If
    End Sub

    Private Sub TxtBoxA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxA.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Harap Hanya Masukkan Angka", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub TxtBoxB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxB.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Harap Hanya Masukkan Angka", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub BtnBeginToEnd_Click(sender As Object, e As EventArgs) Handles BtnBeginToEnd.Click
        ListBoxLoop.Items.Clear()
        For i = 0 To 20
            ListBoxLoop.Items.Add(i)
        Next
    End Sub

    Private Sub BtnBeginToEndStep_Click(sender As Object, e As EventArgs) Handles BtnBeginToEndStep.Click
        ListBoxLoop.Items.Clear()
        For i = 0 To 20 Step 5
            ListBoxLoop.Items.Add(i)
        Next
    End Sub

    Private Sub BtnDoWhileLoop_Click(sender As Object, e As EventArgs) Handles BtnDoWhileLoop.Click
        ListBoxLoop.Items.Clear()
        i = 0
        Do While i <= 20
            ListBoxLoop.Items.Add(i)
            i += 1
        Loop
    End Sub

    Private Sub BtnDoLoopWhile_Click(sender As Object, e As EventArgs) Handles BtnDoLoopWhile.Click
        ListBoxLoop.Items.Clear()
        i = 0
        Do
            ListBoxLoop.Items.Add(i)
            i += 5
        Loop While i <= 20

    End Sub
End Class