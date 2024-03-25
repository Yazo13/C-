using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace TestForQuiz
{
    public partial class Form1 : Form
    {
        private string connString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void User_Click(object sender, EventArgs e)
        {
            User user = new User(connString);
            user.Show();
        }

        private void Admin_Click(object sender, EventArgs e)
        {

        }
    }
}
