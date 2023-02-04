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
    [Table("FAQCategory")]
    public class FAQCategory : IEntity
    {
        public int Id { get; set; }

        [StringLength(100), Column(TypeName = "varchar(100)")]
        public string Name { get; set; }
        public virtual ICollection<FAQ> FAQs { get; set; }

    }
}
