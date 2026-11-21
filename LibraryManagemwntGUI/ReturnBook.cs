using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagemwntGUI
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from IRBook where  std_enroll = '" + txtEnterEnroll.Text + "' and book_return_date IS NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtEnterEnroll.Clear();
        }

        String bname;
        String bdate;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();    //7 and 8 and 0 are the cell numbers in the database
            }
            txtBookName.Text = bname;
            txtBookIssueDate.Text = bdate;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update IRBook set book_return_date='" + dateTimePicker1.Text + "'where std_enroll='" + txtEnterEnroll.Text + "' and std_id=" + rowid + " ";

            cmd.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("Return Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReturnBook_Load(this, null);  //To refresh the page after book is returned
        }

        private void txtEnterEnroll_TextChanged(object sender, EventArgs e)
        {
            if (txtEnterEnroll.Text == "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnterEnroll.Clear(); // gonna use the upper function as a strength to refresh everything
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure You Want To Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
