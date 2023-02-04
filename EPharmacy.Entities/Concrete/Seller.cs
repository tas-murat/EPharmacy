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
    [Table("Seller")]
    public class Seller : IEntity
    {
        public int ID { get; set; }
        [StringLength(13, ErrorMessage = "GLN Numarası 13 karekterden fazla olamaz"), Column(TypeName = "Varchar(13)"), Display(Name = "GLN Numarası"), Required(ErrorMessage = "Gln Numarası boş geçilemez.")]
        public string GLNNumber { get; set; }
        [StringLength(50), Column(TypeName = "Varchar(50)"), Display(Name = "Yetkili Adı"), Required(ErrorMessage = "Ad boş geçilemez.")]
        public string Name { get; set; }
        [StringLength(50), Column(TypeName = "Varchar(50)"), Display(Name = "Yetkili Soyadı"), Required(ErrorMessage = "Soyad boş geçilemez.")]
        public string Surname { get; set; }
        [Column(TypeName = "varchar(100)"), StringLength(100), Display(Name = "Pharmacy Adı")]
        public string PharmacyName { get; set; }
        [Column(TypeName = "varchar"), StringLength(40), Display(Name = "Mail Adresi")]
        public string Email { get; set; }
        [Column(TypeName = "varchar(20)"), StringLength(20), Display(Name = "Telefon Numarası")]
        public string Phone { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
