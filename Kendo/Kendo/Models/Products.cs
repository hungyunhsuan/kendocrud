using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kendo.Models
{
    public class Products
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public string Description { get; set; }

        public string CategoryID { get; set; }

        public DateTime ShelfDate { get; set; }
    }
}