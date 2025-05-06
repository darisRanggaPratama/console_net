Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Display
	Private connString As String = "server=localhost;user id=rangga;password=rangga;database=testing;"
	Private currentId As Integer = -1


	Private Sub Display_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LoadData()
	End Sub

	Private Sub LoadData()
		Using conn As New MySqlConnection(connString)
			Dim query As New MySqlCommand("SELECT * FROM data_kontak ORDER BY id DESC", conn)
			Dim adapter As New MySqlDataAdapter(query)
			Dim dt As New DataTable()
			adapter.Fill(dt)
			dgvContacts.DataSource = dt
			dgvContacts.Font = New Font("Arial", 10, FontStyle.Regular)

			' Add Columns: Edit and Delete
			If dgvContacts.Columns("Edit") Is Nothing Then
				Dim editCol As New DataGridViewButtonColumn()
				editCol.Name = "Edit"
				editCol.HeaderText = "Edit"
				editCol.Text = "Edit"
				editCol.UseColumnTextForButtonValue = True
				dgvContacts.Columns.Add(editCol)
			End If

			If dgvContacts.Columns("Delete") Is Nothing Then
				Dim deleteCol As New DataGridViewButtonColumn()
				deleteCol.Name = "Delete"
				deleteCol.HeaderText = "Delete"
				deleteCol.Text = "Delete"
				deleteCol.UseColumnTextForButtonValue = True
				dgvContacts.Columns.Add(deleteCol)
			End If
		End Using
	End Sub

	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Using conn As New MySqlConnection(connString)
			Dim query As String = "INSERT INTO data_kontak (name, phone) VALUES (@name, @phone)"
			Using cmd As New MySqlCommand(query, conn)
				cmd.Parameters.AddWithValue("@name", txtName.Text)
				cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
				conn.Open()
				cmd.ExecuteNonQuery()
			End Using
		End Using
		ClearForm()
		LoadData()
	End Sub

	Private Sub DeleteData(id As Integer)
		Using conn As New MySqlConnection(connString)
			Dim query As String = "DELETE FROM data_kontak WHERE id = @id"
			conn.Open()
			Using cmd As New MySqlCommand(query, conn)
				cmd.Parameters.AddWithValue("@id", id)
				cmd.ExecuteNonQuery()
			End Using
		End Using
		LoadData()
	End Sub

	Private Sub UpdateData(id As Integer)
		Using conn As New MySqlConnection(connString)
			Dim query As String = "UPDATE data_kontak SET name = @name, phone = @phone WHERE id = @id"
			conn.Open()
			Using cmd As New MySqlCommand(query, conn)
				cmd.Parameters.AddWithValue("@name", txtName.Text)
				cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
				cmd.Parameters.AddWithValue("@id", id)
				cmd.ExecuteNonQuery()
			End Using
		End Using
		LoadData()
	End Sub

	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		If currentId > 0 Then
			UpdateData(currentId)
			ClearForm()
			LoadData()
		Else
			MessageBox.Show("Select a contact to update.")
		End If
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		ClearForm()
	End Sub

	Private Sub ClearForm()
		txtName.Clear()
		txtPhone.Clear()
		currentId = -1
		btnAdd.Enabled = True
		btnUpdate.Enabled = False
	End Sub

	Private Sub dgvContacts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContacts.CellContentClick
		If e.RowIndex >= 0 Then
			Dim id As Integer = Convert.ToInt32(dgvContacts.Rows(e.RowIndex).Cells("id").Value)
			Dim columnName As String = dgvContacts.Columns(e.ColumnIndex).Name
			If columnName = "Edit" Then
				' load data into the form for editing
				txtName.Text = dgvContacts.Rows(e.RowIndex).Cells("name").Value.ToString()
				txtPhone.Text = dgvContacts.Rows(e.RowIndex).Cells("phone").Value.ToString()
				currentId = id
				btnAdd.Enabled = False
				btnUpdate.Enabled = True
			ElseIf columnName = "Delete" Then
				' confirm deletion
				Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this contact?", "Confirm Delete", MessageBoxButtons.YesNo)
				If result = DialogResult.Yes Then
					DeleteData(id)
					LoadData()
				End If
			End If
		End If
	End Sub

	Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
		SearchData(txtName.Text.Trim(), txtPhone.Text.Trim())
	End Sub

	Private Sub SearchData(name As String, phone As String)
		Using conn As New MySqlConnection(connString)
			Dim query As String = "SELECT * FROM data_kontak WHERE 1=1"
			Using cmd As New MySqlCommand()
				If name <> "" Then
					query &= " AND name LIKE @name"
					cmd.Parameters.AddWithValue("@name", "%" & name & "%")
				End If

				If phone <> "" Then
					query &= " AND phone LIKE @phone"
					cmd.Parameters.AddWithValue("@phone", "%" & phone & "%")
				End If

				query &= " ORDER BY id DESC"
				cmd.CommandText = query
				cmd.Connection = conn

				Dim adapter As New MySqlDataAdapter(cmd)
				Dim dt As New DataTable()
				adapter.Fill(dt)
				dgvContacts.DataSource = dt
			End Using
		End Using
	End Sub

	Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
		txtName.Clear()
		txtPhone.Clear()
		LoadData()
	End Sub

	Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
		Try
			Dim openDialoag As New OpenFileDialog()
			openDialoag.Filter = "CSV Files (*.csv)|*.csv"
			openDialoag.Title = "Select CSV File"

			If openDialoag.ShowDialog() = DialogResult.OK Then
				Dim lines() As String = File.ReadAllLines(openDialoag.FileName)
				If lines.Length <= 1 Then
					MessageBox.Show("File is empty or has no data or just column header.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					Return
				End If

				Using conn As New MySqlConnection(connString)
					conn.Open()
					Dim transaction = conn.BeginTransaction()
					Try
						For i As Integer = 1 To lines.Length - 1 ' Skip the header (first line)
							Dim parts() As String = lines(i).Split(";"c)
							If parts.Length >= 2 Then
								Dim name As String = parts(0).Trim()
								Dim phone As String = parts(1).Trim()

								Dim cmd As New MySqlCommand("INSERT INTO data_kontak (name, phone) VALUES (@name, @phone)", conn, transaction)
								cmd.Parameters.AddWithValue("@name", name)
								cmd.Parameters.AddWithValue("@phone", phone)
								cmd.ExecuteNonQuery()
							End If
						Next

						transaction.Commit()
						MessageBox.Show("Data imported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
						LoadData()
					Catch ex As Exception
						transaction.Rollback()
						MessageBox.Show("Error importing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					End Try
				End Using
			End If
		Catch ex As Exception
			MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
		Try
			Dim saveDialog As New SaveFileDialog()
			saveDialog.Filter = "CSV Files (*.csv)|*.csv"
			saveDialog.Title = "Save CSV File"
			saveDialog.FileName = "data_contacts.csv"

			If saveDialog.ShowDialog() = DialogResult.OK Then
				Using conn As New MySqlConnection(connString)
					conn.Open()

					Dim query As String = "SELECT * FROM data_kontak ORDER BY id"
					Dim cmd As New MySqlCommand(query, conn)
					Dim reader As MySqlDataReader = cmd.ExecuteReader()

					Using writer As New StreamWriter(saveDialog.FileName, False)
						' Write the header
						writer.WriteLine("id;name;phone")

						' Write the data
						While reader.Read()
							Dim id As Integer = Convert.ToInt32(reader("id"))
							Dim name As String = reader("name").ToString().Replace(";", ",")
							Dim phone As String = reader("phone").ToString().Replace(";", ",")
							writer.WriteLine($"{id};{name};{phone}")
						End While
					End Using
					MessageBox.Show("Data exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
				End Using
			End If
		Catch ex As Exception
			MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub
End Class