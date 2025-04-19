namespace Bookshop
{
    partial class Purchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CurrentUserlbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BooksBillDGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BooksDataGridView = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.btnAddtobill = new System.Windows.Forms.Button();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCustomer = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksBillDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.CurrentUserlbl);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 627);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CurrentUserlbl
            // 
            this.CurrentUserlbl.AutoSize = true;
            this.CurrentUserlbl.Font = new System.Drawing.Font("Mongolian Baiti", 13.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentUserlbl.Location = new System.Drawing.Point(24, 235);
            this.CurrentUserlbl.Name = "CurrentUserlbl";
            this.CurrentUserlbl.Size = new System.Drawing.Size(152, 24);
            this.CurrentUserlbl.TabIndex = 28;
            this.CurrentUserlbl.Text = "Current User -";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 24);
            this.label10.TabIndex = 27;
            this.label10.Text = "Current User -";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkBlue;
            this.button5.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(16, 468);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 47);
            this.button5.TabIndex = 15;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BooksBillDGV);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.BooksDataGridView);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.BtnPrint);
            this.panel2.Controls.Add(this.btnAddtobill);
            this.panel2.Controls.Add(this.TxtPrice);
            this.panel2.Controls.Add(this.TxtQuantity);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TxtCustomer);
            this.panel2.Controls.Add(this.lblTotalAmount);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TxtTitle);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(234, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 627);
            this.panel2.TabIndex = 5;
            // 
            // BooksBillDGV
            // 
            this.BooksBillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksBillDGV.Location = new System.Drawing.Point(441, 71);
            this.BooksBillDGV.Name = "BooksBillDGV";
            this.BooksBillDGV.RowHeadersVisible = false;
            this.BooksBillDGV.RowHeadersWidth = 51;
            this.BooksBillDGV.RowTemplate.Height = 24;
            this.BooksBillDGV.Size = new System.Drawing.Size(600, 256);
            this.BooksBillDGV.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(677, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Books Bill";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Book List";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BooksDataGridView
            // 
            this.BooksDataGridView.AllowUserToAddRows = false;
            this.BooksDataGridView.AllowUserToDeleteRows = false;
            this.BooksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BooksDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BooksDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BooksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BooksDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.BooksDataGridView.Location = new System.Drawing.Point(20, 333);
            this.BooksDataGridView.Name = "BooksDataGridView";
            this.BooksDataGridView.ReadOnly = true;
            this.BooksDataGridView.RowHeadersVisible = false;
            this.BooksDataGridView.RowHeadersWidth = 51;
            this.BooksDataGridView.RowTemplate.Height = 24;
            this.BooksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BooksDataGridView.Size = new System.Drawing.Size(617, 293);
            this.BooksDataGridView.TabIndex = 22;
            this.BooksDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksDataGridView_CellClick);
            this.BooksDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksDataGridView_CellClick);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkBlue;
            this.btnReset.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(250, 248);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 38);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnPrint.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.ForeColor = System.Drawing.Color.White;
            this.BtnPrint.Location = new System.Drawing.Point(843, 451);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(142, 38);
            this.BtnPrint.TabIndex = 19;
            this.BtnPrint.Text = "Print Bill";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnAddtobill
            // 
            this.btnAddtobill.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAddtobill.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtobill.ForeColor = System.Drawing.Color.White;
            this.btnAddtobill.Location = new System.Drawing.Point(20, 248);
            this.btnAddtobill.Name = "btnAddtobill";
            this.btnAddtobill.Size = new System.Drawing.Size(192, 38);
            this.btnAddtobill.TabIndex = 18;
            this.btnAddtobill.Text = "Add to Bill";
            this.btnAddtobill.UseVisualStyleBackColor = false;
            this.btnAddtobill.Click += new System.EventHandler(this.btnAddtobill_Click);
            // 
            // TxtPrice
            // 
            this.TxtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.Location = new System.Drawing.Point(267, 200);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(74, 27);
            this.TxtPrice.TabIndex = 17;
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuantity.Location = new System.Drawing.Point(267, 125);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(91, 27);
            this.TxtQuantity.TabIndex = 16;
            this.TxtQuantity.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(274, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(263, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Quantity";
            // 
            // TxtCustomer
            // 
            this.TxtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomer.Location = new System.Drawing.Point(3, 200);
            this.TxtCustomer.Name = "TxtCustomer";
            this.TxtCustomer.Size = new System.Drawing.Size(209, 27);
            this.TxtCustomer.TabIndex = 12;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(787, 424);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(70, 24);
            this.lblTotalAmount.TabIndex = 11;
            this.lblTotalAmount.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Customer Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Book Title";
            // 
            // TxtTitle
            // 
            this.TxtTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitle.Location = new System.Drawing.Point(3, 125);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(229, 27);
            this.TxtTitle.TabIndex = 3;
            this.TxtTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(379, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "BookShop";
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1303, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksBillDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView BooksDataGridView;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button btnAddtobill;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCustomer;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView BooksBillDGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CurrentUserlbl;
        private System.Windows.Forms.Label label10;
    }
}