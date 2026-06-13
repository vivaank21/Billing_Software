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

namespace Billing_Software.GETTERnSETTER
{
    class Invoice__getset
    {
        public int invoiceID { get; set; }

        public string invoiceNO { get; set; }

        public DateTime invoiceDate { get; set; }

        public int customerid { get; set; }

        public decimal totalAmount { get; set; }
        
        public decimal tax { get; set; }

        public decimal discount { get; set; }

        public decimal grandTotal { get; set; }
    }
}
