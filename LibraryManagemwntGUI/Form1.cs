using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace LibraryManagemwntGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void pictureBoxYoutube_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo  //HERE IT IS BYPASSING THE EXTRA SECURITY OF THE .NET 10.0 FRAMEWORK AND OPENING THE LINK DIRECTLY IN THE BROWSER
            {
                FileName = "https://www.youtube.com/watch?v=HhjHYkPQ8F0&list=RDxvT1jH8B9AM&index=19",
                UseShellExecute = true  //The UseShellExecute = true command is the key piece that routes the request to Broweser 
            });
        }

        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=HhjHYkPQ8F0&list=RDxvT1jH8B9AM&index=19",
                UseShellExecute = true
            });
        }

        private void pictureBoxInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=HhjHYkPQ8F0&list=RDxvT1jH8B9AM&index=19",
                UseShellExecute = true
            });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            // FIXED: Using parameters to safely pass data and prevent SQL Injection
            cmd.CommandText = "select * from loginTable where username=@user and pass=@pass";
            cmd.Parameters.AddWithValue("@user", txtUsername.Text);
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            // The crash occurred here because the database was missing. 
            // It will work once you run the SQL script in Step 1.
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard d=new Dashboard();
                d.Show();


            }
            else
            {
                MessageBox.Show("Wrong UserName Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
