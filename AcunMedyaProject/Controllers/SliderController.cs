using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject.Models;

namespace AcunMedyaProject.Controllers
{
    public class SliderController : Controller
    {
        // GET: Slider
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();

        public ActionResult Index()
        {
            var values = db.Tbl_Slider.ToList();

            return View(values);
        }
        public ActionResult DeleteSlider(int id)
        {
            var values = db.Tbl_Slider.Find(id);
            db.Tbl_Slider.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CreateSlider()
        {
            return View();
        }
    }
}