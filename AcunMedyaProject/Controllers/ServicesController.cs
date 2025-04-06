using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject.Models;

namespace AcunMedyaProject.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();

        public ActionResult Index()
        {
            var values = db.Tbl_Services.ToList();

            return View(values);

        }
        public ActionResult DeleteServices(int id)
        {
            var values = db.Tbl_Services.Find(id);
            db.Tbl_Services.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CreateServices()
        {
            return View();
        }
    }
}