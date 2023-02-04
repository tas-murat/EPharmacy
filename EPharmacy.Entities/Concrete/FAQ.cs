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
    [Table("FAQ")]
    public class FAQ : IEntity
    {
        public int Id { get; set; }

        [StringLength(180), Column(TypeName = "varchar(180)")]
        public string Question { get; set; }
        [Column(TypeName = "text")]
        public string Answer { get; set; }
        [Display(Name = "Görüntülenme Sırası")]
        public int PIndex { get; set; }
        public int FAQCategoryId { get; set; }
        public virtual FAQCategory FAQCategory { get; set; }

    }
}
