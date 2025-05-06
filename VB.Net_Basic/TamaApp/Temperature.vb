Public Class Temperature
	Private Sub btnTemperature_Click(sender As Object, e As EventArgs) Handles btnTemperature.Click
		Dim temperature As Double = CDbl(txtTemperature.Text)

		Select Case temperature
			Case Is = 0
				MessageBox.Show("Freezing")
			Case Is < 0
				MessageBox.Show("Sub zero")
			Case 1 To 10
				MessageBox.Show("Cold")
			Case 11 To 20
				MessageBox.Show("Warm")
			Case Else
				MessageBox.Show("Hot")
		End Select

	End Sub
End Class