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
using System.Drawing.Printing;


namespace Billing_Software.GUI
{
    public partial class page__INVOICE : Form
    {
        Item__getset itemgetset = new Item__getset();
        Item_DAL itemdal = new Item_DAL();

        Product__getset productgetset = new Product__getset();
        Product_DAL productdal = new Product_DAL();

        Customer__getset cusgetset = new Customer__getset();
        Customer_DAL cusdal = new Customer_DAL();

        Invoice__getset invgetset = new Invoice__getset();
        Invoice_DAL invdal = new Invoice_DAL();

        InvoiceDetail__getset invdetail_getset = new InvoiceDetail__getset();
        InvoiceDetail__DAL invdetaildal = new InvoiceDetail__DAL();

        DataTable dt = new DataTable();
        bool isInvoiceCreated = false;

        public void EnableInputs()
        {
            textBox__CustomerName.Enabled = true;
            textBox__CustomerContact.Enabled = true;
            textBox__CustomerAddress.Enabled = true;
            textBox__InvoiceNO.Enabled = true;
            InvoicedateTimePicker.Enabled = true;
            comboBox__SelectCategory.Enabled = true;
            comboBox__SelectProduct.Enabled = true;
            comboBox__SelectProductSize.Enabled = true;
            textBox__ShowProductRate.Enabled = true;
            textBox__ShowAvailableStock.Enabled = true;
            textBox__SaleStock.Enabled = true;
            textBox__ShowProductDescription.Enabled = true;
            textBox__ShowSubTotal.Enabled = true;
            textBox__Discount.Enabled = true;
            textBox__GSTandTAX.Enabled = true;
            textBox__ShowGrandTotal.Enabled = true;
        }

        public void DisableInputs()
        {
            textBox__CustomerName.Enabled = false;
            textBox__CustomerContact.Enabled = false;
            textBox__CustomerAddress.Enabled = false;
            textBox__InvoiceNO.Enabled = false;
            InvoicedateTimePicker.Enabled = false;
            comboBox__SelectCategory.Enabled = false;
            comboBox__SelectProduct.Enabled = false;
            comboBox__SelectProductSize.Enabled = false;
            textBox__ShowProductRate.Enabled = false;
            textBox__ShowAvailableStock.Enabled = false;
            textBox__SaleStock.Enabled = false;
            textBox__ShowProductDescription.Enabled = false;
            textBox__ShowSubTotal.Enabled = false;
            textBox__Discount.Enabled = false;
            textBox__GSTandTAX.Enabled = false;
            textBox__ShowGrandTotal.Enabled = false;
        }

        public void ClearEverything()
        {
            textBox__CustomerName.Clear();
            textBox__CustomerContact.Clear();
            textBox__CustomerAddress.Clear();
            comboBox__SelectCategory.SelectedIndex = -1;
            comboBox__SelectProduct.SelectedIndex = -1;
            comboBox__SelectProductSize.SelectedIndex = -1;
            textBox__ShowProductRate.Clear();
            textBox__ShowAvailableStock.Clear();
            textBox__SaleStock.Clear();
            textBox__ShowProductDescription.Clear();
            textBox__InvoiceNO.Clear();
            textBox__ShowSubTotal.Clear();
            textBox__Discount.Clear();
            textBox__GSTandTAX.Clear();
            textBox__ShowGrandTotal.Clear();
        }

        public void ClearEverythingNOTinvoNUM()
        {
            textBox__CustomerName.Clear();
            textBox__CustomerContact.Clear();
            textBox__CustomerAddress.Clear();
            comboBox__SelectCategory.SelectedIndex = -1;
            comboBox__SelectProduct.SelectedIndex = -1;
            comboBox__SelectProductSize.SelectedIndex = -1;
            textBox__ShowProductRate.Clear();
            textBox__ShowAvailableStock.Clear();
            textBox__SaleStock.Clear();
            textBox__ShowProductDescription.Clear();
        }

        public page__INVOICE()
        {
            InitializeComponent();
            InitializeProductTable();
        }

