using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C_connMySQL
{
	public partial class FormDisplay : Form
	{
		public FormDisplay()
		{
			InitializeComponent();
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			try
			{
				string connString = "Server=localhost;Database=testing;Uid=rangga;Pwd=rangga;";
				MySqlConnection conn = new MySqlConnection(connString);
				// conn.ConnectionString = connString;
				conn.Open();
				string query = "SELECT * FROM std_table";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				MySqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					int id = reader.GetInt32("std_id"); // Fixed: Use GetInt32 to retrieve an integer value
					string name = reader.GetString("std_name");
					string lastName = reader.GetString("std_fname");

					listBox1.Items.Add(id + " " + name + " " + lastName);
				}
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.ToString());
			}

		}

		private void btnDisplay_Click(object sender, EventArgs e)
		{
			getData();
		}

		public void getData()
		{
			string connString = "Server=localhost;Database=testing;Uid=rangga;Pwd=rangga;";
			MySqlConnection conn = new MySqlConnection(connString);
			conn.Open();
			string query = "SELECT * FROM std_table";
			MySqlCommand cmd = new MySqlCommand(query, conn);
			MySqlDataReader reader = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Load(reader);
			gridData.DataSource = dt;


		}
	}
}
