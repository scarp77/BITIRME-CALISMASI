using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_ile_Ticari_Otomasyon_TEz.Models.Classs
{
    public class Cariler
    {
        [Key]
        public int Cariid { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20,ErrorMessage ="En fazla 20 karakter yazabilirsiniz!!")]
        public string CariAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(25)]
        [Required(ErrorMessage ="Boş Bırakılamaz!!!")]
        public string CariSoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CariSehir { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string CariMail { get; set; }
        public bool Durum { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}