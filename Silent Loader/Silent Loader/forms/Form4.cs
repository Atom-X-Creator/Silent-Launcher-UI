using Silent_Loader.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Silent_Loader
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void siticoneButton3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
