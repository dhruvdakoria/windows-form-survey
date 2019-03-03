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
    public partial class FormQ1 : Form
    {
        public FormQ1()
        {
            InitializeComponent();

        }
        /*string rbChecked;
        private void grpBox_Validated(object sender, EventArgs e)
        {
            GroupBox g = sender as GroupBox;
            var a1 = from RadioButton r in g.Controls where r.Checked == true select r.Name;
            rbChecked = RBExcellent.Text;
        }*/
        public class PassA1
        {
            public static string a1 = string.Empty;
        }
        
        private void BTNext1_Click(object sender, EventArgs e)
        {
            if (RBPoor.Checked == true)
            {
                PassA1.a1 = RBPoor.Text;
            }
            else if (RBFair.Checked == true)
            {
                PassA1.a1 = RBFair.Text;
            }
            else if (RBGood.Checked == true)
            {
                PassA1.a1 = RBGood.Text;
            }
            else if (RBVGood.Checked == true)
            {
                PassA1.a1 = RBVGood.Text;
            }
            else if (RBExcellent.Checked == true)
            {
                PassA1.a1 = RBExcellent.Text;
            }
            else
            {
                PassA1.a1 = RBNoOpinion.Text;
            }
            this.Close();
            FormQ2 formq2 = new FormQ2();
            formq2.Show();
        }
    }
}
