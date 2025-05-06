Public Class Input
	Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
		Dim catName As String

		catName = InputBox("Please enter your cat?")

		MessageBox.Show("Hi, my cat name is: " & catName)
	End Sub
End Class