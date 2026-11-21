namespace LibraryManagemwntGUI
{
    partial class AddBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooks));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            panel6 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtPublication = new TextBox();
            txtAuthor = new TextBox();
            txtBookName = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 349);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 77);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(356, 21);
            label1.Name = "label1";
            label1.Size = new Size(124, 37);
            label1.TabIndex = 4;
            label1.Text = "Add Book";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(233, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.Location = new Point(273, 71);
            panel5.Name = "panel5";
            panel5.Size = new Size(419, 348);
            panel5.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Wheat;
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(275, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(407, 346);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Location = new Point(275, 76);
            panel4.Name = "panel4";
            panel4.Size = new Size(410, 349);
            panel4.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(275, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 349);
            panel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 192, 128);
            panel6.Controls.Add(btnCancel);
            panel6.Controls.Add(btnSave);
            panel6.Controls.Add(txtQuantity);
            panel6.Controls.Add(txtPrice);
            panel6.Controls.Add(txtPublication);
            panel6.Controls.Add(txtAuthor);
            panel6.Controls.Add(txtBookName);
            panel6.Controls.Add(dateTimePicker1);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(270, 74);
            panel6.Name = "panel6";
            panel6.Size = new Size(419, 353);
            panel6.TabIndex = 2;
            panel6.Paint += panel6_Paint;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(128, 64, 64);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Transparent;
            btnCancel.Location = new Point(120, 315);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(76, 27);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 64, 64);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Viner Hand ITC", 7.8F, FontStyle.Italic);
            btnSave.ForeColor = Color.Transparent;
            btnSave.Location = new Point(233, 315);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(70, 27);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Viner Hand ITC", 7.8F, FontStyle.Italic);
            txtQuantity.Location = new Point(203, 274);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(197, 28);
            txtQuantity.TabIndex = 14;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Viner Hand ITC", 7.8F, FontStyle.Italic);
            txtPrice.Location = new Point(203, 230);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(197, 28);
            txtPrice.TabIndex = 13;
            // 
            // txtPublication
            // 
            txtPublication.Font = new Font("Viner Hand ITC", 7.8F, FontStyle.Italic);
            txtPublication.Location = new Point(203, 137);
            txtPublication.Name = "txtPublication";
            txtPublication.Size = new Size(197, 28);
            txtPublication.TabIndex = 12;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Viner Hand ITC", 7.8F, FontStyle.Italic);
            txtAuthor.Location = new Point(203, 96);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(197, 28);
            txtAuthor.TabIndex = 11;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Viner Hand ITC", 7.8F, FontStyle.Italic);
            txtBookName.Location = new Point(203, 45);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(197, 28);
            txtBookName.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Viner Hand ITC", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(203, 184);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(197, 28);
            dateTimePicker1.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 274);
            label7.Name = "label7";
            label7.Size = new Size(81, 24);
            label7.TabIndex = 8;
            label7.Text = "Quantity";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 233);
            label6.Name = "label6";
            label6.Size = new Size(81, 24);
            label6.TabIndex = 7;
            label6.Text = "Book Price";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 187);
            label5.Name = "label5";
            label5.Size = new Size(148, 24);
            label5.TabIndex = 6;
            label5.Text = "Book Purchase Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 141);
            label4.Name = "label4";
            label4.Size = new Size(130, 24);
            label4.TabIndex = 5;
            label4.Text = "Book Publication";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 96);
            label3.Name = "label3";
            label3.Size = new Size(141, 24);
            label3.TabIndex = 4;
            label3.Text = "Book Author Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 55);
            label2.Name = "label2";
            label2.Size = new Size(87, 24);
            label2.TabIndex = 3;
            label2.Text = "Book Name";
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 420);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "AddBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBooks";
            Load += AddBooks_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel6;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtPublication;
        private TextBox txtAuthor;
        private TextBox txtBookName;
        private DateTimePicker dateTimePicker1;
    }
}