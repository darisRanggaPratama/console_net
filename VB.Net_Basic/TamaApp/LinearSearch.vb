Public Class LinearSearch
	Private Sub btnLinear_Click(sender As Object, e As EventArgs)
		Dim fruit(10) As String
		Dim target As String
		Dim found As Boolean
		Dim i As Integer

		fruit(0) = "Apple"
		fruit(1) = "ORANGE"
		fruit(2) = "banana"
		fruit(3) = "MaNgO"
		fruit(4) = "GRAPE"
		fruit(5) = "MELON"
		fruit(6) = "PEAR"
		fruit(7) = "STRAWBERRY"
		fruit(8) = "BLUEBERRY"
		fruit(9) = "WATER MELON"

		target = InputBox("Search your favourite fruit?")

		For i = 0 To fruit.Length - 1 Step 1
			' UCase() is equal to .ToUpper
			If fruit(i).ToUpper = UCase(target) Then
				found = True
				Exit for
			End If
		Next

		If found = True Then
			MessageBox.Show("Found it")
		Else
			MessageBox.Show("Not Found")
		End If


	End Sub
End Class