using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows;
using ASP.NET_MVC_ile_Ticari_Otomasyon_TEz.Controllers;
using ASP.NET_MVC_ile_Ticari_Otomasyon_TEz.Models.Classs;

namespace ASP.NET_MVC_ile_Ticari_Otomasyon_TEz.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Uruns.Where(x => x.Durum == true).ToList();
            return View(deger);
            
        }
        [HttpGet]
        public ActionResult YeniUrun()
        {
            List<SelectListItem> deger1 = (from x in c.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.KategoriAd,
                                               Value = x.KategoriID.ToString()

                                           }).ToList();
            ViewBag.dgr1 = deger1;
            return View();
        }
        [HttpPost]
        public ActionResult YeniUrun(Urun p)
        {
            c.Uruns.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunSil(int id)
        {
            var dgr = c.Uruns.Find(id);
            dgr.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.KategoriAd,
                                               Value = x.KategoriID.ToString()

                                           }).ToList();
            ViewBag.dgr1 = deger1;
            var urundeger = c.Uruns.Find(id);

            return View("UrunGetir",urundeger);
        }
        public ActionResult UrunGuncelle(Urun p)
        {
            var urn = c.Uruns.Find(p.Urunid);
            
            if(p.AlisFiyat<0)
            {
                //urn.HataMesaj = "Negatif Değer Girilmez";
                //TempData["testmsg"] = "<script>alert('AMAVCISI3162 ');</script>";
                MessageBox.Show("Negatif Değer Girilemez");
               
            }
            else 
            {
                urn.AlisFiyat = p.AlisFiyat;
                urn.Durum = p.Durum;
                urn.Kategoriid = p.Kategoriid;
                urn.Marka = p.Marka;
                urn.SatisFİyat = p.SatisFİyat;
                urn.Stok = p.Stok;
                urn.UrunAd = p.UrunAd;
                urn.UrunGorsel = p.UrunGorsel;
                c.SaveChanges();
            }
            

            return RedirectToAction("Index");
        }
        public ActionResult UrunListele()
        {
            var degerler = c.Uruns.ToList();
            return View(degerler);
        }
        
    }
}