using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOnlineOtomasyon.Models.Sınıflar
{
    public class Urun
    {
        [Key]
        public int UrunID { get; set; }

        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string UrunAd { get; set; }
        public string Marka { get; set; }
        public short Stok { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
        public bool Durum { get; set; }

        [Column(TypeName = "VarChar")]
        [StringLength(250)]
        public string UrunGorsel { get; set; }

        
        // 1'e çok ilişkideki n'e anlamına gelen yapı
        // bir kategorinin birden çok ürünü olabilir yapısını kuruyoruz
        public Kategori Kategori { get; set; }

        public SatisHareket SatisHareket { get; set; }

    }
}
