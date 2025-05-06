Public Class Conditional
	Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
		Dim country As String = txtMessage.Text

		If country.ToUpper = "INDONESIA" Then
			MessageBox.Show("Selamat datang di " & country)
		ElseIf country.ToUpper = "SINGAPORE" Then
			MessageBox.Show("Welcome to " & country)
		ElseIf country.ToUpper = "SPAIN" Then
			MessageBox.Show("bienvenido a España")
		Else
			MessageBox.Show("Hello there. I hope you are well")
		End If


	End Sub


End Class