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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEnrollment.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            txtEmail.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" && txtEnrollment.Text != "" && txtDepartment.Text != "" && txtSemester.Text != "" && txtContact.Text != "" && txtEmail.Text != "")
            {
                String name = txtName.Text;
                String enroll = txtEnrollment.Text;
                String dep = txtDepartment.Text;
                String sem = txtSemester.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                String email = txtEmail.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewStudent(sname,enroll,dep,sem,contact,email) values('" + name + "','" + enroll + "','" + dep + "','" + sem + "'," + mobile + ",'" + email + "')";

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
