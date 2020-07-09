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
    public partial class MoneyOrderForm : Form
    {
        private string Cell;
        private string Summ;
        private string PaysId;

        public MoneyOrderForm()
        {
            InitializeComponent();
        }

        public MoneyOrderForm(string cell, string summ, string paysId)
        {
            InitializeComponent();
            label1.Text = label1.Text + " ( " + summ + " )";
            Cell = cell;
            Summ = summ;
            PaysId = paysId;
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            string moneys = MoneysFild.Text;
            string cell_value = Cell;
            string summ_value = Summ;
            string paysId_value = PaysId;
            //MessageBox.Show(cell_value + "," + summ_value);
            //MessageBox.Show(paysId_value);

            DB db = new DB();

            db.OpenConection();
            try
            {
                SqlCommand command = new SqlCommand("SELECT top 1 PaysSumm FROM Pays where PaysId = @Id", db.GetConnection());
                command.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(PaysId);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if(Convert.ToDecimal(moneys) > Convert.ToDecimal(dataReader[0].ToString()))
                    {
                        MessageBox.Show("недостаточно денег");                        
                        return;
                    }
                    else if (Convert.ToDecimal(moneys) > Convert.ToDecimal(summ_value))
                    {
                        MessageBox.Show("заказ стоит меньше введите коректную сумму");                        
                        return;
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                this.Close();
            }
            db.CloseConection();

            db.OpenConection();            
            try
            {                
                SqlCommand command = new SqlCommand(
                    "BEGIN" +
                    " IF NOT EXISTS(SELECT * FROM Moneys WHERE OrdersId = @OId AND MoneysSumm > 0)" +
                    " BEGIN" +
                    " INSERT INTO Moneys(OrdersId, PaysId, MoneysSumm) VALUES(@OId, @PId, @Summ)" +
                    " END" +
                    " END", db.GetConnection());
                command.Parameters.Add("@Summ", SqlDbType.Money).Value = moneys;
                command.Parameters.Add("@OId", SqlDbType.Int).Value = Convert.ToInt32(cell_value);
                command.Parameters.Add("@PId", SqlDbType.Int).Value = Convert.ToInt32(PaysId);
                if (command.ExecuteNonQuery() != 3)
                {
                    MessageBox.Show("этот заказ оплачивается подождите");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());               
                this.Close();
            }  
                    
            
            db.CloseConection();

            //this.Hide();
            //MainForm mainForm = new MainForm(PaysId);
            //mainForm.ShowDialog();
            
            this.Close();
        }

        private void MoneyOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
