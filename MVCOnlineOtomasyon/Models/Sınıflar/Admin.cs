using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOnlineOtomasyon.Models.Sınıflar
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string KullaniciAd { get; set; }
        public string Sifre { get; set; }
        public string Yetki { get; set; }
    }
}
