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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            populate();
            FillCategoryComboBox();
            Bcatcb.DropDownStyle = ComboBoxStyle.DropDown;  // Allow typing new values

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mansi\Desktop\Bookshop project\Bookshop\Bookshopdb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource=ds.Tables[0];
            con.Close();

        }

        private void filter()
        {
            con.Open();
            string query = "select * from BookTbl where Bcat='" +Bcatcbsearch.SelectedItem.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();  
            login.Show();
        }

        private void BSave_btn_Click(object sender, EventArgs e)
        {
            if (Btitletb.Text == "" || Bauthortb.Text == "" || Bcatcb.Text == "" || Bquantitytb.Text == "" || Bpricetb.Text == "")
            {
                MessageBox.Show("Information is missing!!");
            }
            else
            {
                try
                {
                    con.Open();

                    string selectedCategory = Bcatcb.Text.Trim();

                    // Insert book details into BookTbl
                    string query = "INSERT INTO BookTbl (BTitle, BAuthor, BCat, BQty, Price) VALUES (@BTitle, @BAuthor, @BCat, @BQty, @Price)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@BTitle", Btitletb.Text);
                    cmd.Parameters.AddWithValue("@BAuthor", Bauthortb.Text);
                    cmd.Parameters.AddWithValue("@BCat", selectedCategory);
                    cmd.Parameters.AddWithValue("@BQty", Bquantitytb.Text);
                    cmd.Parameters.AddWithValue("@Price", Bpricetb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Saved Successfully.");

                    con.Close();
                    populate();
                    Reset();

                    // Update category dropdown lists if it's a new category
                    if (!Bcatcb.Items.Contains(selectedCategory))
                    {
                        Bcatcb.Items.Add(selectedCategory);
                        Bcatcbsearch.Items.Add(selectedCategory);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error: " + Ex.Message);
                }
            }
        }

        private void Bcatcbsearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filter();
        }

        public void Reset()
        {
            Btitletb.Text = "";
            Bauthortb.Text = "";
            Bcatcb.SelectedIndex = -1;
            Bquantitytb.Text = "";
            Bpricetb.Text = "";
        }
        private void BRefresh_btn_Click(object sender, EventArgs e)
        {
            populate();
            Bcatcbsearch.SelectedIndex = -1;
        }

        private void BReset_Btn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        int key = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Btitletb.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            Bauthortb.Text = BookDGV.SelectedRows[0].Cells[2].Value.ToString();
            Bcatcb.SelectedItem = BookDGV.SelectedRows[0].Cells[3].Value.ToString();
            Bquantitytb.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
            Bpricetb.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();

            if (Btitletb.Text == "")
            { key = 0; }
            else {
                key = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void BEdit_btn_Click(object sender, EventArgs e)
        {
            if (Btitletb.Text == "" || Bauthortb.Text == "" || Bcatcb.Text == "" || Bquantitytb.Text == "" || Bpricetb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    if (con.State == ConnectionState.Closed) // Ensure connection is closed before opening
                    {
                        con.Open();
                    }

                    // Retrieve the current quantity from the database
                    string getQtyQuery = "SELECT BQty FROM BookTbl WHERE BId=@BId";
                    SqlCommand getQtyCmd = new SqlCommand(getQtyQuery, con);
                    getQtyCmd.Parameters.AddWithValue("@BId", key);
                    int currentQty = Convert.ToInt32(getQtyCmd.ExecuteScalar()); // Get existing quantity

                    // Add new quantity to the current quantity
                    int addedQty = Convert.ToInt32(Bquantitytb.Text);
                    int updatedQty = currentQty + addedQty;

                    // Update BookTbl with new quantity
                    string query = "UPDATE BookTbl SET BTitle=@BTitle, BAuthor=@BAuthor, BCat=@BCat, BQty=@BQty, Price=@Price WHERE BId=@BId";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@BTitle", Btitletb.Text);
                    cmd.Parameters.AddWithValue("@BAuthor", Bauthortb.Text);
                    cmd.Parameters.AddWithValue("@BCat", Bcatcb.Text.Trim());
                    cmd.Parameters.AddWithValue("@BQty", updatedQty); // Store updated quantity
                    cmd.Parameters.AddWithValue("@Price", Bpricetb.Text);
                    cmd.Parameters.AddWithValue("@BId", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Updated Successfully!");

                    con.Close(); // Close before repopulating
                    populate();  // Refresh books list
                    FillCategoryComboBox();  // Reload categories
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error: " + Ex.Message);
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close(); // Ensure connection is closed if error occurs
                    }
                }
            }
        }

        private void FillCategoryComboBox()
        {
            try
            {
                con.Open();
                string query = "SELECT DISTINCT BCat FROM BookTbl WHERE BCat IS NOT NULL";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                Bcatcb.Items.Clear();
                Bcatcbsearch.Items.Clear();

                while (reader.Read())
                {
                    string category = reader["BCat"].ToString();
                    Bcatcb.Items.Add(category);
                    Bcatcbsearch.Items.Add(category);
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        private void BDelete_btn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please select a book to delete.");
            }
            else
            {
                try
                {
                    con.Open();

                    // Delete book from BookTbl
                    string query = "DELETE FROM BookTbl WHERE BId=@BId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@BId", key);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Book Deleted Successfully.");

                    con.Close();
                    populate(); // Refresh DataGridView
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
