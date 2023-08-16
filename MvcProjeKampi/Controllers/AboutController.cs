using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AboutController : Controller
    {
        // AboutManager sınıfının örneği, EfAboutDal sınıfını kullanarak oluşturulur.
        AboutManager abm = new AboutManager(new EfAboutDal());

        // Hakkında sayfasının ana görünümü.
        public ActionResult Index()
        {
            // Tüm hakkında bilgilerini alır ve görünüme gönderir.
            var aboutvalues = abm.GetList();
            return View(aboutvalues);
        }

        // Hakkında ekleme sayfasının görünümü (HTTP GET).
        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }

        // Hakkında ekleme sayfasından veri alarak hakkında bilgisi ekler (HTTP POST).
        [HttpPost]
        public ActionResult AddAbout(About p)
        {
            abm.AboutAdd(p);
            return RedirectToAction("Index");
        }

        // Kısmi görünüm olarak hakkında bilgilerini içeren bir PartialViewResult döndürür.
        public PartialViewResult AboutPartial()
        {
            return PartialView();
        }
    }
}
