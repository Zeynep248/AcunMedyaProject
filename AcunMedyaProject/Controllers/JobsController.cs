using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject.Models;


namespace AcunMedyaProject.Controllers
{
    public class JobsController : Controller
    {
        // GET: Jobs
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();

        public ActionResult Index()
        {
            var values = db.Tbl_Job.ToList();

            return View(values);
        }
        public ActionResult DeleteJob(int id)
        {
            var values = db.Tbl_Job.Find(id);
            db.Tbl_Job.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CreateJob()
        {
            return View();
        }
    }
}