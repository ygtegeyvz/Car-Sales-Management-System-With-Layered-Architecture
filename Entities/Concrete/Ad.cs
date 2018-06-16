using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Table("Tbl_Ilan")]
    public class Ad:IEntity
    {
        [Key]
        public int IlanID { get; set; }
        public string Ilan_Adi { get; set; }
        public decimal Ilan_Km { get; set; }
        public decimal Ilan_Fiyat { get; set; }
        public System.DateTime Ilan_Tarih { get; set; }
        public int Ilan_SehirID { get; set; }
        public int Ilan_ArabaID { get; set; }
    }
}
