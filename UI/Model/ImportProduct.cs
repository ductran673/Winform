using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Model
{
    internal class ImportProduct
    {
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public int PriceProduct { get; set; }
        public int Quantity { get; set; }
        public int UnitID { get; set; }
        public int TotalPrice { get { return Quantity* PriceProduct;  } }
    }
}
