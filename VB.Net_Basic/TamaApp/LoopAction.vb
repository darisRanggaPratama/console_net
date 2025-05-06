Public Class LoopAction
	Private Async Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
		Dim type, message As String
		Dim finish As Integer
		type = Nothing

		Try
			type = InputBox("Type: even or odd")
			finish = CInt(InputBox("Limit of number"))
		Catch err As Exception
			MessageBox.Show("Error. Just type number. " & err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try

		If type = "odd" Then
			message = Await GenerateNumbersAsync(1, finish, 2)
			MessageBox.Show("Odd: " & message, "Odd Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Console.WriteLine("Odd: " & message)
		ElseIf type = "even" Then
			message = Await GenerateNumbersAsync(2, finish, 2)
			MessageBox.Show("Even: " & message, "Even Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Console.WriteLine("Even: " & message)
		Else
			MessageBox.Show("Error. Can't be process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If

	End Sub

	Private Function GenerateNumbersAsync(start As Integer, finish As Integer, stepValue As Integer) As Task(Of String)
		Return Task.Run(Function()
							Dim result As String = String.Empty
							For i As Integer = start To finish Step stepValue
								result &= i & ", "
							Next
							Return result.TrimEnd(", ".ToCharArray())
						End Function)
	End Function
End Class