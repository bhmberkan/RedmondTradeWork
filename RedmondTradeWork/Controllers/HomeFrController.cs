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
  //  [AllowAnonymous]
    public class HomeFrController : Controller
    {
        RedmondTradeDBEntities db = new RedmondTradeDBEntities();
        // GET: HomeFr
        public ActionResult Index()
        {
            var deger = db.TblMainPage.Where(x => x.ID == 3).ToList();
            return View(deger);
        }
      

        public PartialViewResult MainAbaoutUsPartialFr()
        {
            var deger = db.TblAboutUs.Where(x => x.Langueage == "Fr").ToList();
            return PartialView(deger);
        }

        public PartialViewResult MainSolutionPartnersFr()
        {
            var deger = db.TblSolution_Partners.ToList();
            return PartialView(deger);
        }

        public PartialViewResult MainServiceFr()
        {
            var deger = db.TblService.ToList();
            return PartialView(deger);
        }

        public ActionResult SurNous()
        {
            var deger = db.TblAboutUs.Where(x => x.AboutUsID == 3).ToList();

            return View(deger);
        }


        public ActionResult Service()
        {
            var deger = db.TblWork.ToList();
            return View(deger);
        }

        [HttpGet]
        public ActionResult Contact()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Contact(TblMessage t)
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

            return RedirectToAction("Contact");
        }
    }
}