using RedmondTradeWork.Models.Entity;
using RedmondTradeWork.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedmondTradeWork.Controllers
{
    public class MemberController : BaseController
    {
        RedmondTradeDBEntities db = new RedmondTradeDBEntities();
        // GET: Member
        public ActionResult Search(string search)
        {
            if (Session["UserRole"].ToString() != "admin")
            {
                Session["UserRole"] = "member";
            }

            using (var db = new RedmondTradeDBEntities())
            {
                var query = db.TblContainer.AsQueryable();

                // Arama parametresi boş değilse
                if (!string.IsNullOrEmpty(search))
                {
                    // TblContainerContents tablosunda arama yap
                    var containerIds = db.TblContainerContents
                                         .Where(c => c.Product.Contains(search) ||
                                         c.TblContainer.Date.ToString().Contains(search) ||
                                         c.TblContainer.Short_Content.Contains(search) ||
                                         c.TblContainer.ContainerNo.Contains(search) ||
                                         c.TblContainer.Deportune_Port.Contains(search) ||
                                         c.TblContainer.Kim.Contains(search)

                                         ) // Burada Content alanında arama yapıyorsunuz
                                         .Select(c => c.Container)            // ContainerID'leri çek
                                         .ToList();

                    // TblContainer'da ContainerID'lerine göre filtrele
                    query = query.Where(x => x.Durum == true && containerIds.Contains(x.ID));
                }
                else
                {
                    query = query.Where(x => x.Durum == true).OrderByDescending(x => x.ID);
                }




                return View(query.ToList());
            }
        }



        [HttpGet]
        public ActionResult SearchDetails(int id, string srch)
        {
            if (Session["UserRole"].ToString() != "admin")
            {
                Session["UserRole"] = "member";
            }

            var query = db.TblContainerContents.Where(x => x.TblContainer.ID == id);

            // Eğer arama terimi boş değilse, sorguyu filtrele
            if (!string.IsNullOrEmpty(srch))
            {
                query = query.Where(x =>
                    x.Unit.Contains(srch) ||
                    x.Quantity.ToString().Contains(srch) ||
                    x.TblContainer.Deportune_Port.Contains(srch) ||

                    x.Product.Contains(srch) ||
                    x.Nots.Contains(srch) ||
                    x.BuyerCompany.Contains(srch)); // Burada arama yapılacak sütunları belirtiyoruz
            }

            var values = query.Select(x => new ContainerDetailsViewModel
            {
                ID = x.ID,
                ContainerNo = x.TblContainer.ContainerNo,
                Product = x.Product,
                Unit = x.Unit,
                Quantity = x.Quantity,
                BuyerCompany = x.BuyerCompany,
                Date = x.TblContainer.Date,
                DeportunePort = x.TblContainer.Deportune_Port,
                Nots = x.Nots
            }).ToList();

            ViewBag.ContID = id;
            // Arama terimini View'a geri göndermek için

            return View(values);



        }


    }
}