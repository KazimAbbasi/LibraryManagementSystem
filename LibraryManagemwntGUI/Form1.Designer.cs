namespace LibraryManagemwntGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            btnLogin = new Button();
            pictureBoxInstagram = new PictureBox();
            pictureBoxYoutube = new PictureBox();
            pictureBoxFacebook = new PictureBox();
            btnClose = new Button();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInstagram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxYoutube).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFacebook).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(125, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.loading_gif;
            pictureBox2.Location = new Point(125, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(83, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(35, 36, 55);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Viner Hand ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(71, 206);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(183, 28);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "Username";
            txtUsername.MouseClick += txtUsername_MouseClick;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(35, 36, 55);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Viner Hand ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(71, 260);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(183, 28);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Password";
            txtPassword.MouseClick += txtPassword_MouseClick;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(37, 204);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Gemini_Generated_Image_s9pzqws9pzqws9pz;
            pictureBox4.Location = new Point(37, 264);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(22, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(65, 237);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 1);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 4);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(65, 290);
            panel3.Name = "panel3";
            panel3.Size = new Size(183, 1);
            panel3.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Info;
            button2.Location = new Point(50, 374);
            button2.Name = "button2";
            button2.Size = new Size(211, 29);
            button2.TabIndex = 9;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 255, 255);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(50, 328);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(211, 29);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBoxInstagram
            // 
            pictureBoxInstagram.Image = (Image)resources.GetObject("pictureBoxInstagram.Image");
            pictureBoxInstagram.Location = new Point(71, 427);
            pictureBoxInstagram.Name = "pictureBoxInstagram";
            pictureBoxInstagram.Size = new Size(33, 32);
            pictureBoxInstagram.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxInstagram.TabIndex = 11;
            pictureBoxInstagram.TabStop = false;
            pictureBoxInstagram.Click += pictureBoxInstagram_Click;
            // 
            // pictureBoxYoutube
            // 
            pictureBoxYoutube.Image = (Image)resources.GetObject("pictureBoxYoutube.Image");
            pictureBoxYoutube.Location = new Point(209, 427);
            pictureBoxYoutube.Name = "pictureBoxYoutube";
            pictureBoxYoutube.Size = new Size(33, 32);
            pictureBoxYoutube.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxYoutube.TabIndex = 12;
            pictureBoxYoutube.TabStop = false;
            pictureBoxYoutube.Click += pictureBoxYoutube_Click;
            // 
            // pictureBoxFacebook
            // 
            pictureBoxFacebook.Image = (Image)resources.GetObject("pictureBoxFacebook.Image");
            pictureBoxFacebook.Location = new Point(139, 427);
            pictureBoxFacebook.Name = "pictureBoxFacebook";
            pictureBoxFacebook.Size = new Size(33, 32);
            pictureBoxFacebook.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFacebook.TabIndex = 13;
            pictureBoxFacebook.TabStop = false;
            pictureBoxFacebook.Click += pictureBoxFacebook_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(64, 64, 64);
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Viner Hand ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(291, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 34);
            btnClose.TabIndex = 14;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(btnLogin);
            panel4.Controls.Add(pictureBoxInstagram);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(pictureBoxFacebook);
            panel4.Controls.Add(txtUsername);
            panel4.Controls.Add(txtPassword);
            panel4.Controls.Add(btnClose);
            panel4.Controls.Add(pictureBoxYoutube);
            panel4.ForeColor = SystemColors.MenuHighlight;
            panel4.Location = new Point(2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(330, 487);
            panel4.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 55);
            ClientSize = new Size(331, 492);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxInstagram).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxYoutube).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFacebook).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
        private Button btnLogin;
        private PictureBox pictureBoxInstagram;
        private PictureBox pictureBoxYoutube;
        private PictureBox pictureBoxFacebook;
        private Button btnClose;
        private Panel panel4;
    }
}
