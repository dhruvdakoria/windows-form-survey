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
    public partial class FormQ3 : Form
    {
        public FormQ3()
        {
            InitializeComponent();
        }
        public class PassA3
        {
            public static string a3 = string.Empty;
        }
        private void BTNext3_Click(object sender, EventArgs e)
        {
            if (RBNever.Checked == true)
            {
                PassA3.a3 = RBNever.Text;
            }
            else if (RBSomeTime.Checked == true)
            {
                PassA3.a3 = RBSomeTime.Text;
            }
            else if (RBMostTime.Checked == true)
            {
                PassA3.a3 = RBMostTime.Text;
            }
            else if (RBAlways.Checked == true)
            {
                PassA3.a3 = RBAlways.Text;
            }
            else
            {
                PassA3.a3 = RBNA.Text;
            }
            this.Close();
            FormLast formlast = new FormLast();
            formlast.Show();
        }
    }
}
