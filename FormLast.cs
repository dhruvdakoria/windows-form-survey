using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab5work
{
    public partial class FormLast : Form
    {
        public FormLast()
        {
            InitializeComponent();
        }
        public string a1, a2, a3;
        
        private void FormLast_Load(object sender, EventArgs e)
        {
            
            LBCCodeL.Text = Form1.PassVar.ccode;
            LBSemL.Text = Form1.PassVar.semester;
            LBProfL.Text = Form1.PassVar.professor;
            LBA1L.Text = FormQ1.PassA1.a1;
            LBA2L.Text = FormQ2.PassA2.a2;
            LBA3L.Text = FormQ3.PassA3.a3;
        }

        private void BTCancel_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void BTSave_Click(object sender, EventArgs e)
        {
            StreamWriter Survey = File.AppendText(@"d:\prg455\studentsurvey.txt");
            Survey.WriteLine("Course Code: " + LBCCodeL.Text);
            Survey.WriteLine("Semester: " + LBSemL.Text);
            Survey.WriteLine("Professor: " + LBProfL.Text);
            Survey.WriteLine("Overall, I would rate the quality of this course as: " + LBA1L.Text);
            Survey.WriteLine("Overall, I would rate this professor’s performance as: " + LBA2L.Text);
            Survey.WriteLine("Professor demonstrates a thorough knowledge of the subject: " + LBA3L.Text);
            Survey.WriteLine("");
            Survey.Close();
            this.Close();
            Environment.Exit(0);
        }
    }
}