        private void InitializeProductTable()
        {
            dt.Columns.Add("ProductID", typeof(int));
            dt.Columns.Add("Product", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Rate", typeof(decimal));
            dt.Columns.Add("Quantity", typeof(decimal));
            dt.Columns.Add("Total", typeof(decimal));

            dataGridViewforPRODUCTS.DataSource = dt;

            if (dataGridViewforPRODUCTS.Columns["ProductID"] != null)
            {
                dataGridViewforPRODUCTS.Columns["ProductID"].Visible = false;
            }

            
            if (dataGridViewforPRODUCTS.Columns["Remove"] == null)
            {
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                btnCol.HeaderText = "DELETE PRODUCT";
                btnCol.Name = "Remove";
                btnCol.Text = "Remove";
                btnCol.UseColumnTextForButtonValue = true;
                dataGridViewforPRODUCTS.Columns.Add(btnCol);
            }

            
            dataGridViewforPRODUCTS.ClearSelection();
        }

        private void dataGridViewforPRODUCTS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex < 0) return;

           
            if (e.ColumnIndex != dataGridViewforPRODUCTS.Columns["Remove"].Index) return;

           
            if (e.RowIndex >= dt.Rows.Count) return;

            if (isInvoiceCreated == true)
            {
                MessageBox.Show("CAN NOT EDIT INVOICE AFTER SAVING", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            dt.Rows.RemoveAt(e.RowIndex);

            RecalculateTotals();

           
            dataGridViewforPRODUCTS.ClearSelection();
        }

        private void RecalculateTotals()
        {
            if (!string.IsNullOrEmpty(textBox__Discount.Text) && !string.IsNullOrEmpty(textBox__GSTandTAX.Text))
            {
                decimal subTotal = 0;
                int i;
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    subTotal += Convert.ToDecimal(dt.Rows[i]["Total"]);
                }
                textBox__ShowSubTotal.Text = subTotal.ToString("0.00");

                decimal discPct = decimal.Parse(textBox__Discount.Text.ToString());
                decimal taxPct = decimal.Parse(textBox__GSTandTAX.Text.ToString()); ;

                decimal discountAmt = (subTotal * discPct) / 100;
                decimal taxAmt = (subTotal - discountAmt) * taxPct / 100;
                decimal grand = (subTotal - discountAmt) + taxAmt;

                textBox__ShowGrandTotal.Text = grand.ToString("0.00");
               
            }
            else
            {
                MessageBox.Show("Please enter Discount and Please enter GST/Tax.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void page__INVOICE_Load(object sender, EventArgs e)
        {
            DisableInputs();
            labelColon1.Focus();
            textBox__InvoiceNO.Text = invdal.GenerateNextInvoiceNumber();
            itemdal.FillCategoriesIntoComboBox(comboBox__SelectCategory);
            dataGridViewforPRODUCTS.ClearSelection();
        }

        private void comboBox__SelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            productgetset.selected_category = comboBox__SelectCategory.Text.Trim();
            int categoryId = productdal.getcategoryidINT(productgetset);
            comboBox__SelectProduct.SelectedIndex = -1;
            comboBox__SelectProductSize.SelectedIndex = -1;
            textBox__ShowProductRate.Clear();
            textBox__ShowAvailableStock.Clear();
            textBox__ShowProductDescription.Clear();
            productdal.FillProductsIntoComboBox(comboBox__SelectProduct, categoryId);
        }

        private void comboBox__SelectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            productgetset.product__name = comboBox__SelectProduct.Text.Trim();
            productdal.FillSizeComboBox(comboBox__SelectProductSize, productgetset);
        }

        private void comboBox__SelectProductSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            productgetset.product__name = comboBox__SelectProduct.Text.Trim();
            productgetset.product__size = comboBox__SelectProductSize.Text.Trim();

            productdal.FillRateTextbox(textBox__ShowProductRate, productgetset);
            productgetset.product__rate = Decimal.Parse(textBox__ShowProductRate.Text.Trim());
            productdal.FillStockTextBox(textBox__ShowAvailableStock, productgetset, productgetset.product__rate);
            productgetset.product__stock = Decimal.Parse(textBox__ShowAvailableStock.Text.Trim());
            productdal.FillDescriptionTextBox(textBox__ShowProductDescription, productgetset, productgetset.product__stock);
        }

        private void comboBox__SelectCategory_Click(object sender, EventArgs e) { }

