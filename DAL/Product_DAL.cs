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
    class Product_DAL
    {
        public static int categoryid;
        public static int proid;
        ConnectiontoDB conn;
        SqlCommand cmd;

        #region getting id from name
        public bool getcategoryid(Product__getset obj)
        {
            bool success = false;
            string sql = "select CategoryID from tbl__category Where CategoryName=@catname AND IsActive=1";
            conn = new ConnectiontoDB();
            cmd = new SqlCommand(sql, conn.GetConnection);
            cmd.Parameters.AddWithValue("@catname", obj.selected_category);
            conn.OpenConnection();
            categoryid = Convert.ToInt32(cmd.ExecuteScalar());
            obj.category__id = categoryid;
            success = true;
            conn.CloseConnection();
            return success;
        }

        public int getcategoryidINT(Product__getset obj)
        {
            
            string sql = "select CategoryID from tbl__category Where CategoryName=@catname AND IsActive=1";
            conn = new ConnectiontoDB();
            cmd = new SqlCommand(sql, conn.GetConnection);
            cmd.Parameters.AddWithValue("@catname", obj.selected_category);
            conn.OpenConnection();
            categoryid = Convert.ToInt32(cmd.ExecuteScalar());
            obj.category__id = categoryid;
            
            conn.CloseConnection();
            return obj.category__id;
        }
        #endregion

       
        #region getting proid from proname
        public bool getproid(Product__getset productgetset)
        {
            bool success = false;
            string qry = "SELECT productID FROM tbl__products WHERE productname = @name AND Size = @size AND Rate = @rate";
            conn = new ConnectiontoDB();
            cmd = new SqlCommand(qry, conn.GetConnection);
            cmd.Parameters.AddWithValue("@name", productgetset.original_product__name);
            cmd.Parameters.AddWithValue("@size", productgetset.original_product__size);
            cmd.Parameters.AddWithValue("@rate", productgetset.original_product__rate);
            conn.OpenConnection();
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                productgetset.pro__id = Convert.ToInt32(result);
                success = true;
            }
            conn.CloseConnection();
            return success;
        }

        public int getproIDINT(Product__getset productgetset)
        {
            int id = 0;
            string qry = "SELECT productID FROM tbl__products WHERE productname = @name AND Size = @size AND Rate = @rate";
            conn = new ConnectiontoDB();
            cmd = new SqlCommand(qry, conn.GetConnection);
            cmd.Parameters.AddWithValue("@name", productgetset.product__name);
            cmd.Parameters.AddWithValue("@size", productgetset.product__size);
            cmd.Parameters.AddWithValue("@rate", productgetset.product__rate);
            conn.OpenConnection();
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                productgetset.pro__id = Convert.ToInt32(result);
                id = productgetset.pro__id;
            }
            return id;
            conn.CloseConnection();
        }

        #endregion

        #region get data from database
        public DataTable select()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT c.CategoryName,p.productname,p.Description,p.Size,p.Rate,p.Stock FROM tbl__category c JOIN tbl__products p ON c.CategoryID = p.CategoryID WHERE c.IsActive = 1 AND p.IsActive = 1;";
            ConnectiontoDB conn = new ConnectiontoDB();
            try
            {

                using (SqlCommand cmd = new SqlCommand(sql, conn.GetConnection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    conn.OpenConnection();
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
             
                MessageBox.Show("Error while fetching data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.CloseConnection();
            }
            return dt;
        }
        #endregion

        public bool chechifexist(Product__getset productgetset)
        {
            bool success = false;
            ConnectiontoDB conn = new ConnectiontoDB();
            try
            {
                string check_qry = "SELECT * FROM tbl__products WHERE CategoryID=@catid AND productname=@productname AND Description=@productdescription AND Size=@productsize AND Rate=@productrate;";
                SqlCommand cmd = new SqlCommand(check_qry, conn.GetConnection);

                cmd.Parameters.AddWithValue("@catid", productgetset.category__id);
                cmd.Parameters.AddWithValue("@productname", productgetset.product__name);
                cmd.Parameters.AddWithValue("@productdescription", productgetset.product__description);
                cmd.Parameters.AddWithValue("@productsize", productgetset.product__size);
                cmd.Parameters.AddWithValue("@productrate", productgetset.product__rate);

                conn.OpenConnection();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
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
                MessageBox.Show("AN ERROR OCCURRED: " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.CloseConnection();
            }

            return success;
        }

        #region insert data to database
        public bool insert(Product__getset productgetset)
        {
            bool success = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectiontoDB.Connection_str))
                {
                    string query = "INSERT INTO tbl__products (CategoryID,productname,Description,Size,Rate,Stock) " +
                                   "VALUES (@catid,@productname, @productdescription, @productsize, @productrate, @productstock)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@catid", productgetset.category__id);
                        cmd.Parameters.AddWithValue("@productname", productgetset.product__name);
                        cmd.Parameters.AddWithValue("@productdescription", productgetset.product__description);
                        cmd.Parameters.AddWithValue("@productsize", productgetset.product__size);
                        cmd.Parameters.AddWithValue("@productrate", productgetset.product__rate);
                        cmd.Parameters.AddWithValue("@productstock", productgetset.product__stock);

                        conn.Open();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting product:\n" + ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.CloseConnection();
            }
            return success;
        }
        #endregion

        #region delete from database
        public bool Delete(Product__getset productgetset)
        {
            bool isSuccess = false;
            ConnectiontoDB conn = new ConnectiontoDB();
            try
            {
                string sql = "UPDATE tbl__products SET IsActive=0 WHERE productname=@name AND Size=@size AND Rate=@rate;";

                SqlCommand cmd = new SqlCommand(sql, conn.GetConnection);

                cmd.Parameters.AddWithValue("@name", productgetset.product__name);
                cmd.Parameters.AddWithValue("@size", productgetset.product__size);
                cmd.Parameters.AddWithValue("@rate", productgetset.product__rate);
                conn.OpenConnection();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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
            return isSuccess;
        }

        public void DeleteInactiveCategoryProducts()
        {
            ConnectiontoDB conn = new ConnectiontoDB();
            string sql = @"DELETE p FROM tbl__products p INNER JOIN tbl__category c ON p.CategoryID = c.CategoryID WHERE c.IsActive = 0";

            using (SqlCommand cmd = new SqlCommand(sql, conn.GetConnection))
            {
              try
              {
                 conn.OpenConnection();
                 cmd.ExecuteNonQuery();
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Error deleting products with inactive categories:\n" + ex.Message);
              }
            }
        }

        #endregion

        #region update in databse
        public bool update(Product__getset obj)
        {
            bool success = false;

            ConnectiontoDB conn = new ConnectiontoDB();

            int proid = obj.pro__id;
            int categoryid = obj.category__id;
            string proname = obj.product__name;
            string des = obj.product__description;
            string size = obj.product__size;
            decimal rate = obj.product__rate;
            decimal stock = obj.product__stock;

            try
            {
                String qry = "UPDATE tbl__products SET CategoryID = @CategoryID, productname = @ProductName, Description = @Description, Size = @Size, Rate = @Rate, Stock = @Stock WHERE productID = @ProductID";
                SqlCommand cmd = new SqlCommand(qry, conn.GetConnection);
                
                cmd.Parameters.AddWithValue("@CategoryID", categoryid);
                cmd.Parameters.AddWithValue("@ProductID", proid);
                cmd.Parameters.AddWithValue("@ProductName", proname);
                cmd.Parameters.AddWithValue("@Description", des);
                cmd.Parameters.AddWithValue("@Size", size);
                cmd.Parameters.AddWithValue("@Rate", rate);
                cmd.Parameters.AddWithValue("@Stock", stock);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return success;

        }
        #endregion

        #region Fill ComboBox AND Txtboxes

        public void FillProductsIntoComboBox(ComboBox comboBox__Selectproducts,int CategoryID)
        {
            
            comboBox__Selectproducts.Items.Clear();

            using (SqlConnection conn = new SqlConnection(ConnectiontoDB.Connection_str))
            { 
                try
                {
                    conn.Open();
                    string query = "SELECT DISTINCT  productname FROM tbl__products WHERE CategoryID=@catid AND IsActive=1";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@catid", CategoryID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                        while (reader.Read())
                        {
                            string categoryname = reader["productname"].ToString();
                            comboBox__Selectproducts.Items.Add(categoryname);
                        }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR LOADING CATEGORIES" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void FillSizeComboBox(ComboBox comboBox__Selectproducts,Product__getset obj)
        {
            
            comboBox__Selectproducts.Items.Clear();

            ConnectiontoDB conn = new ConnectiontoDB();
            
                try
                {
                    conn.OpenConnection();
                    string query = "SELECT Size FROM tbl__products WHERE productname=@proname AND IsActive=1";

                    SqlCommand cmd = new SqlCommand(query, conn.GetConnection);
                    cmd.Parameters.AddWithValue("@proname", obj.product__name);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string categoryname = reader["Size"].ToString();
                        comboBox__Selectproducts.Items.Add(categoryname);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR LOADING CATEGORIES" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        public void FillRateTextbox(TextBox tb, Product__getset obj)
        {
          
            ConnectiontoDB conn = new ConnectiontoDB();
            try
            {
                conn.OpenConnection();
                string query = "SELECT Rate from tbl__products WHERE productname=@proname AND Size=@size AND IsActive=1";

                SqlCommand cmd = new SqlCommand(query, conn.GetConnection);
                cmd.Parameters.AddWithValue("@proname", obj.product__name);
                cmd.Parameters.AddWithValue("@size", obj.product__size);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string rate = reader["Rate"].ToString();
                    tb.Text = rate;
                }
               
            }
            catch (Exception ee)
            {
                MessageBox.Show("ERROR LOADING PRODUCT RATES" + ee.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FillStockTextBox(TextBox tb, Product__getset obj, Decimal rate)
        {
            conn = new ConnectiontoDB();
            try
            {
                conn.OpenConnection();
                string query = "SELECT Stock from tbl__products WHERE productname=@proname AND Size=@size AND Rate=@rate AND IsActive=1";

                SqlCommand cmd = new SqlCommand(query, conn.GetConnection);
                cmd.Parameters.AddWithValue("@proname", obj.product__name);
                cmd.Parameters.AddWithValue("@size", obj.product__size);
                cmd.Parameters.AddWithValue("@rate", rate);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string Stock = reader["Stock"].ToString();
                    tb.Text = Stock;
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show("ERROR LOADING PRODUCT STOCKS" + ee.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FillDescriptionTextBox(TextBox tb, Product__getset obj, decimal stocks)
        {
            conn = new ConnectiontoDB();
            try
            {
                conn.OpenConnection();
                string query = "SELECT Description from tbl__products WHERE productname=@proname AND Size=@size AND Stock=@stock AND IsActive=1";

                SqlCommand cmd = new SqlCommand(query, conn.GetConnection);
                cmd.Parameters.AddWithValue("@proname", obj.product__name);
                cmd.Parameters.AddWithValue("@size", obj.product__size);
                cmd.Parameters.AddWithValue("@stock", stocks);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string Description = reader["Description"].ToString();
                    tb.Text = Description;
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show("ERROR LOADING PRODUCT DESCRIPTION " + ee.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
        #endregion

       
    }
}
