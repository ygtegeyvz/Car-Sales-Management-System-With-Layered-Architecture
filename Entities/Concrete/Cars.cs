using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Table("Tbl_araba")]
    public class Cars:IEntity
    {
        [Key]
        public int ArabaID { get; set; }
        public string Araba_Marka { get; set; }
        public string Araba_Model { get; set; }
        public int Araba_VitesTuruID { get; set; }
        public int Araba_YakitTuruID { get; set; }
        public int Araba_RenkID { get; set; }
    }
}
