using MailKit.Net.Smtp;
using MimeKit;
using RedmondTradeWork.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedmondTradeWork.Controllers
{
    public class HomeTrController : Controller
    {
        RedmondTradeDBEntities db = new RedmondTradeDBEntities();
        // GET: HomeEn
        public ActionResult Index()
        {
            var deger = db.TblMainPage.Where(x => x.ID == 1).ToList();
            return View(deger);
            
        }

        public PartialViewResult MainAbaoutUsPartialTr()
        {
            var deger = db.TblAboutUs.Where(x => x.Langueage == "Tr").ToList();
            return PartialView(deger);
        }

        public PartialViewResult MainSolutionPartnersTr()
        {
            var deger = db.TblSolution_Partners.ToList();
            return PartialView(deger);
        }

        public PartialViewResult MainServiceTr()
        {
            var deger = db.TblService.ToList();
            return PartialView(deger);
        }

        public ActionResult Hakkımızda()
        {
            var deger = db.TblAboutUs.Where(x => x.AboutUsID == 1).ToList();

            return View(deger);
        }


        public ActionResult Servisler()
        {
            var deger = db.TblWork.ToList();
            return View(deger);
        }

        [HttpGet]
        public ActionResult İletişim()
        {


            return View();
        }

        [HttpPost]
        public ActionResult İletişim(TblMessage t)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddress = new MailboxAddress(t.Name, t.Email);
            mimeMessage.From.Add(mailboxAddress); // mesaj kimden 

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", "berkanburakturgut@gmail.com" /* kime */);
            mimeMessage.To.Add(mailboxAddressTo); // mesaj kime 

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = t.Message + " \n \nSender : " + t.Email; // mesajın içerik ne 
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = t.Title;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false); // 587 port numarası , ssl gereksin mi = fasle istersen true yaparsın
            client.Authenticate("berkanburakturgut@gmail.com", "fwsdhhdhrzzhgqmq");
            client.Send(mimeMessage);
            client.Disconnect(true);



            //t.Email = "admin@gmail.com";
            //t.Name= "admin";
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());


            db.TblMessage.Add(t);
            db.SaveChanges();

            return RedirectToAction("İletişim");
        }

    }
}