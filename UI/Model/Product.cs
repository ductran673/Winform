using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Model
{
    internal class Product
    {
        public Product() {
            
        }
        public long ProductID { get; set; }
        [Column(TypeName = ("nvarchar(100)"))]
        public string Name { get; set; }
        public int Price { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string? Description { get; set; }
        public int UnitID { get; set; }
        public Unit Unit { get; set; }
        public StockDetail StockDetail { get; set; }
    }
}
