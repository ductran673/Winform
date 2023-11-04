using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Model
{
    internal class ImportDetail
    {
        public int ImportBillID { get; set; }
        public long ProductID { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public ImportBill ImportBill { get; set; }
        public Product Product { get; set; }
    }
}
