using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPharmacy.Entities.Concrete
{
    [Table("Logs")]
    public class Logs
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(4000)")]
        public string Detail { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Audit { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }
    }
}
