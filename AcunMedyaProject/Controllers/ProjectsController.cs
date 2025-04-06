using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject.Models;
namespace AcunMedyaProject.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();

        public ActionResult Index()
        {
            var values = db.Tbl_Project.ToList();

            return View(values);
        }
       
        public ActionResult DeleteProject(int id)
        {
            var values = db.Tbl_Project.Find(id);
            db.Tbl_Project.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CreateProject()
        {
            return View();
        }
    }
}