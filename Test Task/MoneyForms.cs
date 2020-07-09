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
                    //SqlCommand command1 = new SqlCommand("SELECT top 1 PaysId FROM Pays order by PaysId desc", db.GetConnection());
                    //SqlDataReader dataReader = command1.ExecuteReader();
                    //while (dataReader.Read())
                    //{
                    //    this.Hide();
                    //    MainForm mainForm = new MainForm(dataReader[0].ToString());
                    //    mainForm.Show();
                    //}
                    //this.Hide();
                    //MainForm mainForm = new MainForm();
                    //mainForm.Show();
                    this.Close();

                }
                else
                    MessageBox.Show("вы не зарегестрированы");

                db.CloseConection();
            }
            catch(DBConcurrencyException exp)
            {
                MessageBox.Show(exp.ToString());
                this.Close();
            }              


        }

        private void MoneyForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
