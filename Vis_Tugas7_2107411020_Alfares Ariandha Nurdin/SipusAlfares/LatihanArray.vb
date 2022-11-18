﻿Public Class LatihanArray

    'Belajar Array
    Public Sub runArrayBasic()
        Dim intData(5) As Integer
        Dim i, j As Integer

        For i = 0 To intData.Length() - 1
            intData(i) = i + 10
        Next

        For j = 0 To intData.Length() - 1
            ListBoxArrayStatic.Items.Add(intData(j))
            intData(j) = 0
        Next

    End Sub

    Public Sub runArrayDynamic()
        Dim buah(5) As String
        buah(0) = "Apple"
        buah(1) = "Pisang"
        buah(2) = "Mangga"
        buah(3) = "Jambu"
        buah(4) = "Rambutan"

        ReDim Preserve buah(7)
        buah(5) = "Salak"
        buah(6) = "Durian"
        buah(7) = "Sirsak"

        For i = 0 To buah.Length() - 1
            ListBoxArrayDynamic.Items.Add(buah(i))
        Next

    End Sub

    Public Sub runArrayMulti()
        Dim buahJumlah(,) As Object = {{"Apple", 3}, {"Pisang", 10}, {"Mangga", 7}, {"Jambu", 5}, {"Rambutan", 15}}

        'buahJumlah.LongLength

        For i_horizontal = 0 To buahJumlah.GetLength(1)
            Dim buahDanJumlah As String = ""
            For j_vertical = 0 To 1
                buahDanJumlah += buahJumlah(i_horizontal, j_vertical) & " | "
                buahJumlah(i_horizontal, j_vertical) = ""
            Next
            ListBoxArrayMulti.Items.Add(buahDanJumlah)
        Next
    End Sub

    'Belajar Collections

    Public Sub runArrayList()
        Dim students As New ArrayList()
        students.Add({"Fares", "TI-3A", "Tangerang", "2021"})
        students.Add({"Amir", "TI-3B", "Jakarta", "2020"})

        For Each rowStudent In students
            Dim dataList As String = rowStudent(0) & " | " & rowStudent(1) & " | " & rowStudent(2) & " | " & rowStudent(3)
            ListBoxArrayList.Items.Add(dataList)
        Next
        students.Clear()
    End Sub

    Public Sub runHashTable()
        Dim students As New Hashtable()
        students.Add("A100", {"Fares", "TI-3A", "Tangerang", "2021"})
        students.Add("A101", {"Amir", "TI-3B", "Jakarta", "2020"})

        Dim keyStudents As ICollection = students.Keys()

        For Each rowKoleksis In keyStudents
            Dim rowStudent As String() = students(rowKoleksis)
            Dim dataList As String = rowStudent(0) & " | " & rowStudent(1) & " | " & rowStudent(2) & " | " & rowStudent(3)
            ListBoxHashTable.Items.Add(dataList)
        Next
        students.Clear()
    End Sub

    Public Sub runStackCollection()
        Dim stackBuah As Stack = New Stack()
        stackBuah.Push("Apple")
        stackBuah.Push("Pisang")
        stackBuah.Push("Mangga")
        stackBuah.Push("Rambutan")

        For Each item In stackBuah
            ListBoxStack.Items.Add(item)
        Next
        stackBuah.Clear()
    End Sub

    Public Sub runQueueCollection()
        Dim queueBuah As Queue = New Queue()
        queueBuah.Enqueue("Apple")
        queueBuah.Enqueue("Pisang")
        queueBuah.Enqueue("Mangga")
        queueBuah.Enqueue("Rambutan")

        For Each item In queueBuah
            ListBoxQueue.Items.Add(item)
        Next
        queueBuah.Clear()
    End Sub

    Private Sub LatihanArray_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        runArrayBasic()
        runArrayDynamic()
        runArrayMulti()
        runArrayList()
        runHashTable()
        runStackCollection()
        runQueueCollection()
    End Sub

    Private Sub LatihanArray_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        ListBoxArrayStatic.Items.Clear()
        ListBoxArrayDynamic.Items.Clear()
        ListBoxArrayMulti.Items.Clear()
        ListBoxArrayList.Items.Clear()
        ListBoxHashTable.Items.Clear()
        ListBoxStack.Items.Clear()
        ListBoxQueue.Items.Clear()
    End Sub
End Class