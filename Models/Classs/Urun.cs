using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_ile_Ticari_Otomasyon_TEz.Models.Classs
{
    public class Urun
    {
        [Key]
        public int Urunid { get; set; }
        [Column(TypeName = "Varchar")]

        [StringLength(25, ErrorMessage = "En fazla 30 karakter yazabilirsiniz!!")]
        public string UrunAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(25)]
        public string Marka { get; set; }
        public short Stok { get; set; }
       
        //public string HataMesaj { get; set; }
        public decimal AlisFiyat {get; set;}
        public decimal SatisFİyat { get; set; }
        public bool Durum { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string UrunGorsel { get; set; }
        public int Kategoriid { get; set; }
        public virtual Kategori Kategori { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }


    }
}