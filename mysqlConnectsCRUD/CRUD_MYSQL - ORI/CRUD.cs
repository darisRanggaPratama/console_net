using System;
using System.IO;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD_MYSQL{
	public partial class Display : Form
	{
		private string connString = "server=localhost;user id=rangga;password=rangga;database=testing;";
		private int currentID = -1;

		public Display()
		{
			InitializeComponent();
		}

		private void dgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				var id = Convert.ToInt32(dgvContacts.Rows[e.RowIndex].Cells["id"].Value);
				var columnName = dgvContacts.Columns[e.ColumnIndex].Name;

				if (columnName == "Edit")
				{
					txtName.Text = dgvContacts.Rows[e.RowIndex].Cells["name"].Value.ToString();
					txtPhone.Text = dgvContacts.Rows[e.RowIndex].Cells["phone"].Value.ToString();
					currentID = id;
					btnAdd.Enabled = false;
					btnUpdate.Enabled = true;
				}
				else if (columnName == "Delete")
				{
					if (MessageBox.Show("Are you sure you want to delete this contact?", "Delete Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						DeleteData(id);
						LoadData();
					}
				}
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			using (var conn = new MySqlConnection(connString))
			{
				conn.Open();
				var query = "INSERT INTO data_kontak (name, phone) VALUES (@name, @phone)";
				using (var cmd = new MySqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@name", txtName.Text);
					cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
					cmd.ExecuteNonQuery();
				}
			}
			ClearForm();
			LoadData();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (currentID > 0)
			{
				UpdateData(currentID);
				ClearForm();
				LoadData();
			}
			else
			{
				MessageBox.Show("Please select a contact to update.");
			}
		}

		private void UpdateData(int id)
		{
			using (var conn = new MySqlConnection(connString))
			{
				conn.Open();
				var query = "UPDATE data_kontak SET name = @name, phone = @phone WHERE id = @id";
				using (var cmd = new MySqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@name", txtName.Text);
					cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
					cmd.Parameters.AddWithValue("@id", id);
					cmd.ExecuteNonQuery();
				}
			}
			LoadData();
		}

		private void DeleteData(int id)
		{
			using (var conn = new MySqlConnection(connString))
			{
				conn.Open();
				var query = "DELETE FROM data_kontak WHERE id = @id";
				using (var cmd = new MySqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@id", id);
					cmd.ExecuteNonQuery();
				}
			}
			LoadData();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearForm();
		}

		private void ClearForm()
		{
			txtName.Clear();
			txtPhone.Clear();
			currentID = -1;
			btnAdd.Enabled = true;
			btnUpdate.Enabled = false;
		}

		private void Display_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void LoadData()
		{
			using (var conn = new MySqlConnection(connString))
			{
				var query = "SELECT * FROM data_kontak ORDER BY id DESC";
				var adapter = new MySqlDataAdapter(query, conn);
				var dt = new DataTable();
				adapter.Fill(dt);
				dgvContacts.DataSource = dt;
				dgvContacts.Font = new System.Drawing.Font("Arial", 10);

				if (!dgvContacts.Columns.Contains("Edit"))
				{
					var editCol = new DataGridViewButtonColumn
					{
						Name = "Edit",
						Text = "Edit",
						UseColumnTextForButtonValue = true,
						Width = 50,
						HeaderText = "Edit"
					};
					dgvContacts.Columns.Add(editCol);
				}

				if (!dgvContacts.Columns.Contains("Delete"))
				{
					var deleteCol = new DataGridViewButtonColumn
					{
						Name = "Delete",
						Text = "Delete",
						UseColumnTextForButtonValue = true,
						Width = 50,
						HeaderText = "Delete"
					};
					dgvContacts.Columns.Add(deleteCol);
				}
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			SearchData(txtName.Text.Trim(), txtPhone.Text.Trim());
		}

		private void SearchData(string name, string phone)
		{
			using (var conn = new MySqlConnection(connString))
			{
				string query = "SELECT * FROM data_kontak WHERE 1=1";
				using (var cmd = new MySqlCommand())
				{
					if (!string.IsNullOrEmpty(name))
					{
						query += " AND name LIKE @name";
						cmd.Parameters.AddWithValue("@name", "%" + name + "%");
					}

					if (!string.IsNullOrEmpty(phone))
					{
						query += " AND phone LIKE @phone";
						cmd.Parameters.AddWithValue("@phone", "%" + phone + "%");
					}

					query += " ORDER BY id DESC";
					cmd.CommandText = query;
					cmd.Connection = conn;

					var adapter = new MySqlDataAdapter(cmd);
					var dt = new DataTable();
					adapter.Fill(dt);
					dgvContacts.DataSource = dt;
				}
			}
		}

		private void brnReset_Click(object sender, EventArgs e)
		{
			txtName.Clear();
			txtPhone.Clear();
			LoadData();
		}

		private void btnUpload_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog fileDialog = new OpenFileDialog
				{
					Filter = "CSV Files (*.csv)|*.csv",
					Title = "Select a CSV file"
				};

				if (fileDialog.ShowDialog() == DialogResult.OK)
				{
					string[] lines = File.ReadAllLines(fileDialog.FileName);
					if (lines.Length <= 1)
					{
						MessageBox.Show("The file is empty or does not contain valid data or just column header.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					using (MySqlConnection conn = new MySqlConnection(connString))
					{
						conn.Open();
						MySqlTransaction transaction = conn.BeginTransaction();

						try
						{
							for (int i = 1; i < lines.Length; i++) // skip header
							{
								string[] parts = lines[i].Split(';');
								if (parts.Length >= 2)
								{
									string name = parts[0].Trim();
									string phone = parts[1].Trim();

									MySqlCommand cmd = new MySqlCommand("INSERT INTO data_kontak (name, phone) VALUES (@name, @phone)", conn, transaction);
									cmd.Parameters.AddWithValue("@name", name);
									cmd.Parameters.AddWithValue("@phone", phone);
									cmd.ExecuteNonQuery();
								}
							}

							transaction.Commit();
							MessageBox.Show("Data imported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							LoadData();
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
				MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnDownload_Click(object sender, EventArgs e)
		{
			try
			{
				SaveFileDialog saveDialog = new SaveFileDialog
				{
					Filter = "CSV Files (*.csv)|*.csv",
					Title = "Save as CSV file",
					FileName = "data_kontak.csv"
				};

				if (saveDialog.ShowDialog() == DialogResult.OK)
				{
					using (MySqlConnection conn = new MySqlConnection(connString))
					{
						conn.Open();

						string query = "SELECT * FROM data_kontak ORDER BY id";
						MySqlCommand cmd = new MySqlCommand(query, conn);
						MySqlDataReader reader = cmd.ExecuteReader();

						using (StreamWriter writer = new StreamWriter(saveDialog.FileName, false))
						{
							// Write header
							writer.WriteLine("id;name;phone");

							// Write data
							while (reader.Read())
							{
								int id = Convert.ToInt32(reader["id"]);
								string name = reader["name"].ToString().Replace(";", ",");
								string phone = reader["phone"].ToString().Replace(";", ",");
								writer.WriteLine($"{reader["id"]};{reader["name"]};{reader["phone"]}");
							}
						}
						MessageBox.Show("Data exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}