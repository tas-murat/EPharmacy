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
    [Table("Property")]
    public class Property : IEntity
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(100)"), StringLength(100)]
        public string Name { get; set; }
        [Display(Name = "Görüntülenme Sırası")]
        public int PIndex { get; set; }
        public ICollection<ProductProperty> ProductProperties { get; set; }

    }
}
