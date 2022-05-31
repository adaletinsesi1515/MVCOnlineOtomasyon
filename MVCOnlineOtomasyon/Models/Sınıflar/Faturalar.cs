using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOnlineOtomasyon.Models.Sınıflar
{
    public class Faturalar
    {
        [Key]
        public int FaturaID { get; set; }
        public string FaturaSeriNo { get; set; }
        public string FaturaSiraNo { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime Saat { get; set; }
        public string VergiDairesi { get; set; }
        public string TeslimEden { get; set; }
        public string TeslimAlan { get; set; }



    }
}
