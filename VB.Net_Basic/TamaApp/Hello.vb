Public Class FormHello

	Private Sub btnSay_Click(sender As Object, e As EventArgs) Handles btnSay.Click
		MsgBox("Testing")
		MessageBox.Show("test again")
		Console.WriteLine("Text written")

	End Sub

	Private Sub btnVar_Click(sender As Object, e As EventArgs) Handles btnVar.Click
		Dim firstName As string = "rangga", lastName As string = "pratama"
		MessageBox.Show("Hello " & firstName & _
			" " & lastName)
		Console.WriteLine("Your name: " & vbNewLine & firstName & " " & lastName)
	End Sub
End Class
