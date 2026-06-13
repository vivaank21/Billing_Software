using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Billing_Software.Connection;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;


namespace Billing_Software.GUI
{
    public partial class page__MAIN : Form
    {
        public page__MAIN()
        {
            InitializeComponent();
        }

        ConnectiontoDB conn = new ConnectiontoDB();

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void page__MAIN_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label__time.Text = DateTime.Now.ToString("hh:mm:ss tt");

            label__date.Text = DateTime.Now.ToLongDateString();

            label__day.Text = DateTime.Now.DayOfWeek.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label__time.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void button__save_notes_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_notes.Text))
            {
                MessageBox.Show("PLEASE TAKE NOTES FIRST", "EMPTY NOTES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SaveFileDialog SFD = new SaveFileDialog();
                SFD.Title = "Save MyNotes";
                SFD.Filter = "PlainText File|*.txt";

                if (DialogResult.OK == SFD.ShowDialog())
                {
                    if (SFD.FilterIndex == 1)
                    {
                        try
                        {
                            System.IO.File.WriteAllText(SFD.FileName, textBox_notes.Text);
                            MessageBox.Show("Notes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error saving file:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void button__clear_notes_Click(object sender, EventArgs e)
        {
            textBox_notes.Clear();
            textBox_notes.Focus();
        }

        private void button__open_notes_Click(object sender, EventArgs e)
        {
            OpenFileDialog SFD = new OpenFileDialog();
            SFD.Title = "Open MyNotes";
            SFD.Filter = "PlainText File|*.txt";

            if (DialogResult.OK == SFD.ShowDialog())
            {
                if (SFD.FilterIndex == 1)
                {
                    try
                    {
                        string content = System.IO.File.ReadAllText(SFD.FileName);
                        textBox_notes.Text = content;
                        MessageBox.Show("Notes loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error opening file:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private Form openform;
        public void closeothers()
        {
            if (openform != null)
            {
                if (!openform.IsDisposed)
                {
                    openform.Close();
                }
                openform = null;
            }
        }
        private void button_Inventory_Click(object sender, EventArgs e)
        {
            closeothers();
            page__INVENTORY inv = new page__INVENTORY();
            openform = inv;
            inv.Show();
        }

        private void button_Invoice_Click(object sender, EventArgs e)
        {
            closeothers();
            page__INVOICE invo = new page__INVOICE();
            openform = invo;
            invo.Show();
        }

        private void button_Records_Click(object sender, EventArgs e)
        {
            closeothers();
            page__RECORDS reco = new page__RECORDS();
            openform = reco;
            reco.Show();
        }

        private void button_Reports_Click(object sender, EventArgs e)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\DatabaseBackup.txt";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            ConnectiontoDB con = new ConnectiontoDB();
            con.OpenConnection();
            
            SqlCommand cmdCat = new SqlCommand("SELECT CategoryName, CategoryDescription FROM tbl__category", con.GetConnection);
            SqlDataReader drCat = cmdCat.ExecuteReader();
            sb.AppendLine("===== CATEGORIES =====");
            sb.AppendLine("Category".PadRight(20) + "Description");
            sb.AppendLine(new string('-', 60));
            while (drCat.Read())
            {
                sb.AppendLine(
                    drCat["CategoryName"].ToString().PadRight(20) +
                    drCat["CategoryDescription"].ToString()
                );
            }
            sb.AppendLine();
            drCat.Close();

            // ----------------- PRODUCTS -----------------
            SqlCommand cmdProd = new SqlCommand("SELECT p.productname, c.CategoryName, p.Description, p.Size, p.Rate, p.Stock FROM tbl__products p LEFT JOIN tbl__category c ON p.CategoryID = c.CategoryID", con.GetConnection);
            SqlDataReader drProd = cmdProd.ExecuteReader();
            sb.AppendLine("===== PRODUCTS =====");
            sb.AppendLine("Product".PadRight(20) + "Category".PadRight(20) + "Description".PadRight(20) + "Size".PadRight(10) + "Rate".PadRight(10) + "Stock");
            sb.AppendLine(new string('-', 100));
            while (drProd.Read())
            {
                sb.AppendLine(
                    drProd["productname"].ToString().PadRight(20) +
                    drProd["CategoryName"].ToString().PadRight(20) +
                    drProd["Description"].ToString().PadRight(20) +
                    drProd["Size"].ToString().PadRight(10) +
                    drProd["Rate"].ToString().PadRight(10) +
                    drProd["Stock"].ToString()
                );
            }
            sb.AppendLine();
            drProd.Close();

            // ----------------- CUSTOMERS -----------------
            SqlCommand cmdCust = new SqlCommand("SELECT CustomerName, MobileNo, Address FROM tbl__customers", con.GetConnection);
            SqlDataReader drCust = cmdCust.ExecuteReader();
            sb.AppendLine("===== CUSTOMERS =====");
            sb.AppendLine("Customer Name".PadRight(25) + "Mobile".PadRight(15) + "Address");
            sb.AppendLine(new string('-', 70));
            while (drCust.Read())
            {
                sb.AppendLine(
                    drCust["CustomerName"].ToString().PadRight(25) +
                    drCust["MobileNo"].ToString().PadRight(15) +
                    drCust["Address"].ToString()
                );
            }
            sb.AppendLine();
            drCust.Close();

            // ----------------- INVOICES -----------------
            SqlCommand cmdInv = new SqlCommand("SELECT inv.invoiceno, inv.invoicedate, cust.CustomerName, inv.totalamount, inv.tax, inv.discount, inv.grandtotal FROM tbl__invoice2 inv LEFT JOIN tbl__customers cust ON inv.CustomerID = cust.CustomerID", con.GetConnection);
            SqlDataReader drInv = cmdInv.ExecuteReader();
            sb.AppendLine("===== INVOICES =====");
            sb.AppendLine("Invoice No".PadRight(12) + "Date".PadRight(20) + "Customer".PadRight(25) + "Total".PadRight(10) + "Tax".PadRight(8) + "Discount".PadRight(10) + "Grand Total");
            sb.AppendLine(new string('-', 100));
            while (drInv.Read())
            {
                sb.AppendLine(
                    drInv["invoiceno"].ToString().PadRight(12) +
                    Convert.ToDateTime(drInv["invoicedate"]).ToString("yyyy-MM-dd HH:mm").PadRight(20) +
                    drInv["CustomerName"].ToString().PadRight(25) +
                    drInv["totalamount"].ToString().PadRight(10) +
                    drInv["tax"].ToString().PadRight(8) +
                    drInv["discount"].ToString().PadRight(10) +
                    drInv["grandtotal"].ToString()
                );
            }
            sb.AppendLine();
            drInv.Close();

            con.CloseConnection();

            // Write to file
            File.WriteAllText(filePath, sb.ToString());
            MessageBox.Show("Report generated at:\n" + filePath);
        }

    

        }
    }



