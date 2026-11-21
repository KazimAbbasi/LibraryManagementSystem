using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace LibraryManagemwntGUI
{
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;  // iss line se panel hide ho gya view book main neechy wala
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewBook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];  // Iss line se e Table ki form main data show ho rha view book main

        }


        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)    // e ooper wala wo argument hai jo cell click karne pe aata hai aur uska index hota hai
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel1.Visible = true;  // iss line se panel show ho gya view book main neechy wala

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewBook where bid=" + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtBName.Text = ds.Tables[0].Rows[0][1].ToString();   // with these lines when one book is clicked in the upper table then its details will be shown in the lower panel
            txtAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtPublication.Text = ds.Tables[0].Rows[0][3].ToString();
            txtPDate.Text = ds.Tables[0].Rows[0][4].ToString();
            txtPrice.Text = ds.Tables[0].Rows[0][5].ToString();
            txtQuantity.Text = ds.Tables[0].Rows[0][6].ToString();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;  // iss line se panel hide ho gya view book main neechy wala
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            if (txtBookName.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewBook where bname LIKE '" + txtBookName.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewBook";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            panel1.Visible = false;  // iss line se panel hide ho gya view book main neechy wala
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                string bname = txtBName.Text;
                string author = txtAuthor.Text;
                string publication = txtPublication.Text;
                string pdate = txtPDate.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                Int64 quantity = Int64.Parse(txtQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NewBook set bName='" + bname + "',bAuthor='" + author + "', bPubl='" + publication + "',bPDate='" + pdate + "', bPrice=" + price + ", bQuan=" + quantity + " where bid=" + rowid;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                ViewBook_Load(this, null);  // iss line se update hone ke baad table refresh ho jaye view book main
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewBook where bid=" + rowid;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

            }


        }

       
    }
}
