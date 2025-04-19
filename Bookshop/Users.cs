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
    public partial class Users : Form
    {
        int key = 0;
        public Users()
        {
            InitializeComponent();
            PopulateUsers();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Mansi\\Desktop\\Bookshop project\\Bookshop\\Bookshopdb.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void PopulateUsers()
        {
            con.Open();
            string query = "SELECT UserID,Username,Role,Phone FROM UsersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            UserDGV.DataSource = dt;
            con.Close();
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users users = new Users();
            users.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Books books = new Books();  
            books.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || UpassTb.Text == "" || UphoneTb.Text == "" || UroleCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!");
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Mansi\\Desktop\\Bookshop project\\Bookshop\\Bookshopdb.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False");

            try
            {
                con.Open();
                string query = "INSERT INTO UsersTbl (Username, Password, Role, Phone) VALUES (@Username, @Password, @Role, @Phone)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", UnameTb.Text);
                cmd.Parameters.AddWithValue("@Password", UpassTb.Text);
                cmd.Parameters.AddWithValue("@Role", UroleCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Phone", UphoneTb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close(); //  Ensures connection closes
            }

            PopulateUsers();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select a user to edit");
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Mansi\\Desktop\\Bookshop project\\Bookshop\\Bookshopdb.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False");

            try
            {
                con.Open();
                string query = "UPDATE UsersTbl SET Username=@Username, Password=@Password, Role=@Role, Phone=@Phone WHERE UserID=@UserID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", UnameTb.Text);
                cmd.Parameters.AddWithValue("@Password", UpassTb.Text);
                cmd.Parameters.AddWithValue("@Role", UroleCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Phone", UphoneTb.Text);
                cmd.Parameters.AddWithValue("@UserID", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close(); // ✅ Ensures connection closes
            }

            PopulateUsers();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (key == 0)
            {
                MessageBox.Show("Select a user to delete");
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Mansi\\Desktop\\Bookshop project\\Bookshop\\Bookshopdb.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False");

            try
            {
                con.Open();
                string query = "DELETE FROM UsersTbl WHERE UserID=@UserID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close(); // Ensures connection closes
            }

            PopulateUsers();
        }

        private void UserDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            UroleCb.SelectedItem = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
            UphoneTb.Text = UserDGV.SelectedRows[0].Cells[3].Value.ToString();
            key = Convert.ToInt32(UserDGV.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            UpassTb.Text = "";
            UphoneTb.Text = "";
            UroleCb.SelectedIndex = -1;
        }
    }
}
