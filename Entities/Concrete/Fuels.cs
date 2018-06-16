using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Table("Tbl_YakitTuru")]
    public class Fuels : IEntity
    {
        [Key]
        public int YakitTuruID { get; set; }
        public string YakitTuru { get; set; }

    }
}
