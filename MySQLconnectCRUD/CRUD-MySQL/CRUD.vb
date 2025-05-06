Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Display
	Private connString As String = "server=localhost;user id=rangga;password=rangga;database=testing;"
	Private currentId As Integer = -1

	' Add pagination variable
	Private currentPage As Integer = 1
	Private totalPages As Integer = 1
	Private totalRecords As Integer = 0
	Private pageSize As Integer = 10
	Private isSearchMode As Boolean = False
	Private searchName As String = ""
	Private searchPhone As String = ""

	Private Sub Display_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		nudPageSize.Value = pageSize
		LoadDataWithPagination()
	End Sub

	' Get total record count
	Private Function GetTotalRecords(whereClause As String, parameters As List(Of MySqlParameter)) As Integer
		Dim count As Integer = 0
		Try
			Using conn As New MySqlConnection(connString)
				conn.Open()
				Dim query As String = "SELECT COUNT(*) FROM data_kontak " & whereClause

				Using cmd As New MySqlCommand(query, conn)
					If parameters IsNot Nothing Then
						For Each param As MySqlParameter In parameters
							cmd.Parameters.AddRange(parameters.ToArray())
						Next
					End If
					count = Convert.ToInt32(cmd.ExecuteScalar())
				End Using
			End Using
		Catch ex As Exception
			MessageBox.Show("Error Counting Records: " & vbNewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
		Return count
	End Function

	Private Sub CalculateTotalPages()
		If totalRecords > 0 Then
			totalPages = Math.Ceiling(totalRecords / pageSize)
		Else
			totalPages = 1
		End If

		If currentPage > totalPages Then
			currentPage = totalPages
		ElseIf currentPage < 1 Then
			currentPage = 1
		End If
	End Sub

	Private Sub UpdatePaginationInfo()
		lblPageInfo.Text = $"Page {currentPage} of {totalPages} (Total Records: {totalRecords})"
		btnPrevPage.Enabled = (currentPage > 1)
		btnNextPage.Enabled = (currentPage < totalPages)
	End Sub

	Private Sub LoadData()
		isSearchMode = False
		searchName = ""
		searchPhone = ""
		currentPage = 1
		LoadDataWithPagination()
	End Sub

	Private Sub LoadDataWithPagination()
		If isSearchMode Then
			Dim whereClause As String = "WHERE 1=1"
			Dim parameters As New List(Of MySqlParameter)()

			If searchName <> "" Then
				whereClause &= " AND name LIKE @name"
				parameters.Add(New MySqlParameter("@name", "%" & searchName & "%"))
			End If

			If searchPhone <> "" Then
				whereClause &= " AND phone LIKE @phone"
				parameters.Add(New MySqlParameter("@phone", "%" & searchPhone & "%"))
			End If

			totalRecords = GetTotalRecords(whereClause, parameters)
		Else
			totalRecords = GetTotalRecords("", Nothing)
		End If

		CalculateTotalPages()
		UpdatePaginationInfo()
		LoadCurrentPageData()
	End Sub

	Private Sub LoadCurrentPageData()
		Try
			Using conn As New MySqlConnection(connString)
				Dim offset As Integer = (currentPage - 1) * pageSize
				Dim query As String
				Dim cmd As New MySqlCommand()

				If isSearchMode Then
					query = "SELECT * FROM data_kontak WHERE 1=1"
					If searchName <> "" Then
						query &= " AND name LIKE @name"
						cmd.Parameters.AddWithValue("@name", "%" & searchName & "%")
					End If

					If searchPhone <> "" Then
						query &= " AND phone LIKE @phone"
						cmd.Parameters.AddWithValue("@phone", "%" & searchPhone & "%")
					End If

					query &= " ORDER BY id DESC LIMIT @limit OFFSET @offset"
				Else
					query = "SELECT * FROM data_kontak ORDER BY id DESC LIMIT @limit OFFSET @offset"
				End If

				cmd.Parameters.AddWithValue("@limit", pageSize)
				cmd.Parameters.AddWithValue("@offset", offset)
				cmd.CommandText = query
				cmd.Connection = conn

				Dim adapter As New MySqlDataAdapter(cmd)
				Dim dt As New DataTable()
				adapter.Fill(dt)

				dgvContacts.DataSource = dt
				EnsureActionButtonColumn()
			End Using
		Catch ex As Exception
			MessageBox.Show("Error Loading Data: " & vbNewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub EnsureActionButtonColumn()
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

		OptimizeDataGridView()
	End Sub

	Private Sub OptimizeDataGridView()
		Dim dgvType As Type = dgvContacts.GetType()
		Dim pi As System.Reflection.PropertyInfo = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
		pi.SetValue(dgvContacts, True, Nothing)

		With dgvContacts
			.SuspendLayout()
			.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
			.SelectionMode = DataGridViewSelectionMode.FullRowSelect
			.RowHeadersVisible = False
			.AllowUserToAddRows = False
			.AllowUserToDeleteRows = False
			.AllowUserToOrderColumns = True
			.ReadOnly = True
			.VirtualMode = True

			For Each col As DataGridViewColumn In .Columns
				If col.Name <> "Edit" And col.Name <> "Delete" Then
					col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
				End If
			Next

			.DefaultCellStyle.Font = New Font("Arial", 10)
			.RowTemplate.Height = 25

			.ResumeLayout()
		End With
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
		LoadDataWithPagination()
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

		If isSearchMode Then
			Dim whereClause As String = "WHERE 1=1"
			Dim parameters As New List(Of MySqlParameter)()

			If searchName <> "" Then
				whereClause &= " AND name LIKE @name"
				parameters.Add(New MySqlParameter("@name", "%" & searchName & "%"))
			End If

			If searchPhone <> "" Then
				whereClause &= " AND phone LIKE @phone"
				parameters.Add(New MySqlParameter("@phone", "%" & searchPhone & "%"))
			End If

			totalRecords = GetTotalRecords(whereClause, parameters)
		Else
			totalRecords = GetTotalRecords("", Nothing)
		End If
		CalculateTotalPages()

		If currentPage > totalPages AndAlso totalPages > 0 Then
			currentPage = totalPages
		End If

		LoadCurrentPageData()
		UpdatePaginationInfo()
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
			LoadCurrentPageData()
			UpdatePaginationInfo()
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

	Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
		txtName.Clear()
		txtPhone.Clear()

		pageSize = 10
		nudPageSize.Value = 10
		currentPage = 1
		isSearchMode = False
		searchName = ""
		searchPhone = ""

		LoadDataWithPagination()
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
		searchName = name.Trim()
		searchPhone = phone.Trim()
		isSearchMode = (searchName <> "" Or searchPhone <> "")
		currentPage = 1 ' start from the first page when searching
		LoadDataWithPagination()
	End Sub

	Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
		Try
			Dim openDialoag As New OpenFileDialog()
			openDialoag.Filter = "CSV Files (*.csv)|*.csv"
			openDialoag.Title = "Select CSV File"

			If openDialoag.ShowDialog() = DialogResult.OK Then
				Dim fileInfo As New FileInfo(openDialoag.FileName)
				If fileInfo.Length > 1024 * 1024 Then ' 1 MB
					' Ask user if they want to use batch processing
					Dim result As DialogResult = MessageBox.Show("File is large. Do you want to import in batches?", "Large File Detected", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

					If result = DialogResult.Yes Then
						ImportLargeDatasetInBatches(openDialoag.FileName, 1000) ' Adjust batch size as needed
						Return
					End If
				End If

				' Otherwise use the original import method(for similar size files)
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
						isSearchMode = False
						currentPage = 1
						LoadDataWithPagination()
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

	Private Sub ImportLargeDatasetInBatches(filePath As String, batchSize As Integer)
		Try
			Dim lines() As String = File.ReadAllLines(filePath)
			If lines.Length <= 1 Then
				MessageBox.Show("File is empty or has no data or just column header.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			Dim progress As New Form()
			progress.Text = "Importing Data"
			progress.Size = New Size(300, 100)
			progress.FormBorderStyle = FormBorderStyle.FixedDialog
			progress.StartPosition = FormStartPosition.CenterScreen
			progress.MinimizeBox = False
			progress.MaximizeBox = False

			Dim progressBar As New ProgressBar()
			progressBar.Minimum = 0
			progressBar.Maximum = lines.Length - 1 ' Excluding header
			progressBar.Value = 0
			progressBar.Width = 360
			progress.Location = New Point(20, 20)
			progress.Controls.Add(progressBar)

			Dim lblStatus As New Label()
			lblStatus.AutoSize = True
			lblStatus.Location = New Point(20, 50)
			lblStatus.Text = "Importing..."
			progress.Controls.Add(lblStatus)

			' Show the progress form
			progress.Show()
			Application.DoEvents()

			Using conn As New MySqlConnection(connString)
				conn.Open()

				Dim recordProcessed As Integer = 0
				Dim totalRecords As Integer = lines.Length - 1 ' Excluding header

				For batchStart As Integer = 1 To totalRecords Step batchSize
					Using transaction = conn.BeginTransaction()
						Try
							Dim batchEnd As Integer = Math.Min(batchStart + batchSize - 1, totalRecords)

							For i As Integer = batchStart To batchEnd
								Dim parts() As String = lines(i).Split(";"c)
								If parts.Length >= 2 Then
									Dim name As String = parts(0).Trim()
									Dim phone As String = parts(1).Trim()

									Using cmd As New MySqlCommand("INSERT INTO data_kontak (name, phone) VALUES (@name, @phone)", conn, transaction)
										cmd.Parameters.AddWithValue("@name", name)
										cmd.Parameters.AddWithValue("@phone", phone)
										cmd.ExecuteNonQuery()
									End Using
								End If

								recordProcessed += 1
								progressBar.Value = recordProcessed
								lblStatus.Text = $"Importing... {recordProcessed} of {totalRecords} records processed."
								Application.DoEvents()
							Next
							transaction.Commit()
						Catch ex As Exception
							transaction.Rollback()
							MessageBox.Show($"Error importing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
							progress.Close()
							Return
						End Try
					End Using
				Next
			End Using

			progress.Close()
			MessageBox.Show("Data imported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
			currentPage = 1
			isSearchMode = False
			LoadDataWithPagination()

		Catch ex As Exception
			MessageBox.Show("Error Importing Data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

		End Try
	End Sub

	Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
		Try
			Dim saveDialog As New SaveFileDialog()
			saveDialog.Filter = "CSV Files (*.csv)|*.csv"
			saveDialog.Title = "Save CSV File"
			saveDialog.FileName = "data_contacts.csv"

			If saveDialog.ShowDialog() = DialogResult.OK Then
				Dim totalRecords As Integer

				Using conn As New MySqlConnection(connString)
					conn.Open()
					Dim query As String
					Dim cmd As New MySqlCommand()

					If isSearchMode Then
						query = "SELECT * FROM data_kontak WHERE 1=1"
						If searchName <> "" Then
							query &= " AND name LIKE @name"
							cmd.Parameters.AddWithValue("@name", "%" & searchName & "%")
						End If
						If searchPhone <> "" Then
							query &= " AND phone LIKE @phone"
							cmd.Parameters.AddWithValue("@phone", "%" & searchPhone & "%")
						End If

					Else
						query = "SELECT COUNT(*) FROM data_kontak"
					End If

					cmd.CommandText = query
					cmd.Connection = conn

					totalRecords = Convert.ToInt32(cmd.ExecuteScalar())
				End Using

				If totalRecords > 1000 Then
					ExportLargeDatasetInBatches(saveDialog.FileName, 500) ' Adjust batch size as needed
				Else
					Using conn As New MySqlConnection(connString)
						conn.Open()

						Dim query As String
						Dim cmd As New MySqlCommand()

						If isSearchMode Then
							query = "SELECT * FROM data_kontak WHERE 1=1"
							If searchName <> "" Then
								query &= " AND name LIKE @name"
								cmd.Parameters.AddWithValue("@name", "%" & searchName & "%")
							End If
							If searchPhone <> "" Then
								query &= " AND phone LIKE @phone"
								cmd.Parameters.AddWithValue("@phone", "%" & searchPhone & "%")
							End If

							query &= " ORDER BY id"
						Else
							query = "SELECT * FROM data_kontak ORDER BY id"
						End If

						cmd.CommandText = query
						cmd.Connection = conn

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
			End If
		Catch ex As Exception
			MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub ExportLargeDatasetInBatches(filePath As String, batchSize As Integer)
		Try
			Using writer As New StreamWriter(filePath, False)
				writer.WriteLine("id;name;phone") ' Write header

				' Create progress form
				Dim progress As New Form()
				progress.Text = "Exporting Data"
				progress.Size = New Size(400, 100)
				progress.FormBorderStyle = FormBorderStyle.FixedDialog
				progress.StartPosition = FormStartPosition.CenterScreen
				progress.MinimizeBox = False
				progress.MaximizeBox = False

				' Add progress bar
				Dim progressBar As New ProgressBar()
				progressBar.Minimum = 0
				progressBar.Width = 360
				progressBar.Location = New Point(20, 20)
				progress.Controls.Add(progressBar)

				' Status label
				Dim lblStatus As New Label()
				lblStatus.AutoSize = True
				lblStatus.Location = New Point(20, 50)
				lblStatus.Text = "Exporting..."
				progress.Controls.Add(lblStatus)

				' Get total records count for progress bar
				Dim totalrecords As Integer
				Using conn As New MySqlConnection(connString)
					conn.Open()
					Dim query As String
					Dim cmd As New MySqlCommand()

					If isSearchMode Then
						query = "SELECT COUNT(*) FROM data_kontak WHERE 1=1"
						If searchName <> "" Then
							query &= " AND name LIKE @name"
							cmd.Parameters.AddWithValue("@name", "%" & searchName & "%")
						End If
						If searchPhone <> "" Then
							query &= " AND phone LIKE @phone"
							cmd.Parameters.AddWithValue("@phone", "%" & searchPhone & "%")
						End If
					Else
						query = "SELECT COUNT(*) FROM data_kontak"
					End If

					cmd.CommandText = query
					cmd.Connection = conn

					totalrecords = Convert.ToInt32(cmd.ExecuteScalar())
				End Using

				progressBar.Maximum = totalrecords

				progress.Show()
				Application.DoEvents()

				Using conn As New MySqlConnection(connString)
					conn.Open()
					Dim offset As Integer = 0
					Dim recordProcessed As Integer = 0

					While offset < totalrecords
						Dim query As String
						Dim cmd As New MySqlCommand()

						If isSearchMode Then
							query = "SELECT * FROM data_kontak WHERE 1=1"
							If searchName <> "" Then
								query &= " AND name LIKE @name"
								cmd.Parameters.AddWithValue("@name", "%" & searchName & "%")
							End If
							If searchPhone <> "" Then
								query &= " AND phone LIKE @phone"
								cmd.Parameters.AddWithValue("@phone", "%" & searchPhone & "%")
							End If

							query &= " ORDER BY id LIMIT @limit OFFSET @offset"
						Else
							query = "SELECT * FROM data_kontak ORDER BY id  LIMIT @limit OFFSET @offset"
						End If

						cmd.Parameters.AddWithValue("@limit", batchSize)
						cmd.Parameters.AddWithValue("@offset", offset)
						cmd.CommandText = query
						cmd.Connection = conn

						' Execute query for this batch
						Using reader As MySqlDataReader = cmd.ExecuteReader()
							While reader.Read()
								Dim id As Integer = Convert.ToInt32(reader("id"))
								Dim name As String = reader("name").ToString().Replace(";", ",")
								Dim phone As String = reader("phone").ToString().Replace(";", ",")
								writer.WriteLine($"{id};{name};{phone}")
								recordProcessed += 1
								progressBar.Value = recordProcessed
								lblStatus.Text = $"Exporting... {recordProcessed} of {totalrecords} records processed."
								Application.DoEvents()
							End While
						End Using
						offset += batchSize
					End While
				End Using
				progress.Close()
			End Using
			MessageBox.Show("Data exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Catch ex As Exception
			MessageBox.Show("Error Exporting Data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub btnPrevPage_Click(sender As Object, e As EventArgs) Handles btnPrevPage.Click
		If currentPage > 1 Then
			currentPage -= 1
			LoadCurrentPageData()
			UpdatePaginationInfo()
		End If
	End Sub

	Private Sub btnNextPage_Click(sender As Object, e As EventArgs) Handles btnNextPage.Click
		If currentPage < totalPages Then
			currentPage += 1
			LoadCurrentPageData()
			UpdatePaginationInfo()
		End If
	End Sub

	Private Sub nudPageSize_ValueChanged(sender As Object, e As EventArgs) Handles nudPageSize.ValueChanged
		pageSize = CInt(nudPageSize.Value)
		currentPage = 1 ' Reset to first page
		LoadDataWithPagination()
	End Sub
End Class