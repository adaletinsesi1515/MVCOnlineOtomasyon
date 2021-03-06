using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOnlineOtomasyon.Models.Sınıflar
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }

        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string PersonelAd { get; set; }

        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string PersonelSoyad { get; set; }

        [Column(TypeName = "VarChar")]
        [StringLength(250)]
        public string PersonelGorsel { get; set; }

        public SatisHareket SatisHareket { get; set; }

        public Departman Departman { get; set; }
    }
}
