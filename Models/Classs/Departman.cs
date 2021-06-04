using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_ile_Ticari_Otomasyon_TEz.Models.Classs
{
    public class Departman
    {
        [Key]
        public int Departmanid { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string DepartmanAd { get; set; }
        public bool Durum { get; set; }
        public ICollection<Personel> Personels { get; set; }


    }
}