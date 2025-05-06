Public Class RepeatAction
	Private Dim count As Integer
	Private Dim texts As string
	Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click		

		For count = 1 To 15 Step 3
			MessageBox.Show("Click " & count)
			Beep()
			Threading.Thread.Sleep(3000) ' 3 second
		Next
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		For count = 15 To 0 Step -3
			texts = texts & count & vbNewLine
		Next
		MessageBox.Show(texts)
	End Sub
End Class