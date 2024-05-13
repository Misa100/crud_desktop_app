using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

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
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("select * from teacher", conn))
                {
                    using(var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString(1));
                        }
                    }
                }
            }
        }
        private void btninsert_Click(object sender, EventArgs e)
        {
            ExecuteQuery("INSERT INTO teacher (id, address, salary) VALUES (@id, @address, @salary)",
                new NpgsqlParameter("@id", txtid.Text),
                new NpgsqlParameter("@address", txtaddress.Text),
                new NpgsqlParameter("@salary", txtsalary.Text));
            clearData();
            displaydata();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            ExecuteQuery("UPDATE teacher SET name=@name, address=@address, salary=@salary WHERE id=@id",
                new NpgsqlParameter("@name", txtname.Text),
                new NpgsqlParameter("@address", txtaddress.Text),
                new NpgsqlParameter("@salary", txtsalary.Text),
                new NpgsqlParameter("@id", txtid.Text));
            clearData();
            displaydata();
        }

        private void displaydata()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT * FROM teacher", conn))
                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
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
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddRange(parameters);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to execute query: {ex.Message}");
            }
        }

        private void clearData()
        {
            txtid.Clear();
            txtname.Clear();
            txtaddress.Clear();
            txtsalary.Clear();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM teacher WHERE id=@id";
            ExecuteQuery(query, new NpgsqlParameter("@id", txtid.Text));
            clearData();
            displaydata();
        }
        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT * FROM teacher WHERE id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", txtsearch.Text);

                        DataTable dt = new DataTable();
                        using (var da = new NpgsqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }

                        if (dt.Rows.Count > 0)
                        {
                            txtname.Text = dt.Rows[0]["name"].ToString();
                            txtaddress.Text = dt.Rows[0]["address"].ToString();
                            txtsalary.Text = dt.Rows[0]["salary"].ToString();
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No data found.");
                            dataGridView1.DataSource = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to find data: {ex.Message}");
            }
        }
        private void btnsave_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
