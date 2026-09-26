using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtube_prac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFullDetails_Click(object sender, EventArgs e)
        {
            string title = cbxTitle.Text;
            string initials = txtInitials.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            decimal age = nudAge.Value;

            rtbOutput.Text = "Full Details: " + "\n" + "Title: " + title + "\n" + "Initials: " + initials;
            rtbOutput.Text += "\n" + "Name: " + name + "\n" + "Surname: " + surname + "\n"+ "Age: " + Convert.ToString(age);
        }

        private void btnShowSummary_Click(object sender, EventArgs e)
        {
            string title = cbxTitle.Text;
            string surname = txtSurname.Text;
            
            MessageBox.Show("Summary Details: \n" + title + " " + surname);
        }
    }
}
