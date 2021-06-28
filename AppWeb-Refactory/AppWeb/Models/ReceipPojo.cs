using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWeb.Models
{
    public class ReceipPojo
    {
        public int IDReceip { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public int UserID { get; set; }
        public int ProductId { get; set; }
    }
}