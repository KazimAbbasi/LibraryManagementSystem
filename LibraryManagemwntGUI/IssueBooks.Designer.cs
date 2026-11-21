namespace LibraryManagemwntGUI
{
    partial class IssueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBooks));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            txtEnroll = new TextBox();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearch = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            txtSem = new TextBox();
            comboBox = new ComboBox();
            btnIssueBook = new Button();
            label11 = new Label();
            dateTimePicker = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            txtDepartment = new TextBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(10, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(384, 54);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 1;
            label1.Text = "Issue Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(216, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(txtEnroll);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(10, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 368);
            panel2.TabIndex = 1;
            // 
            // txtEnroll
            // 
            txtEnroll.Location = new Point(44, 144);
            txtEnroll.Name = "txtEnroll";
            txtEnroll.Size = new Size(173, 27);
            txtEnroll.TabIndex = 6;
            txtEnroll.TextChanged += txtEnroll_TextChanged;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Viner Hand ITC", 10.2F, FontStyle.Bold);
            btnExit.Location = new Point(153, 272);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Viner Hand ITC", 10.2F, FontStyle.Bold);
            btnRefresh.Location = new Point(27, 272);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(92, 29);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Viner Hand ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(44, 195);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(173, 49);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search Student";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 108);
            label2.Name = "label2";
            label2.Size = new Size(173, 24);
            label2.TabIndex = 1;
            label2.Text = "Enter Enrollment NO";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(68, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.LightSeaGreen;
            panel3.Controls.Add(txtSem);
            panel3.Controls.Add(comboBox);
            panel3.Controls.Add(btnIssueBook);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(dateTimePicker);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtDepartment);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtContact);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(275, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(422, 368);
            panel3.TabIndex = 6;
            // 
            // txtSem
            // 
            txtSem.Location = new Point(175, 100);
            txtSem.Name = "txtSem";
            txtSem.ReadOnly = true;
            txtSem.Size = new Size(229, 27);
            txtSem.TabIndex = 32;
            // 
            // comboBox
            // 
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(175, 219);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(229, 28);
            comboBox.TabIndex = 31;
            // 
            // btnIssueBook
            // 
            btnIssueBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIssueBook.FlatStyle = FlatStyle.Popup;
            btnIssueBook.Font = new Font("Viner Hand ITC", 10.2F, FontStyle.Bold);
            btnIssueBook.Location = new Point(318, 308);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(86, 29);
            btnIssueBook.TabIndex = 6;
            btnIssueBook.Text = "Issue ";
            btnIssueBook.UseVisualStyleBackColor = true;
            btnIssueBook.Click += btnIssueBook_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Viner Hand ITC", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Firebrick;
            label11.Location = new Point(4, 339);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(307, 29);
            label11.TabIndex = 30;
            label11.Text = "Maximum Issue Limit is 3 Books";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker.Location = new Point(175, 254);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(229, 27);
            dateTimePicker.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label9.Location = new Point(15, 257);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(130, 24);
            label9.TabIndex = 28;
            label9.Text = "Book Issue Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label10.Location = new Point(17, 223);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(102, 24);
            label10.TabIndex = 27;
            label10.Text = "Books Name";
            // 
            // txtDepartment
            // 
            txtDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDepartment.Font = new Font("Viner Hand ITC", 7.8F);
            txtDepartment.Location = new Point(175, 62);
            txtDepartment.Margin = new Padding(4);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.ReadOnly = true;
            txtDepartment.Size = new Size(229, 28);
            txtDepartment.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Viner Hand ITC", 7.8F);
            txtEmail.Location = new Point(175, 183);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(229, 28);
            txtEmail.TabIndex = 22;
            // 
            // txtContact
            // 
            txtContact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContact.Font = new Font("Viner Hand ITC", 7.8F);
            txtContact.Location = new Point(175, 143);
            txtContact.Margin = new Padding(4);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(229, 28);
            txtContact.TabIndex = 21;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("Viner Hand ITC", 7.8F);
            txtName.Location = new Point(175, 14);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(229, 28);
            txtName.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label7.Location = new Point(15, 184);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(127, 24);
            label7.TabIndex = 18;
            label7.Text = "Student Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label6.Location = new Point(15, 147);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(143, 24);
            label6.TabIndex = 17;
            label6.Text = "Student Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label5.Location = new Point(15, 104);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(145, 24);
            label5.TabIndex = 16;
            label5.Text = "Student Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label4.Location = new Point(15, 63);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 24);
            label4.TabIndex = 15;
            label4.Text = "Department";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label8.Location = new Point(15, 22);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(123, 24);
            label8.TabIndex = 13;
            label8.Text = "Student Name";
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(705, 504);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IssueBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IssueBooks";
            Load += IssueBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private Button btnExit;
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtEnrollment;
        private Panel panel3;
    
        private TextBox txtDepartment;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtSemester;
        private TextBox txtName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private DateTimePicker dateTimePicker;
        private Label label9;
        private Label label10;
        private TextBox textBox2;
        private Button btnIssueBook;
        private Label label11;
        private ComboBox comboBox;
        private TextBox txtSem;
        private TextBox txtEnroll;
    }
}