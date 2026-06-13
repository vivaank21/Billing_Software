using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Billing_Software.Connection;
using Billing_Software.GETTERnSETTER;
using System.Data;

namespace Billing_Software.DAL
{
    class Customer_DAL
    {
        ConnectiontoDB conn;
        SqlCommand cmd;

        #region insert into database

        public bool insert(Customer__getset obj)
        {
            bool success = false;
            try
            {
                conn = new ConnectiontoDB();
                string query = "INSERT INTO tbl__customers (CustomerName,MobileNo,Address) " +
                                   "VALUES (@cusname,@cuscontact, @cusaddress)";

                  cmd = new SqlCommand(query, conn.GetConnection);
                    
                        cmd.Parameters.AddWithValue("@cusname", obj.CusName);
                        cmd.Parameters.AddWithValue("@cuscontact", obj.CusContact);
                        cmd.Parameters.AddWithValue("@cusaddress", obj.CusAddress);

                        conn.OpenConnection();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            success = true;
                        }
                        else
                        {
                            success = false;
                        }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting customer:\n" + ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.CloseConnection();
            }
            return success;
        }

        #endregion
    }
}
