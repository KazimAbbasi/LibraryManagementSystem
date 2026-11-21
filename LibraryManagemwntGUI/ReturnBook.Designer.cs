namespace LibraryManagemwntGUI
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            panel1 = new Panel();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearchStudent = new Button();
            txtEnterEnroll = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnCancel = new Button();
            btnReturn = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtBookIssueDate = new TextBox();
            txtBookName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnSearchStudent);
            panel1.Controls.Add(txtEnterEnroll);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 368);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Viner Hand ITC", 10.2F, FontStyle.Bold);
            btnExit.Location = new Point(134, 309);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Viner Hand ITC", 10.2F, FontStyle.Bold);
            btnRefresh.Location = new Point(25, 309);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.FlatStyle = FlatStyle.Popup;
            btnSearchStudent.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchStudent.Location = new Point(44, 197);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(141, 42);
            btnSearchStudent.TabIndex = 5;
            btnSearchStudent.Text = "Search Student";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // txtEnterEnroll
            // 
            txtEnterEnroll.Font = new Font("Viner Hand ITC", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnterEnroll.Location = new Point(25, 145);
            txtEnterEnroll.Name = "txtEnterEnroll";
            txtEnterEnroll.Size = new Size(189, 28);
            txtEnterEnroll.TabIndex = 4;
            txtEnterEnroll.TextChanged += txtEnterEnroll_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 115);
            label1.Name = "label1";
            label1.Size = new Size(203, 27);
            label1.TabIndex = 3;
            label1.Text = "Enter Enrollment No.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(277, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(717, 368);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnReturn);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtBookIssueDate);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(277, 386);
            panel2.Name = "panel2";
            panel2.Size = new Size(717, 141);
            panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Viner Hand ITC", 10.2F, FontStyle.Bold);
            btnCancel.Location = new Point(508, 74);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReturn
            // 
            btnReturn.FlatStyle = FlatStyle.Popup;
            btnReturn.Font = new Font("Viner Hand ITC", 10.2F, FontStyle.Bold);
            btnReturn.Location = new Point(508, 28);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 29);
            btnReturn.TabIndex = 14;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(177, 87);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(267, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // txtBookIssueDate
            // 
            txtBookIssueDate.Font = new Font("Viner Hand ITC", 7.8F);
            txtBookIssueDate.Location = new Point(177, 54);
            txtBookIssueDate.Name = "txtBookIssueDate";
            txtBookIssueDate.Size = new Size(267, 28);
            txtBookIssueDate.TabIndex = 12;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Viner Hand ITC", 7.8F);
            txtBookName.Location = new Point(177, 20);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(267, 28);
            txtBookName.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label4.Location = new Point(24, 97);
            label4.Name = "label4";
            label4.Size = new Size(148, 24);
            label4.TabIndex = 10;
            label4.Text = "Book Return Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 62);
            label3.Name = "label3";
            label3.Size = new Size(130, 24);
            label3.TabIndex = 9;
            label3.Text = "Book Issue Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label2.Location = new Point(24, 28);
            label2.Name = "label2";
            label2.Size = new Size(96, 24);
            label2.TabIndex = 8;
            label2.Text = "Book Name";
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1006, 406);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ReturnBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnBook";
            Load += ReturnBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btnSearchStudent;
        private TextBox txtEnterEnroll;
        private Label label1;
        private Button btnExit;
        private Button btnRefresh;
        private Button btnCancel;
        private Button btnReturn;
        private DateTimePicker dateTimePicker1;
        private TextBox txtBookIssueDate;
        private TextBox txtBookName;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}