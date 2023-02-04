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
    [Table("District")]
    public class District : IEntity
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(100)"), StringLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "varchar(3)"), StringLength(3), Required()]
        public string CityPlaka { get; set; }
        public City City { get; set; }
        public ICollection<Address> Address { get; set; }
    }
}
