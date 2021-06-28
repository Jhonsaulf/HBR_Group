using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWeb.Models
{
    public class ProductPojo
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string FullName { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public int User { get; set; }
    }
}