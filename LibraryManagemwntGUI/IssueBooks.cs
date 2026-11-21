using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagemwntGUI
{
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select bName from NewBook", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    comboBox.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            con.Close();
        }

        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEnroll.Text != "")
            {
                String eid = txtEnroll.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select* from NewStudent where  enroll = '" + eid + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //-----------------------------------------------------------------------------------------------------------------
                //Code to Count How many Books are Issued on this Enrollment Number


                cmd.CommandText = "select count(std_enroll) from IRBook where  std_enroll = '" + eid + "'and book_return_date is null";  //this count() is a function og sql not the count variable declared above;
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA.Fill(DS1);

                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString()); // gonna count how many books are issued to this student



                //-----------------------------------------------------------------------------------------------------------------

                if (DS.Tables[0].Rows.Count != 0)  //ye aise hai k jab student ki id searh hogi aur agr uss ,aim kuch na ho ya ghalat ho tou ye execute hoga
                {
                    txtName.Text = DS.Tables[0].Rows[0][1].ToString();  //THis if is gonna work If DS dataset have a valid value inside it means a right student id 
                    txtDepartment.Text = DS.Tables[0].Rows[0][3].ToString(); //Rows[0][2] assigns the enrollment because of the data table so skipped it
                    txtSem.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = DS.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = DS.Tables[0].Rows[0][6].ToString();
                }


                //-----------------------------------------------------------------------------------------------------------------



                else
                {
                    txtName.Clear();
                    txtDepartment.Clear();  // this will work if above condition is false like DS dataset have a wrong value
                    txtSem.Clear();
                    txtContact.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("Invalid Student Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {

            if (txtName.Text != "")
            {
                if (comboBox.SelectedIndex != -1 && count <= 2)
                {
                    String enroll = txtEnroll.Text;
                    String sname = txtName.Text;
                    String sdep = txtDepartment.Text;
                    String sem = txtSem.Text;
                    Int64 contact = Int64.Parse(txtContact.Text);
                    String email = txtEmail.Text;
                    String bookname = comboBox.Text;
                    String bookIssueDate = dateTimePicker.Text;


                    String eid = txtEnroll.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandText = "insert into IRBook(std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date) values('" + enroll + "','" + sname + "','" + sdep + "','" + sem + "'," + contact + ",'" + email + "','" + bookname + "','" + bookIssueDate + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Book Issued", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select Book or Maximum Number of BOoks Have Been Issued", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Enrollment Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEnroll_TextChanged(object sender, EventArgs e)
        {
            txtName.Clear();
            txtDepartment.Clear();
            txtSem.Clear();
            txtContact.Clear();
            txtEmail.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnroll.Clear(); //iss se ooper likhi condition true hogi tou sab khatam ho jaana
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}