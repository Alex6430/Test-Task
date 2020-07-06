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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            DB db = new DB();

            db.OpenConection();
            try
            {
                SqlCommand command = new SqlCommand("SELECT top 1 PaysSumm FROM Pays order by PaysId desc", db.GetConnection());
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Ostatok.Text = dataReader[0].ToString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                this.Close();
            }
            db.CloseConection();

            DisplayData();
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
                SqlCommand command = new SqlCommand("SELECT * FROM Orders where OrdersSumm != 0", db.GetConnection());
                //command.Parameters.Add("@LoginUser", SqlDbType.NVarChar).Value = LoginUser;
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
                //dataGridView1.Columns["MoneysId1"].Visible = false;
                dataGridView1.ReadOnly = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                this.Close();
            }
        }
        
        private void button_enter_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("нет заказов для оплаты");
                    return;
                }
                else if (dataGridView1.CurrentRow.Index == dataGridView1.RowCount)
                {
                    MessageBox.Show("Строка не выделена");
                    return;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("нет заказов для оплаты");
                return;
            }

            string cell_value = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["OrdersId"].Value.ToString();           

            string summ_value = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["OrdersSumm"].Value.ToString();

            //if(summ_value == "0,0000")
            //{
            //    MessageBox.Show("Заказ оплачен выберите другой");
            //    return;
            //}

            //MessageBox.Show(cell_value +","+ summ_value);

            this.Hide();
            MoneyOrderForm moneyOrderForm = new MoneyOrderForm(cell_value , summ_value);            
            moneyOrderForm.Show();
                               

            //DisplayData();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PayForms payForm = new PayForms();
            payForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
