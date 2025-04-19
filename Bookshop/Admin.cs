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

namespace Bookshop
{
    public partial class Admin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Mansi\\Desktop\\Bookshop project\\Bookshop\\Bookshopdb.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Username and Password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM UsersTbl WHERE Username COLLATE SQL_Latin1_General_CP1_CS_AS = @Username AND Password COLLATE SQL_Latin1_General_CP1_CS_AS = @Password AND Role COLLATE SQL_Latin1_General_CP1_CS_AS = 'Admin'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = username;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = password;

                    int count = Convert.ToInt32(cmd.ExecuteScalar()); // Correct way to check result

                    if (count > 0) // Login successful
                    {
                        MessageBox.Show("Admin Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Books books = new Books();
                        books.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password, or you are not authorized as Admin.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
