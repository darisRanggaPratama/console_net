Public Class Arithmetic
	Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
		Dim number1, number2, result As Decimal

		number1 = txtNumber1.Text
		number2 = txtNumber2.Text
		result = number1 + number2
		MessageBox.Show(number1 & " + " & number2 & " = " & result)

		number1 = txtNumber1.Text
		number2 = txtNumber2.Text
		result = number1 - number2
		MessageBox.Show(number1 & " - " & number2 & " = " & result)

		number1 = txtNumber1.Text
		number2 = txtNumber2.Text
		result = number1 * number2
		MessageBox.Show(number1 & " * " & number2 & " = " & result)

		number1 = txtNumber1.Text
		number2 = txtNumber2.Text
		result = number1 / number2
		MessageBox.Show(number1 & " / " & number2 & " = " & result)

		number1 = txtNumber1.Text
		number2 = txtNumber2.Text
		result = number1 mod number2
		MessageBox.Show(number1 & " % " & number2 & " = " & result)

		' cara lain
		number1 = txtNumber1.Text
		number2 = txtNumber2.Text
		result = number1 \ number2
		MessageBox.Show(number1 & " \ " & number2 & " = " & result)

		number1 = txtNumber1.Text
		number2 = txtNumber2.Text
		result = number1 ^ number2
		MessageBox.Show(number1 & " ^ " & number2 & " = " & result)
	End Sub
End Class