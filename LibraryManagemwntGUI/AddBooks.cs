using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace LibraryManagemwntGUI
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtAuthor.Text != "" && txtPublication.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            {


                String bname = txtBookName.Text;   //  this is gonna be doing that it will take the text which is in the box of book namr from front and save it in this variable
                String bauthor = txtAuthor.Text;
                String publication = txtPublication.Text;
                String pdate = dateTimePicker1.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                Int64 quan = Int64.Parse(txtQuantity.Text);  // THIS PARSING IS LIKE CONVERTING STRING TO INTEGER LIKE C++ INT(FLOAT A) YANI TYPECASTING

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewBook(bName,bAuthor,bPubl,bPDate,bPrice,bQuan) values('" + bname + "','" + bauthor + "','" + publication + "','" + pdate + "'," + price + "," + quan + ")";  // STRINGS K LIYE PEHLY SINGLE USS K ANDAR DOUBLE BUT FOR INTEGER JUST DOUBLE QUOTE
                cmd.ExecuteNonQuery();  //YE KHATAM KAR K BAND KR DE GI QUERY

                con.Close();   //YE CONNECTION BAND KR DE GA

                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookName.Clear();
                txtAuthor.Clear();
                txtPublication.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();   // YE FORM KO CLOSE KR DE GA
            }
            else
            {
                // Do nothing, just return to the form
            }

        }
    }
}
