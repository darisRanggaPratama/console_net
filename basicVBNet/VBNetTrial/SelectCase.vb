Public Class SelectCase
    Sub nilaiSelect()
        Console.Write("Masukan nilai: ")
        Dim nilai As Integer = Console.ReadLine()

        Select Case nilai
            Case 91 To 100
                Console.WriteLine("Nilai A")
            Case 81 To 90
                Console.WriteLine("Nilai B")
            Case 71 To 80
                Console.WriteLine("Nilai C")
            Case Else
                Console.WriteLine("Tidak Lulus")
        End Select
    End Sub

    Sub daySelect()
        Console.Write("Masukan hari: ")
        Dim hari As String = Console.ReadLine()

        Select Case hari
            Case "Senin", "Selasa", "Rabu", "Kamis", "Jumat"
                Console.WriteLine("Ini adalah hari kerja.")
            Case "Sabtu", "Minggu"
                Console.WriteLine("Ini adalah akhir pekan.")
            Case Else
                Console.WriteLine("Hari tidak valid.")
        End Select
    End Sub

    Sub lulusSelect()
        Console.Write("Input nilai: ")
        Dim nilai As Integer = Console.ReadLine()

        Select Case nilai
            Case Is <= 5
                Console.Write("Gagal. Mengulang")
            Case 6
                Console.Write("Tugas tambahan")
            Case 7 To 10
                Console.Write("Lulus")
            Case Else
                Console.Write("Data tidak valid")
        End Select
    End Sub


End Class
