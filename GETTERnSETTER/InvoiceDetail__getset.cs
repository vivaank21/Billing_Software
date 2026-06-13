using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_Software.GETTERnSETTER
{
    class InvoiceDetail__getset
    {
        public int invoiceDetailID { get; set; }

        public int invoiceID { get; set; }

        public int proID { get; set; }

        public decimal qunatity { get; set; }

        public decimal rate { get; set; }
    }
}
