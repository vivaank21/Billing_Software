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
    public partial class page__RECORDS : Form
    {
        Records_DAL Rdal = new Records_DAL();
        public page__RECORDS()
        {
            InitializeComponent();
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void page__RECORDS_Load(object sender, EventArgs e)
        {
            DataTable dt = Rdal.selectAll();
            dataGridViewforSales.DataSource = dt;
            dataGridViewforSales.ClearSelection();
        }

        private void button__ShoeSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox__SelectSearchOption.Text))
            {
                MessageBox.Show("Please select a search option.", "SEARCH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string field = comboBox__SelectSearchOption.Text;
            string searchVal = textBox__SearchVal.Text.Trim();
            DateTime fromDate = InvoiceFromDateTimePicker.Value.Date;
            DateTime toDate = InvoiceToDateTimePicker.Value.Date;
            DataTable dt2 = null;

           
            if (field == "Invoice Date Range")
            {
           
                dt2 = Rdal.selectViaValue(field, "", fromDate, toDate);
            }
            else
            {
           
                if (string.IsNullOrEmpty(searchVal))
                {
                    MessageBox.Show("Please enter a search value for the selected option.", "SEARCH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

           
                dt2 = Rdal.selectViaValue(field, searchVal, DateTime.MinValue, DateTime.MinValue);
            }

            dataGridViewforSales.DataSource = dt2;
            dataGridViewforSales.ClearSelection();
        }

        private void comboBox__SelectSearchOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox__SelectSearchOption.Text == "Invoice Date Range")
            {
                InvoiceFromDateTimePicker.Enabled = true;
                InvoiceToDateTimePicker.Enabled = true;
            }
            else
            {
                InvoiceFromDateTimePicker.Enabled = false;
                InvoiceToDateTimePicker.Enabled = false;
            }
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBox__SelectSearchOption.SelectedIndex = -1;
            textBox__SearchVal.Clear();
            page__RECORDS_Load(null, EventArgs.Empty);
        }


    }
}
