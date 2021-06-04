﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_ile_Ticari_Otomasyon_TEz.Models.Classs
{
    public class Giderler
    {
        [Key]
        public int Giderid { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Tutar { get; set; }
    }
}