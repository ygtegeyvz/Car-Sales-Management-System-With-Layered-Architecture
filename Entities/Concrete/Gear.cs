using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Entities.Concrete
{
    [Table("Tbl_VitesTuru")]
    public  class Gear : IEntity
    {
        [Key]
        public int VitesTuruID { get; set; }
        public string VitesTuru { get; set; }
    }
}


  
   