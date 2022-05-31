using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOnlineOtomasyon.Models.Sınıflar
{
    public class SatisHareket
    {
        [Key]
        public int SatisID { get; set; }
        
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamTutar { get; set; }

        //ürün
        //cari
        //personel

        public ICollection<Urun> Uruns { get; set; }
        public ICollection<Cari> Caris { get; set; }
        public ICollection<Personel> Personels { get; set; }

    }
}
