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
    public partial class Dashboard : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Mansi\\Desktop\\Bookshop project\\Bookshop\\Bookshopdb.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public Dashboard()
        {
            InitializeComponent();
            CountTotalBooks();
            UpdateBookCount();
            LoadUserCount();
        }
        


        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();  
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Books books = new Books();  
            books.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users users = new Users();  
            users.Show();
        }

        private void CountTotalBooks()
        {
            try
            {
                con.Open();

                // Count total books in stock
                string query = "SELECT SUM(BQty) FROM BookTbl";
                SqlCommand cmd = new SqlCommand(query, con);
                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    BooksStock_lbl.Text = result.ToString();
                }
                else
                {
                    BooksStock_lbl.Text = "0"; // No books in stock
                }

                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void UpdateBookCount()
        {
            int bookCount = 0;
            string query = "SELECT COUNT(*) FROM BookTbl";  // Count total books

            using (SqlConnection conn = con) // Using the existing connection object
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    bookCount = (int)cmd.ExecuteScalar();  // Fetch count from DB
                }
                conn.Close();
            }

            lblBookCount.Text = "Books: " + bookCount.ToString();  // Display in label
        }

        private void LoadUserCount()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Mansi\\Desktop\\Bookshop project\\Bookshop\\Bookshopdb.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False")) // Create a new instance
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM UsersTbl";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int userCount = Convert.ToInt32(cmd.ExecuteScalar()); // Ensure proper conversion
                        lblUserCount.Text = userCount.ToString();
                    }
                } // `using` ensures the connection is properly closed
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching user count: " + ex.Message);
            }
        }


    }
}
