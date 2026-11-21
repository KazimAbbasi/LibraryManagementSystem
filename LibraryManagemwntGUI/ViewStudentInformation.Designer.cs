namespace LibraryManagemwntGUI
{
    partial class ViewStudentInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentInformation));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnRefresh = new Button();
            txtSearchEnrollment = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            txtSemester = new TextBox();
            txtSName = new TextBox();
            txtEnrollment = new TextBox();
            txtDepartment = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label9 = new Label();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(5, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(965, 131);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(357, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Viner Hand ITC", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(534, 32);
            label1.Name = "label1";
            label1.Size = new Size(73, 37);
            label1.TabIndex = 2;
            label1.Text = "View";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Viner Hand ITC", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(534, 69);
            label2.Name = "label2";
            label2.Size = new Size(112, 37);
            label2.TabIndex = 3;
            label2.Text = "Student";
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(554, 142);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearchEnrollment
            // 
            txtSearchEnrollment.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchEnrollment.Location = new Point(370, 139);
            txtSearchEnrollment.Name = "txtSearchEnrollment";
            txtSearchEnrollment.Size = new Size(158, 32);
            txtSearchEnrollment.TabIndex = 7;
            txtSearchEnrollment.TextChanged += txtSearchEnrollment_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(210, 142);
            label3.Name = "label3";
            label3.Size = new Size(129, 24);
            label3.TabIndex = 6;
            label3.Text = "Enrollment No.";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(944, 305);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(txtSemester);
            panel2.Controls.Add(txtSName);
            panel2.Controls.Add(txtEnrollment);
            panel2.Controls.Add(txtDepartment);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnCancel);
            panel2.Location = new Point(5, 504);
            panel2.Name = "panel2";
            panel2.Size = new Size(961, 361);
            panel2.TabIndex = 10;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(667, 25);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(154, 27);
            txtSemester.TabIndex = 20;
            // 
            // txtSName
            // 
            txtSName.Location = new Point(247, 25);
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(154, 27);
            txtSName.TabIndex = 18;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Location = new Point(247, 109);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(154, 27);
            txtEnrollment.TabIndex = 17;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(247, 194);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(154, 27);
            txtDepartment.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label8.Location = new Point(474, 194);
            label8.Name = "label8";
            label8.Size = new Size(127, 24);
            label8.TabIndex = 14;
            label8.Text = "Student Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label7.Location = new Point(474, 109);
            label7.Name = "label7";
            label7.Size = new Size(143, 24);
            label7.TabIndex = 13;
            label7.Text = "Student Contact";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label6.Location = new Point(474, 29);
            label6.Name = "label6";
            label6.Size = new Size(145, 24);
            label6.TabIndex = 12;
            label6.Text = "Student Semester";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label5.Location = new Point(81, 198);
            label5.Name = "label5";
            label5.Size = new Size(104, 24);
            label5.TabIndex = 11;
            label5.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label4.Location = new Point(81, 113);
            label4.Name = "label4";
            label4.Size = new Size(164, 24);
            label4.TabIndex = 10;
            label4.Text = "Enrollment Number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label9.Location = new Point(81, 29);
            label9.Name = "label9";
            label9.Size = new Size(123, 24);
            label9.TabIndex = 9;
            label9.Text = "Student Name";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(667, 109);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(154, 27);
            txtContact.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(667, 187);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(154, 27);
            txtEmail.TabIndex = 5;
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
            // ViewStudentInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(968, 490);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearchEnrollment);
            Controls.Add(label3);
            Name = "ViewStudentInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewStudentInformation";
            Load += ViewStudentInformation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnRefresh;
        private TextBox txtSearchEnrollment;
        private Label label3;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox txtSemester;
        private TextBox txtSName;
        private TextBox txtEnrollment;
        private TextBox txtDepartment;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label9;
        private TextBox txtContact;
        private TextBox txtEmail;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCancel;
    }
}