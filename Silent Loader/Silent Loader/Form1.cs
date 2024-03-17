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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            string gettext = siticoneTextBox1.Text;
            int gettext_amount = gettext.Length;
            string pw = "Kazukii!";

            if (pw != gettext)
            {
                MessageBox.Show($"{gettext} is an incorrect password.", "Silent");
                return;
            };

            if (gettext_amount > 0)
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
        }
    }
}
