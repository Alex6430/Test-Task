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
    public partial class ChoosePaysForm : Form
    {
        public ChoosePaysForm()
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
                SqlCommand command = new SqlCommand("SELECT * FROM Pays where PaysSumm > 0", db.GetConnection());
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
                //dataGridView1.Columns["PaysId"].Visible = false;
                dataGridView1.Columns["PaysId"].HeaderText = "Номер платежа";
                dataGridView1.Columns["PaysDate"].HeaderText = "дата платежа";
                dataGridView1.Columns["PaysSumm"].HeaderText = "сумма на счету";
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
                    MessageBox.Show("нет платежей с деньгами");
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
                MessageBox.Show("ошибка");
                return;
            }

            string cell_value = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["PaysId"].Value.ToString();

            string summ_value = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["PaysSumm"].Value.ToString();

            //button_enter.DialogResult = DialogResult.OK;
            this.Visible = false;
            
            MainForm mainForm = new MainForm(cell_value);
            mainForm.ShowDialog();

            this.Visible = true;
            DisplayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button_add_pay.DialogResult = DialogResult.No;
            MoneyForms moneyForms = new MoneyForms();
            moneyForms.ShowDialog();
            DisplayData();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();            
        }
    }
}
