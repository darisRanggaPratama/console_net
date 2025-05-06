Public Class RerunAction
	Private Sub btnFor_Click(sender As Object, e As EventArgs) Handles btnFor.Click
		Dim count As Integer
		For count = 1 To 6 Step 2
			MessageBox.Show("Hello: " & count)
		Next

	End Sub

	Private Sub btnWhile_Click(sender As Object, e As EventArgs) Handles btnWhile.Click
		Dim count As Integer

		Do While count <= 6
			MessageBox.Show("Hi: " & count)
			count += 2
		Loop
	End Sub

	Private Sub btnUntil_Click(sender As Object, e As EventArgs) Handles btnUntil.Click
		Dim count As Integer

		Do Until count = 6
			MessageBox.Show("Hi: " & count)
			count += 2
		Loop
	End Sub

	Private Sub btnLoop_Click(sender As Object, e As EventArgs) Handles btnLoop.Click
		Dim count As Integer

		Do
			MessageBox.Show("Hi: " & count)
			count += 2
		Loop Until count = 6
	End Sub

	Private Sub btnLoopWhile_Click(sender As Object, e As EventArgs) Handles btnLoopWhile.Click
		Dim count As Integer

		Do
			MessageBox.Show("Hi: " & count)
			count += 2
		Loop While count <= 6
	End Sub

	Private Async Sub btnRunLoop_Click(sender As Object, e As EventArgs) Handles btnRunLoop.Click
		Await RunLoopAsync()
	End Sub

	Private Async Function RunLoopAsync() As Task
		Dim name As String = String.Empty

		Do While name <> "TAMA"
			' Menggunakan Task.Run untuk memastikan InputBox dijalankan di thread UI
			name = Await Task.Run(Function() InputBox("Please enter your name: ").ToUpper())
		Loop

		' Menampilkan pesan setelah loop selesai
		MessageBox.Show("Hi " & name)
	End Function

	Private Sub btnNumber_Clickck(sender As Object, e As EventArgs) Handles btnNumber.Click
		Dim age As Integer
		Dim strAge As String = Nothing

		Do While IsNumeric(strAge) = False
			strAge = InputBox("Please enter your age in years?")
		Loop
		age = CInt(strAge)
		MessageBox.Show("Hello you are: " & age)
	End Sub
	
    Private Async Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btnNumber.Click
        Await RunNumberLoopAsync()
    End Sub

    Private Async Function RunNumberLoopAsync() As Task
        Dim age As Integer
        Dim strAge As String = String.Empty

        Do While Not IsNumeric(strAge)
            ' Menggunakan Task.Run untuk memastikan InputBox dijalankan di thread UI
            strAge = Await Task.Run(Function() InputBox("Please enter your age in years?"))
        Loop

        age = CInt(strAge)
        MessageBox.Show("Hello, you are: " & age)
    End Function
End Class
