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
    [Table("Favorite")]
    public class Favorite : IEntity
    {
        [Key, Column(Order = 1)]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Key, Column(Order = 2)]
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
    }
}
