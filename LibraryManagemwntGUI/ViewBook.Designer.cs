namespace LibraryManagemwntGUI
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtBookName = new TextBox();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            txtPDate = new TextBox();
            txtBName = new TextBox();
            txtAuthor = new TextBox();
            txtPublication = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(1, 1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(966, 108);
            flowLayoutPanel1.TabIndex = 0;
            
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(381, -20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Viner Hand ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(582, 19);
            label1.Name = "label1";
            label1.Size = new Size(133, 37);
            label1.TabIndex = 1;
            label1.Text = "Inventory";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(330, 120);
            label2.Name = "label2";
            label2.Size = new Size(96, 24);
            label2.TabIndex = 2;
            label2.Text = "Book Name";
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBookName.Location = new Point(441, 116);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(158, 32);
            txtBookName.TabIndex = 3;
            txtBookName.TextChanged += txtBookName_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(621, 114);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(966, 294);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(txtPDate);
            panel1.Controls.Add(txtBName);
            panel1.Controls.Add(txtAuthor);
            panel1.Controls.Add(txtPublication);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnCancel);
            panel1.Location = new Point(1, 467);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 361);
            panel1.TabIndex = 6;
            // 
            // txtPDate
            // 
            txtPDate.Location = new Point(667, 25);
            txtPDate.Name = "txtPDate";
            txtPDate.Size = new Size(154, 27);
            txtPDate.TabIndex = 20;
            // 
            // txtBName
            // 
            txtBName.Location = new Point(247, 25);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(154, 27);
            txtBName.TabIndex = 18;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(247, 109);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(154, 27);
            txtAuthor.TabIndex = 17;
            // 
            // txtPublication
            // 
            txtPublication.Location = new Point(247, 194);
            txtPublication.Name = "txtPublication";
            txtPublication.Size = new Size(154, 27);
            txtPublication.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label8.Location = new Point(474, 194);
            label8.Name = "label8";
            label8.Size = new Size(130, 24);
            label8.TabIndex = 14;
            label8.Text = "Book Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label7.Location = new Point(474, 109);
            label7.Name = "label7";
            label7.Size = new Size(91, 24);
            label7.TabIndex = 13;
            label7.Text = "Book Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label6.Location = new Point(474, 29);
            label6.Name = "label6";
            label6.Size = new Size(166, 24);
            label6.TabIndex = 12;
            label6.Text = "Book Purchase Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label5.Location = new Point(81, 198);
            label5.Name = "label5";
            label5.Size = new Size(146, 24);
            label5.TabIndex = 11;
            label5.Text = "Book Publication";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label4.Location = new Point(81, 113);
            label4.Name = "label4";
            label4.Size = new Size(108, 24);
            label4.TabIndex = 10;
            label4.Text = "Book Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label3.Location = new Point(81, 29);
            label3.Name = "label3";
            label3.Size = new Size(96, 24);
            label3.TabIndex = 9;
            label3.Text = "Book Name";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(667, 109);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(154, 27);
            txtPrice.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(667, 187);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(154, 27);
            txtQuantity.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(705, 290);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            btnUpdate.Location = new Point(579, 290);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            btnCancel.Location = new Point(830, 290);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(968, 489);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(txtBookName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel1);
            Name = "ViewBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBook";
            Load += ViewBook_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtBookName;
        private Button btnRefresh;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCancel;
        private TextBox txtBName;
        private TextBox txtAuthor;
        private TextBox txtPublication;
        private TextBox txtPDate;
    }
}