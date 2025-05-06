Public Class arrayItems
	Dim arrInt(4), newArrInt(4) As Integer
	Dim item As Integer = Nothing, total As Integer = Nothing, i As Integer = Nothing
	Dim max As Integer = Nothing, min As Integer = Nothing
	Dim avg As Decimal = Nothing
	Dim texts As String = Nothing

	Private Sub addItem()
		arrInt(0) = 1
		arrInt(1) = 15
		arrInt(2) = 66
		arrInt(3) = 100
		arrInt(4) = 2300
	End Sub

	Private Async Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click
		Await ChooseArrayItemAsync()
	End Sub

	Private Async Function ChooseArrayItemAsync() As Task
		addItem()

		Do While True
			Try
				' Menggunakan Task.Run untuk memastikan InputBox dijalankan di thread UI
				Dim input As String = Await Task.Run(Function() InputBox("Select 1 array item?"))
				item = CInt(input)

				' Menampilkan item yang dipilih
				MessageBox.Show("Item: " & item & " Value: " & arrInt(item))
			Catch ex As Exception
				MessageBox.Show("Error: " & ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		Loop
	End Function

	Private Async Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
		Await ShowAllItemsAsync()
	End Sub

	Private Async Function ShowAllItemsAsync() As Task
		addItem()

		For i = 0 To arrInt.Length - 1 Step 1
			Try
				' Menggunakan Task.Run untuk memastikan MessageBox dijalankan di thread UI
				Await Task.Run(Sub() MessageBox.Show("Index: " & i & " Value: " & arrInt(i)))
			Catch ex As Exception
				MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		Next
	End Function

	Private Sub btnShowAllItem_Click(sender As Object, e As EventArgs) Handles btnShowAllItem.Click
		addItem()

		For i = 0 To arrInt.Length - 1 Step 1
			texts = texts & arrInt(i) & vbNewLine
		Next

		MessageBox.Show(texts)
	End Sub

	Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
		addItem()

		For i = 0 To arrInt.Length - 1 Step 1
			total = total + arrInt(i)
		Next

		MessageBox.Show("Average All Item: " & (total / arrInt.Length))
	End Sub

	Private Sub btnSmall_Click(sender As Object, e As EventArgs) Handles btnSmall.Click
		addItem()

		min = 10000
		For i = 0 To arrInt.Length - 1 Step 1
			If arrInt(i) < min Then
				min = arrInt(i)
			End If
		Next

		MessageBox.Show("The smallest value: " & min)
	End Sub

	Private Sub btnNewValue_Click(sender As Object, e As EventArgs) Handles btnNewValue.Click
		addItem()

		For i = 0 To arrInt.Length - 1 Step 1
			arrInt(i) = arrInt(i) * 2
		Next

		For i = 0 To arrInt.Length - 1 Step 1
			Try
				' Menggunakan Task.Run untuk memastikan MessageBox dijalankan di thread UI
				MessageBox.Show("Index: " & i & " Value: " & arrInt(i))
			Catch ex As Exception
				MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		Next


	End Sub

	Private Sub btnBiggerTwenty_Click(sender As Object, e As EventArgs) Handles btnBiggerTwenty.Click
		addItem()

		For i = 0 To arrInt.Length - 1 Step 1
			If arrInt(i) > 20 Then
				total = total + arrInt(i)
			End If
		Next
		MessageBox.Show("Total of item that bigger than 20 is: " & total)
	End Sub

	Private Sub btnBiggest_Click(sender As Object, e As EventArgs) Handles btnBiggest.Click
		addItem()

		max = 0
		For i = 0 To arrInt.Length - 1 Step 1
			If arrInt(i) > max Then
				max = arrInt(i)
			End If
		Next

		MessageBox.Show("The biggest value: " & max)
	End Sub

	Private Sub btnTotalAll_Click(sender As Object, e As EventArgs) Handles btnTotalAll.Click
		addItem()

		For i = 0 To arrInt.Length - 1 Step 1
			total = total + arrInt(i)
		Next

		MessageBox.Show("Total All Item: " & total)
	End Sub
End Class
