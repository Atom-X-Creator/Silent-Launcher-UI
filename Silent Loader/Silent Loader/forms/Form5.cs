using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Silent_Loader.forms
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
