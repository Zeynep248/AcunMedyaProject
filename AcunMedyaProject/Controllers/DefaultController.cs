using AcunMedyaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();

        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialTestimonial()
        {
            var values = db.Tbl_Testimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialServices()
        {
            var deger = db.Tbl_Services.ToList();
            return PartialView(deger);
        }
        public PartialViewResult PartialContact()
        {
            var values = db.Tbl_Contact.ToList();
            return PartialView(values);
        }
        public ActionResult PartialMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult PartialMessage(Tbl_Message message)
        {
            db.Tbl_Message.Add(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.Tbl_Skill.ToList();
            return PartialView();

        }
    }
}
