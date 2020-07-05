using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Task
{
    public partial class MoneyForms : Form
    {
        public MoneyForms()
        {
            InitializeComponent();
        }

        public MoneyForms(string str)
        {
            InitializeComponent();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            int moneysValue;

            DB db = new DB();

            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Pays ( PaysDate, PaysSumm ) VALUES (@Date, @Summ)", db.GetConnection());
                if (Int32.TryParse(MoneysFild.Text, out moneysValue))
                {
                    command.Parameters.Add("@Summ", SqlDbType.Money).Value = Convert.ToInt32(MoneysFild.Text);
                }
                else
                {
                    MessageBox.Show("Некоректно введена сумма");
                    return;
                }
                DateTime date1 = DateTime.Today;
                command.Parameters.Add("@Date", SqlDbType.Date).Value = date1;

                db.OpenConection();

                if (command.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("вы успешно зарегестрированы");
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                    MessageBox.Show("вы не зарегестрированы");

                db.CloseConection();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                this.Close();
            }


        }
    }
}
