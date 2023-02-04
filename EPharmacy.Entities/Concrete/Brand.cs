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
    [Table("Brand")]
    public class Brand : IEntity
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(100)"), StringLength(100), Display(Name = "Marka")]
        public string Name { get; set; }
        [Display(Name = "Görüntülenme Sırası")]
        public int PIndex { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
