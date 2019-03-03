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
    public partial class FormQ2 : Form
    {
        public FormQ2()
        {
            InitializeComponent();
        }
        public class PassA2
        {
            public static string a2 = string.Empty;
        }
        private void BTNext2_Click(object sender, EventArgs e)
        {
            if (RBPoor2.Checked == true)
            {
                PassA2.a2 = RBPoor2.Text;
            }
            else if (RBFair2.Checked == true)
            {
                PassA2.a2 = RBFair2.Text;
            }
            else if (RBGood2.Checked == true)
            {
                PassA2.a2 = RBGood2.Text;
            }
            else if (RBVGood2.Checked == true)
            {
                PassA2.a2 = RBVGood2.Text;
            }
            else if (RBExcellent2.Checked == true)
            {
                PassA2.a2 = RBExcellent2.Text;
            }
            else
            {
                PassA2.a2 = RBNoOpinion2.Text;
            }
            this.Close();
            FormQ3 formq3 = new FormQ3();
            formq3.Show();
        }
    }
}
