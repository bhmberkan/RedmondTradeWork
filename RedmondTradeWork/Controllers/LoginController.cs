using RedmondTradeWork.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace RedmondTradeWork.Controllers
{
    public class LoginController : Controller
    {
        RedmondTradeDBEntities db = new RedmondTradeDBEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TblAdmin p)
        {
            var adminBilgiler = db.TblAdmin.FirstOrDefault(x => x.Name == p.Name && x.Password == p.Password && x.Rol == "admin");
            var memberBilgiler = db.TblAdmin.FirstOrDefault(x => x.Name == p.Name && x.Password == p.Password && x.Rol == "member");

            if (adminBilgiler != null)
            {
                // Admin kullanıcı bilgilerini session'a kaydet
                Session["UserName"] = adminBilgiler.Name;
                Session["UserRole"] = "admin";
                return RedirectToAction("AdminSearch", "Admin");
            }
            else if (memberBilgiler != null)
            {
                // Member kullanıcı bilgilerini session'a kaydet
                Session["UserName"] = memberBilgiler.Name;
                Session["UserRole"] = "member";
             
                return RedirectToAction("Search", "Member");
            }
            else
            {
                // Hatalı giriş durumunda login sayfasına dön
                ViewBag.ErrorMessage = "Geçersiz kullanıcı adı veya şifre.";
                return View();
            }

        }



        public ActionResult Cikis()
        {
            Session.Clear();
            return RedirectToAction("Index","Login");
        }

        public ActionResult CikisSite()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}