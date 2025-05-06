Public Class InputText
	Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
		Dim firstName, lastName, gender, occupation As String

		firstName = txtFirstName.Text
		lastName = txtLastName.Text
		gender = txtGender.Text
		occupation = lstOccupation.SelectedItem

		MessageBox.Show("Your Name: " & firstName & " " & lastName & _
						vbNewLine & "Gender: " & gender & vbNewLine & _
						"Occupation: " & occupation)
	End Sub

	Private Sub InputText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lstOccupation.Items.Add("Carpenter")
		lstOccupation.Items.Add("Painter")
		lstOccupation.Items.Add("Writer")

	End Sub
End Class