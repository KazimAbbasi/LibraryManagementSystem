namespace LibraryManagemwntGUI
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            btnExit = new Button();
            btnSave = new Button();
            btnRefresh = new Button();
            txtEnrollment = new TextBox();
            txtDepartment = new TextBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtSemester = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Silver;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(851, 115);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(234, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Viner Hand ITC", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(409, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(195, 45);
            label1.TabIndex = 1;
            label1.Text = "Add Student";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(txtEnrollment);
            panel1.Controls.Add(txtDepartment);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtContact);
            panel1.Controls.Add(txtSemester);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(270, 114);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 392);
            panel1.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.WhiteSmoke;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            btnExit.Location = new Point(421, 341);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(118, 35);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.WhiteSmoke;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            btnSave.Location = new Point(249, 341);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 35);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save Info";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.WhiteSmoke;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            btnRefresh.Location = new Point(82, 341);
            btnRefresh.Margin = new Padding(4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(118, 35);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            txtEnrollment.Location = new Point(249, 84);
            txtEnrollment.Margin = new Padding(4);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(229, 32);
            txtEnrollment.TabIndex = 12;
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            txtDepartment.Location = new Point(249, 132);
            txtDepartment.Margin = new Padding(4);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(229, 32);
            txtDepartment.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            txtEmail.Location = new Point(249, 272);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 32);
            txtEmail.TabIndex = 10;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            txtContact.Location = new Point(249, 223);
            txtContact.Margin = new Padding(4);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(229, 32);
            txtContact.TabIndex = 9;
            // 
            // txtSemester
            // 
            txtSemester.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            txtSemester.Location = new Point(249, 178);
            txtSemester.Margin = new Padding(4);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(229, 32);
            txtSemester.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            txtName.Location = new Point(249, 32);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 32);
            txtName.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label7.Location = new Point(19, 277);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(127, 24);
            label7.TabIndex = 6;
            label7.Text = "Student Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label6.Location = new Point(19, 228);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(143, 24);
            label6.TabIndex = 5;
            label6.Text = "Student Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label5.Location = new Point(19, 181);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(145, 24);
            label5.TabIndex = 4;
            label5.Text = "Student Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label4.Location = new Point(19, 132);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 24);
            label4.TabIndex = 3;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label3.Location = new Point(19, 84);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(164, 24);
            label3.TabIndex = 2;
            label3.Text = "Enrollment Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            label2.Location = new Point(19, 37);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 24);
            label2.TabIndex = 1;
            label2.Text = "Student Name";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 114);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(269, 389);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 504);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEnrollment;
        private TextBox txtDepartment;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtSemester;
        private TextBox txtName;
        private Button btnExit;
        private Button btnSave;
        private Button btnRefresh;
    }
}