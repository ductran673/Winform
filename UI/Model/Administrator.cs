using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Model
{
    internal class Administrator
    {
        public Administrator() { 
            this.ImportBill = new HashSet<ImportBill>();
        }
        public int AdministratorID { get; set; }
        [Column(TypeName = "char(20)")]
        public string UserName { get; set; }
        [Column(TypeName = "char(16)")]
        public string Password { get; set; }
        [DataType(DataType.EmailAddress)]
        [Column(TypeName = "varchar(50)")]
        public string? Email { get; set; }
        [Column(TypeName = "char(10)")]
        public string? Phone { get; set; }
        public ICollection<ImportBill> ImportBill { get; set; }
    }
}
