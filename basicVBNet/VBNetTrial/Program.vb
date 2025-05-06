Imports System
Imports System.Linq.Expressions.SwitchCase


Module Program
    Sub Main(args As String())
        ' cekNilai()
        ' rentangNilai()
        ' nilaiRentang()

        ' ternaryNilai()

        ' callNilaiSelect()
        ' callDaySelect()
        ' callLulusSelect
        callTipeDataSelect()




    End Sub

    Sub cekNilai()
        Console.Write("Masukan nilai: ")
        Dim nilai As Integer = Console.ReadLine()

        If nilai >= 90 Then
            Console.WriteLine("Nilai A")
        ElseIf nilai >= 80 Then
            Console.WriteLine("Nilai B")
        ElseIf nilai >= 70 Then
            Console.WriteLine("Nilai C")
        Else
            Console.WriteLine("Tidak lulus")
        End If
    End Sub

    Sub rentangNilai()
        Console.Write("Masukan nilai: ")
        Dim nilai As Integer = Console.ReadLine()

        If nilai >= 90 AndAlso nilai < 100 Then
            Console.WriteLine("Nilai A")
        ElseIf nilai >= 80 AndAlso nilai < 90 Then
            Console.WriteLine("Nilai B")
        ElseIf nilai >= 70 AndAlso nilai < 80 Then
            Console.WriteLine("Nilai C")
        Else
            Console.WriteLine("Tidak lulus")
        End If
    End Sub

    Sub nilaiRentang()
        Console.Write("Masukan nilai: ")
        Dim nilai As Integer = Console.ReadLine()

        If nilai >= 90 And nilai < 100 Then
            Console.WriteLine("Nilai A")
        ElseIf nilai >= 80 And nilai < 90 Then
            Console.WriteLine("Nilai B")
        ElseIf nilai >= 70 And nilai < 80 Then
            Console.WriteLine("Nilai C")
        Else
            Console.WriteLine("Tidak lulus")
        End If
    End Sub

    Sub ternaryNilai()
        Dim status As String
        Console.Write("Masukan status: ")
        Dim lulus As String = Console.ReadLine()

        status = If(lulus = "lulus", "Dapat Ijazah", "Tidak dapat Ijazah")
        Console.WriteLine("status: " & status)
    End Sub

    Sub callNilaiSelect()
        Dim selectNilai As New SelectCase()
        selectNilai.nilaiSelect()
    End Sub

    Sub callDaySelect()
        Dim selectDay As New SelectCase()
        selectDay.daySelect()
    End Sub

    Sub callLulusSelect()
        Dim selectLulus As New SelectCase()
        selectLulus.lulusSelect()
    End Sub





End Module
