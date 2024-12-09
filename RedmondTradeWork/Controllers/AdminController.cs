using RedmondTradeWork.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedmondTradeWork.Controllers
{
    public class AdminController : Controller
    {
        RedmondTradeDBEntities db = new RedmondTradeDBEntities();
        // GET: Admin
        public ActionResult Index()
        {
            var deger = db.TblMainPage.ToList();
            return View(deger); 
        }



        [HttpGet]
        public ActionResult UpdateMainpage(int id)
        {
            var deger = db.TblMainPage.Find(id);
            return View("UpdateMainpage", deger);
        }

        [HttpPost]
        public ActionResult UpdateMainpages(TblMainPage t)
        {
            var main = db.TblMainPage.Find(t.ID);
            main.Title = t.Title;
            main.Description = t.Description;
            main.Photo1 = t.Photo1;
            main.İmage2 = t.İmage2;
            main.image3 = t.image3;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult AdminAbout()
        {
            var deger = db.TblAboutUs.ToList();
            return View(deger);
        }


        [HttpGet]
        public ActionResult UpdateAboutpage(int id)
        {
            var deger = db.TblAboutUs.Find(id);
            return View("UpdateAboutpage", deger);
        }

        [HttpPost]
        public ActionResult UpdateAboutpages(TblAboutUs t)
        {
            var about = db.TblAboutUs.Find(t.AboutUsID);
            about.Title = t.Title;
            about.Description = t.Description;
            about.SubHeadingTitle = t.SubHeadingTitle;
            about.SubHeading = t.SubHeading;
            about.Photo = t.Photo;
            about.Photo2 = t.Photo2;
            db.SaveChanges();
            return RedirectToAction("AdminAbout");

        }

        public ActionResult AdminSolutionPartners()
        {

            var deger = db.TblSolution_Partners.ToList();
            return View(deger);
        }


        [HttpGet]
        public ActionResult UpdateSolutionPage(int id)
        {
            var deger = db.TblSolution_Partners.Find(id);
            return View("UpdateSolutionPage", deger);
        }

        [HttpPost]
        public ActionResult UpdateSolutionPages(TblSolution_Partners t)
        {
            var spartner = db.TblSolution_Partners.Find(t.SolutionPartnersID);
            spartner.Title = t.Title;
            spartner.Description = t.Description;
            spartner.Description_En = t.Description_En;
            spartner.Description_Fr = t.Description_Fr;
            db.SaveChanges();
            return RedirectToAction("AdminSolutionPartners");
        }


        public ActionResult AdminWork()
        {
            var deger = db.TblWork.ToList();
            return View(deger);
        }

        [HttpGet]
        public ActionResult UpdateWorkPage(int id)
        {
            var deger = db.TblWork.Find(id);
            return View("UpdateWorkPage", deger);
        }
        [HttpPost]
        public ActionResult UpdateWorkPages(TblWork t)
        {
            var twork = db.TblWork.Find(t.WorkID);
            twork.Title = t.Title;
            twork.Title_En = t.Title_En;
            twork.Title_Fr = t.Title_Fr;
            twork.Description = t.Description;
            twork.Description_En = t.Description_En;
            twork.Description_Fr = t.Description_Fr;
            twork.Photo = t.Photo;
            db.SaveChanges();
            return RedirectToAction("AdminWork");
        }


        public ActionResult DeleteWork(int id)
        {
            var work = db.TblWork.Find(id);
            db.TblWork.Remove(work);
            db.SaveChanges();
            return RedirectToAction("AdminWork");
        }


        [HttpGet]
        public ActionResult InsertWork()
        {
            return View();
        }


        [HttpPost]
        public ActionResult InsertWork(TblWork t)
        {
            if (!ModelState.IsValid)
            {
                return View("InsertWork");
            }

            db.TblWork.Add(t);
            db.SaveChanges();
            return RedirectToAction("AdminWork");
        }


        public ActionResult AdminService()
        {
            var deger = db.TblService.ToList();
            return View(deger);
        }



        [HttpGet]
        public ActionResult UpdateServicePage(int id)
        {
            var deger = db.TblService.Find(id);
            return View("UpdateServicePage",deger);
        }

        [HttpPost]
        public ActionResult UpdateServicePages(TblService t)
        {
            var ServiceT = db.TblService.Find(t.ServiceID);
            ServiceT.Title = t.Title;
            ServiceT.Title_En = t.Title_En;
            ServiceT.Title_Fr = t.Title_Fr;
            ServiceT.Description = t.Description;
            ServiceT.Description_En = t.Description_En;
            ServiceT.Description_Fr = t.Description_Fr;
            ServiceT.İmage = t.İmage;
            ServiceT.ServiceIcon = t.ServiceIcon;
            db.SaveChanges();
            return RedirectToAction("AdminService");
        }


        public ActionResult DeleteService(int id)
        {
            var deger = db.TblService.Find(id);
            db.TblService.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("AdminService");
        }




        [HttpGet]
        public ActionResult InsertService()
        {
            return View();
        }


        [HttpPost]
        public ActionResult InsertService(TblService t)
        {
            if (!ModelState.IsValid)
            {
                return View("InsertService");
            }

            db.TblService.Add(t);
            db.SaveChanges();
            return RedirectToAction("AdminService");
        }





        public ActionResult AdminMessage()
        {
            var deger = db.TblMessage.ToList();
            return View(deger);
        }




        [HttpGet]
        public ActionResult AdminMessageDetailt(int id)
        {
            var deger = db.TblMessage.Find(id);
            return View(deger);
        }

        public ActionResult AdminMessageDelete(int id)
        {
            var deger = db.TblMessage.Find(id);
            db.TblMessage.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("AdminMessage");
           
        }

        public ActionResult AdminRole()
        {
            var values = db.TblAdmin.Where(x=>x.Rol=="member").ToList();
            return View(values);
        }


        [HttpGet]
        public ActionResult UpdateRole(int id)
        {
            var value = db.TblAdmin.Find(id);
            return View("UpdateRole", value);
        }
        
        [HttpPost]
        public ActionResult UpdateRoles(TblAdmin t)
        {
            var value = db.TblAdmin.Find(t.ID);
            value.Name = t.Name;
            value.Password = t.Password;
            db.SaveChanges();
            return RedirectToAction("AdminRole");
        }

        public ActionResult DeleteRole(int id)
        {
            var values = db.TblAdmin.Find(id);
            db.TblAdmin.Remove(values);
            db.SaveChanges();
            return RedirectToAction("AdminRole");
        }


        [HttpGet]
        public ActionResult InsertRole()
        {
            return View();
        }


        [HttpPost]
        public ActionResult InsertRole(TblAdmin t)
        {
            if (!ModelState.IsValid)
            {
                return View("InsertRole");
            }
            t.Rol = "member";
            db.TblAdmin.Add(t);
            db.SaveChanges();
            return RedirectToAction("AdminRole");
        }

















        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavHeaderPartial()
        {
            return PartialView();


        }

        public PartialViewResult PreloaderPartial()
        {
            return PartialView();
        }


        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }


        public PartialViewResult SideBarPartial()
        {
            return PartialView();
        }
    }
}