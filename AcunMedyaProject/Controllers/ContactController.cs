using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject.Models;
namespace AcunMedyaProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();
        public ActionResult Index()
        {
            var values = db.Tbl_Contact.ToList();
            return View(values);
        }
        public ActionResult DeleteContact(int id)
        {
            var values = db.Tbl_Contact.Find(id);
            db.Tbl_Contact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CreateContact()
        {
            return View();
        }
    }
}