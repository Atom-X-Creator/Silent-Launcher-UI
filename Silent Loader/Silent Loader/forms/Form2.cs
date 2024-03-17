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
    public partial class Form2 : Form
    {
        public Form2()
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
            Thread.Sleep(250);
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.siticoneProgressBar1.Increment(5);

            if(siticoneProgressBar1.Value >= siticoneProgressBar1.Maximum)
            {
                this.Close();
                Form3 form3 = new Form3();
                form3.Show();
            }
        }
    }
}
