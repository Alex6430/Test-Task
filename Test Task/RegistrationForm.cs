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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            NameFild.Text = "Введите имя";
            LogFild.Text = "Введите почту";
            PhoneFild.Text = "Введите телефон";
            PassFild.Text = "Введите пароль";
            PassFild1.Text = "Повторите пароль";
            NameFild.ForeColor = Color.Gray;
            LogFild.ForeColor = Color.Gray;
            PhoneFild.ForeColor = Color.Gray;
            PassFild.ForeColor = Color.Gray;
            PassFild1.ForeColor = Color.Gray;
            PassFild.UseSystemPasswordChar = false;
            PassFild1.UseSystemPasswordChar = false;
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm();            
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            if (CheckUsers())
                return;

            DB db = new DB();

            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Users ( UsersName, UsersPhone, UsersLogin, UsersPass ) VALUES (@Name, @Phone, @Login, @Pass)", db.GetConnection());
                if (NameFild.Text != "Введите имя")
                {
                    command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = NameFild.Text;
                }
                else
                {
                    MessageBox.Show("Некоректно введено имя");
                    return;
                }
                if (PhoneFild.Text != "Введите телефон")
                {
                    command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = PhoneFild.Text;
                }
                else
                {
                    MessageBox.Show("Некоректно введен телефон");
                    return;
                }
                if (LogFild.Text != "")
                {
                    command.Parameters.Add("@Login", SqlDbType.NVarChar).Value = LogFild.Text;
                }
                else
                {
                    MessageBox.Show("Некоректно введена почта");
                    return;
                }
                if (PassFild.Text == PassFild1.Text)
                {
                    command.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = PassFild.Text;
                }
                else
                {
                    MessageBox.Show("Введены разные пароли");
                    return;
                }

                db.OpenConection();

                if (command.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("вы успешно зарегестрированы");
                    this.Hide();
                    MoneyForms moneyForms = new MoneyForms();
                    moneyForms.Show();                    
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

        public Boolean CheckUsers()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE UsersLogin= @LoginUser", db.GetConnection());
                command.Parameters.Add("@LoginUser", SqlDbType.NVarChar).Value = LogFild.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                this.Close();
            }

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("такой логин существует введите другой");
                return true;
            }
            else
            {
                return false;
            }
        }

        Point LastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.LastPoint = new Point(e.X, e.Y);
        }

        private void NameFild_Enter(object sender, EventArgs e)
        {
            if(NameFild.Text == "Введите имя")
            {
                NameFild.Text = "";
                NameFild.ForeColor = Color.Black;
            }    
        }

        private void NameFild_Leave(object sender, EventArgs e)
        {
            if (NameFild.Text == "")
            {
                NameFild.Text = "Введите имя";
                NameFild.ForeColor = Color.Gray;
            }
        }

        private void LogFild_Enter(object sender, EventArgs e)
        {
            if (LogFild.Text == "Введите почту")
            {
                LogFild.Text = "";
                LogFild.ForeColor = Color.Black;
            }
        }

        private void LogFild_Leave(object sender, EventArgs e)
        {
            if (LogFild.Text == "")
            {
                LogFild.Text = "Введите почту";
                LogFild.ForeColor = Color.Gray;
            }
        }

        private void PassFild_Enter(object sender, EventArgs e)
        {
            if (PassFild.Text == "Введите пароль")
            {
                PassFild.Text = "";
                PassFild.ForeColor = Color.Black;
                PassFild.UseSystemPasswordChar = true;
            }
        }

        private void PassFild_Leave(object sender, EventArgs e)
        {
            if (PassFild.Text == "")
            {
                PassFild.Text = "Введите пароль";
                PassFild.ForeColor = Color.Gray;
                PassFild.UseSystemPasswordChar = false;
            }
        }

        private void PassFild1_Enter(object sender, EventArgs e)
        {
            if (PassFild1.Text == "Повторите пароль")
            {
                PassFild1.Text = "";
                PassFild1.ForeColor = Color.Black;
                PassFild1.UseSystemPasswordChar = true;
            }
        }

        private void PassFild1_Leave(object sender, EventArgs e)
        {
            if (PassFild1.Text == "")
            {
                PassFild1.Text = "Повторите пароль";
                PassFild1.ForeColor = Color.Gray;
                PassFild1.UseSystemPasswordChar = false;
            }
        }

        private void PhoneFild_Enter(object sender, EventArgs e)
        {
            if (PhoneFild.Text == "Введите телефон")
            {
                PhoneFild.Text = "";
                PhoneFild.ForeColor = Color.Black;
                PhoneFild.UseSystemPasswordChar = true;
            }
        }

        private void PhoneFild_Leave(object sender, EventArgs e)
        {
            if (PhoneFild.Text == "")
            {
                PhoneFild.Text = "Введите телефон";
                PhoneFild.ForeColor = Color.Gray;
                PhoneFild.UseSystemPasswordChar = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
