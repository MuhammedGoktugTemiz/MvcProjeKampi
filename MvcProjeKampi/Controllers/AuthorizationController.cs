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
    public class AuthorizationController : Controller
    {
        // AdminManager sınıfının örneği, EfAdminDal sınıfını kullanarak oluşturulur.
        AdminManager adm = new AdminManager(new EfAdminDal());

        // Yetkilendirme (authorization) sayfasının ana görünümü.
        public ActionResult Index()
        {
            // Tüm yönetici bilgilerini alır ve görünüme gönderir.
            var adminvalues = adm.GetAdminList();
            return View(adminvalues);
        }

        // Yeni yönetici ekleme sayfasının görünümü (HTTP GET).
        [HttpGet]
        public ActionResult AddAdmin()
        {
            // Yönetici rollerini alır ve SelectListItem listesine dönüştürür.
            List<SelectListItem> valuecategory = (from x in adm.GetAdminList()
                                                  select new SelectListItem { Text = x.AdminRole, Value = x.AdminID.ToString() }).ToList();
            ViewBag.adm = valuecategory;
            return View();
        }

        // Yeni yönetici eklemek için veri alır (HTTP POST).
        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            adm.AdminAdd(p);
            return RedirectToAction("Index");
        }

        // Belirli bir yönetici ID'sine sahip yöneticiyi düzenleme sayfasının görünümü (HTTP GET).
        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            var adminvalue = adm.GetByID(id);
            return View(adminvalue);
        }

        // Düzenlenmiş yönetici bilgisiyle yöneticiyi günceller (HTTP POST).
        [HttpPost]
        public ActionResult EditAdmin(Admin p)
        {
            adm.AdminUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
