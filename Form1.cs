using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using ClosedXML.Excel;

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=school";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadInitialData();
        }

        private void LoadInitialData()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT * FROM teacher", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["name"].ToString());
                }
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            InsertOrUpdateTeacher("INSERT INTO teacher (matricule, name, address, salary) VALUES (@id, @name, @address, @salary)",
                txtid.Text, txtname.Text, txtaddress.Text, txtsalary.Text);
            RefreshUI();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            InsertOrUpdateTeacher("UPDATE teacher SET name=@name, address=@address, salary=@salary WHERE matricule=@id",
                txtid.Text, txtname.Text, txtaddress.Text, txtsalary.Text);
            RefreshUI();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            FindTeacherById(txtsearch.Text);
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            DeleteTeacherByMatricule(txtid.Text);
            ClearData();
            DisplayData();
        }

        private void DeleteTeacherByMatricule(string matricule)
        {
            if (!string.IsNullOrWhiteSpace(matricule))
            {
                ExecuteQuery("DELETE FROM teacher WHERE matricule=@id", new NpgsqlParameter("@id", matricule));
            }
            else
            {
                MessageBox.Show("Matricule must be provided to delete a teacher.");
            }
        }

        private void btnsave_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_export_Click(object sender, EventArgs e)
        {
            DataTable dt = GetTeacherData();
            if (dt != null)
            {
                SaveDataTableToExcel(dt);
            }
        }
        private DataTable GetTeacherData()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("select matricule, name, address, salary from teacher", conn);
                var da = new NpgsqlDataAdapter(cmd);
                var dt = new DataTable();
                return dt;
            }
        }
        private void SaveDataTableToExcel(DataTable dt)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Teachers");
                worksheet.Cell(1, 1).InsertTable(dt, "Teachers", true);
                string filePath = "C:\\Users\\Stagiaire\\Downloads\\Documents\\DEV\\MISA NANTENAINA\\Projet\\Teachers.xlsx";
                try
                {
                    workbook.SaveAs(filePath);
                    MessageBox.Show($"Data exported successfully to {filePath}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to save file : {ex.Message}");
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content clicks if necessary
        }

        private void RefreshUI()
        {
            ClearData();
            DisplayData();
        }

        private void DisplayData()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new NpgsqlCommand("SELECT * FROM teacher", conn);
                    var da = new NpgsqlDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data: {ex.Message}");
            }
        }

        private void ExecuteQuery(string sql, params NpgsqlParameter[] parameters)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddRange(parameters);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to execute query: {ex.Message}");
            }
        }

        private void ClearData()
        {
            txtid.Clear();
            txtname.Clear();
            txtaddress.Clear();
            txtsalary.Clear();
        }
        private void InsertOrUpdateTeacher(string sql, string matricule, string name, string address, string salary)
        {
            ExecuteQuery(sql, new NpgsqlParameter("@id", matricule),
                               new NpgsqlParameter("@name", name),
                               new NpgsqlParameter("@address", address),
                               new NpgsqlParameter("@salary", salary));
        }

        private void FindTeacherById(string matricule)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new NpgsqlCommand("SELECT * FROM teacher WHERE matricule=@id", conn);
                    cmd.Parameters.AddWithValue("@id", matricule);
                    var da = new NpgsqlDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No data found.");
                        dataGridView1.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to find data: {ex.Message}");
            }
        }
    }
}
