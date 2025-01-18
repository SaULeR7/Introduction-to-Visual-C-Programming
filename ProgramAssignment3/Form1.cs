using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProgramAssignment3.Program;

namespace ProgramAssignment3
{
    public partial class Form1 : Form
    {
        BankAccount bAccount;
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (fNameTb.Text != "" && lNameTb.Text != "" && balanceTb.Text != "")
            {
                LoginPnl.Visible = false;
                AccountPnl.Visible = true;
                bAccount = new BankAccount("12345", fNameTb.Text, lNameTb.Text, Convert.ToInt32(balanceTb.Text));
                loadMethod();
            }
            else {
                if (fNameTb.Text == "") { fNameTb.BackColor = Color.Red; fNameTb.Focus(); }
                if (lNameTb.Text == "") { lNameTb.BackColor = Color.Red; lNameTb.Focus(); }
                if (balanceTb.Text == "") { balanceTb.BackColor = Color.Red; balanceTb.Focus(); }
            }
        }

        void loadMethod() {
            label5.Text = bAccount.FirstName;
            label6.Text = bAccount.LastName;
            label7.Text = bAccount.Balance.ToString();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 1) {
                if (bAccount.deposit(Convert.ToInt32(textBox1.Text)) == "1"){
                    label7.Text = bAccount.Balance.ToString();
                    textBox2.Text = "Transaction approved.";
                }
                else {
                    textBox2.Text = (bAccount.deposit(Convert.ToInt32(textBox1.Text)));
                }
            }
            else
            {
                if (bAccount.withdraw(Convert.ToInt32(textBox1.Text)) == "1")
                {
                    label7.Text = bAccount.Balance.ToString();
                    textBox2.Text = "Transaction approved.";
                }
                else
                {
                    textBox2.Text = (bAccount.withdraw(Convert.ToInt32(textBox1.Text)));
                }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void fNameTb_Leave(object sender, EventArgs e)
        {
            if (fNameTb.Text == "")
            {
                fNameTb.Focus();
                //MessageBox.Show("Can't be empty");
                fNameTb.BackColor = Color.Red;
            }
        }

        private void lNameTb_Leave(object sender, EventArgs e)
        {
            if (lNameTb.Text == "")
            {
                lNameTb.Focus();
                //MessageBox.Show("Can't be empty");
                lNameTb.BackColor = Color.Red;
            }
        }

        private void balanceTb_Leave(object sender, EventArgs e)
        {
            if (balanceTb.Text == "")
            {
                balanceTb.Focus();
                //MessageBox.Show("Can't be empty");
                balanceTb.BackColor = Color.Red;
            }
        }

        private void fNameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            fNameTb.BackColor = Color.White;
        }

        private void lNameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            lNameTb.BackColor = Color.White;
        }

        private void balanceTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            balanceTb.BackColor = Color.White;
        }
    }
}
