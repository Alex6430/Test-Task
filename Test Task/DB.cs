using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Task
{
    class DB
    {
        static string connectionString = @"Data Source=DESKTOP-UP524EV;Initial Catalog=TestTaskNew;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
    
        public void OpenConection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();                
        }

        public void CloseConection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SqlTransaction GetTransaction()
        {
            return connection.BeginTransaction();
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
