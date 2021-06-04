using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC_ile_Ticari_Otomasyon_TEz.Models.Classs;
namespace ASP.NET_MVC_ile_Ticari_Otomasyon_TEz.Controllers
{
    public class DepartmanController : Controller
    {
        // GET: Departman
        Context e = new Context();
        public ActionResult Index()
        {
            var degerler = e.Departmans.Where(x=>x.Durum==true).ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult DepartmanEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DepartmanEkle(Departman d)
        {
            e.Departmans.Add(d);
            e.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanSil(int id)
        {
            var dep = e.Departmans.Find(id);
            dep.Durum = false;
            e.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanGetir(int id)
        {
            var dpt = e.Departmans.Find(id);
            return View("DepartmanGetir", dpt);
        }
        public ActionResult DepartmanGuncelle(Departman p)
        {
            var dept = e.Departmans.Find(p.Departmanid);
            dept.DepartmanAd = p.DepartmanAd;
            e.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanDetay(int id)
        {
            var degerler = e.Personels.Where(x => x.Departmanid == id).ToList();
            var dpt = e.Departmans.Where(x => x.Departmanid == id).Select(y => y.DepartmanAd).FirstOrDefault();
            ViewBag.d = dpt;
            return View(degerler);
        }
        public ActionResult DepartmanPersonelSatis(int id)
        {
            var degerler = e.SatisHarekets.Where(x => x.Personelid == id).ToList();
            var per = e.Personels.Where(x => x.Personelid == id).Select(y => y.PersonelAd + " " + y.PersonelSoyad).FirstOrDefault();
            ViewBag.dpers = per;
            return View(degerler);
        }
    }
}