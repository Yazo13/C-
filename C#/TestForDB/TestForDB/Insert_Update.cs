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

namespace TestForDB
{
    public partial class Insert_Update : Form
    {
        private string _connString;
        private Optionss _mode;
        private string _query;
        public Insert_Update(string connstring, Optionss mode = Optionss.None)
        {
            InitializeComponent();
            _connString = connstring;
            _mode = mode;
            switch (_mode)
            {
                case Optionss.None: break;
                case Optionss.Insert:
                    {
                        label1.Visible = true;
                        numericUpDown1.Visible = true;
                        _query = "INSERT INTO [Customers] ([CustomerID],[FirstName],[LastName],[Email],[Phone])" +
                            "VALUES (@ID ,@FirstName,@LastName,@Email, @Phone)";
                    }
                    break;
                case Optionss.Update:
                    {
                        _query = "UPDATE [Customers]" +
                            "SET [FirstName] = @FirstName," +
                            "[LastName] = @LastName," +
                            "[Email] = @Email," +
                            "[Phone] = @Phone" +
                            " WHERE CustomerID = @ID";
                        label1.Visible = true;
                        numericUpDown1.Visible = true;
                    }
                    break;
                case Optionss.Delete:
                    {
                        _query = "DELETE FROM [Customers] WHERE CustomerID = @Id";
                        label1.Visible = true;
                        numericUpDown1.Visible = true;
                    }
                    break;
                default:
                    throw new Exception("ოპერაცია არავალიდურია!");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = _query;
                        if (_mode == Optionss.Insert)
                        {
                            cmd.Parameters.Add(new SqlParameter("@ID", numericUpDown1.Value));
                            cmd.Parameters.Add(new SqlParameter("@FirstName", textBox4.Text));
                            cmd.Parameters.Add(new SqlParameter("@LastName", textBox3.Text));
                            cmd.Parameters.Add(new SqlParameter("@Email", textBox2.Text));
                            cmd.Parameters.Add(new SqlParameter("@Phone", numericUpDown2.Value));
                        }
                        if (_mode == Optionss.Update)
                        {
                            cmd.Parameters.Add(new SqlParameter("@ID", numericUpDown1.Value));
                            cmd.Parameters.Add(new SqlParameter("@FirstName", textBox4.Text));
                            cmd.Parameters.Add(new SqlParameter("@LastName", textBox3.Text));
                            cmd.Parameters.Add(new SqlParameter("@Email", textBox2.Text));
                            cmd.Parameters.Add(new SqlParameter("@Phone", numericUpDown2.Value));
                        }
                        if (_mode == Optionss.Delete)
                            cmd.Parameters.Add(new SqlParameter("@Id", numericUpDown1.Value));

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                            MessageBox.Show("ოპერაცია წარმატებულია!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "მოხდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }

        }
    }
}
