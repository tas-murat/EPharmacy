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
    [Table("Address")]
    public class Address:IEntity
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(100)"), StringLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "varchar(250)"), StringLength(250)]
        public string Detail { get; set; }
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
    }
}
