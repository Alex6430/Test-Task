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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //this.PassFild.AutoSize = false;
            //this.PassFild.Size = new Size(this.LogFild.Size.Width, 64);
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            string LoginUser = LogFild.Text;
            string PassUser = PassFild.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE UsersLogin= @LoginUser AND UsersPass= @PassUser", db.GetConnection());
                command.Parameters.Add("@LoginUser", SqlDbType.NVarChar).Value = LoginUser;
                command.Parameters.Add("@PassUser", SqlDbType.NVarChar).Value = PassUser;
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
                this.Visible = false;
                ChoosePaysForm choosePaysForm = new ChoosePaysForm();
                if(choosePaysForm.ShowDialog() == DialogResult.Cancel)
                {
                    this.Close();
                }                
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует\n" +
                    "введите данные еще раз");
            }
        
        }

        Point LastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.LastPoint = new Point(e.X, e.Y);
        }

        private void RegLabel_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Visible = false;
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
            this.Visible = true;
            //if(registrationForm.ShowDialog() == DialogResult.Cancel)
            //{
            //    this.Close();
            //}
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
