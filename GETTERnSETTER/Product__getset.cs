using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_Software.GETTERnSETTER
{
    class Product__getset
    {
        public string original_product__name { get; set; }

        public string original_product__size { get; set; }

        public decimal original_product__rate { get; set; }

        public int pro__id { get; set; }

        public int category__id { get; set; }

        public string selected_category { get; set; }

        public string product__name { get; set; }

        public string product__description { get; set; }

        public string product__size { get; set; }

        public decimal product__rate { get; set; }
        
        public decimal product__stock { get; set; }
    }
}
