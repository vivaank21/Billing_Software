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
    class Records_DAL
    {
        #region get sales information
        public DataTable selectAll()
        {
            ConnectiontoDB conn = new ConnectiontoDB();
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT invoiceno, invoicedate, CustomerName, CustomerContact, CustomerAddress, CategoryList, PurchasedProducts, totalamount, discount, tax, grandtotal FROM v_InvoiceFullDetails ORDER BY invoicedate DESC, invoiceno";
                SqlCommand cmd = new SqlCommand(sql, conn.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.OpenConnection();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return dt;
        }

        public DataTable selectViaValue(string field, string searchVal, DateTime fromDate, DateTime toDate)
        {
            string condition = "";
            SqlParameter parameter = null;

            bool hasFromDate = fromDate != DateTime.MinValue;
            bool hasToDate = toDate != DateTime.MinValue;

            
            if (!string.IsNullOrEmpty(field) && !string.IsNullOrEmpty(searchVal))
            {
                if (field == "Customer Name")
                {
                    condition = "WHERE CustomerName = @searchVal";
                    parameter = new SqlParameter("@searchVal", SqlDbType.NVarChar) { Value = searchVal };
                }
                else if (field == "Customer Contact")
                {
                    condition = "WHERE CustomerContact = @searchVal";
                    parameter = new SqlParameter("@searchVal", SqlDbType.NVarChar) { Value = searchVal };
                }
                else if (field == "Invoice Number")
                {
                    condition = "WHERE invoiceno = @searchVal";
                    parameter = new SqlParameter("@searchVal", SqlDbType.NVarChar) { Value = searchVal };
                }
                else if (field == "Invoice Date")
                {
                    DateTime parsedDate;
                    if (!DateTime.TryParse(searchVal, out parsedDate))
                    {
                        MessageBox.Show("Invalid date format for Invoice Date.");
                        return new DataTable();
                    }
                    condition = "WHERE CONVERT(date, invoicedate) = @searchVal";
                    parameter = new SqlParameter("@searchVal", SqlDbType.Date) { Value = parsedDate.Date };
                }
            }

           
            if (hasFromDate && hasToDate)
            {
                if (string.IsNullOrEmpty(condition))
                    condition = "WHERE invoicedate BETWEEN @fromDate AND @toDate";
                else
                    condition += " AND invoicedate BETWEEN @fromDate AND @toDate";
            }
            else if (hasFromDate) 
            {
                if (string.IsNullOrEmpty(condition))
                    condition = "WHERE invoicedate >= @fromDate";
                else
                    condition += " AND invoicedate >= @fromDate";
            }
            else if (hasToDate) 
            {
                if (string.IsNullOrEmpty(condition))
                    condition = "WHERE invoicedate <= @toDate";
                else
                    condition += " AND invoicedate <= @toDate";
            }

            ConnectiontoDB conn = new ConnectiontoDB();
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT invoiceno, invoicedate, CustomerName, CustomerContact, CustomerAddress, " +
                             "CategoryList, PurchasedProducts, totalamount, discount, tax, grandtotal " +
                             "FROM v_InvoiceFullDetails " + condition +
                             " ORDER BY invoicedate DESC, invoiceno";

                SqlCommand cmd = new SqlCommand(sql, conn.GetConnection);

                if (parameter != null)
                    cmd.Parameters.Add(parameter);

                if (hasFromDate)
                    cmd.Parameters.Add(new SqlParameter("@fromDate", SqlDbType.Date) { Value = fromDate });

                if (hasToDate)
                    cmd.Parameters.Add(new SqlParameter("@toDate", SqlDbType.Date) { Value = toDate });

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.OpenConnection();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }

            return dt;
        }

        #endregion
    }
}
