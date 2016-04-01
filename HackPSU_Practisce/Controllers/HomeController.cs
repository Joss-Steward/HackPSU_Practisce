using HackPSU_Practisce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HackPSU_Practisce.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();



        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string text)
        {
            db.Quotes.Add(new Quote() { Text = text });
            db.SaveChanges();
            return View();
        }

        public ActionResult GetQuote()
        {
            Random random = new Random();
            var val = random.Next(0, db.Quotes.Count());
            var query = db.Quotes.ToList().Skip(val).FirstOrDefault();
            return Json(query, JsonRequestBehavior.AllowGet);
        }
    }
}