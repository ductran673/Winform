using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Model
{
    internal class Unit
    {
        public Unit() {
            this.Products = new HashSet<Product>();
        }
        public int UnitID { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
