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
    [Table("Contacte")]
    public class Contacte : IEntity
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)"), StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "varchar(50)"), StringLength(50)]
        public string Email { get; set; }
        [Column(TypeName = "varchar(50)"), StringLength(50)]
        public string Phone { get; set; }
        [Column(TypeName = "varchar(200)"), StringLength(200)]
        public string Subject { get; set; }
        [Column(TypeName = "text")]
        public string Message { get; set; }
        [Column(TypeName = "varchar(200)"), StringLength(200)]
        public string File { get; set; }

    }
}
