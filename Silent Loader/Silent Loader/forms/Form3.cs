using Silent_Loader.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Silent_Loader
{
    public partial class Form3 : Form
    {
        public Form3()
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

        private void siticoneRoundedComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
