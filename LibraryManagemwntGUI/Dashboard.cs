using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagemwntGUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Coniform", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks addBooks = new AddBooks();
            addBooks.Show();
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.Show();

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent ast = new AddStudent();
            ast.Show();
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentInformation vsi = new ViewStudentInformation();
            vsi.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks isb = new IssueBooks();
            isb.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook rb = new ReturnBook();
            rb.Show();
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBookDetails cbd= new CompleteBookDetails();
            cbd.Show();
        }
    }
}
