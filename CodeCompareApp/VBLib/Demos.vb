Imports System.IO

Public Class Demos
	Implements IDemos
	Public Function LoadFile() As List(Of String) Implements IDemos.LoadFile
		Dim output As New List(Of String)
		Dim lines As List(Of String) = File.ReadAllLines("D:\up2github\console_net\CodeCompareApp\test.txt").ToList()

		For i As Integer = 0 To lines.Count - 1
			If i Mod 2 = 0 Then
				output.Add(lines(i))
			End If
		Next

		Return output
	End Function

	Public Sub PrintFullName(firstName As String, lastName As String) Implements IDemos.PrintFullName
		Console.WriteLine($"{firstName} {lastName}")
	End Sub




End Class
