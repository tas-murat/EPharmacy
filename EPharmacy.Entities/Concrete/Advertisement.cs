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
    [Table("Advertisement")]
    public class Advertisement : IEntity
    {
        public int Id { get; set; }

        [StringLength(150), Column(TypeName = "varchar(150)"), Display(Name = "Reklam Adı")]
        public string Name { get; set; }

        [StringLength(150), Column(TypeName = "varchar(150)"), Display(Name = "Resim Dosyası")]
        public string FPath { get; set; }

        [StringLength(150), Column(TypeName = "varchar(150)"), Display(Name = "Reklam Linki")]
        public string Link { get; set; }

        [Display(Name = "Görüntülenme Sırası")]
        public int PIndex { get; set; }

    }
}
