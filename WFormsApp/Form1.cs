using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text != "First Name" && tbLastName.Text != "Last Name")
            {
                lbWelcome.Text = "Welcome " + tbFirstName.Text + " " + tbLastName.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = "First Name";
            tbFirstName.ForeColor = Color.Silver;
            tbLastName.Text = "Last Name";
            tbLastName.ForeColor = Color.Silver;
            lbWelcome.Text = "";
        }

        private void tbFirstName_Enter(object sender, EventArgs e)
        {
            if (tbFirstName.Text == "First Name") {
                tbFirstName.Text = "";
                tbFirstName.ForeColor = Color.Black;
            }
        }

        private void tbFirstName_Leave(object sender, EventArgs e)
        {
            if (tbFirstName.Text == "")
            {
                tbFirstName.Text = "First Name";
                tbFirstName.ForeColor = Color.Silver;
            }
        }

        private void tbLastName_Enter(object sender, EventArgs e)
        {
            if (tbLastName.Text == "Last Name")
            {
                tbLastName.Text = "";
                tbLastName.ForeColor = Color.Black;
            }
        }

        private void tbLastName_Leave(object sender, EventArgs e)
        {
            if (tbLastName.Text == "")
            {
                tbLastName.Text = "Last Name";
                tbLastName.ForeColor = Color.Silver;
            }
        }
    }
}
