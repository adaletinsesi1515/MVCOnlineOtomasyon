using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOnlineOtomasyon.Models.Sınıflar
{
    public class Departman
    {
        [Key]
        public int DepartmanID { get; set; }
        public string DepartmanAd { get; set; }
    }
}
