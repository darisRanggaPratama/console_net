Public Class Grade
	Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
		Dim score As Integer

		If IsNumeric(txtScore.Text) = True Then
			score = CInt(txtScore.Text)
			If score > 70 And score <= 100 Then
				MessageBox.Show("Grade A")
			ElseIf score > 50 And score <= 70 Then
				MessageBox.Show("Grade B")
			ElseIf score > 40 And score <= 50 Then
				MessageBox.Show("Grade C")
			ElseIf score > 30 And score <= 40 Then
				MessageBox.Show("Grade D")
			ElseIf score > 20 And score <= 30 Then
				MessageBox.Show("Grade E")
			ElseIf score > 0 And score <= 20 Then
				MessageBox.Show("Grade F")
			Else
				MessageBox.Show("That is not a valid score." & vbNewLine & "Enter a number between 0 and 100")
				Exit Sub
			End If
		Else
			MsgBox("You must enter a number")
			Exit Sub
		End If
		MessageBox.Show("All done")
	End Sub
End Class