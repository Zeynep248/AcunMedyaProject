﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject.Models;
namespace AcunMedyaProject.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();

        public ActionResult Index()
            
        {
            var values = db.Tbl_Message.ToList();
            return View(values);
        }
        public ActionResult DeleteMessage(int id)
        {
            var values = db.Tbl_Message.Find(id);
            db.Tbl_Message.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CreateMessage()
        {
            return View();
        }

    }
}
