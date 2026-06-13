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
    class Invoice_DAL
    {
        ConnectiontoDB conn;
        SqlCommand cmd;

        #region get CustomerID from DB

        public int getCusID(Customer__getset obj)
        {
            int id = 0;

            string qry = "SELECT CustomerID from tbl__customers WHERE CustomerName=@cusname AND MobileNO=@contact AND Address=@address";
            conn = new ConnectiontoDB();
            cmd = new SqlCommand(qry, conn.GetConnection);
            cmd.Parameters.AddWithValue("@cusname",obj.CusName);
            cmd.Parameters.AddWithValue("@contact", obj.CusContact);
            cmd.Parameters.AddWithValue("@address", obj.CusAddress);
            conn.OpenConnection();
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                id = Convert.ToInt32(result);
            }
            return id;
        }

        #endregion

        #region insert into database

        public bool insert(Invoice__getset invoicegetset)
        {
            bool isSuccess = false;
            
            conn = new ConnectiontoDB();
            try
            {
            
                string sql = "INSERT INTO tbl__invoice2(invoiceno, invoicedate, CustomerID,totalamount,tax,discount,grandtotal) VALUES (@invno, @invdate, @cusID,@totalamount,@tax,@discount,@grandtotal);";

            
                 cmd = new SqlCommand(sql, conn.GetConnection);

            
                 cmd.Parameters.AddWithValue("@invno", invoicegetset.invoiceNO);
                 cmd.Parameters.AddWithValue("@invdate", invoicegetset.invoiceDate);
                 cmd.Parameters.AddWithValue("@cusID", invoicegetset.customerid);
                 cmd.Parameters.AddWithValue("@totalamount", invoicegetset.totalAmount);
                 cmd.Parameters.AddWithValue("@tax", invoicegetset.tax);
                 cmd.Parameters.AddWithValue("@discount", invoicegetset.discount);
                 cmd.Parameters.AddWithValue("@grandtotal", invoicegetset.grandTotal);

            
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
	
	  public bool update(Invoice__getset invoice)
        {
            bool success = false;
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-6LPJ4I20;Initial Catalog=prj_DB;Integrated Security=True"); // replace with your actual connection string
            try
            {
                string sql = "UPDATE tbl__invoice2 SET totalAmount=@total, tax=@tax, discount=@discount, grandTotal=@grand WHERE invoiceNO=@invoiceNo";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@total", invoice.totalAmount);
                cmd.Parameters.AddWithValue("@tax", invoice.tax);
                cmd.Parameters.AddWithValue("@discount", invoice.discount);
                cmd.Parameters.AddWithValue("@grand", invoice.grandTotal);
                cmd.Parameters.AddWithValue("@invoiceNo", invoice.invoiceNO);

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                success = rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invoice Update Failed: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return success;
        }


        #endregion

        #region generate invoice number
      public string GenerateNextInvoiceNumber()
      {
          string newInvNumber = "";
          int lastNumber = 0;

          try
          {
              conn = new ConnectiontoDB();
              string query = "SELECT TOP 1 invoiceno FROM tbl__invoice2 ORDER BY invoiceID DESC";

              cmd = new SqlCommand(query, conn.GetConnection);
              conn.OpenConnection();
              object result = cmd.ExecuteScalar();

              if (result != null && result.ToString().StartsWith("INVO-"))
              {
                  string lastInv = result.ToString(); 
                  string[] parts = lastInv.Split('-');

                  if (parts.Length == 2 && int.TryParse(parts[1], out lastNumber))
                  {
                      lastNumber++;
                  }
              }
              else
              {
                  lastNumber = 1; 
              }

              
              newInvNumber = "INVO-" + lastNumber.ToString("D4");
          }
          catch (Exception ex)
          {
              MessageBox.Show("Error generating invoice number: " + ex.Message);
              newInvNumber = "INVO-0001";
          }
          finally
          {
              conn.CloseConnection();
          }

          return newInvNumber;
      }

        #endregion

    }
}
