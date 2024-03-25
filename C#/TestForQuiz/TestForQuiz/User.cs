using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForQuiz
{
    public partial class User : Form
    {
        private string _conn;
        public User(string conn)
        {
            InitializeComponent();
            _conn = conn;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection sqlConnection = new SqlConnection(_conn))
                {
                    sqlConnection.Open();
                    using(SqlCommand cmd = sqlConnection.CreateCommand()) 
                    {
                        cmd.CommandText = "SELECT [CustomerID], [FirstName], [LastName], [Email], [Phone] FROM [Customers] WHERE [FirstName] = @name";
                        cmd.Parameters.Add(new SqlParameter("@name", textBox1.Text));
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (!dr.IsClosed) { dt.Load(dr); }
                    }  

                }
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "მოხდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void get_all_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection sqlConnection = new SqlConnection(_conn))
                {
                    sqlConnection.Open();
                    using (SqlCommand cmd = sqlConnection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT [CustomerID], [FirstName], [LastName], [Email], [Phone] FROM [Customers]";
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (!dr.IsClosed) { dt.Load(dr); }
                    }

                }
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "მოხდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection sqlConnection = new SqlConnection(_conn))
                {
                    sqlConnection.Open();
                    using (SqlCommand cmd = sqlConnection.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE [Customers]" +
                            "SET [Phone] = @rate" +
                            " WHERE [FirstName] = @name";
                        cmd.Parameters.Add(new SqlParameter("@rate", numericUpDown1.Value));
                        cmd.Parameters.Add(new SqlParameter("@name", textBox2.Text));
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (!dr.IsClosed) { dt.Load(dr); }
                    }

                }
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "მოხდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
