using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Final.Program;

namespace Final
{
    public partial class Form1 : Form
    {
        Grades newGrade;
        const double min = 0.0, max = 100.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tbHomework.Text = "Homework";
            tbHomework.ForeColor = Color.Silver;
            tbProjects.Text = "Program Projects";
            tbProjects.ForeColor = Color.Silver;
            tbExams.Text = "Exams";
            tbExams.ForeColor = Color.Silver;
            tbParticipation.Text = "Class Participation";
            tbParticipation.ForeColor = Color.Silver;
            tbFinal.Text = "Final Exam";
            tbFinal.ForeColor = Color.Silver;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblGrade.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbHomework.Text, out double homework) && double.TryParse(tbProjects.Text, out double projects) &&
                double.TryParse(tbParticipation.Text, out double participation) && double.TryParse(tbExams.Text, out double exams) &&
                double.TryParse(tbFinal.Text, out double final)) {
                newGrade = new Grades(homework, projects, exams, participation, final);
                lblGrade.Text = "Weighted Total Grade: " + newGrade.CalculatedGrade() + "%";
            }
        }

        private void tbHomework_Enter(object sender, EventArgs e)
        {
            if (tbHomework.Text == "Homework")
            {
                tbHomework.Text = "";
                tbHomework.ForeColor = Color.Black;
            }
        }

        private void tbHomework_Leave(object sender, EventArgs e)
        {
            if (tbHomework.Text == "")
            {
                tbHomework.Text = "Homework";
                tbHomework.ForeColor = Color.Silver;
            }
            else {
                if (double.TryParse(tbHomework.Text, out double result))
                {
                    if ((result <= min) || (result >= max))
                        tbHomework.Focus();
                }
                else
                {
                    tbHomework.Focus();
                }
            }
        }

        private void tbProjects_Enter(object sender, EventArgs e)
        {
            if (tbProjects.Text == "Program Projects")
            {
                tbProjects.Text = "";
                tbProjects.ForeColor = Color.Black;
            }
        }

        private void tbProjects_Leave(object sender, EventArgs e)
        {
            if (tbProjects.Text == "")
            {
                tbProjects.Text = "Program Projects";
                tbProjects.ForeColor = Color.Silver;
            }
            else
            {
                if (double.TryParse(tbProjects.Text, out double result))
                {
                    if ((result <= min) || (result >= max))
                        tbProjects.Focus();
                }
                else
                {
                    tbProjects.Focus();
                }
            }
        }

        private void tbExams_Enter(object sender, EventArgs e)
        {
            if (tbExams.Text == "Exams")
            {
                tbExams.Text = "";
                tbExams.ForeColor = Color.Black;
            }
        }

        private void tbExams_Leave(object sender, EventArgs e)
        {
            if (tbExams.Text == "")
            {
                tbExams.Text = "Exams";
                tbExams.ForeColor = Color.Silver;
            }
            else
            {
                if (double.TryParse(tbExams.Text, out double result))
                {
                    if ((result <= min) || (result >= max))
                        tbExams.Focus();
                }
                else
                {
                    tbExams.Focus();
                }
            }
        }

        private void tbParticipation_Enter(object sender, EventArgs e)
        {
            if (tbParticipation.Text == "Class Participation")
            {
                tbParticipation.Text = "";
                tbParticipation.ForeColor = Color.Black;
            }
        }

        private void tbParticipation_Leave(object sender, EventArgs e)
        {
            if (tbParticipation.Text == "")
            {
                tbParticipation.Text = "Class Participation";
                tbParticipation.ForeColor = Color.Silver;
            }
            else
            {
                if (double.TryParse(tbParticipation.Text, out double result))
                {
                    if ((result <= min) || (result >= max))
                        tbParticipation.Focus();
                }
                else
                {
                    tbParticipation.Focus();
                }
            }
        }

        private void tbFinal_Enter(object sender, EventArgs e)
        {
            if (tbFinal.Text == "Final Exam")
            {
                tbFinal.Text = "";
                tbFinal.ForeColor = Color.Black;
            }
        }

        private void tbFinal_Leave(object sender, EventArgs e)
        {
            if (tbFinal.Text == "")
            {
                tbFinal.Text = "Final Exam";
                tbFinal.ForeColor = Color.Silver;
            }
            else
            {
                if (double.TryParse(tbFinal.Text, out double result))
                {
                    if ((result <= min) || (result >= max))
                        tbFinal.Focus();
                }
                else {
                    tbFinal.Focus();
                }
            }
        }
    }
}
