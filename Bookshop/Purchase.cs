using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshop
{
    public partial class Purchase : Form
    {
        private string currentUser;
        public Purchase(string username)
        {
            InitializeComponent();
            currentUser = username;
            LoadBooks();
            InitializeBillDataGridView();
            TxtPrice.Enabled = false;
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Mansi\\Desktop\\Bookshop project\\Bookshop\\Bookshopdb.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False");

        //private void LoadBooks()
        //{
        //    con.Open();
        //    string query = "SELECT BTitle,BCat,BQty,Price FROM BookTbl";
        //    SqlDataAdapter sda = new SqlDataAdapter(query, con);
        //    SqlCommandBuilder builder= new SqlCommandBuilder(sda);
        //    var ds=new DataSet();

        //    sda.Fill(ds);
        //    BooksDataGridView.DataSource = ds.Tables[0]; // Bind data to grid
        //    con.Close();
        //}


        private void LoadBooks()
        {
            BooksDataGridView.Enabled = false; // Prevent interactions
            try
            {
                con.Open();
                string query = "SELECT BTitle, BCat, BQty, Price FROM BookTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BooksDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
            finally
            {
                con.Close();
                BooksDataGridView.Enabled = true; // Re-enable interaction
            }
        }


        private void Purchase_Load(object sender, EventArgs e)
        {
            CurrentUserlbl.Text = "" + currentUser; // Display username in Label
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = TxtTitle.Text.Trim();
            try
            {
                con.Open();
                string query = "SELECT BTitle, BCat, BQty, Price FROM BookTbl WHERE BTitle LIKE '%' + @SearchText + '%'";
;

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SearchText", searchText);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    BooksDataGridView.DataSource = dt;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void BooksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                DataGridViewRow row = BooksDataGridView.Rows[e.RowIndex];

                if (row.Cells[0].Value != null) // Check for null values
                {
                    TxtTitle.Text = row.Cells[0].Value.ToString();
                }
                else
                {
                    TxtTitle.Text = string.Empty;
                }

                if (row.Cells[3].Value != null)
                {
                    TxtPrice.Text = row.Cells[3].Value.ToString();
                }
                else
                {
                    TxtPrice.Text = string.Empty;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            TxtTitle.Clear();
            TxtQuantity.Clear();
            TxtPrice.Clear();
        }

        private void btnAddtobill_Click(object sender, EventArgs e)
        {
            if (TxtTitle.Text == "" || TxtQuantity.Text == "" || TxtPrice.Text == "")
            {
                MessageBox.Show("Please fill all details!");
                return;
            }

            string bookTitle = TxtTitle.Text; 
            decimal price = decimal.Parse(TxtPrice.Text);
            int quantity = int.Parse(TxtQuantity.Text);
            decimal total = quantity * price;

            BooksBillDGV.Rows.Add(BooksBillDGV.Rows.Count + 1, bookTitle, price, quantity, total);
            CalculateTotal();

            TxtTitle.Clear();
            TxtQuantity.Clear();
            TxtPrice.Clear();

            UpdateStock(bookTitle, quantity); 
            LoadBooks();
        }

        private void CalculateTotal()
        {
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in BooksBillDGV.Rows)
            {
                totalAmount += Convert.ToDecimal(row.Cells["Total"].Value);
            }
            lblTotalAmount.Text = "RS: " + totalAmount.ToString();
        }

        private void InitializeBillDataGridView()
        {
            BooksBillDGV.ColumnCount = 5;
            BooksBillDGV.Columns[0].Name = "S.No";
            BooksBillDGV.Columns[1].Name = "BookTitle";
            BooksBillDGV.Columns[2].Name = "Price";
            BooksBillDGV.Columns[3].Name = "Quantity";
            BooksBillDGV.Columns[4].Name = "Total";

            BooksBillDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Adjust column size
            BooksBillDGV.AllowUserToAddRows = false; // Prevent users from adding empty rows manually
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            TxtTitle.Clear();
            TxtPrice.Clear();
            TxtQuantity.Clear();
            TxtCustomer.Clear();
            BooksBillDGV.Rows.Clear();
            lblTotalAmount.Text = "RS: 0";
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (BooksBillDGV.Rows.Count == 0)
            {
                MessageBox.Show("No items to bill!");
                return;
            }

            string CustomerName = TxtCustomer.Text;
            decimal totalAmount = decimal.Parse(lblTotalAmount.Text.Replace("RS: ", ""));

            // Insert into BillTbl
            string insertBillQuery = "INSERT INTO BillTbl (ClientName, TotalAmount) OUTPUT INSERTED.BillID VALUES (@ClientName, @TotalAmount)";
            SqlCommand cmd = new SqlCommand(insertBillQuery, con);
            cmd.Parameters.AddWithValue("@ClientName", CustomerName);
            cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);

            con.Open();
            int billID = (int)cmd.ExecuteScalar();  // Get the newly inserted BillID

            // Insert details into BillDetailsTbl
            foreach (DataGridViewRow row in BooksBillDGV.Rows)
            {
                string insertDetailsQuery = "INSERT INTO BillDetailsTbl (BillID, BookTitle, Price, Quantity, Total) VALUES (@BillID, @BookTitle, @Price, @Quantity, @Total)";
                SqlCommand detailsCmd = new SqlCommand(insertDetailsQuery, con);
                detailsCmd.Parameters.AddWithValue("@BillID", billID);
                detailsCmd.Parameters.AddWithValue("@BookTitle", row.Cells["BookTitle"].Value.ToString());
                detailsCmd.Parameters.AddWithValue("@Price", row.Cells["Price"].Value);
                detailsCmd.Parameters.AddWithValue("@Quantity", row.Cells["Quantity"].Value);
                detailsCmd.Parameters.AddWithValue("@Total", row.Cells["Total"].Value);
                detailsCmd.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Bill Saved Successfully!");
            //PrintBill(billID);
            SaveBillAsText(billID);
        }

        private void SaveBillAsText(int billID)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.Title = "Save Bill as Text File";
                saveFileDialog.FileName = $"Bill_{billID}.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine("***** Book Store *****");
                        writer.WriteLine($"Bill ID: {billID}");
                        writer.WriteLine($"Customer Name: {TxtCustomer.Text}");
                        writer.WriteLine($"Date: {DateTime.Now}");
                        writer.WriteLine("---------------------------------------------------------");
                        writer.WriteLine("S.No   Book Title                   Price   Quantity   Total");
                        writer.WriteLine("---------------------------------------------------------");

                        int index = 1;
                        int maxTitleWidth = 25; // Max characters for book title

                        foreach (DataGridViewRow row in BooksBillDGV.Rows)
                        {
                            if (row.Cells["BookTitle"].Value != null)
                            {
                                string bookTitle = row.Cells["BookTitle"].Value.ToString();
                                string price = row.Cells["Price"].Value.ToString();
                                string quantity = row.Cells["Quantity"].Value.ToString();
                                string total = row.Cells["Total"].Value.ToString();

                                // Truncate or wrap long book titles
                                string displayTitle = bookTitle.Length > maxTitleWidth ? bookTitle.Substring(0, maxTitleWidth - 3) + "..." : bookTitle;

                                // Format the first line with aligned columns
                                writer.WriteLine($"{index,-5} {displayTitle,-25} {price,8} {quantity,9} {total,10}");

                                // If the book title is too long, write the remaining part in the next line
                                if (bookTitle.Length > maxTitleWidth)
                                {
                                    writer.WriteLine($"      {bookTitle.Substring(maxTitleWidth - 3)}");
                                }

                                index++;
                            }
                        }

                        writer.WriteLine("---------------------------------------------------------");
                        writer.WriteLine($"Grand Total: {lblTotalAmount.Text}");
                        writer.WriteLine("Thank you for shopping!");
                    }

                    MessageBox.Show($"Bill saved successfully at {saveFileDialog.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }




        private void UpdateStock(string bookTitle, int soldQuantity)
        {
            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Mansi\\Desktop\\Bookshop project\\Bookshop\\Bookshopdb.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False"))
            {
                con.Open();

                // Check current stock
                string checkStockQuery = "SELECT BQty FROM BookTbl WHERE BTitle = @bookTitle";
                SqlCommand checkCmd = new SqlCommand(checkStockQuery, con);
                checkCmd.Parameters.AddWithValue("@bookTitle", bookTitle);
                object result = checkCmd.ExecuteScalar();

                if (result != null)
                {
                    int currentStock = Convert.ToInt32(result);

                    // Ensure sufficient stock before deducting
                    if (currentStock >= soldQuantity)
                    {
                        int newStock = currentStock - soldQuantity;

                        // Update the book quantity in BookTbl
                        string updateQuery = "UPDATE BookTbl SET BQty = @newStock WHERE BTitle = @bookTitle";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                        updateCmd.Parameters.AddWithValue("@newStock", newStock);
                        updateCmd.Parameters.AddWithValue("@bookTitle", bookTitle);
                        updateCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Not enough stock available!", "Stock Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Book not found in stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
                LoadBooks();
            }
        }


        






    }
}
