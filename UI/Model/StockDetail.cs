using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Model
{
    internal class StockDetail
    {
        public StockDetail() { }
        public long ProductID { get; set; }
        public int StockID { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public Stock Stock { get; set; }
    }
}
