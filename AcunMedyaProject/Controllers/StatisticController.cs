using AcunMedyaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaProject.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();
        public ActionResult Index()
        {
 
            return View();
        }
    }
}