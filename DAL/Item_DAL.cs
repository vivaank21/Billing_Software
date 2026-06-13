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
    class Item_DAL
    {
      
        #region get data from database

        public DataTable select()
        {
            ConnectiontoDB conn = new ConnectiontoDB();
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT CategoryName,CategoryDescription FROM tbl__Category WHERE IsActive=1";
           
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
        #endregion

        #region check if exists
        public bool chechifexist(Item__getset itemgetset)
        {
            bool success = false;
            ConnectiontoDB conn = new ConnectiontoDB();
            try
            {
                string check_qry = "SELECT COUNT(*) FROM tbl__category WHERE CAST(CategoryName AS VARCHAR(MAX)) = @item__name AND CAST(CategoryDescription AS VARCHAR(MAX)) = @item__description;";
                SqlCommand cmd = new SqlCommand(check_qry, conn.GetConnection);

                cmd.Parameters.AddWithValue("@item__name", itemgetset.item__name);
                cmd.Parameters.AddWithValue("@item__description", itemgetset.item__description);

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
        #endregion

        #region insert data into database

        public bool insert(Item__getset itemgetset)
        {
            bool success = false;
            ConnectiontoDB conn = new ConnectiontoDB();
            try
            {
                string insert_qry = "INSERT INTO tbl__category (CategoryName, CategoryDescription)VALUES (@item__name, @item__description);";
                SqlCommand cmd = new SqlCommand(insert_qry, conn.GetConnection);

                cmd.Parameters.AddWithValue("@item__name", itemgetset.item__name);
                cmd.Parameters.AddWithValue("@item__description", itemgetset.item__description);

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
            catch (Exception e)
            {
                MessageBox.Show("AN ERROR OCCURRED: " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.CloseConnection();
            }

            return success ; 
        }
        #endregion

        #region Delete Data from DAtabase
        public bool Delete(Item__getset itemgetset)
        {
            bool isSuccess = false;
            ConnectiontoDB conn = new ConnectiontoDB();
            try
            {
                string sql = "UPDATE tbl__category SET IsActive = 0 WHERE CategoryName=@name";

                SqlCommand cmd = new SqlCommand(sql, conn.GetConnection);

                cmd.Parameters.AddWithValue("@name", itemgetset.item__name);
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
        #endregion

        #region Fill ComboBox

        public void FillCategoriesIntoComboBox(ComboBox comboBox__SelectCategory)
        {
                     comboBox__SelectCategory.Items.Clear();

            using (SqlConnection conn = new SqlConnection(ConnectiontoDB.Connection_str))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CategoryName FROM tbl__category WHERE IsActive=1";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string categoryname = reader["CategoryName"].ToString();
                            comboBox__SelectCategory.Items.Add(categoryname);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR LOADING CATEGORIES" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

    }
}
