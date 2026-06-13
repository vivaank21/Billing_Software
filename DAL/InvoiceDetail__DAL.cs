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
    class InvoiceDetail__DAL
    {
        ConnectiontoDB conn;
        SqlCommand cmd;

        

        #region get invoiceID from DB

        public int getInvoiceID(Invoice__getset obj)
        {
            int id = 0;
            string qry = "SELECT invoiceID FROM tbl__invoice2 WHERE invoiceno = @invno AND invoicedate= @date AND CustomerID = @cusid AND totalamount=@total AND tax=@tax AND discount=@discount AND grandtotal=@gtotal";
            conn = new ConnectiontoDB();
            cmd = new SqlCommand(qry, conn.GetConnection);
            cmd.Parameters.AddWithValue("@invno", obj.invoiceNO);
            cmd.Parameters.AddWithValue("@date", obj.invoiceDate);
            cmd.Parameters.AddWithValue("@cusid", obj.customerid);
            cmd.Parameters.AddWithValue("@total", obj.totalAmount);
            cmd.Parameters.AddWithValue("@tax", obj.tax);
            cmd.Parameters.AddWithValue("@discount", obj.discount);
            cmd.Parameters.AddWithValue("@gtotal", obj.grandTotal);
            conn.OpenConnection();
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                id = Convert.ToInt32(result);
                obj.invoiceID = id;
            }

            return id;

        }

        public int getInvoiceID_ByInvoiceNO(string invoiceNO)
        {
            int id = 0;
            conn = new ConnectiontoDB();
            try
            {
                string sql = "SELECT invoiceID FROM tbl__invoice2 WHERE invoiceNO = @invoiceNO";
                cmd = new SqlCommand(sql, conn.GetConnection);
                cmd.Parameters.AddWithValue("@invoiceNO", invoiceNO);
                conn.OpenConnection();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    id = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return id;
        }

        #endregion

        #region insert into database

        public bool insert(InvoiceDetail__getset invoicedetailgetset)
        {
            bool isSuccess = false;
            conn = new ConnectiontoDB();
            try
            {
                string sql = "INSERT INTO tbl__invoiceDetail2(invoiceID, productID, quantity, rate) VALUES (@invid, @proid, @qty, @rate);";
                cmd = new SqlCommand(sql, conn.GetConnection);
                cmd.Parameters.AddWithValue("@invid", invoicedetailgetset.invoiceID);
                cmd.Parameters.AddWithValue("@proid", invoicedetailgetset.proID);
                cmd.Parameters.AddWithValue("@qty", invoicedetailgetset.qunatity);
                cmd.Parameters.AddWithValue("@rate", invoicedetailgetset.rate);
                conn.OpenConnection();
                cmd.ExecuteNonQuery();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
                return isSuccess;
        }
        #endregion

        #region update stock after invoice
        public bool updatestock(int productId, decimal qty)
        {
            bool success = false;
            try
            {
                conn = new ConnectiontoDB();
                String qry = "UPDATE tbl__products SET Stock = Stock - @Stock WHERE productID = @ProductID AND Stock >= @Stock";
                cmd = new SqlCommand(qry, conn.GetConnection);
                cmd.Parameters.AddWithValue("@Stock", qty);
                cmd.Parameters.AddWithValue("@ProductID", productId);

                conn.OpenConnection();
                int rows = cmd.ExecuteNonQuery();
                if (rows != 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("SOMETHING WENT WRONG", "DATABASE ERROR");
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
