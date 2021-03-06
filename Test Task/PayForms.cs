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
    public partial class PayForms : Form
    {

        private string PaysId;

        public PayForms(string paysId)
        {
            InitializeComponent();         
            PaysId = paysId;
            DisplayData();
        }

        public PayForms()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            DB db = new DB();

            DataSet dataSet = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Moneys where PaysId = @PId and MoneysSumm > 0", db.GetConnection());
                command.Parameters.Add("@PId", SqlDbType.Int).Value = Convert.ToInt32(PaysId);
                //command.Parameters.Add("@PassUser", SqlDbType.NVarChar).Value = PassUser;
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                // делаем недоступным столбец id для изменения
                //dataGridView1.Columns["OrdersId"].ReadOnly = true;
                //dataGridView1.Columns["PaysId"].ReadOnly = true;
                //dataGridView1.Columns["MoneysId"].ReadOnly = true;
                //dataGridView1.Columns["OrdersDate"].ReadOnly = true;
                //dataGridView1.Columns["PaysId"].Visible = false;
                //dataGridView1.Columns["MoneysId"].Visible = false;
                dataGridView1.Columns["MoneysId"].Visible = false;
                dataGridView1.Columns["OrdersId"].HeaderText = "Номер заказа";
                dataGridView1.Columns["PaysId"].HeaderText = "Номер платежа";
                dataGridView1.Columns["MoneysSumm"].HeaderText = "сумма оплаты";
                dataGridView1.ReadOnly = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //MainForm mainForm  = new MainForm();
            //mainForm.Show();
            this.Close();
        }

        private void PayForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //MoneyForms moneyForms = new MoneyForms();
            //moneyForms.Show();
            DB db = new DB();
            db.OpenConection();
            try
            {
                SqlCommand command = new SqlCommand("UPDATE Moneys SET MoneysSumm = 0 where PaysId = @PId", db.GetConnection());
                command.Parameters.Add("@PId", SqlDbType.Int).Value = Convert.ToInt32(PaysId);
                command.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                this.Close();
            }
            db.CloseConection();
            //DisplayData();
            button_enter.DialogResult = DialogResult.OK;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
