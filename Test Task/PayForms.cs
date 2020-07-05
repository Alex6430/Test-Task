using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Task
{
    public partial class PayForms : Form
    {
        public PayForms()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm  = new MainForm();
            mainForm.Show();
        }

        private void PayForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
