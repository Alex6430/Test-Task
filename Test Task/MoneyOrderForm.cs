﻿using System;
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
    public partial class MoneyOrderForm : Form
    {
        private string Cell;
        private string Summ;
               
        public MoneyOrderForm()
        {
            InitializeComponent();
        }

        public MoneyOrderForm(string cell, string summ)
        {
            InitializeComponent();
            label1.Text = label1.Text + " ( " + summ + " )";
            Cell = cell;
            Summ = summ;
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            string moneys = MoneysFild.Text;
            string cell_value = Cell;
            string summ_value = Summ;
            //MessageBox.Show(cell_value + "," + summ_value);

            DB db = new DB();

            db.OpenConection();

            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Moneys (OrdersId, PaysId, MoneysSumm) VALUES (@OId,(SELECT top 1 PaysId FROM Pays order by PaysId desc),@Summ)", db.GetConnection());

                command.Parameters.Add("@Summ", SqlDbType.Money).Value = moneys;
                command.Parameters.Add("@OId", SqlDbType.Int).Value = Convert.ToInt32(cell_value);
                command.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                this.Close();
            }            

            try
            {
                SqlCommand command1 = new SqlCommand("UPDATE Orders SET OrdersSumm = OrdersSumm - @summ , OrdersSummPay = OrdersSummPay + @summ where OrdersId = @Id", db.GetConnection());

                command1.Parameters.Add("@Summ", SqlDbType.Money).Value = moneys;
                command1.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(cell_value);
                command1.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                this.Close();
            }
            
            db.CloseConection();

            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void MoneyOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
