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
    [Table("Tbl_Renk")]
    public class Color : IEntity
    {
        [Key]
        public int RenkID { get; set; }
        public string Renk { get; set; }

    }
}

