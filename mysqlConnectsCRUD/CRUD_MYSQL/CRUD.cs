using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace CRUD_MYSQL
{
	public partial class Display : Form
	{
		private string connString = "server=localhost;user id=rangga;password=rangga;database=testing;";
		private int currentId = -1;

		// Add pagination variables
		private int currentPage = 1;
		private int totalPages = 1;
		private int totalRecords = 0;
		private int pageSize = 10;
		private bool isSearchMode = false;
		private string searchName = "";
		private string searchPhone = "";

		public Display()
		{
			InitializeComponent();
		}

		private void Display_Load(object sender, EventArgs e)
		{
			nudPageSize.Value = pageSize;
			LoadDataWithPagination();
		}

		// Get total record count
		private int GetTotalRecords(string whereClause, List<MySqlParameter> parameters)
		{
			int count = 0;
			try
			{
				using (MySqlConnection conn = new MySqlConnection(connString))
				{
					conn.Open();
					string query = "SELECT COUNT(*) FROM data_kontak " + whereClause;

					using (MySqlCommand cmd = new MySqlCommand(query, conn))
					{
						if (parameters != null)
						{
							cmd.Parameters.AddRange(parameters.ToArray());
						}
						count = Convert.ToInt32(cmd.ExecuteScalar());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error Counting Records: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return count;
		}

		private void CalculateTotalPages()
		{
			if (totalRecords > 0)
			{
				totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
			}
			else
			{
				totalPages = 1;
			}

			if (currentPage > totalPages)
			{
				currentPage = totalPages;
			}
			else if (currentPage < 1)
			{
				currentPage = 1;
			}
		}

		private void UpdatePaginationInfo()
		{
			lblPageInfo.Text = $"Page {currentPage} of {totalPages} (Total Records: {totalRecords})";
			btnPrevPage.Enabled = (currentPage > 1);
			btnNextPage.Enabled = (currentPage < totalPages);
		}

		private void LoadData()
		{
			isSearchMode = false;
			searchName = "";
			searchPhone = "";
			currentPage = 1;
			LoadDataWithPagination();
		}

		private void LoadDataWithPagination()
		{
			if (isSearchMode)
			{
				string whereClause = "WHERE 1=1";
				List<MySqlParameter> parameters = new List<MySqlParameter>();

				if (searchName != "")
				{
					whereClause += " AND name LIKE @name";
					parameters.Add(new MySqlParameter("@name", "%" + searchName + "%"));
				}

				if (searchPhone != "")
				{
					whereClause += " AND phone LIKE @phone";
					parameters.Add(new MySqlParameter("@phone", "%" + searchPhone + "%"));
				}

				totalRecords = GetTotalRecords(whereClause, parameters);
			}
			else
			{
				totalRecords = GetTotalRecords("", null);
			}

			CalculateTotalPages();
			UpdatePaginationInfo();
			LoadCurrentPageData();
		}

		private void LoadCurrentPageData()
		{
			try
			{
				using (MySqlConnection conn = new MySqlConnection(connString))
				{
					int offset = (currentPage - 1) * pageSize;
					string query;
					MySqlCommand cmd = new MySqlCommand();

					if (isSearchMode)
					{
						query = "SELECT * FROM data_kontak WHERE 1=1";
						if (searchName != "")
						{
							query += " AND name LIKE @name";
							cmd.Parameters.AddWithValue("@name", "%" + searchName + "%");
						}

						if (searchPhone != "")
						{
							query += " AND phone LIKE @phone";
							cmd.Parameters.AddWithValue("@phone", "%" + searchPhone + "%");
						}

						query += " ORDER BY id DESC LIMIT @limit OFFSET @offset";
					}
					else
					{
						query = "SELECT * FROM data_kontak ORDER BY id DESC LIMIT @limit OFFSET @offset";
					}

					cmd.Parameters.AddWithValue("@limit", pageSize);
					cmd.Parameters.AddWithValue("@offset", offset);
					cmd.CommandText = query;
					cmd.Connection = conn;

					MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					adapter.Fill(dt);

					dgvContacts.DataSource = dt;
					EnsureActionButtonColumn();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error Loading Data: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void EnsureActionButtonColumn()
		{
			if (dgvContacts.Columns["Edit"] == null)
			{
				DataGridViewButtonColumn editCol = new DataGridViewButtonColumn();
				editCol.Name = "Edit";
				editCol.HeaderText = "Edit";
				editCol.Text = "Edit";
				editCol.UseColumnTextForButtonValue = true;
				dgvContacts.Columns.Add(editCol);
			}

			if (dgvContacts.Columns["Delete"] == null)
			{
				DataGridViewButtonColumn deleteCol = new DataGridViewButtonColumn();
				deleteCol.Name = "Delete";
				deleteCol.HeaderText = "Delete";
				deleteCol.Text = "Delete";
				deleteCol.UseColumnTextForButtonValue = true;
				dgvContacts.Columns.Add(deleteCol);
			}

			OptimizeDataGridView();
		}

		private void OptimizeDataGridView()
		{
			Type dgvType = dgvContacts.GetType();
			PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			pi.SetValue(dgvContacts, true, null);

			dgvContacts.SuspendLayout();
			dgvContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
			dgvContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvContacts.RowHeadersVisible = false;
			dgvContacts.AllowUserToAddRows = false;
			dgvContacts.AllowUserToDeleteRows = false;
			dgvContacts.AllowUserToOrderColumns = true;
			dgvContacts.ReadOnly = true;
			dgvContacts.VirtualMode = true;

			foreach (DataGridViewColumn col in dgvContacts.Columns)
			{
				if (col.Name != "Edit" && col.Name != "Delete")
				{
					col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
				}
			}

			dgvContacts.DefaultCellStyle.Font = new Font("Arial", 10);
			dgvContacts.RowTemplate.Height = 25;

			dgvContacts.ResumeLayout();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(connString))
			{
				string query = "INSERT INTO data_kontak (name, phone) VALUES (@name, @phone)";
				using (MySqlCommand cmd = new MySqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@name", txtName.Text);
					cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
					conn.Open();
					cmd.ExecuteNonQuery();
				}
			}
			ClearForm();
			LoadDataWithPagination();
		}

		private void DeleteData(int id)
		{
			using (MySqlConnection conn = new MySqlConnection(connString))
			{
				string query = "DELETE FROM data_kontak WHERE id = @id";
				conn.Open();
				using (MySqlCommand cmd = new MySqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@id", id);
					cmd.ExecuteNonQuery();
				}
			}

			if (isSearchMode)
			{
				string whereClause = "WHERE 1=1";
				List<MySqlParameter> parameters = new List<MySqlParameter>();

				if (searchName != "")
				{
					whereClause += " AND name LIKE @name";
					parameters.Add(new MySqlParameter("@name", "%" + searchName + "%"));
				}

				if (searchPhone != "")
				{
					whereClause += " AND phone LIKE @phone";
					parameters.Add(new MySqlParameter("@phone", "%" + searchPhone + "%"));
				}

				totalRecords = GetTotalRecords(whereClause, parameters);
			}
			else
			{
				totalRecords = GetTotalRecords("", null);
			}
			CalculateTotalPages();

			if (currentPage > totalPages && totalPages > 0)
			{
				currentPage = totalPages;
			}

			LoadCurrentPageData();
			UpdatePaginationInfo();
		}

		private void UpdateData(int id)
		{
			using (MySqlConnection conn = new MySqlConnection(connString))
			{
				string query = "UPDATE data_kontak SET name = @name, phone = @phone WHERE id = @id";
				conn.Open();
				using (MySqlCommand cmd = new MySqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@name", txtName.Text);
					cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
					cmd.Parameters.AddWithValue("@id", id);
					cmd.ExecuteNonQuery();
				}
			}
			LoadData();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (currentId > 0)
			{
				UpdateData(currentId);
				ClearForm();
				LoadCurrentPageData();
				UpdatePaginationInfo();
			}
			else
			{
				MessageBox.Show("Select a contact to update.");
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearForm();
		}

		private void ClearForm()
		{
			txtName.Clear();
			txtPhone.Clear();
			currentId = -1;
			btnAdd.Enabled = true;
			btnUpdate.Enabled = false;
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtName.Clear();
			txtPhone.Clear();
			LoadData();
		}

		private void dgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				int id = Convert.ToInt32(dgvContacts.Rows[e.RowIndex].Cells["id"].Value);
				string columnName = dgvContacts.Columns[e.ColumnIndex].Name;
				if (columnName == "Edit")
				{
					// load data into the form for editing
					txtName.Text = dgvContacts.Rows[e.RowIndex].Cells["name"].Value.ToString();
					txtPhone.Text = dgvContacts.Rows[e.RowIndex].Cells["phone"].Value.ToString();
					currentId = id;
					btnAdd.Enabled = false;
					btnUpdate.Enabled = true;
				}
				else if (columnName == "Delete")
				{
					// confirm deletion
					DialogResult result = MessageBox.Show("Are you sure you want to delete this contact?", "Confirm Delete", MessageBoxButtons.YesNo);
					if (result == DialogResult.Yes)
					{
						DeleteData(id);
						LoadData();
					}
				}
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			SearchData(txtName.Text.Trim(), txtPhone.Text.Trim());
		}

		private void SearchData(string name, string phone)
		{
			searchName = name.Trim();
			searchPhone = phone.Trim();
			isSearchMode = (searchName != "" || searchPhone != "");
			currentPage = 1; // start from the first page when searching
			LoadDataWithPagination();
		}

		private void btnUpload_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openDialog = new OpenFileDialog();
				openDialog.Filter = "CSV Files (*.csv)|*.csv";
				openDialog.Title = "Select CSV File";

				if (openDialog.ShowDialog() == DialogResult.OK)
				{
					FileInfo fileInfo = new FileInfo(openDialog.FileName);
					if (fileInfo.Length > 1024 * 1024) // 1 MB
					{
						// Ask user if they want to use batch processing
						DialogResult result = MessageBox.Show("File is large. Do you want to import in batches?", "Large File Detected", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

						if (result == DialogResult.Yes)
						{
							ImportLargeDatasetInBatches(openDialog.FileName, 1000); // Adjust batch size as needed
							return;
						}
					}

					// Otherwise use the original import method (for smaller size files)
					string[] lines = File.ReadAllLines(openDialog.FileName);
					if (lines.Length <= 1)
					{
						MessageBox.Show("File is empty or has no data or just column header.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					using (MySqlConnection conn = new MySqlConnection(connString))
					{
						conn.Open();
						MySqlTransaction transaction = conn.BeginTransaction();
						try
						{
							for (int i = 1; i < lines.Length; i++) // Skip the header (first line)
							{
								string[] parts = lines[i].Split(';');
								if (parts.Length >= 2)
								{
									string name = parts[0].Trim();
									string phone = parts[1].Trim();

									using (MySqlCommand cmd = new MySqlCommand("INSERT INTO data_kontak (name, phone) VALUES (@name, @phone)", conn, transaction))
									{
										cmd.Parameters.AddWithValue("@name", name);
										cmd.Parameters.AddWithValue("@phone", phone);
										cmd.ExecuteNonQuery();
									}
								}
							}

							transaction.Commit();
							MessageBox.Show("Data imported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							isSearchMode = false;
							currentPage = 1;
							LoadDataWithPagination();
						}
						catch (Exception ex)
						{
							transaction.Rollback();
							MessageBox.Show("Error importing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ImportLargeDatasetInBatches(string filePath, int batchSize)
		{
			try
			{
				string[] lines = File.ReadAllLines(filePath);
				if (lines.Length <= 1)
				{
					MessageBox.Show("File is empty or has no data or just column header.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				Form progress = new Form();
				progress.Text = "Importing Data";
				progress.Size = new Size(300, 100);
				progress.FormBorderStyle = FormBorderStyle.FixedDialog;
				progress.StartPosition = FormStartPosition.CenterScreen;
				progress.MinimizeBox = false;
				progress.MaximizeBox = false;

				ProgressBar progressBar = new ProgressBar();
				progressBar.Minimum = 0;
				progressBar.Maximum = lines.Length - 1; // Excluding header
				progressBar.Value = 0;
				progressBar.Width = 360;
				progressBar.Location = new Point(20, 20);
				progress.Controls.Add(progressBar);

				Label lblStatus = new Label();
				lblStatus.AutoSize = true;
				lblStatus.Location = new Point(20, 50);
				lblStatus.Text = "Importing...";
				progress.Controls.Add(lblStatus);

				// Show the progress form
				progress.Show();
				Application.DoEvents();

				using (MySqlConnection conn = new MySqlConnection(connString))
				{
					conn.Open();

					int recordProcessed = 0;
					int totalRecords = lines.Length - 1; // Excluding header

					for (int batchStart = 1; batchStart <= totalRecords; batchStart += batchSize)
					{
						using (MySqlTransaction transaction = conn.BeginTransaction())
						{
							try
							{
								int batchEnd = Math.Min(batchStart + batchSize - 1, totalRecords);

								for (int i = batchStart; i <= batchEnd; i++)
								{
									string[] parts = lines[i].Split(';');
									if (parts.Length >= 2)
									{
										string name = parts[0].Trim();
										string phone = parts[1].Trim();

										using (MySqlCommand cmd = new MySqlCommand("INSERT INTO data_kontak (name, phone) VALUES (@name, @phone)", conn, transaction))
										{
											cmd.Parameters.AddWithValue("@name", name);
											cmd.Parameters.AddWithValue("@phone", phone);
											cmd.ExecuteNonQuery();
										}
									}

									recordProcessed++;
									progressBar.Value = recordProcessed;
									lblStatus.Text = $"Importing... {recordProcessed} of {totalRecords} records processed.";
									Application.DoEvents();
								}
								transaction.Commit();
							}
							catch (Exception ex)
							{
								transaction.Rollback();
								MessageBox.Show($"Error importing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								progress.Close();
								return;
							}
						}
					}
				}

				progress.Close();
				MessageBox.Show("Data imported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				currentPage = 1;
				isSearchMode = false;
				LoadDataWithPagination();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error Importing Data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnDownload_Click(object sender, EventArgs e)
		{
			try
			{
				SaveFileDialog saveDialog = new SaveFileDialog();
				saveDialog.Filter = "CSV Files (*.csv)|*.csv";
				saveDialog.Title = "Save CSV File";
				saveDialog.FileName = "data_contacts.csv";

				if (saveDialog.ShowDialog() == DialogResult.OK)
				{
					int totalRecords;

					using (MySqlConnection conn = new MySqlConnection(connString))
					{
						conn.Open();
						string query;
						MySqlCommand cmd = new MySqlCommand();

						if (isSearchMode)
						{
							query = "SELECT COUNT(*) FROM data_kontak WHERE 1=1";
							if (searchName != "")
							{
								query += " AND name LIKE @name";
								cmd.Parameters.AddWithValue("@name", "%" + searchName + "%");
							}
							if (searchPhone != "")
							{
								query += " AND phone LIKE @phone";
								cmd.Parameters.AddWithValue("@phone", "%" + searchPhone + "%");
							}
						}
						else
						{
							query = "SELECT COUNT(*) FROM data_kontak";
						}

						cmd.CommandText = query;
						cmd.Connection = conn;

						totalRecords = Convert.ToInt32(cmd.ExecuteScalar());
					}

					if (totalRecords > 1000)
					{
						ExportLargeDatasetInBatches(saveDialog.FileName, 500); // Adjust batch size as needed
					}
					else
					{
						using (MySqlConnection conn = new MySqlConnection(connString))
						{
							conn.Open();

							string query;
							MySqlCommand cmd = new MySqlCommand();

							if (isSearchMode)
							{
								query = "SELECT * FROM data_kontak WHERE 1=1";
								if (searchName != "")
								{
									query += " AND name LIKE @name";
									cmd.Parameters.AddWithValue("@name", "%" + searchName + "%");
								}
								if (searchPhone != "")
								{
									query += " AND phone LIKE @phone";
									cmd.Parameters.AddWithValue("@phone", "%" + searchPhone + "%");
								}

								query += " ORDER BY id";
							}
							else
							{
								query = "SELECT * FROM data_kontak ORDER BY id";
							}

							cmd.CommandText = query;
							cmd.Connection = conn;

							MySqlDataReader reader = cmd.ExecuteReader();

							using (StreamWriter writer = new StreamWriter(saveDialog.FileName, false))
							{
								// Write the header
								writer.WriteLine("id;name;phone");

								// Write the data
								while (reader.Read())
								{
									int id = Convert.ToInt32(reader["id"]);
									string name = reader["name"].ToString().Replace(";", ",");
									string phone = reader["phone"].ToString().Replace(";", ",");
									writer.WriteLine($"{id};{name};{phone}");
								}
							}
							MessageBox.Show("Data exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ExportLargeDatasetInBatches(string filePath, int batchSize)
		{
			try
			{
				using (StreamWriter writer = new StreamWriter(filePath, false))
				{
					writer.WriteLine("id;name;phone"); // Write header

					// Create progress form
					Form progress = new Form();
					progress.Text = "Exporting Data";
					progress.Size = new Size(400, 100);
					progress.FormBorderStyle = FormBorderStyle.FixedDialog;
					progress.StartPosition = FormStartPosition.CenterScreen;
					progress.MinimizeBox = false;
					progress.MaximizeBox = false;

					// Add progress bar
					ProgressBar progressBar = new ProgressBar();
					progressBar.Minimum = 0;
					progressBar.Width = 360;
					progressBar.Location = new Point(20, 20);
					progress.Controls.Add(progressBar);

					// Status label
					Label lblStatus = new Label();
					lblStatus.AutoSize = true;
					lblStatus.Location = new Point(20, 50);
					lblStatus.Text = "Exporting...";
					progress.Controls.Add(lblStatus);

					// Get total records count for progress bar
					int totalRecords;
					using (MySqlConnection conn = new MySqlConnection(connString))
					{
						conn.Open();
						string query;
						MySqlCommand cmd = new MySqlCommand();

						if (isSearchMode)
						{
							query = "SELECT COUNT(*) FROM data_kontak WHERE 1=1";
							if (searchName != "")
							{
								query += " AND name LIKE @name";
								cmd.Parameters.AddWithValue("@name", "%" + searchName + "%");
							}
							if (searchPhone != "")
							{
								query += " AND phone LIKE @phone";
								cmd.Parameters.AddWithValue("@phone", "%" + searchPhone + "%");
							}
						}
						else
						{
							query = "SELECT COUNT(*) FROM data_kontak";
						}

						cmd.CommandText = query;
						cmd.Connection = conn;

						totalRecords = Convert.ToInt32(cmd.ExecuteScalar());
					}

					progressBar.Maximum = totalRecords;

					progress.Show();
					Application.DoEvents();

					using (MySqlConnection conn = new MySqlConnection(connString))
					{
						conn.Open();
						int offset = 0;
						int recordProcessed = 0;

						while (offset < totalRecords)
						{
							string query;
							MySqlCommand cmd = new MySqlCommand();

							if (isSearchMode)
							{
								query = "SELECT * FROM data_kontak WHERE 1=1";
								if (searchName != "")
								{
									query += " AND name LIKE @name";
									cmd.Parameters.AddWithValue("@name", "%" + searchName + "%");
								}
								if (searchPhone != "")
								{
									query += " AND phone LIKE @phone";
									cmd.Parameters.AddWithValue("@phone", "%" + searchPhone + "%");
								}

								query += " ORDER BY id LIMIT @limit OFFSET @offset";
							}
							else
							{
								query = "SELECT * FROM data_kontak ORDER BY id LIMIT @limit OFFSET @offset";
							}

							cmd.Parameters.AddWithValue("@limit", batchSize);
							cmd.Parameters.AddWithValue("@offset", offset);
							cmd.CommandText = query;
							cmd.Connection = conn;

							// Execute query for this batch
							using (MySqlDataReader reader = cmd.ExecuteReader())
							{
								while (reader.Read())
								{
									int id = Convert.ToInt32(reader["id"]);
									string name = reader["name"].ToString().Replace(";", ",");
									string phone = reader["phone"].ToString().Replace(";", ",");
									writer.WriteLine($"{id};{name};{phone}");
									recordProcessed++;
									progressBar.Value = recordProcessed;
									lblStatus.Text = $"Exporting... {recordProcessed} of {totalRecords} records processed.";
									Application.DoEvents();
								}
							}
							offset += batchSize;
						}
					}
					progress.Close();
				}
				MessageBox.Show("Data exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error Exporting Data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnPrevPage_Click(object sender, EventArgs e)
		{
			if (currentPage > 1)
			{
				currentPage--;
				LoadCurrentPageData();
				UpdatePaginationInfo();
			}
		}

		private void btnNextPage_Click(object sender, EventArgs e)
		{
			if (currentPage < totalPages)
			{
				currentPage++;
				LoadCurrentPageData();
				UpdatePaginationInfo();
			}
		}

		private void nudPageSize_ValueChanged(object sender, EventArgs e)
		{
			pageSize = (int)nudPageSize.Value;
			currentPage = 1; // Reset to first page
			LoadDataWithPagination();
		}
	}
}