using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EPharmacy.Core.Entities;

namespace EPharmacy.Entities.Concrete
{
    [Table("OrderDetail")]
    public class OrderDetail : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Sipariş")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        [StringLength(150), Column(TypeName = "varchar(150)"), Display(Name = "Ürün Adı")]
        public string Name { get; set; }

        [Display(Name = "Ürün Fiyatı")]
        public decimal Price { get; set; }

        [Display(Name = "Miktar")]
        public int Quantity { get; set; }

    }
}
