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
    [Table("Product")]
    public class Product : IEntity
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(150)"), StringLength(150), Display(Name = "Ürün Adı")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(500)"), StringLength(500), Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Fiyatı")]
        public decimal Price { get; set; }
        [Display(Name = "Stock")]
        public int Stock { get; set; }

        [Display(Name = "İndirim")]
        public bool IsDiscount { get; set; }
        [DataType(DataType.DateTime), Display(Name = "Son Kullanma Tarihi")]
        public DateTime ExpDate { get; set; }
        [DataType(DataType.DateTime), Display(Name = "Yayınlanma Tarihi")]
        public DateTime ReleaseDate { get; set; }
        [Column(TypeName = "varchar(50)"), StringLength(50), Display(Name = "Ürün Barkodu")]
        public string Barkod { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int? SellerId { get; set; }
        public Seller Seller { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<ProductTag> ProductTags { get; set; }
        public ICollection<ProductProperty> ProductProperties { get; set; }
        public ICollection<Picture> Pictures { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
