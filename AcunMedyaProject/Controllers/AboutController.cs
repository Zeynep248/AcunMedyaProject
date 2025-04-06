using System;
using System.Collections.Generic;

using System.Linq;
using System.Web.Mvc;
using AcunMedyaProject.Models;

namespace AcunMedyaProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();
        public ActionResult Index()
        {

            var values = db.Tbl_About.ToList();

            return View(values);

        }
        public ActionResult DeleteAbout(int id)
        {
            var values = db.Tbl_About.Find(id);
            db.Tbl_About.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
         
        public ActionResult CreateAbout()
        {
            return View();
        }

    }
}