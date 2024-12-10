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
            var bilgiler = db.TblAdmin.FirstOrDefault(x => x.Name == p.Name && x.Password == p.Password && x.Rol == "admin");
            var bgm = db.TblAdmin.FirstOrDefault(x => x.Name == p.Name && x.Password == p.Password && x.Rol == "member");
            if (bilgiler!=null)
            {
                return RedirectToAction("Index","Admin");
            }
            else if(bgm!=null)
            {
                return RedirectToAction("Index","Search");
            }
            else
            {
                return RedirectToAction("Index");
            }
           
        }
    }
}