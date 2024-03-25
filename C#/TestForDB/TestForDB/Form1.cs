using System;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TestForDB
{
    public partial class Form1 : Form
    {
        private string connString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable(); 
                using (SqlConnection conn = new SqlConnection(connString)) 
                {
                    conn.Open();
                    using(SqlCommand cmd = conn.CreateCommand()) 
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

        private void button2_Click(object sender, EventArgs e)
        {
            Insert_Update insert = new Insert_Update(connString, Optionss.Insert);
            insert.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Insert_Update insert = new Insert_Update(connString, Optionss.Update);
            insert.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Insert_Update insert = new Insert_Update(connString, Optionss.Delete);
            insert.Show();
        }
    }
}
