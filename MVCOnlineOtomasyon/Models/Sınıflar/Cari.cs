using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOnlineOtomasyon.Models.Sınıflar
{
    public class Cari
    {
        [Key]
        public int CariID { get; set; }
        public string CariAd { get; set; }
        public string CariSoyad { get; set; }
        public string CariSehir { get; set; }
        public string CariMail { get; set; }
    }
}
