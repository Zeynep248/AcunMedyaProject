using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject.Models;
namespace AcunMedyaProject.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();

        public ActionResult Index()
        {
            var values = db.Tbl_Education.ToList();
            return View(values);
        }
        public ActionResult DeleteEducation(int id)
        {
            var values = db.Tbl_Education.Find(id);
            db.Tbl_Education.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CreateEducation()
        {
            return View();

        }

    }
}