using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billing_Software.DAL;
using Billing_Software.GETTERnSETTER;

namespace Billing_Software.GUI
{
    public partial class page__INVENTORY : Form
    {
        Item__getset itemgetset = new Item__getset();
        Item_DAL itemdal = new Item_DAL();

        Product__getset productgetset = new Product__getset();
        Product_DAL productdal = new Product_DAL();

        public page__INVENTORY()
        {
            InitializeComponent();
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ClearInnputs()
        {
            textBox__categoryname.Clear();
            textBox__categoryDescription.Clear();
            comboBox__SelectCategory.SelectedItem = null;
            textBox__ProductName.Clear();
            textBox__ProductSize.Clear();
            textBox__ProductRate.Clear();
            textBox__ProductStock.Clear();
            textBox_ProductDescription.Clear();
        }

        public void EnableCategoryInputs()
        {
            textBox__categoryname.Enabled = true;
            textBox__categoryDescription.Enabled = true;
        }

        public void DisableCategoryInputs()
        {
            textBox__categoryname.Enabled = false;
            textBox__categoryDescription.Enabled = false;
        }

        public void EnableProductInputs()
        {
            comboBox__SelectCategory.Enabled = true;
            textBox__ProductName.Enabled = true;
            textBox__ProductSize.Enabled = true;
            textBox__ProductRate.Enabled = true;
            textBox__ProductStock.Enabled = true;
            textBox_ProductDescription.Enabled = true;
        }

        public void DisableProductInputs()
        {
            comboBox__SelectCategory.Enabled = false;
            textBox__ProductName.Enabled = false;
            textBox__ProductSize.Enabled = false;
            textBox__ProductRate.Enabled = false;
            textBox__ProductStock.Enabled = false;
            textBox_ProductDescription.Enabled = false;
        }

        private void page__INVENTORY_Load(object sender, EventArgs e)
        {
            DataTable dt = itemdal.select();
            dataGridViewforITEM.DataSource = dt;
            dataGridViewforITEM.ClearSelection();
            DataTable dt2 = productdal.select();
            dataGridViewforPRODUCT.DataSource = dt2;
            dataGridViewforPRODUCT.ClearSelection();

            itemdal.FillCategoriesIntoComboBox(comboBox__SelectCategory);
        }

        private void button__AddItem_Click(object sender, EventArgs e)
        {
            if (button__AddItem.Text == "ADD")
            {
               
                EnableCategoryInputs();
                ClearInnputs();
                textBox__categoryname.Focus();
                button__DeleteItem.Enabled = false;
               

                button__AddItem.Text = "SAVE";
            }
            else if (button__AddItem.Text == "SAVE")
            {
               
                if (!string.IsNullOrEmpty(textBox__categoryname.Text) && !string.IsNullOrEmpty(textBox__categoryDescription.Text))
                {
               
                    itemgetset.item__name = textBox__categoryname.Text.Trim();
                    itemgetset.item__description = textBox__categoryDescription.Text.Trim();

                    if (itemdal.chechifexist(itemgetset))
                    {
                        MessageBox.Show("CATEGORY ALREADY EXISTS","DUPLICATION DETACTED",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        button__AddItem.Text = "ADD";
                        button__DeleteItem.Enabled = true;
                        ClearInnputs();
                        DisableCategoryInputs();
                        return;
                    }

               

                    bool SuccessInsert = itemdal.insert(itemgetset);

                    if (SuccessInsert == true)
                    {
               
                        ClearInnputs();

               
                        button__AddItem.Text = "ADD";
                        button__DeleteItem.Enabled = true;
                        
                        DisableCategoryInputs();

                        
                        page__INVENTORY_Load(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert the data.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        button__DeleteItem.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("PLEASE ENTER ALL THE FIELDS", "EMPTY FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    button__AddItem.Text = "ADD";
                    button__DeleteItem.Enabled = true;
                    
                    DisableCategoryInputs();
                }
            }   
        }

        private void button__DeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsNameProvided = !string.IsNullOrEmpty(textBox__categoryname.Text);
                bool Success = false;

                if (IsNameProvided)
                {
                    itemgetset.item__name = textBox__categoryname.Text.Trim();
                    Success = itemdal.Delete(itemgetset);
                    
                }

                if (Success)
                {
                    ClearInnputs();
                    page__INVENTORY_Load(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("SELECT CATEGORY TO DELETE","DELETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOMETHING WENT WRONG"+ex.Message,"DELETE",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        

        private void dataGridViewforITEM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                dataGridViewforITEM.ClearSelection();
                return;
            }
            textBox__categoryname.Text = dataGridViewforITEM.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox__categoryDescription.Text = dataGridViewforITEM.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridViewforPRODUCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                dataGridViewforPRODUCT.ClearSelection();
                return; 
            }
                string catname = dataGridViewforPRODUCT.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (comboBox__SelectCategory.Items.Contains(catname))
                {
                    comboBox__SelectCategory.SelectedItem = catname;
                }
                textBox__ProductName.Text = dataGridViewforPRODUCT.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox_ProductDescription.Text = dataGridViewforPRODUCT.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox__ProductSize.Text = dataGridViewforPRODUCT.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox__ProductRate.Text = dataGridViewforPRODUCT.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox__ProductStock.Text = dataGridViewforPRODUCT.Rows[e.RowIndex].Cells[5].Value.ToString();
           
            
        }

        private void button__AddProduct_Click(object sender, EventArgs e)
        {
            if (button__AddProduct.Text == "ADD")
            {
                EnableProductInputs();
                ClearInnputs();
                comboBox__SelectCategory.Focus();
                button__DeleteProduct.Enabled = false;
                button__EditProduct.Enabled = false;
                button__AddProduct.Text = "SAVE";
            }
            else if (button__AddProduct.Text == "SAVE")
            {
                if (!String.IsNullOrEmpty(comboBox__SelectCategory.Text) && !String.IsNullOrEmpty(textBox__ProductName.Text) &&
                    !String.IsNullOrEmpty(textBox__ProductSize.Text) && !String.IsNullOrEmpty(textBox__ProductRate.Text) &&
                    !String.IsNullOrEmpty(textBox__ProductStock.Text) && !String.IsNullOrEmpty(textBox_ProductDescription.Text))
                {
                    productgetset.selected_category = comboBox__SelectCategory.SelectedItem.ToString().Trim();
                    productgetset.product__name = textBox__ProductName.Text.Trim();
                    productgetset.product__description = textBox_ProductDescription.Text.Trim();
                    productgetset.product__size = textBox__ProductSize.Text.Trim();
                    productgetset.product__rate = Convert.ToDecimal(textBox__ProductRate.Text.Trim());
                    productgetset.product__stock = Convert.ToDecimal(textBox__ProductStock.Text.Trim());

                    if (productdal.getcategoryid(productgetset))
                    {
                        if(productdal.chechifexist(productgetset))
                        {
                            MessageBox.Show("PRODUCT ALREADY EXISTS", "DUPLICATION DETACTED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            button__AddProduct.Text = "ADD";
                            button__DeleteProduct.Enabled = true;
                            button__EditProduct.Enabled = true;
                            DisableProductInputs();
                            ClearInnputs();
                        }
                        bool successInsert = productdal.insert(productgetset);

                        if (successInsert)
                        {
                            ClearInnputs();
                            button__AddProduct.Text = "ADD";
                            button__DeleteProduct.Enabled = true;
                            button__EditProduct.Enabled = true;
                            DisableProductInputs();
                            page__INVENTORY_Load(this, EventArgs.Empty);
                        }
                        else
                        {
                            button__DeleteProduct.Enabled = true;
                            button__EditProduct.Enabled = true;
                            MessageBox.Show("Failed to insert the data.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        button__DeleteProduct.Enabled = true;
                        button__EditProduct.Enabled = true;
                        MessageBox.Show("Failed to insert the data.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    button__DeleteProduct.Enabled = true;
                    button__EditProduct.Enabled = true;
                    MessageBox.Show("PLEASE ENTER ALL THE FIELDS", "EMPTY FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    button__AddProduct.Text = "ADD";
                    DisableProductInputs();
                }
            }
        }

        private void button__DeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsNameProvided = !string.IsNullOrEmpty(textBox__ProductName.Text);
                bool IsSizeProvided = !string.IsNullOrEmpty(textBox__ProductSize.Text);
                bool IsRateProvided = !string.IsNullOrEmpty(textBox__ProductRate.Text);
                bool Success = false;

                if (IsNameProvided && IsSizeProvided && IsRateProvided)
                {
                    productgetset.product__name = textBox__ProductName.Text.Trim();
                    productgetset.product__size = textBox__ProductSize.Text.Trim();
                    productgetset.product__rate = Convert.ToDecimal(textBox__ProductRate.Text.Trim());
                    Success = productdal.Delete(productgetset);
                }

                if (Success)
                {
                    ClearInnputs();
                    page__INVENTORY_Load(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("SELECT PRODUCT TO DELETE", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOMETHING WENT WRONG" + ex.Message, "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void button__EditProduct_Click_1(object sender, EventArgs e)
        {
            
            if (button__EditProduct.Text == "EDIT")
            {
                if (dataGridViewforPRODUCT.SelectedRows.Count > 0)
                {
                    EnableProductInputs();
                    button__AddProduct.Enabled = false;
                    button__DeleteProduct.Enabled = false;
                    button__EditProduct.Text = "UPDATE";

                    DataGridViewRow row = dataGridViewforPRODUCT.SelectedRows[0];

            
                    comboBox__SelectCategory.Text = row.Cells["category"].Value.ToString();
                    textBox__ProductName.Text = row.Cells["productname"].Value.ToString();
                    textBox_ProductDescription.Text = row.Cells["productinfo"].Value.ToString();
                    textBox__ProductSize.Text = row.Cells["productsize"].Value.ToString();
                    textBox__ProductRate.Text = row.Cells["productrate"].Value.ToString();
                    textBox__ProductStock.Text = row.Cells["productstock"].Value.ToString();

           
                    productgetset.original_product__name = row.Cells["productname"].Value.ToString();
                    productgetset.original_product__size = row.Cells["productsize"].Value.ToString();
                    productgetset.original_product__rate = Convert.ToDecimal(row.Cells["productrate"].Value);
                }
                else
                {
                    button__AddProduct.Enabled = true;
                    button__DeleteProduct.Enabled = true;
                    MessageBox.Show("PLEASE SELECT A ROW FIRST TO UPDATE", "UPDATATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
            else if (button__EditProduct.Text == "UPDATE")
            {
                if (!string.IsNullOrEmpty(comboBox__SelectCategory.Text) &&
                    !string.IsNullOrEmpty(textBox__ProductName.Text) &&
                    !string.IsNullOrEmpty(textBox__ProductSize.Text) &&
                    !string.IsNullOrEmpty(textBox__ProductRate.Text) &&
                    !string.IsNullOrEmpty(textBox__ProductStock.Text) &&
                    !string.IsNullOrEmpty(textBox_ProductDescription.Text))
                {
           
                    productgetset.selected_category = comboBox__SelectCategory.Text.Trim();
                    productgetset.product__name = textBox__ProductName.Text.Trim();
                    productgetset.product__description = textBox_ProductDescription.Text.Trim();
                    productgetset.product__size = textBox__ProductSize.Text.Trim();
                    productgetset.product__rate = Convert.ToDecimal(textBox__ProductRate.Text.Trim());
                    productgetset.product__stock = Convert.ToDecimal(textBox__ProductStock.Text.Trim());

           
                    bool categoryFound = productdal.getcategoryid(productgetset);
                    bool productFound = productdal.getproid(productgetset);  

                    if (categoryFound && productFound)
                    {
                        bool success = productdal.update(productgetset);
                        if (success)
                        {
                            MessageBox.Show("PRODUCT UPDATED SUCCESSFULLY!");
                            button__AddProduct.Enabled = true;
                            button__DeleteProduct.Enabled = true;
                            button__EditProduct.Text = "EDIT";
                            DisableProductInputs();
                            page__INVENTORY_Load(this, EventArgs.Empty);
                        }
                        else
                        {
                            button__AddProduct.Enabled = true;
                            button__DeleteProduct.Enabled = true;
                            MessageBox.Show("UPDATE FAILED");
                        }
                    }
                    else
                    {
                        button__AddProduct.Enabled = true;
                        button__DeleteProduct.Enabled = true;
                        MessageBox.Show("CATEGORY OR PRODUCT ID NOT FOUND", "ID ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("PLEASE ENTER ALL THE FIELDS", "EMPTY FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        

        private void textBox__ProductRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; 
            }

            
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void textBox__ProductStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
