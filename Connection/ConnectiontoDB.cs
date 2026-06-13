using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Billing_Software.Connection
{
    class ConnectiontoDB
    {
        public static String Connection_str = "Data Source=DESKTOP-0QM8QJ8\\SQLEXPRESS;Initial Catalog=prj_DB;Integrated Security=True;TrustServerCertificate=True";

        private SqlConnection Conn = new SqlConnection(Connection_str);

        public SqlConnection GetConnection
        {
            get
            {
                return Conn;
            }
        }

        public void OpenConnection()
        {
            Conn.Open();
        }

        public void CloseConnection()
        {
            Conn.Close();
        }
    }
}
