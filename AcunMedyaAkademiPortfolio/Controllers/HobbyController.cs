using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;


namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class HobbyController : Controller
    {
        DbPortfolioEntities db = new DbPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblHobby.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateHobby()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateHobby(TblHobby p)
        {
            db.TblHobby.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteHobby(int id)
        {
            var value = db.TblHobby.Find(id);
            db.TblHobby.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateHobby(int id)
        {
            var value = db.TblHobby.Find(id);
            return View(value);
        }
    }
}