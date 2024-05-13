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
            string query = $"insert into teacher values('{txtid.Text.ToString()}','{txtaddress.Text}','{txtsalary.Text.ToString()}'";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
