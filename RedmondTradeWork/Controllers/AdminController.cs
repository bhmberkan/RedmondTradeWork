﻿using RedmondTradeWork.Models.Entity;
using RedmondTradeWork.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedmondTradeWork.Controllers
{
    //  [Authorize]
    public class AdminController : BaseController
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
            return View("UpdateServicePage", deger);
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
            var values = db.TblAdmin.Where(x => x.Rol == "member").ToList();
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




        public ActionResult AdminSearch(string search)
        {

            /* using (var db = new RedmondTradeDBEntities())
             {
                 var aranacak = db.TblContainer.AsQueryable();

                 aranacak = aranacak.Where(x => x.Durum == true);
                 // Arama parametresi boş değilse filtre uygula
                 if (!string.IsNullOrEmpty(search))
                 {
                     aranacak = aranacak.Where(x => x.ContainerNo.Contains(search) ||
                                                        x.Short_Content.Contains(search) ||
                                                        x.Deportune_Port.Contains(search) ||
                                                         x.Date.ToString().Contains(search) ||
                                                        x.Kim.Contains(search));
                 }

                 return View(aranacak.ToList());

                // var values = db.TblContainer.Where(x => x.Durum == true).ToList();

                 // return View(values); 
             }*/

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





        public ActionResult AdminDeletedContainerPage()
        {
            var values = db.TblContainer.Where(x => x.Durum == false).ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult SearchDetails(int id, string srch)
        {
            /* çok güzel sorgu oldu. ıd alıp başka bir değere göre sorgulama yaptık şimdi de direkt değeri alalim.
               var contno = db.TblConteiner.Where(x => x.ID == id).Select(x => x.ContainerNo);
               var values = db.TblConteiner.Where(x => contno.Contains(x.ContainerNo)).ToList();
            return View("SearchDetails", values);*/
            /*  var values = (from x in db.TblContainerContents
                            where x.TblContainer.ID == id
                            select new ContainerDetailsViewModel
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
                                // burada date kısmını listeleyelim ama eklerken ve güncelelrken direkt pc saati alsın bence
                                // hız açısından

                            }).ToList();


              ViewBag.ContID = id;

              return View(values); */

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

        public ActionResult DeleteSearch(int id)
        {
            var values = db.TblContainer.Find(id);
            //  db.TblContainer.Remove(values);
            values.Durum = false;
            db.SaveChanges();
            return RedirectToAction("AdminSearch");
        }

        public ActionResult UnDeleteSearch(int id)
        {
            var values = db.TblContainer.Find(id);
            values.Durum = true;
            db.SaveChanges();
            return RedirectToAction("AdminSearch");
        }

        [HttpGet]
        public ActionResult InsertSearch(string selectedValue)
        {
            ViewBag.SelectedValue = selectedValue ?? "";
            ViewBag.KimList = new List<SelectListItem>
            {
             new SelectListItem { Text = "Nihat", Value = "Nihat" },
             new SelectListItem { Text = "Emin", Value = "Emin" },
             new SelectListItem { Text = "Mustafa", Value = "Mustafa" },

             new SelectListItem { Text = "Diğer", Value = "Other" }
            };



            //  ViewBag.SelectedValue = selectedValue ?? "";
            ViewBag.Deplist = new List<SelectListItem>
            {
             new SelectListItem { Text = "Sancaktepe ", Value = "Sancaktepe" },
            new SelectListItem { Text = "Gebze ", Value = "Gebze" },
            new SelectListItem { Text = "Mersin ", Value = "Mersin" },
            new SelectListItem { Text = "Aliağa ", Value = "Aliağa" },
          //   new SelectListItem { Text = "", Value = "" },

             new SelectListItem { Text = "Diğer", Value = "Other" }
            };


            return View();
        }
        [HttpPost]
        public ActionResult InsertSearch(TblContainer t)
        {
            if (!ModelState.IsValid)
            {

                ViewBag.Deplist = new List<SelectListItem>
            {
             new SelectListItem { Text = "Sancaktepe ", Value = "Sancaktepe" },
            new SelectListItem { Text = "Gebze ", Value = "Gebze" },
            new SelectListItem { Text = "Mersin ", Value = "Mersin" },
            new SelectListItem { Text = "Aliağa ", Value = "Aliağa" },
          //   new SelectListItem { Text = "", Value = "" },

             new SelectListItem { Text = "Diğer", Value = "Other" }
            };



                ViewBag.KimList = new List<SelectListItem>
        {
            new SelectListItem { Text = "Nihat", Value = "Nihat" },
            new SelectListItem { Text = "Emin", Value = "Emin" },
            new SelectListItem { Text = "Mustafa", Value = "Mustafa" },
            new SelectListItem { Text = "Diğer", Value = "Other" }
        };

                return View("InsertSearch");
            }

            if (t.Kim == "Other" && !string.IsNullOrWhiteSpace(Request.Form["Kim"]))
            {

                t.Kim = Request.Form["Kim"];
            }

            if (t.Deportune_Port == "Other" && !string.IsNullOrWhiteSpace(Request.Form["Deportune_Port"]))
            {
                t.Deportune_Port = Request.Form["Deportune_Port"];
            }


            if (!t.Date.HasValue)
            { // tarih boş geçildiyse günün tarihini ata
                t.Date = DateTime.Now;
            }

            t.Durum = true;
            db.TblContainer.Add(t);
            db.SaveChanges();
            return RedirectToAction("AdminSearch");
        }


        [HttpGet]
        public ActionResult UpdateSearchPage(int id)
        {
            var values = db.TblContainer.Find(id);
            return View("UpdateSearchPage", values);

        }
        [HttpPost]
        public ActionResult UpdateSearchPage(TblContainer t)
        {

            var value = db.TblContainer.Find(t.ID);
            value.Short_Content = t.Short_Content;
            value.ContainerNo = t.ContainerNo;
            value.Date = t.Date ?? DateTime.Now;
            value.Deportune_Port = t.Deportune_Port;
            value.Kim = t.Kim;
            db.SaveChanges();
            return RedirectToAction("AdminSearch");
        }





        public ActionResult DeleteSearchDetail(int id)
        {
            // şunu yapıyoruz.
            // silme işlemi gerçekleştiğinde linkte bulunan /{id} alanına
            // container contents alanında bulunan id numarasını atıyoruz böylece sayfada silme işlemi olsa bile hata vermeden çalışacak.
            var values = db.TblContainerContents.Find(id);
            db.TblContainerContents.Remove(values);

            int? containerID = db.TblContainerContents.
                Where(x => x.ID == id).Select(x => x.Container).FirstOrDefault();


            db.SaveChanges();
            return RedirectToAction("SearchDetails", new { id = containerID });
        }

        [HttpGet]
        public ActionResult InsertSearchDetail(int id)
        {

            //  ViewBag.SelectedValue = selectedValue ?? "";
            ViewBag.Buyerlist = new List<SelectListItem>
            {
             new SelectListItem { Text = "Sonecomx", Value = "Sonecomx" },
            new SelectListItem { Text = "Turkuaz ", Value = "Turkuaz " },
          //   new SelectListItem { Text = "", Value = "" },

             new SelectListItem { Text = "Diğer", Value = "Other" }
            };


            ViewBag.Unitlist = new List<SelectListItem>
            {
             new SelectListItem { Text = "Palet", Value = "Palet" },
            new SelectListItem { Text = "Koli", Value = "Koli" },
            new SelectListItem { Text = "M²", Value = "M²" },
            new SelectListItem { Text = "Adet", Value = "Adet" },
            new SelectListItem { Text = "Boy", Value = "Boy" },
            new SelectListItem { Text = "Bag", Value = "Bag" },
          //   new SelectListItem { Text = "", Value = "" },

             new SelectListItem { Text = "Diğer", Value = "Other" }
            };


            ViewBag.contID = id;
            return View();
        }


        [HttpPost]
        public ActionResult InsertSearchDetail(TblContainerContents t, int id)
        {
            var value = db.TblContainer.FirstOrDefault(x => x.ID == id);

            if (!ModelState.IsValid)
            {

                ViewBag.Unitlist = new List<SelectListItem>
            {
             new SelectListItem { Text = "Palet", Value = "Palet" },
            new SelectListItem { Text = "Koli", Value = "Koli" },
            new SelectListItem { Text = "M²", Value = "M²" },
            new SelectListItem { Text = "Adet", Value = "Adet" },
            new SelectListItem { Text = "Boy", Value = "Boy" },
            new SelectListItem { Text = "Bag", Value = "Bag" },
          //   new SelectListItem { Text = "", Value = "" },

             new SelectListItem { Text = "Diğer", Value = "Other" }
            };




                ViewBag.Buyerlist = new List<SelectListItem>
         {
            new SelectListItem { Text = "Sonecomx", Value = "Sonecomx" },
            new SelectListItem { Text = "Turkuaz ", Value = "Turkuaz " },
           // new SelectListItem { Text = "", Value = "" },
            new SelectListItem { Text = "Diğer", Value = "Other" }
         };

                return View("InsertSearchDetail");
            }

            if (t.BuyerCompany == "Other" && !string.IsNullOrWhiteSpace(Request.Form["BuyerCompany"]))
            {

                t.BuyerCompany = Request.Form["BuyerCompany"];

            }


            if (t.Unit == "Other" && !string.IsNullOrWhiteSpace(Request.Form["Unit"]))
            {
                t.Unit = Request.Form["Unit"];
            }

            t.Container = value.ID;
            db.TblContainerContents.Add(t);
            db.SaveChanges();
            return RedirectToAction("SearchDetails", new { id = value.ID });
        }




        [HttpGet]
        public ActionResult UpdateSearchPageDetail(int id)
        {
            var values = db.TblContainerContents.Find(id);
            return View("UpdateSearchPageDetail", values);

        }
        [HttpPost]
        public ActionResult UpdateSearchPageDetail(TblContainerContents t)
        {
            var cıd = db.TblContainerContents.Where(x => x.ID == t.ID).Select(x => x.Container).FirstOrDefault();
            var value = db.TblContainerContents.Find(t.ID);
            value.Product = t.Product;
            value.Unit = t.Unit;
            value.Quantity = t.Quantity;
            value.BuyerCompany = t.BuyerCompany;
            value.Nots = t.Nots;
            db.SaveChanges();
            return RedirectToAction("SearchDetails", new { id = cıd });
        }


        public ActionResult Settings()
        {

            var values = db.TblAdmin.Where(x => x.Rol == "admin").ToList();
            return View(values);

        }


        [HttpGet]
        public ActionResult UpdateAdminSettings(int id)
        {
            var value = db.TblAdmin.Find(id);
            return View("UpdateAdminSettings", value);
        }

        [HttpPost]
        public ActionResult UpdateAdminSettings(TblAdmin t)
        {
            var value = db.TblAdmin.Find(t.ID);
            value.Name = t.Name;
            value.Password = t.Password;
            db.SaveChanges();
            return RedirectToAction("Settings");
        }



        public ActionResult Gtip(string search)
        {
            using (var db = new RedmondTradeDBEntities())
            {
                var query = db.TblGtip.AsQueryable();

                // Arama parametresi boş değilse
                if (!string.IsNullOrEmpty(search))
                {
                    // TblContainerContents tablosunda arama yap
                    var Gıd = db.TblGtip
                                .Where(c => c.StokKod.Contains(search) || c.Gtip.Contains(search))
                                .Select(c => c.ID) // ID'leri çek
                                .ToList();

                    // TblGtip tablosunda ID'lere göre filtrele
                    query = query.Where(c => Gıd.Contains(c.ID));
                }

                return View(query.ToList());
            }

        }



        [HttpGet]
        public ActionResult InsertGtip()
        {

            return View();
        }

        [HttpPost]
        public ActionResult InsertGtip(TblGtip t)
        {
            if (!ModelState.IsValid)
            {
                return View("InsertGtip");
            }

            db.TblGtip.Add(t);
            db.SaveChanges();
            return RedirectToAction("Gtip");

        }


        [HttpGet]
        public ActionResult UpdateGtip(int id)
        {
            var value = db.TblGtip.Find(id);
            return View("UpdateGtip", value);
        }

        [HttpPost]
        public ActionResult UpdateGtip(TblGtip t)
        {
            var value = db.TblGtip.Find(t.ID);
            value.StokKod = t.StokKod;
            value.Mal_Hizmet = t.Mal_Hizmet;
            value.Miktar = t.Miktar;
            value.BirimF = t.BirimF;
            value.MalHizTut = t.MalHizTut;
            value.Gtip = t.Gtip;
            db.SaveChanges();
            return RedirectToAction("Gtip");
        }

        public ActionResult DeleteGtip(int id)
        {
            var values = db.TblGtip.Find(id);
            db.TblGtip.Remove(values);
            db.SaveChanges();

            return RedirectToAction("Gtip");

        }


        public ActionResult TaxList(string search)
        {
            using (var db = new RedmondTradeDBEntities())
            {
                var query = db.TblTax.AsQueryable();

                // Arama parametresi boş değilse
                if (!string.IsNullOrEmpty(search))
                {
                    // TblContainerContents tablosunda arama yap
                    var Tax = db.TblTax
                                .Where(c => c.ContName.Contains(search) || c.DesProd.Contains(search))
                                .Select(c => c.ID) // ID'leri çek
                                .ToList();

                    // TblGtip tablosunda ID'lere göre filtrele
                    query = query.Where(c => Tax.Contains(c.ID));
                }

                return View(query.ToList());

            }


        }


        [HttpGet]
        public ActionResult InsertTaxList()
        {

            return View();
        }

        [HttpPost]
        public ActionResult InsertTaxList(TblTax t)
        {
            if (!ModelState.IsValid)
            {
                return View("InsertTaxList");
            }

            if (!t.Date.HasValue)
            { // tarih boş geçildiyse günün tarihini ata
                t.Date = DateTime.Now;
            }


            db.TblTax.Add(t);
            db.SaveChanges();
            return RedirectToAction("TaxList");

        }


        [HttpGet]
        public ActionResult UpdateTaxList(int id)
        {
            var value = db.TblTax.Find(id);
            return View("UpdateTaxList", value);
        }

        [HttpPost]
        public ActionResult UpdateTaxList(TblTax t)
        {
            var value = db.TblTax.Find(t.ID);
            value.ContName = t.ContName;
            value.DesProd = t.DesProd;
            value.Quantity = t.Quantity;
            value.GtipHis = t.GtipHis;
            value.DD = t.DD;
            value.ContNo = t.ContNo;
            value.HC = t.HC;
            value.INVOICENO = t.INVOICENO;
            value.SGSNO = t.SGSNO;
            value.Date = t.Date ?? DateTime.Now;
            value.Vaelur = t.Vaelur;
            value.Droist = t.Droist;
            value.TotalDroist = t.TotalDroist;
            value.BizimBeyan = t.BizimBeyan;
            value.Montant = t.Montant;
            value.SG = t.SG;
            value.Import = t.Import;
            db.SaveChanges();
            return RedirectToAction("TaxList");
        }

        public ActionResult DeleteTaxList(int id)
        {
            var values = db.TblTax.Find(id);
            db.TblTax.Remove(values);
            db.SaveChanges();

            return RedirectToAction("TaxList");

        }





        public ActionResult Shipper(string search)
        {
            using (var db = new RedmondTradeDBEntities())
            {
                var query = db.TblShipper.AsQueryable();

                // Arama parametresi boş değilse
                if (!string.IsNullOrEmpty(search))
                {
                    // TblContainerContents tablosunda arama yap
                    var Gıd = db.TblShipper
                                .Where(c => c.SCompanyName.Contains(search) ||
                                c.STelefon.Contains(search) ||
                                c.SAdress.Contains(search) ||
                                c.SEmail.Contains(search) ||
                                c.STaxOfficeNumber.Contains(search)


                                )

                                .Select(c => c.ID) // ID'leri çek
                                .ToList();

                    // TblGtip tablosunda ID'lere göre filtrele
                    query = query.Where(c => Gıd.Contains(c.ID));
                }

                return View(query.ToList());
            }

        }



        [HttpGet]
        public ActionResult InsertShipper()
        {

            return View();
        }

        [HttpPost]
        public ActionResult InsertShipper(TblShipper t)
        {
            if (!ModelState.IsValid)
            {
                return View("InsertShipper");
            }

            db.TblShipper.Add(t);
            db.SaveChanges();
            return RedirectToAction("Shipper");

        }


        [HttpGet]
        public ActionResult UpdateShipper(int id)
        {
            var value = db.TblShipper.Find(id);
            return View("UpdateShipper", value);
        }

        [HttpPost]
        public ActionResult UpdateShipper(TblShipper t)
        {
            var value = db.TblShipper.Find(t.ID);
            value.SCompanyName = t.SCompanyName;
            value.SAdress = t.SAdress;
            value.STelefon = t.STelefon;
            value.SEmail = t.SEmail;
            value.STaxOfficeNumber = t.STaxOfficeNumber;

            db.SaveChanges();
            return RedirectToAction("Shipper");
        }

        public ActionResult DeleteShipper(int id)
        {
            var values = db.TblShipper.Find(id);
            db.TblShipper.Remove(values);
            db.SaveChanges();

            return RedirectToAction("Shipper");

        }



        public ActionResult Consignee(string search)
        {
            using (var db = new RedmondTradeDBEntities())
            {
                var query = db.TblConsignee.AsQueryable();

                // Arama parametresi boş değilse
                if (!string.IsNullOrEmpty(search))
                {
                    // TblContainerContents tablosunda arama yap
                    var Gıd = db.TblConsignee
                                .Where(c => c.CCompanyName.Contains(search) ||
                                c.CTelefon.Contains(search) ||
                                c.CAdress.Contains(search) ||
                                c.CEmail.Contains(search) ||
                                c.CTaxOfficeNumber.Contains(search)


                                )

                                .Select(c => c.ID) // ID'leri çek
                                .ToList();

                    // TblGtip tablosunda ID'lere göre filtrele
                    query = query.Where(c => Gıd.Contains(c.ID));
                }

                return View(query.ToList());
            }

        }



        [HttpGet]
        public ActionResult InsertConsignee()
        {

            return View();
        }

        [HttpPost]
        public ActionResult InsertConsignee(TblConsignee t)
        {
            if (!ModelState.IsValid)
            {
                return View("InsertConsignee");
            }

            db.TblConsignee.Add(t);
            db.SaveChanges();
            return RedirectToAction("Consignee");

        }


        [HttpGet]
        public ActionResult UpdateConsignee(int id)
        {
            var value = db.TblConsignee.Find(id);
            return View("UpdateConsignee", value);
        }

        [HttpPost]
        public ActionResult UpdateConsignee(TblConsignee t)
        {
            var value = db.TblConsignee.Find(t.ID);
            value.CCompanyName = t.CCompanyName;
            value.CAdress = t.CAdress;
            value.CTelefon = t.CTelefon;
            value.CEmail = t.CEmail;
            value.CTaxOfficeNumber = t.CTaxOfficeNumber;

            db.SaveChanges();
            return RedirectToAction("Consignee");
        }

        public ActionResult DeleteConsignee(int id)
        {
            var values = db.TblConsignee.Find(id);
            db.TblConsignee.Remove(values);
            db.SaveChanges();

            return RedirectToAction("Consignee");

        }




        public ActionResult Urun(string search)
        {
            using (var db = new RedmondTradeDBEntities())
            {
                var query = db.TblUrun.AsQueryable();

                // Arama parametresi boş değilse
                if (!string.IsNullOrEmpty(search))
                {
                    // TblContainerContents tablosunda arama yap
                    var Gıd = db.TblUrun
                                .Where(c => c.Description.Contains(search) ||
                                c.Quantity2.Contains(search) ||
                                c.UnitPrice.ToString().Contains(search) ||
                                c.Container.Contains(search) ||
                                c.Weight_KG.ToString().Contains(search) ||
                                c.HSCode.ToString().Contains(search)


                                )

                                .Select(c => c.ID) // ID'leri çek
                                .ToList();

                    // TblGtip tablosunda ID'lere göre filtrele
                    query = query.Where(c => Gıd.Contains(c.ID));
                }

                return View(query.ToList());
            }

        }



        [HttpGet]
        public ActionResult InsertUrun()
        {

            return View();
        }

        [HttpPost]
        public ActionResult InsertUrun(TblUrun t)
        {
            if (!ModelState.IsValid)
            {
                return View("InsertUrun");
            }
            // hesaplama işlemleri burda yapılacak önce bi yazdıralım sonra hesaplatmayı da yaparız

            // ekikler. quanty2 değeri ürünün adı olmalı.
            // ürün kg sini almalıyız.
            // adet sayısısı quantıty 1 değeri unutma
            db.TblUrun.Add(t);
            db.SaveChanges();
            return RedirectToAction("Urun");

        }


        [HttpGet]
        public ActionResult UpdateUrun(int id)
        {
            var value = db.TblUrun.Find(id);
            return View("UpdateUrun", value);
        }

        [HttpPost]
        public ActionResult UpdateUrun(TblUrun t)
        {
            var value = db.TblUrun.Find(t.ID);
            value.Description = t.Description;
          
            value.Quantity2 = t.Quantity2;
            value.UnitPrice = t.UnitPrice;
            // totalı hesaplatma olayı olmalı quantity1 * unit price = total 
            value.Container= t.Container;
            value.Weight_KG = t.Weight_KG; // bu da paletse ona göre çarpım falan yapmalı 
            value.HSCode = t.HSCode;

            db.SaveChanges();
            return RedirectToAction("Urun");
        }

        public ActionResult DeleteUrun(int id)
        {
            var values = db.TblUrun.Find(id);
            db.TblUrun.Remove(values);
            db.SaveChanges();

            return RedirectToAction("Urun");

        }


      

        [HttpGet]
        public ActionResult Proforma()
        {


            // consignee için olan kısım
            ViewBag.CCompanylist = db.TblConsignee.Select(x => new SelectListItem
            {
                Text = x.CCompanyName,
                Value = x.CCompanyName
            }).ToList();

            ViewBag.CAdreslist = db.TblConsignee.Select(x => new SelectListItem
            {
                Text = x.CAdress,
                Value = x.CAdress
            }).ToList();

            ViewBag.CTelList = db.TblConsignee.Select(x => new SelectListItem
            {
                Text = x.CTelefon,
                Value = x.CTelefon
            }).ToList();


            ViewBag.CEmaillist = db.TblConsignee.Select(x => new SelectListItem
            {
                Text = x.CEmail,
                Value = x.CEmail
            }).ToList();

            ViewBag.CtaxOfficeList = db.TblConsignee.Select(x => new SelectListItem
            {
                Text = x.CTaxOfficeNumber,
                Value = x.CTaxOfficeNumber
            }).ToList();


            // Shipper için olan kısım
            ViewBag.SCompanylist = db.TblShipper.Select(x => new SelectListItem
            {
                Text = x.SCompanyName,
                Value = x.SCompanyName
            }).ToList();

            ViewBag.SAdreslist = db.TblShipper.Select(x => new SelectListItem
            {
                Text = x.SAdress,
                Value = x.SAdress
            }).ToList();

            ViewBag.STelList = db.TblShipper.Select(x => new SelectListItem
            {
                Text = x.STelefon,
                Value = x.STelefon
            }).ToList();


            ViewBag.SEmaillist = db.TblShipper.Select(x => new SelectListItem
            {
                Text = x.SEmail,
                Value = x.SEmail
            }).ToList();

            ViewBag.StaxOfficeList = db.TblShipper.Select(x => new SelectListItem
            {
                Text = x.STaxOfficeNumber,
                Value = x.STaxOfficeNumber
            }).ToList();





            // ürünler için olan kısım
            ViewBag.UrunList = db.TblUrun.Select(x => new SelectListItem
            {
                Text = x.Quantity2, // ürünün kendisi
                Value = x.Quantity2
            }).ToList();

            ViewBag.DescriptionList = db.TblUrun.Select(x => new SelectListItem
            {
                Text = x.Description,
                Value = x.Description
            }).ToList();

            ViewBag.UnitpriceList = db.TblUrun.Select(x => new SelectListItem
            {
                Text = x.UnitPrice.ToString(),
                Value = x.UnitPrice.ToString()
            }).ToList();

            ViewBag.ContainerList = db.TblUrun.Select(x => new SelectListItem
            {
                Text = x.Container,
                Value = x.Container
            }).ToList();

            ViewBag.WeightList = db.TblUrun.Select(x => new SelectListItem
            {
                Text = x.Weight_KG.ToString(),
                Value = x.Weight_KG.ToString()
            }).ToList();

            ViewBag.HsList = db.TblUrun.Select(x => new SelectListItem
            {
                Text = x.HSCode.ToString(),
                Value = x.HSCode.ToString()
            }).ToList();



            return View();
        }

        [HttpPost]
        public ActionResult Proforma(Tblortakproforma t)
        {

            t.TotalPrice = t.Quantity1 * t.UnitPrice;
            t.NetWeightKG = t.Quantity1 * t.WeightKG;

            db.Tblortakproforma.Add(t);
            db.SaveChanges();
            return RedirectToAction("AdminSearch");
        }



        public ActionResult Proformlist()
        {
            var values = db.Tblortakproforma.ToList();
            return View(values);
        }






        public ActionResult deneme()
        {

            // consignee için olan kısım
            ViewBag.CCompanylist = db.TblConsignee.Select(x => new SelectListItem
            {
                Text = x.CCompanyName,
                Value = x.CCompanyName
            }).ToList();

            ViewBag.CAdreslist = db.TblConsignee.Select(x => new SelectListItem
            {
                Text = x.CAdress,
                Value = x.CAdress
            }).ToList();

            ViewBag.CTelList = db.TblConsignee.Select(x => new SelectListItem
            {
                Text = x.CTelefon,
                Value = x.CTelefon
            }).ToList();


            ViewBag.CEmaillist = db.TblConsignee.Select(x => new SelectListItem
            {
                Text = x.CEmail,
                Value = x.CEmail
            }).ToList();

            ViewBag.CtaxOfficeList = db.TblConsignee.Select(x => new SelectListItem
            {
                Text = x.CTaxOfficeNumber,
                Value = x.CTaxOfficeNumber
            }).ToList();


            // Shipper için olan kısım
            ViewBag.SCompanylist = db.TblShipper.Select(x => new SelectListItem
            {
                Text = x.SCompanyName,
                Value = x.SCompanyName
            }).ToList();

            ViewBag.SAdreslist = db.TblShipper.Select(x => new SelectListItem
            {
                Text = x.SAdress,
                Value = x.SAdress
            }).ToList();

            ViewBag.STelList = db.TblShipper.Select(x => new SelectListItem
            {
                Text = x.STelefon,
                Value = x.STelefon
            }).ToList();


            ViewBag.SEmaillist = db.TblShipper.Select(x => new SelectListItem
            {
                Text = x.SEmail,
                Value = x.SEmail
            }).ToList();

            ViewBag.StaxOfficeList = db.TblShipper.Select(x => new SelectListItem
            {
                Text = x.STaxOfficeNumber,
                Value = x.STaxOfficeNumber
            }).ToList();





            // ürünler için olan kısım
            ViewBag.UrunList = db.TblUrun.Select(x => new SelectListItem
            {
                Text = x.Quantity2, // ürünün kendisi
                Value = x.Quantity2
            }).ToList();

            ViewBag.DescriptionList = db.TblUrun.Select(x => new SelectListItem
            {
                Text = x.Description,
                Value = x.Description
            }).ToList();

            ViewBag.UnitpriceList = db.TblUrun.Select(x => new SelectListItem
            {
                Text = x.UnitPrice.ToString(),
                Value = x.UnitPrice.ToString()
            }).ToList();

            ViewBag.ContainerList = db.TblUrun.Select(x => new SelectListItem
            {
                Text = x.Container,
                Value = x.Container
            }).ToList();

            ViewBag.WeightList = db.TblUrun.Select(x => new SelectListItem
            {
                Text = x.Weight_KG.ToString(),
                Value = x.Weight_KG.ToString()
            }).ToList();

            ViewBag.HsList = db.TblUrun.Select(x => new SelectListItem
            {
                Text = x.HSCode.ToString(),
                Value = x.HSCode.ToString()
            }).ToList();

            return View();
        }


        public ActionResult Deneme2()
        {
            return View();
        }




        public ActionResult Finalİnvoice()
        {
            return View();
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


        public PartialViewResult SideBarPartialMember()
        {
            return PartialView();
        }
    }
}