namespace Bookshop
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BRefresh_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Bcatcbsearch = new System.Windows.Forms.ComboBox();
            this.BookDGV = new System.Windows.Forms.DataGridView();
            this.BReset_Btn = new System.Windows.Forms.Button();
            this.BEdit_btn = new System.Windows.Forms.Button();
            this.BDelete_btn = new System.Windows.Forms.Button();
            this.BSave_btn = new System.Windows.Forms.Button();
            this.Bpricetb = new System.Windows.Forms.TextBox();
            this.Bquantitytb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Bcatcb = new System.Windows.Forms.ComboBox();
            this.Bauthortb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btitletb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 627);
            this.panel1.TabIndex = 1;
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
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkBlue;
            this.button5.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(82, 460);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(233, 54);
            this.button5.TabIndex = 15;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkBlue;
            this.button4.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(82, 364);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 54);
            this.button4.TabIndex = 14;
            this.button4.Text = "Dashboard";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkBlue;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(82, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 54);
            this.button3.TabIndex = 13;
            this.button3.Text = "Users";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(82, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 54);
            this.button2.TabIndex = 12;
            this.button2.Text = "Books";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BRefresh_btn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Bcatcbsearch);
            this.panel2.Controls.Add(this.BookDGV);
            this.panel2.Controls.Add(this.BReset_Btn);
            this.panel2.Controls.Add(this.BEdit_btn);
            this.panel2.Controls.Add(this.BDelete_btn);
            this.panel2.Controls.Add(this.BSave_btn);
            this.panel2.Controls.Add(this.Bpricetb);
            this.panel2.Controls.Add(this.Bquantitytb);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Bcatcb);
            this.panel2.Controls.Add(this.Bauthortb);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Btitletb);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(471, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 627);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BRefresh_btn
            // 
            this.BRefresh_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.BRefresh_btn.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRefresh_btn.ForeColor = System.Drawing.Color.White;
            this.BRefresh_btn.Location = new System.Drawing.Point(494, 317);
            this.BRefresh_btn.Name = "BRefresh_btn";
            this.BRefresh_btn.Size = new System.Drawing.Size(99, 33);
            this.BRefresh_btn.TabIndex = 25;
            this.BRefresh_btn.Text = "Refresh";
            this.BRefresh_btn.UseVisualStyleBackColor = false;
            this.BRefresh_btn.Click += new System.EventHandler(this.BRefresh_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Book List";
            // 
            // Bcatcbsearch
            // 
            this.Bcatcbsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcatcbsearch.FormattingEnabled = true;
            this.Bcatcbsearch.Items.AddRange(new object[] {
            "Fiction",
            "",
            "Science",
            "",
            "Business",
            "",
            "Technology",
            "",
            "History",
            "",
            "Biography",
            "",
            "Philosophy",
            "",
            "Self-help",
            "",
            "Classic ",
            "Literature",
            "",
            "Design"});
            this.Bcatcbsearch.Location = new System.Drawing.Point(327, 321);
            this.Bcatcbsearch.Name = "Bcatcbsearch";
            this.Bcatcbsearch.Size = new System.Drawing.Size(161, 28);
            this.Bcatcbsearch.TabIndex = 23;
            this.Bcatcbsearch.Text = "Filter by category";
            this.Bcatcbsearch.SelectionChangeCommitted += new System.EventHandler(this.Bcatcbsearch_SelectionChangeCommitted);
            // 
            // BookDGV
            // 
            this.BookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BookDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookDGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.BookDGV.Location = new System.Drawing.Point(-1, 355);
            this.BookDGV.Name = "BookDGV";
            this.BookDGV.ReadOnly = true;
            this.BookDGV.RowHeadersVisible = false;
            this.BookDGV.RowHeadersWidth = 51;
            this.BookDGV.RowTemplate.Height = 24;
            this.BookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookDGV.Size = new System.Drawing.Size(838, 271);
            this.BookDGV.TabIndex = 22;
            this.BookDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDGV_CellContentClick);
            this.BookDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDGV_CellContentClick);
            // 
            // BReset_Btn
            // 
            this.BReset_Btn.BackColor = System.Drawing.Color.DarkBlue;
            this.BReset_Btn.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BReset_Btn.ForeColor = System.Drawing.Color.White;
            this.BReset_Btn.Location = new System.Drawing.Point(578, 215);
            this.BReset_Btn.Name = "BReset_Btn";
            this.BReset_Btn.Size = new System.Drawing.Size(142, 38);
            this.BReset_Btn.TabIndex = 21;
            this.BReset_Btn.Text = "Reset";
            this.BReset_Btn.UseVisualStyleBackColor = false;
            this.BReset_Btn.Click += new System.EventHandler(this.BReset_Btn_Click);
            // 
            // BEdit_btn
            // 
            this.BEdit_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.BEdit_btn.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEdit_btn.ForeColor = System.Drawing.Color.White;
            this.BEdit_btn.Location = new System.Drawing.Point(218, 215);
            this.BEdit_btn.Name = "BEdit_btn";
            this.BEdit_btn.Size = new System.Drawing.Size(142, 38);
            this.BEdit_btn.TabIndex = 20;
            this.BEdit_btn.Text = "Edit";
            this.BEdit_btn.UseVisualStyleBackColor = false;
            this.BEdit_btn.Click += new System.EventHandler(this.BEdit_btn_Click);
            // 
            // BDelete_btn
            // 
            this.BDelete_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.BDelete_btn.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDelete_btn.ForeColor = System.Drawing.Color.White;
            this.BDelete_btn.Location = new System.Drawing.Point(391, 215);
            this.BDelete_btn.Name = "BDelete_btn";
            this.BDelete_btn.Size = new System.Drawing.Size(142, 38);
            this.BDelete_btn.TabIndex = 19;
            this.BDelete_btn.Text = "Delete";
            this.BDelete_btn.UseVisualStyleBackColor = false;
            this.BDelete_btn.Click += new System.EventHandler(this.BDelete_btn_Click);
            // 
            // BSave_btn
            // 
            this.BSave_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.BSave_btn.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSave_btn.ForeColor = System.Drawing.Color.White;
            this.BSave_btn.Location = new System.Drawing.Point(30, 215);
            this.BSave_btn.Name = "BSave_btn";
            this.BSave_btn.Size = new System.Drawing.Size(142, 38);
            this.BSave_btn.TabIndex = 18;
            this.BSave_btn.Text = "Save";
            this.BSave_btn.UseVisualStyleBackColor = false;
            this.BSave_btn.Click += new System.EventHandler(this.BSave_btn_Click);
            // 
            // Bpricetb
            // 
            this.Bpricetb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bpricetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bpricetb.Location = new System.Drawing.Point(713, 152);
            this.Bpricetb.Name = "Bpricetb";
            this.Bpricetb.Size = new System.Drawing.Size(74, 27);
            this.Bpricetb.TabIndex = 17;
            // 
            // Bquantitytb
            // 
            this.Bquantitytb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bquantitytb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bquantitytb.Location = new System.Drawing.Point(596, 151);
            this.Bquantitytb.Name = "Bquantitytb";
            this.Bquantitytb.Size = new System.Drawing.Size(91, 27);
            this.Bquantitytb.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(709, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(592, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Quantity";
            // 
            // Bcatcb
            // 
            this.Bcatcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcatcb.FormattingEnabled = true;
            this.Bcatcb.Items.AddRange(new object[] {
            "Fiction",
            "Science",
            "Business",
            "Technology",
            "History",
            "Biography",
            "Philosophy",
            "Self-help",
            "Classic ",
            "Literature",
            "Design"});
            this.Bcatcb.Location = new System.Drawing.Point(429, 151);
            this.Bcatcb.Name = "Bcatcb";
            this.Bcatcb.Size = new System.Drawing.Size(147, 28);
            this.Bcatcb.TabIndex = 13;
            this.Bcatcb.Text = "Select Category";
            // 
            // Bauthortb
            // 
            this.Bauthortb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bauthortb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bauthortb.Location = new System.Drawing.Point(231, 151);
            this.Bauthortb.Name = "Bauthortb";
            this.Bauthortb.Size = new System.Drawing.Size(179, 27);
            this.Bauthortb.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Book Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Book Title";
            // 
            // Btitletb
            // 
            this.Btitletb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Btitletb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btitletb.Location = new System.Drawing.Point(30, 151);
            this.Btitletb.Name = "Btitletb";
            this.Btitletb.Size = new System.Drawing.Size(182, 27);
            this.Btitletb.TabIndex = 3;
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
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1321, 651);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Btitletb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Bcatcb;
        private System.Windows.Forms.TextBox Bauthortb;
        private System.Windows.Forms.TextBox Bpricetb;
        private System.Windows.Forms.TextBox Bquantitytb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BReset_Btn;
        private System.Windows.Forms.Button BEdit_btn;
        private System.Windows.Forms.Button BDelete_btn;
        private System.Windows.Forms.Button BSave_btn;
        private System.Windows.Forms.ComboBox Bcatcbsearch;
        private System.Windows.Forms.DataGridView BookDGV;
        private System.Windows.Forms.Button BRefresh_btn;
        private System.Windows.Forms.Label label3;
    }
}