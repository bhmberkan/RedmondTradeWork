using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Data.Entity;
using RedmondTradeWork.Models.Entity;


namespace RedmondTradeWork.Controllers
{
    public class HomeController : Controller
    {
        RedmondTradeDBEntities db = new RedmondTradeDBEntities();
        public ActionResult Index()
        {
            var deger = db.TblMainPage.ToList();
            return View(deger);
        }

        public PartialViewResult MainAbaoutUsPartial()
        {
            var deger = db.TblAboutUs.ToList();
            return PartialView(deger);
        }

        public PartialViewResult MainSolutionPartners()
        {
            var deger = db.TblWork.ToList();
            return PartialView(deger);
        }

        public PartialViewResult MainService()
        {
            var deger = db.TblService.ToList();
            return PartialView(deger);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}