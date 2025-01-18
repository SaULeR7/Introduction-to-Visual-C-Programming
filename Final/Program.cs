using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        internal class Grades
        {
            private double homework;
            private double programProjects;
            private double exams;
            private double classParticipation;
            private double finalExam;

            public Grades() { }

            public Grades(double _homework, double _programProjects, double _exams, double _classParticipation, double _finalExam) {
                this.homework = _homework;
                this.programProjects = _programProjects;
                this.exams = _exams;
                this.classParticipation= _classParticipation;
                this.finalExam = _finalExam;
            }

            public string CalculatedGrade()
            {
                double totalGrade = homework * 0.15 + programProjects * 0.2 + exams * 0.3 + classParticipation * 0.1 + finalExam * 0.25;
                return Convert.ToString(totalGrade);
            }
        }
    }
}