        private void button__AddProducts_Click(object sender, EventArgs e)
        {
            if (button__AddProducts.Text == "START INVOICE")
            {
                EnableInputs();
                ClearEverythingNOTinvoNUM();
                textBox__CustomerName.Focus();
                button__AddProducts.Text = "ADD";
            }
            else if (button__AddProducts.Text == "ADD")
            {
                if (!string.IsNullOrEmpty(textBox__CustomerName.Text) &&
                    !string.IsNullOrEmpty(textBox__CustomerContact.Text) &&
                    !string.IsNullOrEmpty(textBox__CustomerAddress.Text) &&
                    !string.IsNullOrEmpty(textBox__InvoiceNO.Text) &&
                    !string.IsNullOrEmpty(comboBox__SelectCategory.Text) &&
                    !string.IsNullOrEmpty(comboBox__SelectProduct.Text) &&
                    !string.IsNullOrEmpty(comboBox__SelectProductSize.Text)&&
                    !string.IsNullOrEmpty(textBox__ShowProductRate.Text) &&
                    !string.IsNullOrEmpty(textBox__ShowAvailableStock.Text) &&
                    !string.IsNullOrEmpty(textBox__SaleStock.Text) && 
                    !string.IsNullOrEmpty(textBox__Discount.Text) &&
                    !string.IsNullOrEmpty(textBox__GSTandTAX.Text) )
                {
                    decimal rate = decimal.Parse(textBox__ShowProductRate.Text);
                    decimal available = decimal.Parse(textBox__ShowAvailableStock.Text);
                    decimal qty = decimal.Parse(textBox__SaleStock.Text);

                    if (qty > available)
                    {
                        MessageBox.Show("NOT ENOUGH QUANTITY AVAILABLE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (qty < 1)
                    {
                        MessageBox.Show("AT LEAST ADD 1 TO PURCHASED STOCK", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string pname = comboBox__SelectProduct.Text.Trim();
                    string size = comboBox__SelectProductSize.Text.Trim();

                    productgetset.product__name = pname;
                    productgetset.product__size = size;
                    productgetset.product__rate = rate;

                    int pid = productdal.getproIDINT(productgetset);

                    if (pid <= 0)
                    {
                        MessageBox.Show("Product not found." + pid.ToString());
                        return;
                    }

                    dt.Rows.Add(pid, pname, size, rate, qty, (rate * qty));
                    RecalculateTotals();
                    textBox__SaleStock.Clear();
                    dataGridViewforPRODUCTS.ClearSelection();
                }
                else
                {

                    MessageBox.Show("PLEASE ENTER ALL THE FIELDS", "EMPTY FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ClearEverythingNOTinvoNUM();
                    DisableInputs();
                    button__AddProducts.Text = "START INVOICE";
                    return;
                }

               
            }
            else
            {
                MessageBox.Show("PLEASE ENTER ALL THE FIELDS 2", "EMPTY FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ClearEverythingNOTinvoNUM();
                DisableInputs();
                button__AddProducts.Text = "START INVOICE";
            }
        }

        private void button__SaveInvoice_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox__CustomerName.Text) &&
                    string.IsNullOrWhiteSpace(textBox__CustomerContact.Text) &&
                    string.IsNullOrWhiteSpace(textBox__CustomerAddress.Text) &&
                    string.IsNullOrWhiteSpace(textBox__InvoiceNO.Text) &&
                    string.IsNullOrEmpty(comboBox__SelectCategory.Text) &&
                    string.IsNullOrEmpty(comboBox__SelectProduct.Text) &&
                    string.IsNullOrEmpty(comboBox__SelectProductSize.Text) &&
                    string.IsNullOrEmpty(textBox__ShowProductRate.Text) &&
                    string.IsNullOrEmpty(textBox__SaleStock.Text) &&
                    string.IsNullOrEmpty(textBox__GSTandTAX.Text) &&
                    string.IsNullOrEmpty(textBox__Discount.Text) &&
                    string.IsNullOrEmpty(textBox__ShowSubTotal.Text) &&
                    string.IsNullOrEmpty(textBox__ShowGrandTotal.Text))
            {
                MessageBox.Show("PLEASE FILL ALL THE DETAILS FIRST", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("ADD PRODUCTS FIRST.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(textBox__CustomerName.Text) &&
               !string.IsNullOrWhiteSpace(textBox__CustomerContact.Text) &&
               !string.IsNullOrWhiteSpace(textBox__CustomerAddress.Text))
            {
                cusgetset.CusName = textBox__CustomerName.Text.Trim();
                cusgetset.CusContact = textBox__CustomerContact.Text.Trim();
                cusgetset.CusAddress = textBox__CustomerAddress.Text.Trim();

                int customerId = invdal.getCusID(cusgetset);
                if (customerId == 0)
                {
                    if (!cusdal.insert(cusgetset))
                    {
                        MessageBox.Show("Failed to insert customer.");
                        return;
                    }
                    customerId = invdal.getCusID(cusgetset);
                }


                decimal subTotal = Convert.ToDecimal(textBox__ShowSubTotal.Text);

                decimal discPct = decimal.Parse(textBox__Discount.Text.ToString());
                decimal taxPct = decimal.Parse(textBox__GSTandTAX.Text.ToString()); ;

                decimal discountAmt = (subTotal * discPct) / 100;
                decimal taxAmt = (subTotal - discountAmt) * taxPct / 100;
                decimal grand = (subTotal - discountAmt) + taxAmt;

                invgetset.invoiceNO = textBox__InvoiceNO.Text.Trim();
                invgetset.invoiceDate = InvoicedateTimePicker.Value;
                invgetset.customerid = customerId;
                invgetset.totalAmount = subTotal;
                invgetset.tax = taxAmt;
                invgetset.discount = discountAmt;
                invgetset.grandTotal = grand;

                if (!invdal.insert(invgetset))
                {
                    MessageBox.Show("Failed to insert invoice.");
                    return;
                }

                int invoiceId = invdetaildal.getInvoiceID_ByInvoiceNO(invgetset.invoiceNO);
                if (invoiceId <= 0)
                {
                    MessageBox.Show("Could not fetch invoice ID. " + invoiceId.ToString());
                    return;
                }

                int i;
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    int pid = Convert.ToInt32(dt.Rows[i]["ProductID"]);
                    decimal rate = Convert.ToDecimal(dt.Rows[i]["Rate"]);
                    decimal qty = Convert.ToDecimal(dt.Rows[i]["Quantity"]);

                    invdetail_getset.invoiceID = invoiceId;
                    invdetail_getset.proID = pid;
                    invdetail_getset.rate = rate;
                    invdetail_getset.qunatity = qty;

                    if (!invdetaildal.insert(invdetail_getset))
                    {
                        MessageBox.Show("Failed to insert invoice detail.");
                        return;
                    }


                    if (!invdetaildal.updatestock(pid, qty))
                    {
                        MessageBox.Show("Failed to update stock.");
                        return;
                    }
                }

                isInvoiceCreated = true;
                MessageBox.Show("Invoice saved.","SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button__ClearProducts_Click(object sender, EventArgs e)
        {
            ClearEverything();
            dt.Rows.Clear();
            isInvoiceCreated = false;
            button__AddProducts.Text = "START INVOICE";
            page__INVOICE_Load(null, EventArgs.Empty);
        }

        private void button__PrintInvoice_Click(object sender, EventArgs e)
        {
            if (isInvoiceCreated == true)
            {
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
                labelColon1.Focus();
            }
            else
            {
                MessageBox.Show("CREATE INVOICE FIRST.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 12, FontStyle.Bold);
            Font labelFont = new Font("Arial", 10, FontStyle.Bold);
            Font regularFont = new Font("Arial", 10);
            Font italicFont = new Font("Arial", 9, FontStyle.Italic);
            Brush brush = Brushes.Black;

            float xLeft = e.MarginBounds.Left;
            float xRight = e.MarginBounds.Right;
            float yPos = 40;

            
            e.Graphics.DrawString("Complete Business Software", regularFont, brush, xRight - 200, yPos);
            yPos += 15;
            e.Graphics.DrawString("ABC sector, XYZ street AnyCity.", regularFont, brush, xRight - 200, yPos);
            yPos += 15;
            e.Graphics.DrawString("361305", regularFont, brush, xRight - 200, yPos);

            yPos = 40;

            
            e.Graphics.DrawString("Invoice", headerFont, brush, xLeft, yPos);
            yPos += 30;

            
            e.Graphics.DrawString("Invoice No: " + textBox__InvoiceNO.Text, regularFont, brush, xLeft, yPos);
            e.Graphics.DrawString("Date: " + InvoicedateTimePicker.Value.ToShortDateString(), regularFont, brush, xLeft + 300, yPos);
            yPos += 30;

            
            e.Graphics.FillRectangle(Brushes.Lavender, new RectangleF(xLeft, yPos, 700, 20));
            e.Graphics.DrawString("BILLING INFORMATION", labelFont, brush, xLeft + 5, yPos);
            yPos += 25;

            
            e.Graphics.DrawString("Customer Name: " + textBox__CustomerName.Text, regularFont, brush, xLeft, yPos);
            yPos += 18;
            e.Graphics.DrawString("Customer Address: " + textBox__CustomerAddress.Text, regularFont, brush, xLeft, yPos);
            yPos += 18;
            e.Graphics.DrawString("Customer Phone: " + textBox__CustomerContact.Text, regularFont, brush, xLeft, yPos);
            yPos += 30;

            
            float tableStartY = yPos;
            float col1 = xLeft;
            float col2 = col1 + 250;
            float col3 = col2 + 100;
            float col4 = col3 + 100;

            e.Graphics.FillRectangle(Brushes.Lavender, new RectangleF(col1, yPos, 550, 20));
            e.Graphics.DrawString("DESCRIPTION", labelFont, brush, col1 + 2, yPos + 2);
            e.Graphics.DrawString("QUANTITY", labelFont, brush, col2 + 2, yPos + 2);
            e.Graphics.DrawString("COST", labelFont, brush, col3 + 2, yPos + 2);
            e.Graphics.DrawString("AMOUNT", labelFont, brush, col4 + 2, yPos + 2);

            yPos += 25;

            
            foreach (DataGridViewRow row in dataGridViewforPRODUCTS.Rows)
            {
                if (row.IsNewRow) continue;

                string pname = row.Cells["Product"].Value.ToString() ?? "";
                string qty = row.Cells["Quantity"].Value.ToString() ?? "";
                string cost = row.Cells["Rate"].Value.ToString() ?? "";
                string total = row.Cells["Total"].Value.ToString() ?? "";

                e.Graphics.DrawString(pname, regularFont, brush, col1 + 2, yPos);
                e.Graphics.DrawString(qty, regularFont, brush, col2 + 2, yPos);
                e.Graphics.DrawString("₹" + cost, regularFont, brush, col3 + 2, yPos);
                e.Graphics.DrawString("₹" + total, regularFont, brush, col4 + 2, yPos);

                yPos += 20;
            }

            
            float notesBoxY = yPos + 10;
            float notesBoxHeight = 60;
            e.Graphics.FillRectangle(Brushes.Lavender, new RectangleF(xLeft, notesBoxY, 350, notesBoxHeight));
            e.Graphics.DrawString("Notes:", regularFont, brush, xLeft + 5, notesBoxY + 5);
            

            
            decimal subtotal = 0;
            foreach (DataGridViewRow row in dataGridViewforPRODUCTS.Rows)
            {
                if (row.Cells["Total"].Value != null)
                    subtotal += Convert.ToDecimal(row.Cells["Total"].Value);
            }
            
            decimal discountPercent = Convert.ToDecimal(textBox__Discount.Text.ToString());
            decimal taxPercent = Convert.ToDecimal(textBox__GSTandTAX.Text.ToString());

            decimal discountAmt = (subtotal * discountPercent) / 100;
            decimal taxAmt = (subtotal - discountAmt) * taxPercent / 100;
            decimal grandTotal = Convert.ToDecimal(textBox__ShowGrandTotal.Text);

            
            float totalsX = xLeft + 400;
            float totalsY = notesBoxY;
            float spacing = 18;

            e.Graphics.DrawString("SUB TOTAL", regularFont, brush, totalsX, totalsY);
            e.Graphics.DrawString("₹" + subtotal.ToString("0.00"), regularFont, brush, totalsX + 120, totalsY);
            totalsY += spacing;

            e.Graphics.DrawString("DISCOUNT", regularFont, brush, totalsX, totalsY);
            e.Graphics.DrawString("- ₹" + discountAmt.ToString("0.00"), regularFont, brush, totalsX + 120, totalsY);
            totalsY += spacing;

            e.Graphics.DrawString("TAX", regularFont, brush, totalsX, totalsY);
            e.Graphics.DrawString("+ ₹" + taxAmt.ToString("0.00"), regularFont, brush, totalsX + 120, totalsY);
            totalsY += spacing;

            e.Graphics.DrawString("TOTAL", subHeaderFont, brush, totalsX, totalsY);
            e.Graphics.DrawString("₹" + grandTotal.ToString("0.00"), subHeaderFont, brush, totalsX + 120, totalsY);

            
            string thankYou = "Thank you for the shopping!";
            SizeF thankSize = e.Graphics.MeasureString(thankYou, italicFont);
            float centerX = e.PageBounds.Width / 2 - thankSize.Width / 2;
            e.Graphics.DrawString(thankYou, italicFont, brush, centerX, totalsY + 50);
        }

        private void textBox__CustomerContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void textBox__SaleStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void textBox__Discount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox__GSTandTAX_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}