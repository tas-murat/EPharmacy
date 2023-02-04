using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPharmacy.Core.Entities;

namespace EPharmacy.Entities.Concrete
{
    [Table("City")]
    public class City : IEntity
    {
        [Key]
        [Column(TypeName = "varchar(3)"), StringLength(3)]
        public string Plaka { get; set; }
        [Column(TypeName = "varchar(100)"), StringLength(100)]
        public string Name { get; set; }
        public ICollection<District> Districts { get; set; }
    }
}
