using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_ile_Ticari_Otomasyon_TEz.Models.Classs
{
    public class Faturalar
    {
        [Key]
        public int Faturaid { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string FaturaSeriNo { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string FaturaSıraNo { get; set; }
        public DateTime Tarih { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(80)]
        public string VergiDairesi { get; set; }
        [Column(TypeName = "char")]
        [StringLength(5)]
        public String Saat { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(25)]
        public string TeslimEden { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(25)]
        public string TeslimAlan { get; set; }
        public decimal Toplam { get; set; }
        public ICollection<FaturaKalem> FaturaKalems { get; set; }
    }
}