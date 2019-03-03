using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        public class PassVar
        {
            public static string ccode = string.Empty;
            public static string semester = string.Empty;
            public static string professor = string.Empty;
        }
        private void BTStartSurvey_Click(object sender, EventArgs e)
        {
            PassVar.ccode = TBCourseCode.Text.ToString();
            PassVar.semester = TBSemester.Text.ToString();
            PassVar.professor = TBProfessor.Text.ToString();
            FormQ1 formq1 = new FormQ1();
            formq1.Show();
        }

        private void BTExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
