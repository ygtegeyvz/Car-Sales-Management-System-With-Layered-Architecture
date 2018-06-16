using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Table("Tbl_Sehir")]
  public  class City :IEntity
    {
        [Key]
        public int SehirID { get; set; }
        public string Sehir { get; set; }
    }
}
